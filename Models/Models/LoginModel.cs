using Models.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{

    public class LoginModel
    {
      
        [Required(ErrorMessage = "Mời nhập username")]
        public string UserName { set; get; }
        [Required(ErrorMessage = "Mời nhập password")]
        public string PassWord { set; get; }
        public bool Remember { set; get; }

        
    }

    
}
