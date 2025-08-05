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




            #endregion


        }
    }
}
