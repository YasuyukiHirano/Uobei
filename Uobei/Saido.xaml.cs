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

        #region 初期値設定
        int itemCnt = 0;
        int itemCnt13 = 0;
        int itemCnt14 = 0;
        int itemCnt15 = 0;
        int itemCnt16 = 0;
        int itemCnt17 = 0;
        int itemCnt18 = 0;
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

        #region 青さ汁注文
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (itemCnt < 4)
            {
                if (ListBox5.Items.Contains("青さ汁") != true)
                {
                    itemCnt13++;
                    ListBox5.Items.Add("青さ汁");
                    ListBox6.Items.Add(itemCnt13);
                    itemCnt++;
                }
                else if (ListBox5.Items.Contains("青さ汁") == true)
                {
                    ListBox5.Items.Remove("青さ汁");
                    ListBox6.Items.Remove(itemCnt13);
                    itemCnt13++;
                    ListBox5.Items.Add("青さ汁");
                    ListBox6.Items.Add(itemCnt13);
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

        #region 茶碗蒸し注文
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (itemCnt < 4)
            {
                if (ListBox5.Items.Contains("茶碗蒸し") != true)
                {
                    itemCnt14++;
                    ListBox5.Items.Add("茶碗蒸し");
                    ListBox6.Items.Add(itemCnt14);
                    itemCnt++;
                }
                else if (ListBox5.Items.Contains("茶碗蒸し") == true)
                {
                    ListBox5.Items.Remove("茶碗蒸し");
                    ListBox6.Items.Remove(itemCnt14);
                    itemCnt14++;
                    ListBox5.Items.Add("茶碗蒸し");
                    ListBox6.Items.Add(itemCnt14);
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

        #region フライドポテト注文
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (itemCnt < 4)
            {
                if (ListBox5.Items.Contains("フライドポテト") != true)
                {
                    itemCnt15++;
                    ListBox5.Items.Add("フライドポテト");
                    ListBox6.Items.Add(itemCnt15);
                    itemCnt++;
                }
                else if (ListBox5.Items.Contains("フライドポテト") == true)
                {
                    ListBox5.Items.Remove("フライドポテト");
                    ListBox6.Items.Remove(itemCnt15);
                    itemCnt15++;
                    ListBox5.Items.Add("フライドポテト");
                    ListBox6.Items.Add(itemCnt15);
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

        #region 唐揚げ注文
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (itemCnt < 4)
            {
                if (ListBox5.Items.Contains("唐揚げ") != true)
                {
                    itemCnt16++;
                    ListBox5.Items.Add("唐揚げ");
                    ListBox6.Items.Add(itemCnt16);
                    itemCnt++;
                }
                else if (ListBox5.Items.Contains("唐揚げ") == true)
                {
                    ListBox5.Items.Remove("唐揚げ");
                    ListBox6.Items.Remove(itemCnt16);
                    itemCnt16++;
                    ListBox5.Items.Add("唐揚げ");
                    ListBox6.Items.Add(itemCnt16);
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

        #region うどん注文
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (itemCnt < 4)
            {
                if (ListBox5.Items.Contains("うどん") != true)
                {
                    itemCnt17++;
                    ListBox5.Items.Add("うどん");
                    ListBox6.Items.Add(itemCnt17);
                    itemCnt++;
                }
                else if (ListBox5.Items.Contains("うどん") == true)
                {
                    ListBox5.Items.Remove("うどん");
                    ListBox6.Items.Remove(itemCnt17);
                    itemCnt17++;
                    ListBox5.Items.Add("うどん");
                    ListBox6.Items.Add(itemCnt17);
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

        #region ラーメン注文
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (itemCnt < 4)
            {
                if (ListBox5.Items.Contains("ラーメン") != true)
                {
                    itemCnt18++;
                    ListBox5.Items.Add("ラーメン");
                    ListBox6.Items.Add(itemCnt18);
                    itemCnt++;
                }
                else if (ListBox5.Items.Contains("ラーメン") == true)
                {
                    ListBox5.Items.Remove("ラーメン");
                    ListBox6.Items.Remove(itemCnt18);
                    itemCnt18++;
                    ListBox5.Items.Add("ラーメン");
                    ListBox6.Items.Add(itemCnt18);
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
