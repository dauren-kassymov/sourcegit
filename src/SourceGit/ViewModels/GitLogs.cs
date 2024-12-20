using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace SourceGit.ViewModels
{
    public class GitLogs : ObservableObject
    {
        private ObservableCollection<GitLogEntry> _logs;
        public ObservableCollection<GitLogEntry> Logs
        {
            get => _logs;
            set => SetProperty(ref _logs, value);
        }

        public GitLogs()
        {
            // Add some dummy data for testing
            Logs = new ObservableCollection<GitLogEntry>
            {
                new GitLogEntry 
                { 
                    Date = DateTime.Now.AddDays(-1),
                    Message = "Fix critical bug in authentication module"
                },
                new GitLogEntry
                {
                    Date = DateTime.Now.AddDays(-2), 
                    Message = "Add new feature for user dashboard"
                },
                new GitLogEntry
                {
                    Date = DateTime.Now.AddDays(-3),
                    Message = "Update documentation for API endpoints"
                },
                new GitLogEntry
                {
                    Date = DateTime.Now.AddDays(-4),
                    Message = "Refactor database access layer"
                },
                new GitLogEntry
                {
                    Date = DateTime.Now.AddDays(-5),
                    Message = "Implement user role management system"
                },
                new GitLogEntry
                {
                    Date = DateTime.Now.AddDays(-6),
                    Message = "Add email notification service"
                },
                new GitLogEntry
                {
                    Date = DateTime.Now.AddDays(-7),
                    Message = "Fix pagination in search results"
                },
                new GitLogEntry
                {
                    Date = DateTime.Now.AddDays(-8),
                    Message = "Optimize database queries for better performance"
                },
                new GitLogEntry
                {
                    Date = DateTime.Now.AddDays(-9),
                    Message = "Add unit tests for core services"
                },
                new GitLogEntry
                {
                    Date = DateTime.Now.AddDays(-10),
                    Message = "Implement file upload functionality"
                },
                new GitLogEntry
                {
                    Date = DateTime.Now.AddDays(-11),
                    Message = "Update third-party dependencies"
                },
                new GitLogEntry
                {
                    Date = DateTime.Now.AddDays(-12),
                    Message = "Add logging for error tracking"
                },
                new GitLogEntry
                {
                    Date = DateTime.Now.AddDays(-13),
                    Message = "Implement password reset flow"
                },
                new GitLogEntry
                {
                    Date = DateTime.Now.AddDays(-14),
                    Message = "Add caching layer for API responses"
                },
                new GitLogEntry
                {
                    Date = DateTime.Now.AddDays(-15),
                    Message = "Fix cross-browser compatibility issues"
                },
                new GitLogEntry
                {
                    Date = DateTime.Now.AddDays(-16),
                    Message = "Implement real-time notifications"
                },
                new GitLogEntry
                {
                    Date = DateTime.Now.AddDays(-17),
                    Message = "Add data export functionality"
                },
                new GitLogEntry
                {
                    Date = DateTime.Now.AddDays(-18),
                    Message = "Update UI components to new design"
                },
                new GitLogEntry
                {
                    Date = DateTime.Now.AddDays(-19),
                    Message = "Implement multi-language support"
                },
                new GitLogEntry
                {
                    Date = DateTime.Now.AddDays(-20),
                    Message = "Add API rate limiting"
                },
                new GitLogEntry
                {
                    Date = DateTime.Now.AddDays(-21),
                    Message = "Fix security vulnerabilities"
                },
                new GitLogEntry
                {
                    Date = DateTime.Now.AddDays(-22),
                    Message = "Implement OAuth authentication"
                },
                new GitLogEntry
                {
                    Date = DateTime.Now.AddDays(-23),
                    Message = "Add automated deployment pipeline"
                },
                new GitLogEntry
                {
                    Date = DateTime.Now.AddDays(-24),
                    Message = "Update error handling system"
                }
            };
        }
    }

    public class GitLogEntry
    {
        public DateTime Date { get; set; }
        public string Message { get; set; }
    }
}