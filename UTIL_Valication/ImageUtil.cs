//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Net.Mime.MediaTypeNames;

//namespace UTIL_Valication
//{
//    public class ImageUtil
//    {
//        public static Boolean IsImage(OpenFileDialog openFileDialog)
//        {
//            if (openFileDialog.CheckFileExists)
//            {
//                string fileName = openFileDialog.FileName;
//                string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };
//                string fileExtension = System.IO.Path.GetExtension(fileName).ToLower();
//                return imageExtensions.Contains(fileExtension);
//            }
//            return false;
//        }
//        /// <summary>
//        /// Tên file theo mốc thời gian lưu
//        /// </summary>
//        /// <param name="openFileDialog">Đối tượng đọc file được chọn</param>
//        /// <returns>Tên file theo mốc thời gian lưu</returns>
//        public string Save(OpenFileDialog openFileDialog)
//        {
//            string sourceFilePath = openFileDialog.FileName;

//            // Kiểm tra file có phải là hình ảnh không trước khi lưu
//            if (!IsImage(openFileDialog))
//            {
//                throw new Exception("File không phải là hình ảnh hợp lệ!");
//            }

//            string projectFolder = Path.Combine(Application.StartupPath, "Images");

//            if (!Directory.Exists(projectFolder))
//            {
//                Directory.CreateDirectory(projectFolder);
//            }

//            // Lấy ngày tháng và thời gian hiện tại sử dụng cho tên ảnh
//            string fileExtension = Path.GetExtension(sourceFilePath).ToLower();
//            string fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + fileExtension;
//            string destinationFilePath = Path.Combine(projectFolder, fileName);

//            // Thực hiện sao chép file
//            try
//            {
//                File.Copy(sourceFilePath, destinationFilePath, true);
//                return fileName; // Trả về tên file đã lưu
//            }
//            catch
//            {
//                throw new Exception("Không thể sao chép file!");
//            }
//        }
//        public Bitmap load(string fileName)
//        {
//            try
//            {
//                string projectFolder = Path.Combine(Application.StartupPath, "Images");
//                return new Bitmap(Path.Combine(projectFolder, fileName));

//            }
//            catch (Exception ex)
//            {
//                return null; // Trả về null nếu có lỗi
//            }
//        }
//    }
//}
