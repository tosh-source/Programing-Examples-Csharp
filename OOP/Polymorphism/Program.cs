using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use most base class available to hold different functionality. In this case we use base class "Control"
            Control firstConstrol = new Control();
            firstConstrol.Draw();

            Control secondControl = new Button();
            Console.WriteLine();
            secondControl.Draw();                   //Polymorphism in action. Base class "Control" wrap his successor class "Button", but can provide method FROM class "Button".

            Control thirdControl = new RadioButton();
            Console.WriteLine();
            thirdControl.Draw();

            //Collection of different controls
            Control[] controls =
                {
                    new Menus(),
                    new Button(),
                    new RadioButton(),
                    new Control()
                };

            foreach (var control in controls)
            {
                Console.WriteLine();
                control.Draw();
            }
        }
    }

    public class Control
    {
        public virtual void Draw()
        {
            Console.WriteLine("Control.Draw()");
        }
    }

    public class Button : Control
    {
        public override void Draw()                 //Polymorphism is possible when we override/implement virtual methods come from base class. Then base class can access methods from it's 
        {
            Console.WriteLine("Button.Draw()");
            base.Draw();                            //Optional, if we want to access base class implementation.
        }
    }

    public class RadioButton : Button
    {
        public override void Draw()
        {
            Console.WriteLine("RadioButton.Draw()");
            base.Draw();                            //Optional, if we want to access base class implementation.
        }
    }

    public class Menus : Control
    {
        public override void Draw()
        {
            Console.WriteLine("Menus.Draw()");
        }
    }
}
