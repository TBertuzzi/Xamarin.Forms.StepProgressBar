# Xamarin.Forms.StepProgressBar

Add a step rogress bar in your Xamarin.Forms project.

You can choose between a square or circular control.
 
###### This is the component, works on iOS, Android and UWP.



![](https://github.com/TBertuzzi/Xamarin.Forms.StepProgressBar/blob/master/Resources/stepBarSample.png?raw=true)

**NuGet**


|Name|Info|
| ------------------- | :------------------: |
|Xamarin.Forms.StepProgressBar|[![NuGet](https://img.shields.io/badge/nuget-1.0.1-blue.svg)](https://www.nuget.org/packages/Xamarin.Forms.StepProgressBar/)|


**Platform Support**

MultiSelectListView is a .NET Standard 2.0 library.Its only dependency is the Xamarin.Forms

## Setup / Usage

Does not require additional configuration. Just install the package in the shared project and use.

You just need to add the reference in your xaml file.

```csharp
  xmlns:control="clr-namespace:Xamarin.Forms.StepProgressBar;assembly=Xamarin.Forms.StepProgressBar"
```

Control

```csharp

  <control:StepProgressBar x:Name="stepbar1" Margin="60,0,60,0" StepCanTouch = "true" 
               StepColor="Red"  Steps="{Binding Steps}" StepSelected="{Binding Step}" IsCircle= "true" />

```

Available properties

* StepCanTouch: Indicates if it is possible to interact with the step. If marked false does not trigger the event.
* StepColor: Control color. Hexadecimal can be used.
* Steps: Number of steps to display.
* StepSelected: Indicates which step is selected.
* IsCircle: Indicates whether the control will be a circle. If marked as false, use a square to display the step.

The complete example can be downloaded here: https://github.com/TBertuzzi/Xamarin.Forms.StepProgressBar/tree/master/StepProgressBarSample


