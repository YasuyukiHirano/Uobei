using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Cash.xaml の相互作用ロジック
    /// </summary>
    public partial class Cash : Page
    {
        public Cash()
        {
            InitializeComponent();
        }        

        #region ひとつ前に戻る
        private void CashBack_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }
        #endregion

        #region 会計ボタン
        private void Cash_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("「ご来店ありがとうございました。またお越しくださいませ。」"
            , "精算済み", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
            else if (result == MessageBoxResult.No)
            {
                for (int i = 0; i < (int)MessageBoxResult.Yes; i++)
                {
                    MessageBox.Show("また来てくださいね!!!!!!!!!!!!", "エラー"
                        , MessageBoxButton.YesNo, MessageBoxImage.Error);
                }
            }
            Application.Current.Shutdown();
        }
        #endregion

        #region DB
        private void OrderListDataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            Uobei.SushiOrderDBDataSet sushiOrderDBDataSet = ((Uobei.SushiOrderDBDataSet)(this.FindResource("sushiOrderDBDataSet")));
            // テーブル 注文情報 にデータを読み込みます。必要に応じてこのコードを変更できます。
            Uobei.SushiOrderDBDataSetTableAdapters.注文情報TableAdapter sushiOrderDBDataSet注文情報TableAdapter = new Uobei.SushiOrderDBDataSetTableAdapters.注文情報TableAdapter();
            sushiOrderDBDataSet注文情報TableAdapter.Fill(sushiOrderDBDataSet.注文情報);
            System.Windows.Data.CollectionViewSource 注文情報ViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("注文情報ViewSource")));
            注文情報ViewSource.View.MoveCurrentToFirst();

            //合計金額
            Number.Content = sushiOrderDBDataSet.注文情報.Select(n => n.Sum_price).Sum();          
        }
        #endregion
    }
}
