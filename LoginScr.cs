using System;
using UnityEngine;

public class LoginScr : mScreen, IActionListener
{
	public TField tfUser;

	public TField tfPass;

	public TField tfRegPass;

	public TField tfEmail;

	public static LoginScr gI;

	private int focus;

	private int wC;

	private int yL;

	private int defYL;

	public bool isCheck;

	public bool isRes;

	private Command cmdLogin;

	private Command cmdCheck;

	private Command cmdFogetPass;

	private Command cmdRes;

	private Command cmdChangePass;

	private Command cmdMenu;

	public string listFAQ = string.Empty;

	public string titleFAQ;

	public string subtitleFAQ;

	private string numSupport = string.Empty;

	private string strUser;

	private string strPass;

	public static int indexLocal;

	public static Image imgTitle;

	public static bool isAutoLogin;

	public static bool isPlayMusic;

	private int yt;

	private int yy = GameCanvas.hh - mScreen.ITEM_HEIGHT - 5;

	private string passRe = string.Empty;

	public bool isFAQ;

	private string[] currentTip;

	private int tipid = -1;

	private int v = 2;

	private int g;

	private int ylogo = -40;

	private int dir = 1;

	public static bool isLoggingIn;

	private string strNick = string.Empty;

	private string oldpass;

	private string newpass;

	public LoginScr()
	{
		if (Main.isAppTeam)
		{
			imgTitle = GameCanvas.loadImage("/tt1");
		}
		else
		{
			imgTitle = GameCanvas.loadImage("/tt");
		}
		gI = this;
		TileMap.bgID = (sbyte)(mSystem.getCurrentTimeMillis() % 9);
		if (TileMap.bgID == 5 || TileMap.bgID == 6)
		{
			TileMap.bgID = 4;
		}
		GameScr.loadCamera(fullScreen: true);
		GameScr.cmx = 100;
		if (GameCanvas.h > 200)
		{
			defYL = GameCanvas.hh - 80;
		}
		else
		{
			defYL = GameCanvas.hh - 65;
		}
		resetLogo();
		wC = GameCanvas.w - 30;
		if (wC < 135)
		{
			wC = 135;
		}
		if (wC > 155)
		{
			wC = 155;
		}
		yt = GameCanvas.hh - mScreen.ITEM_HEIGHT - 5;
		if (GameCanvas.h <= 160)
		{
			yt = 20;
		}
		tfUser = new TField();
		tfUser.name = mResources.USERNAME;
		tfUser.x = GameCanvas.hw - 20 - 57;
		tfUser.y = yt;
		tfUser.width = wC;
		tfUser.height = mScreen.ITEM_HEIGHT + 2;
		tfUser.isFocus = true;
		tfUser.setIputType(TField.INPUT_ALPHA_NUMBER_ONLY);
		tfUser.showSubTextField = false;
		tfUser.setText(string.Empty);
		tfUser.cmdDoneAction = new Command(string.Empty, 4001);
		tfPass = new TField();
		tfPass.name = mResources.PASSWORD;
		tfPass.x = GameCanvas.hw - 20 - 57;
		tfPass.y = (yt += 35);
		tfPass.width = wC;
		tfPass.height = mScreen.ITEM_HEIGHT + 2;
		tfPass.isFocus = false;
		tfPass.setIputType(TField.INPUT_TYPE_PASSWORD);
		tfPass.showSubTextField = false;
		tfPass.setText(string.Empty);
		tfRegPass = new TField();
		tfRegPass.name = mResources.REPASSWORD;
		tfRegPass.x = GameCanvas.hw - 20 - 57;
		tfRegPass.y = (yt += 35);
		tfRegPass.width = wC;
		tfRegPass.height = mScreen.ITEM_HEIGHT + 2;
		tfRegPass.isFocus = false;
		tfRegPass.setIputType(TField.INPUT_TYPE_PASSWORD);
		tfPass.cmdDoneAction = new Command(string.Empty, 4002);
		tfRegPass.cmdDoneAction = new Command(string.Empty, 4003);
		tfEmail = new TField();
		tfEmail.name = "Email/số di động";
		tfEmail.x = GameCanvas.hw - 20 - 57;
		tfEmail.y = (yt += 35);
		tfEmail.width = wC;
		tfEmail.height = mScreen.ITEM_HEIGHT + 2;
		tfEmail.isFocus = false;
		tfEmail.setIputType(TField.INPUT_ALPHA_NUMBER_ONLY);
		isCheck = true;
		switch (RMS.loadRMSInt("check"))
		{
		case 1:
			isCheck = true;
			isAutoLogin = true;
			break;
		case 2:
			isCheck = false;
			break;
		}
		if (SelectServerScr.uname != null)
		{
			if (SelectServerScr.uname.StartsWith("tmpusr"))
			{
				tfUser.setText(string.Empty);
				tfPass.setText(string.Empty);
			}
			else
			{
				tfUser.setText(SelectServerScr.uname);
				tfPass.setText(SelectServerScr.pass);
			}
		}
		loadPass();
		focus = 0;
		cmdLogin = new Command(mResources.OK, this, 2000, null);
		cmdCheck = new Command(mResources.REMEMBER, this, 2001, null);
		cmdRes = new Command(mResources.OK, this, 2002, null);
		cmdChangePass = new Command(mResources.CHANGEPASS, this, 2004, null);
		cmdFogetPass = new Command(mResources.FORGETPASS, this, 2004, null);
		if (!isRes)
		{
			left = (cmdMenu = new Command(mResources.FORGETPASS, this, 2005, null));
		}
		else
		{
			left = (cmdMenu = new Command(mResources.CANCEL, this, 20051, null));
		}
		if (GameCanvas.isTouch && GameCanvas.w >= 320)
		{
			center = null;
			right = cmdLogin;
		}
		else
		{
			center = cmdLogin;
			right = tfUser.cmdClear;
		}
	}

	public static LoginScr mgI()
	{
		return gI;
	}

	protected void saveLastServer(string serverInfo)
	{
		RMS.saveRMSString("lastServer", serverInfo);
	}

	public override void switchToMe()
	{
		isRes = false;
		int num = RMS.loadRMSInt("isSound");
		if (num < 0)
		{
			RMS.saveRMSInt("isSound", 1);
			Sound.isSound = true;
		}
		else
		{
			switch (num)
			{
			case 1:
				Sound.isSound = true;
				break;
			case 2:
				Sound.isSound = false;
				Sound.bMuzikDisable = true;
				break;
			}
		}
		if (RMS.loadRMSString("random") == null)
		{
			RMS.saveRMSString("random", SelectServerScr.randomNumberlist());
		}
		resetLogo();
		GameScr.gH = GameCanvas.h;
		GameCanvas.saveIDBg = -100;
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
		if (GameCanvas.menu != null)
		{
			GameCanvas.menu = new Menu();
		}
		GameCanvas.isGPRS = false;
		if (Main.isPC)
		{
			int num2 = RMS.loadRMSInt("mapKey");
			GameCanvas.isChangMapKey = num2 != 1;
			Out.println(num2 + " loai map key nao");
		}
		int num3 = RMS.loadRMSInt("isSoftKey");
		if (num3 <= 0)
		{
			RMS.saveRMSInt("isSoftKey", 1);
			GameScr.isTouchKey = true;
		}
		else
		{
			switch (num3)
			{
			case 1:
				GameScr.isTouchKey = true;
				break;
			case 2:
				GameScr.isTouchKey = false;
				break;
			}
		}
		if (isAutoLogin && !Main.isPC)
		{
			string text = RMS.loadRMSString("lastServer");
			if (text != null)
			{
				GameMidlet.IP = text;
			}
			doLogin();
		}
		Sound.stopAllBg();
		Sound.play(Sound.MLogin, 0.5f);
		if (Main.isPC)
		{
			focus = 0;
		}
		left = (cmdMenu = new Command(mResources.FORGETPASS, this, 2005, null));
	}

	public void switchToMe(bool isRes)
	{
		this.isRes = isRes;
		resetLogo();
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
		if (GameCanvas.menu != null)
		{
			GameCanvas.menu = new Menu();
		}
		GameCanvas.isGPRS = false;
		left = (cmdMenu = new Command(mResources.CANCEL, this, 20051, null));
	}

	public void updateTfWhenOpenKb()
	{
		int num = (GameCanvas.h / 2 - 60) / 2;
		if (TouchScreenKeyboard.visible)
		{
			if (yy != num)
			{
				if (num - yy >> 1 == 0)
				{
					yy = num;
				}
				else
				{
					yy += num - yy >> 1;
				}
			}
			tfUser.y = yy;
			tfPass.y = yy + 35;
			tfRegPass.y = yy + 70;
			yt = yy + 70;
		}
		else
		{
			yy = GameCanvas.hh - mScreen.ITEM_HEIGHT - 5;
			tfUser.y = yy;
			tfPass.y = (yy += 35);
			tfRegPass.y = (yy += 35);
			yt = yy;
		}
	}

	private void loadPass()
	{
		sbyte[] array = RMS.loadRMS("njlogin");
		if (array == null)
		{
			return;
		}
		DataInputStream dataInputStream = new DataInputStream(array);
		try
		{
			if (isCheck)
			{
				tfUser.setText(dataInputStream.readUTF());
				tfUser.setOffset();
				tfPass.setText(dataInputStream.readUTF());
				tfPass.setOffset();
			}
			dataInputStream.close();
		}
		catch (Exception ex)
		{
			Out.println(ex.StackTrace);
		}
	}

	public void savePass()
	{
		DataOutputStream dataOutputStream = new DataOutputStream();
		try
		{
			if (isCheck)
			{
				dataOutputStream.writeUTF(tfUser.getText());
				dataOutputStream.writeUTF(tfPass.getText());
			}
			else
			{
				dataOutputStream.writeUTF(string.Empty);
				dataOutputStream.writeUTF(string.Empty);
			}
			RMS.saveRMS("njlogin", dataOutputStream.toByteArray());
			dataOutputStream.close();
		}
		catch (Exception ex)
		{
			Out.println(ex.StackTrace);
		}
	}

	private void doAskForGPRS()
	{
		GameCanvas.startYesNoDlg(mResources.ASK_NETWORK, new Command("3G/Wifi", this, 3000, null), new Command("GPRS", this, 3001, null));
	}

	protected void doSetGPRS(bool isGPRS)
	{
		GameCanvas.isGPRS = isGPRS;
		RMS.saveRMSInt("isGPRS", isGPRS ? 1 : 2);
	}

	protected void doMenu()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.NEWREGISTER, this, 1002, null));
		myVector.addElement(cmdFogetPass);
		myVector.addElement(new Command(mResources.CONFIG, this, 1006, null));
		myVector.addElement(new Command(mResources.FORUM, this, 1003, null));
		if (Main.isPC)
		{
			myVector.addElement(new Command(mResources.EXIT, GameCanvas.instance, 8885, null));
		}
		GameCanvas.menu.startAt(myVector, 0);
	}

	protected void doRegister()
	{
		if (tfUser.getText().Equals(string.Empty))
		{
			GameCanvas.startOKDlg(mResources.NOT_INPUT_USERNAME);
			return;
		}
		char[] array = tfUser.getText().ToCharArray();
		for (int i = 0; i < array.Length; i++)
		{
			if (!TField.setNormal(array[i]))
			{
				GameCanvas.startOKDlg(mResources.NOT_SPEC_CHARACTER);
				return;
			}
		}
		if (tfPass.getText().Equals(string.Empty))
		{
			GameCanvas.startOKDlg(mResources.NOT_INPUT_PASS1);
			return;
		}
		if (tfRegPass.getText().Equals(string.Empty))
		{
			GameCanvas.startOKDlg(mResources.NOT_INPUT_PASS2);
			return;
		}
		if (tfUser.getText().Length < 5)
		{
			GameCanvas.startOKDlg(mResources.USERNAME_LENGHT);
			return;
		}
		if (!tfPass.getText().Equals(tfRegPass.getText()))
		{
			GameCanvas.startOKDlg(mResources.WRONG_PASSWORD);
			return;
		}
		if (tfEmail.getText().Equals(string.Empty))
		{
			GameCanvas.startYesNoDlg("Bạn chưa nhập Email/số di động, Email/số di động giúp bạn lấy lại mật khẩu khi mất mật khẩu", new Command(mResources.CONTINUE, this, 4000, null), new Command(mResources.NO, GameCanvas.instance, 8882, null));
			return;
		}
		GameCanvas.msgdlg.setInfo(mResources.REGISTER_TEXT[0] + tfUser.getText() + mResources.REGISTER_TEXT[1], new Command(mResources.ACCEPT, this, 4000, null), null, new Command(mResources.NO, GameCanvas.instance, 8882, null));
		GameCanvas.currentDialog = GameCanvas.msgdlg;
	}

	protected void doRegister(string user)
	{
		isFAQ = false;
		GameMidlet.IP = GameMidlet.ipList[GameMidlet.GetWorldIndex()];
		GameCanvas.startWaitDlg(mResources.CONNECTING);
		GameCanvas.connect(0);
		GameCanvas.startWaitDlg(mResources.REGISTERING);
		Service.gI().setClientType();
		passRe = tfPass.getText();
		if (!Main.isPC)
		{
			Service.gI().requestRegisterNew(user, tfPass.getText(), tfEmail.getText());
		}
		else
		{
			Service.gI().requestRegisterNew(user, tfPass.getText(), tfEmail.getText());
		}
	}

	protected void doGetForgetPass(string user)
	{
		GameMidlet.inFoSMS = mResources.INFO_SEND_SMS_FOGETPASS;
		isFAQ = false;
		GameMidlet.IP = GameMidlet.ipList[GameMidlet.GetWorldIndex()];
		GameCanvas.startWaitDlg(mResources.CONNECTING);
		GameCanvas.connect(1);
		GameCanvas.startWaitDlg(mResources.PLEASEWAIT);
		Service.gI().requestForgetPass(user);
	}

	protected void doGetForgetPassByIMEI(string user, string newpass)
	{
		GameMidlet.inFoSMS = mResources.INFO_SEND_SMS_FOGETPASS;
		isFAQ = false;
		GameMidlet.IP = GameMidlet.ipList[GameMidlet.GetWorldIndex()];
		GameCanvas.startWaitDlg(mResources.CONNECTING);
		GameCanvas.connect(2);
		GameCanvas.startWaitDlg(mResources.PLEASEWAIT);
		Service.gI().requestForgetPassByIMEI(user, Main.IMEI, newpass);
	}

	public void doViewFAQ()
	{
		if (!listFAQ.Equals(string.Empty) || !listFAQ.Equals(string.Empty))
		{
		}
		if (!Session_ME.connected)
		{
			isFAQ = true;
			GameCanvas.connect(3);
		}
		GameCanvas.startWaitDlg();
	}

	protected void doLogin()
	{
		tipid = GameCanvas.gameTick % mResources.tips[Main.isPC ? 1 : 0].Length;
		currentTip = mFont.tahoma_7_white.splitStrInLine(mResources.tips[Main.isPC ? 1 : 0][tipid], GameCanvas.w - ((!Main.isPC) ? 100 : 40));
		isFAQ = false;
		string text = tfUser.getText().ToLower().Trim();
		string text2 = tfPass.getText().ToLower().Trim();
		if (text.Equals("showimei"))
		{
			GameCanvas.startOKDlg("IMEI : " + Main.IMEI);
		}
		else
		{
			if (text == null || text2 == null || text.Equals(string.Empty))
			{
				return;
			}
			if (text2.Equals(string.Empty))
			{
				focus = 1;
				tfUser.isFocus = false;
				tfPass.isFocus = true;
				right = tfPass.cmdClear;
				return;
			}
			if (!isAutoLogin)
			{
				GameCanvas.startWaitDlg(mResources.CONNECTING);
			}
			GameCanvas.connect(4);
			GameCanvas.startWaitDlg(mResources.LOGGING);
			Service.gI().setClientType();
			Service.gI().login(text, text2, "1.8.8");
			isLoggingIn = true;
			savePass(text, text2);
			focus = 0;
		}
	}

	public void savePass(string user, string pass)
	{
		if (isCheck)
		{
			RMS.saveRMSInt("check", 1);
			savePass();
		}
		else
		{
			RMS.saveRMSInt("check", 2);
			savePass();
		}
	}

	public override void update()
	{
		GameScr.cmx++;
		if (GameScr.cmx > GameCanvas.w * 3 + 100)
		{
			GameScr.cmx = 60;
		}
		GameCanvas.debug("LGU1", 0);
		tfUser.update();
		tfPass.update();
		GameCanvas.debug("LGU2", 0);
		if (isRes)
		{
			tfRegPass.update();
			tfEmail.update();
		}
		GameCanvas.debug("LGU3", 0);
		updateLogo();
		GameCanvas.debug("LGU4", 0);
		if (GameCanvas.isTouch)
		{
			center = null;
			if (isRes)
			{
				right = cmdRes;
			}
			else
			{
				right = cmdLogin;
			}
		}
		else if (isRes)
		{
			center = cmdRes;
		}
		else if (focus == 2)
		{
			center = cmdCheck;
			if (isCheck)
			{
				center.caption = mResources.UNCHECK;
			}
			else
			{
				center.caption = mResources.REMEMBER;
			}
		}
		else
		{
			center = cmdLogin;
		}
		GameCanvas.debug("LGU5", 0);
		if (g >= 0)
		{
			ylogo += dir * g;
			g += dir * v;
			if (g <= 0)
			{
				dir *= -1;
			}
			if (ylogo > 0)
			{
				dir *= -1;
				g -= 2 * v;
			}
		}
		GameCanvas.debug("LGU6", 0);
		if (tipid >= 0 && GameCanvas.gameTick % 100 == 0)
		{
			tipid++;
			if (tipid >= mResources.tips[Main.isPC ? 1 : 0].Length)
			{
				tipid = 0;
			}
			currentTip = mFont.tahoma_7_white.splitStrInLine(mResources.tips[Main.isPC ? 1 : 0][tipid], GameCanvas.w - ((!Main.isPC) ? 100 : 40));
		}
		updateTfWhenOpenKb();
	}

	public void updateLogo()
	{
		if (defYL != yL)
		{
			yL += defYL - yL >> 1;
		}
	}

	public override void keyPress(int keyCode)
	{
		if (tfUser.isFocus)
		{
			tfUser.keyPressed(keyCode);
		}
		else if (tfPass.isFocus)
		{
			tfPass.keyPressed(keyCode);
		}
		else if (isRes && tfRegPass.isFocus)
		{
			tfRegPass.keyPressed(keyCode);
		}
		else if (isRes && tfEmail.isFocus)
		{
			tfEmail.keyPressed(keyCode);
		}
		base.keyPress(keyCode);
	}

	public override void paint(mGraphics g)
	{
		g.setColor(0);
		g.fillRect(0, 0, GameCanvas.w, GameCanvas.h);
		GameCanvas.paintBGGameScr(g);
		int num = tfUser.y - 45;
		if (GameCanvas.h <= 220)
		{
			num += 5;
		}
		if (GameCanvas.currentDialog == null)
		{
			if (!isRes)
			{
				GameCanvas.paintz.paintFrame(GameCanvas.hw - 92, tfUser.y - 15, 184, 95, g);
			}
			else
			{
				GameCanvas.paintz.paintFrame(GameCanvas.hw - 92, tfUser.y - 15, 184, 155, g);
			}
			if (GameCanvas.h > 160 && imgTitle != null)
			{
				g.drawImage(imgTitle, GameCanvas.hw, num, 3);
			}
			GameCanvas.debug("PLG4", 1);
			tfUser.paint(g);
			g.setClip(0, 0, GameCanvas.w, GameCanvas.h);
			tfPass.paint(g);
			if (isRes)
			{
				tfRegPass.paint(g);
				tfEmail.paint(g);
			}
			g.setClip(0, 0, GameCanvas.w, GameCanvas.h);
			int num2 = 0;
			if (GameCanvas.w > 200)
			{
				if (tfUser.getText().Equals(string.Empty))
				{
					if (!tfUser.isFocus)
					{
						mFont.tahoma_7b_white.drawString(g, mResources.USERNAME, tfUser.x + 7, tfUser.y + 6, 0);
					}
					else
					{
						mFont.tahoma_7_grey.drawString(g, mResources.USERNAME, tfUser.x + 7, tfUser.y + 6, 0);
					}
				}
				if (tfPass.getText().Equals(string.Empty))
				{
					if (!tfPass.isFocus)
					{
						mFont.tahoma_7b_white.drawString(g, mResources.PASSWORD, tfPass.x + 7, tfPass.y + 6, 0);
					}
					else
					{
						mFont.tahoma_7_grey.drawString(g, mResources.PASSWORD, tfPass.x + 7, tfPass.y + 6, 0);
					}
				}
				if (isRes)
				{
					if (tfRegPass.getText().Equals(string.Empty))
					{
						if (!tfRegPass.isFocus)
						{
							mFont.tahoma_7b_white.drawString(g, mResources.REPASS, tfRegPass.x + 7, tfRegPass.y + 6, 0);
						}
						else
						{
							mFont.tahoma_7_grey.drawString(g, mResources.REPASS, tfRegPass.x + 7, tfRegPass.y + 6, 0);
						}
					}
					if (tfEmail.getText().Equals(string.Empty))
					{
						if (!tfEmail.isFocus)
						{
							mFont.tahoma_7b_white.drawString(g, "Email/số di động", tfEmail.x + 7, tfEmail.y + 6, 0);
						}
						else
						{
							mFont.tahoma_7_grey.drawString(g, "Email/số di động", tfEmail.x + 7, tfEmail.y + 6, 0);
						}
					}
				}
				num2 = 10;
			}
		}
		else if (currentTip != null)
		{
			for (int i = 0; i < currentTip.Length; i++)
			{
				mFont.tahoma_7_white.drawString(g, currentTip[i], GameCanvas.w / 2, tfUser.y - 15 + 10 * i, 2, mFont.tahoma_7_grey);
			}
		}
		string st = "1.8.8";
		if (isLoggingIn)
		{
			st = Session_ME.strRecvByteCount;
		}
		mFont.tahoma_7_grey.drawString(g, st, GameCanvas.w - 5, 5, 1);
		base.paint(g);
	}

	public override void updateKey()
	{
		if (GameCanvas.keyPressedz[2] || GameCanvas.keyPressedz[24])
		{
			focus--;
			if (focus < 0)
			{
				focus = 3;
			}
		}
		else if (GameCanvas.keyPressedz[8] || GameCanvas.keyPressedz[25] || GameCanvas.keyPressedz[32])
		{
			focus++;
			if (focus > 3)
			{
				focus = 0;
			}
		}
		if (GameCanvas.keyPressedz[2] || GameCanvas.keyPressedz[8] || GameCanvas.keyPressedz[25] || GameCanvas.keyPressedz[24] || GameCanvas.keyPressedz[32])
		{
			GameCanvas.clearKeyPressed();
			if (focus == 1)
			{
				tfUser.isFocus = false;
				tfPass.isFocus = true;
				tfRegPass.isFocus = false;
				tfEmail.isFocus = false;
				right = tfPass.cmdClear;
			}
			else if (focus == 0)
			{
				tfUser.isFocus = true;
				tfPass.isFocus = false;
				tfRegPass.isFocus = false;
				tfEmail.isFocus = false;
				right = tfUser.cmdClear;
			}
			else
			{
				tfUser.isFocus = false;
				tfPass.isFocus = false;
				if (isRes)
				{
					if (focus == 2)
					{
						tfRegPass.isFocus = true;
						tfEmail.isFocus = false;
						right = tfRegPass.cmdClear;
					}
					else if (focus == 3)
					{
						tfEmail.isFocus = true;
						tfRegPass.isFocus = false;
						right = tfEmail.cmdClear;
					}
				}
			}
		}
		if (GameCanvas.isPointerJustRelease)
		{
			if (GameCanvas.isPointerHoldIn(tfUser.x, tfUser.y, tfUser.width, tfUser.height))
			{
				focus = 0;
			}
			else if (GameCanvas.isPointerHoldIn(tfPass.x, tfPass.y, tfPass.width, tfPass.height))
			{
				focus = 1;
			}
			else
			{
				if (isRes)
				{
					if (GameCanvas.isPointerHoldIn(tfRegPass.x, tfRegPass.y, tfRegPass.width, tfRegPass.height))
					{
						focus = 2;
					}
				}
				else if (GameCanvas.isPointerHoldIn(tfUser.x - 30, GameCanvas.hh + 40, 90, 35))
				{
					isCheck = !isCheck;
				}
				focus = 2;
			}
		}
		if (Main.isPC && GameCanvas.keyPressedz[5] && right != null)
		{
			right.performAction();
		}
		base.updateKey();
		GameCanvas.clearKeyPressed();
	}

	public void resetLogo()
	{
		yL = -50;
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		case 1002:
			actRegister();
			break;
		case 10021:
			actRegisterLeft();
			break;
		case 1003:
			try
			{
				GameMidlet.instance.platformRequest("http://ninjaschool.vn");
				break;
			}
			catch (Exception ex)
			{
				Out.println(ex.ToString() + " loi tai perform cua login");
				break;
			}
		case 1004:
			domenuConfig();
			break;
		case 10041:
			RMS.saveRMSInt("lowGraphic", 0);
			GameCanvas.startOK(mResources.RESTART, 8885, null);
			break;
		case 10042:
			RMS.saveRMSInt("lowGraphic", 1);
			GameCanvas.startOK(mResources.RESTART, 8885, null);
			break;
		case 1005:
			doAskForGPRS();
			break;
		case 1006:
			domenuConfig();
			break;
		case 10061:
			RMS.saveRMSInt("isSoftKey", 1);
			GameScr.isTouchKey = true;
			break;
		case 1009:
			RMS.clearRMS();
			break;
		case 10062:
			RMS.saveRMSInt("isSoftKey", 2);
			GameScr.isTouchKey = false;
			break;
		case 1006190:
			RMS.saveRMSInt("mapKey", 1);
			GameCanvas.isChangMapKey = false;
			break;
		case 1006291:
			RMS.saveRMSInt("mapKey", 2);
			GameCanvas.isChangMapKey = true;
			break;
		case 1007:
			Sound.isSound = !Sound.isSound;
			if (Sound.isSound)
			{
				RMS.saveRMSInt("isSound", 1);
				GameMidlet.isPlaySound = true;
				Sound.bMuzikDisable = false;
				if (GameCanvas.currentScreen == GameCanvas.loginScr)
				{
					Sound.play(Sound.MLogin, 0.5f);
				}
				Out.println("mo am thanh");
			}
			else
			{
				RMS.saveRMSInt("isSound", 2);
				Sound.stopAll();
				Sound.stopAllBg();
				GameMidlet.isPlaySound = false;
			}
			GameMidlet.isPlaySound = Sound.isSound;
			break;
		case 10071:
			AskChangeScreen();
			break;
		case 10072:
			doChangeScreen();
			break;
		case 1008:
			GameCanvas.startYesNoDlg(mResources.SELECT_LANGUAGE, new Command(mResources.ACCEPT, this, 10081, null), new Command(mResources.NO, GameCanvas.gI(), 8882, null));
			break;
		case 10081:
			GameCanvas.endDlg();
			doResetToSelectLanguage();
			break;
		case 10082:
			LanguageScr.saveLanguageID(mResources.Lang_EN);
			RMS.clearRMS();
			GameCanvas.startOK(mResources.RESTART2, 8885, null);
			break;
		case 2000:
			if (!tfUser.getText().Equals(string.Empty) && !tfPass.getText().Equals(string.Empty))
			{
				SelectServerScr.unameChange = tfUser.getText();
				SelectServerScr.passChange = tfPass.getText();
			}
			GameCanvas.selectsvScr.switchToMe();
			break;
		case 2001:
			if (isCheck)
			{
				isCheck = false;
			}
			else
			{
				isCheck = true;
			}
			break;
		case 2002:
			doRegister();
			break;
		case 2003:
			GameMidlet.flatForm("http://dd.ninjaschool.vn/app/index.php?for=event&do=resetpass");
			break;
		case 2004:
			if (Main.isPC)
			{
				GameCanvas.inputDlg.show(mResources.INPUT_NICK, new Command(mResources.OK, this, 20041, null), TField.INPUT_TYPE_ANY);
				break;
			}
			GameCanvas.input2Dlg.setTitle(mResources.INPUT_NICK, mResources.NEWPASS);
			GameCanvas.input2Dlg.show(mResources.CLAN[0], new Command(mResources.CLOSE, GameCanvas.gI(), 8882, null), new Command(mResources.OK, mgI(), 200423, null), TField.INPUT_TYPE_ANY, TField.INPUT_TYPE_ANY);
			break;
		case 200423:
			strNick = GameCanvas.input2Dlg.tfInput.getText().ToString();
			newpass = GameCanvas.input2Dlg.tfInput2.getText().ToString();
			GameCanvas.endDlg();
			if (strNick.Equals(string.Empty))
			{
				GameCanvas.startOKDlg(mResources.NOT_INPUT_USERNAME);
				break;
			}
			if (newpass.Equals(string.Empty))
			{
				GameCanvas.startOKDlg(mResources.NOT_INPUT_PASS);
				break;
			}
			GameCanvas.endDlg();
			if (Main.isPC)
			{
				doGetForgetPass(strNick);
			}
			else
			{
				doGetForgetPassByIMEI(strNick, newpass);
			}
			break;
		case 20041:
			strNick = GameCanvas.inputDlg.tfInput.getText().ToString();
			GameCanvas.endDlg();
			if (strNick.Equals(string.Empty))
			{
				GameCanvas.startOKDlg(mResources.NOT_INPUT_USERNAME);
				break;
			}
			GameCanvas.startYesNoDlg(mResources.ASK_REG_NUM, new Command(mResources.YES, this, 200421, null), new Command(mResources.NO, this, 200422, null));
			GameCanvas.endDlg();
			doGetForgetPass(strNick);
			break;
		case 200421:
			GameCanvas.endDlg();
			if (Main.isPC)
			{
				doGetForgetPass(strNick);
			}
			else
			{
				doGetForgetPassByIMEI(strNick, newpass);
			}
			break;
		case 200422:
			GameCanvas.startOKDlg(mResources.replace(mResources.GETPASS_BY_NUMPHONE, strNick));
			break;
		case 2005:
			GameCanvas.startYesNoDlg("Bạn có muốn reset mật khẩu?", new Command(mResources.OK, this, 20052, null), new Command(mResources.NO, GameCanvas.instance, 8882, null));
			break;
		case 20051:
			GameScr.gI().switchToMe();
			break;
		case 20052:
			Application.OpenURL("http://dd.ninjaschool.vn/app/index.php?for=event&do=resetpass");
			break;
		case 3000:
			doSetGPRS(isGPRS: false);
			GameCanvas.endDlg();
			break;
		case 3001:
			doSetGPRS(isGPRS: true);
			GameCanvas.endDlg();
			break;
		case 4000:
			doRegister(tfUser.getText());
			break;
		case 4001:
			tfUser.setFocus(isFocus: false);
			tfPass.setFocusWithKb(isFocus: true);
			break;
		case 4002:
			tfPass.setFocus(isFocus: false);
			if (isRes)
			{
				tfRegPass.setFocusWithKb(isFocus: true);
			}
			break;
		case 4003:
			tfRegPass.setFocus(isFocus: false);
			tfRegPass.setFocusWithKb(isFocus: true);
			break;
		case 200411:
			oldpass = GameCanvas.input2Dlg.tfInput.getText().ToString();
			newpass = GameCanvas.input2Dlg.tfInput2.getText().ToString();
			GameCanvas.endDlg();
			if (oldpass.Equals(string.Empty) || newpass.Equals(string.Empty))
			{
				GameCanvas.startOKDlg(mResources.NOT_INPUT_PASS1);
			}
			else
			{
				GameCanvas.startYesNoDlg(mResources.replace(mResources.ASK_ACC_CHANGE, strNick), new Command(string.Empty, this, 200421, null), new Command(string.Empty, this, 200422, null));
			}
			break;
		}
	}

	private void doResetToSelectLanguage()
	{
		LanguageScr.saveLanguageID(-1);
		GameMidlet.instance.notifyDestroyed();
	}

	private void domenuConfig()
	{
		MyVector myVector = new MyVector();
		if (!Main.isPC)
		{
			myVector.addElement(new Command(mResources.SOFT_KEY, this, 10061, null));
			myVector.addElement(new Command(mResources.ANALOG_KEY, this, 10062, null));
		}
		else
		{
			myVector.addElement(new Command(mResources.control1, this, 1006190, null));
			myVector.addElement(new Command(mResources.control2, this, 1006291, null));
			myVector.addElement(new Command((mGraphics.zoomLevel != 1) ? mResources.SCREEN1 : mResources.SCREEN2, this, 10071, null));
		}
		myVector.addElement(new Command(mResources.SOUND + (Sound.isSound ? mResources.OFF : mResources.ON), this, 1007, null));
		myVector.addElement(new Command(mResources.LANGUAGE, this, 1008, null));
		if (GameCanvas.currentScreen == this)
		{
			myVector.addElement(new Command(mResources.RMS, this, 1009, null));
		}
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void doChangeScreen()
	{
		if (mGraphics.zoomLevel != 1)
		{
			RMS.saveRMSInt("levelScreenKN", 1);
			Screen.SetResolution(480, 320, fullscreen: false);
		}
		else
		{
			RMS.saveRMSInt("levelScreenKN", 0);
			Screen.SetResolution(1024, 600, fullscreen: false);
		}
		GameMidlet.instance.exit();
	}

	private void AskChangeScreen()
	{
		GameCanvas.startYesNoDlg(mResources.Noti_ResizeScr + ((mGraphics.zoomLevel != 1) ? mResources.large : mResources.small), new Command(mResources.YES, this, 10072, null), new Command(mResources.NO, GameCanvas.gI(), 8882, null));
	}

	private void actRegisterLeft()
	{
		isRes = false;
		tfRegPass.isFocus = false;
		tfPass.isFocus = false;
		tfUser.isFocus = true;
		right = tfUser.cmdClear;
		left = cmdMenu;
	}

	private void actRegister()
	{
		isRes = true;
		tfRegPass.isFocus = false;
		tfEmail.isFocus = false;
		tfPass.isFocus = false;
		tfUser.isFocus = true;
		right = tfUser.cmdClear;
		left = new Command(mResources.CANCEL, this, 10021, null);
	}
}
