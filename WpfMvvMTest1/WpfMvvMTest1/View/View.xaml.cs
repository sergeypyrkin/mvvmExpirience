﻿using System;
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
using WpfMvvMTest1.Test;

namespace WpfMvvMTest1.View
{
    /// <summary>
    /// Логика взаимодействия для View.xaml
    /// </summary>
    public partial class View : Window
    {
        public View()
        {
            InitializeComponent();
            r(new test1());
            r(new test1());

        }

        //public IEnumerable<string> test
        //{
        //    get
        //    {
        //        return  IEnumerable<string>() {"1", "2"};
        //    }
        //}

        public ITest r(ITest x)
        {
            x.run();
            return new test1();
        }
    }
}
