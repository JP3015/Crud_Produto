using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud___Produto.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name = "Código")]
        [Key]
        public int id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Column("Desc")]
        [Display(Name = "Descrição")]
        public string desc { get; set; }

        [Column("Preco")]
        [Display(Name = "Preço")]
        public double preco { get; set; }

        [Column("Peso")]
        [Display(Name = "Peso")]
        public double peso { get; set; }

    }
}
