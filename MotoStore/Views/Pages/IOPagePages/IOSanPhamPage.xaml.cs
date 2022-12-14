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
using Microsoft.Win32;
using MotoStore.Databases;

namespace MotoStore.Views.Pages.IOPagePages
{
    /// <summary>
    /// Interaction logic for IOSanPhamPage.xaml
    /// </summary>
    public partial class IOSanPhamPage : Page
    {
        
        public IOSanPhamPage()
        {
            InitializeComponent();
            
            var products = GetProducts();
            if (products.Count > 0)
                ListViewProduct.ItemsSource = products;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }
        
        private List<Product> GetProducts()
        {
           MainDatabase db = new MainDatabase();
            List<Product> listproducts = new List<Product>();
            foreach (var dbproduct in db.MatHangs.ToList())
                listproducts.Add(new Product(dbproduct.TenMh));
            return new List<Product>()
            {
                
            };
        }
        private void btnAddNewSP_Click(object sender, RoutedEventArgs e)
        {
            IOAddSP ioAddSP = new IOAddSP();
            NavigationService.Navigate(ioAddSP);

        }
        //Khi ấn vào nút này, sẽ hiện Page IOAddSp để thêm 1 sản phẩm mới !

    }
}
