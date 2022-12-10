using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degustatotor_Laba_OOP.classes
{
    internal interface IProductDisplayer
    {
        public void Display(Product product,int index);
         
    }

    internal class DislayerDataGrid_format1: IProductDisplayer
    {
        readonly DataGridView display;
        readonly int _IndexOfColummWithIndexes;
        readonly string _NameOfIndexCollum = "IndexInDateStructure";

        public DislayerDataGrid_format1(DataGridView dataGridView)
        {
            display = dataGridView;

            var dataGridViewColumn = dataGridView.Columns[_NameOfIndexCollum];
            if (dataGridViewColumn == null)
            {
                throw new Exception("_NameOfCollumWithIndexValue - is wrong, please correct int according to your DataGridView");
            }

            _IndexOfColummWithIndexes = dataGridView.Columns.IndexOf(dataGridViewColumn);
        }
        public void Display(Product product, int index)
        {   
            
            int newRowIndex = display.Rows.Add();
            
            //finish
            display.Rows[newRowIndex].Cells[0].Value = product.Name;
            display.Rows[newRowIndex].Cells[1].Value = product.Type;
            display.Rows[newRowIndex].Cells[2].Value = product.HealthPoints;
            display.Rows[newRowIndex].Cells[3].Value = product.TastePoints;
            display.Rows[newRowIndex].Cells[4].Value = product.Note;
            display.Rows[newRowIndex].Cells[5].Value = product.Verified;
            display.Rows[newRowIndex].Cells[6].Value = product.Price;
            display.Rows[newRowIndex].Cells[7].Value = product.ShopInfo;
            display.Rows[newRowIndex].Cells[_IndexOfColummWithIndexes].Value = index;

        }

    }
}
