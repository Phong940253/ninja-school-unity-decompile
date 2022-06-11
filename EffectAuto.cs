using System;
using System.Collections;

public class EffectAuto : Effect2
{
	private short id;

	private MyImage img;

	private int x;

	private int y;

	private int f;

	private int dir;

	private sbyte loopCount;

	private long endTime;

	public static EffAtutoTemp[] arrEffAtutoTemplate = new EffAtutoTemp[20];

	public static mHashtable imgEffAuto = new mHashtable();

	public static mHashtable dataEffAuto = new mHashtable();

	private bool isInfinite_loop;

	public static void addEffectAuto(short id, int x, int y, sbyte loopCount, short time, int dir)
	{
		EffectAuto effectAuto = new EffectAuto();
		effectAuto.id = id;
		effectAuto.x = x;
		effectAuto.y = y;
		effectAuto.loopCount = loopCount;
		if (effectAuto.loopCount < 0)
		{
			effectAuto.isInfinite_loop = true;
		}
		else
		{
			effectAuto.isInfinite_loop = false;
		}
		if (time > 0)
		{
			effectAuto.endTime = mSystem.currentTimeMillis() + time * 1000;
		}
		else
		{
			effectAuto.endTime = -1L;
		}
		effectAuto.dir = dir;
		Effect2.vEffect2.addElement(effectAuto);
	}

	public EffAtutoTemp getTemplate()
	{
		return arrEffAtutoTemplate[id];
	}

	public override void paint(mGraphics g)
	{
		if (img == null || img.img == null || getTemplate().frameRunning == null)
		{
			return;
		}
		Frame frame = getTemplate().frameEffAuto[getTemplate().frameRunning[f]];
		for (int i = 0; i < frame.dx.Length; i++)
		{
			ImageInfo imgInfo = getTemplate().getImgInfo(frame.idImg[i]);
			if (dir > 0)
			{
				g.drawRegion(img.img, imgInfo.x0, imgInfo.y0, imgInfo.w, imgInfo.h, 0, x + frame.dx[i], y + frame.dy[i] - 1, mGraphics.TOP | mGraphics.LEFT);
			}
			else
			{
				g.drawRegion(img.img, imgInfo.x0, imgInfo.y0, imgInfo.w, imgInfo.h, 2, x - frame.dx[i], y + frame.dy[i] - 1, mGraphics.TOP | mGraphics.RIGHT);
			}
		}
	}

	public override void update()
	{
		try
		{
			arrEffAtutoTemplate[id] = (EffAtutoTemp)dataEffAuto.get(id + string.Empty);
			if (arrEffAtutoTemplate[id] == null)
			{
				arrEffAtutoTemplate[id] = new EffAtutoTemp();
				getTemplate().idEffAuto = id;
				dataEffAuto.put(id + string.Empty, arrEffAtutoTemplate[id]);
				getTemplate().timerequest = mSystem.currentTimeMillis();
				Service.gI().request_imgEffAuto(1, id);
			}
			else if (getTemplate().frameRunning == null && mSystem.currentTimeMillis() - getTemplate().timerequest > 3000)
			{
				getTemplate().timerequest = mSystem.currentTimeMillis();
				Service.gI().request_imgEffAuto(1, id);
			}
			if (getTemplate().frameRunning != null)
			{
				img = (MyImage)imgEffAuto.get(id + string.Empty);
				if (img == null)
				{
					img = new MyImage();
					img.idImage = id;
					imgEffAuto.put(id + string.Empty, img);
					img.img = Controller.createImage(RMS.loadRMS("effauto " + id));
					if (img.img == null)
					{
						img.timerequest = mSystem.currentTimeMillis();
						Service.gI().request_imgEffAuto(0, id);
					}
				}
				else if (img.img == null && mSystem.currentTimeMillis() - img.timerequest > 6000)
				{
					img.timerequest = mSystem.currentTimeMillis();
					Service.gI().request_imgEffAuto(0, id);
				}
			}
			if (img == null || img.img == null || getTemplate().frameRunning == null)
			{
				return;
			}
			f++;
			if (f >= getTemplate().frameRunning.Length)
			{
				if (endTime != -1)
				{
					if (endTime - mSystem.currentTimeMillis() <= 0)
					{
						Effect2.vEffect2.removeElement(this);
					}
					else
					{
						f = 0;
					}
				}
				else if (isInfinite_loop)
				{
					f = 0;
				}
				else
				{
					loopCount--;
					if (loopCount <= 0)
					{
						Effect2.vEffect2.removeElement(this);
					}
					else
					{
						f = 0;
					}
				}
			}
			img.timeUse = mSystem.currentTimeMillis();
		}
		catch (Exception)
		{
			mSystem.println("Err update effauto:");
		}
	}

	public static void reciveData(short id, sbyte[] data)
	{
		EffAtutoTemp effAtutoTemp = (EffAtutoTemp)dataEffAuto.get(id + string.Empty);
		if (effAtutoTemp.frameRunning == null)
		{
			effAtutoTemp = new EffAtutoTemp();
			effAtutoTemp = creatDataEffauto(id, data);
			dataEffAuto.put(id + string.Empty, effAtutoTemp);
		}
	}

	public static EffAtutoTemp creatDataEffauto(short idEff, sbyte[] data)
	{
		try
		{
			EffAtutoTemp effAtutoTemp = new EffAtutoTemp();
			DataInputStream dataInputStream = new DataInputStream(data);
			effAtutoTemp.idEffAuto = idEff;
			effAtutoTemp.imginfo = new ImageInfo[dataInputStream.readByte()];
			for (int i = 0; i < effAtutoTemp.imginfo.Length; i++)
			{
				effAtutoTemp.imginfo[i] = new ImageInfo();
				effAtutoTemp.imginfo[i].ID = dataInputStream.readByte();
				effAtutoTemp.imginfo[i].x0 = dataInputStream.readUnsignedByte();
				effAtutoTemp.imginfo[i].y0 = dataInputStream.readUnsignedByte();
				effAtutoTemp.imginfo[i].w = dataInputStream.readUnsignedByte();
				effAtutoTemp.imginfo[i].h = dataInputStream.readUnsignedByte();
			}
			effAtutoTemp.frameEffAuto = new Frame[dataInputStream.readShort()];
			for (int j = 0; j < effAtutoTemp.frameEffAuto.Length; j++)
			{
				effAtutoTemp.frameEffAuto[j] = new Frame();
				sbyte b = dataInputStream.readByte();
				effAtutoTemp.frameEffAuto[j].dx = new short[b];
				effAtutoTemp.frameEffAuto[j].dy = new short[b];
				effAtutoTemp.frameEffAuto[j].idImg = new sbyte[b];
				for (int k = 0; k < b; k++)
				{
					effAtutoTemp.frameEffAuto[j].dx[k] = dataInputStream.readShort();
					effAtutoTemp.frameEffAuto[j].dy[k] = dataInputStream.readShort();
					effAtutoTemp.frameEffAuto[j].idImg[k] = dataInputStream.readByte();
				}
			}
			short num = dataInputStream.readShort();
			effAtutoTemp.frameRunning = new short[num];
			for (int l = 0; l < num; l++)
			{
				effAtutoTemp.frameRunning[l] = dataInputStream.readShort();
			}
			return effAtutoTemp;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void reciveImage(short id, sbyte[] data)
	{
		MyImage myImage = (MyImage)imgEffAuto.get(id + string.Empty);
		if (myImage == null)
		{
			myImage = new MyImage();
			imgEffAuto.put(id + string.Empty, myImage);
		}
		myImage.idImage = id;
		myImage.img = Controller.createImage(data);
		if (GameMidlet.CLIENT_TYPE != 1)
		{
			RMS.saveRMSImage("effauto " + id, data);
		}
	}

	public static void checkTimeUseImg()
	{
		try
		{
			IDictionaryEnumerator enumerator = imgEffAuto.GetEnumerator();
			MyVector myVector = new MyVector();
			while (enumerator.MoveNext())
			{
				string text = enumerator.Key.ToString();
				MyImage myImage = (MyImage)imgEffAuto.get(text);
				if (mSystem.currentTimeMillis() - myImage.timeUse > 60000)
				{
					myVector.addElement(text);
				}
			}
			for (int i = 0; i < myVector.size(); i++)
			{
				string k = (string)myVector.elementAt(i);
				imgEffAuto.remove(k);
			}
		}
		catch (Exception)
		{
		}
	}

	public static void checkTimeUseData()
	{
		try
		{
			IDictionaryEnumerator enumerator = dataEffAuto.GetEnumerator();
			MyVector myVector = new MyVector();
			while (enumerator.MoveNext())
			{
				string text = enumerator.Key.ToString();
				EffAtutoTemp effAtutoTemp = (EffAtutoTemp)dataEffAuto.get(text);
				if (mSystem.currentTimeMillis() - effAtutoTemp.timeUse > 600000)
				{
					myVector.addElement(text);
				}
			}
			for (int i = 0; i < myVector.size(); i++)
			{
				string k = (string)myVector.elementAt(i);
				dataEffAuto.remove(k);
			}
		}
		catch (Exception)
		{
		}
	}
}
