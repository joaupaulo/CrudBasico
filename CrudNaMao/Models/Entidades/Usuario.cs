using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNaMao.Models
{

    [Table("Usuario")]


    public class Usuario
    {

        [Display(Description="Código")]
        public int Id { get; set; }
        [Display(Description = "Nome Do Usuário")]
        public string NomeUsuario { get; set; }
        [Display(Description = "Idade Do Usuário")]
        public int Idade { get; set; }
        [Display(Description = "Tipo Do Usuário")]
        public int TipoDoUsuario { get; set; }
    }
}
