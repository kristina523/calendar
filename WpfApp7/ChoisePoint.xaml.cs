using System.Windows;

namespace WpfApp7
{
    public partial class ChoisePoint : Window
    {
        public ChoisePoint()
        {
            InitializeComponent();
            DataContext = new ChoisePointViewModel(); 
        }
    }
}