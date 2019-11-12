using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Web.Modelos
{
    public class CrearGrupoViewModel
    {
        [Required]
        public Guid ID { get; set; }
        [Required]
        public string Nombre_Grupo { get; set; }
        [Required]
        public string CreadorID { get; set; }
    }
}
