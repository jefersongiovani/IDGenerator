// Author: Jeferson Giovani D. Schneider - Email: j.g@live.com
// Date: 21/08/2023 - All rights reserved.
//
using System;

namespace IDGenerator
{

	/// <summary>
	/// Static class that provides methods that return string representations of
	/// time span (minutes/seconds) from different configurations.
	/// </summary>
	public class TimeFromFoundation
	{

		//Date and time used as a base for creating invoices based on the current year's start
		private static readonly DateTime CurrentYearStart = new DateTime(DateTime.Now.Year, 01, 01, 0, 0, 0);

		/// <summary>
		/// Generates a string representing an integer number with total seconds from the foundation date
		/// represented by the epoch parameter until now.
		/// </summary>
		/// <returns>String with the total seconds</returns>
		public static string CreateTimeStampInSecondsFromEpoch(DateTime epoch)
		{
			//Initialising the actual date and time
			DateTime today = DateTime.UtcNow;

			// Getting the time span
			TimeSpan ts = today.Subtract(epoch);

			// Getting the total in seconds
			var result = ts.TotalSeconds;

			// Converting to integer
			int finalNumber = (int)result;

			// Converting to string and returning
			return finalNumber.ToString();
		}

		/// <summary>
		/// Creates a timestamp from 01/01/CurrentYear 00:00:00
		/// The generated number has 6 to 8 digits and is the total seconds
		/// from the current year until the date it is generated.
		/// </summary>
		/// <returns>String with 6 to 8 digits long for the total seconds</returns>
		public static string CreateTimeStampFromCurrentYear()
		{
			//Initialising the actual date and time
			DateTime today = DateTime.UtcNow;

			// Getting the time span
			TimeSpan ts = today.Subtract(CurrentYearStart);

			// Getting the total in seconds
			var result = ts.TotalSeconds;

			// Converting to integer
			int finalNumber = (int)result;

			// Converting to string and returning
			return finalNumber.ToString();

		}

		/// <summary>
		/// Generates an string representing the integer number with total minutes from the foundation date
		/// (represented by the epoch parameter) until now.
		/// </summary>
		/// <returns>String with the total minutes</returns>
		public static string CreateTimeStampInMinutesFromEpoch(DateTime epoch)
		{
			//Initialising the actual date and time
			DateTime today = DateTime.UtcNow;

			// Getting the time span
			TimeSpan ts = today.Subtract(epoch);

			// Getting the total in minutes
			var result = ts.TotalMinutes;

			// Converting to integer
			int finalNumber = (int)result;

			// Converting to string and returning
			return finalNumber.ToString();
		}

		/// <summary>
		/// Generates a string representation with the total number in minutes from
		/// the current year.
		/// </summary>
		/// <returns>String with the total minutes</returns>
		public static string CreateTimeStampInMinutesFromCurrentYear()
		{
			//Initialising the actual date and time
			DateTime today = DateTime.UtcNow;

			// Getting the time span
			TimeSpan ts = today.Subtract(CurrentYearStart);

			// Getting the total in minutes
			var result = ts.TotalMinutes;

			// Converting to integer
			int finalNumber = (int)result;

			// Converting to string and returning
			return finalNumber.ToString();
		}

		/// <summary>
		/// Generates a string representation with the total minutes from
		/// the start of the current year until the date passed as a paramenter.
		/// </summary>
		/// <param name="date">DateTime with the date to be subtracted from the time span.</param>
		/// <returns>String with the total minutes.</returns>
		public static string CreateTimeStampInMinutesFromDateCreated(DateTime date)
		{

			// Getting the time span
			TimeSpan ts = date.Subtract(CurrentYearStart);

			// Getting the total in minutes
			var result = ts.TotalMinutes;

			// Converting to integer
			int finalNumber = (int)result;

			// Converting to string and returning
			return finalNumber.ToString();
		}
	}
}

