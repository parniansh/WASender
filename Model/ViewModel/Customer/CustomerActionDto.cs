using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModel
{
    public class CustomerActionDto
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string WAPhonenumber { get; set; }
        public CollaborationType collaborationType { get; set; }
        public string Description { get; set; }
        public int applicationUserId { get; set; }
    }
}
