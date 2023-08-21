// Author: Jeferson Giovani D. Schneider - Email: j.g@live.com
// Date: 21/08/2023 - All rights reserved.
//
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
		public static string CreateTimeStampInSecondsFromCurrentYear()
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
		/// Overload that generates a time stamp in minutes from a given DateTime parameter.
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

		/// <summary>
		/// Generates a time span in minutes from two given dates.
		/// </summary>
		/// <param name="olderDate">DateTime older date</param>
		/// <param name="newerDate">DateTime newer date</param>
		/// <returns>String representation of the time span in minutes.</returns>
		public static string CreateTimeStampInMinutesFromTwoDates(DateTime olderDate, DateTime newerDate)
		{
			TimeSpan ts = newerDate.Subtract(olderDate);

			// Getting the total in minutes
			var result = ts.TotalMinutes;

			// Converting to integer
			int finalNumber = (int)result;

			// Converting to string and returning
			return finalNumber.ToString();
		}

		/// <summary>
		/// Generates a time span in seconds from two given dates.
		/// </summary>
		/// <param name="olderDate">DateTime older date</param>
		/// <param name="newerDate">DateTime newer date</param>
		/// <returns>String representation of the time span in seconds.</returns>
		public static string CreateTimeStampInSecondsFromTwoDates(DateTime olderDate, DateTime newerDate)
		{
			TimeSpan ts = newerDate.Subtract(olderDate);

			// Getting the total in minutes
			var result = ts.TotalSeconds;

			// Converting to integer
			int finalNumber = (int)result;

			// Converting to string and returning
			return finalNumber.ToString();
		}


	}
}

