using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OsmSharp.Forms.Demo
{
	public partial class MyPage : TabbedPage
	{
		public MyPage()
		{
			InitializeComponent();

		}

		public void setMapContent(StackLayout stack)
		{
			mapContainer.Children.Add(stack);
		}
	}
}

