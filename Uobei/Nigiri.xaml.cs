using Microsoft.Win32;
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

        #region 初期値設定
        int itemCnt = 0;
        int itemCnt1 = 0;        
        int itemCnt2 = 0;
        int itemCnt3 = 0;
        int itemCnt4 = 0;
        int itemCnt5 = 0;
        int itemCnt6 = 0;
        #endregion

        #region アイテム数カウント用
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            itemCnt = itemCnt1 + itemCnt2 + itemCnt3 + itemCnt4 + itemCnt5 + itemCnt6;
        }
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

        #region まぐろ注文
        private void Button_Click(object sender, RoutedEventArgs e)
        {           
            
            if (itemCnt < 4)
            {
                if (ListBox1.Items.Contains("まぐろ") != true)
                {
                    itemCnt1++;
                    ListBox1.Items.Add("まぐろ");
                    ListBox2.Items.Add(itemCnt1);
                    itemCnt++;
                    
                }
                else if (ListBox1.Items.Contains("まぐろ") == true)
                {
                    ListBox1.Items.Remove("まぐろ");
                    ListBox2.Items.Remove(itemCnt1);
                    itemCnt1++;
                    ListBox1.Items.Add("まぐろ");
                    ListBox2.Items.Add(itemCnt1);
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

        #region サーモン注文
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (itemCnt < 4)
            {
                if (ListBox1.Items.Contains("サーモン") != true)
                {
                    itemCnt2++;
                    ListBox1.Items.Add("サーモン");
                    ListBox2.Items.Add(itemCnt2);
                    itemCnt++;
                }
                else if (ListBox1.Items.Contains("サーモン") == true)
                {
                    ListBox1.Items.Remove("サーモン");
                    ListBox2.Items.Remove(itemCnt2);
                    itemCnt2++;
                    ListBox1.Items.Add("サーモン");
                    ListBox2.Items.Add(itemCnt2);
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

        #region はまち注文
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (itemCnt < 4)
            {
                if (ListBox1.Items.Contains("はまち") != true)
                {
                    itemCnt3++;
                    ListBox1.Items.Add("はまち");
                    ListBox2.Items.Add(itemCnt3);
                    itemCnt++;
                }
                else if (ListBox1.Items.Contains("はまち") == true)
                {
                    ListBox1.Items.Remove("はまち");
                    ListBox2.Items.Remove(itemCnt3);
                    itemCnt3++;
                    ListBox1.Items.Add("はまち");
                    ListBox2.Items.Add(itemCnt3);
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

        #region つぶ貝注文
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (itemCnt < 4)
            {
                if (ListBox1.Items.Contains("つぶ貝") != true)
                {
                    itemCnt4++;
                    ListBox1.Items.Add("つぶ貝");
                    ListBox2.Items.Add(itemCnt4);
                    itemCnt++;
                }
                else if (ListBox1.Items.Contains("つぶ貝") == true)
                {
                    ListBox1.Items.Remove("つぶ貝");
                    ListBox2.Items.Remove(itemCnt4);
                    itemCnt4++;
                    ListBox1.Items.Add("つぶ貝");
                    ListBox2.Items.Add(itemCnt4);
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

        #region あじ注文
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (itemCnt < 4)
            {
                if (ListBox1.Items.Contains("あじ") != true)
                {
                    itemCnt5++;
                    ListBox1.Items.Add("あじ");
                    ListBox2.Items.Add(itemCnt5);
                    itemCnt++;
                }
                else if (ListBox1.Items.Contains("あじ") == true)
                {
                    ListBox1.Items.Remove("あじ");
                    ListBox2.Items.Remove(itemCnt5);
                    itemCnt5++;
                    ListBox1.Items.Add("あじ");
                    ListBox2.Items.Add(itemCnt5);
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

        #region 平目注文
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (itemCnt < 4)
            {
                if (ListBox1.Items.Contains("平目") != true)
                {
                    itemCnt6++;
                    ListBox1.Items.Add("平目");
                    ListBox2.Items.Add(itemCnt6);
                    itemCnt++;
                }
                else if (ListBox1.Items.Contains("平目") == true)
                {
                    ListBox1.Items.Remove("平目");
                    ListBox2.Items.Remove(itemCnt6);
                    itemCnt6++;
                    ListBox1.Items.Add("平目");
                    ListBox2.Items.Add(itemCnt6);
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

        #region +ボタン        
        private void Inc_Click(object sender, RoutedEventArgs e)
        {
            //ListBox1.Items.Add(ListBox1.SelectedIndex);
            //ListBox2.Items.Add(ListBox2.SelectedIndex);
            //ListBox1.Items.Remove("まぐろ");
            //ListBox2.Items.Remove(itemCnt1);
            //itemCnt1++;
            //ListBox1.Items.Add("まぐろ");
            //ListBox2.Items.Add(itemCnt1);
            //itemCnt++;
        }
        #endregion

        #region -ボタン
        private void Dec_Click(object sender, RoutedEventArgs e)
        {
            //ListBox1.Items.RemoveAt(ListBox1.SelectedIndex);
            //ListBox2.Items.RemoveAt(ListBox2.SelectedIndex);
            //itemCnt--;
            //itemCnt1--;
            //itemCnt2--;
            //itemCnt3--;
            //itemCnt4--;
            //itemCnt5--;
            //itemCnt6--;
        }
        #endregion
    }
}
