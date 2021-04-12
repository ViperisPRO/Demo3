using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace DEMO_03
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private List<Sklad> _MyVw_ProductDetails;

        public List<Sklad> MyVw_ProductDetails

        {
            get
            {
                return _MyVw_ProductDetails; 
            }
            set
            {
                _MyVw_ProductDetails = value;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            MyVw_ProductDetails = Core.DB.Sklad.ToList(); 
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private string _SearchFilter = "";
        public string SearchFilter
        {
            get
            {
                return _SearchFilter;
            }
            set
            {
                _SearchFilter = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("MyVw_ProductDetails"));
                    // PropertyChanged(this, new PropertyChangedEventArgs("FilteredProductsCount"));
                }
            }
        }

        private void SearchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            SearchFilter = SearchTextBox.Text;
        }
      }
}
