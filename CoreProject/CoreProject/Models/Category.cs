using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Models
{
    public class Category
    {

        public int CategoryID { get; set; }
        [Required(ErrorMessage ="Category Name is not Empty!")]
        [StringLength(20,ErrorMessage ="Max 20 characters :(")]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }


        public List<Food> Foods { get; set; }



        public bool Status { get; set; }

    }
}
