using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Degustatotor_Laba_OOP.classes;

namespace Degustatotor_Laba_OOP.Managers
{

    internal interface IDataGridManager
    {
        public void Dispaly(List<Product> toDisplay);
        public List<int> PullOutSelected();

        public int GetSelectedIndex();
    }
    internal class DataGridManager_type1: IDataGridManager
    {
        readonly string _NameOfCollumWithIndexValue = "IndexInDateStructure";

        private DataGridView ToManage;
        private IProductDisplayer Displayer;
        public DataGridManager_type1(DataGridView dtv)
        {
            ToManage = dtv;
            Displayer = new DislayerDataGrid_format1(dtv);

        }
        public void Dispaly(List<Product> toDisplay)
        {
            foreach (Product product in toDisplay)
            {
                Displayer.Display(product, toDisplay.IndexOf(product));
            }
        }
        public List<int> PullOutSelected()//IT IS THE WORSE PART OF ALL WORK!
        {
            


            List<int> result = new List<int>();

            var dataGridViewColumn = ToManage.Columns[_NameOfCollumWithIndexValue];
            if (dataGridViewColumn == null)
            {
                throw new Exception("_NameOfCollumWithIndexValue - is wrong, please correct int according to your DataGridView");
            }

            int index = ToManage.Columns.IndexOf(dataGridViewColumn);

            foreach (DataGridViewRow item in this.ToManage.SelectedRows)
            {
                int toResult;
                if (!int.TryParse(item.Cells[index].Value.ToString(), out toResult))
                {
                    throw new ArgumentException("Cell that save int does not parse to int");

                };
                //Should be there
                ToManage.Rows.Remove(item);//COULD BE rerro


                result.Add(toResult);

            }


            return result;   
        }

        public int GetSelectedIndex()
        { 
            if (ToManage.SelectedRows.Count == 0)
            {
                throw new Exception("No selected row");
            }


            var dataGridViewColumn = ToManage.Columns[_NameOfCollumWithIndexValue];
            if (dataGridViewColumn == null)
            {
                throw new Exception("_NameOfCollumWithIndexValue - is wrong, please correct int according to your DataGridView");
            }

            int index = ToManage.Columns.IndexOf(dataGridViewColumn);

            DataGridViewRow item = this.ToManage.SelectedRows[0];

            int result;
            if (!int.TryParse(item.Cells[index].Value.ToString(), out result))
            {
                throw new ArgumentException("Cell that save int does not parse to int");

            };

            return result;
        }



    } 



      
}
