using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfStudy.Annotations;

/*
 * 源数据对象准备
 * 
 * 
*/

namespace WpfStudy.Binding
{
    public class Student :INotifyPropertyChanged
    {
        private int m_ID;
        private string m_StudentName;
        private double m_Score;

        public int ID
        {
            get { return m_ID; }
            set
            {
                if (value != m_ID)
                {
                    m_ID = value;
                    OnPropertyChanged("ID");
                }
            }
        }

        public string StudentName
        {
            get { return m_StudentName; }
            set
            {
                if (value != m_StudentName)
                {
                    m_StudentName = value;
                    OnPropertyChanged("StudentName");
                }
            }
        }

        public double Score
        {
            get { return m_Score; }
            set
            {
                if (value != m_Score)
                {
                    m_Score = value;
                    OnPropertyChanged("Score");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
