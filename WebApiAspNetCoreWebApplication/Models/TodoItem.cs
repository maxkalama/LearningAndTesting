using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAspNetCoreWebApplication.Models
{
    public class TodoItem
    {
        public string Key { get; set; }
        public String Name { get; set; }
        public bool IsComplete { get; set; }     
    }
}
