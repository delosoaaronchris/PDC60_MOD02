using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using PDC60_MOD02.Model;


using Xamarin.Forms;
using static System.Collections.Specialized.BitVector32;

namespace PDC60_MOD02.View_Model
{
    class StudentInformationViewModel: INotifyPropertyChanged
    {
        public StudentInformation StudentInfo { get; set; }
        public Command CommandInformationUpdate { get; set; }

        public int sID { get; set; }
        public string Sname { get; set; }
        public int sLevel { get; set; }
        public string sSection { get; set; }
   
        public string sCourseCode { get; set; }
        public string sCourse { get; set; }


        public StudentInformationViewModel()
        {
            CommandInformationUpdate = new Command(()=>               
            {
                StudentInfo = new StudentInformation
                {
                    StudentID = sID,
                    StudentName = Sname,
                    YearLevel = sLevel,
                    Section = sSection,
                    CourseCode = sCourseCode,
                    Course = sCourse
                };
                OnPropertyChanged(nameof(StudentInfo));
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
