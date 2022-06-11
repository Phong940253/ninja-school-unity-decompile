public class Command
{
	public string caption;

	public string[] subCaption;

	public ActionChat actionChat;

	public IActionListener actionListener;

	public int idAction;

	public Image back;

	public Image focus;

	public Image img;

	public int x;

	public int y;

	public int w = mScreen.cmdW;

	public int h = mScreen.cmdH;

	private int lenCaption;

	private bool isFocus;

	public object p;

	public Command(string caption, IActionListener actionListener, int action, object p, int x, int y)
	{
		this.caption = caption;
		idAction = action;
		this.actionListener = actionListener;
		this.p = p;
		this.x = x;
		this.y = y;
		w = mScreen.cmdW;
		h = mScreen.cmdH;
		back = null;
		focus = null;
	}

	public Command()
	{
	}

	public Command(string caption)
	{
		this.caption = caption;
	}

	public Command(string caption, IActionListener actionListener, int action, object p)
	{
		this.caption = caption;
		idAction = action;
		this.actionListener = actionListener;
		this.p = p;
	}

	public Command(string caption, int action, object p)
	{
		this.caption = caption;
		idAction = action;
		this.p = p;
	}

	public Command(string caption, int action)
	{
		this.caption = caption;
		idAction = action;
	}

	public Command(string caption, int action, int x, int y)
	{
		this.caption = caption;
		idAction = action;
		this.x = x;
		this.y = y;
	}

	public void perform(string str)
	{
		if (actionChat != null)
		{
			actionChat(str);
		}
	}

	public void setpos(int x, int y)
	{
		this.x = x;
		this.y = y;
	}

	public void performAction()
	{
		if (idAction > 0)
		{
			if (actionListener != null)
			{
				actionListener.perform(idAction, p);
			}
			else
			{
				GameScr.gI().actionPerform(idAction, p);
			}
		}
	}

	public void performAction(string str)
	{
		if (idAction > 0)
		{
			if (actionListener != null)
			{
				actionListener.perform(idAction, p);
			}
			else
			{
				GameScr.gI().actionPerform(idAction, p);
			}
		}
	}

	public void paint(mGraphics g)
	{
		if (back != null)
		{
			g.drawImage(back, x, y, 0);
		}
		if (focus != null && isFocus)
		{
			g.drawImage(focus, x, y, 0);
		}
		if (img != null)
		{
			g.drawImage(img, x + mGraphics.getImageWidth(img) / 2, y + mGraphics.getImageHeight(img) / 2, mGraphics.HCENTER | mGraphics.VCENTER);
		}
		else if (caption != string.Empty)
		{
			if (!isFocus)
			{
				g.drawImage(GameScr.imgLbtn, x, y, 0);
			}
			else
			{
				g.drawImage(GameScr.imgLbtnFocus, x, y, 0);
			}
			mFont.tahoma_7b_yellow.drawString(g, caption, x + 36, y + 3, 2);
		}
	}

	public bool input()
	{
		if (GameCanvas.isPointerHoldIn(x - 3, y - 3, w + 6, h + 6))
		{
			isFocus = true;
			if (GameCanvas.isPointerJustRelease && GameCanvas.isPointerClick)
			{
				Sound.play(Sound.MBClick, 0.5f);
				return true;
			}
		}
		else
		{
			isFocus = false;
		}
		return false;
	}

	public bool isPosCmd()
	{
		if (x > 0 && y > 0)
		{
			return true;
		}
		return false;
	}

	public void updatePointer()
	{
		if (isPosCmd() && input())
		{
			performAction();
			GameCanvas.isPointerDown = false;
			isFocus = false;
		}
	}
}
