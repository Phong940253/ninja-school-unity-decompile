using System;

public class Service
{
	private ISession session = Session_ME.gI();

	protected static Service instance;

	private int xx;

	private int yy;

	public const sbyte KHAMNGOC = 0;

	public const sbyte LUYENNGOC = 1;

	public const sbyte GOTNGOC = 2;

	public const sbyte THAONGOC = 3;

	public static Service gI()
	{
		if (instance == null)
		{
			instance = new Service();
		}
		return instance;
	}

	public void chatClan(string text)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)(-19));
			message.writer().writeUTF(text);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void clearTask()
	{
		Message message = null;
		try
		{
			message = messageNotMap(-98);
			session.sendMessage(message);
		}
		catch (Exception)
		{
		}
		finally
		{
			message.cleanup();
		}
	}

	public void clanPlease(int charId)
	{
		Message message = null;
		try
		{
			message = messageSubCommand(-61);
			message.writer().writeInt(charId);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void acceptInviteClan(int playerMapId)
	{
		Message message = null;
		try
		{
			message = messageSubCommand(-62);
			message.writer().writeInt(playerMapId);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void clanInvite(int charId)
	{
		Message message = null;
		try
		{
			message = messageSubCommand(-63);
			message.writer().writeInt(charId);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void requestClanInfo()
	{
		Message message = null;
		try
		{
			message = messageNotMap(-113);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public Message messageNotLogin(sbyte command)
	{
		Message message = new Message((sbyte)(-29));
		message.writer().writeByte(command);
		return message;
	}

	public Message messageNotMap(sbyte command)
	{
		Message message = new Message((sbyte)(-28));
		message.writer().writeByte(command);
		return message;
	}

	public void changeName(string name, int id)
	{
		Message message = null;
		try
		{
			message = messageNotMap(-97);
			message.writer().writeInt(id);
			message.writer().writeUTF(name);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void requestIcon(int id)
	{
		Message message = null;
		try
		{
			message = messageNotMap(-115);
			message.writer().writeInt(id);
			session.sendMessage(message);
		}
		catch (Exception)
		{
		}
		finally
		{
			message.cleanup();
		}
	}

	public static Message messageSubCommand(sbyte command)
	{
		Message message = new Message((sbyte)(-30));
		message.writer().writeByte(command);
		return message;
	}

	public void setClientType()
	{
		try
		{
			Message message = messageNotLogin(-125);
			GameMidlet.CLIENT_TYPE = 4;
			if (mGraphics.zoomLevel == 1)
			{
				GameMidlet.CLIENT_TYPE = 0;
			}
			if (!Main.isPC)
			{
				if (Main.isWp)
				{
					GameMidlet.CLIENT_TYPE = 6;
				}
				else if (Main.IphoneVersionApp)
				{
					GameMidlet.CLIENT_TYPE = 5;
				}
				else
				{
					GameMidlet.CLIENT_TYPE = 3;
				}
			}
			message.writer().writeByte(GameMidlet.CLIENT_TYPE);
			message.writer().writeByte(mGraphics.zoomLevel);
			message.writer().writeBoolean(GameCanvas.isGPRS);
			message.writer().writeInt(GameCanvas.w);
			message.writer().writeInt(GameCanvas.h);
			message.writer().writeBoolean(TField.isQwerty);
			message.writer().writeBoolean(GameCanvas.isTouch);
			message.writer().writeUTF("iphone platform xxx");
			if (!Main.isPC)
			{
				message.writer().writeInt(Main.versionIp);
			}
			else
			{
				message.writer().writeInt(0);
			}
			message.writer().writeByte(0);
			message.writer().writeByte(mResources.languageID);
			message.writer().writeInt(GameMidlet.userProvider);
			message.writer().writeUTF(GameMidlet.clientAgent);
			session.sendMessage(message);
			message.cleanup();
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
	}

	public void adminMove(int mapId)
	{
		Message message = null;
		try
		{
			message = messageSubCommand(-70);
			message.writer().writeByte(mapId);
			session.sendMessage(message);
		}
		catch (Exception)
		{
		}
		finally
		{
			message.cleanup();
		}
	}

	public void requestClanMember()
	{
		Message message = null;
		try
		{
			message = messageNotMap(-112);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void login(string username, string pass, string version)
	{
		gI().setClientType();
		try
		{
			Message message = messageNotLogin(-127);
			message.writer().writeUTF(username);
			message.writer().writeUTF(pass);
			message.writer().writeUTF(version);
			message.writer().writeUTF(string.Empty);
			message.writer().writeUTF(string.Empty);
			message.writer().writeUTF(RMS.loadRMSString("random"));
			message.writer().writeByte(GameMidlet.serverLogin);
			session.sendMessage(message);
			message.cleanup();
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
	}

	public void requestRegisterNew(string username, string pass, string email)
	{
		try
		{
			Message message = new Message((sbyte)118);
			message.writer().writeUTF(username);
			message.writer().writeUTF(pass);
			message.writer().writeUTF(email);
			session.sendMessage(message);
			message.cleanup();
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
	}

	public void requestForgetPass(string username)
	{
		try
		{
			Message message = messageNotLogin(-122);
			message.writer().writeUTF(username);
			session.sendMessage(message);
			message.cleanup();
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
	}

	public void requestForgetPassByIMEI(string username, string IMEI, string newpass)
	{
		try
		{
			Message message = messageNotLogin(-121);
			message.writer().writeUTF(username);
			message.writer().writeUTF(IMEI);
			message.writer().writeUTF(newpass);
			session.sendMessage(message);
			message.cleanup();
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
	}

	public void requestChangeMap()
	{
		Message message = new Message((sbyte)(-17));
		session.sendMessage(message);
		message.cleanup();
	}

	public void requestChangeZone(int zoneId, int indexUI)
	{
		Message message = new Message((sbyte)28);
		try
		{
			message.writer().writeByte(zoneId);
			message.writer().writeByte(indexUI);
			session.sendMessage(message);
			message.cleanup();
		}
		catch (Exception)
		{
		}
	}

	public void charMove(string pos, int xSend, int ySend)
	{
		try
		{
			if (xSend - xx != 0 || ySend - yy != 0)
			{
				Message message = new Message((sbyte)1);
				message.writer().writeShort(xSend);
				message.writer().writeShort(ySend);
				xx = xSend;
				yy = ySend;
				session.sendMessage(message);
				message.cleanup();
			}
		}
		catch (Exception)
		{
		}
	}

	public void selectCharToPlay(string charname)
	{
		Message message = new Message((sbyte)(-28));
		try
		{
			message.writer().writeByte((sbyte)(-126));
			message.writer().writeUTF(charname);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		session.sendMessage(message);
	}

	public void selectZone(sbyte sub, int value)
	{
	}

	public void createChar(string name, int gender, int hair)
	{
		Message message = new Message((sbyte)(-28));
		try
		{
			message.writer().writeByte((sbyte)(-125));
			message.writer().writeUTF(name);
			message.writer().writeByte(gender);
			message.writer().writeByte(hair);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		session.sendMessage(message);
	}

	public void requestModTemplate(int modTemplateId)
	{
		Message message = null;
		try
		{
			message = messageNotMap(-108);
			message.writer().writeByte(modTemplateId);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void requestNpcTemplate(int npcTemplateId)
	{
		Message message = null;
		try
		{
			message = messageNotMap(-107);
			message.writer().writeByte(npcTemplateId);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void requestSkill(int skillId)
	{
		Message message = null;
		try
		{
			message = messageNotMap(-110);
			message.writer().writeShort(skillId);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void requestItemInfo(int typeUI, int indexUI)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)42);
			message.writer().writeByte(typeUI);
			message.writer().writeByte(indexUI);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void requestItemPlayer(int charId, int indexUI)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)94);
			message.writer().writeInt(charId);
			message.writer().writeByte(indexUI);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void upPotential(int index, int point)
	{
		Message message = null;
		try
		{
			message = messageSubCommand(-109);
			message.writer().writeByte(index);
			message.writer().writeShort(point);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void upSkill(int skillTemplateId, int point)
	{
		Message message = null;
		try
		{
			message = messageSubCommand(-108);
			message.writer().writeShort(skillTemplateId);
			message.writer().writeByte(point);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void itemBodyToBag(int indexUI)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)15);
			message.writer().writeByte(indexUI);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void itemMonToBag(int indexUI)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)108);
			message.writer().writeByte(indexUI);
			session.sendMessage(message);
		}
		catch (Exception)
		{
		}
		finally
		{
			message.cleanup();
		}
	}

	public void itemBoxToBag(int indexUI)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)16);
			message.writer().writeByte(indexUI);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void itemBagToBox(int indexUI)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)17);
			message.writer().writeByte(indexUI);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void useItem(int indexUI)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)11);
			message.writer().writeByte(indexUI);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
		if (Char.getMyChar().arrItemBag[indexUI] != null && Char.getMyChar().arrItemBag[indexUI].template.type == 24)
		{
			GameScr.gI().resetButton();
			InfoDlg.showWait(string.Empty);
		}
	}

	public void saleItem(int indexUI, int quantity)
	{
		GameCanvas.msgdlg.pleasewait();
		Message message = null;
		try
		{
			message = new Message((sbyte)14);
			message.writer().writeByte(indexUI);
			if (quantity > 1)
			{
				message.writer().writeShort(quantity);
			}
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void buyItem(int typeUI, int indexUI, int quantity)
	{
		GameCanvas.msgdlg.pleasewait();
		Message message = null;
		try
		{
			message = new Message((sbyte)13);
			message.writer().writeByte(typeUI);
			message.writer().writeByte(indexUI);
			if (quantity > 1)
			{
				message.writer().writeShort(quantity);
			}
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void selectSkill(int skillTemplateId)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)41);
			message.writer().writeShort(skillTemplateId);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void openFindParty()
	{
		Message message = null;
		try
		{
			message = messageSubCommand(-77);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void openUIZone()
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)36);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void useItemChangeMap(int indexUI, int indexMenu)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)12);
			message.writer().writeByte(indexUI);
			message.writer().writeByte(indexMenu);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void openMenu(int npcId)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)40);
			message.writer().writeShort(npcId);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void menu(int npcId, int menuId, int optionId)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)29);
			message.writer().writeByte(npcId);
			message.writer().writeByte(menuId);
			message.writer().writeByte(optionId);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void menuId(short menuId)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)34);
			message.writer().writeShort(menuId);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void textBoxId(short menuId, string str)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)92);
			message.writer().writeShort(menuId);
			message.writer().writeUTF(str);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void requestItem(int typeUI)
	{
		Message message = null;
		try
		{
			message = messageSubCommand(-103);
			message.writer().writeByte(typeUI);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void bagSort()
	{
		Message message = null;
		try
		{
			message = messageSubCommand(-107);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void boxSort()
	{
		Message message = null;
		try
		{
			message = messageSubCommand(-106);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void boxCoinIn(int coinIn)
	{
		Message message = null;
		try
		{
			message = messageSubCommand(-105);
			message.writer().writeInt(coinIn);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void boxCoinOut(int coinOut)
	{
		Message message = null;
		try
		{
			message = messageSubCommand(-104);
			message.writer().writeInt(coinOut);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void crystalCollect(Item[] items)
	{
		GameCanvas.msgdlg.pleasewait();
		Message message = null;
		try
		{
			message = new Message((sbyte)19);
			for (int i = 0; i < items.Length; i++)
			{
				if (items[i] != null)
				{
					message.writer().writeByte(items[i].indexUI);
				}
			}
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void upgradeItem(Item item, Item[] items, bool isGold)
	{
		GameCanvas.msgdlg.pleasewait();
		Message message = null;
		try
		{
			message = new Message((sbyte)21);
			message.writer().writeBoolean(isGold);
			message.writer().writeByte(item.indexUI);
			for (int i = 0; i < items.Length; i++)
			{
				if (items[i] != null)
				{
					message.writer().writeByte(items[i].indexUI);
				}
			}
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void crystalCollectLock(Item[] items)
	{
		GameCanvas.msgdlg.pleasewait();
		Message message = null;
		try
		{
			message = new Message((sbyte)20);
			for (int i = 0; i < items.Length; i++)
			{
				if (items[i] != null)
				{
					message.writer().writeByte(items[i].indexUI);
				}
			}
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void splitItem(Item item)
	{
		GameCanvas.msgdlg.pleasewait();
		Message message = null;
		try
		{
			message = new Message((sbyte)22);
			message.writer().writeByte(item.indexUI);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void acceptInviteTrade(int playerMapId)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)44);
			message.writer().writeInt(playerMapId);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void acceptInviteTestDun(int playerMapId)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)99);
			message.writer().writeInt(playerMapId);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void acceptInviteTestGT(int playerMapId)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)106);
			message.writer().writeInt(playerMapId);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void sendUIConfirmID(int Id)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)107);
			message.writer().writeByte(Id);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void acceptInviteTest(int playerMapId)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)66);
			message.writer().writeInt(playerMapId);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void cancelInviteTrade()
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)56);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void cancelTrade()
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)57);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void tradeAccept()
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)46);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void tradeItemLock(int coin, Item[] items)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)45);
			message.writer().writeInt(coin);
			int num = 0;
			for (int i = 0; i < items.Length; i++)
			{
				if (items[i] != null)
				{
					num++;
				}
			}
			message.writer().writeByte(num);
			for (int j = 0; j < items.Length; j++)
			{
				if (items[j] != null)
				{
					message.writer().writeByte(items[j].indexUI);
				}
			}
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void sendPlayerAttack(MyVector vMob, MyVector vChar, int type)
	{
		try
		{
			Message message = null;
			if (type == 0)
			{
				return;
			}
			if (vMob.size() > 0 && vChar.size() > 0)
			{
				switch (type)
				{
				case 1:
					message = new Message((sbyte)4);
					break;
				case 2:
					message = new Message((sbyte)73);
					break;
				}
				message.writer().writeByte(vMob.size());
				for (int i = 0; i < vMob.size(); i++)
				{
					Mob mob = (Mob)vMob.elementAt(i);
					message.writer().writeByte(mob.mobId);
				}
				for (int j = 0; j < vChar.size(); j++)
				{
					Char @char = (Char)vChar.elementAt(j);
					if (@char != null)
					{
						message.writer().writeInt(@char.charID);
					}
					else
					{
						message.writer().writeInt(-1);
					}
				}
			}
			else if (vMob.size() > 0)
			{
				message = new Message((sbyte)60);
				for (int k = 0; k < vMob.size(); k++)
				{
					Mob mob2 = (Mob)vMob.elementAt(k);
					message.writer().writeByte(mob2.mobId);
				}
			}
			else if (vChar.size() > 0)
			{
				message = new Message((sbyte)61);
				for (int l = 0; l < vChar.size(); l++)
				{
					Char char2 = (Char)vChar.elementAt(l);
					message.writer().writeInt(char2.charID);
				}
			}
			if (message != null)
			{
				session.sendMessage(message);
			}
		}
		catch (Exception)
		{
			Out.println("loi send attt ");
		}
	}

	public void pickItem(int itemMapId)
	{
		Message message = null;
		ItemMap itemMap = null;
		for (int i = 0; i < GameScr.vItemMap.size(); i++)
		{
			itemMap = (ItemMap)GameScr.vItemMap.elementAt(i);
		}
		try
		{
			message = new Message((sbyte)(-14));
			message.writer().writeShort(itemMapId);
			session.sendMessage(message);
		}
		catch (Exception)
		{
		}
		finally
		{
			message.cleanup();
		}
	}

	public void throwItem(int index)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)(-12));
			message.writer().writeByte(index);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void returnTownFromDead()
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)(-9));
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void wakeUpFromDead()
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)(-10));
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void getTask(int npcTemplateId, int menuId, int optionId)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)47);
			message.writer().writeByte(npcTemplateId);
			message.writer().writeByte(menuId);
			if (optionId >= 0)
			{
				message.writer().writeByte(optionId);
			}
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void chat(string text)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)(-23));
			message.writer().writeUTF(text);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void updateData()
	{
		Message message = null;
		try
		{
			message = messageNotMap(-122);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void updateMap()
	{
		Message message = null;
		try
		{
			message = messageNotMap(-121);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void updateSkill()
	{
		Message message = null;
		try
		{
			message = messageNotMap(-120);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void updateItem()
	{
		Message message = null;
		try
		{
			message = messageNotMap(-119);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void clientOk()
	{
		Message message = null;
		try
		{
			message = messageNotMap(-101);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void tradeInvite(int charId)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)43);
			message.writer().writeInt(charId);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void addFriend(string name)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)59);
			message.writer().writeUTF(name);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void addPartyAccept(int charId)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)80);
			message.writer().writeInt(charId);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void addPartyCancel(int charId)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)81);
			message.writer().writeInt(charId);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void testInvite(int charId)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)65);
			message.writer().writeInt(charId);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void addCuuSat(int charId)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)68);
			message.writer().writeInt(charId);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void buffLive(int charId)
	{
		Message message = null;
		try
		{
			message = messageSubCommand(-79);
			message.writer().writeInt(charId);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void addParty(string name)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)79);
			message.writer().writeUTF(name);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void requestMaptemplate(int maptemplateId)
	{
		Message message = null;
		try
		{
			message = messageNotMap(-109);
			message.writer().writeByte(maptemplateId);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void changePk(int typePk)
	{
		Message message = null;
		try
		{
			message = messageSubCommand(-93);
			message.writer().writeByte(typePk);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void changeTeamLeader(int index)
	{
		Message message = null;
		try
		{
			message = messageSubCommand(-87);
			message.writer().writeByte(index);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void moveMember(int index)
	{
		Message message = null;
		try
		{
			message = messageSubCommand(-86);
			message.writer().writeByte(index);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void sendUseSkillMyBuff()
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)74);
			message.writer().writeByte(Char.getMyChar().cdir);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void createParty()
	{
		Message message = null;
		try
		{
			message = messageSubCommand(-88);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void lockParty(bool isLock)
	{
		Message message = null;
		try
		{
			message = messageSubCommand(-76);
			message.writer().writeBoolean(isLock);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void outParty()
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)83);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void requestFriend()
	{
		Message message = null;
		try
		{
			message = messageSubCommand(-85);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void requestMatchInfo(int zoneid)
	{
		Message message = null;
		try
		{
			Out.println("zone id: " + zoneid);
			message = new Message((sbyte)100);
			message.writer().writeByte(zoneid);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void requestPlayerInfo(MyVector chars)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)25);
			message.writer().writeByte(chars.size());
			for (int i = 0; i < chars.size(); i++)
			{
				Char @char = (Char)chars.elementAt(i);
				message.writer().writeInt(@char.charID);
			}
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void requestEnemies()
	{
		Message message = null;
		try
		{
			message = messageSubCommand(-84);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void removeFriend(string name)
	{
		Message message = null;
		try
		{
			message = messageSubCommand(-83);
			message.writer().writeUTF(name);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void pleaseInputParty(string str)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)23);
			message.writer().writeUTF(str);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void acceptPleaseParty(string str)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)24);
			message.writer().writeUTF(str);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void chatParty(string text)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)(-20));
			message.writer().writeUTF(text);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void chatGlobal(string text)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)(-21));
			message.writer().writeUTF(text);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void chatPrivate(string to, string text)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)(-22));
			message.writer().writeUTF(to);
			message.writer().writeUTF(text);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void sendCardInfo(string NAP, string PIN)
	{
		Message message = null;
		try
		{
			message = messageNotMap(-99);
			message.writer().writeUTF(NAP);
			message.writer().writeUTF(PIN);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void saveRms(string key, sbyte[] data, sbyte type)
	{
		Message message = null;
		try
		{
			message = messageSubCommand(-67);
			message.writer().writeUTF(key);
			message.writer().writeInt(data.Length);
			message.writer().write(data);
			message.writer().writeByte(type);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void loadRMS(string key)
	{
		Message message = null;
		try
		{
			message = messageSubCommand(-65);
			message.writer().writeUTF(key);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void acceptPleaseClan(int playerMapId)
	{
		Message message = null;
		try
		{
			message = messageSubCommand(-60);
			message.writer().writeInt(playerMapId);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void changeClanType(string name, int type)
	{
		Message message = null;
		try
		{
			message = messageNotMap(-94);
			message.writer().writeUTF(name);
			message.writer().writeByte(type);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void changeClanAlert(string str)
	{
		Message message = null;
		try
		{
			message = messageNotMap(-95);
			message.writer().writeUTF(str);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void inputCoinClan(int coin)
	{
		Message message = null;
		try
		{
			message = messageNotMap(-90);
			message.writer().writeInt(coin);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void outputCoinClan(int coin)
	{
		Message message = null;
		try
		{
			message = messageNotMap(-89);
			message.writer().writeInt(coin);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void requestClanItem()
	{
		Message message = null;
		try
		{
			message = messageNotMap(-111);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void requestClanLog()
	{
		Message message = null;
		try
		{
			message = messageNotMap(-114);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void moveOutClan(string name)
	{
		Message message = null;
		try
		{
			message = messageNotMap(-93);
			message.writer().writeUTF(name);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void outClan()
	{
		Message message = null;
		try
		{
			message = messageNotMap(-92);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void clanUpLevel()
	{
		Message message = null;
		try
		{
			message = messageNotMap(-91);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void viewInfo(string cName)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)93);
			message.writer().writeUTF(cName);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void inviteClanDun(string name)
	{
		Message message = null;
		try
		{
			message = messageNotMap(-87);
			message.writer().writeUTF(name);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void doConvertUpgrade(int index1, int index2, int index3)
	{
		Message message = null;
		try
		{
			message = messageNotMap(-88);
			message.writer().writeByte(index1);
			message.writer().writeByte(index2);
			message.writer().writeByte(index3);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void openLockAccProtect(int pass2)
	{
		Message message = null;
		try
		{
			message = messageNotMap(-103);
			message.writer().writeInt(pass2);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void inviteClanBattlefield(string name)
	{
		Message message = null;
		try
		{
			message = messageNotMap(-70);
			message.writer().writeUTF(name);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void acceptClanBattlefield()
	{
		Message message = null;
		try
		{
			message = messageNotMap(-68);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void inviteClanBattlefieldAll()
	{
		Message message = null;
		try
		{
			message = messageNotMap(-69);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void unlockClanItem()
	{
		Message message = null;
		try
		{
			message = messageNotMap(-62);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void inputNumSplit(int indexItem, int numSplit)
	{
		Message message = null;
		try
		{
			message = messageNotMap(-85);
			message.writer().writeByte(indexItem);
			message.writer().writeInt(numSplit);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void activeAccProtect(int pass)
	{
		Message message = null;
		try
		{
			message = messageNotMap(-105);
			message.writer().writeInt(pass);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void updateActive(int passOld, int passNew)
	{
		Message message = null;
		try
		{
			message = messageNotMap(-104);
			message.writer().writeInt(passOld);
			message.writer().writeInt(passNew);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void clearAccProtect(int pass)
	{
		Message message = null;
		try
		{
			message = messageNotMap(-102);
			message.writer().writeInt(pass);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void rewardPB()
	{
		Message message = null;
		try
		{
			message = messageNotMap(-82);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void adminChat(string text)
	{
		Message message = null;
		try
		{
			message = messageNotMap(-78);
			message.writer().writeUTF(text);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void rewardCT()
	{
		Message message = null;
		try
		{
			message = messageNotMap(-79);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void sendToSaleItem(Item item, int value)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)102);
			message.writer().writeByte(item.indexUI);
			message.writer().writeInt(value);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void requestItemAuction(int itemId)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)104);
			message.writer().writeInt(itemId);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void buyItemAuction(int itemId)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)105);
			message.writer().writeInt(itemId);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void selectCard()
	{
		Message message = null;
		try
		{
			message = messageNotMap(-72);
			message.writer().writeByte(GameScr.indexSelect);
			session.sendMessage(message);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			message.cleanup();
		}
	}

	public void sendClanItem(string name)
	{
		Message message = null;
		try
		{
			message = messageNotMap(-61);
			message.writer().writeByte(GameScr.indexSelect);
			message.writer().writeUTF(name);
			session.sendMessage(message);
		}
		catch (Exception)
		{
		}
		finally
		{
			message.cleanup();
		}
	}

	public void useClanItem()
	{
		Message message = null;
		try
		{
			message = messageNotMap(-60);
			message.writer().writeByte(GameScr.indexSelect);
			session.sendMessage(message);
		}
		catch (Exception)
		{
		}
		finally
		{
			message.cleanup();
		}
	}

	public void luyenthach(Item[] items)
	{
		GameCanvas.msgdlg.pleasewait();
		Message message = null;
		try
		{
			message = new Message((sbyte)110);
			for (int i = 0; i < items.Length; i++)
			{
				if (items[i] != null && (items[i].template.id == 10 || items[i].template.id == 11))
				{
					message.writer().writeByte(items[i].indexUI);
					break;
				}
			}
			for (int j = 0; j < items.Length; j++)
			{
				if (items[j] != null && (items[j].template.id == 455 || items[j].template.id == 456))
				{
					message.writer().writeByte(items[j].indexUI);
				}
			}
			session.sendMessage(message);
		}
		catch (Exception)
		{
		}
		finally
		{
			message.cleanup();
		}
	}

	public void tinhluyen(Item it, Item[] items)
	{
		GameCanvas.msgdlg.pleasewait();
		Message message = null;
		try
		{
			message = new Message((sbyte)111);
			message.writer().writeByte(it.indexUI);
			for (int i = 0; i < items.Length; i++)
			{
				if (items[i] != null && (items[i].template.id == 455 || items[i].template.id == 456 || items[i].template.id == 457))
				{
					message.writer().writeByte(items[i].indexUI);
				}
			}
			session.sendMessage(message);
		}
		catch (Exception)
		{
		}
		finally
		{
			message.cleanup();
		}
	}

	public void dichchuyen(Item it, Item[] items)
	{
		GameCanvas.msgdlg.pleasewait();
		Message message = null;
		try
		{
			message = new Message((sbyte)112);
			message.writer().writeByte(it.indexUI);
			int num = 0;
			for (int i = 0; i < items.Length; i++)
			{
				if (items[i] != null && items[i].template.id == 454)
				{
					message.writer().writeByte(items[i].indexUI);
					num++;
				}
			}
			if (num < 20)
			{
				GameCanvas.startOKDlg(mResources.NOT_ENOUGH_DICHCHUYEN);
			}
			else
			{
				session.sendMessage(message);
			}
		}
		catch (Exception)
		{
		}
		finally
		{
			message.cleanup();
		}
	}

	public void sendCatkeo(int id)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)113);
			message.writer().writeShort(id);
			session.sendMessage(message);
		}
		catch (Exception)
		{
		}
		finally
		{
			message.cleanup();
		}
	}

	public void ChucTet(string to, string loichuc, byte type)
	{
		Message message = null;
		string value = to + " " + loichuc;
		try
		{
			message = new Message((sbyte)(-21));
			message.writer().writeUTF(value);
			message.writer().writeByte(type);
			session.sendMessage(message);
		}
		catch (Exception)
		{
		}
		finally
		{
			message.cleanup();
		}
	}

	public void SendCapcha(short idRe, string capcha)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)118);
			message.writer().writeUTF(capcha);
			message.writer().writeShort(idRe);
			session.sendMessage(message);
		}
		catch (Exception)
		{
		}
		finally
		{
			message.cleanup();
		}
	}

	public void sendAttackMobFast(short idMonter)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)119);
			message.writer().writeByte(idMonter);
			session.sendMessage(message);
		}
		catch (Exception)
		{
		}
		finally
		{
			message.cleanup();
		}
	}

	public void requestRegister(string username, string pass, string email)
	{
		try
		{
			Message message = messageNotLogin(-123);
			message.writer().writeUTF(username);
			message.writer().writeUTF(pass);
			message.writer().writeUTF(email);
			session.sendMessage(message);
			message.cleanup();
		}
		catch (Exception)
		{
		}
	}

	public void requestChangePass(string username, string oldpass, string newpass)
	{
		try
		{
			Message message = messageNotLogin(120);
			message.writer().writeUTF(username);
			message.writer().writeUTF(oldpass);
			message.writer().writeUTF(newpass);
			session.sendMessage(message);
			message.cleanup();
		}
		catch (Exception)
		{
		}
	}

	public void requestForgetPassByIMEI(string username, string email, string IMEI2, string IMEI3, string IMEI4)
	{
		try
		{
			Message message = messageNotLogin(-121);
			message.writer().writeUTF(username);
			message.writer().writeUTF(email);
			message.writer().writeUTF(IMEI2);
			message.writer().writeUTF(IMEI3);
			message.writer().writeUTF(IMEI4);
			session.sendMessage(message);
			message.cleanup();
		}
		catch (Exception)
		{
		}
	}

	public void requestRegister(string IMEI1)
	{
		try
		{
			Message message = messageNotLogin(-126);
			message.writer().writeUTF(IMEI1);
			session.sendMessage(message);
			message.cleanup();
		}
		catch (Exception)
		{
		}
	}

	public void requestRegisterIME(string username, string pass, string email)
	{
		try
		{
			Message message = messageNotLogin(-123);
			message.writer().writeUTF(username);
			message.writer().writeUTF(pass);
			message.writer().writeUTF(email);
			session.sendMessage(message);
			message.cleanup();
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
	}

	public void requestRanked(sbyte index, string name)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)121);
			message.writer().writeByte(index);
			message.writer().writeUTF(name);
			session.sendMessage(message);
		}
		catch (Exception)
		{
		}
		finally
		{
			message.cleanup();
		}
	}

	public void request_imgEffAuto(sbyte type, short id)
	{
		Message message = null;
		try
		{
			message = messageNotMap(122);
			message.writer().writeByte(type);
			message.writer().writeByte(id);
			session.sendMessage(message);
		}
		catch (Exception)
		{
		}
		finally
		{
			message.cleanup();
		}
	}

	public void luckyDraw(short type, string money, sbyte typeLucky)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)92);
			message.writer().writeShort(type);
			message.writer().writeUTF(money);
			message.writer().writeByte(typeLucky);
			session.sendMessage(message);
		}
		catch (Exception)
		{
		}
		finally
		{
			message.cleanup();
		}
	}

	public void info_Kiemduyet(string name, string ngaysinh, string diachi, string cmnd, string ngaycap, string noicap, string email)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)123);
			message.writer().writeUTF(name);
			message.writer().writeUTF(ngaysinh);
			message.writer().writeUTF(diachi);
			message.writer().writeUTF(cmnd);
			message.writer().writeUTF(ngaycap);
			message.writer().writeUTF(noicap);
			message.writer().writeUTF(email);
			session.sendMessage(message);
		}
		catch (Exception)
		{
		}
		finally
		{
			message.cleanup();
		}
	}

	public void send_Captcha(sbyte type)
	{
		Message message = null;
		try
		{
			message = messageNotMap(122);
			message.writer().writeByte(4);
			message.writer().writeByte(type);
			session.sendMessage(message);
		}
		catch (Exception)
		{
		}
		finally
		{
			message.cleanup();
		}
	}

	public void ngockham(sbyte type, Item item, Item ngoc, Item[] items)
	{
		GameCanvas.msgdlg.pleasewait();
		Message message = null;
		try
		{
			message = new Message((sbyte)124);
			message.writer().writeByte(type);
			if (type == 0)
			{
				message.writer().writeByte(item.indexUI);
				message.writer().writeByte(ngoc.indexUI);
				for (int i = 0; i < items.Length; i++)
				{
					if (items[i] != null)
					{
						message.writer().writeByte(items[i].indexUI);
					}
				}
			}
			else if (type == 1)
			{
				message.writer().writeByte(ngoc.indexUI);
				for (int j = 0; j < items.Length; j++)
				{
					if (items[j] != null)
					{
						message.writer().writeByte(items[j].indexUI);
					}
				}
			}
			else if (type == 2 || type == 3)
			{
				message.writer().writeByte(ngoc.indexUI);
			}
			session.sendMessage(message);
		}
		catch (Exception)
		{
		}
		finally
		{
			message.cleanup();
		}
	}

	public void giaodo(Item[] items)
	{
		GameCanvas.msgdlg.pleasewait();
		Message message = null;
		try
		{
			message = new Message((sbyte)126);
			for (int i = 0; i < items.Length; i++)
			{
				if (items[i] != null)
				{
					message.writer().writeByte(items[i].indexUI);
				}
			}
			session.sendMessage(message);
		}
		catch (Exception)
		{
		}
		finally
		{
			message.cleanup();
		}
	}

	public void doGetImgIcon(short id)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)125);
			message.writer().writeByte(1);
			message.writer().writeShort(id);
			session.sendMessage(message);
		}
		catch (Exception)
		{
		}
		finally
		{
			message.cleanup();
		}
	}

	public void doGetByteData(int id)
	{
		Message message = null;
		try
		{
			message = new Message((sbyte)125);
			message.writer().writeByte(2);
			message.writer().writeShort(id);
			session.sendMessage(message);
		}
		catch (Exception)
		{
		}
		finally
		{
			message.cleanup();
		}
	}

	public void sendGPS()
	{
		Message message = null;
		try
		{
			message = messageNotMap(-59);
			message.writer().writeUTF(GameMidlet.longitude);
			message.writer().writeUTF(GameMidlet.latitude);
			session.sendMessage(message);
		}
		catch (Exception)
		{
		}
	}
}
