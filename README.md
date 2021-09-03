# MvvmCross.Plugin.Control
Plugin to MvvCross, automatically search and assign viewmodels to controls.

1. Add plugin in Setup.cs:

```
    public override void LoadPlugins(IMvxPluginManager pluginManager)
    {
        base.LoadPlugins(pluginManager);
            
        pluginManager.EnsurePluginLoaded<MvvmCross.Plugin.Control.Plugin>(true);
    }
```

2. Change control parent class:

```      
    public partial class ButtonsControl : MvxWpfControl
``` 

3. Change control class i xaml:   
```
    <controls:MvxWpfControl
         xmlns:controls="clr-namespace:MvvmCross.Plugin.Control.Platforms.Wpf;assembly=MvvmCross.Plugin.Control.Platforms.Wpf"
``` 
4. Create ViewModel with the same name as Control (but without 'Control' suffix) e.g.: 
     - WindowControl.xaml => WindowViewModel.cs 
     - Footer.xaml => FooterViewModel.cs
     
5. Add on View:
<controls:NavigationBarControl InitializeOnLoad="true" />


Additional attributes:
- InitializeOnLoad => Initialize and display on page load


Check sample for more info.
