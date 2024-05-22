namespace TouchTracking.MAUI.Demo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }



        private void OnCaptureToggleClicked(object sender, EventArgs e)
        {
            MyTouchBehavior.Capture = !MyTouchBehavior.Capture;
		}

		private void OnTouchAction(object sender, TouchActionEventArgs args)
		{
            Status.Text = $"Capture: {MyTouchBehavior.Capture}, " +
                $"Id: {args.Id}, " +
                $"Touch: {args.Type}, " +
                $"Location: {args.Location.X}, {args.Location.Y}, " +
                $"IsInContact: {args.IsInContact}, ";
		}
	}

}
