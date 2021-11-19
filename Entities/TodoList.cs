using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TodoList : IEntity
    {
        public int Id { get; set; }
        public string ToDoName { get; set; }
        public string ToDoDescription { get; set; }
        public Boolean ToDoIsItDone { get; set; }
    }
}
