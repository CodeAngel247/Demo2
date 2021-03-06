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

namespace Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private CollectionViewSource itemCollectionViewSource;
        public CollectionViewSource ItemCollectionViewSource
        {
            get { return itemCollectionViewSource; }
            set { itemCollectionViewSource = value; }
        }


        public MainWindow()
        {
            InitializeComponent();


            List<SomeInfo> arrSomeInfo;

            arrSomeInfo = new List<SomeInfo>() 
                {
                new SomeInfo(){ ID="3", Title="test", ViewCount="55"},
                new SomeInfo(){ ID="3", Title="test", ViewCount="55"},
                new SomeInfo(){ ID="3", Title="test", ViewCount="55"},
                new SomeInfo(){ ID="3", Title="test", ViewCount="55"},
                };

            CollectionViewSource itemCollectionViewSource;
            itemCollectionViewSource = (CollectionViewSource)(FindResource("ItemCollectionViewSource"));
            itemCollectionViewSource.Source = arrSomeInfo;

            this.MyGrid.ItemsSource = arrSomeInfo; 
            this.MyGrid.DataContext = arrSomeInfo;  
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            var data = new SomeInfo
            {
                ID = IDTextbox.Text,
                Title = TitleTextbox.Text,
                ViewCount = ViewCountTextbox.Text
            };

            MyGrid.Items.Add(data);
        }

    }

        public class SomeInfo
        {
            public string ID {get;set;}
            public string Title {get;set;}
            public string ViewCount {get;set;}
        }

}
