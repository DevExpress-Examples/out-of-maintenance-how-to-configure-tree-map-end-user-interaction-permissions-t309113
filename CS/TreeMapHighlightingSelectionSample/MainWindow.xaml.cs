using System.Windows;
using Dxtm = DevExpress.Xpf.TreeMap;

namespace TreeMapHighlightingSelectionSample {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }

    public class SelectionModeWrapper {
        public string ModeName { get; set; }
        public Dxtm.SelectionMode Mode { get; set; }
    }
}
