public class ChatManager
{
	public MyVector chatTabs;

	public int isNewMessage;

	private static ChatManager instance;

	public int currentTabIndex;

	public static bool blockGlobalChat;

	public static bool blockPrivateChat;

	public static bool isMessageClan;

	public static bool isMessagePt;

	public MyVector waitList = new MyVector();

	public ChatManager()
	{
		chatTabs = new MyVector();
		chatTabs.addElement(new ChatTab(mResources.PUBLICCHAT[0], 0));
		chatTabs.addElement(new ChatTab(mResources.PARTYCHAT[0], 1));
		chatTabs.addElement(new ChatTab(mResources.GLOBALCHAT[0], 3));
		chatTabs.addElement(new ChatTab(mResources.CLANCHAT[0], 4));
		ChatTab chatTab = findTab(mResources.GLOBALCHAT[0]);
		chatTab.addInfo("c8" + mResources.GLOBALCHAT[1]);
		chatTab.addInfo("c8" + mResources.GLOBALCHAT[2]);
		chatTab.addInfo("c8" + mResources.GLOBALCHAT[3]);
		ChatTab chatTab2 = findTab(mResources.PARTYCHAT[0]);
		chatTab2.addInfo("c8" + mResources.PARTYCHAT[1]);
		ChatTab chatTab3 = findTab(mResources.CLANCHAT[0]);
		chatTab3.addInfo("c8" + mResources.CLANCHAT[1]);
		ChatTab chatTab4 = findTab(mResources.PUBLICCHAT[0]);
		chatTab4.addInfo("c8" + mResources.PUBLICCHAT[1]);
	}

	public void switchToNextTab()
	{
		currentTabIndex++;
		if (currentTabIndex > chatTabs.size() - 1)
		{
			currentTabIndex = 0;
		}
	}

	public void switchToPreviousTab()
	{
		currentTabIndex--;
		if (currentTabIndex < 0)
		{
			currentTabIndex = chatTabs.size() - 1;
		}
	}

	public void switchToTab(int index)
	{
		currentTabIndex = index;
	}

	public void switchToTab(ChatTab t)
	{
		currentTabIndex = chatTabs.indexOf(t);
	}

	public void switchToLastTab()
	{
		currentTabIndex = chatTabs.size() - 1;
	}

	public bool findWaitPerson(string nick)
	{
		for (int i = 0; i < waitList.size(); i++)
		{
			if (((string)waitList.elementAt(i)).Equals(nick))
			{
				return true;
			}
		}
		return false;
	}

	public static ChatManager gI()
	{
		return (instance != null) ? instance : (instance = new ChatManager());
	}

	public ChatTab findTab(string ownerName)
	{
		for (int i = 0; i < chatTabs.size(); i++)
		{
			ChatTab chatTab = (ChatTab)chatTabs.elementAt(i);
			if (chatTab.ownerName.Equals(ownerName))
			{
				return chatTab;
			}
		}
		return null;
	}

	public void addChat(string ownerName, string whoChat, string text)
	{
		ChatTab chatTab = findTab(ownerName);
		if (chatTab == null)
		{
			chatTab = addNewTab(ownerName);
		}
		chatTab.addChat(whoChat, text);
	}

	public void addPublicInfo(string text)
	{
		findTab(mResources.PUBLICCHAT[0])?.addInfo(text);
	}

	public ChatTab getCurrentChatTab()
	{
		return (ChatTab)chatTabs.elementAt(currentTabIndex);
	}

	public ChatTab addNewTab(string friendName)
	{
		ChatTab chatTab = new ChatTab(friendName, 2);
		if (!GameCanvas.isTouch)
		{
			chatTab.addInfo("c2" + mResources.CLOSE_CURTAB);
		}
		chatTabs.addElement(chatTab);
		return chatTab;
	}

	public void addWaitList(string nick)
	{
		for (int i = 0; i < waitList.size(); i++)
		{
			if (((string)waitList.elementAt(i)).Equals(nick))
			{
				return;
			}
		}
		waitList.addElement(nick);
	}

	public int postWaitPerson()
	{
		int result = -1;
		for (int i = 3; i < chatTabs.size(); i++)
		{
			ChatTab chatTab = (ChatTab)chatTabs.elementAt(i);
			for (int j = 0; j < waitList.size(); j++)
			{
				if (chatTab.ownerName.Equals(waitList.elementAt(j).ToString()))
				{
					return i;
				}
			}
		}
		return result;
	}

	public void removeFromWaitList(string nick)
	{
		for (int i = 0; i < waitList.size(); i++)
		{
			if (((string)waitList.elementAt(i)).Equals(nick))
			{
				waitList.removeElementAt(i);
				break;
			}
		}
	}

	public void clear()
	{
		instance = null;
	}
}
