using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using wpf_tomsk_asu.ViewModels;

namespace wpf_tomsk_asu
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void aTB_TextChanged(object sender, TextChangedEventArgs e)
            => TextValidator(sender, e);
        private void bTB_TextChanged(object sender, TextChangedEventArgs e)
            => TextValidator(sender, e);
        private void yTB_TextChanged(object sender, TextChangedEventArgs e)
            => TextValidator(sender, e);
        private void xTB_TextChanged(object sender, TextChangedEventArgs e)
            => TextValidator(sender, e);
        // TextValidator запрещает писать в текстбоксы все кроме чисел:)
        private void TextValidator(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox)  
                textBox.Text = new string
                    (
                        textBox
                            .Text
                            .Where(c => c >= '0' && c <= '9')
                            .ToArray()
                    );
        }

        LinkedList<int> vs = new LinkedList<int>();
        private void fucnCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (vs != null&&vs.Count>1)
            {
                varCB.SelectedIndex = vs.Last.Previous.Value;
            }
        }

        private void varCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vs.AddLast(varCB.SelectedIndex);
        }
    }
}
