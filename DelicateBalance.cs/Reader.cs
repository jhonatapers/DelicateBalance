using System.Net;
using System.IO;
public class Reader
{
    public static string[] readData(string arquivo)
    {
        return System.IO.File.ReadAllLines(Directory.GetCurrentDirectory() + @"\casos\" + arquivo);
    }
}