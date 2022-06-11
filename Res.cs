public class Res
{
	private static short[] SIN = new short[91]
	{
		0, 18, 36, 54, 71, 89, 107, 125, 143, 160,
		178, 195, 213, 230, 248, 265, 282, 299, 316, 333,
		350, 367, 384, 400, 416, 433, 449, 465, 481, 496,
		512, 527, 543, 558, 573, 587, 602, 616, 630, 644,
		658, 672, 685, 698, 711, 724, 737, 749, 761, 773,
		784, 796, 807, 818, 828, 839, 849, 859, 868, 878,
		887, 896, 904, 912, 920, 928, 935, 943, 949, 956,
		962, 968, 974, 979, 984, 989, 994, 998, 1002, 1005,
		1008, 1011, 1014, 1016, 1018, 1020, 1022, 1023, 1023, 1024,
		1024
	};

	private static short[] COS;

	private static int[] TAN;

	public static MyRandom r = new MyRandom();

	public static void init()
	{
		COS = new short[91];
		TAN = new int[91];
		for (int i = 0; i <= 90; i++)
		{
			COS[i] = SIN[90 - i];
			if (COS[i] == 0)
			{
				TAN[i] = int.MaxValue;
			}
			else
			{
				TAN[i] = (SIN[i] << 10) / COS[i];
			}
		}
	}

	public static int sin(int a)
	{
		a = fixangle(a);
		if (a >= 0 && a < 90)
		{
			return SIN[a];
		}
		if (a >= 90 && a < 180)
		{
			return SIN[180 - a];
		}
		if (a >= 180 && a < 270)
		{
			return -SIN[a - 180];
		}
		return -SIN[360 - a];
	}

	public static int cos(int a)
	{
		a = fixangle(a);
		if (a >= 0 && a < 90)
		{
			return COS[a];
		}
		if (a >= 90 && a < 180)
		{
			return -COS[180 - a];
		}
		if (a >= 180 && a < 270)
		{
			return -COS[a - 180];
		}
		return COS[360 - a];
	}

	public static int tan(int a)
	{
		a = fixangle(a);
		if (a >= 0 && a < 90)
		{
			return TAN[a];
		}
		if (a >= 90 && a < 180)
		{
			return -TAN[180 - a];
		}
		if (a >= 180 && a < 270)
		{
			return TAN[a - 180];
		}
		return -TAN[360 - a];
	}

	public static int atan(int a)
	{
		for (int i = 0; i <= 90; i++)
		{
			if (TAN[i] >= a)
			{
				return i;
			}
		}
		return 0;
	}

	public static int angle(int dx, int dy)
	{
		int num;
		if (dx != 0)
		{
			int a = Math.abs((dy << 10) / dx);
			num = atan(a);
			if (dy >= 0 && dx < 0)
			{
				num = 180 - num;
			}
			if (dy < 0 && dx < 0)
			{
				num = 180 + num;
			}
			if (dy < 0 && dx >= 0)
			{
				num = 360 - num;
			}
		}
		else
		{
			num = ((dy <= 0) ? 270 : 90);
		}
		return num;
	}

	public static int fixangle(int angle)
	{
		if (angle >= 360)
		{
			angle -= 360;
		}
		if (angle < 0)
		{
			angle += 360;
		}
		return angle;
	}

	public static int xetVX(int goc, int d)
	{
		return cos(fixangle(goc)) * d >> 10;
	}

	public static int xetVY(int goc, int d)
	{
		return sin(fixangle(goc)) * d >> 10;
	}

	public static int random(int a, int b)
	{
		return a + r.nextInt(b - a);
	}

	public static int s2tick(int currentTimeMillis)
	{
		int num = 0;
		num = currentTimeMillis * 16 / 1000;
		if (currentTimeMillis * 16 % 1000 >= 5)
		{
			num++;
		}
		return num;
	}

	public static int distance(int x1, int y1, int x2, int y2)
	{
		return sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
	}

	public static int sqrt(int a)
	{
		if (a <= 0)
		{
			return 0;
		}
		int num = (a + 1) / 2;
		int num2;
		do
		{
			num2 = num;
			num = num / 2 + a / (2 * num);
		}
		while (Math.abs(num2 - num) > 1);
		return num;
	}

	public static void println(string str)
	{
	}

	public static void LogError(string str)
	{
	}

	public static void LogWarning(string str)
	{
	}

	public static int rnd(int a)
	{
		return r.nextInt(a);
	}

	public static int abs(int i)
	{
		return (i <= 0) ? (-i) : i;
	}

	public static bool inRect(int x1, int y1, int width, int height, int x2, int y2)
	{
		return x2 >= x1 && x2 <= x1 + width && y2 >= y1 && y2 <= y1 + height;
	}

	public static void resetTrans(mGraphics g)
	{
		g.translate(-g.getTranslateX(), -g.getTranslateY());
		g.setClip(0, 0, GameCanvas.w, GameCanvas.h);
	}

	public static string[] split(string original, string separator, int count)
	{
		int num = original.IndexOf(separator);
		string[] array;
		if (num >= 0)
		{
			array = split(original.Substring(num + separator.Length), separator, count + 1);
		}
		else
		{
			array = new string[count + 1];
			num = original.Length;
		}
		if (num < original.Length)
		{
			array[count] = original.Substring(0, num);
		}
		else
		{
			array[count] = original.Substring(0);
		}
		return array;
	}

	public static string getTimeCountDown(long timeStart, int milisecondCount)
	{
		string result = string.Empty;
		long num = (timeStart + milisecondCount - mSystem.currentTimeMillis()) / 1000;
		if (num <= 0)
		{
			return string.Empty;
		}
		long num2 = 0L;
		long num3 = 0L;
		long num4 = num / 60;
		long num5 = num;
		if (num >= 86400)
		{
			num2 = num / 86400;
			num3 = num % 86400 / 3600;
		}
		else if (num >= 3600)
		{
			num3 = num / 3600;
			num4 = num % 3600 / 60;
		}
		else if (num >= 60)
		{
			num4 = num / 60;
			num5 = num % 60;
		}
		else
		{
			num5 = num;
		}
		if (num2 > 0)
		{
			if (num2 >= 10)
			{
				result = ((num3 < 1) ? (num2 + "d") : ((num3 >= 10) ? (num2 + "d" + num3 + "h") : (num2 + "d0" + num3 + "h")));
			}
			else if (num2 < 10)
			{
				result = ((num3 < 1) ? (num2 + "d") : ((num3 >= 10) ? (num2 + "d" + num3 + "h") : (num2 + "d0" + num3 + "h")));
			}
		}
		else if (num3 > 0)
		{
			if (num3 >= 10)
			{
				result = ((num4 < 1) ? (num3 + "h") : ((num4 >= 10) ? (num3 + "h" + num4 + "m") : (num3 + "h0" + num4 + "m")));
			}
			else if (num3 < 10)
			{
				result = ((num4 < 1) ? (num3 + "h") : ((num4 >= 10) ? (num3 + "h" + num4 + "m") : (num3 + "h0" + num4 + "m")));
			}
		}
		else if (num4 > 0)
		{
			if (num4 >= 10)
			{
				if (num5 >= 10)
				{
					result = num4 + "m" + num5 + "s";
				}
				else if (num5 < 10)
				{
					result = num4 + "m0" + num5 + "s";
				}
			}
			else if (num4 < 10)
			{
				if (num5 >= 10)
				{
					result = num4 + "m" + num5 + "s";
				}
				else if (num5 < 10)
				{
					result = num4 + "m0" + num5 + "s";
				}
			}
		}
		else
		{
			result = ((num5 >= 10) ? (num5 + "s") : ("0" + num5 + "s"));
		}
		return result;
	}

	public static DataInputStream readFile(string path)
	{
		DataInputStream dataInputStream = null;
		return DataInputStream.getResourceAsStream(Main.res + path);
	}
}
