public class Input2Dlg : Dialog, IActionListener
{
	protected string[] info;

	public TField tfInput;

	public TField tfInput2;

	private int padLeft;

	private int focus;

	private int line;

	private int titleLenght;

	public Command cmdClose = new Command(string.Empty, 1000, null);

	public Input2Dlg()
	{
		tfInput = new TField();
		tfInput2 = new TField();
	}

	public void setTitle(string title, string title2)
	{
		titleLenght = ((mFont.tahoma_8b.getWidth(title) <= mFont.tahoma_8b.getWidth(title2)) ? mFont.tahoma_8b.getWidth(title2) : mFont.tahoma_8b.getWidth(title));
		padLeft = 40;
		focus = 0;
		if (GameCanvas.w <= 176)
		{
			padLeft = 10;
		}
		tfInput.x = padLeft + titleLenght + 10;
		tfInput.y = GameCanvas.h - 2 * mScreen.ITEM_HEIGHT - 50;
		tfInput.width = GameCanvas.w - 2 * padLeft - titleLenght - 20;
		tfInput.height = mScreen.ITEM_HEIGHT + 2;
		tfInput.isFocus = true;
		tfInput.title = title;
		tfInput2.x = padLeft + titleLenght + 10;
		tfInput2.y = GameCanvas.h - mScreen.ITEM_HEIGHT - 43;
		tfInput2.width = GameCanvas.w - 2 * padLeft - titleLenght - 20;
		tfInput2.height = mScreen.ITEM_HEIGHT + 2;
		tfInput2.title = title2;
		right = tfInput.cmdClear;
	}

	public void show(string info, Command left, Command ok, int type1, int type2)
	{
		tfInput.setText(string.Empty);
		tfInput.setIputType(type1);
		tfInput2.setText(string.Empty);
		tfInput2.setIputType(type2);
		this.info = mFont.tahoma_8b.splitFontArray(info, GameCanvas.w - padLeft * 3);
		MyVector myVector = mFont.tahoma_8b.splitFontVector(info, GameCanvas.w - padLeft * 3);
		line = myVector.size();
		Out.println("line value:" + line);
		base.left = left;
		center = ok;
		show();
	}

	public override void paint(mGraphics g)
	{
		GameCanvas.paintz.paintInputDlg(g, padLeft, GameCanvas.h - 85 - mScreen.cmdH - line * 13, GameCanvas.w - padLeft * 2, 80 + line * 13, info, GameCanvas.testCapcha);
		mFont.tahoma_8b.drawString(g, tfInput.title + ": ", tfInput.x - titleLenght - 5, tfInput.y + 2, 0);
		tfInput.paint(g);
		g.setClip(0, 0, GameCanvas.w, GameCanvas.h);
		mFont.tahoma_8b.drawString(g, tfInput2.title + ": ", tfInput2.x - titleLenght - 5, tfInput2.y + 2, 0);
		tfInput2.paint(g);
		base.paint(g);
	}

	public override void keyPress(int keyCode)
	{
		if (focus == 0)
		{
			tfInput.keyPressed(keyCode);
		}
		else
		{
			tfInput2.keyPressed(keyCode);
		}
		base.keyPress(keyCode);
	}

	public override void update()
	{
		if (GameCanvas.keyPressedz[2])
		{
			focus = 0;
		}
		if (GameCanvas.keyPressedz[8])
		{
			focus = 1;
		}
		if (focus == 0)
		{
			tfInput.isFocus = true;
			tfInput2.isFocus = false;
			if (Main.isPC)
			{
				right = tfInput.cmdClear;
			}
			tfInput.update();
		}
		else
		{
			tfInput.isFocus = false;
			tfInput2.isFocus = true;
			if (Main.isPC)
			{
				right = tfInput2.cmdClear;
			}
			tfInput2.update();
		}
		if (GameCanvas.isTouch && GameCanvas.isPointerJustRelease && GameCanvas.isPointerClick)
		{
			if (GameCanvas.isPointerHoldIn(tfInput.x, tfInput.y, tfInput.width, tfInput.height))
			{
				focus = 0;
			}
			if (GameCanvas.isPointerHoldIn(tfInput2.x, tfInput2.y, tfInput2.width, tfInput2.height))
			{
				focus = 1;
			}
		}
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
		base.update();
	}

	public override void show()
	{
		GameCanvas.currentDialog = this;
	}

	public void hide()
	{
		GameCanvas.endDlg();
	}

	public void perform(int idAction, object p)
	{
	}
}
