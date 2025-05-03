using System.ComponentModel.DataAnnotations;

namespace CrudAplicExam.Models
{
    public class Product
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Моля, въведете име на продукта")]
        public string Name { get; set; }

        [Range(0.01, 10000, ErrorMessage = "Цената трябва да е между 0.01 и 10 000")]
        public decimal Price { get; set; }
    }
}
