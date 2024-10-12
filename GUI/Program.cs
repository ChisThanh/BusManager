using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.UI;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Main());
            Application.Run(new frm_Statistical());
        }
    }
}

//db.Trip.aggregate([
//    {
//        $match:
//    {
//            $expr:
//        {
//                $eq: [{ $year: "$Trip.Date" }, 2024] // Chọn các chuyến đi trong năm 2024
//            }
//    }
//},
//    {
//        $addFields:
//    {
//    regionId: { $toObjectId: "$Trip.Region" } // Chuyển đổi string thành ObjectId
//    }
//},
//    {
//        $lookup:
//    {
//    from: "Region", // Tên collection Region
//            localField: "regionId", // Trường vừa chuyển đổi sang ObjectId
//            foreignField: "_id", // Trường trong Region để so khớp
//            as: "regionData" // Tên trường mới sẽ chứa dữ liệu kết hợp
//        }
//},
//    {
//        $unwind:
//    {
//    path: "$regionData", // Giải nén mảng regionData
//            preserveNullAndEmptyArrays: true // Giữ nguyên các tài liệu không có dữ liệu tương ứng
//        }
//},
//    {
//        $group:
//    {
//    _id: "$regionData.Region.Name", // Nhóm theo tên vùng
//            totalRevenue: { $sum: "$Trip.Price" } // Tính tổng doanh thu
//    }
//},
//    {
//        $project:
//    {
//    _id: 0, // Không hiển thị _id
//            region: "$_id", // Đặt lại tên cho trường vùng
//            totalRevenue: 1 // Hiển thị tổng doanh thu
//        }
//}
//]);