using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    internal class TaskItem
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }

        public TaskItem(string title)
        {
            Title = title;
            IsCompleted = false;
        }
    }
}
