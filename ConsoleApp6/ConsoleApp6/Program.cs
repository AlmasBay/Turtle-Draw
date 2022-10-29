using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace ConsoleApp6
{
    class Program
    {
        static int speed = 10;

        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            while (true)
            {
                Turtle.Speed = speed;
                Turtle.Move(10);
                
            }







            Console.ReadLine();
        }

        private static void GraphicsWindow_KeyDown()
        {

            if (GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;

            }
            else if (GraphicsWindow.LastKey == "Right")
            {

                Turtle.Angle = 90;

            }
            else if (GraphicsWindow.LastKey == "Down")
            {

                Turtle.Angle = 180;

            }
            else if (GraphicsWindow.LastKey == "Left")
            {

                Turtle.Angle = 270;

            }
            else if (GraphicsWindow.LastKey == "W")
            {

                Turtle.Angle = 45;
            }
            else if (GraphicsWindow.LastKey == "S")
            {

                Turtle.Angle = 115;

            }
            else if (GraphicsWindow.LastKey == "A")
            {

                Turtle.Angle = 290;

            }
            else if (GraphicsWindow.LastKey == "D")
            {


                Turtle.Angle = 210;

            }
            else if (GraphicsWindow.LastKey == "Z")
            {

                speed = + 4;

            }
            else if (GraphicsWindow.LastKey == "X")
            {

                speed = - 2;

            }
        } 









    } 
    
    
         

   

}



