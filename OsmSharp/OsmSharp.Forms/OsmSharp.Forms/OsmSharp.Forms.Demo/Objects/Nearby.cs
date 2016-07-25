using System;
namespace OsmSharp.Forms.Demo
{
	public class Nearby
	{
		public Nearby()
		{
			
		}

		string descripion;
		string url;
		bool isOpen;
		double range;

		//-----------------------------•-------------------------------

		public string Descripion
		{
			get
			{
				return descripion;
			}

			set
			{
				descripion = value;
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

		public bool IsOpen
		{
			get
			{
				return isOpen;
			}

			set
			{
				isOpen = value;
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

	
	}
}

