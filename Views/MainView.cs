using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MVPDemo
{
    public partial class MainView : Form, IMainView
    {
        public IMainPresenter Presenter { get; set; }

        public string Time
        {
            get { return this.label1.Text; }
            set { this.label1.Text = value; }
        }

        public MainView()
        {
            InitializeComponent();
        }


        public void button1_Click(object sender, EventArgs e)
        {
            Presenter.UpdateTime();
        }
    }
}
