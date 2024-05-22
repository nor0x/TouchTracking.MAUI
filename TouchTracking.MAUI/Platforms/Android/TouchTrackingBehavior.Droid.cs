
using TouchTracking.Droid;

namespace TouchTracking;

public partial class TouchTrackingBehavior : PlatformBehavior<View, Android.Views.View>
{
    private TouchHandler _touchHandler;
    private Android.Views.View _view;


    protected override void OnAttachedTo(View bindable, Android.Views.View platformView)
    {
        base.OnAttachedTo(bindable, platformView);
        _touchHandler = new TouchHandler();
        _touchHandler.TouchAction += TouchHandlerOnTouch;
        _touchHandler.Capture = Capture;
        _touchHandler.RegisterEvents(platformView);
    }

    private void TouchHandlerOnTouch(object sender, TouchActionEventArgs args)
    {
        OnTouchAction(sender, args);
    }

    protected override void OnDetachedFrom(View bindable, Android.Views.View platformView)
    {
        base.OnDetachedFrom(bindable, platformView);
        if (_touchHandler is null)
        {
            return;
        }
        _touchHandler.TouchAction -= TouchHandlerOnTouch;
        _touchHandler.UnregisterEvents(platformView);
    }
}
