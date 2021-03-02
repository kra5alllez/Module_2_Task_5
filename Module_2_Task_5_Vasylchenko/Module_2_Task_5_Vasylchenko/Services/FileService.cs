using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Module_2_Task_5_Vasylchenko.Services
{
    public class FileService : IFileService
    {
        private readonly FileServiceConfig _file;
        private readonly FileDeleteService _fileDeleteService;
        private string _path;

        public FileService()
        {
            _file = new FileServiceConfig();
            _fileDeleteService = new FileDeleteService();
            _path = $@"{_file.Json().DirectoryPath}{DateTime.UtcNow.ToString(_file.Json().TimeFormat)}{_file.Json().FileExtension}";
            _fileDeleteService.DeleteFile(_file.Json().DirectoryPath);
        }

        public void FileSeve(string text)
        {
            string writePath = _path;

            using (StreamWriter fileWrite = new StreamWriter(writePath, true, System.Text.Encoding.Default))
            {
                fileWrite.WriteLine(text);
            }
        }
    }
}
