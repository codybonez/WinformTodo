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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
           
            // Where we handle the add event (Event handler)
            Todo myToDo = new Todo (txtTaskDescription.Text, DateTime.Parse(txtDueDate.Text));

            MessageBox.Show(myToDo.ToString());

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
