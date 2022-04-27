using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.MVVM.ViewModels
{
    public class ViewModelMain : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; set; }

        public void MainViewModel()
        {
            CurrentViewModel = new ViewModelHome();
        }
    }
}
