public class Menu
{
	public bool showMenu;

	public MyVector menuItems;

	public int menuSelectedItem;

	public static int[] menuTemY;

	public int menuX;

	public int menuY;

	public int menuW;

	public int menuH;

	public int w;

	public static int cmtoX;

	public static int cmx;

	public static int cmdy;

	public static int cmvy;

	public static int cmxLim;

	public static int xc;

	private bool wantUpdateList;

	private Command left = new Command(mResources.SELECT, 0);

	private Command right = ((!GameCanvas.isTouch) ? new Command(mResources.CLOSE, 0, GameCanvas.w - 71, GameCanvas.h - mScreen.cmdH + 1) : null);

	private Command center;

	public bool disableClose;

	private int pa;

	private bool trans;

	private bool touch;

	private bool close;

	public int tDelay;

	private int pointerDownTime;

	private int pointerDownFirstX;

	private int[] pointerDownLastX = new int[3];

	public bool pointerIsDowning;

	public bool isDownWhenRunning;

	private int waitToPerform;

	private int cmRun;

	private int cmvx;

	private int cmdx;

	private bool isClose;

	public bool[] isNotClose;

	public long timeStart;

	public void startWithoutCloseButton(MyVector menuItems, int pos)
	{
		startAt(menuItems, pos);
		disableClose = true;
	}

	public void startAt(MyVector menuItems, int pos)
	{
		if (showMenu)
		{
			return;
		}
		isClose = false;
		touch = false;
		close = false;
		isNotClose = new bool[menuItems.size()];
		for (int i = 0; i < isNotClose.Length; i++)
		{
			isNotClose[i] = false;
		}
		disableClose = false;
		ChatPopup.currentMultilineChatPopup = null;
		InfoDlg.hide();
		tDelay = 0;
		if (menuItems.size() == 0)
		{
			return;
		}
		this.menuItems = menuItems;
		menuW = 60;
		menuH = 60;
		for (int j = 0; j < menuItems.size(); j++)
		{
			Command command = (Command)menuItems.elementAt(j);
			int width = mFont.tahoma_7_yellow.getWidth(command.caption);
			if (width > menuW - 8)
			{
				command.subCaption = mFont.tahoma_7_yellow.splitFontArray(command.caption, menuW - 8);
			}
		}
		menuTemY = new int[menuItems.size()];
		menuX = (GameCanvas.w - menuItems.size() * menuW) / 2;
		if (menuX < 1)
		{
			menuX = 1;
		}
		menuY = GameCanvas.h - menuH - (Paint.hTab + 1);
		if (GameCanvas.isTouch)
		{
			menuY -= 3;
		}
		menuY += 27;
		for (int k = 0; k < menuTemY.Length; k++)
		{
			menuTemY[k] = GameCanvas.h;
		}
		showMenu = true;
		menuSelectedItem = 0;
		cmxLim = this.menuItems.size() * menuW - GameCanvas.w;
		if (cmxLim < 0)
		{
			cmxLim = 0;
		}
		cmtoX = 0;
		cmx = 0;
		xc = 50;
		w = menuItems.size() * menuW - 1;
		if (w > GameCanvas.w - 2)
		{
			w = GameCanvas.w - 2;
		}
		if (GameCanvas.isTouch && !Main.isPC)
		{
			menuSelectedItem = -1;
		}
		mScreen.keyTouch = -1;
	}

	public void updateMenuKey()
	{
		if (!showMenu || isScrolling())
		{
			return;
		}
		bool flag = false;
		if (GameCanvas.keyPressedz[(!Main.isPC) ? 2 : 21] || GameCanvas.keyPressedz[(!Main.isPC) ? 4 : 23])
		{
			flag = true;
			menuSelectedItem--;
			if (menuSelectedItem < 0)
			{
				menuSelectedItem = menuItems.size() - 1;
			}
		}
		else if (GameCanvas.keyPressedz[(!Main.isPC) ? 8 : 22] || GameCanvas.keyPressedz[(!Main.isPC) ? 6 : 24])
		{
			flag = true;
			menuSelectedItem++;
			if (menuSelectedItem > menuItems.size() - 1)
			{
				menuSelectedItem = 0;
			}
		}
		else if (GameCanvas.keyPressedz[5])
		{
			if (center != null)
			{
				if (center.idAction > 0)
				{
					if (center.actionListener == GameScr.gI())
					{
						GameScr.gI().actionPerform(center.idAction, center.p);
					}
					else
					{
						perform(center.idAction, center.p);
					}
				}
			}
			else
			{
				waitToPerform = 2;
			}
		}
		else if (GameCanvas.keyPressedz[12])
		{
			if (isScrolling())
			{
				return;
			}
			if (left.idAction > 0)
			{
				perform(left.idAction, left.p);
			}
			else
			{
				waitToPerform = 2;
			}
		}
		else if (!disableClose && (GameCanvas.keyPressedz[13] || mScreen.getCmdPointerLast(right)))
		{
			if (isScrolling())
			{
				return;
			}
			if (!close)
			{
				close = true;
			}
			isClose = true;
		}
		if (flag)
		{
			cmtoX = menuSelectedItem * menuW + menuW - GameCanvas.w / 2;
			if (cmtoX > cmxLim)
			{
				cmtoX = cmxLim;
			}
			if (cmtoX < 0)
			{
				cmtoX = 0;
			}
			if (menuSelectedItem == menuItems.size() - 1 || menuSelectedItem == 0)
			{
				cmx = cmtoX;
			}
		}
		if (!disableClose && GameCanvas.isPointerJustRelease && !GameCanvas.isPointer(menuX, menuY, w, menuH) && !pointerIsDowning)
		{
			if (!isScrolling())
			{
				pointerDownTime = (pointerDownFirstX = 0);
				pointerIsDowning = false;
				isClose = true;
				close = true;
			}
			return;
		}
		if (GameCanvas.isPointerDown)
		{
			if (!pointerIsDowning && GameCanvas.isPointer(menuX, menuY, w, menuH))
			{
				for (int i = 0; i < pointerDownLastX.Length; i++)
				{
					pointerDownLastX[0] = GameCanvas.px;
				}
				pointerDownFirstX = GameCanvas.px;
				pointerIsDowning = true;
				isDownWhenRunning = cmRun != 0;
				cmRun = 0;
			}
			else if (pointerIsDowning)
			{
				pointerDownTime++;
				if (pointerDownTime > 5 && pointerDownFirstX == GameCanvas.px && !isDownWhenRunning)
				{
					pointerDownFirstX = -1000;
					menuSelectedItem = (cmtoX + GameCanvas.px - menuX) / menuW;
				}
				int num = GameCanvas.px - pointerDownLastX[0];
				if (num != 0 && menuSelectedItem != -1)
				{
					menuSelectedItem = -1;
				}
				for (int num2 = pointerDownLastX.Length - 1; num2 > 0; num2--)
				{
					pointerDownLastX[num2] = pointerDownLastX[num2 - 1];
				}
				pointerDownLastX[0] = GameCanvas.px;
				cmtoX -= num;
				if (cmtoX < 0)
				{
					cmtoX = 0;
				}
				if (cmtoX > cmxLim)
				{
					cmtoX = cmxLim;
				}
				if (cmx < 0 || cmx > cmxLim)
				{
					num /= 2;
				}
				cmx -= num;
				if (cmx < -(GameCanvas.h / 3))
				{
					wantUpdateList = true;
				}
				else
				{
					wantUpdateList = false;
				}
			}
		}
		if (GameCanvas.isPointerJustRelease && pointerIsDowning)
		{
			int i2 = GameCanvas.px - pointerDownLastX[0];
			GameCanvas.isPointerJustRelease = false;
			if (Res.abs(i2) < 20 && Res.abs(GameCanvas.px - pointerDownFirstX) < 20 && !isDownWhenRunning)
			{
				cmRun = 0;
				cmtoX = cmx;
				pointerDownFirstX = -1000;
				menuSelectedItem = (cmtoX + GameCanvas.px - menuX) / menuW;
				pointerDownTime = 0;
				waitToPerform = 10;
			}
			else if (menuSelectedItem != -1 && pointerDownTime > 5)
			{
				pointerDownTime = 0;
				waitToPerform = 1;
			}
			else if (menuSelectedItem == -1 && !isDownWhenRunning)
			{
				if (cmx < 0)
				{
					cmtoX = 0;
				}
				else if (cmx > cmxLim)
				{
					cmtoX = cmxLim;
				}
				else
				{
					int num3 = GameCanvas.px - pointerDownLastX[0] + (pointerDownLastX[0] - pointerDownLastX[1]) + (pointerDownLastX[1] - pointerDownLastX[2]);
					num3 = ((num3 > 10) ? 10 : ((num3 < -10) ? (-10) : 0));
					cmRun = -num3 * 100;
				}
			}
			pointerIsDowning = false;
			pointerDownTime = 0;
			GameCanvas.isPointerJustRelease = false;
		}
		GameCanvas.clearKeyPressed();
		GameCanvas.clearKeyHold();
	}

	public void moveCamera()
	{
		if (cmRun != 0 && !pointerIsDowning)
		{
			cmtoX += cmRun / 100;
			if (cmtoX < 0)
			{
				cmtoX = 0;
			}
			else if (cmtoX > cmxLim)
			{
				cmtoX = cmxLim;
			}
			else
			{
				cmx = cmtoX;
			}
			cmRun = cmRun * 9 / 10;
			if (cmRun < 100 && cmRun > -100)
			{
				cmRun = 0;
			}
		}
		if (cmx != cmtoX && !pointerIsDowning)
		{
			cmvx = cmtoX - cmx << 2;
			cmdx += cmvx;
			cmx += cmdx >> 4;
			cmdx &= 15;
		}
	}

	public void paintMenu(mGraphics g)
	{
		g.translate(-g.getTranslateX(), -g.getTranslateY());
		g.translate(-cmx, 0);
		for (int i = 0; i < menuItems.size(); i++)
		{
			if (i == menuSelectedItem)
			{
				g.drawImage(GameScr.imgMenu2, menuX + i * menuW - 1, menuTemY[i] + 1, mGraphics.TOP | mGraphics.LEFT);
			}
			else
			{
				g.drawImage(GameScr.imgMenu1, menuX + i * menuW - 1, menuTemY[i] + 1, mGraphics.TOP | mGraphics.LEFT);
			}
			string[] array = ((Command)menuItems.elementAt(i)).subCaption;
			if (array == null)
			{
				array = new string[1] { ((Command)menuItems.elementAt(i)).caption };
			}
			int num = menuTemY[i] + (menuH - array.Length * 14) / 2 + 1;
			for (int j = 0; j < array.Length; j++)
			{
				if (GameScr.isMessageMenu)
				{
					if (ChatManager.gI().findWaitPerson(array[j]))
					{
						if (GameCanvas.gameTick % 10 > 5)
						{
							mFont.tahoma_7_red.drawString(g, array[j], menuX + i * menuW + menuW / 2 - 2, num + j * 14, 2);
						}
						else
						{
							mFont.tahoma_7_yellow.drawString(g, array[j], menuX + i * menuW + menuW / 2 - 2, num + j * 14, 2);
						}
					}
					else
					{
						mFont.tahoma_7_yellow.drawString(g, array[j], menuX + i * menuW + menuW / 2 - 2, num + j * 14, 2);
					}
				}
				else
				{
					mFont.tahoma_7_yellow.drawString(g, array[j], menuX + i * menuW + menuW / 2 - 2, num + j * 14, 2);
				}
			}
		}
		g.translate(-g.getTranslateX(), -g.getTranslateY());
		Command command = ((!disableClose) ? right : null);
		if (!GameCanvas.isTouch)
		{
			GameCanvas.paintz.paintCmdBar(g, left, center, command);
		}
		else
		{
			GameCanvas.paintz.paintCmdBar(g, null, center, command);
		}
	}

	public void doCloseMenu()
	{
		isClose = false;
		showMenu = false;
		InfoDlg.hide();
		if (close)
		{
			GameScr.isMessageMenu = false;
			if (Char.getMyChar().npcFocus != null && Char.getMyChar().npcFocus.chatPopup != null)
			{
				Char.getMyChar().npcFocus.chatPopup = null;
			}
		}
		else if (touch && menuSelectedItem >= 0)
		{
			((Command)menuItems.elementAt(menuSelectedItem))?.performAction();
		}
	}

	public bool isScrolling()
	{
		if ((!isClose && menuTemY[menuTemY.Length - 1] > menuY) || (isClose && menuTemY[menuTemY.Length - 1] < GameCanvas.h))
		{
			return true;
		}
		return false;
	}

	public void updateMenu()
	{
		moveCamera();
		if (!isClose)
		{
			tDelay++;
			for (int i = 0; i < menuTemY.Length; i++)
			{
				if (menuTemY[i] <= menuY)
				{
					continue;
				}
				if ((mSystem.currentTimeMillis() - timeStart) / 1000 > 5)
				{
					int num = menuTemY[i] - menuY >> 1;
					if (num < 1)
					{
						num = 1;
					}
					if (tDelay > i)
					{
						menuTemY[i] -= num;
					}
				}
				else
				{
					menuTemY[i] = menuY;
				}
			}
			if (menuTemY[menuTemY.Length - 1] <= menuY)
			{
				tDelay = 0;
			}
		}
		else
		{
			tDelay++;
			for (int j = 0; j < menuTemY.Length; j++)
			{
				if (menuTemY[j] < GameCanvas.h)
				{
					menuTemY[j] = GameCanvas.h;
					timeStart = mSystem.currentTimeMillis();
				}
			}
			if (menuTemY[menuTemY.Length - 1] >= GameCanvas.h)
			{
				tDelay = 0;
				doCloseMenu();
			}
		}
		if (xc != 0)
		{
			xc >>= 1;
			if (xc < 0)
			{
				xc = 0;
			}
		}
		if (isScrolling() || waitToPerform <= 0)
		{
			return;
		}
		waitToPerform--;
		if (waitToPerform == 0)
		{
			if (!isNotClose[menuSelectedItem])
			{
				isClose = true;
				touch = true;
			}
			else
			{
				performSelect();
			}
		}
	}

	public void perform(int idAction, object p)
	{
		if (idAction != 1000)
		{
			return;
		}
		ChatTab chatTab = (ChatTab)p;
		menuItems.removeAllElements();
		ChatManager.gI().removeFromWaitList(chatTab.ownerName);
		ChatManager.gI().chatTabs.removeElement(chatTab);
		for (int i = 0; i < ChatManager.gI().chatTabs.size(); i++)
		{
			ChatTab chatTab2 = (ChatTab)ChatManager.gI().chatTabs.elementAt(i);
			menuItems.addElement(new Command(chatTab2.ownerName, null, 12001, i));
		}
		menuItems.addElement(new Command(mResources.BLOCK_MESSAGE, null, 12006, null));
		menuItems.addElement(new Command(mResources.CHAT_ADMIN, null, 12008, null));
		for (int j = 0; j < menuItems.size(); j++)
		{
			Command command = (Command)menuItems.elementAt(j);
			int width = mFont.tahoma_7_yellow.getWidth(command.caption);
			if (width > menuW - 8)
			{
				command.subCaption = mFont.tahoma_7_yellow.splitFontArray(command.caption, menuW - 8);
			}
		}
		cmxLim = menuItems.size() * menuW - GameCanvas.w;
		cmtoX = menuSelectedItem * menuW + menuW - GameCanvas.w / 2;
		if (cmtoX > cmxLim)
		{
			cmtoX = cmxLim;
		}
		if (cmtoX < 0)
		{
			cmtoX = 0;
		}
		if (menuSelectedItem == menuItems.size() - 1 || menuSelectedItem == 0)
		{
			cmx = cmtoX;
		}
	}

	public void performSelect()
	{
		InfoDlg.hide();
		if (menuSelectedItem >= 0)
		{
			((Command)menuItems.elementAt(menuSelectedItem))?.performAction();
		}
	}
}
