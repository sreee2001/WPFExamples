# WPFExamples

## Introduction

**WPFExamples** showcases custom implementations of various components in the Windows Presentation Foundation (WPF) framework using C#. The repository is designed to help developers understand, extend, and apply WPF concepts in their own projects. Each subproject demonstrates best practices for building UI controls, infrastructure features, and integration with .NET Framework libraries.

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

### 1. BasicControls
- **Role:** Contains demos and sample code for foundational WPF controls (buttons, textboxes, etc.), illustrating customization and event handling.

### 2. Feature.Infrastructure
- **Role:** Provides infrastructure code (helpers, services, data access) to support scalable WPF applications. This layer demonstrates separation of concerns and reusable patterns.

### 3. WPF_Components_Demo
- **Role:** A full-featured demo application aggregating various components, showcasing integration and advanced scenarios.

---

## Submodules & Their Roles

### DotnetFrameworkReferenceLibraries
- **Role:** Contains reference libraries for .NET Framework integration, enabling extended functionality and compatibility for WPF projects.

---

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

To add a new custom control, for example a `CustomSlider`, follow these steps:

1. **Add a new control class:**
   ```csharp
   // BasicControls/CustomSlider.xaml.cs
   public partial class CustomSlider : UserControl
   {
       public CustomSlider()
       {
           InitializeComponent();
       }

       // Extend with custom properties and events
   }
   ```
2. **Add XAML for the UI:**
   ```xml
   <!-- BasicControls/CustomSlider.xaml -->
   <UserControl x:Class="BasicControls.CustomSlider"
                ...>
       <Slider Minimum="0" Maximum="100" Value="{Binding CustomValue}" />
   </UserControl>
   ```
3. **Register and use your new control in the demo project (WPF_Components_Demo).**

---

## License

See [LICENSE.txt](https://github.com/sreee2001/WPFExamples/blob/master/LICENSE.txt) for details.