using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Windows;
using Feature.Infrastructure.Core;
using Feature.Infrastructure.Interfaces;
using Infrastructure.Base;

namespace WPF_Components_Demo
{
    public class MainWindowViewModel : PropertyChangedBase
    {
        #region Imports

        [ImportMany(typeof(IFeatureDemoTopic))]
        private IEnumerable<IFeatureDemoTopic> _featureDemoTopics;

        [ImportMany]
        private IEnumerable<Lazy<IIntroductionView, IHaveTitle>> _introductionViews;

        #endregion

        #region Private Members

        private ObservableCollection<TopicViewModel> _topicViewModels;
        private SubTopicViewModel _selectedSubTopicViewModel;
        private void LoadTopicViewModels()
        {
            foreach (var topic in _featureDemoTopics)
            {
                TopicViewModels.Add(new TopicViewModel(topic));
            }
        }

        #endregion


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

                var data = _introductionViews.Where(b => b.Metadata.Title == _selectedSubTopicViewModel.SubTopic.Title);

                return data.Select(b => b.Value).FirstOrDefault();
            }
        }

    }
}
