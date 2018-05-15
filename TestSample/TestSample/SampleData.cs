using System.ComponentModel;

namespace TestSample
{
    public class SampleData : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }
    }
}