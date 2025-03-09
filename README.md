# my-c-#
- C#을 공부하는  This is repository for C# study.

## C# 이란 무엇인가?
- C#은 멀티 패러다임 언어로, 주로 객체지향 프로그래밍(OOP) 언어로 설계되었지만, 시간이 지남에 따라 함수형 프로그래밍(FP)의 많은 기능들을 통합되었다.
- Java와는 문법적으로 유사한 부분이 많고, TypeScript의 타입 시스템과도 유사점이 있다고 한다.


### 객체지향 프로그래밍 언어로서의 C# 특징 
1. **클래스와 객체**: 기본적인 OOP 구성 요소
2. **캡슐화**: 접근 제어자(public, private, protected, internal)
3. **상속**: 단일 상속 지원
4. **다형성**: 오버라이딩, 오버로딩
5. **인터페이스**: 다중 인터페이스 구현 가능
6. **추상 클래스**: 부분적 구현을 가진 추상화
7. **프로퍼티**: 간결한 getter/setter 문법

8. **이벤트와 델리게이트**: 이벤트 기반 프로그래밍
9. **확장 메서드**: 기존 타입에 메서드 추가
10. **LINQ**: 컬렉션 쿼리를 위한 통합 문법



### 함수형 프로그래밍 언어로서의 C# 특징 
- C#은 기본적으로 객체지향 언어로 시작했지만, 버전이 업그레이드되면서 많은 함수형 프로그래밍 기능들이 추가되었다.

1. **람다 표현식(Lambda Expressions)**: 간결한 익명 함수 정의
2. **LINQ(Language Integrated Query)**: 선언적 데이터 쿼리
3. **고차 함수(Higher-order Functions)**: 함수를 인자로 받거나 반환하는 함수
4. **불변성(Immutability) 지원**: 읽기 전용 컬렉션, record 타입(C# 9.0+)
5. **패턴 매칭(Pattern Matching)**: 데이터 구조와 타입 매칭
6. **튜플(Tuples)**: 구조화된 다중 값 반환
7. **함수 합성(Function Composition)**: 확장 메서드를 통한 함수 체이닝
8. **지연 평가(Lazy Evaluation)**: IEnumerable, yield 키워드 등을 통한 구현
9. **부분 적용(Partial Application)**: 일부 매개변수가 적용된 함수 생성
10. **옵션 타입(Option Types)**: Nullable<T>와 C# 8.0의 nullable 참조 타입


## 다른 언어와 C#의 차이
- Java와는 문법적으로 유사한 부분이 많고, TypeScript의 타입 시스템과도 유사점이 있습니다.

## Java와 C#의 함수형 프로그래밍 차이점

1. **LINQ vs Stream API**: 
   ```csharp
   // C# LINQ
   var adults = people.Where(p => p.Age >= 18)
                     .OrderBy(p => p.Name)
                     .Select(p => new { p.Name, p.Age });
   ```
   ```java
   // Java Stream API
   List<Person> adults = people.stream()
                           .filter(p -> p.getAge() >= 18)
                           .sorted(Comparator.comparing(Person::getName))
                           .collect(Collectors.toList());
   ```

2. **확장 메서드**: C#은 기존 타입에 메서드를 추가할 수 있어 함수 합성에 유리
3. **표현력**: C#은 쿼리 구문(query syntax)을 제공하여 SQL과 유사한 형태로 쿼리 작성 가능
4. **불변 컬렉션**: C#은 ReadOnlyCollection<T>와 ImmutableCollection을 제공
5. **패턴 매칭**: C#의 패턴 매칭은 Java보다 더 풍부하고 표현력이 높음
6. **Records**: C# 9.0+은 불변 데이터를 위한 record 타입 제공 (Java 14+도 제공)
7. **값 타입 튜플**: C#은 값 타입 튜플을 지원하여 효율적인 다중 값 반환




#### 1. **프로퍼티**: C#은 간결한 프로퍼티 문법 제공
   ```csharp
   // C#
   public class Person {
       public string Name { get; set; }
   }
   ```
   ```java
   // Java
   public class Person {
       private String name;
       public String getName() { return name; }
       public void setName(String name) { this.name = name; }
   }
   ```

2. **이벤트 처리**: C#은 이벤트와 델리게이트 개념 내장
3. **제네릭스**: C#은 더 풍부한 제네릭 기능 제공 (공변성/반공변성 등)
4. **연산자 오버로딩**: C#은 연산자 오버로딩 지원, Java는 미지원
5. **확장 메서드**: 기존 클래스 변경 없이 기능 확장 가능
6. **프로퍼티 초기화자**: C#은 객체 초기화 문법 간결
7. **패키지 vs 네임스페이스**: 구조화 방식에 차이
8. **구조체(struct)**: C#은 값 타입 구조체 지원
9. **nullable 타입**: C#은 값 타입에 null 할당 지원
10. **using 문**: 리소스 관리 방식 차이
11. **async/await**: C#은 비동기 프로그래밍 지원이 더 강력



## JavaScript/TypeScript와 C#의 함수형 프로그래밍 차이점

1. **1급 함수(First-class Functions)**: JS/TS는 함수가 언어의 핵심 요소, C#은 델리게이트/람다로 유사 기능
2. **클로저(Closures)**: 두 언어 모두 지원하지만 JS/TS에서 더 광범위하게 사용됨
   ```javascript
   // JavaScript
   function counter() {
     let count = 0;
     return function() {
       return ++count;
     };
   }
   const increment = counter();
   ```
   ```csharp
   // C#
   Func<int> Counter() {
     int count = 0;
     return () => ++count;
   }
   var increment = Counter();
   ```

3. **커링(Currying)**: JS/TS에서는 자연스럽게 구현, C#에서는 더 복잡
   ```javascript
   // JavaScript
   const add = a => b => a + b;
   const add5 = add(5);
   console.log(add5(3)); // 8
   ```
   ```csharp
   // C#
   Func<int, Func<int, int>> Add = a => b => a + b;
   Func<int, int> Add5 = Add(5);
   Console.WriteLine(Add5(3)); // 8
   ```

4. **스프레드 연산자와 구조 분해**: TS의 스프레드 연산자가 더 간결하고 유연함
5. **동적 타이핑**: JS/TS는 동적 타이핑으로 더 유연한 함수형 패턴 구현 가능
6. **프로토타입 기반 vs 클래스 기반**: 객체 모델의 근본적 차이
7. **비동기 처리**: JS/TS는 Promise와 async/await, C#은 Task와 async/await로 구현
8. **이터레이터/제너레이터**: JS/TS의 제너레이터 함수 vs C#의 yield return
9. **함수형 라이브러리**: JS/TS는 Lodash, Ramda 등 풍부한 함수형 라이브러리 생태계



1. **정적 타입 시스템**: C#은 컴파일 시 완전한 타입 검사, TS는 선택적 타입 시스템
2. **런타임 환경**: C#은 CLR 기반, TS는 JS로 컴파일되어 브라우저/Node.js에서 실행
3. **구조적 타이핑 vs 명목적 타이핑**: TS는 구조적 타이핑, C#은 명목적 타이핑 사용
   ```typescript
   // TypeScript (구조적 타이핑)
   interface Point { x: number; y: number; }
   
   function printPoint(p: Point) {
       console.log(`${p.x}, ${p.y}`);
   }
   
   // 명시적으로 구현할 필요 없음
   const myPoint = { x: 10, y: 20 };
   printPoint(myPoint); // 유효함
   ```
   ```csharp
   // C# (명목적 타이핑)
   interface IPoint { int X { get; set; } int Y { get; set; } }
   
   void PrintPoint(IPoint p) {
       Console.WriteLine($"{p.X}, {p.Y}");
   }
   
   // 반드시 인터페이스를 명시적으로 구현해야 함
   class MyPoint : IPoint {
       public int X { get; set; }
       public int Y { get; set; }
   }
   ```

4. **유니온 타입**: TS는 유니온 타입 지원, C#은 제한적 (C# 9.0부터 record 유형 지원)
5. **인터페이스 확장**: TS는 인터페이스 합성이 더 유연함
6. **메타 프로그래밍**: TS는 타입 조작 기능이 풍부함
7. **속성 접근**: TS는 동적 속성 접근, C#은 리플렉션으로 유사 기능 제공
8. **타입 추론**: 두 언어 모두 지원하지만 메커니즘에 차이가 있음



## 코드 비교 예시

**함수 합성 패턴:**

```csharp
// C#
public static class FunctionalExtensions {
    public static Func<T1, T3> Compose<T1, T2, T3>(this Func<T2, T3> f, Func<T1, T2> g) {
        return x => f(g(x));
    }
}

var addOne = (int x) => x + 1;
var multiplyByTwo = (int x) => x * 2;
var addOneThenMultiply = multiplyByTwo.Compose(addOne);
```

```typescript
// TypeScript
const compose = <A, B, C>(f: (b: B) => C, g: (a: A) => B) => (x: A): C => f(g(x));

const addOne = (x: number) => x + 1;
const multiplyByTwo = (x: number) => x * 2;
const addOneThenMultiply = compose(multiplyByTwo, addOne);
```

C#은 객체지향과 함수형 패러다임을 균형 있게 섞은 실용적인 접근법을 취하고 있으며, 버전이 올라갈수록 함수형 프로그래밍 기능이 강화되고 있습니다.










































### Java와 C#의 주요 차이점


### TypeScript와 C#의 주요 차이점


### C#의 객체지향적 특성

클래스와 객체
캡슐화, 상속, 다형성
인터페이스
추상 클래스
접근 제어자 (public, private, protected 등)

### C#의 함수형 특성
람다 표현식 (x => x * 2)
LINQ (Language Integrated Query)
고차 함수 (Select, Where, Reduce 등)
불변성을 지원하는 기능 (readonly, immutable collections)
패턴 매칭 (C# 7.0 이후)
튜플 및 분해 (deconstruction)
확장 메서드
함수를 일급 객체로 취급 (Func, Action 델리게이트)

C#은 기본적으로 객체지향적 설계를 중심으로 하면서도, 함수형 프로그래밍의 강점을 활용할 수 있도록 진화해왔습니다. 특히 C# 3.0에서 LINQ가 도입된 이후로 함수형 프로그래밍 스타일이 크게 강화되었습니다.
그래서 C#으로 순수한 객체지향 방식으로 프로그래밍할 수도 있고, 함수형 프로그래밍 패턴을 많이 활용할 수도 있으며, 두 패러다임을 혼합하여 사용하는 것도 가능합니다. 이런 유연성이 C#의 강점 중 하나입니다.





















