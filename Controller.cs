using System;
using UnityEngine;

public class Controller : IMessageHandler
{
    protected static Controller me;

    public Message messWait;

    private int move;

    private int total;

    public const int ID_NEWMOB = 236;

    public static Controller gI()
    {
        if (me == null)
        {
            me = new Controller();
        }
        return me;
    }

    public void onConnectOK()
    {
        Out.println("Connect ok");
    }

    public void onConnectionFail()
    {
        GameCanvas.isConnectFail = true;
    }

    public void onDisconnected()
    {
        GameCanvas.instance.resetToLoginScr();
    }

    public void requestItemPlayer(Message msg)
    {
        try
        {
            int num = msg.reader().readUnsignedByte();
            Item item = GameScr.currentCharViewInfo.arrItemBody[num];
            item.expires = msg.reader().readLong();
            item.saleCoinLock = msg.reader().readInt();
            item.sys = msg.reader().readByte();
            item.options = new MyVector();
            try
            {
                while (true)
                {
                    item.options.addElement(new ItemOption(msg.reader().readUnsignedByte(), msg.reader().readInt()));
                }
            }
            catch (Exception ex)
            {
                Out.println(" >>>11  loi tai requestItemPlayer" + ex.ToString());
            }
        }
        catch (Exception ex2)
        {
            Out.println(">>>222 loi tai requestItemPlayer" + ex2.ToString());
        }
    }

    public void viewItemAuction(Message msg)
    {
        try
        {
            Item item = null;
            int num = msg.reader().readInt();
            for (int i = 0; i < GameScr.arrItemStands.Length; i++)
            {
                if (GameScr.arrItemStands[i].item.itemId == num)
                {
                    item = GameScr.arrItemStands[i].item;
                    break;
                }
            }
            item.typeUI = 37;
            item.expires = -1L;
            item.saleCoinLock = msg.reader().readInt();
            if (!item.isTypeBody() && !item.isTypeNgocKham())
            {
                return;
            }
            item.options = new MyVector();
            try
            {
                item.upgrade = msg.reader().readByte();
                item.sys = msg.reader().readByte();
                while (true)
                {
                    item.options.addElement(new ItemOption(msg.reader().readUnsignedByte(), msg.reader().readInt()));
                }
            }
            catch (Exception)
            {
            }
        }
        catch (Exception)
        {
        }
    }

    public void onMessage(Message msg)
    {
        GameCanvas.debugSession.removeAllElements();
        GameCanvas.debug("SA1", 2);
        Friend friend = null;
        Char @char = null;
        Char char2 = null;
        int num = 0;
        Mob mob = null;
        try
        {
            switch (msg.command)
            {
                case 125:
                    switch (msg.reader().readByte())
                    {
                        case 0:
                            addEffect(msg);
                            break;
                        case 1:
                            getImgEffect(msg);
                            break;
                        case 2:
                            getDataEffect(msg);
                            break;
                    }
                    break;
                case 124:
                    khamngoc(msg);
                    break;
                case 123:
                    switch (msg.reader().readByte())
                    {
                        case 0:
                            GameCanvas.isKiemduyet_info = true;
                            break;
                        case 1:
                            GameCanvas.isKiemduyet_info = false;
                            break;
                        case 2:
                            RMS.saveRMSInt("isKiemduyet", 0);
                            GameCanvas.isKiemduyet = true;
                            break;
                        default:
                            RMS.saveRMSInt("isKiemduyet", 1);
                            GameCanvas.isKiemduyet = false;
                            break;
                    }
                    break;
                case 122:
                    switch (msg.reader().readByte())
                    {
                        case 0:
                            addMob(msg);
                            break;
                        case 1:
                            addEffAuto(msg);
                            break;
                        case 2:
                            getImgEffAuto(msg);
                            break;
                        case 3:
                            getDataEffAuto(msg);
                            break;
                    }
                    break;
                case 121:
                    {
                        GameScr.vList.removeAllElements();
                        int num100 = msg.reader().readUnsignedByte();
                        Ranked ranked = null;
                        for (int num101 = 0; num101 < num100; num101++)
                        {
                            try
                            {
                                ranked = new Ranked();
                                ranked.name = msg.reader().readUTF();
                                ranked.ranked = msg.reader().readInt();
                                ranked.stt = msg.reader().readUTF();
                                GameScr.vList.addElement(ranked);
                            }
                            catch (Exception)
                            {
                            }
                        }
                        GameScr.gI().doShowRankedListUI();
                        break;
                    }
                case 119:
                    switch (msg.reader().readByte())
                    {
                        case -1:
                            GameScr.isUseitemAuto = true;
                            GameScr.rangeSearch = msg.reader().readInt();
                            if (GameScr.rangeSearch > 360)
                            {
                                GameScr.isAllmap = true;
                                break;
                            }
                            GameScr.isAllmap = false;
                            GameScr.pointCenterX = Char.getMyChar().cx;
                            GameScr.pointCenterY = Char.getMyChar().cy;
                            break;
                        case 0:
                            {
                                int charId5 = msg.reader().readInt();
                                Char char26 = GameScr.findCharInMap(charId5);
                                if (char26 != null)
                                {
                                    ServerEffect.addServerEffect(141, char26.cx, char26.cy, 2);
                                    short num102 = (short)(char26.cxMoveLast = msg.reader().readShort());
                                    short num103 = (short)(char26.cyMoveLast = msg.reader().readShort());
                                    ServerEffect.addServerEffect(141, char26.cx, char26.cy, 2);
                                }
                                break;
                            }
                        default:
                            GameScr.isUseitemAuto = false;
                            GameScr.auto = 0;
                            break;
                    }
                    break;
                case 118:
                    {
                        string text10 = msg.reader().readUTF();
                        RMS.saveRMSString("acc", text10);
                        string text11 = msg.reader().readUTF();
                        RMS.saveRMSString("pass", text11);
                        SelectServerScr.uname = text10;
                        SelectServerScr.pass = text11;
                        SelectServerScr.unameChange = string.Empty;
                        SelectServerScr.passChange = string.Empty;
                        if (!text10.StartsWith("tmpusr"))
                        {
                            GameScr.gI().switchToMe();
                        }
                        break;
                    }
                case 117:
                    try
                    {
                        Mob.vEggMonter.removeAllElements();
                        TileMap.itemMap.clear();
                        GameScr.vItemTreeBehind.removeAllElements();
                        GameScr.vItemTreeBetwen.removeAllElements();
                        GameScr.vItemTreeFront.removeAllElements();
                        sbyte b5 = msg.reader().readsbyte();
                        for (int num73 = 0; num73 < b5; num73++)
                        {
                            string k2 = msg.reader().readShort() + string.Empty;
                            int num74 = msg.reader().readInt();
                            sbyte[] array3 = new sbyte[num74];
                            msg.reader().readz(array3);
                            object v = createImage(array3);
                            TileMap.itemMap.put(k2, v);
                        }
                        int num75 = msg.reader().readUnsignedByte();
                        for (int num76 = 0; num76 < num75; num76++)
                        {
                            int idTree = msg.reader().readUnsignedByte();
                            int x = msg.reader().readUnsignedByte();
                            int y = msg.reader().readUnsignedByte();
                            ItemTree itemTree = new ItemTree(x, y);
                            itemTree.idTree = idTree;
                            GameScr.vItemTreeBehind.addElement(itemTree);
                        }
                        num75 = msg.reader().readUnsignedByte();
                        for (int num77 = 0; num77 < num75; num77++)
                        {
                            int idTree2 = msg.reader().readUnsignedByte();
                            int x2 = msg.reader().readUnsignedByte();
                            int y2 = msg.reader().readUnsignedByte();
                            ItemTree itemTree2 = new ItemTree(x2, y2);
                            itemTree2.idTree = idTree2;
                            GameScr.vItemTreeBetwen.addElement(itemTree2);
                        }
                        num75 = msg.reader().readUnsignedByte();
                        for (int num78 = 0; num78 < num75; num78++)
                        {
                            int idTree3 = msg.reader().readUnsignedByte();
                            int x3 = msg.reader().readUnsignedByte();
                            int y3 = msg.reader().readUnsignedByte();
                            ItemTree itemTree3 = new ItemTree(x3, y3);
                            itemTree3.idTree = idTree3;
                            GameScr.vItemTreeFront.addElement(itemTree3);
                        }
                    }
                    catch (Exception)
                    {
                    }
                    break;
                case -21:
                    {
                        string text5 = msg.reader().readUTF();
                        string text6 = msg.reader().readUTF();
                        ChatManager.gI().addChat(mResources.GLOBALCHAT[0], text5, text6);
                        if (!ChatManager.blockGlobalChat)
                        {
                            Info.addInfo(text5 + ": " + text6, 80, mFont.tahoma_7b_yellow);
                        }
                        break;
                    }
                case -20:
                    {
                        string whoChat2 = msg.reader().readUTF();
                        string text16 = msg.reader().readUTF();
                        ChatManager.gI().addChat(mResources.PARTYCHAT[0], whoChat2, text16);
                        if (!GameScr.isPaintMessage || ChatManager.gI().getCurrentChatTab().type != 1)
                        {
                            ChatManager.isMessagePt = true;
                        }
                        break;
                    }
                case -22:
                    {
                        string text12 = msg.reader().readUTF();
                        string text13 = msg.reader().readUTF();
                        ChatManager.gI().addChat(text12, text12, text13);
                        if ((!GameScr.isPaintMessage || !ChatManager.gI().getCurrentChatTab().ownerName.Equals(text12)) && !ChatManager.blockPrivateChat)
                        {
                            ChatManager.gI().addWaitList(text12);
                        }
                        break;
                    }
                case -19:
                    {
                        string whoChat = msg.reader().readUTF();
                        string text3 = msg.reader().readUTF();
                        ChatManager.gI().addChat(mResources.CLANCHAT[0], whoChat, text3);
                        if (!GameScr.isPaintMessage || ChatManager.gI().getCurrentChatTab().type != 4)
                        {
                            ChatManager.isMessageClan = true;
                        }
                        break;
                    }
                case -26:
                    GameCanvas.debug("SA2", 2);
                    GameCanvas.startOKDlg(msg.reader().readUTF());
                    break;
                case -24:
                    GameCanvas.debug("SA3", 2);
                    InfoMe.addInfo(msg.reader().readUTF(), 50, mFont.tahoma_7_yellow);
                    break;
                case -25:
                    {
                        GameCanvas.debug("SA3", 2);
                        string text8 = msg.reader().readUTF();
                        Info.addInfo(text8, 150, mFont.tahoma_7b_yellow);
                        ChatManager.gI().addChat(mResources.GLOBALCHAT[0], mResources.SERVER_ALERT, text8);
                        break;
                    }
                case 53:
                    {
                        GameCanvas.debug("SA4", 2);
                        GameScr.gI().resetButton();
                        string text2 = msg.reader().readUTF();
                        if (!text2.Equals("typemoi"))
                        {
                            string str = msg.reader().readUTF();
                            GameScr.gI().showAlert(text2, str, withMenuShow: false);
                            break;
                        }
                        string title = msg.reader().readUTF();
                        short time = msg.reader().readShort();
                        string totalMoney = msg.reader().readUTF();
                        short percentWin = msg.reader().readShort();
                        string percentWin2 = msg.reader().readUTF();
                        short numPlayer = msg.reader().readShort();
                        string winnerInfo = msg.reader().readUTF();
                        sbyte typeLucky = msg.reader().readByte();
                        string myMoney = msg.reader().readUTF();
                        GameScr.gI().showLucky_Draw(title, time, totalMoney, percentWin, percentWin2, numPlayer, winnerInfo, myMoney, typeLucky);
                        break;
                    }
                case 54:
                    GameCanvas.debug("SA44", 2);
                    GameCanvas.gI().openWeb(msg.reader().readUTF(), msg.reader().readUTF(), msg.reader().readUTF(), msg.reader().readUTF());
                    break;
                case 55:
                    GameCanvas.debug("SA444", 2);
                    GameCanvas.gI().sendSms(msg.reader().readUTF(), msg.reader().readUTF(), msg.reader().readShort(), msg.reader().readUTF(), msg.reader().readUTF());
                    break;
                case 57:
                    GameCanvas.debug("SA44444", 2);
                    GameCanvas.endDlg();
                    GameScr.gI().resetButton();
                    break;
                case 58:
                    GameCanvas.debug("SA444444", 2);
                    GameScr.arrItemTradeMe = null;
                    GameScr.arrItemTradeOrder = null;
                    if (GameScr.gI().coinTradeOrder > 0)
                    {
                        GameScr gameScr3 = GameScr.gI();
                        string tradeItemName = gameScr3.tradeItemName;
                        gameScr3.tradeItemName = tradeItemName + ", " + GameScr.gI().coinTradeOrder + " " + mResources.XU;
                        GameScr.startFlyText("+" + GameScr.gI().coinTradeOrder, Char.getMyChar().cx, Char.getMyChar().cy - Char.getMyChar().ch - 10, 0, -2, mFont.ADDMONEY);
                    }
                    GameScr.gI().coinTrade = (GameScr.gI().coinTradeOrder = 0);
                    GameScr.gI().resetButton();
                    Char.getMyChar().xu = msg.reader().readInt();
                    InfoDlg.hide();
                    if (!GameScr.gI().tradeItemName.Equals(string.Empty))
                    {
                        InfoMe.addInfo(mResources.RECEIVE + " " + GameScr.gI().tradeItemName);
                    }
                    break;
                case 59:
                    {
                        GameCanvas.debug("SA48888", 2);
                        string text9 = msg.reader().readUTF();
                        Friend o = new Friend(text9, 4);
                        GameScr.vFriendWait.addElement(o);
                        InfoMe.addInfo(text9 + " " + mResources.FRIEND_ADDED, 20, mFont.tahoma_7_white);
                        if (!GameScr.isPaintFriend)
                        {
                            break;
                        }
                        bool flag2 = false;
                        for (int num92 = 0; num92 < GameScr.vFriend.size(); num92++)
                        {
                            friend = (Friend)GameScr.vFriend.elementAt(num92);
                            if (friend.friendName.Equals(text9))
                            {
                                flag2 = true;
                                break;
                            }
                        }
                        if (!flag2)
                        {
                            GameScr.vFriend.addElement(o);
                            GameScr.gI().sortList(0);
                            GameScr.indexRow = 0;
                            GameScr.scrMain.clear();
                        }
                        break;
                    }
                case 79:
                    {
                        GameCanvas.debug("SA4888888", 2);
                        int num106 = msg.reader().readInt();
                        string text14 = msg.reader().readUTF();
                        GameCanvas.startYesNoDlg(text14 + " " + mResources.INVITEPARTY, 8887, num106, 8888, num106);
                        break;
                    }
                case 82:
                    {
                        GameCanvas.debug("SXX1", 2);
                        GameScr.vParty.removeAllElements();
                        bool isLock = msg.reader().readBoolean();
                        try
                        {
                            for (int num104 = 0; num104 < 6; num104++)
                            {
                                GameScr.vParty.addElement(new Party(msg.reader().readInt(), msg.reader().readByte(), msg.reader().readUTF(), isLock));
                            }
                        }
                        catch (Exception)
                        {
                        }
                        GameScr.gI().refreshTeam();
                        break;
                    }
                case 83:
                    GameCanvas.debug("SXX2", 2);
                    GameScr.vParty.removeAllElements();
                    GameScr.gI().refreshTeam();
                    break;
                case 84:
                    GameCanvas.debug("SXX3", 2);
                    friend = new Friend(msg.reader().readUTF(), msg.reader().readByte());
                    GameScr.gI().actRemoveWaitAcceptFriend(friend.friendName);
                    if (friend.type == 0)
                    {
                        InfoMe.addInfo(mResources.YOU_ADD + " " + friend.friendName + " " + mResources.TO_LIST);
                        GameScr.vFriend.addElement(friend);
                    }
                    else if (friend.type == 1)
                    {
                        for (int l = 0; l < GameScr.vFriend.size(); l++)
                        {
                            if (((Friend)GameScr.vFriend.elementAt(l)).friendName.Equals(friend.friendName))
                            {
                                GameScr.vFriend.removeElementAt(l);
                                break;
                            }
                        }
                        InfoMe.addInfo(mResources.YOU_AND + " " + friend.friendName + " " + mResources.BE_FRIEND);
                        friend.type = 3;
                        GameScr.vFriend.insertElementAt(friend, 0);
                    }
                    if (GameScr.isPaintFriend)
                    {
                        GameScr.gI().sortList(0);
                        GameScr.indexRow = 0;
                        GameScr.scrMain.clear();
                    }
                    break;
                case 107:
                    {
                        int num12 = msg.reader().readByte();
                        GameCanvas.startYesNoDlg(msg.reader().readUTF(), 8890, num12, 8891, null);
                        break;
                    }
                case 85:
                    {
                        GameCanvas.debug("SXX4", 2);
                        int iD2 = msg.reader().readUnsignedByte();
                        Mob mob2 = Mob.get_Mob(iD2);
                        bool isDisable = msg.reader().readBoolean();
                        if (mob2 != null)
                        {
                            mob2.isDisable = isDisable;
                        }
                        break;
                    }
                case 86:
                    {
                        GameCanvas.debug("SXX5", 2);
                        int iD17 = msg.reader().readUnsignedByte();
                        Mob mob8 = Mob.get_Mob(iD17);
                        bool isDontMove = msg.reader().readBoolean();
                        if (mob8 != null)
                        {
                            mob8.isDontMove = isDontMove;
                        }
                        break;
                    }
                case 89:
                    {
                        GameCanvas.debug("SXX5", 2);
                        int iD15 = msg.reader().readUnsignedByte();
                        Mob mob6 = Mob.get_Mob(iD15);
                        bool isFire = msg.reader().readBoolean();
                        if (mob6 != null)
                        {
                            mob6.isFire = isFire;
                        }
                        break;
                    }
                case 90:
                    {
                        GameCanvas.debug("SXX5", 2);
                        int iD16 = msg.reader().readUnsignedByte();
                        Mob mob7 = Mob.get_Mob(iD16);
                        bool isIce = msg.reader().readBoolean();
                        if (mob7 != null)
                        {
                            mob7.isIce = isIce;
                            if (!mob7.isIce)
                            {
                                ServerEffect.addServerEffect(77, mob7.x, mob7.y - 9, 1);
                            }
                        }
                        break;
                    }
                case 91:
                    {
                        GameCanvas.debug("SXX5", 2);
                        int iD12 = msg.reader().readUnsignedByte();
                        Mob mob5 = Mob.get_Mob(iD12);
                        bool isWind = msg.reader().readBoolean();
                        if (mob5 != null)
                        {
                            mob5.isWind = isWind;
                        }
                        break;
                    }
                case 62:
                    {
                        GameCanvas.debug("SXX6", 2);
                        int num55 = msg.reader().readInt();
                        Char myChar;
                        if (num55 == Char.getMyChar().charID)
                        {
                            myChar = Char.getMyChar();
                            myChar.cHP = msg.reader().readInt();
                            int num56 = msg.reader().readInt();
                            int num57 = 0;
                            try
                            {
                                myChar.cMP = msg.reader().readInt();
                                num57 = msg.reader().readInt();
                            }
                            catch (Exception)
                            {
                            }
                            num56 += num57;
                            if (num56 == 0)
                            {
                                GameScr.startFlyText(string.Empty, myChar.cx, myChar.cy - myChar.ch, 0, -2, mFont.MISS_ME);
                            }
                            else if (num56 < 0)
                            {
                                GameScr.startFlyText("-" + num56 * -1, myChar.cx, myChar.cy - myChar.ch, 0, -2, mFont.FATAL_ME);
                            }
                            else
                            {
                                GameScr.startFlyText("-" + num56, myChar.cx, myChar.cy - myChar.ch, 0, -2, mFont.RED);
                            }
                            break;
                        }
                        myChar = GameScr.findCharInMap(num55);
                        if (myChar == null)
                        {
                            return;
                        }
                        myChar.cHP = msg.reader().readInt();
                        int num58 = msg.reader().readInt();
                        int num59 = 0;
                        try
                        {
                            myChar.cMP = msg.reader().readInt();
                            num59 = msg.reader().readInt();
                        }
                        catch (Exception)
                        {
                        }
                        num58 += num59;
                        if (num58 == 0)
                        {
                            GameScr.startFlyText(string.Empty, myChar.cx, myChar.cy - myChar.ch, 0, -2, mFont.MISS);
                        }
                        else if (num58 < 0)
                        {
                            GameScr.startFlyText("-" + num58 * -1, myChar.cx, myChar.cy - myChar.ch, 0, -2, mFont.FATAL);
                        }
                        else
                        {
                            GameScr.startFlyText("-" + num58, myChar.cx, myChar.cy - myChar.ch, 0, -2, mFont.ORANGE);
                        }
                        break;
                    }
                case 23:
                    {
                        GameCanvas.debug("SXX7", 2);
                        string text4 = msg.reader().readUTF();
                        GameCanvas.startYesNoDlg(text4 + " " + mResources.PLEASE_PARTY, 8889, text4, 8882, null);
                        break;
                    }
                case 87:
                    {
                        GameCanvas.debug("SXX8", 2);
                        int num9 = msg.reader().readInt();
                        Char char5 = ((num9 != Char.getMyChar().charID) ? GameScr.findCharInMap(num9) : Char.getMyChar());
                        if (char5 == null)
                        {
                            return;
                        }
                        int iD = msg.reader().readUnsignedByte();
                        short idSkill_atk = msg.reader().readShort();
                        sbyte typeAtk = msg.reader().readByte();
                        sbyte typeTool = msg.reader().readByte();
                        sbyte b2 = 0;
                        int charId2 = -1;
                        try
                        {
                            b2 = msg.reader().readByte();
                            if (b2 == 1)
                            {
                                charId2 = msg.reader().readInt();
                            }
                        }
                        catch (Exception)
                        {
                        }
                        if (char5.mobMe != null)
                        {
                            if (b2 == 0)
                            {
                                Mob mobToAttack = Mob.get_Mob(iD);
                                char5.mobMe.attackOtherMob(mobToAttack);
                            }
                            else
                            {
                                Char charToAttack = GameScr.findCharInMap(charId2);
                                char5.mobMe.attackOtherChar(charToAttack);
                            }
                        }
                        char5.mobMe.setTypeAtk(idSkill_atk, typeAtk, typeTool);
                        break;
                    }
                case 88:
                    {
                        int num125 = msg.reader().readInt();
                        Char char30;
                        if (num125 == Char.getMyChar().charID)
                        {
                            char30 = Char.getMyChar();
                        }
                        else
                        {
                            char30 = GameScr.findCharInMap(num125);
                            if (char30 == null)
                            {
                                return;
                            }
                        }
                        char30.cHP = char30.cMaxHP;
                        char30.cMP = char30.cMaxMP;
                        char30.cx = msg.reader().readShort();
                        char30.cy = msg.reader().readShort();
                        char30.liveFromDead();
                        break;
                    }
                case 52:
                    GameCanvas.debug("SA5", 2);
                    Char.ischangingMap = false;
                    Char.isLockKey = false;
                    Char.getMyChar().cx = msg.reader().readShort();
                    Char.getMyChar().cy = msg.reader().readShort();
                    Char.getMyChar().cxSend = Char.getMyChar().cx;
                    Char.getMyChar().cySend = Char.getMyChar().cy;
                    break;
                case -29:
                    messageNotLogin(msg);
                    break;
                case -28:
                    messageNotMap(msg);
                    break;
                case -30:
                    messageSubCommand(msg);
                    break;
                case 8:
                    {
                        GameCanvas.debug("SA37", 2);
                        int num82 = msg.reader().readByte();
                        Char.getMyChar().arrItemBag[num82] = new Item();
                        Char.getMyChar().arrItemBag[num82].typeUI = 3;
                        Char.getMyChar().arrItemBag[num82].indexUI = num82;
                        Char.getMyChar().arrItemBag[num82].template = ItemTemplates.get(msg.reader().readShort());
                        Char.getMyChar().arrItemBag[num82].isLock = msg.reader().readBoolean();
                        if (Char.getMyChar().arrItemBag[num82].isTypeBody() || Char.getMyChar().arrItemBag[num82].isTypeNgocKham())
                        {
                            Char.getMyChar().arrItemBag[num82].upgrade = msg.reader().readByte();
                        }
                        Char.getMyChar().arrItemBag[num82].isExpires = msg.reader().readBoolean();
                        try
                        {
                            Char.getMyChar().arrItemBag[num82].quantity = msg.reader().readUnsignedShort();
                        }
                        catch (Exception)
                        {
                            Char.getMyChar().arrItemBag[num82].quantity = 1;
                        }
                        if (Char.getMyChar().arrItemBag[num82].template.type == 16)
                        {
                            GameScr.hpPotion += Char.getMyChar().arrItemBag[num82].quantity;
                        }
                        if (Char.getMyChar().arrItemBag[num82].template.type == 17)
                        {
                            GameScr.mpPotion += Char.getMyChar().arrItemBag[num82].quantity;
                        }
                        if (Char.getMyChar().arrItemBag[num82].template.id == 340)
                        {
                            GameScr gameScr = GameScr.gI();
                            gameScr.numSprinLeft += Char.getMyChar().arrItemBag[num82].quantity;
                        }
                        if (GameScr.isPaintTrade)
                        {
                            if (GameScr.gI().tradeItemName.Equals(string.Empty))
                            {
                                GameScr gameScr = GameScr.gI();
                                gameScr.tradeItemName += Char.getMyChar().arrItemBag[num82].template.name;
                            }
                            else
                            {
                                GameScr gameScr2 = GameScr.gI();
                                gameScr2.tradeItemName = gameScr2.tradeItemName + ", " + Char.getMyChar().arrItemBag[num82].template.name;
                            }
                        }
                        else if (Char.getMyChar().arrItemBag[num82].template.type != 20)
                        {
                            InfoMe.addInfo(mResources.RECEIVE + " " + Char.getMyChar().arrItemBag[num82].template.name);
                        }
                        break;
                    }
                case 10:
                    {
                        GameCanvas.debug("SA38", 2);
                        int num54 = msg.reader().readByte();
                        if (Char.getMyChar().arrItemBag[num54].template.type == 16)
                        {
                            GameScr.hpPotion -= Char.getMyChar().arrItemBag[num54].quantity;
                        }
                        if (Char.getMyChar().arrItemBag[num54].template.type == 17)
                        {
                            GameScr.mpPotion -= Char.getMyChar().arrItemBag[num54].quantity;
                        }
                        Char.getMyChar().arrItemBag[num54] = null;
                        if (GameScr.gI().isPaintUI())
                        {
                            GameScr.gI().left = (GameScr.gI().center = null);
                        }
                        else
                        {
                            GameScr.gI().resetButton();
                        }
                        break;
                    }
                case 18:
                    {
                        GameCanvas.debug("SYA9", 2);
                        int num3 = msg.reader().readByte();
                        int num4 = 1;
                        try
                        {
                            num4 = msg.reader().readShort();
                        }
                        catch (Exception)
                        {
                        }
                        if (Char.getMyChar().arrItemBag[num3].template.type == 24)
                        {
                            InfoDlg.hide();
                        }
                        if (Char.getMyChar().arrItemBag[num3].template.type == 16)
                        {
                            GameScr.hpPotion--;
                        }
                        if (Char.getMyChar().arrItemBag[num3].template.type == 17)
                        {
                            GameScr.mpPotion--;
                        }
                        if (Char.getMyChar().arrItemBag[num3].quantity > num4)
                        {
                            Item item = Char.getMyChar().arrItemBag[num3];
                            item.quantity -= num4;
                        }
                        else
                        {
                            Char.getMyChar().arrItemBag[num3] = null;
                        }
                        if (GameScr.isPaintInfoMe)
                        {
                            GameScr.gI().setLCR();
                        }
                        break;
                    }
                case 9:
                    {
                        GameCanvas.debug("SA39", 2);
                        Item item6 = Char.getMyChar().arrItemBag[msg.reader().readUnsignedByte()];
                        int num116 = 0;
                        try
                        {
                            num116 = msg.reader().readShort();
                        }
                        catch (Exception)
                        {
                            num116 = 1;
                        }
                        Item item = item6;
                        item.quantity += num116;
                        if (item6.template.type == 16)
                        {
                            GameScr.hpPotion += num116;
                        }
                        if (item6.template.type == 17)
                        {
                            GameScr.mpPotion += num116;
                        }
                        if (item6.template.id == 340)
                        {
                            GameScr gameScr = GameScr.gI();
                            gameScr.numSprinLeft += num116;
                        }
                        GameCanvas.endDlg();
                        if (GameScr.isPaintTrade)
                        {
                            if (GameScr.gI().tradeItemName.Equals(string.Empty))
                            {
                                GameScr gameScr = GameScr.gI();
                                gameScr.tradeItemName += item6.template.name;
                            }
                            else
                            {
                                GameScr gameScr4 = GameScr.gI();
                                gameScr4.tradeItemName = gameScr4.tradeItemName + ", " + item6.template.name;
                            }
                        }
                        else if (item6.template.type != 20)
                        {
                            InfoMe.addInfo(mResources.RECEIVE + " " + item6.template.name);
                        }
                        break;
                    }
                case 15:
                    GameCanvas.debug("SA40", 2);
                    Char.getMyChar().itemBodyToBag(msg);
                    break;
                case 16:
                    GameCanvas.debug("SA41", 2);
                    Char.getMyChar().itemBoxToBag(msg);
                    break;
                case 108:
                    Char.getMyChar().itemMonToBag(msg);
                    break;
                case 114:
                    GameScr.gI().typeba = msg.reader().readSByte();
                    break;
                case 17:
                    GameCanvas.debug("SA42", 2);
                    Char.getMyChar().itemBagToBox(msg);
                    break;
                case 19:
                    GameCanvas.debug("SA43", 2);
                    Char.getMyChar().crystalCollect(msg, isCoin: true);
                    break;
                case 20:
                    GameCanvas.debug("SA44", 2);
                    Char.getMyChar().crystalCollect(msg, isCoin: false);
                    break;
                case 21:
                    {
                        GameCanvas.debug("SA45", 2);
                        int num84 = msg.reader().readByte();
                        Char.getMyChar().luong = msg.reader().readInt();
                        Char.getMyChar().xu = msg.reader().readInt();
                        Char.getMyChar().yen = msg.reader().readInt();
                        if (GameScr.itemUpGrade != null)
                        {
                            GameScr.itemUpGrade.upgrade = msg.reader().readByte();
                            GameScr.itemUpGrade.isLock = true;
                            GameScr.itemUpGrade.clearExpire();
                            if (num84 == 1)
                            {
                                GameScr.effUpok = GameScr.efs[53];
                                GameScr.indexEff = 0;
                            }
                        }
                        if (GameScr.arrItemUpGrade != null)
                        {
                            for (int num85 = 0; num85 < GameScr.arrItemUpGrade.Length; num85++)
                            {
                                GameScr.arrItemUpGrade[num85] = null;
                            }
                        }
                        if (num84 == 5 || num84 == 6)
                        {
                            if (GameScr.itemSplit != null)
                            {
                                GameScr.itemSplit = null;
                            }
                            if (GameScr.arrItemSplit != null)
                            {
                                for (int num86 = 0; num86 < GameScr.arrItemSplit.Length; num86++)
                                {
                                    GameScr.arrItemSplit[num86] = null;
                                }
                            }
                        }
                        GameScr.gI().left = (GameScr.gI().center = null);
                        GameScr.gI().updateKeyBuyItemUI();
                        GameCanvas.endDlg();
                        switch (num84)
                        {
                            case 5:
                                InfoMe.addInfo(mResources.TYPEKHAMNGOC[0] + GameScr.itemUpGrade.upgrade, 20, mFont.tahoma_7_white);
                                break;
                            case 6:
                                InfoMe.addInfo(mResources.TYPEKHAMNGOC[1] + GameScr.itemUpGrade.upgrade, 20, mFont.tahoma_7_red);
                                break;
                            case 1:
                                InfoMe.addInfo(mResources.TYPEUPGRADE[0] + GameScr.itemUpGrade.upgrade, 20, mFont.tahoma_7_white);
                                break;
                            default:
                                InfoMe.addInfo(mResources.TYPEUPGRADE[1] + GameScr.itemUpGrade.upgrade, 20, mFont.tahoma_7_red);
                                break;
                        }
                        break;
                    }
                case 112:
                    {
                        Item item5 = Char.getMyChar().arrItemBag[msg.reader().readByte()];
                        item5.upgrade = msg.reader().readByte();
                        item5.expires = 0L;
                        break;
                    }
                case 22:
                    {
                        GameCanvas.debug("SA46", 2);
                        int num64 = msg.reader().readByte();
                        string text7 = mResources.SPLIT_ITEM_NAME;
                        for (int num65 = 0; num65 < GameScr.arrItemSplit.Length; num65++)
                        {
                            GameScr.arrItemSplit[num65] = null;
                        }
                        for (int num66 = 0; num66 < num64; num66++)
                        {
                            Item item4 = new Item();
                            item4.typeUI = 3;
                            item4.indexUI = msg.reader().readByte();
                            item4.template = ItemTemplates.get(msg.reader().readShort());
                            item4.expires = -1L;
                            item4.quantity = 1;
                            item4.isLock = GameScr.itemSplit.isLock;
                            Char.getMyChar().arrItemBag[item4.indexUI] = item4;
                            text7 += item4.template.name;
                            if (num66 < num64 - 1)
                            {
                                text7 += ", ";
                            }
                        }
                        GameScr.itemSplit.upgrade = 0;
                        GameScr.itemSplit.clearExpire();
                        GameScr.gI().left = (GameScr.gI().center = null);
                        GameScr.gI().updateCommandForUI();
                        GameCanvas.endDlg();
                        InfoMe.addInfo(text7);
                        GameScr.effUpok = GameScr.efs[66];
                        GameScr.indexEff = 0;
                        break;
                    }
                case 11:
                    {
                        int num49 = msg.reader().readByte();
                        if (Char.getMyChar().arrItemBag[num49].template.type == 24)
                        {
                            InfoDlg.hide();
                        }
                        Char.getMyChar().useItem(num49);
                        Char.getMyChar().readParam(msg, "Cmd.ITEM_USE");
                        Char.getMyChar().eff5BuffHp = msg.reader().readShort();
                        Char.getMyChar().eff5BuffMp = msg.reader().readShort();
                        GameScr.gI().setLCR();
                        break;
                    }
                case 43:
                    {
                        GameCanvas.debug("SA48", 2);
                        int num47 = msg.reader().readInt();
                        Char char13 = GameScr.findCharInMap(num47);
                        if (char13 != null)
                        {
                            GameCanvas.startYesNoDlg(char13.cName + " " + mResources.INVITETRADE, 88810, num47, 88811, null);
                        }
                        break;
                    }
                case 65:
                    {
                        GameCanvas.debug("SA48", 2);
                        Char char11 = GameScr.findCharInMap(msg.reader().readInt());
                        if (char11 != null)
                        {
                            GameCanvas.startYesNoDlg(char11.cName + " " + mResources.INVITETEST, 88812, char11, 8882, null);
                        }
                        break;
                    }
                case 99:
                    {
                        Out.println("Vao DUN >>>>>");
                        GameCanvas.debug("SA48", 2);
                        Char char10 = GameScr.findCharInMap(msg.reader().readInt());
                        if (char10 != null)
                        {
                            GameCanvas.startYesNoDlg(char10.cName + " " + mResources.INVITETESTDUN, 88840, char10, 8882, null);
                        }
                        break;
                    }
                case 106:
                    {
                        GameCanvas.debug("SA48", 2);
                        Char char9 = GameScr.findCharInMap(msg.reader().readInt());
                        if (char9 != null)
                        {
                            GameCanvas.startYesNoDlg(char9.cName + " " + mResources.INVITETESTGT, 88841, char9, 8882, null);
                        }
                        break;
                    }
                case 100:
                    {
                        GameScr.vList.removeAllElements();
                        int num11 = msg.reader().readByte();
                        DunItem dunItem = null;
                        for (int j = 0; j < num11; j++)
                        {
                            try
                            {
                                dunItem = new DunItem();
                                dunItem.id = msg.reader().readByte();
                                dunItem.name1 = msg.reader().readUTF();
                                dunItem.name2 = msg.reader().readUTF();
                                GameScr.vList.addElement(dunItem);
                            }
                            catch (Exception)
                            {
                            }
                        }
                        GameScr.gI().doShowListUI();
                        break;
                    }
                case 66:
                    {
                        GameCanvas.debug("SZ1", 2);
                        int num7 = msg.reader().readInt();
                        int num8 = msg.reader().readInt();
                        if (num7 != Char.getMyChar().charID && num8 != Char.getMyChar().charID)
                        {
                            GameScr.findCharInMap(num7).testCharId = num8;
                            GameScr.findCharInMap(num8).testCharId = num7;
                        }
                        else if (num7 == Char.getMyChar().charID)
                        {
                            Char.getMyChar().testCharId = num8;
                            Char.getMyChar().npcFocus = null;
                            Char.getMyChar().mobFocus = null;
                            Char.getMyChar().itemFocus = null;
                            Char.getMyChar().charFocus = GameScr.findCharInMap(Char.getMyChar().testCharId);
                            Char.getMyChar().charFocus.testCharId = Char.getMyChar().charID;
                            GameScr.gI().cPreFocusID = GameScr.gI().cLastFocusID;
                            GameScr.gI().cLastFocusID = num8;
                            Char.isManualFocus = true;
                        }
                        else if (num8 == Char.getMyChar().charID)
                        {
                            Char.getMyChar().testCharId = num7;
                            Char.getMyChar().npcFocus = null;
                            Char.getMyChar().mobFocus = null;
                            Char.getMyChar().itemFocus = null;
                            Char.getMyChar().charFocus = GameScr.findCharInMap(Char.getMyChar().testCharId);
                            Char.getMyChar().charFocus.testCharId = Char.getMyChar().charID;
                            GameScr.gI().cPreFocusID = GameScr.gI().cLastFocusID;
                            GameScr.gI().cLastFocusID = num7;
                            Char.isManualFocus = true;
                        }
                        break;
                    }
                case 67:
                    {
                        GameCanvas.debug("SZ2", 2);
                        int num50 = msg.reader().readInt();
                        int num51 = msg.reader().readInt();
                        int num52 = 0;
                        try
                        {
                            num52 = msg.reader().readInt();
                        }
                        catch (Exception)
                        {
                        }
                        if (num50 == Char.getMyChar().charID)
                        {
                            Char char15 = GameScr.findCharInMap(num51);
                            if (num52 > 0)
                            {
                                InfoMe.addInfo(mResources.replace(mResources.YOU_LOST, char15.cName));
                                Char.getMyChar().cHP = num52;
                                Char.getMyChar().resultTest = 29;
                                if (char15 != null)
                                {
                                    char15.resultTest = 89;
                                }
                            }
                            else
                            {
                                if (char15 != null)
                                {
                                    char15.resultTest = 59;
                                }
                                Char.getMyChar().resultTest = 59;
                                InfoMe.addInfo(mResources.replace(mResources.TEST_END, char15.cName));
                            }
                            Char.getMyChar().testCharId = -9999;
                            Char.getMyChar().charFocus = null;
                            if (GameScr.gI().cPreFocusID >= 0)
                            {
                                GameScr.gI().cLastFocusID = GameScr.gI().cPreFocusID;
                                GameScr.gI().cPreFocusID = -1;
                            }
                            else
                            {
                                GameScr.gI().cLastFocusID = -1;
                            }
                            if (char15 != null)
                            {
                                char15.testCharId = -9999;
                            }
                            break;
                        }
                        if (num51 == Char.getMyChar().charID)
                        {
                            Char char16 = GameScr.findCharInMap(num50);
                            if (num52 > 0)
                            {
                                if (char16 != null)
                                {
                                    char16.cHP = num52;
                                }
                                if (char16 != null)
                                {
                                    char16.resultTest = 29;
                                }
                                Char.getMyChar().resultTest = 89;
                                InfoMe.addInfo(mResources.replace(mResources.YOU_WIN, char16.cName));
                            }
                            else
                            {
                                if (char16 != null)
                                {
                                    char16.resultTest = 59;
                                }
                                Char.getMyChar().resultTest = 59;
                                InfoMe.addInfo(mResources.replace(mResources.TEST_END, char16.cName));
                            }
                            if (char16 != null)
                            {
                                char16.testCharId = -9999;
                            }
                            Char.getMyChar().testCharId = -9999;
                            Char.getMyChar().charFocus = null;
                            if (GameScr.gI().cPreFocusID >= 0)
                            {
                                GameScr.gI().cLastFocusID = GameScr.gI().cPreFocusID;
                                GameScr.gI().cPreFocusID = -1;
                            }
                            else
                            {
                                GameScr.gI().cLastFocusID = -1;
                            }
                            break;
                        }
                        @char = GameScr.findCharInMap(num50);
                        char2 = GameScr.findCharInMap(num51);
                        if (num52 > 0)
                        {
                            if (@char != null)
                            {
                                @char.cHP = num52;
                            }
                            if (@char != null)
                            {
                                @char.resultTest = 29;
                            }
                            if (char2 != null)
                            {
                                char2.resultTest = 89;
                            }
                        }
                        else
                        {
                            if (@char != null)
                            {
                                @char.resultTest = 59;
                            }
                            if (char2 != null)
                            {
                                char2.resultTest = 59;
                            }
                        }
                        if (@char != null)
                        {
                            @char.testCharId = -9999;
                        }
                        if (char2 != null)
                        {
                            char2.testCharId = -9999;
                        }
                        break;
                    }
                case 68:
                    {
                        GameCanvas.debug("SZ3", 2);
                        Char char14 = GameScr.findCharInMap(msg.reader().readInt());
                        if (char14 != null)
                        {
                            char14.killCharId = Char.getMyChar().charID;
                            Char.getMyChar().npcFocus = null;
                            Char.getMyChar().mobFocus = null;
                            Char.getMyChar().itemFocus = null;
                            Char.getMyChar().charFocus = char14;
                            Char.isManualFocus = true;
                            InfoMe.addInfo(char14.cName + mResources.CUU_SAT, 20, mFont.tahoma_7_red);
                        }
                        break;
                    }
                case 69:
                    GameCanvas.debug("SZ4", 2);
                    Char.getMyChar().killCharId = msg.reader().readInt();
                    Char.getMyChar().npcFocus = null;
                    Char.getMyChar().mobFocus = null;
                    Char.getMyChar().itemFocus = null;
                    Char.getMyChar().charFocus = GameScr.findCharInMap(Char.getMyChar().killCharId);
                    Char.isManualFocus = true;
                    break;
                case 70:
                    {
                        GameCanvas.debug("SZ5", 2);
                        Char char12 = Char.getMyChar();
                        try
                        {
                            char12 = GameScr.findCharInMap(msg.reader().readInt());
                        }
                        catch (Exception)
                        {
                        }
                        char12.killCharId = -9999;
                        break;
                    }
                case 46:
                    GameCanvas.debug("SA49", 2);
                    GameScr.gI().typeTradeOrder = 2;
                    if (GameScr.gI().typeTrade >= 2 && GameScr.gI().typeTradeOrder >= 2)
                    {
                        InfoDlg.showWait();
                    }
                    break;
                case 45:
                    {
                        GameCanvas.debug("SA50", 2);
                        GameScr.gI().typeTradeOrder = 1;
                        GameScr.gI().coinTradeOrder = msg.reader().readInt();
                        GameScr.arrItemTradeOrder = new Item[12];
                        int num14 = msg.reader().readByte();
                        for (int k = 0; k < num14; k++)
                        {
                            GameScr.arrItemTradeOrder[k] = new Item();
                            GameScr.arrItemTradeOrder[k].typeUI = 3;
                            GameScr.arrItemTradeOrder[k].indexUI = k;
                            GameScr.arrItemTradeOrder[k].template = ItemTemplates.get(msg.reader().readShort());
                            GameScr.arrItemTradeOrder[k].isLock = false;
                            if (GameScr.arrItemTradeOrder[k].isTypeBody() || GameScr.arrItemTradeOrder[k].isTypeNgocKham())
                            {
                                GameScr.arrItemTradeOrder[k].upgrade = msg.reader().readByte();
                            }
                            GameScr.arrItemTradeOrder[k].isExpires = msg.reader().readBoolean();
                            GameScr.arrItemTradeOrder[k].quantity = msg.reader().readShort();
                        }
                        if (GameScr.gI().typeTrade == 1 && GameScr.gI().typeTradeOrder == 1)
                        {
                            GameScr.gI().timeTrade = (int)(mSystem.getCurrentTimeMillis() / 1000 + 5);
                        }
                        break;
                    }
                case 63:
                    {
                        GameCanvas.debug("SZ6", 2);
                        MyVector myVector = new MyVector();
                        while (true)
                        {
                            try
                            {
                                myVector.addElement(new Command(msg.reader().readUTF(), GameCanvas.instance, 88817, null));
                            }
                            catch (Exception)
                            {
                                break;
                            }
                        }
                        GameCanvas.menu.startAt(myVector, 3);
                        break;
                    }
                case 27:
                    {
                        GameCanvas.debug("SZ7", 2);
                        int iD3 = msg.reader().readUnsignedByte();
                        Mob mob3 = Mob.get_Mob(iD3);
                        int num10 = msg.reader().readInt();
                        if (mob3 != null)
                        {
                            Char char6 = ((num10 != Char.getMyChar().charID) ? GameScr.findCharInMap(num10) : Char.getMyChar());
                            if (char6 != null)
                            {
                                char6.moveFast = new short[3];
                                char6.moveFast[0] = 0;
                                char6.moveFast[1] = (short)mob3.x;
                                char6.moveFast[2] = (short)mob3.y;
                            }
                        }
                        break;
                    }
                case 64:
                    {
                        GameCanvas.debug("SZ7", 2);
                        int num122 = msg.reader().readInt();
                        @char = ((num122 != Char.getMyChar().charID) ? GameScr.findCharInMap(num122) : Char.getMyChar());
                        @char.moveFast = new short[3];
                        @char.moveFast[0] = 0;
                        short num123 = msg.reader().readShort();
                        short num124 = msg.reader().readShort();
                        @char.moveFast[1] = num123;
                        @char.moveFast[2] = num124;
                        try
                        {
                            num122 = msg.reader().readInt();
                            char2 = ((num122 != Char.getMyChar().charID) ? GameScr.findCharInMap(num122) : Char.getMyChar());
                            char2.cx = num123;
                            char2.cy = num124;
                        }
                        catch (Exception)
                        {
                            Out.println(" loi tai cmd   " + msg.command);
                        }
                        break;
                    }
                case 92:
                    {
                        string info = msg.reader().readUTF();
                        short num121 = msg.reader().readShort();
                        GameCanvas.inputDlg.show(info, new Command(mResources.ACCEPT, GameCanvas.instance, 88818, num121), TField.INPUT_TYPE_ANY);
                        break;
                    }
                case 34:
                    {
                        MyVector myVector4 = new MyVector();
                        string text17 = msg.reader().readUTF();
                        if (!text17.Equals(string.Empty))
                        {
                            GameScr.gI().showAlert(null, text17, withMenuShow: true);
                        }
                        int num118 = msg.reader().readByte();
                        for (int num119 = 0; num119 < num118; num119++)
                        {
                            string caption = msg.reader().readUTF();
                            short num120 = msg.reader().readShort();
                            myVector4.addElement(new Command(caption, GameCanvas.instance, 88819, num120));
                        }
                        GameCanvas.menu.startAt(myVector4, 3);
                        break;
                    }
                case 40:
                    {
                        GameCanvas.debug("SA51", 2);
                        InfoDlg.hide();
                        GameCanvas.clearKeyHold();
                        GameCanvas.clearKeyPressed();
                        MyVector myVector3 = new MyVector();
                        Npc npcFocus = Char.getMyChar().npcFocus;
                        try
                        {
                            while (true)
                            {
                                myVector3.addElement(new Command(msg.reader().readUTF(), GameCanvas.instance, 88822, null));
                            }
                        }
                        catch (Exception)
                        {
                        }
                        if (npcFocus == null)
                        {
                            return;
                        }

                        
                        myVector3 = NPCMenuTemplate.getVectorMenu(myVector3, npcFocus.template.npcTemplateId);
                        for (int num117 = 0; num117 < npcFocus.template.menu.Length; num117++)
                        {
                            string[] array10 = npcFocus.template.menu[num117];
                            myVector3.addElement(new Command(array10[0], GameCanvas.instance, 88820, array10));
                        }
                        GameCanvas.menu.startAt(myVector3, 3);
                        break;
                    }
                case 109:
                    {
                        GameCanvas.debug("SA51", 2);
                        InfoDlg.hide();
                        GameCanvas.clearKeyHold();
                        GameCanvas.clearKeyPressed();
                        MyVector myVector2 = new MyVector();
                        try
                        {
                            int num113 = msg.reader().readByte();
                            for (int num114 = 0; num114 < num113; num114++)
                            {
                                string[] array9 = new string[msg.reader().readByte()];
                                for (int num115 = 0; num115 < array9.Length; num115++)
                                {
                                    array9[num115] = msg.reader().readUTF();
                                }
                                myVector2.addElement(new Command(array9[0], GameCanvas.instance, 88820, array9));
                            }
                        }
                        catch (Exception)
                        {
                        }
                        if (Char.getMyChar().npcFocus == null)
                        {
                            return;
                        }
                        GameCanvas.menu.startAt(myVector2, 3);
                        break;
                    }
                case 47:
                    {
                        GameCanvas.debug("SA52", 2);
                        GameCanvas.taskTick = 150;
                        short taskId = msg.reader().readShort();
                        sbyte index = msg.reader().readByte();
                        string name = msg.reader().readUTF();
                        string detail = msg.reader().readUTF();
                        string[] array6 = new string[msg.reader().readByte()];
                        short[] array7 = new short[array6.Length];
                        short count = -1;
                        for (int num107 = 0; num107 < array6.Length; num107++)
                        {
                            string text15 = msg.reader().readUTF();
                            array7[num107] = -1;
                            if (!text15.Equals(string.Empty))
                            {
                                array6[num107] = text15;
                            }
                        }
                        try
                        {
                            count = msg.reader().readShort();
                            for (int num108 = 0; num108 < array6.Length; num108++)
                            {
                                array7[num108] = msg.reader().readShort();
                            }
                        }
                        catch (Exception)
                        {
                        }
                        Char.getMyChar().taskMaint = new Task(taskId, index, name, detail, array6, array7, count);
                        Char.getMyChar().callEffTask(21);
                        if (Char.getMyChar().npcFocus != null)
                        {
                            Npc.clearEffTask();
                        }
                        break;
                    }
                case 48:
                    {
                        GameCanvas.debug("SA53", 2);
                        GameCanvas.taskTick = 100;
                        Task taskMaint = Char.getMyChar().taskMaint;
                        taskMaint.index++;
                        Char.getMyChar().taskMaint.count = 0;
                        if (Char.getMyChar().npcFocus != null && Char.getMyChar().npcFocus.chatPopup != null && Char.getMyChar().taskMaint.index >= 2)
                        {
                            Char.getMyChar().npcFocus.chatPopup = null;
                        }
                        if (Char.getMyChar().taskMaint.index >= Char.getMyChar().taskMaint.subNames.Length - 1)
                        {
                            Char.getMyChar().callEffTask(61);
                        }
                        else
                        {
                            Char.getMyChar().callEffTask(21);
                        }
                        Npc.clearEffTask();
                        break;
                    }
                case 49:
                    {
                        GameCanvas.debug("SA54", 2);
                        Char myChar2 = Char.getMyChar();
                        myChar2.ctaskId++;
                        Char.getMyChar().clearTask();
                        break;
                    }
                case 50:
                    GameCanvas.taskTick = 50;
                    GameCanvas.debug("SA55", 2);
                    Char.getMyChar().taskMaint.count = msg.reader().readShort();
                    if (Char.getMyChar().npcFocus != null)
                    {
                        Npc.clearEffTask();
                    }
                    break;
                case 93:
                    {
                        int num93 = msg.reader().readInt();
                        GameScr.currentCharViewInfo = new Char();
                        if (Char.getMyChar().charID == num93)
                        {
                            GameScr.currentCharViewInfo = Char.getMyChar();
                        }
                        else
                        {
                            Char char25 = GameScr.findCharInMap(num93);
                            if (char25 == null)
                            {
                                GameScr.currentCharViewInfo = new Char();
                            }
                            else
                            {
                                GameScr.currentCharViewInfo = char25;
                            }
                            GameScr.currentCharViewInfo.charID = num93;
                            GameScr.currentCharViewInfo.statusMe = 1;
                            GameScr.gI().showViewInfo();
                        }
                        GameScr.currentCharViewInfo.cName = msg.reader().readUTF();
                        GameScr.currentCharViewInfo.head = msg.reader().readShort();
                        GameScr.currentCharViewInfo.cgender = msg.reader().readByte();
                        int num94 = msg.reader().readByte();
                        GameScr.currentCharViewInfo.nClass = GameScr.nClasss[num94];
                        GameScr.currentCharViewInfo.cPk = msg.reader().readByte();
                        GameScr.currentCharViewInfo.cHP = msg.reader().readInt();
                        GameScr.currentCharViewInfo.cMaxHP = msg.reader().readInt();
                        GameScr.currentCharViewInfo.cMP = msg.reader().readInt();
                        GameScr.currentCharViewInfo.cMaxMP = msg.reader().readInt();
                        GameScr.currentCharViewInfo.cspeed = msg.reader().readByte();
                        GameScr.currentCharViewInfo.cResFire = msg.reader().readShort();
                        GameScr.currentCharViewInfo.cResIce = msg.reader().readShort();
                        GameScr.currentCharViewInfo.cResWind = msg.reader().readShort();
                        GameScr.currentCharViewInfo.cdame = msg.reader().readInt();
                        GameScr.currentCharViewInfo.cdameDown = msg.reader().readInt();
                        GameScr.currentCharViewInfo.cExactly = msg.reader().readShort();
                        GameScr.currentCharViewInfo.cMiss = msg.reader().readShort();
                        GameScr.currentCharViewInfo.cFatal = msg.reader().readShort();
                        GameScr.currentCharViewInfo.cReactDame = msg.reader().readShort();
                        GameScr.currentCharViewInfo.sysUp = msg.reader().readShort();
                        GameScr.currentCharViewInfo.sysDown = msg.reader().readShort();
                        GameScr.currentCharViewInfo.clevel = msg.reader().readUnsignedByte();
                        GameScr.currentCharViewInfo.pointUydanh = msg.reader().readShort();
                        GameScr.currentCharViewInfo.cClanName = msg.reader().readUTF();
                        if (!GameScr.currentCharViewInfo.cClanName.Equals(string.Empty))
                        {
                            GameScr.currentCharViewInfo.ctypeClan = msg.reader().readByte();
                        }
                        GameScr.currentCharViewInfo.pointUydanh = msg.reader().readShort();
                        GameScr.currentCharViewInfo.pointNon = msg.reader().readShort();
                        GameScr.currentCharViewInfo.pointAo = msg.reader().readShort();
                        GameScr.currentCharViewInfo.pointGangtay = msg.reader().readShort();
                        GameScr.currentCharViewInfo.pointQuan = msg.reader().readShort();
                        GameScr.currentCharViewInfo.pointGiay = msg.reader().readShort();
                        GameScr.currentCharViewInfo.pointVukhi = msg.reader().readShort();
                        GameScr.currentCharViewInfo.pointLien = msg.reader().readShort();
                        GameScr.currentCharViewInfo.pointNhan = msg.reader().readShort();
                        GameScr.currentCharViewInfo.pointNgocboi = msg.reader().readShort();
                        GameScr.currentCharViewInfo.pointPhu = msg.reader().readShort();
                        GameScr.currentCharViewInfo.countFinishDay = msg.reader().readByte();
                        GameScr.currentCharViewInfo.countLoopBoos = msg.reader().readByte();
                        GameScr.currentCharViewInfo.countPB = msg.reader().readByte();
                        GameScr.currentCharViewInfo.limitTiemnangso = msg.reader().readByte();
                        GameScr.currentCharViewInfo.limitKynangso = msg.reader().readByte();
                        GameScr.currentCharViewInfo.arrItemBody = new Item[32];
                        try
                        {
                            GameScr.currentCharViewInfo.setDefaultPart();
                            for (int num95 = 0; num95 < 16; num95++)
                            {
                                short num96 = msg.reader().readShort();
                                if (num96 > -1)
                                {
                                    ItemTemplate itemTemplate = ItemTemplates.get(num96);
                                    int type = itemTemplate.type;
                                    GameScr.currentCharViewInfo.arrItemBody[type] = new Item();
                                    GameScr.currentCharViewInfo.arrItemBody[type].indexUI = type;
                                    GameScr.currentCharViewInfo.arrItemBody[type].typeUI = 5;
                                    GameScr.currentCharViewInfo.arrItemBody[type].template = itemTemplate;
                                    GameScr.currentCharViewInfo.arrItemBody[type].isLock = true;
                                    GameScr.currentCharViewInfo.arrItemBody[type].upgrade = msg.reader().readByte();
                                    GameScr.currentCharViewInfo.arrItemBody[type].sys = msg.reader().readByte();
                                    switch (type)
                                    {
                                        case 1:
                                            GameScr.currentCharViewInfo.wp = GameScr.currentCharViewInfo.arrItemBody[type].template.part;
                                            break;
                                        case 2:
                                            GameScr.currentCharViewInfo.body = GameScr.currentCharViewInfo.arrItemBody[type].template.part;
                                            break;
                                        case 6:
                                            GameScr.currentCharViewInfo.leg = GameScr.currentCharViewInfo.arrItemBody[type].template.part;
                                            break;
                                    }
                                }
                            }
                        }
                        catch (Exception)
                        {
                        }
                        try
                        {
                            for (int num97 = 0; num97 < 16; num97++)
                            {
                                short num98 = msg.reader().readShort();
                                if (num98 > -1)
                                {
                                    ItemTemplate itemTemplate2 = ItemTemplates.get(num98);
                                    int num99 = itemTemplate2.type + 16;
                                    GameScr.currentCharViewInfo.arrItemBody[num99] = new Item();
                                    GameScr.currentCharViewInfo.arrItemBody[num99].indexUI = num99;
                                    GameScr.currentCharViewInfo.arrItemBody[num99].typeUI = 5;
                                    GameScr.currentCharViewInfo.arrItemBody[num99].template = itemTemplate2;
                                    GameScr.currentCharViewInfo.arrItemBody[num99].isLock = true;
                                    GameScr.currentCharViewInfo.arrItemBody[num99].upgrade = msg.reader().readByte();
                                    GameScr.currentCharViewInfo.arrItemBody[num99].sys = msg.reader().readByte();
                                    switch (num99)
                                    {
                                        case 1:
                                            GameScr.currentCharViewInfo.wp = GameScr.currentCharViewInfo.arrItemBody[num99].template.part;
                                            break;
                                        case 2:
                                            GameScr.currentCharViewInfo.body = GameScr.currentCharViewInfo.arrItemBody[num99].template.part;
                                            break;
                                        case 6:
                                            GameScr.currentCharViewInfo.leg = GameScr.currentCharViewInfo.arrItemBody[num99].template.part;
                                            break;
                                    }
                                }
                            }
                        }
                        catch (Exception)
                        {
                        }
                        break;
                    }
                case 101:
                    try
                    {
                        GameScr.currentCharViewInfo.pointTinhTu = msg.reader().readInt();
                        GameScr.currentCharViewInfo.limitPhongLoi = msg.reader().readByte();
                        GameScr.currentCharViewInfo.limitBangHoa = msg.reader().readByte();
                    }
                    catch (Exception)
                    {
                    }
                    break;
                case 42:
                    GameCanvas.debug("SA57", 2);
                    requestItemInfo(msg);
                    break;
                case 94:
                    GameCanvas.debug("SA577", 2);
                    requestItemPlayer(msg);
                    break;
                case 36:
                    GameCanvas.debug("SA58", 2);
                    GameScr.gI().openUIZone(msg);
                    break;
                case 37:
                    GameCanvas.debug("SA59", 2);
                    GameScr.gI().tradeName = msg.reader().readUTF();
                    GameScr.gI().openUITrade();
                    break;
                case -15:
                    {
                        GameCanvas.debug("SA60", 2);
                        short num87 = msg.reader().readShort();
                        for (int num88 = 0; num88 < GameScr.vItemMap.size(); num88++)
                        {
                            ItemMap itemMap6 = (ItemMap)GameScr.vItemMap.elementAt(num88);
                            if (itemMap6 != null && itemMap6.itemMapID == num87)
                            {
                                GameScr.vItemMap.removeElementAt(num88);
                                break;
                            }
                        }
                        break;
                    }
                case -14:
                    {
                        GameCanvas.debug("SA61", 2);
                        Char.getMyChar().itemFocus = null;
                        short num79 = msg.reader().readShort();
                        for (int num80 = 0; num80 < GameScr.vItemMap.size(); num80++)
                        {
                            ItemMap itemMap5 = (ItemMap)GameScr.vItemMap.elementAt(num80);
                            if (itemMap5.itemMapID != num79)
                            {
                                continue;
                            }
                            itemMap5.setPoint(Char.getMyChar().cx, Char.getMyChar().cy - 10);
                            if (itemMap5.template.type == 19)
                            {
                                num = msg.reader().readUnsignedShort();
                                Char myChar2 = Char.getMyChar();
                                myChar2.yen += num;
                                if (itemMap5.template.id != 238)
                                {
                                    InfoMe.addInfo(mResources.RECEIVE + " " + num + " " + mResources.YEN);
                                }
                            }
                            else if (itemMap5.template.type == 25 && itemMap5.template.id != 238)
                            {
                                InfoMe.addInfo(mResources.RECEIVE + " " + itemMap5.template.name, 15, mFont.tahoma_7_yellow);
                            }
                            break;
                        }
                        break;
                    }
                case -13:
                    {
                        GameCanvas.debug("SA62", 2);
                        short num70 = msg.reader().readShort();
                        for (int num71 = 0; num71 < GameScr.vItemMap.size(); num71++)
                        {
                            ItemMap itemMap4 = (ItemMap)GameScr.vItemMap.elementAt(num71);
                            if (itemMap4 == null || itemMap4.itemMapID != num70)
                            {
                                continue;
                            }
                            Char char22 = GameScr.findCharInMap(msg.reader().readInt());
                            if (char22 == null)
                            {
                                return;
                            }
                            itemMap4.setPoint(char22.cx, char22.cy - 10);
                            if (itemMap4.x < char22.cx)
                            {
                                char22.cdir = -1;
                            }
                            else if (itemMap4.x > char22.cx)
                            {
                                char22.cdir = 1;
                            }
                            break;
                        }
                        break;
                    }
                case -12:
                    {
                        GameCanvas.debug("SA63", 2);
                        int num69 = msg.reader().readByte();
                        GameScr.vItemMap.addElement(new ItemMap(msg.reader().readShort(), Char.getMyChar().arrItemBag[num69].template.id, Char.getMyChar().cx, Char.getMyChar().cy, msg.reader().readShort(), msg.reader().readShort()));
                        Char.getMyChar().arrItemBag[num69] = null;
                        break;
                    }
                case 6:
                    {
                        GameCanvas.debug("SA6333", 2);
                        ItemMap itemMap3 = new ItemMap(msg.reader().readShort(), msg.reader().readShort(), msg.reader().readShort(), msg.reader().readShort());
                        sbyte[] array2 = NinjaUtil.readByteArray_Int(msg);
                        if (array2 != null && array2.Length != 0)
                        {
                            itemMap3.imgCaptcha = new MyImage();
                            itemMap3.imgCaptcha.img = createImage(array2);
                        }
                        GameScr.vItemMap.addElement(itemMap3);
                        break;
                    }
                case 7:
                    GameCanvas.debug("SA633355", 2);
                    Char.getMyChar().arrItemBag[msg.reader().readByte()].quantity = msg.reader().readShort();
                    break;
                case 75:
                    {
                        GameCanvas.debug("SA6333e55", 2);
                        BuNhin buNhin3 = new BuNhin(msg.reader().readUTF(), msg.reader().readShort(), msg.reader().readShort());
                        GameScr.vBuNhin.addElement(buNhin3);
                        ServerEffect.addServerEffect(60, buNhin3.x, buNhin3.y, 1);
                        break;
                    }
                case 76:
                    {
                        GameCanvas.debug("SA6333e155", 2);
                        int iD10 = msg.reader().readUnsignedByte();
                        Mob mob4 = Mob.get_Mob(iD10);
                        if (mob4 != null)
                        {
                            BuNhin buNhin2 = GameScr.findBuNhinInMap(msg.reader().readShort());
                            if (buNhin2 == null)
                            {
                                return;
                            }
                            short idSkill_atk4 = msg.reader().readShort();
                            sbyte typeAtk4 = msg.reader().readByte();
                            sbyte typeTool4 = msg.reader().readByte();
                            mob4.setAttack(buNhin2);
                            mob4.setTypeAtk(idSkill_atk4, typeAtk4, typeTool4);
                        }
                        break;
                    }
                case 77:
                    {
                        GameCanvas.debug("SA6333e255", 2);
                        BuNhin buNhin = (BuNhin)GameScr.vBuNhin.elementAt(msg.reader().readShort());
                        if (buNhin != null)
                        {
                            GameScr.vBuNhin.removeElement(buNhin);
                            ServerEffect.addServerEffect(60, buNhin.x, buNhin.y, 1);
                        }
                        break;
                    }
                case -6:
                    {
                        GameCanvas.debug("SA64", 2);
                        Char char17 = GameScr.findCharInMap(msg.reader().readInt());
                        if (char17 == null)
                        {
                            return;
                        }
                        GameScr.vItemMap.addElement(new ItemMap(msg.reader().readShort(), msg.reader().readShort(), char17.cx, char17.cy, msg.reader().readShort(), msg.reader().readShort()));
                        break;
                    }
                case -16:
                    GameCanvas.debug("SA65", 2);
                    Char.isLockKey = true;
                    Char.ischangingMap = true;
                    Mob.vEggMonter.removeAllElements();
                    if (!Main.isPC)
                    {
                        GameCanvas.startWaitDlgIpad(mResources.PLEASEWAIT, isIpad: true);
                    }
                    GameScr.gI().timeStartMap = 0;
                    GameScr.gI().timeLengthMap = 0;
                    Char.getMyChar().mobFocus = null;
                    Char.getMyChar().npcFocus = null;
                    Char.getMyChar().charFocus = null;
                    Char.getMyChar().itemFocus = null;
                    Char.getMyChar().focus.removeAllElements();
                    Char.getMyChar().testCharId = -9999;
                    Char.getMyChar().killCharId = -9999;
                    GameScr.resetAllvector();
                    GameCanvas.resetBg();
                    if (GameScr.vParty.size() <= 1)
                    {
                        GameScr.vParty.removeAllElements();
                    }
                    GameScr.gI().resetButton();
                    GameScr.gI().center = null;
                    break;
                case 30:
                    {
                        sbyte typeUI = msg.reader().readByte();
                        try
                        {
                            GameScr.svTitle = msg.reader().readUTF();
                            GameScr.svAction = msg.reader().readUTF();
                        }
                        catch (Exception)
                        {
                        }
                        GameScr.gI().doOpenUI(typeUI);
                        break;
                    }
                case 38:
                    {
                        GameCanvas.debug("SA67", 2);
                        int num45 = msg.reader().readShort();
                        for (int num46 = 0; num46 < GameScr.vNpc.size(); num46++)
                        {
                            Npc npc2 = (Npc)GameScr.vNpc.elementAt(num46);
                            if (npc2 != null && npc2.template.npcTemplateId == num45 && npc2.Equals(Char.getMyChar().npcFocus))
                            {
                                ChatPopup.addChatPopupMultiLine(msg.reader().readUTF(), 1000, npc2);
                                break;
                            }
                        }
                        break;
                    }
                case 39:
                    {
                        GameCanvas.debug("SA68", 2);
                        int num42 = msg.reader().readShort();
                        for (int num43 = 0; num43 < GameScr.vNpc.size(); num43++)
                        {
                            Npc npc = (Npc)GameScr.vNpc.elementAt(num43);
                            if (npc != null && npc.template.npcTemplateId == num42 && npc.Equals(Char.getMyChar().npcFocus))
                            {
                                ChatPopup.addChatPopup(msg.reader().readUTF(), 1000, npc);
                                string[] array = new string[msg.reader().readByte()];
                                for (int num44 = 0; num44 < array.Length; num44++)
                                {
                                    array[num44] = msg.reader().readUTF();
                                }
                                GameScr.gI().createMenu(array, npc);
                                break;
                            }
                        }
                        break;
                    }
                case 31:
                    {
                        GameCanvas.debug("SA69", 2);
                        Char.getMyChar().xuInBox = msg.reader().readInt();
                        Char.getMyChar().arrItemBox = new Item[msg.reader().readUnsignedByte()];
                        for (int n = 0; n < Char.getMyChar().arrItemBox.Length; n++)
                        {
                            short num17 = msg.reader().readShort();
                            if (num17 != -1)
                            {
                                Char.getMyChar().arrItemBox[n] = new Item();
                                Char.getMyChar().arrItemBox[n].typeUI = 4;
                                Char.getMyChar().arrItemBox[n].indexUI = n;
                                Char.getMyChar().arrItemBox[n].template = ItemTemplates.get(num17);
                                Char.getMyChar().arrItemBox[n].isLock = msg.reader().readBoolean();
                                if (Char.getMyChar().arrItemBox[n].isTypeBody() || Char.getMyChar().arrItemBox[n].isTypeNgocKham())
                                {
                                    Char.getMyChar().arrItemBox[n].upgrade = msg.reader().readByte();
                                }
                                Char.getMyChar().arrItemBox[n].isExpires = msg.reader().readBoolean();
                                Char.getMyChar().arrItemBox[n].quantity = msg.reader().readShort();
                            }
                        }
                        break;
                    }
                case 13:
                    GameCanvas.debug("SA70", 2);
                    Char.getMyChar().xu = msg.reader().readInt();
                    Char.getMyChar().yen = msg.reader().readInt();
                    Char.getMyChar().luong = msg.reader().readInt();
                    GameCanvas.endDlg();
                    break;
                case 33:
                    {
                        GameCanvas.debug("SA72", 2);
                        sbyte b3 = msg.reader().readByte();
                        switch (b3)
                        {
                            case 14:
                                {
                                    GameScr.arrItemStore = new Item[msg.reader().readByte()];
                                    for (int num33 = 0; num33 < GameScr.arrItemStore.Length; num33++)
                                    {
                                        GameScr.arrItemStore[num33] = new Item();
                                        GameScr.arrItemStore[num33].typeUI = 14;
                                        GameScr.arrItemStore[num33].indexUI = msg.reader().readUnsignedByte();
                                        GameScr.arrItemStore[num33].template = ItemTemplates.get(msg.reader().readShort());
                                    }
                                    break;
                                }
                            case 15:
                                {
                                    GameScr.arrItemBook = new Item[msg.reader().readByte()];
                                    for (int num41 = 0; num41 < GameScr.arrItemBook.Length; num41++)
                                    {
                                        GameScr.arrItemBook[num41] = new Item();
                                        GameScr.arrItemBook[num41].typeUI = 15;
                                        GameScr.arrItemBook[num41].indexUI = msg.reader().readUnsignedByte();
                                        GameScr.arrItemBook[num41].template = ItemTemplates.get(msg.reader().readShort());
                                    }
                                    break;
                                }
                            case 32:
                                {
                                    GameScr.arrItemFashion = new Item[msg.reader().readByte()];
                                    for (int num25 = 0; num25 < GameScr.arrItemFashion.Length; num25++)
                                    {
                                        GameScr.arrItemFashion[num25] = new Item();
                                        GameScr.arrItemFashion[num25].typeUI = 32;
                                        GameScr.arrItemFashion[num25].indexUI = msg.reader().readUnsignedByte();
                                        GameScr.arrItemFashion[num25].template = ItemTemplates.get(msg.reader().readShort());
                                    }
                                    break;
                                }
                            case 34:
                                {
                                    GameScr.arrItemClanShop = new Item[msg.reader().readByte()];
                                    for (int num37 = 0; num37 < GameScr.arrItemClanShop.Length; num37++)
                                    {
                                        GameScr.arrItemClanShop[num37] = new Item();
                                        GameScr.arrItemClanShop[num37].typeUI = 34;
                                        GameScr.arrItemClanShop[num37].indexUI = msg.reader().readUnsignedByte();
                                        GameScr.arrItemClanShop[num37].template = ItemTemplates.get(msg.reader().readShort());
                                    }
                                    break;
                                }
                            case 35:
                                {
                                    GameScr.arrItemElites = new Item[msg.reader().readByte()];
                                    for (int num29 = 0; num29 < GameScr.arrItemElites.Length; num29++)
                                    {
                                        GameScr.arrItemElites[num29] = new Item();
                                        GameScr.arrItemElites[num29].typeUI = 35;
                                        GameScr.arrItemElites[num29].indexUI = msg.reader().readUnsignedByte();
                                        GameScr.arrItemElites[num29].template = ItemTemplates.get(msg.reader().readShort());
                                    }
                                    break;
                                }
                            case 20:
                                {
                                    GameScr.arrItemNonNam = new Item[msg.reader().readByte()];
                                    for (int num21 = 0; num21 < GameScr.arrItemNonNam.Length; num21++)
                                    {
                                        GameScr.arrItemNonNam[num21] = new Item();
                                        GameScr.arrItemNonNam[num21].typeUI = b3;
                                        GameScr.arrItemNonNam[num21].indexUI = msg.reader().readUnsignedByte();
                                        GameScr.arrItemNonNam[num21].template = ItemTemplates.get(msg.reader().readShort());
                                    }
                                    break;
                                }
                            case 21:
                                {
                                    GameScr.arrItemNonNu = new Item[msg.reader().readByte()];
                                    for (int num39 = 0; num39 < GameScr.arrItemNonNu.Length; num39++)
                                    {
                                        GameScr.arrItemNonNu[num39] = new Item();
                                        GameScr.arrItemNonNu[num39].typeUI = b3;
                                        GameScr.arrItemNonNu[num39].indexUI = msg.reader().readUnsignedByte();
                                        GameScr.arrItemNonNu[num39].template = ItemTemplates.get(msg.reader().readShort());
                                    }
                                    break;
                                }
                            case 22:
                                {
                                    GameScr.arrItemAoNam = new Item[msg.reader().readByte()];
                                    for (int num35 = 0; num35 < GameScr.arrItemAoNam.Length; num35++)
                                    {
                                        GameScr.arrItemAoNam[num35] = new Item();
                                        GameScr.arrItemAoNam[num35].typeUI = b3;
                                        GameScr.arrItemAoNam[num35].indexUI = msg.reader().readUnsignedByte();
                                        GameScr.arrItemAoNam[num35].template = ItemTemplates.get(msg.reader().readShort());
                                    }
                                    break;
                                }
                            case 23:
                                {
                                    GameScr.arrItemAoNu = new Item[msg.reader().readByte()];
                                    for (int num31 = 0; num31 < GameScr.arrItemAoNu.Length; num31++)
                                    {
                                        GameScr.arrItemAoNu[num31] = new Item();
                                        GameScr.arrItemAoNu[num31].typeUI = b3;
                                        GameScr.arrItemAoNu[num31].indexUI = msg.reader().readUnsignedByte();
                                        GameScr.arrItemAoNu[num31].template = ItemTemplates.get(msg.reader().readShort());
                                    }
                                    break;
                                }
                            case 24:
                                {
                                    GameScr.arrItemGangTayNam = new Item[msg.reader().readByte()];
                                    for (int num27 = 0; num27 < GameScr.arrItemGangTayNam.Length; num27++)
                                    {
                                        GameScr.arrItemGangTayNam[num27] = new Item();
                                        GameScr.arrItemGangTayNam[num27].typeUI = b3;
                                        GameScr.arrItemGangTayNam[num27].indexUI = msg.reader().readUnsignedByte();
                                        GameScr.arrItemGangTayNam[num27].template = ItemTemplates.get(msg.reader().readShort());
                                    }
                                    break;
                                }
                            case 25:
                                {
                                    GameScr.arrItemGangTayNu = new Item[msg.reader().readByte()];
                                    for (int num23 = 0; num23 < GameScr.arrItemGangTayNu.Length; num23++)
                                    {
                                        GameScr.arrItemGangTayNu[num23] = new Item();
                                        GameScr.arrItemGangTayNu[num23].typeUI = b3;
                                        GameScr.arrItemGangTayNu[num23].indexUI = msg.reader().readUnsignedByte();
                                        GameScr.arrItemGangTayNu[num23].template = ItemTemplates.get(msg.reader().readShort());
                                    }
                                    break;
                                }
                            case 26:
                                {
                                    GameScr.arrItemQuanNam = new Item[msg.reader().readByte()];
                                    for (int num19 = 0; num19 < GameScr.arrItemQuanNam.Length; num19++)
                                    {
                                        GameScr.arrItemQuanNam[num19] = new Item();
                                        GameScr.arrItemQuanNam[num19].typeUI = b3;
                                        GameScr.arrItemQuanNam[num19].indexUI = msg.reader().readUnsignedByte();
                                        GameScr.arrItemQuanNam[num19].template = ItemTemplates.get(msg.reader().readShort());
                                    }
                                    break;
                                }
                            case 27:
                                {
                                    GameScr.arrItemQuanNu = new Item[msg.reader().readByte()];
                                    for (int num40 = 0; num40 < GameScr.arrItemQuanNu.Length; num40++)
                                    {
                                        GameScr.arrItemQuanNu[num40] = new Item();
                                        GameScr.arrItemQuanNu[num40].typeUI = b3;
                                        GameScr.arrItemQuanNu[num40].indexUI = msg.reader().readUnsignedByte();
                                        GameScr.arrItemQuanNu[num40].template = ItemTemplates.get(msg.reader().readShort());
                                    }
                                    break;
                                }
                            case 28:
                                {
                                    GameScr.arrItemGiayNam = new Item[msg.reader().readByte()];
                                    for (int num38 = 0; num38 < GameScr.arrItemGiayNam.Length; num38++)
                                    {
                                        GameScr.arrItemGiayNam[num38] = new Item();
                                        GameScr.arrItemGiayNam[num38].typeUI = b3;
                                        GameScr.arrItemGiayNam[num38].indexUI = msg.reader().readUnsignedByte();
                                        GameScr.arrItemGiayNam[num38].template = ItemTemplates.get(msg.reader().readShort());
                                    }
                                    break;
                                }
                            case 29:
                                {
                                    GameScr.arrItemGiayNu = new Item[msg.reader().readByte()];
                                    for (int num36 = 0; num36 < GameScr.arrItemGiayNu.Length; num36++)
                                    {
                                        GameScr.arrItemGiayNu[num36] = new Item();
                                        GameScr.arrItemGiayNu[num36].typeUI = b3;
                                        GameScr.arrItemGiayNu[num36].indexUI = msg.reader().readUnsignedByte();
                                        GameScr.arrItemGiayNu[num36].template = ItemTemplates.get(msg.reader().readShort());
                                    }
                                    break;
                                }
                            case 16:
                                {
                                    GameScr.arrItemLien = new Item[msg.reader().readByte()];
                                    for (int num34 = 0; num34 < GameScr.arrItemLien.Length; num34++)
                                    {
                                        GameScr.arrItemLien[num34] = new Item();
                                        GameScr.arrItemLien[num34].typeUI = b3;
                                        GameScr.arrItemLien[num34].indexUI = msg.reader().readUnsignedByte();
                                        GameScr.arrItemLien[num34].template = ItemTemplates.get(msg.reader().readShort());
                                    }
                                    break;
                                }
                            case 17:
                                {
                                    GameScr.arrItemNhan = new Item[msg.reader().readByte()];
                                    for (int num32 = 0; num32 < GameScr.arrItemNhan.Length; num32++)
                                    {
                                        GameScr.arrItemNhan[num32] = new Item();
                                        GameScr.arrItemNhan[num32].typeUI = b3;
                                        GameScr.arrItemNhan[num32].indexUI = msg.reader().readUnsignedByte();
                                        GameScr.arrItemNhan[num32].template = ItemTemplates.get(msg.reader().readShort());
                                    }
                                    break;
                                }
                            case 18:
                                {
                                    GameScr.arrItemNgocBoi = new Item[msg.reader().readByte()];
                                    for (int num30 = 0; num30 < GameScr.arrItemNgocBoi.Length; num30++)
                                    {
                                        GameScr.arrItemNgocBoi[num30] = new Item();
                                        GameScr.arrItemNgocBoi[num30].typeUI = b3;
                                        GameScr.arrItemNgocBoi[num30].indexUI = msg.reader().readUnsignedByte();
                                        GameScr.arrItemNgocBoi[num30].template = ItemTemplates.get(msg.reader().readShort());
                                    }
                                    break;
                                }
                            case 19:
                                {
                                    GameScr.arrItemPhu = new Item[msg.reader().readByte()];
                                    for (int num28 = 0; num28 < GameScr.arrItemPhu.Length; num28++)
                                    {
                                        GameScr.arrItemPhu[num28] = new Item();
                                        GameScr.arrItemPhu[num28].typeUI = b3;
                                        GameScr.arrItemPhu[num28].indexUI = msg.reader().readUnsignedByte();
                                        GameScr.arrItemPhu[num28].template = ItemTemplates.get(msg.reader().readShort());
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    GameScr.arrItemWeapon = new Item[msg.reader().readByte()];
                                    for (int num26 = 0; num26 < GameScr.arrItemWeapon.Length; num26++)
                                    {
                                        GameScr.arrItemWeapon[num26] = new Item();
                                        GameScr.arrItemWeapon[num26].typeUI = b3;
                                        GameScr.arrItemWeapon[num26].indexUI = msg.reader().readUnsignedByte();
                                        GameScr.arrItemWeapon[num26].template = ItemTemplates.get(msg.reader().readShort());
                                    }
                                    break;
                                }
                            case 6:
                                {
                                    GameScr.arrItemStack = new Item[msg.reader().readByte()];
                                    for (int num24 = 0; num24 < GameScr.arrItemStack.Length; num24++)
                                    {
                                        GameScr.arrItemStack[num24] = new Item();
                                        GameScr.arrItemStack[num24].typeUI = b3;
                                        GameScr.arrItemStack[num24].indexUI = msg.reader().readUnsignedByte();
                                        GameScr.arrItemStack[num24].template = ItemTemplates.get(msg.reader().readShort());
                                    }
                                    break;
                                }
                            case 7:
                                {
                                    GameScr.arrItemStackLock = new Item[msg.reader().readByte()];
                                    for (int num22 = 0; num22 < GameScr.arrItemStackLock.Length; num22++)
                                    {
                                        GameScr.arrItemStackLock[num22] = new Item();
                                        GameScr.arrItemStackLock[num22].typeUI = b3;
                                        GameScr.arrItemStackLock[num22].isLock = true;
                                        GameScr.arrItemStackLock[num22].indexUI = msg.reader().readUnsignedByte();
                                        GameScr.arrItemStackLock[num22].template = ItemTemplates.get(msg.reader().readShort());
                                    }
                                    break;
                                }
                            case 8:
                                {
                                    GameScr.arrItemGrocery = new Item[msg.reader().readByte()];
                                    for (int num20 = 0; num20 < GameScr.arrItemGrocery.Length; num20++)
                                    {
                                        GameScr.arrItemGrocery[num20] = new Item();
                                        GameScr.arrItemGrocery[num20].typeUI = b3;
                                        GameScr.arrItemGrocery[num20].indexUI = msg.reader().readUnsignedByte();
                                        GameScr.arrItemGrocery[num20].template = ItemTemplates.get(msg.reader().readShort());
                                    }
                                    break;
                                }
                            case 9:
                                {
                                    GameScr.arrItemGroceryLock = new Item[msg.reader().readByte()];
                                    for (int num18 = 0; num18 < GameScr.arrItemGroceryLock.Length; num18++)
                                    {
                                        GameScr.arrItemGroceryLock[num18] = new Item();
                                        GameScr.arrItemGroceryLock[num18].typeUI = b3;
                                        GameScr.arrItemGroceryLock[num18].isLock = true;
                                        GameScr.arrItemGroceryLock[num18].indexUI = msg.reader().readUnsignedByte();
                                        GameScr.arrItemGroceryLock[num18].template = ItemTemplates.get(msg.reader().readShort());
                                    }
                                    break;
                                }
                        }
                        break;
                    }
                case 103:
                    {
                        GameScr.indexMenu = msg.reader().readByte();
                        GameScr.arrItemStands = new ItemStands[msg.reader().readInt()];
                        for (int m = 0; m < GameScr.arrItemStands.Length; m++)
                        {
                            GameScr.arrItemStands[m] = new ItemStands();
                            GameScr.arrItemStands[m].item = new Item();
                            GameScr.arrItemStands[m].item.itemId = msg.reader().readInt();
                            GameScr.arrItemStands[m].timeStart = (int)(mSystem.getCurrentTimeMillis() / 1000);
                            GameScr.arrItemStands[m].timeEnd = msg.reader().readInt();
                            GameScr.arrItemStands[m].item.quantity = msg.reader().readUnsignedShort();
                            GameScr.arrItemStands[m].seller = msg.reader().readUTF();
                            GameScr.arrItemStands[m].price = msg.reader().readInt();
                            GameScr.arrItemStands[m].item.template = ItemTemplates.get(msg.reader().readShort());
                        }
                        GameScr.gI().doOpenUI(37);
                        break;
                    }
                case 104:
                    viewItemAuction(msg);
                    break;
                case 102:
                    {
                        GameCanvas.debug("SA74565", 2);
                        Item item3 = Char.getMyChar().arrItemBag[msg.reader().readByte()];
                        if (item3 != null)
                        {
                            GameScr.itemSell = item3;
                        }
                        Char.getMyChar().xu = msg.reader().readInt();
                        if (GameScr.itemSell != null)
                        {
                            if (GameScr.itemSell.template.type == 16)
                            {
                                GameScr.hpPotion -= GameScr.itemSell.quantity;
                            }
                            if (GameScr.itemSell.template.type == 17)
                            {
                                GameScr.mpPotion -= GameScr.itemSell.quantity;
                            }
                            Char.getMyChar().arrItemBag[GameScr.itemSell.indexUI] = null;
                            GameScr.itemSell = null;
                            GameScr.gI().resetButton();
                            InfoMe.addInfo(mResources.SALE_INFO);
                        }
                        GameCanvas.endDlg();
                        break;
                    }
                case 14:
                    {
                        Item item2 = Char.getMyChar().arrItemBag[msg.reader().readByte()];
                        Char.getMyChar().yen = msg.reader().readInt();
                        int num6 = 0;
                        try
                        {
                            num6 = msg.reader().readShort();
                        }
                        catch (Exception)
                        {
                            num6 = 1;
                        }
                        Item item = item2;
                        item.quantity -= num6;
                        if (item2.template.type == 16)
                        {
                            GameScr.hpPotion -= num6;
                        }
                        if (item2.template.type == 17)
                        {
                            GameScr.mpPotion -= num6;
                        }
                        if (item2.quantity <= 0)
                        {
                            Char.getMyChar().arrItemBag[item2.indexUI] = null;
                        }
                        GameScr.gI().left = (GameScr.gI().center = null);
                        GameScr.gI().updateCommandForUI();
                        GameCanvas.endDlg();
                        break;
                    }
                case -18:
                    GameCanvas.isLoading = true;
                    GameScr.resetAllvector();
                    TileMap.vGo.removeAllElements();
                    TileMap.mapID = msg.reader().readUnsignedByte();
                    TileMap.tileID = msg.reader().readByte();
                    TileMap.bgID = msg.reader().readByte();
                    TileMap.typeMap = msg.reader().readByte();
                    TileMap.mapName = msg.reader().readUTF();
                    TileMap.zoneID = msg.reader().readByte();
                    try
                    {
                        TileMap.loadMapFromResource(TileMap.mapID);
                    }
                    catch (Exception)
                    {
                        Out.println("load map from server: " + TileMap.mapID);
                        Service.gI().requestMaptemplate(TileMap.mapID);
                        messWait = msg;
                        return;
                    }
                    Resources.UnloadUnusedAssets();
                    GC.Collect();
                    loadInfoMap(msg);
                    if (Char.getMyChar().mobMe != null)
                    {
                        Char.getMyChar().mobMe.x = Char.getMyChar().cx;
                        Char.getMyChar().mobMe.y = Char.getMyChar().cy - 40;
                    }
                    break;
                case 4:
                    {
                        GameCanvas.debug("SA76", 2);
                        Char char28 = GameScr.findCharInMap(msg.reader().readInt());
                        if (char28 == null)
                        {
                            return;
                        }
                        GameCanvas.debug("SA76v1", 2);
                        if ((TileMap.tileTypeAtPixel(char28.cx, char28.cy) & TileMap.T_TOP) == TileMap.T_TOP)
                        {
                            char28.setSkillPaint(GameScr.sks[msg.reader().readByte()], 0);
                        }
                        else
                        {
                            char28.setSkillPaint(GameScr.sks[msg.reader().readByte()], 1);
                        }
                        if (char28.isWolf)
                        {
                            char28.isWolf = false;
                            char28.timeSummon = mSystem.currentTimeMillis();
                            if (char28.vitaWolf >= 500)
                            {
                                ServerEffect.addServerEffect(60, char28, 1);
                            }
                        }
                        if (char28.isMoto)
                        {
                            char28.isMoto = false;
                            char28.isMotoBehind = true;
                        }
                        GameCanvas.debug("SA76v2", 2);
                        int num109 = msg.reader().readByte();
                        char28.attMobs = new Mob[num109];
                        for (int num110 = 0; num110 < char28.attMobs.Length; num110++)
                        {
                            int iD14 = msg.reader().readUnsignedByte();
                            mob = Mob.get_Mob(iD14);
                            char28.attMobs[num110] = mob;
                            if (num110 == 0)
                            {
                                if (char28.cx <= mob.x)
                                {
                                    char28.cdir = 1;
                                }
                                else
                                {
                                    char28.cdir = -1;
                                }
                            }
                        }
                        GameCanvas.debug("SA76v3", 2);
                        char28.mobFocus = char28.attMobs[0];
                        Char[] array8 = new Char[10];
                        int num111 = 0;
                        try
                        {
                            for (num111 = 0; num111 < array8.Length; num111++)
                            {
                                int num112 = msg.reader().readInt();
                                Char char29 = (array8[num111] = ((num112 != Char.getMyChar().charID) ? GameScr.findCharInMap(num112) : Char.getMyChar()));
                                if (num111 == 0)
                                {
                                    if (char28.cx <= char29.cx)
                                    {
                                        char28.cdir = 1;
                                    }
                                    else
                                    {
                                        char28.cdir = -1;
                                    }
                                }
                            }
                        }
                        catch (Exception)
                        {
                        }
                        GameCanvas.debug("SA76v4", 2);
                        if (num111 > 0)
                        {
                            char28.attChars = new Char[num111];
                            for (num111 = 0; num111 < char28.attChars.Length; num111++)
                            {
                                char28.attChars[num111] = array8[num111];
                            }
                            char28.charFocus = char28.attChars[0];
                        }
                        GameCanvas.debug("SA76v5", 2);
                        break;
                    }
                case 60:
                    {
                        GameCanvas.debug("SA769991", 2);
                        Char char27 = GameScr.findCharInMap(msg.reader().readInt());
                        if (char27 == null)
                        {
                            return;
                        }
                        if ((TileMap.tileTypeAtPixel(char27.cx, char27.cy) & TileMap.T_TOP) == TileMap.T_TOP)
                        {
                            sbyte b9 = msg.reader().readByte();
                            char27.setSkillPaint(GameScr.sks[b9], 0);
                            Mob.interestChar.myskill.template.id = b9;
                        }
                        else
                        {
                            sbyte b10 = msg.reader().readByte();
                            char27.setSkillPaint(GameScr.sks[b10], 1);
                            Mob.interestChar.myskill.template.id = b10;
                        }
                        GameCanvas.debug("SA769991v2", 2);
                        if (char27.isWolf)
                        {
                            char27.isWolf = false;
                            char27.timeSummon = mSystem.currentTimeMillis();
                            if (char27.vitaWolf >= 500)
                            {
                                ServerEffect.addServerEffect(60, char27, 1);
                            }
                        }
                        if (char27.isMoto)
                        {
                            char27.isMoto = false;
                            char27.isMotoBehind = true;
                            ServerEffect.addServerEffect(60, char27, 1);
                        }
                        Mob[] array5 = new Mob[10];
                        int num105 = 0;
                        try
                        {
                            for (num105 = 0; num105 < array5.Length; num105++)
                            {
                                if (msg.reader().available() <= 0)
                                {
                                    break;
                                }
                                int iD13 = msg.reader().readUnsignedByte();
                                mob = (array5[num105] = Mob.get_Mob(iD13));
                                if (num105 == 0)
                                {
                                    if (char27.cx <= mob.x)
                                    {
                                        char27.cdir = 1;
                                    }
                                    else
                                    {
                                        char27.cdir = -1;
                                    }
                                }
                            }
                        }
                        catch (Exception)
                        {
                            Out.println("bi vang ra");
                        }
                        GameCanvas.debug("SA769992", 2);
                        if (num105 > 0)
                        {
                            char27.attMobs = new Mob[num105];
                            for (num105 = 0; num105 < char27.attMobs.Length; num105++)
                            {
                                char27.attMobs[num105] = array5[num105];
                            }
                            char27.mobFocus = char27.attMobs[0];
                        }
                        break;
                    }
                case 61:
                    {
                        GameCanvas.debug("SA7666", 2);
                        Char char23 = GameScr.findCharInMap(msg.reader().readInt());
                        if (char23 == null)
                        {
                            return;
                        }
                        if ((TileMap.tileTypeAtPixel(char23.cx, char23.cy) & TileMap.T_TOP) == TileMap.T_TOP)
                        {
                            sbyte b7 = msg.reader().readByte();
                            char23.setSkillPaint(GameScr.sks[b7], 0);
                        }
                        else
                        {
                            sbyte b8 = msg.reader().readByte();
                            char23.setSkillPaint(GameScr.sks[b8], 1);
                        }
                        if (char23.isWolf)
                        {
                            char23.isWolf = false;
                            char23.timeSummon = mSystem.getCurrentTimeMillis();
                            if (char23.vitaWolf >= 500)
                            {
                                ServerEffect.addServerEffect(60, char23, 1);
                            }
                        }
                        if (char23.isMoto)
                        {
                            char23.isMoto = false;
                            char23.isMotoBehind = true;
                            ServerEffect.addServerEffect(60, char23, 1);
                        }
                        Char[] array4 = new Char[10];
                        int num90 = 0;
                        try
                        {
                            for (num90 = 0; num90 < array4.Length; num90++)
                            {
                                int num91 = msg.reader().readInt();
                                Char char24 = (array4[num90] = ((num91 != Char.getMyChar().charID) ? GameScr.findCharInMap(num91) : Char.getMyChar()));
                                if (num90 == 0)
                                {
                                    if (char23.cx <= char24.cx)
                                    {
                                        char23.cdir = 1;
                                    }
                                    else
                                    {
                                        char23.cdir = -1;
                                    }
                                }
                            }
                        }
                        catch (Exception)
                        {
                        }
                        GameCanvas.debug("SA7666x7", 2);
                        if (num90 > 0)
                        {
                            char23.attChars = new Char[num90];
                            for (num90 = 0; num90 < char23.attChars.Length; num90++)
                            {
                                char23.attChars[num90] = array4[num90];
                            }
                            char23.charFocus = char23.attChars[0];
                        }
                        break;
                    }
                case -8:
                    {
                        GameCanvas.debug("SA77", 22);
                        int num89 = msg.reader().readInt();
                        Char myChar2 = Char.getMyChar();
                        myChar2.yen += num89;
                        GameScr.gI().yenTemp = num89;
                        GameScr.startFlyText((num89 <= 0) ? (string.Empty + num89) : ("+" + num89), Char.getMyChar().cx, Char.getMyChar().cy - Char.getMyChar().ch - 10, 0, -2, mFont.YELLOW);
                        break;
                    }
                case 95:
                    {
                        GameCanvas.debug("SA77", 22);
                        int num83 = msg.reader().readInt();
                        Char myChar2 = Char.getMyChar();
                        myChar2.xu += num83;
                        GameScr.startFlyText((num83 <= 0) ? (string.Empty + num83) : ("+" + num83), Char.getMyChar().cx, Char.getMyChar().cy - Char.getMyChar().ch - 10, 0, -2, mFont.YELLOW);
                        break;
                    }
                case 96:
                    GameCanvas.debug("SA77a", 22);
                    Char.getMyChar().taskOrders.addElement(new TaskOrder(msg.reader().readByte(), msg.reader().readInt(), msg.reader().readInt(), msg.reader().readUTF(), msg.reader().readUTF(), msg.reader().readUnsignedByte(), msg.reader().readUnsignedByte()));
                    Char.getMyChar().callEffTask(21);
                    break;
                case 97:
                    {
                        sbyte b6 = msg.reader().readByte();
                        for (int num81 = 0; num81 < Char.getMyChar().taskOrders.size(); num81++)
                        {
                            TaskOrder taskOrder2 = (TaskOrder)Char.getMyChar().taskOrders.elementAt(num81);
                            if (taskOrder2 != null && taskOrder2.taskId == b6)
                            {
                                taskOrder2.count = msg.reader().readInt();
                                if (taskOrder2.count == taskOrder2.maxCount)
                                {
                                    Char.getMyChar().callEffTask(61);
                                }
                                break;
                            }
                        }
                        break;
                    }
                case 98:
                    {
                        sbyte b4 = msg.reader().readByte();
                        for (int num72 = 0; num72 < Char.getMyChar().taskOrders.size(); num72++)
                        {
                            TaskOrder taskOrder = (TaskOrder)Char.getMyChar().taskOrders.elementAt(num72);
                            if (taskOrder != null && taskOrder.taskId == b4)
                            {
                                Char.getMyChar().taskOrders.removeElementAt(num72);
                                break;
                            }
                        }
                        Char.getMyChar().callEffTask(21);
                        break;
                    }
                case -7:
                    {
                        GameCanvas.debug("SA77", 222);
                        num = msg.reader().readInt();
                        Char myChar2 = Char.getMyChar();
                        myChar2.xu += num;
                        myChar2 = Char.getMyChar();
                        myChar2.yen -= num;
                        GameScr.startFlyText("+" + num, Char.getMyChar().cx, Char.getMyChar().cy - Char.getMyChar().ch - 10, 0, -2, mFont.YELLOW);
                        break;
                    }
                case 5:
                    {
                        GameCanvas.debug("SA78", 2);
                        long num68 = msg.reader().readLong();
                        Char.getMyChar().cExpDown = 0L;
                        Char myChar2 = Char.getMyChar();
                        myChar2.cEXP += num68;
                        int clevel = Char.getMyChar().clevel;
                        GameScr.setLevel_Exp(Char.getMyChar().cEXP, value: true);
                        if (clevel != Char.getMyChar().clevel)
                        {
                            ServerEffect.addServerEffect(58, Char.getMyChar(), 1);
                        }
                        GameScr.startFlyText("+" + num68, Char.getMyChar().cx, Char.getMyChar().cy - Char.getMyChar().ch, 0, -2, mFont.GREEN);
                        if (num68 >= 1000000)
                        {
                            InfoMe.addInfo(mResources.RECEIVE + " " + num68 + " " + mResources.EXP, 20, mFont.tahoma_7_yellow);
                        }
                        break;
                    }
                case 71:
                    {
                        long num67 = msg.reader().readLong();
                        Char myChar2 = Char.getMyChar();
                        myChar2.cExpDown -= num67;
                        GameScr.startFlyText("+" + num67, Char.getMyChar().cx, Char.getMyChar().cy - Char.getMyChar().ch, 0, -2, mFont.GREEN);
                        break;
                    }
                case 116:
                    {
                        int charId4 = msg.reader().readInt();
                        Char char21 = GameScr.findCharInMap(charId4);
                        if (char21 != null)
                        {
                            readCharInfo(char21, msg);
                        }
                        break;
                    }
                case 3:
                    {
                        GameCanvas.debug("SA79", 2);
                        Char char20 = new Char();
                        char20.charID = msg.reader().readInt();
                        if (readCharInfo(char20, msg))
                        {
                            GameScr.vCharInMap.addElement(char20);
                        }
                        break;
                    }
                case 1:
                    {
                        GameCanvas.debug("SA80", 2);
                        int num62 = msg.reader().readInt();
                        for (int num63 = 0; num63 < GameScr.vCharInMap.size(); num63++)
                        {
                            Char char19 = null;
                            try
                            {
                                char19 = (Char)GameScr.vCharInMap.elementAt(num63);
                            }
                            catch (Exception)
                            {
                            }
                            if (char19 == null)
                            {
                                break;
                            }
                            if (char19.charID == num62)
                            {
                                GameCanvas.debug("SA8x2y" + num63, 2);
                                char19.cxMoveLast = msg.reader().readShort();
                                char19.cyMoveLast = msg.reader().readShort();
                                char19.moveTo(char19.cxMoveLast, char19.cyMoveLast);
                                char19.lastUpdateTime = mSystem.getCurrentTimeMillis();
                                break;
                            }
                        }
                        GameCanvas.debug("SA80x3", 2);
                        break;
                    }
                case 2:
                    {
                        GameCanvas.debug("SA81", 2);
                        int num60 = msg.reader().readInt();
                        for (int num61 = 0; num61 < GameScr.vCharInMap.size(); num61++)
                        {
                            Char char18 = (Char)GameScr.vCharInMap.elementAt(num61);
                            if (char18 != null && char18.charID == num60)
                            {
                                if (!char18.isInvisible)
                                {
                                    ServerEffect.addServerEffect(60, char18.cx, char18.cy, 1);
                                }
                                GameScr.vCharInMap.removeElementAt(num61);
                                Party.clear(num60);
                                return;
                            }
                        }
                        break;
                    }
                case -5:
                    GameCanvas.debug("SA82", 2);
                    try
                    {
                        int iD11 = msg.reader().readUnsignedByte();
                        mob = Mob.get_Mob(iD11);
                        mob.sys = msg.reader().readByte();
                        mob.levelBoss = msg.reader().readByte();
                        mob.x = mob.xFirst;
                        mob.y = mob.yFirst;
                        mob.status = 5;
                        mob.injureThenDie = false;
                        mob.hp = msg.reader().readInt();
                        mob.maxHp = mob.hp;
                        if (mob.getTemplate().mobTemplateId == 202)
                        {
                            ServerEffect.addServerEffect(148, mob.x, mob.y, 0);
                        }
                        else
                        {
                            ServerEffect.addServerEffect(60, mob.x, mob.y, 1);
                        }
                    }
                    catch (Exception)
                    {
                    }
                    break;
                case -1:
                    {
                        GameCanvas.debug("SA83", 2);
                        mob = null;
                        try
                        {
                            int iD9 = msg.reader().readUnsignedByte();
                            mob = Mob.get_Mob(iD9);
                        }
                        catch (Exception)
                        {
                        }
                        GameCanvas.debug("SA83v1", 2);
                        if (mob == null)
                        {
                            break;
                        }
                        mob.hp = msg.reader().readInt();
                        int num53 = msg.reader().readInt();
                        if (num53 < 0)
                        {
                            num53 = Res.abs(num53) + 32767;
                        }
                        bool flag = msg.reader().readBoolean();
                        try
                        {
                            if (msg.reader().available() > 0)
                            {
                                mob.levelBoss = msg.reader().readByte();
                            }
                            mob.maxHp = msg.reader().readInt();
                        }
                        catch (Exception)
                        {
                        }
                        if (flag)
                        {
                            GameScr.startFlyText("-" + num53, mob.x, mob.y - mob.h, 0, -2, mFont.FATAL);
                        }
                        else
                        {
                            GameScr.startFlyText("-" + num53, mob.x, mob.y - mob.h, 0, -2, mFont.ORANGE);
                        }
                        break;
                    }
                case 51:
                    mob = null;
                    try
                    {
                        int iD8 = msg.reader().readUnsignedByte();
                        mob = Mob.get_Mob(iD8);
                    }
                    catch (Exception)
                    {
                    }
                    if (mob != null)
                    {
                        mob.hp = msg.reader().readInt();
                        GameScr.startFlyText(string.Empty, mob.x, mob.y - mob.h, 0, -2, mFont.MISS);
                    }
                    break;
                case -4:
                    mob = null;
                    try
                    {
                        int iD7 = msg.reader().readUnsignedByte();
                        mob = Mob.get_Mob(iD7);
                    }
                    catch (Exception)
                    {
                    }
                    if (mob == null || mob.status == 0 || mob.status == 0)
                    {
                        break;
                    }
                    mob.startDie();
                    try
                    {
                        int num48 = msg.reader().readInt();
                        if (num48 < 0)
                        {
                            num48 = Res.abs(num48) + 32767;
                        }
                        if (msg.reader().readBoolean())
                        {
                            GameScr.startFlyText("-" + num48, mob.x, mob.y - mob.h, 0, -2, mFont.FATAL);
                        }
                        else
                        {
                            GameScr.startFlyText("-" + num48, mob.x, mob.y - mob.h, 0, -2, mFont.ORANGE);
                        }
                        ItemMap itemMap2 = new ItemMap(msg.reader().readShort(), msg.reader().readShort(), mob.x, mob.y, msg.reader().readShort(), msg.reader().readShort());
                        GameScr.vItemMap.addElement(itemMap2);
                        if (Res.abs(itemMap2.y - Char.getMyChar().cy) < 24 && Res.abs(itemMap2.x - Char.getMyChar().cx) < 24)
                        {
                            Char.getMyChar().charFocus = null;
                        }
                    }
                    catch (Exception)
                    {
                    }
                    break;
                case 78:
                    GameCanvas.debug("SA85", 2);
                    mob = null;
                    try
                    {
                        int iD6 = msg.reader().readUnsignedByte();
                        mob = Mob.get_Mob(iD6);
                    }
                    catch (Exception)
                    {
                    }
                    if (mob != null && mob.status != 0 && mob.status != 0)
                    {
                        mob.status = 0;
                        ServerEffect.addServerEffect(60, mob.x, mob.y, 1);
                        ItemMap itemMap = new ItemMap(msg.reader().readShort(), msg.reader().readShort(), mob.x, mob.y, msg.reader().readShort(), msg.reader().readShort());
                        GameScr.vItemMap.addElement(itemMap);
                        if (Res.abs(itemMap.y - Char.getMyChar().cy) < 24 && Res.abs(itemMap.x - Char.getMyChar().cx) < 24)
                        {
                            Char.getMyChar().charFocus = null;
                        }
                    }
                    break;
                case -3:
                    GameCanvas.debug("SA86", 2);
                    mob = null;
                    try
                    {
                        int iD5 = msg.reader().readUnsignedByte();
                        mob = Mob.get_Mob(iD5);
                    }
                    catch (Exception)
                    {
                    }
                    if (mob != null)
                    {
                        int num15 = msg.reader().readInt();
                        int num16;
                        try
                        {
                            num16 = msg.reader().readInt();
                        }
                        catch (Exception)
                        {
                            num16 = 0;
                        }
                        if (mob.isBusyAttackSomeOne)
                        {
                            Char.getMyChar().doInjure(num15, num16, isBoss: false, -1);
                            mob.attackOtherInRange();
                        }
                        else
                        {
                            mob.dame = num15;
                            mob.dameMp = num16;
                            mob.setAttack(Char.getMyChar());
                        }
                        short idSkill_atk3 = msg.reader().readShort();
                        sbyte typeAtk3 = msg.reader().readByte();
                        sbyte typeTool3 = msg.reader().readByte();
                        mob.setTypeAtk(idSkill_atk3, typeAtk3, typeTool3);
                    }
                    break;
                case -2:
                    {
                        GameCanvas.debug("SA87", 2);
                        mob = null;
                        try
                        {
                            int iD4 = msg.reader().readUnsignedByte();
                            mob = Mob.get_Mob(iD4);
                        }
                        catch (Exception)
                        {
                        }
                        int charId3 = msg.reader().readInt();
                        int num13 = msg.reader().readInt();
                        GameCanvas.debug("SA87x1", 2);
                        if (mob != null)
                        {
                            GameCanvas.debug("SA87x2", 2);
                            Char char8 = GameScr.findCharInMap(charId3);
                            if (char8 == null)
                            {
                                return;
                            }
                            GameCanvas.debug("SA87x3", 2);
                            mob.dame = char8.cHP - num13;
                            char8.cHpNew = num13;
                            GameCanvas.debug("SA87x4", 2);
                            try
                            {
                                char8.cMP = msg.reader().readInt();
                            }
                            catch (Exception)
                            {
                            }
                            GameCanvas.debug("SA87x5", 2);
                            if (mob.isBusyAttackSomeOne)
                            {
                                char8.doInjure(mob.dame, 0, isBoss: false, -1);
                                mob.attackOtherInRange();
                            }
                            else
                            {
                                mob.setAttack(char8);
                            }
                            short idSkill_atk2 = msg.reader().readShort();
                            sbyte typeAtk2 = msg.reader().readByte();
                            sbyte typeTool2 = msg.reader().readByte();
                            mob.setTypeAtk(idSkill_atk2, typeAtk2, typeTool2);
                            GameCanvas.debug("SA87x6", 2);
                        }
                        break;
                    }
                case -11:
                    GameCanvas.debug("SA88", 2);
                    Char.getMyChar().cPk = msg.reader().readByte();
                    Char.getMyChar().waitToDie(msg.reader().readShort(), msg.reader().readShort());
                    try
                    {
                        Char.getMyChar().cEXP = msg.reader().readLong();
                        GameScr.setLevel_Exp(Char.getMyChar().cEXP, value: true);
                    }
                    catch (Exception)
                    {
                    }
                    Char.getMyChar().countKill = 0;
                    break;
                case 72:
                    GameCanvas.debug("SA88", 2);
                    Char.getMyChar().cPk = msg.reader().readByte();
                    Char.getMyChar().waitToDie(msg.reader().readShort(), msg.reader().readShort());
                    Char.getMyChar().cEXP = GameScr.getMaxExp(Char.getMyChar().clevel - 1);
                    Char.getMyChar().cExpDown = msg.reader().readLong();
                    GameScr.setLevel_Exp(Char.getMyChar().cEXP, value: true);
                    break;
                case 0:
                    {
                        GameCanvas.debug("SA89", 2);
                        Char char7 = GameScr.findCharInMap(msg.reader().readInt());
                        if (char7 == null)
                        {
                            return;
                        }
                        char7.cPk = msg.reader().readByte();
                        if (char7.charID == Char.aCID)
                        {
                            Char.isAFocusDie = true;
                        }
                        char7.waitToDie(msg.reader().readShort(), msg.reader().readShort());
                        if (Char.getMyChar().charFocus == char7)
                        {
                            Char.getMyChar().charFocus = null;
                        }
                        break;
                    }
                case -10:
                    GameCanvas.debug("SA90", 2);
                    if (Char.getMyChar().wdx != 0 || Char.getMyChar().wdy != 0)
                    {
                        Char.getMyChar().cx = Char.getMyChar().wdx;
                        Char.getMyChar().cy = Char.getMyChar().wdy;
                        Char.getMyChar().wdx = (Char.getMyChar().wdy = 0);
                    }
                    Char.getMyChar().liveFromDead();
                    Char.isLockKey = false;
                    break;
                case -23:
                    {
                        GameCanvas.debug("SA91", 2);
                        int num5 = msg.reader().readInt();
                        string text = msg.reader().readUTF();
                        Char char4 = ((Char.getMyChar().charID != num5) ? GameScr.findCharInMap(num5) : Char.getMyChar());
                        if (char4 == null)
                        {
                            return;
                        }
                        ChatPopup.addChatPopup(text, 100, char4);
                        ChatManager.gI().addChat(mResources.PUBLICCHAT[0], char4.cName, text);
                        break;
                    }
                case 25:
                    {
                        sbyte b = msg.reader().readByte();
                        for (int i = 0; i < b; i++)
                        {
                            int charId = msg.reader().readInt();
                            int cx = msg.reader().readShort();
                            int cy = msg.reader().readShort();
                            int hPShow = msg.reader().readInt();
                            Char char3 = GameScr.findCharInMap(charId);
                            if (char3 != null)
                            {
                                char3.cx = cx;
                                char3.cy = cy;
                                char3.cHP = (char3.HPShow = hPShow);
                                char3.lastUpdateTime = mSystem.getCurrentTimeMillis();
                            }
                        }
                        break;
                    }
                case 26:
                    Char.getMyChar().countKill = msg.reader().readUnsignedShort();
                    Char.getMyChar().countKillMax = msg.reader().readUnsignedShort();
                    break;
                case 126:
                    {
                        int num2 = msg.reader().readByte();
                        GameCanvas.endDlg();
                        if (num2 == 0)
                        {
                            GameScr.instance.resetButton();
                        }
                        break;
                    }
            }
            GameCanvas.debug("SA92", 2);
        }
        catch (Exception ex40)
        {
            Out.println("loi tai cmd " + msg.command + " ly do >> " + ex40.ToString());
        }
        finally
        {
            msg?.cleanup();
        }
    }

    private void createItem(myReader d)
    {
        GameScr.vcItem = d.readByte();
        GameScr.iOptionTemplates = new ItemOptionTemplate[d.readUnsignedByte()];
        for (int i = 0; i < GameScr.iOptionTemplates.Length; i++)
        {
            GameScr.iOptionTemplates[i] = new ItemOptionTemplate();
            GameScr.iOptionTemplates[i].id = i;
            GameScr.iOptionTemplates[i].name = d.readUTF();
            GameScr.iOptionTemplates[i].type = d.readByte();
        }
        int num = d.readShort();
        for (int j = 0; j < num; j++)
        {
            ItemTemplate it = new ItemTemplate((short)j, d.readByte(), d.readByte(), d.readUTF(), d.readUTF(), d.readByte(), d.readShort(), d.readShort(), d.readBoolean());
            ItemTemplates.add(it);
        }
    }

    private void createSkill(myReader d)
    {
        GameScr.vcSkill = d.readByte();
        GameScr.sOptionTemplates = new SkillOptionTemplate[d.readByte()];
        for (int i = 0; i < GameScr.sOptionTemplates.Length; i++)
        {
            GameScr.sOptionTemplates[i] = new SkillOptionTemplate();
            GameScr.sOptionTemplates[i].id = i;
            GameScr.sOptionTemplates[i].name = d.readUTF();
        }
        GameScr.nClasss = new NClass[d.readUnsignedByte()];
        for (int j = 0; j < GameScr.nClasss.Length; j++)
        {
            GameScr.nClasss[j] = new NClass();
            GameScr.nClasss[j].classId = j;
            GameScr.nClasss[j].name = d.readUTF();
            GameScr.nClasss[j].skillTemplates = new SkillTemplate[d.readByte()];
            for (int k = 0; k < GameScr.nClasss[j].skillTemplates.Length; k++)
            {
                GameScr.nClasss[j].skillTemplates[k] = new SkillTemplate();
                GameScr.nClasss[j].skillTemplates[k].id = d.readByte();
                GameScr.nClasss[j].skillTemplates[k].name = d.readUTF();
                GameScr.nClasss[j].skillTemplates[k].maxPoint = d.readByte();
                GameScr.nClasss[j].skillTemplates[k].type = d.readByte();
                GameScr.nClasss[j].skillTemplates[k].iconId = d.readShort();
                int lineWidth = 150;
                if (GameCanvas.w == 128 || GameCanvas.h <= 208)
                {
                    lineWidth = 100;
                }
                GameScr.nClasss[j].skillTemplates[k].description = mFont.tahoma_7_white.splitFontArray(d.readUTF(), lineWidth);
                GameScr.nClasss[j].skillTemplates[k].skills = new Skill[d.readByte()];
                for (int l = 0; l < GameScr.nClasss[j].skillTemplates[k].skills.Length; l++)
                {
                    GameScr.nClasss[j].skillTemplates[k].skills[l] = new Skill();
                    GameScr.nClasss[j].skillTemplates[k].skills[l].skillId = d.readShort();
                    GameScr.nClasss[j].skillTemplates[k].skills[l].template = GameScr.nClasss[j].skillTemplates[k];
                    GameScr.nClasss[j].skillTemplates[k].skills[l].point = d.readByte();
                    GameScr.nClasss[j].skillTemplates[k].skills[l].level = d.readByte();
                    GameScr.nClasss[j].skillTemplates[k].skills[l].manaUse = d.readShort();
                    GameScr.nClasss[j].skillTemplates[k].skills[l].coolDown = d.readInt();
                    GameScr.nClasss[j].skillTemplates[k].skills[l].dx = d.readShort();
                    GameScr.nClasss[j].skillTemplates[k].skills[l].dy = d.readShort();
                    GameScr.nClasss[j].skillTemplates[k].skills[l].maxFight = d.readByte();
                    GameScr.nClasss[j].skillTemplates[k].skills[l].options = new SkillOption[d.readByte()];
                    for (int m = 0; m < GameScr.nClasss[j].skillTemplates[k].skills[l].options.Length; m++)
                    {
                        GameScr.nClasss[j].skillTemplates[k].skills[l].options[m] = new SkillOption();
                        GameScr.nClasss[j].skillTemplates[k].skills[l].options[m].param = d.readShort();
                        GameScr.nClasss[j].skillTemplates[k].skills[l].options[m].optionTemplate = GameScr.sOptionTemplates[d.readByte()];
                    }
                    Skills.add(GameScr.nClasss[j].skillTemplates[k].skills[l]);
                }
            }
        }
    }

    private void createMap(myReader d)
    {
        GameScr.vcMap = d.readByte();
        TileMap.mapNames = new string[d.readUnsignedByte()];
        for (int i = 0; i < TileMap.mapNames.Length; i++)
        {
            TileMap.mapNames[i] = d.readUTF();
        }
        Npc.arrNpcTemplate = new NpcTemplate[d.readByte()];
        for (sbyte b = 0; b < Npc.arrNpcTemplate.Length; b = (sbyte)(b + 1))
        {
            Npc.arrNpcTemplate[b] = new NpcTemplate();
            Npc.arrNpcTemplate[b].npcTemplateId = b;
            Npc.arrNpcTemplate[b].name = d.readUTF();
            Npc.arrNpcTemplate[b].headId = d.readShort();
            Npc.arrNpcTemplate[b].bodyId = d.readShort();
            Npc.arrNpcTemplate[b].legId = d.readShort();
            Npc.arrNpcTemplate[b].menu = new string[d.readByte()][];
            for (int j = 0; j < Npc.arrNpcTemplate[b].menu.Length; j++)
            {
                Npc.arrNpcTemplate[b].menu[j] = new string[d.readByte()];
                for (int k = 0; k < Npc.arrNpcTemplate[b].menu[j].Length; k++)
                {
                    Npc.arrNpcTemplate[b].menu[j][k] = d.readUTF();
                }
            }
        }
        int num = d.readUnsignedByte();
        Mob.arrMobTemplate = new MobTemplate[num];
        for (int l = 0; l < num; l++)
        {
            Mob.arrMobTemplate[l] = new MobTemplate();
            Mob.arrMobTemplate[l].mobTemplateId = (short)l;
            Mob.arrMobTemplate[l].type = d.readByte();
            Mob.arrMobTemplate[l].name = d.readUTF();
            Mob.arrMobTemplate[l].hp = d.readInt();
            Mob.arrMobTemplate[l].rangeMove = d.readByte();
            Mob.arrMobTemplate[l].speed = d.readByte();
        }
    }

    private void createData(myReader d)
    {
        GameScr.vcData = d.readByte();
        RMS.saveRMS("nj_arrow", NinjaUtil.readByteArray(d));
        RMS.saveRMS("nj_effect", NinjaUtil.readByteArray(d));
        RMS.saveRMS("nj_image", NinjaUtil.readByteArray(d));
        RMS.saveRMS("nj_part", NinjaUtil.readByteArray(d));
        RMS.saveRMS("nj_skill", NinjaUtil.readByteArray(d));
        GameScr.tasks = new sbyte[d.readByte()][];
        GameScr.mapTasks = new sbyte[GameScr.tasks.Length][];
        for (int i = 0; i < GameScr.tasks.Length; i++)
        {
            GameScr.tasks[i] = new sbyte[d.readByte()];
            GameScr.mapTasks[i] = new sbyte[GameScr.tasks[i].Length];
            for (int j = 0; j < GameScr.tasks[i].Length; j++)
            {
                GameScr.tasks[i][j] = d.readByte();
                GameScr.mapTasks[i][j] = d.readByte();
            }
        }
        GameScr.exps = new long[d.readUnsignedByte()];
        for (int k = 0; k < GameScr.exps.Length; k++)
        {
            GameScr.exps[k] = d.readLong();
        }
        GameScr.crystals = new int[d.readByte()];
        for (int l = 0; l < GameScr.crystals.Length; l++)
        {
            GameScr.crystals[l] = d.readInt();
        }
        GameScr.upClothe = new int[d.readByte()];
        for (int m = 0; m < GameScr.upClothe.Length; m++)
        {
            GameScr.upClothe[m] = d.readInt();
        }
        GameScr.upAdorn = new int[d.readByte()];
        for (int n = 0; n < GameScr.upAdorn.Length; n++)
        {
            GameScr.upAdorn[n] = d.readInt();
        }
        GameScr.upWeapon = new int[d.readByte()];
        for (int num = 0; num < GameScr.upWeapon.Length; num++)
        {
            GameScr.upWeapon[num] = d.readInt();
        }
        GameScr.coinUpCrystals = new int[d.readByte()];
        for (int num2 = 0; num2 < GameScr.coinUpCrystals.Length; num2++)
        {
            GameScr.coinUpCrystals[num2] = d.readInt();
        }
        GameScr.coinUpClothes = new int[d.readByte()];
        for (int num3 = 0; num3 < GameScr.coinUpClothes.Length; num3++)
        {
            GameScr.coinUpClothes[num3] = d.readInt();
        }
        GameScr.coinUpAdorns = new int[d.readByte()];
        for (int num4 = 0; num4 < GameScr.coinUpAdorns.Length; num4++)
        {
            GameScr.coinUpAdorns[num4] = d.readInt();
        }
        GameScr.coinUpWeapons = new int[d.readByte()];
        for (int num5 = 0; num5 < GameScr.coinUpWeapons.Length; num5++)
        {
            GameScr.coinUpWeapons[num5] = d.readInt();
        }
        GameScr.goldUps = new int[d.readByte()];
        for (int num6 = 0; num6 < GameScr.goldUps.Length; num6++)
        {
            GameScr.goldUps[num6] = d.readInt();
        }
        GameScr.maxPercents = new int[d.readByte()];
        for (int num7 = 0; num7 < GameScr.maxPercents.Length; num7++)
        {
            GameScr.maxPercents[num7] = d.readInt();
        }
        Effect.effTemplates = new EffectTemplate[d.readByte()];
        for (int num8 = 0; num8 < Effect.effTemplates.Length; num8++)
        {
            Effect.effTemplates[num8] = new EffectTemplate();
            Effect.effTemplates[num8].id = d.readByte();
            Effect.effTemplates[num8].type = d.readByte();
            Effect.effTemplates[num8].name = d.readUTF();
            Effect.effTemplates[num8].iconId = d.readShort();
        }
    }

    public static Image createImage(sbyte[] arr)
    {
        try
        {
            return Image.createImage(arr, 0, arr.Length);
        }
        catch (Exception)
        {
            Out.println("loi tao hinh tai createImage cua controler");
        }
        return null;
    }

    public int[] arraysbyte2Int(sbyte[] b)
    {
        int[] array = new int[b.Length];
        for (int i = 0; i < b.Length; i++)
        {
            int num = b[i];
            if (num < 0)
            {
                num += 256;
            }
            array[i] = num;
        }
        return array;
    }

    public void loadInfoMap(Message msg)
    {
        try
        {
            Char.getMyChar().cx = (Char.getMyChar().cxSend = (Char.getMyChar().cxFocus = msg.reader().readShort()));
            Char.getMyChar().cy = (Char.getMyChar().cySend = (Char.getMyChar().cyFocus = msg.reader().readShort()));
            int num = msg.reader().readByte();
            for (int i = 0; i < num; i++)
            {
                TileMap.vGo.addElement(new Waypoint(msg.reader().readShort(), msg.reader().readShort(), msg.reader().readShort(), msg.reader().readShort()));
            }
            num = msg.reader().readByte();
            for (sbyte b = 0; b < num; b = (sbyte)(b + 1))
            {
                Mob mob = new Mob(b, msg.reader().readBoolean(), msg.reader().readBoolean(), msg.reader().readBoolean(), msg.reader().readBoolean(), msg.reader().readBoolean(), msg.reader().readUnsignedByte(), msg.reader().readByte(), msg.reader().readInt(), msg.reader().readUnsignedByte(), msg.reader().readInt(), msg.reader().readShort(), msg.reader().readShort(), msg.reader().readByte(), msg.reader().readByte(), msg.reader().readBoolean(), removeWhenDie: false);
                if (Mob.arrMobTemplate[mob.templateId].type != 0)
                {
                    if (b % 3 == 0)
                    {
                        mob.dir = -1;
                    }
                    else
                    {
                        mob.dir = 1;
                    }
                    mob.x += 10 - b % 20;
                }
                GameScr.vMob.addElement(mob);
            }
            num = msg.reader().readByte();
            for (byte b2 = 0; b2 < num; b2 = (byte)(b2 + 1))
            {
                GameScr.vBuNhin.addElement(new BuNhin(msg.reader().readUTF(), msg.reader().readShort(), msg.reader().readShort()));
            }
            num = msg.reader().readByte();
            for (int j = 0; j < num; j++)
            {
                GameScr.vNpc.addElement(new Npc(j, msg.reader().readByte(), msg.reader().readShort(), msg.reader().readShort(), msg.reader().readByte()));
            }
            num = msg.reader().readByte();
            for (int k = 0; k < num; k++)
            {
                ItemMap itemMap = new ItemMap(msg.reader().readShort(), msg.reader().readShort(), msg.reader().readShort(), msg.reader().readShort());
                bool flag = false;
                for (int l = 0; l < GameScr.vItemMap.size(); l++)
                {
                    ItemMap itemMap2 = (ItemMap)GameScr.vItemMap.elementAt(l);
                    if (itemMap2.itemMapID == itemMap.itemMapID)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    GameScr.vItemMap.addElement(itemMap);
                }
            }
            GameScr.loadCamera(fullScreen: false);
            try
            {
                TileMap.mapName1 = null;
                TileMap.mapName1 = msg.reader().readUTF();
                TileMap.mapName = TileMap.mapName1;
            }
            catch (Exception)
            {
            }
            try
            {
                TileMap.locationStand.clear();
                int num2 = msg.reader().readUnsignedByte();
                for (int m = 0; m < num2; m++)
                {
                    int num3 = msg.reader().readUnsignedByte();
                    int num4 = msg.reader().readUnsignedByte();
                    string k2 = (short)(num4 * TileMap.tmw + num3) + string.Empty;
                    TileMap.locationStand.put(k2, "location");
                }
            }
            catch (Exception ex2)
            {
                ex2.ToString();
            }
            TileMap.loadMap(TileMap.tileID);
            Char.getMyChar().cvx = 0;
            Char.getMyChar().statusMe = 4;
            GameScr.gI().loadGameScr();
            GameCanvas.loadBG(TileMap.bgID);
            Char.isLockKey = false;
            Char.ischangingMap = false;
            GameCanvas.clearKeyHold();
            GameCanvas.clearKeyPressed();
            GameScr.gI().switchToMe();
            InfoDlg.hide();
            InfoDlg.show(TileMap.mapName, mResources.ZONE + " " + TileMap.zoneID, 30);
            Party.refreshAll();
            GameCanvas.endDlg();
            GameCanvas.isLoading = false;
        }
        catch (Exception ex3)
        {
            Debug.Log("EROR: " + ex3.Message);
        }
    }

    public void messageNotMap(Message msg)
    {
        GameCanvas.debug("SA6", 2);
        try
        {
            switch (msg.reader().readByte())
            {
                case -59:
                    GameMidlet.instance.CheckPerGPS();
                    break;
                case -98:
                    Char.getMyChar().clearTask();
                    break;
                case -99:
                    {
                        GameCanvas.input2Dlg.setTitle(mResources.SERI_NUM, mResources.CARD_CODE);
                        string info = msg.reader().readUTF();
                        GameCanvas.input2Dlg.show(info, new Command(mResources.CLOSE, GameCanvas.instance, 8882, null), new Command(mResources.CHARGE, GameCanvas.instance, 88816, null), TField.INPUT_TYPE_ANY, TField.INPUT_TYPE_NUMERIC);
                        break;
                    }
                case -97:
                    {
                        GameCanvas.isLoading = false;
                        GameCanvas.endDlg();
                        int num6 = msg.reader().readInt();
                        GameCanvas.inputDlg.show(mResources.NAME_CHANGE, new Command("OK", GameCanvas.instance, 88829, num6), TField.INPUT_TYPE_ANY);
                        break;
                    }
                case -115:
                    {
                        int id = msg.reader().readInt();
                        sbyte[] data = NinjaUtil.readByteArray(msg);
                        SmallImage.reciveImage(id, data);
                        break;
                    }
                case -117:
                    Char.getMyChar().cPk = msg.reader().readByte();
                    Info.addInfo(mResources.PK_NOW + " " + Char.getMyChar().cPk, 15, mFont.tahoma_7_yellow);
                    Char.getMyChar().callEffTask(21);
                    break;
                case -96:
                    Char.getMyChar().cClanName = msg.reader().readUTF();
                    Char.getMyChar().ctypeClan = 4;
                    Char.getMyChar().luong = msg.reader().readInt();
                    Char.getMyChar().callEffTask(21);
                    break;
                case -113:
                    Out.println("vao REQUEST_CLAN_INFO roi ");
                    if (Char.clan == null)
                    {
                        Char.clan = new Clan();
                    }
                    Char.clan.name = msg.reader().readUTF();
                    Char.clan.main_name = msg.reader().readUTF();
                    Char.clan.assist_name = msg.reader().readUTF();
                    Char.clan.total = msg.reader().readShort();
                    Char.clan.openDun = msg.reader().readByte();
                    Char.clan.level = msg.reader().readByte();
                    Char.clan.exp = msg.reader().readInt();
                    Char.clan.expNext = msg.reader().readInt();
                    Char.clan.coin = msg.reader().readInt();
                    Char.clan.freeCoin = msg.reader().readInt();
                    Char.clan.coinUp = msg.reader().readInt();
                    Char.clan.reg_date = msg.reader().readUTF();
                    Char.clan.alert = msg.reader().readUTF();
                    Char.clan.use_card = msg.reader().readInt();
                    Char.clan.itemLevel = msg.reader().readByte();
                    break;
                case -93:
                    {
                        int num17 = msg.reader().readInt();
                        if (num17 == Char.getMyChar().charID)
                        {
                            GameScr.vClan.removeAllElements();
                            Char.getMyChar().cClanName = string.Empty;
                            Char.getMyChar().ctypeClan = -1;
                            Char.clan = null;
                        }
                        else
                        {
                            GameScr.vClan.removeAllElements();
                            Char char3 = GameScr.findCharInMap(num17);
                            char3.cClanName = string.Empty;
                            char3.ctypeClan = -1;
                        }
                        break;
                    }
                case -114:
                    if (Char.clan == null)
                    {
                        Char.clan = new Clan();
                    }
                    Char.clan.writeLog(msg.reader().readUTF());
                    break;
                case -62:
                    Char.clan.itemLevel = msg.reader().readByte();
                    break;
                case -81:
                    Char.pointChienTruong = msg.reader().readShort();
                    break;
                case -77:
                    TileMap.bgID = msg.reader().readByte();
                    GameCanvas.loadBG(TileMap.bgID);
                    break;
                case -70:
                    {
                        string replacement = msg.reader().readUTF();
                        GameCanvas.startYesNoDlg(NinjaUtil.replace(mResources.INVITE_TO_CBT, "#", replacement), new Command(mResources.YES, GameCanvas.instance, 88842, null), new Command(mResources.NO, GameCanvas.instance, 8882, null));
                        break;
                    }
                case -72:
                    {
                        GameScr.gI().yenValue = new string[9];
                        GameScr.arrItemSprin = new short[9];
                        if (GameScr.indexSelect < 0 || GameScr.indexSelect > 8)
                        {
                            GameScr.indexSelect = (GameScr.indexCard = 0);
                        }
                        if (GameScr.indexSelect < 0 || GameScr.indexSelect > 8)
                        {
                            GameScr.indexSelect = (GameScr.indexCard = 0);
                        }
                        for (int k = 0; k < 9; k++)
                        {
                            GameScr.arrItemSprin[k] = msg.reader().readShort();
                            GameScr.gI().yenValue[k] = GameScr.gI().YenCards[NinjaUtil.randomNumber(6)];
                        }
                        GameScr.gI().left = new Command(mResources.CONTINUE, null, 1506, null);
                        GameScr.gI().timePoint = mSystem.getCurrentTimeMillis();
                        GameScr.gI().numSprinLeft--;
                        GameCanvas.endDlg();
                        break;
                    }
                case -88:
                    {
                        GameScr.gI().resetButton();
                        Item item = Char.getMyChar().arrItemBag[msg.reader().readByte()];
                        item.clearExpire();
                        item.isLock = true;
                        item.upgrade = msg.reader().readByte();
                        Item item2 = Char.getMyChar().arrItemBag[msg.reader().readByte()];
                        item2.clearExpire();
                        item2.isLock = true;
                        item2.upgrade = msg.reader().readByte();
                        Info.addInfo(mResources.CONVERT_OK, 20, mFont.tahoma_7b_yellow);
                        break;
                    }
                case -112:
                    {
                        GameScr.vClan.removeAllElements();
                        int num2 = msg.reader().readShort();
                        for (int i = 0; i < num2; i++)
                        {
                            GameScr.vClan.addElement(new Member(msg.reader().readByte(), msg.reader().readByte(), msg.reader().readByte(), msg.reader().readUTF(), msg.reader().readInt(), msg.reader().readBoolean()));
                        }
                        try
                        {
                            for (int j = 0; j < num2; j++)
                            {
                                ((Member)GameScr.vClan.elementAt(j)).pointClanWeek = msg.reader().readInt();
                            }
                        }
                        catch (Exception)
                        {
                        }
                        GameScr.gI().sortClan();
                        break;
                    }
                case -111:
                    {
                        Char.clan.items = new Item[30];
                        int num18 = msg.reader().readByte();
                        for (int num19 = 0; num19 < num18; num19++)
                        {
                            Char.clan.items[num19] = new Item();
                            Char.clan.items[num19].typeUI = 39;
                            Char.clan.items[num19].indexUI = num19;
                            Char.clan.items[num19].quantity = msg.reader().readShort();
                            Char.clan.items[num19].template = ItemTemplates.get(msg.reader().readShort());
                        }
                        GameScr.gI().clearVecThanThu();
                        sbyte b3 = msg.reader().readByte();
                        for (int num20 = 0; num20 < b3; num20++)
                        {
                            string name = msg.reader().readUTF();
                            short idIconItem = msg.reader().readShort();
                            short idThanThu = msg.reader().readShort();
                            int num21 = msg.reader().readInt();
                            string str_trungno = string.Empty;
                            MyVector myVector = new MyVector();
                            int curExp = -1;
                            int maxExp = -1;
                            sbyte b4 = msg.reader().readByte();
                            if (num21 >= 0)
                            {
                                str_trungno = msg.reader().readUTF();
                            }
                            else
                            {
                                for (int num22 = 0; num22 < b4; num22++)
                                {
                                    string o = msg.reader().readUTF();
                                    myVector.addElement(o);
                                }
                                curExp = msg.reader().readInt();
                                maxExp = msg.reader().readInt();
                            }
                            sbyte stars = msg.reader().readByte();
                            GameScr.gI().addInfo_ThanThu(new Clan_ThanThu(name, stars, idIconItem, idThanThu, num21, str_trungno, myVector, curExp, maxExp));
                        }
                        break;
                    }
                case -116:
                    Char.getMyChar().xu = msg.reader().readInt();
                    Char.clan.coin = msg.reader().readInt();
                    break;
                case -90:
                    Char.getMyChar().xu = msg.reader().readInt();
                    GameScr.gI().resetButton();
                    break;
                case -86:
                    GameCanvas.endDlg();
                    GameScr.gI().resetButton();
                    InfoMe.addInfo(msg.reader().readUTF(), 20, mFont.tahoma_7_yellow);
                    break;
                case -106:
                    GameScr.typeActive = msg.reader().readByte();
                    Out.println("load Me Active: " + GameScr.typeActive);
                    break;
                case -84:
                    Char.pointPB = msg.reader().readShort();
                    break;
                case -80:
                    GameScr.gI().showAlert(mResources.RESULT, msg.reader().readUTF(), withMenuShow: false);
                    if (msg.reader().readBoolean())
                    {
                        GameScr.gI().left = new Command(mResources.REWARD, 2000);
                    }
                    break;
                case -83:
                    {
                        int num13 = msg.reader().readShort();
                        int num14 = msg.reader().readShort();
                        int num15 = msg.reader().readByte();
                        int num16 = msg.reader().readShort();
                        if (num13 == 0)
                        {
                            GameScr.gI().showAlert(mResources.REVIEW, "          " + mResources.EMPTY_INFO, withMenuShow: false);
                            break;
                        }
                        string text = mResources.PROPERTY + ": " + num13 + "\n\n";
                        string text2;
                        if (num14 == 0)
                        {
                            text = text + mResources.NOT_FINISH + "\n\n";
                        }
                        else
                        {
                            text2 = text;
                            text = text2 + mResources.TIME_FINISH + ": " + NinjaUtil.getTime(num14) + "\n\n";
                        }
                        text2 = text;
                        text = text2 + mResources.TEAMWORK + ": " + num15 + "\n\n";
                        text2 = text;
                        text = text2 + mResources.REWARD + ": " + num16 + " " + mResources.LUCKY_GIFT + "\n\n";
                        GameScr.gI().showAlert(mResources.REVIEW, text, withMenuShow: false);
                        if (num16 > 0)
                        {
                            GameScr.gI().left = new Command(mResources.REWARD, 1000);
                        }
                        break;
                    }
                case -95:
                    if (Char.clan != null)
                    {
                        Char.clan.alert = msg.reader().readUTF();
                    }
                    break;
                case -126:
                    {
                        GameCanvas.debug("SA7", 2);
                        int num4 = msg.reader().readByte();
                        LoginScr.isLoggingIn = false;
                        SelectCharScr.gI().initSelectChar();
                        for (sbyte b = 0; b < num4; b = (sbyte)(b + 1))
                        {
                            SelectCharScr.gI().gender[b] = msg.reader().readByte();
                            SelectCharScr.gI().name[b] = msg.reader().readUTF();
                            SelectCharScr.gI().phai[b] = msg.reader().readUTF();
                            SelectCharScr.gI().level[b] = msg.reader().readUnsignedByte();
                            SelectCharScr.gI().parthead[b] = msg.reader().readShort();
                            SelectCharScr.gI().partWp[b] = msg.reader().readShort();
                            SelectCharScr.gI().partbody[b] = msg.reader().readShort();
                            SelectCharScr.gI().partleg[b] = msg.reader().readShort();
                            if (SelectCharScr.gI().partWp[b] == -1)
                            {
                                SelectCharScr.gI().partWp[b] = 15;
                            }
                            if (SelectCharScr.gI().partbody[b] == -1)
                            {
                                if (SelectCharScr.gI().gender[b] == 0)
                                {
                                    SelectCharScr.gI().partbody[b] = 10;
                                }
                                else
                                {
                                    SelectCharScr.gI().partbody[b] = 1;
                                }
                            }
                            if (SelectCharScr.gI().partleg[b] == -1)
                            {
                                if (SelectCharScr.gI().gender[b] == 0)
                                {
                                    SelectCharScr.gI().partleg[b] = 9;
                                }
                                else
                                {
                                    SelectCharScr.gI().partleg[b] = 0;
                                }
                            }
                        }
                        SelectCharScr.gI().switchToMe();
                        GameCanvas.endDlg();
                        break;
                    }
                case -123:
                    GameCanvas.debug("SA8", 2);
                    GameScr.vsData = msg.reader().readByte();
                    GameScr.vsMap = msg.reader().readByte();
                    GameScr.vsSkill = msg.reader().readByte();
                    GameScr.vsItem = msg.reader().readByte();
                    if (GameScr.vsData != GameScr.vcData)
                    {
                        Service.gI().updateData();
                    }
                    else
                    {
                        try
                        {
                            DataInputStream dataInputStream = new DataInputStream(RMS.loadRMS("data"));
                            createData(dataInputStream.r);
                        }
                        catch (Exception)
                        {
                            GameScr.vcData = -1;
                            Service.gI().updateData();
                        }
                    }
                    if (GameScr.vsMap != GameScr.vcMap)
                    {
                        Service.gI().updateMap();
                    }
                    else
                    {
                        try
                        {
                            DataInputStream dataInputStream2 = new DataInputStream(RMS.loadRMS("map"));
                            createMap(dataInputStream2.r);
                        }
                        catch (Exception)
                        {
                            GameScr.vcMap = -1;
                            Service.gI().updateMap();
                        }
                    }
                    if (GameScr.vsSkill != GameScr.vcSkill)
                    {
                        Service.gI().updateSkill();
                    }
                    else
                    {
                        try
                        {
                            DataInputStream dataInputStream3 = new DataInputStream(RMS.loadRMS("skill"));
                            createSkill(dataInputStream3.r);
                        }
                        catch (Exception)
                        {
                            GameScr.vcSkill = -1;
                            Service.gI().updateSkill();
                        }
                    }
                    if (GameScr.vsItem != GameScr.vcItem)
                    {
                        Service.gI().updateItem();
                    }
                    else
                    {
                        try
                        {
                            DataInputStream dataInputStream4 = new DataInputStream(RMS.loadRMS("item"));
                            createItem(dataInputStream4.r);
                        }
                        catch (Exception)
                        {
                            GameScr.vcItem = -1;
                            Service.gI().updateItem();
                        }
                    }
                    if (GameScr.vsData == GameScr.vcData && GameScr.vsMap == GameScr.vcMap && GameScr.vsSkill == GameScr.vcSkill && GameScr.vsItem == GameScr.vcItem)
                    {
                        GameScr.gI().readEfect();
                        GameScr.gI().readArrow();
                        GameScr.gI().readSkill();
                        Service.gI().clientOk();
                    }
                    CharPartInfo.doSetInfo(msg);
                    break;
                case -122:
                    {
                        Out.println("GET UPDATE_DATA " + msg.reader().available() + " sbytes");
                        msg.reader().mark(100000);
                        createData(msg.reader());
                        msg.reader().reset();
                        sbyte[] data4 = new sbyte[msg.reader().available()];
                        msg.reader().readFully(ref data4);
                        RMS.saveRMS("data", data4);
                        sbyte[] data5 = new sbyte[1] { GameScr.vcData };
                        RMS.saveRMS("dataVersion", data5);
                        if (GameScr.vsData == GameScr.vcData && GameScr.vsMap == GameScr.vcMap && GameScr.vsSkill == GameScr.vcSkill && GameScr.vsItem == GameScr.vcItem)
                        {
                            GameScr.gI().readEfect();
                            GameScr.gI().readArrow();
                            GameScr.gI().readSkill();
                            Service.gI().clientOk();
                        }
                        break;
                    }
                case -121:
                    {
                        Out.println("GET UPDATE_MAP " + msg.reader().available() + " sbytes");
                        msg.reader().mark(100000);
                        createMap(msg.reader());
                        msg.reader().reset();
                        sbyte[] data2 = new sbyte[msg.reader().available()];
                        msg.reader().readFully(ref data2);
                        RMS.saveRMS("map", data2);
                        sbyte[] data3 = new sbyte[1] { GameScr.vcMap };
                        RMS.saveRMS("mapVersion", data3);
                        if (GameScr.vsData == GameScr.vcData && GameScr.vsMap == GameScr.vcMap && GameScr.vsSkill == GameScr.vcSkill && GameScr.vsItem == GameScr.vcItem)
                        {
                            GameScr.gI().readEfect();
                            GameScr.gI().readArrow();
                            GameScr.gI().readSkill();
                            Service.gI().clientOk();
                        }
                        break;
                    }
                case -120:
                    {
                        Out.println("GET UPDATE_SKILL " + msg.reader().available() + " sbytes");
                        msg.reader().mark(100000);
                        createSkill(msg.reader());
                        msg.reader().reset();
                        sbyte[] data8 = new sbyte[msg.reader().available()];
                        msg.reader().readFully(ref data8);
                        if (Char.getMyChar().isHumanz())
                        {
                            RMS.saveRMS("skill", data8);
                        }
                        else
                        {
                            RMS.saveRMS("skillnhanban", data8);
                        }
                        sbyte[] data9 = new sbyte[1] { GameScr.vcSkill };
                        RMS.saveRMS("skillVersion", data9);
                        if (GameScr.vsData == GameScr.vcData && GameScr.vsMap == GameScr.vcMap && GameScr.vsSkill == GameScr.vcSkill && GameScr.vsItem == GameScr.vcItem)
                        {
                            GameScr.gI().readEfect();
                            GameScr.gI().readArrow();
                            GameScr.gI().readSkill();
                            Service.gI().clientOk();
                        }
                        break;
                    }
                case -119:
                    {
                        Out.println("GET UPDATE_ITEM " + msg.reader().available() + " sbytes");
                        msg.reader().mark(100000);
                        createItem(msg.reader());
                        msg.reader().reset();
                        sbyte[] data6 = new sbyte[msg.reader().available()];
                        msg.reader().readFully(ref data6);
                        RMS.saveRMS("item", data6);
                        sbyte[] data7 = new sbyte[1] { GameScr.vcItem };
                        RMS.saveRMS("itemVersion", data7);
                        if (GameScr.vsData == GameScr.vcData && GameScr.vsMap == GameScr.vcMap && GameScr.vsSkill == GameScr.vcSkill && GameScr.vsItem == GameScr.vcItem)
                        {
                            GameScr.gI().readEfect();
                            GameScr.gI().readArrow();
                            GameScr.gI().readSkill();
                            Service.gI().clientOk();
                        }
                        break;
                    }
                case -108:
                    {
                        int num7 = msg.reader().readShort();
                        try
                        {
                            sbyte typeFly = msg.reader().readByte();
                            Mob.arrMobTemplate[num7].typeFly = typeFly;
                        }
                        catch (Exception)
                        {
                        }
                        sbyte b2 = msg.reader().readByte();
                        Mob.arrMobTemplate[num7].imgs = new Image[b2];
                        if (num7 == 98 || num7 == 99)
                        {
                            Mob.arrMobTemplate[num7].imgs = new Image[3];
                            Image image = createImage(NinjaUtil.readByteArray(msg));
                            for (int m = 0; m < Mob.arrMobTemplate[num7].imgs.Length; m++)
                            {
                                Mob.arrMobTemplate[num7].imgs[m] = image;
                            }
                        }
                        else
                        {
                            for (int n = 0; n < Mob.arrMobTemplate[num7].imgs.Length; n++)
                            {
                                sbyte[] arr = NinjaUtil.readByteArray(msg);
                                Mob.arrMobTemplate[num7].imgs[n] = createImage(arr);
                            }
                        }
                        if (msg.reader().readBoolean())
                        {
                            int num8 = msg.reader().readByte();
                            Mob.arrMobTemplate[num7].frameBossMove = new sbyte[num8];
                            for (int num9 = 0; num9 < num8; num9++)
                            {
                                Mob.arrMobTemplate[num7].frameBossMove[num9] = msg.reader().readByte();
                            }
                            num8 = msg.reader().readByte();
                            Mob.arrMobTemplate[num7].frameBossAttack = new sbyte[num8][];
                            for (int num10 = 0; num10 < num8; num10++)
                            {
                                Mob.arrMobTemplate[num7].frameBossAttack[num10] = new sbyte[msg.reader().readByte()];
                                for (int num11 = 0; num11 < Mob.arrMobTemplate[num7].frameBossAttack[num10].Length; num11++)
                                {
                                    Mob.arrMobTemplate[num7].frameBossAttack[num10][num11] = msg.reader().readByte();
                                }
                            }
                        }
                        int num12 = msg.reader().readInt();
                        if (num12 > 0)
                        {
                            if (num7 < 236)
                            {
                                readDataMobOld(msg, num7);
                            }
                            else
                            {
                                readDataMobNew(msg, num7);
                            }
                        }
                        break;
                    }
                case -109:
                    try
                    {
                        GameCanvas.isLoading = true;
                        TileMap.maps = null;
                        TileMap.types = null;
                        GameCanvas.debug("SA99", 2);
                        TileMap.tmw = msg.reader().readByte();
                        TileMap.tmh = msg.reader().readByte();
                        TileMap.maps = new char[TileMap.tmw * TileMap.tmh];
                        for (int l = 0; l < TileMap.maps.Length; l++)
                        {
                            int num5 = msg.reader().readByte();
                            if (num5 < 0)
                            {
                                num5 += 256;
                            }
                            TileMap.maps[l] = (char)num5;
                        }
                        TileMap.types = new int[TileMap.maps.Length];
                        msg = messWait;
                        loadInfoMap(msg);
                    }
                    catch (Exception)
                    {
                        Out.println(" loi tai cmd  " + msg.command);
                    }
                    msg.cleanup();
                    messWait.cleanup();
                    msg = (messWait = null);
                    break;
                case -107:
                    GameCanvas.debug("SA10", 2);
                    break;
                case -110:
                    GameCanvas.debug("SA11", 2);
                    break;
                case -67:
                    {
                        Mob mob = null;
                        try
                        {
                            int iD = msg.reader().readUnsignedByte();
                            mob = Mob.get_Mob(iD);
                        }
                        catch (Exception)
                        {
                        }
                        if (mob == null)
                        {
                            break;
                        }
                        int num3 = msg.reader().readInt();
                        if (num3 == Char.getMyChar().charID)
                        {
                            GameScr.vMobSoul.addElement(new MobSoul(mob.x, mob.y, Char.getMyChar()));
                            break;
                        }
                        Char char2 = GameScr.findCharInMap(num3);
                        if (char2 != null)
                        {
                            GameScr.vMobSoul.addElement(new MobSoul(mob.x, mob.y, char2));
                        }
                        break;
                    }
                case -66:
                    {
                        int num = msg.reader().readInt();
                        if (Char.getMyChar().charID == num)
                        {
                            GameScr.vMobSoul.addElement(new MobSoul(Char.getMyChar().cx, Char.getMyChar().cy));
                            break;
                        }
                        Char @char = GameScr.findCharInMap(num);
                        if (@char != null)
                        {
                            GameScr.vMobSoul.addElement(new MobSoul(@char.cx, @char.cy));
                        }
                        break;
                    }
                case -125:
                case -124:
                case -118:
                case -105:
                case -104:
                case -103:
                case -102:
                case -101:
                case -100:
                case -94:
                case -92:
                case -91:
                case -89:
                case -87:
                case -85:
                case -82:
                case -79:
                case -78:
                case -76:
                case -75:
                case -74:
                case -73:
                case -71:
                case -69:
                case -68:
                case -65:
                case -64:
                case -63:
                case -61:
                case -60:
                    break;
            }
        }
        catch (Exception)
        {
        }
        finally
        {
            msg?.cleanup();
        }
    }

    public void messageNotLogin(Message msg)
    {
        try
        {
            switch (msg.reader().readByte())
            {
                case -124:
                    {
                        string text = msg.reader().readUTF();
                        string data = msg.reader().readUTF();
                        GameMidlet.sendSMSRe(data, "sms://" + text, new Command(string.Empty, GameCanvas.gI(), 88825, null), new Command(string.Empty, GameCanvas.gI(), 88826, null));
                        break;
                    }
                case 2:
                    RMS.clearRMS();
                    break;
            }
        }
        catch (Exception)
        {
        }
        finally
        {
            msg?.cleanup();
        }
    }

    public void messageSubCommand(Message msg)
    {
        try
        {
            GameCanvas.debug("SA12", 2);
            sbyte b = msg.reader().readByte();
            Skill skill = null;
            Effect effect = null;
            sbyte b2 = 0;
            Out.println("sub: " + b);
            switch (b)
            {
                case -126:
                    Char.getMyChar().readParam(msg, "Cmd.ME_LOAD_SKILL");
                    Char.getMyChar().potential[0] = msg.reader().readShort();
                    Char.getMyChar().potential[1] = msg.reader().readShort();
                    Char.getMyChar().potential[2] = msg.reader().readInt();
                    Char.getMyChar().potential[3] = msg.reader().readInt();
                    Char.getMyChar().callEffTask(61);
                    Char.getMyChar().nClass = GameScr.nClasss[msg.reader().readByte()];
                    Char.getMyChar().sPoint = msg.reader().readShort();
                    Char.getMyChar().pPoint = msg.reader().readShort();
                    Char.getMyChar().vSkill.removeAllElements();
                    Char.getMyChar().vSkillFight.removeAllElements();
                    Char.getMyChar().myskill = null;
                    break;
                case -125:
                    {
                        Char.getMyChar().readParam(msg, "Cmd.ME_LOAD_SKILL");
                        if (Char.getMyChar().statusMe != 14 && Char.getMyChar().statusMe != 5)
                        {
                            Char.getMyChar().cHP = Char.getMyChar().cMaxHP;
                            Char.getMyChar().cMP = Char.getMyChar().cMaxMP;
                        }
                        Char.getMyChar().sPoint = msg.reader().readShort();
                        Char.getMyChar().vSkill.removeAllElements();
                        Char.getMyChar().vSkillFight.removeAllElements();
                        b2 = msg.reader().readByte();
                        for (sbyte b3 = 0; b3 < b2; b3 = (sbyte)(b3 + 1))
                        {
                            short skillId = msg.reader().readShort();
                            skill = Skills.get(skillId);
                            if (Char.getMyChar().myskill == null)
                            {
                                Char.getMyChar().myskill = skill;
                            }
                            else if (skill.template.Equals(Char.getMyChar().myskill.template))
                            {
                                Char.getMyChar().myskill = skill;
                            }
                            Char.getMyChar().vSkill.addElement(skill);
                            if ((skill.template.type == 1 || skill.template.type == 4 || skill.template.type == 2 || skill.template.type == 3) && (skill.template.maxPoint == 0 || (skill.template.maxPoint > 0 && skill.point > 0)))
                            {
                                if (skill.template.id == Char.getMyChar().skillTemplateId)
                                {
                                    Service.gI().selectSkill(Char.getMyChar().skillTemplateId);
                                }
                                Char.getMyChar().vSkillFight.addElement(skill);
                            }
                        }
                        GameScr.gI().sortSkill();
                        if (GameScr.isPaintInfoMe)
                        {
                            GameScr.indexRow = -1;
                            GameScr.gI().setLCR();
                        }
                        break;
                    }
                case -109:
                    Char.getMyChar().readParam(msg, "Cmd.ME_LOAD_SKILL");
                    if (Char.getMyChar().statusMe != 14 && Char.getMyChar().statusMe != 5)
                    {
                        Char.getMyChar().cHP = Char.getMyChar().cMaxHP;
                        Char.getMyChar().cMP = Char.getMyChar().cMaxMP;
                    }
                    Char.getMyChar().pPoint = msg.reader().readShort();
                    Char.getMyChar().potential[0] = msg.reader().readShort();
                    Char.getMyChar().potential[1] = msg.reader().readShort();
                    Char.getMyChar().potential[2] = msg.reader().readInt();
                    Char.getMyChar().potential[3] = msg.reader().readInt();
                    break;
                case -107:
                    GameCanvas.debug("SA16", 2);
                    Char.getMyChar().bagSort();
                    break;
                case -106:
                    GameCanvas.debug("SA17", 2);
                    Char.getMyChar().boxSort();
                    break;
                case -105:
                    {
                        GameCanvas.debug("SA18", 2);
                        int num7 = msg.reader().readInt();
                        Char.getMyChar().xu -= num7;
                        Char.getMyChar().xuInBox += num7;
                        break;
                    }
                case -104:
                    {
                        GameCanvas.debug("SA19", 2);
                        int num27 = msg.reader().readInt();
                        Char.getMyChar().xuInBox -= num27;
                        Char.getMyChar().xu += num27;
                        break;
                    }
                case -102:
                    GameCanvas.debug("SA20", 2);
                    Char.getMyChar().arrItemBag[msg.reader().readByte()] = null;
                    skill = Skills.get(msg.reader().readShort());
                    Char.getMyChar().vSkill.addElement(skill);
                    if ((skill.template.type == 1 || skill.template.type == 4 || skill.template.type == 2 || skill.template.type == 3) && (skill.template.maxPoint == 0 || (skill.template.maxPoint > 0 && skill.point > 0)))
                    {
                        if (skill.template.id == Char.getMyChar().skillTemplateId)
                        {
                            Service.gI().selectSkill(Char.getMyChar().skillTemplateId);
                        }
                        Char.getMyChar().vSkillFight.addElement(skill);
                    }
                    GameScr.gI().sortSkill();
                    GameScr.gI().addSkillShortcut(skill);
                    GameScr.gI().setLCR();
                    InfoMe.addInfo(mResources.LEARN_SKILL + " " + skill.template.name);
                    break;
                case 115:
                    {
                        GameScr.currentCharViewInfo = Char.getMyChar();
                        Char.getMyChar().charID = msg.reader().readInt();
                        Char.getMyChar().cClanName = msg.reader().readUTF();
                        if (!Char.getMyChar().cClanName.Equals(string.Empty))
                        {
                            Char.getMyChar().ctypeClan = msg.reader().readByte();
                        }
                        Char.getMyChar().ctaskId = msg.reader().readByte();
                        Char.getMyChar().cgender = msg.reader().readByte();
                        Char.getMyChar().head = msg.reader().readShort();
                        Char.getMyChar().cspeed = msg.reader().readByte();
                        Char.getMyChar().cName = msg.reader().readUTF();
                        Char.getMyChar().cPk = msg.reader().readByte();
                        Char.getMyChar().cTypePk = msg.reader().readByte();
                        Char.getMyChar().cMaxHP = msg.reader().readInt();
                        Char.getMyChar().cHP = msg.reader().readInt();
                        Char.getMyChar().cMaxMP = msg.reader().readInt();
                        Char.getMyChar().cMP = msg.reader().readInt();
                        Char.getMyChar().cEXP = msg.reader().readLong();
                        Char.getMyChar().cExpDown = msg.reader().readLong();
                        GameScr.setLevel_Exp(Char.getMyChar().cEXP, value: true);
                        Char.getMyChar().eff5BuffHp = msg.reader().readShort();
                        Char.getMyChar().eff5BuffMp = msg.reader().readShort();
                        Char.getMyChar().nClass = GameScr.nClasss[msg.reader().readByte()];
                        Char.getMyChar().pPoint = msg.reader().readShort();
                        Char.getMyChar().potential[0] = msg.reader().readShort();
                        Char.getMyChar().potential[1] = msg.reader().readShort();
                        Char.getMyChar().potential[2] = msg.reader().readInt();
                        Char.getMyChar().potential[3] = msg.reader().readInt();
                        Char.getMyChar().sPoint = msg.reader().readShort();
                        Char.getMyChar().vSkill.removeAllElements();
                        Char.getMyChar().vSkillFight.removeAllElements();
                        b2 = msg.reader().readByte();
                        for (byte b8 = 0; b8 < b2; b8 = (byte)(b8 + 1))
                        {
                            skill = Skills.get(msg.reader().readShort());
                            if (Char.getMyChar().myskill == null)
                            {
                                Char.getMyChar().myskill = skill;
                            }
                            Char.getMyChar().vSkill.addElement(skill);
                            if ((skill.template.type == 1 || skill.template.type == 4 || skill.template.type == 2 || skill.template.type == 3) && (skill.template.maxPoint == 0 || (skill.template.maxPoint > 0 && skill.point > 0)))
                            {
                                if (skill.template.id == Char.getMyChar().skillTemplateId)
                                {
                                    Service.gI().selectSkill(Char.getMyChar().skillTemplateId);
                                }
                                Char.getMyChar().vSkillFight.addElement(skill);
                            }
                        }
                        GameScr.gI().sortSkill();
                        Char.getMyChar().xu = msg.reader().readInt();
                        Char.getMyChar().yen = msg.reader().readInt();
                        Char.getMyChar().luong = msg.reader().readInt();
                        Char.getMyChar().arrItemBag = new Item[msg.reader().readUnsignedByte()];
                        GameScr.hpPotion = (GameScr.mpPotion = 0);
                        for (int num13 = 0; num13 < Char.getMyChar().arrItemBag.Length; num13++)
                        {
                            short num14 = msg.reader().readShort();
                            if (num14 != -1)
                            {
                                Char.getMyChar().arrItemBag[num13] = new Item();
                                Char.getMyChar().arrItemBag[num13].typeUI = 3;
                                Char.getMyChar().arrItemBag[num13].indexUI = num13;
                                Char.getMyChar().arrItemBag[num13].template = ItemTemplates.get(num14);
                                Char.getMyChar().arrItemBag[num13].isLock = msg.reader().readBoolean();
                                if (Char.getMyChar().arrItemBag[num13].isTypeBody() || Char.getMyChar().arrItemBag[num13].isTypeMounts() || Char.getMyChar().arrItemBag[num13].isTypeNgocKham())
                                {
                                    Char.getMyChar().arrItemBag[num13].upgrade = msg.reader().readByte();
                                }
                                Char.getMyChar().arrItemBag[num13].isExpires = msg.reader().readBoolean();
                                Char.getMyChar().arrItemBag[num13].quantity = msg.reader().readUnsignedShort();
                                if (Char.getMyChar().arrItemBag[num13].template.type == 16)
                                {
                                    GameScr.hpPotion += Char.getMyChar().arrItemBag[num13].quantity;
                                }
                                if (Char.getMyChar().arrItemBag[num13].template.type == 17)
                                {
                                    GameScr.mpPotion += Char.getMyChar().arrItemBag[num13].quantity;
                                }
                                if (Char.getMyChar().arrItemBag[num13].template.id == 340)
                                {
                                    GameScr.gI().numSprinLeft += Char.getMyChar().arrItemBag[num13].quantity;
                                }
                            }
                        }
                        Char.getMyChar().arrItemBody = new Item[32];
                        try
                        {
                            Char.getMyChar().setDefaultPart();
                            for (int num15 = 0; num15 < 16; num15++)
                            {
                                short num16 = msg.reader().readShort();
                                if (num16 != -1)
                                {
                                    ItemTemplate itemTemplate = ItemTemplates.get(num16);
                                    int type = itemTemplate.type;
                                    Char.getMyChar().arrItemBody[type] = new Item();
                                    Char.getMyChar().arrItemBody[type].indexUI = type;
                                    Char.getMyChar().arrItemBody[type].typeUI = 5;
                                    Char.getMyChar().arrItemBody[type].template = itemTemplate;
                                    Char.getMyChar().arrItemBody[type].isLock = true;
                                    Char.getMyChar().arrItemBody[type].upgrade = msg.reader().readByte();
                                    Char.getMyChar().arrItemBody[type].sys = msg.reader().readByte();
                                    switch (type)
                                    {
                                        case 1:
                                            Char.getMyChar().wp = Char.getMyChar().arrItemBody[type].template.part;
                                            break;
                                        case 2:
                                            Char.getMyChar().body = Char.getMyChar().arrItemBody[type].template.part;
                                            break;
                                        case 6:
                                            Char.getMyChar().leg = Char.getMyChar().arrItemBody[type].template.part;
                                            break;
                                    }
                                }
                            }
                        }
                        catch (Exception)
                        {
                        }
                        Char.getMyChar().isHuman = msg.reader().readBoolean();
                        Char.getMyChar().isNhanban = msg.reader().readBoolean();
                        short[] array2 = new short[4]
                        {
                    msg.reader().readShort(),
                    msg.reader().readShort(),
                    msg.reader().readShort(),
                    msg.reader().readShort()
                        };
                        if (array2[0] > -1)
                        {
                            Char.getMyChar().head = array2[0];
                        }
                        if (array2[1] > -1)
                        {
                            Char.getMyChar().wp = array2[1];
                        }
                        if (array2[2] > -1)
                        {
                            Char.getMyChar().body = array2[2];
                        }
                        if (array2[3] > -1)
                        {
                            Char.getMyChar().leg = array2[3];
                        }
                        short[] array3 = new short[10];
                        try
                        {
                            for (int num17 = 0; num17 < 10; num17++)
                            {
                                array3[num17] = msg.reader().readShort();
                            }
                        }
                        catch (Exception)
                        {
                            array3 = null;
                        }
                        if (array3 != null)
                        {
                            Char.getMyChar().setThoiTrang(array3);
                        }
                        GameScr.gI().sortSkill();
                        if (Char.getMyChar().isHuman)
                        {
                            GameScr.gI().loadSkillShortcut();
                        }
                        else if (Char.getMyChar().isNhanban)
                        {
                            GameScr.gI().loadSkillShortcutNhanban();
                        }
                        Char.getMyChar().statusMe = 4;
                        GameScr.isViewClanInvite = RMS.loadRMSInt(Char.getMyChar().cName + "vci") >= 1;
                        Service.gI().loadRMS("KSkill");
                        Service.gI().loadRMS("OSkill");
                        Service.gI().loadRMS("CSkill");
                        try
                        {
                            for (int num18 = 0; num18 < 16; num18++)
                            {
                                short num19 = msg.reader().readShort();
                                if (num19 != -1)
                                {
                                    ItemTemplate itemTemplate2 = ItemTemplates.get(num19);
                                    int num20 = itemTemplate2.type + 16;
                                    Char.getMyChar().arrItemBody[num20] = new Item();
                                    Char.getMyChar().arrItemBody[num20].indexUI = num20;
                                    Char.getMyChar().arrItemBody[num20].typeUI = 5;
                                    Char.getMyChar().arrItemBody[num20].template = itemTemplate2;
                                    Char.getMyChar().arrItemBody[num20].isLock = true;
                                    Char.getMyChar().arrItemBody[num20].upgrade = msg.reader().readByte();
                                    Char.getMyChar().arrItemBody[num20].sys = msg.reader().readByte();
                                    switch (num20)
                                    {
                                        case 1:
                                            Char.getMyChar().wp = Char.getMyChar().arrItemBody[num20].template.part;
                                            break;
                                        case 2:
                                            Char.getMyChar().body = Char.getMyChar().arrItemBody[num20].template.part;
                                            break;
                                        case 6:
                                            Char.getMyChar().leg = Char.getMyChar().arrItemBody[num20].template.part;
                                            break;
                                    }
                                }
                            }
                            break;
                        }
                        catch (Exception)
                        {
                            break;
                        }
                    }
                case -127:
                    {
                        GameScr.vCharInMap.removeAllElements();
                        GameScr.vItemMap.removeAllElements();
                        GameScr.loadImg();
                        GameScr.currentCharViewInfo = Char.getMyChar();
                        Char.getMyChar().charID = msg.reader().readInt();
                        Char.getMyChar().cClanName = msg.reader().readUTF();
                        if (!Char.getMyChar().cClanName.Equals(string.Empty))
                        {
                            Char.getMyChar().ctypeClan = msg.reader().readByte();
                        }
                        Char.getMyChar().ctaskId = msg.reader().readByte();
                        Char.getMyChar().cgender = msg.reader().readByte();
                        Char.getMyChar().head = msg.reader().readShort();
                        Char.getMyChar().cspeed = msg.reader().readByte();
                        Char.getMyChar().cName = msg.reader().readUTF();
                        Char.getMyChar().cPk = msg.reader().readByte();
                        Char.getMyChar().cTypePk = msg.reader().readByte();
                        Char.getMyChar().cMaxHP = msg.reader().readInt();
                        Char.getMyChar().cHP = msg.reader().readInt();
                        Char.getMyChar().cMaxMP = msg.reader().readInt();
                        Char.getMyChar().cMP = msg.reader().readInt();
                        Char.getMyChar().cEXP = msg.reader().readLong();
                        Char.getMyChar().cExpDown = msg.reader().readLong();
                        GameScr.setLevel_Exp(Char.getMyChar().cEXP, value: true);
                        Char.getMyChar().eff5BuffHp = msg.reader().readShort();
                        Char.getMyChar().eff5BuffMp = msg.reader().readShort();
                        Char.getMyChar().nClass = GameScr.nClasss[msg.reader().readByte()];
                        Char.getMyChar().pPoint = msg.reader().readShort();
                        Char.getMyChar().potential[0] = msg.reader().readShort();
                        Char.getMyChar().potential[1] = msg.reader().readShort();
                        Char.getMyChar().potential[2] = msg.reader().readInt();
                        Char.getMyChar().potential[3] = msg.reader().readInt();
                        Char.getMyChar().sPoint = msg.reader().readShort();
                        Char.getMyChar().vSkill.removeAllElements();
                        Char.getMyChar().vSkillFight.removeAllElements();
                        b2 = msg.reader().readByte();
                        for (byte b9 = 0; b9 < b2; b9 = (byte)(b9 + 1))
                        {
                            skill = Skills.get(msg.reader().readShort());
                            if (Char.getMyChar().myskill == null)
                            {
                                Char.getMyChar().myskill = skill;
                            }
                            Char.getMyChar().vSkill.addElement(skill);
                            if ((skill.template.type == 1 || skill.template.type == 4 || skill.template.type == 2 || skill.template.type == 3) && (skill.template.maxPoint == 0 || (skill.template.maxPoint > 0 && skill.point > 0)))
                            {
                                if (skill.template.id == Char.getMyChar().skillTemplateId)
                                {
                                    Service.gI().selectSkill(Char.getMyChar().skillTemplateId);
                                }
                                Char.getMyChar().vSkillFight.addElement(skill);
                            }
                        }
                        GameScr.gI().sortSkill();
                        Char.getMyChar().xu = msg.reader().readInt();
                        Char.getMyChar().yen = msg.reader().readInt();
                        Char.getMyChar().luong = msg.reader().readInt();
                        Char.getMyChar().arrItemBag = new Item[msg.reader().readUnsignedByte()];
                        GameScr.hpPotion = (GameScr.mpPotion = 0);
                        for (int num31 = 0; num31 < Char.getMyChar().arrItemBag.Length; num31++)
                        {
                            short num32 = msg.reader().readShort();
                            if (num32 != -1)
                            {
                                Char.getMyChar().arrItemBag[num31] = new Item();
                                Char.getMyChar().arrItemBag[num31].typeUI = 3;
                                Char.getMyChar().arrItemBag[num31].indexUI = num31;
                                Char.getMyChar().arrItemBag[num31].template = ItemTemplates.get(num32);
                                Char.getMyChar().arrItemBag[num31].isLock = msg.reader().readBoolean();
                                if (Char.getMyChar().arrItemBag[num31].isTypeBody() || Char.getMyChar().arrItemBag[num31].isTypeMounts() || Char.getMyChar().arrItemBag[num31].isTypeNgocKham())
                                {
                                    Char.getMyChar().arrItemBag[num31].upgrade = msg.reader().readByte();
                                }
                                Char.getMyChar().arrItemBag[num31].isExpires = msg.reader().readBoolean();
                                Char.getMyChar().arrItemBag[num31].quantity = msg.reader().readUnsignedShort();
                                if (Char.getMyChar().arrItemBag[num31].template.type == 16)
                                {
                                    GameScr.hpPotion += Char.getMyChar().arrItemBag[num31].quantity;
                                }
                                if (Char.getMyChar().arrItemBag[num31].template.type == 17)
                                {
                                    GameScr.mpPotion += Char.getMyChar().arrItemBag[num31].quantity;
                                }
                                if (Char.getMyChar().arrItemBag[num31].template.id == 340)
                                {
                                    GameScr.gI().numSprinLeft += Char.getMyChar().arrItemBag[num31].quantity;
                                }
                            }
                        }
                        Char.getMyChar().arrItemBody = new Item[32];
                        try
                        {
                            Char.getMyChar().setDefaultPart();
                            for (int num33 = 0; num33 < 16; num33++)
                            {
                                short num34 = msg.reader().readShort();
                                if (num34 != -1)
                                {
                                    ItemTemplate itemTemplate3 = ItemTemplates.get(num34);
                                    int type2 = itemTemplate3.type;
                                    Char.getMyChar().arrItemBody[type2] = new Item();
                                    Char.getMyChar().arrItemBody[type2].indexUI = type2;
                                    Char.getMyChar().arrItemBody[type2].typeUI = 5;
                                    Char.getMyChar().arrItemBody[type2].template = itemTemplate3;
                                    Char.getMyChar().arrItemBody[type2].isLock = true;
                                    Char.getMyChar().arrItemBody[type2].upgrade = msg.reader().readByte();
                                    Char.getMyChar().arrItemBody[type2].sys = msg.reader().readByte();
                                    switch (type2)
                                    {
                                        case 1:
                                            Char.getMyChar().wp = Char.getMyChar().arrItemBody[type2].template.part;
                                            break;
                                        case 2:
                                            Char.getMyChar().body = Char.getMyChar().arrItemBody[type2].template.part;
                                            break;
                                        case 6:
                                            Char.getMyChar().leg = Char.getMyChar().arrItemBody[type2].template.part;
                                            break;
                                    }
                                }
                            }
                        }
                        catch (Exception)
                        {
                        }
                        Char.getMyChar().isHuman = msg.reader().readBoolean();
                        Char.getMyChar().isNhanban = msg.reader().readBoolean();
                        short[] array4 = new short[4]
                        {
                    msg.reader().readShort(),
                    msg.reader().readShort(),
                    msg.reader().readShort(),
                    msg.reader().readShort()
                        };
                        if (array4[0] > -1)
                        {
                            Char.getMyChar().head = array4[0];
                        }
                        if (array4[1] > -1)
                        {
                            Char.getMyChar().wp = array4[1];
                        }
                        if (array4[2] > -1)
                        {
                            Char.getMyChar().body = array4[2];
                        }
                        if (array4[3] > -1)
                        {
                            Char.getMyChar().leg = array4[3];
                        }
                        if (Char.getMyChar().isHuman)
                        {
                            GameScr.gI().loadSkillShortcut();
                        }
                        else if (Char.getMyChar().isNhanban)
                        {
                            GameScr.gI().loadSkillShortcutNhanban();
                        }
                        Char.getMyChar().statusMe = 4;
                        GameScr.isViewClanInvite = RMS.loadRMSInt(Char.getMyChar().cName + "vci") >= 1;
                        short[] array5 = new short[10];
                        try
                        {
                            for (int num35 = 0; num35 < 10; num35++)
                            {
                                array5[num35] = msg.reader().readShort();
                            }
                        }
                        catch (Exception)
                        {
                            array5 = null;
                        }
                        if (array5 != null)
                        {
                            Char.getMyChar().setThoiTrang(array5);
                        }
                        try
                        {
                            for (int num36 = 0; num36 < 16; num36++)
                            {
                                short num37 = msg.reader().readShort();
                                if (num37 != -1)
                                {
                                    ItemTemplate itemTemplate4 = ItemTemplates.get(num37);
                                    int num38 = itemTemplate4.type + 16;
                                    Char.getMyChar().arrItemBody[num38] = new Item();
                                    Char.getMyChar().arrItemBody[num38].indexUI = num38;
                                    Char.getMyChar().arrItemBody[num38].typeUI = 5;
                                    Char.getMyChar().arrItemBody[num38].template = itemTemplate4;
                                    Char.getMyChar().arrItemBody[num38].isLock = true;
                                    Char.getMyChar().arrItemBody[num38].upgrade = msg.reader().readByte();
                                    Char.getMyChar().arrItemBody[num38].sys = msg.reader().readByte();
                                    switch (num38)
                                    {
                                        case 1:
                                            Char.getMyChar().wp = Char.getMyChar().arrItemBody[num38].template.part;
                                            break;
                                        case 2:
                                            Char.getMyChar().body = Char.getMyChar().arrItemBody[num38].template.part;
                                            break;
                                        case 6:
                                            Char.getMyChar().leg = Char.getMyChar().arrItemBody[num38].template.part;
                                            break;
                                    }
                                }
                            }
                        }
                        catch (Exception)
                        {
                        }
                        if (Char.getMyChar().isHumanz())
                        {
                            DataInputStream dataInputStream = new DataInputStream(RMS.loadRMS("skill"));
                            createSkill(dataInputStream.r);
                        }
                        else
                        {
                            DataInputStream dataInputStream2 = new DataInputStream(RMS.loadRMS("skill"));
                            createSkill(dataInputStream2.r);
                        }
                        Service.gI().loadRMS("KSkill");
                        Service.gI().loadRMS("OSkill");
                        Service.gI().loadRMS("CSkill");
                        break;
                    }
                case -124:
                    Char.getMyChar().readParam(msg, "Cmd.ME_LOAD_SKILL");
                    Char.getMyChar().cEXP = msg.reader().readLong();
                    GameScr.setLevel_Exp(Char.getMyChar().cEXP, value: true);
                    Char.getMyChar().sPoint = msg.reader().readShort();
                    Char.getMyChar().pPoint = msg.reader().readShort();
                    Char.getMyChar().potential[0] = msg.reader().readShort();
                    Char.getMyChar().potential[1] = msg.reader().readShort();
                    Char.getMyChar().potential[2] = msg.reader().readInt();
                    Char.getMyChar().potential[3] = msg.reader().readInt();
                    break;
                case -123:
                    {
                        Char.getMyChar().xu = msg.reader().readInt();
                        Char.getMyChar().yen = msg.reader().readInt();
                        Char.getMyChar().luong = msg.reader().readInt();
                        Char.getMyChar().cHP = msg.reader().readInt();
                        Char.getMyChar().cMP = msg.reader().readInt();
                        sbyte b6 = msg.reader().readByte();
                        if (b6 == 1)
                        {
                            GameScr.gI().resetCaptcha();
                            Char.getMyChar().isCaptcha = true;
                        }
                        else
                        {
                            Char.getMyChar().isCaptcha = false;
                        }
                        break;
                    }
                case -122:
                    GameCanvas.debug("SA24", 2);
                    Char.getMyChar().cHP = msg.reader().readInt();
                    break;
                case -121:
                    GameCanvas.debug("SA25", 2);
                    Char.getMyChar().cMP = msg.reader().readInt();
                    break;
                case -120:
                    {
                        Char char14 = GameScr.findCharInMap(msg.reader().readInt());
                        if (char14 != null)
                        {
                            readCharInfo(char14, msg);
                        }
                        break;
                    }
                case -119:
                    {
                        GameCanvas.debug("SA26", 2);
                        Char char11 = GameScr.findCharInMap(msg.reader().readInt());
                        if (char11 != null)
                        {
                            char11.cHP = msg.reader().readInt();
                            char11.cMaxHP = msg.reader().readInt();
                        }
                        break;
                    }
                case sbyte.MinValue:
                    {
                        GameCanvas.debug("SA27", 2);
                        Char char6 = GameScr.findCharInMap(msg.reader().readInt());
                        if (char6 != null)
                        {
                            char6.cHP = msg.reader().readInt();
                            char6.cMaxHP = msg.reader().readInt();
                            char6.clevel = msg.reader().readUnsignedByte();
                        }
                        break;
                    }
                case -117:
                    {
                        GameCanvas.debug("SA28", 2);
                        Char char4 = GameScr.findCharInMap(msg.reader().readInt());
                        if (char4 != null)
                        {
                            char4.cHP = msg.reader().readInt();
                            char4.cMaxHP = msg.reader().readInt();
                            char4.eff5BuffHp = msg.reader().readShort();
                            char4.eff5BuffMp = msg.reader().readShort();
                            char4.wp = msg.reader().readShort();
                            if (char4.wp == -1)
                            {
                                char4.setDefaultWeapon();
                            }
                        }
                        break;
                    }
                case -116:
                    {
                        GameCanvas.debug("SA29", 2);
                        Char @char = GameScr.findCharInMap(msg.reader().readInt());
                        if (@char != null)
                        {
                            @char.cHP = msg.reader().readInt();
                            @char.cMaxHP = msg.reader().readInt();
                            @char.eff5BuffHp = msg.reader().readShort();
                            @char.eff5BuffMp = msg.reader().readShort();
                            @char.body = msg.reader().readShort();
                            if (@char.body == -1)
                            {
                                @char.setDefaultBody();
                            }
                        }
                        break;
                    }
                case -113:
                    {
                        GameCanvas.debug("SA30", 2);
                        Char char7 = GameScr.findCharInMap(msg.reader().readInt());
                        if (char7 != null)
                        {
                            char7.cHP = msg.reader().readInt();
                            char7.cMaxHP = msg.reader().readInt();
                            char7.eff5BuffHp = msg.reader().readShort();
                            char7.eff5BuffMp = msg.reader().readShort();
                            char7.leg = msg.reader().readShort();
                            if (char7.leg == -1)
                            {
                                char7.setDefaultLeg();
                            }
                        }
                        break;
                    }
                case -64:
                    {
                        GameCanvas.debug("SA30", 2);
                        Char char20 = GameScr.findCharInMap(msg.reader().readInt());
                        if (char20 != null)
                        {
                            char20.cHP = msg.reader().readInt();
                            char20.cMaxHP = msg.reader().readInt();
                            char20.eff5BuffHp = msg.reader().readShort();
                            char20.eff5BuffMp = msg.reader().readShort();
                            char20.head = msg.reader().readShort();
                        }
                        break;
                    }
                case -63:
                    {
                        GameCanvas.debug("SA3001", 2);
                        int num30 = msg.reader().readInt();
                        Char char22 = GameScr.findCharInMap(num30);
                        if (char22 != null)
                        {
                            GameCanvas.startYesNoDlg(char22.cName + " " + mResources.replace(mResources.INVITECLAN, msg.reader().readUTF()), 88830, num30, 88811, null);
                        }
                        break;
                    }
                case -61:
                    {
                        GameCanvas.debug("SA30021", 2);
                        int num8 = msg.reader().readInt();
                        if (GameScr.isViewClanInvite)
                        {
                            int num9 = num8;
                            Char char16 = GameScr.findCharInMap(num9);
                            if (char16 != null)
                            {
                                GameCanvas.startYesNoDlg(char16.cName + " " + mResources.PLEASECLAN, 88831, num9, 88811, null);
                            }
                        }
                        break;
                    }
                case -62:
                    {
                        GameCanvas.debug("SA3001", 2);
                        int num5 = msg.reader().readInt();
                        string cClanName = msg.reader().readUTF();
                        sbyte ctypeClan = msg.reader().readByte();
                        if (Char.getMyChar().charID == num5)
                        {
                            Char.getMyChar().cClanName = cClanName;
                            Char.getMyChar().ctypeClan = ctypeClan;
                            Char.getMyChar().callEffTask(21);
                            break;
                        }
                        Char char13 = GameScr.findCharInMap(num5);
                        if (char13 != null)
                        {
                            char13.cClanName = cClanName;
                            char13.ctypeClan = ctypeClan;
                        }
                        break;
                    }
                case -112:
                    {
                        GameCanvas.debug("SA31", 2);
                        Char char12 = GameScr.findCharInMap(msg.reader().readInt());
                        if (char12 != null)
                        {
                            char12.cHP = msg.reader().readInt();
                            char12.cMaxHP = msg.reader().readInt();
                            char12.eff5BuffHp = msg.reader().readShort();
                            char12.eff5BuffMp = msg.reader().readShort();
                        }
                        break;
                    }
                case -111:
                    {
                        GameCanvas.debug("SA32", 2);
                        Char char9 = GameScr.findCharInMap(msg.reader().readInt());
                        if (char9 != null)
                        {
                            char9.cHP = msg.reader().readInt();
                        }
                        break;
                    }
                case -110:
                    {
                        GameCanvas.debug("SA33", 2);
                        Char char10 = GameScr.findCharInMap(msg.reader().readInt());
                        if (char10 != null)
                        {
                            char10.cHP = msg.reader().readInt();
                            char10.cMaxHP = msg.reader().readInt();
                            char10.cx = msg.reader().readShort();
                            char10.cy = msg.reader().readShort();
                            char10.statusMe = 1;
                            ServerEffect.addServerEffect(20, char10, 2);
                        }
                        break;
                    }
                case -101:
                    {
                        GameCanvas.debug("SA34", 2);
                        Effect effect4 = new Effect(msg.reader().readByte(), (int)(mSystem.getCurrentTimeMillis() / 1000) - msg.reader().readInt(), msg.reader().readInt(), msg.reader().readShort());
                        Char.getMyChar().vEff.addElement(effect4);
                        if (effect4.template.type == 7)
                        {
                            Char.getMyChar().cMiss += effect4.param;
                        }
                        else if (effect4.template.type == 12 || effect4.template.type == 11)
                        {
                            Char.getMyChar().isInvisible = true;
                            ServerEffect.addServerEffect(60, Char.getMyChar().cx, Char.getMyChar().cy, 1);
                        }
                        else if (effect4.template.type == 14)
                        {
                            GameCanvas.clearKeyPressed();
                            GameCanvas.clearKeyHold();
                            Char.getMyChar().cx = msg.reader().readShort();
                            Char.getMyChar().cy = msg.reader().readShort();
                            Char.getMyChar().statusMe = 1;
                            Char.getMyChar().isLockMove = true;
                            ServerEffect.addServerEffectWithTime(76, Char.getMyChar(), effect4.timeLenght);
                        }
                        else if (effect4.template.type == 1)
                        {
                            ServerEffect.addServerEffectWithTime(48, Char.getMyChar(), effect4.timeLenght);
                        }
                        else if (effect4.template.type == 2)
                        {
                            GameCanvas.clearKeyPressed();
                            GameCanvas.clearKeyHold();
                            Char.getMyChar().cx = msg.reader().readShort();
                            Char.getMyChar().cy = msg.reader().readShort();
                            Char.getMyChar().statusMe = 1;
                            Char.getMyChar().isLockMove = true;
                            Char.getMyChar().isLockAttack = true;
                        }
                        else if (effect4.template.type == 3)
                        {
                            GameCanvas.clearKeyPressed();
                            GameCanvas.clearKeyHold();
                            Char.getMyChar().cx = msg.reader().readShort();
                            Char.getMyChar().cy = msg.reader().readShort();
                            Char.getMyChar().statusMe = 1;
                            Char.isLockKey = true;
                            ServerEffect.addServerEffectWithTime(43, Char.getMyChar(), effect4.timeLenght);
                        }
                        break;
                    }
                case -98:
                    GameCanvas.debug("SA344", 2);
                    try
                    {
                        Char char19 = GameScr.findCharInMap(msg.reader().readInt());
                        if (char19 != null)
                        {
                            Effect effect3 = new Effect(msg.reader().readByte(), (int)(mSystem.getCurrentTimeMillis() / 1000) - msg.reader().readInt(), msg.reader().readInt(), msg.reader().readShort());
                            char19.vEff.addElement(effect3);
                            if (effect3.template.type == 12 || effect3.template.type == 11)
                            {
                                char19.isInvisible = true;
                                ServerEffect.addServerEffect(60, char19.cx, char19.cy, 1);
                            }
                            else if (effect3.template.type == 14)
                            {
                                char19.cx = (char19.cxMoveLast = msg.reader().readShort());
                                char19.cy = (char19.cyMoveLast = msg.reader().readShort());
                                char19.statusMe = 1;
                                ServerEffect.addServerEffectWithTime(76, char19, effect3.timeLenght);
                            }
                            else if (effect3.template.type == 1)
                            {
                                ServerEffect.addServerEffectWithTime(48, char19, effect3.timeLenght);
                            }
                            else if (effect3.template.type == 2)
                            {
                                char19.cx = (char19.cxMoveLast = msg.reader().readShort());
                                char19.cy = (char19.cyMoveLast = msg.reader().readShort());
                                char19.statusMe = 1;
                                char19.isLockAttack = true;
                            }
                            else if (effect3.template.type == 3)
                            {
                                char19.cx = (char19.cxMoveLast = msg.reader().readShort());
                                char19.cy = (char19.cyMoveLast = msg.reader().readShort());
                                char19.statusMe = 1;
                                ServerEffect.addServerEffectWithTime(43, char19, effect3.timeLenght);
                            }
                        }
                        break;
                    }
                    catch (Exception)
                    {
                        break;
                    }
                case -100:
                    {
                        GameCanvas.debug("SA35", 2);
                        EffectTemplate effectTemplate2 = Effect.effTemplates[msg.reader().readByte()];
                        for (int num11 = 0; num11 < Char.getMyChar().vEff.size(); num11++)
                        {
                            effect = (Effect)Char.getMyChar().vEff.elementAt(num11);
                            if (effect != null && effect.template.type == effectTemplate2.type)
                            {
                                if (effect.template.type == 7)
                                {
                                    Char.getMyChar().cMiss -= effect.param;
                                }
                                effect.template = effectTemplate2;
                                effect.timeStart = (int)(mSystem.getCurrentTimeMillis() / 1000) - msg.reader().readInt();
                                effect.timeLenght = msg.reader().readInt() / 1000;
                                effect.param = msg.reader().readShort();
                                if (effect.template.type == 7)
                                {
                                    Char.getMyChar().cMiss += effect.param;
                                }
                                break;
                            }
                        }
                        if (!GameScr.isPaintInfoMe)
                        {
                            GameScr.gI().resetButton();
                        }
                        break;
                    }
                case -97:
                    GameCanvas.debug("SA355", 2);
                    try
                    {
                        Char char17 = GameScr.findCharInMap(msg.reader().readInt());
                        if (char17 == null)
                        {
                            break;
                        }
                        EffectTemplate effectTemplate = Effect.effTemplates[msg.reader().readByte()];
                        for (int num10 = 0; num10 < char17.vEff.size(); num10++)
                        {
                            effect = (Effect)char17.vEff.elementAt(num10);
                            if (effect != null && effectTemplate.type == effectTemplate.type)
                            {
                                effect.template = effectTemplate;
                                effect.timeStart = (int)(mSystem.getCurrentTimeMillis() / 1000) - msg.reader().readInt();
                                effect.timeLenght = msg.reader().readInt() / 1000;
                                effect.param = msg.reader().readShort();
                                break;
                            }
                        }
                        break;
                    }
                    catch (Exception)
                    {
                        break;
                    }
                case -99:
                    {
                        GameCanvas.debug("SA36", 2);
                        int num28 = msg.reader().readByte();
                        effect = null;
                        for (int num29 = 0; num29 < Char.getMyChar().vEff.size(); num29++)
                        {
                            effect = (Effect)Char.getMyChar().vEff.elementAt(num29);
                            if (effect != null && effect.template.id == num28)
                            {
                                if (effect.template.type == 7)
                                {
                                    Char myChar = Char.getMyChar();
                                    myChar.cMiss -= effect.param;
                                }
                                Char.getMyChar().vEff.removeElementAt(num29);
                                break;
                            }
                        }
                        if (effect.template.type == 0 || effect.template.type == 12)
                        {
                            Char.getMyChar().cHP = msg.reader().readInt();
                            Char.getMyChar().cMP = msg.reader().readInt();
                            if (effect.template.type == 0)
                            {
                                InfoMe.addInfo(mResources.EFF_REMOVE);
                            }
                            else if (effect.template.type == 12)
                            {
                                Char.getMyChar().isInvisible = false;
                                ServerEffect.addServerEffect(60, Char.getMyChar().cx, Char.getMyChar().cy, 1);
                            }
                        }
                        else if (effect.template.type == 4 || effect.template.type == 13 || effect.template.type == 17)
                        {
                            Char.getMyChar().cHP = msg.reader().readInt();
                        }
                        else if (effect.template.type == 23)
                        {
                            Char.getMyChar().cHP = msg.reader().readInt();
                            Char.getMyChar().cMaxHP = msg.reader().readInt();
                        }
                        else if (effect.template.type == 11)
                        {
                            Char.getMyChar().isInvisible = false;
                            ServerEffect.addServerEffect(60, Char.getMyChar().cx, Char.getMyChar().cy, 1);
                        }
                        else if (effect.template.type == 14)
                        {
                            Char.getMyChar().isLockMove = false;
                        }
                        else if (effect.template.type == 2)
                        {
                            Char.getMyChar().isLockMove = false;
                            Char.getMyChar().isLockAttack = false;
                            ServerEffect.addServerEffect(77, Char.getMyChar().cx, Char.getMyChar().cy - 9, 1);
                        }
                        else if (effect.template.type == 3)
                        {
                            Char.isLockKey = false;
                        }
                        break;
                    }
                case -96:
                    {
                        GameCanvas.debug("SA366", 2);
                        Char char15 = GameScr.findCharInMap(msg.reader().readInt());
                        GameCanvas.debug("SA366x1", 2);
                        if (char15 == null)
                        {
                            break;
                        }
                        GameCanvas.debug("SA366x2", 2);
                        int num6 = msg.reader().readByte();
                        Effect effect2 = null;
                        for (int n = 0; n < char15.vEff.size(); n++)
                        {
                            GameCanvas.debug("SA366x3k" + n, 2);
                            effect2 = (Effect)char15.vEff.elementAt(n);
                            if (effect2 != null)
                            {
                                if (effect2.template.id == num6)
                                {
                                    char15.vEff.removeElementAt(n);
                                    break;
                                }
                                GameCanvas.debug("SA366x3i" + n, 2);
                            }
                        }
                        GameCanvas.debug("SA366x5", 2);
                        if (effect2 != null)
                        {
                            if (effect2.template.type == 0)
                            {
                                GameCanvas.debug("SA366x5a2", 2);
                                char15.cHP = msg.reader().readInt();
                                char15.cMP = msg.reader().readInt();
                            }
                            else if (effect2.template.type == 11)
                            {
                                char15.cx = (char15.cxMoveLast = msg.reader().readUnsignedShort());
                                char15.cy = (char15.cyMoveLast = msg.reader().readUnsignedShort());
                                char15.isInvisible = false;
                                ServerEffect.addServerEffect(60, char15.cx, char15.cy, 1);
                            }
                            else if (effect2.template.type == 12)
                            {
                                char15.cHP = msg.reader().readInt();
                                char15.cMP = msg.reader().readInt();
                                char15.isInvisible = false;
                                ServerEffect.addServerEffect(60, char15.cx, char15.cy, 1);
                            }
                            else if (effect2.template.type == 4 || effect2.template.type == 13 || effect2.template.type == 17)
                            {
                                char15.cHP = msg.reader().readInt();
                            }
                            else if (effect2.template.type == 23)
                            {
                                Char.getMyChar().cHP = msg.reader().readInt();
                                Char.getMyChar().cMaxHP = msg.reader().readInt();
                            }
                            else if (effect2.template.type == 2)
                            {
                                char15.isLockAttack = false;
                                ServerEffect.addServerEffect(77, char15.cx, char15.cy - 9, 1);
                            }
                        }
                        GameCanvas.debug("SA366x7", 2);
                        break;
                    }
                case -95:
                    GameCanvas.debug("SXX9", 2);
                    GameScr.gI().timeLengthMap = msg.reader().readInt();
                    GameScr.gI().timeStartMap = (int)(mSystem.getCurrentTimeMillis() / 1000);
                    break;
                case -94:
                    {
                        GameCanvas.debug("SY1", 2);
                        int index2 = msg.reader().readByte();
                        Npc npc2 = (Npc)GameScr.vNpc.elementAt(index2);
                        npc2.statusMe = msg.reader().readByte();
                        if (npc2.template.npcTemplateId == 31 && npc2.statusMe == 15)
                        {
                            GameScr.startLanterns(npc2.cx, npc2.cy);
                        }
                        break;
                    }
                case -92:
                    {
                        GameCanvas.debug("SY3", 2);
                        int num2 = msg.reader().readInt();
                        Char char8 = ((num2 != Char.getMyChar().charID) ? GameScr.findCharInMap(num2) : Char.getMyChar());
                        if (char8 != null)
                        {
                            char8.cTypePk = msg.reader().readByte();
                        }
                        break;
                    }
                case -59:
                    {
                        int num = msg.reader().readInt();
                        Char char5 = ((num != Char.getMyChar().charID) ? GameScr.findCharInMap(num) : Char.getMyChar());
                        char5.cHP = msg.reader().readInt();
                        char5.cMaxHP = msg.reader().readInt();
                        break;
                    }
                case -58:
                    GameScr.gI().resetButton();
                    GameCanvas.timeBallEffect = 70;
                    GameCanvas.isBallEffect = true;
                    ServerEffect.addServerEffect(119, GameScr.gW2 + GameScr.cmx, GameScr.gH2 + GameScr.cmy, 1);
                    break;
                case -57:
                    GameCanvas.timeBallEffect = 40;
                    GameCanvas.isBallEffect = true;
                    break;
                case -56:
                    {
                        int charId2 = msg.reader().readInt();
                        Char char3 = GameScr.findCharInMap(charId2);
                        if (char3 != null)
                        {
                            char3.cHP = msg.reader().readInt();
                            char3.cMaxHP = msg.reader().readInt();
                            char3.coat = (short)msg.reader().readUnsignedShort();
                        }
                        break;
                    }
                case -55:
                    {
                        int charId = msg.reader().readInt();
                        Char char2 = GameScr.findCharInMap(charId);
                        if (char2 != null)
                        {
                            char2.cHP = msg.reader().readInt();
                            char2.cMaxHP = msg.reader().readInt();
                            char2.glove = (short)msg.reader().readUnsignedShort();
                        }
                        break;
                    }
                case -54:
                    {
                        int num22 = msg.reader().readInt();
                        Char char21 = ((Char.getMyChar().charID != num22) ? GameScr.findCharInMap(num22) : Char.getMyChar());
                        if (char21 == null)
                        {
                            break;
                        }
                        char21.arrItemMounts = new Item[5];
                        char21.isNewMount = (char21.isWolf = (char21.isMoto = (char21.isMotoBehind = false)));
                        for (int num23 = 0; num23 < char21.arrItemMounts.Length; num23++)
                        {
                            short num24 = msg.reader().readShort();
                            if (num24 == -1)
                            {
                                continue;
                            }
                            char21.arrItemMounts[num23] = new Item();
                            char21.arrItemMounts[num23].typeUI = 41;
                            char21.arrItemMounts[num23].indexUI = num23;
                            char21.arrItemMounts[num23].template = ItemTemplates.get(num24);
                            char21.arrItemMounts[num23].upgrade = msg.reader().readByte();
                            char21.arrItemMounts[num23].expires = msg.reader().readLong();
                            char21.arrItemMounts[num23].sys = msg.reader().readByte();
                            char21.arrItemMounts[num23].isLock = true;
                            if (num23 == 4)
                            {
                                if (char21.arrItemMounts[num23].template.id == 485 || char21.arrItemMounts[num23].template.id == 524)
                                {
                                    char21.isMoto = true;
                                }
                                else if (char21.arrItemMounts[num23].template.id == 443 || char21.arrItemMounts[num23].template.id == 523)
                                {
                                    char21.isWolf = true;
                                }
                                else
                                {
                                    char21.isNewMount = true;
                                    char21.GetNewMount();
                                }
                            }
                            int num25 = msg.reader().readByte();
                            char21.arrItemMounts[num23].options = new MyVector();
                            for (int num26 = 0; num26 < num25; num26++)
                            {
                                char21.arrItemMounts[num23].options.addElement(new ItemOption(msg.reader().readUnsignedByte(), msg.reader().readInt()));
                            }
                        }
                        break;
                    }
                case -78:
                    GameCanvas.debug("SY4", 2);
                    ServerEffect.addServerEffect(msg.reader().readShort(), Char.getMyChar().cx, Char.getMyChar().cy, 1);
                    break;
                case -73:
                    {
                        GameCanvas.debug("SY4", 2);
                        int iD = msg.reader().readUnsignedByte();
                        Mob mob = Mob.get_Mob(iD);
                        ServerEffect.addServerEffect(67, mob.x, mob.y, 1);
                        break;
                    }
                case -72:
                    GameCanvas.debug("SY4", 2);
                    Char.getMyChar().luong = msg.reader().readInt();
                    break;
                case -71:
                    {
                        GameCanvas.debug("SY422", 2);
                        int num21 = msg.reader().readInt();
                        Char myChar = Char.getMyChar();
                        myChar.luong += num21;
                        GameScr.startFlyText("+" + num21, Char.getMyChar().cx, Char.getMyChar().cy - Char.getMyChar().ch - 10, 0, -2, mFont.ADDMONEY);
                        InfoMe.addInfo(mResources.RECEIVE + " " + num21 + " " + mResources.GOLD, 20, mFont.tahoma_7_yellow);
                        break;
                    }
                case -68:
                    {
                        GameCanvas.debug("SY42222E", 2);
                        Char char18 = GameScr.findCharInMap(msg.reader().readInt());
                        if (char18 != null)
                        {
                            int num12 = msg.reader().readUnsignedByte();
                            sbyte b7 = msg.reader().readByte();
                            if (num12 > 0)
                            {
                                short pointx2 = (short)char18.cx;
                                short pointy2 = (short)(char18.cy - 40);
                                char18.mobMe = new Mob(-1, isDisable: false, isDontMove: false, isFire: false, isIce: false, isWind: false, num12, 1, 0, 0, 0, pointx2, pointy2, 4, 0, (b7 != 0) ? true : false, removeWhenDie: false);
                                char18.mobMe.status = 5;
                            }
                            else
                            {
                                char18.mobMe = null;
                            }
                        }
                        break;
                    }
                case -65:
                    {
                        string text2 = msg.reader().readUTF();
                        sbyte[] data = new sbyte[msg.reader().readInt()];
                        msg.reader().read(ref data);
                        if (data.Length == 0)
                        {
                            data = null;
                        }
                        sbyte b5 = 0;
                        try
                        {
                            b5 = msg.reader().readByte();
                        }
                        catch (Exception)
                        {
                        }
                        if (text2.Equals("KSkill"))
                        {
                            GameScr.gI().onKSkill(data);
                        }
                        else if (text2.Equals("OSkill"))
                        {
                            GameScr.gI().onOSkill(data);
                        }
                        else if (text2.Equals("CSkill"))
                        {
                            GameScr.gI().onCSkill(data);
                        }
                        break;
                    }
                case -69:
                    {
                        GameCanvas.debug("SY42222EE", 2);
                        int num4 = msg.reader().readUnsignedByte();
                        sbyte b4 = msg.reader().readByte();
                        if (num4 > 0)
                        {
                            short pointx = (short)Char.getMyChar().cx;
                            short pointy = (short)(Char.getMyChar().cy - 40);
                            Char.getMyChar().mobMe = new Mob(-1, isDisable: false, isDontMove: false, isFire: false, isIce: false, isWind: false, num4, 1, 0, 0, 0, pointx, pointy, 4, 0, (b4 != 0) ? true : false, removeWhenDie: false);
                            Char.getMyChar().mobMe.status = 5;
                        }
                        else
                        {
                            Char.getMyChar().mobMe = null;
                        }
                        break;
                    }
                case -77:
                    GameCanvas.debug("SY5", 2);
                    try
                    {
                        GameScr.vPtMap.removeAllElements();
                        while (true)
                        {
                            GameScr.vPtMap.addElement(new Party(msg.reader().readByte(), msg.reader().readUnsignedByte(), msg.reader().readUTF(), msg.reader().readByte()));
                        }
                    }
                    catch (Exception)
                    {
                    }
                    GameScr.gI().refreshFindTeam();
                    break;
                case -76:
                    ((Party)GameScr.vParty.firstElement()).isLock = msg.reader().readBoolean();
                    break;
                case -75:
                    Char.getMyChar().arrItemBox[msg.reader().readByte()] = null;
                    break;
                case -74:
                    InfoDlg.showWait(msg.reader().readUTF());
                    break;
                case -80:
                    Char.getMyChar().arrItemBody[msg.reader().readByte()] = null;
                    break;
                case -91:
                    {
                        GameCanvas.debug("SY6", 2);
                        int num3 = msg.reader().readUnsignedByte();
                        Item[] array = new Item[num3];
                        for (int m = 0; m < Char.getMyChar().arrItemBag.Length; m++)
                        {
                            array[m] = Char.getMyChar().arrItemBag[m];
                        }
                        Char.getMyChar().arrItemBag = array;
                        Char.getMyChar().arrItemBag[msg.reader().readUnsignedByte()] = null;
                        InfoMe.addInfo(mResources.BAG_EXPANDED + " " + Char.getMyChar().arrItemBag.Length + " ô");
                        break;
                    }
                case -90:
                    {
                        GameCanvas.debug("SY7", 2);
                        for (int l = 0; l < GameScr.vNpc.size(); l++)
                        {
                            Npc npc = (Npc)GameScr.vNpc.elementAt(l);
                            if (npc != null && npc.statusMe == 15)
                            {
                                npc.statusMe = 1;
                                break;
                            }
                        }
                        switch (msg.reader().readByte())
                        {
                            case 1:
                                InfoMe.addInfo(mResources.PROTECT_FAR, 20, mFont.tahoma_7_yellow);
                                break;
                            case 2:
                                InfoMe.addInfo(mResources.PROTECT_INJURE, 20, mFont.tahoma_7_yellow);
                                break;
                        }
                        break;
                    }
                case -89:
                    GameCanvas.isLoading = false;
                    GameCanvas.debug("SY8", 2);
                    try
                    {
                        InfoMe.addInfo(msg.reader().readUTF(), 20, mFont.tahoma_7_yellow);
                    }
                    catch (Exception)
                    {
                    }
                    InfoDlg.hide();
                    GameCanvas.endDlg();
                    break;
                case -87:
                    {
                        GameCanvas.debug("SY9", 2);
                        int index = msg.reader().readByte();
                        Party party = (Party)GameScr.vParty.elementAt(index);
                        GameScr.vParty.setElementAt(GameScr.vParty.elementAt(0), index);
                        if (party != null)
                        {
                            GameScr.vParty.setElementAt(party, 0);
                        }
                        GameScr.gI().refreshTeam();
                        if (party != null)
                        {
                            InfoMe.addInfo(party.name + mResources.TEAMLEADER_CHANGE, 20, mFont.tahoma_7_yellow);
                        }
                        break;
                    }
                case -86:
                    GameCanvas.debug("SYA1", 2);
                    GameScr.vParty.removeAllElements();
                    GameScr.gI().refreshTeam();
                    InfoMe.addInfo(mResources.MOVEOUT_ME, 20, mFont.tahoma_7_yellow);
                    break;
                case -85:
                    {
                        GameCanvas.debug("SYA2", 2);
                        GameScr.vFriend.removeAllElements();
                        try
                        {
                            while (true)
                            {
                                GameScr.vFriend.addElement(new Friend(msg.reader().readUTF(), msg.reader().readByte()));
                            }
                        }
                        catch (Exception)
                        {
                        }
                        for (int k = 0; k < GameScr.vFriendWait.size(); k++)
                        {
                            GameScr.vFriend.addElement(GameScr.vFriendWait.elementAt(k));
                        }
                        GameScr.gI().sortList(0);
                        break;
                    }
                case -84:
                    GameCanvas.debug("SYA3", 2);
                    GameScr.vEnemies.removeAllElements();
                    try
                    {
                        while (true)
                        {
                            GameScr.vEnemies.addElement(new Friend(msg.reader().readUTF(), msg.reader().readByte()));
                        }
                    }
                    catch (Exception)
                    {
                    }
                    GameScr.gI().sortList(1);
                    break;
                case -83:
                    {
                        GameCanvas.debug("SYA4", 2);
                        string text = msg.reader().readUTF();
                        for (int j = 0; j < GameScr.vFriend.size(); j++)
                        {
                            Friend friend2 = (Friend)GameScr.vFriend.elementAt(j);
                            if (friend2 != null && friend2.friendName.Equals(text))
                            {
                                GameScr.indexRow = 0;
                                GameScr.vFriend.removeElementAt(j);
                                GameScr.gI().actRemoveWaitAcceptFriend(text);
                                break;
                            }
                        }
                        if (GameScr.isPaintFriend)
                        {
                            GameScr.gI().sortList(0);
                            GameScr.indexRow = 0;
                            GameScr.scrMain.clear();
                        }
                        break;
                    }
                case -82:
                    {
                        GameCanvas.debug("SYA5", 2);
                        string value = msg.reader().readUTF();
                        for (int i = 0; i < GameScr.vEnemies.size(); i++)
                        {
                            Friend friend = (Friend)GameScr.vEnemies.elementAt(i);
                            if (friend != null && friend.friendName.Equals(value))
                            {
                                GameScr.indexRow = 0;
                                GameScr.vEnemies.removeElementAt(i);
                                break;
                            }
                        }
                        GameScr.gI().sortList(0);
                        break;
                    }
                case -81:
                    GameCanvas.debug("SYA6", 2);
                    Char.getMyChar().cPk = msg.reader().readByte();
                    Char.getMyChar().charFocus = null;
                    break;
            }
        }
        catch (Exception)
        {
        }
        finally
        {
            msg?.cleanup();
        }
    }

    public bool readCharInfo(Char c, Message msg)
    {
        try
        {
            c.cClanName = msg.reader().readUTF();
            if (!c.cClanName.Equals(string.Empty))
            {
                c.ctypeClan = msg.reader().readByte();
            }
            c.isInvisible = msg.reader().readBoolean();
            c.cTypePk = msg.reader().readByte();
            c.nClass = GameScr.nClasss[msg.reader().readByte()];
            c.cgender = msg.reader().readByte();
            c.head = msg.reader().readShort();
            c.cName = msg.reader().readUTF();
            c.cHP = msg.reader().readInt();
            c.cMaxHP = msg.reader().readInt();
            c.clevel = msg.reader().readUnsignedByte();
            c.wp = msg.reader().readShort();
            c.body = msg.reader().readShort();
            c.leg = msg.reader().readShort();
            sbyte b = msg.reader().readByte();
            if (c.wp == -1)
            {
                c.setDefaultWeapon();
            }
            if (c.body == -1)
            {
                c.setDefaultBody();
            }
            if (c.leg == -1)
            {
                c.setDefaultLeg();
            }
            if (b == -1)
            {
                c.mobMe = null;
            }
            else
            {
                short pointx = (short)c.cx;
                short pointy = (short)(c.cy - 40);
                c.mobMe = new Mob(-1, isDisable: false, isDontMove: false, isFire: false, isIce: false, isWind: false, b, 1, 0, 0, 0, pointx, pointy, 4, 0, isBos: false, removeWhenDie: false);
                c.mobMe.status = 5;
            }
            c.cx = (c.cxMoveLast = msg.reader().readShort());
            c.cy = (c.cyMoveLast = msg.reader().readShort());
            c.eff5BuffHp = msg.reader().readShort();
            c.eff5BuffMp = msg.reader().readShort();
            int num = msg.reader().readByte();
            for (int i = 0; i < num; i++)
            {
                Effect effect = new Effect(msg.reader().readByte(), msg.reader().readInt(), msg.reader().readInt(), msg.reader().readShort());
                c.vEff.addElement(effect);
                if (effect.template.type == 12 || effect.template.type == 11)
                {
                    c.isInvisible = true;
                }
            }
            if (!c.isInvisible)
            {
                ServerEffect.addServerEffect(60, c, 1);
            }
            if (c.cHP == 0)
            {
                c.statusMe = 14;
                if (Char.getMyChar().charID == c.charID)
                {
                    GameScr.gI().resetButton();
                }
            }
            if (c.charID == -Char.getMyChar().charID)
            {
                for (int j = 0; j < GameScr.vNpc.size(); j++)
                {
                    Npc npc = (Npc)GameScr.vNpc.elementAt(j);
                    if (npc.template.name.Equals(c.cName))
                    {
                        npc.hide();
                        break;
                    }
                }
            }
            c.isHuman = msg.reader().readBoolean();
            c.isNhanban = msg.reader().readBoolean();
            if (c.isNhanbanz())
            {
                ServerEffect.addServerEffect(141, c.cx, c.cy, 0);
            }
            short[] array = new short[4]
            {
                msg.reader().readShort(),
                msg.reader().readShort(),
                msg.reader().readShort(),
                msg.reader().readShort()
            };
            if (array[0] > -1)
            {
                c.head = array[0];
            }
            if (array[1] > -1)
            {
                c.wp = array[1];
            }
            if (array[2] > -1)
            {
                c.body = array[2];
            }
            if (array[3] > -1)
            {
                c.leg = array[3];
            }
            short[] array2 = new short[10];
            try
            {
                for (int k = 0; k < 10; k++)
                {
                    array2[k] = msg.reader().readShort();
                }
            }
            catch (Exception)
            {
            }
            if (array2 != null)
            {
                c.setThoiTrang(array2);
            }
            Party.refresh(c);
            return true;
        }
        catch (Exception)
        {
        }
        return false;
    }

    public void requestItemInfo(Message msg)
    {
        try
        {
            int num = msg.reader().readByte();
            int num2 = msg.reader().readUnsignedByte();
            Item item = null;
            switch (num)
            {
                case 3:
                    {
                        item = Char.getMyChar().arrItemBag[num2];
                        if (item != null)
                        {
                            break;
                        }
                        if (GameScr.itemSplit != null && GameScr.itemSplit.indexUI == num2)
                        {
                            item = GameScr.itemSplit;
                        }
                        if (GameScr.itemUpGrade != null && GameScr.itemUpGrade.indexUI == num2)
                        {
                            item = GameScr.itemUpGrade;
                        }
                        if (GameScr.itemSell != null && GameScr.itemSell.indexUI == num2)
                        {
                            item = GameScr.itemSell;
                        }
                        if (item == null && GameScr.arrItemUpGrade != null)
                        {
                            for (int i = 0; i < GameScr.arrItemUpGrade.Length; i++)
                            {
                                if (GameScr.arrItemUpGrade[i] != null && GameScr.arrItemUpGrade[i].indexUI == num2)
                                {
                                    item = GameScr.arrItemUpGrade[i];
                                    break;
                                }
                            }
                        }
                        if (item == null && GameScr.arrItemConvert != null)
                        {
                            for (int j = 0; j < GameScr.arrItemConvert.Length; j++)
                            {
                                if (GameScr.arrItemConvert[j] != null && GameScr.arrItemConvert[j].indexUI == num2)
                                {
                                    item = GameScr.arrItemConvert[j];
                                    break;
                                }
                            }
                        }
                        if (item == null && GameScr.arrItemUpPeal != null)
                        {
                            for (int k = 0; k < GameScr.arrItemUpPeal.Length; k++)
                            {
                                if (GameScr.arrItemUpPeal[k] != null && GameScr.arrItemUpPeal[k].indexUI == num2)
                                {
                                    item = GameScr.arrItemUpPeal[k];
                                    break;
                                }
                            }
                        }
                        if (item == null && GameScr.arrItemTradeMe != null)
                        {
                            for (int l = 0; l < GameScr.arrItemTradeMe.Length; l++)
                            {
                                if (GameScr.arrItemTradeMe[l] != null && GameScr.arrItemTradeMe[l].indexUI == num2)
                                {
                                    item = GameScr.arrItemTradeMe[l];
                                    break;
                                }
                            }
                        }
                        if (item != null || GameScr.arrItemSplit == null)
                        {
                            break;
                        }
                        for (int m = 0; m < GameScr.arrItemSplit.Length; m++)
                        {
                            if (GameScr.arrItemSplit[m] != null && GameScr.arrItemSplit[m].indexUI == num2)
                            {
                                item = GameScr.arrItemSplit[m];
                                break;
                            }
                        }
                        break;
                    }
                case 4:
                    item = Char.getMyChar().arrItemBox[num2];
                    break;
                case 39:
                    item = Char.clan.items[GameScr.indexSelect];
                    break;
                case 5:
                    item = Char.getMyChar().arrItemBody[num2];
                    break;
                case 20:
                    item = GameScr.arrItemNonNam[num2];
                    break;
                case 21:
                    item = GameScr.arrItemNonNu[num2];
                    break;
                case 22:
                    item = GameScr.arrItemAoNam[num2];
                    break;
                case 23:
                    item = GameScr.arrItemAoNu[num2];
                    break;
                case 24:
                    item = GameScr.arrItemGangTayNam[num2];
                    break;
                case 25:
                    item = GameScr.arrItemGangTayNu[num2];
                    break;
                case 26:
                    item = GameScr.arrItemQuanNam[num2];
                    break;
                case 27:
                    item = GameScr.arrItemQuanNu[num2];
                    break;
                case 28:
                    item = GameScr.arrItemGiayNam[num2];
                    break;
                case 29:
                    item = GameScr.arrItemGiayNu[num2];
                    break;
                case 16:
                    item = GameScr.arrItemLien[num2];
                    break;
                case 17:
                    item = GameScr.arrItemNhan[num2];
                    break;
                case 18:
                    item = GameScr.arrItemNgocBoi[num2];
                    break;
                case 19:
                    item = GameScr.arrItemPhu[num2];
                    break;
                case 2:
                    item = GameScr.arrItemWeapon[num2];
                    break;
                case 6:
                    item = GameScr.arrItemStack[num2];
                    break;
                case 7:
                    item = GameScr.arrItemStackLock[num2];
                    break;
                case 8:
                    item = GameScr.arrItemGrocery[num2];
                    break;
                case 9:
                    item = GameScr.arrItemGroceryLock[num2];
                    break;
                case 14:
                    item = GameScr.arrItemStore[num2];
                    break;
                case 35:
                    item = GameScr.arrItemElites[num2];
                    break;
                case 15:
                    item = GameScr.arrItemBook[num2];
                    break;
                case 32:
                    item = GameScr.arrItemFashion[num2];
                    break;
                case 34:
                    item = GameScr.arrItemClanShop[num2];
                    break;
                case 30:
                    item = GameScr.arrItemTradeOrder[num2];
                    break;
            }
            item.expires = msg.reader().readLong();
            if (item.isTypeUIMe())
            {
                item.saleCoinLock = msg.reader().readInt();
            }
            else if (item.isTypeUIShop() || item.isTypeUIShopLock() || item.isTypeUIStore() || item.isTypeUIBook() || item.isTypeUIFashion() || item.isTypeUIClanShop())
            {
                item.buyCoin = msg.reader().readInt();
                item.buyCoinLock = msg.reader().readInt();
                item.buyGold = msg.reader().readInt();
            }
            if (item.isTypeBody() || item.isTypeMounts() || item.isTypeNgocKham())
            {
                item.sys = msg.reader().readByte();
                item.options = new MyVector();
                try
                {
                    while (true)
                    {
                        item.options.addElement(new ItemOption(msg.reader().readUnsignedByte(), msg.reader().readInt()));
                    }
                }
                catch (Exception)
                {
                }
            }
            else if (item.template.id == 233)
            {
                item.img = createImage(NinjaUtil.readByteArray(msg));
            }
            else if (item.template.id == 234)
            {
                item.img = createImage(NinjaUtil.readByteArray(msg));
            }
            else if (item.template.id == 235)
            {
                item.img = createImage(NinjaUtil.readByteArray(msg));
            }
            if (num == 5)
            {
                Char.getMyChar().updateKickOption();
            }
        }
        catch (Exception)
        {
            Out.println("loi tai day ham requet item info ---------------------------------------------------------");
        }
    }

    public void addMob(Message msg)
    {
        try
        {
            int num = msg.reader().readByte();
            for (sbyte b = 0; b < num; b = (sbyte)(b + 1))
            {
                short mobId = msg.reader().readUnsignedByte();
                bool isDisable = msg.reader().readBoolean();
                bool isDontMove = msg.reader().readBoolean();
                bool isFire = msg.reader().readBoolean();
                bool isIce = msg.reader().readBoolean();
                bool isWind = msg.reader().readBoolean();
                int templateId = msg.reader().readUnsignedByte();
                int sys = msg.reader().readByte();
                int hp = msg.reader().readInt();
                int level = msg.reader().readUnsignedByte();
                int maxhp = msg.reader().readInt();
                short pointx = msg.reader().readShort();
                short pointy = msg.reader().readShort();
                sbyte status = msg.reader().readByte();
                sbyte levelBoss = msg.reader().readByte();
                bool isBos = msg.reader().readBoolean();
                Mob mob = new Mob(mobId, isDisable, isDontMove, isFire, isIce, isWind, templateId, sys, hp, level, maxhp, pointx, pointy, status, levelBoss, isBos, removeWhenDie: true);
                if (Mob.arrMobTemplate[mob.templateId].type != 0)
                {
                    if (b % 3 == 0)
                    {
                        mob.dir = -1;
                    }
                    else
                    {
                        mob.dir = 1;
                    }
                    mob.x += 10 - b % 20;
                }
                GameScr.vMob.addElement(mob);
            }
        }
        catch (Exception)
        {
            mSystem.println("err addMob");
        }
    }

    public void addEffAuto(Message msg)
    {
        try
        {
            short id = msg.reader().readUnsignedByte();
            int x = msg.reader().readShort();
            int y = msg.reader().readShort();
            sbyte loopCount = msg.reader().readByte();
            short time = msg.reader().readShort();
            EffectAuto.addEffectAuto(id, x, y, loopCount, time, 1);
        }
        catch (Exception)
        {
            mSystem.println("err add effAuto");
        }
    }

    public void getDataEffAuto(Message msg)
    {
        try
        {
            short id = msg.reader().readUnsignedByte();
            short num = msg.reader().readShort();
            sbyte[] data = null;
            if (num > 0)
            {
                data = new sbyte[num];
                msg.reader().read(ref data);
            }
            EffectAuto.reciveData(id, data);
        }
        catch (Exception)
        {
            mSystem.println("err add effAuto");
        }
    }

    public void getImgEffAuto(Message msg)
    {
        try
        {
            short id = msg.reader().readUnsignedByte();
            sbyte[] data = NinjaUtil.readByteArray_Int(msg);
            EffectAuto.reciveImage(id, data);
        }
        catch (Exception)
        {
            mSystem.println("err getImgEffAuto");
        }
    }

    public void khamngoc(Message msg)
    {
        try
        {
            sbyte b = msg.reader().readByte();
            sbyte b2 = 1;
            Char.getMyChar().luong = msg.reader().readInt();
            Char.getMyChar().xu = msg.reader().readInt();
            Char.getMyChar().yen = msg.reader().readInt();
            switch (b)
            {
                case 0:
                    if (GameScr.itemSplit != null)
                    {
                        GameScr.itemSplit = null;
                    }
                    if (GameScr.arrItemSplit != null)
                    {
                        for (int k = 0; k < GameScr.arrItemSplit.Length; k++)
                        {
                            GameScr.arrItemSplit[k] = null;
                        }
                    }
                    break;
                case 1:
                    if (GameScr.itemSplit != null)
                    {
                        GameScr.itemSplit.isLock = true;
                        GameScr.itemSplit.upgrade = msg.reader().readByte();
                        if (b2 == 1)
                        {
                            GameScr.effUpok = GameScr.efs[53];
                            GameScr.indexEff = 0;
                        }
                    }
                    if (GameScr.arrItemSplit != null)
                    {
                        for (int j = 0; j < GameScr.arrItemSplit.Length; j++)
                        {
                            GameScr.arrItemSplit[j] = null;
                        }
                    }
                    break;
                case 2:
                case 3:
                    if (GameScr.arrItemSplit != null)
                    {
                        for (int i = 0; i < GameScr.arrItemSplit.Length; i++)
                        {
                            GameScr.arrItemSplit[i] = null;
                        }
                    }
                    break;
            }
            GameScr.gI().left = (GameScr.gI().center = null);
            GameScr.gI().updateKeyBuyItemUI();
            GameCanvas.endDlg();
        }
        catch (Exception)
        {
        }
    }

    public void addEffect(Message msg)
    {
        try
        {
            sbyte b = msg.reader().readByte();
            MainObject mainObject;
            if (b == 1)
            {
                int iD = msg.reader().readUnsignedByte();
                mainObject = Mob.get_Mob(iD);
            }
            else
            {
                int num = msg.reader().readInt();
                mainObject = ((num != Char.getMyChar().charID) ? GameScr.findCharInMap(num) : Char.getMyChar());
            }
            if (mainObject != null)
            {
                short id = msg.reader().readShort();
                int num2 = msg.reader().readInt();
                sbyte b2 = msg.reader().readByte();
                bool isHead = ((msg.reader().readByte() != 0) ? true : false);
                mainObject.addDataeff(id, num2, b2 * 1000, isHead);
            }
        }
        catch (Exception)
        {
        }
    }

    public void getImgEffect(Message msg)
    {
        try
        {
            short id = msg.reader().readUnsignedByte();
            sbyte[] array = NinjaUtil.readByteArray_Int(msg);
            GameData.setImgIcon(id, array);
            ImageIcon imageIcon = (ImageIcon)GameData.listImgIcon.get(string.Empty + id);
            if (imageIcon == null)
            {
                imageIcon = new ImageIcon();
                GameData.listImgIcon.put(id + string.Empty, imageIcon);
            }
            imageIcon.isLoad = false;
            imageIcon.img = createImage(array);
            if (GameMidlet.CLIENT_TYPE != 1)
            {
                RMS.saveRMSImage("ImgEffect " + id, array);
            }
        }
        catch (Exception)
        {
        }
    }

    public void getDataEffect(Message msg)
    {
        try
        {
            short num = msg.reader().readUnsignedByte();
            short num2 = msg.reader().readShort();
            sbyte[] data = null;
            if (num2 > 0)
            {
                data = new sbyte[num2];
                msg.reader().read(ref data);
            }
            ((EffectData)GameData.listbyteData.get(string.Empty + num))?.setdata(data);
        }
        catch (Exception)
        {
        }
    }

    public void LoadBijuu(Message msg)
    {
        try
        {
            switch (msg.reader().readByte())
            {
                case 0:
                    {
                        Char myChar = Char.getMyChar();
                        if (myChar == null)
                        {
                            break;
                        }
                        myChar.arrItemBijuu = new Item[5];
                        for (int i = 0; i < myChar.arrItemBijuu.Length; i++)
                        {
                            short num = msg.reader().readShort();
                            if (num != -1)
                            {
                                myChar.arrItemBijuu[i] = new Item();
                                myChar.arrItemBijuu[i].typeUI = 41;
                                myChar.arrItemBijuu[i].indexUI = i;
                                myChar.arrItemBijuu[i].template = ItemTemplates.get(num);
                                myChar.arrItemBijuu[i].upgrade = msg.reader().readByte();
                                myChar.arrItemBijuu[i].expires = msg.reader().readLong();
                                myChar.arrItemBijuu[i].sys = msg.reader().readByte();
                                myChar.arrItemBijuu[i].isLock = true;
                                int num2 = msg.reader().readByte();
                                myChar.arrItemBijuu[i].options = new MyVector();
                                for (int j = 0; j < num2; j++)
                                {
                                    myChar.arrItemBijuu[i].options.addElement(new ItemOption(msg.reader().readUnsignedByte(), msg.reader().readInt()));
                                }
                            }
                        }
                        myChar.bijuuPoint = msg.reader().readShort();
                        myChar.bijuupotential[0] = msg.reader().readShort();
                        myChar.bijuupotential[1] = msg.reader().readShort();
                        myChar.bijuupotential[2] = msg.reader().readShort();
                        myChar.bijuupotential[3] = msg.reader().readShort();
                        myChar.bijuuSkillPoint = msg.reader().readShort();
                        myChar.vSkillBijuu.removeAllElements();
                        sbyte b2 = msg.reader().readByte();
                        for (byte b3 = 0; b3 < b2; b3 = (byte)(b3 + 1))
                        {
                            short skillId = msg.reader().readShort();
                            Skill o = Skills.get(skillId);
                            myChar.vSkillBijuu.addElement(o);
                        }
                        break;
                    }
                case 1:
                    {
                        sbyte b4 = msg.reader().readByte();
                        if (b4 != 0 && b4 == 1)
                        {
                        }
                        break;
                    }
                case 2:
                    {
                        sbyte b = msg.reader().readByte();
                        if (b != 0 && b == 1)
                        {
                        }
                        break;
                    }
            }
        }
        catch (Exception)
        {
        }
    }

    private void readDataMobOld(Message msg, int mobTemplateId)
    {
        try
        {
            Mob.arrMobTemplate[mobTemplateId].imginfo = new ImageInfo[msg.reader().readByte()];
            for (int i = 0; i < Mob.arrMobTemplate[mobTemplateId].imginfo.Length; i++)
            {
                Mob.arrMobTemplate[mobTemplateId].imginfo[i] = new ImageInfo();
                Mob.arrMobTemplate[mobTemplateId].imginfo[i].ID = msg.reader().readByte();
                Mob.arrMobTemplate[mobTemplateId].imginfo[i].x0 = msg.reader().readUnsignedByte();
                Mob.arrMobTemplate[mobTemplateId].imginfo[i].y0 = msg.reader().readUnsignedByte();
                Mob.arrMobTemplate[mobTemplateId].imginfo[i].w = msg.reader().readUnsignedByte();
                Mob.arrMobTemplate[mobTemplateId].imginfo[i].h = msg.reader().readUnsignedByte();
            }
            Mob.arrMobTemplate[mobTemplateId].frameBoss = new Frame[msg.reader().readShort()];
            for (int j = 0; j < Mob.arrMobTemplate[mobTemplateId].frameBoss.Length; j++)
            {
                Mob.arrMobTemplate[mobTemplateId].frameBoss[j] = new Frame();
                sbyte b = msg.reader().readByte();
                Mob.arrMobTemplate[mobTemplateId].frameBoss[j].dx = new short[b];
                Mob.arrMobTemplate[mobTemplateId].frameBoss[j].dy = new short[b];
                Mob.arrMobTemplate[mobTemplateId].frameBoss[j].idImg = new sbyte[b];
                for (int k = 0; k < b; k++)
                {
                    Mob.arrMobTemplate[mobTemplateId].frameBoss[j].dx[k] = msg.reader().readShort();
                    Mob.arrMobTemplate[mobTemplateId].frameBoss[j].dy[k] = msg.reader().readShort();
                    Mob.arrMobTemplate[mobTemplateId].frameBoss[j].idImg[k] = msg.reader().readByte();
                }
            }
            short num = msg.reader().readShort();
            for (int l = 0; l < num; l++)
            {
                msg.reader().readShort();
            }
        }
        catch (Exception)
        {
        }
    }

    private void readDataMobNew(Message msg, int mobTemplateId)
    {
        try
        {
            bool flag = true;
            Mob.arrMobTemplate[mobTemplateId].imginfo = new ImageInfo[msg.reader().readByte()];
            for (int i = 0; i < Mob.arrMobTemplate[mobTemplateId].imginfo.Length; i++)
            {
                Mob.arrMobTemplate[mobTemplateId].imginfo[i] = new ImageInfo();
                Mob.arrMobTemplate[mobTemplateId].imginfo[i].ID = msg.reader().readByte();
                Mob.arrMobTemplate[mobTemplateId].imginfo[i].x0 = msg.reader().readUnsignedByte();
                Mob.arrMobTemplate[mobTemplateId].imginfo[i].y0 = msg.reader().readUnsignedByte();
                Mob.arrMobTemplate[mobTemplateId].imginfo[i].w = msg.reader().readUnsignedByte();
                Mob.arrMobTemplate[mobTemplateId].imginfo[i].h = msg.reader().readUnsignedByte();
            }
            Mob.arrMobTemplate[mobTemplateId].frameBoss = new Frame[msg.reader().readShort()];
            for (int j = 0; j < Mob.arrMobTemplate[mobTemplateId].frameBoss.Length; j++)
            {
                Mob.arrMobTemplate[mobTemplateId].frameBoss[j] = new Frame();
                sbyte b = msg.reader().readByte();
                Mob.arrMobTemplate[mobTemplateId].frameBoss[j].dx = new short[b];
                Mob.arrMobTemplate[mobTemplateId].frameBoss[j].dy = new short[b];
                Mob.arrMobTemplate[mobTemplateId].frameBoss[j].idImg = new sbyte[b];
                Mob.arrMobTemplate[mobTemplateId].frameBoss[j].flip = new sbyte[b];
                Mob.arrMobTemplate[mobTemplateId].frameBoss[j].onTop = new sbyte[b];
                for (int k = 0; k < b; k++)
                {
                    Mob.arrMobTemplate[mobTemplateId].frameBoss[j].dx[k] = msg.reader().readShort();
                    Mob.arrMobTemplate[mobTemplateId].frameBoss[j].dy[k] = msg.reader().readShort();
                    Mob.arrMobTemplate[mobTemplateId].frameBoss[j].idImg[k] = msg.reader().readByte();
                    if (flag)
                    {
                        Mob.arrMobTemplate[mobTemplateId].frameBoss[j].flip[k] = msg.reader().readByte();
                        Mob.arrMobTemplate[mobTemplateId].frameBoss[j].onTop[k] = msg.reader().readByte();
                    }
                }
            }
            short num = 0;
            num = ((!flag) ? msg.reader().readShort() : msg.reader().readUnsignedByte());
            Mob.arrMobTemplate[mobTemplateId].sequence = new sbyte[num];
            for (int l = 0; l < num; l++)
            {
                Mob.arrMobTemplate[mobTemplateId].sequence[l] = (sbyte)msg.reader().readShort();
            }
            if (flag)
            {
                msg.reader().readByte();
                for (int m = 0; m < 4; m++)
                {
                    if (m != 2)
                    {
                        num = msg.reader().readByte();
                        Mob.arrMobTemplate[mobTemplateId].frameChar[m] = new sbyte[num];
                        for (int n = 0; n < num; n++)
                        {
                            Mob.arrMobTemplate[mobTemplateId].frameChar[m][n] = msg.reader().readByte();
                        }
                    }
                }
            }
            try
            {
                Mob.arrMobTemplate[mobTemplateId].indexSplash[0] = (sbyte)(Mob.arrMobTemplate[mobTemplateId].frameChar[0].Length - 7);
                Mob.arrMobTemplate[mobTemplateId].indexSplash[1] = (sbyte)(Mob.arrMobTemplate[mobTemplateId].frameChar[1].Length - 7);
                Mob.arrMobTemplate[mobTemplateId].indexSplash[2] = (sbyte)(Mob.arrMobTemplate[mobTemplateId].frameChar[3].Length - 7);
                Mob.arrMobTemplate[mobTemplateId].indexSplash[3] = (sbyte)(Mob.arrMobTemplate[mobTemplateId].frameChar[3].Length - 7);
            }
            catch (Exception)
            {
            }
            for (int num2 = 0; num2 < 3; num2++)
            {
                Mob.arrMobTemplate[mobTemplateId].indexSplash[num2] = msg.reader().readByte();
            }
            Mob.arrMobTemplate[mobTemplateId].indexSplash[3] = Mob.arrMobTemplate[mobTemplateId].indexSplash[2];
            Mob.arrMobTemplate[mobTemplateId].imginfo = new ImageInfo[msg.reader().readByte()];
        }
        catch (Exception)
        {
        }
    }

    public void readDataMobNew(sbyte[] data, int mobTemplateId)
    {
        DataInputStream dataInputStream = null;
        try
        {
            dataInputStream = new DataInputStream(data);
            bool flag = true;
            Mob.arrMobTemplate[mobTemplateId].imginfo = new ImageInfo[dataInputStream.readByte()];
            for (int i = 0; i < Mob.arrMobTemplate[mobTemplateId].imginfo.Length; i++)
            {
                Mob.arrMobTemplate[mobTemplateId].imginfo[i] = new ImageInfo();
                Mob.arrMobTemplate[mobTemplateId].imginfo[i].ID = dataInputStream.readByte();
                Mob.arrMobTemplate[mobTemplateId].imginfo[i].x0 = dataInputStream.readUnsignedByte();
                Mob.arrMobTemplate[mobTemplateId].imginfo[i].y0 = dataInputStream.readUnsignedByte();
                Mob.arrMobTemplate[mobTemplateId].imginfo[i].w = dataInputStream.readUnsignedByte();
                Mob.arrMobTemplate[mobTemplateId].imginfo[i].h = dataInputStream.readUnsignedByte();
            }
            Mob.arrMobTemplate[mobTemplateId].frameBoss = new Frame[dataInputStream.readShort()];
            for (int j = 0; j < Mob.arrMobTemplate[mobTemplateId].frameBoss.Length; j++)
            {
                Mob.arrMobTemplate[mobTemplateId].frameBoss[j] = new Frame();
                sbyte b = dataInputStream.readByte();
                Mob.arrMobTemplate[mobTemplateId].frameBoss[j].dx = new short[b];
                Mob.arrMobTemplate[mobTemplateId].frameBoss[j].dy = new short[b];
                Mob.arrMobTemplate[mobTemplateId].frameBoss[j].idImg = new sbyte[b];
                Mob.arrMobTemplate[mobTemplateId].frameBoss[j].flip = new sbyte[b];
                Mob.arrMobTemplate[mobTemplateId].frameBoss[j].onTop = new sbyte[b];
                for (int k = 0; k < b; k++)
                {
                    Mob.arrMobTemplate[mobTemplateId].frameBoss[j].dx[k] = dataInputStream.readShort();
                    Mob.arrMobTemplate[mobTemplateId].frameBoss[j].dy[k] = dataInputStream.readShort();
                    Mob.arrMobTemplate[mobTemplateId].frameBoss[j].idImg[k] = dataInputStream.readByte();
                    if (flag)
                    {
                        Mob.arrMobTemplate[mobTemplateId].frameBoss[j].flip[k] = dataInputStream.readByte();
                        Mob.arrMobTemplate[mobTemplateId].frameBoss[j].onTop[k] = dataInputStream.readByte();
                    }
                }
            }
            short num = 0;
            num = ((!flag) ? dataInputStream.readShort() : ((short)dataInputStream.readUnsignedByte()));
            Mob.arrMobTemplate[mobTemplateId].sequence = new sbyte[num];
            for (int l = 0; l < num; l++)
            {
                Mob.arrMobTemplate[mobTemplateId].sequence[l] = (sbyte)dataInputStream.readShort();
            }
            if (flag)
            {
                dataInputStream.readByte();
                for (int m = 0; m < 4; m++)
                {
                    if (m != 2)
                    {
                        num = dataInputStream.readByte();
                        Mob.arrMobTemplate[mobTemplateId].frameChar[m] = new sbyte[num];
                        for (int n = 0; n < num; n++)
                        {
                            Mob.arrMobTemplate[mobTemplateId].frameChar[m][n] = dataInputStream.readByte();
                        }
                    }
                }
            }
            try
            {
                Mob.arrMobTemplate[mobTemplateId].indexSplash[0] = (sbyte)(Mob.arrMobTemplate[mobTemplateId].frameChar[0].Length - 7);
                Mob.arrMobTemplate[mobTemplateId].indexSplash[1] = (sbyte)(Mob.arrMobTemplate[mobTemplateId].frameChar[1].Length - 7);
                Mob.arrMobTemplate[mobTemplateId].indexSplash[2] = (sbyte)(Mob.arrMobTemplate[mobTemplateId].frameChar[3].Length - 7);
                Mob.arrMobTemplate[mobTemplateId].indexSplash[3] = (sbyte)(Mob.arrMobTemplate[mobTemplateId].frameChar[3].Length - 7);
            }
            catch (Exception)
            {
            }
            for (int num2 = 0; num2 < 3; num2++)
            {
                Mob.arrMobTemplate[mobTemplateId].indexSplash[num2] = dataInputStream.readByte();
            }
            Mob.arrMobTemplate[mobTemplateId].indexSplash[3] = Mob.arrMobTemplate[mobTemplateId].indexSplash[2];
            Mob.arrMobTemplate[mobTemplateId].imginfo = new ImageInfo[dataInputStream.readByte()];
        }
        catch (Exception)
        {
        }
    }
}
