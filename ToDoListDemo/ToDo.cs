using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListDemo
{
    public enum TaskStatus { ToDo,InProgress,Complete};
    public class ToDo
    {
        public int Id { get; set; }
        public static int GlobalId { get; set; } = 0;
        public string TaskName { get; set; }
        public TaskStatus Status { get; set; } = TaskStatus.ToDo;


        public ToDo()
        {
            Id = ++GlobalId;
        }
    }
}
