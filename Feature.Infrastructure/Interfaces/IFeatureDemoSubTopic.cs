namespace Feature.Infrastructure.Interfaces
{
    public interface IFeatureDemoSubTopic
    {
        string Title { get; }
        void LaunchDemoWindow();
        // Optionally, you can add a method to set an introduction page if needed
    }
}
