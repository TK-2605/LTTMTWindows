using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ShoppingSystem.Utils
{
    public static class FileHelper
    {
        // Copy ảnh vào thư mục dự án và đổi tên UUID
        public static string CopyImageToProject(string sourceFilePath)
        {
            try
            {
                string projectPath = Application.StartupPath;
                string imageFolder = Path.Combine(projectPath, "Images");

                if (!Directory.Exists(imageFolder)) Directory.CreateDirectory(imageFolder);

                string extension = Path.GetExtension(sourceFilePath);
                string newFileName = Guid.NewGuid().ToString() + extension; // Tên ngẫu nhiên
                string destFilePath = Path.Combine(imageFolder, newFileName);

                File.Copy(sourceFilePath, destFilePath);
                return newFileName;
            }
            catch { return null; }
        }

        // Lấy đường dẫn ảnh để hiện lên PictureBox
        public static string GetImagePath(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) return null;
            return Path.Combine(Application.StartupPath, "Images", fileName);
        }
    }
}
