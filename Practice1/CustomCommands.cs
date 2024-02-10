using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Practice1
{
    class CustomCommands
    {
        public static RoutedUICommand Launch { get; }

        static CustomCommands()
        { 
            InputGestureCollection inputCollection = new InputGestureCollection();
            inputCollection.Add(new KeyGesture(Key.L, ModifierKeys.Control));
            Launch = new RoutedUICommand("Запуск", "Launch", typeof(CustomCommands), inputCollection);
        }

    }
}
