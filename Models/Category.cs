using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Key]     // data annotation is when we want to configuration more details on the properties like Id to be primary key
                   //or something to not null we use [Key] and import the DataAnnotaion
        public int Id { get; set; }
        [Required]  //name cannot be null
        public string Name { get; set; }

        [Range(1,100, ErrorMessage ="Display Order must be between 1 and 100 only")]
        public int DisplayOrder { get; set; }   
        public DateTime CreatedDateTime { get; set; } = DateTime.Now; //to set a deafult date time we set it equal to DateTime.Now


    }
}
