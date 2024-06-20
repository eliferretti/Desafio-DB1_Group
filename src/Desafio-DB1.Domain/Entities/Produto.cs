using Desafio_DB1.Domain.Validations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio_DB1.Domain.Entities
{
    [Table("Produto")]
    public class Produto : BaseEntity<Guid>
    {
        public Produto()
        {
            Id = Guid.NewGuid();
        }

        [Required(ErrorMessage = "O nome do produto não pode ser nulo.")]
        public dynamic Name { get; set; }

        public dynamic Size { get; set; }
        
        public string Description { get; set; }

        public int Amount { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "O valor do produto não pode ser menor do que R$0,01.")]
        public decimal Value { get; set; }
        
        public List<ProdutoCategory> CategorySubCategory { get; set; }
       
        [MaxItems(10, ErrorMessage = "A lista de imagens não pode conter mais de 10 itens.")]
        public List<Asset> Imagens { get; set; }
        
        [MaxItems(5, ErrorMessage = "A lista de vídeos não pode conter mais de 5 itens.")]
        public List<Asset> Videos { get; set; }
    }
}
