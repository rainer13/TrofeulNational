using System;
using System.Collections.Generic;
using System.Windows;

namespace TrofeulNational.Apps
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class EchipeOutput : Window
    {
        public EchipeOutput()
        {
            InitializeComponent();
        }

        public void Show(List<Echipa> echipe)
        {
            Console.WriteLine(this.GetType().ToString());
            Console.WriteLine(listaEchipe1.GetType().ToString());
            listaEchipe1.
        }

        public void print(List<Echipa> echipe)
        {
            Console.WriteLine(this.GetType().ToString());
            foreach (Echipa ee in echipe)
                Console.WriteLine(ee.getNume());
        }
    }
}
