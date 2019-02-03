using System.Linq;

namespace _04.Telephony
{

	public class Smartphone : ICalling
	{
		public string[] PhoneNumbersArray { get; private set; }

		public string[] SitesArray { get; private set; }

		public string CallNumber(string number)
		{

			if (number.Any(c => !char.IsDigit(c)))
			{
				return "Invalid number!";
			}

			return $"Calling... {number}";
		}

		public string BrowseSite(string site)
		{
			if (site.Any(c => char.IsDigit(c)))
			{
				return "Invalid URL!";
			}

			return $"Browsing: {site}!";
		}

		public Smartphone(string[] phoneNumbersArray, string[] sitesArray)
		{
			PhoneNumbersArray = phoneNumbersArray;
			SitesArray = sitesArray;
		}
	}
}
