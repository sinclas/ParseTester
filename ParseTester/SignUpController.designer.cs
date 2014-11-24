// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace ParseTester
{
	[Register ("SignUpController")]
	partial class SignUpController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtEmail { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtSignUpPassword { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtSignUpPasswordConfirm { get; set; }

		[Action ("UIButton98_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIButton98_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (txtEmail != null) {
				txtEmail.Dispose ();
				txtEmail = null;
			}
			if (txtSignUpPassword != null) {
				txtSignUpPassword.Dispose ();
				txtSignUpPassword = null;
			}
			if (txtSignUpPasswordConfirm != null) {
				txtSignUpPasswordConfirm.Dispose ();
				txtSignUpPasswordConfirm = null;
			}
		}
	}
}
