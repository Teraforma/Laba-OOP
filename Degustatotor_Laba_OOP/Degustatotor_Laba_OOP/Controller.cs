using Degustatotor_Laba_OOP.classes;
using Degustatotor_Laba_OOP.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degustatotor_Laba_OOP
{
    internal class Controller
    {
        private DataGridView CurDataGriwView;
        private List<Product> Data;
        private IProductDisplayer ProductDisplayer;
        private InputManager Input;
        private IDataGridManager Display;
        private IFileManager FileManager;
        
        int ToEditIndex;

        public Controller(DataGridView dtv)
        {
            Data = new List<Product>();
            CurDataGriwView = dtv;
            ProductDisplayer = new DislayerDataGrid_format1(CurDataGriwView);
            Display = new DataGridManager_type1(dtv);
        }

        public void SetInputManager(TextBox[] forProductData)
        {
            Input = new InputManager(forProductData);

        }

        public void CreateNewProduct()
        {
            try {
                Data.Add(Input.CreateProduct());
                RefreshView();
            }
            catch(Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        


        public void RefreshView()//dont clean tails
        {
            CurDataGriwView.Rows.Clear();
            foreach (Product product in Data)
            {
                ProductDisplayer.Display(product, Data.IndexOf(product));
            }
        }
        public void DeleteSelected()
        {
            var indexesToDel = this.Display.PullOutSelected();
            indexesToDel = indexesToDel.OrderByDescending(i => i).ToList();

            foreach (int i in indexesToDel)        //NOT AFFICIANT CODE
            {
                Data.RemoveAt(i);
            }
            

            this.RefreshView();
        }
        public void RowSelectedAction()
        {
            ToEditIndex = this.Display.GetSelectedIndex();
            try
            {
                Input.DisplayAsExaple(Data[ToEditIndex]);
                Input.SetInputTestBoxesColor(Color.Black);
            }
            catch(Exception ex) { }
        }

        public void EditData()
        {
            Data[ToEditIndex] = Input.CreateProduct();
            RefreshView();
        }

        public void SaveData()
        {
            if (this.FileManager == null)
            {
                SetSavePath();
            }
            if (Data == null || Data.Count == 0) { return; }

            try
            {
                 this.FileManager.Save(Data);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        public void SetSavePath( )
        {
            try
            {
                FileManager = new JsonFileManager();
            }catch(Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        public void LoadData()
        {
            if (this.FileManager == null)
            {
                SetSavePath();
                MessageBox.Show("SetSavePath");
            }

            //if (this.Data == null) {  }

            try
            {
                Data = this.FileManager.Load();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

            RefreshView();

        }

        public void Sort()
        {
            IEnumerable<Product> scoreQuery = Data;
            Dictionary<string, string> SortBy = Input.GetStringParameters();


            string Test = " Discinary: \n";
            foreach (var item in SortBy)
            {
                Test += item.ToString();
                Test += "\n";
            }
            MessageBox.Show(Test);


            if (SortBy.ContainsKey("Name") )
            {
                scoreQuery = from prod in scoreQuery
                             where prod.Name.Contains( SortBy["Name"] )
                             select prod;
            }

            if (SortBy.ContainsKey("Type") )
            {
                scoreQuery = from prod in scoreQuery
                             where prod.Type.Contains( SortBy["Type"] )
                             select prod;
            }

            if (SortBy.ContainsKey("Note"))
            {
                scoreQuery = from prod in scoreQuery
                             where prod.Note.Contains( SortBy["Note"] )
                             select prod;
            }

            CurDataGriwView.Rows.Clear();

            var toDislay = scoreQuery.ToArray();
            foreach (Product product in toDislay )
            {
                ProductDisplayer.Display(product, Data.IndexOf(product));
            }
            
        }

        public void Who()
        {
            MessageBox.Show("Creted: Voloshyn Danyl Maksymovich\n2Kurs gropu K26 2022(3rd semeste)\nNothing spesial reall,but it took a lot of time just because I DAMN HAD NO PLAN!\n And yeah, it is NO perfect, but i liked and it's also not the worse work of mine, it overlooks a lot of OOP princibels or iplement them poorly, but i got an expirience, so totally worhted it");
        }

    }
}
