using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StepProgressBarSample.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        #region Property

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion

        private int _step;
        public int Step
        {
            get { return _step; }
            set
            {
                this.SetProperty(ref _step, value);
            }
        }



        private int _steps;
        public int Steps
        {
            get { return _steps; }
            set
            {
                this.SetProperty(ref _steps, value);
            }
        }


        public MainViewModel()
        {

            Steps = 4;
        }
    }
}
