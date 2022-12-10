using Degustatotor_Laba_OOP.classes;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Windows.Forms.Design.AxImporter;

namespace Degustatotor_Laba_OOP.Managers
{
    internal interface IFileManager 
    {
        
        public bool Save(List<Product> ToSave);
        public List<Product> Load();
    }


    internal class JsonFileManager : IFileManager
    {
        string path;
        private readonly string _defaultPath = @"D:\Saves\SerializeJsonExample.json";
        public JsonFileManager()
        {
            this.path = _defaultPath;
            using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate)) { return; };

        }
        

        public bool Save(List<Product> ToSave)
        {
            if (ToSave == null) { return true; }

            try {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
                };

                using (FileStream fstream = new FileStream(path, FileMode.CreateNew))
                {

                    JsonSerializer.Serialize(fstream, ToSave, options);
                }

                return true;

                }catch(IOException ex) { 
                File.Delete(path); 
                
            }
            catch(Exception ex)
            {
                throw new Exception("ERROR Can not save " + ex.ToString());
                
            }return false;
        }
        public List<Product> Load()
        {
            try {
                using FileStream openStream = File.OpenRead(path);
                
                   return  JsonSerializer.Deserialize<List<Product>>(openStream);

                
            }
            catch(Exception ex)
            {
                throw new Exception("Wrong Json//Can not be loaded as List<Product>" + ex.ToString() );
                //return false;
            }
        }


        public async Task<bool> SaveAsync(List<Product> ToSave)
        {

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
            };

             using (FileStream fstream = new FileStream(path, FileMode.CreateNew))
            {

                 JsonSerializer.Serialize(fstream, ToSave, options);
                Console.WriteLine(@"written in file");
            }

            return true;
        }
        public async Task<List<Product>> LoadAsync()
        {

            using FileStream openStream = File.OpenRead(path);
            List<Product> Result =
                await JsonSerializer.DeserializeAsync<List<Product>>(openStream);

            return Result;
        }
     
    }
}
