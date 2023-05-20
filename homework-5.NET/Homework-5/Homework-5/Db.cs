
using Newtonsoft.Json;

namespace Homework_5
{
    public class Db
    {
        private string _folderPath;
        private string _filePath;
        public Db() 
        {
            _folderPath = "../../../Dogs";
            _filePath = _folderPath + "/Dog.json";
            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }
            if(!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
            }
            List<Dog> data = ReadFromFile();
            if (data == null)
            {
                WriteToFile(new List<Dog>());
            }
        }
        public List<Dog> ReadFromFile()
        {
            using(StreamReader sr = new StreamReader(_filePath))
            {
                string json = sr.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Dog>>(json);
            }
        }
        public void WriteToFile(List<Dog> dogs)
        {
            using(StreamWriter sw = new StreamWriter(_filePath))
            {
                string json = JsonConvert.SerializeObject(dogs);
                sw.WriteLine(json);
            }
        }
        public List<Dog> GetAll() 
        {
            return ReadFromFile();
        }
        public void Insert (Dog dog)
        {
            List<Dog> dogs = ReadFromFile();
            dogs.Add(dog);
            WriteToFile(dogs);
        }
    }
}
