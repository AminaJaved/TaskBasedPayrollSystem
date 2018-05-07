using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication2
{
    class Employee
    {
        private string sec_question;
        private string sec_answer;
        public string Sec_question
        {
            get { return sec_question; }
            set { sec_question = value; }
        }


        public string Sec_answer
        {
            get { return sec_answer; }
            set { sec_answer = value; }
        }
        public List<Task> contacts = new List<Task>();
        private string employeeName;

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        private string adminName;

        public string AdminName
        {
            get { return adminName; }
            set { adminName = value; }
        }
        private string adminPassword;

        public string AdminPassword
        {
            get { return adminPassword; }
            set { adminPassword = value; }
        }
        private string employeePassword;

        public string EmployeePassword
        {
            get { return employeePassword; }
            set { employeePassword = value; }
        }
        private Image adminImage;

        public Image AdminImage
        {
            get { return adminImage; }
            set { adminImage = value; }
        }
        private Image userImage;

        public Image UserImage
        {
            get { return userImage; }
            set { userImage = value; }
        }
        private string employeeID;

        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
        private string employeeDesignation;

        public string EmployeeDesignation
        {
            get { return employeeDesignation; }
            set { employeeDesignation = value; }
        }

    }
}
