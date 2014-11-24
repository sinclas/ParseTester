using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;
using Parse;

namespace ParseTester
{
	partial class LoginViewController : UIViewController
	{
		public LoginViewController (IntPtr handle) : base (handle)
		{
		}

		async partial  void  btnLogin_TouchUpInside (UIButton sender)
		{

			var userName = txtUserName.Text;
			var password = txtPassword.Text;

			// Login into the Parse System
			if (userName.Length ==0 || password.Length==0){
				using (var alert = new UIAlertView("Login Error", "Invalid Username or Password",null,"Ok",null)){
					alert.Show();

				}
			}else{
				// Lets try to login
				try {
					// this will create a user as current user in the static parse class
			 		await Parse.ParseUser.LogInAsync(userName,password);

					// Move to the app //
					//this.PrepareForSegue("LoginToApp",this);

					// handle invalid login. parse will throw an exception
				}catch(System.Exception){
					using (var alert = new UIAlertView("Login Error", "Invalid login",null,"Ok",null)){
						alert.Show();

					}

				}

			}



		}
	}
}
