using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
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
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
        }

        #region 初期値設定
        int itemCnt;
        int countnum = 0;
        int num;
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

            //注文個数
            foreach (var item in Order.OrderList)
            {
                countnum += item.Value;
                //itemCntを保持
                itemCnt += item.Value;
            }
            //if(itemCnt > 4 && itemCnt != 0)
            //{
            //    Inc.IsEnabled = true;
            //    Dec.IsEnabled = true;
            //}
            //else
            //{
            //    Inc.IsEnabled = false;
            //    Dec.IsEnabled = false;
            //}
            count.Content = countnum;

            //リストを表示させる動作(値は何も追加しない)
            ListAdd();
        }
        #endregion

        #region ボタン編集

        //メニュー握り
        private void NigiriNigiri_Click(object sender, RoutedEventArgs e)
        {
            Maguro();
            
        }

        //メニュー軍艦
        private void NigiriGun_Click(object sender, RoutedEventArgs e)
        {
            Gunkan();
            
        }

        //メニューサイド
        private void NigiriSaido_Click(object sender, RoutedEventArgs e)
        {
            Saido();
            
        }

        //メニューデザート
        private void NigiriDezart_Click(object sender, RoutedEventArgs e)
        {
            Dezart();
            
        }

        //メニューから会計確認へ
        private void NigiriCash_Click(object sender, RoutedEventArgs e)
        {
            var cash = new Cash();
            NavigationService.Navigate(cash);
        }

        //メニューから注文へ
        private void NigiriChumon_Click(object sender, RoutedEventArgs e)
        {
            var check = new Check();
            NavigationService.Navigate(check);
        }

        //握り前へ
        private void NigiriFront_Click(object sender, RoutedEventArgs e)
        {
           
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }

        //握り次へ
        private void NigiriBack_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoForward)
            {
                this.NavigationService.GoForward();
            }
        }
        #endregion

        #region にぎり

            #region Button1注文           
            private void Button1_Click(object sender, RoutedEventArgs e)
            {
                num = 0;
                if (itemCnt < 4)
                {
                //Inc.IsEnabled = true;
                //Dec.IsEnabled = true;
                Order.OrderAdd(Button1.Name);
                    ListAdd();
                    foreach (var item in Order.OrderList)
                    {
                      num += item.Value;
                    }
                    count.Content = num;
                    itemCnt++;                    
                }
                else
                {
                    MessageBox.Show("一度に4皿まで注文できます。");

                    var check = new Check();
                    NavigationService.Navigate(check);
                }
            }
            #endregion

            #region Button2注文        
            private void Button2_Click(object sender, RoutedEventArgs e)
            {
                num = 0;
                if (itemCnt < 4)
                {
                    Order.OrderAdd(Button2.Name);
                    ListAdd();
                    foreach (var item in Order.OrderList)
                    {
                       num += item.Value;
                    }
                    count.Content = num;
                    itemCnt++;
                }
                else
                {
                    MessageBox.Show("一度に4皿まで注文できます。");
                                     var check = new Check();
                    NavigationService.Navigate(check);
                }
            }
        #endregion

            #region Button3注文
            private void Button3_Click(object sender, RoutedEventArgs e)
            {
                num = 0;
                if (itemCnt < 4)
                {
                    Order.OrderAdd(Button3.Name);
                    ListAdd();
                    foreach (var item in Order.OrderList)
                    {
                        num += item.Value;
                    }
                    count.Content = num;
                    itemCnt++;
                }
                else
                {
                    MessageBox.Show("一度に4皿まで注文できます。");

                    var check = new Check();
                    NavigationService.Navigate(check);
                }
            }
        #endregion

            #region Button4注文
            private void Button4_Click(object sender, RoutedEventArgs e)
            {
                num = 0;
                if (itemCnt < 4)
                {
                    Order.OrderAdd(Button4.Name);
                    ListAdd();
                    foreach (var item in Order.OrderList)
                    {
                        num += item.Value;
                    }
                    count.Content = num;
                itemCnt++;
                }
                else
                {
                    MessageBox.Show("一度に4皿まで注文できます。");

                    var check = new Check();
                    NavigationService.Navigate(check);
                }
            }
        #endregion

            #region Button5注文
            private void Button5_Click(object sender, RoutedEventArgs e)
            {
                num = 0;
                if (itemCnt < 4)
                {
                    Order.OrderAdd(Button5.Name);
                    ListAdd();
                    foreach (var item in Order.OrderList)
                    {
                        num += item.Value;
                    }
                    count.Content = num;
                    itemCnt++;
                }
                else
                {
                    MessageBox.Show("一度に4皿まで注文できます。");

                    var check = new Check();
                    NavigationService.Navigate(check);
                }
            }
            #endregion

            #region Button6注文
            private void Button6_Click(object sender, RoutedEventArgs e)
            {
                num = 0;
                if (itemCnt < 4)
                {
                    Order.OrderAdd(Button6.Name);
                    ListAdd();
                    foreach (var item in Order.OrderList)
                    {
                        num += item.Value;
                    }
                    count.Content = num;
                    itemCnt++;
                }
                else
                {
                    MessageBox.Show("一度に4皿まで注文できます。");

                    var check = new Check();
                    NavigationService.Navigate(check);
                }
            }
            #endregion

            #region リストに追加
            private void ListAdd()
            {
                ListBox1.Items.Clear();
                ListBox2.Items.Clear();
                foreach (KeyValuePair<string, int> kvp in Order.OrderList)
                {
                    ListBox1.Items.Add(kvp.Key);
                    ListBox2.Items.Add(kvp.Value);
                }
            }
            #endregion

            #region リストからマイナス
            private void ListDec()
            {
            
            //削除する初期化
            int delete = 0;
            //商品名を取ってくる
            string name = "";
                ListBox1.Items.Clear();
                ListBox2.Items.Clear();
            foreach (KeyValuePair<string, int> kvp in Order.OrderList)
                {
                    if(kvp.Value == 0)
                {
                    ListBox1.Items.Remove(kvp.Key);
                    ListBox2.Items.Remove(kvp.Value);
                    delete++;
                    name = kvp.Key;
                    
                }
                else
                {
                    ListBox1.Items.Add(kvp.Key);
                    ListBox2.Items.Add(kvp.Value);
                    
                }
                

            }
            //OrderListに追加されているList(Name)を削除
            if(delete == 1)
            {
                Order.OrderList.Remove(name);
            }
            }
            #endregion

            #region +ボタン        
            private void Inc_Click(object sender, RoutedEventArgs e)
            {
                num = 0;
            try
            {
                if (itemCnt < 4)
                {
                    ListBox2.Items.Add(Order.OrderAdd(ListBox1.SelectedItem.ToString()));
                    ListAdd();
                    foreach (var item in Order.OrderList)
                    {
                        num += item.Value;
                    }
                    count.Content = num;
                    itemCnt++;
                }
                else
                {
                    MessageBox.Show("一度に4皿まで注文できます。");

                    var check = new Check();
                    NavigationService.Navigate(check);
                }
            }
            catch (NullReferenceException)
            {
                return;
            }
                
            }
            #endregion

            #region -ボタン
            private void Dec_Click(object sender, RoutedEventArgs e)
            {
            num = 0;
                try
                {
                    if (itemCnt > 0)
                    {
                        Order.OrderDec(ListBox1.SelectedItem.ToString());                                               
                        ListDec();
                    foreach (var item in Order.OrderList)
                    {
                        
                        num  +=  item.Value;
                    }
                    count.Content = num;
                    itemCnt--;
                }
                else if (itemCnt == 0)
                {
                    return;
                }
                }
                catch (NullReferenceException)
                {
                    return;
                }                                
            }
            #endregion

        #endregion

        //握りページのメソッド
        public void Maguro()
        {
            Uobei.SushiOrderDBDataSet sushiOrderDBDataSet = ((Uobei.SushiOrderDBDataSet)(this.FindResource("sushiOrderDBDataSet")));
            // テーブル 商品テーブル にデータを読み込みます。必要に応じてこのコードを変更できます。
            Uobei.SushiOrderDBDataSetTableAdapters.商品テーブルTableAdapter sushiOrderDBDataSet商品テーブルTableAdapter = new Uobei.SushiOrderDBDataSetTableAdapters.商品テーブルTableAdapter();
            sushiOrderDBDataSet商品テーブルTableAdapter.Fill(sushiOrderDBDataSet.商品テーブル);
            System.Windows.Data.CollectionViewSource 商品テーブルViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("商品テーブルViewSource")));
            商品テーブルViewSource.View.MoveCurrentToFirst();            

            var menu = new Menu();
            NavigationService.Navigate(menu);

            

            #region 写真挿入
            var drv1 = (DataRow)sushiOrderDBDataSet.商品テーブル.Rows[0];
            if (drv1[5].ToString() == "販売中")
            {
                menu.Button1.IsEnabled = true;
                menu.image1.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(drv1[4]);
                menu.Button1.Name = drv1[2].ToString();
            }
            else
            {
                menu.Button1.IsEnabled = false;
            }

            var drv2 = (DataRow)sushiOrderDBDataSet.商品テーブル.Rows[1];
            if (drv2[5].ToString() == "販売中")
            {
                menu.Button2.IsEnabled = true;
                menu.image2.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(drv2[4]);
                menu.Button2.Name = drv2[2].ToString();
            }
            else
            {
                menu.Button2.IsEnabled = false;
            }

            var drv3 = (DataRow)sushiOrderDBDataSet.商品テーブル.Rows[2];
            if (drv3[5].ToString() == "販売中")
            {
                menu.image3.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(drv3[4]);
                menu.Button3.Name = drv3[2].ToString();
            }
            else
            {
                menu.Button3.IsEnabled = false;
            }

            var drv4 = (DataRow)sushiOrderDBDataSet.商品テーブル.Rows[3];
            if (drv4[5].ToString() == "販売中")
            {
                menu.image4.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(drv4[4]);
                menu.Button4.Name = drv4[2].ToString();
            }
            else
            {
                menu.Button4.IsEnabled = false;
            }

            var drv5 = (DataRow)sushiOrderDBDataSet.商品テーブル.Rows[4];
            if (drv5[5].ToString() == "販売中")
            {
                menu.image5.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(drv5[4]);
                menu.Button5.Name = drv5[2].ToString();
            }
            else
            {
                menu.Button5.IsEnabled = false;
            }

            var drv6 = (DataRow)sushiOrderDBDataSet.商品テーブル.Rows[5];
            if (drv6[5].ToString() == "販売中")
            {
                menu.image6.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(drv6[4]);
                menu.Button6.Name = drv6[2].ToString();
            }
            else
            {
                menu.Button6.IsEnabled = false;
            }
            #endregion
        }

        //軍艦ページのメソッド
        public void Gunkan()
        {
            Uobei.SushiOrderDBDataSet sushiOrderDBDataSet = ((Uobei.SushiOrderDBDataSet)(this.FindResource("sushiOrderDBDataSet")));
            // テーブル 商品テーブル にデータを読み込みます。必要に応じてこのコードを変更できます。
            Uobei.SushiOrderDBDataSetTableAdapters.商品テーブルTableAdapter sushiOrderDBDataSet商品テーブルTableAdapter = new Uobei.SushiOrderDBDataSetTableAdapters.商品テーブルTableAdapter();
            sushiOrderDBDataSet商品テーブルTableAdapter.Fill(sushiOrderDBDataSet.商品テーブル);
            System.Windows.Data.CollectionViewSource 商品テーブルViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("商品テーブルViewSource")));
            商品テーブルViewSource.View.MoveCurrentToFirst();

            var menu = new Menu();
            NavigationService.Navigate(menu);

            #region 写真挿入
            var drv1 = (DataRow)sushiOrderDBDataSet.商品テーブル.Rows[6];
            if (drv1[5].ToString() == "販売中")
            {
                menu.Button1.IsEnabled = true;
                menu.image1.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(drv1[4]);
                menu.Button1.Name = drv1[2].ToString();
            }
            else
            {
                menu.Button1.IsEnabled = false;
            }

            var drv2 = (DataRow)sushiOrderDBDataSet.商品テーブル.Rows[7];
            if (drv2[5].ToString() == "販売中")
            {
                menu.Button2.IsEnabled = true;
                menu.image2.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(drv2[4]);
                menu.Button2.Name = drv2[2].ToString();
            }
            else
            {
                menu.Button2.IsEnabled = false;
            }

            var drv3 = (DataRow)sushiOrderDBDataSet.商品テーブル.Rows[8];
            if (drv3[5].ToString() == "販売中")
            {
                menu.image3.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(drv3[4]);
                menu.Button3.Name = drv3[2].ToString();
            }
            else
            {
                menu.Button3.IsEnabled = false;
            }

            var drv4 = (DataRow)sushiOrderDBDataSet.商品テーブル.Rows[9];
            if (drv4[5].ToString() == "販売中")
            {
                menu.image4.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(drv4[4]);
                menu.Button4.Name = drv4[2].ToString();
            }
            else
            {
                menu.Button4.IsEnabled = false;
            }

            var drv5 = (DataRow)sushiOrderDBDataSet.商品テーブル.Rows[10];
            if (drv5[5].ToString() == "販売中")
            {
                menu.image5.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(drv5[4]);
                menu.Button5.Name = drv5[2].ToString();
            }
            else
            {
                menu.Button5.IsEnabled = false;
            }

            var drv6 = (DataRow)sushiOrderDBDataSet.商品テーブル.Rows[11];
            if (drv6[5].ToString() == "販売中")
            {
                menu.image6.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(drv6[4]);
                menu.Button6.Name = drv6[2].ToString();
            }
            else
            {
                menu.Button6.IsEnabled = false;
            }
            #endregion
        }

        //サイドページのメソッド
        public void Saido()
        {
            Uobei.SushiOrderDBDataSet sushiOrderDBDataSet = ((Uobei.SushiOrderDBDataSet)(this.FindResource("sushiOrderDBDataSet")));
            // テーブル 商品テーブル にデータを読み込みます。必要に応じてこのコードを変更できます。
            Uobei.SushiOrderDBDataSetTableAdapters.商品テーブルTableAdapter sushiOrderDBDataSet商品テーブルTableAdapter = new Uobei.SushiOrderDBDataSetTableAdapters.商品テーブルTableAdapter();
            sushiOrderDBDataSet商品テーブルTableAdapter.Fill(sushiOrderDBDataSet.商品テーブル);
            System.Windows.Data.CollectionViewSource 商品テーブルViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("商品テーブルViewSource")));
            商品テーブルViewSource.View.MoveCurrentToFirst();

            var menu = new Menu();
            NavigationService.Navigate(menu);

            #region 写真挿入
            var drv1 = (DataRow)sushiOrderDBDataSet.商品テーブル.Rows[12];
            if (drv1[5].ToString() == "販売中")
            {
                menu.Button1.IsEnabled = true;
                menu.image1.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(drv1[4]);
                menu.Button1.Name = drv1[2].ToString();
            }
            else
            {
                menu.Button1.IsEnabled = false;
            }

            var drv2 = (DataRow)sushiOrderDBDataSet.商品テーブル.Rows[13];
            if (drv2[5].ToString() == "販売中")
            {
                menu.Button2.IsEnabled = true;
                menu.image2.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(drv2[4]);
                menu.Button2.Name = drv2[2].ToString();
            }
            else
            {
                menu.Button2.IsEnabled = false;
            }

            var drv3 = (DataRow)sushiOrderDBDataSet.商品テーブル.Rows[14];
            if (drv3[5].ToString() == "販売中")
            {
                menu.image3.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(drv3[4]);
                menu.Button3.Name = drv3[2].ToString();
            }
            else
            {
                menu.Button3.IsEnabled = false;
            }

            var drv4 = (DataRow)sushiOrderDBDataSet.商品テーブル.Rows[15];
            if (drv4[5].ToString() == "販売中")
            {
                menu.image4.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(drv4[4]);
                menu.Button4.Name = drv4[2].ToString();
            }
            else
            {
                menu.Button4.IsEnabled = false;
            }

            var drv5 = (DataRow)sushiOrderDBDataSet.商品テーブル.Rows[16];
            if (drv5[5].ToString() == "販売中")
            {
                menu.image5.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(drv5[4]);
                menu.Button5.Name = drv5[2].ToString();
            }
            else
            {
                menu.Button5.IsEnabled = false;
            }

            var drv6 = (DataRow)sushiOrderDBDataSet.商品テーブル.Rows[17];
            if (drv6[5].ToString() == "販売中")
            {
                menu.image6.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(drv6[4]);
                menu.Button6.Name = drv6[2].ToString();
            }
            else
            {
                menu.Button6.IsEnabled = false;
            }
            #endregion
        }

        //デザートのページのメソッド
        public void Dezart()
        {
            Uobei.SushiOrderDBDataSet sushiOrderDBDataSet = ((Uobei.SushiOrderDBDataSet)(this.FindResource("sushiOrderDBDataSet")));
            // テーブル 商品テーブル にデータを読み込みます。必要に応じてこのコードを変更できます。
            Uobei.SushiOrderDBDataSetTableAdapters.商品テーブルTableAdapter sushiOrderDBDataSet商品テーブルTableAdapter = new Uobei.SushiOrderDBDataSetTableAdapters.商品テーブルTableAdapter();
            sushiOrderDBDataSet商品テーブルTableAdapter.Fill(sushiOrderDBDataSet.商品テーブル);
            System.Windows.Data.CollectionViewSource 商品テーブルViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("商品テーブルViewSource")));
            商品テーブルViewSource.View.MoveCurrentToFirst();

            var menu = new Menu();
            NavigationService.Navigate(menu);

            #region 写真挿入
            var drv1 = (DataRow)sushiOrderDBDataSet.商品テーブル.Rows[18];
            if (drv1[5].ToString() == "販売中")
            {
                menu.Button1.IsEnabled = true;
                menu.image1.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(drv1[4]);
                menu.Button1.Name = drv1[2].ToString();
            }
            else
            {
                menu.Button1.IsEnabled = false;
            }

            var drv2 = (DataRow)sushiOrderDBDataSet.商品テーブル.Rows[19];
            if (drv2[5].ToString() == "販売中")
            {
                menu.Button2.IsEnabled = true;
                menu.image2.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(drv2[4]);
                menu.Button2.Name = drv2[2].ToString();
            }
            else
            {
                menu.Button2.IsEnabled = false;
            }

            var drv3 = (DataRow)sushiOrderDBDataSet.商品テーブル.Rows[20];
            if (drv3[5].ToString() == "販売中")
            {
                menu.image3.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(drv3[4]);
                menu.Button3.Name = drv3[2].ToString();
            }
            else
            {
                menu.Button3.IsEnabled = false;
            }

            var drv4 = (DataRow)sushiOrderDBDataSet.商品テーブル.Rows[21];
            if (drv4[5].ToString() == "販売中")
            {
                menu.image4.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(drv4[4]);
                menu.Button4.Name = drv4[2].ToString();
            }
            else
            {
                menu.Button4.IsEnabled = false;
            }

            var drv5 = (DataRow)sushiOrderDBDataSet.商品テーブル.Rows[22];
            if (drv5[5].ToString() == "販売中")
            {
                menu.image5.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(drv5[4]);
                menu.Button5.Name = drv5[2].ToString();
            }
            else
            {
                menu.Button5.IsEnabled = false;
            }

            var drv6 = (DataRow)sushiOrderDBDataSet.商品テーブル.Rows[23];
            if (drv6[5].ToString() == "販売中")
            {
                menu.image6.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(drv6[4]);
                menu.Button6.Name = drv6[2].ToString();
            }
            else
            {
                menu.Button6.IsEnabled = false;
            }
            #endregion
        }
    }
}
