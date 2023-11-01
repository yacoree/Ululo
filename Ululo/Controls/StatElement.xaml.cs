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
    /// Логика взаимодействия для StatElement.xaml
    /// </summary>
    public partial class StatElement : UserControl
    {
        public StatElement()
        {
            InitializeComponent();
        }


        public string Activity
        {
            get { return (string)GetValue(ActivityProperty); }
            set { SetValue(ActivityProperty, value); }
        }

        public static readonly DependencyProperty ActivityProperty = DependencyProperty.Register
            ("Activity", typeof(string), typeof(StatElement));

        public string FirstPlase
        {
            get { return (string)GetValue(FirstPlaseProperty); }
            set { SetValue(FirstPlaseProperty, value); }
        }

        public static readonly DependencyProperty FirstPlaseProperty = DependencyProperty.Register
            ("FirstPlase", typeof(string), typeof(StatElement));

        public string SecondPlase
        {
            get { return (string)GetValue(SecondPlaseProperty); }
            set { SetValue(SecondPlaseProperty, value); }
        }

        public static readonly DependencyProperty SecondPlaseProperty = DependencyProperty.Register
            ("SecondPlase", typeof(string), typeof(StatElement));

        public string ThirdPlase
        {
            get { return (string)GetValue(ThirdPlaseProperty); }
            set { SetValue(ThirdPlaseProperty, value); }
        }

        public static readonly DependencyProperty ThirdPlaseProperty = DependencyProperty.Register
            ("ThirdPlase", typeof(string), typeof(StatElement));
    }


    }
