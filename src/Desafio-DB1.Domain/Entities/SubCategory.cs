using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio_DB1.Domain.Entities
{
    [Table("SubCategory")]
    public class SubCategory : Category
    {
        public SubCategory()
        {
            Id = Guid.NewGuid();
        }

        public Guid IdCategory { get; set; }
        public Category Category { get; set; }
    }
}
