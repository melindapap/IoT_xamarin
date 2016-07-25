using System;
namespace OsmSharp.Forms.Demo
{
	public class News
	{
		public News(DateTime Start,DateTime? End,string Title,string Location,string Url, string Description)
		{
			this.Start = Start;
			this.End = End;
			this.Title = Title;
			this.Location = Location;
			this.Url = Url;
			this.Description = Description;

		}
		public News(DateTime Start, string Title, string Location, string Url, string Description)
		{
			this.Start = Start;
			this.Title = Title;
			this.Location = Location;
			this.Url = Url;
			this.Description = Description;

		}

		public News(string Title, string Location, string Url, string Description)
		{
			this.Title = Title;
			this.Location = Location;
			this.Url = Url;
			this.Description = Description;

		}

		DateTime start;

		DateTime? end;

		string title;

		string location;

		string url;

		string description;

		//------------------------------------------------------------•------------------------------------------------
		public DateTime Start
		{
			get
			{
				return start;
			}

			set
			{
				start = value;
			}
		}

		public DateTime? End
		{
			get
			{
				return end;
			}

			set
			{
				end = value;
			}
		}

		public string Title
		{
			get
			{
				return title;
			}

			set
			{
				title = value;
			}
		}

		public string Location
		{
			get
			{
				return location;
			}

			set
			{
				location = value;
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
	}
}

