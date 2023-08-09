﻿using Microsoft.Win32.TaskScheduler;
using System.Linq;
using System;
using Task = Microsoft.Win32.TaskScheduler.Task;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreshInkManager
{
    public class TaskSchedulerManager
    {
        private string _taskName = "FreshInk";
        private string _description = "Prints a test page at a specified increment to keep printer ink from drying out.";
        private string _executablePath = "C:\\Users\\Michael\\Desktop\\Software Development\\Dev\\FreshInk\\FreshInk\\bin\\Debug\\FreshInk.exe";
        private Task _task;

        public TaskSchedulerManager()
        {
            using (TaskService taskService = new TaskService())
            {
                if (taskService.RootFolder.AllTasks.Any(t => t.Name.Equals(_taskName, StringComparison.OrdinalIgnoreCase)))
                {
                    _task = taskService.RootFolder.AllTasks.FirstOrDefault(t => t.Name == _taskName);
                }
                else
                {
                    _task = CreateTask(_taskName, _description, _executablePath);
                }

            }
        }

        public void UpdateTask(DateTime dateTime, short interval)
        {
            DailyTrigger trigger = new DailyTrigger(interval);
            trigger.StartBoundary = dateTime;
            SetTrigger(_task, trigger);
        }

        public DateTime GetTriggerStartBoundary()
        {
            return _task.Definition.Triggers[0].StartBoundary;
        }

        public DateTime GetNextRunTime()
        {
            return _task.NextRunTime;
        }

        public string GetExecutablePath()
        {
            return _executablePath;
        }

        public int GetInterval()
        {
            var trigger = _task.Definition.Triggers[0];
            if (trigger is DailyTrigger dailyTrigger)
            {
                return dailyTrigger.DaysInterval;
            }
            return 0;
        }

        private Task CreateTask(string taskName, string description, string executablePath, string arguments = "")
        {
            using (TaskService taskService = new TaskService())
            {
                TaskDefinition taskDefinition = taskService.NewTask();
                taskDefinition.RegistrationInfo.Description = description;

                ExecAction execAction = new ExecAction(executablePath, arguments);
                taskDefinition.Actions.Add(execAction);

                return taskService.RootFolder.RegisterTaskDefinition(taskName, taskDefinition);
            }
        }

        private void SetTrigger(Task task, Trigger trigger)
        {
            task.Definition.Triggers.Clear();
            task.Definition.Triggers.Add(trigger);
            using (TaskService taskService = new TaskService())
            {
                taskService.RootFolder.RegisterTaskDefinition(task.Name, task.Definition);
            }
        }
    }
}
