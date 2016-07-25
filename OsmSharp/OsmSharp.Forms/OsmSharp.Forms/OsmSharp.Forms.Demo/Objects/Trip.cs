using System;
namespace OsmSharp.Forms.Demo
{
	public class Trip
	{
		public Trip()
		{
			
		}

		string description;
		string url;
		double range;
		double heightDiff;
		//--------------------------------------------•------------------------------------------------------
		public string Description
		{
			get
			{
				return description;
			}

			set
			{
				description = value;
			}
		}

		public string Url
		{
			get
			{
				return url;
			}

			set
			{
				url = value;
			}
		}

		public double Range
		{
			get
			{
				return range;
			}

			set
			{
				range = value;
			}
		}

		public double HeightDiff
		{
			get
			{
				return heightDiff;
			}

			set
			{
				heightDiff = value;
			}
		}
	}
}

