namespace Winform_To_do
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnClear = new Button();
            BtnAdd = new Button();
            lblDueDate = new Label();
            txtDueDate = new TextBox();
            lblTaskBoxLabel = new Label();
            txtTaskDescription = new TextBox();
            gbTaskList = new GroupBox();
            lbTaskList = new ListBox();
            groupBox1.SuspendLayout();
            gbTaskList.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(BtnAdd);
            groupBox1.Controls.Add(lblDueDate);
            groupBox1.Controls.Add(txtDueDate);
            groupBox1.Controls.Add(lblTaskBoxLabel);
            groupBox1.Controls.Add(txtTaskDescription);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(469, 112);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task Form";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(278, 77);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 23);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear Form";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            btnClear.KeyPress += Form1_KeyPress;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(388, 77);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(75, 23);
            BtnAdd.TabIndex = 5;
            BtnAdd.Text = "Add To Do";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += SubmitForm;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(2, 51);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(52, 15);
            lblDueDate.TabIndex = 4;
            lblDueDate.Text = "DueDate";
            // 
            // txtDueDate
            // 
            txtDueDate.Location = new Point(60, 48);
            txtDueDate.Name = "txtDueDate";
            txtDueDate.PlaceholderText = "2025-01-20";
            txtDueDate.Size = new Size(409, 23);
            txtDueDate.TabIndex = 2;
            txtDueDate.KeyPress += Form1_KeyPress;
            // 
            // lblTaskBoxLabel
            // 
            lblTaskBoxLabel.AutoSize = true;
            lblTaskBoxLabel.Location = new Point(23, 19);
            lblTaskBoxLabel.Name = "lblTaskBoxLabel";
            lblTaskBoxLabel.Size = new Size(29, 15);
            lblTaskBoxLabel.TabIndex = 1;
            lblTaskBoxLabel.Text = "Task";
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Location = new Point(60, 11);
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(409, 23);
            txtTaskDescription.TabIndex = 0;
            txtTaskDescription.KeyPress += Form1_KeyPress;
            // 
            // gbTaskList
            // 
            gbTaskList.Controls.Add(lbTaskList);
            gbTaskList.Location = new Point(12, 130);
            gbTaskList.Name = "gbTaskList";
            gbTaskList.Size = new Size(469, 694);
            gbTaskList.TabIndex = 1;
            gbTaskList.TabStop = false;
            gbTaskList.Text = "Task List";
            // 
            // lbTaskList
            // 
            lbTaskList.FormattingEnabled = true;
            lbTaskList.Location = new Point(6, 22);
            lbTaskList.Name = "lbTaskList";
            lbTaskList.Size = new Size(457, 664);
            lbTaskList.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 836);
            Controls.Add(gbTaskList);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "To do app";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbTaskList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTaskDescription;
        private Label lblDueDate;
        private TextBox txtDueDate;
        private Label lblTaskBoxLabel;
        private Button btnClear;
        private Button BtnAdd;
        private GroupBox gbTaskList;
        private ListBox lbTaskList;
    }
}
