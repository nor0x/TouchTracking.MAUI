<img src="https://raw.githubusercontent.com/nor0x/TouchTracking.MAUI/main/Art/packageicon.png" width="320px" />

# TouchTracking.MAUI 👆
[![.NET](https://github.com/nor0x/TouchTracking.MAUI/actions/workflows/dotnet.yml/badge.svg)](https://github.com/nor0x/TouchTracking.MAUI/actions/workflows/dotnet.yml)
[![](https://img.shields.io/nuget/v/Plugin.MAUI.TouchTracking)](https://www.nuget.org/packages/Plugin.MAUI.TouchTracking)
[![](https://img.shields.io/nuget/dt/Plugin.MAUI.TouchTracking)](https://www.nuget.org/packages/Plugin.MAUI.TouchTracking)

TouchTracking provides unified API for multi-touch gestures in .NET MAUI. It is a hard-fork of [TouchTracking.Forms](https://www.nuget.org/packages/TouchTracking.Forms) upgraded to .NET MAUI - it has a similar API and functionality as the original library.

## Usage
Install the [Plugin.MAUI.TouchTracking](https://www.nuget.org/packages/Plugin.MAUI.TouchTracking) NuGet package.

Add TouchTrackingBehavior to your view in XAML:
```xml
<!-- add namespace -->
xmlns:tt="clr-namespace:TouchTracking;assembly=TouchTracking.MAUI"

<!-- add behavior to any view -->
<Image.Behaviors>
	<tt:TouchTrackingBehavior TouchAction="OnTouchAction" />
</Image.Behaviors>
```

TouchAction with TouchActionEventArgs will be called on every touch event:
```csharp
void OnTouchAction(object sender, TouchActionEventArgs args)
{
	Status.Text = $"Capture: {MyTouchBehavior.Capture}, " +
		$"Id: {args.Id}, " +
		$"Touch: {args.Type}, " +
		$"Location: {args.Location.X}, {args.Location.Y}, " +
		$"IsInContact: {args.IsInContact}, ";
}
```

### not finalized yet
please note that the API is not finalized yet and might change in the future. Currently it should be easy to upgrade from the original package - I will most likely add some new features in the future. If you have any suggestions or feature requests, feel free to open an issue or a pull request.


## Credits
TouchTracking.MAUI is hard-forked from TouchTrack.Forms in [SkiaScene](https://github.com/OndrejKunc/SkiaScene). Credits to the original author and contributors.