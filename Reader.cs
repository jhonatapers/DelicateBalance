using System.Net;
using System.IO;
class Reader
{
    public string[] readData(string arquivo)
    {
        string test = Directory.GetCurrentDirectory();
        return System.IO.File.ReadAllLines(@test);
    }
}