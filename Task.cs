using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Task
    {
        private bool task_Done;

        public bool Task_Done
        {
            get { return task_Done; }
            set { task_Done = value; }
        }
        private string empName;

        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }
        private string task;

        public string Tasks
        {
            get { return task; }
            set { task = value; }
        }
        //private string designation;

        //public string Designation
        //{
        //    get { return designation; }
        //    set { designation = value; }
        //}
        private string taskDetails;

        public string TaskDetails
        {
            get { return taskDetails; }
            set { taskDetails = value; }
        }
        
    }
}
