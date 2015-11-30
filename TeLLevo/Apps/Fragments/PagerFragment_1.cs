
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace TeLLevo
{
	public class PagerFragment_1 : Fragment
	{
		Button btn;	
		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			// Use this to return your custom view for this Fragment
			// return inflater.Inflate(Resource.Layout.YourFragment, container, false);

			View view = inflater.Inflate (Resource.Layout.Fragment_1, container, false);
			btn = view.FindViewById<Button> (Resource.Id.button1);

			btn.Click += (sender, e) => {
				Intent intent = new Intent(Activity, typeof(LoginActivity));
				this.StartActivity(intent);
			};
			return view;
		}
	}
}

