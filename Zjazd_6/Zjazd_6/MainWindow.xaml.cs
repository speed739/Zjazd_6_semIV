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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zjazd_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double Glosy { get; set; } = 0;
        public int A { get; set; } = 0;
        public int B { get; set; } = 0;
        public int C { get; set; } = 0;
        public int D { get; set; } = 0;
        public double maxH
        {
            get => canvas.Height;
        }
        public double udzial { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("Zagłosuj  A,B,C lub D !!! ", "Głosowanie", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Aktualizacja_wysokosci()
        {
            Canvas.SetTop(rec_A, maxH - ((A/Glosy) * maxH)); 
            Canvas.SetTop(rec_B, maxH - ((B/Glosy) * maxH)); 
            Canvas.SetTop(rec_C, maxH - ((C/Glosy) * maxH));
            Canvas.SetTop(rec_D, maxH - ((D/Glosy) * maxH));

        }
        private void Button_Click_A(object sender, RoutedEventArgs e)
        {
            ++A;
            ++Glosy;
            udzial = A / Glosy;
            rec_A.Height = maxH * udzial;
            Aktualizacja_wysokosci();
            
            lb_wszystkie_glosy.Content = Glosy.ToString();
            lb_a.Content = A.ToString();
        }

        private void Button_Click_B(object sender, RoutedEventArgs e)
        {
            ++B;
            ++Glosy;
            udzial = B / Glosy;
            rec_B.Height = maxH * udzial;
            Aktualizacja_wysokosci();

            lb_wszystkie_glosy.Content = Glosy.ToString();
            lb_b.Content = B.ToString();
        }

        private void Button_Click_C(object sender, RoutedEventArgs e)
        {
            ++C;
            ++Glosy;
            udzial = C / Glosy;
            rec_C.Height = maxH * udzial;
            Aktualizacja_wysokosci();

            lb_wszystkie_glosy.Content = Glosy.ToString();
            lb_c.Content = C.ToString();
        }

        private void Button_Click_D(object sender, RoutedEventArgs e)
        {
            ++D;
            ++Glosy;
            udzial = D / Glosy;
            rec_D.Height = maxH * udzial;
            Aktualizacja_wysokosci();

            lb_wszystkie_glosy.Content = Glosy.ToString();
            lb_d.Content = D.ToString();
        }
    }
}



