using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEPServerEX
{
    public partial class FHeaderMainFooter : UIHeaderMainFooterFrame
    {
        public FHeaderMainFooter()
        {
            InitializeComponent();
            //设置关联
            Header.TabControl = MainTabControl;

            //加页面到Main

            //设置Header节点索引
            Header.CreateNode("Page1", 1001);
            Header.CreateNode("Page2", 1002);
            Header.CreateNode("Page3", 1003);


        }

        private void Header_MenuItemClick(string itemText, int menuIndex, int pageIndex)
        {
            Footer.Text = "PageIndex:" + pageIndex;
            MessageBox.Show(Footer.Text);
        }
    }
}
