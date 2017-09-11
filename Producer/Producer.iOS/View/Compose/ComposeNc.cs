using System;

using UIKit;

namespace Producer.iOS
{
	public partial class ComposeNc : UINavigationController
	{
		public ComposeNc (IntPtr handle) : base (handle) { }

		public override UIStatusBarStyle PreferredStatusBarStyle () => UIStatusBarStyle.LightContent;
	}
}
