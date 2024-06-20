using Desafio_DB1.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio_DB1.Domain.Entities
{
    [Table("Asset")]
    public class Asset : BaseEntity<Guid>
    {
        public Asset()
        {
            Id = Guid.NewGuid();
        }

        public AssetType Type { get; set; }
        public string Url { get; set; }
        public Guid ProdutoId { get; set; }
        public Produto Produto { get; set; }
    }
}
