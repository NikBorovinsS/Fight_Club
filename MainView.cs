using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_Club
{
    public delegate void ViewHandler<IView>(IView sender, MainViewEventArgs e);

    public class MainViewEventArgs : EventArgs
    {
        public int value;
        public MainViewEventArgs(int v)
        {
            value = v; 
        }
    }

    public interface IMainView
    {
        event ViewHandler<IMainView> changed;
        void setController(IMainController cont);

        void showSettings();
        void showLogs();
        void showFighters();
        void showWinner();
    }
}
