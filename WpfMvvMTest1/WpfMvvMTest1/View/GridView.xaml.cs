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
using WpfMvvMTest1.ViewModel;

namespace WpfMvvMTest1.View
{
    /// <summary>
    /// Логика взаимодействия для GridView.xaml
    /// </summary>
    public partial class GridView : Window
    {

        public GridViewViewModel gv = null;
        public GridView()
        {
            InitializeComponent();
        }

        public GridView(string number)
        {
            InitializeComponent();
            gv = new GridViewViewModel(number);
            this.DataContext = gv;
        }

        private void GridMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            gv.Command_GridView_MouseDoubleDown.Execute(new object[] { sender, e });
        }


        private void GridView_MouseDown(object sender, MouseButtonEventArgs e)
        {
            gv.CommandGridView_MouseDown.Execute(new object[] { sender, e });
        }
    }
}
