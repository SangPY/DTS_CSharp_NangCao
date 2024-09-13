using DTS_CSharp_NangCao;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DTS_CSharp_NangCap
{
    internal class Program
    {
        private static void Main(string[] args)
        {
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
            Stack MyStack4 = new Stack();

            // Thực hiện thêm vài phần tử vào Stack thông qua hàm Push.
            MyStack4.Push("Education");
            MyStack4.Push("Free");
            MyStack4.Push("HowKteam");

            // Thử sử dụng các phương thức của Stack.
            Console.WriteLine(" So phan tu hien tai cua Stack la: {0}", MyStack4.Count);

            // Lưu ý ở đây ta chỉ muốn xem giá trị mà không muốn nó khỏi Stack thì ta sẽ dùng Peek.
            Console.WriteLine(" Phan tu dau cua Stack la: {0}", MyStack4.Peek());

            // Thử kiểm tra lại số phần tử để chắc chắn rằng hàm Peek không xoá phần tử ra khỏi Stack.
            Console.WriteLine(" So phan tu cua Stack sau khi goi ham Peek: {0}", MyStack4.Count);

            // Thực hiện xoá các phần tử ra khỏi Stack.
            Console.WriteLine(" Popping...");
            int Length = MyStack4.Count;
            for (int i = 0; i < Length; i++)
            {
                Console.Write(" " + MyStack4.Pop());
            }
            Console.WriteLine();

            // Kiểm tra lại số phần tử của Stack sau khi Pop
            Console.WriteLine(" So phan tu cua Stack sau khi Pop la: {0}", MyStack4.Count);

            #endregion Sắp xếp, thuộc tính Stack
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