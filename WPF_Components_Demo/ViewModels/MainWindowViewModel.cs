using Feature.Infrastructure.Core;
using Feature.Infrastructure.Interfaces;
using Infrastructure.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using WPF_Components_Demo.Views;

namespace WPF_Components_Demo
{
    public class MainWindowViewModel : PropertyChangedBase
    {
        #region Imports

        [ImportMany(typeof(IFeatureDemoTopic))]
        private IEnumerable<IFeatureDemoTopic> _featureDemoTopics;

        [ImportMany]
        private IEnumerable<Lazy<IIntroductionViewModel, IHaveTitle>> _introductionViewModels;

        [ImportMany]
        private IEnumerable<Lazy<IDemonstrationViewModel, IHaveTitle>> _allDemonstrationViewModels;

        #endregion

        #region Private Members

        private ObservableCollection<TopicViewModel> _topicViewModels;
        private SubTopicViewModel _selectedSubTopicViewModel;
        private ICommand _launchDemoCommand;

        private void LoadTopicViewModels()
        {
            foreach (var topic in _featureDemoTopics)
            {
                TopicViewModels.Add(new TopicViewModel(topic));
            }
        }

        private void LaunchDemo(IFeatureDemoSubTopic subTopic)
        {
            IEnumerable<Lazy<IDemonstrationViewModel, IHaveTitle>> enumerable = _allDemonstrationViewModels.Where(b => b.Metadata.Title == subTopic.Title);
            IEnumerable<IDemonstrationViewModel> ViewModels = enumerable
                            .Select(b => b.Value);
            var viewModel = ViewModels.FirstOrDefault();
            if (viewModel == null)
            {
                MessageBox.Show($"No demonstration viewModel found for {subTopic.Title}");
                return;
            }
            var demoWindow = new DemoWindow()
            {
                Title = subTopic.Title,
                DataContext = viewModel
            }.ShowDialog();
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
                OnPropertyChanged(nameof(SelectedIntroductionViewModel));
                OnPropertyChanged(nameof(IsSubTopicSelected));
                OnPropertyChanged(nameof(IsDemoViewAvailable));
            }
        }

        public bool IsSubTopicSelected
        {
            get
            {
                return SelectedSubTopicViewModel != null;
            }
        }

        public IIntroductionViewModel SelectedIntroductionViewModel
        {
            get
            {
                if (_selectedSubTopicViewModel == null)
                    return null;

                var data = _introductionViewModels.Where(b => b.Metadata.Title == _selectedSubTopicViewModel.SubTopic.Title);

                return data.Select(b => b.Value).FirstOrDefault();
            }
        }

        public ICommand LaunchDemoCommand
        {
            get
            {
                if (_launchDemoCommand == null)
                {
                    _launchDemoCommand = new RelayCommand(
                        executeParam =>
                        {
                            if (SelectedSubTopicViewModel != null)
                            {
                                LaunchDemo(SelectedSubTopicViewModel.SubTopic);
                            }
                        }/*, 
                        canExecuteParam =>
                        {
                            return SelectedSubTopicViewModel != null;
                        }*/
                        );
                }
                return _launchDemoCommand;
            }
        }

        public bool IsDemoViewAvailable
        {
            get
            {
                if (SelectedSubTopicViewModel == null || SelectedSubTopicViewModel.SubTopic == null || SelectedSubTopicViewModel.SubTopic.Title == null)
                    return false;

                IEnumerable<Lazy<IDemonstrationViewModel, IHaveTitle>> enumerable = _allDemonstrationViewModels.Where(b => b.Metadata.Title == SelectedSubTopicViewModel.SubTopic.Title);
                IEnumerable<IDemonstrationViewModel> ViewModels = enumerable
                                .Select(b => b.Value);
                var viewModel = ViewModels.FirstOrDefault();
                return viewModel != null;
            }
        }

    }
}
