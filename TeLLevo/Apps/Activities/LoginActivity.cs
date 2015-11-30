
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TeLLevo
{
	[Activity (Label = "Login")]			
	public class LoginActivity : Activity
	{
		Button btn;
		EditText username, password;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.Login);

			btn = FindViewById<Button> (Resource.Id.siBtn);
			username = FindViewById<EditText> (Resource.Id.siTxtUsername);
			password = FindViewById<EditText> (Resource.Id.siTxtPassword);
			// Create your application here

			btn.Enabled = false;

			username.AfterTextChanged += (object sender, Android.Text.AfterTextChangedEventArgs e) => {
				EnableSaveItemButton();
			};

			password.AfterTextChanged += (object sender, Android.Text.AfterTextChangedEventArgs e) => {
				EnableSaveItemButton();
			};

			btn.Click += (sender, e) => {
				if(username.Text == "admin" && password.Text == "admin"){
					StartActivity(typeof(Dashboard));
				}
				else{
					Toast.MakeText (this, "Please check username and password!", ToastLength.Long).Show ();
				}
			};
		}

		private void EnableSaveItemButton(){
			if (username.Text.Length != 0 && password.Text.Length != 0) {
				btn.Enabled = true;				
			} else {
				btn.Enabled = false;				
			}
		}
	}
}

