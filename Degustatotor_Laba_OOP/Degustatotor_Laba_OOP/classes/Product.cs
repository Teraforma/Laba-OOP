using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Degustatotor_Laba_OOP.classes
{
    internal  class Product
    {   
        public  string Name { get;  set; }
        public  string Type { get;  set; }
        public int HealthPoints { get;  set; }
        public int TastePoints { get;  set; }
        
        public double Price { get;  set; }
        public string ShopInfo { get;  set; }
        public string Note { get;  set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly Verified { get;  set; }




        public Product() { }
        
        public Product(string name, string type, int healthPoints, int tastePoints, string note)
        {

            this.Type = type;
            this.Name = name;
            this.HealthPoints = healthPoints;
            this.TastePoints = tastePoints;
            this.Note = note;

            Verified = DateOnly.FromDateTime(DateTime.Now);

        }

        public Product(string name,string type, int healthPoints, int tastePoints, string note, DateOnly toSet)
        {
            this.Type = type;
            this.Name = name;
            this.HealthPoints = healthPoints;
            this.TastePoints = tastePoints;
            this.Note = note;

            SetVerificationDate( toSet );

        }

        

        

        public void SetVerificationDate(DateOnly NewVerified)
        {
            if (NewVerified > DateOnly.FromDateTime(DateTime.Now))
            {
                throw new ArgumentOutOfRangeException("Date of done verification IS in future");
            }

            if (NewVerified < Verified)
            {
                throw new ArgumentOutOfRangeException("Can not set date of verification later than previous one");
            }

            this.Verified = NewVerified;
        }

        
        

    }

    


    /*
    public class PriceAndShop
    {
        public double Price { get; private set; }
        public string ShopInfo { get;  set; }

        public PriceAndShop(double price, string shopInfo)
        {
            SetPrice(price);
            this.ShopInfo = shopInfo;

        }
        public void SetPrice(double price)
        {
            if (price < 0) { this.Price = 0; }
            else { this.Price = price; }
        }

    }
    */
}
