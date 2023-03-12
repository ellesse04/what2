using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace pm2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public List<List<int>> toMatrix(List<int> data)
        {
            data.RemoveAt(0);
            List<List<int>> G = new List<List<int>>();
            int size = Convert.ToInt32(Math.Sqrt(data.Count()));
            for (int i = 0; i < size; i++)
                G.Add(new List<int> (size));

            int cnt = 0;
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    G[i].Add(data[cnt++]);

            return G;
        }

        public struct Pair
        {
            public int a;
            public int b;
        }

        public List<Pair> toList(List<int> data)
        {
            int n = data[0];
            int m = data[1];
            data.RemoveAt(0);
            data.RemoveAt(0);
            
            List<Pair> G = new List<Pair>(0);
            for(int i = 0; i < data.Count(); i=i+2)
            {
                Pair a = new Pair();
                a.a = data[i];
                a.b = data[i+1];

                G.Add(a);
            }

            return G;
        }

        public Window1(List<int> data)
        {
            InitializeComponent();
            List<Pair> g = toList(data);
            List<List<int>> gg = toMatrix(data);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Close();
        }
    }
}
