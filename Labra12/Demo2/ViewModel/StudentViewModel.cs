using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo2.Model;
using System.Collections.ObjectModel;

namespace Demo2.ViewModel
{
    public class StudentViewModel
    {
        public ObservableCollection<Student> Students
        {
            get;
            set;
        }
        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();
            // lisätään esimerkin vuoksi muutama opiskelija, oikeassa sovelluksessa haettaisin esim tietokannasta
            students.Add(new Student { FirstName = "Kalle", LastName = "Jalkanen", AsioId="A1234" });
            students.Add(new Student { FirstName = "Teppo", LastName = "Testaaja", AsioId = "B1234" });
            students.Add(new Student { FirstName = "Tomi", LastName = "Töttenström", AsioId = "C1234" });
            students.Add(new Student { FirstName = "Matias", LastName = "Hepponen", AsioId = "D1234" });
            Students = students;
        }
    }
}
