using TouchTracking.iOS;
using UIKit;

namespace TouchTracking;

public partial class TouchTrackingBehavior : PlatformBehavior<View, UIView>
{
	private TouchHandler? _touchHandler;

	protected override void OnAttachedTo(View bindable, UIView platformView)
	{
		base.OnAttachedTo(bindable, platformView);
		_touchHandler = new TouchHandler();
		_touchHandler.TouchAction += TouchHandlerOnTouch;
		_touchHandler.Capture = Capture;
		_touchHandler.RegisterEvents(platformView);
	}

	private void TouchHandlerOnTouch(object sender, TouchTracking.TouchActionEventArgs args)
	{
		OnTouchAction(sender, args);
	}

	protected override void OnDetachedFrom(View bindable, UIView platformView)
	{
		base.OnDetachedFrom(bindable, platformView);
		if (_touchHandler == null)
		{
			return;
		}
		_touchHandler.TouchAction -= TouchHandlerOnTouch;
		_touchHandler.UnregisterEvents(platformView);
	}
}