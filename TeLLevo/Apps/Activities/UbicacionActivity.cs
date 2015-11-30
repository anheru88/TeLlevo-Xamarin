
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
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.Locations;

namespace TeLLevo
{
	[Activity (Label = "Ubicacion")]			
	public class UbicacionActivity : Activity, IOnMapReadyCallback, ILocationListener
	{
		private GoogleMap mMap;
		private LatLng latlng;
		LocationManager locMgr;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.Ubicacion);
			// Create your application here

			SetUpMap ();

		}

		protected override void OnResume ()
		{
			base.OnResume ();


			locMgr = GetSystemService (Context.LocationService) as LocationManager;

			if (locMgr.AllProviders.Contains (LocationManager.NetworkProvider)
				&& locMgr.IsProviderEnabled (LocationManager.NetworkProvider)) {
				locMgr.RequestLocationUpdates (LocationManager.NetworkProvider, 2000, 1, this);
			} else {
				Toast.MakeText (this, "The Network Provider does not exist or is not enabled!", ToastLength.Long).Show ();
			}
		}

		protected override void OnPause ()
		{
			base.OnPause ();

			locMgr.RemoveUpdates (this);
		}

		public void OnLocationChanged (Android.Locations.Location location)
		{
			
		}

		private void SetUpMap(){
			if (mMap == null) {
				FragmentManager.FindFragmentById<MapFragment> (Resource.Id.map).GetMapAsync (this);
			}
		}



		public void OnMapReady (GoogleMap googleMap)
		{
			mMap = googleMap;
		}

		public void OnProviderDisabled (string provider)
		{
			throw new NotImplementedException ();
		}

		public void OnProviderEnabled (string provider)
		{
			throw new NotImplementedException ();
		}

		public void OnStatusChanged (string provider, Availability status, Bundle extras)
		{
			throw new NotImplementedException ();
		}
	}
}

