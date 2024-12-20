using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using SourceGit.Models;

namespace SourceGit.ViewModels
{
    public class GitLogs : ObservableObject
    {
        private ObservableCollection<GitLog> _logs;
        public ObservableCollection<GitLog> Logs
        {
            get => _logs;
            set => SetProperty(ref _logs, value);
        }

        public GitLogs()
        {
            Logs = new ObservableCollection<GitLog>();
            foreach (var log in Services.GitLogsList.Logs)
            {
                Logs.Add(log);
            }
        }
    }
}