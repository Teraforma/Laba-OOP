using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Degustatotor_Laba_OOP
{
    public partial class MainMenu : Form
    {
        Controller controller;

        public MainMenu()
        {
            InitializeComponent();
            controller = new Controller(dataGridView1);
            

        }

        public void OpenInput()
        {
            var m = new Input(controller);
            
            m.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.controller.DeleteSelected();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenInput();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.SaveData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.Who();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
             
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
           
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {
            
            //
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                controller.RowSelectedAction();
            }
        }

        private void Load_button_Click(object sender, EventArgs e)
        {
            controller.LoadData();
            OpenInput();
        }
    }
}
