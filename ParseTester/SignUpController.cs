using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace ParseTester
{
	partial class SignUpController : UIViewController
	{
		public SignUpController (IntPtr handle) : base (handle)
		{
		}

		async partial void UIButton98_TouchUpInside (UIButton sender)
		{
			// create a parse user
			var username=  txtEmail.Text;
			var psw = txtSignUpPassword.Text;
			var pswc = txtSignUpPasswordConfirm.Text;
			// Check for a valid email address
			if (string.IsNullOrEmpty(username)){

				using(var a = new UIAlertView("Signup","Invalid or missing email address",null,"Ok",null)){
					a.Show();

				}
				return;
			}
			// Check for a valid password
			if (string.IsNullOrEmpty(psw)){

				using(var a = new UIAlertView("Signup","Invalid or password",null,"Ok",null)){
					a.Show();
				}
				return;
			}
			//check if the passwords match
			if (psw !=pswc) {
				using(var a = new UIAlertView("Signup","Invalid or password",null,"Ok",null)){
					a.Show();
				}
				return;
			}

			var newUser = new Parse.ParseUser(){
				Email = username,
				Password = psw,
				Username = username
				


			};

			try {
				await newUser.SignUpAsync();

			}catch(System.Exception se){
				using(var a = new UIAlertView("Signup",se.Message,null,"Ok",null)){
					a.Show();
				}
			}

		
		}
	}
}
