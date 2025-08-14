using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Windows;
using WPF_Components_Demo.Views;

namespace WPF_Components_Demo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public CompositionContainer Container { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            SetupCompositionContainer();

            // Show the main window
            ShowMainWindow();
        }

        private void ShowMainWindow()
        {
            var mainWindowViewModel = new MainWindowViewModel();
            // Compose the main window view model with the container
            try
            {
                Container.ComposeParts(mainWindowViewModel);
            }
            catch (CompositionException compositionException)
            {
                Console.WriteLine($"Error during composition: {compositionException.Message}");
                return;
            }

            var mainWindow = new MainWindow() { DataContext = mainWindowViewModel };
            try
            {
                Container.ComposeParts(mainWindow);
            }
            catch (CompositionException compositionException)
            {
                Console.WriteLine($"Error during composition: {compositionException.Message}");
                return;
            }
            mainWindow.Show();
        }

        private void SetupCompositionContainer()
        {
            // This method is used to set up the MEF composition container if needed.
            // It can be implemented in the App.xaml.cs file to load features dynamically.
            // Create an aggregate catalog for all parts
            var catalog = new AggregateCatalog();

            // Add the current assembly (or others as needed)
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(App).Assembly));

            // This will be mandatory list of assemblies that needs to be loaded at the minimum
            //catalog.Catalogs.Add(new DirectoryCatalog("BasicControls"));

            // Add directory catalogs for plugins/features
            // these will be picked dynamically from the Addons directory
            //catalog.Catalogs.Add(new DirectoryCatalog(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, WPF_Components_Demo.Properties.Resources.FeaturesDemo)));
            catalog.Catalogs.Add(new DirectoryCatalog(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, WPF_Components_Demo.Properties.Resources.AddonsDirectory)));

            // Create the container
            Container = new CompositionContainer(catalog);

            // Compose the parts (this will automatically import any dependencies)
            try
            {
                Container.ComposeParts(this);
            }
            catch (CompositionException compositionException)
            {
                Console.WriteLine($"Error during composition: {compositionException.Message}");
            }
        }
    }
}