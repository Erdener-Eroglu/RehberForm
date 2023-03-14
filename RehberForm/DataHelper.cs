using Newtonsoft.Json;

namespace RehberForm;

public class DataHelper
{
    private static readonly string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Kisiler.json";

    public static void Save(DataContext context)
    {
        FileStream file = File.Open(Path, FileMode.Create);
        StreamWriter writer = new StreamWriter(file);
        writer.Write(JsonConvert.SerializeObject(context));
        writer.Close();
        writer.Dispose();
    }

    public static DataContext Load()
    {
        FileStream file = File.Open(Path, FileMode.OpenOrCreate);
        StreamReader reader = new StreamReader(file);
        string data = reader.ReadToEnd();
        if (!string.IsNullOrEmpty(data))
        {
            reader.Close();
            reader.Dispose();
            return JsonConvert.DeserializeObject<DataContext>(data);
        }
        reader.Close();
        reader.Dispose();
        return null;
    }
}
