using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _81_ToDoList.Models
{
    public enum Status
    {
        [Display(Name = "Open")]
        Open,

        [Display(Name = "In Progress")]
        InProgress,

        [Display(Name = "Finished")]
        Finished
    }
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Status Status { get; set; }
    }
}
