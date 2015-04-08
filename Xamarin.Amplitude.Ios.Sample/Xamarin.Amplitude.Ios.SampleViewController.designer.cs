// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Xamarin.Amplitude.Ios.Sample
{
	[Register ("Xamarin_Amplitude_Ios_SampleViewController")]
	partial class Xamarin_Amplitude_Ios_SampleViewController
	{
		[Outlet]
		UIKit.UIButton BtnEvent1 { get; set; }

		[Outlet]
		UIKit.UIButton BtnEvent2 { get; set; }

		[Outlet]
		UIKit.UIButton BtnOptIn { get; set; }

		[Outlet]
		UIKit.UIButton BtnOptOut { get; set; }

		[Outlet]
		UIKit.UIButton BtnSetUserId { get; set; }

		[Outlet]
		UIKit.UIButton BtnTrackRevenue { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (BtnEvent1 != null) {
				BtnEvent1.Dispose ();
				BtnEvent1 = null;
			}

			if (BtnEvent2 != null) {
				BtnEvent2.Dispose ();
				BtnEvent2 = null;
			}

			if (BtnOptIn != null) {
				BtnOptIn.Dispose ();
				BtnOptIn = null;
			}

			if (BtnOptOut != null) {
				BtnOptOut.Dispose ();
				BtnOptOut = null;
			}

			if (BtnSetUserId != null) {
				BtnSetUserId.Dispose ();
				BtnSetUserId = null;
			}

			if (BtnTrackRevenue != null) {
				BtnTrackRevenue.Dispose ();
				BtnTrackRevenue = null;
			}
		}
	}
}
