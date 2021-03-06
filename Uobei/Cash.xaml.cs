﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
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
    /// Check.xaml の相互作用ロジック
    /// </summary>
    public partial class Check : Page
    {
        public Check()
        {
            InitializeComponent();
            ListAdd();
        }

        int count = 0;
        int num;

        //リスト
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

        //リストからマイナス
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
                if (kvp.Value == 0)
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
            if (delete == 1)
            {
                Order.OrderList.Remove(name);
            }

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //DB
            Uobei.SushiOrderDBDataSet sushiOrderDBDataSet = ((Uobei.SushiOrderDBDataSet)(this.FindResource("sushiOrderDBDataSet")));
            // テーブル 商品テーブル にデータを読み込みます。必要に応じてこのコードを変更できます。
            Uobei.SushiOrderDBDataSetTableAdapters.商品テーブルTableAdapter sushiOrderDBDataSet商品テーブルTableAdapter = new Uobei.SushiOrderDBDataSetTableAdapters.商品テーブルTableAdapter();
            sushiOrderDBDataSet商品テーブルTableAdapter.Fill(sushiOrderDBDataSet.商品テーブル);
            System.Windows.Data.CollectionViewSource 商品テーブルViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("商品テーブルViewSource")));
            商品テーブルViewSource.View.MoveCurrentToFirst();

            // テーブル 注文情報 にデータを読み込みます。必要に応じてこのコードを変更できます。
            Uobei.SushiOrderDBDataSetTableAdapters.注文情報TableAdapter sushiOrderDBDataSet注文情報TableAdapter = new Uobei.SushiOrderDBDataSetTableAdapters.注文情報TableAdapter();
            sushiOrderDBDataSet注文情報TableAdapter.Fill(sushiOrderDBDataSet.注文情報);
            System.Windows.Data.CollectionViewSource 注文情報ViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("注文情報ViewSource")));
            注文情報ViewSource.View.MoveCurrentToFirst();

            //注文個数
            foreach (var item in Order.OrderList)
            {
                count += item.Value;
            }
            count6.Content = count;
        }

        #region ボタン編集

        //会計確認から握りへ
        private void CheckNigiri_Click(object sender, RoutedEventArgs e)
        {
            Maguro();
        }

        //会計確認から軍艦へ
        private void CheckGun_Click(object sender, RoutedEventArgs e)
        {
            Gunkan();
        }

        //会計確認からサイドへ
        private void CheckSaido_Click(object sender, RoutedEventArgs e)
        {
            Saido();
        }

        //会計確認からデザートへ
        private void CheckDezart_Click(object sender, RoutedEventArgs e)
        {
            Dezart();
        }

        //会計確認からトップへ
        private void CheckTop_Click(object sender, RoutedEventArgs e)
        {
            var top = new Top();
            NavigationService.Navigate(top);
        }
        #endregion

        #region 注文確定ボタン
        private void Chumon_Click(object sender, RoutedEventArgs e)
        {
            num = 0;
            foreach (var item in Order.OrderList)
            {
                num += item.Value;
            }

            if (num != 0)
            {
                MessageBox.Show("ご注文が完了しました。");

                //注文確定
                Uobei.SushiOrderDBDataSet sushiOrderDBDataSet = ((Uobei.SushiOrderDBDataSet)(this.FindResource("sushiOrderDBDataSet")));
                // テーブル 注文情報 にデータを読み込みます。必要に応じてこのコードを変更できます。
                Uobei.SushiOrderDBDataSetTableAdapters.注文情報TableAdapter sushiOrderDBDataSet注文情報TableAdapter = new Uobei.SushiOrderDBDataSetTableAdapters.注文情報TableAdapter();
                sushiOrderDBDataSet注文情報TableAdapter.Fill(sushiOrderDBDataSet.注文情報);
                System.Windows.Data.CollectionViewSource 注文情報ViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("注文情報ViewSource")));
                注文情報ViewSource.View.MoveCurrentToFirst();

                //DB
                Uobei.SushiOrderDBDataSet sushiOrderDBDataSet1 = ((Uobei.SushiOrderDBDataSet)(this.FindResource("sushiOrderDBDataSet")));
                // テーブル 商品テーブル にデータを読み込みます。必要に応じてこのコードを変更できます。
                Uobei.SushiOrderDBDataSetTableAdapters.商品テーブルTableAdapter sushiOrderDBDataSet商品テーブルTableAdapter = new Uobei.SushiOrderDBDataSetTableAdapters.商品テーブルTableAdapter();
                sushiOrderDBDataSet商品テーブルTableAdapter.Fill(sushiOrderDBDataSet.商品テーブル);
                System.Windows.Data.CollectionViewSource 商品テーブルViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("商品テーブルViewSource")));
                商品テーブルViewSource.View.MoveCurrentToFirst();

                for (int i = 0; i < ListBox2.Items.Count; i++)
                {
                    DataRow newDrv = (DataRow)sushiOrderDBDataSet.注文情報.NewRow();
                    newDrv[3] = Time(sender, e);
                    newDrv[6] = ListBox1.Items[i];
                    newDrv[7] = ListBox2.Items[i];
                    var price = (int[])sushiOrderDBDataSet1.商品テーブル.Where(x => x.Name == ListBox1.Items[i].ToString())
                                                                         .Select(x => x.Price * int.Parse(ListBox2.Items[i].ToString())).ToArray();
                    newDrv[8] = price[0];
                    newDrv[9] = "未";
                    //データセットに新しいレコードを追加
                    sushiOrderDBDataSet.注文情報.Rows.Add(newDrv);
                }
                //データベース更新
                sushiOrderDBDataSet注文情報TableAdapter.Update(sushiOrderDBDataSet.注文情報);
                ListBox1.Items.Clear();
                ListBox2.Items.Clear();
                Order.OrderList.Clear();
                count6.Content = null;
            }
            else
            {
                MessageBox.Show("商品を選択してください。");
            }
        }
        #endregion

        //日本の現在の時刻を持ってくる
        private TimeSpan Time(object sender, RoutedEventArgs e)
        {
            //日本時間のタイムゾーン
            var jstZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");
            DateTime utc = DateTime.UtcNow;
            DateTime dt = TimeZoneInfo.ConvertTimeFromUtc(utc, jstZoneInfo);
            TimeSpan ts = dt.TimeOfDay;

            return ts;
        }

        #region メソッド
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

            var st = sushiOrderDBDataSet.商品テーブル.Where(x => x.Status.Contains("販売中"));

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
        #endregion

        #region マイナス
        private void Dec1_Click(object sender, RoutedEventArgs e)
        {
            num = 0;
            count = 0;
            try
            {
                foreach (var item in Order.OrderList)
                {
                    num += item.Value;
                }
                if (num > 0)
                {
                    Order.OrderDec(ListBox1.SelectedItem.ToString());
                    ListDec();
                    foreach (var item in Order.OrderList)
                    {
                        count += item.Value;
                    }
                    count6.Content = count;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }

        }
        #endregion

        #region プラス
        private void Inc1_Click(object sender, RoutedEventArgs e)
        {
            num = 0;
            count = 0;
            try
            {
                foreach (var item in Order.OrderList)
                {
                    num += item.Value;
                }
                if (num < 4)
                {
                    ListBox2.Items.Add(Order.OrderAdd(ListBox1.SelectedItem.ToString()));
                    ListAdd();
                    foreach (var item in Order.OrderList)
                    {
                        count += item.Value;
                    }
                    count6.Content = count;
                }
                else
                {
                    MessageBox.Show("一度に4皿まで注文できます。");
                }
            }
            catch (NullReferenceException)
            {
                return;
            }
        }
        #endregion
    }
}
