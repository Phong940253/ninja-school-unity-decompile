using System;

public class CharPartInfo
{
	public static mHashtable head_jump = new mHashtable();

	public static mHashtable head_normal = new mHashtable();

	public static mHashtable head_boc_dau = new mHashtable();

	public static mHashtable body_jump = new mHashtable();

	public static mHashtable body_normal = new mHashtable();

	public static mHashtable body_boc_dau = new mHashtable();

	public static mHashtable leg = new mHashtable();

	public mHashtable item = new mHashtable();

	public static mHashtable newMount = new mHashtable();

	public int dx;

	public int dy;

	public int idSmall;

	public int[] getDxDy(int idTem)
	{
		CharPartInfo charPartInfo = (CharPartInfo)item.get(idTem + string.Empty);
		if (charPartInfo != null)
		{
			return new int[2] { charPartInfo.dx, charPartInfo.dy };
		}
		return new int[2];
	}

	public static void doSetInfo(Message msg)
	{
		try
		{
			head_boc_dau.clear();
			head_jump.clear();
			head_normal.clear();
			body_boc_dau.clear();
			body_jump.clear();
			body_normal.clear();
			newMount.clear();
			int num = msg.reader().readUnsignedByte();
			for (int i = 0; i < num; i++)
			{
				int num2 = msg.reader().readByte();
				int num3 = msg.reader().readShort();
				int num4 = msg.reader().readShort();
				CharPartInfo charPartInfo = new CharPartInfo();
				charPartInfo.idSmall = num4;
				for (int j = 0; j < num2 - 2; j += 3)
				{
					int num5 = msg.reader().readShort();
					int num6 = msg.reader().readShort();
					int num7 = msg.reader().readShort();
					CharPartInfo charPartInfo2 = new CharPartInfo();
					charPartInfo2.dx = num6;
					charPartInfo2.dy = num7;
					charPartInfo.item.put(num5 + string.Empty, charPartInfo2);
				}
				head_jump.put(num3 + string.Empty, charPartInfo);
			}
			for (int k = 0; k < num; k++)
			{
				int num8 = msg.reader().readByte();
				int num9 = msg.reader().readShort();
				int num10 = msg.reader().readShort();
				CharPartInfo charPartInfo3 = new CharPartInfo();
				charPartInfo3.idSmall = num10;
				for (int l = 0; l < num8 - 2; l += 3)
				{
					int num11 = msg.reader().readShort();
					int num12 = msg.reader().readShort();
					int num13 = msg.reader().readShort();
					CharPartInfo charPartInfo4 = new CharPartInfo();
					charPartInfo4.dx = num12;
					charPartInfo4.dy = num13;
					charPartInfo3.item.put(num11 + string.Empty, charPartInfo4);
				}
				head_normal.put(num9 + string.Empty, charPartInfo3);
			}
			for (int m = 0; m < num; m++)
			{
				int num14 = msg.reader().readByte();
				int num15 = msg.reader().readShort();
				int num16 = msg.reader().readShort();
				CharPartInfo charPartInfo5 = new CharPartInfo();
				charPartInfo5.idSmall = num16;
				for (int n = 0; n < num14 - 2; n += 3)
				{
					int num17 = msg.reader().readShort();
					int num18 = msg.reader().readShort();
					int num19 = msg.reader().readShort();
					CharPartInfo charPartInfo6 = new CharPartInfo();
					charPartInfo6.dx = num18;
					charPartInfo6.dy = num19;
					charPartInfo5.item.put(num17 + string.Empty, charPartInfo6);
				}
				head_boc_dau.put(num15 + string.Empty, charPartInfo5);
			}
			num = msg.reader().readUnsignedByte();
			for (int num20 = 0; num20 < num; num20 += 2)
			{
				int num21 = msg.reader().readShort();
				int num22 = msg.reader().readShort();
				CharPartInfo charPartInfo7 = new CharPartInfo();
				charPartInfo7.idSmall = num22;
				leg.put(num21 + string.Empty, charPartInfo7);
			}
			num = msg.reader().readUnsignedByte();
			for (int num23 = 0; num23 < num; num23++)
			{
				int num24 = msg.reader().readByte();
				int num25 = msg.reader().readShort();
				int num26 = msg.reader().readShort();
				CharPartInfo charPartInfo8 = new CharPartInfo();
				charPartInfo8.idSmall = num26;
				for (int num27 = 0; num27 < num24 - 2; num27 += 3)
				{
					int num28 = msg.reader().readShort();
					int num29 = msg.reader().readShort();
					int num30 = msg.reader().readShort();
					CharPartInfo charPartInfo9 = new CharPartInfo();
					charPartInfo9.dx = num29;
					charPartInfo9.dy = num30;
					charPartInfo8.item.put(num28 + string.Empty, charPartInfo9);
				}
				body_jump.put(num25 + string.Empty, charPartInfo8);
			}
			for (int num31 = 0; num31 < num; num31++)
			{
				int num32 = msg.reader().readByte();
				int num33 = msg.reader().readShort();
				int num34 = msg.reader().readShort();
				CharPartInfo charPartInfo10 = new CharPartInfo();
				charPartInfo10.idSmall = num34;
				for (int num35 = 0; num35 < num32 - 2; num35 += 3)
				{
					int num36 = msg.reader().readShort();
					int num37 = msg.reader().readShort();
					int num38 = msg.reader().readShort();
					CharPartInfo charPartInfo11 = new CharPartInfo();
					charPartInfo11.dx = num37;
					charPartInfo11.dy = num38;
					charPartInfo10.item.put(num36 + string.Empty, charPartInfo11);
				}
				body_normal.put(num33 + string.Empty, charPartInfo10);
			}
			for (int num39 = 0; num39 < num; num39++)
			{
				int num40 = msg.reader().readByte();
				int num41 = msg.reader().readShort();
				int num42 = msg.reader().readShort();
				CharPartInfo charPartInfo12 = new CharPartInfo();
				charPartInfo12.idSmall = num42;
				for (int num43 = 0; num43 < num40 - 2; num43 += 3)
				{
					int num44 = msg.reader().readShort();
					int num45 = msg.reader().readShort();
					int num46 = msg.reader().readShort();
					CharPartInfo charPartInfo13 = new CharPartInfo();
					charPartInfo13.dx = num45;
					charPartInfo13.dy = num46;
					charPartInfo12.item.put(num44 + string.Empty, charPartInfo13);
				}
				body_boc_dau.put(num41 + string.Empty, charPartInfo12);
			}
			int num47 = msg.reader().readByte();
			for (int num48 = 0; num48 < num47; num48++)
			{
				int num49 = msg.reader().readShort();
				int num50 = 6;
				int[][] array = new int[num50][];
				for (int num51 = 0; num51 < num50; num51++)
				{
					int num52 = msg.reader().readByte();
					array[num51] = new int[num52];
					for (int num53 = 0; num53 < num52; num53++)
					{
						array[num51][num53] = msg.reader().readShort();
					}
				}
				newMount.put(num49 + string.Empty, array);
			}
		}
		catch (Exception)
		{
		}
	}
}
