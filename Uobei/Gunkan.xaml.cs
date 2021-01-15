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
    /// Gunkan.xaml の相互作用ロジック
    /// </summary>
    public partial class Gunkan : Page
    {
        public Gunkan()
        {
            InitializeComponent();
        }

        #region ボタン編集

        //軍艦から握りへ
        private void GunNigiri_Click(object sender, RoutedEventArgs e)
        {
            var nigiri = new Nigiri();
            NavigationService.Navigate(nigiri);
        }

        //軍艦からサイドメニューへ
        private void GunSaido_Click(object sender, RoutedEventArgs e)
        {
            var saido = new Saido();
            NavigationService.Navigate(saido);
        }

        //軍艦からデザートへ
        private void GunDezart_Click(object sender, RoutedEventArgs e)
        {
            var dezart = new Dezart();
            NavigationService.Navigate(dezart);
        }

        //軍艦から会計確認へ
        private void GunCash_Click(object sender, RoutedEventArgs e)
        {
            var cash = new Cash();
            NavigationService.Navigate(cash);
        }

        //軍艦から注文へ
        private void GunChumon_Click(object sender, RoutedEventArgs e)
        {
            var check = new Check();
            NavigationService.Navigate(check);
        }

        //軍艦から前へ
        private void GunFront_Click(object sender, RoutedEventArgs e)
        {
            var nigiri = new Nigiri();
            NavigationService.Navigate(nigiri);
        }

        //軍艦から次へ
        private void GunBack_Click(object sender, RoutedEventArgs e)
        {
            var saido = new Saido();
            NavigationService.Navigate(saido);
        }
        #endregion
    }
}
