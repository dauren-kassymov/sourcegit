using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace SourceGit.Views
{
    public partial class GitLogs : Window
    {
        public GitLogs()
        {
            InitializeComponent();
        }
        
        private void BeginMoveWindow(object sender, PointerPressedEventArgs e)
        {
            BeginMoveDrag(e);
        }
        
        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}