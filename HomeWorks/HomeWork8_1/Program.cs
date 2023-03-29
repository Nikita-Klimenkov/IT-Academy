namespace HomeWork8_1
{
    internal abstract class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\FORTESTHOMEWORK\test.txt";
            string newPath = @"D:\FORTESTHOMEWORK\copy.txt";
            string directory = @"D:\FORTESTHOMEWORK\names";
            
            Explorer.CreateDirectory(directory);
            Explorer.CreateFile(path);
            Explorer.CopyFile(path, newPath);
            Explorer.RenameFile(path, newPath);
            Explorer.DeleteFile(path);
            Explorer.DeleteDirectory(directory);


        }
        
    }
}