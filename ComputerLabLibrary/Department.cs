using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLabLibrary
{
    public class Department
    {
        public Department() { }
        [Key]
        public int Id { get; set; }

        public string deptname { get; set; }
    }
}
