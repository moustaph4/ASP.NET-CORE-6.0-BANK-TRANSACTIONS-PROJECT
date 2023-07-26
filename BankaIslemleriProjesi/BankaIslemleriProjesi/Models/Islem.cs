using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BankaIslemleriProjesi.Models
{
    public class Islem
    {
        [Key]
        public int IslemId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [MaxLength(12,ErrorMessage = "Hesap Numarası maksimum 12 karakter olabilir.")]
        public string HesapNumarasi { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public string MusteriAdi { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public string BankaAdi { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [MaxLength(11, ErrorMessage = "SWIFTCode maksimum 11 karakter olabilir.")]
        public string SWIFTCode { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public int Tutar { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}")]
        public DateTime Tarih { get; set; }
    }
}
