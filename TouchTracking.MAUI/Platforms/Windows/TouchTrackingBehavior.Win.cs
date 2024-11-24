using Microsoft.UI.Xaml;
using TouchTracking.WinUI;

namespace TouchTracking;

public partial class TouchTrackingBehavior
{
    private TouchHandler? _touchHandler;

    protected override void OnAttachedTo(View bindable, FrameworkElement platformView)
    {
        base.OnAttachedTo(bindable, platformView);
        _touchHandler = new TouchHandler();
        _touchHandler.TouchAction += TouchHandlerOnTouch;
        _touchHandler.Capture = Capture;
        _touchHandler.RegisterEvents(platformView);
    }

    protected override void OnDetachedFrom(View bindable, FrameworkElement platformView)
    {
        base.OnDetachedFrom(bindable, platformView);
        if (_touchHandler is null)
        {
            return;
        }
        _touchHandler.TouchAction -= TouchHandlerOnTouch;
        _touchHandler.UnregisterEvents(platformView);
    }

    private void TouchHandlerOnTouch(object sender, TouchTracking.TouchActionEventArgs args)
    {
        OnTouchAction(sender, args);
    }
}
