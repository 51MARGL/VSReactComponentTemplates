using Microsoft.VisualStudio.PlatformUI;
using System.Windows;

namespace ReactComponentWizard
{
    /// <summary>
    /// Interaction logic for ReactComponentWizardWindow.xaml
    /// </summary>
    public partial class ReactComponentWizardWindow : DialogWindow
    {
        public ReactComponentWizardWindow()
        {
            InitializeComponent();
            CreateFolder.IsChecked = true;
            CreateScss.IsChecked = true;
            CreateIndex.IsChecked = true;
            WithProps.IsChecked = true;
        }
        private void FinishButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
