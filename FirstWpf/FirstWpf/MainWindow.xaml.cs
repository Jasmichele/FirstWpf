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

namespace FirstWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            if(sender.GetType() == typeof(CheckBox))
            {
                CheckBox cb = (CheckBox)sender;
                if (cb.Name == checkBox1.Name)
                    MessageBox.Show("RULES!!");

                Grid parent = (Grid)cb.Parent;

                if(parent != null)
                    foreach(object obj in parent.Children)
                    {
                        CheckBox newCb = obj as CheckBox;
                        if (newCb != null)
                        {
                            if (newCb.Name != cb.Name)
                                newCb.IsChecked = false;
                        }
                    }

                if (cb.Name == checkBox2.Name)
                    MessageBox.Show("BOOOOOOOOOOO");

                
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBoxTop.Text = "This is awesome!!";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void textBoxTop_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if(sender.GetType() == typeof(MenuItem))
            {
                MenuItem mI = (MenuItem)sender;
                if (mI.Name == topp1.Name)
                    MessageBox.Show("That's YOU");

                if (mI.Name == top2.Name)
                    MessageBox.Show("SORRY");

                if (mI.Name == top3.Name)
                    MessageBox.Show("Adios'");
            }
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slide = sender as Slider;
            textBox2.Text = slide.Value.ToString();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
