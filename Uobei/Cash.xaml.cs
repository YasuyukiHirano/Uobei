﻿using System;
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
    /// Check.xaml の相互作用ロジック
    /// </summary>
    public partial class Check : Page
    {
        public Check()
        {
            InitializeComponent();
        }

        #region ボタン編集

        //会計確認から握りへ
        private void CheckNigiri_Click(object sender, RoutedEventArgs e)
        {
            var nigiri = new Nigiri();
            NavigationService.Navigate(nigiri);
        }

        //会計確認から軍艦へ
        private void CheckGun_Click(object sender, RoutedEventArgs e)
        {
            var gunkan = new Gunkan();
            NavigationService.Navigate(gunkan);
        }

        //会計確認からサイドへ
        private void CheckSaido_Click(object sender, RoutedEventArgs e)
        {
            var saido = new Saido();
            NavigationService.Navigate(saido);
        }

        //会計確認からデザートへ
        private void CheckDezart_Click(object sender, RoutedEventArgs e)
        {
            var dezart = new Dezart();
            NavigationService.Navigate(dezart);
        }

        //会計確認からトップへ
        private void CheckTop_Click(object sender, RoutedEventArgs e)
        {
            var top = new Top();
            NavigationService.Navigate(top);
        }
        #endregion
    }
}
