using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace DotNetCoreMVC.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "사용자 이름을 입력하세요.")]
        [Display(Name = "사용자 이름")]
        public string Username { get; set; }

        [Required(ErrorMessage = "이메일을 입력하세요.")]
        [EmailAddress(ErrorMessage = "유효한 이메일 주소를 입력하세요.")]
        [Display(Name = "이메일")]
        public string Email { get; set; }

        [Required(ErrorMessage = "비밀번호를 입력하세요.")]
        [DataType(DataType.Password)]
        [Display(Name = "비밀번호")]
        [StringLength(100, ErrorMessage = "{0}는 최소 {2} 글자 이상이어야 합니다.", MinimumLength = 6)]
        public string Password { get; set; }
    }
}
