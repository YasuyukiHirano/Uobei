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
    /// Cash.xaml の相互作用ロジック
    /// </summary>
    public partial class Cash : Page
    {
        public Cash()
        {
            InitializeComponent();
        }

        //ひとつ前に戻る
        private void CashBack_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }

        //会計ボタン
        private void Cash_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("「ご来店ありがとうございました。またお越しくださいませ。」"
            ,"精算済み",MessageBoxButton.YesNo);

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
    }
}
