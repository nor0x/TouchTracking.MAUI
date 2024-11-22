
namespace TouchTracking;

public partial class TouchTrackingBehavior : PlatformBehavior<View>
{
	public event TouchActionEventHandler TouchAction;

	public bool Capture { set; get; }

	public bool Enabled { set; get; } = true;

	public void OnTouchAction(object element, TouchActionEventArgs args)
	{
		if (Enabled)
		{
			TouchAction?.Invoke(element, args);
		}
	}
}
