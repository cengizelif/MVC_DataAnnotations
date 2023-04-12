using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MVC_DataAnnotations.Models
{
    public class Kullanici
    {
        [DisplayName("Adınız")]
        public string Ad { get; set; }

        [DisplayName("Soyadınız")]
        public string Soyad { get; set; }

        [DisplayName("Yaş"),Required(ErrorMessage ="Lütfen yaş değeri giriniz"),Range(18,65,ErrorMessage ="Yaş değeri 18 ile 65 arasında olmalıdır")]
        public int Yas { get; set; }

        [DisplayName("Kullanıcı Adı"), Required(ErrorMessage ="Lütfen {0} giriniz"),MinLength(5,ErrorMessage ="{0} en az {1} karakter olmalıdır"),MaxLength(15,ErrorMessage = "{0} en çok {1} karakter olmalıdır")]
        public string KullaniciAdi { get; set; }

        [DisplayName("Şifre"), Required(ErrorMessage ="Lütfen {0} giriniz"),DataType(DataType.Password)]
        public string Sifre { get; set; }

        [DisplayName("Şifre(Tekrar)"), Required(ErrorMessage ="Lütfen {0}giriniz"),Compare(nameof(Sifre),ErrorMessage ="{0} ile {1} eşleşmiyor")]
        public string Sifre2 { get; set; }

        [DisplayName("Email"), Required(ErrorMessage ="Lütfen {0} giriniz")]
        public string Eposta { get; set; }

        [DisplayName("Email(Tekrar)"), 
         Required(ErrorMessage ="Lütfen {0} giriniz"), 
         Compare(nameof(Eposta), ErrorMessage = "{0} ile {1} eşleşmiyor")]
        public string Eposta2 { get; set; }


    }
}