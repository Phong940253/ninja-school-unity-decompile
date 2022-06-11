public abstract class Dialog
{
	public Command left;

	public Command center;

	public Command right;

	private int lenCaption;

	public virtual void paint(mGraphics g)
	{
		g.translate(-g.getTranslateX(), -g.getTranslateY());
		g.setClip(0, 0, GameCanvas.w, GameCanvas.h);
		GameCanvas.paintz.paintCmdBar(g, left, center, right);
	}

	public virtual void keyPress(int keyCode)
	{
		switch (keyCode)
		{
		case -38:
		case -1:
			GameCanvas.keyHold[2] = true;
			GameCanvas.keyPressedz[2] = true;
			break;
		case -39:
		case -2:
			GameCanvas.keyHold[8] = true;
			GameCanvas.keyPressedz[8] = true;
			break;
		case -21:
		case -6:
			GameCanvas.keyHold[12] = true;
			GameCanvas.keyPressedz[12] = true;
			break;
		case -22:
		case -7:
			GameCanvas.keyHold[13] = true;
			GameCanvas.keyPressedz[13] = true;
			break;
		case -5:
		case 10:
			GameCanvas.keyHold[5] = true;
			GameCanvas.keyPressedz[5] = true;
			break;
		case 119:
			GameCanvas.keyHold[16] = true;
			GameCanvas.keyPressedz[16] = true;
			break;
		case 115:
			GameCanvas.keyHold[17] = true;
			GameCanvas.keyPressedz[17] = true;
			break;
		case 97:
			GameCanvas.keyHold[18] = true;
			GameCanvas.keyPressedz[18] = true;
			break;
		case 100:
			GameCanvas.keyHold[19] = true;
			GameCanvas.keyPressedz[19] = true;
			break;
		}
	}

	public virtual void update()
	{
		if (center != null && (GameCanvas.keyPressedz[5] || mScreen.getCmdPointerLast(center)))
		{
			GameCanvas.keyPressedz[5] = false;
			GameCanvas.isPointerClick = false;
			mScreen.keyTouch = -1;
			GameCanvas.isPointerJustRelease = false;
			if (center != null)
			{
				center.performAction();
			}
			mScreen.keyTouch = -1;
			Sound.play(Sound.MBClick, 0.5f);
		}
		if (left != null && (GameCanvas.keyPressedz[12] || mScreen.getCmdPointerLast(left)))
		{
			GameCanvas.keyPressedz[12] = false;
			GameCanvas.isPointerClick = false;
			mScreen.keyTouch = -1;
			GameCanvas.isPointerJustRelease = false;
			if (left != null)
			{
				left.performAction();
			}
			mScreen.keyTouch = -1;
			Sound.play(Sound.MBClick, 0.5f);
		}
		if (right != null && (GameCanvas.keyPressedz[13] || mScreen.getCmdPointerLast(right)))
		{
			GameCanvas.keyPressedz[13] = false;
			GameCanvas.isPointerClick = false;
			GameCanvas.isPointerJustRelease = false;
			mScreen.keyTouch = -1;
			if (right != null)
			{
				right.performAction();
			}
			mScreen.keyTouch = -1;
			Sound.play(Sound.MBClick, 0.5f);
		}
		GameCanvas.clearKeyPressed();
		GameCanvas.clearKeyHold();
	}

	public virtual void show()
	{
	}
}
