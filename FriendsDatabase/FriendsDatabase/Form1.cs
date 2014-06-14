using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FriendsDatabase
{
    public partial class Form1 : Form
    {
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void friends_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.friends_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.friends_DatabaseDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'friends_DatabaseDataSet1.Friends_Table' table. You can move, or remove it, as needed.
            this.friends_TableTableAdapter.Fill(this.friends_DatabaseDataSet1.Friends_Table);
            timer1.Start();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.friends_TableBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.friends_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.friends_DatabaseDataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.friends_TableBindingSource.RemoveCurrent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count = friends_TableBindingSource.Count;
            numberOfRowsLabel.Text = "Number of rows in the database: " + count.ToString();

            if (count < 2)
            {
                nextButton.Visible = false;
                previousButton.Visible = false;
            }
            else
            {
                nextButton.Visible = true;
                previousButton.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            friends_TableBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            friends_TableBindingSource.MovePrevious();
        }

        private void searchNameQueryToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.friends_TableTableAdapter.SearchNameQuery(this.friends_DatabaseDataSet1.Friends_Table, firstNameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
