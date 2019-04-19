using System.ComponentModel.DataAnnotations;

namespace BooksAPI.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        [Required]//数据验证  System.ComponentModel.DataAnnotations;
        public string Name { get; set; }
    }
}