using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio_DB1.Domain.Entities
{
    [Table("ProdutoCategory")]
    public class ProdutoCategory : BaseEntity<Guid>
    {
        public ProdutoCategory()
        {
            Id = Guid.NewGuid();
        }

        public Guid ProdutoId { get; set; }
        public Guid CategoryId { get; set; }
    }
}
