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

namespace Uobei
{
    /// <summary>
    /// Top.xaml の相互作用ロジック
    /// </summary>
    public partial class Top : Page
    {
        public Top()
        {
            InitializeComponent();
        }

        #region ボタン編集

        //握りボタン
        private void MainNigiri_Click(object sender, RoutedEventArgs e)
        {
            var nigiri = new Nigiri();
            NavigationService.Navigate(nigiri);
        }

        //軍艦ボタン
        private void MainGun_Click(object sender, RoutedEventArgs e)
        {
            var gunkan = new Gunkan();
            NavigationService.Navigate(gunkan);
        }

        //サイドメニューボタン
        private void MainSaido_Click(object sender, RoutedEventArgs e)
        {
            var saido = new Saido();
            NavigationService.Navigate(saido);
        }

        //デザートボタン
        private void MainDezart_Click(object sender, RoutedEventArgs e)
        {
            var dezart = new Dezart();
            NavigationService.Navigate(dezart);
        }

        //会計確認ボタン
        private void MainCash_Click(object sender, RoutedEventArgs e)
        {
            var cash = new Cash();
            NavigationService.Navigate(cash);
        }
        #endregion
    }
}
