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
    /// Saido.xaml の相互作用ロジック
    /// </summary>
    public partial class Saido : Page
    {
        public Saido()
        {
            InitializeComponent();
        }

        #region ボタン編集

        //サイドメニューから握りへ
        private void SaidoNigiri_Click(object sender, RoutedEventArgs e)
        {
            var nigiri = new Nigiri();
            NavigationService.Navigate(nigiri);
        }

        //サイドメニューから軍艦へ
        private void SaidoGun_Click(object sender, RoutedEventArgs e)
        {
            var gunkan = new Gunkan();
            NavigationService.Navigate(gunkan);
        }

        //サイドメニューからデザートへ
        private void SaidoDezart_Click(object sender, RoutedEventArgs e)
        {
            var dezart = new Dezart();
            NavigationService.Navigate(dezart);
        }

        //サイドからサイドへ
        private void SaidoSaido_Click(object sender, RoutedEventArgs e)
        {
            var saido = new Saido();
            NavigationService.Navigate(saido);
        }

        //サイドから会計確認へ
        private void SaidoCash_Click(object sender, RoutedEventArgs e)
        {
            var cash = new Cash();
            NavigationService.Navigate(cash);
        }

        //サイドから注文へ
        private void SaidoChumon_Click(object sender, RoutedEventArgs e)
        {
            var check = new Check();
            NavigationService.Navigate(check);
        }

        //サイドメニューから前へ
        private void SaidoFront_Click(object sender, RoutedEventArgs e)
        {
            var gunkan = new Gunkan();
            NavigationService.Navigate(gunkan);
        }

        //サイドメニューから次へ
        private void SaidoBack_Click(object sender, RoutedEventArgs e)
        {
            var dezart = new Dezart();
            NavigationService.Navigate(dezart);
        }
        #endregion
    }
}
