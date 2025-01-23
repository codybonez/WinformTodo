namespace Winform_To_do
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void BtnAdd_Todo (object sender, EventArgs e){

            
        }

      


        private void lvTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        List<Todo> list = new List<Todo>();
        void recalltaskview() {
            lvTasks.Items.Clear();

           // ameon helped me on this part
            for (int i = 0; i < list.Count; i++) {
                ListViewItem item = new ListViewItem();
                lvTasks.Items.Add(item);
                item.Text = list[i].ToString();
                // this part I figured it out 
                list.AddRange();


            }



        }
        
       


        private void BtnAdd_Click(object sender, EventArgs e)
        {
          
            // Where we handle the add event (Event handler)
            Todo myToDo = new Todo(txtTaskDescription.Text, DateTime.Parse(txtDueDate.Text));
         


            MessageBox.Show(myToDo.ToString());
            list.Add(myToDo);
            recalltaskview();
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tasks Cleared");
            recalltaskview();
            list.Clear();


        }


      
    }
}
