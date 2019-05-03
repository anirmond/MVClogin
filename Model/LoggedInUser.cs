using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LoggedInUser
    {
        public string FirstNAme { get; set; }
        public string LastName { get; set; }
        public bool? IsMatched { get; set; }
        public string UserName { get; set; }
    }
}
