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
    /// DB.xaml の相互作用ロジック
    /// </summary>
    public partial class DB : Window
    {
        public DB()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Uobei.SushiOrderDBDataSet sushiOrderDBDataSet = ((Uobei.SushiOrderDBDataSet)(this.FindResource("sushiOrderDBDataSet")));
            // テーブル 注文情報 にデータを読み込みます。必要に応じてこのコードを変更できます。
            Uobei.SushiOrderDBDataSetTableAdapters.注文情報TableAdapter sushiOrderDBDataSet注文情報TableAdapter = new Uobei.SushiOrderDBDataSetTableAdapters.注文情報TableAdapter();
            sushiOrderDBDataSet注文情報TableAdapter.Fill(sushiOrderDBDataSet.注文情報);
            System.Windows.Data.CollectionViewSource 注文情報ViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("注文情報ViewSource")));
            注文情報ViewSource.View.MoveCurrentToFirst();
            // テーブル 商品テーブル にデータを読み込みます。必要に応じてこのコードを変更できます。
            Uobei.SushiOrderDBDataSetTableAdapters.商品テーブルTableAdapter sushiOrderDBDataSet商品テーブルTableAdapter = new Uobei.SushiOrderDBDataSetTableAdapters.商品テーブルTableAdapter();
            sushiOrderDBDataSet商品テーブルTableAdapter.Fill(sushiOrderDBDataSet.商品テーブル);
            System.Windows.Data.CollectionViewSource 商品テーブルViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("商品テーブルViewSource")));
            商品テーブルViewSource.View.MoveCurrentToFirst();
        }
    }
}
