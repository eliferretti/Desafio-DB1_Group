using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio_DB1.Domain.Entities
{
    [Table("CategorySubCategory")]
    public class CategorySubCategory : ProdutoCategory
    {
        public CategorySubCategory()
        {
            Id = Guid.NewGuid();
        }

        public Guid SubCategoryId { get; set; }
    }
}
