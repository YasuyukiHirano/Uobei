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
    /// Dezart.xaml の相互作用ロジック
    /// </summary>
    public partial class Dezart : Page
    {
        public Dezart()
        {
            InitializeComponent();
        }

        #region ボタン編集

        //デザートから握りへ
        private void DezartNigiri_Click(object sender, RoutedEventArgs e)
        {
            var nigiri = new Nigiri();
            NavigationService.Navigate(nigiri);
        }

        //デザートから軍艦へ
        private void DezartGun_Click(object sender, RoutedEventArgs e)
        {
            var gunkan = new Gunkan();
            NavigationService.Navigate(gunkan);
        }

        //デザートからサイドメニューへ
        private void DezartSaido_Click(object sender, RoutedEventArgs e)
        {
            var saido = new Saido();
            NavigationService.Navigate(saido);
        }

        //デザートから会計確認へ
        private void DezartCash_Click(object sender, RoutedEventArgs e)
        {
            var cash = new Cash();
            NavigationService.Navigate(cash);
        }

        //デザートから注文へ
        private void DezartChumon_Click(object sender, RoutedEventArgs e)
        {
            var check = new Check();
            NavigationService.Navigate(check);
        }

        //デザートから前へ
        private void DezartFront_Click(object sender, RoutedEventArgs e)
        {
            var saido = new Saido();
            NavigationService.Navigate(saido);
        }

        //デザートから次へ
        private void DezartBack_Click(object sender, RoutedEventArgs e)
        {
            var nigiri = new Nigiri();
            NavigationService.Navigate(nigiri);
        }
        #endregion

        //データベース
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Uobei.SushiOrderDBDataSet sushiOrderDBDataSet = ((Uobei.SushiOrderDBDataSet)(this.FindResource("sushiOrderDBDataSet")));
            // テーブル 商品テーブル にデータを読み込みます。必要に応じてこのコードを変更できます。
            Uobei.SushiOrderDBDataSetTableAdapters.商品テーブルTableAdapter sushiOrderDBDataSet商品テーブルTableAdapter = new Uobei.SushiOrderDBDataSetTableAdapters.商品テーブルTableAdapter();
            sushiOrderDBDataSet商品テーブルTableAdapter.Fill(sushiOrderDBDataSet.商品テーブル);
            System.Windows.Data.CollectionViewSource 商品テーブルViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("商品テーブルViewSource")));
            商品テーブルViewSource.View.MoveCurrentToFirst();
        }
    }
}
