using System;

public class Clan
{
	public const int CREATE_CLAN = 0;

	public const int MOVE_OUT_MEM = 1;

	public const int MOVE_INPUT_MONEY = 2;

	public const int MOVE_OUT_MONEY = 3;

	public const int FREE_MONEY = 4;

	public const int UP_LEVEL = 5;

	public const int TYPE_NORMAL = 0;

	public const int TYPE_UUTU = 1;

	public const int TYPE_TRUONGLAO = 2;

	public const int TYPE_TOCPHO = 3;

	public const int TYPE_TOCTRUONG = 4;

	public string name = string.Empty;

	public int exp;

	public int expNext;

	public int level;

	public int itemLevel;

	public int icon;

	public int coin;

	public int freeCoin;

	public int coinUp;

	public string main_name = string.Empty;

	public string assist_name = string.Empty;

	public string elder1_name = string.Empty;

	public string elder2_name = string.Empty;

	public string elder3_name = string.Empty;

	public string elder4_name = string.Empty;

	public string elder5_name = string.Empty;

	public string reg_date = string.Empty;

	public string log = string.Empty;

	public string alert = string.Empty;

	public int total;

	public int use_card;

	public int openDun;

	public MyVector members = new MyVector();

	public Item[] items;

	public void writeLog(string data)
	{
		string[] array = NinjaUtil.split(data, "\n");
		log = string.Empty;
		try
		{
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i].Trim();
				if (text.Equals(string.Empty))
				{
					continue;
				}
				try
				{
					string[] array2 = NinjaUtil.split(text, ",");
					string text2 = array2[0];
					switch (int.Parse(array2[1]))
					{
					case 0:
					{
						text2 = "c0" + text2;
						string text8 = text2;
						text2 = text8 + mResources.CLAN_ACTIVITY[1] + " " + NinjaUtil.numberToString(array2[2]) + " " + mResources.CLAN_ACTIVITY[0] + " " + array2[3];
						break;
					}
					case 1:
					{
						text2 = "c1" + text2;
						string text7 = text2;
						text2 = text7 + " " + mResources.CLAN_ACTIVITY[2] + " " + NinjaUtil.numberToString(array2[2]) + " " + mResources.CLAN_ACTIVITY[0] + " " + array2[3];
						break;
					}
					case 2:
					{
						text2 = "c2" + text2;
						string text6 = text2;
						text2 = text6 + " " + mResources.CLAN_ACTIVITY[3] + " " + NinjaUtil.numberToString(array2[2]) + " " + mResources.CLAN_ACTIVITY[0] + " " + array2[3];
						break;
					}
					case 3:
					{
						text2 = "c1" + text2;
						string text5 = text2;
						text2 = text5 + " " + mResources.CLAN_ACTIVITY[4] + " " + NinjaUtil.numberToString(array2[2]) + " " + mResources.CLAN_ACTIVITY[0] + " " + array2[3];
						break;
					}
					case 4:
					{
						text2 = "c1" + text2;
						string text4 = text2;
						text2 = text4 + mResources.CLAN_ACTIVITY[5] + " " + NinjaUtil.numberToString(array2[2]) + " " + mResources.CLAN_ACTIVITY[0] + " " + array2[3];
						break;
					}
					case 5:
					{
						text2 = "c2" + text2;
						string text3 = text2;
						text2 = text3 + " " + mResources.CLAN_ACTIVITY[6] + " " + NinjaUtil.numberToString(array2[2]) + " " + mResources.CLAN_ACTIVITY[0] + " " + array2[3];
						break;
					}
					}
					log = log + text2 + "\n";
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
	}
}
