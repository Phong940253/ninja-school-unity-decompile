using System;
using System.Collections;

public class DataSkillEff
{
	public long timeRemove;

	public static mHashtable ALL_DATA_SKILL_EFF = new mHashtable();

	public MyVector listFrame = new MyVector();

	public MyVector listAnima = new MyVector();

	public SmallImage[] smallImage;

	public sbyte[][] frameChar = new sbyte[4][];

	public sbyte[] sequence;

	public sbyte Frame;

	public sbyte f;

	public bool IsStop;

	public MyVector mst = new MyVector();

	public static sbyte TYPE_EFFECT_END = 0;

	public static sbyte TYPE_EFFECT_STARTSKILL = 1;

	public static sbyte TYPE_EFFECT_BUFF = 2;

	private int loop;

	public int[] arrDame;

	public sbyte leavelPaint;

	public short x;

	public short y;

	public bool isLoadData;

	public short idEff;

	public bool canremove;

	public bool canActorMove;

	public bool canPaintActor;

	public bool canActorFight;

	public static sbyte ACTOR_NORMAL = 0;

	public static sbyte ACTOR_CAN_NOT_MOVE = 1;

	public static sbyte ACTOR_CAN_NOT_PAINT = 2;

	public sbyte typeupdate;

	public sbyte[] indexSplash = new sbyte[4];

	public const sbyte NORMAL = 0;

	public const sbyte REMOVE_BY_FRAME = 1;

	public const sbyte REMOVE_BY_TIME = 2;

	public const sbyte NO_REMOVE = 3;

	private bool isHorse;

	public bool isAddEffect;

	public bool isHead;

	public sbyte[] ActionStand;

	public sbyte[] ActionMove;

	public sbyte[] ActionJum;

	public sbyte[] ActionFall;

	public sbyte[] FrameChar;

	public sbyte nHorseFrame;

	public sbyte dxHorse;

	public sbyte dyHorse;

	private MyVector v1 = new MyVector();

	private MyVector v2 = new MyVector();

	private MyVector v3 = new MyVector();

	private MyVector v4 = new MyVector();

	private MyVector v5 = new MyVector();

	public MyVector vecmySkil = new MyVector();

	public long timelive;

	public long timeWait;

	public int miliSecondWait;

	public bool wantDetroy;

	public bool wait;

	public int fw;

	public int fh;

	public DataSkillEff()
	{
	}

	public DataSkillEff(short id, bool isEff)
	{
		idEff = id;
		isHorse = isEff;
		loadnew(null);
	}

	public DataSkillEff(short id, long timelive, int miliSecondWait, bool isHead)
	{
		idEff = id;
		this.timelive = timelive;
		this.miliSecondWait = miliSecondWait;
		this.isHead = isHead;
		loadnew(null);
		switch (timelive)
		{
		case -1L:
			typeupdate = 3;
			break;
		case 0L:
			typeupdate = 1;
			break;
		default:
			this.timelive += mSystem.currentTimeMillis();
			typeupdate = 2;
			break;
		}
	}

	public DataSkillEff(sbyte[] array)
	{
		loadData(array);
	}

	public void loadnew(sbyte[] array)
	{
		try
		{
			if (array == null || array.Length == 0)
			{
				EffectData effectData = (EffectData)GameData.listbyteData.get(string.Empty + (idEff + GameData.ID_START_SKILL));
				if (effectData != null && effectData.data != null)
				{
					array = effectData.data;
				}
				if (effectData == null)
				{
					effectData = new EffectData((short)(idEff + GameData.ID_START_SKILL));
					GameData.listbyteData.put(string.Empty + (idEff + GameData.ID_START_SKILL), effectData);
					Service.gI().doGetByteData(idEff + GameData.ID_START_SKILL);
					effectData.timeremove = (int)(mSystem.currentTimeMillis() / 1000);
				}
			}
			if (array != null && array.Length != 0)
			{
				loadData(array);
			}
		}
		catch (Exception)
		{
		}
	}

	public void loadData(sbyte[] array)
	{
		if (array == null)
		{
			return;
		}
		DataInputStream dataInputStream = null;
		try
		{
			bool flag = true;
			listFrame.removeAllElements();
			smallImage = null;
			dataInputStream = new DataInputStream(array);
			int num = dataInputStream.readByte();
			smallImage = new SmallImage[num];
			for (int i = 0; i < num; i++)
			{
				smallImage[i] = new SmallImage(dataInputStream.readUnsignedByte(), dataInputStream.readUnsignedByte(), dataInputStream.readUnsignedByte(), dataInputStream.readUnsignedByte(), dataInputStream.readUnsignedByte());
			}
			int num2 = 0;
			int num3 = dataInputStream.readShort();
			for (int j = 0; j < num3; j++)
			{
				sbyte b = dataInputStream.readByte();
				MyVector myVector = new MyVector();
				MyVector myVector2 = new MyVector();
				for (int k = 0; k < b; k++)
				{
					PartFrame partFrame = new PartFrame(dataInputStream.readShort(), dataInputStream.readShort(), dataInputStream.readByte());
					if (flag)
					{
						partFrame.flip = dataInputStream.readByte();
						partFrame.onTop = dataInputStream.readByte();
					}
					if (partFrame.onTop == 0)
					{
						myVector.addElement(partFrame);
					}
					else
					{
						myVector2.addElement(partFrame);
					}
					if (num2 < Res.abs(partFrame.dy))
					{
						num2 = Res.abs(partFrame.dy);
					}
				}
				listFrame.addElement(new FrameEff(myVector, myVector2));
			}
			fw = smallImage[0].w;
			fh = (short)num2;
			short num4 = 0;
			num4 = ((!flag) ? dataInputStream.readShort() : ((short)dataInputStream.readUnsignedByte()));
			sequence = new sbyte[num4];
			int num5 = 0;
			for (int l = 0; l < num4; l++)
			{
				sequence[l] = (sbyte)dataInputStream.readShort();
				if (isHorse)
				{
					if (num5 == 2 && sequence[l] != -1)
					{
						v1.addElement(sequence[l] + string.Empty);
					}
					if (num5 == 3 && sequence[l] != -1)
					{
						v2.addElement(sequence[l] + string.Empty);
					}
					if (num5 == 4 && sequence[l] != -1)
					{
						v3.addElement(sequence[l] + string.Empty);
					}
					if (num5 == 5 && sequence[l] != -1)
					{
						v4.addElement(sequence[l] + string.Empty);
					}
					if (num5 == 6 && sequence[l] != -1)
					{
						v5.addElement(sequence[l] + string.Empty);
					}
					if (sequence[l] == -1)
					{
						num5++;
					}
				}
			}
			if (isHorse)
			{
				nHorseFrame = sequence[0];
				dxHorse = sequence[2];
				dyHorse = sequence[3];
				FrameChar = vector2arr(v1);
				ActionStand = vector2arr(v2);
				ActionMove = vector2arr(v3);
				ActionJum = vector2arr(v4);
				ActionFall = vector2arr(v5);
				v1.removeAllElements();
				v2.removeAllElements();
				v3.removeAllElements();
				v4.removeAllElements();
				v5.removeAllElements();
			}
			if (flag)
			{
				dataInputStream.readByte();
				num4 = dataInputStream.readByte();
				frameChar[0] = new sbyte[num4];
				for (int m = 0; m < num4; m++)
				{
					frameChar[0][m] = dataInputStream.readByte();
				}
				num4 = dataInputStream.readByte();
				frameChar[1] = new sbyte[num4];
				for (int n = 0; n < num4; n++)
				{
					frameChar[1][n] = dataInputStream.readByte();
				}
				num4 = dataInputStream.readByte();
				frameChar[3] = new sbyte[num4];
				for (int num6 = 0; num6 < num4; num6++)
				{
					frameChar[3][num6] = dataInputStream.readByte();
				}
			}
			isLoadData = true;
			try
			{
				indexSplash[0] = (sbyte)(frameChar[0].Length - 7);
				indexSplash[1] = (sbyte)(frameChar[1].Length - 7);
				indexSplash[2] = (sbyte)(frameChar[3].Length - 7);
				indexSplash[3] = (sbyte)(frameChar[3].Length - 7);
			}
			catch (Exception)
			{
			}
			indexSplash[0] = dataInputStream.readByte();
			indexSplash[1] = dataInputStream.readByte();
			indexSplash[2] = dataInputStream.readByte();
			indexSplash[3] = indexSplash[2];
		}
		catch (Exception)
		{
		}
		finally
		{
			try
			{
				dataInputStream.close();
			}
			catch (Exception)
			{
			}
		}
	}

	public static void checkremove()
	{
		try
		{
			IDictionaryEnumerator enumerator = GameData.listbyteData.GetEnumerator();
			MyVector myVector = new MyVector();
			while (enumerator.MoveNext())
			{
				string text = enumerator.Key.ToString();
				EffectData effectData = (EffectData)GameData.listbyteData.get(text);
				if (mSystem.currentTimeMillis() / 1000 - effectData.timeremove > 60)
				{
					myVector.addElement(text);
				}
			}
			for (int i = 0; i < myVector.size(); i++)
			{
				string k = (string)myVector.elementAt(i);
				GameData.listbyteData.remove(k);
			}
		}
		catch (Exception)
		{
		}
	}

	public sbyte[] vector2arr(MyVector vec)
	{
		sbyte[] array = null;
		array = new sbyte[vec.size()];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = sbyte.Parse((string)vec.elementAt(i));
		}
		return array;
	}

	public void setTypeEff(long timelive)
	{
		switch (timelive)
		{
		case -1L:
			typeupdate = 3;
			break;
		case 0L:
			typeupdate = 1;
			break;
		default:
			typeupdate = 2;
			break;
		}
	}

	public void setInfodata(EffectData dinfo)
	{
		if (dinfo != null && dinfo.isLoad)
		{
			listFrame = dinfo.listFrame;
			smallImage = dinfo.smallImage;
			fw = dinfo.fw;
			fh = dinfo.fh;
			sequence = dinfo.sequence;
			indexSplash = dinfo.indexStartSkill;
			frameChar = dinfo.frameChar;
			isLoadData = dinfo.isLoad;
		}
	}

	public bool isHavedata()
	{
		if (isLoadData)
		{
			return true;
		}
		loadnew(null);
		return false;
	}

	public void paintBottomEff_new(mGraphics g, int x, int y, int Frame, int rotale)
	{
		if (!isHavedata() || Frame >= listFrame.size())
		{
			return;
		}
		FrameEff frameEff = (FrameEff)listFrame.elementAt(Frame);
		try
		{
			MyVector listPartBottom = frameEff.listPartBottom;
			for (int i = 0; i < listPartBottom.size(); i++)
			{
				PartFrame partFrame = (PartFrame)listPartBottom.elementAt(i);
				SmallImage smallImage = this.smallImage[partFrame.idSmallImg];
				ImageIcon imgIcon = GameData.getImgIcon((short)(idEff + GameData.ID_START_SKILL));
				if (imgIcon != null && imgIcon.img != null)
				{
					int num = partFrame.dx;
					int num2 = smallImage.w;
					int num3 = smallImage.h;
					int num4 = smallImage.x;
					int num5 = smallImage.y;
					int width = imgIcon.img.getWidth();
					int height = imgIcon.img.getHeight();
					if (num4 > width)
					{
						num4 = 0;
					}
					if (num5 > height)
					{
						num5 = 0;
					}
					if (num4 + num2 > width)
					{
						num2 = width - num4;
					}
					if (num5 + num3 > height)
					{
						num3 = height - num5;
					}
					int num6 = ((partFrame.flip == 1) ? 2 : 0);
					if (rotale == 2 || rotale == 6)
					{
						num6 = ((num6 != 2) ? 2 : 0);
						num = -(num + num2);
					}
					g.drawRegion(imgIcon.img, num4, num5, num2, num3, num6, x + num, y + partFrame.dy, 0);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public void paintTopEff_new(mGraphics g, int x, int y, int Frame, int rotale)
	{
		if (!isHavedata() || Frame >= listFrame.size())
		{
			return;
		}
		FrameEff frameEff = (FrameEff)listFrame.elementAt(Frame);
		try
		{
			MyVector listPartTop = frameEff.listPartTop;
			for (int i = 0; i < listPartTop.size(); i++)
			{
				PartFrame partFrame = (PartFrame)listPartTop.elementAt(i);
				SmallImage smallImage = this.smallImage[partFrame.idSmallImg];
				ImageIcon imgIcon = GameData.getImgIcon((short)(idEff + GameData.ID_START_SKILL));
				if (imgIcon != null && imgIcon.img != null)
				{
					int num = partFrame.dx;
					int num2 = smallImage.w;
					int num3 = smallImage.h;
					int num4 = smallImage.x;
					int num5 = smallImage.y;
					int width = imgIcon.img.getWidth();
					int height = imgIcon.img.getHeight();
					if (num4 > width)
					{
						num4 = 0;
					}
					if (num5 > height)
					{
						num5 = 0;
					}
					if (num4 + num2 > width)
					{
						num2 = width - num4;
					}
					if (num5 + num3 > height)
					{
						num3 = height - num5;
					}
					int num6 = ((partFrame.flip == 1) ? 2 : 0);
					if (rotale == 2 || rotale == 6)
					{
						num6 = ((num6 != 2) ? 2 : 0);
						num = -(num + num2);
					}
					g.drawRegion(imgIcon.img, num4, num5, num2, num3, num6, x + num, y + partFrame.dy, 0);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public void paintTopEff(mGraphics g, int x, int y)
	{
		try
		{
			if (!isHavedata() || wait || Frame >= listFrame.size())
			{
				return;
			}
			FrameEff frameEff = (FrameEff)listFrame.elementAt(Frame);
			MyVector listPartTop = frameEff.listPartTop;
			for (int i = 0; i < listPartTop.size(); i++)
			{
				PartFrame partFrame = (PartFrame)listPartTop.elementAt(i);
				SmallImage smallImage = this.smallImage[partFrame.idSmallImg];
				ImageIcon imgIcon = GameData.getImgIcon((short)(idEff + GameData.ID_START_SKILL));
				if (imgIcon != null && imgIcon.img != null)
				{
					int dx = partFrame.dx;
					int num = smallImage.w;
					int num2 = smallImage.h;
					int num3 = smallImage.x;
					int num4 = smallImage.y;
					if (num3 > imgIcon.img.getWidth())
					{
						num3 = 0;
					}
					if (num4 > imgIcon.img.getHeight())
					{
						num4 = 0;
					}
					if (num3 + num > imgIcon.img.getWidth())
					{
						num = imgIcon.img.getWidth() - num3;
					}
					if (num4 + num2 > imgIcon.img.getHeight())
					{
						num2 = imgIcon.img.getHeight() - num4;
					}
					g.drawRegion(imgIcon.img, num3, num4, num, num2, (partFrame.flip == 1) ? 2 : 0, x + dx, y + partFrame.dy, 0);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public void paintBottomEff(mGraphics g, int x, int y)
	{
		try
		{
			if (!isHavedata() || wait || Frame >= listFrame.size())
			{
				return;
			}
			FrameEff frameEff = (FrameEff)listFrame.elementAt(Frame);
			MyVector listPartBottom = frameEff.listPartBottom;
			for (int i = 0; i < listPartBottom.size(); i++)
			{
				PartFrame partFrame = (PartFrame)listPartBottom.elementAt(i);
				SmallImage smallImage = this.smallImage[partFrame.idSmallImg];
				ImageIcon imgIcon = GameData.getImgIcon((short)(idEff + GameData.ID_START_SKILL));
				if (imgIcon != null && imgIcon.img != null)
				{
					int dx = partFrame.dx;
					int num = smallImage.w;
					int num2 = smallImage.h;
					int num3 = smallImage.x;
					int num4 = smallImage.y;
					if (num3 > imgIcon.img.getWidth())
					{
						num3 = 0;
					}
					if (num4 > imgIcon.img.getHeight())
					{
						num4 = 0;
					}
					if (num3 + num > imgIcon.img.getWidth())
					{
						num = imgIcon.img.getWidth() - num3;
					}
					if (num4 + num2 > imgIcon.img.getHeight())
					{
						num2 = imgIcon.img.getHeight() - num4;
					}
					g.drawRegion(imgIcon.img, num3, num4, num, num2, (partFrame.flip == 1) ? 2 : 0, x + dx, y + partFrame.dy, 0);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public void setFrame(int fr)
	{
		Frame = (sbyte)fr;
	}

	private void setWait(bool iss)
	{
		if (miliSecondWait > 0)
		{
			wait = iss;
			if (wait)
			{
				timeWait = mSystem.currentTimeMillis() + miliSecondWait;
			}
		}
		else
		{
			wait = false;
		}
	}

	public void updateEffCharDie()
	{
		if (isLoadData)
		{
			if (f < sequence.Length)
			{
				f++;
			}
			if (f > sequence.Length - 1)
			{
				f = (sbyte)(sequence.Length - 1);
			}
			Frame = sequence[f];
		}
	}

	public void setLoop(int loop)
	{
		this.loop = loop;
	}

	public void update()
	{
		if (listFrame.size() <= 0)
		{
			return;
		}
		try
		{
			if (!wait)
			{
				switch (typeupdate)
				{
				case 0:
					f++;
					if (f > sequence.Length)
					{
						if (!canremove)
						{
							wantDetroy = true;
						}
						f = 0;
					}
					Frame = sequence[f];
					break;
				case 1:
					f++;
					if (f > sequence.Length)
					{
						f = 0;
						wantDetroy = true;
					}
					Frame = sequence[f];
					break;
				case 2:
					f++;
					if (f == (sbyte)(sequence.Length - 1) && timelive - mSystem.currentTimeMillis() < 0)
					{
						wantDetroy = true;
					}
					if (f > sequence.Length)
					{
						f = 0;
						setWait(iss: true);
					}
					Frame = sequence[f];
					break;
				case 3:
					f++;
					if (f > sequence.Length)
					{
						f = 0;
						setWait(iss: true);
					}
					Frame = sequence[f];
					break;
				}
			}
			else if (timeWait - mSystem.currentTimeMillis() < 0)
			{
				setWait(iss: false);
			}
		}
		catch (Exception)
		{
		}
	}

	public int getWidth()
	{
		return fw;
	}

	public int getHeight()
	{
		return fh;
	}

	public int getX()
	{
		return x;
	}

	public int getY()
	{
		return y;
	}
}
