using System.IO;
using System.Text;

namespace Race;

internal class FileProvider
{
    public static void Replace(string Path, string value)
    {
        var writer = new StreamWriter(Path, false, Encoding.UTF8);
        writer.WriteLine(value);
        writer.Close();
    }
    public static string GetValue(string Path)
    {
        var reader = new StreamReader(Path, Encoding.UTF8);
        var value = reader.ReadToEnd();
        reader.Close();
        return value;
    }
    public static bool Exists(string Path)
    {
        return File.Exists(Path);
    }
}
