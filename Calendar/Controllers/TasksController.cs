using Calendar.Models;
using Calendar.ModelViews;
using Calendar.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Calendar.Controllers {
    public class TasksController: Controller {
        [HttpGet("Calendar")]
        [HttpGet("~/")]
        public IActionResult ShowCalendar(int? y, int? m) {
            using(TaskContext db = new TaskContext()) {
                string path = "~/views/Calendar.cshtml";
                DateTime date;
                if (y.HasValue && m.HasValue) {
                    date = new DateTime(y.Value, m.Value, 1);
                }
                else {
                    date = DateTime.Now;
                }
                List<Task> tasks = (from t in db.Tasks
                                   where t.Month == date.Month && t.Year == date.Year
                                   select t).ToList();
                TasksView tasksView = new TasksView(tasks, date, Calendar.getCalendar(date));
                return View(path, tasksView);
            }
        }
        [HttpGet("Tasks")]
        public IActionResult Tasks(int y, int m, int d) {
            using (TaskContext db = new TaskContext()) {
                List<Task> tasks = (from t in db.Tasks
                                    where t.Month == m && t.Year == y && t.Day == d
                                    select t).ToList();
                TasksView tasksView = new TasksView(tasks, new DateTime(y, m, d));
                return View("~/views/Tasks.cshtml", tasksView);
            }
        }
        [HttpPost("Delete/Task")]
        public IActionResult DeleteTask(int id) {
            using (TaskContext db = new TaskContext()) {
                var task = from t in db.Tasks
                           where t.Id == id
                           select t;
                db.RemoveRange(task);
                db.SaveChanges();
            }
            return Redirect(Request.Headers["Referer"].ToString());
        }
        [HttpPost("Add/Task")]
        public IActionResult AddTask(Task task) {
            using (TaskContext db = new TaskContext()) {
                db.Add(task);
                db.SaveChanges();
            }
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
