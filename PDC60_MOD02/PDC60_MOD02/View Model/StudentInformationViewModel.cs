using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using PDC60_MOD02.Model;


using Xamarin.Forms;

namespace PDC60_MOD02.View_Model
{
    class StudentInformationViewModel: INotifyPropertyChanged
    {
        public StudentInformation StudentInfo { get; set; }
        public Command CommandInformationUpdate { get; set; }

        public int sID { get; set; }
        public string Sname { get; set; }

        public StudentInformationViewModel()
        {
            CommandInformationUpdate = new Command(()=>               
            {
                StudentInfo = new StudentInformation
                {
                    StudentID = sID,
                    StudentName = Sname
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
