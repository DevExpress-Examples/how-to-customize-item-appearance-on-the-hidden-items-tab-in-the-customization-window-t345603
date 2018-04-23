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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShowHiddenItemsAsTree {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }
    public class HiddenItemTemplateSelector : DataTemplateSelector {
        public DataTemplate ItemTemplate { get; set; }
        public DataTemplate GroupTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container) {
            if(item is DevExpress.Xpf.Docking.LayoutGroup) return GroupTemplate;
            if(item is DevExpress.Xpf.Docking.BaseLayoutItem) return ItemTemplate;
            return base.SelectTemplate(item, container);
        }
    }
}
