
namespace TouchTracking;

public partial class TouchTrackingBehavior
{
	public event TouchActionEventHandler TouchAction;

	public bool Capture { set; get; }

	public void OnTouchAction(object element, TouchActionEventArgs args)
	{
		TouchAction?.Invoke(element, args);
	}
}
