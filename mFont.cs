using System;
using System.Collections;
using UnityEngine;

public class mFont
{
	public static int LEFT;

	public static int RIGHT = 1;

	public static int CENTER = 2;

	public static int RED;

	public static int YELLOW = 1;

	public static int GREEN = 2;

	public static int FATAL = 3;

	public static int MISS = 4;

	public static int ORANGE = 5;

	public static int ADDMONEY = 6;

	public static int MISS_ME = 7;

	public static int FATAL_ME = 8;

	private int space;

	private Image imgFont;

	private string strFont;

	private int[][] fImages;

	public static mFont gI;

	public static mFont tahoma_7b_red;

	public static mFont tahoma_7b_blue;

	public static mFont tahoma_7b_purple;

	public static mFont tahoma_7b_yellow;

	public static mFont tahoma_7b_green;

	public static mFont tahoma_7b_white;

	public static mFont tahoma_7;

	public static mFont tahoma_7_blue1;

	public static mFont tahoma_7_white;

	public static mFont tahoma_7_yellow;

	public static mFont tahoma_7_grey;

	public static mFont tahoma_7_red;

	public static mFont tahoma_7_blue;

	public static mFont tahoma_7_green;

	public static mFont tahoma_8b;

	public static mFont number_yellow;

	public static mFont number_red;

	public static mFont number_green;

	public static mFont number_white;

	public static mFont number_orange;

	public static mFont numberb_yellow;

	public static mFont numberb_red;

	public static mFont numberb_green;

	public static mFont numberb_white;

	public static mFont numberb_orange;

	public static mFont tahoma_7_white_b;

	public static mFont number_fly_txt;

	public static mFont bigNumber_red;

	public static mFont bigNumber_While;

	public static mFont bigNumber_yellow;

	public static mFont bigNumber_green;

	public static mFont bigNumber_orange;

	public static mFont bigNumber_blue;

	public Font myFont;

	private int height;

	private int wO;

	public Color color1 = Color.white;

	public Color color2 = Color.gray;

	public sbyte id;

	public int fstyle;

	public string st1 = "áàảãạăắằẳẵặâấầẩẫậéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵđÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴĐ";

	public string st2 = "\u00b8µ¶·¹\u00a8¾»¼½Æ©ÊÇÈÉËÐÌÎÏÑªÕÒÓÔÖÝ×ØÜÞãßáâä«èåæçé¬íêëìîóïñòô­øõö÷ùýúûüþ®\u00b8µ¶·¹¡¾»¼½Æ¢ÊÇÈÉËÐÌÎÏÑ£ÕÒÓÔÖÝ×ØÜÞãßáâä¤èåæçé¥íêëìîóïñòô¦øõö÷ùýúûüþ§";

	public mFont(sbyte id)
	{
		string text = "normalFont2";
		if (id > 0 && id < 8)
		{
			text = "normalFont3";
		}
		else if (id >= 17 && id < 22)
		{
			text = "normalFont0";
		}
		else if (id >= 8 && id <= 15)
		{
			text = "normalFont1";
		}
		else if (id >= 22)
		{
			text = "normalFont4";
		}
		if (id >= 28)
		{
			text = "normalFont5";
		}
		if (id == 16)
		{
			text = "normalFont3";
		}
		this.id = id;
		text = "res/x" + mGraphics.zoomLevel + "/" + text;
		myFont = (Font)Resources.Load(text);
		color1 = setColorFont(id);
		color2 = setColorFont(id);
		wO = getWidthExactOf("o");
	}

	public static void init()
	{
		gI = new mFont(0);
		tahoma_7b_red = new mFont(1);
		tahoma_7b_blue = new mFont(2);
		tahoma_7b_purple = new mFont(3);
		tahoma_7b_yellow = new mFont(4);
		tahoma_7b_green = new mFont(5);
		tahoma_7b_white = new mFont(7);
		tahoma_7 = new mFont(8);
		tahoma_7_blue1 = new mFont(9);
		tahoma_7_white = new mFont(10);
		tahoma_7_yellow = new mFont(11);
		tahoma_7_grey = new mFont(12);
		tahoma_7_red = new mFont(13);
		tahoma_7_blue = new mFont(14);
		tahoma_7_green = new mFont(15);
		tahoma_8b = new mFont(16);
		number_yellow = new mFont(17);
		number_red = new mFont(18);
		number_green = new mFont(19);
		number_white = new mFont(20);
		number_orange = new mFont(21);
		numberb_yellow = new mFont(22);
		numberb_red = new mFont(23);
		numberb_green = new mFont(24);
		numberb_white = new mFont(25);
		numberb_orange = new mFont(26);
		tahoma_7_white_b = new mFont(27);
		bigNumber_red = new mFont(28);
		bigNumber_While = new mFont(29);
		bigNumber_yellow = new mFont(30);
		bigNumber_green = new mFont(31);
		bigNumber_orange = new mFont(32);
		bigNumber_blue = new mFont(33);
	}

	public Color setColor(int rgb)
	{
		int num = rgb & 0xFF;
		int num2 = (rgb >> 8) & 0xFF;
		int num3 = (rgb >> 16) & 0xFF;
		float b = (float)num / 256f;
		float g = (float)num2 / 256f;
		float r = (float)num3 / 256f;
		return new Color(r, g, b);
	}

	public void setTypePaint(mGraphics g, string st, int x, int y, int align, sbyte idFont)
	{
		sbyte b = id;
		if (idFont > 0)
		{
			b = idFont;
		}
		x--;
		if (mGraphics.zoomLevel == 4)
		{
			y += 2;
		}
		switch (b)
		{
		case 1:
			color1 = Color.red;
			color2 = Color.red;
			_drawString(g, st, x, y, align);
			break;
		case 2:
			color1 = Color.blue;
			color2 = Color.blue;
			_drawString(g, st, x, y, align);
			break;
		case 3:
			color1 = setColor(13500671);
			color2 = setColor(13500671);
			_drawString(g, st, x, y, align);
			break;
		case 4:
			color1 = setColor(16755200);
			color2 = setColor(16755200);
			_drawString(g, st, x, y, align);
			break;
		case 5:
			color1 = Color.green;
			color2 = Color.green;
			_drawString(g, st, x, y, align);
			break;
		case 6:
			color1 = setColor(16776960);
			color2 = setColor(16776960);
			_drawString(g, st, x, y, align);
			break;
		case 7:
		case 27:
			color1 = Color.white;
			color2 = Color.white;
			_drawString(g, st, x, y, align);
			break;
		case 8:
			color1 = Color.black;
			color2 = Color.black;
			_drawString(g, st, x, y, align);
			break;
		case 9:
			color1 = setColor(65535);
			color2 = setColor(65535);
			_drawString(g, st, x, y, align);
			break;
		case 10:
			color1 = Color.white;
			color2 = Color.white;
			_drawString(g, st, x, y, align);
			break;
		case 11:
			color1 = Color.yellow;
			color2 = Color.yellow;
			_drawString(g, st, x, y, align);
			break;
		case 12:
			color1 = setColor(5592405);
			color2 = setColor(5592405);
			_drawString(g, st, x, y, align);
			break;
		case 13:
			color1 = Color.red;
			color2 = Color.red;
			_drawString(g, st, x, y, align);
			break;
		case 14:
			color1 = setColor(33023);
			color2 = setColor(33023);
			_drawString(g, st, x, y, align);
			break;
		case 15:
			color1 = setColor(8701737);
			color2 = setColor(8701737);
			_drawString(g, st, x, y, align);
			break;
		case 16:
			color1 = setColor(15655191);
			color2 = setColor(15655191);
			_drawString(g, st, x, y, align);
			break;
		case 17:
			color1 = setColor(0);
			color2 = setColor(0);
			_drawString(g, st, x - 1, y - 3, align);
			color1 = Color.yellow;
			color2 = Color.yellow;
			_drawString(g, st, x - 2, y - 3, align);
			break;
		case 18:
			color1 = setColor(0);
			color2 = setColor(0);
			_drawString(g, st, x - 1, y - 3, align);
			color1 = Color.red;
			color2 = Color.red;
			_drawString(g, st, x - 2, y - 3, align);
			break;
		case 19:
			color1 = setColor(0);
			color2 = setColor(0);
			_drawString(g, st, x - 1, y - 3, align);
			color1 = Color.green;
			color2 = Color.green;
			_drawString(g, st, x - 2, y - 3, align);
			break;
		case 20:
			color1 = setColor(0);
			color2 = setColor(0);
			_drawString(g, st, x - 1, y - 3, align);
			color1 = Color.white;
			color2 = Color.white;
			_drawString(g, st, x - 2, y - 3, align);
			break;
		case 21:
			color1 = setColor(0);
			color2 = setColor(0);
			_drawString(g, st, x - 1, y - 3, align);
			color1 = setColor(16096312);
			color2 = setColor(16096312);
			_drawString(g, st, x - 2, y - 3, align);
			break;
		case 22:
			color1 = setColor(5592405);
			color2 = setColor(5592405);
			_drawString(g, st, x, y + 1, align);
			color1 = Color.yellow;
			color2 = Color.yellow;
			_drawString(g, st, x, y, align);
			break;
		case 30:
			color1 = Color.black;
			color2 = Color.black;
			_drawString(g, st, x, y + 1, align);
			color1 = Color.yellow;
			color2 = Color.yellow;
			_drawString(g, st, x, y, align);
			break;
		case 23:
		case 28:
			color1 = setColor(5592405);
			color2 = setColor(5592405);
			_drawString(g, st, x, y + 1, align);
			color1 = Color.red;
			color2 = Color.red;
			_drawString(g, st, x, y, align);
			break;
		case 24:
		case 31:
			color1 = setColor(5592405);
			color2 = setColor(5592405);
			_drawString(g, st, x, y + 1, align);
			color1 = Color.green;
			color2 = Color.green;
			_drawString(g, st, x, y, align);
			break;
		case 25:
		case 29:
			color1 = setColor(5592405);
			color1 = setColor(5592405);
			_drawString(g, st, x, y + 1, align);
			color1 = Color.white;
			color2 = Color.white;
			_drawString(g, st, x, y, align);
			break;
		case 26:
		case 32:
			color1 = setColor(5592405);
			color1 = setColor(5592405);
			_drawString(g, st, x, y + 1, align);
			color1 = setColor(16096312);
			color1 = setColor(16096312);
			_drawString(g, st, x, y, align);
			break;
		case 33:
			color1 = setColor(5592405);
			color1 = setColor(5592405);
			_drawString(g, st, x, y + 1, align);
			color1 = Color.blue;
			color1 = Color.blue;
			_drawString(g, st, x, y, align);
			break;
		}
	}

	public Color setColorFont(sbyte id)
	{
		switch (id)
		{
		case 1:
			return Color.red;
		case 2:
			return Color.blue;
		case 3:
			return setColor(13500671);
		case 4:
			return setColor(16755200);
		case 5:
			return Color.green;
		case 6:
			return setColor(16776960);
		case 7:
			return Color.white;
		case 8:
			return Color.black;
		case 9:
			return setColor(65535);
		case 10:
			return Color.white;
		case 11:
			return Color.yellow;
		case 12:
			return setColor(5592405);
		case 13:
			return Color.red;
		case 14:
			return setColor(33023);
		case 15:
			return setColor(8701737);
		case 16:
			return setColor(15655191);
		case 17:
			return setColor(0);
		case 18:
			return setColor(0);
		case 19:
			return setColor(0);
		case 20:
			return setColor(0);
		case 21:
			return setColor(0);
		case 22:
		case 30:
			return setColor(5592405);
		case 23:
		case 28:
			return setColor(5592405);
		case 24:
		case 31:
			return setColor(5592405);
		case 25:
		case 29:
			return setColor(5592405);
		case 26:
		case 32:
			return setColor(5592405);
		default:
			return Color.white;
		}
	}

	public void drawString(mGraphics g, string st, int x, int y, int align)
	{
		setTypePaint(g, st, x, y, align, 0);
	}

	public void drawString(mGraphics g, string st, int x, int y, int align, mFont font)
	{
		setTypePaint(g, st, x, y + 1, align, font.id);
		setTypePaint(g, st, x, y, align, 0);
	}

	public MyVector splitFontVector(string src, int lineWidth)
	{
		MyVector myVector = new MyVector();
		string text = string.Empty;
		for (int i = 0; i < src.Length; i++)
		{
			if (src[i] == '\n')
			{
				myVector.addElement(text);
				text = string.Empty;
				continue;
			}
			text += src[i];
			if (getWidth(text) > lineWidth)
			{
				int num = 0;
				num = text.Length - 1;
				while (num >= 0 && text[num] != ' ')
				{
					num--;
				}
				if (num < 0)
				{
					num = text.Length - 1;
				}
				myVector.addElement(text.Substring(0, num));
				i = i - (text.Length - num) + 1;
				text = string.Empty;
			}
			if (i == src.Length - 1 && !text.Trim().Equals(string.Empty))
			{
				myVector.addElement(text);
			}
		}
		return myVector;
	}

	public string splitFirst(string str)
	{
		string text = string.Empty;
		bool flag = false;
		for (int i = 0; i < str.Length; i++)
		{
			if (!flag)
			{
				string text2 = str.Substring(i);
				text = ((!compare(text2, " ")) ? (text + text2) : (text + str[i] + "-"));
				flag = true;
			}
			else if (str[i] == ' ')
			{
				flag = false;
			}
		}
		return text;
	}

	public string[] splitStrInLine(string src, int lineWidth)
	{
		ArrayList arrayList = splitStrInLineA(src, lineWidth);
		string[] array = new string[arrayList.Count];
		for (int i = 0; i < arrayList.Count; i++)
		{
			array[i] = (string)arrayList[i];
		}
		return array;
	}

	public ArrayList splitStrInLineA(string src, int lineWidth)
	{
		ArrayList arrayList = new ArrayList();
		int i = 0;
		int num = 0;
		int length = src.Length;
		if (length < 5)
		{
			arrayList.Add(src);
			return arrayList;
		}
		string text = string.Empty;
		try
		{
			while (true)
			{
				if (getWidthNotExactOf(text) < lineWidth)
				{
					text += src[num];
					num++;
					if (src[num] != '\n')
					{
						if (num < length - 1)
						{
							continue;
						}
						num = length - 1;
					}
				}
				if (num != length - 1 && src[num + 1] != ' ')
				{
					int num2 = num;
					while (src[num + 1] != '\n' && (src[num + 1] != ' ' || src[num] == ' ') && num != i)
					{
						num--;
					}
					if (num == i)
					{
						num = num2;
					}
				}
				string text2 = src.Substring(i, num + 1 - i);
				if (text2[0] == '\n')
				{
					text2 = text2.Substring(1, text2.Length - 1);
				}
				if (text2[text2.Length - 1] == '\n')
				{
					text2 = text2.Substring(0, text2.Length - 1);
				}
				arrayList.Add(text2);
				if (num != length - 1)
				{
					for (i = num + 1; i != length - 1 && src[i] == ' '; i++)
					{
					}
					if (i == length - 1)
					{
						break;
					}
					num = i;
					text = string.Empty;
					continue;
				}
				return arrayList;
			}
			return arrayList;
		}
		catch (Exception ex)
		{
			Out.LogWarning("EXCEPTION WHEN REAL SPLIT " + src + "\nend=" + num + "\n" + ex.Message + "\n" + ex.StackTrace);
			arrayList.Add(src);
			return arrayList;
		}
	}

	public string[] splitFontArray(string src, int lineWidth)
	{
		MyVector myVector = splitFontVector(src, lineWidth);
		string[] array = new string[myVector.size()];
		for (int i = 0; i < myVector.size(); i++)
		{
			array[i] = (string)myVector.elementAt(i);
		}
		return array;
	}

	public bool compare(string strSource, string str)
	{
		for (int i = 0; i < strSource.Length; i++)
		{
			if ((string.Empty + strSource[i]).Equals(str))
			{
				return true;
			}
		}
		return false;
	}

	public int getWidth(string s)
	{
		return getWidthExactOf(s);
	}

	public int getWidthExactOf(string s)
	{
		try
		{
			GUIStyle gUIStyle = new GUIStyle();
			gUIStyle.font = myFont;
			return (int)gUIStyle.CalcSize(new GUIContent(s)).x / mGraphics.zoomLevel;
		}
		catch (Exception ex)
		{
			Out.LogError("GET WIDTH OF " + s + " FAIL.\n" + ex.Message + "\n" + ex.StackTrace);
			return getWidthNotExactOf(s);
		}
	}

	public int getWidthNotExactOf(string s)
	{
		return s.Length * wO / mGraphics.zoomLevel;
	}

	public int getHeight()
	{
		if (height > 0)
		{
			return height / mGraphics.zoomLevel;
		}
		GUIStyle gUIStyle = new GUIStyle();
		gUIStyle.font = myFont;
		try
		{
			height = (int)gUIStyle.CalcSize(new GUIContent("Adg")).y + 2;
		}
		catch (Exception ex)
		{
			Out.LogError("FAIL GET HEIGHT " + ex.StackTrace);
			height = 20;
		}
		return height / mGraphics.zoomLevel;
	}

	public void _drawString(mGraphics g, string st, int x0, int y0, int align)
	{
		GUIStyle gUIStyle = new GUIStyle(GUI.skin.label);
		gUIStyle.font = myFont;
		float num = 0f;
		float num2 = 0f;
		switch (align)
		{
		case 0:
			num = x0;
			num2 = y0;
			gUIStyle.alignment = TextAnchor.UpperLeft;
			break;
		case 1:
			num = x0 - GameCanvas.w;
			num2 = y0;
			gUIStyle.alignment = TextAnchor.UpperRight;
			break;
		case 2:
		case 3:
			num = x0 - GameCanvas.w / 2;
			num2 = y0;
			gUIStyle.alignment = TextAnchor.UpperCenter;
			break;
		}
		gUIStyle.normal.textColor = color1;
		g.drawString(st, (int)num, (int)num2, gUIStyle);
	}

	public static string[] splitStringSv(string _text, string _searchStr)
	{
		int num = 0;
		int startIndex = 0;
		int length = _searchStr.Length;
		int num2 = _text.IndexOf(_searchStr, startIndex);
		while (num2 != -1)
		{
			startIndex = num2 + length;
			num2 = _text.IndexOf(_searchStr, startIndex);
			num++;
		}
		string[] array = new string[num + 1];
		int num3 = _text.IndexOf(_searchStr);
		int num4 = 0;
		int num5 = 0;
		while (num3 != -1)
		{
			array[num5] = _text.Substring(num4, num3 - num4);
			num4 = num3 + length;
			num3 = _text.IndexOf(_searchStr, num4);
			num5++;
		}
		array[num5] = _text.Substring(num4, _text.Length - num4);
		return array;
	}

	public void reloadImage()
	{
	}

	public void freeImage()
	{
	}
}
