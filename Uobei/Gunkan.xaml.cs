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

        #region 初期値設定用
        int itemCnt = 0;
        int itemCnt7 = 0;
        int itemCnt8 = 0;
        int itemCnt9 = 0;
        int itemCnt10 = 0;
        int itemCnt11 = 0;
        int itemCnt12 = 0;
        #endregion

        #region データベース
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
        #endregion

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

        #region　まぐろたたき注文用
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (itemCnt < 4)
            {
                if (ListBox3.Items.Contains("まぐろたたき") != true)
                {
                    itemCnt7++;
                    ListBox3.Items.Add("まぐろたたき");
                    ListBox4.Items.Add(itemCnt7);
                    itemCnt++;
                }
                else if (ListBox3.Items.Contains("まぐろたたき") == true)
                {
                    ListBox3.Items.Remove("まぐろたたき");
                    ListBox4.Items.Remove(itemCnt7);
                    itemCnt7++;
                    ListBox3.Items.Add("まぐろたたき");
                    ListBox4.Items.Add(itemCnt7);
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

        #region　いくら注文用
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (itemCnt < 4)
            {
                if (ListBox3.Items.Contains("いくら") != true)
                {
                    itemCnt8++;
                    ListBox3.Items.Add("いくら");
                    ListBox4.Items.Add(itemCnt8);
                    itemCnt++;
                }
                else if (ListBox3.Items.Contains("いくら") == true)
                {
                    ListBox3.Items.Remove("いくら");
                    ListBox4.Items.Remove(itemCnt8);
                    itemCnt8++;
                    ListBox3.Items.Add("いくら");
                    ListBox4.Items.Add(itemCnt8);
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

        #region　とびこ注文用
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (itemCnt < 4)
            {
                if (ListBox3.Items.Contains("とびこ") != true)
                {
                    itemCnt9++;
                    ListBox3.Items.Add("とびこ");
                    ListBox4.Items.Add(itemCnt9);
                    itemCnt++;
                }
                else if (ListBox3.Items.Contains("とびこ") == true)
                {
                    ListBox3.Items.Remove("とびこ");
                    ListBox4.Items.Remove(itemCnt9);
                    itemCnt9++;
                    ListBox3.Items.Add("とびこ");
                    ListBox4.Items.Add(itemCnt9);
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

        #region 海鮮ユッケ注文用
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (itemCnt < 4)
            {
                if (ListBox3.Items.Contains("海鮮ユッケ") != true)
                {
                    itemCnt10++;
                    ListBox3.Items.Add("海鮮ユッケ");
                    ListBox4.Items.Add(itemCnt10);
                    itemCnt++;
                }
                else if (ListBox3.Items.Contains("海鮮ユッケ") == true)
                {
                    ListBox3.Items.Remove("海鮮ユッケ");
                    ListBox4.Items.Remove(itemCnt10);
                    itemCnt10++;
                    ListBox3.Items.Add("海鮮ユッケ");
                    ListBox4.Items.Add(itemCnt10);
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

        #region 納豆注文用
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (itemCnt < 4)
            {
                if (ListBox3.Items.Contains("納豆") != true)
                {
                    itemCnt11++;
                    ListBox3.Items.Add("納豆");
                    ListBox4.Items.Add(itemCnt11);
                    itemCnt++;
                }
                else if (ListBox3.Items.Contains("納豆") == true)
                {
                    ListBox3.Items.Remove("納豆");
                    ListBox4.Items.Remove(itemCnt11);
                    itemCnt11++;
                    ListBox3.Items.Add("納豆");
                    ListBox4.Items.Add(itemCnt11);
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

        #region コーン注文用
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (itemCnt < 4)
            {
                if (ListBox3.Items.Contains("コーン") != true)
                {
                    itemCnt12++;
                    ListBox3.Items.Add("コーン");
                    ListBox4.Items.Add(itemCnt12);
                    itemCnt++;
                }
                else if (ListBox3.Items.Contains("コーン") == true)
                {
                    ListBox3.Items.Remove("コーン");
                    ListBox4.Items.Remove(itemCnt12);
                    itemCnt12++;
                    ListBox3.Items.Add("コーン");
                    ListBox4.Items.Add(itemCnt12);
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
