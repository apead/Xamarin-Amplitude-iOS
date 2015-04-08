using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace Xamarin.Amplitude.Ios.Sample
{
	public partial class Xamarin_Amplitude_Ios_SampleViewController : UIViewController
	{
		public Xamarin_Amplitude_Ios_SampleViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			BtnEvent1.TouchUpInside += BtnEvent1_TouchUpInside;
			BtnEvent2.TouchUpInside += BtnEvent2_TouchUpInside;
			BtnOptIn.TouchUpInside += BtnOptIn_TouchUpInside;
			BtnOptOut.TouchUpInside += BtnOptOut_TouchUpInside;
			BtnSetUserId.TouchUpInside += BtnSetUserId_TouchUpInside;
			BtnTrackRevenue.TouchUpInside += BtnTrackRevenue_TouchUpInside;
			// Perform any additional setup after loading the view, typically from a nib.
		}

		void BtnTrackRevenue_TouchUpInside (object sender, EventArgs e)
		{
			var amp = AmplitudeSdk.Amplitude.Instance;

			if (amp != null)
				amp.LogRevenue("Product1",5,1.50);
		}

		void BtnSetUserId_TouchUpInside (object sender, EventArgs e)
		{
			var amp = AmplitudeSdk.Amplitude.Instance;

			if (amp != null)
				amp.SetUserId("TestUser");
		}

		void BtnOptIn_TouchUpInside (object sender, EventArgs e)
		{
			var amp = AmplitudeSdk.Amplitude.Instance;

			if (amp != null)
				amp.OptOut = false;
		}

		void BtnOptOut_TouchUpInside (object sender, EventArgs e)
		{
			var amp = AmplitudeSdk.Amplitude.Instance;

			if (amp != null)
				amp.OptOut = true;
		}

		void BtnEvent1_TouchUpInside (object sender, EventArgs e)
		{
			var amp = AmplitudeSdk.Amplitude.Instance;

			if (amp != null)
				amp.LogEvent("Event1");
		}

		void BtnEvent2_TouchUpInside (object sender, EventArgs e)
		{
			var amp = AmplitudeSdk.Amplitude.Instance;

			if (amp != null)
				amp.LogEvent("Event2");
			
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}

