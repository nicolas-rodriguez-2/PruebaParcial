﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CancionAPI.Models
{
    public class Cancion
    {

        [Key]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Ingrese nombre de la cancion")]
        [Display(Name = "Nombre de la Cancion")]
        public string NombreCancion { get; set; }



        [Required] //primero las condiciones
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Ingrese autor/compositor de la cancion")]
        [Display(Name = "Autor/Compositor")]
        public string Autor { get; set; } //luego se muestra que chota



        [Required]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Ingrese Letra de la cancion")]
        [Display(Name = "Letra")]
        public string Letra { get; set; }



        [Url] //solo cuando es un link xd, caso contrario required
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Ingrese Enlace de la cancion")]
        [Display(Name = "Enlace")]
        public string Enlace { get; set; }
    }
}
