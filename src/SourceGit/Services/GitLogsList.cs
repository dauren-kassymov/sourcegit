using System;
using System.Collections.Generic;
using SourceGit.Models;

namespace SourceGit.Services
{
    public static class GitLogsList
    {
        private static readonly List<GitLog> _logs = new();
        private const int MAX_LOGS = 20;

        public static IReadOnlyList<GitLog> Logs => _logs.AsReadOnly();

        public static void AddLog(string message)
        {
            _logs.Add(new GitLog 
            { 
                DateTime = DateTime.Now,
                Message = message
            });

            if (_logs.Count > MAX_LOGS)
            {
                _logs.RemoveAt(0);
            }
        }
    }
}