﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventarioV6.Modelos
{
    public class Bodega
    {
        [Key]
        public int BodegaId { get; set; }
        [Required(ErrorMessage ="Nombre es Requerido")]
        [MaxLength(60, ErrorMessage ="Nombre debe ser máximo 60 caracteres")]
        public int Nombre { get; set; }
        [Required(ErrorMessage = "Descripción es Requerido")]
        [MaxLength(60, ErrorMessage = "Descripción debe ser máximo 100 caracteres")]
        public int Descripcion { get; set; }
        [Required(ErrorMessage ="Estado es Requerido")]
        public bool Estado { get; set; }
    }
}
