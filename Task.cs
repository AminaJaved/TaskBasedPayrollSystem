using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Task
    {
        private string task;

        public string Tasks
        {
            get { return task; }
            set { task = value; }
        }
        private string designation;

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }
        private string taskDetails;

        public string TaskDetails
        {
            get { return taskDetails; }
            set { taskDetails = value; }
        }
    }
}
