using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListenerEmployee
{
    internal class Employee
    {
        public int IDEmployee;

        public string LastName;

        public string FirstName;

        public int YearService;

        public double Salary;

        public int LastNameSize;

        public int FirstNameSize;

        public int Size;
    }

    // GetByte :   Dùng Phương Thức GetBytes() của lớp BitConverter 
    //             _ Trả vể Mảng Byte
    //             _BitConverter.GetBytes(Varible) : int, double,..
    //             _Encoding.ASCII.GetBytes(Varible) : string
    //             Dùng phương thức BlockCopy của lớp Butter 
    //             _ Để tập hơp các mảng byte thành phần vào 1 mảng lớn
    //             _ Butter.BlockCopy(ArrayByte[] ThànhPhầni, int start,
    //                 ArrayByte[] tập hợp, int SizeByte]
    //             _Size cần lấy trong ArrayByte là Byte
    //             _Ta sẽ căn cứ vào Length của Varible để lấy được Size (string)
    //             _  hoặc là số Byte của kiểu dữ liệu để lấy được chính xác hơn
}   // 
    //              
    // ConvertByte: Dùng phương thức các Converter của BitConverter ( ToInt32(), ToDouble()) 
    //              - Encoding.ASCII.GetString(ArrayByte[] tập hợp, place, size) : string
    //              _ BitConverter.ToInt32(ArrayByte[] tập hợp, place)
    //         Không cần size vì đã biết số Byte của các phương thức Convert ( Int32 = 4 byte)
    //              _ StringSize sẽ không cố định, vậy làm sao để biết khi chỉ có ArrayByte[] tập hợp
    //         Không thể dùng Length vì nó không có gì hết
    //              _Vì chỉ có Array[] nên bắt buộc phải có Length của string trong đây
    //         Vậy khi GetBytes 