using System.IO;

namespace Module_2_Task_5_Vasylchenko.Services
{
    public class FileDeleteService
    {
        public void DeleteFile(string dirName)
        {
            if (Directory.Exists(dirName))
            {
                string[] files = Directory.GetFiles(dirName);
                if (files.Length == 3)
                {
                     File.Delete(files[0]);
                }
            }
        }
    }
}
