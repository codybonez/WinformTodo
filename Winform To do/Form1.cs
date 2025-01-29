namespace Winform_To_do
{
    public partial class Form1 : Form
    {
        private List<Todo> TaskList { get; set; }
           
        public Form1()
        {
            InitializeComponent();
            TaskList = new List<Todo>();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void BtnAdd_Todo(object sender, EventArgs e)
        {


        }




        private void lvTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        


        private void ClearTask()
        {
            txtDueDate.Clear();
            txtTaskDescription.Clear();
        }

        private void SubmitForm(object sender, EventArgs e)
        {
            // check if the todo is valid
            // if it is not, display an error
            // exit
            if (Validators.IsEmptyText(txtTaskDescription))// description must exist
                      // due date must be formatted as a valid date
            {
                MessageBox.Show("Description is empty, please provide a description.");




                return;
            }
            if (!Validators.IsValidDate(txtDueDate)) {
                MessageBox.Show("Missing a due date.");
                return;
            }

            if (Validators.IsTextNull(txtTaskDescription)){
                MessageBox.Show("Description needs to be created.");
                return;
            }

             
            
                
           
           

            





            // Where we handle the add event (Event handler)

            Todo myToDo = new Todo(txtTaskDescription.Text, DateTime.Parse(txtDueDate.Text));



            // adds the list to the listview
            
            TaskList.Add(myToDo);


            UpdateListBox();

            MessageBox.Show(myToDo.ToString());
            ClearTask();

        }

        public void UpdateListBox()
        {
            // clear the contents
            lbTaskList.Items.Clear();

            //transform the list 
            var list = TaskList
                .Where(t => t.IsDone == false)
                .OrderBy(t => t.DueDate)
                .ToList();


            
            // read in the new contents







            for (int i = 0; i < list.Count; i++)
            {
                lbTaskList.Items.Add(list[i].ToString());
            }
            // clean up if required





        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clears the form 
            MessageBox.Show("Form Cleared");
            ClearTask();


        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
          if (e.KeyChar == 13)
            {
                SubmitForm(sender, e);
            }
        }
    }
}
