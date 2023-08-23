using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [Display(Name = "Ad")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [Display(Name = "Soyad")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [Display(Name = "E-Posta")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır.")]
        [EmailAddress(ErrorMessage ="E-Mail formatı şeklinde giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [Display(Name = "Kullanıcı adı")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [Display(Name = "Şifre")]
        [StringLength(10, ErrorMessage = "Max 10 karakter olmalıdır.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [StringLength(10, ErrorMessage = "Max 10 karakter olmalıdır.")]
        public string Role { get; set; }

    
    }
}
