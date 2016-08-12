using System;
using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Views;




namespace Project1
{
	[Activity(Label = "Project1", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		private List<string> mItems;
		private ListView mListView;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.OpenMenuPage);
			mListView = FindViewById<ListView>(Resource.Id.myListView);

			mItems = new List<string>();
			mItems.Add("Book 1");
			mItems.Add("Book 2");
			mItems.Add("Book 3");

			ArrayAdapter<string> ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItems);
			mListView.Adapter = ListAdapter;
			mListView.ItemClick += mListView_ItemClick;

			button.Click += delegate {
				StartActivity(typeof(MenuActivity));
			};

		}

		void mListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
		{
			StartActivity(typeof());

		}
	}
}	


