using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nunes_Sports.Models
{
   public class Produto
 {
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo Nome é obrigatório.")]
    public string? Nome { get; set; }

     [Required(ErrorMessage = "O campo Codigo é obrigatório.")]
    public string? Codigo { get; set; }
     
    public string? Descricao { get; set; }
     
    [Required(ErrorMessage = "O campo Preço é obrigatório.")]
     public decimal Preco { get; set; }
    
    }

}