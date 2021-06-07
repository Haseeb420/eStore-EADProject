using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EStore.Shared
{
    public class User
    {
        public int U_Id { get; set; }

        public int Rank { get; set; }

        [Required(ErrorMessage = "This field is required......!")]
        [DataType(DataType.Text,ErrorMessage ="Only string allowed...!")]
        [MaxLength(50,ErrorMessage ="Name cann't be more then 50 charaters....!")]
        public string  Name { get; set; }


        [Required(ErrorMessage = "This field is required......!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Enter Valid email address...!")]
        [MaxLength(50, ErrorMessage = "email cann't be more then 30 charaters....!")]
        public string  Email { get; set; }


        [Required(ErrorMessage = "This field is required......!")]
        [DataType(DataType.Date, ErrorMessage = "Enter Valid DOB......!")]

        public DataType DOB { get; set; }

        [Required(ErrorMessage = "This field is required......!")]
        [DataType(DataType.Password, ErrorMessage = "Enter Valid email address...!")]
        [MaxLength(16, ErrorMessage = "password cann't be more then 16 charaters....!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "This field is required......!")]
        [DataType(DataType.Password, ErrorMessage = "Enter Valid email address...!")]
        [MaxLength(16, ErrorMessage = "password cann't be more then 16 charaters....!")]
        [Compare("Password",ErrorMessage ="Password should be matched.....!")]
        public string ConfirmPassword { get; set; }


    }
}
