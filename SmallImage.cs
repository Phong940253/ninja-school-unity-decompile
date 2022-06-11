using System;
using System.Collections;
using UnityEngine;

public class SmallImage
{
	public static int[][] smallImg;

	public static SmallImage instance;

	public static Image[] imgbig;

	public static mHashtable imgNew = new mHashtable();

	public static Image imgEmpty = null;

	public short id;

	public short x;

	public short y;

	public short w;

	public short h;

	public SmallImage(int id, int x, int y, int w, int h)
	{
		this.id = (short)id;
		this.x = (short)x;
		this.y = (short)y;
		this.w = (short)w;
		this.h = (short)h;
	}

	public SmallImage()
	{
		readImage();
	}

	public void paint(mGraphics g, Image img, int x, int y)
	{
	}

	public static Image checkloadImageres(int id)
	{
		string path = "/x" + mGraphics.zoomLevel + "/Small" + id;
		MyImage myImage = new MyImage();
		imgNew.put(id + string.Empty, myImage);
		myImage.img = GameCanvas.loadImage(path);
		return myImage?.img;
	}

	public static void checkTimeUseImg()
	{
		IDictionaryEnumerator enumerator = imgNew.GetEnumerator();
		MyVector myVector = new MyVector();
		while (enumerator.MoveNext())
		{
			string text = enumerator.Key.ToString();
			MyImage myImage = (MyImage)imgNew.get(text);
			if (mSystem.currentTimeMillis() - myImage.timeUse > 180000)
			{
				myVector.addElement(text);
			}
		}
		for (int i = 0; i < myVector.size(); i++)
		{
			string k = (string)myVector.elementAt(i);
			imgNew.remove(k);
		}
	}

	public static void freeBig()
	{
		imgbig = null;
	}

	public static void loadBigImage()
	{
		imgbig = null;
		imgbig = new Image[5]
		{
			GameCanvas.loadImage("/img/Big0"),
			GameCanvas.loadImage("/img/Big1"),
			GameCanvas.loadImage("/img/Big2"),
			GameCanvas.loadImage("/img/Big3"),
			GameCanvas.loadImage("/img/Big4")
		};
		imgEmpty = Image.createRGBImage(new int[1], 1, 1, bl: true);
	}

	public static void init()
	{
		instance = null;
		instance = new SmallImage();
	}

	public void readImage()
	{
		try
		{
			DataInputStream dataInputStream = new DataInputStream(RMS.loadRMS("nj_image"));
			int num = dataInputStream.readShort();
			smallImg = new int[num][];
			for (int i = 0; i < smallImg.Length; i++)
			{
				smallImg[i] = new int[5];
			}
			for (int j = 0; j < num; j++)
			{
				smallImg[j][0] = dataInputStream.readUnsignedByte();
				smallImg[j][1] = dataInputStream.readShort();
				smallImg[j][2] = dataInputStream.readShort();
				smallImg[j][3] = dataInputStream.readShort();
				smallImg[j][4] = dataInputStream.readShort();
			}
		}
		catch (Exception ex)
		{
			Out.println(" loi redImg " + ex.ToString());
		}
	}

	public static int getWith(int id)
	{
		return smallImg[id][3];
	}

	public static int getHeight(int id)
	{
		return smallImg[id][4];
	}

	public static void reciveImage(int id, sbyte[] data)
	{
		MyImage myImage = (MyImage)imgNew.get(id + string.Empty);
		if (myImage == null)
		{
			myImage = new MyImage();
			imgNew.put(myImage.idImage + string.Empty, myImage);
		}
		myImage.idImage = id;
		myImage.img = Controller.createImage(data);
		if (GameMidlet.CLIENT_TYPE != 1)
		{
			RMS.saveRMSImage(id + string.Empty, data);
		}
	}

	public static bool isExitsImage(int id)
	{
		try
		{
			if (id >= smallImg.Length || smallImg[id][1] >= imgbig[smallImg[id][0]].getWidth() || smallImg[id][3] >= imgbig[smallImg[id][0]].getWidth() || smallImg[id][2] >= imgbig[smallImg[id][0]].getHeight() || smallImg[id][4] >= imgbig[smallImg[id][0]].getHeight())
			{
				MyImage myImage = (MyImage)imgNew.get(id + string.Empty);
				if (myImage == null || myImage.Equals(imgEmpty))
				{
					myImage = new MyImage();
					myImage.idImage = id;
					imgNew.put(myImage.idImage + string.Empty, myImage);
					myImage.img = checkloadImageres(id);
					if (myImage.img == null)
					{
						myImage.img = Controller.createImage(RMS.loadRMS(id + string.Empty));
					}
					if (myImage.img == null)
					{
						myImage.timerequest = mSystem.currentTimeMillis();
						Service.gI().requestIcon(id);
					}
					return false;
				}
				if (myImage.img != null)
				{
					return true;
				}
				if (myImage.img == null && mSystem.currentTimeMillis() - myImage.timerequest > 60000)
				{
					myImage.timerequest = mSystem.currentTimeMillis();
					Service.gI().requestIcon(id);
					return false;
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			Debug.Log("EEEEE ---> " + ex.Message + ex.StackTrace);
		}
		return true;
	}

	public static void drawSmallImageNew(mGraphics g, int id, int x, int y, int transform, int anchor)
	{
		try
		{
			if (smallImg == null)
			{
				return;
			}
			if (id >= smallImg.Length || smallImg[id][1] >= imgbig[smallImg[id][0]].getWidth() || smallImg[id][3] >= imgbig[smallImg[id][0]].getWidth() || smallImg[id][2] >= imgbig[smallImg[id][0]].getHeight() || smallImg[id][4] >= imgbig[smallImg[id][0]].getHeight())
			{
				MyImage myImage = (MyImage)imgNew.get(id + string.Empty);
				if (myImage == null)
				{
					myImage = new MyImage();
					myImage.idImage = id;
					imgNew.put(myImage.idImage + string.Empty, myImage);
					myImage.img = checkloadImageres(id);
					if (myImage.img == null)
					{
						myImage.img = Controller.createImage(RMS.loadRMS(id + string.Empty));
						if (myImage.img == null)
						{
							myImage.timerequest = mSystem.currentTimeMillis();
							Service.gI().requestIcon(id);
						}
					}
				}
				else if (myImage.img == null && mSystem.currentTimeMillis() - myImage.timerequest > 60000)
				{
					myImage.timerequest = mSystem.currentTimeMillis();
					Service.gI().requestIcon(id);
				}
				if (myImage == null)
				{
					return;
				}
				if (myImage.img != null)
				{
					if (myImage.img.getHeight() > 35)
					{
						int width = myImage.img.getWidth();
						int num = myImage.img.getHeight() / 3;
						if (GameCanvas.gameTick % 6 == 0)
						{
							myImage.indexFrame = (sbyte)((myImage.indexFrame + 1) % 3);
						}
						g.drawRegion(myImage.img, 0, myImage.indexFrame * num, width, num, transform, x, y, anchor);
					}
					else
					{
						g.drawRegion(myImage.img, 0, 0, myImage.img.getWidth(), myImage.img.getHeight(), transform, x, y, anchor);
					}
				}
				myImage.timeUse = mSystem.currentTimeMillis();
			}
			else
			{
				g.drawRegion(imgbig[smallImg[id][0]], smallImg[id][1], smallImg[id][2], smallImg[id][3], smallImg[id][4], transform, x, y, anchor);
			}
		}
		catch (Exception ex)
		{
			Debug.Log("DRAW SMALL IMAGE ----> " + ex.Message + ex.StackTrace);
		}
	}

	public static void drawSmallImage(mGraphics g, int id, int x, int y, int transform, int anchor)
	{
		try
		{
			if (smallImg == null)
			{
				return;
			}
			if (id >= smallImg.Length || smallImg[id][1] >= imgbig[smallImg[id][0]].getWidth() || smallImg[id][3] >= imgbig[smallImg[id][0]].getWidth() || smallImg[id][2] >= imgbig[smallImg[id][0]].getHeight() || smallImg[id][4] >= imgbig[smallImg[id][0]].getHeight())
			{
				MyImage myImage = (MyImage)imgNew.get(id + string.Empty);
				if (myImage == null)
				{
					myImage = new MyImage();
					myImage.idImage = id;
					imgNew.put(myImage.idImage + string.Empty, myImage);
					myImage.img = checkloadImageres(id);
					if (myImage.img == null)
					{
						myImage.img = Controller.createImage(RMS.loadRMS(id + string.Empty));
						if (myImage.img == null)
						{
							myImage.timerequest = mSystem.currentTimeMillis();
							Service.gI().requestIcon(id);
						}
					}
				}
				else if (myImage.img == null && mSystem.currentTimeMillis() - myImage.timerequest > 60000)
				{
					myImage.timerequest = mSystem.currentTimeMillis();
					Service.gI().requestIcon(id);
				}
				if (myImage != null)
				{
					if (myImage.img != null)
					{
						g.drawRegion(myImage.img, 0, 0, myImage.img.getWidth(), myImage.img.getHeight(), transform, x, y, anchor);
					}
					myImage.timeUse = mSystem.currentTimeMillis();
				}
			}
			else
			{
				g.drawRegion(imgbig[smallImg[id][0]], smallImg[id][1], smallImg[id][2], smallImg[id][3], smallImg[id][4], transform, x, y, anchor);
			}
		}
		catch (Exception ex)
		{
			Debug.Log("DRAW SMALL IMAGE ----> " + ex.Message + ex.StackTrace);
		}
	}

	public static void drawRegionSmallImage(mGraphics g, int id, int x, int y, int w, int h, int transform, int anchor)
	{
		g.drawRegion(imgbig[smallImg[id][0]], smallImg[id][1], smallImg[id][2], (smallImg[id][3] >= w) ? w : smallImg[id][3], (smallImg[id][4] >= h) ? h : smallImg[id][4], transform, x, y, anchor);
	}
}
