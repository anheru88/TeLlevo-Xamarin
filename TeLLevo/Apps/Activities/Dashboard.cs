
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
	[Activity (Label = "Dashboard")]			
	public class Dashboard : Activity
	{
		Button ubicacion;
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.Dashboard);
			// Create your application here

			ubicacion = FindViewById<Button> (Resource.Id.ubicacion);


			ubicacion.Click += (sender, e) => {
				StartActivity(typeof(UbicacionActivity));
			};
		}
	}
}

