using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Windows.Input;
using Feature.Infrastructure.Interfaces;

namespace WPF_Components_Demo
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<TopicViewModel> Topics { get; set; } = new ObservableCollection<TopicViewModel>();

        public MainWindowViewModel()
        {
            LoadTopics();
        }

        private void LoadTopics()
        {
            var catalog = new DirectoryCatalog(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "FeaturesDemo"));
            var container = new CompositionContainer(catalog);
            var topics = container.GetExportedValues<IFeatureDemoTopic>().ToList();
            foreach (var topic in topics)
            {
                container.SatisfyImportsOnce(topic);
                Topics.Add(new TopicViewModel(topic));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class TopicViewModel
    {
        public string Title { get; set; }
        public ObservableCollection<SubTopicViewModel> SubTopics { get; set; } = new ObservableCollection<SubTopicViewModel>();
        public TopicViewModel(IFeatureDemoTopic topic)
        {
            Title = topic.Title;
            foreach (var sub in topic.SubTopics)
            {
                SubTopics.Add(new SubTopicViewModel(sub));
            }
        }
    }

    public class SubTopicViewModel
    {
        public string Title { get; set; }
        public IFeatureDemoSubTopic SubTopic { get; set; }
        public ICommand LaunchDemoCommand { get; set; }
        public SubTopicViewModel(IFeatureDemoSubTopic subTopic)
        {
            Title = subTopic.Title;
            SubTopic = subTopic;
            LaunchDemoCommand = new RelayCommand(_ => SubTopic.LaunchDemoWindow());
        }
    }

    public class RelayCommand : ICommand
    {
        private readonly System.Action<object> _execute;
        private readonly System.Func<object, bool> _canExecute;
        public RelayCommand(System.Action<object> execute, System.Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }
        public bool CanExecute(object parameter) => _canExecute == null || _canExecute(parameter);
        public void Execute(object parameter) => _execute(parameter);
        public event System.EventHandler CanExecuteChanged { add { } remove { } }
    }
}
