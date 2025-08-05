using Demo.SelfStudy;

namespace Demo
{
    internal class Program
    {
        static void Move(IMoveable moveable)
        {
            moveable.Move();
        }
        static void Main(string[] args)
        {
            #region 
            //string str = "1a3";
            //int x;
            //int.TryParse(str, out x); 

            //Employee e1 = new Employee() { Id = 10, Name = "Mena" }; 
            #endregion

            #region Generic
            /// int[] arr = { 1, 2, 3, 4, 5 };
            /// 
            /// MyCollection<int> myCollection = new MyCollection<int>();
            /// 
            /// MyCollection<string> myCollection1;
            /// 
            /// myCollection.Add(1);
            /// myCollection.Add(2);
            /// myCollection.Add(3);
            /// myCollection.Add(4);
            /// myCollection.Add(5);
            /// 
            /// //int n = (int)myCollection.GetByIndex(2);
            /// myCollection.Print();
            #endregion

            #region Interfaces
            #region User Define
            //Humman humman = new Humman();
            //Car car = new Car();

            //Move(humman);
            //Move(car); 
            #endregion

            //int[] numbers = { 2, 589, 56, 823710, 387, 9 };

            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //Employee[] employees = new Employee[]
            //{
            //    new Employee {Id = 2 , Name = "Mena" },
            //    new Employee {Id = 1 , Name = "Ali" },
            //    new Employee {Id = 3 , Name = "Hosam" }
            //};


            //Array.Sort(employees);

            //for (int i = 0; i < employees.Length; i++)
            //{
            //    Console.WriteLine(employees[i]);
            //}

            //Employee e1 = new Employee { Id = 1, Name = "Mena" };
            //Employee e2 = new Employee { Id = 1, Name = "Hamda" };

            //if (e1.CompareTo(e2) == 0) Console.WriteLine("Equals");
            //else Console.WriteLine("Not Equals");
            #endregion

            #region Reimplementing an Interface in a Subclass (Self Study)
            //IUndoable iUndoable = new TextBox();
            //RichTextBox richTextBox = new RichTextBox();

            //((IUndoable)richTextBox).Undo(); //From RichTextBox 
            #endregion

        }
    }
}
