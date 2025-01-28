using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_To_do
{
    public class Todo
    {
        public static int ObjectCounter = 0;
        public int Id { get; set; }

        public string TaskDescription { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsDone { get; set; }

        public Todo(string Description, DateTime date, bool donestate = false)
        {
            ObjectCounter++;
            Id = ObjectCounter;
            TaskDescription = Description;
            DueDate = date; 
            IsDone = donestate;
        }

        public override string? ToString()
        {
            return $"{Id} - {DueDate} - {TaskDescription} ";
        }
    }
    // TODO: Make sure that the task list is sorted by date time,

    // TODO: clears the whole data of the list 
    // TODO: 
}
