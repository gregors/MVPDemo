using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVPDemo
{
    public interface IMainView
    {
       IMainPresenter Presenter { get; set; }
       string Time { get; set; }
        void button1_Click(object sender, EventArgs e);
    }
}
