using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoFinal.Models
{
    public partial class Todo
    {
      
        public int TodoID { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }

    }
}
