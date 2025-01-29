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


        public string GetStatus() {
            string Status = "";

            if (IsDone)
            {

                Status = "Status: Complete";
            }
            else {
                Status = "Status: InComplete";
            }


            return Status;        
        }
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
            return $"{Id} - {DueDate} - {TaskDescription} - {GetStatus()}";
        }
    }
    // TODO: Make sure that the task list is sorted by date time,

    // TODO: clears the whole data of the list 
    // TODO: 
}
