using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Web.Modelos
{
    public class GruposViewModel
    {
        [Required]
        public Guid ID { get; set; }
        public string Nombre_Grupo { get; set; }
        public string CreadorID { get; set; }
    }
}
