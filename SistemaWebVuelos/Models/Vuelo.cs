using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaWebVuelos.Models
{
    [Table("Vuelo")]
    public class Vuelo
    {
        [Required(ErrorMessage = "Ingrese un Id de Vuelo")]
        [DisplayName("Id Vuelo")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese una Fecha (dd/mm/aaaa)")]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}", ApplyFormatInEditMode =true)]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage ="Ingrese un Destino")]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string Destino { get; set; }
        [Required(ErrorMessage = "Ingrese un Origen")]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Origen { get; set; }
        [Range(100,1000, ErrorMessage = "Ingrese un valor entre 100 y 1000")]
        [DisplayName("Matricula Avión")]
        public int Matricula { get; set; }
    }
}