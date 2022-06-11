using System;

public class NinjaUtil
{
	public static MyRandom randomz = new MyRandom();

	public static void onLoadMapComplete()
	{
		GameCanvas.endDlg();
	}

	public void onLoading()
	{
		GameCanvas.startWaitDlg("Đang tải dữ liệu");
	}

	public static int randomNumber(int max)
	{
		return randomz.nextInt(max);
	}

	public static string numberToString(string number)
	{
		string text = string.Empty;
		string text2 = string.Empty;
		if (number.Equals(string.Empty))
		{
			return text;
		}
		if (number[0] == '-')
		{
			text2 = "-";
			number = number.Substring(1);
		}
		for (int num = number.Length - 1; num >= 0; num--)
		{
			text = (((number.Length - 1 - num) % 3 != 0 || number.Length - 1 - num <= 0) ? (number[num] + text) : (number[num] + "." + text));
		}
		return text2 + text;
	}

	public static int random(int a, int b)
	{
		return a + randomz.nextInt(b - a);
	}

	public static sbyte[] readByteArray_Int(Message msg)
	{
		try
		{
			int num = msg.reader().readInt();
			sbyte[] data = new sbyte[num];
			msg.reader().read(ref data);
			return data;
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		return null;
	}

	public static sbyte[] readByteArray(Message msg)
	{
		try
		{
			int num = msg.reader().readInt();
			sbyte[] data = new sbyte[num];
			msg.reader().read(ref data);
			return data;
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		return null;
	}

	public static sbyte[] readByteArray(myReader dos)
	{
		try
		{
			int num = dos.readInt();
			sbyte[] data = new sbyte[num];
			dos.read(ref data);
			return data;
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		return null;
	}

	public static string[] split(string _text, string _searchStr)
	{
		return mFont.splitStringSv(_text, _searchStr);
	}

	public static string replace(string text, string regex, string replacement)
	{
		return text.Replace(regex, replacement);
	}

	public static void sendMsDK(string syntax, short port)
	{
		GameMidlet.sendSMS(syntax, "sms://" + port, new Command(string.Empty, GameCanvas.gI(), 88827, null), new Command(string.Empty, GameCanvas.gI(), 88828, null));
	}

	public static void downloadGame(string url)
	{
		try
		{
			GameMidlet.instance.platformRequest(url);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
			Out.println("NinjaUtil.downloadGame()");
		}
		finally
		{
			GameMidlet.instance.notifyDestroyed();
		}
	}

	public static string getTime(int timeRemainS)
	{
		int num = 0;
		if (timeRemainS > 60)
		{
			num = timeRemainS / 60;
			timeRemainS %= 60;
		}
		int num2 = 0;
		if (num > 60)
		{
			num2 = num / 60;
			num %= 60;
		}
		int num3 = 0;
		if (num2 > 24)
		{
			num3 = num2 / 24;
			num2 %= 24;
		}
		string empty = string.Empty;
		if (num3 > 0)
		{
			empty += num3;
			empty += "d";
			return empty + num2 + "h";
		}
		if (num2 > 0)
		{
			empty += num2;
			empty += "h";
			return empty + num + "'";
		}
		empty = ((num <= 9) ? (empty + "0" + num) : (empty + num));
		empty += ":";
		if (timeRemainS > 9)
		{
			return empty + timeRemainS;
		}
		return empty + "0" + timeRemainS;
	}
}
