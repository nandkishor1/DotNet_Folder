using System;


namespace DelegatesProject
{
    class Rectangle
    {
        public delegate void RectDelegate(double Width, double Height);
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine("Area  of Reactangle: " +  Width * Height);
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("Perimeter  of Reactangle " + 2 * (Width + Height));
        }
        static void Main()
        {
            Rectangle rect = new Rectangle();
            //RectDelegate obj = new RectDelegate(rect.GetArea);
            RectDelegate obj = rect.GetArea;
            obj += rect.GetPerimeter;
            obj.Invoke(45.5, 2.36);
            Console.WriteLine();
            obj.Invoke(10.25, 25.32);

           
            Console.ReadLine();
        }
    }

}
