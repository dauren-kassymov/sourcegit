using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

using SourceGit.Models;

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

        private void OnGridDoubleTapped(object sender, TappedEventArgs e)
        {
            if (e.Source is TextBlock textBlock && 
                textBlock.DataContext is GitLog log)
            {
                // Copy the message to clipboard
                Clipboard?.SetTextAsync(log.Message);
            }
        }
    }
}