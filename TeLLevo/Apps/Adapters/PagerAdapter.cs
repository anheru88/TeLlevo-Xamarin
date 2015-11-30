using System;
using Android.App;
using System.Collections.Generic;

namespace TeLLevo
{
	public class PagerAdapter : Android.Support.V13.App.FragmentStatePagerAdapter
	{
		private List<Fragment> list;

		public PagerAdapter (FragmentManager fm, List<Fragment> list) : base(fm)
		{
			this.list = list;
		}


		#region implemented abstract members of PagerAdapter
		public override int Count {
			get {
				return list.Count;
			}
		}
		#endregion
		#region implemented abstract members of FragmentStatePagerAdapter
		public override Fragment GetItem (int position)
		{
			return list [position];
		}
		#endregion
	}
}

