using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ITI_GraduationProject.Models
{
    public class Employee
    {

        [Display(Name = "SSN")]
        [Required(ErrorMessage = "Req field")]  
        public int Id { get; set; }
        
        
        
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Required field")]    
        public string FName { get; set; }
        
        
        
        [Display(Name = "Last Name")]
        public string? LName { get; set; }
               
           
        
        
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required]    
        public string Pwd { get; set; }
        
        
        
        
        [Display(Name = "Conf. Password")]
        [DataType(DataType.Password)]
        [NotMapped]
        [Compare("Pwd")]
        public string CPwd { get; set; }

        
        
        
        [DataType(DataType.EmailAddress)]
        [Required]
        [EmailAddress(ErrorMessage = "Not valid Email")]
        public string Email { get; set; }


        [DataType(DataType.MultilineText)]
        public string? Address { get; set; }
        
        
        
        
        [Range(18, 60)]
        public int? Age { get; set; }
        
        
        
        
        [Display(Name = "Url")]
        [DataType(DataType.Url)]
        [Url]  //http://www.kjhgf.com
        public string? Url { get; set; }
        
        
        
        
        
        
        [Compare("Fname")]
        [NotMapped]
        [Required]
        public string? LoginName { get; set; }

        
        
        
        
        [Required]
        [Compare("Pwd")]
        [NotMapped]
        public string? LoginPassward { get; set; }




        [ForeignKey("Department")]
        public int DeptId { get; set; }

        //Navigation proparty
        public virtual Department Department { get; set; }

    }
}
