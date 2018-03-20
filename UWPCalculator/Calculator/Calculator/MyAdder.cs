using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Calculator
{
    class MyAdder : INotifyPropertyChanged
    {
        private int topValue;
        private int bottomValue;
        private int answerValue;

        public event PropertyChangedEventHandler PropertyChanged;

        public int BottomValue
        {
            set
            {
                bottomValue = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("AnswerValue"));
                }
            }
            get
            {
                return bottomValue;
            }
        }

        public int TopValue
        {
            set
            {
                topValue = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("AnswerValue"));
                }
            }
            get
            {
                return topValue;
            }
        }

        public int AnswerValue
        {

            get
            {
                return bottomValue + topValue;
            }
        }

    }
}
