using DTS_CSharp_NangCao;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using static DTS_CSharp_NangCap.Program.SinhVien;
using System.Threading;

namespace DTS_CSharp_NangCap
{
    internal class Program
    {
        private delegate int MyDelegate(string s);

        public delegate void UpdateNameHandler(string name);

        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            #region Khởi tạo ArrayList

            //ArrayList arrayList = new ArrayList(); // Khởi tạo 1 arraylist rỗng

            //ArrayList arrayList2 = new ArrayList(5); //Khởi tạo 1 arraylist và chỉ định capacity ban đầu là 5

            ///* Khởi tạo 1 arraylist có kích thường bằng arrayList2
            //* Sao chép toàn bộ phần tử trong arrayList2 vào arrayList3
            //* 2 thằng khác vùng nhớ nên thay đổi k ảnh hưởng
            //*/
            //ArrayList arrayList3 = new ArrayList(arrayList2);

            ///*
            // * Kiểu dữ liệu tham chiếu.
            // * Array4 tham  chiếu tới giá trị tới array2
            // * 2 thằng cùng chỉ, trỏ đến 1 giá trị của bộ nhớ nên khi 1 thằng thay đổi, thằng kia sẽ thay đổi theo.
            // * array4 thay đổi thì array2 nhận giá trị thay đổi đó, và ngược lại
            // */
            //ArrayList arrayList4 = arrayList2;

            #endregion Khởi tạo ArrayList

            #region Sắp xếp ArrayList

            //// Tạo ds rỗng
            //ArrayList arrPersons = new ArrayList();

            //// Thêm phần tử vào ds
            //arrPersons.Add(new Person("Do Thanh Sang", 29));
            //arrPersons.Add(new Person("Nguyen Van B", 34));
            //arrPersons.Add(new Person("Le van C", 23));
            //arrPersons.Add(new Person("Ho van D", 37));

            ////In thử ds ra màn hình
            //Console.WriteLine("Danh sach Person ban dau: ");
            //foreach (Person person in arrPersons)
            //{
            //    Console.WriteLine(person.ToString());
            //}

            ///*
            // * Thực hiện sắp xếp
            // * Trong phướng thức Compare của lớp SortPerson (tuổi tăng dần)
            // */

            //arrPersons.Sort(new SortPersons());

            //// In ra màn hình kq
            //Console.WriteLine();
            //Console.WriteLine("Danh sach Person duoc tra ve theo kieu tang dan: ");
            //foreach (Person person in arrPersons)
            //{
            //    Console.WriteLine(person.ToString());
            //}

            #endregion Sắp xếp ArrayList

            #region Khởi tạo HashTable

            //Hashtable hashtable = new Hashtable(5);

            ////Thêm dữ liệu
            //hashtable.Add("K", "Kteam");
            //hashtable.Add("S", "SangDT");
            //hashtable.Add("N", "NganVo");

            #endregion Khởi tạo HashTable

            #region Lưu ý HashTable

            //In tất cả phần tử theo key-value
            //foreach (DictionaryEntry item in hashtable)
            //{
            //    // Add phần từ vào nên tự động sắp xếp luôn.
            //    Console.WriteLine(item.Key + "\t" + item.Value);
            //}

            //// In theo Key với giá trị mong muốn
            //// Mảng bt theo xuất theo Index, HashTable truy xuất theo Key
            //Console.WriteLine(hashtable["S"]);

            #endregion Lưu ý HashTable

            #region Khởi tạo SortedList

            // Là 1 SortedList giống như Hashtable, các giá trị được sắp xếp theo Key. Khi được add vào sẽ được sắp xếp theo Key.
            // Là sự kết hợp giữa ArrayList và HashTable
            // SortedList sortedList2 = new SortedList(5);

            /* Khởi tạo 1 SoertedList có kích thường bằng sortedList2
            * Sao chép toàn bộ phần tử trong sortedList vào sortedList3
            * 2 thằng khác vùng nhớ nên thay đổi k ảnh hưởng
            */
            //SortedList sortedList3 = new SortedList(sortedList2);

            /*
             * Định nghĩa 1 lớp PersonComparer có thực thi 1 interface Icomparer
             * Sau đó override lại phương thức Comparer
             * Sử dụng lớp trên để truyền lại vào constructor của SortedList
             */
            //SortedList sortedList4 = new SortedList(new PersonComparer());

            /*
             * Tạo 1 ShortedList mới và sao chép các phần tử từ sortedList3 đồng thời sắp xếp các phần từ còn lại
             * Theo cách sắp xếp được định nghĩa trong lớp PersonComparer
             */
            //SortedList sortedList5 = new SortedList(sortedList3, new PersonComparer());

            #endregion Khởi tạo SortedList

            #region Sắp xếp SortedList

            //sortedList4.Add(new Person("Sang", 20), 25);
            //sortedList4.Add(new Person("HongAn", 12), 28);
            //sortedList4.Add(new Person("Ngan", 27), 15);

            //foreach (DictionaryEntry item in sortedList4)
            //{
            //    Console.WriteLine("Key: " + item.Key + "\tVale: " + item.Value);
            //}

            #endregion Sắp xếp SortedList

            #region Khởi tạo Stack

            //Stack stack = new Stack();

            // Khởi tạo 1 mảng bất kỳ
            // ArrayList arrayList = new ArrayList();
            //arrayList.Add(5);

            // Khởi tạo 1 Stack và sao chép giá trị các phần tử từ arrayList vào stack
            //Stack stack2 = new Stack(arrayList);

            #endregion Khởi tạo Stack

            #region Sắp xếp, thuộc tính Stack

            // Tạo 1 Stack rỗng
            //Stack MyStack4 = new Stack();

            //// Thực hiện thêm vài phần tử vào Stack thông qua hàm Push.
            //MyStack4.Push("Education");
            //MyStack4.Push("Free");
            //MyStack4.Push("HowKteam");

            //// Thử sử dụng các phương thức của Stack.
            //Console.WriteLine(" So phan tu hien tai cua Stack la: {0}", MyStack4.Count);

            //// Lưu ý ở đây ta chỉ muốn xem giá trị mà không muốn nó khỏi Stack thì ta sẽ dùng Peek.
            //Console.WriteLine(" Phan tu dau cua Stack la: {0}", MyStack4.Peek());

            //// Thử kiểm tra lại số phần tử để chắc chắn rằng hàm Peek không xoá phần tử ra khỏi Stack.
            //Console.WriteLine(" So phan tu cua Stack sau khi goi ham Peek: {0}", MyStack4.Count);

            //// Thực hiện xoá các phần tử ra khỏi Stack.
            //Console.WriteLine(" Popping...");
            //int Length = MyStack4.Count;
            //for (int i = 0; i < Length; i++)
            //{
            //    Console.Write(" " + MyStack4.Pop());
            //}
            //Console.WriteLine();

            //// Kiểm tra lại số phần tử của Stack sau khi Pop
            //Console.WriteLine(" So phan tu cua Stack sau khi Pop la: {0}", MyStack4.Count);

            #endregion Sắp xếp, thuộc tính Stack

            #region Tạo và sắp xếp Queue

            //Queue queue = new Queue();

            //// Tạo 1 Queue rỗng
            //Queue MyQueue4 = new Queue();

            //// Thực hiện thêm vài phần tử vào Queue thông qua hàm Enqueue.
            //MyQueue4.Enqueue("HowKteam");
            //MyQueue4.Enqueue("Free");
            //MyQueue4.Enqueue("Education");

            //// Thử sử dụng các phương thức của Queue.
            //Console.WriteLine(" So phan tu hien tai cua Queue la: {0}", MyQueue4.Count);

            //// Lưu ý ở đây ta chỉ muốn xem giá trị mà không muốn nó khỏi Queue thì ta sẽ dùng Peek.
            //Console.WriteLine(" Phan tu dau cua Queue la: {0}", MyQueue4.Peek());

            //// Thử kiểm tra lại số phần tử để chắc chắn rằng hàm Peek không xoá phần tử ra khỏi Queue.
            //Console.WriteLine(" So phan tu cua Queue sau khi goi ham Peek: {0}", MyQueue4.Count);

            //// Thực hiện xoá các phần tử ra khỏi Queue thông qua hàm Dequeue.
            //Console.WriteLine(" Popping...");
            //int Length = MyQueue4.Count;
            //for (int i = 0; i < Length; i++)
            //{
            //    Console.Write(" " + MyQueue4.Dequeue());
            //}
            //Console.WriteLine();

            //// Kiểm tra lại số phần tử của Queue sau khi Pop
            //Console.WriteLine(" So phan tu cua Queue sau khi Pop la: {0}", MyQueue4.Count);

            #endregion Tạo và sắp xếp Queue

            #region Khởi tạo BitArray

            /*
            * Khởi tạo 1 BitArray có 10 phần tử.
            * Mỗi phần tử có giá trị mặc định 0 (false).
            */
            // BitArray bitArray = new BitArray(10);

            // Muốn mặc định bằng flase
            //BitArray bitArray1 = new BitArray(10, true);

            /*
            * Khởi tạo 1 BitArray từ một mảng bool có sẵn.
            */
            // bool[] mybools = new bool[5] { true, false, true, true, false };
            // BitArray bitArray2 = new BitArray(mybools);

            #endregion Khởi tạo BitArray

            #region Generic

            /*
             * Generic trong C# cho phép bạn định nghĩa một hàm, một lớp mà không cần chỉ ra đối số kiểu dữ liệu là gì.
             * Tuỳ vào kiểu dữ liệu mà người dùng truyền vào thì nó sẽ hoạt động theo kiểu dữ liệu đó.
             */
            //int a = 5, b = 7;
            //double c = 1.2, d = 5.6;

            //Swap<int>(ref a, ref b);
            //Swap<double>(ref c, ref d);

            //Console.WriteLine($"{a}, {b}, {c}, {d}");

            //// Khởi tạo 1 mảng số nguyên kiểu int có 5 phần tử
            //MyGeneric<int> MyG = new MyGeneric<int>(5);

            //MyG.SetItemValue(0, 10);

            #endregion Generic

            #region List

            //List<string> list = new List<string>();

            //List<int> list2 = new List<int>(5);

            ///*
            //* Khởi tạo 1 List số nguyên có kích thước bằng với MyList2.
            //* Sao chép toàn độ phần tử trong MyList2 vào MyList3.
            //* Tạo ra vùng nhớ riêng biệt
            //*/
            //List<int> list3 = new List<int>(list2);

            ///*
            //* Tạo 1 List các kiểu string và thêm 2 phần tử vào List.
            //*/
            //List<string> list4 = new List<string>();
            //list4.Add("Free");
            //list4.Add("Education");

            //// In giá trị các phần tử trong List
            //Console.WriteLine(" List ban dau: ");
            //Console.WriteLine(" So luong phan tu trong List la: {0}", list4.Count);
            //foreach (string item in list4)
            //{
            //    Console.Write(" " + item);
            //}
            //Console.WriteLine();

            //// Chèn 1 phần tử vào đầu List.
            //list4.Insert(0, "HowKteam");

            //// In lại giá trị các phần tử trong List để xem đã chèn được hay chưa
            //Console.WriteLine(" List sau khi insert: ");
            //Console.WriteLine(" So luong phan tu trong List la: {0}", list4.Count);
            //foreach (string item in list4)
            //{
            //    Console.Write(" " + item);
            //}
            //Console.WriteLine();

            //// Kiểm tra 1 phần tử có tồn tại trong List hay không.
            //bool isExists = list4.Contains("Kteam");

            //if (isExists == false)
            //{
            //    Console.WriteLine(" Khong tim thay chuoi Kteam trong List");
            //}

            //HowKteam là sẽ có -- dùng else để hiển thị

            #endregion List

            #region Dictionary

            //Dictionary chính là sự thay thế cho Collections Hashtable đã được học.
            //Dictionary<string, string> dic = new Dictionary<string, string>();

            //dic.Add("Sang", "Do thanh sang");
            //dic.Add("An", "Do thanh Hong An");
            //dic.Add("Ngan", "Do vo thanh ngan");

            //foreach (KeyValuePair<string, string> item in dic)
            //{
            //    Console.WriteLine(item.Key + "\t" + item.Value);
            //}

            // Trùng Key báo lỗi

            /*HASHTABLE
             * Threadsafe - Hỗ trợ multi threading không đụng độ tài nguyên
             * Cặp Key - Value lưu kiểu object
             * Truy xuất phần tử không tồn tại trong Hashtable sẽ không báo lỗi suy ra return null.
             * Hiệu quả cho dữ liệu lớn
             * Các phần tử được sắp xếp lại mỗi khi thêm hoặc xóa các phần tử trong Hashtable.
             * Tìm kiếm nhanh hơn.
             */

            /*DICTIONARY
             *
             * Threadsafe - Không hỗ trợ.
             * Phải xác định cụ thể kiểu dữ liệu của cặp Key - value
             * Truy xuất phần tử không tồn tại trong Dictionary sẽ báo lỗi
             * Không hiệu quả cho dữ liệu lớn
             * Các phần tử nằm theo thứ tự được thêm vào.
             * Tìm kiếm chậm hơn.
             */

            #endregion Dictionary

            #region Tuple

            //Tuple là một kiểu dữ liệu có cấu trúc, giúp lưu trữ các dữ liệu phức tạp mà không cần phải tạo ra một struct hay class mới
            //var MyTyple = Tuple.Create<int, string>(1, "DTS");
            //Console.WriteLine(MyTyple);

            //// Khởi tạo Tuple thông qua constructor của các lớp generic
            //var MyTuple2 = new Tuple<int, string>(2, "Kteam");

            ///*
            // * Mình dùng var để C# tự nhận diện kiểu dữ liệu.
            // * Bạn có thể khai báo tường minh kiểu dữ liệu là Tuple<int, int, int>
            // */

            //var now = GetCurrentDayMonthYear();
            //Console.WriteLine(" Day: {0}, Month: {1}, Year: {2}", now.Item1, now.Item2, now.Item3);

            #endregion Tuple

            #region ICollection

            // ICollection là một interface trong bộ các interface được định nghĩa sẵn của.NET Framework.

            #endregion ICollection

            #region Delegate

            /*Delegate trong C# tương tự như con trỏ hàm trong C hoặc C++.
             * Delegate là một biến kiểu tham chiếu(references) chứa tham chiếu tới một phương thức.
             * Tham chiếu của Delegate có thể thay đổi runtime (khi chương trình đang thực thi).
             * Delegate thường được dùng để triển khai các phương thức hoặc sự kiện call-back.
             */

            //MyDelegate convertToInt = new MyDelegate(ConvertStringToInt);
            //string numberSTR = "35";
            //int valueConverted = convertToInt(numberSTR);
            //Console.WriteLine("Giá trị đã convert thành int: " + valueConverted);
            // Thay vì gọi hàm thì gán biến bằng hàm, và gọi biến đó thôi. hiểu delegate là như vậy

            //MyDelegate showString = new MyDelegate(ShowString);

            //NhapVaShowTen(showString);
            // Ví dụ callback

            #endregion Delegate

            #region Event Delegate

            //a
            //HocSinh hocSinh = new HocSinh();
            //hocSinh.NameChanged += HocSinh_NameChanged;

            //hocSinh.Name = "Test";
            //Console.WriteLine("Tên từ class: " + hocSinh.Name);
            //hocSinh.Name = "HowKteam.com";
            //Console.WriteLine("Tên từ class: " + hocSinh.Name);

            #endregion Event Delegate

            #region Event chuan .Net

            /*
             * Event chuẩn .Net là event với Delegate nhưng thỏa mãn các điều kiện:
             * Delegate có kiểu trả về là void
             * Delegate có hai tham số, tham số thứ nhất có kiểu dữ liệu là object, tham số thứ hai có kiểu EventArgs. object chính là đối tượng phát sinh sự kiện, EventArgs chính là class giữ thông tin mà đối tượng gửi kèm trong quá trình phát sinh sự kiện.
             * Lúc này thay vì chúng ta dùng Delegate do chúng ta tự tạo thì .Net có sẵn Delegate tên là EventHandler theo chuẩn ở trên.
             */
            //SinhVien sinhVien = new SinhVien();
            //sinhVien.NameChange += SinhVien_NameChange;

            //sinhVien.Name = "Thay đổi lần 1";
            //sinhVien.Name = "Thay đổi lần 2";
            //sinhVien.Name = "Thay đổi lần 3";

            #endregion Event chuan .Net

            #region MultiThread

            /*
             *Multi threading có thể hiểu là một kỹ thuật để cùng một lúc xử lý nhiều tác vụ.
             *Bản chất chương trình C# được tạo ra sẽ có hai luồng chạy chính.
             *Luồng thứ nhất là MainThread(luồng chính của chương trình mặc định là hàm Main) và UIThread(luồng cập nhật giao diện).
             */

            for (int i = 0; i < 5; i++)
            {
                int tempI = i;
                Thread t = new Thread(() =>
                {
                    DemoThread("Thread " + tempI);

                    // Invoke cần một đối tượng giao diện để Invoke. Ở đây mình dùng this là form hiện tại.
                    // Bạn có thể dùng control bất kỳ thay thế
                    //Invoke(new Action(() =>
                    //{
                    //    // code của bạn
                    //}));
                });
                t.IsBackground = true; // tắt chương trình, thread sẽ được giải phóng liền
                t.Start();
            }

            #endregion MultiThread
        }

        private static void DemoThread(string threadIndex)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.WriteLine(threadIndex + " - " + i);
            }
        }

        private static void SinhVien_NameChange(object sender, NameChangedEventArgs e)
        {
            Console.WriteLine("Tên có thay đổi: " + e.Name);
        }

        private static void HocSinh_NameChanged(string name)
        {
            Console.WriteLine("Tên mới: " + name);
        }

        public class SinhVien
        {
            private string _Name;

            public string Name
            {
                get => _Name;
                set
                {
                    _Name = value;
                    OnNameChange(value);
                }
            }

            public event EventHandler<NameChangedEventArgs> _NameChanged;

            public event EventHandler<NameChangedEventArgs> NameChange
            {
                add => _NameChanged += value;
                remove => _NameChanged -= value;
            }

            private void OnNameChange(string name)
            {
                if (_NameChanged != null)
                {
                    _NameChanged(this, new NameChangedEventArgs(name));
                }
            }
        }

        public class NameChangedEventArgs : EventArgs
        {
            public string Name { get; set; }

            public NameChangedEventArgs(string name)
            {
                Name = name;
            }
        }

        public class HocSinh
        {
            public event UpdateNameHandler NameChanged;

            private string _Name;

            public string Name
            {
                get => _Name;
                set
                {
                    _Name = value;
                    if (NameChanged != null)
                    {
                        NameChanged(Name);
                    }
                }
            }
        }

        private static void NhapVaShowTen(MyDelegate showTen)
        {
            Console.WriteLine("Mời nhập tên của bạn:");
            string ten = Console.ReadLine();
            showTen(ten);
        }

        private static int ConvertStringToInt(string stringValue)
        {
            int valueInt = 0;

            Int32.TryParse(stringValue, out valueInt);
            Console.WriteLine("Đã ép kiểu dữ liệu thành công");

            return valueInt;
        }

        private static int ShowString(string stringValue)
        {
            Console.WriteLine(stringValue);
            return 0;
        }

        public void Sort(IComparer comparer)
        {
            /* Mình sử dụng thuật toán sắp xếp đơn giản nhất nhé.
            * Còn thực sự hàm Sort của .NET sử dụng thuật toán khác nha.
            */
            ArrayList array = new ArrayList();

            int count = array.Count;
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    /* Nếu phần tử i bé hơn phần tử j thì thực hiện hoán đổi vị trí 2 phần tử này */
                    if (comparer.Compare(array[i], array[j]) > 0)
                    {
                        object tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
        }

        /// <summary>
        /// Phương thức trả về 1 Tuple có 3 thuộc tính (cả 3 đều có kiểu dữ liệu là int)
        /// </summary>
        /// <returns></returns>
        private static Tuple<int, int, int> GetCurrentDayMonthYear()
        {
            DateTime now = DateTime.Now; // lấy ngày giờ hiện tại của hệ thống.
            /* Sử dụng Constructor của Tuple<> để trả về hoặc có thể sử dụng phương thức Create đã trình bày ở trên. */
            return new Tuple<int, int, int>(now.Day, now.Month, now.Year);
        }

        // Dùng Generic
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public class PersonComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                // Ép kiểu 2 object truyền vào về Persin
                Person a = x as Person;
                Person b = y as Person;

                if (a == null || b == null)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    if (a.Age > b.Age)
                    {
                        return 1;
                    }
                    else if (a.Age == b.Age)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }

        public class SortPersons : IComparer
        {
            public int Compare(object x, object y)
            {
                // Ép kiểu 2 object truyền vào về Persin
                Person p1 = x as Person;
                Person p2 = y as Person;

                if (p1 == null || p2 == null)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    if (p1.Age < p2.Age)
                    {
                        return 1;
                    }
                    else if (p1.Age > p2.Age)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }
    }
}