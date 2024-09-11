using DTS_CSharp_NangCao;
using System;
using System.Collections;

namespace DTS_CSharp_NangCap
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Khởi tạo ArrayList

            ArrayList arrayList = new ArrayList(); // Khởi tạo 1 arraylist rỗng

            ArrayList arrayList2 = new ArrayList(5); //Khởi tạo 1 arraylist và chỉ định capacity ban đầu là 5

            /* Khởi tạo 1 arraylist có kích thường bằng arrayList2
            * Sao chép toàn bộ phần tử trong arrayList2 vào arrayList3
            * 2 thằng khác vùng nhớ nên thay đổi k ảnh hưởng
            */
            ArrayList arrayList3 = new ArrayList(arrayList2);

            /*
             * Kiểu dữ liệu tham chiếu.
             * Array4 tham  chiếu tới giá trị tới array2
             * 2 thằng cùng chỉ, trỏ đến 1 giá trị của bộ nhớ nên khi 1 thằng thay đổi, thằng kia sẽ thay đổi theo.
             * array4 thay đổi thì array2 nhận giá trị thay đổi đó, và ngược lại
             */
            ArrayList arrayList4 = arrayList2;

            #endregion Khởi tạo ArrayList

            #region Sắp xếp

            // Tạo ds rỗng
            ArrayList arrPersons = new ArrayList();

            // Thêm phần tử vào ds
            arrPersons.Add(new Person("Do Thanh Sang", 29));
            arrPersons.Add(new Person("Nguyen Van B", 34));
            arrPersons.Add(new Person("Le van C", 23));
            arrPersons.Add(new Person("Ho van D", 37));

            //In thử ds ra màn hình
            Console.WriteLine("Danh sach Person ban dau: ");
            foreach (Person person in arrPersons)
            {
                Console.WriteLine(person.ToString());
            }

            /*
             * Thực hiện sắp xếp
             * Trong phướng thức Compare của lớp SortPerson (tuổi tăng dần)
             */

            arrPersons.Sort(new SortPersons());

            // In ra màn hình kq
            Console.WriteLine();
            Console.WriteLine("Danh sach Person duoc tra ve theo kieu tang dan: ");
            foreach (Person person in arrPersons)
            {
                Console.WriteLine(person.ToString());
            }

            #endregion Sắp xếp

            Console.WriteLine("Hello World!");
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