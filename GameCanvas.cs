using System;
using UnityEngine;

public class GameCanvas : IActionListener
{
	public static Image testCapcha = null;

	public static bool lowGraphic = false;

	public static bool isMoveNumberPad = true;

	public static bool isLoading;

	public static bool isChangMapKey;

	public static bool isGPRS = true;

	public static bool isBallEffect = false;

	public static bool isTouch = true;

	public static bool isTouchControl;

	public static bool isTouchControlSmallScreen;

	public static bool isTouchControlLargeScreen;

	public static GameCanvas instance;

	public static bool bRun;

	public static bool[] keyPressedz = new bool[33];

	public static bool[] keyReleasedz = new bool[33];

	public static bool[] keyHold = new bool[33];

	public static bool isPointerDown;

	public static bool isPointerClick;

	public static bool isPointerJustRelease;

	public static int px;

	public static int py;

	public static int pxFirst;

	public static int pyFirst;

	public static int pxLast;

	public static int pyLast;

	public static Position[] arrPos = new Position[4];

	public static int gameTick;

	public static int taskTick;

	public static bool isEff1;

	public static bool isEff2;

	public static long timeTickEff1;

	public static long timeTickEff2;

	public static int w;

	public static int h;

	public static int hw;

	public static int hh;

	public static int wd3;

	public static int hd3;

	public static int w2d3;

	public static int h2d3;

	public static int w3d4;

	public static int h3d4;

	public static int wd6;

	public static int hd6;

	public static mScreen currentScreen;

	public static Menu menu = new Menu();

	public static SelectServerScr selectsvScr;

	public static LoginScr loginScr;

	public static LanguageScr languageScr;

	public static Dialog currentDialog;

	public static MsgDlg msgdlg;

	public static InputDlg inputDlg;

	public static Input2Dlg input2Dlg;

	public static MyVector currentPopup = new MyVector();

	public static int requestLoseCount;

	public static MyVector listPoint = new MyVector();

	public static Paint paintz;

	public static Position pos;

	public static Image[] imgBG;

	public static int skyColor;

	public static int curPos = 0;

	public static int timeBallEffect;

	public static int borderConnerW;

	public static int borderConnerH;

	public static int borderLineW;

	public static int borderLineH;

	public static int[] imgBGWidth;

	private mGraphics g = new mGraphics();

	public static bool isConnectFail;

	public static Image efArr;

	public static RegisterScr regScr;

	public static int himgShuriken = 0;

	public static MyVector debugUpdate;

	public static MyVector debugPaint;

	public static MyVector debugSession;

	private static bool isShowErrorForm = false;

	public static bool paintBG;

	public static int gsskyHeight;

	public static int gsgreenField1Y;

	public static int gsgreenField2Y;

	public static int gshouseY;

	public static int gsmountainY;

	public static int bgLayer0y;

	public static int bgLayer1y;

	public static Image imgCloud1;

	public static Image imgCloud2;

	public static Image imgfog;

	public static Image imgfog1;

	public static Image imgfog2;

	public static Image imgCloud;

	public static Image imgSun;

	public static Image imgClear;

	public static Image[] imgBorder = new Image[5];

	public static int[] cloudX;

	public static int[] cloudY;

	public static int sunX;

	public static int sunY;

	public static int hImgimgBorder;

	public static int wImgimgBorder;

	public static int wImBd4;

	public static int hImgBd4;

	public static int typeBg = -1;

	public static int saveIDBg = -10;

	private static long lastTimePress = 0L;

	public static int keyAsciiPress;

	public static int timePutKeyPc;

	public int UP = -1;

	public int DOWN = -2;

	public int LEFT = -3;

	public int RIGHT = -4;

	private static Image imgSignal;

	public static MyVector flyTexts = new MyVector();

	public static bool isPointerJustDown = false;

	private int count = 1;

	public static int[] bgSpeed;

	public static int cmdBarX;

	public static int cmdBarY;

	public static int cmdBarW;

	public static int cmdBarH;

	public static int cmdBarLeftW;

	public static int cmdBarRightW;

	public static int cmdBarCenterW;

	public static int hpBarX;

	public static int hpBarY;

	public static int hpBarW;

	public static int expBarW;

	public static int lvPosX;

	public static int moneyPosX;

	public static int hpBarH;

	public static int girlHPBarY;

	public int timeOut;

	public int[] dustX;

	public int[] dustY;

	public int[] dustState;

	public static int[] wsX;

	public static int[] wsY;

	public static int[] wsState;

	public static int[] wsF;

	public static Image[] imgWS;

	public static Image imgShuriken;

	public static Image[][] imgDust;

	private bool resetToLoginScrz;

	public static bool isKiemduyet = false;

	public static bool isKiemduyet_info = false;

	public static Image imgPlus12;

	public static int secondRemain;

	public static int xKd = w;

	public static int yKd = 0;

	public static int wStr;

	public static long currT;

	public static long lastT;

	public GameCanvas()
	{
		MotherCanvas.instance.setChildCanvas(this);
		w = MotherCanvas.instance.getWidth_new();
		h = MotherCanvas.instance.getHeight_new();
		hw = w / 2;
		hh = h / 2;
		isTouch = true;
		if (w >= 240)
		{
			isTouchControl = true;
		}
		if (w < 320)
		{
			isTouchControlSmallScreen = true;
		}
		if (w >= 320)
		{
			isTouchControlLargeScreen = true;
		}
		msgdlg = new MsgDlg();
		if (h <= 160)
		{
			Paint.hTab = 15;
			mScreen.cmdH = 17;
		}
		GameScr.d = ((w <= h) ? h : w) + 20;
		instance = this;
		GameScr.load_GameScr();
		initPaint();
		loadDust();
		loadWaterSplash();
		GameMidlet.loadLinkRMS();
		imgShuriken = loadImage("/u/f");
		Paint.imgCheckPass = loadImage("/hd/check");
		himgShuriken = imgShuriken.getHeight();
		debugUpdate = new MyVector();
		debugPaint = new MyVector();
		debugSession = new MyVector();
		if (isTouch)
		{
			for (int i = 0; i < imgBorder.Length; i++)
			{
				imgBorder[i] = loadImage("/hd/bd" + i + string.Empty);
			}
			borderConnerW = imgBorder[0].getWidth();
			borderConnerH = imgBorder[0].getHeight();
			borderLineW = imgBorder[1].getWidth();
			borderLineH = imgBorder[1].getHeight();
			hImgimgBorder = imgBorder[0].getHeight();
			wImgimgBorder = imgBorder[0].getWidth();
			wImBd4 = imgBorder[4].getWidth();
			hImgBd4 = imgBorder[4].getHeight();
			Out.println(" borderLineH " + borderLineH);
		}
		if (imgClear == null)
		{
			imgClear = loadImage("/er");
		}
		SmallImage.loadBigImage();
		listPoint = new MyVector();
		mScreen.initPos();
		languageScr = new LanguageScr();
	}

	public static GameCanvas gI()
	{
		if (instance == null)
		{
			instance = new GameCanvas();
		}
		return instance;
	}

	public void initPaint()
	{
		paintz = new Paint();
	}

	public static void connect(int i)
	{
		Session_ME.gI().connect(GameMidlet.IP, GameMidlet.PORT);
	}

	public void initGameCanvas()
	{
		w = MotherCanvas.instance.getWidth_new();
		h = MotherCanvas.instance.getHeight_new();
		hw = w / 2;
		hh = h / 2;
		wd3 = w / 3;
		hd3 = h / 3;
		w2d3 = 2 * w / 3;
		h2d3 = 2 * h / 3;
		w3d4 = 3 * w / 4;
		h3d4 = 3 * h / 4;
		wd6 = w / 6;
		hd6 = h / 6;
		loginScr = new LoginScr();
		selectsvScr = new SelectServerScr();
		regScr = new RegisterScr();
		inputDlg = new InputDlg();
		input2Dlg = new Input2Dlg();
	}

	public static void debug(string s, int type)
	{
	}

	public static bool isHoldPress()
	{
		if (mSystem.getCurrentTimeMillis() - lastTimePress >= 800)
		{
			return true;
		}
		return false;
	}

	public void update()
	{
		try
		{
			debugUpdate.removeAllElements();
			long currentTimeMillis = mSystem.getCurrentTimeMillis();
			if (currentTimeMillis - timeTickEff1 >= 780 && !isEff1)
			{
				timeTickEff1 = currentTimeMillis;
				isEff1 = true;
			}
			else
			{
				isEff1 = false;
			}
			if (currentTimeMillis - timeTickEff2 >= 7800 && !isEff2)
			{
				timeTickEff2 = currentTimeMillis;
				isEff2 = true;
			}
			else
			{
				isEff2 = false;
			}
			if (taskTick > 0)
			{
				taskTick--;
			}
			gameTick++;
			if (gameTick > 10000)
			{
				if (mSystem.getCurrentTimeMillis() - lastTimePress > 20000 && currentScreen == loginScr)
				{
					GameMidlet.instance.exit();
				}
				gameTick = 0;
			}
			debug("A", 0);
			if (currentScreen != null)
			{
				if (currentDialog != null)
				{
					debug("B", 0);
					currentDialog.update();
				}
				else if (menu.showMenu)
				{
					debug("C", 0);
					menu.updateMenu();
					debug("D", 0);
					menu.updateMenuKey();
				}
				debug("E", 0);
				if (!isLoading)
				{
					currentScreen.update();
				}
				debug("F", 0);
				if (!menu.showMenu)
				{
					currentScreen.updateKey();
				}
			}
			debug("Ix", 0);
			Timer.update();
			debug("Hx", 0);
			InfoDlg.update();
			debug("G", 0);
			if (resetToLoginScrz)
			{
				resetToLoginScrz = false;
				doResetToLoginScr();
			}
			debug("Zz", 0);
			if (isConnectFail)
			{
				isConnectFail = false;
				startOK(mResources.SERVER_MAINTENANCE, 8884, null);
			}
		}
		catch (Exception)
		{
		}
	}

	private void doResetToLoginScr()
	{
		selectsvScr.switchToMe();
		try
		{
			TileMap.resetDataImg();
			Char.clearMyChar();
			GameScr.clearGameScr();
			GameScr.resetAllvector();
			endDlg();
			InfoDlg.hide();
			GameScr.loadCamera(fullScreen: true);
			GameScr.cmx = 100;
			loadBG(TileMap.bgID);
			GameScr.vParty.removeAllElements();
			GameScr.vClan.removeAllElements();
			GameScr.vFriend.removeAllElements();
			GameScr.vEnemies.removeAllElements();
			Char.clan = null;
		}
		catch (Exception)
		{
			Out.println("loi doResetToLoginScr tai class GameCanvas");
		}
	}

	public static void showErrorForm(int type, string moreInfo)
	{
		Out.println("SHOW ERROR FORM  " + moreInfo);
	}

	public void updateBallEffect()
	{
		if (isBallEffect)
		{
			timeBallEffect--;
			if (timeBallEffect < 0)
			{
				isBallEffect = false;
			}
		}
	}

	public static void updateBG()
	{
		if (lowGraphic || Main.isIpod || mGraphics.zoomLevel == 1 || imgCloud == null)
		{
			return;
		}
		for (int i = 0; i < cloudX.Length; i++)
		{
			if (gameTick % (i + 2 << 3) == 0)
			{
				cloudX[i]++;
				if (cloudX[i] > GameScr.gW + (mGraphics.getImageWidth(imgCloud) >> 1))
				{
					cloudX[i] = -(mGraphics.getImageWidth(imgCloud) >> 1);
				}
			}
		}
	}

	public static bool isPointerInRoll(int x, int y, int w, int h, Scroll scroll)
	{
		int num = px + scroll.cmx;
		int num2 = scroll.cmy + py;
		if (!isPointerDown && !isPointerJustRelease)
		{
			return false;
		}
		if (num >= x && num <= x + w && num2 >= y && num2 <= y + h)
		{
			return true;
		}
		return false;
	}

	public static void paintBGGameScr(mGraphics g)
	{
		if (isBallEffect)
		{
			if (gameTick % 10 > 7)
			{
				g.setColor(16777215);
			}
			else
			{
				g.setColor(0);
			}
			g.fillRect(0, 0, GameScr.gW, GameScr.gH);
		}
		else if (paintBG && !lowGraphic && imgBG != null)
		{
			g.setColor(skyColor);
			g.fillRect(0, 0, GameScr.gW, gsskyHeight);
			if (typeBg >= 0 && typeBg <= 1)
			{
				if (imgBG[0] != null)
				{
					for (int i = -((GameScr.cmx >> 1) % 24); i < GameScr.gW; i += 24)
					{
						g.drawImage(imgBG[0], i, gsgreenField1Y, 0);
					}
				}
				if (imgBG[1] != null)
				{
					for (int j = -((GameScr.cmx >> 2) % 24); j < GameScr.gW; j += 24)
					{
						g.drawImage(imgBG[1], j, gsgreenField2Y, 0);
					}
				}
				if (imgBG[3] != null)
				{
					for (int k = -((GameScr.cmx >> 4) % 64); k < GameScr.gW; k += 64)
					{
						g.drawImage(imgBG[3], k, gsmountainY, 0);
					}
				}
				if (imgSun != null)
				{
					g.drawImage(imgSun, sunX, sunY, 3);
				}
				if (imgCloud != null)
				{
					for (int l = 0; l < 2; l++)
					{
						g.drawImage(imgCloud, cloudX[l], cloudY[l], 3);
					}
				}
				if (imgBG[2] != null)
				{
					for (int m = -((GameScr.cmx >> 3) % 192); m < GameScr.gW; m += 192)
					{
						g.drawImage(imgBG[2], m, gshouseY, 0);
					}
				}
			}
			else if (typeBg >= 2 && typeBg <= 6)
			{
				if (imgSun != null)
				{
					g.drawImage(imgSun, sunX, sunY, 3);
				}
				if (imgCloud != null)
				{
					for (int n = 0; n < cloudX.Length; n++)
					{
						g.drawImage(imgCloud, cloudX[n], cloudY[n], 3);
					}
				}
				if (typeBg == 2)
				{
					return;
				}
				if (imgBG[3] != null)
				{
					for (int num = -((GameScr.cmx >> bgSpeed[3]) % imgBGWidth[3]); num < GameScr.gW; num += imgBGWidth[3])
					{
						g.drawImage(imgBG[3], num, gsmountainY, 0);
					}
				}
				if (imgBG[2] != null)
				{
					for (int num2 = -((GameScr.cmx >> bgSpeed[2]) % imgBGWidth[2]); num2 < GameScr.gW; num2 += imgBGWidth[2])
					{
						g.drawImage(imgBG[2], num2, gshouseY, 0);
					}
				}
				if (imgBG[1] != null)
				{
					for (int num3 = -((GameScr.cmx >> bgSpeed[1]) % imgBGWidth[1]); num3 < GameScr.gW; num3 += imgBGWidth[1])
					{
						g.drawImage(imgBG[1], num3, bgLayer1y, 0);
					}
				}
				if (imgBG[0] != null)
				{
					for (int num4 = -((GameScr.cmx >> bgSpeed[0]) % imgBGWidth[0]); num4 < GameScr.gW; num4 += imgBGWidth[0])
					{
						g.drawImage(imgBG[0], num4, bgLayer0y, 0);
					}
				}
			}
			else
			{
				if (typeBg < 7 || typeBg > 16)
				{
					return;
				}
				g.setColor(skyColor);
				g.fillRect(0, 0, GameScr.gW, GameScr.gH);
				if (typeBg != 8 && imgBG[3] != null)
				{
					for (int num5 = -((GameScr.cmx >> bgSpeed[3]) % imgBGWidth[3]); num5 < GameScr.gW; num5 += imgBGWidth[3])
					{
						if (typeBg == 11 || typeBg == 12)
						{
							g.drawImage(imgBG[3], num5, GameScr.gH - mGraphics.getImageHeight(imgBG[3]), 0);
						}
						else
						{
							g.drawImage(imgBG[3], num5, gsmountainY, 0);
						}
					}
				}
				if (typeBg != 8 && typeBg != 11 && typeBg != 12 && imgBG[2] != null)
				{
					if (TileMap.mapID == 45)
					{
						g.drawImage(imgBG[2], GameScr.gW, gshouseY, 0);
					}
					else
					{
						for (int num6 = -((GameScr.cmx >> bgSpeed[2]) % imgBGWidth[2]); num6 < GameScr.gW; num6 += imgBGWidth[2])
						{
							if (typeBg == 14)
							{
								g.drawImage(imgBG[2], num6, gshouseY + 12, 0);
							}
							else
							{
								g.drawImage(imgBG[2], num6, gshouseY, 0);
							}
						}
					}
				}
				if (typeBg != 11 && typeBg != 12 && imgBG[1] != null && TileMap.mapID != 52)
				{
					for (int num7 = -((GameScr.cmx >> bgSpeed[1]) % imgBGWidth[1]); num7 < GameScr.gW; num7 += imgBGWidth[1])
					{
						g.drawImage(imgBG[1], num7, bgLayer1y, 0);
					}
				}
				if (TileMap.mapID == 45 || TileMap.mapID == 55)
				{
					g.setColor(1114112);
					g.fillRect(0, bgLayer0y + 20, GameScr.gW, GameScr.gH);
				}
				if (imgBG[0] != null)
				{
					for (int num8 = -((GameScr.cmx >> bgSpeed[0]) % imgBGWidth[0]); num8 < GameScr.gW; num8 += imgBGWidth[0])
					{
						g.drawImage(imgBG[0], num8, bgLayer0y, 0);
					}
				}
				if (imgCloud == null)
				{
					return;
				}
				if (typeBg == 13 || typeBg == 15)
				{
					for (int num9 = 0; num9 < 2; num9++)
					{
						g.drawImage(imgCloud, cloudX[num9], cloudY[num9] - 130, 3);
					}
				}
				else
				{
					for (int num10 = 0; num10 < 2; num10++)
					{
						g.drawImage(imgCloud, cloudX[num10], cloudY[num10], 3);
					}
				}
			}
		}
		else
		{
			g.setColor(skyColor);
			g.fillRect(0, 0, GameScr.gW, GameScr.gH);
		}
	}

	public static void resetBg()
	{
	}

	public static void loadBG(int typeBG)
	{
		if (typeBG < 0)
		{
			typeBG = 0;
		}
		if (saveIDBg == typeBG)
		{
			return;
		}
		saveIDBg = typeBG;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		typeBg = typeBG;
		switch (typeBG)
		{
		case 2:
			bgSpeed = new int[4] { 1, 2, 3, 4 };
			break;
		case 3:
			bgSpeed = new int[4] { 1, 2, 3, 4 };
			break;
		case 4:
			num = 9;
			num2 = 6;
			bgSpeed = new int[4] { 1, 2, 3, 4 };
			break;
		case 5:
			bgSpeed = new int[4] { 1, 1, 1, 1 };
			break;
		case 6:
			num = 12;
			bgSpeed = new int[4] { 1, 2, 3, 4 };
			break;
		case 12:
			bgSpeed = new int[4] { 1, 2, 3, 4 };
			break;
		case 11:
			bgSpeed = new int[4] { 1, 2, 3, 4 };
			break;
		case 10:
			bgSpeed = new int[4] { 1, 1, 1, 1 };
			break;
		case 9:
			num = 16;
			num2 = 10;
			num3 = 6;
			bgSpeed = new int[4] { 1, 2, 3, 4 };
			break;
		case 8:
			bgSpeed = new int[4] { 1, 2, 3, 4 };
			break;
		case 7:
			bgSpeed = new int[4] { 1, 2, 3, 4 };
			break;
		case 13:
			num = 60;
			bgSpeed = new int[4] { 1, 2, 3, 4 };
			break;
		case 14:
			bgSpeed = new int[4] { 1, 2, 3, 4 };
			break;
		case 15:
			bgSpeed = new int[4] { 1, 2, 3, 4 };
			break;
		case 16:
			bgSpeed = new int[4] { 1, 2, 3, 4 };
			break;
		}
		skyColor = StaticObj.SKYCOLOR[typeBg];
		try
		{
			if (!lowGraphic && !Main.isIpod && mGraphics.zoomLevel != 1)
			{
				if (imgBG != null)
				{
					for (int i = 0; i < imgBG.Length; i++)
					{
						if (imgBG[i] != null)
						{
							imgBG[i].texture = null;
							imgBG[i] = null;
						}
					}
					Resources.UnloadUnusedAssets();
					GC.Collect();
				}
				else
				{
					imgBG = new Image[4];
				}
				imgBGWidth = new int[4];
				for (int j = 0; j < 4; j++)
				{
					try
					{
						if (StaticObj.TYPEBG[typeBg][j] != -1)
						{
							imgBG[j] = loadImage("/bg/bg" + j + StaticObj.TYPEBG[typeBg][j] + string.Empty);
						}
					}
					catch (Exception ex)
					{
						Out.println(ex.Message + ex.StackTrace);
					}
					if (imgBG[j] != null)
					{
						imgBGWidth[j] = mGraphics.getImageWidth(imgBG[j]);
					}
				}
				if (typeBg == 10)
				{
					imgBG[1].texture = null;
					imgBG[2].texture = null;
					imgBG[1] = null;
					imgBG[2] = null;
					imgBG[1] = loadImage("/bg/bg09");
					imgBG[2] = loadImage("/bg/bg09");
					imgBGWidth[1] = mGraphics.getImageWidth(imgBG[1]);
					imgBGWidth[2] = mGraphics.getImageWidth(imgBG[2]);
				}
				if (typeBg == 12)
				{
					imgBG[3].texture = null;
					imgBG[3] = null;
					imgBG[3] = loadImage("/bg/bg39");
					imgBGWidth[3] = mGraphics.getImageWidth(imgBG[3]);
				}
				if (typeBg == 14)
				{
					if (isTouch)
					{
						bgLayer0y = h - mGraphics.getImageHeight(imgBG[0]);
						bgLayer1y = bgLayer0y - mGraphics.getImageHeight(imgBG[1]);
					}
					else
					{
						bgLayer0y = h - mGraphics.getImageHeight(imgBG[0]) - 45;
						bgLayer1y = bgLayer0y - mGraphics.getImageHeight(imgBG[1]);
					}
				}
				if (typeBg == 15 && isTouch)
				{
					bgLayer0y = h - mGraphics.getImageHeight(imgBG[0]);
					bgLayer1y = bgLayer0y - mGraphics.getImageHeight(imgBG[1]) + 100;
				}
				if (typeBg == 16)
				{
					if (isTouch)
					{
						bgLayer0y = h - mGraphics.getImageHeight(imgBG[0]);
						bgLayer1y = bgLayer0y - mGraphics.getImageHeight(imgBG[1]) + 100;
					}
					else
					{
						bgLayer0y = h - mGraphics.getImageHeight(imgBG[0]) - 40;
						bgLayer1y = bgLayer0y - mGraphics.getImageHeight(imgBG[1]) + 100;
					}
				}
			}
			if (typeBg >= 0 && typeBg <= 1)
			{
				imgCloud = loadImage("/bg/cl0");
				imgSun = loadImage("/bg/sun0");
			}
			else
			{
				imgCloud = null;
				imgSun = null;
			}
			if (typeBg == 2)
			{
				imgCloud = loadImage("/bg/cl1");
				imgSun = loadImage("/bg/sun1");
			}
			if (typeBg == 7 || typeBg == 11 || typeBg == 12)
			{
				if (TileMap.mapID == 20)
				{
					imgCloud = null;
				}
				else
				{
					imgCloud = loadImage("/bg/cl0");
				}
			}
			if (typeBG == 13 || typeBG == 15)
			{
				imgCloud = loadImage("/bg/cl2");
			}
			if (typeBg == 12)
			{
				imgCloud1 = loadImage("/bg/may0");
				imgCloud2 = loadImage("/bg/may1");
				imgfog = loadImage("/bg/cloud0");
				imgfog1 = loadImage("/bg/cloud1");
				imgfog2 = loadImage("/bg/cloud2");
			}
		}
		catch (Exception)
		{
			Out.println("BG ERR >>>>>>>>>>>>>>>>>>>>>.");
		}
		paintBG = false;
		if (!lowGraphic && !Main.isIpod && mGraphics.zoomLevel != 1)
		{
			paintBG = true;
			if (imgBG[0] != null && imgBG[1] != null && imgBG[2] != null)
			{
				gsskyHeight = GameScr.gH - (mGraphics.getImageHeight(imgBG[0]) + mGraphics.getImageHeight(imgBG[1]) + mGraphics.getImageHeight(imgBG[2])) + 11;
			}
			if (imgBG[0] != null)
			{
				gsgreenField1Y = GameScr.gH - mGraphics.getImageHeight(imgBG[0]);
			}
			if (imgBG[1] != null)
			{
				gsgreenField2Y = gsgreenField1Y - mGraphics.getImageHeight(imgBG[1]);
			}
			if (imgBG[2] != null)
			{
				gshouseY = gsgreenField2Y - mGraphics.getImageHeight(imgBG[2]);
			}
			if (imgBG[3] != null)
			{
				gsmountainY = gsgreenField2Y - mGraphics.getImageHeight(imgBG[3]) - 10;
			}
			if (typeBg >= 2 && typeBg <= 13)
			{
				int num4 = (bgLayer0y = GameScr.gH - mGraphics.getImageHeight(imgBG[0]));
				if (imgBG[1] != null)
				{
					num4 = num4 - mGraphics.getImageHeight(imgBG[1]) + num;
				}
				bgLayer1y = num4;
				if (imgBG[3] != null)
				{
					num4 = num4 - mGraphics.getImageHeight(imgBG[3]) + num3;
				}
				gsmountainY = num4;
				gsskyHeight = num4;
				if (imgBG[2] != null)
				{
					gshouseY = bgLayer1y - mGraphics.getImageHeight(imgBG[2]) + num2;
				}
				if (typeBg == 2)
				{
					gsskyHeight = h;
				}
			}
		}
		int num5 = 0;
		num5 = ((typeBg < 2 || typeBg > 12) ? (2 * GameScr.gH / 3 - gsgreenField2Y) : (2 * GameScr.gH / 3 - bgLayer1y));
		if (num5 < 0)
		{
			num5 = 0;
		}
		if (TileMap.mapID == 48 && TileMap.mapID == 51)
		{
			bgLayer0y += num5;
		}
		if (typeBg >= 2 && typeBg <= 6)
		{
			bgLayer1y += num5;
		}
		gsskyHeight += num5;
		gsgreenField1Y += num5;
		gsgreenField2Y += num5;
		gshouseY += num5;
		gsmountainY += num5;
		sunX = 3 * GameScr.gW / 4;
		sunY = gsskyHeight / 3;
		cloudX = new int[2];
		cloudY = new int[2];
		cloudX[0] = GameScr.gW / 3;
		cloudY[0] = gsskyHeight / 2 - 8;
		cloudX[1] = 2 * GameScr.gW / 3;
		cloudY[1] = gsskyHeight / 2 + 8;
		if (typeBg == 2)
		{
			sunY = gsskyHeight / 5;
			cloudX = new int[5];
			cloudY = new int[5];
			cloudX[0] = GameScr.gW / 3;
			cloudY[0] = gsskyHeight / 3 - 35;
			cloudX[1] = 3 * GameScr.gW / 4;
			cloudY[1] = gsskyHeight / 3 + 12;
			cloudX[2] = GameScr.gW / 3 - 15;
			cloudY[2] = gsskyHeight / 3 + 12;
			cloudX[3] = GameScr.gW / 15;
			cloudY[3] = gsskyHeight / 2 + 12;
			cloudX[4] = 2 * GameScr.gW / 3 + 25;
			cloudY[4] = gsskyHeight / 3 + 12;
		}
		if (!lowGraphic && !Main.isIpod && mGraphics.zoomLevel != 1)
		{
			if (typeBg == 8)
			{
				bgLayer0y = (bgLayer1y = GameScr.gH2 - 50);
			}
			if (typeBg == 10 && imgBG[3] != null)
			{
				gsmountainY = gshouseY - mGraphics.getImageHeight(imgBG[3]);
			}
			if (typeBg == 11 || typeBg == 12)
			{
				gsmountainY = 0;
			}
		}
		Resources.UnloadUnusedAssets();
		GC.Collect();
	}

	public void keyPressed(int keyCode)
	{
		lastTimePress = mSystem.getCurrentTimeMillis();
		if ((keyCode >= 48 && keyCode <= 57) || (keyCode >= 65 && keyCode <= 122) || keyCode == 10 || keyCode == 8 || keyCode == 13 || keyCode == 32 || keyCode == -8)
		{
			keyAsciiPress = keyCode;
		}
		mapKeyPress(keyCode);
	}

	public int getWidth()
	{
		return (int)ScaleGUI.WIDTH;
	}

	public int getHeight()
	{
		return (int)ScaleGUI.HEIGHT;
	}

	public void mapKeyPress(int keyCode)
	{
		if (currentDialog != null)
		{
			currentDialog.keyPress(keyCode);
			keyAsciiPress = 0;
			return;
		}
		currentScreen.keyPress(keyCode);
		timePutKeyPc = 100;
		switch (keyCode)
		{
		case 48:
			keyHold[0] = true;
			keyPressedz[0] = true;
			break;
		case 49:
			if (currentScreen == GameScr.instance && isMoveNumberPad && !ChatTextField.gI().isShow)
			{
				keyHold[1] = true;
				keyPressedz[1] = true;
			}
			break;
		case 51:
			if (currentScreen == GameScr.instance && isMoveNumberPad && !ChatTextField.gI().isShow)
			{
				keyHold[3] = true;
				keyPressedz[3] = true;
			}
			break;
		case 55:
			keyHold[7] = true;
			keyPressedz[7] = true;
			break;
		case 57:
			keyHold[9] = true;
			keyPressedz[9] = true;
			break;
		case 42:
			keyHold[10] = true;
			keyPressedz[10] = true;
			break;
		case 35:
			keyHold[11] = true;
			keyPressedz[11] = true;
			break;
		case -21:
		case -6:
			keyHold[12] = true;
			keyPressedz[12] = true;
			break;
		case -22:
		case -7:
			keyHold[13] = true;
			keyPressedz[13] = true;
			break;
		case -5:
		case 10:
			if (currentScreen is GameScr && Char.getMyChar().isAttack)
			{
				clearKeyHold();
				clearKeyPressed();
			}
			else
			{
				keyHold[5] = true;
				keyPressedz[5] = true;
			}
			break;
		case -1:
			if (currentScreen is GameScr && Char.getMyChar().isAttack)
			{
				clearKeyHold();
				clearKeyPressed();
			}
			else
			{
				keyHold[24] = true;
				keyPressedz[24] = true;
			}
			break;
		case -2:
			if (currentScreen is GameScr && Char.getMyChar().isAttack)
			{
				clearKeyHold();
				clearKeyPressed();
			}
			else
			{
				keyHold[25] = true;
				keyPressedz[25] = true;
			}
			break;
		case -3:
			if (currentScreen is GameScr && Char.getMyChar().isAttack)
			{
				clearKeyHold();
				clearKeyPressed();
			}
			else
			{
				keyHold[23] = true;
				keyPressedz[23] = true;
			}
			break;
		case -4:
			if (currentScreen is GameScr && Char.getMyChar().isAttack)
			{
				clearKeyHold();
				clearKeyPressed();
			}
			else
			{
				keyHold[22] = true;
				keyPressedz[22] = true;
			}
			break;
		case 50:
			if (currentScreen == GameScr.instance && isMoveNumberPad && !ChatTextField.gI().isShow && !GameScr.isPaintAuctionSale)
			{
				keyHold[2] = true;
				keyPressedz[2] = true;
			}
			break;
		case 52:
			if (currentScreen == GameScr.instance && isMoveNumberPad && !ChatTextField.gI().isShow && !GameScr.isPaintAuctionSale)
			{
				keyHold[4] = true;
				keyPressedz[4] = true;
			}
			break;
		case 54:
			if (currentScreen == GameScr.instance && isMoveNumberPad && !ChatTextField.gI().isShow && !GameScr.isPaintAuctionSale)
			{
				keyHold[6] = true;
				keyPressedz[6] = true;
			}
			break;
		case 56:
			if (currentScreen == GameScr.instance && isMoveNumberPad && !ChatTextField.gI().isShow && !GameScr.isPaintAuctionSale)
			{
				keyHold[8] = true;
				keyPressedz[8] = true;
			}
			break;
		case 53:
			if (currentScreen == GameScr.instance && isMoveNumberPad && !ChatTextField.gI().isShow && !GameScr.isPaintAuctionSale)
			{
				keyHold[27] = true;
				keyPressedz[27] = true;
			}
			break;
		case 32:
			if (currentScreen == GameScr.instance && isMoveNumberPad && !ChatTextField.gI().isShow && !GameScr.isPaintAuctionSale)
			{
				keyHold[20] = true;
				keyPressedz[20] = true;
			}
			break;
		case 113:
			if (currentScreen is GameScr && Char.getMyChar().isAttack)
			{
				clearKeyHold();
				clearKeyPressed();
			}
			else
			{
				keyHold[14] = true;
				keyPressedz[14] = true;
			}
			break;
		case 101:
			if (currentScreen is GameScr && Char.getMyChar().isAttack)
			{
				clearKeyHold();
				clearKeyPressed();
			}
			else
			{
				keyHold[15] = true;
				keyPressedz[15] = true;
			}
			break;
		case 119:
			if (currentScreen is GameScr && Char.getMyChar().isAttack)
			{
				clearKeyHold();
				clearKeyPressed();
			}
			else
			{
				keyHold[16] = true;
				keyPressedz[16] = true;
			}
			break;
		case 115:
			if (currentScreen is GameScr && Char.getMyChar().isAttack)
			{
				clearKeyHold();
				clearKeyPressed();
			}
			else
			{
				keyHold[17] = true;
				keyPressedz[17] = true;
			}
			break;
		case 97:
			if (currentScreen is GameScr && Char.getMyChar().isAttack)
			{
				clearKeyHold();
				clearKeyPressed();
			}
			else
			{
				keyHold[18] = true;
				keyPressedz[18] = true;
			}
			break;
		case 100:
			if (currentScreen is GameScr && Char.getMyChar().isAttack)
			{
				clearKeyHold();
				clearKeyPressed();
			}
			else
			{
				keyHold[19] = true;
				keyPressedz[19] = true;
			}
			break;
		case 112:
			if (currentScreen == GameScr.instance && isMoveNumberPad && !ChatTextField.gI().isShow)
			{
				keyHold[21] = true;
				keyPressedz[21] = true;
			}
			break;
		case 111:
			if (currentScreen == GameScr.instance && isMoveNumberPad && !ChatTextField.gI().isShow)
			{
				keyHold[26] = true;
				keyPressedz[26] = true;
			}
			break;
		case -8:
			if (currentScreen == GameScr.instance && isMoveNumberPad && !ChatTextField.gI().isShow)
			{
				keyHold[27] = true;
				keyPressedz[27] = true;
			}
			break;
		case -23:
			keyHold[29] = true;
			keyPressedz[29] = true;
			break;
		case -24:
			keyHold[30] = true;
			keyPressedz[30] = true;
			break;
		case -25:
			keyHold[31] = true;
			keyPressedz[31] = true;
			break;
		case -26:
			keyHold[32] = true;
			break;
		}
	}

	public void keyReleased(int keyCode)
	{
		keyAsciiPress = 0;
		mapKeyRelease(keyCode);
	}

	public void mapKeyRelease(int keyCode)
	{
		switch (keyCode)
		{
		case 48:
			keyHold[Key.NUM0] = false;
			keyReleasedz[Key.NUM0] = true;
			break;
		case 49:
			keyHold[Key.NUM1] = false;
			keyReleasedz[Key.NUM1] = true;
			break;
		case 51:
			keyHold[Key.NUM3] = false;
			keyReleasedz[Key.NUM3] = true;
			break;
		case 55:
			keyHold[7] = false;
			keyReleasedz[7] = true;
			break;
		case 57:
			keyHold[9] = false;
			keyReleasedz[9] = true;
			break;
		case 42:
			keyHold[10] = false;
			keyReleasedz[10] = true;
			break;
		case 35:
			keyHold[11] = false;
			keyReleasedz[11] = true;
			break;
		case -21:
		case -6:
			keyHold[12] = false;
			keyReleasedz[12] = true;
			break;
		case -22:
		case -7:
			keyHold[13] = false;
			keyReleasedz[13] = true;
			break;
		case -5:
		case 10:
			keyHold[5] = false;
			keyReleasedz[5] = true;
			break;
		case -1:
			keyHold[24] = false;
			break;
		case -38:
			keyHold[2] = false;
			break;
		case -2:
			keyHold[25] = false;
			break;
		case -39:
			keyHold[8] = false;
			break;
		case -3:
			keyHold[23] = false;
			break;
		case -4:
			keyHold[22] = false;
			break;
		case 50:
			keyHold[Key.NUM2] = false;
			keyReleasedz[Key.NUM2] = true;
			break;
		case 52:
			keyHold[Key.NUM4] = false;
			keyReleasedz[Key.NUM4] = true;
			break;
		case 54:
			keyHold[Key.NUM6] = false;
			keyReleasedz[Key.NUM6] = true;
			break;
		case 56:
			keyHold[Key.NUM8] = false;
			keyReleasedz[Key.NUM8] = true;
			break;
		case 53:
			keyHold[27] = false;
			keyReleasedz[27] = true;
			break;
		case 32:
			keyHold[20] = false;
			keyReleasedz[20] = true;
			break;
		case 113:
			keyHold[14] = false;
			keyReleasedz[14] = true;
			break;
		case 101:
			keyHold[15] = false;
			keyReleasedz[15] = true;
			break;
		case 119:
			keyHold[16] = false;
			keyReleasedz[16] = true;
			break;
		case 115:
			keyHold[17] = false;
			keyReleasedz[17] = true;
			break;
		case 97:
			keyHold[18] = false;
			keyReleasedz[18] = true;
			break;
		case 100:
			keyHold[19] = false;
			keyReleasedz[19] = true;
			break;
		case 112:
			keyHold[21] = false;
			keyReleasedz[21] = true;
			break;
		case 111:
			keyHold[26] = false;
			keyReleasedz[26] = true;
			break;
		case -8:
			keyHold[27] = true;
			keyPressedz[27] = true;
			break;
		case -23:
			keyHold[29] = false;
			keyReleasedz[29] = true;
			break;
		case -24:
			keyHold[30] = false;
			keyReleasedz[30] = true;
			break;
		case -25:
			keyHold[31] = false;
			keyReleasedz[31] = true;
			break;
		case -26:
			keyHold[32] = false;
			keyPressedz[32] = true;
			break;
		}
	}

	public void pointerDragged(int x, int y)
	{
		if (Res.abs(x - pxLast) >= 10 || Res.abs(y - pyLast) >= 10)
		{
			isPointerClick = false;
		}
		px = x;
		py = y;
		curPos++;
		if (curPos > 3)
		{
			curPos = 0;
		}
		arrPos[curPos] = new Position(x, y);
	}

	public void pointerPressed(int x, int y)
	{
		isPointerJustDown = true;
		isPointerDown = true;
		isPointerClick = true;
		lastTimePress = mSystem.getCurrentTimeMillis();
		pxFirst = x;
		pyFirst = y;
		pxLast = x;
		pyLast = y;
		px = x;
		py = y;
	}

	public void pointerReleased(int x, int y)
	{
		isPointerDown = false;
		isPointerJustRelease = true;
		mScreen.keyTouch = -1;
		px = x;
		py = y;
	}

	public static bool isPointerInGame(int x, int y, int w, int h)
	{
		int num;
		int num2;
		if (Screen.width > TileMap.pxw)
		{
			num = px + GameScr.cmx + 40;
			num2 = GameScr.cmy + py;
		}
		else
		{
			num = px + GameScr.cmx;
			num2 = GameScr.cmy + py;
		}
		if (!isPointerDown && !isPointerJustRelease)
		{
			return false;
		}
		if (num >= x && num <= x + w && num2 >= y && num2 <= y + h)
		{
			return true;
		}
		return false;
	}

	public static bool isPointerHoldIn(int x, int y, int w, int h)
	{
		if (!isPointerDown && !isPointerJustRelease)
		{
			return false;
		}
		if (px >= x && px <= x + w && py >= y && py <= y + h)
		{
			return true;
		}
		return false;
	}

	public static void clearKeyPressed()
	{
		for (int i = 0; i < keyPressedz.Length; i++)
		{
			keyPressedz[i] = false;
		}
		isPointerJustRelease = false;
	}

	public static void clearKeyHold()
	{
		for (int i = 0; i < keyHold.Length; i++)
		{
			keyHold[i] = false;
		}
	}

	public void paint(mGraphics g)
	{
		try
		{
			debugPaint.removeAllElements();
			debug("PA", 1);
			if (currentScreen != null && !isLoading)
			{
				currentScreen.paint(g);
				g.setClip(0, 0, w, h);
			}
			debug("PB", 1);
			g.translate(-g.getTranslateX(), -g.getTranslateY());
			g.setClip(0, 0, w, h);
			InfoDlg.paint(g);
			if (currentDialog != null)
			{
				debug("PC", 1);
				currentDialog.paint(g);
			}
			else if (menu.showMenu)
			{
				debug("PD", 1);
				menu.paintMenu(g);
			}
			debug("PE", 1);
			paintKiemduyetTime(g);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
	}

	public static void resetTrans(mGraphics g)
	{
		g.translate(-g.getTranslateX(), -g.getTranslateY());
		g.setClip(0, 0, w, h);
	}

	public static void endDlg()
	{
		if (inputDlg != null)
		{
			inputDlg.tfInput.setMaxTextLenght(500);
		}
		if (input2Dlg != null)
		{
			input2Dlg.tfInput.setMaxTextLenght(500);
			input2Dlg.tfInput2.setMaxTextLenght(500);
		}
		msgdlg.isIpad = false;
		currentDialog = null;
	}

	public static void startOKDlg(string info)
	{
		msgdlg.setInfo(info, null, new Command(mResources.OK, instance, 8882, null), null);
		LoginScr.isAutoLogin = false;
		currentDialog = msgdlg;
	}

	public static void startWaitDlg(string info)
	{
		msgdlg.setInfo(info, null, new Command(mResources.CANCEL, instance, 8882, null), null);
		currentDialog = msgdlg;
		msgdlg.isWait = true;
	}

	public static void startWaitDlgIpad(string info, bool isIpad)
	{
		msgdlg.setInfoIpad(info, null, null, null, isIpad);
		currentDialog = msgdlg;
		msgdlg.isWait = true;
	}

	public static void startOKDlg(string info, bool isError)
	{
		startOKDlg(info);
	}

	public static void startWaitDlg()
	{
		startWaitDlg(mResources.PLEASEWAIT);
	}

	public static void startWaitDlgWithoutCancel()
	{
		msgdlg.timeShow = 500;
		msgdlg.setInfo(mResources.PLEASEWAIT, null, null, null);
		currentDialog = msgdlg;
		msgdlg.isWait = true;
	}

	public void openWeb(string strLeft, string strRight, string url, string str)
	{
		msgdlg.setInfo(str, new Command(strLeft, this, 8881, url), null, new Command(strRight, this, 8882, null));
		currentDialog = msgdlg;
	}

	public void sendSms(string strLeft, string strRight, short port, string syntax, string str)
	{
		MyVector myVector = new MyVector();
		myVector.addElement(port);
		myVector.addElement(syntax);
		msgdlg.setInfo(str, new Command(strLeft, this, 8883, myVector), null, new Command(strRight, this, 8882, null));
		currentDialog = msgdlg;
	}

	public static void startOK(string info, int actionID, object p)
	{
		msgdlg.setInfo(info, null, new Command(mResources.OK, instance, actionID, p, w / 2 - 35, h - 50), null);
		msgdlg.show();
	}

	public static void startYesNoDlg(string info, int iYes, object pYes, int iNo, object pNo)
	{
		msgdlg.setInfo(info, new Command(mResources.YES, instance, iYes, pYes), new Command(string.Empty, instance, iYes, pYes), new Command(mResources.NO, instance, iNo, pNo));
		msgdlg.show();
	}

	public static void startYesNoDlg(string info, Command cmdYes, Command cmdNo)
	{
		msgdlg.setInfo(info, cmdYes, null, cmdNo);
		msgdlg.show();
	}

	public static void sendSms(string syntax, string firNum)
	{
		startWaitDlg(mResources.SENDINGMSG);
		GameMidlet.sendSMS(syntax, firNum, new Command(string.Empty, gI(), 88823, null), new Command(string.Empty, gI(), 88824, null));
	}

	public static Image loadImage(string path)
	{
		path = Main.res + "/x" + mGraphics.zoomLevel + path;
		Image result = null;
		try
		{
			result = Image.createImage(path);
			return result;
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
			Debug.LogError("ERROR LOAD:" + path);
			return result;
		}
	}

	public bool startDust(int dir, int x, int y)
	{
		if (lowGraphic || Main.isIpod || mGraphics.zoomLevel == 1)
		{
			return false;
		}
		int num = ((dir != 1) ? 1 : 0);
		if (dustState[num] != -1)
		{
			return false;
		}
		dustState[num] = 0;
		dustX[num] = x;
		dustY[num] = y;
		return true;
	}

	public void loadWaterSplash()
	{
		if (!lowGraphic && !Main.isIpod && mGraphics.zoomLevel != 1)
		{
			imgWS = new Image[3];
			for (int i = 0; i < 3; i++)
			{
				imgWS[i] = loadImage("/e/w" + i + string.Empty);
			}
			wsX = new int[2];
			wsY = new int[2];
			wsState = new int[2];
			wsF = new int[2];
			wsState[0] = (wsState[1] = -1);
		}
	}

	public bool startWaterSplash(int x, int y)
	{
		if (lowGraphic || Main.isIpod || mGraphics.zoomLevel == 1)
		{
			return false;
		}
		int num = ((wsState[0] != -1) ? 1 : 0);
		if (wsState[num] != -1)
		{
			return false;
		}
		wsState[num] = 0;
		wsX[num] = x;
		wsY[num] = y;
		return true;
	}

	public void updateWaterSplash()
	{
		if (lowGraphic || Main.isIpod || mGraphics.zoomLevel == 1)
		{
			return;
		}
		for (int i = 0; i < 2; i++)
		{
			if (wsState[i] == -1)
			{
				continue;
			}
			wsY[i]--;
			if (gameTick % 2 == 0)
			{
				wsState[i]++;
				if (wsState[i] > 2)
				{
					wsState[i] = -1;
				}
				else
				{
					wsF[i] = wsState[i];
				}
			}
		}
	}

	public void updateDust()
	{
		if (lowGraphic || Main.isIpod || mGraphics.zoomLevel == 1)
		{
			return;
		}
		for (int i = 0; i < 2; i++)
		{
			if (dustState[i] != -1)
			{
				dustState[i]++;
				if (dustState[i] >= 5)
				{
					dustState[i] = -1;
				}
				if (i == 0)
				{
					dustX[i]--;
				}
				else
				{
					dustX[i]++;
				}
				dustY[i]--;
			}
		}
	}

	public static bool isPaint(int x, int y)
	{
		if (x < GameScr.cmx)
		{
			return false;
		}
		if (x > GameScr.cmx + GameScr.gW)
		{
			return false;
		}
		if (y < GameScr.cmy)
		{
			return false;
		}
		if (y > GameScr.cmy + GameScr.gH + 30)
		{
			return false;
		}
		return true;
	}

	public void paintDust(mGraphics g)
	{
		if (lowGraphic || Main.isIpod || mGraphics.zoomLevel == 1)
		{
			return;
		}
		for (int i = 0; i < 2; i++)
		{
			if (dustState[i] != -1 && isPaint(dustX[i], dustY[i]))
			{
				g.drawImage(imgDust[i][dustState[i]], dustX[i], dustY[i], 3);
			}
		}
	}

	public void loadDust()
	{
		if (lowGraphic || Main.isIpod || mGraphics.zoomLevel == 1)
		{
			return;
		}
		if (imgDust == null)
		{
			imgDust = new Image[2][];
			for (int i = 0; i < 2; i++)
			{
				imgDust[i] = new Image[5];
				for (int j = 0; j < 5; j++)
				{
					imgDust[i][j] = loadImage("/e/d" + i + j + string.Empty);
				}
			}
		}
		dustX = new int[2];
		dustY = new int[2];
		dustState = new int[2];
		dustState[0] = (dustState[1] = -1);
	}

	public static void paintShukiren(int x, int y, mGraphics g, bool noRotate)
	{
		g.drawRegion(y0: ((!noRotate) ? (gameTick % 3) : 0) * 16, arg0: imgShuriken, x0: 0, w0: 16, h0: 16, arg5: 0, x: x, y: y, arg8: mGraphics.HCENTER | mGraphics.VCENTER);
	}

	public void resetToLoginScr()
	{
		isLoading = false;
		resetToLoginScrz = true;
	}

	public static bool isPointer(int x, int y, int w, int h)
	{
		if (!isPointerDown && !isPointerJustRelease)
		{
			return false;
		}
		if (px >= x && px <= x + w && py >= y && py <= y + h)
		{
			return true;
		}
		return false;
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		case 8891:
			Service.gI().sendUIConfirmID(0);
			currentDialog = null;
			break;
		case 8881:
		{
			string url = (string)p;
			NinjaUtil.downloadGame(url);
			currentDialog = null;
			break;
		}
		case 8882:
			currentDialog = null;
			break;
		case 8883:
		{
			short port = (short)((MyVector)p).elementAt(0);
			string syntax = (string)((MyVector)p).elementAt(0);
			NinjaUtil.sendMsDK(syntax, port);
			currentDialog = null;
			break;
		}
		case 8884:
			endDlg();
			LoginScr.isAutoLogin = false;
			selectsvScr.switchToMe();
			break;
		case 8885:
			GameMidlet.instance.exit();
			break;
		case 8886:
			startYesNoDlg(mResources.NEW_ACC_ARLET, new Command(mResources.COUNTINUE, instance, 8880, null), new Command(mResources.NO, instance, 8882, null));
			break;
		case 8880:
			endDlg();
			languageScr.switchToMe();
			break;
		case 8887:
		{
			endDlg();
			int charId2 = (int)p;
			Service.gI().addPartyAccept(charId2);
			break;
		}
		case 8888:
		{
			int charId = (int)p;
			Service.gI().addPartyCancel(charId);
			endDlg();
			break;
		}
		case 8889:
		{
			string str = (string)p;
			endDlg();
			Service.gI().acceptPleaseParty(str);
			break;
		}
		case 88810:
		{
			int playerMapId = (int)p;
			endDlg();
			Service.gI().acceptInviteTrade(playerMapId);
			break;
		}
		case 88811:
			endDlg();
			Service.gI().cancelInviteTrade();
			break;
		case 88812:
		{
			Char char3 = (Char)p;
			endDlg();
			Service.gI().acceptInviteTest(char3.charID);
			break;
		}
		case 88813:
		{
			endDlg();
			Item[] items2 = (Item[])p;
			Service.gI().crystalCollect(items2);
			break;
		}
		case 88814:
		{
			Item[] items = (Item[])p;
			endDlg();
			Service.gI().crystalCollectLock(items);
			break;
		}
		case 88815:
			GameScr.gI().doUpgrade();
			break;
		case 88816:
			Service.gI().sendCardInfo(input2Dlg.tfInput.getText(), input2Dlg.tfInput2.getText());
			endDlg();
			break;
		case 88817:
			if (Char.getMyChar().npcFocus != null)
			{
				Service.gI().menu(Char.getMyChar().npcFocus.template.npcTemplateId, menu.menuSelectedItem, 0);
			}
			else
			{
				Service.gI().menu(0, menu.menuSelectedItem, 0);
			}
			break;
		case 888181:
		{
			short idRe = (short)p;
			Service.gI().SendCapcha(idRe, inputDlg.tfInput.getText());
			testCapcha = null;
			endDlg();
			break;
		}
		case 88818:
		{
			short menuId3 = (short)p;
			Service.gI().textBoxId(menuId3, inputDlg.tfInput.getText());
			endDlg();
			break;
		}
		case 88819:
		{
			short menuId2 = (short)p;
			Service.gI().menuId(menuId2);
			GameScr.gI().doCloseAlert();
			break;
		}
		case 88820:
		{
			string[] array = (string[])p;
			if (Char.getMyChar().npcFocus == null)
			{
				break;
			}
			int menuSelectedItem = menu.menuSelectedItem;
			if (array.Length > 1)
			{
				MyVector myVector = new MyVector();
				for (int i = 0; i < array.Length - 1; i++)
				{
					myVector.addElement(new Command(array[i + 1], instance, 88821, menuSelectedItem));
				}
				menu.startAt(myVector, 3);
			}
			else
			{
				ChatPopup.addChatPopup(string.Empty, 1, Char.getMyChar().npcFocus);
				Service.gI().menu(Char.getMyChar().npcFocus.template.npcTemplateId, menuSelectedItem, 0);
			}
			break;
		}
		case 88821:
		{
			int menuId = (int)p;
			ChatPopup.addChatPopup(string.Empty, 1, Char.getMyChar().npcFocus);
			Service.gI().menu(Char.getMyChar().npcFocus.template.npcTemplateId, menuId, menu.menuSelectedItem);
			break;
		}
		case 88822:
			ChatPopup.addChatPopup(string.Empty, 1, Char.getMyChar().npcFocus);
			Service.gI().menu(Char.getMyChar().npcFocus.template.npcTemplateId, menu.menuSelectedItem, 0);
			break;
		case 88823:
			startOKDlg(mResources.SENTMSG);
			break;
		case 88824:
			startOKDlg(mResources.NOSENDMSG);
			break;
		case 88825:
			startOKDlg(mResources.SENT_SUCCESS1, isError: false);
			break;
		case 88826:
			startOKDlg(mResources.NOT_SENT_SUCCESS, isError: false);
			break;
		case 88827:
			startOKDlg(mResources.SENT_SUCCESS2);
			break;
		case 88828:
			startOKDlg(mResources.SENT_UNSUCCESS);
			break;
		case 88829:
		{
			string text10 = inputDlg.tfInput.getText();
			if (!text10.Equals(string.Empty))
			{
				Service.gI().changeName(text10, (int)p);
				startWaitDlg();
			}
			break;
		}
		case 88830:
		{
			int playerMapId3 = (int)p;
			endDlg();
			Service.gI().acceptInviteClan(playerMapId3);
			break;
		}
		case 88831:
		{
			int playerMapId2 = (int)p;
			endDlg();
			Service.gI().acceptPleaseClan(playerMapId2);
			break;
		}
		case 88832:
		{
			string text9 = inputDlg.tfInput.getText();
			endDlg();
			if (!text9.Equals(string.Empty))
			{
				Service.gI().changeClanAlert(text9);
			}
			break;
		}
		case 88833:
		{
			string text8 = inputDlg.tfInput.getText();
			endDlg();
			if (text8.Equals(string.Empty))
			{
				break;
			}
			try
			{
				int num6 = int.Parse(text8);
				if (Char.getMyChar().xu < num6 || num6 < 0)
				{
					InfoMe.addInfo(mResources.NOT_ENOUGH_XU, 20, mFont.tahoma_7_yellow);
				}
				else
				{
					Service.gI().inputCoinClan(num6);
				}
				break;
			}
			catch (Exception)
			{
				break;
			}
		}
		case 88834:
		{
			string text7 = inputDlg.tfInput.getText();
			endDlg();
			if (text7.Equals(string.Empty))
			{
				break;
			}
			try
			{
				int num5 = int.Parse(text7);
				if (num5 > 0)
				{
					Service.gI().outputCoinClan(num5);
				}
				break;
			}
			catch (Exception)
			{
				break;
			}
		}
		case 88835:
		{
			int num3 = int.Parse((string)p);
			int num4 = int.Parse(inputDlg.tfInput.getText());
			currentDialog = null;
			if (num4 < 1 || num4 >= Char.getMyChar().arrItemBag[num3].quantity)
			{
				startOKDlg(mResources.INVALID_NUMSPLIT);
			}
			else
			{
				Service.gI().inputNumSplit(num3, num4);
			}
			break;
		}
		case 88836:
			inputDlg.tfInput.setMaxTextLenght(6);
			inputDlg.show(mResources.INPUT_PRIVATE_PASS, new Command(mResources.ACCEPT, instance, 888361, null), TField.INPUT_TYPE_NUMERIC);
			break;
		case 888361:
		{
			string text6 = inputDlg.tfInput.getText();
			endDlg();
			if (text6.Length < 6 || text6.Equals(string.Empty))
			{
				startOKDlg(mResources.ALERT_PRIVATE_PASS_1);
				break;
			}
			try
			{
				Service.gI().activeAccProtect(int.Parse(text6));
				break;
			}
			catch (Exception)
			{
				startOKDlg(mResources.ALERT_PRIVATE_PASS_2);
				break;
			}
		}
		case 88837:
		{
			string text5 = inputDlg.tfInput.getText();
			inputDlg.tfInput.setMaxTextLenght(500);
			endDlg();
			try
			{
				Service.gI().openLockAccProtect(int.Parse(text5.Trim()));
				break;
			}
			catch (Exception)
			{
				break;
			}
		}
		case 88838:
		{
			string text3 = input2Dlg.tfInput.getText().Trim();
			string text4 = input2Dlg.tfInput2.getText().Trim();
			endDlg();
			if (text3.Length < 6 || text4.Length < 6)
			{
				startOKDlg(mResources.ALERT_PRIVATE_PASS_1);
				break;
			}
			try
			{
				int num = int.Parse(text3);
				int num2 = int.Parse(text4);
				if (num < 99999 || num2 < 99999)
				{
					startOKDlg(mResources.ALERT_PRIVATE_PASS_3);
				}
				else
				{
					Service.gI().updateActive(num, num2);
				}
				break;
			}
			catch (Exception)
			{
				startOKDlg(mResources.ALERT_PRIVATE_PASS_2);
				break;
			}
		}
		case 88839:
		{
			string text2 = inputDlg.tfInput.getText();
			endDlg();
			try
			{
				int.Parse(text2);
				startYesNoDlg(mResources.CANCEL_PROTECT, 888391, text2, 8882, null);
				break;
			}
			catch (Exception)
			{
				InfoMe.addInfo(mResources.ALERT_PRIVATE_PASS_4, 20, mFont.tahoma_7_yellow);
				break;
			}
		}
		case 888391:
			try
			{
				endDlg();
				int pass = int.Parse((string)p);
				Service.gI().clearAccProtect(pass);
				break;
			}
			catch (Exception)
			{
				break;
			}
		case 88840:
		{
			Char char2 = (Char)p;
			endDlg();
			Service.gI().acceptInviteTestDun(char2.charID);
			break;
		}
		case 88841:
		{
			Char @char = (Char)p;
			endDlg();
			Service.gI().acceptInviteTestGT(@char.charID);
			break;
		}
		case 88842:
			Service.gI().acceptClanBattlefield();
			break;
		case 88843:
		{
			string text = inputDlg.tfInput.getText();
			endDlg();
			if (text.Equals(string.Empty))
			{
				startOKDlg(mResources.INVALID_NUM);
			}
			else
			{
				Service.gI().sendClanItem(text);
			}
			break;
		}
		case 8890:
			endDlg();
			Service.gI().sendUIConfirmID((int)p);
			break;
		case 1608:
			Service.gI().ChucTet(input2Dlg.tfInput.getText(), input2Dlg.tfInput2.getText(), 0);
			endDlg();
			break;
		case 16081:
			Service.gI().ChucTet(input2Dlg.tfInput.getText(), input2Dlg.tfInput2.getText(), 1);
			endDlg();
			break;
		case 1700:
			Service.gI().luckyDraw(100, inputDlg.tfInput.getText(), GameScr.typeLucky_Draw);
			endDlg();
			break;
		}
	}

	protected void sizeChanged(int w, int h)
	{
	}

	public static void updateTimeplay()
	{
		wStr = mFont.tahoma_7b_yellow.getWidth(mResources.kiemduyet);
		if (wStr > w)
		{
			xKd--;
			if (xKd < -440)
			{
				xKd = w;
			}
		}
	}

	public static void initTime()
	{
	}

	public static void paintKiemduyetTime(mGraphics g)
	{
		if (isKiemduyet)
		{
			updateTimeplay();
			g.setColor(0);
			g.fillRect(0, yKd, w, 16);
			mFont.tahoma_7b_yellow.drawString(g, mResources.kiemduyet, xKd + 20, yKd, 0);
			g.drawImage(imgPlus12, 0, yKd, 0);
		}
	}

	public static string converSecon2hours(int totalSeconds)
	{
		int num = totalSeconds % 60;
		int num2 = totalSeconds / 60;
		return string.Concat(str2: (num2 % 60).ToString(), str0: (num2 / 60).ToString(), str1: ":");
	}
}
