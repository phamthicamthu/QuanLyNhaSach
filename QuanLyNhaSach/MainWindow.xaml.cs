using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Ribbon;

namespace QuanLyNhaSach
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXRibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            bNgayThang.Content = DateTime.Now.ToShortDateString();
        }

        private void btnQLNhanVien_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            //DXTabItem newTab = new DXTabItem();
            //newTab.Header = "Quản lý nhân viên";
            //QuanLyNhanVien qlnv = new QuanLyNhanVien();
            //newTab.Content = qlnv;
            //tabControl.Items.Add(newTab);
        }
    }
}
