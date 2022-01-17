using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Easy_Dentes_Final.Models
{
    public class Consultas
    {
        [Key]
        public int ConsultaId { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }


        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; } = DateTime.Now;

        [Required]
        [StringLength(200)]
        public string Horario { get; set; }

        [Required]
        [StringLength(200)]
        public string Especialidade { get; set; }

        [Required]
        [StringLength(200)]
        public string Convenio { get; set; }
    }
}
