using Microsoft.AspNetCore.Http;
using System;
using System.IO;


    public interface IUploadHeper
    {
        void UploadImage(IFormFile formFile, string rootPath, string thuMucCon);
        void DeleteImage(string fileDel);
    }
    public class UploadHelper : IUploadHeper
    {

        
        public void UploadImage(IFormFile FileUpload, string rootPath, string thuMucCon)
        {
            if (FileUpload != null)
            {

                var file = Path.Combine(rootPath, thuMucCon);
                string filePath = Path.Combine(file, FileUpload.FileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    FileUpload.CopyTo(fileStream);
                }
            }
        }

        public void DeleteImage(string fileDel)
        {
            if (System.IO.File.Exists(fileDel))
                System.IO.File.Delete(fileDel);
        }

    }

