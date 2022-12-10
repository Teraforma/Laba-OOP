using Degustatotor_Laba_OOP.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degustatotor_Laba_OOP.Managers
{
    internal class InputManager
    {
        TextBox NameInput_TextBox;
        TextBox Note_TextBox;
        TextBox HealthyValueInput_TextBox;
        TextBox TypeInput_TextBox;
        TextBox PriceInput_TextBox;
        TextBox DateOnlyVerificate_TextBox;
        TextBox ShopInfoInput_TextBox;
        TextBox TasteInput_TextBox;

        Product[] ToEdit;

        readonly static string _NameInputBackgroundText = "Name of product";
        readonly static string _TypeInputBackgroundText = "Type of Product";
        readonly static string _NoteInputBackgroundText = "Note";

        public InputManager(TextBox[] forProduct)
        {
             NameInput_TextBox = forProduct[0];
             Note_TextBox = forProduct[1];
             HealthyValueInput_TextBox = forProduct[2];
             TypeInput_TextBox = forProduct[3];
             PriceInput_TextBox = forProduct[4];
             DateOnlyVerificate_TextBox = forProduct[5];
             ShopInfoInput_TextBox = forProduct[6];
             TasteInput_TextBox = forProduct[7];
        }

        
        public  Product CreateProduct()
        {
            Product result;

            //string name, type, note, shopInfo;
            int health, taste;
            double price;
            DateOnly toCreate;

            if (!int.TryParse(HealthyValueInput_TextBox.Text, out health))
            {
                throw new ArgumentException("HealthPoints has to be an integer ");
            }
            
            if (!int.TryParse(TasteInput_TextBox.Text, out taste))
            {
                throw new ArgumentException("TastePoints has to be an integer ");
            }
            
            if (!double.TryParse(PriceInput_TextBox.Text, out price))
            {
                throw new ArgumentException("Price has to be a number");
            }
            
            
            if (string.IsNullOrEmpty(ShopInfoInput_TextBox.Text))
            {
                throw new ArgumentException("Shop Info has to containt information");
            }
            if (DateOnly.TryParse(DateOnlyVerificate_TextBox.Text, out toCreate)) 
            {
                result = new Product(NameInput_TextBox.Text, TypeInput_TextBox.Text, health, taste, Note_TextBox.Text, toCreate);
            }
            else
            {

                result = new Product(NameInput_TextBox.Text, TypeInput_TextBox.Text, health, taste, Note_TextBox.Text);
            }


            result.Price = price;
            result.ShopInfo = ShopInfoInput_TextBox.Text;

            return result;
        }

        public void DisplayAsExaple( Product toDisplay)
        {
             NameInput_TextBox.Text = toDisplay.Name.ToString();
             Note_TextBox.Text = toDisplay.Note;
             HealthyValueInput_TextBox.Text= toDisplay.HealthPoints.ToString();
             TypeInput_TextBox.Text = toDisplay.Type;
             PriceInput_TextBox.Text = toDisplay.Price.ToString();
             DateOnlyVerificate_TextBox.Text = toDisplay.Verified.ToString();
             ShopInfoInput_TextBox.Text = toDisplay.ShopInfo;
             TasteInput_TextBox.Text = toDisplay.HealthPoints.ToString();
        }
        public void SetInputTestBoxesColor (Color toChange)
        {
            NameInput_TextBox.ForeColor = toChange;
            Note_TextBox.ForeColor = toChange;
            HealthyValueInput_TextBox.ForeColor = toChange;
            TypeInput_TextBox.ForeColor = toChange;
            PriceInput_TextBox.ForeColor = toChange;
            DateOnlyVerificate_TextBox.ForeColor = toChange;
            ShopInfoInput_TextBox.ForeColor = toChange;
            TasteInput_TextBox.ForeColor = toChange;
        }

        public Dictionary<string, string> GetStringParameters()
        {
            Dictionary<string, string> Result = new Dictionary<string, string>();


            if (!(NameInput_TextBox.Text == _NameInputBackgroundText))
            {
                Result["Name"] = NameInput_TextBox.Text;
            }
           

            if (!(TypeInput_TextBox.Text == _TypeInputBackgroundText))
            {
                Result["Type"] = TypeInput_TextBox.Text;
            }
            

            if (!(Note_TextBox.Text == _NoteInputBackgroundText))
            {
                Result["Note"] = Note_TextBox.Text;
            }

            return Result;
        }
        


    }
}
