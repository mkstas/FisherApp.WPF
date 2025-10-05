using System.IO;
using System.Text.Json;

namespace FisherApp.WPF.Utilites
{
    public class FileReader
    {
        public static string ReadJson(string path)
        {
            try
            {
                return File.ReadAllText(path);
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("File is not found");
            }
        }
    }
}
