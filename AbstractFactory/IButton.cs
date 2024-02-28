using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAndAbstractFactory.AbstaractFactory
{
    public interface IButton
    {
        void Click();
    }

    public interface ITextBox
    {
        void Type();
    }

    class WindowsButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("Windows Button is clicked");
        }
    }

    class WindowsTextBox : ITextBox
    {
        public void Type()
        {
            Console.WriteLine("Windows TextBox is typed");
        }
    }

    class MacButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("Mac Button is clicked");
        }
    }

    class MacTextBox : ITextBox
    {
        public void Type()
        {
            Console.WriteLine("Mac TextBox is typed");
        }
    }

    public interface IGuiFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }

    class WindowsGuiFactory : IGuiFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ITextBox CreateTextBox()
        {
            return new WindowsTextBox();
        }
    }

    class MacGuiFactory : IGuiFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ITextBox CreateTextBox()
        {
            return new MacTextBox();
        }
    }

    
}
