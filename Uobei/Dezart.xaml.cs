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

        #region 初期値設定
        int itemCnt = 0;
        int itemCnt19 = 0;
        int itemCnt20 = 0;
        int itemCnt21 = 0;
        int itemCnt22 = 0;
        int itemCnt23 = 0;
        int itemCnt24 = 0;
        #endregion

        #region データベース
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Uobei.SushiOrderDBDataSet sushiOrderDBDataSet = ((Uobei.SushiOrderDBDataSet)(this.FindResource("sushiOrderDBDataSet")));
            // テーブル 商品テーブル にデータを読み込みます。必要に応じてこのコードを変更できます。
            Uobei.SushiOrderDBDataSetTableAdapters.商品テーブルTableAdapter sushiOrderDBDataSet商品テーブルTableAdapter = new Uobei.SushiOrderDBDataSetTableAdapters.商品テーブルTableAdapter();
            sushiOrderDBDataSet商品テーブルTableAdapter.Fill(sushiOrderDBDataSet.商品テーブル);
            System.Windows.Data.CollectionViewSource 商品テーブルViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("商品テーブルViewSource")));
            商品テーブルViewSource.View.MoveCurrentToFirst();
        }
        #endregion

        #region ボタン編集

        //デザートから握りへ
        private void DezartNigiri_Click(object sender, RoutedEventArgs e)
        {
            var nigiri = new Menu();
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
            var nigiri = new Menu();
            NavigationService.Navigate(nigiri);
        }

        #endregion

        #region プリン注文
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (itemCnt < 4)
            {
                if (ListBox7.Items.Contains("プリン") != true)
                {
                    itemCnt19++;
                    ListBox7.Items.Add("プリン");
                    ListBox8.Items.Add(itemCnt19);
                    itemCnt++;
                }
                else if (ListBox7.Items.Contains("プリン") == true)
                {
                    ListBox7.Items.Remove("プリン");
                    ListBox8.Items.Remove(itemCnt19);
                    itemCnt19++;
                    ListBox7.Items.Add("プリン");
                    ListBox8.Items.Add(itemCnt19);
                    itemCnt++;
                }
            }
            else
            {
                MessageBox.Show("一度に4皿まで注文できます。");

                var check = new Check();
                NavigationService.Navigate(check);
            }
        }
        #endregion

        #region チョコレートケーキ注文
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (itemCnt < 4)
            {
                if (ListBox7.Items.Contains("チョコレートケーキ") != true)
                {
                    itemCnt20++;
                    ListBox7.Items.Add("チョコレートケーキ");
                    ListBox8.Items.Add(itemCnt20);
                    itemCnt++;
                }
                else if (ListBox7.Items.Contains("チョコレートケーキ") == true)
                {
                    ListBox7.Items.Remove("チョコレートケーキ");
                    ListBox8.Items.Remove(itemCnt20);
                    itemCnt20++;
                    ListBox7.Items.Add("チョコレートケーキ");
                    ListBox8.Items.Add(itemCnt20);
                    itemCnt++;
                }
            }
            else
            {
                MessageBox.Show("一度に4皿まで注文できます。");

                var check = new Check();
                NavigationService.Navigate(check);
            }
        }
        #endregion

        #region ソフトクリーム注文
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (itemCnt < 4)
            {
                if (ListBox7.Items.Contains("ソフトクリーム") != true)
                {
                    itemCnt21++;
                    ListBox7.Items.Add("ソフトクリーム");
                    ListBox8.Items.Add(itemCnt21);
                    itemCnt++;
                }
                else if (ListBox7.Items.Contains("ソフトクリーム") == true)
                {
                    ListBox7.Items.Remove("ソフトクリーム");
                    ListBox8.Items.Remove(itemCnt21);
                    itemCnt21++;
                    ListBox7.Items.Add("ソフトクリーム");
                    ListBox8.Items.Add(itemCnt21);
                    itemCnt++;
                }
            }
            else
            {
                MessageBox.Show("一度に4皿まで注文できます。");

                var check = new Check();
                NavigationService.Navigate(check);
            }
        }
        #endregion

        #region コーラ注文
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (itemCnt < 4)
            {
                if (ListBox7.Items.Contains("コーラ") != true)
                {
                    itemCnt22++;
                    ListBox7.Items.Add("コーラ");
                    ListBox8.Items.Add(itemCnt22);
                    itemCnt++;
                }
                else if (ListBox7.Items.Contains("コーラ") == true)
                {
                    ListBox7.Items.Remove("コーラ");
                    ListBox8.Items.Remove(itemCnt22);
                    itemCnt22++;
                    ListBox7.Items.Add("コーラ");
                    ListBox8.Items.Add(itemCnt22);
                    itemCnt++;
                }
            }
            else
            {
                MessageBox.Show("一度に4皿まで注文できます。");

                var check = new Check();
                NavigationService.Navigate(check);
            }
        }
        #endregion

        #region グレープジュース注文
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (itemCnt < 4)
            {
                if (ListBox7.Items.Contains("グレープジュース") != true)
                {
                    itemCnt23++;
                    ListBox7.Items.Add("グレープジュース");
                    ListBox8.Items.Add(itemCnt23);
                    itemCnt++;
                }
                else if (ListBox7.Items.Contains("グレープジュース") == true)
                {
                    ListBox7.Items.Remove("グレープジュース");
                    ListBox8.Items.Remove(itemCnt23);
                    itemCnt23++;
                    ListBox7.Items.Add("グレープジュース");
                    ListBox8.Items.Add(itemCnt23);
                    itemCnt++;
                }
            }
            else
            {
                MessageBox.Show("一度に4皿まで注文できます。");

                var check = new Check();
                NavigationService.Navigate(check);
            }
        }
        #endregion

        #region アップルジュース
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (itemCnt < 4)
            {
                if (ListBox7.Items.Contains("アップルジュース") != true)
                {
                    itemCnt24++;
                    ListBox7.Items.Add("アップルジュース");
                    ListBox8.Items.Add(itemCnt24);
                    itemCnt++;
                }
                else if (ListBox7.Items.Contains("アップルジュース") == true)
                {
                    ListBox7.Items.Remove("アップルジュース");
                    ListBox8.Items.Remove(itemCnt24);
                    itemCnt24++;
                    ListBox7.Items.Add("アップルジュース");
                    ListBox8.Items.Add(itemCnt24);
                    itemCnt++;
                }
            }
            else
            {
                MessageBox.Show("一度に4皿まで注文できます。");

                var check = new Check();
                NavigationService.Navigate(check);
            }
        }
        #endregion
    }
}
