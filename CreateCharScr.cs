using System;

public class CreateCharScr : mScreen, IActionListener
{
	public static CreateCharScr instance;

	public static TField tAddName;

	public static int indexGender;

	public static int indexHair;

	public static int selected;

	private static int[][] hairID = new int[2][]
	{
		new int[4] { 11, 26, 27, 28 },
		new int[4] { 2, 23, 24, 25 }
	};

	private static int[] defaultLeg = new int[2] { 9, 0 };

	private static int[] defaultBody = new int[2] { 10, 1 };

	private Command cmdGender;

	private Command cmdHair;

	private int curIndex;

	public CreateCharScr()
	{
		if (GameCanvas.w == 128)
		{
			GameScr.setPopupSize(128, 120);
			GameScr.popupX = (GameCanvas.w - 128) / 2;
			GameScr.popupY = 0;
		}
		else
		{
			GameScr.setPopupSize(170, 190);
			GameScr.popupX = (GameCanvas.w - 170) / 2;
			GameScr.popupY = (GameCanvas.h - 220) / 2;
		}
		indexGender = 1;
		tAddName = new TField();
		tAddName.name = mResources.CHARNAME;
		tAddName.width = 100;
		tAddName.x = GameScr.popupX + 45;
		tAddName.x = GameScr.popupX + GameScr.popupW / 2 - tAddName.width / 2;
		tAddName.y = GameScr.popupY + 62;
		if (GameCanvas.w == 128)
		{
			tAddName.width = 60;
		}
		tAddName.height = 26;
		tAddName.isFocus = true;
		tAddName.setIputType(TField.INPUT_TYPE_ANY);
		indexGender = 1;
		indexHair = 0;
		center = new Command(mResources.NEWCHAR, this, 8000, null);
		left = new Command(mResources.BACK, this, 8001, null);
		cmdGender = new Command(string.Empty, this, 8002, null, GameScr.popupX + GameScr.popupW / 2 - mScreen.cmdW / 2, GameScr.popupY + 70 + 30);
		cmdHair = new Command(string.Empty, this, 8003, null, GameScr.popupX + GameScr.popupW / 2 - mScreen.cmdW / 2, GameScr.popupY + 70 + 70);
		right = tAddName.cmdClear;
	}

	public static CreateCharScr gI()
	{
		if (instance == null)
		{
			instance = new CreateCharScr();
		}
		return instance;
	}

	public override void switchToMe()
	{
		indexGender = GameCanvas.gameTick % 2;
		indexHair = GameCanvas.gameTick % 4;
		base.switchToMe();
	}

	public override void keyPress(int keyCode)
	{
		tAddName.keyPressed(keyCode);
	}

	public override void update()
	{
		GameScr.cmx++;
		if (GameScr.cmx > GameCanvas.w * 3 + 100)
		{
			GameScr.cmx = 100;
		}
		if (GameCanvas.isTouch && GameCanvas.w >= 320)
		{
			if (left != null)
			{
				left.x = GameCanvas.w / 2 - 160;
				left.y = GameCanvas.h - 26;
			}
			if (center != null)
			{
				center.x = GameCanvas.w / 2 - 35;
				center.y = GameCanvas.h - 26;
			}
			if (right != null)
			{
				right.x = GameCanvas.w / 2 + 88;
				right.y = GameCanvas.h - 26;
			}
		}
		if (cmdHair != null)
		{
			cmdHair.updatePointer();
		}
		if (cmdGender != null)
		{
			cmdGender.updatePointer();
		}
	}

	public override void updateKey()
	{
		if (GameCanvas.keyPressedz[Key.NUM2])
		{
			selected--;
			if (selected < 0)
			{
				selected = mResources.MENUNEWCHAR.Length - 1;
			}
		}
		if (GameCanvas.keyPressedz[Key.NUM8])
		{
			selected++;
			if (selected >= mResources.MENUNEWCHAR.Length)
			{
				selected = 0;
			}
		}
		if (selected == 0)
		{
			right = tAddName.cmdClear;
			tAddName.update();
		}
		if (selected == 1)
		{
			if (GameCanvas.keyPressedz[Key.NUM4])
			{
				indexGender--;
				if (indexGender < 0)
				{
					indexGender = mResources.MENUGENDER.Length - 1;
				}
			}
			if (GameCanvas.keyPressedz[Key.NUM6])
			{
				indexGender++;
				if (indexGender > mResources.MENUGENDER.Length - 1)
				{
					indexGender = 0;
				}
			}
			right = null;
		}
		if (selected == 2)
		{
			if (GameCanvas.keyPressedz[Key.NUM4])
			{
				indexHair--;
				if (indexHair < 0)
				{
					indexHair = mResources.HAIR_STYLE[0].Length - 1;
				}
			}
			if (GameCanvas.keyPressedz[Key.NUM6])
			{
				indexHair++;
				if (indexHair > mResources.HAIR_STYLE[0].Length - 1)
				{
					indexHair = 0;
				}
			}
		}
		if (GameCanvas.isPointerJustRelease && GameCanvas.isPointerHoldIn(GameScr.popupX + 5, GameScr.popupY + 65, GameScr.popupW - 5, mScreen.ITEM_HEIGHT))
		{
			selected = 0;
		}
		base.updateKey();
		GameCanvas.clearKeyHold();
		GameCanvas.clearKeyPressed();
	}

	public override void paint(mGraphics g)
	{
		int num = 0;
		try
		{
			GameCanvas.paintBGGameScr(g);
			num = 1;
			GameCanvas.paintz.paintFrame(GameScr.popupX, GameScr.popupY, GameScr.popupW, GameScr.popupH, g);
			int num2 = 40;
			if (GameCanvas.w == 128)
			{
				num2 = 20;
			}
			num = 2;
			int num3 = hairID[indexGender][indexHair];
			int num4 = defaultLeg[indexGender];
			int num5 = defaultBody[indexGender];
			num = 3;
			Part part = GameScr.parts[num3];
			Part part2 = GameScr.parts[num4];
			Part part3 = GameScr.parts[num5];
			int num6 = GameCanvas.w / 2;
			int num7 = GameScr.popupY + 50;
			num = 4;
			SmallImage.drawSmallImage(g, part2.pi[Char.CharInfo[0][1][0]].id, num6 + Char.CharInfo[0][1][1] + part2.pi[Char.CharInfo[0][1][0]].dx, num7 - Char.CharInfo[0][1][2] + part2.pi[Char.CharInfo[0][1][0]].dy, 0, 0);
			SmallImage.drawSmallImage(g, part3.pi[Char.CharInfo[0][2][0]].id, num6 + Char.CharInfo[0][2][1] + part3.pi[Char.CharInfo[0][2][0]].dx, num7 - Char.CharInfo[0][2][2] + part3.pi[Char.CharInfo[0][2][0]].dy, 0, 0);
			SmallImage.drawSmallImage(g, part.pi[Char.CharInfo[0][0][0]].id, num6 + Char.CharInfo[0][0][1] + part.pi[Char.CharInfo[0][0][0]].dx, num7 - Char.CharInfo[0][0][2] + part.pi[Char.CharInfo[0][0][0]].dy, 0, 0);
			num = 5;
			if (!GameCanvas.isTouch)
			{
				for (int i = 0; i < mResources.MENUNEWCHAR.Length; i++)
				{
					int num8 = ((i > 0) ? (-5) : 0);
					if (selected == i)
					{
						SmallImage.drawSmallImage(g, 989, GameScr.popupX + 10 + ((GameCanvas.gameTick % 7 > 3) ? 1 : 0), GameScr.popupY + 76 + i * num2 + num8, 2, StaticObj.VCENTER_HCENTER);
						SmallImage.drawSmallImage(g, 989, GameScr.popupX + GameScr.popupW - 15 - ((GameCanvas.gameTick % 7 > 3) ? 1 : 0), GameScr.popupY + 76 + i * num2 + num8, 0, StaticObj.VCENTER_HCENTER);
					}
				}
			}
			num = 6;
			num = 7;
			if (GameCanvas.isTouch)
			{
				cmdGender.caption = mResources.MENUGENDER[indexGender];
				cmdGender.paint(g);
				cmdHair.caption = mResources.HAIR_STYLE[indexGender][indexHair];
				cmdHair.paint(g);
			}
			else
			{
				GameCanvas.paintz.paintFrameBorder(cmdGender.x, cmdGender.y, cmdGender.w, cmdGender.h, g);
				if (selected == 1)
				{
					g.setColor(Paint.COLORLIGHT);
					g.fillRect(cmdGender.x, cmdGender.y, cmdGender.w, cmdGender.h);
					GameCanvas.paintz.paintFrameBorder(cmdGender.x, cmdGender.y, cmdGender.w, cmdGender.h, g);
				}
				GameCanvas.paintz.paintFrameBorder(cmdHair.x, cmdHair.y, cmdHair.w, cmdHair.h, g);
				if (selected == 2)
				{
					g.setColor(Paint.COLORLIGHT);
					g.fillRect(cmdHair.x, cmdHair.y, cmdHair.w, cmdHair.h);
					GameCanvas.paintz.paintFrameBorder(cmdHair.x, cmdHair.y, cmdHair.w, cmdHair.h, g);
				}
				mFont.tahoma_7b_white.drawString(g, mResources.MENUGENDER[indexGender], GameScr.popupX + 85, GameScr.popupY + 66 + num2, mFont.CENTER);
				mFont.tahoma_7b_white.drawString(g, mResources.HAIR_STYLE[indexGender][indexHair], GameScr.popupX + 85, GameScr.popupY + 66 + 2 * num2, mFont.CENTER);
			}
			tAddName.x = GameScr.popupX + GameScr.popupW / 2 - tAddName.width / 2;
			tAddName.y = GameScr.popupY + 62;
			tAddName.title_Null = mResources.CHARNAME;
			tAddName.paint(g);
			base.paint(g);
			g.setColor(0);
		}
		catch (Exception)
		{
			Out.println("CreateCharScr.paint(): " + num);
		}
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		case 8000:
			Service.gI().createChar(tAddName.getText(), indexGender, hairID[indexGender][indexHair]);
			break;
		case 8001:
			if (SelectCharScr.gI().isNullChar)
			{
				GameCanvas.selectsvScr.switchToMe();
			}
			else
			{
				SelectCharScr.gI().switchToMe();
			}
			break;
		case 8002:
			curIndex = 1;
			selected = 1;
			if (curIndex == selected)
			{
				indexGender--;
				if (indexGender < 0)
				{
					indexGender = mResources.MENUGENDER.Length - 1;
				}
			}
			break;
		case 8003:
			curIndex = 2;
			selected = 2;
			if (curIndex == selected)
			{
				indexHair++;
				if (indexHair > mResources.HAIR_STYLE[0].Length - 1)
				{
					indexHair = 0;
				}
			}
			break;
		}
	}
}
