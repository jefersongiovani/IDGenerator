// Author: Jeferson Giovani D. Schneider - Email: j.g@live.com
// Date: 21/08/2023 - All rights reserved.
//
using System;
namespace IDGenerator
{
	public static class IDGenerator
	{

		public static string CreateStringIdWithFixedLength(int length)
		{
			var x = new Random();
			var suffix = Guid.NewGuid().ToString().Replace("-", string.Empty)
				.Substring(x.Next(1, 27), length).ToUpper();
			return suffix.ToUpper();
		}

		public static string CreateStringIdWithFixedLength(int length, string prefix)
		{
			var x = new Random();
			var suffix = Guid.NewGuid().ToString().Replace("-", string.Empty)
				.Substring(x.Next(1, 27), length).ToUpper();
			var result =  $"{prefix}{suffix}";
			return result.ToUpper();
		}

		public static string CreateStringIdWithFixedLength(int length, string prefix, string suffix)
		{
			var x = new Random();
			var guid = Guid.NewGuid().ToString().Replace("-", string.Empty)
				.Substring(x.Next(1, 27), length).ToUpper();
			var result = $"{prefix}{guid}{suffix}";
			return result.ToUpper();
		}

		public static string CreateStringIdFromTimeStampInSeconds(DateTime dateTime)
		{
			TimeSpan ts = DateTime.Now.Subtract(dateTime);
			var result = ts.TotalSeconds;
			int finalNumber = (int)result;
			return finalNumber.ToString();
		}

		public static string CreateStringIdWithPrefixAndTimeStampInMinutes(DateTime date, string prefix)
		{
			TimeSpan ts = DateTime.Now.Subtract(date);
			var value = ts.TotalMinutes;
			return $"{prefix}{value}";
		}

		public static string CreateStringIdWithPrefixAndTimeStampInSeconds(DateTime date, string prefix)
		{
			TimeSpan ts = DateTime.Now.Subtract(date);
			var value = ts.TotalSeconds;
			return $"{prefix}{value}";
		}



		public static int CreateIntegerIdFromTimeStampInSeconds(DateTime dateTime)
		{
			TimeSpan ts = DateTime.Now.Subtract(dateTime);
			var result = ts.TotalSeconds;
			int finalNumber = (int)result;
			return finalNumber;
		}

		public static int CreateIntegerIdFromTimeStampInMinutes(DateTime dateTime)
		{
			TimeSpan ts = DateTime.Now.Subtract(dateTime);
			var result = ts.TotalMinutes;
			int finalNumber = (int)result;
			return finalNumber;
		}

	}
}

