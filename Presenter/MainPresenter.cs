using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVPDemo
{
    public class MainPresenter : IMainPresenter
    {
        public IMainModel model { get; set; }
        public IMainView view { get; set; }

        public MainPresenter(IMainView view, IMainModel model)
        {
            this.view = view;
            this.view.Presenter = this;
            this.model = model;
        }

        public void UpdateTime()
        {
            this.model.time = DateTime.Now.ToString();  // How can we make time testable?
            // this.model.save    // save to database if it existed
            this.view.Time = this.model.time; // update our view layer
        }
    }
}
