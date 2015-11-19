using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V4.View;
using Android.Support.V4.App;
using System.Collections.Generic;

namespace TeLLevo
{
	[Activity (Label = "TeLLevo", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

		private ViewPager viewPager;
		private PagerAdapter pagerAdapter;
		private List<Android.App.Fragment> fragments;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			// Get our button from the layout resource,
			// and attach an event to it
			this.fragments = new List<Android.App.Fragment>();

			PagerFragment_1 pager1 = new PagerFragment_1 ();
			PagerFragment_2 pager2 = new PagerFragment_2 ();

			this.fragments.Add (pager1);
			this.fragments.Add (pager2);

			pagerAdapter = new PagerAdapter (this.FragmentManager, this.fragments);

			viewPager = this.FindViewById<ViewPager> (Resource.Id.pager);
			viewPager.Adapter = pagerAdapter;



		}
	}
}
