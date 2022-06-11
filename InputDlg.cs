public class InputDlg : Dialog
{
	protected string[] info;

	public TField tfInput;

	private int padLeft;

	public InputDlg()
	{
		padLeft = 40;
		if (GameCanvas.w <= 176)
		{
			padLeft = 10;
		}
		tfInput = new TField();
		tfInput.x = padLeft + 10;
		tfInput.y = GameCanvas.h - mScreen.ITEM_HEIGHT - 43;
		tfInput.width = GameCanvas.w - 2 * (padLeft + 10);
		tfInput.height = mScreen.ITEM_HEIGHT + 2;
		tfInput.isFocus = true;
		right = tfInput.cmdClear;
	}

	public void show(string info, Command ok, int type)
	{
		tfInput.setText(string.Empty);
		tfInput.setIputType(type);
		this.info = mFont.tahoma_8b.splitFontArray(info, GameCanvas.w - padLeft * 2);
		left = new Command(mResources.CLOSE, GameCanvas.gI(), 8882, null);
		center = ok;
		show();
	}

	public override void paint(mGraphics g)
	{
		GameCanvas.paintz.paintInputDlg(g, padLeft, GameCanvas.h - 77 - mScreen.cmdH, GameCanvas.w - padLeft * 2, 69, info, GameCanvas.testCapcha);
		tfInput.paint(g);
		base.paint(g);
	}

	public override void keyPress(int keyCode)
	{
		tfInput.keyPressed(keyCode);
		base.keyPress(keyCode);
	}

	public override void update()
	{
		tfInput.update();
		base.update();
	}

	public override void show()
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
		GameCanvas.currentDialog = this;
	}

	public void hide()
	{
		GameCanvas.endDlg();
	}
}
