using System;
using System.Configuration;

namespace StrongConfig.Example
{
	/// <summary>
	/// Provides strongly-typed access to configuration data.
	/// </summary>
	public static class ConfigurationFacade
	{
		/// <summary>
		/// The boolean key value.
		/// </summary>
		public static bool BooleanKey
		{
			get { return bool.Parse(ConfigurationManager.AppSettings["BooleanKey"]); }
		}

		/// <summary>
		/// A multiline comment
		/// about the string key.
		/// </summary>
		public static string StringKey
		{
			get { return ConfigurationManager.AppSettings["StringKey"]; }
		}

		/// <summary>
		/// Second comment above the date key.
		/// </summary>
		public static DateTime DateKey
		{
			get { return DateTime.Parse(ConfigurationManager.AppSettings["DateKey"]); }
		}

		public static int IntKey
		{
			get { return int.Parse(ConfigurationManager.AppSettings["IntKey"]); }
		}

		public static bool PreserveLoginUrl
		{
			get { return bool.Parse(ConfigurationManager.AppSettings["PreserveLoginUrl"]); }
		}

		public static bool ClientValidationEnabled
		{
			get { return bool.Parse(ConfigurationManager.AppSettings["ClientValidationEnabled"]); }
		}

		public static bool UnobtrusiveJavaScriptEnabled
		{
			get { return bool.Parse(ConfigurationManager.AppSettings["UnobtrusiveJavaScriptEnabled"]); }
		}
	}
}
