public class ChatTab
{
	public int type;

	public string ownerName;

	public MyVector contents = new MyVector();

	public ChatTab(string ownerName, int type)
	{
		this.ownerName = ownerName;
		this.type = type;
	}

	public void addChat(string whoChat, string text)
	{
		bool flag = false;
		if (GameScr.isPaintMessage && ChatManager.gI().getCurrentChatTab() == this && GameScr.indexRow == contents.size() - 1)
		{
			flag = true;
		}
		contents.addElement("c3@" + whoChat);
		MyVector myVector = mFont.tahoma_7_white.splitFontVector(text, 160);
		for (int i = 0; i < myVector.size(); i++)
		{
			contents.addElement("c0" + myVector.elementAt(i));
		}
		if (flag)
		{
			GameScr.gI().scrollDownAlert();
		}
		clear();
	}

	private void clear()
	{
		while (contents.size() > 50)
		{
			contents.removeElementAt(1);
		}
	}

	public void addInfo(string text)
	{
		bool flag = false;
		if (GameScr.isPaintMessage && ChatManager.gI().getCurrentChatTab() == this && GameScr.indexRow == contents.size() - 1)
		{
			flag = true;
		}
		MyVector myVector = mFont.tahoma_7_white.splitFontVector(text, 170);
		for (int i = 0; i < myVector.size(); i++)
		{
			contents.addElement(myVector.elementAt(i));
		}
		if (flag)
		{
			GameScr.gI().scrollDownAlert();
		}
		clear();
	}
}
