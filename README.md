# WPFExamples

## Introduction
<!--
**WPFExamples** showcases implementations of various components in the Windows Presentation Foundation (WPF) framework using C#. The repository is designed to help developers understand, extend, and apply WPF concepts in their own projects. Each subproject demonstrates best practices for building UI controls, infrastructure features, and integration with .NET Framework libraries.
-->

**WPFExamples** is a trial ground project to show case different components in Windows Presentation Foundation (WPF) framework using C#.
The goal is the show example implementations of each component, categorically and logically organized. In some cases, allow  the user to see existing examples and in few limited cases even control the parameters and see how the changes look in real time for simple Controls.

**Note**: The primary purpose is to get a look and feel on how an UI element is visible and how we can control it. Not learn how to code it.

If you want to learn about WPF, there are some nice tutorials available online.

---

## Table of Contents

1. [BasicControls](#basiccontrols)
2. [Feature.Infrastructure](#featureinfrastructure)
3. [WPF_Components_Demo](#wpfcomponentsdemo)
4. [DotnetFrameworkReferenceLibraries (Submodule)](#dotnetframeworkreferencelibraries-submodule)
5. [Architectural Overview](#architectural-overview)
6. [Code Schema](#code-schema)
7. [How to Extend](#how-to-extend)
8. [License](#license)

---

## Projects & Their Roles

### Core Projects

#### 1. Feature.Infrastructure
- **Role:** Provides infrastructure code that defines interfaces needed for Feature based Demonstrations. This will be Foundational project that other Feature Project will depend on
- Key Interfaces:
  * `IFeatureDemoTopic` - This is the primary contract that new Demo Classes will implement(i.e. Controls). This Topic and its SubTopics are directly displayed in Table of Contents for Demo.
  * `IFeatureDemoSubTopic` - This is the contract for the sub topics (i.e. Buttons, Labels, ComboBoxes) etc
  * `ISubTopicMetadata` - Metadata needed for SubTopic to be binded to Topic (i.e. Topic: Control, SubTopic: Button Examples)

#### 2. Submodules & Their Roles

#### DotnetFrameworkReferenceLibraries
- **Role:** Contains reference libraries for .NET Framework integration, enabling extended functionality and compatibility for WPF projects.

#### 3. WPF_Components_Demo
- **Role:** Contains demos and sample code for foundational WPF controls (buttons, textboxes, etc.), illustrating customization and event handling.

### Extension Projects
**Info** These are to be created as WPF .Net Framework Class Libraries. They should output their binaries to `$(SolutionDir)/bin/$(Configuration)/FeaturesDemo` folder for MEF to pickup

#### BasicControls
**Role** This porject is created to showcase basic controls like Label, TextBox, TextBlock, Combobox etc.

## Architectural Overview

The repository follows a modular architecture:

- **UI Layer:** (BasicControls, WPF_Components_Demo)
  - Focuses on presentation, user interaction, and UI customization.
- **Infrastructure Layer:** (Feature.Infrastructure)
  - Handles business logic, data access, and common utilities.
- **External Libraries:** (DotnetFrameworkReferenceLibraries)
  - Provides additional .NET Framework capabilities as needed.

Each module is self-contained but designed to interoperate via shared interfaces and data models.

---

## Code Schema (Auto-Generated Example)

Here’s an example schema describing typical structure:

```
WPFExamples/
│
├── BasicControls/
│   ├── ButtonDemo.xaml.cs
│   ├── TextBoxDemo.xaml.cs
│   └── ...
├── Feature.Infrastructure/
│   ├── Service/
│   │   └── LoggingService.cs
│   ├── Helpers/
│   │   └── DataHelper.cs
│   └── ...
├── WPF_Components_Demo/
│   ├── MainWindow.xaml.cs
│   ├── ViewModels/
│   │   └── MainViewModel.cs
│   └── ...
├── DotnetFrameworkReferenceLibraries/ (submodule)
│   └── ...
└── WPFExamples.sln
```

---

## Sample Code: How to Extend

To add a new demo for a feature, for example a demo for SubTopic `Border` under Topic `Additional Controls`, follow these steps:

1. **Reuse an existing Addin Project** created earlier for `Additional Controls` OR
2. **Create a new .Net Framework WPF Class Library**. Call it `AdditionalControls`
3. For this example I am assuming the latter
4. Set its output Directory to `$(SolutionDir)/bin/$(Configuration)/Addons`
5. **Add a new FeatureDemoTopic and SubFeatureDemoTopic classes:**
  ```csharp
  // AdditionalControls/BorderExample.cs
  namespace AdditionalControls
  {
      public class AdditionalControlsMetaDataKeys
      {
          public const string Title = "Additional Controls";
      }
      
      [Export(typeof(IFeatureDemoTopic))]
      public class AdditionalControls : FeatureDemoTopic
      {
          public override string Title => AdditionalControlsMetaDataKeys.Title;
      }
      
      [Export(typeof(IFeatureDemoSubTopic))]
      [ExportMetadata(MetaDataKeys.TopicName, AdditionalControlsMetaDataKeys.Title)]
      public class BorderSubTopic : IFeatureDemoSubTopic
      {
          public string Title => "Border Samples";
          public void LaunchDemoWindow()
          {
              // Logic to launch Border Sample demo window
              var borderExampleView = new Views.BorderExampleView();
              borderExampleView.ShowDialog();
          }
      }
  }
  ```
6. **Add a new Window for the UI: .xaml and backing .cs**
   ```xml
   <!-- AdditionalControls/View/borderExampleView.xaml -->
    <Window x:Class="AdditionalControls.Views.borderExampleView"
                 ...>
        <StackPanel>
            <TextBlock Text="Different Border Styles in WPF" FontSize="18" FontWeight="Bold" Margin="0,0,0,10" HorizontalAlignment="Center"/>
            <ItemsControl ItemsSource="{Binding BorderSamples}">
                <ItemsControl.ItemTemplate>
                    <DataTemplate>
                        <StackPanel Orientation="Vertical" >
                           ...
                        </StackPanel>
                    </DataTemplate>
                </ItemsControl.ItemTemplate>                
            </ItemsControl>
        </StackPanel>
    </Window>
   ```

   ```C#
    namespace AdditionalControls.Views
    {
        /// <summary>
        /// Interaction logic for BorderExampleView.xaml
        /// </summary>
        public partial class BorderExampleView : Window
        {
            public BorderExampleView()
            {
                InitializeComponent();
                DataContext = new ViewModels.BorderExampleViewModel();
            }
        }
    }
   ```
7. **Add viewmodel AdditionalControls.ViewModels.BorderExampleViewModel**
   ````C#
   internal class LabelExampleViewModel : PropertyChangedBase
   {
     public ObservableCollection<LabelExample> LabelSamples {get; set;}
   }
   ````
8. **Add model AdditionalControls.Models.BorderExample**
   ````C#
   internal class LabelExample {} // add any properties you want to control
   ````
---

## License

See [LICENSE.txt](https://github.com/sreee2001/WPFExamples/blob/master/LICENSE.txt) for details.
