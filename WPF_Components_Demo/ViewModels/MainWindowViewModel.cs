using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Windows;
using Feature.Infrastructure.Interfaces;
using Infrastructure.Base;

namespace WPF_Components_Demo
{
    public class MainWindowViewModel : PropertyChangedBase
    {
        [ImportMany(typeof(IFeatureDemoTopic))]
        private IEnumerable<IFeatureDemoTopic> _featureDemoTopics;

        private ObservableCollection<TopicViewModel> _topicViewModels;

        public ObservableCollection<TopicViewModel> TopicViewModels
        {
            get
            {
                if (_topicViewModels == null)
                {
                    _topicViewModels = new ObservableCollection<TopicViewModel>();
                    LoadTopicViewModels();
                }
                return _topicViewModels;
            }

            set => SetField(ref _topicViewModels, value);
        }

        private SubTopicViewModel _selectedSubTopicViewModel;

        public SubTopicViewModel SelectedSubTopicViewModel
        {
            get => _selectedSubTopicViewModel;
            set
            {
                SetField(ref _selectedSubTopicViewModel, value); 
                OnPropertyChanged(nameof(SelectedIntroductionView));
            }
        }

        public IIntroductionView SelectedIntroductionView
        {
            get
            {
                if (_selectedSubTopicViewModel == null)
                    return null;
                return _selectedSubTopicViewModel.SubTopic.GetIntroductionView();
            }
        }

        private void LoadTopicViewModels()
        {
            foreach (var topic in _featureDemoTopics)
            {
                TopicViewModels.Add(new TopicViewModel(topic));
            }
        }
    }
}
