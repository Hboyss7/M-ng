using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Permissions;
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

        public byte[] GetBytes()
        {
            byte[] data = new byte[1024];
            int place = 0;

            //Marshal.SizeOf(typeof(int)) : số Byte của int

            Buffer.BlockCopy(BitConverter.GetBytes(IDEmployee), 0, data, place, Marshal.SizeOf(typeof(int)));    
            place += Marshal.SizeOf(typeof(int));

            Buffer.BlockCopy(BitConverter.GetBytes(LastNameSize), 0, data, place, Marshal.SizeOf(typeof(int)));
            place += Marshal.SizeOf(typeof(int));

            Buffer.BlockCopy(Encoding.ASCII.GetBytes(LastName), 0, data, place, LastName.Length);
            place += LastName.Length;

            Buffer.BlockCopy(BitConverter.GetBytes(FirstNameSize), 0, data, place, Marshal.SizeOf(typeof(int)));
            place += Marshal.SizeOf(typeof(int));

            Buffer.BlockCopy(Encoding.ASCII.GetBytes(FirstName), 0, data, place, FirstName.Length);
            place += FirstName.Length;

            Buffer.BlockCopy(BitConverter.GetBytes(YearService), 0, data, place, Marshal.SizeOf(typeof(int)));
            place += Marshal.SizeOf(typeof(int));

            Buffer.BlockCopy(BitConverter.GetBytes(Salary), 0, data, place, Marshal.SizeOf(typeof(double)));
            place += Marshal.SizeOf(typeof(double));

            Buffer.BlockCopy(BitConverter.GetBytes(Size), 0, data, place, Marshal.SizeOf(typeof(int)));
            place += Marshal.SizeOf(typeof(int));

            return data;
        }

        public Employee()
        {
                
        }

        public Employee(byte[] data)
        {
            int place = 0;

            IDEmployee = BitConverter.ToInt32(data, place);
            place += Marshal.SizeOf(typeof(double));

            LastNameSize = BitConverter.ToInt32(data, place);
            place += Marshal.SizeOf(typeof(int));

            LastName = Encoding.ASCII.GetString(data, place, LastNameSize);
            place += LastNameSize;

            FirstNameSize = BitConverter.ToInt32(data, place);
            place += Marshal.SizeOf(typeof(int));

            FirstName = Encoding.ASCII.GetString(data, place, FirstNameSize);
            place += FirstNameSize;

            YearService = BitConverter.ToInt32(data, place);
            place += Marshal.SizeOf(typeof(double));

            Salary = BitConverter.ToDouble(data, place);
            place += Marshal.SizeOf(typeof(double));

            Size = BitConverter.ToInt32(data, place);
            


        }










    }

    // GetByte :   Dùng Phương Thức GetBytes() của lớp BitConverter 
    //             _ Trả vể Mảng Byte
    //             _BitConverter.GetBytes(Varible) : int, double,..
    //             _Encoding.ASCII.GetBytes(Varible) : string
    //             Dùng phương thức BlockCopy của lớp Butter 
    //             _ Để tập hơp các mảng byte thành phần vào 1 mảng lớn
    //             _ Buffer.BlockCopy(ArrayByte[] ThànhPhầni, int start,
    //                 ArrayByte[] tập hợp, int place, int SizeByte]
    //             _Size cần lấy trong ArrayByte là Byte
    //             _Place : nơi để trong ArrayByte
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
    //         Vậy khi GetBytes cần chuyển Length (int) của string vô 