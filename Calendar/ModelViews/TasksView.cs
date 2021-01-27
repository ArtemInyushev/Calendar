using Calendar.Models;
using System;
using System.Collections.Generic;

namespace Calendar.ModelViews {
    public class TasksView {
        public TasksView(List<Task> tasks,  DateTime date, DateTime[,] calendar) {
            Tasks = tasks;
            Date = date;
            Calendar = calendar;
        }
        public TasksView(List<Task> tasks, DateTime date) {
            Tasks = tasks;
            Date = date;
            Calendar = null;
        }
        public List<Task> Tasks { get; set; }
        public DateTime Date { get; set; }
        public DateTime [,] Calendar { get; set; }
    }
}
