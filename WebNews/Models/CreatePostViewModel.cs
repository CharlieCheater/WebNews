using System.ComponentModel.DataAnnotations;

namespace WebNews.Models
{
    public class CreatePostViewModel
    {
        [MinLength(5, ErrorMessage = "Минимальная длина заголовка составляет {1} символов.")]
        public string Title { get;set; }
        public string? Description { get;set; }
        public string? Author { get;set; }
    }
}
