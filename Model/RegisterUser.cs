using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class RegisterUser
    {
        [Required(ErrorMessage ="please fill")]
        public string FirstNAme { get; set; }
        [Required(ErrorMessage = "please fill")]
        public string LastName { get; set; }        
        [Required(ErrorMessage = "please fill")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "please fill")]
        [StringLength(10,ErrorMessage ="Password Length Should Be Min 5 to Max 10",MinimumLength =5)]
        public string Password { get; set; }
        [Required(ErrorMessage = "please fill")]
        [Compare("Password",ErrorMessage ="Please Confirm Your Entered Passowrd ")]
        public string ConfirmPassword { get; set; }
    }
}
