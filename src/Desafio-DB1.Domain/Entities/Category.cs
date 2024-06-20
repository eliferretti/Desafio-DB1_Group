using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio_DB1.Domain.Entities
{
    [Table("Category")]
    public class Category : BaseEntity<Guid>
    {
        public Category()
        {
            Id = Guid.NewGuid();
        }

        public string Nome { get; set; }
        public string Description { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }
    }
}
