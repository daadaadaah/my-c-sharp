# 간단한 게시판 CRUD
## 개발 환경 셋팅

- .NET
- ORM : EF Core(LTS) 
- DB : MSSQL


### Mac에서 Docker로 MSSQL 셋팅
- 참고 : https://hsbyduts.tistory.com/115

1. 터미널에서 mssql 이미지 다운로드
```bash
$ docker pull mcr.microsoft.com/azure-sql-edge:latest

latest: Pulling from azure-sql-edge
f0412dfb1aae: Pull complete 
c62c3fc0300d: Pull complete 
57f13386bc1b: Pull complete 
dcc7b800eec9: Pull complete 
Digest: sha256:902628a8be89e35dfb7895ca31d602974c7bafde4d583a0d0873844feb1c42cf
Status: Downloaded newer image for mcr.microsoft.com/azure-sql-edge:latest
mcr.microsoft.com/azure-sql-edge:latest
```

2. 컨테이너 생성

```bash
# <your password> 부분엔 설정할 비밀번호를, <mssql-server> 부분엔 설정할 DB 이름을 입력하여 생성한다.

# $ docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=<your password>' -p 1433:1433 --name <docker-container-name> -d mcr.microsoft.com/mssql/server:2019-latest

$ docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=test1234!' -p 1433:1433 --name cshaptest2 -d mcr.microsoft.com/mssql/server:2019-latest

Unable to find image 'mcr.microsoft.com/mssql/server:2019-latest' locally
2019-latest: Pulling from mssql/server
b43df23e6f02: Pull complete 
75364e5e02c7: Pull complete 
86f1aa391d69: Pull complete 
Digest: sha256:7a879e9af3557e81a3b3ad14acd071e3638788387f394d27a9d3404b28e954ce
Status: Downloaded newer image for mcr.microsoft.com/mssql/server:2019-latest
83f64367987aab371c27de6b2b5080ceb20b59178d16635c28911ab6b4c0af6f
```

3. 확인

```bash
$ docker ps -a

CONTAINER ID   IMAGE                                        COMMAND                  CREATED              STATUS                       PORTS                                                    NAMES
a9ed4689e056   mcr.microsoft.com/mssql/server:2019-latest   "/opt/mssql/bin/perm…"   20 minutes ago   Up 20 minutes                 0.0.0.0:1433->1433/tcp                                   cshaptest2
```
4. 컨테이너 진입

```bash
$ docker exec -it cshaptest2 "bash"
mssql@a9ed4689e056:/$ 
```

5. 현재 컨테이너에 sqlcmd 도구 설치하기
```bash
# root 권한이 필요하므로 아래 명령어로 컨테이너 진입
$ docker exec -it --user root cshaptest2 bash

# 필요한 패키지 설치
root@a9ed4689e056:/# apt-get update
root@a9ed4689e056:/# apt-get install -y wget apt-transport-https

# Microsoft 패키지 리포지토리 추가
root@a9ed4689e056:/# wget -qO- https://packages.microsoft.com/keys/microsoft.asc | apt-key add -
root@a9ed4689e056:/# wget -qO- https://packages.microsoft.com/config/ubuntu/20.04/prod.list > /etc/apt/sources.list.d/mssql-release.list

# 패키지 목록 업데이트 및 mssql-tools 설치
root@a9ed4689e056:/# apt-get update
root@a9ed4689e056:/# ACCEPT_EULA=Y apt-get install -y mssql-tools unixodbc-dev

# 설치 확인
root@a9ed4689e056:/# /opt/mssql-tools/bin/sqlcmd -?
Microsoft (R) SQL Server Command Line Tool
Version 17.10.0001.1 Linux
Copyright (C) 2017 Microsoft Corporation. All rights reserved.
```

6. MSSQL 실행하여 진입하기
```bash
root@a9ed4689e056:/# /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P 'test1234!'
1> 
```


## .Net 프로젝트와 MSSQL과 연동하기

```bash 
$ dotnet add package Microsoft.EntityFrameworkCore
$ dotnet add package Microsoft.EntityFrameworkCore.Design
$ dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

## appsettings.json에 MSSQL 연결 문자열 설정
```json
{
  // ...
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=crudtest;User=sa;Password=test1234;TrustServerCertificate=True;"
  }
}
```

## EF Core 마이그레이션 생성 및 적용

```bash
# 마이그레이션 도구 설치 (아직 설치하지 않았다면)
$ dotnet tool install --global dotnet-ef

# EF Core 디자인 도구 설치
$ dotnet add package Microsoft.EntityFrameworkCore.Design

# 마이그레이션 생성
$ dotnet ef migrations add InitialCreate

# 데이터베이스에 마이그레이션 적용
$ dotnet ef database update
```

## MSSQL 사용하기
### DB 만들기
```bash
# DB(이름 : crudtest) 생성
1> CREATE DATABASE crudtest;
2> GO

# 생성 확인
1> SELECT name FROM sys.databases;
2> GO
name                           
-----------
master
tempdb
model 
msdb     
crudtest #  생성됨

# 생성된 DB 사용
1> USE crudtest;
2> GO
Changed database context to 'crudtest'.
1>

```

### 테이블 만들기

### 데이터 CRUD

## Swagger 패키지 설치
```bash
$ dotnet add package Swashbuckle.AspNetCore

# .cs 파일 중 swagger 관련 설정 있는 곳에 추가해주기
using Microsoft.OpenApi.Models;
```

## Reference
- 참고 : https://learn.microsoft.com/ko-kr/aspnet/core/tutorials/first-web-api?view=aspnetcore-9.0&tabs=visual-studio-code







