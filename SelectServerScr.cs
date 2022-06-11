public class SelectServerScr : mScreen, IActionListener
{
	private int popupW;

	private int popupH;

	private int popupX;

	private int popupY;

	private static LanguageScr gI;

	private int indexRow = -1;

	public static bool isFromLogin;

	public static string[] menu;

	public static string uname;

	public static string pass;

	public static string unameChange = string.Empty;

	public static string passChange = string.Empty;

	public static Command cmdChoiMoi;

	public static Command cmdDoiTaiKhoan;

	public static Command cmdChoiTiep;

	public static Command cmdChonServer;

	public static Command cmdUpdLinkSv;

	public static Command[][] cmd;

	public static int ipSelect;

	public bool isFAQ;

	public string listFAQ = string.Empty;

	public string titleFAQ;

	public string subtitleFAQ;

	public string randomResuft;

	public static void loadIP()
	{
		ipSelect = loadIndexServer();
		if (ipSelect < 0 || ipSelect > GameMidlet.nameServer.Length - 1)
		{
			loadInfoIp(GameMidlet.GetWorldIndex());
		}
		else
		{
			loadInfoIp(ipSelect);
		}
	}

	public static void loadInfoIp(int index)
	{
		if (Session_ME.gI().isConnected())
		{
			Session_ME.gI().close();
		}
		ipSelect = index;
		saveIndexServer(ipSelect);
		GameMidlet.IP = GameMidlet.ipList[ipSelect];
		GameMidlet.PORT = GameMidlet.portList[ipSelect];
		GameMidlet.serverLogin = GameMidlet.serverLoginList[ipSelect];
		mResources.loadLanguage(GameMidlet.language[ipSelect]);
		GameCanvas.menu.menuSelectedItem = GameMidlet.serverST[ipSelect];
		GameCanvas.connect(5);
	}

	public override void switchToMe()
	{
		if (RMS.loadRMSInt("isKiemduyet") == 0)
		{
			GameCanvas.isKiemduyet = true;
		}
		else
		{
			GameCanvas.isKiemduyet = false;
		}
		GameScr.gH = GameCanvas.h;
		if (GameCanvas.typeBg == 2)
		{
			GameCanvas.loadBG(0);
		}
		else
		{
			GameCanvas.loadBG(TileMap.bgID);
		}
		base.switchToMe();
		if (GameScr.instance != null)
		{
			GameScr.instance = null;
		}
		TileMap.bgID = (sbyte)(mSystem.currentTimeMillis() % 9);
		if (TileMap.bgID == 5 || TileMap.bgID == 6)
		{
			TileMap.bgID = 4;
		}
		GameScr.loadCamera(fullScreen: true);
		GameScr.cmx = 100;
		popupW = 170;
		popupH = 175;
		if (GameCanvas.w == 128 || GameCanvas.h <= 208)
		{
			popupW = 126;
			popupH = 160;
		}
		popupX = GameCanvas.w / 2 - popupW / 2;
		popupY = GameCanvas.h / 2 - popupH / 2;
		if (GameCanvas.h <= 250)
		{
			popupY -= 10;
		}
		left = new Command(mResources.LANGUAGE, GameCanvas.instance, 8886, null);
		indexRow = -1;
		if (!GameCanvas.isTouch)
		{
			indexRow = 0;
		}
		if (cmdChoiMoi == null)
		{
			cmdChoiMoi = new Command((!GameCanvas.isTouch) ? mResources.OK : string.Empty, this, 1000, null);
			cmdDoiTaiKhoan = new Command((!GameCanvas.isTouch) ? mResources.OK : string.Empty, this, 1001, null);
			cmdChonServer = new Command((!GameCanvas.isTouch) ? mResources.OK : string.Empty, this, 1002, null);
			cmdChoiTiep = new Command((!GameCanvas.isTouch) ? mResources.OK : string.Empty, this, 1003, null);
			cmdUpdLinkSv = new Command((!GameCanvas.isTouch) ? mResources.OK : string.Empty, this, 20100, null);
			cmd = new Command[2][]
			{
				new Command[4] { cmdChoiMoi, cmdDoiTaiKhoan, cmdChonServer, cmdUpdLinkSv },
				new Command[5] { cmdChoiTiep, cmdChoiMoi, cmdDoiTaiKhoan, cmdChonServer, cmdUpdLinkSv }
			};
		}
		uname = RMS.loadRMSString("acc");
		pass = RMS.loadRMSString("pass");
		if (uname == null)
		{
			uname = string.Empty;
		}
		if (pass == null)
		{
			pass = string.Empty;
		}
		if ((uname == null || uname.Equals(string.Empty)) && unameChange.Equals(string.Empty))
		{
			menu = new string[4]
			{
				mResources.NEW_PLAY,
				mResources.CHANGE_ACC,
				mResources.SERVER,
				mResources.UPDATE_LINKSV
			};
		}
		else
		{
			menu = new string[5]
			{
				mResources.COUNTINUE_PLAY,
				mResources.NEW_PLAY,
				mResources.CHANGE_ACC,
				mResources.SERVER,
				mResources.UPDATE_LINKSV
			};
		}
		GameCanvas.menu.menuSelectedItem = GameMidlet.GetWorldIndex();
		GameMidlet.IP = GameMidlet.ipList[GameMidlet.GetWorldIndex()];
		if (loadIndexServer() > -1 && loadIndexServer() < GameMidlet.ipList.Length)
		{
			GameCanvas.menu.menuSelectedItem = loadIndexServer();
			GameMidlet.IP = GameMidlet.ipList[loadIndexServer()];
		}
		if (RMS.loadRMSString("random") == null)
		{
			RMS.saveRMSString("random", randomNumberlist());
		}
		if (LoginScr.imgTitle == null)
		{
			if (Main.isAppTeam)
			{
				LoginScr.imgTitle = GameCanvas.loadImage("/tt1");
			}
			else
			{
				LoginScr.imgTitle = GameCanvas.loadImage("/tt");
			}
		}
	}

	public override void paint(mGraphics g)
	{
		g.setColor(0);
		g.fillRect(0, 0, GameCanvas.w, GameCanvas.h);
		GameCanvas.paintBGGameScr(g);
		g.drawImage(LoginScr.imgTitle, GameCanvas.hw - LoginScr.imgTitle.getWidth() / 2, popupY + 10 - LoginScr.imgTitle.getHeight() / 2, 0);
		if (!GameCanvas.isTouch && GameCanvas.menu.menuSelectedItem == -1)
		{
			GameCanvas.menu.menuSelectedItem = 0;
		}
		int num = popupY + 50;
		for (int i = 0; i < menu.Length; i++)
		{
			g.setColor(Paint.COLORDARK);
			g.fillRect(popupX + 10, num + i * 35, popupW - 20, 28);
			GameCanvas.paintz.paintFrameBorder(popupX + 10, num + i * 35, popupW - 20, 28, g);
			if (i == indexRow)
			{
				g.setColor(Paint.COLORLIGHT);
				g.fillRect(popupX + 10, num + i * 35, popupW - 20, 28);
				GameCanvas.paintz.paintFrameBorder(popupX + 10, num + i * 35, popupW - 20, 28, g);
			}
			if (i >= menu.Length)
			{
				continue;
			}
			if (uname.Equals(string.Empty) && unameChange.Equals(string.Empty))
			{
				if (i == 2)
				{
					string text = GameMidlet.nameServer[loadIndexServer()];
					mFont.tahoma_7b_white.drawString(g, menu[i] + text, popupX + popupW / 2, num + i * 35 + 8, 2);
				}
				else
				{
					mFont.tahoma_7b_white.drawString(g, menu[i], popupX + popupW / 2, num + i * 35 + 6, 2);
				}
				continue;
			}
			switch (i)
			{
			case 0:
				mFont.tahoma_7b_white.drawString(g, menu[i] + ((!unameChange.Equals(string.Empty)) ? (": " + unameChange) : ((!uname.StartsWith("tmpusr")) ? (": " + uname) : string.Empty)), popupX + popupW / 2, num + i * 35 + 6, 2);
				break;
			case 3:
			{
				string text2 = GameMidlet.nameServer[loadIndexServer()];
				mFont.tahoma_7b_white.drawString(g, menu[i] + text2, popupX + popupW / 2, num + i * 35 + 8, 2);
				break;
			}
			default:
				mFont.tahoma_7b_white.drawString(g, menu[i], popupX + popupW / 2, num + i * 35 + 6, 2);
				break;
			}
		}
		if (GameCanvas.currentDialog == null)
		{
			GameCanvas.paintz.paintCmdBar(g, left, center, right);
		}
		base.paint(g);
	}

	public override void update()
	{
		if (uname.Equals(string.Empty) && unameChange.Equals(string.Empty))
		{
			if (indexRow > -1 && indexRow < cmd[0].Length)
			{
				center = cmd[0][indexRow];
			}
		}
		else if (indexRow > -1 && indexRow < cmd[1].Length)
		{
			center = cmd[1][indexRow];
		}
		GameScr.cmx++;
		if (GameScr.cmx > GameCanvas.w * 3 + 100)
		{
			GameScr.cmx = 100;
		}
		base.update();
	}

	public override void updateKey()
	{
		if (GameCanvas.keyPressedz[2] || GameCanvas.keyPressedz[4])
		{
			indexRow--;
			if (indexRow < 0)
			{
				indexRow = menu.Length - 1;
			}
		}
		else if (GameCanvas.keyPressedz[8] || GameCanvas.keyPressedz[6])
		{
			indexRow++;
			if (indexRow > menu.Length - 1)
			{
				indexRow = 0;
			}
		}
		if (GameCanvas.isPointerJustRelease && GameCanvas.isPointerHoldIn(popupX + 10, popupY + 45, popupW - 10, 170))
		{
			if (GameCanvas.isPointerClick)
			{
				indexRow = (GameCanvas.py - (popupY + 45)) / 35;
			}
			if (uname.Equals(string.Empty) && unameChange.Equals(string.Empty))
			{
				if (indexRow > -1 && indexRow < cmd[0].Length)
				{
					cmd[0][indexRow].performAction();
				}
			}
			else if (indexRow > -1 && indexRow < cmd[1].Length)
			{
				cmd[1][indexRow].performAction();
			}
		}
		base.updateKey();
		GameCanvas.clearKeyPressed();
	}

	protected void doSelectServer()
	{
		MyVector myVector = new MyVector();
		if (GameMidlet.indexClient == 0)
		{
			if (GameMidlet.isWorldver)
			{
				for (int i = GameMidlet.GetLastIndex() + 1; i <= GameMidlet.language.Length - 1; i++)
				{
					myVector.addElement(new Command(GameMidlet.nameServer[i], this, 20000 + i, null));
				}
			}
			else
			{
				for (int j = 0; j <= GameMidlet.GetLastIndex(); j++)
				{
					myVector.addElement(new Command(GameMidlet.nameServer[j], this, 20000 + j, null));
				}
			}
			GameCanvas.menu.startAt(myVector, 0);
			if (loadIndexServer() != -1)
			{
				GameCanvas.menu.menuSelectedItem = GameMidlet.serverST[loadIndexServer()];
			}
		}
		else
		{
			GameCanvas.menu.showMenu = false;
			GameMidlet.IP = GameMidlet.ipList[GameMidlet.GetWorldIndex()];
			saveIndexServer(GameMidlet.GetWorldIndex());
		}
	}

	public static void saveIndexServer(int index)
	{
		RMS.saveRMSInt("indServer", index);
	}

	public static int loadIndexServer()
	{
		return RMS.loadRMSInt("indServer");
	}

	public void doViewFAQ()
	{
		if (!listFAQ.Equals(string.Empty) || !listFAQ.Equals(string.Empty))
		{
		}
		if (!Session_ME.connected)
		{
			isFAQ = true;
			GameCanvas.connect(6);
		}
		GameCanvas.startWaitDlg();
	}

	public static bool isVirtualAcc()
	{
		if (uname != null && (uname.StartsWith("tmpusr") || uname.Equals(string.Empty)))
		{
			return true;
		}
		return false;
	}

	public static string randomNumberlist()
	{
		string text = string.Empty;
		for (int i = 0; i < 12; i++)
		{
			string text2 = Res.random(0, 9).ToString();
			text += text2;
		}
		return text;
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		case 1000:
			if (isVirtualAcc() && !uname.Equals(string.Empty))
			{
				GameCanvas.startYesNoDlg(mResources.NEW_ACC_ARLET, new Command(mResources.COUNTINUE_PLAY, this, 10001, null), new Command(mResources.NO, GameCanvas.instance, 8882, null));
				break;
			}
			doViewFAQ();
			Service.gI().login("-1", "12345", "1.8.8");
			break;
		case 10001:
			doViewFAQ();
			Service.gI().login("-1", "12345", "1.8.8");
			if (!unameChange.Equals(string.Empty))
			{
				uname = unameChange;
				pass = passChange;
				unameChange = string.Empty;
				passChange = string.Empty;
				RMS.saveRMSString("acc", uname);
				RMS.saveRMSString("pass", pass);
			}
			break;
		case 1001:
			if (isVirtualAcc() && !uname.Equals(string.Empty) && unameChange.Equals(string.Empty))
			{
				GameCanvas.startYesNoDlg(mResources.NEW_ACC_ARLET, new Command(mResources.COUNTINUE, this, 10004, null), new Command(mResources.NO, GameCanvas.instance, 8882, null));
			}
			else
			{
				GameCanvas.loginScr.switchToMe();
			}
			break;
		case 10004:
			GameCanvas.currentDialog = null;
			GameCanvas.loginScr.switchToMe();
			break;
		case 1002:
			doSelectServer();
			break;
		case 1003:
			doViewFAQ();
			if (!unameChange.Equals(string.Empty))
			{
				uname = unameChange;
				pass = passChange;
				unameChange = string.Empty;
				passChange = string.Empty;
				RMS.saveRMSString("acc", uname);
				RMS.saveRMSString("pass", pass);
			}
			Service.gI().login(uname, pass, "1.8.8");
			break;
		case 20000:
		case 20001:
		case 20002:
		case 20003:
		case 20004:
		case 20005:
		case 20006:
		case 20007:
		case 20008:
		case 20009:
		case 20010:
		case 20011:
		case 20012:
		case 20013:
		case 20014:
		case 20015:
		case 20016:
		case 20017:
		case 20018:
		case 20019:
		{
			if (Session_ME.gI().isConnected())
			{
				Session_ME.gI().close();
			}
			int num = idAction - 20000;
			GameCanvas.menu.showMenu = false;
			GameMidlet.IP = GameMidlet.ipList[num];
			GameMidlet.PORT = GameMidlet.portList[num];
			GameMidlet.serverLogin = GameMidlet.serverLoginList[num];
			saveIndexServer(num);
			GameCanvas.menu.menuSelectedItem = GameMidlet.serverST[num];
			GameCanvas.connect(7);
			break;
		}
		case 20100:
			GameCanvas.startWaitDlg();
			GameMidlet.getStrSv();
			GameCanvas.endDlg();
			break;
		}
	}
}
