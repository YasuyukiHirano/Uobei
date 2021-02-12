using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
using Image = System.Windows.Controls.Image;

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


       
              

        //DB
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Uobei.SushiOrderDBDataSet sushiOrderDBDataSet = ((Uobei.SushiOrderDBDataSet)(this.FindResource("sushiOrderDBDataSet")));
            // テーブル 商品テーブル にデータを読み込みます。必要に応じてこのコードを変更できます。
            Uobei.SushiOrderDBDataSetTableAdapters.商品テーブルTableAdapter sushiOrderDBDataSet商品テーブルTableAdapter = new Uobei.SushiOrderDBDataSetTableAdapters.商品テーブルTableAdapter();
            sushiOrderDBDataSet商品テーブルTableAdapter.Fill(sushiOrderDBDataSet.商品テーブル);
            System.Windows.Data.CollectionViewSource 商品テーブルViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("商品テーブルViewSource")));
            商品テーブルViewSource.View.MoveCurrentToFirst();
        }

        

        #region ボタン編集

        //握りボタン
        private void MainNigiri_Click(object sender, RoutedEventArgs e)
        {
            Maguro();
            
        }

        //軍艦ボタン
        private void MainGun_Click(object sender, RoutedEventArgs e)
        {
            Gunkan();
            
        }

        //サイドメニューボタン
        private void MainSaido_Click(object sender, RoutedEventArgs e)
        {
            Saido();
            
        }

        //デザートボタン
        private void MainDezart_Click(object sender, RoutedEventArgs e)
        {
            Dezart();
            
        }

        //会計確認ボタン
        private void MainCash_Click(object sender, RoutedEventArgs e)
        {
            var cash = new Cash();
            NavigationService.Navigate(cash);
        }
        

        //握りページのメソッド
        public void Maguro()
        {
            Uobei.SushiOrderDBDataSet sushiOrderDBDataSet = ((Uobei.SushiOrderDBDataSet)(this.FindResource("sushiOrderDBDataSet")));
            // テーブル 商品テーブル にデータを読み込みます。必要に応じてこのコードを変更できます。
            Uobei.SushiOrderDBDataSetTableAdapters.商品テーブルTableAdapter sushiOrderDBDataSet商品テーブルTableAdapter = new Uobei.SushiOrderDBDataSetTableAdapters.商品テーブルTableAdapter();
            sushiOrderDBDataSet商品テーブルTableAdapter.Fill(sushiOrderDBDataSet.商品テーブル);
            System.Windows.Data.CollectionViewSource 商品テーブルViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("商品テーブルViewSource")));
            商品テーブルViewSource.View.MoveCurrentToFirst();

            //Menu.initButton();

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
    }
}
