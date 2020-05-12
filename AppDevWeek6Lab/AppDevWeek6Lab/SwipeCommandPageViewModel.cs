using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System;
using Xamarin.Forms;

namespace AppDevWeek6Lab
{
    public class SwipeCommandPageViewModel : INotifyPropertyChanged
    {
        public ICommand SwipeCommand => new Command<string>(Swipe);

        public string FileDescription { get; private set; }

        public string ImageName { get; private set; }
        private int index=0;
        private List<string> FileNames = new List<string>(new string[] { "granigrind.jpg", "coffindance.jpg", "pepsiman.jpg", "scorpioncrab.jpg" });
        private List<string> FileDescriptions = new List<string>(new string[] { "I swear today isn't the last day of an event and I need to grind harder. ", "The coffin dancers have come.","Pepsiman. Have you taken a sip today?","Oh no the crab has a gun. Oh god no."});
        public SwipeCommandPageViewModel()
        {
            FileDescription = "Grani cheering you on to farm harder. ";
            ImageName = "granigrind.jpg";
        }

        void Swipe(string value)
        {
            index += value == "Right" ? 1 : -1;
            FileDescription = FileDescriptions.ToArray()[Math.Abs(index) % FileNames.Count];
            ImageName = FileNames.ToArray()[Math.Abs(index) % FileNames.Count];
            OnPropertyChanged("FileDescription");
            OnPropertyChanged("ImageName");
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
