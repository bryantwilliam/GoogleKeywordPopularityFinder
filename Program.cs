using System;
using System.Web;
using System.Web.UI;

namespace GoogleKeywordPopularityFinder
{
	class MainClass
	{
		public static void Main (string [] args)
		{
			Console.WriteLine ("Hello World!");
			runScript ("<script type='text/javascript'>functionname1();</script>", "Test");
		}

		public static void runScript (string javaScript, string key)
		{
			Page page = HttpContext.Current.CurrentHandler as Page;
			page.ClientScript.RegisterStartupScript (
				typeof (Page),
				key,
			javaScript);
		}
	}
}
