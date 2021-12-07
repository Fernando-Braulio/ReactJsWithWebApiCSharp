using System.ComponentModel.DataAnnotations.Schema;

namespace ReactJsWithWebApiCSharp.Models
{
    [Table("Produto")]
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
