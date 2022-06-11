using UnityEngine;

internal class Net
{
	public static WWW www;

	public static HTTPHandler h;

	public static void update()
	{
		if (www != null && www.isDone)
		{
			string s = string.Empty;
			if (www.error == null || www.error.Equals(string.Empty))
			{
				s = www.text;
			}
			www = null;
			h.onGetText(s);
		}
	}

	public static void connectHTTP(string link, HTTPHandler h)
	{
		if (www != null)
		{
			Debug.LogError("GET HTTP BUSY");
		}
		Debug.LogWarning("REQUEST " + link);
		www = new WWW(link);
		Net.h = h;
	}
}
