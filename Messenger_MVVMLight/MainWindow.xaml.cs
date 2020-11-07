using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Messenger_MVVMLight
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static int _counter;

        public MainWindow()
        {
            InitializeComponent();
            Messenger.Default.Register<BaseEvent>(this, OnBaseEvent);
            Messenger.Default.Register<BaseEvent>(this, OnDerivedEventOne);
            Messenger.Default.Register<DerivedEventTwo>(this, OnDerivedEventTwo);
        }


        private void btnBase_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<BaseEvent>(new BaseEvent(_counter++));
        }
        private void btnDerivedOne_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<BaseEvent>(new DerivedEventOne(_counter, $"D1#_counter"));
            _counter++;
        }
        private void btnDerivedTwo_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<DerivedEventTwo>(new DerivedEventTwo(_counter,$"D2#_counter"));
            _counter++;
        }

        private void OnBaseEvent(BaseEvent be)
        {
            switch (be)
            {
                case DerivedEventOne derivedEventOne:
                    {
                    tbBase.Text += derivedEventOne.ToString() + "\n";
                    }
                    break;
                case DerivedEventTwo derivedEventTwo:
                    {
                    tbBase.Text += derivedEventTwo.ToString() + "\n";
                    }
                    break;
                case BaseEvent baseEvent:
                     tbBase.Text += baseEvent.ToString()+"\n";
                    break;
                default:
                    break;
            }

        }


        private void OnDerivedEventOne(BaseEvent be)
        {
            if (be is DerivedEventOne derivedEventOne)
            tbDerivedOne.Text += derivedEventOne.ToString() + "\n";
        }
        private void OnDerivedEventTwo(DerivedEventTwo derivedEventTwo)
        {

                tbDerivedTwo.Text += derivedEventTwo.ToString() + "\n";
        }

    }
}
