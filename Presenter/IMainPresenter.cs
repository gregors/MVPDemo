using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVPDemo
{
    public interface IMainPresenter
    {
        IMainModel model { get; set; }
        IMainView view { get; set; }
        void UpdateTime();
    }
}
