using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vhuthuhaweStudyGroup.ViewModels
{
    public class StudentsViewModel
    {
        private string _studentNumber;
        private string _name;
        private string _surname;
        private string _email;

        public StudentsViewModel(string studentNumber, string name, string surname, string email)
        {
            _studentNumber = studentNumber;
            _name = name;
            _surname = surname;
            _email = email;
        }

        public string StudentNumber
        {
            get { return _studentNumber; }
            set { _studentNumber = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }   
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

    }
}