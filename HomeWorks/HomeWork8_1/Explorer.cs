namespace HomeWork8_1;

public class Explorer
{
    public static void CreateFile(string path)
    {
        if (!File.Exists(path))
        {
            File.Create(path);
            Console.WriteLine("Создание");
        }
    }
            
    public static void CopyFile(string path, string newPath)
    {
        if (File.Exists(path))
        {
            File.Copy(path, newPath, true);
            Console.WriteLine("Копирование");
        }
    }
            
    public static void DeleteFile(string path)
    {
        if (File.Exists(path))
        {
            File.Delete(path);
            Console.WriteLine("Удаление");
        }
    }
            
            
    public static void RenameFile(string path,string newPath)
    {
        if (File.Exists(path))
        {
            File.Copy(path, newPath, true);
            File.Delete(path);
            Console.WriteLine("Переименование");
        }
    }
            
    public static void CreateDirectory(string path)
    {
        Directory.CreateDirectory(path);
        Console.WriteLine("Создание директории");
                
    }
            
    public static void DeleteDirectory(string path)
    {
        Directory.Delete(path);
        Console.WriteLine("Удаление директории");
                
    }
}