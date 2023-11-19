using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebUygulamaProje1.Models
{
    public class KitapTuru
    {
        [Key] //primary  key
        public int Id { get; set; }

        [Required(ErrorMessage ="Kitap Türü Adı Boş Bırakılamaz!")] //null olamaz anlamına geliyor
        [MaxLength(25)]
        [DisplayName("Kitap Türü Adı")]
        public string Ad { get; set; }
    }
}
