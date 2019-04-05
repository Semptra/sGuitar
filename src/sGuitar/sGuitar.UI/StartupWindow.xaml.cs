using sGuitar.UI.Controls;
using sGuitar.UI.ViewModels;
using Splat;
using System;
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

namespace sGuitar.UI
{
    /// <summary>
    /// Interaction logic for StartupWindow.xaml
    /// </summary>
    public partial class StartupWindow : StartupWindowControl
    {
        public StartupWindow()
        {
            InitializeComponent();

            this.AppBootstrapper = new AppBootstrapper();
            ViewModel = this.AppBootstrapper;
            this.DataContext = ViewModel;
        }

        public AppBootstrapper AppBootstrapper { get; protected set; }
    }
}
