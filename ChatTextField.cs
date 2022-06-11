public class ChatTextField : IActionListener
{
	private static ChatTextField instance;

	public TField tfChat;

	public bool isShow;

	public IChatable parentScreen;

	private long lastChatTime;

	public Command left;

	public Command right;

	public Command cmdChat;

	public Command cmdFireChat;

	public Command center;

	private string to;

	private bool isPublic;

	protected ChatTextField()
	{
		left = new Command(mResources.CHAT, this, 8000, null, 1, GameCanvas.h - mScreen.cmdH + 1);
		right = new Command(mResources.DELETE, this, 8001, null, GameCanvas.w - 72, GameCanvas.h - mScreen.cmdH - 2);
		tfChat = new TField();
		cmdFireChat = new Command(mResources.CHAT, this, 8002, null, 1, GameCanvas.h - mScreen.cmdH + 1);
		tfChat.x = 16;
		tfChat.width = GameCanvas.instance.getWidth() / mGraphics.zoomLevel - 32;
		tfChat.height = mScreen.ITEM_HEIGHT + 2;
		tfChat.setMaxTextLenght(40);
		tfChat.showSubTextField = false;
		tfChat.setText(string.Empty);
		tfChat.setIputType(TField.INPUT_TYPE_ANY);
		cmdChat = new Command();
		ActionChat actionChat = delegate(string str)
		{
			tfChat.justReturnFromTextBox = false;
			parentScreen.onChatFromMe(str, to);
			tfChat.setText(string.Empty);
			right.caption = mResources.CLOSE;
		};
		if (Main.isPC)
		{
			left = null;
		}
		cmdChat.actionChat = actionChat;
	}

	public void keyPressed(int keyCode)
	{
		if (isShow)
		{
			tfChat.keyPressed(keyCode);
		}
		if (!Main.isPC)
		{
			if (tfChat.getText().Equals(string.Empty))
			{
				right.caption = mResources.CLOSE;
			}
			else
			{
				right.caption = mResources.DELETE;
			}
		}
		else
		{
			right.caption = mResources.CLOSE;
		}
	}

	public void close()
	{
		tfChat.setText(string.Empty);
		isShow = false;
	}

	public static ChatTextField gI()
	{
		return (instance != null) ? instance : (instance = new ChatTextField());
	}

	public void startChat(int firstCharacter, IChatable parentScreen, string to)
	{
		right.caption = mResources.CLOSE;
		this.to = to;
		tfChat.keyPressed(firstCharacter);
		if (!tfChat.getText().Equals(string.Empty) && GameCanvas.currentDialog == null)
		{
			this.parentScreen = parentScreen;
			isShow = true;
		}
		tfChat.setText(string.Empty);
		tfChat.title_Null = to;
		tfChat.isFocus = true;
		tfChat.clearAll();
	}

	public void keyPresbs(int keyCode)
	{
		if (tfChat.isFocus)
		{
			tfChat.keyPressed(keyCode);
		}
	}

	public void startChat(IChatable parentScreen, string to)
	{
		right.caption = mResources.CLOSE;
		this.to = to;
		if (GameCanvas.currentDialog == null)
		{
			isShow = true;
			if (!Main.isPC)
			{
				ipKeyboard.openKeyBoard("chat", ipKeyboard.TEXT, string.Empty, cmdChat);
			}
		}
		tfChat.setText(string.Empty);
		tfChat.title_Null = to;
		tfChat.clearAll();
		isPublic = false;
	}

	public void startChatPC(IChatable parentScreen, string to, bool isPublic)
	{
		GameCanvas.clearKeyHold();
		GameCanvas.clearKeyPressed();
		right.caption = mResources.CLOSE;
		this.to = to;
		if (GameCanvas.currentDialog == null)
		{
			isShow = true;
		}
		tfChat.setText(string.Empty);
		tfChat.title_Null = to;
		tfChat.clearAll();
		this.isPublic = isPublic;
	}

	public void update()
	{
		if (isShow)
		{
			if (Main.isPC)
			{
				tfChat.update();
				tfChat.isFocus = true;
			}
			if (tfChat.justReturnFromTextBox)
			{
				tfChat.justReturnFromTextBox = false;
				parentScreen.onChatFromMe(tfChat.getText(), to);
				tfChat.setText(string.Empty);
				right.caption = mResources.CLOSE;
			}
		}
	}

	public void paint(mGraphics g)
	{
		g.setClip(0, -200, GameCanvas.w, 200 + GameCanvas.h);
		if (isShow && Main.isPC)
		{
			tfChat.paint(g);
		}
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		case 8000:
			if (parentScreen != null)
			{
				long currentTimeMillis2 = mSystem.getCurrentTimeMillis();
				if (currentTimeMillis2 - lastChatTime >= 1000)
				{
					lastChatTime = currentTimeMillis2;
					parentScreen.onChatFromMe(tfChat.getText(), to);
					tfChat.setText(string.Empty);
					tfChat.clearAll();
					right.caption = mResources.CLOSE;
				}
			}
			break;
		case 8001:
			if (!Main.isPC)
			{
				tfChat.clear();
				if (tfChat.getText().Equals(string.Empty))
				{
					isShow = false;
					parentScreen.onCancelChat();
				}
			}
			else
			{
				tfChat.clearAll();
				isShow = false;
				parentScreen.onCancelChat();
			}
			break;
		case 8002:
			if (parentScreen != null)
			{
				long currentTimeMillis = mSystem.getCurrentTimeMillis();
				if (currentTimeMillis - lastChatTime < 1000)
				{
					break;
				}
				lastChatTime = currentTimeMillis;
				parentScreen.onChatFromMe(tfChat.getText(), to);
				tfChat.setText(string.Empty);
				tfChat.clearAll();
				tfChat.isFocus = false;
			}
			if (isPublic)
			{
				right.performAction();
			}
			break;
		}
	}
}
