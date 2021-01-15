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
using System.Windows.Shapes;

namespace Uobei
{
    /// <summary>
    /// Nigiri.xaml の相互作用ロジック
    /// </summary>
    public partial class Nigiri : Page
    {
        public Nigiri()
        {
            InitializeComponent();
        }

        #region ボタン編集

        //握りから軍艦へ
        private void NigiriGun_Click(object sender, RoutedEventArgs e)
        {
            var gunkan = new Gunkan();
            NavigationService.Navigate(gunkan);
        }

        //握りからサイドへ
        private void NigiriSaido_Click(object sender, RoutedEventArgs e)
        {
            var saido = new Saido();
            NavigationService.Navigate(saido);
        }

        //握りからデザートへ
        private void NigiriDezart_Click(object sender, RoutedEventArgs e)
        {
            var dezart = new Dezart();
            NavigationService.Navigate(dezart);
        }

        //握りから会計確認へ
        private void NigiriCash_Click(object sender, RoutedEventArgs e)
        {
            var cash = new Cash();
            NavigationService.Navigate(cash);
        }

        //握りから注文へ
        private void NigiriChumon_Click(object sender, RoutedEventArgs e)
        {
            var check = new Check();
            NavigationService.Navigate(check);
        }

        //握り前へ
        private void NigiriFront_Click(object sender, RoutedEventArgs e)
        {
            var dezart = new Dezart();
            NavigationService.Navigate(dezart);
        }

        //握り次へ
        private void NigiriBack_Click(object sender, RoutedEventArgs e)
        {
            var gunkan = new Gunkan();
            NavigationService.Navigate(gunkan);
        }
        #endregion
    }
}
