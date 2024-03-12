using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Label_slipe
    {
        public static Timer slideTimer=new Timer();
		//设置 Label 字体左右滑动

		public static void fontSlide(Label lab)
		{
			int width = lab.Parent.Width;//重新调用容易出bug
			if (lab == null)
            {
				return;
            }
            else
            {
				//初始化对象从右侧开始
				lab.Location = new Point(width, lab.Location.Y);
				slideTimer.Enabled = true;
				slideTimer.Interval = 140;
				//鼠标放上去停止滚动
				lab.MouseMove += new MouseEventHandler((s, x) =>
				{
					slideTimer.Enabled = false;
				});
				//鼠标离开继续滚动
				lab.MouseLeave += new EventHandler((s, x) =>
				{
					slideTimer.Enabled = true;
				});
				//滚动
				slideTimer.Tick += new EventHandler((s, x) =>
				{
					//如果当前标签定位已经完全滚动完了就恢复到右侧重新滚动
					if (lab.Location.X <= (lab.Width - (lab.Width * 2)))

					{
						lab.Location = new Point(width, lab.Location.Y);
					}
					else
					{
						lab.Location = new Point(lab.Location.X - 10, lab.Location.Y);
					}
				});
			}
		}
	}
}
