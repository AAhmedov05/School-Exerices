using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoWeb.Models
{
    public class Task
    {
        public enum Statuses
        {
            Open,
            InProgress,
            Finished
        }
        public int ID { get; set; }
        public string Title { get; set; }
        public Statuses Status { get; set; }
    }
}
