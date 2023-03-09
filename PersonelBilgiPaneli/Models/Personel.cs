using System.Diagnostics.Contracts;

namespace PersonelBilgiPaneli.Models
{
    public class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }    
        public string Soyad { get; set; }
        public string TCKimlikNo  { get; set; }
        public string Departman { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public string TelefonNo { get; set; }
    }
}
