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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ululo.Controls
{
    /// <summary>
    /// Логика взаимодействия для Classes.xaml
    /// </summary>
    public partial class Classes : UserControl
    {
        public Classes()
        {
            InitializeComponent();
        }

        public string NameClass
        {
            get { return (string)GetValue(NameClassProperty); }
            set { SetValue(NameClassProperty, value); }
        }

        public static readonly DependencyProperty NameClassProperty = DependencyProperty.Register
            ("NameClass", typeof(string), typeof(Classes));

        public string Office
        {
            get { return (string)GetValue(OfficeProperty); }
            set { SetValue(OfficeProperty, value); }
        }

        public static readonly DependencyProperty OfficeProperty = DependencyProperty.Register
            ("Office", typeof(string), typeof(Classes));
    }
}
