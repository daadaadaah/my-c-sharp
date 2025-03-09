using System;

namespace BoardAPI.Models 
{
    public class Board
    {
        public int Id { get; set; }
        
        // required 속성 추가 또는 기본값 설정
        public string Title { get; set; } = string.Empty;
        
        public string Content { get; set; } = string.Empty;
        
        public string Author { get; set; } = string.Empty;
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        public DateTime? UpdatedAt { get; set; }
    }
}