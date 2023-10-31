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
    /// Логика взаимодействия для MyTextBox.xaml
    /// </summary>
    public partial class MyTextBox : UserControl
    {
        public MyTextBox()
        {
            InitializeComponent();
        }

        public string Hint
        {
            get { return (string)GetValue(HitProperty); }
            set { SetValue(HitProperty, value); }
        }

        public static readonly DependencyProperty HitProperty = DependencyProperty.Register
            ("Hint", typeof(string), typeof(MyTextBox));
    }
}
