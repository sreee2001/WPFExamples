using System;

using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Feature.Infrastructure.Interfaces;

namespace WPF_Components_Demo
{
    public class SubTopicViewModel
    {
        [ImportMany]
        private IEnumerable<Lazy<IDemonstrationView, IHaveTitle>> _allDemonstrationViews;

        public string Title { get; set; }
        public IFeatureDemoSubTopic SubTopic { get; set; }
        public ICommand LaunchDemoCommand { get; set; }
        public bool IsExpanded { get; set; } = true;
        public SubTopicViewModel(IFeatureDemoSubTopic subTopic)
        {
            Title = subTopic.Title;
            SubTopic = subTopic;
            LaunchDemoCommand = new RelayCommand(_ =>
            {
                IEnumerable<Lazy<IDemonstrationView, IHaveTitle>> enumerable = _allDemonstrationViews.Where(b => b.Metadata.Title == subTopic.Title);
                IEnumerable<IDemonstrationView> views = enumerable
                                .Select(b => b.Value);
                var view = views.FirstOrDefault();
                if (view == null)
                {
                    MessageBox.Show($"No demonstration view found for {subTopic.Title}");
                    return;
                }
                var topicDemoWindow = view as Window;
                if (topicDemoWindow == null)
                {
                    MessageBox.Show($"The view for {subTopic.Title} is not a Window.");
                    return;
                }
                if ((topicDemoWindow.IsLoaded && !topicDemoWindow.IsVisible) ||
                !topicDemoWindow.IsLoaded)
                {
                    // If the window is not loaded or is not visible, create a new instance
                    // to ensure it can be shown again.
                    {
                        topicDemoWindow = Activator.CreateInstance(topicDemoWindow.GetType()) as Window;
                    }
                }
                topicDemoWindow?.ShowDialog();
            });
        }
    }
}
