using System;
using UnityEngine;

public class GameScr : mScreen, IChatable, IActionListener
{
	public static GameScr instance;

	public static int gW;

	public static int gH;

	public static int gW2;

	public static int gssw;

	public static int gssh;

	public static int gH34;

	public static int gW3;

	public static int gH3;

	public static int gH23;

	public static int gW23;

	public static int gH2;

	public static int csPadMaxH;

	public static int cmdBarH;

	public static int gW34;

	public static int gW6;

	public static int gH6;

	public static int cmx;

	public static int cmy;

	public static int cmdx;

	public static int cmdy;

	public static int cmvx;

	public static int cmvy;

	public static int cmtoX;

	public static int cmtoY;

	public static int cmxLim;

	public static int cmyLim;

	public static int gssx;

	public static int gssy;

	public static int gssxe;

	public static int gssye;

	public Command cmdback;

	public Command cmdBag;

	public Command cmdSkill;

	public Command cmdTiemnang;

	public Command cmdtrangbi;

	public Command cmdInfo;

	public Command cmdFocus;

	public Command cmdFire;

	public Command cmdBijuu;

	public Command cmdTrangbi2;

	public static int d;

	public static int mpPotion;

	public static int hpPotion;

	public static SkillPaint[] sks;

	public static Arrowpaint[] arrs;

	public static Part[] parts;

	public static EffectCharPaint[] efs;

	private int moveUp;

	private int moveDow;

	private int idTypeTask;

	private bool isstarOpen;

	private bool isChangeSkill;

	private bool isShortcut;

	public static MyVector vMobSoul;

	public static MyVector vClan;

	public static MyVector vParty;

	public static MyVector vPtMap;

	public static MyVector vFriend;

	public static MyVector vList;

	public static MyVector vFriendWait;

	public static MyVector vEnemies;

	public static MyVector vCharInMap;

	public static MyVector vItemMap;

	public static MyVector vMobAttack;

	public static MyVector vSet;

	public static MyVector vMob;

	public static MyVector vNpc;

	public static MyVector vBuNhin;

	public static MyVector vLanterns;

	public static NClass[] nClasss;

	public static int indexSize;

	public static int indexTitle;

	public static int indexSelect;

	public static int indexRow;

	public static int indexRowMax;

	public static int indexMenu;

	public static int indexCard;

	public Item itemFocus;

	public static ItemOptionTemplate[] iOptionTemplates;

	public static SkillOptionTemplate[] sOptionTemplates;

	private static Scroll scrInfo;

	public static Scroll scrMain;

	private static GamePad gamePad;

	public static Item[] arrItemNonNam;

	public static Item[] arrItemNonNu;

	public static Item[] arrItemAoNam;

	public static Item[] arrItemAoNu;

	public static Item[] arrItemGangTayNam;

	public static Item[] arrItemGangTayNu;

	public static Item[] arrItemQuanNam;

	public static Item[] arrItemQuanNu;

	public static Item[] arrItemGiayNam;

	public static Item[] arrItemGiayNu;

	public static Item[] arrItemLien;

	public static Item[] arrItemNhan;

	public static Item[] arrItemNgocBoi;

	public static Item[] arrItemPhu;

	public static Item[] arrItemWeapon;

	public static Item[] arrItemStack;

	public static Item[] arrItemStackLock;

	public static Item[] arrItemGrocery;

	public static Item[] arrItemGroceryLock;

	public static Item[] arrItemStore;

	public static Item[] arrItemElites;

	public static Item[] arrItemClanShop;

	public static Item[] arrItemBook;

	public static Item[] arrItemFashion;

	public static Item[] arrItemUpPeal;

	public static Item[] arrItemUpGrade;

	public static Item[] arrItemSplit;

	public static Item[] arrItemTradeMe;

	public static Item[] arrItemTradeOrder;

	public static Item[] arrItemConvert;

	public static ItemStands[] arrItemStands;

	public static Item itemUpGrade;

	public static Item itemSplit;

	public static Item itemSell;

	public static short[] arrItemSprin;

	public int numSprinLeft;

	public static MyVector vItemUpGrade;

	public static bool isTypeXu;

	public static bool isViewNext;

	public static bool isViewClanMemOnline;

	public static bool isSortClanByPointWeek;

	public static bool isViewClanInvite;

	public static bool isChop;

	public static bool isMessageMenu;

	public static string titleInputText;

	public static bool isPaintRankedList;

	public static bool isPaintAuctionSale;

	public static bool isPaintAlert;

	public static bool isPaintTask;

	public static bool isPaintTeam;

	public static bool isPaintFindTeam;

	public static bool isPaintFriend;

	public static bool isPaintList;

	public static bool isPaintEnemies;

	public static bool isPaintItemInfo;

	public static bool isPaintSelectSkill;

	public static bool isPaintInfoMe;

	public static bool isPaintStore;

	public static bool isPaintEliteShop;

	public static bool isPaintNonNam;

	public static bool isPaintNonNu;

	public static bool isPaintAoNam;

	public static bool isPaintAoNu;

	public static bool isPaintGangTayNam;

	public static bool isPaintGangTayNu;

	public static bool isPaintQuanNam;

	public static bool isPaintQuanNu;

	public static bool isPaintGiayNam;

	public static bool isPaintGiayNu;

	public static bool isPaintLien;

	public static bool isPaintNhan;

	public static bool isPaintNgocBoi;

	public static bool isPaintPhu;

	public static bool isPaintWeapon;

	public static bool isPaintStack;

	public static bool isPaintStackLock;

	public static bool isPaintGrocery;

	public static bool isPaintGroceryLock;

	public static bool isPaintUpGrade;

	public static bool isPaintConvert;

	public static bool isPaintUpGradeGold;

	public static bool isPaintUpPearl;

	public static bool isPaintBox;

	public static bool isPaintSplit;

	public static bool isPaintCharInMap;

	public static bool isPaintTrade;

	public static bool isPaintZone;

	public static bool isPaintAuto;

	public static bool isPaintMessage;

	public static bool isPaintClan;

	public static bool isRequestMember;

	public static bool isPaintLuckySpin;

	public static bool isPaintAuctionBuy;

	public static bool isPaintLuyenThach;

	public static bool isPaintTinhluyen;

	public static bool isPaintDichChuyen;

	public static bool isPaintLuyenNgoc;

	public static bool isPaintKhamNgoc;

	public static bool isPaintGotNgoc;

	public static bool isPaintThaoNgoc;

	public static bool isPaintLucky_Draw;

	public static bool isPaintGiaoDo;

	public static bool isShopOnline;

	public static Char currentCharViewInfo;

	public static long[] exps;

	public static int[] crystals;

	public static int[] upClothe;

	public static int[] upAdorn;

	public static int[] upWeapon;

	public static int[] coinUpCrystals;

	public static int[] coinUpClothes;

	public static int[] coinUpAdorns;

	public static int[] coinUpWeapons;

	public static int[] maxPercents;

	public static int[] goldUps;

	public static int[] coinGotngoc;

	public int zoneCol = 6;

	public int[] zones;

	public int[] pts;

	public int typeTrade;

	public int typeTradeOrder;

	public int coinTrade;

	public int coinTradeOrder;

	public int timeTrade;

	public int typeSortPrice;

	public int typeSortLevel;

	public int typeSortName;

	public int indexItemUse = -1;

	public int cLastFocusID = -1;

	public int cPreFocusID = -1;

	public bool isLockKey;

	public static sbyte[][] tasks;

	public static sbyte[][] mapTasks;

	public MyVector texts;

	public string textsTitle;

	public TField tfText;

	public static sbyte vcData;

	public static sbyte vcMap;

	public static sbyte vcSkill;

	public static sbyte vcItem;

	public static sbyte vsData;

	public static sbyte vsMap;

	public static sbyte vsSkill;

	public static sbyte vsItem;

	public static Image imgTopBar;

	public static Image imgArrow;

	public static Image imgArrow2;

	public static Image imgChat;

	public static Image imgMenu;

	public static Image imgFocus;

	public static Image imgButton;

	public static Image imgButton2;

	public static Image imgHpp;

	public static Image imgMpp;

	public static Image imgRight;

	public static Image imgRight2;

	public static Image imgSkill;

	public static Image imgMapBorder;

	public static Image imgLbtn;

	public static Image imgLbtnFocus;

	public static Image imgSelect;

	public static Image imgAnalog1;

	public static Image imgAnalog2;

	public static Image imgMenu1;

	public static Image imgMenu2;

	public static Image imgTf;

	public static Image imgMatcho;

	public static Image imgFiremoto;

	public string tradeName = string.Empty;

	public string tradeItemName = string.Empty;

	public int timeLengthMap;

	public int timeStartMap;

	public static sbyte typeViewInfo;

	public static sbyte typeActive;

	private int[] xM = new int[2];

	private int[] yM = new int[2];

	public long timePoint;

	private int[] xMounts;

	private int[] yMounts;

	public string[] YenCards = new string[9] { "10000", "20000", "30000", "50000", "100000", "200000", "500000", "1000000", "5000000" };

	public int yenTemp;

	public int typeba;

	public string[] yenValue;

	public static MyVector vItemTreeFront;

	public static MyVector vItemTreeBehind;

	public static MyVector vItemTreeBetwen;

	private static GamePad tgamePad;

	public static bool isTouchKey;

	public int wColoerMp = 85;

	public int hColorMp = 11;

	public static Image imgEggMonters;

	public static Image imgEffMob;

	public static Image imgEffMob1;

	public static Image imgEffMob2;

	public static Image imgEffMob3;

	public static Image imgsmokeFollow;

	public static Command cmd240;

	public static Command cmd360;

	public static Command cmdallmap;

	public static bool isUseitemAuto;

	public static bool isAllmap;

	private static Skill[] keySkill;

	private static Skill[] onScreenSkill;

	public Command menu;

	private Command cmdPotentialAdd;

	private Command cmdSkillUp;

	private Command cmdAddFriend;

	private Command cmdBijuuAddPoint;

	private Command cmdBijuuSkillUp;

	public static int shaking;

	public static int count;

	private static int deltaY;

	private int saveAuto;

	private long lastMove;

	private long lastFire;

	public static int auto;

	public bool lockAutoMove;

	private int nSkill;

	private int selectedIndexSkill = -1;

	private long longPress;

	public static bool isManualFocus;

	private long lastSendUpdatePostion;

	public int runArrow;

	private static int yTouchBar;

	private static int xL;

	private static int yL;

	private static int xC;

	private static int yC;

	private static int xR;

	private static int yR;

	private static int xF;

	private static int yF;

	private static int xU;

	private static int yU;

	private static int xHP;

	private static int yHP;

	private static int xMP;

	private static int yMP;

	private static int xTG;

	private static int yTG;

	private static int[] xS;

	private static int[] yS;

	private static int xSkill;

	private static int ySkill;

	private static int padSkill;

	public static string[] flyTextString;

	public static int[] flyTextX;

	public static int[] flyTextY;

	public static int[] flyTextDx;

	public static int[] flyTextDy;

	public static int[] flyTextState;

	public static int[] flyTextColor;

	public static int[] splashX;

	public static int[] splashY;

	public static int[] splashState;

	public static int[] splashF;

	public static int[] splashDir;

	public static Image[] imgSplash;

	public static int cmdBarX;

	public static int cmdBarY;

	public static int cmdBarW;

	public static int hpBarX;

	public static int hpBarY;

	public static int hpBarW;

	public static int mpBarW;

	public static int expBarW;

	public static int lvPosX;

	public static int moneyPosX;

	public static int hpBarH;

	public static int girlHPBarY;

	public static int popupY;

	public static int popupX;

	public static int isborderIndex;

	public static int isselectedRow;

	private static Image imgNolearn;

	public static int indextabTrangbi;

	private int[] fhorse = new int[11]
	{
		0, 0, 0, 0, 0, 0, 1, 1, 1, 1,
		1
	};

	private int fhorsetrangbi;

	private int indexMember;

	private string[] arrClanInfo;

	private string[] arrClanDongGop;

	public int cmxp;

	public int cmvxp;

	public int cmdxp;

	public int cmxLimp;

	public int cmyLimp;

	public int cmyp;

	public int cmvyp;

	public int cmdyp;

	private int indexTiemNang;

	protected Command cmdGiaoDoMoveOut;

	private Command cmdTradeLock;

	private Command cmdTradeAccept;

	protected Command cmdKhamNgocMoveOut_Ngoc;

	protected Command cmdKhamNgocMoveOut_Item;

	protected Command cmdKhamNgocMoveOut_Stone;

	protected Command cmdUpgradeMoveOut;

	protected Command cmdConvertMoveOut;

	protected Command cmdSplitMoveOut;

	private Command cmdTradeSendMoney;

	private Command cmdTradeMoveOut;

	private Command cmdTradeViewItemInfo;

	private Command cmdTradeSelectItem;

	private Command cmdTradeSelectInBag;

	private Command cmdTradeSelectInList;

	public Command cmdCloseAll;

	private Command cmdEliteShopBuy;

	private Command cmdEliteShopView;

	private Command cmdStoreBuy;

	private Command cmdStoreView;

	private Command cmdStoreLockBuy;

	private Command cmdStoreLockView;

	private Command cmdClanStoreBuy;

	private Command cmdClanStoreView;

	private Command cmdStoreFashionBuy;

	private Command cmdStoreFashionView;

	private Command cmdNonNamBuy;

	private Command cmdNonNamView;

	private Command cmdNonNuBuy;

	private Command cmdNonNuView;

	private Command cmdAoNamBuy;

	private Command cmdAoNamView;

	private Command cmdAoNuBuy;

	private Command cmdAoNuView;

	private Command cmdGangTayNamBuy;

	private Command cmdGangTayNamView;

	private Command cmdGangTayNuBuy;

	private Command cmdGangTayNuView;

	private static int pa;

	public static bool trans;

	private string alertURL;

	private string fnick;

	public static int xstart;

	public static int ystart;

	public static int popupW;

	public static int popupH;

	public static int cmySK;

	public static int cmtoYSK;

	public static int cmdySK;

	public static int cmvySK;

	public static int cmyLimSK;

	public static int columns;

	public static int rows;

	private int totalRowInfo;

	private int ypaintKill;

	private int ylimUp;

	private int ylimDow;

	private int yPaint;

	private int[] color = new int[18]
	{
		0, 0, 0, 0, 600841, 600841, 667658, 667658, 3346944, 3346688,
		4199680, 5052928, 3276851, 3932211, 4587571, 5046280, 6684682, 3359744
	};

	private int[][] colorBorder = new int[5][]
	{
		new int[6] { 18687, 16869, 15052, 13235, 11161, 9344 },
		new int[6] { 45824, 39168, 32768, 26112, 19712, 13056 },
		new int[6] { 16744192, 15037184, 13395456, 11753728, 10046464, 8404992 },
		new int[6] { 13500671, 12058853, 10682572, 9371827, 7995545, 6684800 },
		new int[6] { 16711705, 15007767, 13369364, 11730962, 10027023, 8388621 }
	};

	private int[] size = new int[6] { 2, 1, 1, 1, 1, 1 };

	public static string Name_store;

	public static MyVector vecShop;

	public static int indexEff;

	public static EffectCharPaint effUpok;

	private int yhelp;

	public bool isPaintInfoHelpNotIphone;

	public static int inforX;

	public static int inforY;

	public static int inforW;

	public static int inforH;

	public Command cmdDead = new Command(mResources.DIES[0], 11038);

	protected Command cmdBagUseItem;

	protected Command cmdBagSortItem;

	private Command cmdItemInfoClose;

	protected Command cmdBagThrowItem;

	protected Command cmdBagSplitItem;

	private Command cmdBagViewItemInfo;

	private Command cmdBagSelectItem;

	public static string svTitle;

	public static string svAction;

	public static int INFO;

	public static int STORE;

	public static int ZONE;

	public static int UPGRADE;

	private int Hitem = 30;

	private int maxSizeRow = 5;

	private int isTranKyNang;

	private bool isTran;

	private int cmY_Old;

	private int cmX_Old;

	private int step;

	private Input2Dlg ipError;

	private string strErrCard = string.Empty;

	private long timeLastBuff;

	public static long lastAutoMove;

	public static int index;

	public static int[] fardistandsX;

	public static int[] fardistandsY;

	public static bool isItemNearMe;

	public static int pointCenterX;

	public static int pointCenterY;

	public static int rangeSearch;

	public short timeLucky_Draw;

	public short percentWin1Lucky_Draw;

	public short numPlayerLucky_Draw;

	public string timeC;

	public string totalMoneyLucky_Draw;

	public string percentWin2Lucky_Draw;

	public string winnerInfoLucky_Draw;

	public string myMoneyLucky_Draw;

	public long timeStart;

	public bool isRefresh;

	public static sbyte typeLucky_Draw;

	private mFont fnt = mFont.tahoma_7b_yellow;

	private sbyte countCaptcha;

	private sbyte[] arrowCaptcha = new sbyte[6] { -1, -1, -1, -1, -1, -1 };

	public sbyte indexThanThu;

	public MyVector clan_thanthu = new MyVector();

	private int xThanThu;

	private int yThanThu;

	private int wThanThu;

	private int hThanThu;

	private int xExpThanThu;

	private int yExpThanThu;

	private int wExpThanThu;

	private int hExpThanThu;

	private int xSelectThanThu;

	private int ySelectThanThu;

	private int wSelectThanThu;

	private int xRecThanThu;

	private int yRecThanThu;

	private int wRecThanThu;

	private int hRecThanThu;

	private int countSendRequests;

	private string strTime = string.Empty;

	public bool hideInterface;

	private int[][] arrNgocKhamEXP = new int[11][]
	{
		new int[2],
		new int[2] { 200, 10 },
		new int[2] { 500, 20 },
		new int[2] { 1000, 50 },
		new int[2] { 2000, 100 },
		new int[2] { 5000, 200 },
		new int[2] { 10000, 500 },
		new int[2] { 20000, 1000 },
		new int[2] { 50000, 2000 },
		new int[2] { 100000, 5000 },
		new int[2] { 100000, 10000 }
	};

	private const int CMD_BIJUU = 500;

	private const sbyte INDEXMENU_BIJUU = 6;

	private const sbyte INDEXMENU_BIJUU_NOPOINT = 0;

	private const sbyte INDEXMENU_BIJUU_POINT = 1;

	private const sbyte INDEXMENU_BIJUU_SKILL = 2;

	private static int indexBijuuMenu;

	public GameScr()
	{
		if (GameCanvas.w == 128 || GameCanvas.h <= 208)
		{
			indexSize = 20;
		}
		initCommand();
		left = menu;
		right = cmdFocus;
	}

	static GameScr()
	{
		vMobSoul = new MyVector();
		vClan = new MyVector();
		vParty = new MyVector();
		vPtMap = new MyVector();
		vFriend = new MyVector();
		vList = new MyVector();
		vFriendWait = new MyVector();
		vEnemies = new MyVector();
		vCharInMap = new MyVector();
		vItemMap = new MyVector();
		vMobAttack = new MyVector();
		vSet = new MyVector();
		vMob = new MyVector();
		vNpc = new MyVector();
		vBuNhin = new MyVector();
		vLanterns = new MyVector();
		indexSize = 28;
		indexTitle = 0;
		indexSelect = 0;
		indexRow = -1;
		indexMenu = 0;
		indexCard = -1;
		scrInfo = new Scroll();
		scrMain = new Scroll();
		gamePad = new GamePad();
		vItemUpGrade = new MyVector();
		isViewClanMemOnline = false;
		isSortClanByPointWeek = false;
		isViewClanInvite = true;
		isMessageMenu = false;
		titleInputText = string.Empty;
		isPaintRankedList = false;
		isPaintAuctionSale = false;
		isPaintAlert = false;
		isPaintTask = false;
		isPaintTeam = false;
		isPaintFindTeam = false;
		isPaintFriend = false;
		isPaintList = false;
		isPaintEnemies = false;
		isPaintItemInfo = false;
		isPaintSelectSkill = false;
		isPaintInfoMe = false;
		isPaintStore = false;
		isPaintEliteShop = false;
		isPaintNonNam = false;
		isPaintNonNu = false;
		isPaintAoNam = false;
		isPaintAoNu = false;
		isPaintGangTayNam = false;
		isPaintGangTayNu = false;
		isPaintQuanNam = false;
		isPaintQuanNu = false;
		isPaintGiayNam = false;
		isPaintGiayNu = false;
		isPaintLien = false;
		isPaintNhan = false;
		isPaintNgocBoi = false;
		isPaintPhu = false;
		isPaintWeapon = false;
		isPaintStack = false;
		isPaintStackLock = false;
		isPaintGrocery = false;
		isPaintGroceryLock = false;
		isPaintUpGrade = false;
		isPaintConvert = false;
		isPaintUpGradeGold = false;
		isPaintUpPearl = false;
		isPaintBox = false;
		isPaintSplit = false;
		isPaintCharInMap = false;
		isPaintTrade = false;
		isPaintZone = false;
		isPaintAuto = false;
		isPaintMessage = false;
		isPaintClan = false;
		isRequestMember = false;
		isPaintLuckySpin = false;
		isPaintAuctionBuy = false;
		isPaintLucky_Draw = false;
		isPaintGiaoDo = false;
		coinGotngoc = new int[11]
		{
			0, 5000, 40000, 135000, 320000, 625000, 1080000, 1715000, 2560000, 3645000,
			5000000
		};
		typeViewInfo = 0;
		typeActive = 0;
		vItemTreeFront = new MyVector();
		vItemTreeBehind = new MyVector();
		vItemTreeBetwen = new MyVector();
		tgamePad = new GamePad();
		isTouchKey = true;
		isUseitemAuto = false;
		isAllmap = false;
		keySkill = new Skill[3];
		onScreenSkill = new Skill[5];
		count = 0;
		deltaY = 20;
		isManualFocus = false;
		pa = 0;
		trans = false;
		popupW = 140;
		popupH = 160;
		columns = 6;
		Name_store = "Shop Online";
		vecShop = new MyVector();
		indexEff = 0;
		svTitle = string.Empty;
		svAction = string.Empty;
		INFO = 0;
		STORE = 1;
		ZONE = 2;
		UPGRADE = 3;
		isItemNearMe = false;
		typeLucky_Draw = 0;
		indexBijuuMenu = 0;
		flyTextX = new int[5];
		flyTextY = new int[5];
		flyTextDx = new int[5];
		flyTextDy = new int[5];
		flyTextState = new int[5];
		flyTextString = new string[5];
		flyTextColor = new int[8];
		for (int i = 0; i < 5; i++)
		{
			flyTextState[i] = -1;
		}
	}

	public static void load_GameScr()
	{
		GameCanvas.imgPlus12 = GameCanvas.loadImage("/plus12");
		imgEggMonters = GameCanvas.loadImage("/trung1");
		imgSelect = GameCanvas.loadImage("/u/select");
		imgMatcho = GameCanvas.loadImage("/hd/mat");
		imgFiremoto = GameCanvas.loadImage("/hd/lua");
		imgEffMob = GameCanvas.loadImage("/eff/g132");
		imgEffMob1 = GameCanvas.loadImage("/eff/g10");
		imgEffMob2 = GameCanvas.loadImage("/eff/g6");
		imgEffMob3 = GameCanvas.loadImage("/eff/g99");
		imgsmokeFollow = GameCanvas.loadImage("/eff/g9");
		imgTf = GameCanvas.loadImage("/hd/tf");
		imgMenu1 = GameCanvas.loadImage("/hd/btnlBig0");
		imgMenu2 = GameCanvas.loadImage("/hd/btnlBig1");
		imgButton = GameCanvas.loadImage("/hd/button");
		imgButton2 = GameCanvas.loadImage("/hd/button2");
		imgHpp = GameCanvas.loadImage("/hd/hpp");
		imgMpp = GameCanvas.loadImage("/hd/mpp");
		imgRight = GameCanvas.loadImage("/hd/right");
		imgRight2 = GameCanvas.loadImage("/hd/right2");
		imgSkill = GameCanvas.loadImage("/hd/skill");
		imgLbtn = GameCanvas.loadImage("/hd/btnl");
		mScreen.cmdW = imgLbtn.getWidth();
		imgLbtnFocus = GameCanvas.loadImage("/hd/btnlf");
		mScreen.cmdW = imgLbtn.getWidth();
		imgArrow = GameCanvas.loadImage("/hd/arrow");
		imgArrow2 = GameCanvas.loadImage("/hd/arrow2");
		imgChat = GameCanvas.loadImage("/hd/chat");
		imgFocus = GameCanvas.loadImage("/hd/focus");
		imgMenu = GameCanvas.loadImage("/hd/menu");
		imgTopBar = GameCanvas.loadImage("/hd/topbar");
		imgMapBorder = GameCanvas.loadImage("/hd/mapborder");
		imgAnalog1 = GameCanvas.loadImage("/hd/analog1");
		imgAnalog2 = GameCanvas.loadImage("/hd/analog2");
		sbyte[] array = RMS.loadRMS("dataVersion");
		sbyte[] array2 = RMS.loadRMS("mapVersion");
		sbyte[] array3 = RMS.loadRMS("skillVersion");
		sbyte[] array4 = RMS.loadRMS("itemVersion");
		if (array != null)
		{
			vcData = array[0];
		}
		if (array2 != null)
		{
			vcMap = array2[0];
		}
		if (array3 != null)
		{
			vcSkill = array3[0];
		}
		if (array4 != null)
		{
			vcItem = array4[0];
		}
	}

	public static long getMaxExp(int level)
	{
		long num = 0L;
		for (int i = 0; i <= level; i++)
		{
			num += exps[i];
		}
		return num;
	}

	public static void resetAllvector()
	{
		vCharInMap.removeAllElements();
		vItemMap.removeAllElements();
		vMobSoul.removeAllElements();
		Effect2.vEffect2.removeAllElements();
		Effect2.vAnimateEffect.removeAllElements();
		Effect2.vEffect2Outside.removeAllElements();
		vMobAttack.removeAllElements();
		vSet.removeAllElements();
		vMob.removeAllElements();
		vNpc.removeAllElements();
		vBuNhin.removeAllElements();
		Char.getMyChar().vMovePoints.removeAllElements();
	}

	public void loadSkillShortcut()
	{
		Service.gI().loadRMS("KSkill");
		Service.gI().loadRMS("OSkill");
		Service.gI().loadRMS("CSkill");
	}

	public void loadSkillShortcutNhanban()
	{
		Service.gI().loadRMS("KSkill");
		Service.gI().loadRMS("OSkill");
		Service.gI().loadRMS("CSkill");
	}

	public void onOSkill(sbyte[] oSkillID)
	{
		onScreenSkill = new Skill[5];
		if (oSkillID == null)
		{
			loadDefaultOnScreenSkill();
			return;
		}
		for (int i = 0; i < oSkillID.Length; i++)
		{
			for (int j = 0; j < Char.getMyChar().vSkillFight.size(); j++)
			{
				Skill skill = (Skill)Char.getMyChar().vSkillFight.elementAt(j);
				if (skill.template.id == oSkillID[i])
				{
					onScreenSkill[i] = skill;
					break;
				}
			}
		}
	}

	public void onKSkill(sbyte[] kSkillID)
	{
		keySkill = new Skill[3];
		if (kSkillID == null)
		{
			loadDefaultKeySkill();
			return;
		}
		for (int i = 0; i < kSkillID.Length; i++)
		{
			for (int j = 0; j < Char.getMyChar().vSkillFight.size(); j++)
			{
				Skill skill = (Skill)Char.getMyChar().vSkillFight.elementAt(j);
				if (skill.template.id == kSkillID[i])
				{
					keySkill[i] = skill;
					break;
				}
			}
		}
	}

	public void onCSkill(sbyte[] cSkillID)
	{
		if (cSkillID == null || cSkillID.Length == 0)
		{
			if (Char.getMyChar().vSkillFight.size() > 0)
			{
				Char.getMyChar().myskill = (Skill)Char.getMyChar().vSkillFight.elementAt(0);
			}
		}
		else
		{
			for (int i = 0; i < Char.getMyChar().vSkillFight.size(); i++)
			{
				Skill skill = (Skill)Char.getMyChar().vSkillFight.elementAt(i);
				if (skill.template.id == cSkillID[0])
				{
					Char.getMyChar().myskill = skill;
					Char.getMyChar().lastNormalSkill = skill;
					break;
				}
			}
		}
		if (Char.getMyChar().myskill != null)
		{
			Service.gI().selectSkill(Char.getMyChar().myskill.template.id);
			saveRMSCurrentSkill(Char.getMyChar().myskill.template.id);
		}
	}

	private void loadDefaultOnScreenSkill()
	{
		Out.println("LOAD DEFAULT ONSCREEN SKILL");
		for (int i = 0; i < onScreenSkill.Length && i < Char.getMyChar().vSkillFight.size(); i++)
		{
			Skill skill = (Skill)Char.getMyChar().vSkillFight.elementAt(i);
			onScreenSkill[i] = skill;
		}
		saveOnScreenSkillToRMS();
	}

	private void loadDefaultKeySkill()
	{
		Out.println("LOAD DEFAULT KEY SKILL");
		for (int i = 0; i < keySkill.Length && i < Char.getMyChar().vSkillFight.size(); i++)
		{
			Skill skill = (Skill)Char.getMyChar().vSkillFight.elementAt(i);
			keySkill[i] = skill;
		}
		saveKeySkillToRMS();
	}

	protected void doSetOnScreenSkill(SkillTemplate skillTemplate)
	{
		Skill skill = Char.getMyChar().getSkill(skillTemplate);
		MyVector myVector = new MyVector();
		for (int i = 0; i < 5; i++)
		{
			bool flag = false;
			if (onScreenSkill[i] == null)
			{
				flag = true;
			}
			myVector.addElement(new Command(p: new object[2]
			{
				skill,
				i + string.Empty
			}, caption: mResources.CELLS + " " + (i + 1), action: 11120));
			if (flag)
			{
				break;
			}
		}
		GameCanvas.menu.startAt(myVector, 0);
	}

	private Member curMemberSelected()
	{
		return (Member)vClan.elementAt(indexRow);
	}

	protected void doSetKeySkill(SkillTemplate skillTemplate)
	{
		Skill skill = Char.getMyChar().getSkill(skillTemplate);
		string[] array = ((!TField.isQwerty) ? mResources.KEY_T9 : mResources.KEY_QWERTY);
		MyVector myVector = new MyVector();
		for (int i = 0; i < 3; i++)
		{
			myVector.addElement(new Command(p: new object[2]
			{
				skill,
				i + string.Empty
			}, caption: array[i], action: 11121));
		}
		GameCanvas.menu.startAt(myVector, 0);
	}

	protected void doMenusynthesis()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.SYNTHESIS[0], 110002));
		myVector.addElement(new Command(mResources.SYNTHESIS[1], 1100032));
		myVector.addElement(new Command(mResources.SYNTHESIS[2], 1100033));
		myVector.addElement(new Command(mResources.Lucky_draw, 1100034));
		myVector.addElement(new Command(mResources.CONFIG, LoginScr.mgI(), 1006, null));
		GameCanvas.menu.startAt(myVector, 3);
	}

	protected void saveOnScreenSkillToRMS()
	{
		sbyte[] array = new sbyte[onScreenSkill.Length];
		for (int i = 0; i < onScreenSkill.Length; i++)
		{
			if (onScreenSkill[i] == null)
			{
				array[i] = -1;
			}
			else
			{
				array[i] = onScreenSkill[i].template.id;
			}
		}
		if (Char.getMyChar().isHumanz())
		{
			Service.gI().saveRms("OSkill", array, 0);
		}
		else
		{
			Service.gI().saveRms("OSkill", array, 1);
		}
	}

	protected void saveKeySkillToRMS()
	{
		sbyte[] array = new sbyte[keySkill.Length];
		for (int i = 0; i < keySkill.Length; i++)
		{
			if (keySkill[i] == null)
			{
				array[i] = -1;
			}
			else
			{
				array[i] = keySkill[i].template.id;
			}
		}
		if (Char.getMyChar().isHumanz())
		{
			Service.gI().saveRms("KSkill", array, 0);
		}
		else
		{
			Service.gI().saveRms("KSkill", array, 1);
		}
	}

	protected void saveRMSCurrentSkill(sbyte id)
	{
	}

	public void addSkillShortcut(Skill skill)
	{
		if (skill.template.type == 0)
		{
			return;
		}
		Out.println("ADD SKILL SHORTCUT TO SKILL " + skill.template.id);
		for (int i = 0; i < onScreenSkill.Length; i++)
		{
			if (onScreenSkill[i] == null)
			{
				onScreenSkill[i] = skill;
				break;
			}
		}
		for (int j = 0; j < keySkill.Length; j++)
		{
			if (keySkill[j] == null)
			{
				keySkill[j] = skill;
				break;
			}
		}
		if (Char.getMyChar().myskill == null)
		{
			Char.getMyChar().myskill = skill;
		}
		saveKeySkillToRMS();
		saveOnScreenSkillToRMS();
	}

	public void createConfirm(string[] menu, Npc npc)
	{
		resetButton();
		isLockKey = true;
		left = new Command(menu[0], 130011, npc);
		right = new Command(menu[1], 130012, npc);
	}

	public void createMenu(string[] menu, Npc npc)
	{
		MyVector myVector = new MyVector();
		for (int i = 0; i < menu.Length; i++)
		{
			myVector.addElement(new Command(menu[i], 11057, npc));
		}
		GameCanvas.menu.startAt(myVector, 2);
	}

	public void doBag()
	{
		currentCharViewInfo = Char.getMyChar();
		indexMenu = 0;
		doMiniMenuInforMe();
	}

	public void doskill()
	{
		currentCharViewInfo = Char.getMyChar();
		indexMenu = 1;
		doMiniMenuInforMe();
	}

	public void doTiemnangMe()
	{
		currentCharViewInfo = Char.getMyChar();
		indexMenu = 2;
		doMiniMenuInforMe();
	}

	public void doInfo()
	{
		currentCharViewInfo = Char.getMyChar();
		indexMenu = 3;
		doMiniMenuInforMe();
	}

	public void doTrangbi()
	{
		currentCharViewInfo = Char.getMyChar();
		indexMenu = 4;
		doMiniMenuInforMe();
	}

	public void doThucuoi()
	{
		currentCharViewInfo = Char.getMyChar();
		indexMenu = 5;
		doMiniMenuInforMe();
	}

	public void doBiJuu()
	{
		currentCharViewInfo = Char.getMyChar();
		indexMenu = 6;
		indexBijuuMenu = 0;
		doMiniMenuInforMe();
	}

	public void doBiJuu_Point()
	{
		currentCharViewInfo = Char.getMyChar();
		indexMenu = 6;
		indexBijuuMenu = 1;
		doMiniMenuInforMe();
	}

	public void doBiJuu_Skill()
	{
		currentCharViewInfo = Char.getMyChar();
		indexMenu = 6;
		indexBijuuMenu = 2;
		doMiniMenuInforMe();
	}

	public void readPart()
	{
		DataInputStream dataInputStream = null;
		try
		{
			dataInputStream = new DataInputStream(RMS.loadRMS("nj_part"));
			int num = dataInputStream.readShort();
			parts = new Part[num];
			for (int i = 0; i < num; i++)
			{
				int type = dataInputStream.readByte();
				parts[i] = new Part(type);
				for (int j = 0; j < parts[i].pi.Length; j++)
				{
					parts[i].pi[j] = new PartImage();
					parts[i].pi[j].id = dataInputStream.readShort();
					parts[i].pi[j].dx = dataInputStream.readByte();
					parts[i].pi[j].dy = dataInputStream.readByte();
				}
			}
		}
		catch (Exception ex)
		{
			Out.println(" loi doc part ");
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			try
			{
				dataInputStream.close();
			}
			catch (Exception ex2)
			{
				Out.println(ex2.Message + ex2.StackTrace);
			}
		}
	}

	public void readEfect()
	{
		DataInputStream dataInputStream = null;
		try
		{
			dataInputStream = new DataInputStream(RMS.loadRMS("nj_effect"));
			int num = dataInputStream.readShort();
			efs = new EffectCharPaint[num];
			for (int i = 0; i < num; i++)
			{
				efs[i] = new EffectCharPaint();
				efs[i].idEf = dataInputStream.readShort();
				efs[i].arrEfInfo = new EffectInfoPaint[dataInputStream.readByte()];
				for (int j = 0; j < efs[i].arrEfInfo.Length; j++)
				{
					efs[i].arrEfInfo[j] = new EffectInfoPaint();
					efs[i].arrEfInfo[j].idImg = dataInputStream.readShort();
					efs[i].arrEfInfo[j].dx = dataInputStream.readByte();
					efs[i].arrEfInfo[j].dy = dataInputStream.readByte();
				}
			}
		}
		catch (Exception ex)
		{
			Out.println("loi doc eff");
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			try
			{
				dataInputStream.close();
			}
			catch (Exception ex2)
			{
				Out.println(ex2.Message + ex2.StackTrace);
			}
		}
	}

	public void readArrow()
	{
		DataInputStream dataInputStream = null;
		try
		{
			dataInputStream = new DataInputStream(RMS.loadRMS("nj_arrow"));
			int num = dataInputStream.readShort();
			arrs = new Arrowpaint[num];
			for (int i = 0; i < num; i++)
			{
				arrs[i] = new Arrowpaint();
				arrs[i].id = dataInputStream.readShort();
				arrs[i].imgId[0] = dataInputStream.readShort();
				arrs[i].imgId[1] = dataInputStream.readShort();
				arrs[i].imgId[2] = dataInputStream.readShort();
			}
		}
		catch (Exception ex)
		{
			Out.println(" loi doc arr");
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			try
			{
				dataInputStream.close();
			}
			catch (Exception ex2)
			{
				Out.println(ex2.Message + ex2.StackTrace);
			}
		}
	}

	public void readSkill()
	{
		DataInputStream dataInputStream = null;
		try
		{
			dataInputStream = new DataInputStream(RMS.loadRMS("nj_skill"));
			int num = dataInputStream.readShort();
			int num2 = 0;
			for (int i = 0; i < nClasss.Length; i++)
			{
				num2 += nClasss[i].skillTemplates.Length;
			}
			sks = new SkillPaint[num2];
			for (int j = 0; j < num; j++)
			{
				short num3 = dataInputStream.readShort();
				sks[num3] = new SkillPaint();
				sks[num3].id = num3;
				sks[num3].effId = dataInputStream.readShort();
				sks[num3].numEff = dataInputStream.readByte();
				sks[num3].skillStand = new SkillInfoPaint[dataInputStream.readByte()];
				for (int k = 0; k < sks[num3].skillStand.Length; k++)
				{
					sks[num3].skillStand[k] = new SkillInfoPaint();
					sks[num3].skillStand[k].status = dataInputStream.readByte();
					sks[num3].skillStand[k].effS0Id = dataInputStream.readShort();
					sks[num3].skillStand[k].e0dx = dataInputStream.readShort();
					sks[num3].skillStand[k].e0dy = dataInputStream.readShort();
					sks[num3].skillStand[k].effS1Id = dataInputStream.readShort();
					sks[num3].skillStand[k].e1dx = dataInputStream.readShort();
					sks[num3].skillStand[k].e1dy = dataInputStream.readShort();
					sks[num3].skillStand[k].effS2Id = dataInputStream.readShort();
					sks[num3].skillStand[k].e2dx = dataInputStream.readShort();
					sks[num3].skillStand[k].e2dy = dataInputStream.readShort();
					sks[num3].skillStand[k].arrowId = dataInputStream.readShort();
					sks[num3].skillStand[k].adx = dataInputStream.readShort();
					sks[num3].skillStand[k].ady = dataInputStream.readShort();
				}
				sks[num3].skillfly = new SkillInfoPaint[dataInputStream.readByte()];
				for (int l = 0; l < sks[num3].skillfly.Length; l++)
				{
					sks[num3].skillfly[l] = new SkillInfoPaint();
					sks[num3].skillfly[l].status = dataInputStream.readByte();
					sks[num3].skillfly[l].effS0Id = dataInputStream.readShort();
					sks[num3].skillfly[l].e0dx = dataInputStream.readShort();
					sks[num3].skillfly[l].e0dy = dataInputStream.readShort();
					sks[num3].skillfly[l].effS1Id = dataInputStream.readShort();
					sks[num3].skillfly[l].e1dx = dataInputStream.readShort();
					sks[num3].skillfly[l].e1dy = dataInputStream.readShort();
					sks[num3].skillfly[l].effS2Id = dataInputStream.readShort();
					sks[num3].skillfly[l].e2dx = dataInputStream.readShort();
					sks[num3].skillfly[l].e2dy = dataInputStream.readShort();
					sks[num3].skillfly[l].arrowId = dataInputStream.readShort();
					sks[num3].skillfly[l].adx = dataInputStream.readShort();
					sks[num3].skillfly[l].ady = dataInputStream.readShort();
				}
			}
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
		finally
		{
			try
			{
				dataInputStream.close();
			}
			catch (Exception ex2)
			{
				Out.println(ex2.Message + ex2.StackTrace);
			}
		}
	}

	public static long[] getLevelExp(long exp)
	{
		long num = exp;
		int num2 = 0;
		for (num2 = 0; num2 < exps.Length && num >= exps[num2]; num2++)
		{
			num -= exps[num2];
		}
		return new long[2] { num2, num };
	}

	public static void setLevel_Exp(long exp, bool value)
	{
		long[] levelExp = getLevelExp(exp);
		if (value)
		{
			Char.getMyChar().clevel = (int)levelExp[0];
		}
		Char.getMyChar().cExpR = levelExp[1];
	}

	public static GameScr gI()
	{
		if (instance == null)
		{
			instance = new GameScr();
		}
		return instance;
	}

	public static void clearGameScr()
	{
		instance = null;
		arrItemUpPeal = (arrItemUpGrade = (arrItemSplit = (arrItemTradeMe = (arrItemTradeOrder = null))));
		itemUpGrade = (itemSplit = null);
	}

	public void loadGameScr()
	{
		loadSplash();
		loadCmdBar();
		Res.init();
	}

	private void initCommand()
	{
		cmdBijuuAddPoint = new Command(mResources.ADD, 5043);
		cmdBijuuSkillUp = new Command(mResources.ADD, 5053);
		cmdAddFriend = new Command(mResources.ACCEPT, 11002);
		cmdSkillUp = new Command(mResources.ADD, 11003);
		cmdGangTayNuView = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11004);
		cmdGangTayNuBuy = new Command(mResources.BUY, 11005);
		cmdPotentialAdd = new Command(mResources.ADD, 11006);
		cmdGangTayNamView = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11007);
		cmdGangTayNamBuy = new Command(mResources.BUY, 11008);
		cmdAoNuView = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11009);
		cmdAoNuBuy = new Command(mResources.BUY, 11010);
		cmdAoNamView = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11011);
		cmdAoNamBuy = new Command(mResources.BUY, 11012);
		cmdNonNuView = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11013);
		cmdNonNuBuy = new Command(mResources.BUY, 11014);
		cmdNonNamView = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11015);
		cmdNonNamBuy = new Command(mResources.BUY, 11016);
		cmdStoreFashionView = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 13001);
		cmdStoreLockBuy = new Command(mResources.BUY, 11018);
		cmdStoreFashionBuy = new Command(mResources.BUY, 13002);
		cmdStoreView = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11019);
		cmdStoreBuy = new Command(mResources.BUY, 11020);
		cmdEliteShopBuy = new Command(mResources.BUY, 14022);
		cmdEliteShopView = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 14023);
		cmdClanStoreView = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 14018);
		cmdClanStoreBuy = new Command(mResources.BUY, 14019);
		cmdCloseAll = new Command(mResources.CLOSE, 11021);
		cmdBagSelectItem = new Command(mResources.SELECT, 11022);
		cmdBagViewItemInfo = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11023);
		cmdBagThrowItem = new Command(mResources.THROW, 11024);
		cmdBagSplitItem = new Command(mResources.SPLIT, 110244);
		cmdItemInfoClose = new Command(mResources.CLOSE, 11025);
		cmdBagUseItem = new Command(mResources.USE, 11026);
		cmdBagSortItem = new Command(mResources.SORT, 110221);
		cmdTradeSelectInList = new Command(mResources.SELECT, 11027);
		cmdTradeSelectInBag = new Command(mResources.SELECT, 11028);
		cmdTradeSelectItem = new Command(mResources.SELECT, 11029);
		cmdTradeViewItemInfo = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11030);
		cmdback = new Command(mResources.BACK, 11021);
		menu = new Command(mResources.MENU, 11000);
		cmdFocus = new Command(string.Empty, 11001);
		cmdTradeLock = new Command(mResources.LOCK1, 11032);
		cmdTradeAccept = new Command(mResources.ACCEPT, 11033);
		cmdUpgradeMoveOut = new Command(mResources.MOVEOUT, 11034);
		cmdConvertMoveOut = new Command(mResources.MOVEOUT, 14014);
		cmdSplitMoveOut = new Command(mResources.MOVEOUT, 11035);
		cmdTradeSendMoney = new Command(mResources.SENDMONEY, 11036);
		cmdTradeMoveOut = new Command(mResources.MOVEOUT, 11037);
		cmdKhamNgocMoveOut_Ngoc = new Command(mResources.MOVEOUT, 339);
		cmdKhamNgocMoveOut_Item = new Command(mResources.MOVEOUT, 340);
		cmdKhamNgocMoveOut_Stone = new Command(mResources.MOVEOUT, 343);
		cmdGiaoDoMoveOut = new Command(mResources.MOVEOUT, 402);
		cmd240 = new Command("240", 110381);
		cmd360 = new Command("360", 1103911);
		cmdallmap = new Command("Toàn Map", 110401);
		cmdTrangbi2 = new Command(mResources.tbi2, 2003);
		cmdTrangbi2.setpos(GameCanvas.w / 2 - mScreen.cmdW / 2, GameCanvas.h - 26);
		if (GameCanvas.isTouch && GameCanvas.isTouchControl)
		{
			menu.x = gW - 135;
			menu.y = 6;
			menu.img = imgMenu;
			cmdFocus.x = gW;
			cmdFocus.y = gH;
			if (GameCanvas.isTouchControlSmallScreen)
			{
				menu.x = gW / 2 - 38;
				menu.y = gH - 34;
			}
		}
	}

	protected void doCloseItemInfo()
	{
		if (!GameCanvas.isTouch || (GameCanvas.isTouch && GameCanvas.w < 320) || (isPaintInfoMe && indexMenu > 0) || (isPaintClan && indexMenu == 0))
		{
			isPaintItemInfo = false;
		}
		isViewNext = false;
		if (isPaintUI())
		{
			updateCommandForUI();
			right = cmdCloseAll;
		}
		else
		{
			setLCR();
		}
	}

	public void doUpPotential()
	{
		if ((indexTitle > 0 && indexTitle <= 4) || GameCanvas.isTouch)
		{
			GameCanvas.inputDlg.show(mResources.INPUT_POINT, cmdPotentialAdd, TField.INPUT_TYPE_NUMERIC);
		}
	}

	public void doUpSkill()
	{
		if (indexTitle > 0 && indexTitle <= 4)
		{
			GameCanvas.inputDlg.show(mResources.INPUT_POINT, cmdSkillUp, TField.INPUT_TYPE_NUMERIC);
		}
	}

	public void doAddFriend()
	{
		if (isPaintFriend)
		{
			GameCanvas.inputDlg.show(mResources.BE_FRIEND_WITH, cmdAddFriend, TField.INPUT_TYPE_ANY);
		}
	}

	public void doMiniMenuInforMe()
	{
		isPaintInfoMe = true;
		if (!Main.isPC)
		{
			setPopupSize(175, 200 - ((indexMenu != 4) ? indexSize : 0));
		}
		else
		{
			setPopupSize(175, 200);
		}
		setLCR();
		if (indexMenu == 3 && currentCharViewInfo.charID == Char.getMyChar().charID)
		{
			Service.gI().viewInfo(currentCharViewInfo.cName);
		}
		if (indexMenu == 5)
		{
			xMounts = new int[5];
			yMounts = new int[5];
			xstart = popupX + 5;
			ystart = popupY + 35;
			xMounts[0] = xstart + 5;
			yMounts[0] = ystart + 35;
			xMounts[1] = xstart + 5;
			yMounts[1] = ystart + 70;
			xMounts[2] = xstart + 131;
			yMounts[2] = ystart + 35;
			xMounts[3] = xstart + 131;
			yMounts[3] = ystart + 70;
			xMounts[4] = xMounts[0] + indexSize + 7;
			yMounts[4] = yMounts[0] - 5;
		}
		if (indexMenu == 6)
		{
			xMounts = new int[5];
			yMounts = new int[5];
			xstart = popupX + 5;
			ystart = popupY + 35;
			xMounts[0] = xstart + 5;
			yMounts[0] = ystart + 35;
			xMounts[1] = xstart + 5;
			yMounts[1] = ystart + 70;
			xMounts[2] = xstart + 131;
			yMounts[2] = ystart + 35;
			xMounts[3] = xstart + 131;
			yMounts[3] = ystart + 70;
			xMounts[4] = xMounts[0] + indexSize + 7;
			yMounts[4] = yMounts[0] - 5;
		}
		right = new Command(mResources.BACK, 11060);
	}

	protected void doMenuInforMe()
	{
		scrMain.clear();
		scrInfo.clear();
		isViewNext = false;
		cmdBag = new Command(mResources.MENUME[0], 1100011);
		cmdSkill = new Command(mResources.MENUME[1], 1100012);
		cmdTiemnang = new Command(mResources.MENUME[2], 1100013);
		cmdInfo = new Command(mResources.MENUME[3], 1100014);
		cmdtrangbi = new Command(mResources.MENUME[4], 1100015);
		cmdBijuu = new Command(mResources.MENUME[6], 1100017);
		MyVector myVector = new MyVector();
		myVector.addElement(cmdBag);
		myVector.addElement(cmdSkill);
		myVector.addElement(cmdTiemnang);
		myVector.addElement(cmdInfo);
		myVector.addElement(cmdtrangbi);
		myVector.addElement(new Command(mResources.MENUME[5], 1100016));
		myVector.addElement(cmdBijuu);
		GameCanvas.menu.startAt(myVector, 3);
	}

	protected void actMenu()
	{
		Command o = new Command(mResources.MENUGAMESCR[1], 110001);
		Command command = new Command(mResources.MENUGAMESCR[2], 110002);
		Command o2 = new Command(mResources.MENUGAMESCR[3], 110003);
		Command o3 = new Command(mResources.MENUGAMESCR[4], 110004);
		Command command2 = new Command(mResources.MENUGAMESCR[0], 110005);
		Command o4 = new Command(mResources.MENUGAMESCR[6], 110006);
		Command command3 = new Command(mResources.MENUGAMESCR[7], 110007);
		Command command4 = new Command(mResources.MENUGAMESCR[8], 110008);
		Command command5 = new Command(mResources.MENUGAMESCR[9], 110009);
		Command command6 = new Command(mResources.MENUGAMESCR[10], 110010);
		Command command7 = new Command(mResources.MENUGAMESCR[11], 110011);
		Command command8 = new Command(mResources.MENUGAMESCR[12], 110012);
		Command command9 = new Command(mResources.MENUGAMESCR[13], 110013);
		Command command10 = new Command(mResources.MENUGAMESCR[14], 110014);
		Command command11 = new Command(mResources.MENUGAMESCR[15], 110015);
		Command command12 = new Command(mResources.MENUGAMESCR[16], 110016);
		Command command13 = new Command(mResources.MENUGAMESCR[17], 110017);
		Command o5 = new Command(mResources.MENUGAMESCR[18], 110018);
		Command o6 = new Command("Xác thực tài khoản", 1100181);
		MyVector myVector = new MyVector();
		if (Char.getMyChar().clevel >= 3 && SelectServerScr.isVirtualAcc())
		{
			myVector.addElement(o6);
		}
		myVector.addElement(o);
		myVector.addElement(o2);
		myVector.addElement(o4);
		myVector.addElement(o5);
		myVector.addElement(o3);
		GameCanvas.menu.startAt(myVector, 3);
	}

	public void doShowTaskUI()
	{
		resetButton();
		isPaintTask = true;
		isLockKey = true;
		int num = ((!Main.isPC) ? indexSize : 0);
		setPopupSize(175, 200 - num);
		right = cmdCloseAll;
		left = new Command(mResources.MENUGAMESCR[2], 110002);
		center = new Command(mResources.CHANGE, 110019);
	}

	public void doShowFindTeamUI()
	{
		resetButton();
		isPaintFindTeam = true;
		isLockKey = true;
		int num = ((!Main.isPC) ? indexSize : 0);
		setPopupSize(175, 200 - num);
		right = cmdCloseAll;
		Service.gI().openFindParty();
		refreshFindTeam();
	}

	public void doShowCharInMap()
	{
		resetButton();
		if (cLastFocusID > 0)
		{
			indexRow = Char.getIndexChar(cLastFocusID);
		}
		else
		{
			indexRow = 0;
			cLastFocusID = -1;
		}
		isPaintCharInMap = true;
		isLockKey = true;
		int num = ((!Main.isPC) ? indexSize : 0);
		setPopupSize(175, 200 - num);
		right = cmdCloseAll;
	}

	public void doShowTeamUI()
	{
		resetButton();
		isPaintTeam = true;
		isLockKey = true;
		int num = ((!Main.isPC) ? indexSize : 0);
		setPopupSize(175, 200 - num);
		right = cmdCloseAll;
		refreshTeam();
	}

	public void doShowRankedListUI()
	{
		resetButton();
		isPaintRankedList = true;
		isLockKey = true;
		setPopupSize(175, 200);
		right = cmdCloseAll;
		left = (center = null);
		indexRow = 0;
	}

	public void doShowListUI()
	{
		resetButton();
		isPaintList = true;
		isLockKey = true;
		setPopupSize(175, 200);
		right = cmdCloseAll;
		left = (center = null);
		indexRow = 0;
	}

	public void doShowFriendUI()
	{
		resetButton();
		isPaintFriend = true;
		isLockKey = true;
		int num = ((!Main.isPC) ? indexSize : 0);
		setPopupSize(175, 200 - num);
		right = cmdCloseAll;
		left = new Command(mResources.LIST, 11044);
		center = null;
		indexRow = 0;
		Service.gI().requestFriend();
	}

	public void doShowEnemiesUI()
	{
		resetButton();
		isPaintEnemies = true;
		isLockKey = true;
		int num = ((!Main.isPC) ? indexSize : 0);
		setPopupSize(175, 200 - num);
		right = cmdCloseAll;
		left = new Command(mResources.LIST, 14017);
		center = null;
		indexRow = 0;
		Service.gI().requestEnemies();
	}

	public void refreshFindTeam()
	{
		if (!isPaintFindTeam)
		{
			return;
		}
		left = (center = null);
		left = new Command(mResources.MENU, 11045);
		if (vPtMap.size() > 0 && indexRow >= 0 && indexRow < vPtMap.size())
		{
			Party party = (Party)vPtMap.elementAt(indexRow);
			if (party != null && !Char.getMyChar().cName.Equals(party.name))
			{
				center = new Command(mResources.SELECT, 11046);
			}
		}
	}

	public void refreshTeam()
	{
		if (!isPaintTeam)
		{
			return;
		}
		left = (center = null);
		indexRow = 0;
		if (vParty.size() == 0)
		{
			center = null;
			left = new Command(mResources.MENU, 11047);
			return;
		}
		Party party = (Party)vParty.firstElement();
		if (party.charId == Char.getMyChar().charID)
		{
			left = new Command(mResources.TEAMLEADER, 11070, party);
		}
		else
		{
			left = new Command(mResources.OUT_TEAM, 11071);
		}
	}

	public override void switchToMe()
	{
		TileMap.loadMusicBackground();
		base.switchToMe();
	}

	protected void doShowMap()
	{
		if (TileMap.typeMap != TileMap.MAP_DAUTRUONG)
		{
			MapScr.gI().switchToMe();
		}
	}

	public void openUIZone(Message message)
	{
		InfoDlg.hide();
		try
		{
			sbyte b = message.reader().readByte();
			if (b > 0)
			{
				zones = new int[b];
				pts = new int[zones.Length];
				for (int i = 0; i < zones.Length; i++)
				{
					zones[i] = message.reader().readByte();
					pts[i] = message.reader().readByte();
				}
				isPaintZone = true;
				indexSelect = TileMap.zoneID;
				int num = ((!Main.isPC) ? indexSize : 0);
				setPopupSize(175, 200 - num);
				left = new Command(mResources.SELECT, 11067);
				center = new Command(string.Empty, 11067);
				right = cmdCloseAll;
			}
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
	}

	public void openUITrade()
	{
		try
		{
			resetButton();
			tradeItemName = string.Empty;
			typeTrade = 0;
			typeTrade = (typeTradeOrder = (coinTrade = (coinTradeOrder = 0)));
			isPaintTrade = true;
			arrItemTradeMe = new Item[12];
			arrItemTradeOrder = new Item[12];
			indexMenu = 0;
			int num = ((!Main.isPC) ? indexSize : 0);
			setPopupSize(175, 200 - num);
			right = cmdCloseAll;
		}
		catch (Exception ex)
		{
			Out.println(ex.ToString() + " loi tai ham openUITrade");
		}
	}

	public static void loadCamera(bool fullScreen)
	{
		gW = GameCanvas.w;
		if (!GameCanvas.isTouch || (GameCanvas.isTouch && !GameCanvas.isTouchControl))
		{
			cmdBarH = 36;
			if (GameCanvas.isTouch)
			{
				cmdBarH += 3;
			}
		}
		else
		{
			cmdBarH = 8;
		}
		gH = GameCanvas.h - cmdBarH - 20;
		if (fullScreen)
		{
			gH = GameCanvas.h;
		}
		if (GameCanvas.isTouch && GameCanvas.isTouchControl)
		{
			gH = GameCanvas.h;
		}
		if (GameCanvas.h == 160)
		{
			gH = 150;
		}
		cmdBarW = gW;
		if (GameCanvas.w > 176)
		{
			cmdBarW -= 50;
		}
		cmdBarX = 0;
		cmdBarY = GameCanvas.h - Paint.hTab - cmdBarH;
		girlHPBarY = 0;
		csPadMaxH = GameCanvas.h / 6;
		if (csPadMaxH < 48)
		{
			csPadMaxH = 48;
		}
		gW2 = gW >> 1;
		gH2 = gH >> 1;
		gW3 = gW / 3;
		gH3 = gH / 3;
		gW23 = 2 * gW / 3;
		gH23 = 2 * gH / 3;
		gW34 = 3 * gW / 4;
		gH34 = 3 * gH / 4;
		gW6 = gW / 6;
		gH6 = gH / 6;
		gssw = gW / TileMap.size + 2;
		gssh = gH / TileMap.size + 2;
		if (gW % 24 != 0)
		{
			gssw++;
		}
		cmxLim = (TileMap.tmw - 1) * TileMap.size - gW;
		cmyLim = (TileMap.tmh - 1) * TileMap.size - gH;
		if (GameCanvas.isTouch && GameCanvas.isTouchControl)
		{
			cmyLim += 60;
		}
		cmx = (cmtoX = Char.getMyChar().cx - gW2);
		cmy = (cmtoY = Char.getMyChar().cy - gH23);
		if (cmx < 24)
		{
			cmx = 24;
		}
		if (cmx > cmxLim)
		{
			cmx = cmxLim;
		}
		if (cmy < 0)
		{
			cmy = 0;
		}
		if (cmy > cmyLim)
		{
			cmy = cmyLim;
		}
		gssx = cmx / TileMap.size - 1;
		if (gssx < 0)
		{
			gssx = 0;
		}
		gssy = cmy / TileMap.size;
		gssxe = gssx + gssw;
		gssye = gssy + gssh;
		if (gssy < 0)
		{
			gssy = 0;
		}
		if (gssye > TileMap.tmh - 1)
		{
			gssye = TileMap.tmh - 1;
		}
		TileMap.countx = (gssxe - gssx) * 4;
		if (TileMap.countx > TileMap.tmw)
		{
			TileMap.countx = TileMap.tmw;
		}
		TileMap.county = (gssye - gssy) * 4;
		if (TileMap.county > TileMap.tmh)
		{
			TileMap.county = TileMap.tmh;
		}
		TileMap.gssx = (Char.getMyChar().cx - 2 * gW) / TileMap.size;
		if (TileMap.gssx < 0)
		{
			TileMap.gssx = 0;
		}
		TileMap.gssxe = TileMap.gssx + TileMap.countx;
		if (TileMap.gssxe > TileMap.tmw)
		{
			TileMap.gssxe = TileMap.tmw;
		}
		TileMap.gssy = (Char.getMyChar().cy - 2 * gH) / TileMap.size;
		if (TileMap.gssy < 0)
		{
			TileMap.gssy = 0;
		}
		TileMap.gssye = TileMap.gssy + TileMap.county;
		if (TileMap.gssye > TileMap.tmh)
		{
			TileMap.gssye = TileMap.tmh;
		}
		ChatTextField.gI().parentScreen = instance;
		ChatTextField.gI().tfChat.y = GameCanvas.h - 35 - ChatTextField.gI().tfChat.height;
		if (!GameCanvas.isTouch || (GameCanvas.isTouch && !GameCanvas.isTouchControl))
		{
			TileMap.setPosMiniMap(GameCanvas.w - 51, cmdBarY - 4, 50, 40);
		}
		else
		{
			TileMap.setPosMiniMap(GameCanvas.w - 60, 0, 60, 42);
		}
		yTouchBar = gH - 88;
		if (!Main.isPC)
		{
			xC = gW - 100;
			yC = 2;
			xL = 1;
			yL = yTouchBar + 50;
			xR = 42;
			yR = yTouchBar + 50;
			xF = gW - 50;
			yF = yTouchBar + 35;
			xU = 22;
			yU = yTouchBar + 19;
			xHP = gW - 74;
			yHP = yTouchBar + 13;
			xMP = gW - 85;
			yMP = yTouchBar + 50;
			xTG = gW - 37;
			yTG = yTouchBar - 1;
			if (GameCanvas.w >= 450)
			{
				yU -= 15;
				xU += 28;
				xR += 45;
				xL += 10;
				yTG -= 12;
				yHP -= 7;
				xF -= 18;
				xTG -= 10;
				xHP -= 17;
				xMP -= 24;
			}
			else if (GameCanvas.w >= 360)
			{
				yU -= 5;
				xU += 6;
				xR += 12;
				yTG -= 2;
				yHP -= 2;
				xHP -= 2;
				xMP -= 2;
			}
		}
		else
		{
			xMP = gW - 40;
			yMP = yTouchBar + 51;
			xHP = gW - 85;
			yHP = yTouchBar + 51;
		}
		xS = new int[onScreenSkill.Length];
		yS = new int[onScreenSkill.Length];
		if (GameCanvas.isTouch)
		{
			if (GameCanvas.isTouchControlSmallScreen)
			{
				xSkill = 2;
				ySkill = 55;
				padSkill = 5;
				for (int i = 0; i < xS.Length; i++)
				{
					xS[i] = i * (25 + padSkill);
					yS[i] = ySkill;
				}
				return;
			}
			if (GameCanvas.w <= 320)
			{
				xSkill = gW2 - onScreenSkill.Length * 25 / 2 - 15;
			}
			else
			{
				xSkill = gW2 - onScreenSkill.Length * 25 / 2 - 15;
			}
			ySkill = yTouchBar + 58;
			padSkill = 5;
			for (int j = 0; j < xS.Length; j++)
			{
				xS[j] = j * (25 + padSkill);
				yS[j] = ySkill;
			}
		}
		else
		{
			xSkill = 0;
			for (int k = 0; k < yS.Length; k++)
			{
				xS[k] = 2;
				yS[k] = 2 + 25 * k;
			}
		}
	}

	private static void updateCamera()
	{
		if (shaking != 0 && !GameCanvas.lowGraphic && !Main.isIpod && mGraphics.zoomLevel != 1)
		{
			cmx += NinjaUtil.random(-7, 7);
			count++;
			if (count > 20)
			{
				shaking = 0;
				count = 0;
			}
		}
		else if (cmx != cmtoX || cmy != cmtoY)
		{
			cmvx = cmtoX - cmx << 2;
			cmvy = cmtoY - cmy << 2;
			cmdx += cmvx;
			cmx += cmdx >> 4;
			cmdx &= 15;
			cmdy += cmvy;
			cmy += cmdy >> 4;
			cmdy &= 15;
			if (cmx < 24)
			{
				cmx = 24;
			}
			if (cmx > cmxLim)
			{
				cmx = cmxLim;
			}
			if (cmy < 0)
			{
				cmy = 0;
			}
			if (cmy > cmyLim)
			{
				cmy = cmyLim;
			}
		}
		gssx = cmx / TileMap.size - 1;
		if (gssx < 0)
		{
			gssx = 0;
		}
		gssy = cmy / TileMap.size;
		gssxe = gssx + gssw;
		gssye = gssy + gssh;
		if (gssy < 0)
		{
			gssy = 0;
		}
		if (gssye > TileMap.tmh - 1)
		{
			gssye = TileMap.tmh - 1;
		}
		TileMap.gssx = (Char.getMyChar().cx - 2 * gW) / TileMap.size;
		if (TileMap.gssx < 0)
		{
			TileMap.gssx = 0;
		}
		TileMap.gssxe = TileMap.gssx + TileMap.countx;
		if (TileMap.gssxe > TileMap.tmw)
		{
			TileMap.gssxe = TileMap.tmw;
			TileMap.gssx = TileMap.gssxe - TileMap.countx;
		}
		TileMap.gssy = (Char.getMyChar().cy - 2 * gH) / TileMap.size;
		if (TileMap.gssy < 0)
		{
			TileMap.gssy = 0;
		}
		TileMap.gssye = TileMap.gssy + TileMap.county;
		if (TileMap.gssye > TileMap.tmh)
		{
			TileMap.gssye = TileMap.tmh;
			TileMap.gssy = TileMap.gssye - TileMap.county;
		}
		scrMain.updatecm();
		scrInfo.updatecm();
	}

	public bool testAct()
	{
		for (sbyte b = 2; b < 9; b = (sbyte)(b + 2))
		{
			if (GameCanvas.keyHold[b])
			{
				return false;
			}
		}
		return true;
	}

	public bool isAttack()
	{
		if (InfoDlg.isLock || Char.getMyChar().isLockAttack || Char.isLockKey || Char.getMyChar().isBlinking)
		{
			return false;
		}
		if (Char.getMyChar().mobFocus != null && ((Char.getMyChar().mobFocus.templateId == 97 && Char.getMyChar().cTypePk == Char.PK_PHE1) || (Char.getMyChar().mobFocus.templateId == 98 && Char.getMyChar().cTypePk == Char.PK_PHE1) || (Char.getMyChar().mobFocus.templateId == 96 && Char.getMyChar().cTypePk == Char.PK_PHE2) || (Char.getMyChar().mobFocus.templateId == 99 && Char.getMyChar().cTypePk == Char.PK_PHE2) || (Char.getMyChar().mobFocus.templateId == 200 && Char.getMyChar().cTypePk == Char.PK_PHE1) || (Char.getMyChar().mobFocus.templateId == 199 && Char.getMyChar().cTypePk == Char.PK_PHE2) || (Char.getMyChar().mobFocus.templateId == 198 && Char.getMyChar().cTypePk == Char.PK_PHE3)))
		{
			return false;
		}
		if (Char.getMyChar().myskill != null && Char.getMyChar().myskill.template.type == 2 && Char.getMyChar().npcFocus == null)
		{
			if (!checkSkillValid())
			{
				return false;
			}
			return true;
		}
		if (Char.getMyChar().skillPaint != null || (Char.getMyChar().charFocus != null && Char.getMyChar().charFocus.isNhanbanz()) || (Char.getMyChar().mobFocus == null && Char.getMyChar().npcFocus == null && Char.getMyChar().charFocus == null && Char.getMyChar().itemFocus == null))
		{
			return false;
		}
		if (Char.getMyChar().mobFocus != null)
		{
			if (Char.getMyChar().myskill == null)
			{
				return false;
			}
			if (Char.getMyChar().arrItemBody[1] == null)
			{
				InfoMe.addInfo(mResources.WEAPON_FAIL);
				return false;
			}
			if (Char.getMyChar().mobFocus.status == 1 || Char.getMyChar().mobFocus.status == 0 || Char.getMyChar().myskill.template.type == 4)
			{
				return false;
			}
			if (!checkSkillValid())
			{
				return false;
			}
			if (Char.getMyChar().cx < Char.getMyChar().mobFocus.x)
			{
				Char.getMyChar().cdir = 1;
			}
			else
			{
				Char.getMyChar().cdir = -1;
			}
			int num = Math.abs(Char.getMyChar().cx - Char.getMyChar().mobFocus.x);
			int num2 = Math.abs(Char.getMyChar().cy - Char.getMyChar().mobFocus.y);
			Char.getMyChar().cvx = 0;
			if (Char.getMyChar().isUseLongRangeWeapon())
			{
				if (num <= Char.getMyChar().myskill.dx && num2 <= Char.getMyChar().myskill.dy)
				{
					GameCanvas.clearKeyHold();
					GameCanvas.clearKeyPressed();
					return true;
				}
				Char.getMyChar().currentMovePoint = new MovePoint(Char.getMyChar().mobFocus.x, Char.getMyChar().cy);
				GameCanvas.clearKeyHold();
				GameCanvas.clearKeyPressed();
				return false;
			}
			if ((Char.getMyChar().myskill.template.id == 24 || Char.getMyChar().myskill.template.id == 40 || Char.getMyChar().myskill.template.id == 42) && num <= Char.getMyChar().myskill.dx && num2 <= Char.getMyChar().myskill.dy)
			{
				GameCanvas.clearKeyHold();
				GameCanvas.clearKeyPressed();
				Char.getMyChar().cvx = 0;
				return true;
			}
			if (num <= Char.getMyChar().myskill.dx && num2 <= Char.getMyChar().myskill.dy && Char.getMyChar().cy >= Char.getMyChar().mobFocus.y - 10)
			{
				GameCanvas.clearKeyHold();
				GameCanvas.clearKeyPressed();
				Char.getMyChar().cvx = 0;
				return true;
			}
			Char.getMyChar().currentMovePoint = new MovePoint(Char.getMyChar().mobFocus.x + Char.getMyChar().mobFocus.dir * 12, Char.getMyChar().cy);
			GameCanvas.clearKeyHold();
			GameCanvas.clearKeyPressed();
			return false;
		}
		if (Char.getMyChar().npcFocus != null)
		{
			if (Char.getMyChar().cx < Char.getMyChar().npcFocus.cx)
			{
				Char.getMyChar().cdir = 1;
			}
			else
			{
				Char.getMyChar().cdir = -1;
			}
			if (Char.getMyChar().cx < Char.getMyChar().npcFocus.cx)
			{
				Char.getMyChar().npcFocus.cdir = -1;
			}
			else
			{
				Char.getMyChar().npcFocus.cdir = 1;
			}
			int num3 = Math.abs(Char.getMyChar().cx - Char.getMyChar().npcFocus.cx);
			int num4 = Math.abs(Char.getMyChar().cy - Char.getMyChar().npcFocus.cy);
			if (num3 < 60 && num4 < 40)
			{
				GameCanvas.clearKeyHold();
				GameCanvas.clearKeyPressed();
				if (Char.getMyChar().npcFocus.template.npcTemplateId == 13)
				{
					InfoDlg.showWait();
					Service.gI().openUIZone();
				}
				else
				{
					Service.gI().openMenu(Char.getMyChar().npcFocus.template.npcTemplateId);
					InfoDlg.showWait();
				}
			}
			else
			{
				Char.getMyChar().currentMovePoint = new MovePoint(Char.getMyChar().npcFocus.cx, Char.getMyChar().cy);
				GameCanvas.clearKeyHold();
				GameCanvas.clearKeyPressed();
			}
			return false;
		}
		if (Char.getMyChar().charFocus != null)
		{
			if (Char.getMyChar().cx < Char.getMyChar().charFocus.cx)
			{
				Char.getMyChar().cdir = 1;
			}
			else
			{
				Char.getMyChar().cdir = -1;
			}
			int num5 = Math.abs(Char.getMyChar().cx - Char.getMyChar().charFocus.cx);
			int num6 = Math.abs(Char.getMyChar().cy - Char.getMyChar().charFocus.cy);
			if (Char.getMyChar().isMeCanAttackOtherPlayer(Char.getMyChar().charFocus))
			{
				if (Char.getMyChar().myskill == null)
				{
					return false;
				}
				if (Char.getMyChar().arrItemBody[1] == null)
				{
					InfoMe.addInfo(mResources.WEAPON_FAIL);
					return false;
				}
				if (!checkSkillValid())
				{
					return false;
				}
				if (Char.getMyChar().cx < Char.getMyChar().charFocus.cx)
				{
					Char.getMyChar().cdir = 1;
				}
				else
				{
					Char.getMyChar().cdir = -1;
				}
				Char.getMyChar().cvx = 0;
				if (Char.getMyChar().isUseLongRangeWeapon())
				{
					if (num5 <= Char.getMyChar().myskill.dx && num6 <= Char.getMyChar().myskill.dy)
					{
						GameCanvas.clearKeyHold();
						GameCanvas.clearKeyPressed();
						return true;
					}
					Char.getMyChar().currentMovePoint = new MovePoint(Char.getMyChar().charFocus.cx, Char.getMyChar().cy);
					GameCanvas.clearKeyHold();
					GameCanvas.clearKeyPressed();
					return false;
				}
				if ((Char.getMyChar().myskill.template.id == 24 || Char.getMyChar().myskill.template.id == 40 || Char.getMyChar().myskill.template.id == 42) && num5 <= Char.getMyChar().myskill.dx && num6 <= Char.getMyChar().myskill.dy)
				{
					GameCanvas.clearKeyHold();
					GameCanvas.clearKeyPressed();
					Char.getMyChar().cvx = 0;
					return true;
				}
				if (num5 <= Char.getMyChar().myskill.dx && num6 <= Char.getMyChar().myskill.dy && Char.getMyChar().cy >= Char.getMyChar().charFocus.cy)
				{
					GameCanvas.clearKeyHold();
					GameCanvas.clearKeyPressed();
					Char.getMyChar().cvx = 0;
					return true;
				}
				Char.getMyChar().currentMovePoint = new MovePoint(Char.getMyChar().charFocus.cx + Char.getMyChar().charFocus.cdir * 12, Char.getMyChar().cy);
				GameCanvas.clearKeyHold();
				GameCanvas.clearKeyPressed();
				return false;
			}
			if (num5 < 60 && num6 < 40 && Char.getMyChar().charFocus.charID >= 0)
			{
				GameCanvas.clearKeyHold();
				if (Char.getMyChar().charFocus.statusMe != 14 && Char.getMyChar().charFocus.statusMe != 5 && TileMap.typeMap == TileMap.MAP_DAUTRUONG)
				{
					return false;
				}
				if (!isShortcut)
				{
					MyVector myVector = new MyVector();
					myVector.addElement(new Command(mResources.CHAR_ORDER[6], 110397));
					myVector.addElement(new Command(mResources.CHAR_ORDER[4], 110391));
					if ((Char.getMyChar().ctypeClan == 4 || Char.getMyChar().ctypeClan == 3 || Char.getMyChar().ctypeClan == 2) && Char.getMyChar().charFocus.cClanName.Equals(string.Empty))
					{
						myVector.addElement(new Command(mResources.CHAR_ORDER[8], 110398));
					}
					if ((Char.getMyChar().charFocus.ctypeClan == 4 || Char.getMyChar().charFocus.ctypeClan == 3 || Char.getMyChar().charFocus.ctypeClan == 2) && Char.getMyChar().cClanName.Equals(string.Empty))
					{
						myVector.addElement(new Command(mResources.CHAR_ORDER[9], 110399));
					}
					myVector.addElement(new Command(mResources.CHAR_ORDER[7], 12004, Char.getMyChar().charFocus.cName));
					if (Char.getMyChar().nClass.classId == 6)
					{
						myVector.addElement(new Command(mResources.CHAR_ORDER[11] + ": " + (Char.isAResuscitate ? mResources.OFF : mResources.ON), 1103991));
					}
					if (Char.getMyChar().charFocus.statusMe != 14 && Char.getMyChar().charFocus.statusMe != 5)
					{
						myVector.addElement(new Command(mResources.CHAR_ORDER[0], 110392));
						myVector.addElement(new Command(mResources.CHAR_ORDER[1], 110393));
						myVector.addElement(new Command(mResources.CHAR_ORDER[2], 110394));
					}
					else if (Char.getMyChar().myskill.template.type == 4)
					{
						myVector.addElement(new Command(mResources.CHAR_ORDER[5], 110395));
					}
					myVector.addElement(new Command(mResources.CHAR_ORDER[3], 110396));
					GameCanvas.menu.startAt(myVector, 3);
				}
				isShortcut = false;
			}
			else
			{
				Char.getMyChar().currentMovePoint = new MovePoint(Char.getMyChar().charFocus.cx, Char.getMyChar().cy);
				GameCanvas.clearKeyHold();
				GameCanvas.clearKeyPressed();
			}
			return false;
		}
		if (Char.getMyChar().itemFocus != null)
		{
			if (Char.getMyChar().statusMe != 1)
			{
				return false;
			}
			if (Char.getMyChar().cx < Char.getMyChar().itemFocus.x)
			{
				Char.getMyChar().cdir = 1;
			}
			else
			{
				Char.getMyChar().cdir = -1;
			}
			int num7 = Math.abs(Char.getMyChar().cx - Char.getMyChar().itemFocus.x);
			int num8 = Math.abs(Char.getMyChar().cy - Char.getMyChar().itemFocus.y);
			if ((num7 <= 35 && num8 < 35) || (auto != 0 && num7 <= 48 && num8 <= 48))
			{
				GameCanvas.clearKeyHold();
				GameCanvas.clearKeyPressed();
				Service.gI().pickItem(Char.getMyChar().itemFocus.itemMapID);
			}
			else
			{
				Char.getMyChar().currentMovePoint = new MovePoint(Char.getMyChar().itemFocus.x, Char.getMyChar().cy);
				GameCanvas.clearKeyHold();
				GameCanvas.clearKeyPressed();
			}
			return false;
		}
		return true;
	}

	public bool checkExistFriend(string strName)
	{
		for (int i = 0; i < vFriend.size(); i++)
		{
			Friend friend = (Friend)vFriend.elementAt(i);
			if (friend.friendName.Equals(strName))
			{
				return false;
			}
		}
		return true;
	}

	private bool checkSkillValid()
	{
		if (Char.getMyChar().myskill != null && Char.getMyChar().cMP < Char.getMyChar().myskill.manaUse)
		{
			InfoMe.addInfo(mResources.NOT_ENOUGH_MP);
			return false;
		}
		if (Char.getMyChar().myskill == null || (Char.getMyChar().myskill.template.maxPoint > 0 && Char.getMyChar().myskill.point == 0))
		{
			GameCanvas.startOKDlg(mResources.SKILL_FAIL);
			return false;
		}
		if (Char.getMyChar().arrItemBody[1] == null)
		{
			GameCanvas.startOKDlg(mResources.WEAPON_EMPTY);
			return false;
		}
		return true;
	}

	private bool checkSkillValid2()
	{
		if (Char.getMyChar().myskill != null && Char.getMyChar().cMP < Char.getMyChar().myskill.manaUse)
		{
			return false;
		}
		if (Char.getMyChar().myskill == null || (Char.getMyChar().myskill.template.maxPoint > 0 && Char.getMyChar().myskill.point == 0))
		{
			return false;
		}
		if (Char.getMyChar().arrItemBody[1] == null)
		{
			return false;
		}
		return true;
	}

	public void resetButton()
	{
		if (Char.getMyChar().arrItemBag != null)
		{
			if ((isPaintUpPearl || isPaintLuyenThach) && arrItemUpPeal != null)
			{
				for (int i = 0; i < arrItemUpPeal.Length; i++)
				{
					if (arrItemUpPeal[i] != null)
					{
						Char.getMyChar().arrItemBag[arrItemUpPeal[i].indexUI] = arrItemUpPeal[i];
						arrItemUpPeal[i] = null;
					}
				}
			}
			if (isPaintUpGrade)
			{
				if (itemUpGrade != null)
				{
					Char.getMyChar().arrItemBag[itemUpGrade.indexUI] = itemUpGrade;
					itemUpGrade = null;
				}
				if (arrItemUpGrade != null)
				{
					for (int j = 0; j < arrItemUpGrade.Length; j++)
					{
						if (arrItemUpGrade[j] != null)
						{
							Char.getMyChar().arrItemBag[arrItemUpGrade[j].indexUI] = arrItemUpGrade[j];
							arrItemUpGrade[j] = null;
						}
					}
				}
			}
			if (isPaintKhamNgoc)
			{
				if (itemUpGrade != null)
				{
					Char.getMyChar().arrItemBag[itemUpGrade.indexUI] = itemUpGrade;
					itemUpGrade = null;
				}
				if (itemSplit != null)
				{
					Char.getMyChar().arrItemBag[itemSplit.indexUI] = itemSplit;
					itemSplit = null;
				}
				if (arrItemUpGrade != null)
				{
					for (int k = 0; k < arrItemUpGrade.Length; k++)
					{
						if (arrItemUpGrade[k] != null)
						{
							Char.getMyChar().arrItemBag[arrItemUpGrade[k].indexUI] = arrItemUpGrade[k];
							arrItemUpGrade[k] = null;
						}
					}
				}
			}
			if (isPaintGiaoDo && arrItemUpGrade != null)
			{
				for (int l = 0; l < arrItemUpGrade.Length; l++)
				{
					if (arrItemUpGrade[l] != null)
					{
						Char.getMyChar().arrItemBag[arrItemUpGrade[l].indexUI] = arrItemUpGrade[l];
						arrItemUpGrade[l] = null;
					}
				}
			}
			if (isPaintAuctionSale && itemSell != null)
			{
				Char.getMyChar().arrItemBag[itemSell.indexUI] = itemSell;
				itemSell = null;
			}
			if (isPaintConvert && arrItemConvert != null)
			{
				for (int m = 0; m < arrItemConvert.Length; m++)
				{
					if (arrItemConvert[m] != null)
					{
						Char.getMyChar().arrItemBag[arrItemConvert[m].indexUI] = arrItemConvert[m];
						arrItemConvert[m] = null;
					}
				}
			}
			if (isPaintSplit || isPaintDichChuyen || isPaintTinhluyen || isPaintLuyenNgoc)
			{
				if (itemSplit != null)
				{
					Char.getMyChar().arrItemBag[itemSplit.indexUI] = itemSplit;
					itemSplit = null;
				}
				if (arrItemSplit != null)
				{
					for (int n = 0; n < arrItemSplit.Length; n++)
					{
						if (arrItemSplit[n] != null)
						{
							if (isPaintTinhluyen || isPaintDichChuyen || isPaintLuyenNgoc)
							{
								Char.getMyChar().arrItemBag[arrItemSplit[n].indexUI] = arrItemSplit[n];
							}
							arrItemSplit[n] = null;
						}
					}
				}
			}
			if (isPaintGiaoDo && arrItemSplit != null)
			{
				for (int num = 0; num < arrItemSplit.Length; num++)
				{
					if (arrItemSplit[num] != null)
					{
						Char.getMyChar().arrItemBag[arrItemSplit[num].indexUI] = arrItemSplit[num];
						arrItemSplit[num] = null;
					}
				}
			}
			if (isPaintTrade)
			{
				InfoDlg.hide();
				if (coinTrade > 0)
				{
					Char.getMyChar().xu += coinTrade;
				}
				if (arrItemTradeMe != null)
				{
					for (int num2 = 0; num2 < arrItemTradeMe.Length; num2++)
					{
						if (arrItemTradeMe[num2] != null)
						{
							Char.getMyChar().arrItemBag[arrItemTradeMe[num2].indexUI] = arrItemTradeMe[num2];
							arrItemTradeMe[num2] = null;
						}
					}
				}
				if (arrItemTradeOrder != null)
				{
					for (int num3 = 0; num3 < arrItemTradeOrder.Length; num3++)
					{
						arrItemTradeOrder[num3] = null;
					}
				}
			}
			if ((isPaintGotNgoc || isPaintThaoNgoc) && itemSplit != null)
			{
				Char.getMyChar().arrItemBag[itemSplit.indexUI] = itemSplit;
				itemSplit = null;
			}
		}
		if (isPaintTrade)
		{
			Service.gI().cancelTrade();
		}
		GameCanvas.menu.showMenu = false;
		ChatTextField.gI().close();
		ChatTextField.gI().center = null;
		if (!GameCanvas.isTouch)
		{
			isPaintSelectSkill = false;
		}
		isMessageMenu = false;
		isPaintUpGradeGold = false;
		isLockKey = false;
		isPaintZone = false;
		isPaintInfoMe = false;
		isPaintItemInfo = false;
		isPaintTask = false;
		isPaintTeam = false;
		isPaintAuto = false;
		isPaintMessage = false;
		isPaintClan = false;
		isPaintLuckySpin = false;
		isRequestMember = false;
		isPaintCharInMap = false;
		isPaintFindTeam = false;
		isPaintFriend = false;
		isPaintAuctionBuy = false;
		isPaintList = false;
		isPaintRankedList = false;
		isPaintEnemies = false;
		isPaintAlert = false;
		isPaintLucky_Draw = false;
		typeTrade = 0;
		isPaintStore = false;
		isPaintEliteShop = false;
		isPaintNonNam = false;
		isPaintNonNu = false;
		isPaintAoNam = false;
		isPaintAoNu = false;
		isPaintGangTayNam = false;
		isPaintGangTayNu = false;
		isPaintQuanNam = false;
		isPaintQuanNu = false;
		isPaintGiayNam = false;
		isPaintGiayNu = false;
		isPaintLien = false;
		isPaintNhan = false;
		isPaintNgocBoi = false;
		isPaintPhu = false;
		isPaintWeapon = false;
		isPaintStack = false;
		isPaintStackLock = false;
		isPaintGrocery = false;
		isPaintGroceryLock = false;
		isPaintUpGrade = false;
		isPaintAuctionSale = false;
		isPaintConvert = false;
		isPaintSplit = (isPaintTinhluyen = (isPaintDichChuyen = false));
		isPaintTrade = false;
		isPaintUpPearl = (isPaintLuyenThach = false);
		isPaintBox = false;
		isPaintKhamNgoc = false;
		isPaintLuyenNgoc = false;
		isPaintGiaoDo = false;
		isPaintGotNgoc = false;
		isPaintThaoNgoc = false;
		indexMenu = 0;
		indexSelect = 0;
		indexItemUse = -1;
		indexRow = -1;
		indexRowMax = 0;
		indexTitle = 0;
		typeTrade = (typeTradeOrder = 0);
		left = menu;
		right = cmdFocus;
		xMounts = (yMounts = null);
		center = null;
		if (Char.getMyChar().cHP <= 0 || Char.getMyChar().statusMe == 14 || Char.getMyChar().statusMe == 5)
		{
			if (GameCanvas.isTouchControlSmallScreen)
			{
				cmdDead.caption = string.Empty;
			}
			center = cmdDead;
		}
		scrMain.clear();
	}

	public override void keyPress(int keyCode)
	{
		if (tfText != null && tfText.isFocus)
		{
			tfText.keyPressed(keyCode);
		}
		base.keyPress(keyCode);
	}

	private void doFocusbyTouch()
	{
		if (isPaintPopup() || isPaintUI() || isOpenUI() || !GameCanvas.isPointerClick)
		{
			return;
		}
		for (int i = 0; i < vMob.size(); i++)
		{
			Mob mob = (Mob)vMob.elementAt(i);
			if (mob.isPaint() && GameCanvas.isPointerInGame(mob.x - mob.w / 2, mob.y - mob.h, mob.w, mob.h) && GameCanvas.isPointerJustRelease)
			{
				Char.getMyChar().mobFocus = mob;
				Char.getMyChar().deFocusNPC();
				Char.getMyChar().charFocus = null;
				Char.getMyChar().itemFocus = null;
				Char.isManualFocus = true;
				return;
			}
		}
		for (int j = 0; j < vNpc.size(); j++)
		{
			Npc npc = (Npc)vNpc.elementAt(j);
			if (npc.isPaint() && GameCanvas.isPointerInGame(npc.cx - npc.cw / 2, npc.cy - npc.ch, npc.cw, npc.ch) && GameCanvas.isPointerJustRelease)
			{
				Char.getMyChar().mobFocus = null;
				Char.getMyChar().deFocusNPC();
				Char.getMyChar().npcFocus = npc;
				Char.getMyChar().charFocus = null;
				Char.getMyChar().itemFocus = null;
				Char.isManualFocus = true;
				return;
			}
		}
		for (int k = 0; k < vCharInMap.size(); k++)
		{
			Char @char = (Char)vCharInMap.elementAt(k);
			if (@char.isPaint() && !@char.isNhanbanz())
			{
				if (TileMap.mapID == 111 && Char.getMyChar().cTypePk == 0)
				{
					return;
				}
				if (GameCanvas.isPointerInGame(@char.cx - @char.cw / 2, @char.cy - @char.ch, @char.cw, @char.ch) && GameCanvas.isPointerJustRelease)
				{
					Char.getMyChar().mobFocus = null;
					Char.getMyChar().deFocusNPC();
					Char.getMyChar().charFocus = @char;
					Char.getMyChar().itemFocus = null;
					Char.isManualFocus = true;
					return;
				}
			}
		}
		for (int l = 0; l < vItemMap.size(); l++)
		{
			ItemMap itemMap = (ItemMap)vItemMap.elementAt(l);
			if (GameCanvas.isPointerInGame(itemMap.x - itemMap.sizeItem / 2, itemMap.y - itemMap.sizeItem, itemMap.sizeItem, itemMap.sizeItem) && GameCanvas.isPointerJustRelease)
			{
				Char.getMyChar().mobFocus = null;
				Char.getMyChar().deFocusNPC();
				Char.getMyChar().charFocus = null;
				Char.getMyChar().itemFocus = itemMap;
				Char.isManualFocus = true;
				break;
			}
		}
	}

	private void showCharList()
	{
		if (GameCanvas.isTouch && !Main.isPC)
		{
			if (GameCanvas.isPointerDown && !GameCanvas.isPointerJustRelease && GameCanvas.isPointerHoldIn(xTG, yTG, 34, 34) && !isPaintCharInMap && GameCanvas.isPointerClick && GameCanvas.isHoldPress())
			{
				doShowCharInMap();
			}
		}
		else if (Main.isPC && GameCanvas.keyHold[13] && !isPaintCharInMap && GameCanvas.isHoldPress())
		{
			doShowCharInMap();
		}
	}

	public override void updateKey()
	{
		if (InfoDlg.isLock)
		{
			return;
		}
		if (GameCanvas.isTouch && !ChatTextField.gI().isShow && !GameCanvas.menu.showMenu)
		{
			doViewMessagebyTouch();
			updateKeyTouchControl();
		}
		checkAuto();
		showCharList();
		GameCanvas.debug("F2", 0);
		if (ChatPopup.currentMultilineChatPopup != null)
		{
			Command cmdNextLine = ChatPopup.currentMultilineChatPopup.cmdNextLine;
			if ((GameCanvas.keyPressedz[5] || mScreen.getCmdPointerLast(cmdNextLine)) && cmdNextLine != null)
			{
				GameCanvas.isPointerJustRelease = false;
				GameCanvas.keyPressedz[5] = false;
				mScreen.keyTouch = -1;
				cmdNextLine?.performAction();
			}
		}
		else if (!ChatTextField.gI().isShow)
		{
			if ((GameCanvas.keyPressedz[12] || mScreen.getCmdPointerLast(GameCanvas.currentScreen.left)) && left != null)
			{
				GameCanvas.isPointerJustRelease = false;
				GameCanvas.isPointerClick = false;
				GameCanvas.keyPressedz[12] = false;
				mScreen.keyTouch = -1;
				if (left != null)
				{
					left.performAction();
				}
				Sound.play(Sound.MBClick, 0.5f);
			}
			if ((GameCanvas.keyPressedz[13] || mScreen.getCmdPointerLast(GameCanvas.currentScreen.right)) && right != null)
			{
				GameCanvas.isPointerJustRelease = false;
				GameCanvas.isPointerClick = false;
				GameCanvas.keyPressedz[13] = false;
				mScreen.keyTouch = -1;
				if (right != null)
				{
					right.performAction();
				}
				Sound.play(Sound.MBClick, 0.5f);
			}
			if ((GameCanvas.keyPressedz[5] || mScreen.getCmdPointerLast(GameCanvas.currentScreen.center)) && center != null)
			{
				GameCanvas.isPointerJustRelease = false;
				GameCanvas.keyPressedz[5] = false;
				mScreen.keyTouch = -1;
				if (center != null)
				{
					center.performAction();
				}
			}
		}
		else if (!Main.isPC)
		{
			if (ChatTextField.gI().left != null && (GameCanvas.keyPressedz[12] || mScreen.getCmdPointerLast(ChatTextField.gI().left)) && ChatTextField.gI().left != null)
			{
				ChatTextField.gI().left.performAction();
			}
			if (ChatTextField.gI().right != null && (GameCanvas.keyPressedz[13] || mScreen.getCmdPointerLast(ChatTextField.gI().right)) && ChatTextField.gI().right != null)
			{
				ChatTextField.gI().right.performAction();
			}
			if (ChatTextField.gI().center != null && (GameCanvas.keyPressedz[5] || mScreen.getCmdPointerLast(ChatTextField.gI().center)) && ChatTextField.gI().center != null)
			{
				ChatTextField.gI().center.performAction();
			}
		}
		else
		{
			if (ChatTextField.gI().right != null && (GameCanvas.keyPressedz[13] || mScreen.getCmdPointerLast(ChatTextField.gI().right)))
			{
				if (ChatTextField.gI().right != null)
				{
					ChatTextField.gI().right.performAction();
				}
				Sound.play(Sound.MBClick, 0.5f);
				GameCanvas.clearKeyHold();
				GameCanvas.clearKeyPressed();
			}
			if (ChatTextField.gI().right != null && GameCanvas.keyPressedz[5])
			{
				Out.println("chat>>>>>>>>>>>> " + auto);
				ChatTextField.gI().cmdFireChat.performAction();
				GameCanvas.keyPressedz[5] = false;
				Sound.play(Sound.MBClick, 0.5f);
				GameCanvas.clearKeyHold();
				GameCanvas.clearKeyPressed();
				auto = saveAuto;
				return;
			}
		}
		updateKeySelectZone();
		GameCanvas.debug("F4", 0);
		updateSelectList();
		updateKeyBuyItemUI();
		GameCanvas.debug("F5", 0);
		updateKeyUIInforMe();
		updateKeyClanInfo();
		updateKeyTask();
		GameCanvas.debug("F6", 0);
		updateKeyAlert();
		updateKeyMessage();
		updateSelectList();
		GameCanvas.debug("F7", 0);
		if (Char.getMyChar().currentMovePoint != null)
		{
			for (int i = 0; i < GameCanvas.keyPressedz.Length; i++)
			{
				if (GameCanvas.keyPressedz[i])
				{
					Char.getMyChar().currentMovePoint = null;
					break;
				}
			}
		}
		GameCanvas.debug("F8", 0);
		if (ChatTextField.gI().isShow && GameCanvas.keyAsciiPress != 0)
		{
			ChatTextField.gI().keyPressed(GameCanvas.keyAsciiPress);
			GameCanvas.keyAsciiPress = 0;
		}
		if (isLockKey)
		{
			GameCanvas.clearKeyHold();
			GameCanvas.clearKeyPressed();
			return;
		}
		GameCanvas.debug("F9", 0);
		if (GameCanvas.menu.showMenu || isOpenUI() || Char.isLockKey)
		{
			return;
		}
		if (GameCanvas.keyPressedz[(!Main.isPC) ? 10 : ((!GameCanvas.isChangMapKey) ? 6 : 30)])
		{
			GameCanvas.keyPressedz[(!Main.isPC) ? 10 : ((!GameCanvas.isChangMapKey) ? 6 : 30)] = false;
			Sound.play(Sound.MBClick, 0.5f);
			doUseHP();
		}
		if (GameCanvas.keyPressedz[(!Main.isPC) ? 11 : ((!GameCanvas.isChangMapKey) ? 7 : 31)])
		{
			GameCanvas.keyPressedz[(!Main.isPC) ? 11 : ((!GameCanvas.isChangMapKey) ? 7 : 31)] = false;
			Sound.play(Sound.MBClick, 0.5f);
			doUseMP();
		}
		if (Char.getMyChar().skillPaint != null)
		{
			return;
		}
		if (Main.isPC && ChatTextField.gI().isShow)
		{
			GameCanvas.clearKeyPressed();
			return;
		}
		if (!Char.getMyChar().isCaptcha)
		{
			if (Char.getMyChar().statusMe == 1)
			{
				GameCanvas.debug("F10", 0);
				if (GameCanvas.keyPressedz[5] || GameCanvas.keyPressedz[20])
				{
					GameCanvas.keyPressedz[5] = false;
					GameCanvas.keyPressedz[20] = false;
					doFire(isFireByShortCut: false);
				}
				else if (GameCanvas.keyHold[Key.NUM2] || GameCanvas.keyHold[24])
				{
					if (!Char.getMyChar().isLockMove && !Char.getMyChar().isBlinking)
					{
						setCharJump(0);
					}
				}
				else if (GameCanvas.keyHold[Key.NUM1])
				{
					Char.getMyChar().cdir = -1;
					if (!Char.getMyChar().isLockMove && !Char.getMyChar().isBlinking)
					{
						setCharJump(-4);
					}
				}
				else if (GameCanvas.keyHold[Key.NUM3])
				{
					Char.getMyChar().cdir = 1;
					if (!Char.getMyChar().isLockMove && !Char.getMyChar().isBlinking)
					{
						setCharJump(4);
					}
				}
				else if (GameCanvas.keyHold[Key.NUM4] || GameCanvas.keyHold[23])
				{
					Char.getMyChar().isAttack = false;
					if (Char.getMyChar().cdir == 1)
					{
						Char.getMyChar().cdir = -1;
					}
					else if (!Char.getMyChar().isLockMove && !Char.getMyChar().isBlinking)
					{
						Char.getMyChar().statusMe = 2;
						Char.getMyChar().cvx = -Char.getMyChar().getSpeed();
					}
				}
				else if (GameCanvas.keyHold[Key.NUM6] || GameCanvas.keyHold[22])
				{
					Char.getMyChar().isAttack = false;
					if (Char.getMyChar().cdir == -1)
					{
						Char.getMyChar().cdir = 1;
					}
					else if (!Char.getMyChar().isLockMove && !Char.getMyChar().isBlinking)
					{
						Char.getMyChar().statusMe = 2;
						Char.getMyChar().cvx = Char.getMyChar().getSpeed();
					}
				}
			}
			else if (Char.getMyChar().statusMe == 2)
			{
				GameCanvas.debug("F11", 0);
				if (GameCanvas.keyPressedz[5] || GameCanvas.keyPressedz[20])
				{
					GameCanvas.keyPressedz[5] = false;
					GameCanvas.keyPressedz[20] = false;
					doFire(isFireByShortCut: false);
				}
				else if (GameCanvas.keyHold[Key.NUM2] || GameCanvas.keyHold[24])
				{
					Char.getMyChar().cvy = ((!Char.getMyChar().canJumpHigh) ? (-8) : (-10));
					Char.getMyChar().statusMe = 3;
					Char.getMyChar().cp1 = 0;
				}
				else if (GameCanvas.keyHold[Key.NUM1])
				{
					Char.getMyChar().cdir = -1;
					Char.getMyChar().cvy = ((!Char.getMyChar().canJumpHigh) ? (-8) : (-10));
					Char.getMyChar().cvx = -4;
					Char.getMyChar().statusMe = 3;
					Char.getMyChar().cp1 = 0;
				}
				else if (GameCanvas.keyHold[Key.NUM3])
				{
					Char.getMyChar().cdir = 1;
					Char.getMyChar().cvy = ((!Char.getMyChar().canJumpHigh) ? (-8) : (-10));
					Char.getMyChar().cvx = 4;
					Char.getMyChar().statusMe = 3;
					Char.getMyChar().cp1 = 0;
				}
				else if (GameCanvas.keyHold[Key.NUM4] || GameCanvas.keyHold[23])
				{
					if (Char.getMyChar().cdir == 1)
					{
						Char.getMyChar().cdir = -1;
					}
					else
					{
						Char.getMyChar().cvx = -Char.getMyChar().getSpeed() + Char.getMyChar().cBonusSpeed;
					}
				}
				else if (GameCanvas.keyHold[Key.NUM6] || GameCanvas.keyHold[22])
				{
					if (Char.getMyChar().cdir == -1)
					{
						Char.getMyChar().cdir = 1;
					}
					else
					{
						Char.getMyChar().cvx = Char.getMyChar().getSpeed() + Char.getMyChar().cBonusSpeed;
					}
				}
			}
			else if (Char.getMyChar().statusMe == 3)
			{
				GameCanvas.debug("F12", 0);
				if (GameCanvas.keyPressedz[5] || GameCanvas.keyPressedz[20])
				{
					GameCanvas.keyPressedz[5] = false;
					GameCanvas.keyPressedz[20] = false;
					doFire(isFireByShortCut: false);
				}
				if (GameCanvas.keyHold[Key.NUM4] || GameCanvas.keyHold[Key.NUM1] || GameCanvas.keyHold[23])
				{
					if (Char.getMyChar().cdir == 1)
					{
						Char.getMyChar().cdir = -1;
					}
					else
					{
						Char.getMyChar().cvx = -Char.getMyChar().getSpeed();
					}
				}
				else if (GameCanvas.keyHold[Key.NUM6] || GameCanvas.keyHold[Key.NUM3] || GameCanvas.keyHold[22])
				{
					if (Char.getMyChar().cdir == -1)
					{
						Char.getMyChar().cdir = 1;
					}
					else
					{
						Char.getMyChar().cvx = Char.getMyChar().getSpeed();
					}
				}
				if ((GameCanvas.keyHold[Key.NUM2] || GameCanvas.keyHold[Key.NUM1] || GameCanvas.keyHold[Key.NUM3] || GameCanvas.keyHold[24]) && Char.getMyChar().canJumpHigh && Char.getMyChar().cp1 == 0 && Char.getMyChar().cvy > -4)
				{
					Char.getMyChar().cp1++;
					Char.getMyChar().cvy = -7;
				}
			}
			else if (Char.getMyChar().statusMe == 4)
			{
				GameCanvas.debug("F13", 0);
				if (GameCanvas.keyPressedz[5] || GameCanvas.keyPressedz[20])
				{
					GameCanvas.keyPressedz[5] = false;
					GameCanvas.keyPressedz[20] = false;
					doFire(isFireByShortCut: false);
				}
				if (GameCanvas.keyPressedz[2] || GameCanvas.keyHold[24])
				{
					GameCanvas.clearKeyPressed();
				}
				if (GameCanvas.keyHold[Key.NUM4] || GameCanvas.keyHold[23])
				{
					if (Char.getMyChar().cdir == 1)
					{
						Char.getMyChar().cdir = -1;
					}
					else
					{
						Char.getMyChar().cvx = -Char.getMyChar().getSpeed();
					}
				}
				else if (GameCanvas.keyHold[Key.NUM6] || GameCanvas.keyHold[22])
				{
					if (Char.getMyChar().cdir == -1)
					{
						Char.getMyChar().cdir = 1;
					}
					else
					{
						Char.getMyChar().cvx = Char.getMyChar().getSpeed();
					}
				}
			}
			else if (Char.getMyChar().statusMe == 10)
			{
				GameCanvas.debug("F14", 0);
				if (GameCanvas.keyPressedz[5] || GameCanvas.keyPressedz[20])
				{
					GameCanvas.keyPressedz[5] = false;
					GameCanvas.keyPressedz[20] = false;
					doFire(isFireByShortCut: false);
				}
				if (GameCanvas.keyHold[Key.NUM2] || GameCanvas.keyHold[24])
				{
					Char.getMyChar().cvy = -10;
					Char.getMyChar().statusMe = 3;
					Char.getMyChar().cp1 = 0;
				}
				else if (GameCanvas.keyHold[Key.NUM4] || GameCanvas.keyHold[23])
				{
					if (Char.getMyChar().cdir == 1)
					{
						Char.getMyChar().cdir = -1;
					}
					else
					{
						Char.getMyChar().cvx = -5;
					}
				}
				else if (GameCanvas.keyHold[Key.NUM6] || GameCanvas.keyHold[22])
				{
					if (Char.getMyChar().cdir == -1)
					{
						Char.getMyChar().cdir = 1;
					}
					else
					{
						Char.getMyChar().cvx = 5;
					}
				}
			}
			else if (Char.getMyChar().statusMe == 7)
			{
				GameCanvas.debug("F15", 0);
				if (GameCanvas.keyPressedz[5])
				{
					GameCanvas.keyPressedz[5] = false;
				}
				if (GameCanvas.keyHold[Key.NUM4] || GameCanvas.keyHold[23])
				{
					if (Char.getMyChar().cdir == 1)
					{
						Char.getMyChar().cdir = -1;
					}
					else
					{
						Char.getMyChar().cvx = -Char.getMyChar().cspeed + 2;
					}
				}
				else if (GameCanvas.keyHold[Key.NUM6] || GameCanvas.keyHold[22])
				{
					if (Char.getMyChar().cdir == -1)
					{
						Char.getMyChar().cdir = 1;
					}
					else
					{
						Char.getMyChar().cvx = Char.getMyChar().cspeed - 2;
					}
				}
			}
			else if (Char.getMyChar().statusMe == 11)
			{
				GameCanvas.debug("F16", 0);
				if (GameCanvas.keyPressedz[5] || GameCanvas.keyPressedz[20])
				{
					GameCanvas.keyPressedz[5] = false;
					GameCanvas.keyPressedz[20] = false;
					doFire(isFireByShortCut: false);
				}
				if (GameCanvas.keyHold[Key.NUM2] || GameCanvas.keyHold[24])
				{
					Char.getMyChar().cvy = -10;
					Char.getMyChar().statusMe = 3;
					Char.getMyChar().cp1 = 0;
				}
			}
		}
		else
		{
			updateKeyCaptcha();
		}
		GameCanvas.debug("F17", 0);
		if (Main.isPC)
		{
			if (GameCanvas.keyPressedz[(!GameCanvas.isChangMapKey) ? 21 : 2])
			{
				doChangeSkill();
			}
		}
		else if (GameCanvas.keyPressedz[8] && GameCanvas.keyAsciiPress != 56)
		{
			GameCanvas.keyPressedz[8] = false;
			doChangeSkill();
		}
		GameCanvas.debug("F20", 0);
		if (GameCanvas.keyAsciiPress != 0)
		{
			if (!Main.isPC)
			{
				if (TField.isQwerty)
				{
					if (GameCanvas.keyAsciiPress == 113)
					{
						isShortcut = true;
						if (keySkill[0] != null)
						{
							doUseSkill(keySkill[0], isShortcut: true, isSelectSkill: true);
						}
					}
					else if (GameCanvas.keyAsciiPress == 119)
					{
						isShortcut = true;
						if (keySkill[1] != null)
						{
							doUseSkill(keySkill[1], isShortcut: true, isSelectSkill: true);
						}
					}
					else if (GameCanvas.keyAsciiPress == 101)
					{
						isShortcut = true;
						if (keySkill[2] != null)
						{
							doUseSkill(keySkill[2], isShortcut: true, isSelectSkill: true);
						}
					}
					else
					{
						if (!Main.isPC)
						{
							ChatTextField.gI().startChat(GameCanvas.keyAsciiPress, this, mResources.PUBLICCHAT[0]);
						}
						Out.println("day >>>>  " + GameCanvas.keyAsciiPress);
					}
				}
				else if (!GameCanvas.isMoveNumberPad)
				{
					ChatTextField.gI().startChat(GameCanvas.keyAsciiPress, this, mResources.PUBLICCHAT[0]);
				}
				else if (GameCanvas.keyAsciiPress == 55)
				{
					isShortcut = true;
					if (keySkill[0] != null)
					{
						doUseSkill(keySkill[0], isShortcut: true, isSelectSkill: true);
					}
				}
				else if (GameCanvas.keyAsciiPress == 56)
				{
					isShortcut = true;
					if (keySkill[1] != null)
					{
						doUseSkill(keySkill[1], isShortcut: true, isSelectSkill: true);
					}
				}
				else if (GameCanvas.keyAsciiPress == 57)
				{
					isShortcut = true;
					if (keySkill[2] != null)
					{
						doUseSkill(keySkill[2], isShortcut: true, isSelectSkill: true);
					}
				}
				else if (GameCanvas.keyAsciiPress == 48)
				{
					ChatTextField.gI().startChat(this, mResources.PUBLICCHAT[0]);
				}
			}
			else if (!GameCanvas.isChangMapKey)
			{
				if (GameCanvas.keyAsciiPress == 48)
				{
					saveAuto = 0;
					saveAuto = auto;
					Sound.play(Sound.MBClick, 0.5f);
					ChatTextField.gI().startChatPC(this, mResources.PUBLICCHAT[0], isPublic: true);
				}
			}
			else if (GameCanvas.keyAsciiPress == 49)
			{
				saveAuto = 0;
				saveAuto = auto;
				Sound.play(Sound.MBClick, 0.5f);
				ChatTextField.gI().startChatPC(this, mResources.PUBLICCHAT[0], isPublic: true);
			}
			GameCanvas.keyAsciiPress = 0;
		}
		GameCanvas.clearKeyPressed();
		GameCanvas.debug("F23", 0);
	}

	public void resetKeyNotRelease()
	{
		if (GameCanvas.timePutKeyPc > 0)
		{
			GameCanvas.timePutKeyPc--;
		}
		if (GameCanvas.timePutKeyPc <= 0)
		{
			GameCanvas.timePutKeyPc = 0;
			if (Main.isPC && (Char.getMyChar().statusMe == 2 || Char.getMyChar().statusMe == 3 || Char.getMyChar().statusMe == 4))
			{
				bool[] keyHold = GameCanvas.keyHold;
				int nUM = Key.NUM2;
				bool[] keyHold2 = GameCanvas.keyHold;
				int nUM2 = Key.NUM4;
				bool[] keyHold3 = GameCanvas.keyHold;
				int nUM3 = Key.NUM6;
				bool[] keyHold4 = GameCanvas.keyHold;
				bool flag;
				GameCanvas.keyHold[23] = (flag = (GameCanvas.keyHold[24] = false));
				keyHold4[22] = (flag = flag);
				keyHold3[nUM3] = (flag = flag);
				keyHold2[nUM2] = (flag = flag);
				keyHold[nUM] = flag;
			}
		}
	}

	private void checkAuto()
	{
		if (TileMap.mapID == 130 || isMobSameParty())
		{
			return;
		}
		long currentTimeMillis = mSystem.getCurrentTimeMillis();
		if ((GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[Key.NUM4] || GameCanvas.keyPressedz[Key.NUM6] || GameCanvas.keyPressedz[14] || GameCanvas.keyPressedz[15] || GameCanvas.keyPressedz[22] || GameCanvas.keyPressedz[23] || GameCanvas.keyPressedz[24]) && !ChatTextField.gI().isShow)
		{
			auto = 0;
			if (lockAutoMove)
			{
				Char.getMyChar().isLockMove = false;
				lockAutoMove = false;
			}
		}
		if (GameCanvas.keyPressedz[5] && !isPaintPopup())
		{
			if (auto == 0 && !isPaintPopup())
			{
				if (currentTimeMillis - lastFire < 800 && checkSkillValid2() && Char.getMyChar().mobFocus != null)
				{
					auto = 10;
					GameCanvas.keyPressedz[5] = false;
				}
			}
			else
			{
				if (!lockAutoMove && Char.getMyChar().statusMe != 14)
				{
					lockAutoMove = !lockAutoMove;
					Char.getMyChar().isLockMove = !Char.getMyChar().isLockMove;
					lastFire = currentTimeMillis;
					return;
				}
				auto = 0;
				if (lockAutoMove)
				{
					Char.getMyChar().isLockMove = false;
					lockAutoMove = false;
				}
				GameCanvas.keyPressedz[Key.NUM4] = (GameCanvas.keyPressedz[Key.NUM6] = false);
			}
			lastFire = currentTimeMillis;
		}
		if (GameCanvas.gameTick % 10 == 0 && auto > 0 && (Char.getMyChar().mobFocus != null || Char.getMyChar().itemFocus != null))
		{
			doFire(isFireByShortCut: false);
		}
		if (auto > 1)
		{
			auto--;
		}
	}

	private void resetAuto()
	{
		auto = 0;
		lockAutoMove = (Char.getMyChar().isLockMove = false);
	}

	public void doUseHP()
	{
		int num = (int)(mSystem.getCurrentTimeMillis() / 1000);
		for (int i = 0; i < Char.getMyChar().vEff.size(); i++)
		{
			Effect effect = (Effect)Char.getMyChar().vEff.elementAt(i);
			if (effect.template.id == 21 && effect.timeLenght - (num - effect.timeStart) >= 2)
			{
				return;
			}
		}
		if (Char.getMyChar().doUsePotion(16))
		{
			return;
		}
		for (int j = 0; j < Char.getMyChar().arrItemBag.Length; j++)
		{
			if (Char.getMyChar().arrItemBag[j] != null && Char.getMyChar().arrItemBag[j].template.type == 16)
			{
				InfoMe.addInfo(mResources.NOT_ENOUGH_LEVEL);
				return;
			}
		}
		if (auto != 1)
		{
			InfoMe.addInfo(mResources.HP_EMPTY);
		}
	}

	public void doUseMP()
	{
		// Debug
		Char.getMyChar().testAsset++;
		// Service.gI().chat(Char.getMyChar().testAsset.ToString());

		if (Char.getMyChar().doUsePotion(17))
		{
			return;
		}
		for (int i = 0; i < Char.getMyChar().arrItemBag.Length; i++)
		{
			if (Char.getMyChar().arrItemBag[i] != null && Char.getMyChar().arrItemBag[i].template.type == 17)
			{
				InfoMe.addInfo(mResources.NOT_ENOUGH_LEVEL);
				return;
			}
		}
		if (auto != 1)
		{
			InfoMe.addInfo(mResources.MP_EMPTY);
		}
	}

	private bool isMobSameParty()
	{
		if (Char.getMyChar().mobFocus != null)
		{
			if ((Char.getMyChar().mobFocus.getTemplate().mobTemplateId == 142 && Char.getMyChar().cTypePk == Char.PK_PHE1) || (Char.getMyChar().mobFocus.getTemplate().mobTemplateId == 143 && Char.getMyChar().cTypePk == Char.PK_PHE2) || (Char.getMyChar().mobFocus.getTemplate().mobTemplateId == 143 && Char.getMyChar().cTypePk == Char.PK_PHE3))
			{
				return true;
			}
			return false;
		}
		return false;
	}

	private void doFire(bool isFireByShortCut)
	{
		if (Char.getMyChar().statusMe == 14 || !isAttack())
		{
			return;
		}
		if (isMobSameParty())
		{
			MyVector myVector = new MyVector();
			myVector.addElement(new Command(mResources.CAT_KEO, 151301));
			GameCanvas.menu.startAt(myVector, 0);
			return;
		}
		if (Char.getMyChar().mobFocus != null && Char.getMyChar().mobFocus.getTemplate().mobTemplateId == 144 && TileMap.mapID == 130)
		{
			MyVector myVector2 = new MyVector();
			myVector2.addElement(new Command(mResources.CHO_KEO, 151301));
			GameCanvas.menu.startAt(myVector2, 0);
			return;
		}
		Char.getMyChar().setSkillPaint(sks[Char.getMyChar().myskill.template.id], 0);
		Char.getMyChar().currentFireByShortcut = isFireByShortCut;
		if (Char.getMyChar().isWolf)
		{
			Char.getMyChar().isWolf = false;
			Char.getMyChar().timeSummon = mSystem.getCurrentTimeMillis();
			ServerEffect.addServerEffect(60, Char.getMyChar(), 1);
		}
		if (Char.getMyChar().isHaveMoto() && !Char.getMyChar().isMotoBehind)
		{
			Char.getMyChar().isMoto = false;
			Char.getMyChar().isMotoBehind = true;
			ServerEffect.addServerEffect(60, Char.getMyChar(), 1);
		}
		if (Char.getMyChar().isHaveNewMount() && !Char.getMyChar().isMotoBehind)
		{
			Char.getMyChar().isNewMount = false;
			Char.getMyChar().isMotoBehind = true;
			ServerEffect.addServerEffect(60, Char.getMyChar(), 1);
		}
		if (!isFireByShortCut)
		{
			Char.getMyChar().lastNormalSkill = Char.getMyChar().myskill;
		}
	}

	public bool isBagFull()
	{
		for (int num = Char.getMyChar().arrItemBag.Length - 1; num >= 0; num--)
		{
			if (Char.getMyChar().arrItemBag[num] == null)
			{
				return false;
			}
		}
		return true;
	}

	private void doChangeSkill()
	{
		nSkill = 0;
		for (int i = 0; i < onScreenSkill.Length; i++)
		{
			if (onScreenSkill[i] != null)
			{
				nSkill++;
			}
		}
		if (nSkill > 1)
		{
			if (!isPaintSelectSkill || selectedIndexSkill == -1)
			{
				isPaintSelectSkill = true;
				for (int j = 0; j < onScreenSkill.Length; j++)
				{
					if (onScreenSkill[j] == Char.getMyChar().myskill)
					{
						selectedIndexSkill = j;
						break;
					}
				}
			}
			selectedIndexSkill++;
			if (selectedIndexSkill >= onScreenSkill.Length)
			{
				selectedIndexSkill = 0;
			}
			if (onScreenSkill[selectedIndexSkill] == null)
			{
				selectedIndexSkill = 0;
			}
			center = new Command(string.Empty, 11059);
		}
		else if (InfoMe.isEmpty())
		{
		}
	}

	public void doUseSkill(Skill skill, bool isShortcut, bool isSelectSkill)
	{
		selectedIndexSkill = -1;
		if (skill != null)
		{
			if (skill.template.type == 4 && Char.getMyChar().charFocus != null)
			{
				if (Char.getMyChar().charFocus.isNhanbanz())
				{
					return;
				}
				if (Char.getMyChar().charFocus.statusMe == 14 || Char.getMyChar().charFocus.statusMe == 5)
				{
					Service.gI().buffLive(Char.getMyChar().charFocus.charID);
					if ((TileMap.tileTypeAtPixel(Char.getMyChar().cx, Char.getMyChar().cy) & TileMap.T_TOP) == TileMap.T_TOP)
					{
						Char.getMyChar().setSkillPaint(sks[49], 0);
					}
					else
					{
						Char.getMyChar().setSkillPaint(sks[49], 1);
					}
				}
			}
			if (isSelectSkill)
			{
				Service.gI().selectSkill(skill.template.id);
			}
			saveRMSCurrentSkill(skill.template.id);
		}
		if (skill.template.type != 2)
		{
			resetButton();
		}
		if (skill != null)
		{
			Char.getMyChar().myskill = skill;
			if (Char.getMyChar().npcFocus == null && skill.template.type != 4)
			{
				doFire(isShortcut);
			}
		}
	}

	public void sortList(int type)
	{
		MyVector myVector = ((type != 0) ? vEnemies : vFriend);
		for (int i = 0; i < myVector.size() - 1; i++)
		{
			Friend friend = (Friend)myVector.elementAt(i);
			for (int j = i + 1; j < myVector.size(); j++)
			{
				Friend friend2 = (Friend)myVector.elementAt(j);
				if (friend2.type > friend.type)
				{
					Friend friend3 = friend2;
					friend2 = friend;
					friend = friend3;
					myVector.setElementAt(friend, i);
					myVector.setElementAt(friend2, j);
				}
				else if (friend2.type == friend.type && friend.friendName.CompareTo(friend2.friendName) > 0)
				{
					Friend friend4 = friend2;
					friend2 = friend;
					friend = friend4;
					myVector.setElementAt(friend, i);
					myVector.setElementAt(friend2, j);
				}
			}
		}
	}

	public void sortClan()
	{
		for (int i = 0; i < vClan.size() - 1; i++)
		{
			Member member = (Member)vClan.elementAt(i);
			for (int j = i + 1; j < vClan.size(); j++)
			{
				Member member2 = (Member)vClan.elementAt(j);
				if (isViewClanMemOnline && !isSortClanByPointWeek)
				{
					if (member2.isOnline && !member.isOnline)
					{
						Member member3 = member2;
						member2 = member;
						member = member3;
						vClan.setElementAt(member, i);
						vClan.setElementAt(member2, j);
					}
					else
					{
						if (!member2.isOnline || !member.isOnline)
						{
							continue;
						}
						if (member2.type > member.type)
						{
							Member member4 = member2;
							member2 = member;
							member = member4;
							vClan.setElementAt(member, i);
							vClan.setElementAt(member2, j);
						}
						else
						{
							if (member2.type != member.type)
							{
								continue;
							}
							if (member2.pointClan > member.pointClan)
							{
								Member member5 = member2;
								member2 = member;
								member = member5;
								vClan.setElementAt(member, i);
								vClan.setElementAt(member2, j);
							}
							else
							{
								if (member.pointClan != member2.pointClan)
								{
									continue;
								}
								if (member2.pointClanWeek > member.pointClanWeek)
								{
									Member member6 = member2;
									member2 = member;
									member = member6;
									vClan.setElementAt(member, i);
									vClan.setElementAt(member2, j);
								}
								else if (member.pointClanWeek == member2.pointClanWeek)
								{
									if (member2.level > member.level)
									{
										Member member7 = member2;
										member2 = member;
										member = member7;
										vClan.setElementAt(member, i);
										vClan.setElementAt(member2, j);
									}
									else if (member.level == member2.level && member.name.CompareTo(member2.name) > 0)
									{
										Member member8 = member2;
										member2 = member;
										member = member8;
										vClan.setElementAt(member, i);
										vClan.setElementAt(member2, j);
									}
								}
							}
						}
					}
				}
				else if (isSortClanByPointWeek)
				{
					if (isViewClanMemOnline)
					{
						if (member2.isOnline && !member.isOnline)
						{
							Member member9 = member2;
							member2 = member;
							member = member9;
							vClan.setElementAt(member, i);
							vClan.setElementAt(member2, j);
						}
						else
						{
							if (!member2.isOnline || !member.isOnline)
							{
								continue;
							}
							if (member2.pointClanWeek > member.pointClanWeek)
							{
								Member member10 = member2;
								member2 = member;
								member = member10;
								vClan.setElementAt(member, i);
								vClan.setElementAt(member2, j);
							}
							else
							{
								if (member.pointClanWeek != member2.pointClanWeek)
								{
									continue;
								}
								if (member2.pointClan > member.pointClan)
								{
									Member member11 = member2;
									member2 = member;
									member = member11;
									vClan.setElementAt(member, i);
									vClan.setElementAt(member2, j);
								}
								else if (member.pointClan == member2.pointClan)
								{
									if (member2.type > member.type)
									{
										Member member12 = member2;
										member2 = member;
										member = member12;
										vClan.setElementAt(member, i);
										vClan.setElementAt(member2, j);
									}
									else if (member2.type == member.type && member.level == member2.level && member.name.CompareTo(member2.name) > 0)
									{
										Member member13 = member2;
										member2 = member;
										member = member13;
										vClan.setElementAt(member, i);
										vClan.setElementAt(member2, j);
									}
								}
							}
						}
					}
					else if (member2.pointClanWeek > member.pointClanWeek)
					{
						Member member14 = member2;
						member2 = member;
						member = member14;
						vClan.setElementAt(member, i);
						vClan.setElementAt(member2, j);
					}
					else
					{
						if (member.pointClanWeek != member2.pointClanWeek)
						{
							continue;
						}
						if (member2.pointClan > member.pointClan)
						{
							Member member15 = member2;
							member2 = member;
							member = member15;
							vClan.setElementAt(member, i);
							vClan.setElementAt(member2, j);
						}
						else if (member.pointClan == member2.pointClan)
						{
							if (member2.type > member.type)
							{
								Member member16 = member2;
								member2 = member;
								member = member16;
								vClan.setElementAt(member, i);
								vClan.setElementAt(member2, j);
							}
							else if (member2.type == member.type && member.level == member2.level && member.name.CompareTo(member2.name) > 0)
							{
								Member member17 = member2;
								member2 = member;
								member = member17;
								vClan.setElementAt(member, i);
								vClan.setElementAt(member2, j);
							}
						}
					}
				}
				else if (member2.type > member.type)
				{
					Member member18 = member2;
					member2 = member;
					member = member18;
					vClan.setElementAt(member, i);
					vClan.setElementAt(member2, j);
				}
				else
				{
					if (member2.type != member.type)
					{
						continue;
					}
					if (member2.pointClan > member.pointClan)
					{
						Member member19 = member2;
						member2 = member;
						member = member19;
						vClan.setElementAt(member, i);
						vClan.setElementAt(member2, j);
					}
					else
					{
						if (member.pointClan != member2.pointClan)
						{
							continue;
						}
						if (member2.pointClanWeek > member.pointClanWeek)
						{
							Member member20 = member2;
							member2 = member;
							member = member20;
							vClan.setElementAt(member, i);
							vClan.setElementAt(member2, j);
						}
						else if (member.pointClanWeek == member2.pointClanWeek)
						{
							if (member2.level > member.level)
							{
								Member member21 = member2;
								member2 = member;
								member = member21;
								vClan.setElementAt(member, i);
								vClan.setElementAt(member2, j);
							}
							else if (member.level == member2.level && member.name.CompareTo(member2.name) > 0)
							{
								Member member22 = member2;
								member2 = member;
								member = member22;
								vClan.setElementAt(member, i);
								vClan.setElementAt(member2, j);
							}
						}
					}
				}
			}
		}
	}

	public void sortSkill()
	{
		for (int i = 0; i < Char.getMyChar().vSkillFight.size() - 1; i++)
		{
			Skill skill = (Skill)Char.getMyChar().vSkillFight.elementAt(i);
			for (int j = i + 1; j < Char.getMyChar().vSkillFight.size(); j++)
			{
				Skill skill2 = (Skill)Char.getMyChar().vSkillFight.elementAt(j);
				if (skill2.template.id < skill.template.id)
				{
					Skill skill3 = skill2;
					skill2 = skill;
					skill = skill3;
					Char.getMyChar().vSkillFight.setElementAt(skill, i);
					Char.getMyChar().vSkillFight.setElementAt(skill2, j);
				}
			}
		}
	}

	private void doViewMessagebyTouch()
	{
		int num = messageType();
		if (num == -1 || isPaintPopup() || isPaintUI() || isOpenUI())
		{
			return;
		}
		if (num == 0)
		{
			if (ChatManager.gI().waitList.size() > 0)
			{
				int num2 = ChatManager.gI().postWaitPerson();
				ChatManager.gI().switchToTab(num2);
				openUIChatTab();
				xM[0] = (yM[0] = -1);
			}
			return;
		}
		if (ChatManager.isMessagePt)
		{
			ChatManager.gI().switchToTab(1);
		}
		else if (ChatManager.isMessageClan)
		{
			ChatManager.gI().switchToTab(3);
		}
		openUIChatTab();
		xM[1] = (yM[1] = -1);
	}

	private int messageType()
	{
		int result = -1;
		if (GameCanvas.isPointerClick)
		{
			for (int i = 0; i < xM.Length; i++)
			{
				if (GameCanvas.isPointerHoldIn(xM[i], yM[i], 100, 12) && GameCanvas.isPointerJustRelease)
				{
					result = i;
					break;
				}
			}
		}
		return result;
	}

	private void updateKeyTouchControl()
	{
		bool flag = false;
		mScreen.keyTouch = -1;
		if (GameCanvas.isPointerHoldIn(TileMap.posMiniMapX, TileMap.posMiniMapY, TileMap.wMiniMap, TileMap.hMiniMap) && GameCanvas.isPointerClick && GameCanvas.isPointerJustRelease)
		{
			doShowMap();
			flag = true;
		}
		if (!GameCanvas.isTouch || (GameCanvas.menu.showMenu && GameCanvas.isTouchControlSmallScreen) || GameCanvas.currentDialog != null || ChatPopup.currentMultilineChatPopup != null || GameCanvas.menu.showMenu || isPaintPopup())
		{
			return;
		}
		if (GameCanvas.isPointerHoldIn(xC, yC, 34, 34))
		{
			mScreen.keyTouch = 15;
			if (GameCanvas.isPointerClick && GameCanvas.isPointerJustRelease)
			{
				Sound.play(Sound.MBClick, 0.5f);
				if (!Main.isPC)
				{
					ChatTextField.gI().startChat(this, mResources.PUBLICCHAT[0]);
				}
				else
				{
					ChatTextField.gI().startChatPC(this, mResources.PUBLICCHAT[0], isPublic: true);
				}
				GameCanvas.isPointerJustRelease = false;
				GameCanvas.isPointerClick = false;
				flag = true;
			}
		}
		if (!Char.getMyChar().isCaptcha)
		{
			if (isNotPaintTouchControl())
			{
				return;
			}
			if (!isTouchKey)
			{
				gamePad.update();
			}
			else if (!Main.isPC)
			{
				if (GameCanvas.isPointerHoldIn(xU, yU, 34, 34))
				{
					mScreen.keyTouch = 3;
					GameCanvas.keyHold[2] = true;
					resetAuto();
					flag = true;
				}
				else if (GameCanvas.isPointerDown)
				{
					GameCanvas.keyHold[2] = false;
				}
				if (GameCanvas.isPointerHoldIn(xU - 30, yU, 30, 34))
				{
					GameCanvas.keyHold[1] = true;
					resetAuto();
					flag = true;
				}
				else if (GameCanvas.isPointerDown)
				{
					GameCanvas.keyHold[1] = false;
				}
				if (GameCanvas.isPointerHoldIn(xU + 34, yU, 30, 34))
				{
					GameCanvas.keyHold[3] = true;
					resetAuto();
					flag = true;
				}
				else if (GameCanvas.isPointerDown)
				{
					GameCanvas.keyHold[3] = false;
				}
				if (GameCanvas.isPointerHoldIn(xL, yL, 34, 34))
				{
					mScreen.keyTouch = 4;
					GameCanvas.keyHold[4] = true;
					resetAuto();
					flag = true;
				}
				else if (GameCanvas.isPointerDown)
				{
					GameCanvas.keyHold[4] = false;
				}
				if (GameCanvas.isPointerHoldIn(xR - 5, yR, 40, 34))
				{
					mScreen.keyTouch = 6;
					GameCanvas.keyHold[6] = true;
					resetAuto();
					flag = true;
				}
				else if (GameCanvas.isPointerDown)
				{
					GameCanvas.keyHold[6] = false;
				}
			}
			if (!Main.isPC && GameCanvas.isPointerHoldIn(xF, yF, 54, 54))
			{
				GameCanvas.keyHold[5] = true;
				mScreen.keyTouch = 5;
				if (GameCanvas.isPointerJustRelease)
				{
					GameCanvas.keyPressedz[5] = true;
					flag = true;
				}
			}
		}
		else
		{
			updateTouchCaptcha();
		}
		if (Char.getMyChar().ctaskId > 1)
		{
			if (GameCanvas.isPointerHoldIn(xMP, yMP, 34, 34))
			{
				mScreen.keyTouch = 11;
				if (GameCanvas.isPointerClick && GameCanvas.isPointerJustRelease)
				{
					doUseMP();
					Sound.play(Sound.MBClick, 0.5f);
					GameCanvas.isPointerClick = false;
					flag = true;
				}
			}
			if (GameCanvas.isPointerHoldIn(xHP, yHP, 34, 34))
			{
				mScreen.keyTouch = 10;
				if (GameCanvas.isPointerClick && GameCanvas.isPointerJustRelease)
				{
					doUseHP();
					Sound.play(Sound.MBClick, 0.5f);
					GameCanvas.isPointerClick = false;
					flag = true;
				}
			}
			if (!Main.isPC && GameCanvas.isPointerHoldIn(xTG, yTG, 34, 34))
			{
				mScreen.keyTouch = 13;
				if (GameCanvas.isPointerClick && GameCanvas.isPointerJustRelease)
				{
					Char.getMyChar().findNextFocusByKey();
					Sound.play(Sound.MBClick, 0.5f);
					flag = true;
				}
			}
		}
		if (Char.getMyChar().vSkill.size() >= 2 && (GameCanvas.isPointerHoldIn(xSkill + xS[0], yS[0], onScreenSkill.Length * 30, 30) || (!GameCanvas.isTouchControl && GameCanvas.isPointerHoldIn(xSkill + xS[0], yS[0], 30, onScreenSkill.Length * 25))) && GameCanvas.isPointerClick && GameCanvas.isPointerJustRelease)
		{
			int num = 0;
			num = (selectedIndexSkill = (GameCanvas.isTouchControl ? ((GameCanvas.pxLast - (xSkill + xS[0])) / 30) : ((GameCanvas.pyLast - (ySkill + yS[0])) / 25)));
			if (indexSelect < 0)
			{
				indexSelect = 0;
			}
			if (selectedIndexSkill > onScreenSkill.Length - 1)
			{
				selectedIndexSkill = onScreenSkill.Length - 1;
			}
			flag = true;
			Skill skill = onScreenSkill[selectedIndexSkill];
			doUseSkill(skill, isShortcut: false, isSelectSkill: true);
			isShortcut = true;
		}
		if (Main.isPC)
		{
			if (GameCanvas.keyPressedz[(!GameCanvas.isChangMapKey) ? 1 : 6])
			{
				GameCanvas.keyPressedz[(!GameCanvas.isChangMapKey) ? 1 : 6] = false;
				Skill skill2 = onScreenSkill[0];
				doUseSkill(skill2, isShortcut: false, isSelectSkill: true);
			}
			if (GameCanvas.keyPressedz[GameCanvas.isChangMapKey ? 7 : 2])
			{
				GameCanvas.keyPressedz[GameCanvas.isChangMapKey ? 7 : 2] = false;
				Skill skill3 = onScreenSkill[1];
				doUseSkill(skill3, isShortcut: false, isSelectSkill: true);
			}
			if (GameCanvas.keyPressedz[GameCanvas.isChangMapKey ? 8 : 3])
			{
				GameCanvas.keyPressedz[GameCanvas.isChangMapKey ? 8 : 3] = false;
				Skill skill4 = onScreenSkill[2];
				doUseSkill(skill4, isShortcut: false, isSelectSkill: true);
			}
			if (GameCanvas.keyPressedz[GameCanvas.isChangMapKey ? 9 : 4])
			{
				GameCanvas.keyPressedz[GameCanvas.isChangMapKey ? 9 : 4] = false;
				Skill skill5 = onScreenSkill[3];
				doUseSkill(skill5, isShortcut: false, isSelectSkill: true);
			}
			if (GameCanvas.keyPressedz[(!GameCanvas.isChangMapKey) ? 27 : 0])
			{
				GameCanvas.keyPressedz[(!GameCanvas.isChangMapKey) ? 27 : 0] = false;
				Skill skill6 = onScreenSkill[4];
				doUseSkill(skill6, isShortcut: false, isSelectSkill: true);
			}
		}
		if (GameCanvas.isPointerJustRelease)
		{
			GameCanvas.keyHold[Key.NUM1] = false;
			GameCanvas.keyHold[Key.NUM2] = false;
			GameCanvas.keyHold[Key.NUM3] = false;
			GameCanvas.keyHold[Key.NUM4] = false;
			GameCanvas.keyHold[Key.NUM6] = false;
			GameCanvas.keyHold[22] = false;
			GameCanvas.keyHold[23] = false;
			GameCanvas.keyHold[24] = false;
			GameCanvas.keyHold[25] = false;
		}
		if (!flag)
		{
			doFocusbyTouch();
		}
	}

	private void autoFocus()
	{
		if (cLastFocusID >= 0 && vCharInMap.size() > 0)
		{
			int indexChar = Char.getIndexChar(cLastFocusID);
			if (indexChar >= 0 && indexChar < vCharInMap.size())
			{
				Char @char = (Char)vCharInMap.elementAt(indexChar);
				if (@char != null && Char.isCharInScreen(@char) && !@char.isNhanbanz())
				{
					Char.getMyChar().mobFocus = null;
					Char.getMyChar().deFocusNPC();
					Char.getMyChar().itemFocus = null;
					Char.isManualFocus = true;
					Char.getMyChar().charFocus = @char;
				}
			}
			else
			{
				cLastFocusID = -1;
				Char.getMyChar().charFocus = null;
			}
		}
		else
		{
			cLastFocusID = -1;
		}
	}

	public void setCharJumpAtt()
	{
		Char.getMyChar().cvy = ((!Char.getMyChar().canJumpHigh) ? (-8) : (-10));
		Char.getMyChar().statusMe = 3;
		Char.getMyChar().cp1 = 0;
	}

	public void setCharJump(int cvx)
	{
		Char.getMyChar().cvy = ((!Char.getMyChar().canJumpHigh) ? (-8) : (-10));
		Char.getMyChar().cvx = cvx;
		Char.getMyChar().statusMe = 3;
		Char.getMyChar().cp1 = 0;
	}

	public void updateOpen()
	{
		if (isstarOpen)
		{
			if (moveUp > -3)
			{
				moveUp -= 4;
			}
			else
			{
				moveUp = -2;
			}
			if (moveDow < GameCanvas.h + 3)
			{
				moveDow += 4;
			}
			else
			{
				moveDow = GameCanvas.h + 2;
			}
			if (moveUp <= -2 && moveDow >= GameCanvas.h + 2)
			{
				isstarOpen = false;
			}
		}
	}

	public override void update()
	{
		runArrow++;
		if (runArrow > 3)
		{
			runArrow = 0;
		}
		updateCamera();
		if (indexMenu == 4 && GameCanvas.isTouch && mScreen.getCmdPointerLast(cmdTrangbi2) && cmdTrangbi2 != null)
		{
			GameCanvas.isPointerJustRelease = false;
			GameCanvas.keyPressedz[5] = false;
			mScreen.keyTouch = -1;
			cmdTrangbi2.performAction();
		}
		fhorsetrangbi = (fhorsetrangbi + 1) % fhorse.Length;
		if (GameCanvas.gameTick % 200 == 0)
		{
			Char.SetRemove();
		}
		ChatTextField.gI().update();
		TileMap.updateCmMiniMap();
		GameCanvas.gI().updateBallEffect();
		TileMap.updateMusic();
		if (GameCanvas.isGPRS)
		{
			MyVector myVector = new MyVector();
			long currentTimeMillis = mSystem.getCurrentTimeMillis();
			for (int i = 0; i < vCharInMap.size(); i++)
			{
				Char @char = (Char)vCharInMap.elementAt(i);
				if (@char == null)
				{
					continue;
				}
				@char.update();
				if (@char.isPaint())
				{
					if (@char.isDirtyPostion && currentTimeMillis - @char.lastUpdateTime > 10000 && currentTimeMillis - lastSendUpdatePostion > 10000)
					{
						@char.isDirtyPostion = false;
						@char.lastUpdateTime = currentTimeMillis;
						myVector.addElement(@char);
					}
				}
				else
				{
					@char.lastUpdateTime = currentTimeMillis;
					@char.isDirtyPostion = true;
				}
			}
			if (myVector.size() > 0)
			{
				Service.gI().requestPlayerInfo(myVector);
				lastSendUpdatePostion = currentTimeMillis;
			}
		}
		else
		{
			for (int j = 0; j < vCharInMap.size(); j++)
			{
				((Char)vCharInMap.elementAt(j))?.update();
			}
		}
		GameCanvas.debug("E5", 0);
		Char.getMyChar().update();
		GameCanvas.debug("E5x", 0);
		for (int k = 0; k < vMob.size(); k++)
		{
			((Mob)vMob.elementAt(k))?.update();
		}
		GameCanvas.debug("E6", 0);
		for (int l = 0; l < vNpc.size(); l++)
		{
			((Npc)vNpc.elementAt(l))?.update();
		}
		GameCanvas.debug("E7", 0);
		GameCanvas.gI().updateDust();
		GameCanvas.debug("E8", 0);
		updateFlyText();
		updateLanterns();
		updateSplash();
		updateSS();
		GameCanvas.updateBG();
		GameCanvas.debug("E9", 0);
		for (int m = 0; m < vMobAttack.size(); m++)
		{
			((MobAttack)vMobAttack.elementAt(m))?.update();
		}
		GameCanvas.debug("E10", 0);
		for (int n = 0; n < vItemMap.size(); n++)
		{
			((ItemMap)vItemMap.elementAt(n))?.update();
		}
		for (int num = 0; num < vMobSoul.size(); num++)
		{
			((MobSoul)vMobSoul.elementAt(num)).update();
		}
		if (tfText != null && tfText.isFocus)
		{
			tfText.update();
		}
		GameCanvas.debug("E11", 0);
		for (int num2 = 0; num2 < vSet.size(); num2++)
		{
			((Set)vSet.elementAt(num2))?.update();
		}
		GameCanvas.debug("E12", 0);
		if ((TileMap.tmw * TileMap.sizeMiniMap >= TileMap.wMiniMap || TileMap.tmh * TileMap.sizeMiniMap >= TileMap.hMiniMap) && mSystem.getCurrentTimeMillis() / 100 - TileMap.timeTranMini > 20)
		{
			TileMap.updateMiniMap();
		}
		GameCanvas.debug("E13", 0);
		for (int num3 = Effect2.vRemoveEffect2.size() - 1; num3 >= 0; num3--)
		{
			Effect2.vEffect2.removeElement(Effect2.vRemoveEffect2.elementAt(num3));
			Effect2.vRemoveEffect2.removeElementAt(num3);
		}
		for (int num4 = 0; num4 < Effect2.vEffect2.size(); num4++)
		{
			((Effect2)Effect2.vEffect2.elementAt(num4))?.update();
		}
		for (int num5 = 0; num5 < Effect2.vEffect2Outside.size(); num5++)
		{
			((Effect2)Effect2.vEffect2Outside.elementAt(num5))?.update();
		}
		for (int num6 = 0; num6 < Effect2.vAnimateEffect.size(); num6++)
		{
			((Effect2)Effect2.vAnimateEffect.elementAt(num6))?.update();
		}
		for (int num7 = 0; num7 < Mob.vEggMonter.size(); num7++)
		{
			EggMonters eggMonters = (EggMonters)Mob.vEggMonter.elementAt(num7);
			if (eggMonters == null)
			{
				continue;
			}
			eggMonters.update();
			if (eggMonters.frame == 6)
			{
				if (EggMonters.ownerEgg != null)
				{
					EggMonters.ownerEgg.status = 5;
				}
				Mob.vEggMonter.removeElementAt(num7);
			}
		}
		SmallImage.checkTimeUseImg();
		autoFocus();
		Info.update();
		InfoMe.update();
		if (currentCharViewInfo != null && currentCharViewInfo.charID != Char.getMyChar().charID)
		{
			currentCharViewInfo.update();
		}
		if (isPaintRankedList)
		{
			indexSize = 40;
		}
		else
		{
			indexSize = 28;
		}
		EffectAuto.checkTimeUseImg();
		EffectAuto.checkTimeUseData();
		if (GameCanvas.isKiemduyet_info)
		{
			GameCanvas.regScr.switchToMe();
		}
	}

	public override void paint(mGraphics g)
	{
		GameCanvas.debug("PA1", 1);
		if (Char.ischangingMap)
		{
			g.setColor(0);
			g.fillRect(0, 0, GameCanvas.w, GameCanvas.h);
			mFont.tahoma_7b_yellow.drawString(g, mResources.LOADING, GameCanvas.hw, GameCanvas.hh + 20, 2);
			GameCanvas.paintShukiren(GameCanvas.hw, GameCanvas.hh, g, noRotate: false);
			return;
		}
		isPaintInfoHelpNotIphone = false;
		GameCanvas.paintBGGameScr(g);
		if (Screen.width > TileMap.pxw && mGraphics.zoomLevel != 3 && TileMap.mapID == 6)
		{
			g.translate(-cmx - 40, -cmy);
		}
		else
		{
			g.translate(-cmx, -cmy);
		}
		for (int i = 0; i < vItemTreeBehind.size(); i++)
		{
			((ItemTree)vItemTreeBehind.elementAt(i)).paint(g);
		}
		TileMap.paintTilemap(g);
		for (int j = 0; j < vItemTreeBetwen.size(); j++)
		{
			((ItemTree)vItemTreeBetwen.elementAt(j)).paint(g);
		}
		for (int k = 0; k < vMob.size(); k++)
		{
			((Mob)vMob.elementAt(k))?.paint(g);
		}
		for (int l = 0; l < Mob.vEggMonter.size(); l++)
		{
			((EggMonters)Mob.vEggMonter.elementAt(l))?.paint(g);
		}
		for (int m = 0; m < vBuNhin.size(); m++)
		{
			((BuNhin)vBuNhin.elementAt(m))?.paint(g);
		}
		GameCanvas.debug("PA6", 1);
		for (int n = 0; n < vNpc.size(); n++)
		{
			((Npc)vNpc.elementAt(n))?.paint(g);
		}
		paintWaypointArrow(g);
		GameCanvas.debug("PA7", 1);
		GameCanvas.gI().paintDust(g);
		GameCanvas.debug("PA8", 1);
		for (int num = 0; num < vCharInMap.size(); num++)
		{
			Char @char = null;
			try
			{
				@char = (Char)vCharInMap.elementAt(num);
			}
			catch (Exception)
			{
			}
			if (@char != null)
			{
				if (TileMap.mapID == 111 && num > 19)
				{
					@char.paintCharName_HP_MP_Overhead(g);
				}
				else
				{
					@char.paint(g);
				}
			}
		}
		for (int num2 = 0; num2 < vParty.size(); num2++)
		{
			Party party = (Party)vParty.elementAt(num2);
			if (party.c != null && party.c != Char.getMyChar())
			{
				party.c.paintNameInSameParty(g);
			}
		}
		GameCanvas.debug("PA9", 1);
		paintFlyText(g);
		paintLanterns(g);
		paintSplash(g);
		GameCanvas.debug("PA10", 1);
		Char.getMyChar().paint(g);
		paintCaptcha(g);
		GameCanvas.debug("PA11", 1);
		for (int num3 = 0; num3 < vSet.size(); num3++)
		{
			((Set)vSet.elementAt(num3))?.paint(g);
		}
		GameCanvas.debug("PA12", 1);
		for (int num4 = 0; num4 < vItemMap.size(); num4++)
		{
			((ItemMap)vItemMap.elementAt(num4))?.paint(g);
		}
		for (int num5 = 0; num5 < vMobSoul.size(); num5++)
		{
			((MobSoul)vMobSoul.elementAt(num5)).paint(g);
		}
		GameCanvas.debug("PA13", 1);
		TileMap.paintOutTilemap(g);
		GameCanvas.debug("PA14", 1);
		for (int num6 = 0; num6 < Effect2.vEffect2.size(); num6++)
		{
			((Effect2)Effect2.vEffect2.elementAt(num6))?.paint(g);
		}
		for (int num7 = 0; num7 < vItemTreeFront.size(); num7++)
		{
			((ItemTree)vItemTreeFront.elementAt(num7)).paint(g);
		}
		if (GameCanvas.imgfog1 != null)
		{
			for (int num8 = 0; num8 < 2; num8++)
			{
				g.drawImage(GameCanvas.imgfog1, GameCanvas.cloudX[num8], 100, 3);
			}
			for (int num9 = 0; num9 < TileMap.pxw; num9 += GameCanvas.imgfog.getWidth())
			{
				g.drawImage(GameCanvas.imgfog, num9, TileMap.pxh, 3);
			}
		}
		if (!GameCanvas.lowGraphic && !Main.isIpod && mGraphics.zoomLevel != 1)
		{
			for (int num10 = 0; num10 < Effect2.vAnimateEffect.size(); num10++)
			{
				((Effect2)Effect2.vAnimateEffect.elementAt(num10))?.paint(g);
			}
		}
		GameCanvas.debug("PA15", 1);
		for (int num11 = 0; num11 < vMobAttack.size(); num11++)
		{
			((MobAttack)vMobAttack.elementAt(num11))?.paint(g);
		}
		GameCanvas.debug("PA16", 1);
		paintArrowPointToNPC(g);
		GameCanvas.debug("PA17", 1);
		if (hideInterface)
		{
			return;
		}
		paintInfoBar(g);
		if (!Char.getMyChar().isCaptcha)
		{
			paintDebugInfo(g);
			g.translate(-g.getTranslateX(), -g.getTranslateY());
			paintFoodEffect(g);
			GameCanvas.debug("PA21", 1);
			g.translate(-g.getTranslateX(), -g.getTranslateY());
			TileMap.paintMiniMap(g);
			GameCanvas.debug("PA18", 1);
			g.translate(-g.getTranslateX(), -g.getTranslateY());
			if (GameCanvas.isTouch)
			{
				isPaintSelectSkill = true;
			}
			GameCanvas.debug("PA19", 1);
			GameCanvas.debug("PA20", 1);
			g.translate(-g.getTranslateX(), -g.getTranslateY());
			paintSelectedSkill(g);
			GameCanvas.debug("PA22", 1);
			g.translate(-g.getTranslateX(), -g.getTranslateY());
			for (int num12 = 0; num12 < Effect2.vEffect2Outside.size(); num12++)
			{
				((Effect2)Effect2.vEffect2Outside.elementAt(num12))?.paint(g);
			}
			g.translate(-g.getTranslateX(), -g.getTranslateY());
			g.setClip(0, -200, GameCanvas.w, 200 + GameCanvas.h);
			if (isPaintInfoMe)
			{
				GameCanvas.debug("PA24", 1);
				paintHanhTrang(g);
				GameCanvas.debug("PA25", 1);
				paintKyNang(g);
				GameCanvas.debug("PA26", 1);
				paintTiemNang(g);
				GameCanvas.debug("PA27", 1);
				paintThongtin(g);
				GameCanvas.debug("PA28", 1);
				paintTrangbi(g);
				GameCanvas.debug("PA29", 1);
				paintThuCuoi(g);
				paintBijuu(g);
			}
			else if (isPaintUI())
			{
				GameCanvas.debug("PA30", 1);
				paintUIStore(g);
				GameCanvas.debug("PA31", 1);
				paintNonNam(g);
				GameCanvas.debug("PA32", 1);
				paintNonNu(g);
				GameCanvas.debug("PA33", 1);
				paintAoNam(g);
				GameCanvas.debug("PA34", 1);
				paintAoNu(g);
				GameCanvas.debug("PA35", 1);
				paintGangTayNam(g);
				GameCanvas.debug("PA36", 1);
				paintGangTayNu(g);
				GameCanvas.debug("PA37", 1);
				paintQuanNam(g);
				GameCanvas.debug("PA38", 1);
				paintQuanNu(g);
				GameCanvas.debug("PA39", 1);
				paintGiayNam(g);
				GameCanvas.debug("PA40", 1);
				paintGiayNu(g);
				GameCanvas.debug("PA41", 1);
				paintLien(g);
				GameCanvas.debug("PA42", 1);
				paintNhan(g);
				GameCanvas.debug("PA43", 1);
				paintNgocBoi(g);
				GameCanvas.debug("PA44", 1);
				paintPhu(g);
				GameCanvas.debug("PA45", 1);
				paintBinhkhi(g);
				paintUIEliteShop(g);
				paintUILuckySprin(g);
				GameCanvas.debug("PA46", 1);
				paintThuoc(g);
				GameCanvas.debug("PA47", 1);
				paintThuocKhoa(g);
				GameCanvas.debug("PA48", 1);
				paintTaphoa(g);
				GameCanvas.debug("PA49", 1);
				paintTaphoakhoa(g);
				GameCanvas.debug("PA50", 1);
				paintCuonghoa(g);
				paintGianHang(g);
				PaintAuctionBuy(g);
				paintChuyenHoa(g);
				GameCanvas.debug("PA51", 1);
				paintTachHT(g);
				paintLuyenThu(g);
				paintLuyenAo(g);
				GameCanvas.debug("PA52", 1);
				paintGhepngoc(g);
				GameCanvas.debug("PA53", 1);
				paintLuyenThach(g);
				paintRuong(g);
				GameCanvas.debug("PA54", 1);
				paintItemTrade(g);
				GameCanvas.debug("PA55", 1);
				paintLuyenNgoc(g);
				paintKhamNgoc(g);
				paintGiaoDo(g);
				paintGotNgoc(g);
				paintThaoNgoc(g);
			}
			else if (isPaintZone)
			{
				GameCanvas.debug("PA56", 1);
				paintZone(g);
			}
			paintUIAuto(g);
			GameCanvas.debug("PA57", 1);
			paintTask(g);
			paintCharInMap(g);
			paintTeam(g);
			paintFindTeam(g);
			paintFriend(g);
			paintList(g);
			paintClanInfo(g);
			GameCanvas.debug("PA58", 1);
			paintItemInfo(g);
			paintListRanked(g);
			GameCanvas.debug("PA59", 1);
			g.translate(-g.getTranslateX(), -g.getTranslateY());
			if (GameCanvas.isTouch && GameCanvas.w >= 320)
			{
				if (left != null && left != menu)
				{
					left.x = GameCanvas.w / 2 - 160;
					left.y = GameCanvas.h - 26;
				}
				if (center != null)
				{
					center.x = GameCanvas.w / 2 - 35;
					center.y = GameCanvas.h - 26;
				}
				if (right != null && right != cmdFocus)
				{
					right.x = GameCanvas.w / 2 + 88;
					right.y = GameCanvas.h - 26;
				}
			}
		}
		base.paint(g);
		if (GameCanvas.isTouch && GameCanvas.isTouchControl)
		{
			paintTouchControl(g);
			isPaintSelectSkill = true;
		}
		resetTranslate(g);
		paintAlert(g);
		resetTranslate(g);
		paintLucky_Draw(g);
		resetTranslate(g);
		Info.paint(g);
		g.translate(-g.getTranslateX(), -g.getTranslateY());
		ChatTextField.gI().paint(g);
		resetTranslate(g);
		InfoMe.paint(g);
	}

	private void paintUIAuto(mGraphics g)
	{
		if (isPaintAuto)
		{
			resetTranslate(g);
			GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
			if (indexTitle == 1)
			{
				g.setColor(Paint.COLORDARK);
				g.fillRect(popupX + 7, popupY + 32, popupW - 14, popupH - 55);
				g.setColor(16777215);
			}
			else
			{
				g.setColor(10249521);
			}
			g.drawRect(popupX + 7, popupY + 32, popupW - 14, popupH - 55);
			paintTitle(g, mResources.ACTIONS[7], arrow: false);
			xstart = popupX + 17;
			ystart = popupY + 45;
			indexRowMax = 7;
			scrMain.setStyle(indexRowMax, 35, popupX, popupY + 39, popupW, popupH - 63, styleUPDOWN: true, 1);
			scrMain.setClip(g);
			int num = ystart;
			paintCheckBox(g, mResources.AUTO_TEXT[0], Char.isAHP, Char.aHpValue + "%", xstart, num);
			paintCheckBox(g, mResources.AUTO_TEXT[1], Char.isAMP, Char.aMpValue + "%", xstart, num += 30);
			paintCheckBox(g, mResources.AUTO_TEXT[2], Char.isAFood, Char.aFoodValue + string.Empty, xstart, num += 30);
			paintCheckBox(g, mResources.AUTO_TEXT[3], Char.isABuff, string.Empty, xstart, num += 30);
			paintCheckBox(g, mResources.AUTO_TEXT[4], Char.isAPickYen, string.Empty, xstart, num += 30);
			paintCheckBox(g, mResources.AUTO_TEXT[5], Char.isAPickYHM, string.Empty, xstart, num += 30);
			paintCheckBox(g, mResources.AUTO_TEXT[6], Char.isAPickYHMS, string.Empty, xstart, num += 30);
			paintCheckBox(g, mResources.AUTO_TEXT[7], Char.isANoPick, string.Empty, xstart, num += 30);
			if (indexTitle == 1 && indexRow >= 0 && !GameCanvas.isTouch)
			{
				SmallImage.drawSmallImage(g, 942, xstart - 8, ystart + 2 + indexRow * 30, 0, StaticObj.TOP_LEFT);
			}
			resetTranslate(g);
			mFont.tahoma_7_green.drawString(g, (!GameCanvas.isTouch) ? mResources.AUTO_TIP1 : mResources.AUTO_TIP2, popupX + popupW / 2, popupY + popupH - 17, 2);
		}
	}

	private void paintCheckBox(mGraphics g, string title, bool isCheck, string value, int x, int y)
	{
		g.setColor(16777215);
		g.fillRect(x, y, 12, 12);
		if (isCheck)
		{
			g.setColor(9650442);
			g.drawLine(x + 2, y + 2, x + 2 + 7, y + 2 + 7);
			g.drawLine(x + 2, y + 2 + 7, x + 2 + 7, y + 2);
		}
		mFont mFont2 = ((!isCheck) ? mFont.tahoma_7_grey : mFont.tahoma_7_white);
		mFont2.drawString(g, title, x + 18, y, 0);
		if (!value.Equals(string.Empty))
		{
			g.setColor(Paint.COLORLIGHT);
			g.fillRect(x + 115, y - 3, 30, 20);
			g.setColor(isCheck ? 16777215 : 0);
			g.drawRect(x + 115, y - 3, 30, 20);
			mFont2.drawString(g, value, x + 133, y + 2, mFont.CENTER);
		}
	}

	public bool isOpeningUI()
	{
		return false;
	}

	private void paintList(mGraphics g)
	{
		if (!isPaintList)
		{
			return;
		}
		GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
		paintTitle(g, mResources.LIST, arrow: false);
		xstart = popupX + 5;
		ystart = popupY + 40;
		if (vList.size() == 0)
		{
			mFont.tahoma_7_white.drawString(g, mResources.EMPTY_INFO, popupX + popupW / 2, popupY + 40, mFont.CENTER);
			return;
		}
		g.setColor(6425);
		g.fillRect(xstart - 2, ystart - 2, popupW - 6, indexSize * 5 + 8);
		resetTranslate(g);
		scrMain.setStyle(vList.size(), indexSize, xstart, ystart, popupW - 3, indexSize * 5 + 4, styleUPDOWN: true, 1);
		if (Main.isPC)
		{
			scrMain.setClip(g, xstart, ystart, popupW - 3, indexSize * 5 + 6);
		}
		else
		{
			scrMain.setClip(g, xstart, ystart, popupW - 3, indexSize * 4 + 6);
		}
		indexRowMax = vList.size();
		for (int i = 0; i < vList.size(); i++)
		{
			DunItem dunItem = null;
			try
			{
				dunItem = (DunItem)vList.elementAt(i);
			}
			catch (Exception)
			{
			}
			if (dunItem != null)
			{
				if (indexRow == i)
				{
					g.setColor(Paint.COLORLIGHT);
					g.fillRect(xstart + 2, ystart + indexRow * indexSize + 2, popupW - 15, indexSize - 4);
					g.setColor(16777215);
					g.drawRect(xstart + 2, ystart + indexRow * indexSize + 2, popupW - 15, indexSize - 4);
				}
				else
				{
					g.setColor(Paint.COLORBACKGROUND);
					g.fillRect(xstart + 2, ystart + i * indexSize + 2, popupW - 15, indexSize - 4);
					g.setColor(13932896);
					g.drawRect(xstart + 2, ystart + i * indexSize + 2, popupW - 15, indexSize - 4);
				}
				mFont.tahoma_7_yellow.drawString(g, dunItem.name1, xstart + (popupW - 10) / 2 - popupW / 4, ystart + i * indexSize + indexSize / 2 - 6, 2);
				mFont.tahoma_7b_red.drawString(g, " vs ", xstart + (popupW - 10) / 2, ystart + i * indexSize + indexSize / 2 - 6, 2);
				mFont.tahoma_7_yellow.drawString(g, dunItem.name2, xstart + (popupW - 10) / 2 + popupW / 4, ystart + i * indexSize + indexSize / 2 - 6, 2);
			}
		}
		paintNumCount(g);
	}

	private void paintCharInMap(mGraphics g)
	{
		if (!isPaintCharInMap)
		{
			return;
		}
		GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
		paintTitle(g, mResources.LIST, arrow: false);
		xstart = popupX + 5;
		ystart = popupY + 40;
		int num = ((!Main.isPC) ? 4 : 5);
		if (vCharInMap.size() == 0)
		{
			mFont.tahoma_7_white.drawString(g, mResources.NO_ONE, popupX + popupW / 2, popupY + 40, mFont.CENTER);
			return;
		}
		g.setColor(6425);
		g.fillRect(xstart - 2, ystart - 2, popupW - 6, indexSize * num + 8);
		resetTranslate(g);
		scrMain.setStyle(vCharInMap.size(), indexSize, xstart, ystart, popupW - 3, indexSize * num + 4, styleUPDOWN: true, 1);
		scrMain.setClip(g, xstart, ystart, popupW - 3, indexSize * num + 6);
		indexRowMax = vCharInMap.size();
		for (int i = 0; i < vCharInMap.size(); i++)
		{
			Char @char = null;
			try
			{
				@char = (Char)vCharInMap.elementAt(i);
				if (@char.isNhanbanz())
				{
					continue;
				}
			}
			catch (Exception)
			{
			}
			if (@char != null)
			{
				if (indexRow == i)
				{
					g.setColor(Paint.COLORLIGHT);
					g.fillRect(xstart + 2, ystart + indexRow * indexSize + 2, popupW - 15, indexSize - 4);
					g.setColor(16777215);
					g.drawRect(xstart + 2, ystart + indexRow * indexSize + 2, popupW - 15, indexSize - 4);
				}
				else
				{
					g.setColor(Paint.COLORBACKGROUND);
					g.fillRect(xstart + 2, ystart + i * indexSize + 2, popupW - 15, indexSize - 4);
					g.setColor(13932896);
					g.drawRect(xstart + 2, ystart + i * indexSize + 2, popupW - 15, indexSize - 4);
				}
				SmallImage.drawSmallImage(g, 647, xstart + 12, ystart + i * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				if (cLastFocusID > 0 && cLastFocusID == @char.charID)
				{
					mFont.tahoma_7_yellow.drawString(g, @char.cName + " - " + mResources.level + ": " + @char.clevel, xstart + 22, ystart + i * indexSize + indexSize / 2 - 6, 0);
				}
				else if (@char.statusMe == 14)
				{
					mFont.tahoma_7_grey.drawString(g, @char.cName + " - " + mResources.level + ": " + @char.clevel, xstart + 22, ystart + i * indexSize + indexSize / 2 - 6, 0);
				}
				else
				{
					mFont.tahoma_7_green.drawString(g, @char.cName + " - " + mResources.level + ": " + @char.clevel, xstart + 22, ystart + i * indexSize + indexSize / 2 - 6, 0);
				}
			}
		}
		paintNumCount(g);
	}

	private void paintFoodEffect(mGraphics g)
	{
		try
		{
			int num = (int)(mSystem.getCurrentTimeMillis() / 1000);
			int num2 = 5;
			if (GameCanvas.isTouch && GameCanvas.isTouchControl)
			{
				num2 = 45 + Info.hI;
			}
			if (GameCanvas.isTouchControlSmallScreen && Char.getMyChar().vSkillFight.size() > 4)
			{
				num2 += 25;
			}
			resetTranslate(g);
			if (vParty.size() <= 0 || GameCanvas.w <= 128 || isPaintUI())
			{
				return;
			}
			num2 -= 18;
			for (int i = 0; i < vParty.size(); i++)
			{
				Party party = (Party)vParty.elementAt(i);
				if (party.c != null)
				{
					mFont.tahoma_7_white.drawString(g, party.name + "(" + party.c.clevel + ")", GameCanvas.w - 14, num2 += 18, 1, mFont.tahoma_7_grey);
					party.c.paintHp(g, GameCanvas.w - 41, num2 + 12);
					SmallImage.drawSmallImage(g, party.iconId, GameCanvas.w - 7, num2 + 9, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				}
				else
				{
					num2 += 16;
					mFont.tahoma_7_green.drawString(g, party.name, GameCanvas.w - 14, num2 + 5, 1, mFont.tahoma_7_grey);
					SmallImage.drawSmallImage(g, party.iconId, GameCanvas.w - 7, num2 + 11, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private void paintWaypointArrow(mGraphics g)
	{
		int num = 10;
		for (int i = 0; i < TileMap.vGo.size(); i++)
		{
			Waypoint waypoint = (Waypoint)TileMap.vGo.elementAt(i);
			if (waypoint.minY == 0 || waypoint.maxY >= TileMap.pxh - 24)
			{
				if (waypoint.maxY <= TileMap.pxh / 2)
				{
					int x = waypoint.minX + (waypoint.maxX - waypoint.minX) / 2;
					int y = waypoint.minY + (waypoint.maxY - waypoint.minY) / 2 + runArrow;
					if (GameCanvas.isTouch)
					{
						y = waypoint.maxY + (waypoint.maxY - waypoint.minY) + runArrow + num;
					}
					SmallImage.drawSmallImage(g, 1213, x, y, 6, StaticObj.VCENTER_HCENTER);
				}
				else if (waypoint.minY >= TileMap.pxh / 2)
				{
					SmallImage.drawSmallImage(g, 1213, waypoint.minX + (waypoint.maxX - waypoint.minX) / 2, waypoint.minY - 12 - runArrow, 4, StaticObj.VCENTER_HCENTER);
				}
			}
			else if (waypoint.maxX <= TileMap.pxw / 2)
			{
				if (!GameCanvas.isTouch)
				{
					SmallImage.drawSmallImage(g, 1213, waypoint.maxX + 12 + runArrow, waypoint.maxY - 12, 2, StaticObj.VCENTER_HCENTER);
				}
				else
				{
					SmallImage.drawSmallImage(g, 1213, waypoint.maxX + 12 + runArrow, waypoint.maxY - 32, 2, StaticObj.VCENTER_HCENTER);
				}
			}
			else if (waypoint.minX >= TileMap.pxw / 2)
			{
				if (!GameCanvas.isTouch)
				{
					SmallImage.drawSmallImage(g, 1213, waypoint.minX - 12 - runArrow, waypoint.maxY - 12, 0, StaticObj.VCENTER_HCENTER);
				}
				else
				{
					SmallImage.drawSmallImage(g, 1213, waypoint.minX - 12 - runArrow, waypoint.maxY - 32, 0, StaticObj.VCENTER_HCENTER);
				}
			}
		}
	}

	private void paintArrowPointToNPC(mGraphics g)
	{
		try
		{
			int taskNpcId = getTaskNpcId();
			if (taskNpcId == -1)
			{
				return;
			}
			Npc npc = null;
			for (int i = 0; i < vNpc.size(); i++)
			{
				Npc npc2 = (Npc)vNpc.elementAt(i);
				if (npc2.template.npcTemplateId == taskNpcId)
				{
					if (npc == null)
					{
						npc = npc2;
					}
					else if (Res.abs(npc2.cx - Char.getMyChar().cx) < Res.abs(npc.cx - Char.getMyChar().cx))
					{
						npc = npc2;
					}
				}
			}
			if (npc == null || npc.statusMe == 15 || (npc.cx > cmx - 40 && npc.cx < cmx - 40 + gW && npc.cy > cmy && npc.cy < cmy + gH) || GameCanvas.gameTick % 10 < 5)
			{
				return;
			}
			int num = npc.cx - Char.getMyChar().cx;
			int num2 = npc.cy - Char.getMyChar().cy;
			int x = 0;
			int y = 0;
			int transform = 0;
			if (num > 0 && num2 >= 0)
			{
				if (Res.abs(num) >= Res.abs(num2))
				{
					x = gW - 10;
					y = gH / 2 + 30;
					if (GameCanvas.isTouch)
					{
						y = gH / 2 + 10;
					}
					transform = 0;
				}
				else
				{
					x = gW / 2;
					y = gH - 10;
					transform = 5;
				}
			}
			else if (num >= 0 && num2 < 0)
			{
				if (Res.abs(num) >= Res.abs(num2))
				{
					x = gW - 10;
					y = gH / 2 + 30;
					if (GameCanvas.isTouch)
					{
						y = gH / 2 + 10;
					}
					transform = 0;
				}
				else
				{
					x = gW / 2;
					y = 10;
					transform = 6;
				}
			}
			if (num < 0 && num2 >= 0)
			{
				if (Res.abs(num) >= Res.abs(num2))
				{
					x = 10;
					y = gH / 2 + 30;
					if (GameCanvas.isTouch)
					{
						y = gH / 2 + 10;
					}
					transform = 3;
				}
				else
				{
					x = gW / 2;
					y = gH - 10;
					transform = 5;
				}
			}
			else if (num <= 0 && num2 < 0)
			{
				if (Res.abs(num) >= Res.abs(num2))
				{
					x = 10;
					y = gH / 2 + 30;
					if (GameCanvas.isTouch)
					{
						y = gH / 2 + 10;
					}
					transform = 3;
				}
				else
				{
					x = gW / 2;
					y = 10;
					transform = 6;
				}
			}
			resetTranslate(g);
			SmallImage.drawSmallImage(g, 992, x, y, transform, StaticObj.VCENTER_HCENTER);
		}
		catch (Exception)
		{
		}
	}

	public static void resetTranslate(mGraphics g)
	{
		g.translate(-g.getTranslateX(), -g.getTranslateY());
		g.setClip(0, -200, GameCanvas.w, 200 + GameCanvas.h);
	}

	private void paintDebugInfo(mGraphics g)
	{
		int num = 0;
		try
		{
			if (GameCanvas.menu.showMenu || InfoDlg.isShow || isPaintPopup())
			{
				return;
			}
			int num2 = -7;
			if (GameCanvas.isTouch)
			{
				num2 = ((!GameCanvas.isKiemduyet) ? (-7) : 16);
			}
			int num3 = 3;
			num = 1;
			if ((!GameCanvas.isTouch || (GameCanvas.isTouch && !GameCanvas.isTouchControl)) && isPaintSelectSkill)
			{
				num3 += 30;
			}
			if (GameCanvas.isTouch)
			{
				num2 += 45 + Info.hI;
				if (GameCanvas.isTouchControlSmallScreen)
				{
					num2 += 35;
				}
			}
			g.translate(-g.getTranslateX(), -g.getTranslateY());
			if (GameCanvas.isTouchControlLargeScreen)
			{
				int num4 = (int)(mSystem.getCurrentTimeMillis() / 1000);
				int num5 = 13;
				int num6;
				for (int i = 0; i < Char.getMyChar().vEff.size(); i++)
				{
					Effect effect = (Effect)Char.getMyChar().vEff.elementAt(i);
					SmallImage.drawSmallImage(g, effect.template.iconId, num3 + num5 + i * num5 * 2, num2 + 27, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
					num6 = effect.timeLenght - (num4 - effect.timeStart);
					if (num6 >= 0)
					{
						mFont.tahoma_7_white.drawString(g, NinjaUtil.getTime(num6), num3 + num5 + i * num5 * 2, num2 + 28, mFont.CENTER, mFont.tahoma_7_grey);
					}
				}
				num6 = timeLengthMap - (num4 - timeStartMap);
				if (Char.getMyChar().vEff.size() > 0)
				{
					num2 += 27;
				}
				if (num6 > 0)
				{
					mFont.tahoma_7_white.drawString(g, mResources.TIME + NinjaUtil.getTime(num6), num3, num2 += 12, 0, mFont.tahoma_7_grey);
				}
			}
			if (Char.getMyChar().clevel <= 20)
			{
				if (Char.getMyChar().pPoint > 0)
				{
					string st = "+" + Char.getMyChar().pPoint + mResources.POTENIAL;
					mFont.tahoma_7_yellow.drawString(g, st, num3, num2 += 12, 0, mFont.tahoma_7_grey);
				}
				if (Char.getMyChar().sPoint > 0)
				{
					string st2 = "+" + Char.getMyChar().sPoint + mResources.SKILL_PT;
					mFont.tahoma_7_yellow.drawString(g, st2, num3, num2 += 12, 0, mFont.tahoma_7_grey);
				}
			}
			if (ChatManager.gI().waitList.size() > 0)
			{
				xM[0] = num3;
				yM[0] = num2 + 12;
				string st3 = "+" + ChatManager.gI().waitList.size() + " " + mResources.private_message;
				if (GameCanvas.gameTick % 10 > 4)
				{
					mFont.tahoma_7_red.drawString(g, st3, num3, num2 += 12, 0, mFont.tahoma_7_grey);
				}
				else
				{
					mFont.tahoma_7_yellow.drawString(g, st3, num3, num2 += 12, 0, mFont.tahoma_7_grey);
				}
			}
			if (ChatManager.isMessageClan || ChatManager.isMessagePt)
			{
				string st4 = string.Empty;
				xM[0] = num3;
				yM[0] = num2 + 12;
				if (ChatManager.isMessageClan && ChatManager.isMessagePt)
				{
					st4 = mResources.CLANPT_MESSAGE[0];
				}
				else if (ChatManager.isMessageClan)
				{
					st4 = mResources.CLANPT_MESSAGE[1];
				}
				else if (ChatManager.isMessagePt)
				{
					st4 = mResources.CLANPT_MESSAGE[2];
				}
				if (GameCanvas.gameTick % 10 > 7)
				{
					mFont.tahoma_7_red.drawString(g, st4, num3, num2 += 12, 0, mFont.tahoma_7_grey);
				}
				else
				{
					mFont.tahoma_7_yellow.drawString(g, st4, num3, num2 += 12, 0, mFont.tahoma_7_grey);
				}
			}
			if (TileMap.typeMap != TileMap.MAP_CHIENTRUONG)
			{
				num = 2;
				if (Char.getMyChar().isHumanz())
				{
					if (Char.getMyChar().taskMaint != null)
					{
						string text = Char.getMyChar().taskMaint.subNames[Char.getMyChar().taskMaint.index];
						int num7 = 0;
						while (text == null)
						{
							num7++;
							text = Char.getMyChar().taskMaint.subNames[Char.getMyChar().taskMaint.index - num7];
						}
						if (Char.getMyChar().taskMaint.counts[Char.getMyChar().taskMaint.index] != -1)
						{
							string text2 = text;
							text = text2 + " " + Char.getMyChar().taskMaint.count + "/" + Char.getMyChar().taskMaint.counts[Char.getMyChar().taskMaint.index];
						}
						if (GameCanvas.taskTick > 0 && GameCanvas.gameTick % 10 > 4)
						{
							mFont.tahoma_7_yellow.drawString(g, text, num3, num2 += 12, 0, mFont.tahoma_7_grey);
						}
						else
						{
							mFont.tahoma_7_white.drawString(g, text, num3, num2 += 12, 0, mFont.tahoma_7_grey);
						}
					}
					else
					{
						sbyte taskMapId = getTaskMapId();
						if (taskMapId >= 0)
						{
							mFont.tahoma_7_white.drawString(g, mResources.TASK_RECEIVE + " " + TileMap.mapNames[taskMapId], num3, num2 += 12, 0, mFont.tahoma_7_grey);
						}
					}
				}
			}
			else if (Char.getMyChar().charFocus != null)
			{
				if (Char.getMyChar().charFocus.cTypePk == Char.PK_PHE1)
				{
					mFont.tahoma_7_white.drawString(g, mResources.WHITE_PARTY, num3, num2 += 12, 0, mFont.tahoma_7_grey);
				}
				else if (Char.getMyChar().charFocus.cTypePk == Char.PK_PHE2)
				{
					mFont.tahoma_7_white.drawString(g, mResources.BLACK_PARTY, num3, num2 += 12, 0, mFont.tahoma_7_grey);
				}
				else if (Char.getMyChar().charFocus.cTypePk == Char.PK_PHE3)
				{
					mFont.tahoma_7_white.drawString(g, mResources.PHE3_PARTY, num3, num2 += 12, 0, mFont.tahoma_7_grey);
				}
			}
			else if (Char.getMyChar().mobFocus != null)
			{
				if (Char.getMyChar().mobFocus.templateId == 96)
				{
					mFont.tahoma_7_white.drawString(g, mResources.BLACK_PARTY, num3, num2 += 12, 0, mFont.tahoma_7_grey);
				}
				else if (Char.getMyChar().mobFocus.templateId == 97)
				{
					mFont.tahoma_7_white.drawString(g, mResources.WHITE_PARTY, num3, num2 += 12, 0, mFont.tahoma_7_grey);
				}
				else if (Char.getMyChar().mobFocus.templateId == 93)
				{
					mFont.tahoma_7_white.drawString(g, mResources.PHE3_PARTY, num3, num2 += 12, 0, mFont.tahoma_7_grey);
				}
				else
				{
					mFont.tahoma_7_white.drawString(g, mResources.NEUTRAL, num3, num2 += 12, 0, mFont.tahoma_7_grey);
				}
			}
			num = 3;
			if (Char.getMyChar().mobFocus != null)
			{
				num = 4;
				MobTemplate template = Char.getMyChar().mobFocus.getTemplate();
				string text3 = template.name + " lv" + Char.getMyChar().mobFocus.level;
				if (Char.getMyChar().mobFocus.templateId != 0 && Char.getMyChar().mobFocus.templateId != 142 && Char.getMyChar().mobFocus.templateId != 143)
				{
					string text4 = text3;
					text3 = text4 + ": " + Char.getMyChar().mobFocus.hp + "/" + Char.getMyChar().mobFocus.maxHp;
				}
				g.setColor(Char.getMyChar().mobFocus.getHPColor());
				num2 += 12;
				g.fillRect(num3, num2 + 5, 5, 5);
				g.setColor(0);
				g.drawRect(num3, num2 + 5, 5, 5);
				mFont.tahoma_7_white.drawString(g, text3, num3 + 12, num2, 0, mFont.tahoma_7_grey);
			}
			else if (Char.getMyChar().npcFocus != null)
			{
				num = 5;
				mFont.tahoma_7_yellow.drawString(g, Char.getMyChar().npcFocus.template.name, num3, num2 += 12, 0, mFont.tahoma_7_grey);
			}
			else if (Char.getMyChar().charFocus != null)
			{
				num = 6;
				g.setColor(Char.getMyChar().charFocus.getClassColor());
				num2 += 12;
				g.fillRect(num3, num2 + 5, 5, 5);
				g.setColor(0);
				g.drawRect(num3, num2 + 5, 5, 5);
				mFont.tahoma_7_white.drawString(g, Char.getMyChar().charFocus.cName + " lv" + Char.getMyChar().charFocus.clevel + ": " + Char.getMyChar().charFocus.cHP + "/" + Char.getMyChar().charFocus.cMaxHP, num3 + 12, num2, 0, mFont.tahoma_7_grey);
			}
			if (TileMap.typeMap == TileMap.MAP_DAUTRUONG)
			{
				mFont.tahoma_7_white.drawString(g, mResources.ACHIEVEMENT + ": " + Char.getMyChar().countKill, num3, num2 += 12, 0, mFont.tahoma_7_grey);
				mFont.tahoma_7_white.drawString(g, mResources.MAX + ": " + Char.getMyChar().countKillMax, num3, num2 += 12, 0, mFont.tahoma_7_grey);
			}
			else if (TileMap.typeMap == TileMap.MAP_PB || TileMap.mapID == 114 || TileMap.mapID == 115 || TileMap.mapID == 116)
			{
				mFont.tahoma_7_white.drawString(g, mResources.PROPERTY + ": " + Char.pointPB, num3, num2 += 12, 0, mFont.tahoma_7_grey);
			}
			else if (TileMap.typeMap == TileMap.MAP_CHIENTRUONG)
			{
				mFont.tahoma_7_white.drawString(g, mResources.PROPERTY + ": " + Char.pointChienTruong, num3, num2 += 12, 0, mFont.tahoma_7_grey);
				mFont.tahoma_7_white.drawString(g, mResources.TITLE_CT[Char.getCT()], num3, num2 += 12, 0, mFont.tahoma_7_grey);
			}
			g.translate(-g.getTranslateX(), -g.getTranslateY());
		}
		catch (Exception)
		{
			Out.println("paintDebugInfo: line " + num);
		}
	}

	private void paintTouchControl(mGraphics g)
	{
		if (!GameCanvas.isTouch || (GameCanvas.menu.showMenu && GameCanvas.isTouchControlSmallScreen) || GameCanvas.currentDialog != null || ChatPopup.currentMultilineChatPopup != null || GameCanvas.menu.showMenu || isPaintPopup())
		{
			return;
		}
		resetTranslate(g);
		if (!ChatTextField.gI().isShow)
		{
			g.drawImage(imgChat, xC + 17, yC + 17, mGraphics.HCENTER | mGraphics.VCENTER);
		}
		if (isNotPaintTouchControl())
		{
			return;
		}
		if (Main.isPC)
		{
			if (!ChatTextField.gI().isShow)
			{
				mFont.numberb_white.drawString(g, (!GameCanvas.isChangMapKey) ? "O" : "1", xC + 17, yC - imgChat.getHeight() / 2 - mFont.numberb_white.getHeight() + 16, 0);
			}
			if (menu != null)
			{
				mFont.tahoma_7b_white.drawString(g, "F1", menu.x + 14, menu.y - mFont.tahoma_7b_white.getHeight() - 1, 2, mFont.tahoma_7_grey);
			}
		}
		if (!Main.isPC)
		{
			if (!isTouchKey)
			{
				gamePad.paint(g);
			}
			else
			{
				g.drawImage(imgButton, xL, yL, 0);
				g.drawRegion(imgArrow, 0, 0, mGraphics.getImageWidth(imgArrow), mGraphics.getImageHeight(imgArrow), 2, xL + 15, yL + 16, mGraphics.HCENTER | mGraphics.VCENTER);
				if (mScreen.keyTouch == 4)
				{
					g.drawImage(imgButton2, xL, yL, 0);
					g.drawRegion(imgArrow2, 0, 0, mGraphics.getImageWidth(imgArrow), mGraphics.getImageHeight(imgArrow), 2, xL + 15, yL + 16, mGraphics.HCENTER | mGraphics.VCENTER);
				}
				g.drawImage(imgButton, xR, yR, 0);
				g.drawRegion(imgArrow, 0, 0, mGraphics.getImageWidth(imgArrow), mGraphics.getImageHeight(imgArrow), 0, xR + 17, yR + 16, mGraphics.HCENTER | mGraphics.VCENTER);
				if (mScreen.keyTouch == 6)
				{
					g.drawImage(imgButton2, xR, yR, 0);
					g.drawRegion(imgArrow2, 0, 0, mGraphics.getImageWidth(imgArrow), mGraphics.getImageHeight(imgArrow), 0, xR + 17, yR + 16, mGraphics.HCENTER | mGraphics.VCENTER);
				}
				g.drawImage(imgButton, xU, yU, 0);
				g.drawRegion(imgArrow, 0, 0, mGraphics.getImageWidth(imgArrow), mGraphics.getImageHeight(imgArrow), 7, xU + 17, yU + 14, mGraphics.HCENTER | mGraphics.VCENTER);
				if (mScreen.keyTouch == 3)
				{
					g.drawImage(imgButton2, xU, yU, 0);
					g.drawRegion(imgArrow2, 0, 0, mGraphics.getImageWidth(imgArrow), mGraphics.getImageHeight(imgArrow), 7, xU + 17, yU + 14, mGraphics.HCENTER | mGraphics.VCENTER);
				}
			}
			if (Char.getMyChar().ctaskId > 1)
			{
				g.drawImage(imgButton, xTG, yTG, 0);
				if (mScreen.keyTouch == 13)
				{
					g.drawImage(imgButton2, xTG, yTG, 0);
				}
				g.drawImage(imgFocus, xTG + 16, yTG + 16, mGraphics.HCENTER | mGraphics.VCENTER);
			}
			g.drawImage(imgRight, xF, yF, 0);
			if (mScreen.keyTouch == 5)
			{
				g.drawImage(imgRight2, xF, yF, 0);
			}
		}
		if (isPcLevelSmall())
		{
			g.drawImage(imgButton, xHP, yHP, 0);
			if (mScreen.keyTouch == 10)
			{
				g.drawImage(imgButton2, xHP, yHP, 0);
			}
			g.drawImage(imgHpp, xHP + 17, yHP + 15, mGraphics.HCENTER | mGraphics.VCENTER);
			if (Main.isPC)
			{
				mFont.numberb_white.drawString(g, (!GameCanvas.isChangMapKey) ? "6" : "-", xHP + imgButton.getWidth() / 2, yHP - mFont.numberb_white.getHeight() - 1, 0);
			}
			mFont.number_white.drawString(g, string.Empty + hpPotion, xHP + 30, yHP + 22, 1);
			g.drawImage(imgButton, xMP, yMP, 0);
			if (mScreen.keyTouch == 11)
			{
				g.drawImage(imgButton2, xMP, yMP, 0);
			}
			g.drawImage(imgMpp, xMP + 17, yMP + 15, mGraphics.HCENTER | mGraphics.VCENTER);
			if (Main.isPC)
			{
				mFont.numberb_white.drawString(g, (!GameCanvas.isChangMapKey) ? "7" : "+", xMP + imgButton.getWidth() / 2, yHP - mFont.numberb_white.getHeight() - 1, 0);
			}
			mFont.number_white.drawString(g, string.Empty + mpPotion, xMP + 30, yMP + 22, 1);
		}
	}

	public bool isPcLevelSmall()
	{
		if (Main.isPC)
		{
			return true;
		}
		if (Char.getMyChar().ctaskId > 1)
		{
			return true;
		}
		return false;
	}

	private void paintInfoBar(mGraphics g)
	{
		if (GameCanvas.isTouch)
		{
			resetTranslate(g);
			loadInforBar();
			int num = Char.getMyChar().cHP * hpBarW / Char.getMyChar().cMaxHP;
			int w = Char.getMyChar().cMP * mpBarW / Char.getMyChar().cMaxMP;
			int w2 = (int)(Char.getMyChar().cExpR * expBarW / exps[Char.getMyChar().clevel]);
			if (num > hpBarW)
			{
				num = 0;
			}
			g.setColor(6191872);
			g.fillRect(0, hpBarY - 10, expBarW, 3);
			g.setColor(6350080);
			g.fillRect(0, hpBarY - 10, w2, 3);
			g.setColor(7020544);
			g.fillRect(0, hpBarY - 10, expBarW, 1);
			g.fillRect(0, hpBarY - 7, expBarW, 1);
			for (int i = 0; i < 10; i++)
			{
				g.fillRect(i * expBarW / 10 - 1, hpBarY - 10, 1, 3);
			}
			g.setColor(0, 0.8f);
			g.fillRect(hpBarX - 1, hpBarY, wColoerMp, hColorMp);
			g.setColor(15007764);
			g.fillRect(hpBarX, hpBarY, num, 9);
			g.setColor(0, 0.8f);
			g.fillRect(hpBarX - 28, hpBarY + 13, wColoerMp, hColorMp);
			g.setColor(21989);
			g.fillRect(hpBarX, hpBarY + 16, w, 7);
			g.drawImage(imgTopBar, 0, hpBarY - 7, 0);
			mFont.number_white.drawString(g, string.Empty + Char.getMyChar().cHP, hpBarX + hpBarW / 2 - 30, hpBarY + 1, 0);
			mFont.number_white.drawString(g, string.Empty + Char.getMyChar().cMP, hpBarX + hpBarW / 2 - 30, hpBarY + 16, 0);
			mFont.bigNumber_yellow.drawString(g, string.Empty + Char.getMyChar().clevel, hpBarX - 25, hpBarY + 1, 2);
			long num2 = 0L;
			num2 = ((Char.getMyChar().cExpDown <= 0) ? (Char.getMyChar().cExpR * 10000 / exps[Char.getMyChar().clevel]) : (Char.getMyChar().cExpDown * 10000 / exps[Char.getMyChar().clevel]));
			int num3 = (int)(num2 % 100);
			mFont.number_white.drawString(g, ((Char.getMyChar().cExpDown <= 0) ? (string.Empty + num2 / 100) : ("-" + num2 / 100)) + "." + ((num3 >= 10) ? (string.Empty + num3) : ("0" + num3)) + "%", hpBarX - 25, hpBarY + 20, 2);
		}
	}

	private void paintSelectedSkill(mGraphics g)
	{
		if (GameCanvas.currentDialog != null || ChatPopup.currentMultilineChatPopup != null || GameCanvas.menu.showMenu || isPaintPopup() || center == cmdDead || (GameCanvas.isTouch && Char.getMyChar().vSkill.size() < 2) || !isPaintSelectSkill)
		{
			return;
		}
		for (int i = 0; i < onScreenSkill.Length; i++)
		{
			if (GameCanvas.isTouchControlSmallScreen)
			{
				if (Info.hI > 0)
				{
					yS[i] = 55 + Info.hI;
				}
				else
				{
					yS[i] = 55;
				}
			}
			if (GameCanvas.isTouch && GameCanvas.isTouchControl)
			{
				g.drawImage(imgSkill, xSkill + xS[i] - 1, yS[i] - 1, 0);
			}
			else
			{
				g.setColor(16764040);
				g.drawRect(xSkill + xS[i] - 1, yS[i] - 1, 25, 25);
			}
			Skill skill = onScreenSkill[i];
			if (i == selectedIndexSkill && !isPaintUI() && GameCanvas.gameTick % 10 > 5)
			{
				g.setColor(16777215);
				g.fillRect(xSkill + xS[i] + 1, yS[i] + 1, 22, 22);
			}
			else if (!GameCanvas.isTouch)
			{
				g.setColor(0);
				g.fillRect(xSkill + xS[i], yS[i], 24, 24);
			}
			if (skill == null)
			{
				continue;
			}
			if (skill == Char.getMyChar().myskill)
			{
				g.setColor(16711680);
				g.drawRect(xSkill + xS[i] + 2, yS[i] + 2, 19, 19);
			}
			skill.paint(xSkill + xS[i] + 12, yS[i] + 12, g);
			if (Main.isPC)
			{
				int num = i + ((!GameCanvas.isChangMapKey) ? 1 : 6);
				if (num >= 10)
				{
					num = 0;
				}
				mFont.numberb_white.drawString(g, num + string.Empty, xSkill + xS[i] + 11, yS[i] - mFont.numberb_white.getHeight() - 2, 0);
			}
		}
	}

	public void paintOpen(mGraphics g)
	{
		if (isstarOpen)
		{
			g.translate(-g.getTranslateX(), -g.getTranslateY());
			g.fillRect(0, 0, GameCanvas.w, moveUp);
			g.setColor(10275899);
			g.fillRect(0, moveUp - 1, GameCanvas.w, 1);
			g.fillRect(0, moveDow + 1, GameCanvas.w, 1);
		}
	}

	public static void startFlyText(string flyString, int x, int y, int dx, int dy, int color)
	{
		int num = -1;
		for (int i = 0; i < 5; i++)
		{
			if (flyTextState[i] == -1)
			{
				num = i;
				break;
			}
		}
		if (num != -1)
		{
			flyTextColor[num] = color;
			flyTextString[num] = flyString;
			flyTextX[num] = x;
			flyTextY[num] = y;
			flyTextDx[num] = dx;
			flyTextDy[num] = dy;
			flyTextState[num] = 0;
		}
	}

	public static void updateFlyText()
	{
		for (int i = 0; i < 5; i++)
		{
			if (flyTextState[i] != -1)
			{
				flyTextState[i] += Res.abs(flyTextDy[i]);
				if (flyTextState[i] > 30)
				{
					flyTextState[i] = -1;
				}
				flyTextX[i] += flyTextDx[i];
				flyTextY[i] += flyTextDy[i];
			}
		}
	}

	public static void paintFlyText(mGraphics g)
	{
		for (int i = 0; i < 5; i++)
		{
			if (flyTextState[i] != -1 && GameCanvas.isPaint(flyTextX[i], flyTextY[i]))
			{
				if (flyTextColor[i] == mFont.RED)
				{
					mFont.bigNumber_red.drawString(g, flyTextString[i], flyTextX[i], flyTextY[i], mFont.CENTER);
				}
				else if (flyTextColor[i] == mFont.YELLOW)
				{
					mFont.bigNumber_yellow.drawString(g, flyTextString[i], flyTextX[i], flyTextY[i], mFont.CENTER);
				}
				else if (flyTextColor[i] == mFont.GREEN)
				{
					mFont.bigNumber_green.drawString(g, flyTextString[i], flyTextX[i], flyTextY[i], mFont.CENTER);
				}
				else if (flyTextColor[i] == mFont.FATAL)
				{
					mFont.bigNumber_red.drawString(g, flyTextString[i], flyTextX[i], flyTextY[i], mFont.CENTER);
				}
				else if (flyTextColor[i] == mFont.FATAL_ME)
				{
					mFont.bigNumber_While.drawString(g, flyTextString[i], flyTextX[i], flyTextY[i], mFont.CENTER, mFont.numberb_red);
				}
				else if (flyTextColor[i] == mFont.MISS)
				{
					mFont.bigNumber_blue.drawString(g, "Né", flyTextX[i], flyTextY[i], mFont.CENTER);
				}
				else if (flyTextColor[i] == mFont.ORANGE)
				{
					mFont.bigNumber_orange.drawString(g, flyTextString[i], flyTextX[i], flyTextY[i], mFont.CENTER);
				}
				else if (flyTextColor[i] == mFont.ADDMONEY)
				{
					mFont.tahoma_7_yellow.drawString(g, flyTextString[i], flyTextX[i], flyTextY[i], mFont.CENTER, mFont.tahoma_7_red);
				}
				else if (flyTextColor[i] == mFont.MISS_ME)
				{
					mFont.bigNumber_red.drawString(g, "Né", flyTextX[i], flyTextY[i], mFont.CENTER);
				}
			}
		}
	}

	public static void startLanterns(int x, int y)
	{
		vLanterns.addElement(new Lanterns(x, y));
	}

	public static void paintLanterns(mGraphics g)
	{
		for (int i = 0; i < vLanterns.size(); i++)
		{
			((Lanterns)vLanterns.elementAt(i)).paint(g);
		}
	}

	public static void updateLanterns()
	{
		for (int i = 0; i < vLanterns.size(); i++)
		{
			((Lanterns)vLanterns.elementAt(i)).update();
			if (((Lanterns)vLanterns.elementAt(i)).isEnd)
			{
				vLanterns.removeElementAt(i);
			}
		}
	}

	public static void loadSplash()
	{
		if (imgSplash == null)
		{
			imgSplash = new Image[3];
			for (int i = 0; i < 3; i++)
			{
				imgSplash[i] = GameCanvas.loadImage("/e/sp" + i + string.Empty);
			}
		}
		splashX = new int[2];
		splashY = new int[2];
		splashState = new int[2];
		splashF = new int[2];
		splashDir = new int[2];
		splashState[0] = (splashState[1] = -1);
	}

	public static bool startSplash(int x, int y, int dir)
	{
		int num = ((splashState[0] != -1) ? 1 : 0);
		if (splashState[num] != -1)
		{
			return false;
		}
		splashState[num] = 0;
		splashDir[num] = dir;
		splashX[num] = x;
		splashY[num] = y;
		return true;
	}

	public static void updateSplash()
	{
		for (int i = 0; i < 2; i++)
		{
			if (splashState[i] != -1)
			{
				splashState[i]++;
				splashX[i] += splashDir[i] << 2;
				splashY[i]--;
				if (splashState[i] >= 6)
				{
					splashState[i] = -1;
				}
				else
				{
					splashF[i] = (splashState[i] >> 1) % 3;
				}
			}
		}
	}

	public static void paintSplash(mGraphics g)
	{
		for (int i = 0; i < 2; i++)
		{
			if (splashState[i] != -1)
			{
				if (splashDir[i] == 1)
				{
					g.drawImage(imgSplash[splashF[i]], splashX[i], splashY[i], 3);
				}
				else
				{
					g.drawRegion(imgSplash[splashF[i]], 0, 0, mGraphics.getImageWidth(imgSplash[splashF[i]]), mGraphics.getImageHeight(imgSplash[splashF[i]]), 2, splashX[i], splashY[i], 3);
				}
			}
		}
	}

	public void loadCmdBar()
	{
		hpBarX = 63;
		hpBarY = cmdBarY + 7;
		hpBarW = gW - 84 - 30 + 15;
		expBarW = gW - 44 - 4;
		hpBarH = 5;
		if (GameCanvas.w > 176)
		{
			hpBarW -= 50;
			expBarW -= 50;
			hpBarX += 15;
			hpBarW -= 15;
		}
		loadInforBar();
	}

	private void loadInforBar()
	{
		if (GameCanvas.isTouch)
		{
			hpBarW = 82;
			mpBarW = 57;
			hpBarX = 52;
			hpBarY = ((!GameCanvas.isKiemduyet) ? (10 + Info.hI) : 25);
			expBarW = gW - 61;
			if (!Main.isPC)
			{
				menu.y = 6 + Info.hI;
				xC = gW - 100;
				yC = 2 + Info.hI;
			}
			else
			{
				xC = 40;
				yC = yHP + 2;
				menu.y = yHP + 6;
				menu.x = 8;
			}
			TileMap.setPosMiniMap(GameCanvas.w - 60, (!GameCanvas.isKiemduyet) ? Info.hI : 16, 60, 42);
		}
	}

	public void paintTrangbi(mGraphics g)
	{
		if (indexMenu != 4)
		{
			return;
		}
		g.translate(-g.getTranslateX(), -g.getTranslateY());
		GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
		g.setColor(Paint.COLORBACKGROUND);
		paintTitle(g, mResources.MENUME[indexMenu], arrow: true);
		if (currentCharViewInfo.arrItemBody == null)
		{
			GameCanvas.paintShukiren(popupX + 90, popupY + 75, g, noRotate: false);
			mFont.tahoma_7b_white.drawString(g, mResources.PLEASEWAIT, popupX + popupW / 2, popupY + 90, 2);
			return;
		}
		g.setColor(13606712);
		g.drawRect(popupX + 33, popupY + ((!GameCanvas.isTouchControlLargeScreen) ? 34 : 87), popupW - 67, (!GameCanvas.isTouchControlLargeScreen) ? 128 : 76);
		int num = indexSize - 2;
		int num2 = 0;
		for (int i = 0; i < 16; i++)
		{
			switch (i)
			{
			case 0:
			case 2:
			case 4:
			case 6:
			case 8:
				g.setColor(0);
				g.fillRect(popupX + 4 + 1, popupY + 35 + i / 2 * num + 1, num - 1, num - 1);
				if (indextabTrangbi == 0)
				{
					if (mResources.ITEMNAME[i].Length > 1)
					{
						mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[i][0], popupX + 7 + 11, popupY + 36 + i / 2 * num + 2, 2);
						mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[i][1], popupX + 7 + 11, popupY + 36 + i / 2 * num + 2 + 9, 2);
					}
					else
					{
						mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[i][0], popupX + 7 + 11, popupY + 36 + i / 2 * num + 2 + 5, 2);
					}
				}
				continue;
			case 1:
			case 3:
			case 5:
			case 7:
			case 9:
				g.setColor(0);
				g.fillRect(popupX + popupW - num - 4, popupY + 35 + i / 2 * num + 1, num - 1, num - 1);
				if (indextabTrangbi == 0)
				{
					if (mResources.ITEMNAME[i].Length > 1)
					{
						mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[i][0], popupX + popupW - num / 2 - 4, popupY + 36 + i / 2 * num + 2, 2);
						mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[i][1], popupX + popupW - num / 2 - 4, popupY + 36 + i / 2 * num + 2 + 9, 2);
					}
					else
					{
						mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[i][0], popupX + popupW - num / 2 - 4, popupY + 36 + i / 2 * num + 2 + 5, 2);
					}
				}
				continue;
			}
			if (i != 9 && i != 10 && i != 11 && i != 12 && i != 13 && i != 14 && i != 15)
			{
				continue;
			}
			int num3 = popupX + 4 + 1 + num2 * (num + 2);
			int num4 = popupY + 35 + 5 * num + 1;
			g.setColor(0);
			g.fillRect(num3, popupY + 35 + 5 * num + 1, num - 1, num - 1);
			if (indextabTrangbi == 0)
			{
				if (mResources.ITEMNAME[i].Length > 1)
				{
					mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[i][0], num3 + num / 2, num4 + 2, 2);
					mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[i][1], num3 + num / 2, num4 + 2 + 9, 2);
				}
				else
				{
					mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[i][0], num3 + num / 2, num4 + 2 + 5, 2);
				}
			}
			num2++;
		}
		if (indextabTrangbi == 0)
		{
			for (int j = 0; j < 16; j++)
			{
				Item item = currentCharViewInfo.arrItemBody[j];
				if (item == null)
				{
					continue;
				}
				if (item.eff == null)
				{
					item.eff = efs[56];
				}
				if (item.indexUI == 0 || item.indexUI == 2 || item.indexUI == 4 || item.indexUI == 6 || item.indexUI == 8 || item.indexUI == 10)
				{
					int num5 = popupX + 4;
					int y = popupY + 34 + item.indexUI / 2 * num;
					paintItem(g, item, num5 - 1, y, 0, 1);
				}
				else if (item.indexUI == 1 || item.indexUI == 3 || item.indexUI == 5 || item.indexUI == 7 || item.indexUI == 9)
				{
					int num6 = popupX + popupW - num - 5;
					int num7 = popupY + 35 + item.indexUI / 2 * num;
					paintItem(g, item, num6 - 1, num7 - 1, 0, 1);
				}
				else if (item.indexUI == 11 || item.indexUI == 12 || item.indexUI == 13 || item.indexUI == 14 || item.indexUI == 15)
				{
					if (item.indexUI == 10)
					{
						num2 = 1;
					}
					else if (item.indexUI == 11)
					{
						num2 = 2;
					}
					else if (item.indexUI == 12)
					{
						num2 = 3;
					}
					else if (item.indexUI == 13)
					{
						num2 = 4;
					}
					else if (item.indexUI == 14)
					{
						num2 = 5;
					}
					else if (item.indexUI == 15)
					{
						num2 = 6;
					}
					int num8 = popupX + 2 + 1 + num2 * (num + 2) - num;
					int num9 = popupY + 35 + 5 * num;
					paintItem(g, item, num8 - 2, num9 - 1, 0, 1);
				}
				if (GameCanvas.gameTick % 4 == 0)
				{
					item.indexEff++;
					if (item.indexEff >= item.eff.arrEfInfo.Length)
					{
						item.indexEff = 0;
					}
				}
			}
		}
		if (indextabTrangbi > 0)
		{
			for (int k = 0; k < 16; k++)
			{
				Item item2 = currentCharViewInfo.arrItemBody[k + indextabTrangbi];
				if (item2 == null)
				{
					continue;
				}
				int num10 = item2.indexUI - 16;
				if (item2.eff == null)
				{
					item2.eff = efs[56];
				}
				switch (num10)
				{
				case 0:
				case 2:
				case 4:
				case 6:
				case 8:
				case 10:
				{
					int num13 = popupX + 4;
					int y2 = popupY + 34 + num10 / 2 * num;
					paintItem(g, item2, num13 - 1, y2, 0, 1);
					break;
				}
				case 1:
				case 3:
				case 5:
				case 7:
				case 9:
				{
					int num14 = popupX + popupW - num - 5;
					int num15 = popupY + 35 + num10 / 2 * num;
					paintItem(g, item2, num14 - 1, num15 - 1, 0, 1);
					break;
				}
				case 11:
				case 12:
				case 13:
				case 14:
				case 15:
				{
					switch (num10)
					{
					case 10:
						num2 = 1;
						break;
					case 11:
						num2 = 2;
						break;
					case 12:
						num2 = 3;
						break;
					case 13:
						num2 = 4;
						break;
					case 14:
						num2 = 5;
						break;
					case 15:
						num2 = 6;
						break;
					}
					int num11 = popupX + 2 + 1 + num2 * (num + 2) - num;
					int num12 = popupY + 35 + 5 * num;
					paintItem(g, item2, num11 - 2, num12 - 1, 0, 1);
					break;
				}
				}
				if (GameCanvas.gameTick % 4 == 0)
				{
					item2.indexEff++;
					if (item2.indexEff >= item2.eff.arrEfInfo.Length)
					{
						item2.indexEff = 0;
					}
				}
			}
		}
		for (int l = 0; l < 16; l++)
		{
			if (indexTitle != 1 || l != indexSelect)
			{
				continue;
			}
			switch (l)
			{
			case 0:
			case 2:
			case 4:
			case 6:
			case 8:
				g.setColor(16777215);
				g.drawRect(popupX + 4, popupY + 35 + l / 2 * num, num, num);
				paintSelectHighlight(popupX + 5 - 2, popupY + 35 + l / 2 * num - 1, g);
				continue;
			case 1:
			case 3:
			case 5:
			case 7:
			case 9:
				g.setColor(16777215);
				g.drawRect(popupX + popupW - num - 4 - 1, popupY + 35 + l / 2 * num, num, num);
				paintSelectHighlight(popupX + popupW - num - 4 - 2, popupY + 35 + l / 2 * num - 1, g);
				continue;
			}
			if (l == 9 || l == 10 || l == 11 || l == 12 || l == 13 || l == 14 || l == 15)
			{
				switch (l)
				{
				case 9:
					num2 = 0;
					break;
				case 10:
					num2 = 1;
					break;
				case 11:
					num2 = 2;
					break;
				case 12:
					num2 = 3;
					break;
				case 13:
					num2 = 4;
					break;
				case 14:
					num2 = 5;
					break;
				case 15:
					num2 = 6;
					break;
				}
				int num16 = popupX + 2 + 1 + num2 * (num + 2) - num;
				int num17 = popupY + 35 + 5 * num;
				g.setColor(16777215);
				g.drawRect(num16 - 1, num17, num, num);
				paintSelectHighlight(num16 - 2, num17 - 1, g);
			}
		}
		int num18 = ((!GameCanvas.isTouchControlLargeScreen) ? 16 : (-25));
		Part part = parts[currentCharViewInfo.head];
		Part part2 = parts[currentCharViewInfo.leg];
		Part part3 = parts[currentCharViewInfo.body];
		Part part4 = parts[currentCharViewInfo.wp];
		if (currentCharViewInfo.arrItemBody != null && currentCharViewInfo.arrItemBody[11] != null)
		{
			part = parts[currentCharViewInfo.arrItemBody[11].template.part];
		}
		if (part.pi == null || part.pi.Length < 8)
		{
			part = Char.getMyChar().getDefaultHead(Char.getMyChar().cgender);
		}
		else
		{
			for (int m = 0; m < part.pi.Length; m++)
			{
				if (part.pi[m] == null || !SmallImage.isExitsImage(part.pi[m].id))
				{
					part = Char.getMyChar().getDefaultHead(Char.getMyChar().cgender);
					break;
				}
			}
		}
		int[] classCoat = currentCharViewInfo.getClassCoat();
		int num19 = 13;
		int num20 = 24;
		int f = ((currentCharViewInfo.cp1 % 15 >= 5) ? 1 : 0);
		if (currentCharViewInfo.ID_WEA_PONE > -1)
		{
			currentCharViewInfo.paintWeaponUIBot(g, gW2, gH2 - num20, f);
		}
		if (currentCharViewInfo.ID_PP > -1)
		{
			currentCharViewInfo.paintPPUIBot(g, gW2, gH2 - num20, f);
		}
		if (classCoat != null && currentCharViewInfo.ID_PP == -1)
		{
			if (Char.getMyChar().tickCoat == 0)
			{
				SmallImage.drawSmallImage(g, classCoat[Char.getMyChar().tickCoat], gW2 + Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][0][1] + part.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][0][0]].dx - 2, gH2 + num18 - Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][0][2] + part.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][0][0]].dy + 16, 0, 0);
			}
			else if (Char.getMyChar().tickCoat == 1)
			{
				SmallImage.drawSmallImage(g, classCoat[Char.getMyChar().tickCoat], gW2 + Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][0][1] + part.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][0][0]].dx - 9, gH2 + num18 - Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][0][2] + part.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][0][0]].dy + 16, 0, 0);
			}
			else if (Char.getMyChar().tickCoat == 2)
			{
				SmallImage.drawSmallImage(g, classCoat[Char.getMyChar().tickCoat], gW2 + Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][0][1] + part.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][0][0]].dx - 12, gH2 + num18 - Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][0][2] + part.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][0][0]].dy + 16, 0, 0);
			}
			else
			{
				SmallImage.drawSmallImage(g, classCoat[Char.getMyChar().tickCoat], gW2 + Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][0][1] + part.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][0][0]].dx - 9, gH2 + num18 - Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][0][2] + part.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][0][0]].dy + 16, 0, 0);
			}
		}
		currentCharViewInfo.paintClanEffect(g, gW2 + Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][2][1] + part3.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][2][0]].dx + 18, gH2 + num18 - Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][1][2] + part2.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][1][0]].dy + 5);
		if (currentCharViewInfo.ID_WEA_PONE == -1)
		{
			SmallImage.drawSmallImage(g, part4.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][3][0]].id, gW2 + Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][3][1] + part4.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][3][0]].dx, gH2 + num18 - Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][3][2] + part4.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][3][0]].dy, 0, 0);
		}
		if (currentCharViewInfo.ID_LEG > -1)
		{
			currentCharViewInfo.paintLegUI(g, gW2, gH2 - num20, f);
		}
		else
		{
			SmallImage.drawSmallImage(g, part2.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][1][0]].id, gW2 + Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][1][1] + part2.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][1][0]].dx, gH2 + num18 - Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][1][2] + part2.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][1][0]].dy, 0, 0);
		}
		if (currentCharViewInfo.ID_Body > -1)
		{
			currentCharViewInfo.paintBodyUI(g, gW2, gH2 - num20, f);
		}
		else
		{
			SmallImage.drawSmallImage(g, part3.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][2][0]].id, gW2 + Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][2][1] + part3.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][2][0]].dx, gH2 + num18 - Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][2][2] + part3.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][2][0]].dy, 0, 0);
		}
		if (currentCharViewInfo.ID_HAIR > -1)
		{
			currentCharViewInfo.paintHeadUI(g, gW2, gH2 - num20, f);
		}
		else
		{
			SmallImage.drawSmallImage(g, part.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][0][0]].id, gW2 + Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][0][1] + part.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][0][0]].dx, gH2 + num18 - Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][0][2] + part.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][0][0]].dy, 0, 0);
		}
		currentCharViewInfo.paintClanEffect(g, gW2 + Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][2][1] + part3.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][2][0]].dx + 5, gH2 + num18 - Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][1][2] + part2.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][1][0]].dy + 5);
		currentCharViewInfo.paintClanEffect2(g, gW2 + Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][2][1] + part3.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][2][0]].dx + 22, gH2 + num18 - Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][1][2] + part2.pi[Char.CharInfo[(currentCharViewInfo.cp1 % 15 >= 5) ? 1u : 0u][1][0]].dy + 5);
		if (currentCharViewInfo.ID_PP > -1)
		{
			currentCharViewInfo.paintPPUITop(g, gW2, gH2 - num20, f);
		}
		if (currentCharViewInfo.ID_WEA_PONE > -1)
		{
			currentCharViewInfo.paintWeaponUITop(g, gW2, gH2 - num20, f);
		}
		if (cmdTrangbi2 != null && GameCanvas.isTouch)
		{
			cmdTrangbi2.paint(g);
		}
	}

	public void paintThongtin(mGraphics g)
	{
		if (indexMenu != 3)
		{
			return;
		}
		resetTranslate(g);
		GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
		if (indexTitle == 1)
		{
			g.setColor(Paint.COLORDARK);
			g.fillRect(popupX + 7, popupY + 32, popupW - 14, popupH - 40);
			g.setColor(16777215);
		}
		else
		{
			g.setColor(10249521);
		}
		g.drawRect(popupX + 7, popupY + 32, popupW - 14, popupH - 40);
		paintTitle(g, mResources.MENUME[indexMenu], arrow: true);
		xstart = popupX + 17;
		ystart = popupY + 34;
		scrMain.setStyle(indexRowMax, 12, popupX, popupY + 35, popupW, popupH - 44, styleUPDOWN: true, 1);
		scrMain.setClip(g);
		if (typeViewInfo == 0)
		{
			indexRowMax = 19;
			int num = ystart;
			if (currentCharViewInfo == null)
			{
				return;
			}
			mFont.tahoma_7b_white.drawString(g, mResources.inforMe[0] + currentCharViewInfo.cName, xstart, num, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMe[1] + currentCharViewInfo.cPk, xstart, num += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMe[2] + currentCharViewInfo.clevel, xstart, num += 12, 0);
			mFont.tahoma_7_blue1.drawString(g, mResources.inforMe[3] + currentCharViewInfo.nClass.name, xstart, num += 12, 0);
			mFont.tahoma_7_blue1.drawString(g, mResources.inforMe[4] + mResources.SYS[currentCharViewInfo.getSys()], xstart, num += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMe[5] + currentCharViewInfo.cHP + "/" + currentCharViewInfo.cMaxHP, xstart, num += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMe[6] + currentCharViewInfo.cMP + "/" + currentCharViewInfo.cMaxMP, xstart, num += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMe[7] + currentCharViewInfo.getSpeed(), xstart, num += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMe[8] + (currentCharViewInfo.cdame - currentCharViewInfo.cdame / 10) + "-" + currentCharViewInfo.cdame, xstart, num += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMe[9] + currentCharViewInfo.cResFire, xstart, num += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMe[10] + currentCharViewInfo.cResIce, xstart, num += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMe[11] + currentCharViewInfo.cResWind, xstart, num += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMe[12] + currentCharViewInfo.cdameDown, xstart, num += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMe[13] + currentCharViewInfo.cExactly, xstart, num += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMe[14] + currentCharViewInfo.cMiss, xstart, num += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMe[15] + currentCharViewInfo.cFatal, xstart, num += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMe[16] + currentCharViewInfo.cReactDame, xstart, num += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMe[17] + currentCharViewInfo.sysUp, xstart, num += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMe[18] + currentCharViewInfo.sysDown, xstart, num += 12, 0);
		}
		else if (typeViewInfo == 1)
		{
			indexRowMax = 20;
			int num2 = ystart;
			if (currentCharViewInfo == null)
			{
				return;
			}
			mFont.tahoma_7b_white.drawString(g, mResources.inforMePoint[15] + ((!currentCharViewInfo.cClanName.Equals(string.Empty)) ? currentCharViewInfo.cClanName : mResources.NO_CLAN), xstart, num2, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMePoint[0] + currentCharViewInfo.pointUydanh, xstart, num2 += 12, 0);
			mFont.tahoma_7_blue1.drawString(g, mResources.inforMePoint[11] + currentCharViewInfo.countFinishDay + "/20", xstart, num2 += 12, 0);
			mFont.tahoma_7_blue1.drawString(g, mResources.inforMePoint[12] + currentCharViewInfo.countLoopBoos + mResources.NUMBER, xstart, num2 += 12, 0);
			mFont.tahoma_7_blue1.drawString(g, mResources.inforMePoint[16] + currentCharViewInfo.countPB + mResources.NUMBER, xstart, num2 += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMePoint[13] + currentCharViewInfo.limitTiemnangso, xstart, num2 += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMePoint[14] + currentCharViewInfo.limitKynangso, xstart, num2 += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMePoint[18] + currentCharViewInfo.limitPhongLoi + mResources.NUMBER, xstart, num2 += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMePoint[19] + currentCharViewInfo.limitBangHoa + mResources.NUMBER, xstart, num2 += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMePoint[17] + currentCharViewInfo.pointTinhTu, xstart, num2 += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMePoint[1] + currentCharViewInfo.pointVukhi, xstart, num2 += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMePoint[2] + currentCharViewInfo.pointLien, xstart, num2 += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMePoint[3] + currentCharViewInfo.pointNhan, xstart, num2 += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMePoint[4] + currentCharViewInfo.pointNgocboi, xstart, num2 += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMePoint[5] + currentCharViewInfo.pointPhu, xstart, num2 += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMePoint[6] + currentCharViewInfo.pointNon, xstart, num2 += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMePoint[7] + currentCharViewInfo.pointAo, xstart, num2 += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMePoint[8] + currentCharViewInfo.pointGangtay, xstart, num2 += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMePoint[9] + currentCharViewInfo.pointQuan, xstart, num2 += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.inforMePoint[10] + currentCharViewInfo.pointGiay, xstart, num2 += 12, 0);
		}
		if (indexTitle == 1 && indexRow >= 0)
		{
			SmallImage.drawSmallImage(g, 942, xstart - 8, ystart + 2 + indexRow * 12, 0, StaticObj.TOP_LEFT);
		}
	}

	public void paintThuCuoi(mGraphics g)
	{
		if (indexMenu != 5)
		{
			return;
		}
		g.translate(-g.getTranslateX(), -g.getTranslateY());
		GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
		g.setColor(Paint.COLORBACKGROUND);
		paintTitle(g, mResources.MENUME[indexMenu], arrow: true);
		resetTranslate(g);
		g.setColor(0);
		g.fillRect(popupX + 2, popupY + 31, 171, popupH - 34);
		g.setColor(13606712);
		g.drawRect(popupX + 3, popupY + 32, 168, popupH - 37);
		g.setColor(Paint.COLORBACKGROUND);
		g.fillRect(popupX + 4, popupY + 34, 166, popupH - 39);
		if (currentCharViewInfo.arrItemMounts[4] != null)
		{
			mFont.tahoma_7b_white.drawString(g, currentCharViewInfo.arrItemMounts[4].template.name, popupX + 90, ystart + 2, 2);
			int num = currentCharViewInfo.arrItemMounts[4].sys + 1;
			for (int i = 0; i < num; i++)
			{
				SmallImage.drawSmallImage(g, 628, popupX + 90 + i * 12 - num * 6, ystart + 20, 0, mGraphics.HCENTER | mGraphics.VCENTER);
			}
		}
		else
		{
			mFont.tahoma_7b_white.drawString(g, mResources.MON_NAME, popupX + 90, ystart + 2, 2);
		}
		for (int j = 0; j < currentCharViewInfo.arrItemMounts.Length - 1; j++)
		{
			if (currentCharViewInfo.arrItemMounts[j] != null)
			{
				paintItem(g, currentCharViewInfo.arrItemMounts[j], xMounts[j], yMounts[j]);
			}
			else
			{
				g.setColor(6425);
				g.fillRect(xMounts[j] - 1, yMounts[j] - 1, indexSize + 3, indexSize + 3);
				switch (j)
				{
				case 0:
					if (currentCharViewInfo.isHaveMoto())
					{
						mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[22][0], xMounts[j] + indexSize / 2, yMounts[j] + indexSize / 2 - 10, 2);
						mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[22][1], xMounts[j] + indexSize / 2, yMounts[j] + indexSize / 2 + 2, 2);
					}
					else
					{
						mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[19][0], xMounts[j] + indexSize / 2, yMounts[j] + indexSize / 2 - 10, 2);
						mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[19][1], xMounts[j] + indexSize / 2, yMounts[j] + indexSize / 2 + 2, 2);
					}
					break;
				case 1:
					if (currentCharViewInfo.isHaveMoto())
					{
						mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[20][0], xMounts[j] + indexSize / 2, yMounts[j] + indexSize / 2 - 10, 2);
						mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[20][1], xMounts[j] + indexSize / 2, yMounts[j] + indexSize / 2 + 2, 2);
					}
					else
					{
						mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[16][0], xMounts[j] + indexSize / 2, yMounts[j] + indexSize / 2 - 10, 2);
						mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[16][1], xMounts[j] + indexSize / 2, yMounts[j] + indexSize / 2 + 2, 2);
					}
					break;
				case 2:
					if (currentCharViewInfo.isHaveMoto())
					{
						mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[21][0], xMounts[j] + indexSize / 2, yMounts[j] + indexSize / 2 - 10, 2);
						mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[21][1], xMounts[j] + indexSize / 2, yMounts[j] + indexSize / 2 + 2, 2);
					}
					else
					{
						mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[17][0], xMounts[j] + indexSize / 2, yMounts[j] + indexSize / 2 - 10, 2);
						mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[17][1], xMounts[j] + indexSize / 2, yMounts[j] + indexSize / 2 + 2, 2);
					}
					break;
				case 3:
					if (currentCharViewInfo.isHaveMoto())
					{
						mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[23][0], xMounts[j] + indexSize / 2, yMounts[j] + indexSize / 2 - 10, 2);
						mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[23][1], xMounts[j] + indexSize / 2, yMounts[j] + indexSize / 2 + 2, 2);
					}
					else
					{
						mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[18][0], xMounts[j] + indexSize / 2, yMounts[j] + indexSize / 2 - 10, 2);
						mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[18][1], xMounts[j] + indexSize / 2, yMounts[j] + indexSize / 2 + 2, 2);
					}
					break;
				}
			}
			if (indexSelect == j && indexTitle == 1 && indexSelect < 4)
			{
				g.setColor(16777215);
			}
			else
			{
				g.setColor(12281361);
			}
			g.drawRect(xMounts[j], yMounts[j], indexSize, indexSize);
		}
		int num2 = xMounts[0] + indexSize + 7;
		int num3 = yMounts[0] - 5;
		g.setColor(6425);
		g.fillRect(num2, num3, 84, 75);
		if (indexSelect == 4)
		{
			g.setColor(16777215);
		}
		else
		{
			g.setColor(12281361);
		}
		g.drawRect(num2, num3, 84, 75);
		int num4 = 0;
		int num5 = 0;
		int w = 0;
		int w2 = 0;
		int num6 = 0;
		if (currentCharViewInfo.ID_HORSE > -1)
		{
			currentCharViewInfo.paintHorseUI(g, num2 + 35, num3 + 55, fhorse[fhorsetrangbi]);
		}
		if (currentCharViewInfo.arrItemMounts[4] != null)
		{
			if (currentCharViewInfo.isHaveNewMount())
			{
				int[][] array = (int[][])CharPartInfo.newMount.get(currentCharViewInfo.arrItemMounts[4].template.id + string.Empty);
				if (GameCanvas.gameTick % 20 > 15)
				{
					SmallImage.drawSmallImage(g, array[0][0], num2 + 45 - 10, num3 + 35, 0, mGraphics.HCENTER | mGraphics.VCENTER);
				}
				else
				{
					SmallImage.drawSmallImage(g, array[0][1], num2 + 45 - 10, num3 + 35, 0, mGraphics.HCENTER | mGraphics.VCENTER);
				}
			}
			else if (currentCharViewInfo.isHaveMoto())
			{
				if (currentCharViewInfo.arrItemMounts[4].template.id == 485)
				{
					if (currentCharViewInfo.arrItemMounts[4].sys < 2)
					{
						SmallImage.drawSmallImage(g, 1800, num2 + 45, num3 + 35, 0, mGraphics.HCENTER | mGraphics.VCENTER);
					}
					else
					{
						SmallImage.drawSmallImage(g, 2063, num2 + 45, num3 + 35, 0, mGraphics.HCENTER | mGraphics.VCENTER);
					}
				}
				else if (currentCharViewInfo.arrItemMounts[4].template.id == 524)
				{
					if (currentCharViewInfo.arrItemMounts[4].sys < 2)
					{
						SmallImage.drawSmallImage(g, 2067, num2 + 45, num3 + 35, 0, mGraphics.HCENTER | mGraphics.VCENTER);
					}
					else
					{
						SmallImage.drawSmallImage(g, 2071, num2 + 45, num3 + 35, 0, mGraphics.HCENTER | mGraphics.VCENTER);
					}
				}
			}
			else if (currentCharViewInfo.isHaveWolf())
			{
				if (currentCharViewInfo.arrItemMounts[4].template.id == 443)
				{
					if (currentCharViewInfo.arrItemMounts[4].sys < 2)
					{
						if (GameCanvas.gameTick % 20 > 15)
						{
							SmallImage.drawSmallImage(g, 1801, num2 + 45, num3 + 35, 0, mGraphics.HCENTER | mGraphics.VCENTER);
						}
						else
						{
							SmallImage.drawSmallImage(g, 1802, num2 + 45, num3 + 35, 0, mGraphics.HCENTER | mGraphics.VCENTER);
						}
					}
					else if (GameCanvas.gameTick % 20 > 15)
					{
						SmallImage.drawSmallImage(g, 2080, num2 + 45, num3 + 35, 0, mGraphics.HCENTER | mGraphics.VCENTER);
					}
					else
					{
						SmallImage.drawSmallImage(g, 2081, num2 + 45, num3 + 35, 0, mGraphics.HCENTER | mGraphics.VCENTER);
					}
				}
				else if (currentCharViewInfo.arrItemMounts[4].template.id == 523)
				{
					if (GameCanvas.gameTick % 20 > 15)
					{
						SmallImage.drawSmallImage(g, 2062, num2 + 45, num3 + 35, 0, mGraphics.HCENTER | mGraphics.VCENTER);
					}
					else
					{
						SmallImage.drawSmallImage(g, 2061, num2 + 45, num3 + 35, 0, mGraphics.HCENTER | mGraphics.VCENTER);
					}
				}
			}
			if (currentCharViewInfo.arrItemMounts[4].options != null)
			{
				for (int k = 0; k < currentCharViewInfo.arrItemMounts[4].options.size(); k++)
				{
					ItemOption itemOption = (ItemOption)currentCharViewInfo.arrItemMounts[4].options.elementAt(k);
					if (itemOption.optionTemplate.id == 65)
					{
						num4 = itemOption.param;
					}
					else if (itemOption.optionTemplate.id == 66)
					{
						num5 = itemOption.param;
					}
				}
			}
			w = num4 * 85 / 1000;
			w2 = num5 * 85 / 1000;
			num6 = currentCharViewInfo.arrItemMounts[4].upgrade + 1;
		}
		int num7 = xstart + 5;
		int num8 = ystart + 112;
		mFont.tahoma_7b_white.drawString(g, mResources.Level + ": ", num7, num8, 0);
		mFont.tahoma_7b_white.drawString(g, num6 + string.Empty, num7 + 70, num8, 0);
		if (currentCharViewInfo.isHaveMoto())
		{
			mFont.tahoma_7b_white.drawString(g, mResources.MACHINE + ": ", num7, num8 += 15, 0);
		}
		else
		{
			mFont.tahoma_7b_white.drawString(g, mResources.EXP + ": ", num7, num8 += 15, 0);
		}
		g.setColor(6425);
		g.fillRect(num7 + 70, num8, 85, 14);
		g.setColor(371981);
		g.fillRect(num7 + 70, num8, w, 14);
		g.setColor(5131338);
		g.drawRect(num7 + 70, num8, 85, 14);
		mFont.tahoma_7_white.drawString(g, num4 + "/" + 1000, num7 + 113, num8 + 2, 2);
		if (currentCharViewInfo.isHaveMoto())
		{
			mFont.tahoma_7b_white.drawString(g, mResources.POWER + ": ", num7, num8 += 17, 0);
		}
		else
		{
			mFont.tahoma_7b_white.drawString(g, mResources.VITALITY + ": ", num7, num8 += 17, 0);
		}
		g.setColor(6425);
		g.fillRect(num7 + 70, num8, 85, 14);
		g.setColor(16711680);
		g.fillRect(num7 + 70, num8, w2, 14);
		g.setColor(5131338);
		g.drawRect(num7 + 70, num8, 85, 14);
		mFont.tahoma_7_white.drawString(g, num5 + "/" + 1000, num7 + 113, num8 + 2, 2);
	}

	public void paintClanInfo(mGraphics g)
	{
		if (!isPaintClan)
		{
			return;
		}
		resetTranslate(g);
		GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
		paintTitle(g, mResources.CLAN[indexMenu], arrow: true);
		if (indexMenu == 0)
		{
			if (Char.clan == null || Char.clan.name == null || Char.clan.name.Equals(string.Empty))
			{
				indexRowMax = 1;
				mFont.tahoma_7_white.drawString(g, mResources.EMPTY_INFO, popupX + popupW / 2, popupY + 40, 2);
				return;
			}
			int[] array = new int[5] { 1692, 1693, 1694, 1695, 1696 };
			for (int i = 0; i < array.Length; i++)
			{
				g.setColor(6425);
				g.fillRect(popupX + i * indexSize + 18, popupY + 32, indexSize - 2, indexSize - 2);
				if (indexTitle == 1 && i == indexSelect)
				{
					g.setColor(16777215);
				}
				else
				{
					g.setColor(12281361);
				}
				g.drawRect(popupX + i * indexSize + 18, popupY + 32, indexSize - 2, indexSize - 2);
				if (i > Char.clan.itemLevel - 1)
				{
					SmallImage.drawSmallImage(g, 1697, popupX + i * indexSize + 18 + indexSize / 2, popupY + 32 + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				}
				else
				{
					SmallImage.drawSmallImage(g, array[i], popupX + i * indexSize + 18 + indexSize / 2, popupY + 32 + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				}
			}
			if (indexTitle == 2)
			{
				g.setColor(Paint.COLORDARK);
				g.fillRect(popupX + 7, popupY + 60, popupW - 14, popupH - 68);
				g.setColor(16777215);
			}
			else
			{
				g.setColor(10249521);
			}
			g.drawRect(popupX + 7, popupY + 60, popupW - 14, popupH - 68);
			xstart = popupX + 17;
			ystart = popupY + 62;
			indexRowMax = 12;
			scrMain.setStyle(indexRowMax, 12, popupX, popupY + 62, popupW, popupH - 72, styleUPDOWN: true, 1);
			scrMain.setClip(g);
			mFont.tahoma_7b_yellow.drawString(g, mResources.CLANINFO[0] + Char.clan.name, xstart, ystart, 0);
			mFont.tahoma_7_blue1.drawString(g, mResources.CLANINFO[1] + Char.clan.main_name, xstart, ystart += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.CLANINFO[2] + Char.clan.total + "/" + (Char.clan.level * 5 + 45), xstart, ystart += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.CLANINFO[3] + Char.clan.level, xstart, ystart += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.CLANINFO[4] + Char.clan.exp + "/" + Char.clan.expNext, xstart, ystart += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.CLANINFO[5] + NinjaUtil.numberToString(Char.clan.coin + string.Empty) + " " + mResources.XU, xstart, ystart += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.CLANINFO[8] + NinjaUtil.numberToString(Char.clan.freeCoin + string.Empty) + " " + mResources.XU, xstart, ystart += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.CLANINFO[9] + NinjaUtil.numberToString(Char.clan.coinUp + string.Empty) + " " + mResources.XU, xstart, ystart += 12, 0);
			if (mFont.tahoma_7_white.getWidth(mResources.CLANINFO[10] + Char.clan.openDun + " " + mResources.COUNT) > inforW - 10)
			{
				paintMultiLine(g, mFont.tahoma_7_white, mResources.CLANINFO[10] + Char.clan.openDun + " " + mResources.COUNT, xstart, ystart += 12, 0, popupW - 20);
			}
			else
			{
				mFont.tahoma_7_white.drawString(g, mResources.CLANINFO[10] + Char.clan.openDun + " " + mResources.COUNT, xstart, ystart += 12, 0);
			}
			if (mFont.tahoma_7_white.getWidth(mResources.CLANINFO[12] + Char.clan.use_card + " " + mResources.COUNT) > inforW - 10)
			{
				paintMultiLine(g, mFont.tahoma_7_white, mResources.CLANINFO[12] + Char.clan.use_card + " " + mResources.COUNT, xstart, ystart += 12, 0, popupW - 20);
			}
			else
			{
				mFont.tahoma_7_white.drawString(g, mResources.CLANINFO[12] + Char.clan.use_card + " " + mResources.COUNT, xstart, ystart += 12, 0);
			}
			mFont.tahoma_7_white.drawString(g, mResources.CLANINFO[6] + Char.clan.reg_date, xstart, ystart += 12, 0);
			if (arrClanInfo == null)
			{
				arrClanInfo = splitMultiLine(mFont.tahoma_7_yellow, Char.clan.alert);
			}
			paintMultiLine(g, mFont.tahoma_7_yellow, arrClanInfo, xstart, ystart += 12, 0);
			if (indexTitle == 2 && indexRow >= 0)
			{
				SmallImage.drawSmallImage(g, 942, xstart - 8, popupY + 62 + 2 + indexRow * 12, 0, StaticObj.TOP_LEFT);
			}
			scrMain.setStyle(indexRowMax, 12, popupX, popupY + 62, popupW, popupH - 72, styleUPDOWN: true, 1);
		}
		else if (indexMenu == 1)
		{
			xstart = popupX + 5;
			ystart = popupY + 32;
			if (vClan.size() == 0)
			{
				mFont.tahoma_7_white.drawString(g, mResources.EMPTY_INFO, popupX + popupW / 2, popupY + 40, mFont.CENTER);
				return;
			}
			g.setColor(6425);
			g.fillRect(xstart - 2, ystart - 2, popupW - 6, indexSize * 5 + 8);
			resetTranslate(g);
			if (Main.isPC)
			{
				scrMain.setClip(g, xstart, ystart, popupW - 3, indexSize * 5 + 6);
			}
			else
			{
				scrMain.setClip(g, xstart, ystart, popupW - 3, indexSize * 4 + 6);
			}
			indexMember = 0;
			for (int j = 0; j < vClan.size(); j++)
			{
				Member member = (Member)vClan.elementAt(j);
				if (isViewClanMemOnline && !member.isOnline)
				{
					continue;
				}
				if (j * (indexSize + indexSize / 2) >= scrMain.cmy - (indexSize + indexSize / 2) && j * (indexSize + indexSize / 2) < scrMain.cmy + (indexSize * 5 + 8))
				{
					if (indexRow == indexMember)
					{
						g.setColor(Paint.COLORLIGHT);
						g.fillRect(xstart + 2, ystart + indexRow * (indexSize + indexSize / 2) + 2, popupW - 15, indexSize + indexSize / 2 - 4);
						g.setColor(16777215);
						g.drawRect(xstart + 2, ystart + indexRow * (indexSize + indexSize / 2) + 2, popupW - 15, indexSize + indexSize / 2 - 4);
					}
					else
					{
						g.setColor(Paint.COLORBACKGROUND);
						g.fillRect(xstart + 2, ystart + indexMember * (indexSize + indexSize / 2) + 2, popupW - 15, indexSize + indexSize / 2 - 4);
						g.setColor(13932896);
						g.drawRect(xstart + 2, ystart + indexMember * (indexSize + indexSize / 2) + 2, popupW - 15, indexSize + indexSize / 2 - 4);
					}
					SmallImage.drawSmallImage(g, member.iconId, xstart + 12, ystart + indexMember * (indexSize + indexSize / 2) + 13, 0, mGraphics.VCENTER | mGraphics.HCENTER);
					if (member.type == 4)
					{
						SmallImage.drawSmallImage(g, 1216, xstart + 12, ystart + indexMember * (indexSize + indexSize / 2) + 30, 0, mGraphics.VCENTER | mGraphics.HCENTER);
						if (member.isOnline)
						{
							mFont.tahoma_7_yellow.drawString(g, mResources.CLANS_STANDFOR[0] + " ", xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 5, 0, mFont.tahoma_7_grey);
							mFont.tahoma_7_white.drawString(g, member.name + " - " + mResources.level + ": " + member.level, xstart + 45, ystart + indexMember * (indexSize + indexSize / 2) + 5, 0);
							mFont.tahoma_7_green.drawString(g, mResources.CLANINFO[7] + member.pointClan, xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 16, 0);
							mFont.tahoma_7_blue1.drawString(g, mResources.CLANINFO[11] + member.pointClanWeek, xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 26, 0);
						}
						else
						{
							mFont.tahoma_7_grey.drawString(g, mResources.CLANS_STANDFOR[0] + " ", xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 5, 0);
							mFont.tahoma_7_grey.drawString(g, member.name + " - " + mResources.level + ": " + member.level, xstart + 45, ystart + indexMember * (indexSize + indexSize / 2) + 5, 0);
							mFont.tahoma_7_grey.drawString(g, mResources.CLANINFO[7] + member.pointClan, xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 16, 0);
							mFont.tahoma_7_grey.drawString(g, mResources.CLANINFO[11] + member.pointClanWeek, xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 26, 0);
						}
					}
					else if (member.type == 3)
					{
						SmallImage.drawSmallImage(g, 1215, xstart + 12, ystart + indexMember * (indexSize + indexSize / 2) + 30, 0, mGraphics.VCENTER | mGraphics.HCENTER);
						if (member.isOnline)
						{
							mFont.tahoma_7_yellow.drawString(g, mResources.CLANS_STANDFOR[1] + " ", xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 5, 0, mFont.tahoma_7_grey);
							mFont.tahoma_7_white.drawString(g, member.name + " - " + mResources.level + ": " + member.level, xstart + 45, ystart + indexMember * (indexSize + indexSize / 2) + 5, 0);
							mFont.tahoma_7_green.drawString(g, mResources.CLANINFO[7] + member.pointClan, xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 16, 0);
							mFont.tahoma_7_blue1.drawString(g, mResources.CLANINFO[11] + member.pointClanWeek, xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 26, 0);
						}
						else
						{
							mFont.tahoma_7_grey.drawString(g, mResources.CLANS_STANDFOR[1] + " ", xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 5, 0);
							mFont.tahoma_7_grey.drawString(g, member.name + " - " + mResources.level + ": " + member.level, xstart + 45, ystart + indexMember * (indexSize + indexSize / 2) + 5, 0);
							mFont.tahoma_7_grey.drawString(g, mResources.CLANINFO[7] + member.pointClan, xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 16, 0);
							mFont.tahoma_7_grey.drawString(g, mResources.CLANINFO[11] + member.pointClanWeek, xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 26, 0);
						}
					}
					else if (member.type == 2)
					{
						SmallImage.drawSmallImage(g, 1217, xstart + 12, ystart + indexMember * (indexSize + indexSize / 2) + 30, 0, mGraphics.VCENTER | mGraphics.HCENTER);
						if (member.isOnline)
						{
							mFont.tahoma_7_yellow.drawString(g, mResources.CLANS_STANDFOR[2] + " ", xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 5, 0, mFont.tahoma_7_grey);
							mFont.tahoma_7_white.drawString(g, member.name + " - " + mResources.level + ": " + member.level, xstart + 45, ystart + indexMember * (indexSize + indexSize / 2) + 5, 0);
							mFont.tahoma_7_green.drawString(g, mResources.CLANINFO[7] + member.pointClan, xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 16, 0);
							mFont.tahoma_7_blue1.drawString(g, mResources.CLANINFO[11] + member.pointClanWeek, xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 26, 0);
						}
						else
						{
							mFont.tahoma_7_grey.drawString(g, mResources.CLANS_STANDFOR[2] + " ", xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 5, 0);
							mFont.tahoma_7_grey.drawString(g, member.name + " - " + mResources.level + ": " + member.level, xstart + 45, ystart + indexMember * (indexSize + indexSize / 2) + 5, 0);
							mFont.tahoma_7_grey.drawString(g, mResources.CLANINFO[7] + member.pointClan, xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 16, 0);
							mFont.tahoma_7_grey.drawString(g, mResources.CLANINFO[11] + member.pointClanWeek, xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 26, 0);
						}
					}
					else if (member.type == 1)
					{
						SmallImage.drawSmallImage(g, 1214, xstart + 12, ystart + indexMember * (indexSize + indexSize / 2) + 30, 0, mGraphics.VCENTER | mGraphics.HCENTER);
						if (member.isOnline)
						{
							mFont.tahoma_7_yellow.drawString(g, mResources.CLANS_STANDFOR[3] + " ", xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 5, 0, mFont.tahoma_7_grey);
							mFont.tahoma_7_white.drawString(g, member.name + " - " + mResources.level + ": " + member.level, xstart + 45, ystart + indexMember * (indexSize + indexSize / 2) + 5, 0);
							mFont.tahoma_7_green.drawString(g, mResources.CLANINFO[7] + member.pointClan, xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 16, 0);
							mFont.tahoma_7_blue1.drawString(g, mResources.CLANINFO[11] + member.pointClanWeek, xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 26, 0);
						}
						else
						{
							mFont.tahoma_7_grey.drawString(g, mResources.CLANS_STANDFOR[3] + " ", xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 5, 0);
							mFont.tahoma_7_grey.drawString(g, member.name + " - " + mResources.level + ": " + member.level, xstart + 45, ystart + indexMember * (indexSize + indexSize / 2) + 5, 0);
							mFont.tahoma_7_grey.drawString(g, mResources.CLANINFO[7] + member.pointClan, xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 16, 0);
							mFont.tahoma_7_grey.drawString(g, mResources.CLANINFO[11] + member.pointClanWeek, xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 26, 0);
						}
					}
					else if (member.isOnline)
					{
						mFont.tahoma_7_white.drawString(g, member.name + " - " + mResources.level + ": " + member.level, xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 5, 0);
						mFont.tahoma_7_green.drawString(g, mResources.CLANINFO[7] + member.pointClan, xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 16, 0);
						mFont.tahoma_7_blue1.drawString(g, mResources.CLANINFO[11] + member.pointClanWeek, xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 26, 0);
					}
					else
					{
						mFont.tahoma_7_grey.drawString(g, member.name + " - " + mResources.level + ": " + member.level, xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 5, 0);
						mFont.tahoma_7_grey.drawString(g, mResources.CLANINFO[7] + member.pointClan, xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 16, 0);
						mFont.tahoma_7_grey.drawString(g, mResources.CLANINFO[11] + member.pointClanWeek, xstart + 22, ystart + indexMember * (indexSize + indexSize / 2) + 26, 0);
					}
				}
				indexMember++;
			}
			scrMain.setStyle(indexMember, indexSize + indexSize / 2, xstart, ystart, popupW - 3, indexSize * 5 + 4, styleUPDOWN: true, 1);
			indexRowMax = indexMember;
			paintNumCount(g);
		}
		else if (indexMenu == 2)
		{
			xstart = popupX + 3;
			ystart = popupY + 32;
			g.setColor(6425);
			g.fillRect(xstart - 1, ystart - 1, columns * indexSize + 3, 5 * indexSize + 3);
			Item[] array2 = null;
			array2 = ((Char.clan != null && Char.clan.items != null) ? Char.clan.items : new Item[30]);
			paintBagItem(g, array2);
		}
		else if (indexMenu == 3)
		{
			if (Char.clan == null || Char.clan.name == null || Char.clan.name.Equals(string.Empty) || Char.clan.log.Equals(string.Empty))
			{
				indexRowMax = 1;
				mFont.tahoma_7_white.drawString(g, mResources.EMPTY_INFO, popupX + popupW / 2, popupY + 40, 2);
				return;
			}
			indexRowMax = 1;
			xstart = popupX + 17;
			ystart = popupY + 34;
			inforW = popupW - 30;
			scrMain.setClip(g);
			if (arrClanDongGop == null)
			{
				arrClanDongGop = splitMultiLine(mFont.tahoma_7_white, Char.clan.log);
			}
			paintMultiLine(g, mFont.tahoma_7_white, arrClanDongGop, xstart, ystart, 0);
			if (indexTitle == 1 && indexRow >= 0)
			{
				SmallImage.drawSmallImage(g, 942, xstart - 8, popupY + 34 + 2 + indexRow * 12, 0, StaticObj.TOP_LEFT);
			}
			scrMain.setStyle(indexRowMax, 12, popupX, popupY + 35, popupW, popupH - 44, styleUPDOWN: true, 1);
		}
		else if (indexMenu == 4)
		{
			paintThanThu_Clan(g);
		}
	}

	private void paintNumCount(mGraphics g)
	{
		resetTranslate(g);
		int num = indexRow;
		if (isPaintAuctionBuy)
		{
			num = indexSelect;
		}
		if (num >= 0 && indexRowMax > 0)
		{
			int num2 = ((num + 1 >= indexRowMax) ? indexRowMax : (num + 1));
			mFont.tahoma_7_yellow.drawString(g, num2 + "/" + indexRowMax, popupX + popupW / 2, popupY + popupH - 14, 2, mFont.tahoma_7_grey);
		}
	}

	public void updateKeyTask()
	{
		if (!isPaintTask)
		{
			return;
		}
		if (indexTitle == 0)
		{
			if (indexTitle == 0 && (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25]))
			{
				indexTitle = 1;
				indexRow = -1;
				scrMain.clear();
				scrInfo.clear();
			}
		}
		else
		{
			if (indexRow < 0)
			{
				indexRow = 0;
			}
			if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
			{
				if (indexRow == 0)
				{
					indexTitle--;
					indexRow = -1;
				}
				else
				{
					indexRow--;
				}
				scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
			}
			else if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
			{
				indexRow++;
				if (indexRow >= indexRowMax)
				{
					indexRow = 0;
				}
				scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
			}
		}
		if (GameCanvas.isTouch)
		{
			ScrollResult scrollResult = scrMain.updateKey();
			if (scrollResult.isDowning || scrollResult.isFinish)
			{
				indexRow = scrollResult.selected;
				indexTitle = 1;
			}
		}
	}

	public void updateKeyClanInfo()
	{
		if (!isPaintClan)
		{
			return;
		}
		if (indexTitle == 0)
		{
			if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
			{
				if (Char.clan == null)
				{
					indexTitle = 0;
				}
				else
				{
					indexTitle = 1;
				}
				indexSelect = 0;
				indexRow = -1;
				if (indexMenu == 0)
				{
					indexSelect = Char.clan.itemLevel;
				}
				scrMain.clear();
				scrInfo.clear();
			}
			if (GameCanvas.keyPressedz[Key.NUM4] || GameCanvas.keyPressedz[23])
			{
				indexSelect = 0;
				indexRow = -1;
				indexMenu--;
				scrMain.clear();
				scrInfo.clear();
				if (indexMenu < 0)
				{
					indexMenu = mResources.CLAN.Length - 1;
				}
				if (indexMenu >= mResources.CLAN.Length)
				{
					indexMenu = 0;
				}
				if (indexMenu == 1 && isRequestMember)
				{
					Service.gI().requestClanMember();
					isRequestMember = false;
				}
				else if (indexMenu == 2)
				{
					Service.gI().requestClanItem();
				}
				else if (indexMenu == 3)
				{
					Service.gI().requestClanLog();
				}
				else if (indexMenu == 4)
				{
					Service.gI().requestClanItem();
				}
				setPopupSize(175, 200);
			}
			if (GameCanvas.keyPressedz[Key.NUM6] || GameCanvas.keyPressedz[22])
			{
				indexSelect = 0;
				indexRow = -1;
				indexMenu++;
				scrMain.clear();
				scrInfo.clear();
				if (indexMenu < 0)
				{
					indexMenu = mResources.CLAN.Length - 1;
				}
				if (indexMenu >= mResources.CLAN.Length)
				{
					indexMenu = 0;
				}
				if (indexMenu == 1 && isRequestMember)
				{
					Service.gI().requestClanMember();
					isRequestMember = false;
				}
				else if (indexMenu == 2 && Char.clan.items == null)
				{
					Service.gI().requestClanItem();
				}
				else if (indexMenu == 3)
				{
					Service.gI().requestClanLog();
				}
				else if (indexMenu == 4)
				{
					Service.gI().requestClanItem();
				}
				setPopupSize(175, 200);
			}
			setClanComand();
		}
		else if (isPaintItemInfo)
		{
			if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
			{
				indexRow--;
				if (indexRow < 0)
				{
					indexRow = indexRowMax - 1;
				}
				scrInfo.moveTo(indexRow * scrInfo.ITEM_SIZE);
			}
			else if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
			{
				indexRow++;
				if (indexRow >= indexRowMax)
				{
					indexRow = 0;
				}
				scrInfo.moveTo(indexRow * scrInfo.ITEM_SIZE);
			}
		}
		else
		{
			if (indexRow < 0)
			{
				indexRow = 0;
			}
			if (indexMenu == 2)
			{
				if (Char.clan.items != null && Char.clan.items != null)
				{
					if (GameCanvas.keyPressedz[Key.NUM4] || GameCanvas.keyPressedz[23])
					{
						indexSelect--;
						if (indexSelect < 0)
						{
							indexSelect = Char.clan.items.Length - 1;
						}
					}
					else if (GameCanvas.keyPressedz[Key.NUM6] || GameCanvas.keyPressedz[22])
					{
						indexSelect++;
						if (indexSelect >= Char.clan.items.Length)
						{
							indexSelect = 0;
						}
					}
					else if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
					{
						if (indexSelect + columns <= Char.clan.items.Length - 1)
						{
							indexSelect += columns;
						}
					}
					else if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
					{
						if (indexSelect >= 0 && indexSelect < columns)
						{
							indexTitle = 0;
							indexSelect = 0;
						}
						else if (indexSelect - columns >= 0)
						{
							indexSelect -= columns;
						}
					}
					scrMain.moveTo(indexSelect / columns * scrMain.ITEM_SIZE);
				}
			}
			else if (indexMenu == 0 && indexTitle == 1)
			{
				if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
				{
					indexTitle++;
				}
				else if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
				{
					indexTitle--;
				}
			}
			else if (indexMenu == 4)
			{
				updateKeyThanThu();
			}
			else if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
			{
				if (indexRow == 0)
				{
					indexTitle--;
					indexRow = -1;
				}
				else
				{
					indexRow--;
				}
				scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
				if (indexMenu == 1 && isRequestMember)
				{
					Service.gI().requestClanMember();
					isRequestMember = false;
				}
			}
			else if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
			{
				indexRow++;
				if (indexRow >= indexRowMax)
				{
					indexRow = 0;
				}
				scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
			}
			setClanComand();
		}
		if (GameCanvas.isTouch)
		{
			updateKeyClanInfoTouch();
		}
		GameCanvas.clearKeyHold();
		GameCanvas.clearKeyPressed();
	}

	private void updateKeyClanInfoTouch()
	{
		if (GameCanvas.currentDialog != null || GameCanvas.menu.showMenu)
		{
			return;
		}
		if (GameCanvas.isPointerJustRelease)
		{
			if (GameCanvas.isPointerHoldIn(popupX, popupY, popupW, Hitem) && (!isPaintItemInfo || GameCanvas.w >= 320) && GameCanvas.isPointerClick)
			{
				if (GameCanvas.isPointerHoldIn(gW2 - 90, popupY + 5, 60, 40))
				{
					indexSelect = 0;
					indexMenu--;
					indexRow = 0;
					Sound.play(Sound.MBClick, 0.5f);
				}
				if (GameCanvas.isPointerHoldIn(gW2 + 20, popupY + 5, 60, 40))
				{
					indexSelect = 0;
					indexMenu++;
					indexRow = 0;
					Sound.play(Sound.MBClick, 0.5f);
				}
				isPaintItemInfo = false;
				scrMain.clear();
				scrInfo.clear();
				if (indexMenu < 0)
				{
					indexMenu = mResources.CLAN.Length - 1;
				}
				if (indexMenu > mResources.CLAN.Length - 1)
				{
					indexMenu = 0;
				}
				indexTitle = 1;
				if (indexMenu == 1 && isRequestMember)
				{
					Service.gI().requestClanMember();
					isRequestMember = false;
				}
				else if (indexMenu == 2 && Char.clan != null && Char.clan.items == null)
				{
					Service.gI().requestClanItem();
				}
				if (indexMenu == 3)
				{
					Service.gI().requestClanLog();
				}
				if (indexMenu == 4)
				{
					Service.gI().requestClanItem();
				}
				setPopupSize(175, 200);
				setClanComand();
			}
			if (indexMenu == 4)
			{
				updateTouchThanThu();
			}
		}
		if (isPaintItemInfo)
		{
			ScrollResult scrollResult = scrInfo.updateKey();
			if (scrollResult.isDowning || scrollResult.isFinish)
			{
				indexRow = scrollResult.selected;
				indexTitle = 1;
			}
			if (GameCanvas.isTouchControlSmallScreen)
			{
				return;
			}
		}
		if (indexMenu == 2)
		{
			ScrollResult scrollResult2 = scrMain.updateKey();
			if (scrollResult2.isDowning || scrollResult2.isFinish)
			{
				indexSelect = scrollResult2.selected;
				indexTitle = 1;
				actionPerform(1509, null);
			}
		}
		else if (indexMenu == 0 && GameCanvas.isPointerHoldIn(popupX + 18, popupY + 32, 5 * indexSize, indexSize) && GameCanvas.isPointerJustRelease && GameCanvas.isPointerClick)
		{
			if (Char.clan != null)
			{
				indexSelect = Char.clan.itemLevel;
				indexTitle = 1;
			}
		}
		else if (indexMenu == 0 || indexMenu == 3)
		{
			if (isPaintItemInfo)
			{
				return;
			}
			ScrollResult scrollResult3 = scrMain.updateKey();
			if (scrollResult3.isDowning || scrollResult3.isFinish)
			{
				indexRow = scrollResult3.selected;
				indexTitle = ((indexMenu != 0) ? 1 : 2);
				if (scrollResult3.isFinish)
				{
					scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
				}
			}
		}
		else if (indexMenu == 1 && vClan.size() != 0)
		{
			ScrollResult scrollResult4 = scrMain.updateKey();
			if (scrollResult4.isDowning || scrollResult4.isFinish)
			{
				indexRow = scrollResult4.selected;
				updateCommandForUI();
			}
		}
	}

	private void setClanComand()
	{
		if (isPaintItemInfo)
		{
			return;
		}
		left = (center = null);
		if (indexMenu == 0)
		{
			if (Char.getMyChar().ctypeClan == 4)
			{
				left = new Command(mResources.CLANS[0], 14004);
			}
			if (Char.getMyChar().ctypeClan == 3)
			{
				left = new Command(mResources.CLANS[1], 14004);
			}
			if (Char.getMyChar().ctypeClan == 2)
			{
				left = new Command(mResources.CLANS[2], 14004);
			}
			if (!Char.getMyChar().cClanName.Equals(string.Empty))
			{
				if (indexTitle == 1)
				{
					center = new Command(mResources.VIEW, 140101);
				}
				else
				{
					center = new Command(mResources.CLAN_MENU[3], 14010);
				}
			}
		}
		else if (indexMenu == 1)
		{
			if (vClan.size() <= 0 || indexRow < 0 || indexRow >= vClan.size())
			{
				return;
			}
			Member member = curMemberSelected();
			if (member != null)
			{
				if (Char.getMyChar().ctypeClan == 4)
				{
					left = new Command(mResources.CLANS[0], 14005);
				}
				if (Char.getMyChar().ctypeClan == 3)
				{
					left = new Command(mResources.CLANS[1], 14005);
				}
				if (Char.getMyChar().ctypeClan != 4 && Char.getMyChar().ctypeClan != 3)
				{
					left = new Command(mResources.CLANS[4], 14005);
				}
				if (!member.name.Equals(Char.getMyChar().cName) && (!isViewClanMemOnline || indexMember != 0))
				{
					center = new Command(mResources.SELECT, 14006, member.name);
				}
			}
		}
		else if (indexMenu == 2 && indexTitle == 1 && Char.clan != null && Char.clan.items != null)
		{
			left = new Command(mResources.SELECT, 1508);
			if (!GameCanvas.isTouchControlLargeScreen)
			{
				center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 1509);
			}
		}
	}

	public void updateSS()
	{
		if (indexMenu != -1)
		{
			if (cmySK != cmtoYSK)
			{
				cmvySK = cmtoYSK - cmySK << 2;
				cmdySK += cmvySK;
				cmySK += cmdySK >> 4;
				cmdySK &= 15;
			}
			if (Math.abs(cmtoYSK - cmySK) < 15 && cmySK < 0)
			{
				cmtoYSK = 0;
			}
			if (Math.abs(cmtoYSK - cmySK) < 15 && cmySK > cmyLimSK)
			{
				cmtoYSK = cmyLimSK;
			}
		}
	}

	public void updateKeyUIInforMe()
	{
		if (!isPaintInfoMe || indexMenu == -1 || GameCanvas.currentDialog != null || (isselectedRow >= 1 && indexMenu == 1))
		{
			return;
		}
		if (indexTitle == 0)
		{
			left = (center = null);
			if (indexMenu == 0)
			{
				left = new Command(mResources.SORT, 110221);
			}
			if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
			{
				indexTitle = 1;
				indexSelect = 0;
				indexRow = 0;
				scrMain.clear();
				scrInfo.clear();
				setLCR();
			}
			if (GameCanvas.keyPressedz[Key.NUM4] || GameCanvas.keyPressedz[23])
			{
				indexSelect = 0;
				indexRow = -1;
				indexMenu--;
				scrMain.clear();
				scrInfo.clear();
				if (currentCharViewInfo.charID != Char.getMyChar().charID)
				{
					if (indexMenu < 3)
					{
						indexMenu = 5;
					}
				}
				else if (indexMenu < 0)
				{
					indexMenu = mResources.MENUME.Length - 1;
				}
				doMiniMenuInforMe();
			}
			if (GameCanvas.keyPressedz[Key.NUM6] || GameCanvas.keyPressedz[22])
			{
				indexSelect = 0;
				indexRow = -1;
				indexMenu++;
				scrMain.clear();
				scrInfo.clear();
				if (currentCharViewInfo.charID != Char.getMyChar().charID)
				{
					if (indexMenu > 5)
					{
						indexMenu = 3;
					}
				}
				else if (indexMenu > mResources.MENUME.Length - 1)
				{
					indexMenu = 0;
				}
				doMiniMenuInforMe();
			}
			setLCR();
		}
		else if (isPaintItemInfo)
		{
			if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
			{
				indexRow--;
				if (indexRow < 0)
				{
					indexRow = indexRowMax - 1;
				}
				scrInfo.moveTo(indexRow * scrInfo.ITEM_SIZE);
			}
			else if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
			{
				indexRow++;
				if (indexRow >= indexRowMax)
				{
					indexRow = 0;
				}
				scrInfo.moveTo(indexRow * scrInfo.ITEM_SIZE);
			}
		}
		else if (indexMenu == 0)
		{
			if (GameCanvas.keyPressedz[Key.NUM4] || GameCanvas.keyPressedz[23])
			{
				indexSelect--;
				if (indexSelect < 0)
				{
					indexSelect = Char.getMyChar().arrItemBag.Length - 1;
				}
				left = (center = null);
				setLCR();
				scrMain.moveTo(indexSelect / columns * scrMain.ITEM_SIZE);
			}
			else if (GameCanvas.keyPressedz[Key.NUM6] || GameCanvas.keyPressedz[22])
			{
				indexSelect++;
				if (indexSelect >= Char.getMyChar().arrItemBag.Length)
				{
					indexSelect = 0;
				}
				left = (center = null);
				setLCR();
				scrMain.moveTo(indexSelect / columns * scrMain.ITEM_SIZE);
			}
			else if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
			{
				if (indexSelect + columns <= Char.getMyChar().arrItemBag.Length - 1)
				{
					indexSelect += columns;
				}
				left = (center = null);
				setLCR();
				scrMain.moveTo(indexSelect / columns * scrMain.ITEM_SIZE);
			}
			else if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
			{
				if (indexSelect >= 0 && indexSelect < columns)
				{
					indexTitle = 0;
					indexSelect = 0;
				}
				else if (indexSelect - columns >= 0)
				{
					indexSelect -= columns;
				}
				left = (center = null);
				setLCR();
				scrMain.moveTo(indexSelect / columns * scrMain.ITEM_SIZE);
			}
		}
		else if (indexMenu == 1)
		{
			if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
			{
				if (indexTitle == 1 && indexRow == -1)
				{
					indexTitle--;
				}
				else if (indexTitle == 1 && indexRow >= 0)
				{
					indexRow--;
				}
				scrInfo.moveTo(indexRow * scrInfo.ITEM_SIZE);
			}
			else if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
			{
				if (indexTitle == 0)
				{
					indexTitle++;
				}
				else if (indexTitle == 1)
				{
					indexRow++;
					if (indexRow >= indexRowMax)
					{
						indexRow = 0;
					}
					scrInfo.moveTo(indexRow * scrInfo.ITEM_SIZE);
				}
				left = (center = null);
				setLCR();
			}
			else if (GameCanvas.keyPressedz[Key.NUM4] || GameCanvas.keyPressedz[23])
			{
				indexRow = -1;
				if (indexTitle == 1)
				{
					indexSelect--;
					if (indexSelect < 0)
					{
						indexSelect = Char.getMyChar().nClass.skillTemplates.Length - 1;
					}
				}
				left = (center = null);
				setLCR();
				scrMain.moveTo(indexSelect * scrMain.ITEM_SIZE);
				scrInfo.clear();
				indexRow = 0;
			}
			else if (GameCanvas.keyPressedz[Key.NUM6] || GameCanvas.keyPressedz[22])
			{
				indexRow = -1;
				if (indexTitle == 1)
				{
					indexSelect++;
					if (indexSelect >= Char.getMyChar().nClass.skillTemplates.Length)
					{
						indexSelect = 0;
					}
				}
				left = (center = null);
				setLCR();
				scrMain.moveTo(indexSelect * scrMain.ITEM_SIZE);
				scrInfo.clear();
				indexRow = 0;
			}
		}
		else if (indexMenu == 2)
		{
			if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
			{
				indexTitle--;
			}
			else if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
			{
				indexTitle++;
				if (indexTitle >= 5)
				{
					indexTitle = 1;
				}
				left = (center = null);
				setLCR();
			}
		}
		else if (indexMenu == 3)
		{
			if (indexRow < 0)
			{
				indexRow = 0;
			}
			if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
			{
				if (indexRow == 0)
				{
					indexTitle--;
					indexRow = -1;
				}
				else
				{
					indexRow--;
				}
				scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
			}
			else if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
			{
				indexRow++;
				if (indexRow >= indexRowMax)
				{
					indexRow = 0;
				}
				scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
			}
		}
		else if (indexMenu == 4)
		{
			int num = indexSelect;
			if (indexSelect == 11 || indexSelect == 12 || indexSelect == 13 || indexSelect == 14)
			{
				if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[Key.NUM4] || GameCanvas.keyPressedz[24] || GameCanvas.keyPressedz[23])
				{
					indexSelect--;
				}
				else if (GameCanvas.keyPressedz[Key.NUM6] || GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[22] || GameCanvas.keyPressedz[25])
				{
					indexSelect++;
				}
			}
			else if (indexSelect == 9)
			{
				if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
				{
					indexSelect -= 2;
				}
				else if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
				{
					indexSelect = 15;
				}
				else if (GameCanvas.keyPressedz[Key.NUM4] || GameCanvas.keyPressedz[23])
				{
					indexSelect--;
				}
				else if (GameCanvas.keyPressedz[Key.NUM6] || GameCanvas.keyPressedz[22])
				{
					indexSelect++;
				}
			}
			else if (indexSelect == 10)
			{
				if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
				{
					indexSelect -= 2;
				}
				else if (GameCanvas.keyPressedz[Key.NUM4] || GameCanvas.keyPressedz[23])
				{
					indexSelect--;
				}
				else if (GameCanvas.keyPressedz[Key.NUM6] || GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[22] || GameCanvas.keyPressedz[25])
				{
					indexSelect++;
				}
			}
			else if (indexSelect == 15)
			{
				if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
				{
					indexSelect = 9;
				}
				else if (GameCanvas.keyPressedz[Key.NUM4] || GameCanvas.keyPressedz[23])
				{
					indexSelect--;
				}
				else if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[Key.NUM6] || GameCanvas.keyPressedz[22] || GameCanvas.keyPressedz[25])
				{
					indexSelect = 0;
				}
			}
			else if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
			{
				if (indexSelect <= 1)
				{
					indexSelect = 0;
					indexTitle = 0;
				}
				else
				{
					indexSelect -= 2;
				}
			}
			else if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
			{
				indexSelect += 2;
				if (indexSelect > 15)
				{
					indexSelect = 0;
				}
			}
			else if (GameCanvas.keyPressedz[Key.NUM4] || GameCanvas.keyPressedz[23])
			{
				indexSelect--;
				if (indexSelect < 0)
				{
					indexSelect = 15;
				}
			}
			else if (GameCanvas.keyPressedz[Key.NUM6] || GameCanvas.keyPressedz[22])
			{
				indexSelect++;
				if (indexSelect > 11)
				{
					indexSelect = 0;
				}
			}
			if (num != indexSelect)
			{
				left = (center = null);
				setLCR();
			}
		}
		else if (indexMenu == 5)
		{
			if (GameCanvas.keyPressedz[Key.NUM2])
			{
				if (indexSelect == 4)
				{
					indexSelect = 0;
					indexTitle--;
				}
				else
				{
					indexSelect--;
					if (indexSelect < 0)
					{
						indexSelect = 0;
						indexTitle--;
					}
				}
				setLCR();
			}
			else if (GameCanvas.keyPressedz[Key.NUM4] || GameCanvas.keyPressedz[23])
			{
				if (indexSelect >= 2 && indexSelect != 4)
				{
					indexSelect = 4;
				}
				else
				{
					indexSelect = 0;
				}
				setLCR();
			}
			else if (GameCanvas.keyPressedz[Key.NUM6] || GameCanvas.keyPressedz[22])
			{
				if (indexSelect < 2)
				{
					indexSelect = 4;
				}
				else
				{
					indexSelect = 2;
				}
				setLCR();
			}
			else if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
			{
				indexSelect++;
				if (indexSelect >= 4)
				{
					indexSelect = 0;
				}
				setLCR();
			}
		}
		else if (indexMenu == 6)
		{
			if (indexBijuuMenu == 0)
			{
				if (GameCanvas.keyPressedz[Key.NUM2])
				{
					if (indexSelect == 4)
					{
						indexSelect = 0;
						indexTitle--;
					}
					else
					{
						indexSelect--;
						if (indexSelect < 0)
						{
							indexSelect = 0;
							indexTitle--;
						}
					}
					setLCR();
				}
				else if (GameCanvas.keyPressedz[Key.NUM4])
				{
					if (indexSelect >= 2 && indexSelect != 4)
					{
						indexSelect = 4;
					}
					else
					{
						indexSelect = 0;
					}
					setLCR();
				}
				else if (GameCanvas.keyPressedz[Key.NUM6])
				{
					if (indexSelect < 2)
					{
						indexSelect = 4;
					}
					else
					{
						indexSelect = 2;
					}
					setLCR();
				}
				else if (GameCanvas.keyPressedz[Key.NUM8])
				{
					indexSelect++;
					if (indexSelect >= 4)
					{
						indexSelect = 0;
					}
					setLCR();
				}
			}
			else if (indexBijuuMenu == 1)
			{
				if (GameCanvas.keyPressedz[Key.NUM2])
				{
					indexTitle--;
				}
				else if (GameCanvas.keyPressedz[Key.NUM8])
				{
					indexTitle++;
					if (indexTitle >= 5)
					{
						indexTitle = 1;
					}
					left = (center = null);
					setLCR();
				}
			}
			else if (GameCanvas.keyPressedz[Key.NUM2])
			{
				if (indexTitle == 1 && indexRow == -1)
				{
					indexTitle--;
				}
				else if (indexTitle == 1 && indexRow >= 0)
				{
					indexRow--;
				}
				scrInfo.moveTo(indexRow * scrInfo.ITEM_SIZE);
			}
			else if (GameCanvas.keyPressedz[Key.NUM8])
			{
				if (indexTitle == 0)
				{
					indexTitle++;
				}
				else if (indexTitle == 1)
				{
					indexRow++;
					if (indexRow >= indexRowMax)
					{
						indexRow = 0;
					}
					scrInfo.moveTo(indexRow * scrInfo.ITEM_SIZE);
				}
				left = (center = null);
				setLCR();
			}
			else if (GameCanvas.keyPressedz[Key.NUM4])
			{
				indexRow = -1;
				if (indexTitle == 1)
				{
					indexSelect--;
					if (indexSelect < 0)
					{
						indexSelect = Char.getMyChar().nClass.skillTemplates.Length - 1;
					}
				}
				left = (center = null);
				setLCR();
				scrMain.moveTo(indexSelect * scrMain.ITEM_SIZE);
				scrInfo.clear();
				indexRow = 0;
			}
			else if (GameCanvas.keyPressedz[Key.NUM6])
			{
				indexRow = -1;
				if (indexTitle == 1)
				{
					indexSelect++;
					if (indexSelect >= Char.getMyChar().nClass.skillTemplates.Length)
					{
						indexSelect = 0;
					}
				}
				left = (center = null);
				setLCR();
				scrMain.moveTo(indexSelect * scrMain.ITEM_SIZE);
				scrInfo.clear();
				indexRow = 0;
			}
		}
		if (GameCanvas.isTouch)
		{
			updateKeyUIInforMeTouch();
		}
		GameCanvas.clearKeyHold();
		GameCanvas.clearKeyPressed();
	}

	private void updateKeyUIInforMeTouch()
	{
		if (GameCanvas.menu.showMenu || GameCanvas.currentDialog != null)
		{
			return;
		}
		if (GameCanvas.isPointerJustRelease && GameCanvas.isPointerHoldIn(popupX, popupY, popupW, Hitem) && (!isPaintItemInfo || GameCanvas.w >= 320) && GameCanvas.isPointerClick)
		{
			if (GameCanvas.isPointerHoldIn(gW2 - 90, popupY + 5, 60, 40))
			{
				indexSelect = 0;
				indexMenu--;
				Sound.play(Sound.MBClick, 0.5f);
			}
			if (GameCanvas.isPointerHoldIn(gW2 + 20, popupY + 5, 60, 40))
			{
				indexSelect = 0;
				indexMenu++;
				Sound.play(Sound.MBClick, 0.5f);
			}
			isPaintItemInfo = false;
			scrMain.clear();
			scrInfo.clear();
			if (currentCharViewInfo.charID != Char.getMyChar().charID)
			{
				if (indexMenu < 3)
				{
					indexMenu = mResources.MENUME.Length - 1;
				}
				if (indexMenu > mResources.MENUME.Length - 1)
				{
					indexMenu = 3;
				}
			}
			else
			{
				if (indexMenu < 0)
				{
					indexMenu = mResources.MENUME.Length - 1;
				}
				if (indexMenu > mResources.MENUME.Length - 1)
				{
					indexMenu = 0;
				}
			}
			indexTitle = 1;
			indexSelect = -1;
			doMiniMenuInforMe();
		}
		if (isPaintItemInfo)
		{
			ScrollResult scrollResult = scrInfo.updateKey();
			if (scrollResult.isDowning || scrollResult.isFinish)
			{
				indexRow = scrollResult.selected;
				indexTitle = 1;
			}
			if (GameCanvas.isTouchControlSmallScreen)
			{
				return;
			}
		}
		if (indexMenu == 0)
		{
			ScrollResult scrollResult2 = scrMain.updateKey();
			if (!scrollResult2.isDowning && !scrollResult2.isFinish)
			{
				return;
			}
			if (indexSelect != scrollResult2.selected)
			{
				indexSelect = scrollResult2.selected;
				left = (center = null);
				if (GameCanvas.isTouchControlSmallScreen)
				{
					setLCR();
				}
				else
				{
					Item item = getItemFocus(3);
					if (item != null)
					{
						Sound.play(Sound.MBClick, 0.5f);
						actBagViewItemInfo();
					}
					else
					{
						isPaintItemInfo = false;
						left = cmdBagSortItem;
					}
				}
			}
			indexTitle = 1;
		}
		else if (indexMenu == 1)
		{
			ScrollResult scrollResult3 = scrMain.updateKey();
			if (scrollResult3.isDowning || scrollResult3.isFinish)
			{
				if (indexSelect != scrollResult3.selected)
				{
					indexSelect = scrollResult3.selected;
					if (indexSelect >= Char.getMyChar().nClass.skillTemplates.Length)
					{
						indexSelect = -1;
					}
					left = (center = null);
					setLCR();
					scrInfo.clear();
					indexRow = 0;
					if (indexSelect > -1)
					{
						Sound.play(Sound.MBClick, 0.5f);
					}
				}
				indexTitle = 1;
			}
			else
			{
				ScrollResult scrollResult4 = scrInfo.updateKey();
				if ((scrollResult4.isDowning || scrollResult4.isFinish) && indexRow != scrollResult4.selected)
				{
					indexRow = scrollResult4.selected;
				}
			}
		}
		else if (indexMenu == 2)
		{
			if (!GameCanvas.isPointerJustRelease || !GameCanvas.isPointerJustRelease)
			{
				return;
			}
			int num = 0;
			if (!Main.isPC)
			{
				num = indexSize;
			}
			if (GameCanvas.isPointerHoldIn(popupX + 5, popupY + 52, popupW - 10, 111 - num) && GameCanvas.isPointerClick)
			{
				int num2 = (GameCanvas.py - (popupY + 52)) / ((!Main.isPC) ? 22 : 27);
				num2++;
				if (num2 == indexTiemNang)
				{
					doUPPOINT();
				}
				indexTitle = num2;
				indexTiemNang = num2;
				Sound.play(Sound.MBClick, 0.5f);
				setLCR();
			}
		}
		else if (indexMenu == 3)
		{
			ScrollResult scrollResult5 = scrMain.updateKey();
			if (scrollResult5.isDowning || scrollResult5.isFinish)
			{
				indexRow = scrollResult5.selected;
				indexTitle = 1;
			}
		}
		else if (indexMenu == 4)
		{
			if (GameCanvas.isPointerJustRelease)
			{
				indexTitle = 1;
				if (GameCanvas.isPointerHoldIn(popupX + 4, popupY + 35, indexSize, 130))
				{
					int num3 = (GameCanvas.py - (popupY + 35)) / indexSize;
					num3 = (indexSelect = num3 * 2);
					Sound.play(Sound.MBClick, 0.5f);
					left = (center = null);
					setLCR();
				}
				if (GameCanvas.isPointerHoldIn(popupX + popupW - 30, popupY + 35, indexSize, 130))
				{
					int num4 = (GameCanvas.pyLast - (popupY + 35)) / indexSize;
					num4 = (indexSelect = num4 * 2 + 1);
					left = (center = null);
					setLCR();
					Sound.play(Sound.MBClick, 0.5f);
				}
				if (GameCanvas.isPointerHoldIn(popupX + 4, popupY + 165, popupW - 8, indexSize))
				{
					int num5 = (GameCanvas.pxLast - (popupX + 4)) / indexSize;
					num5 = (indexSelect = 10 + num5);
					left = (center = null);
					setLCR();
					Sound.play(Sound.MBClick, 0.5f);
				}
			}
		}
		else if (indexMenu == 5)
		{
			if (!GameCanvas.isPointerJustRelease)
			{
				return;
			}
			for (int i = 0; i < xMounts.Length; i++)
			{
				if (i == 4)
				{
					if (GameCanvas.isPointerHoldIn(xMounts[i], yMounts[i], 84, 75) && GameCanvas.isPointerClick)
					{
						indexTitle = 1;
						indexSelect = 4;
						setLCR();
						if (!GameCanvas.isTouchControlSmallScreen && center != null)
						{
							actionPerform(center.idAction, center.p);
						}
					}
				}
				else
				{
					if (!GameCanvas.isPointerHoldIn(xMounts[i], yMounts[i], indexSize, indexSize) || !GameCanvas.isPointerClick)
					{
						continue;
					}
					indexTitle = 1;
					indexSelect = i;
					setLCR();
					if (!GameCanvas.isTouchControlSmallScreen)
					{
						if (currentCharViewInfo.arrItemMounts[indexSelect] != null)
						{
							actionPerform(center.idAction, center.p);
						}
						else
						{
							isPaintItemInfo = false;
						}
					}
				}
			}
		}
		else
		{
			if (indexMenu != 6)
			{
				return;
			}
			if (indexBijuuMenu == 0)
			{
				if (!GameCanvas.isPointerJustRelease)
				{
					return;
				}
				for (int j = 0; j < xMounts.Length; j++)
				{
					if (j == 4)
					{
						if (GameCanvas.isPointerHoldIn(xMounts[j], yMounts[j], 84, 75) && GameCanvas.isPointerClick)
						{
							indexTitle = 1;
							indexSelect = 4;
							setLCR();
							if (!GameCanvas.isTouchControlSmallScreen && center != null)
							{
								actionPerform(center.idAction, center.p);
							}
						}
					}
					else
					{
						if (!GameCanvas.isPointerHoldIn(xMounts[j], yMounts[j], indexSize, indexSize) || !GameCanvas.isPointerClick)
						{
							continue;
						}
						indexTitle = 1;
						indexSelect = j;
						setLCR();
						if (!GameCanvas.isTouchControlSmallScreen)
						{
							if (currentCharViewInfo.arrItemMounts[indexSelect] != null)
							{
								actionPerform(center.idAction, center.p);
							}
							else
							{
								isPaintItemInfo = false;
							}
						}
					}
				}
				return;
			}
			if (indexBijuuMenu == 1)
			{
				if (GameCanvas.isPointerJustRelease && GameCanvas.isPointerHoldIn(popupX + 5, popupY + 52, popupW - 10, 130) && GameCanvas.isPointerClick)
				{
					int num6 = (GameCanvas.py - (popupY + 52)) / 32;
					num6++;
					if (num6 == indexTiemNang)
					{
						actBijuuMenuPoint();
					}
					indexTitle = num6;
					indexTiemNang = num6;
					setLCR();
				}
				return;
			}
			ScrollResult scrollResult6 = scrMain.updateKey();
			if (scrollResult6.isDowning || scrollResult6.isFinish)
			{
				if (indexSelect != scrollResult6.selected)
				{
					indexSelect = scrollResult6.selected;
					if (indexSelect >= Char.getMyChar().nClass.skillTemplates.Length)
					{
						indexSelect = -1;
					}
					left = (center = null);
					setLCR();
					scrInfo.clear();
					indexRow = 0;
				}
				indexTitle = 1;
			}
			else
			{
				ScrollResult scrollResult7 = scrInfo.updateKey();
				if ((scrollResult7.isDowning || scrollResult7.isFinish) && indexRow != scrollResult7.selected)
				{
					indexRow = scrollResult7.selected;
				}
			}
		}
	}

	public void updateKeySelectZone()
	{
		if (!isPaintZone || GameCanvas.currentDialog != null)
		{
			return;
		}
		bool flag = false;
		if (GameCanvas.keyPressedz[Key.NUM4] || GameCanvas.keyPressedz[23])
		{
			indexSelect--;
			if (indexSelect < 0)
			{
				indexSelect = zones.Length - 1;
			}
			flag = true;
		}
		else if (GameCanvas.keyPressedz[Key.NUM6] || GameCanvas.keyPressedz[22])
		{
			indexSelect++;
			if (indexSelect >= zones.Length)
			{
				indexSelect = 0;
			}
			flag = true;
		}
		else if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
		{
			if (indexSelect + zoneCol <= zones.Length - 1)
			{
				indexSelect += zoneCol;
			}
			flag = true;
		}
		else if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
		{
			if (indexSelect - zoneCol >= 0)
			{
				indexSelect -= zoneCol;
			}
			flag = true;
		}
		if (flag)
		{
			scrMain.moveTo(indexSelect / columns * scrMain.ITEM_SIZE);
			GameCanvas.clearKeyHold();
			GameCanvas.clearKeyPressed();
		}
		if (!GameCanvas.isTouch)
		{
			return;
		}
		ScrollResult scrollResult = scrMain.updateKey();
		if (scrollResult.isDowning || scrollResult.isFinish)
		{
			indexSelect = scrollResult.selected;
			if (scrollResult.isFinish)
			{
				Sound.play(Sound.MBClick, 0.5f);
			}
		}
	}

	public void updateKeyAlert()
	{
		if (!isPaintAlert || GameCanvas.currentDialog != null)
		{
			return;
		}
		bool flag = false;
		if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
		{
			indexRow++;
			if (indexRow >= texts.size())
			{
				indexRow = 0;
			}
			flag = true;
		}
		else if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
		{
			indexRow--;
			if (indexRow < 0)
			{
				indexRow = texts.size() - 1;
			}
			flag = true;
		}
		if (flag)
		{
			scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
			GameCanvas.clearKeyHold();
			GameCanvas.clearKeyPressed();
		}
		if (GameCanvas.isTouch)
		{
			ScrollResult scrollResult = scrMain.updateKey();
			if (scrollResult.isDowning || scrollResult.isFinish)
			{
				indexRow = scrollResult.selected;
				flag = true;
			}
		}
		if (isPaintMessage && !GameCanvas.isTouch)
		{
			ChatTab currentChatTab = ChatManager.gI().getCurrentChatTab();
			if (currentChatTab.type == 2 && indexRow == 0)
			{
				ChatTextField.gI().center = new Command(mResources.HIDE_TAB, 120051, currentChatTab);
			}
		}
		if (!flag || indexRow < 0 || indexRow >= texts.size())
		{
			return;
		}
		string text = (string)texts.elementAt(indexRow);
		int num = -1;
		fnick = null;
		alertURL = null;
		center = null;
		ChatTextField.gI().center = null;
		if ((num = text.IndexOf("http://")) >= 0)
		{
			alertURL = text.Substring(num);
			center = new Command(mResources.OPEN_LINK, 12000);
			if (!GameCanvas.isTouch)
			{
				ChatTextField.gI().center = new Command(mResources.OPEN_LINK, null, 12000, null);
			}
		}
		else
		{
			if ((num = text.IndexOf("@")) < 0)
			{
				return;
			}
			string text2 = text.Substring(2);
			text2 = text2.Trim();
			num = text2.IndexOf("@");
			string text3 = text2.Substring(num);
			int num2 = -1;
			num2 = text3.IndexOf(" ");
			num2 = ((num2 > 0) ? (num2 + num) : (num + text3.Length));
			fnick = text2.Substring(num + 1, num2 - 1);
			if (!fnick.Equals(string.Empty) && !fnick.Equals(Char.getMyChar().cName) && !fnick.Equals(mResources.SERVER_ALERT.Substring(0, 5)) && !fnick.Equals(mResources.SERVER_ALERT))
			{
				center = new Command(mResources.SELECT, 12009, fnick);
				if (!GameCanvas.isTouch)
				{
					ChatTextField.gI().center = new Command(mResources.SELECT, null, 12009, fnick);
				}
			}
			else
			{
				fnick = null;
				center = null;
			}
		}
	}

	public void updateKeyMessage()
	{
		if (!isPaintMessage || (Main.isPC && ChatTextField.gI().isShow))
		{
			return;
		}
		bool flag = false;
		if (GameCanvas.keyPressedz[Key.NUM4] || GameCanvas.keyPressedz[23])
		{
			flag = true;
			ChatManager.gI().switchToPreviousTab();
			Sound.play(Sound.MBClick, 0.5f);
		}
		else if (GameCanvas.keyPressedz[Key.NUM6] || GameCanvas.keyPressedz[22])
		{
			flag = true;
			ChatManager.gI().switchToNextTab();
			Sound.play(Sound.MBClick, 0.5f);
		}
		if (flag)
		{
			openUIChatTab();
		}
		if (GameCanvas.isTouch && GameCanvas.isTouch && GameCanvas.isPointerHoldIn(popupX, popupY, popupW, Hitem) && (!isPaintItemInfo || GameCanvas.w >= 320) && GameCanvas.isPointerClick && GameCanvas.isPointerJustRelease)
		{
			if (GameCanvas.isPointerHoldIn(gW2 - 90, popupY + 5, 60, 40))
			{
				ChatManager.gI().switchToPreviousTab();
				openUIChatTab();
				Sound.play(Sound.MBClick, 0.5f);
			}
			if (GameCanvas.isPointerHoldIn(gW2 + 20, popupY + 5, 60, 40))
			{
				ChatManager.gI().switchToNextTab();
				openUIChatTab();
				Sound.play(Sound.MBClick, 0.5f);
			}
		}
	}

	private void setCharFocusCommand()
	{
		if (indexRow >= 0 && vCharInMap.size() > 0)
		{
			if (Char.getIndexChar(cLastFocusID) == indexRow)
			{
				left = new Command(mResources.UNSELECT, 14002);
				return;
			}
			left = new Command(mResources.SELECT, 14003);
			center = new Command(string.Empty, 14003);
		}
		else
		{
			left = (center = null);
		}
	}

	public void updateSelectList()
	{
		if (!isPaintRankedList && !isPaintTeam && !isPaintFindTeam && !isPaintFriend && !isPaintEnemies && !isPaintCharInMap && !isPaintList && !isPaintAuctionBuy)
		{
			return;
		}
		if (isPaintAuctionBuy)
		{
			if (!isPaintAuctionBuy)
			{
				return;
			}
			ScrollResult scrollResult = scrMain.updateKey();
			if (scrollResult.isDowning || scrollResult.isFinish)
			{
				indexSelect = scrollResult.selected;
				if (indexSelect >= arrItemStands.Length)
				{
					indexSelect = -1;
				}
				if (indexSelect >= 0)
				{
					indexTitle = 1;
				}
				updateCommandForUI();
			}
			return;
		}
		if (isPaintTeam)
		{
			if (vParty.size() == 0)
			{
				return;
			}
			if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
			{
				indexRow++;
				if (indexRow >= vParty.size())
				{
					indexRow = vParty.size() - 1;
				}
				scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
			}
			else if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
			{
				indexRow--;
				if (indexRow < 0)
				{
					indexRow = 0;
				}
				scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
			}
			setPartyCommand();
		}
		else if (isPaintFindTeam)
		{
			if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
			{
				indexRow++;
				if (indexRow >= vPtMap.size())
				{
					indexRow = vPtMap.size() - 1;
				}
				scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
			}
			else if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
			{
				indexRow--;
				if (indexRow < 0)
				{
					indexRow = 0;
				}
				scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
			}
			refreshFindTeam();
		}
		else if (isPaintFriend)
		{
			if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
			{
				indexRow++;
				if (indexRow >= indexRowMax)
				{
					indexRow = 0;
				}
				scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
			}
			else if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
			{
				indexRow--;
				if (indexRow < 0)
				{
					indexRow = indexRowMax - 1;
				}
				scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
			}
			setFriendCommand();
		}
		else if (isPaintEnemies)
		{
			if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
			{
				indexRow++;
				if (indexRow >= indexRowMax)
				{
					indexRow = 0;
				}
				scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
			}
			else if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
			{
				indexRow--;
				if (indexRow < 0)
				{
					indexRow = indexRowMax - 1;
				}
				scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
			}
			setEnemiesCommand();
		}
		else if (isPaintCharInMap)
		{
			if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
			{
				indexRow++;
				if (indexRow >= vCharInMap.size())
				{
					indexRow = vCharInMap.size() - 1;
				}
				scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
			}
			else if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
			{
				indexRow--;
				if (indexRow < 0)
				{
					indexRow = 0;
				}
				scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
			}
			if (cLastFocusID > 0 && !GameCanvas.isTouch)
			{
				scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
			}
			setCharFocusCommand();
		}
		else if (isPaintList)
		{
			if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
			{
				indexRow++;
				if (indexRow >= vList.size())
				{
					indexRow = vList.size() - 1;
				}
				scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
			}
			else if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
			{
				indexRow--;
				if (indexRow < 0)
				{
					indexRow = 0;
				}
				scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
			}
			setDunListCommand();
		}
		else if (isPaintRankedList)
		{
			if (GameCanvas.keyPressedz[Key.NUM8])
			{
				indexRow++;
				if (indexRow >= vList.size())
				{
					indexRow = vList.size() - 1;
				}
				scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
			}
			else if (GameCanvas.keyPressedz[Key.NUM2])
			{
				indexRow--;
				if (indexRow < 0)
				{
					indexRow = 0;
				}
				scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
			}
			setRankedListCommand();
		}
		if (GameCanvas.isTouch && GameCanvas.currentDialog == null && !GameCanvas.menu.showMenu)
		{
			MyVector myVector = null;
			if (isPaintTeam)
			{
				myVector = vParty;
			}
			else if (isPaintFriend)
			{
				myVector = vFriend;
			}
			else if (isPaintEnemies)
			{
				myVector = vEnemies;
			}
			else if (isPaintFindTeam)
			{
				myVector = vPtMap;
			}
			else if (isPaintCharInMap)
			{
				myVector = vCharInMap;
			}
			else if (isPaintList)
			{
				myVector = vList;
			}
			else if (isPaintRankedList)
			{
				myVector = vList;
			}
			ScrollResult scrollResult2 = scrMain.updateKey();
			if (scrollResult2.isDowning || scrollResult2.isFinish)
			{
				indexRow = scrollResult2.selected;
				if (indexRow >= myVector.size())
				{
					indexRow = -1;
				}
				if (isPaintTeam)
				{
					setPartyCommand();
				}
				else if (isPaintFriend)
				{
					setFriendCommand();
				}
				else if (isPaintEnemies)
				{
					setEnemiesCommand();
				}
				else if (isPaintCharInMap)
				{
					setCharFocusCommand();
				}
				else if (isPaintList)
				{
					setDunListCommand();
				}
				else if (isPaintRankedList)
				{
					setRankedListCommand();
				}
			}
		}
		GameCanvas.clearKeyHold();
		GameCanvas.clearKeyPressed();
	}

	private void setRankedListCommand()
	{
		if (vList.size() > 0 && indexRow >= 0 && indexRowMax > 0)
		{
			center = new Command(mResources.RANKED_MATCH, 14024);
			left = new Command(mResources.PLAYER_INFO, 14025);
		}
		else
		{
			center = null;
			left = null;
		}
	}

	private void setDunListCommand()
	{
		if (vList.size() > 0 && indexRow >= 0 && indexRowMax > 0)
		{
			center = new Command(mResources.SELECT, 14021);
		}
		else
		{
			center = null;
		}
	}

	private void setEnemiesCommand()
	{
		if (vEnemies.size() > 0 && indexRow >= 0 && indexRowMax > 0)
		{
			center = new Command(mResources.SELECT, 11078);
		}
		else
		{
			center = null;
		}
	}

	private void setFriendCommand()
	{
		if (vFriend.size() > 0 && indexRow >= 0 && indexRowMax > 0 && indexRow < vFriend.size())
		{
			Friend friend = (Friend)vFriend.elementAt(indexRow);
			center = new Command(mResources.SELECT, 11079);
		}
		else
		{
			center = null;
		}
	}

	private void setPartyCommand()
	{
		center = null;
		if (indexRow == -1)
		{
			return;
		}
		if (((Party)vParty.elementAt(0)).charId == Char.getMyChar().charID)
		{
			Party party = (Party)vParty.elementAt(indexRow);
			if (party.charId != Char.getMyChar().charID)
			{
				center = new Command(mResources.SELECT, 11080, party.name);
			}
		}
		else
		{
			Party party2 = (Party)vParty.elementAt(indexRow);
			if (party2.charId != Char.getMyChar().charID)
			{
				center = new Command(mResources.SELECT, 12009, party2.name);
			}
		}
	}

	public bool isPaintPopup()
	{
		if (isPaintRankedList || isPaintLuckySpin || isPaintItemInfo || isPaintInfoMe || isPaintStore || isPaintEliteShop || isPaintAuctionBuy || isPaintWeapon || isPaintNonNam || isPaintNonNu || isPaintAoNam || isPaintAoNu || isPaintGangTayNam || isPaintGangTayNu || isPaintQuanNam || isPaintQuanNu || isPaintGiayNam || isPaintGiayNu || isPaintLien || isPaintNhan || isPaintNgocBoi || isPaintPhu || isPaintStack || isPaintStackLock || isPaintGrocery || isPaintGroceryLock || isPaintUpGrade || isPaintAuctionSale || isPaintConvert || isPaintSplit || isPaintTinhluyen || isPaintDichChuyen || isPaintUpPearl || isPaintLuyenThach || isPaintBox || isPaintTrade || isPaintAlert || isPaintZone || isPaintAuto || isPaintTeam || isPaintClan || isPaintFindTeam || isPaintTask || isPaintFriend || isPaintList || isPaintEnemies || isPaintCharInMap || isPaintMessage || isPaintLucky_Draw || isPaintLuyenNgoc || isPaintKhamNgoc || isPaintGiaoDo || isPaintGotNgoc || isPaintThaoNgoc)
		{
			return true;
		}
		return false;
	}

	public bool isNotPaintTouchControl()
	{
		if (!GameCanvas.isTouch || Char.ischangingMap || isPaintZone || isPaintAuto)
		{
			return true;
		}
		if (ChatTextField.gI().isShow)
		{
			return true;
		}
		if (center == cmdDead && GameCanvas.isTouchControlLargeScreen)
		{
			return true;
		}
		if (GameCanvas.currentDialog != null || ChatPopup.currentMultilineChatPopup != null || GameCanvas.menu.showMenu || isPaintPopup())
		{
			return true;
		}
		return false;
	}

	public bool isPaintUI()
	{
		if (isPaintAuto || isPaintStore || isPaintLuckySpin || isPaintEliteShop || isPaintWeapon || isPaintNonNam || isPaintNonNu || isPaintAoNam || isPaintAoNu || isPaintGangTayNam || isPaintGangTayNu || isPaintQuanNam || isPaintQuanNu || isPaintGiayNam || isPaintGiayNu || isPaintLien || isPaintNhan || isPaintNgocBoi || isPaintPhu || isPaintStack || isPaintStackLock || isPaintGrocery || isPaintGroceryLock || isPaintUpGrade || isPaintAuctionBuy || isPaintAuctionSale || isPaintConvert || isPaintSplit || isPaintTinhluyen || isPaintDichChuyen || isPaintUpPearl || isPaintLuyenThach || isPaintBox || isPaintTrade || isPaintLuyenNgoc || isPaintKhamNgoc || isPaintGiaoDo || isPaintGotNgoc || isPaintThaoNgoc)
		{
			return true;
		}
		return false;
	}

	public bool isOpenUI()
	{
		if (isPaintAuto || isPaintItemInfo || isPaintLuckySpin || isPaintInfoMe || isPaintStore || isPaintEliteShop || isPaintWeapon || isPaintNonNam || isPaintNonNu || isPaintAoNam || isPaintAoNu || isPaintGangTayNam || isPaintGangTayNu || isPaintQuanNam || isPaintQuanNu || isPaintGiayNam || isPaintGiayNu || isPaintLien || isPaintNhan || isPaintNgocBoi || isPaintPhu || isPaintStack || isPaintStackLock || isPaintGrocery || isPaintGroceryLock || isPaintUpGrade || isPaintAuctionBuy || isPaintAuctionSale || isPaintConvert || isPaintSplit || isPaintTinhluyen || isPaintDichChuyen || isPaintUpPearl || isPaintLuyenThach || isPaintBox || isPaintTrade || isPaintLuyenNgoc || isPaintKhamNgoc || isPaintGiaoDo || isPaintGotNgoc || isPaintThaoNgoc)
		{
			return true;
		}
		return false;
	}

	public static bool isSmallUI()
	{
		if (isPaintRankedList || (isPaintInfoMe && indexMenu == 6 && indexBijuuMenu != 0) || (isPaintInfoMe && indexMenu > 0 && indexMenu < 5) || isPaintAuto || isPaintZone || (isPaintClan && (indexMenu == 0 || indexMenu == 1 || indexMenu == 3 || indexMenu == 4)) || isPaintCharInMap || isPaintTeam || isPaintFindTeam || isPaintFriend || isPaintList || isPaintEnemies || isPaintTask || isPaintMessage || isPaintAlert || isPaintLucky_Draw)
		{
			return true;
		}
		return false;
	}

	public void actionBuy(Item item)
	{
		Command ok = new Command(mResources.ACCEPT, 11055, item);
		GameCanvas.inputDlg.show(mResources.INPUT_QUANTITY, ok, TField.INPUT_TYPE_NUMERIC);
	}

	public void actionSale(Item item)
	{
		GameCanvas.inputDlg.tfInput.getText();
		if (item.quantity > 1)
		{
			Command ok = new Command(mResources.ACCEPT, 110562, item);
			GameCanvas.inputDlg.show(mResources.INPUT_QUANTITY, ok, TField.INPUT_TYPE_NUMERIC);
		}
		else
		{
			GameCanvas.startYesNoDlg(mResources.CONFIRMSALEITEM, new Command(mResources.YES, 11061, item), new Command(mResources.NO, 1));
		}
	}

	public void actionCoinOut()
	{
		Command ok = new Command(mResources.ACCEPT, 11042);
		GameCanvas.inputDlg.show(mResources.INPUT_COIN, ok, TField.INPUT_TYPE_NUMERIC);
	}

	public void actionCoinTrade()
	{
		Command ok = new Command(mResources.ACCEPT, 110361);
		GameCanvas.inputDlg.show(mResources.INPUT_COIN, ok, TField.INPUT_TYPE_NUMERIC);
	}

	public void actionCoinIn()
	{
		Command ok = new Command(mResources.ACCEPT, 11043);
		GameCanvas.inputDlg.show(mResources.INPUT_COIN, ok, TField.INPUT_TYPE_NUMERIC);
	}

	public void updateKeyBuyItemUI()
	{
		if (GameCanvas.currentDialog != null || !isPaintUI())
		{
			return;
		}
		if (indexTitle == 0)
		{
			updateKeyBuyItemUITitle();
		}
		else if (indexTitle >= 1)
		{
			if (isPaintItemInfo)
			{
				if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
				{
					indexRow--;
					if (indexRow < 0)
					{
						indexRow = indexRowMax - 1;
					}
					scrInfo.moveTo(indexRow * scrInfo.ITEM_SIZE);
				}
				else if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
				{
					indexRow++;
					if (indexRow >= indexRowMax)
					{
						indexRow = 0;
					}
					scrInfo.moveTo(indexRow * scrInfo.ITEM_SIZE);
				}
			}
			else
			{
				if (isPaintAuto)
				{
					if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
					{
						indexRow--;
						if (indexRow < 0)
						{
							indexRow = indexRowMax;
						}
						scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
					}
					else if (GameCanvas.keyPressedz[Key.NUM4] || GameCanvas.keyPressedz[23])
					{
						if (indexRow == 0)
						{
							Char.aHpValue -= 10;
							if (Char.aHpValue < 10)
							{
								Char.aHpValue = 10;
							}
						}
						else if (indexRow == 1)
						{
							Char.aMpValue -= 10;
							if (Char.aMpValue < 10)
							{
								Char.aMpValue = 10;
							}
						}
						else if (indexRow == 2)
						{
							Char.aFoodValue -= 10;
							if (Char.aFoodValue <= 0)
							{
								Char.aFoodValue = 1;
							}
						}
					}
					else if (GameCanvas.keyPressedz[Key.NUM6] || GameCanvas.keyPressedz[22])
					{
						if (indexRow == 0)
						{
							Char.aHpValue += 10;
							if (Char.aHpValue > 90)
							{
								Char.aHpValue = 90;
							}
						}
						else if (indexRow == 1)
						{
							Char.aMpValue += 10;
							if (Char.aMpValue > 90)
							{
								Char.aMpValue = 90;
							}
						}
						else if (indexRow == 2)
						{
							if (Char.aFoodValue == 1)
							{
								Char.aFoodValue = 10;
							}
							else
							{
								Char.aFoodValue += 10;
								if (Char.aFoodValue > 70)
								{
									Char.aFoodValue = 70;
								}
							}
						}
					}
					else if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
					{
						indexRow++;
						if (indexRow > indexRowMax)
						{
							indexRow = 0;
						}
						scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
					}
				}
				if (!GameCanvas.isTouch)
				{
					GameCanvas.clearKeyHold();
					GameCanvas.clearKeyPressed();
				}
				else if (isPaintTrade && indexMenu == 0)
				{
					int num = 12;
					if (indexTitle == 1)
					{
						if (GameCanvas.keyPressedz[Key.NUM4] || GameCanvas.keyPressedz[23])
						{
							indexSelect--;
							if (indexSelect < 0)
							{
								indexSelect = num - 1;
							}
							left = (center = null);
							updateCommandForUI();
						}
						else if (GameCanvas.keyPressedz[Key.NUM6] || GameCanvas.keyPressedz[22])
						{
							if (indexSelect == 2)
							{
								indexTitle = 2;
								indexSelect = 0;
							}
							else if (indexSelect == 5)
							{
								indexTitle = 2;
								indexSelect = 3;
							}
							else if (indexSelect == 8)
							{
								indexTitle = 2;
								indexSelect = 6;
							}
							else if (indexSelect == 11)
							{
								indexTitle = 2;
								indexSelect = 9;
							}
							else if (indexSelect == 14)
							{
								indexTitle = 2;
								indexSelect = 12;
							}
							else
							{
								indexSelect++;
								if (indexSelect >= num)
								{
									indexSelect = 0;
								}
							}
							left = (center = null);
							updateCommandForUI();
						}
						else if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
						{
							if (indexSelect + 3 <= num - 1)
							{
								indexSelect += 3;
							}
							left = (center = null);
							updateCommandForUI();
						}
						else if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
						{
							if (indexSelect >= 0 && indexSelect < 3)
							{
								indexTitle = 0;
								indexSelect = 0;
							}
							else if (indexSelect - 3 >= 0)
							{
								indexSelect -= 3;
							}
							left = (center = null);
							updateCommandForUI();
						}
					}
					else if (indexTitle == 2)
					{
						if (GameCanvas.keyPressedz[Key.NUM4] || GameCanvas.keyPressedz[23])
						{
							if (indexSelect == 0)
							{
								indexTitle = 1;
								indexSelect = 2;
							}
							else if (indexSelect == 3)
							{
								indexTitle = 1;
								indexSelect = 5;
							}
							else if (indexSelect == 6)
							{
								indexTitle = 1;
								indexSelect = 8;
							}
							else if (indexSelect == 9)
							{
								indexTitle = 1;
								indexSelect = 11;
							}
							else if (indexSelect == 12)
							{
								indexTitle = 1;
								indexSelect = 14;
							}
							else
							{
								indexSelect--;
								if (indexSelect < 0)
								{
									indexSelect = num - 1;
								}
							}
							left = (center = null);
							updateCommandForUI();
						}
						else if (GameCanvas.keyPressedz[Key.NUM6] || GameCanvas.keyPressedz[22])
						{
							indexSelect++;
							if (indexSelect >= num)
							{
								indexSelect = 0;
							}
							left = (center = null);
							updateCommandForUI();
						}
						else if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
						{
							if (indexSelect + 3 <= num - 1)
							{
								indexSelect += 3;
							}
							left = (center = null);
							updateCommandForUI();
						}
						else if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
						{
							if (indexSelect >= 0 && indexSelect < 3)
							{
								indexTitle = 0;
								indexSelect = 0;
							}
							else if (indexSelect - 3 >= 0)
							{
								indexSelect -= 3;
							}
							left = (center = null);
							updateCommandForUI();
						}
					}
					if (!GameCanvas.isTouch)
					{
						GameCanvas.clearKeyHold();
						GameCanvas.clearKeyPressed();
					}
				}
				else if (isPaintLuckySpin)
				{
					if (GameCanvas.keyPressedz[Key.NUM4] || GameCanvas.keyPressedz[23])
					{
						indexSelect--;
						if (indexSelect < 0)
						{
							indexSelect = 8;
						}
					}
					else if (GameCanvas.keyPressedz[Key.NUM6] || GameCanvas.keyPressedz[22])
					{
						indexSelect++;
						if (indexSelect > 8)
						{
							indexSelect = 0;
						}
					}
					else if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
					{
						if (indexSelect + 3 < 9)
						{
							indexSelect += 3;
						}
					}
					else if ((GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24]) && indexSelect - 3 >= 0)
					{
						indexSelect -= 3;
					}
					if (!GameCanvas.isTouch)
					{
						GameCanvas.clearKeyHold();
						GameCanvas.clearKeyPressed();
					}
				}
				else if (isPaintAuctionSale && indexMenu == 0)
				{
					if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
					{
						indexTitle--;
						if (indexTitle < 0)
						{
							indexTitle = 0;
						}
					}
					else if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
					{
						indexTitle++;
						if (indexTitle > 2)
						{
							indexTitle = 2;
						}
					}
					updateCommandForUI();
				}
				else if (isPaintAuctionBuy)
				{
					if (GameCanvas.keyPressedz[Key.NUM4] || GameCanvas.keyPressedz[23])
					{
						if (arrItemStands != null)
						{
							indexSelect -= 5;
							if (indexSelect < 0)
							{
								indexSelect = arrItemStands.Length - 1;
							}
							scrMain.moveTo(indexSelect * scrMain.ITEM_SIZE);
							updateCommandForUI();
						}
					}
					else if (GameCanvas.keyPressedz[Key.NUM6] || GameCanvas.keyPressedz[22])
					{
						if (arrItemStands != null)
						{
							indexSelect += 5;
							if (indexSelect >= arrItemStands.Length)
							{
								indexSelect = 0;
							}
							scrMain.moveTo(indexSelect * scrMain.ITEM_SIZE);
							updateCommandForUI();
						}
					}
					else if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
					{
						if (arrItemStands != null)
						{
							indexSelect++;
							if (indexSelect >= arrItemStands.Length)
							{
								indexSelect = 0;
							}
							scrMain.moveTo(indexSelect * scrMain.ITEM_SIZE);
							updateCommandForUI();
						}
					}
					else if ((GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24]) && arrItemStands != null)
					{
						indexSelect--;
						if (indexSelect < 0)
						{
							indexTitle = 0;
						}
						scrMain.moveTo(indexSelect * scrMain.ITEM_SIZE);
						updateCommandForUI();
					}
					GameCanvas.clearKeyHold();
					GameCanvas.clearKeyPressed();
				}
				else if ((isPaintGiaoDo || isPaintKhamNgoc || isPaintUpGrade || isPaintConvert) && indexTitle == 1 && indexMenu == 0)
				{
					if (GameCanvas.keyPressedz[Key.NUM4] || GameCanvas.keyPressedz[23])
					{
						indexSelect--;
						if (indexSelect < 0)
						{
							indexSelect = 1;
						}
						left = (center = null);
						updateCommandForUI();
					}
					else if (GameCanvas.keyPressedz[Key.NUM6] || GameCanvas.keyPressedz[22])
					{
						indexSelect++;
						if (indexSelect > 1)
						{
							indexSelect = 0;
						}
						left = (center = null);
						updateCommandForUI();
					}
					else if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
					{
						indexTitle = 2;
						indexSelect = 0;
						left = (center = null);
						updateCommandForUI();
					}
					else if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
					{
						indexTitle = 0;
						indexSelect = 0;
						left = (center = null);
						updateCommandForUI();
					}
					if (!GameCanvas.isTouch)
					{
						GameCanvas.clearKeyHold();
						GameCanvas.clearKeyPressed();
					}
				}
				else if ((isPaintSplit || isPaintTinhluyen || isPaintDichChuyen || isPaintLuyenNgoc) && indexTitle == 1 && indexMenu == 0)
				{
					if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
					{
						indexTitle = 2;
						indexSelect = 0;
						left = (center = null);
						updateCommandForUI();
					}
					else if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
					{
						indexTitle = 0;
						indexSelect = 0;
						left = (center = null);
						updateCommandForUI();
					}
					GameCanvas.clearKeyHold();
					GameCanvas.clearKeyPressed();
				}
				else if ((isPaintGotNgoc || isPaintThaoNgoc) && indexMenu == 0)
				{
					if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
					{
						indexTitle--;
						if (indexTitle < 0)
						{
							indexTitle = 0;
						}
					}
					else if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
					{
						indexTitle++;
						if (indexTitle > 1)
						{
							indexTitle = 1;
						}
					}
					updateCommandForUI();
				}
				int maxIndexForCurrentStore = getMaxIndexForCurrentStore();
				if (GameCanvas.keyPressedz[Key.NUM4] || GameCanvas.keyPressedz[23])
				{
					indexSelect--;
					if (indexSelect < 0)
					{
						indexSelect = maxIndexForCurrentStore - 1;
					}
					left = (center = null);
					updateCommandForUI();
					scrMain.moveTo(indexSelect / columns * scrMain.ITEM_SIZE);
				}
				else if (GameCanvas.keyPressedz[Key.NUM6] || GameCanvas.keyPressedz[22])
				{
					indexSelect++;
					if (indexSelect >= maxIndexForCurrentStore)
					{
						indexSelect = 0;
					}
					left = (center = null);
					updateCommandForUI();
					scrMain.moveTo(indexSelect / columns * scrMain.ITEM_SIZE);
				}
				else if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
				{
					if (indexSelect + columns <= maxIndexForCurrentStore - 1)
					{
						indexSelect += columns;
					}
					left = (center = null);
					updateCommandForUI();
					scrMain.moveTo(indexSelect / columns * scrMain.ITEM_SIZE);
				}
				else if (GameCanvas.keyPressedz[Key.NUM2] || GameCanvas.keyPressedz[24])
				{
					if (indexSelect >= 0 && indexSelect < columns)
					{
						indexTitle = 0;
						indexSelect = 0;
						if ((isPaintKhamNgoc || isPaintUpGrade || isPaintSplit || isPaintTinhluyen || isPaintDichChuyen || isPaintConvert || isPaintLuyenNgoc) && indexMenu == 0)
						{
							indexTitle = 1;
						}
					}
					else if (indexSelect - columns >= 0)
					{
						indexSelect -= columns;
					}
					left = (center = null);
					updateCommandForUI();
					scrMain.moveTo(indexSelect / columns * scrMain.ITEM_SIZE);
				}
			}
		}
		if (GameCanvas.isTouch)
		{
			updateKeyBuyItemUITouch();
		}
		GameCanvas.clearKeyHold();
		GameCanvas.clearKeyPressed();
	}

	private int getMaxIndexForCurrentStore()
	{
		int num = 0;
		try
		{
			if (isPaintEliteShop)
			{
				num = ((arrItemElites.Length % columns != 0) ? ((arrItemElites.Length / columns + 1) * columns) : arrItemElites.Length);
			}
			else if (isPaintStore)
			{
				if (indexMenu == 0)
				{
					num = ((arrItemStore.Length % columns != 0) ? ((arrItemStore.Length / columns + 1) * columns) : arrItemStore.Length);
				}
				else if (indexMenu == 1)
				{
					num = ((arrItemBook.Length % columns != 0) ? ((arrItemBook.Length / columns + 1) * columns) : arrItemBook.Length);
				}
				else if (indexMenu == 2)
				{
					num = ((arrItemFashion.Length % columns != 0) ? ((arrItemFashion.Length / columns + 1) * columns) : arrItemFashion.Length);
				}
				else if (indexMenu == 51)
				{
					num = ((arrItemFashion.Length % columns != 0) ? ((arrItemFashion.Length / columns + 1) * columns) : arrItemFashion.Length);
				}
			}
			else if (isPaintNonNam)
			{
				num = ((arrItemNonNam.Length % columns != 0) ? ((arrItemNonNam.Length / columns + 1) * columns) : arrItemNonNam.Length);
			}
			else if (isPaintNonNu)
			{
				num = ((arrItemNonNu.Length % columns != 0) ? ((arrItemNonNu.Length / columns + 1) * columns) : arrItemNonNu.Length);
			}
			else if (isPaintAoNam)
			{
				num = ((arrItemAoNam.Length % columns != 0) ? ((arrItemAoNam.Length / columns + 1) * columns) : arrItemAoNam.Length);
			}
			else if (isPaintAoNu)
			{
				num = ((arrItemAoNu.Length % columns != 0) ? ((arrItemAoNu.Length / columns + 1) * columns) : arrItemAoNu.Length);
			}
			else if (isPaintGangTayNam)
			{
				num = ((arrItemGangTayNam.Length % columns != 0) ? ((arrItemGangTayNam.Length / columns + 1) * columns) : arrItemGangTayNam.Length);
			}
			else if (isPaintGangTayNu)
			{
				num = ((arrItemGangTayNu.Length % columns != 0) ? ((arrItemGangTayNu.Length / columns + 1) * columns) : arrItemGangTayNu.Length);
			}
			else if (isPaintQuanNam)
			{
				num = ((arrItemQuanNam.Length % columns != 0) ? ((arrItemQuanNam.Length / columns + 1) * columns) : arrItemQuanNam.Length);
			}
			else if (isPaintQuanNu)
			{
				num = ((arrItemQuanNu.Length % columns != 0) ? ((arrItemQuanNu.Length / columns + 1) * columns) : arrItemQuanNu.Length);
			}
			else if (isPaintGiayNam)
			{
				num = ((arrItemGiayNam.Length % columns != 0) ? ((arrItemGiayNam.Length / columns + 1) * columns) : arrItemGiayNam.Length);
			}
			else if (isPaintGiayNu)
			{
				num = ((arrItemGiayNu.Length % columns != 0) ? ((arrItemGiayNu.Length / columns + 1) * columns) : arrItemGiayNu.Length);
			}
			else if (isPaintLien)
			{
				num = ((arrItemLien.Length % columns != 0) ? ((arrItemLien.Length / columns + 1) * columns) : arrItemLien.Length);
			}
			else if (isPaintNhan)
			{
				num = ((arrItemNhan.Length % columns != 0) ? ((arrItemNhan.Length / columns + 1) * columns) : arrItemNhan.Length);
			}
			else if (isPaintNgocBoi)
			{
				num = ((arrItemNgocBoi.Length % columns != 0) ? ((arrItemNgocBoi.Length / columns + 1) * columns) : arrItemNgocBoi.Length);
			}
			else if (isPaintPhu)
			{
				num = ((arrItemPhu.Length % columns != 0) ? ((arrItemPhu.Length / columns + 1) * columns) : arrItemPhu.Length);
			}
			else if (isPaintWeapon)
			{
				num = ((arrItemWeapon.Length % columns != 0) ? ((arrItemWeapon.Length / columns + 1) * columns) : arrItemWeapon.Length);
			}
			else if (isPaintStack)
			{
				num = ((arrItemStack.Length % columns != 0) ? ((arrItemStack.Length / columns + 1) * columns) : arrItemStack.Length);
			}
			else if (isPaintStackLock)
			{
				num = ((arrItemStackLock.Length % columns != 0) ? ((arrItemStackLock.Length / columns + 1) * columns) : arrItemStackLock.Length);
			}
			else if (isPaintGrocery)
			{
				num = ((arrItemGrocery.Length % columns != 0) ? ((arrItemGrocery.Length / columns + 1) * columns) : arrItemGrocery.Length);
			}
			else if (isPaintGroceryLock)
			{
				num = ((arrItemGroceryLock.Length % columns != 0) ? ((arrItemGroceryLock.Length / columns + 1) * columns) : arrItemGroceryLock.Length);
			}
			if (isPaintBox)
			{
				num = Char.getMyChar().arrItemBox.Length;
			}
			if (indexMenu == 1 && !isPaintStore)
			{
				num = Char.getMyChar().arrItemBag.Length;
			}
		}
		catch (Exception ex)
		{
			Out.println(" loi tai getMaxIndex  " + ex.ToString());
		}
		if ((isPaintUpPearl || isPaintLuyenThach || isPaintSplit || isPaintTinhluyen || isPaintDichChuyen || isPaintLuyenNgoc) && indexMenu == 0)
		{
			num = 24;
		}
		else if ((isPaintKhamNgoc || isPaintUpGrade || isPaintConvert) && indexMenu == 0)
		{
			num = 18;
		}
		else if (num < 30)
		{
			num = 30;
		}
		return num;
	}

	private void getCurrentStoreData()
	{
		if (indexMenu == 0)
		{
			Service.gI().requestItem(14);
		}
		else if (indexMenu == 1)
		{
			Service.gI().requestItem(15);
		}
		else if (indexMenu == 2)
		{
			Service.gI().requestItem(32);
		}
		else if (indexMenu == 3)
		{
			Service.gI().requestItem(34);
		}
		else if (indexMenu == 51)
		{
			Service.gI().requestItem(32);
		}
	}

	private void updateKeyBuyItemUITouch()
	{
		if (GameCanvas.menu.showMenu || GameCanvas.currentDialog != null)
		{
			return;
		}
		if (GameCanvas.isPointerJustRelease && GameCanvas.isPointerHoldIn(popupX, popupY, popupW, Hitem) && (!isPaintItemInfo || GameCanvas.w >= 320) && GameCanvas.isPointerClick)
		{
			if (GameCanvas.isPointerHoldIn(gW2 - 80, popupY + 5, 60, 40))
			{
				indexSelect = 0;
				indexMenu--;
				updateCommandForUI();
				Sound.play(Sound.MBClick, 0.5f);
			}
			if (GameCanvas.isPointerHoldIn(gW2 + 10, popupY + 5, 60, 40))
			{
				indexSelect = 0;
				indexMenu++;
				updateCommandForUI();
				Sound.play(Sound.MBClick, 0.5f);
			}
			indexTitle = 0;
			if (!isPaintUI())
			{
				if (indexMenu < 0)
				{
					indexMenu = mResources.MENUME.Length - 1;
				}
				if (indexMenu > mResources.MENUME.Length - 1)
				{
					indexMenu = 0;
				}
			}
			else
			{
				if (isPaintStore)
				{
					if (indexMenu < 0)
					{
						indexMenu = mResources.TITLESTORE.Length - 1;
					}
					else if (indexMenu > mResources.TITLESTORE.Length - 1)
					{
						indexMenu = 0;
					}
					getCurrentStoreData();
				}
				else if (isPaintAuctionBuy)
				{
					if (indexMenu < 0)
					{
						indexMenu = mResources.MENUSTANDS.Length - 1;
					}
					else if (indexMenu > mResources.MENUSTANDS.Length - 1)
					{
						indexMenu = 0;
					}
					Service.gI().menu(28, 0, indexMenu);
					indexSelect = -1;
				}
				else if (isPaintEliteShop || isPaintAuto)
				{
					indexMenu = 0;
				}
				else if (indexMenu < 0)
				{
					indexMenu = 1;
				}
				else if (indexMenu > 1)
				{
					indexMenu = 0;
				}
				if (isPaintEliteShop)
				{
					indexMenu = 0;
				}
			}
			isPaintItemInfo = false;
			scrMain.clear();
		}
		if (isPaintItemInfo)
		{
			ScrollResult scrollResult = scrInfo.updateKey();
			if (scrollResult.isDowning || scrollResult.isFinish)
			{
				indexRow = scrollResult.selected;
				indexTitle = 1;
			}
			if (!GameCanvas.isTouchControlLargeScreen)
			{
				return;
			}
		}
		if (isPaintAuto)
		{
			ScrollResult scrollResult2 = scrMain.updateKey();
			if ((scrollResult2.isFinish || scrollResult2.isDowning) && indexSelect != scrollResult2.selected)
			{
				indexTitle = 1;
				indexRow = scrollResult2.selected;
				updateCommandForUI();
			}
			if (GameCanvas.isPointerInRoll(scrMain.xPos + 16, scrMain.yPos + 5, 16, 16, scrMain) && GameCanvas.isPointerClick)
			{
				Char.isAHP = !Char.isAHP;
				if (typeActive == 1)
				{
					Char.isAHP = false;
					InfoMe.addInfo(mResources.AOPENACC, 20, mFont.tahoma_7_yellow);
				}
				GameCanvas.isPointerDown = false;
			}
			if (GameCanvas.isPointerInRoll(scrMain.xPos + 16, scrMain.yPos + 35, 16, 16, scrMain) && GameCanvas.isPointerClick)
			{
				Char.isAMP = !Char.isAMP;
				if (typeActive == 1)
				{
					Char.isAMP = false;
					InfoMe.addInfo(mResources.AOPENACC, 20, mFont.tahoma_7_yellow);
				}
				GameCanvas.isPointerDown = false;
			}
			if (GameCanvas.isPointerInRoll(scrMain.xPos + 16, scrMain.yPos + 65, 16, 16, scrMain) && GameCanvas.isPointerClick)
			{
				Char.isAFood = !Char.isAFood;
				if (typeActive == 1)
				{
					Char.isAFood = false;
					InfoMe.addInfo(mResources.AOPENACC, 20, mFont.tahoma_7_yellow);
				}
				GameCanvas.isPointerDown = false;
			}
			if (GameCanvas.isPointerInRoll(scrMain.xPos + 16, scrMain.yPos + 95, 16, 16, scrMain) && GameCanvas.isPointerClick)
			{
				Char.isABuff = !Char.isABuff;
				GameCanvas.isPointerDown = false;
			}
			if (GameCanvas.isPointerInRoll(scrMain.xPos + 16, scrMain.yPos + 125, 16, 16, scrMain) && GameCanvas.isPointerClick)
			{
				Char.isAPickYen = !Char.isAPickYen;
				GameCanvas.isPointerDown = false;
				if (Char.isAPickYen)
				{
					Char.isAPickYHM = (Char.isAPickYHMS = (Char.isANoPick = false));
				}
			}
			if (GameCanvas.isPointerInRoll(scrMain.xPos + 16, scrMain.yPos + 155, 16, 16, scrMain) && GameCanvas.isPointerClick)
			{
				Char.isAPickYHM = !Char.isAPickYHM;
				GameCanvas.isPointerDown = false;
				if (Char.isAPickYHM)
				{
					Char.isAPickYen = (Char.isAPickYHMS = (Char.isANoPick = false));
				}
			}
			if (GameCanvas.isPointerInRoll(scrMain.xPos + 16, scrMain.yPos + 185, 16, 16, scrMain) && GameCanvas.isPointerClick)
			{
				Char.isAPickYHMS = !Char.isAPickYHMS;
				GameCanvas.isPointerDown = false;
				if (Char.isAPickYHMS)
				{
					Char.isAPickYen = (Char.isAPickYHM = (Char.isANoPick = false));
				}
			}
			if (GameCanvas.isPointerInRoll(scrMain.xPos + 16, scrMain.yPos + 215, 16, 16, scrMain) && GameCanvas.isPointerClick)
			{
				Char.isANoPick = !Char.isANoPick;
				GameCanvas.isPointerDown = false;
				if (Char.isANoPick)
				{
					Char.isAPickYen = (Char.isAPickYHM = (Char.isAPickYHMS = false));
				}
			}
			if (GameCanvas.isPointerInRoll(scrMain.xPos + 131, scrMain.yPos + 2, 30, 20, scrMain) && GameCanvas.isPointerClick && Char.isAHP)
			{
				GameCanvas.inputDlg.show(mResources.AHP_TEXT, new Command(mResources.OK, 1511), TField.INPUT_TYPE_NUMERIC);
				GameCanvas.isPointerDown = false;
			}
			if (GameCanvas.isPointerInRoll(scrMain.xPos + 131, scrMain.yPos + 32, 30, 20, scrMain) && GameCanvas.isPointerClick && Char.isAMP)
			{
				GameCanvas.inputDlg.show(mResources.AHP_TEXT, new Command(mResources.OK, 1512), TField.INPUT_TYPE_NUMERIC);
				GameCanvas.isPointerDown = false;
			}
			if (GameCanvas.isPointerInRoll(scrMain.xPos + 131, scrMain.yPos + 62, 30, 20, scrMain) && GameCanvas.isPointerClick && Char.isAFood)
			{
				MyVector myVector = new MyVector();
				myVector.addElement(new Command(mResources.ALEVEL[0], 15130));
				myVector.addElement(new Command(mResources.ALEVEL[1], 15131));
				myVector.addElement(new Command(mResources.ALEVEL[2], 15132));
				myVector.addElement(new Command(mResources.ALEVEL[3], 15133));
				myVector.addElement(new Command(mResources.ALEVEL[4], 15134));
				myVector.addElement(new Command(mResources.ALEVEL[5], 15135));
				myVector.addElement(new Command(mResources.ALEVEL[6], 15136));
				myVector.addElement(new Command(mResources.ALEVEL[7], 15137));
				GameCanvas.menu.startAt(myVector, 0);
				GameCanvas.menu.disableClose = true;
			}
		}
		if (isPaintEliteShop || isPaintStore || isPaintBox || isPaintGrocery || isPaintGroceryLock || isPaintStack || isPaintStackLock || isPaintNonNam || isPaintNonNu || isPaintAoNam || isPaintAoNu || isPaintGangTayNam || isPaintGangTayNu || isPaintQuanNam || isPaintQuanNu || isPaintGiayNam || isPaintGiayNu || isPaintWeapon || isPaintLien || isPaintNhan || isPaintNgocBoi || isPaintPhu)
		{
			ScrollResult scrollResult3 = scrMain.updateKey();
			if ((scrollResult3.isFinish || scrollResult3.isDowning) && indexSelect != scrollResult3.selected)
			{
				indexTitle = 1;
				indexSelect = scrollResult3.selected;
				left = (center = null);
				isPaintItemInfo = false;
				if (scrollResult3.isDowning)
				{
					Sound.play(Sound.MBClick, 0.5f);
				}
				updateCommandForUI();
			}
		}
		else if (isPaintTrade)
		{
			if (indexMenu == 0)
			{
				indexPointer(popupX + 4, popupY + Hitem + 15, 3, 4, 1);
				indexPointer(popupX + popupW - 3 - 3 * indexSize, popupY + Hitem + 15, 3, 4, 2);
			}
			else
			{
				if (indexMenu != 1)
				{
					return;
				}
				ScrollResult scrollResult4 = scrMain.updateKey();
				if ((scrollResult4.isFinish || scrollResult4.isDowning) && indexSelect != scrollResult4.selected)
				{
					indexTitle = 1;
					indexSelect = scrollResult4.selected;
					if (scrollResult4.isDowning)
					{
						Sound.play(Sound.MBClick, 0.5f);
					}
					updateCommandForUI();
				}
			}
		}
		else if (isPaintUpPearl || isPaintLuyenThach)
		{
			if (indexMenu == 0)
			{
				indexPointer(popupX + 4, popupY + Hitem + 3, 6, 4, 1);
			}
			else
			{
				if (indexMenu != 1)
				{
					return;
				}
				ScrollResult scrollResult5 = scrMain.updateKey();
				if ((scrollResult5.isFinish || scrollResult5.isDowning) && indexSelect != scrollResult5.selected)
				{
					indexTitle = 1;
					indexSelect = scrollResult5.selected;
					if (scrollResult5.isDowning)
					{
						Sound.play(Sound.MBClick, 0.5f);
					}
					updateCommandForUI();
				}
			}
		}
		else if (isPaintSplit || isPaintTinhluyen || isPaintDichChuyen || isPaintLuyenNgoc)
		{
			if (indexMenu == 0)
			{
				if (GameCanvas.isPointerHoldIn(popupX + 74, ystart - indexSize - 3, indexSize, indexSize))
				{
					indexTitle = 1;
					indexSelect = 0;
					Sound.play(Sound.MBClick, 0.5f);
					updateCommandForUI();
				}
				indexPointer(popupX + 4, popupY + 2 * Hitem + 5, 6, 4, 2);
			}
			else
			{
				if (indexMenu != 1)
				{
					return;
				}
				ScrollResult scrollResult6 = scrMain.updateKey();
				if ((scrollResult6.isFinish || scrollResult6.isDowning) && indexSelect != scrollResult6.selected)
				{
					indexTitle = 1;
					indexSelect = scrollResult6.selected;
					if (scrollResult6.isDowning)
					{
						Sound.play(Sound.MBClick, 0.5f);
					}
					updateCommandForUI();
				}
			}
		}
		else if (isPaintUpGrade || isPaintConvert || isPaintKhamNgoc)
		{
			if (indexMenu == 0)
			{
				doTouchUpgrade();
			}
			else
			{
				if (indexMenu != 1)
				{
					return;
				}
				ScrollResult scrollResult7 = scrMain.updateKey();
				if ((scrollResult7.isFinish || scrollResult7.isDowning) && indexSelect != scrollResult7.selected)
				{
					indexTitle = 1;
					indexSelect = scrollResult7.selected;
					if (scrollResult7.isDowning)
					{
						Sound.play(Sound.MBClick, 0.5f);
					}
					updateCommandForUI();
				}
			}
		}
		else if (isPaintGiaoDo)
		{
			if (indexMenu == 0)
			{
				ScrollResult scrollResult8 = scrMain.updateKey();
				if ((scrollResult8.isFinish || scrollResult8.isDowning) && indexSelect != scrollResult8.selected)
				{
					indexTitle = 1;
					indexSelect = scrollResult8.selected;
					left = (center = null);
					isPaintItemInfo = false;
					updateCommandForUI();
				}
			}
			else if (indexMenu == 1)
			{
				ScrollResult scrollResult9 = scrMain.updateKey();
				if ((scrollResult9.isFinish || scrollResult9.isDowning) && indexSelect != scrollResult9.selected)
				{
					indexTitle = 1;
					indexSelect = scrollResult9.selected;
					updateCommandForUI();
				}
			}
		}
		else if (isPaintAuctionSale)
		{
			if (indexMenu == 0)
			{
				if (GameCanvas.isPointerHoldIn(popupX + 75, popupY + 69, indexSize, indexSize))
				{
					if (GameCanvas.isPointerClick && GameCanvas.isPointerJustRelease)
					{
						indexTitle = 1;
						updateCommandForUI();
					}
				}
				else if (GameCanvas.isPointerHoldIn(tfText.x, tfText.y, tfText.width, tfText.height) && GameCanvas.isPointerClick && GameCanvas.isPointerJustRelease)
				{
					indexTitle = 2;
					tfText.isFocus = true;
					right = tfText.cmdClear;
					updateCommandForUI();
				}
			}
			else if (indexMenu == 1)
			{
				ScrollResult scrollResult10 = scrMain.updateKey();
				if ((scrollResult10.isFinish || scrollResult10.isDowning) && indexSelect != scrollResult10.selected)
				{
					indexTitle = 1;
					indexSelect = scrollResult10.selected;
					updateCommandForUI();
				}
			}
		}
		else if (isPaintLuckySpin)
		{
			int num = ((!Main.isPC) ? 36 : 40);
			if (GameCanvas.isPointerHoldIn(xstart, ystart, num * 3, num * 3) && GameCanvas.isPointerJustRelease && GameCanvas.isPointerClick)
			{
				int num2 = (indexSelect = (GameCanvas.pxLast - xstart) / num + (GameCanvas.pyLast - ystart) / num * 3);
				indexTitle = 1;
				updateCommandForUI();
				doviewCardsInfo();
			}
		}
		else
		{
			if (!isPaintGotNgoc && !isPaintThaoNgoc)
			{
				return;
			}
			if (indexMenu == 0)
			{
				if (GameCanvas.isPointerHoldIn(popupX + 75, popupY + 69, indexSize, indexSize) && GameCanvas.isPointerClick && GameCanvas.isPointerJustRelease)
				{
					indexTitle = 1;
					updateCommandForUI();
				}
			}
			else if (indexMenu == 1)
			{
				ScrollResult scrollResult11 = scrMain.updateKey();
				if ((scrollResult11.isFinish || scrollResult11.isDowning) && indexSelect != scrollResult11.selected)
				{
					indexTitle = 1;
					indexSelect = scrollResult11.selected;
					updateCommandForUI();
				}
			}
		}
	}

	private bool isCanLuyenThach()
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		for (int i = 0; i < arrItemUpPeal.Length; i++)
		{
			Item item = arrItemUpPeal[i];
			if (item != null)
			{
				if (item.template.id == 455)
				{
					num++;
				}
				else if (item.template.id == 456)
				{
					num2++;
				}
				else if (item.template.type == 26)
				{
					num3++;
					num4 = item.template.id;
				}
			}
		}
		if (num >= 9 || num2 >= 9 || (num4 >= 10 && num >= 3 && num3 == 1) || (num4 >= 11 && num2 >= 3 && num3 == 1))
		{
			return true;
		}
		return false;
	}

	private void updateKeyBuyItemUITitle()
	{
		left = (center = null);
		if (isPaintLuckySpin)
		{
			return;
		}
		if (isPaintBox)
		{
			if (svTitle.Equals(string.Empty))
			{
				if (indexMenu == 0)
				{
					left = new Command(mResources.MENU, 11115);
				}
				else if (indexMenu == 1)
				{
					left = new Command(mResources.MENU, 11116);
				}
			}
			else
			{
				left = null;
			}
		}
		else if (indexMenu == 1 && isPaintTrade && typeTrade == 0)
		{
			left = cmdTradeSendMoney;
		}
		else if (indexMenu == 1 && !isPaintStore && !isPaintEliteShop && !isPaintUpPearl && !isPaintLuyenThach && !isPaintUpGrade && !isPaintConvert && !isPaintSplit && !isPaintTinhluyen && !isPaintDichChuyen && !isPaintTrade && !isPaintAuctionBuy && !isPaintAuctionSale && !isPaintLuyenNgoc && !isPaintKhamNgoc && !isPaintGiaoDo && !isPaintGotNgoc)
		{
			left = new Command(mResources.SORT, 110221);
		}
		if (isPaintLuyenThach && indexMenu == 0)
		{
			if (isCanLuyenThach())
			{
				left = new Command(mResources.BEGIN, 1600);
			}
		}
		else if (isPaintTinhluyen)
		{
			try
			{
				if (indexMenu == 0)
				{
					if (indexTitle == 1)
					{
						if (itemSplit != null)
						{
							left = new Command(mResources.SELECT, 11103);
						}
						else
						{
							isPaintItemInfo = false;
						}
						if (GameCanvas.isTouchControlLargeScreen)
						{
							updateItemInfo(3, itemSplit);
						}
						else
						{
							center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11104, itemSplit);
						}
					}
					else if (indexTitle == 2)
					{
						Item item = arrItemSplit[indexSelect];
						if (item != null)
						{
							if (GameCanvas.isTouchControlLargeScreen)
							{
								updateItemInfo(3, item);
							}
							else
							{
								center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11104, item);
							}
							left = new Command(mResources.MOVEOUT, 1605);
						}
						else
						{
							isPaintItemInfo = false;
						}
						if (itemSplit != null)
						{
							left = new Command(mResources.SELECT, 1604);
						}
					}
				}
				else if (indexMenu == 1)
				{
					if (Char.getMyChar().arrItemBag[indexSelect] == null)
					{
						left = null;
						isPaintItemInfo = false;
					}
					else
					{
						left = new Command(mResources.SELECT, 11106);
					}
				}
			}
			catch (Exception)
			{
			}
		}
		else if (isPaintDichChuyen)
		{
			if (indexMenu == 0)
			{
				if (indexTitle == 1)
				{
					if (itemSplit != null && itemSplit.upgrade > 13)
					{
						left = new Command(mResources.SELECT, 11103);
					}
					else if (itemSplit != null)
					{
						left = cmdSplitMoveOut;
					}
					else
					{
						isPaintItemInfo = false;
					}
					if (GameCanvas.isTouchControlLargeScreen)
					{
						updateItemInfo(3, itemSplit);
					}
					else
					{
						center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11104, itemSplit);
					}
				}
				else if (indexTitle == 2)
				{
					Item item2 = arrItemSplit[indexSelect];
					if (item2 != null)
					{
						if (GameCanvas.isTouchControlLargeScreen)
						{
							updateItemInfo(3, item2);
						}
						else
						{
							center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11104, item2);
						}
					}
					else
					{
						isPaintItemInfo = false;
					}
					if (itemSplit != null && itemSplit.upgrade > 13)
					{
						left = new Command(mResources.SELECT, 1604);
					}
				}
			}
			else if (indexMenu == 1)
			{
				if (Char.getMyChar().arrItemBag[indexSelect] == null)
				{
					left = null;
					isPaintItemInfo = false;
				}
				else
				{
					left = new Command(mResources.SELECT, 1606);
				}
			}
		}
		if (isPaintUpPearl && indexMenu == 0)
		{
			int num = 0;
			for (int i = 0; i < arrItemUpPeal.Length; i++)
			{
				if (arrItemUpPeal[i] != null)
				{
					num++;
					if (num >= 2)
					{
						left = new Command(mResources.BEGIN, 11062);
						break;
					}
				}
			}
		}
		if (isPaintUpGrade && indexMenu == 0 && itemUpGrade != null)
		{
			for (int j = 0; j < arrItemUpGrade.Length; j++)
			{
				if (arrItemUpGrade[j] != null)
				{
					center = new Command(string.Empty, 110981);
					left = new Command(mResources.BEGIN, 110981);
					break;
				}
			}
		}
		if (isPaintKhamNgoc && indexMenu == 0 && itemUpGrade != null && itemSplit != null)
		{
			for (int k = 0; k < arrItemUpGrade.Length; k++)
			{
				if (arrItemUpGrade[k] != null)
				{
					center = new Command(string.Empty, 341);
					left = new Command(mResources.BEGIN, 341);
					break;
				}
			}
		}
		if (isPaintAuctionSale && indexMenu == 0 && itemSell != null && tfText != null && !tfText.getText().Equals(string.Empty) && Char.getMyChar().xu >= 5000)
		{
			left = new Command(mResources.SALE, 15002);
		}
		if (isPaintGotNgoc && indexMenu == 0 && itemSplit != null && Char.getMyChar().xu >= coinGotngoc[itemSplit.upgrade])
		{
			left = new Command(mResources.BEGIN, 111031);
		}
		if (isPaintConvert && indexMenu == 0 && indexTitle == 0)
		{
			for (int l = 0; l < arrItemConvert.Length; l++)
			{
				if (arrItemConvert[l] == null)
				{
					left = null;
					break;
				}
				if (l == arrItemConvert.Length - 1)
				{
					left = new Command(mResources.BEGIN, 140131);
				}
			}
		}
		if (isPaintSplit && indexMenu == 0 && itemSplit != null && itemSplit.upgrade > 0)
		{
			left = new Command(mResources.BEGIN, 11105);
		}
		if (isPaintTrade && indexMenu == 0)
		{
			if (typeTrade == 0)
			{
				left = cmdTradeLock;
			}
			else if (typeTrade == 1 && typeTradeOrder >= 1 && timeTrade - mSystem.getCurrentTimeMillis() / 1000 <= 0)
			{
				left = cmdTradeAccept;
			}
		}
		if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
		{
			indexTitle = 1;
			indexSelect = 0;
			indexRow = -1;
			scrMain.clear();
			scrInfo.clear();
			updateCommandForUI();
		}
		if (GameCanvas.keyPressedz[Key.NUM4] || GameCanvas.keyPressedz[23])
		{
			indexSelect = 0;
			indexRow = -1;
			indexMenu--;
			scrMain.clear();
			scrInfo.clear();
			if (isPaintAuctionBuy)
			{
				if (indexMenu < 0)
				{
					indexMenu = mResources.MENUSTANDS.Length - 1;
				}
				Service.gI().menu(28, 0, indexMenu);
				arrItemStands = null;
				indexSelect = -1;
			}
			else if (isPaintEliteShop || isPaintAuto)
			{
				indexMenu = 0;
			}
			else if (indexMenu < 0)
			{
				if (isPaintStore)
				{
					indexMenu = mResources.TITLESTORE.Length - 1;
				}
				else
				{
					indexMenu = 1;
				}
			}
			left = (center = null);
			if (isPaintStore)
			{
				getCurrentStoreData();
			}
			if (isPaintEliteShop && arrItemElites == null && indexMenu == 0)
			{
				Service.gI().requestItem(35);
			}
		}
		if (!GameCanvas.keyPressedz[Key.NUM6] && !GameCanvas.keyPressedz[22])
		{
			return;
		}
		indexSelect = 0;
		indexRow = -1;
		indexMenu++;
		scrMain.clear();
		scrInfo.clear();
		if (isPaintAuctionBuy)
		{
			if (indexMenu > mResources.MENUSTANDS.Length - 1)
			{
				indexMenu = 0;
			}
			Service.gI().menu(28, 0, indexMenu);
			arrItemStands = null;
			indexSelect = -1;
		}
		else if (isPaintEliteShop || isPaintAuto)
		{
			indexMenu = 0;
		}
		else if (isPaintStore)
		{
			if (indexMenu > 2)
			{
				indexMenu = 0;
			}
		}
		else if (indexMenu > 1)
		{
			indexMenu = 0;
		}
		left = (center = null);
		if (isPaintStore)
		{
			if (indexMenu == 0)
			{
				Service.gI().requestItem(14);
			}
			else if (indexMenu == 1)
			{
				Service.gI().requestItem(15);
			}
			else if (indexMenu == 2)
			{
				Service.gI().requestItem(32);
			}
		}
		if (isPaintEliteShop && arrItemElites == null && indexMenu == 0)
		{
			Service.gI().requestItem(35);
		}
	}

	private void doTouchUpgrade()
	{
		int x = popupX + 45;
		int y = popupY + 32;
		int x2 = popupX + 100;
		if (!GameCanvas.isPointerJustRelease)
		{
			return;
		}
		if (GameCanvas.isPointerHoldIn(x, y, 29, 29))
		{
			indexTitle = 1;
			indexSelect = 0;
			Sound.play(Sound.MBClick, 0.5f);
			updateCommandForUI();
		}
		if (GameCanvas.isPointerHoldIn(x2, y, 29, 29))
		{
			indexTitle = 1;
			indexSelect = 1;
			Sound.play(Sound.MBClick, 0.5f);
			updateCommandForUI();
			if (isPaintUpPearl && indexMenu == 0)
			{
				for (int i = 0; i < arrItemUpPeal.Length; i++)
				{
					if (arrItemUpPeal[i] != null)
					{
						center = new Command(mResources.ACCEPT, 11062);
						break;
					}
				}
			}
		}
		if (GameCanvas.isPointerHoldIn(popupX, popupY + 2 * Hitem + 5, popupW, popupH - Hitem * 3))
		{
			indexPointer(popupX, popupY + 2 * Hitem + 5, 6, 3, 2);
		}
	}

	private void doUPPOINT()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.UPPOINT, 11064));
		myVector.addElement(new Command(mResources.UPPOINTS, 11065));
		GameCanvas.menu.startAt(myVector, 0);
	}

	public void saleItem()
	{
		if (Char.getMyChar().arrItemBag[indexSelect].quantity > 1)
		{
			left = new Command(mResources.SALE, 11072);
		}
		else
		{
			left = new Command(mResources.SALE, 11073);
		}
	}

	public void updateCommandForUI()
	{
		left = (center = null);
		if (indexSelect < 0)
		{
			return;
		}
		if (isPaintAuto)
		{
			if (indexTitle == 1 && !GameCanvas.isTouch)
			{
				left = new Command(mResources.SELECT, 1510);
			}
			return;
		}
		if (isPaintLuckySpin)
		{
			if (indexTitle == 1)
			{
				left = new Command(mResources.SELECT, 1506);
				center = new Command(string.Empty, 1507);
			}
			return;
		}
		if (isPaintEliteShop)
		{
			if (indexMenu != 0)
			{
				return;
			}
			Item item = getItemFocus(35);
			if (item != null)
			{
				left = cmdEliteShopBuy;
				if (!GameCanvas.isTouchControlLargeScreen)
				{
					center = cmdEliteShopView;
				}
				else
				{
					actView(35);
				}
			}
			return;
		}
		if (isPaintStore)
		{
			if (indexMenu == 51)
			{
				Item item2 = getItemFocus(32);
				if (item2 != null)
				{
					left = cmdStoreFashionBuy;
					if (!GameCanvas.isTouchControlLargeScreen)
					{
						center = cmdStoreFashionView;
					}
					else
					{
						actView(32);
					}
				}
			}
			else if (indexMenu == 0)
			{
				Item item3 = getItemFocus(14);
				if (item3 != null)
				{
					left = cmdStoreBuy;
					if (!GameCanvas.isTouchControlLargeScreen)
					{
						center = cmdStoreView;
					}
					else
					{
						actView(14);
					}
				}
			}
			else if (indexMenu == 1)
			{
				Item item4 = getItemFocus(15);
				if (item4 != null)
				{
					left = cmdStoreLockBuy;
					if (!GameCanvas.isTouchControlLargeScreen)
					{
						center = cmdStoreLockView;
					}
					else
					{
						actView(15);
					}
				}
			}
			else if (indexMenu == 2)
			{
				Item item5 = getItemFocus(32);
				if (item5 != null)
				{
					left = cmdStoreFashionBuy;
					if (!GameCanvas.isTouchControlLargeScreen)
					{
						center = cmdStoreFashionView;
					}
					else
					{
						actView(32);
					}
				}
			}
			else
			{
				if (indexMenu != 3)
				{
					return;
				}
				Item item6 = getItemFocus(34);
				if (item6 != null)
				{
					left = cmdClanStoreBuy;
					if (!GameCanvas.isTouchControlLargeScreen)
					{
						center = cmdClanStoreView;
					}
					else
					{
						actView(34);
					}
				}
			}
			return;
		}
		if (isPaintNonNam)
		{
			if (indexMenu == 0)
			{
				Item item7 = getItemFocus(20);
				if (item7 != null)
				{
					left = cmdNonNamBuy;
					if (!GameCanvas.isTouchControlLargeScreen)
					{
						center = cmdNonNamView;
					}
					else
					{
						actView(20);
					}
				}
			}
			else if (indexMenu == 1 && Char.getMyChar().arrItemBag[indexSelect] != null)
			{
				saleItem();
			}
		}
		else if (isPaintNonNu)
		{
			if (indexMenu == 0)
			{
				Item item8 = getItemFocus(21);
				if (item8 != null)
				{
					left = cmdNonNuBuy;
					if (!GameCanvas.isTouchControlLargeScreen)
					{
						center = cmdNonNuView;
					}
					else
					{
						actView(21);
					}
				}
			}
			else if (indexMenu == 1 && Char.getMyChar().arrItemBag[indexSelect] != null)
			{
				saleItem();
			}
		}
		else if (isPaintAoNam)
		{
			if (indexMenu == 0)
			{
				Item item9 = getItemFocus(22);
				if (item9 != null)
				{
					left = cmdAoNamBuy;
					if (!GameCanvas.isTouchControlLargeScreen)
					{
						center = cmdAoNamView;
					}
					else
					{
						actView(22);
					}
				}
			}
			else if (indexMenu == 1 && Char.getMyChar().arrItemBag[indexSelect] != null)
			{
				saleItem();
			}
		}
		else if (isPaintAoNu)
		{
			if (indexMenu == 0)
			{
				Item item10 = getItemFocus(23);
				if (item10 != null)
				{
					left = cmdAoNuBuy;
					if (!GameCanvas.isTouchControlLargeScreen)
					{
						center = cmdAoNuView;
					}
					else
					{
						actView(23);
					}
				}
			}
			else if (indexMenu == 1 && Char.getMyChar().arrItemBag[indexSelect] != null)
			{
				saleItem();
			}
		}
		else if (isPaintGangTayNam)
		{
			if (indexMenu == 0)
			{
				Item item11 = getItemFocus(24);
				if (item11 != null)
				{
					left = cmdGangTayNamBuy;
					if (!GameCanvas.isTouchControlLargeScreen)
					{
						center = cmdGangTayNamView;
					}
					else
					{
						actView(24);
					}
				}
			}
			else if (indexMenu == 1 && Char.getMyChar().arrItemBag[indexSelect] != null)
			{
				saleItem();
			}
		}
		else if (isPaintGangTayNu)
		{
			if (indexMenu == 0)
			{
				Item item12 = getItemFocus(25);
				if (item12 != null)
				{
					left = cmdGangTayNuBuy;
					if (!GameCanvas.isTouchControlLargeScreen)
					{
						center = cmdGangTayNuView;
					}
					else
					{
						actView(25);
					}
				}
			}
			else if (indexMenu == 1 && Char.getMyChar().arrItemBag[indexSelect] != null)
			{
				saleItem();
			}
		}
		else if (isPaintQuanNam)
		{
			if (indexMenu == 0)
			{
				Item item13 = getItemFocus(26);
				if (item13 != null)
				{
					left = new Command(mResources.BUY, 11092, item13);
					if (!GameCanvas.isTouchControlLargeScreen)
					{
						center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11088, item13);
					}
					else
					{
						updateItemInfo(26, item13);
					}
				}
			}
			else if (indexMenu == 1 && Char.getMyChar().arrItemBag[indexSelect] != null)
			{
				saleItem();
			}
		}
		else if (isPaintQuanNu)
		{
			if (indexMenu == 0)
			{
				Item item14 = getItemFocus(27);
				if (item14 != null)
				{
					left = new Command(mResources.BUY, 11092, item14);
					if (!GameCanvas.isTouchControlLargeScreen)
					{
						center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11089);
					}
					else
					{
						updateItemInfo(27, item14);
					}
				}
			}
			else if (indexMenu == 1 && Char.getMyChar().arrItemBag[indexSelect] != null)
			{
				saleItem();
			}
		}
		else if (isPaintGiayNam)
		{
			if (indexMenu == 0)
			{
				Item item15 = getItemFocus(28);
				if (item15 != null)
				{
					left = new Command(mResources.BUY, 11092, item15);
					if (!GameCanvas.isTouchControlLargeScreen)
					{
						center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11090);
					}
					else
					{
						updateItemInfo(28, item15);
					}
				}
			}
			else if (indexMenu == 1 && Char.getMyChar().arrItemBag[indexSelect] != null)
			{
				saleItem();
			}
		}
		else if (isPaintGiayNu)
		{
			if (indexMenu == 0)
			{
				Item item16 = getItemFocus(29);
				if (item16 != null)
				{
					left = new Command(mResources.BUY, 11092, item16);
					if (!GameCanvas.isTouchControlLargeScreen)
					{
						center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11091);
					}
					else
					{
						updateItemInfo(29, item16);
					}
				}
			}
			else if (indexMenu == 1 && Char.getMyChar().arrItemBag[indexSelect] != null)
			{
				saleItem();
			}
		}
		else if (isPaintLien)
		{
			if (indexMenu == 0)
			{
				Item item17 = getItemFocus(16);
				if (item17 != null)
				{
					left = new Command(mResources.BUY, 11092, item17);
					if (GameCanvas.isTouchControlLargeScreen)
					{
						updateItemInfo(16, item17);
					}
					else
					{
						center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 110923);
					}
				}
				else
				{
					isPaintItemInfo = false;
				}
			}
			else if (indexMenu == 1 && Char.getMyChar().arrItemBag[indexSelect] != null)
			{
				saleItem();
			}
		}
		else if (isPaintNhan)
		{
			if (indexMenu == 0)
			{
				Item item18 = getItemFocus(17);
				if (item18 != null)
				{
					left = new Command(mResources.BUY, 11092, item18);
					if (GameCanvas.isTouchControlLargeScreen)
					{
						updateItemInfo(17, item18);
					}
					else
					{
						center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 110924);
					}
				}
				else
				{
					isPaintItemInfo = false;
				}
			}
			else if (indexMenu == 1 && Char.getMyChar().arrItemBag[indexSelect] != null)
			{
				saleItem();
			}
		}
		else if (isPaintNgocBoi)
		{
			if (indexMenu == 0)
			{
				Item item19 = getItemFocus(18);
				if (item19 != null)
				{
					left = new Command(mResources.BUY, 11092, item19);
					if (GameCanvas.isTouchControlLargeScreen)
					{
						updateItemInfo(18, item19);
					}
					else
					{
						center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 110925);
					}
				}
				else
				{
					isPaintItemInfo = false;
				}
			}
			else if (indexMenu == 1 && Char.getMyChar().arrItemBag[indexSelect] != null)
			{
				saleItem();
			}
		}
		else if (isPaintPhu)
		{
			if (indexMenu == 0)
			{
				Item item20 = getItemFocus(19);
				if (item20 != null)
				{
					left = new Command(mResources.BUY, 11092, item20);
					if (GameCanvas.isTouchControlLargeScreen)
					{
						updateItemInfo(19, item20);
					}
					else
					{
						center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 110926);
					}
				}
				else
				{
					isPaintItemInfo = false;
				}
			}
			else if (indexMenu == 1 && Char.getMyChar().arrItemBag[indexSelect] != null)
			{
				saleItem();
			}
		}
		else if (isPaintWeapon)
		{
			if (indexMenu == 0)
			{
				Item item21 = getItemFocus(2);
				if (item21 != null)
				{
					left = new Command(mResources.BUY, 11092, item21);
					if (GameCanvas.isTouchControlLargeScreen)
					{
						updateItemInfo(2, item21);
					}
					else
					{
						center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11093);
					}
				}
				else
				{
					isPaintItemInfo = false;
				}
			}
			else if (indexMenu == 1 && Char.getMyChar().arrItemBag[indexSelect] != null)
			{
				saleItem();
			}
		}
		else if (isPaintStack)
		{
			if (indexMenu == 0)
			{
				Item item22 = getItemFocus(6);
				if (item22 != null)
				{
					left = new Command(mResources.BUY, 11092, item22);
					if (GameCanvas.isTouchControlLargeScreen)
					{
						updateItemInfo(6, item22);
					}
					else
					{
						center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11094);
					}
				}
			}
			else if (indexMenu == 1)
			{
				if (Char.getMyChar().arrItemBag[indexSelect] != null)
				{
					saleItem();
				}
				else
				{
					left = cmdBagSortItem;
				}
			}
		}
		else if (isPaintStackLock)
		{
			if (indexMenu == 0)
			{
				Item item23 = getItemFocus(7);
				if (item23 != null)
				{
					left = new Command(mResources.BUY, 11092, item23);
					if (GameCanvas.isTouchControlLargeScreen)
					{
						updateItemInfo(7, item23);
					}
					else
					{
						center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11095);
					}
				}
			}
			else if (indexMenu == 1)
			{
				if (Char.getMyChar().arrItemBag[indexSelect] != null)
				{
					saleItem();
				}
				else
				{
					left = cmdBagSortItem;
				}
			}
		}
		else if (isPaintGrocery)
		{
			if (indexMenu == 0)
			{
				Item item24 = getItemFocus(8);
				if (item24 != null)
				{
					left = new Command(mResources.BUY, 11092, item24);
					if (GameCanvas.isTouchControlLargeScreen)
					{
						updateItemInfo(8, item24);
					}
					else
					{
						center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11096);
					}
				}
			}
			else if (indexMenu == 1)
			{
				if (Char.getMyChar().arrItemBag[indexSelect] != null)
				{
					saleItem();
				}
				else
				{
					left = cmdBagSortItem;
				}
			}
		}
		else if (isPaintGroceryLock)
		{
			if (indexMenu == 0)
			{
				Item item25 = getItemFocus(9);
				if (item25 != null)
				{
					left = new Command(mResources.BUY, 11092, item25);
					if (GameCanvas.isTouchControlLargeScreen)
					{
						updateItemInfo(9, item25);
					}
					else
					{
						center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11097);
					}
				}
			}
			else if (indexMenu == 1)
			{
				if (Char.getMyChar().arrItemBag[indexSelect] != null)
				{
					saleItem();
				}
				else
				{
					left = cmdBagSortItem;
				}
			}
		}
		else if (isPaintUpGrade)
		{
			if (indexMenu == 0)
			{
				if (indexTitle == 1)
				{
					if (itemUpGrade != null)
					{
						if (indexSelect == 0)
						{
							left = new Command(mResources.SELECT, 11098);
							if (GameCanvas.isTouchControlLargeScreen)
							{
								isViewNext = false;
								updateItemInfo(3, itemUpGrade);
							}
							else
							{
								center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11099);
							}
						}
						else if (indexSelect == 1 && !itemUpGrade.isUpMax())
						{
							if (GameCanvas.isTouchControlLargeScreen)
							{
								isViewNext = true;
								updateItemInfo(3, itemUpGrade);
							}
							else
							{
								center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 110991);
							}
						}
					}
					else
					{
						isPaintItemInfo = false;
					}
				}
				else if (indexTitle == 2)
				{
					Item item26 = getItemFocus(10);
					isViewNext = false;
					if (item26 != null)
					{
						left = new Command(mResources.SELECT, 11100);
						if (GameCanvas.isTouchControlLargeScreen)
						{
							updateItemInfo(3, item26);
						}
						else
						{
							center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11101);
						}
					}
					else
					{
						left = null;
						isPaintItemInfo = false;
						if (itemUpGrade != null)
						{
							for (int i = 0; i < arrItemUpGrade.Length; i++)
							{
								if (arrItemUpGrade[i] != null)
								{
									left = new Command(mResources.BEGIN, 110981);
									break;
								}
							}
						}
					}
				}
			}
			else if (indexMenu == 1)
			{
				if (Char.getMyChar().arrItemBag[indexSelect] != null)
				{
					left = new Command(mResources.SELECT, 11102);
				}
				else
				{
					left = null;
				}
			}
		}
		else if (isPaintConvert)
		{
			if (indexMenu == 0)
			{
				if (indexTitle == 1)
				{
					if (indexSelect == 0)
					{
						if (arrItemConvert[0] != null)
						{
							left = new Command(mResources.SELECT, 14013);
							if (GameCanvas.isTouchControlLargeScreen)
							{
								updateItemInfo(3, arrItemConvert[indexSelect]);
							}
							else
							{
								center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 14016);
							}
						}
					}
					else if (indexSelect == 1)
					{
						if (arrItemConvert[1] != null)
						{
							left = new Command(mResources.SELECT, 14013);
							if (GameCanvas.isTouchControlLargeScreen)
							{
								updateItemInfo(3, arrItemConvert[indexSelect]);
							}
							else
							{
								center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 14016);
							}
						}
					}
					else
					{
						isPaintItemInfo = false;
					}
				}
				else if (indexTitle == 2)
				{
					Item item27 = null;
					int num = indexSelect + 2;
					if (num <= arrItemConvert.Length - 1)
					{
						item27 = arrItemConvert[num];
					}
					if (item27 != null)
					{
						left = new Command(mResources.MOVEOUT, 140151);
						if (GameCanvas.isTouchControlLargeScreen)
						{
							updateItemInfo(3, item27);
						}
						else
						{
							center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 140161);
						}
					}
					else
					{
						left = new Command(mResources.BEGIN, 140131);
						for (int j = 0; j < arrItemConvert.Length; j++)
						{
							if (arrItemConvert[j] == null)
							{
								left = null;
								break;
							}
						}
						isPaintItemInfo = false;
					}
				}
			}
			else if (indexMenu == 1)
			{
				if (Char.getMyChar().arrItemBag[indexSelect] != null)
				{
					left = new Command(mResources.SELECT, 14012);
				}
				else
				{
					left = null;
				}
			}
		}
		else if (isPaintAuctionSale)
		{
			if (indexMenu == 0)
			{
				if (indexTitle == 2)
				{
					tfText.isFocus = true;
					right = tfText.cmdClear;
				}
				else
				{
					tfText.isFocus = false;
					right = cmdCloseAll;
				}
				int num2 = 0;
				try
				{
					num2 = int.Parse(tfText.getText());
				}
				catch (Exception)
				{
				}
				if (itemSell != null && num2 > 0 && Char.getMyChar().xu >= 5000)
				{
					left = new Command(mResources.SALE, 15002);
				}
				if (indexTitle == 1 && itemSell != null)
				{
					left = new Command(mResources.SELECT, 1500);
					if (GameCanvas.isTouchControlLargeScreen)
					{
						updateItemInfo(3, itemSell);
					}
					else
					{
						center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 1501);
					}
				}
			}
			else if (indexMenu == 1)
			{
				right = cmdCloseAll;
				if (Char.getMyChar().arrItemBag[indexSelect] != null)
				{
					left = new Command(mResources.SELECT, 1503);
				}
				else
				{
					left = null;
					isPaintItemInfo = false;
				}
			}
		}
		else
		{
			if (isPaintAuctionBuy)
			{
				if (indexTitle != 1 || arrItemStands == null || indexSelect < 0 || indexSelect >= arrItemStands.Length)
				{
					return;
				}
				ItemStands itemStands = arrItemStands[indexSelect];
				if (itemStands != null)
				{
					left = new Command(mResources.SELECT, 1504);
					if (GameCanvas.isTouchControlLargeScreen)
					{
						actionPerform(1505, null);
					}
					else
					{
						center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 1505);
					}
				}
				return;
			}
			if (isPaintSplit)
			{
				if (indexMenu == 0)
				{
					if (indexTitle == 1)
					{
						if (itemSplit != null && itemSplit.upgrade > 0)
						{
							left = new Command(mResources.SELECT, 11103);
						}
						else if (itemSplit != null)
						{
							left = cmdSplitMoveOut;
						}
						else
						{
							isPaintItemInfo = false;
						}
						if (GameCanvas.isTouchControlLargeScreen)
						{
							updateItemInfo(3, itemSplit);
						}
						else
						{
							center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11104, itemSplit);
						}
					}
					else if (indexTitle == 2)
					{
						Item item28 = arrItemSplit[indexSelect];
						if (item28 != null)
						{
							if (GameCanvas.isTouchControlLargeScreen)
							{
								updateItemInfo(3, item28);
							}
							else
							{
								center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11104, item28);
							}
						}
						else
						{
							isPaintItemInfo = false;
						}
						if (itemSplit != null && itemSplit.upgrade > 0)
						{
							left = new Command(mResources.BEGIN, 11105);
						}
					}
				}
				else if (indexMenu == 1)
				{
					if (Char.getMyChar().arrItemBag[indexSelect] == null)
					{
						left = null;
						isPaintItemInfo = false;
					}
					else
					{
						left = new Command(mResources.SELECT, 11106);
					}
				}
			}
			else if (isPaintTinhluyen)
			{
				try
				{
					if (indexMenu == 0)
					{
						if (indexTitle == 1)
						{
							if (itemSplit != null)
							{
								left = new Command(mResources.SELECT, 11103);
							}
							else
							{
								isPaintItemInfo = false;
							}
							if (GameCanvas.isTouchControlLargeScreen)
							{
								updateItemInfo(3, itemSplit);
							}
							else
							{
								center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11104, itemSplit);
							}
						}
						else if (indexTitle == 2)
						{
							Item item29 = arrItemSplit[indexSelect];
							if (item29 != null)
							{
								if (GameCanvas.isTouchControlLargeScreen)
								{
									updateItemInfo(3, item29);
								}
								else
								{
									center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11104, item29);
								}
								left = new Command(mResources.MOVEOUT, 1605);
							}
							else
							{
								isPaintItemInfo = false;
							}
							if (itemSplit != null)
							{
								left = new Command(mResources.SELECT, 1604);
							}
						}
					}
					else if (indexMenu == 1)
					{
						if (Char.getMyChar().arrItemBag[indexSelect] == null)
						{
							left = null;
							isPaintItemInfo = false;
						}
						else
						{
							left = new Command(mResources.SELECT, 11106);
						}
					}
				}
				catch (Exception)
				{
				}
			}
			else if (isPaintDichChuyen)
			{
				if (indexMenu == 0)
				{
					if (indexTitle == 1)
					{
						if (itemSplit != null && itemSplit.upgrade > 11)
						{
							left = new Command(mResources.SELECT, 11103);
						}
						else if (itemSplit != null)
						{
							left = cmdSplitMoveOut;
						}
						else
						{
							isPaintItemInfo = false;
						}
						if (GameCanvas.isTouchControlLargeScreen)
						{
							updateItemInfo(3, itemSplit);
						}
						else
						{
							center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11104, itemSplit);
						}
					}
					else if (indexTitle == 2)
					{
						Item item30 = arrItemSplit[indexSelect];
						if (item30 != null)
						{
							if (GameCanvas.isTouchControlLargeScreen)
							{
								updateItemInfo(3, item30);
							}
							else
							{
								center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11104, item30);
							}
						}
						else
						{
							isPaintItemInfo = false;
						}
						if (itemSplit != null && itemSplit.upgrade > 11)
						{
							left = new Command(mResources.SELECT, 1604);
						}
					}
				}
				else if (indexMenu == 1)
				{
					if (Char.getMyChar().arrItemBag[indexSelect] == null)
					{
						left = null;
						isPaintItemInfo = false;
					}
					else
					{
						left = new Command(mResources.SELECT, 1606);
					}
				}
			}
			else if (isPaintUpPearl)
			{
				if (indexMenu == 0)
				{
					int num3 = 0;
					for (int k = 0; k < arrItemUpPeal.Length; k++)
					{
						if (arrItemUpPeal[k] != null)
						{
							num3++;
							if (num3 >= 2)
							{
								break;
							}
						}
					}
					Item item31 = getItemFocus(11);
					if (item31 != null)
					{
						if (num3 >= 2)
						{
							left = new Command(mResources.SELECT, 11107);
						}
						else
						{
							left = new Command(mResources.MOVEOUT, 111071);
						}
						if (GameCanvas.isTouchControlLargeScreen)
						{
							updateItemInfo(3, item31);
						}
						else
						{
							center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11108);
						}
					}
					else
					{
						isPaintItemInfo = false;
						if (num3 >= 2)
						{
							left = new Command(mResources.BEGIN, 11062);
						}
					}
				}
				else if (indexMenu == 1)
				{
					if (Char.getMyChar().arrItemBag[indexSelect] != null)
					{
						left = new Command(mResources.SELECT, 11109);
					}
					else
					{
						isPaintItemInfo = false;
						left = null;
					}
				}
			}
			else if (isPaintLuyenThach)
			{
				if (indexMenu == 0)
				{
					int num4 = 0;
					int num5 = 0;
					int num6 = 0;
					int num7 = 0;
					for (int l = 0; l < arrItemUpPeal.Length; l++)
					{
						Item item32 = arrItemUpPeal[l];
						if (item32 != null)
						{
							if (item32.template.id == 455)
							{
								num4++;
							}
							else if (item32.template.id == 456)
							{
								num5++;
							}
							else if (item32.template.type == 26)
							{
								num7 = item32.template.id;
								num6++;
							}
						}
						if (num4 >= 9 || num5 >= 9 || (num7 == 10 && num4 >= 3) || (num7 == 11 && num5 >= 3))
						{
							break;
						}
					}
					Item item33 = getItemFocus(43);
					if (item33 != null)
					{
						if (num4 == 9 || num5 == 9 || (num7 == 10 && num4 == 3 && num6 == 1) || (num7 == 11 && num5 == 3 && num6 == 1))
						{
							left = new Command(mResources.SELECT, 1601);
						}
						else
						{
							left = new Command(mResources.MOVEOUT, 111071);
						}
						if (GameCanvas.isTouchControlLargeScreen)
						{
							updateItemInfo(43, item33);
						}
						else
						{
							center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 1602);
						}
					}
					else
					{
						isPaintItemInfo = false;
						if (num4 >= 9 || num5 >= 9 || (num7 >= 10 && (num4 >= 3 || num5 >= 3)))
						{
							left = new Command(mResources.BEGIN, 1600);
						}
					}
				}
				else if (indexMenu == 1)
				{
					if (Char.getMyChar().arrItemBag[indexSelect] != null)
					{
						left = new Command(mResources.SELECT, 1603);
					}
					else
					{
						isPaintItemInfo = false;
						left = null;
					}
				}
			}
			else if (isPaintTrade)
			{
				if (indexMenu == 0)
				{
					if (indexTitle == 1)
					{
						Item item34 = arrItemTradeMe[indexSelect];
						if (item34 != null)
						{
							if (typeTrade == 0)
							{
								left = cmdTradeSelectInList;
							}
							else if (typeTrade == 1 && typeTradeOrder >= 1 && timeTrade - mSystem.getCurrentTimeMillis() / 1000 <= 0)
							{
								left = cmdTradeAccept;
							}
							if (GameCanvas.isTouchControlLargeScreen)
							{
								Item item35 = arrItemTradeMe[indexSelect];
								updateItemInfo(3, item35);
							}
							else
							{
								center = cmdTradeViewItemInfo;
							}
						}
						else
						{
							isPaintItemInfo = false;
							if (typeTrade == 0)
							{
								left = cmdTradeLock;
							}
							else if (typeTrade == 1 && typeTradeOrder >= 1 && timeTrade - mSystem.getCurrentTimeMillis() / 1000 <= 0)
							{
								left = cmdTradeAccept;
							}
						}
					}
					if (indexTitle == 2)
					{
						Item item36 = arrItemTradeOrder[indexSelect];
						if (item36 != null)
						{
							if (GameCanvas.isTouchControlLargeScreen)
							{
								Item item37 = arrItemTradeOrder[indexSelect];
								updateItemInfo(30, item37);
							}
							else
							{
								center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11110);
							}
						}
						else
						{
							isPaintItemInfo = false;
						}
					}
				}
				else if (indexMenu == 1 && typeTrade == 0)
				{
					if (Char.getMyChar().arrItemBag[indexSelect] != null)
					{
						left = cmdTradeSelectInBag;
					}
					else
					{
						left = cmdTradeSendMoney;
					}
				}
			}
			else if (isPaintBox)
			{
				if (indexMenu == 0)
				{
					Item item38 = getItemFocus(4);
					if (item38 != null)
					{
						string gETOUT = mResources.GETOUT;
						if (!svTitle.Equals(string.Empty))
						{
							gETOUT = svAction;
						}
						left = new Command(gETOUT, 111101);
						if (GameCanvas.isTouchControlLargeScreen)
						{
							updateItemInfo(4, item38);
						}
						else
						{
							center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11111);
						}
					}
					else if (svTitle.Equals(string.Empty))
					{
						left = new Command(mResources.SORT, 11112);
					}
				}
				else if (indexMenu == 1)
				{
					if (Char.getMyChar().arrItemBag[indexSelect] != null)
					{
						left = new Command(mResources.GETIN, 11113);
					}
					else
					{
						left = cmdBagSortItem;
					}
				}
			}
			else if (isPaintLuyenNgoc)
			{
				setCMD_luyenngoc();
			}
			else if (isPaintKhamNgoc)
			{
				setCMD_khamngoc();
			}
			else if (isPaintGiaoDo)
			{
				setCMD_giaodo();
			}
			else if (isPaintGotNgoc || isPaintThaoNgoc)
			{
				setCMD_gotngoc();
			}
		}
		if (isPaintUI() && indexMenu == 1 && Char.getMyChar().arrItemBag[indexSelect] != null)
		{
			if (GameCanvas.isTouchControlLargeScreen)
			{
				updateItemInfo(3, Char.getMyChar().arrItemBag[indexSelect]);
			}
			else
			{
				center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11114);
			}
		}
	}

	public static void setPopupSize(int w, int h)
	{
		popupW = w;
		popupH = h;
		popupX = gW2 - w / 2;
		popupY = gH2 - h / 2;
		if (GameCanvas.h <= 250)
		{
			popupY -= 10;
		}
		if (GameCanvas.isTouch && !isSmallUI() && !GameCanvas.isTouchControlSmallScreen && GameCanvas.currentScreen is GameScr)
		{
			popupW = 310;
			popupX = gW / 2 - popupW / 2;
		}
		if (popupY < -10)
		{
			popupY = -10;
		}
		if (GameCanvas.h > 208 && popupY < 0)
		{
			popupY = 0;
		}
		if (GameCanvas.h == 208 && popupY < 10)
		{
			popupY = 10;
		}
		if (GameCanvas.w == 128 || GameCanvas.h <= 208)
		{
			w = 126;
			h = 160;
		}
	}

	public void paintSkillInfo(mGraphics g, Skill skill)
	{
		if (Char.getMyChar().clevel >= skill.level)
		{
			mFont.tahoma_7_white.drawString(g, mResources.LEVELNEED + " " + skill.level, xstart + 5, yPaint += 12, 0);
		}
		else
		{
			mFont.tahoma_7_red.drawString(g, mResources.LEVELNEED + " " + skill.level, xstart + 5, yPaint += 12, 0);
		}
		if (skill.template.type != 0)
		{
			indexRowMax += 4;
			mFont.tahoma_7_white.drawString(g, mResources.MAX_FIGHT + ": " + skill.maxFight, xstart + 5, yPaint += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.MANA_USE + ": " + skill.manaUse, xstart + 5, yPaint += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.RANGE_ATTACK + ": " + skill.dx, xstart + 5, yPaint += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.TIME_LOOP + ": " + skill.strTimeReplay() + " " + mResources.SECOND, xstart + 5, yPaint += 12, 0);
		}
		indexRowMax++;
	}

	public void paintSkillOption(mGraphics g, Skill skill)
	{
		SkillOption[] options = skill.options;
		SkillOption[] array = options;
		foreach (SkillOption skillOption in array)
		{
			if (mFont.tahoma_7_white.getWidth(skillOption.getOptionString()) > 145)
			{
				MyVector myVector = mFont.tahoma_7_white.splitFontVector(skillOption.getOptionString(), 145);
				for (int j = 0; j < myVector.size(); j++)
				{
					mFont.tahoma_7_white.drawString(g, myVector.elementAt(j).ToString(), xstart + 5, yPaint += 12, 0);
					indexRowMax++;
				}
			}
			else
			{
				mFont.tahoma_7_white.drawString(g, skillOption.getOptionString(), xstart + 5, yPaint += 12, 0);
				indexRowMax++;
			}
		}
	}

	public void paintKyNang(mGraphics g)
	{
		if (indexMenu != 1)
		{
			return;
		}
		resetTranslate(g);
		GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
		paintTitle(g, mResources.MENUME[indexMenu], arrow: true);
		mFont.tahoma_7b_white.drawString(g, mResources.SKILL_POINT, popupX + 10, popupY + 30, 0);
		mFont.tahoma_7b_white.drawString(g, string.Empty + Char.getMyChar().sPoint, popupX + popupW - 10, popupY + 30, mFont.RIGHT);
		g.setColor(0);
		g.fillRect(popupX + 4, popupY + 44, popupW - 7, indexSize + 3);
		g.setColor(12281361);
		g.drawRect(popupX + 5, popupY + 45, popupW - 10, indexSize);
		if (indexTitle >= 1)
		{
			g.setColor(Paint.COLORBORDER);
			g.drawRect(popupX + 5, popupY + 48 + indexSize, popupW - 10, popupH - 64 - indexSize);
		}
		int num = Char.getMyChar().nClass.skillTemplates.Length;
		xstart = popupX + 5;
		ystart = popupY + 45;
		scrMain.setStyle(num, indexSize + 2, xstart + 1, ystart, popupW - 12, indexSize + 2, styleUPDOWN: false, 1);
		scrMain.setClip(g);
		for (int i = 0; i < num; i++)
		{
			SmallImage.drawSmallImage(g, Char.getMyChar().nClass.skillTemplates[i].iconId, xstart + i * (indexSize + 2) + indexSize / 2, ystart + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
			if (indexTitle == 1 && i == indexSelect)
			{
				g.setColor(16777215);
				g.drawRect(xstart + i * (indexSize + 2) + 2, ystart + 2, indexSize - 4, indexSize - 4);
				paintSelectHighlight(xstart + i * (indexSize + 2), ystart, g);
			}
		}
		xstart += 8;
		ystart += 6;
		if (indexTitle != 1 || indexSelect < 0)
		{
			return;
		}
		resetTranslate(g);
		SkillTemplate skillTemplate = Char.getMyChar().nClass.skillTemplates[indexSelect];
		indexRowMax = 4 + skillTemplate.description.Length;
		Skill skill = Char.getMyChar().getSkill(skillTemplate);
		int num2 = popupX;
		int num3 = ystart + indexSize + 2;
		int w = popupW - 6;
		int h = popupH - 70 - indexSize;
		scrInfo.setClip(g, num2, num3, w, h);
		yPaint = ystart + 18;
		if (skill == null)
		{
			skill = ((skillTemplate.skills.Length <= 1) ? skillTemplate.skills[0] : skillTemplate.skills[1]);
			mFont.tahoma_7b_red.drawString(g, skillTemplate.name, xstart + 5, yPaint += 12, 0);
			for (int j = 0; j < skillTemplate.description.Length; j++)
			{
				mFont.tahoma_7_white.drawString(g, skillTemplate.description[j], xstart + 5, yPaint += 12, 0);
			}
			mFont.tahoma_7_white.drawString(g, mResources.SKILLTYPE[skillTemplate.type], xstart + 5, yPaint += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.LEVELMAX + ": " + skillTemplate.maxPoint, xstart + 5, yPaint += 12, 0);
			mFont.tahoma_7_red.drawString(g, mResources.replace(mResources.LEVELNEXT, skill.point + string.Empty), xstart + 5, yPaint += 12, 0);
			paintSkillInfo(g, skill);
			paintSkillOption(g, skill);
		}
		else
		{
			mFont.tahoma_7b_white.drawString(g, skillTemplate.name, xstart + 5, yPaint += 12, 0);
			for (int k = 0; k < skillTemplate.description.Length; k++)
			{
				mFont.tahoma_7_white.drawString(g, skillTemplate.description[k], xstart + 5, yPaint += 12, 0);
			}
			mFont.tahoma_7_white.drawString(g, mResources.SKILLTYPE[skillTemplate.type], xstart + 5, yPaint += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.LEVELMAX + ": " + skillTemplate.maxPoint, xstart + 5, yPaint += 12, 0);
			if (skill.point == skillTemplate.maxPoint)
			{
				mFont.tahoma_7_blue.drawString(g, mResources.LEVELEDMAX, xstart + 5, yPaint += 12, 0);
				paintSkillInfo(g, skill);
				paintSkillOption(g, skill);
			}
			else
			{
				mFont.tahoma_7_blue.drawString(g, mResources.replace(mResources.LEVELNOW, skill.point + string.Empty), xstart + 5, yPaint += 12, 0);
				paintSkillInfo(g, skill);
				paintSkillOption(g, skill);
				int num4 = 0;
				for (num4 = 0; num4 < skillTemplate.skills.Length; num4++)
				{
					if (skillTemplate.skills[num4].Equals(skill))
					{
						num4++;
						break;
					}
				}
				mFont.tahoma_7_red.drawString(g, mResources.replace(mResources.LEVELNEXT, string.Empty + skillTemplate.skills[num4].point), xstart + 5, yPaint += 12, 0);
				paintSkillInfo(g, skillTemplate.skills[num4]);
				indexRowMax++;
				paintSkillOption(g, skillTemplate.skills[num4]);
			}
		}
		scrInfo.setStyle(indexRowMax, 12, num2, num3, w, h, styleUPDOWN: true, 1);
		if (indexRow >= 0)
		{
			SmallImage.drawSmallImage(g, 942, xstart + 2, ystart + 32 + indexRow * 12, 0, StaticObj.TOP_RIGHT);
		}
	}

	public void paintHanhTrang(mGraphics g)
	{
		if (indexMenu == 0)
		{
			paintBag(g, mResources.MENUME);
		}
	}

	public void paintBag(mGraphics g, string[] titles)
	{
		try
		{
			resetTranslate(g);
			paintItemFrame(g, titles, paintMoney: true);
			paintBagItem(g, Char.getMyChar().arrItemBag);
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
	}

	private void paintBagItem(mGraphics g, Item[] items)
	{
		rows = items.Length / columns;
		int num = (Main.isPC ? 5 : 4);
		scrMain.setStyle(rows, indexSize, xstart, ystart, columns * indexSize, num * indexSize, styleUPDOWN: true, 6);
		scrMain.setClip(g, xstart, ystart, scrMain.width + 2, scrMain.height + 2);
		for (int i = 0; i < rows; i++)
		{
			for (int j = 0; j < columns; j++)
			{
				SmallImage.drawSmallImage(g, 154, xstart + j * indexSize + indexSize / 2, ystart + i * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				g.setColor(12281361);
				g.drawRect(xstart + j * indexSize, ystart + i * indexSize, indexSize, indexSize);
			}
		}
		foreach (Item item in items)
		{
			if (item != null)
			{
				int num2 = item.indexUI / columns;
				int num3 = item.indexUI - num2 * columns;
				paintItem(g, item, xstart + num3 * indexSize, ystart + num2 * indexSize);
				if (item.quantity > 1)
				{
					mFont.number_yellow.drawString(g, string.Empty + item.quantity, xstart + num3 * indexSize + indexSize, ystart + num2 * indexSize + indexSize - mFont.number_yellow.getHeight(), 1);
				}
			}
		}
		if (indexTitle > 0 && indexSelect >= 0)
		{
			int num4 = indexSelect / columns;
			int num5 = indexSelect - num4 * columns;
			g.setColor(16777215);
			g.drawRect(xstart + num5 * indexSize, ystart + num4 * indexSize, indexSize, indexSize);
			paintSelectHighlight(xstart + num5 * indexSize, ystart + num4 * indexSize, g);
		}
	}

	private void paintSelectHighlight(int x, int y, mGraphics g)
	{
		g.drawImage(imgSelect, x - 5, y - 5, 0);
	}

	private void paintUpgradeEffect(int x, int y, int upgrade, mGraphics g)
	{
		int num = indexSize - 2;
		int num2 = 0;
		int num3 = ((upgrade >= 4) ? ((upgrade < 8) ? 1 : ((upgrade < 12) ? 2 : ((upgrade > 14) ? 4 : 3))) : 0);
		for (int i = num2; i < size.Length; i++)
		{
			int num4 = x - num / 2 + upgradeEffectX(GameCanvas.gameTick - i * 4);
			int num5 = y - num / 2 + upgradeEffectY(GameCanvas.gameTick - i * 4);
			g.setColor(colorBorder[num3][i]);
			g.fillRect(num4 - size[i] / 2, num5 - size[i] / 2, size[i], size[i]);
		}
		if (upgrade == 4 || upgrade == 8)
		{
			for (int j = num2; j < size.Length; j++)
			{
				int num6 = x - num / 2 + upgradeEffectX(GameCanvas.gameTick - num * 2 - j * 4);
				int num7 = y - num / 2 + upgradeEffectY(GameCanvas.gameTick - num * 2 - j * 4);
				g.setColor(colorBorder[num3 - 1][j]);
				g.fillRect(num6 - size[j] / 2, num7 - size[j] / 2, size[j], size[j]);
			}
		}
		if (upgrade != 1 && upgrade != 4 && upgrade != 8)
		{
			for (int k = num2; k < size.Length; k++)
			{
				int num8 = x - num / 2 + upgradeEffectX(GameCanvas.gameTick - num * 2 - k * 4);
				int num9 = y - num / 2 + upgradeEffectY(GameCanvas.gameTick - num * 2 - k * 4);
				g.setColor(colorBorder[num3][k]);
				g.fillRect(num8 - size[k] / 2, num9 - size[k] / 2, size[k], size[k]);
			}
		}
		if (upgrade != 1 && upgrade != 4 && upgrade != 8 && upgrade != 12 && upgrade != 2 && upgrade != 5 && upgrade != 9)
		{
			for (int l = num2; l < size.Length; l++)
			{
				int num10 = x - num / 2 + upgradeEffectX(GameCanvas.gameTick - num - l * 4);
				int num11 = y - num / 2 + upgradeEffectY(GameCanvas.gameTick - num - l * 4);
				g.setColor(colorBorder[num3][l]);
				g.fillRect(num10 - size[l] / 2, num11 - size[l] / 2, size[l], size[l]);
			}
		}
		if (upgrade != 1 && upgrade != 4 && upgrade != 8 && upgrade != 12 && upgrade != 2 && upgrade != 5 && upgrade != 9 && upgrade != 13 && upgrade != 3 && upgrade != 6 && upgrade != 10 && upgrade != 15)
		{
			for (int m = num2; m < size.Length; m++)
			{
				int num12 = x - num / 2 + upgradeEffectX(GameCanvas.gameTick - num * 3 - m * 4);
				int num13 = y - num / 2 + upgradeEffectY(GameCanvas.gameTick - num * 3 - m * 4);
				g.setColor(colorBorder[num3][m]);
				g.fillRect(num12 - size[m] / 2, num13 - size[m] / 2, size[m], size[m]);
			}
		}
	}

	private int upgradeEffectY(int tick)
	{
		int num = indexSize - 2;
		int num2 = tick % (4 * num);
		if (0 <= num2 && num2 < num)
		{
			return 0;
		}
		if (num <= num2 && num2 < num * 2)
		{
			return num2 % num;
		}
		if (num * 2 <= num2 && num2 < num * 3)
		{
			return num;
		}
		return num - num2 % num;
	}

	private void paintItemFrame_shopOnline(mGraphics g, string titles, bool paintMoney)
	{
		GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
		if (paintMoney)
		{
			mFont.tahoma_7_white.drawString(g, mResources.XU + ": " + NinjaUtil.numberToString(string.Empty + Char.getMyChar().xu), popupX + 6, popupY + popupH - 26, 0);
			mFont.tahoma_7_white.drawString(g, mResources.YEN + ": " + NinjaUtil.numberToString(string.Empty + Char.getMyChar().yen), popupX + popupW - 6, popupY + popupH - 26, 1);
			if (isPaintTrade)
			{
				if (GameCanvas.gameTick % 10 > 4)
				{
					mFont.tahoma_7_yellow.drawString(g, mResources.SELECTTRADE, popupX + popupW / 2, popupY + popupH - 14, 2);
				}
			}
			else if (isPaintUpPearl)
			{
				if (GameCanvas.gameTick % 10 > 4)
				{
					mFont.tahoma_7_yellow.drawString(g, mResources.SELECTPEARL, popupX + popupW / 2, popupY + popupH - 14, 2);
				}
			}
			else if (isPaintSplit)
			{
				if (GameCanvas.gameTick % 10 > 4)
				{
					mFont.tahoma_7_yellow.drawString(g, mResources.SELECT_ITEM, popupX + popupW / 2, popupY + popupH - 14, 2);
				}
			}
			else
			{
				mFont.tahoma_7_yellow.drawString(g, mResources.LUONG + ": " + NinjaUtil.numberToString(string.Empty + Char.getMyChar().luong), popupX + popupW / 2, popupY + popupH - 16, 2);
			}
		}
		paintTitle(g, titles, titles.Length > 1);
		xstart = popupX + 3;
		ystart = popupY + 32;
		g.setColor(6425);
		int num = (Main.isPC ? 5 : 4);
		g.fillRect(xstart - 1, ystart - 1, columns * indexSize + 3, num * indexSize + 3);
	}

	public void paintShopOnline(mGraphics g, Item[] items)
	{
		try
		{
			resetTranslate(g);
			paintItemFrame_shopOnline(g, Name_store, paintMoney: true);
			if (items == null)
			{
				GameCanvas.paintShukiren(popupX + 90, popupY + 75, g, noRotate: false);
				mFont.tahoma_7b_white.drawString(g, mResources.PLEASEWAIT, popupX + 90, popupY + 90, 2);
				return;
			}
			if (items.Length <= 30)
			{
				rows = 5;
			}
			else if (items.Length % columns == 0)
			{
				rows = items.Length / columns;
			}
			else
			{
				rows = items.Length / columns + 1;
			}
			scrMain.setStyle(rows, indexSize, xstart, ystart, columns * indexSize, 5 * indexSize, styleUPDOWN: true, 6);
			scrMain.setClip(g, xstart, ystart, scrMain.width + 2, scrMain.height + 2);
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					SmallImage.drawSmallImage(g, 154, xstart + j * indexSize + indexSize / 2, ystart + i * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
					g.setColor(12281361);
					g.drawRect(xstart + j * indexSize, ystart + i * indexSize, indexSize, indexSize);
				}
			}
			foreach (Item item in items)
			{
				if (item != null)
				{
					int num = item.indexUI / columns;
					int num2 = item.indexUI - num * columns;
					if (!item.isLock)
					{
						g.setColor(12083);
						g.fillRect(xstart + num2 * indexSize + 1, ystart + num * indexSize + 1, indexSize - 1, indexSize - 1);
						SmallImage.drawSmallImage(g, 154, xstart + num2 * indexSize + indexSize / 2, ystart + num * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
					}
					SmallImage.drawSmallImage(g, item.template.iconID, xstart + num2 * indexSize + indexSize / 2, ystart + num * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				}
			}
			if (indexTitle > 0 && indexSelect >= 0)
			{
				int num3 = indexSelect / columns;
				int num4 = indexSelect - num3 * columns;
				g.setColor(16777215);
				g.drawRect(xstart + num4 * indexSize, ystart + num3 * indexSize, indexSize, indexSize);
				paintSelectHighlight(xstart + num4 * indexSize, ystart + num3 * indexSize, g);
			}
		}
		catch (Exception)
		{
		}
	}

	private int upgradeEffectX(int tick)
	{
		int num = indexSize - 2;
		int num2 = tick % (4 * num);
		if (0 <= num2 && num2 < num)
		{
			return num2 % num;
		}
		if (num <= num2 && num2 < num * 2)
		{
			return num;
		}
		if (num * 2 <= num2 && num2 < num * 3)
		{
			return num - num2 % num;
		}
		return 0;
	}

	public void paintItemList(mGraphics g, string[] titles, Item[] items)
	{
		try
		{
			resetTranslate(g);
			paintItemFrame(g, titles, paintMoney: true);
			if (items == null)
			{
				GameCanvas.paintShukiren(popupX + 90, popupY + 75, g, noRotate: false);
				mFont.tahoma_7b_white.drawString(g, mResources.PLEASEWAIT, popupX + 90, popupY + 90, 2);
				return;
			}
			if (items.Length <= 30)
			{
				rows = 5;
			}
			else if (items.Length % columns == 0)
			{
				rows = items.Length / columns;
			}
			else
			{
				rows = items.Length / columns + 1;
			}
			int num = (Main.isPC ? 5 : 4);
			scrMain.setStyle(rows, indexSize, xstart, ystart, columns * indexSize, num * indexSize, styleUPDOWN: true, 6);
			scrMain.setClip(g, xstart, ystart, scrMain.width + 2, scrMain.height + 2);
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					SmallImage.drawSmallImage(g, 154, xstart + j * indexSize + indexSize / 2, ystart + i * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
					g.setColor(12281361);
					g.drawRect(xstart + j * indexSize, ystart + i * indexSize, indexSize, indexSize);
				}
			}
			foreach (Item item in items)
			{
				if (item != null)
				{
					int num2 = item.indexUI / columns;
					int num3 = item.indexUI - num2 * columns;
					if (!item.isLock)
					{
						g.setColor(12083);
						g.fillRect(xstart + num3 * indexSize + 1, ystart + num2 * indexSize + 1, indexSize - 1, indexSize - 1);
						SmallImage.drawSmallImage(g, 154, xstart + num3 * indexSize + indexSize / 2, ystart + num2 * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
					}
					SmallImage.drawSmallImage(g, item.template.iconID, xstart + num3 * indexSize + indexSize / 2, ystart + num2 * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				}
			}
			if (indexTitle > 0 && indexSelect >= 0)
			{
				int num4 = indexSelect / columns;
				int num5 = indexSelect - num4 * columns;
				g.setColor(16777215);
				g.drawRect(xstart + num5 * indexSize, ystart + num4 * indexSize, indexSize, indexSize);
				paintSelectHighlight(xstart + num5 * indexSize, ystart + num4 * indexSize, g);
			}
		}
		catch (Exception)
		{
		}
	}

	private void paintItemFrame(mGraphics g, string[] titles, bool paintMoney)
	{
		GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
		if (paintMoney)
		{
			mFont.tahoma_7_white.drawString(g, mResources.XU + ": " + NinjaUtil.numberToString(string.Empty + Char.getMyChar().xu), popupX + 6, popupY + popupH - 26, 0);
			mFont.tahoma_7_white.drawString(g, mResources.YEN + ": " + NinjaUtil.numberToString(string.Empty + Char.getMyChar().yen), popupX + popupW - 6, popupY + popupH - 26, 1);
			if (isPaintTrade)
			{
				if (GameCanvas.gameTick % 10 > 4)
				{
					mFont.tahoma_7_yellow.drawString(g, mResources.SELECTTRADE, popupX + popupW / 2, popupY + popupH - 14, 2);
				}
			}
			else if (isPaintUpPearl)
			{
				if (GameCanvas.gameTick % 10 > 4)
				{
					mFont.tahoma_7_yellow.drawString(g, mResources.SELECTPEARL, popupX + popupW / 2, popupY + popupH - 14, 2);
				}
			}
			else if (isPaintSplit)
			{
				if (GameCanvas.gameTick % 10 > 4)
				{
					mFont.tahoma_7_yellow.drawString(g, mResources.SELECT_ITEM, popupX + popupW / 2, popupY + popupH - 14, 2);
				}
			}
			else
			{
				mFont.tahoma_7_yellow.drawString(g, mResources.LUONG + ": " + NinjaUtil.numberToString(string.Empty + Char.getMyChar().luong), popupX + popupW / 2, popupY + popupH - 16, 2);
			}
		}
		paintTitle(g, titles[indexMenu], titles.Length > 1);
		xstart = popupX + 3;
		ystart = popupY + 32;
		g.setColor(6425);
		int num = (Main.isPC ? 5 : 4);
		g.fillRect(xstart - 1, ystart - 1, columns * indexSize + 3, num * indexSize + 3);
	}

	public void paintBox(mGraphics g, string[] titles)
	{
		try
		{
			resetTranslate(g);
			paintItemFrame(g, titles, paintMoney: false);
			if (Char.getMyChar().arrItemBox == null)
			{
				GameCanvas.paintShukiren(popupX + 90, popupY + 75, g, noRotate: false);
				mFont.tahoma_7b_white.drawString(g, mResources.PLEASEWAIT, popupX + 90, popupY + 90, 2);
			}
			else
			{
				mFont.tahoma_7_white.drawString(g, mResources.XUINBAG + ": " + NinjaUtil.numberToString(string.Empty + Char.getMyChar().xuInBox), popupX + popupW / 2, popupY + popupH - 18, 2);
				paintBagItem(g, Char.getMyChar().arrItemBox);
			}
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
	}

	public void paintUpgrade(mGraphics g, string[] titles)
	{
		try
		{
			rows = 3;
			GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
			paintTitle(g, titles[indexMenu], titles.Length > 1);
			xstart = popupX + 3;
			ystart = popupY + 34 + indexSize;
			int num = popupX + 45;
			int num2 = popupX + 100;
			int num3 = ystart - indexSize - 3;
			if (itemUpGrade != null)
			{
				paintItem(g, itemUpGrade, num, num3);
				g.setColor(12281361);
				g.drawRect(num, num3, indexSize, indexSize);
				mFont.tahoma_7_yellow.drawString(g, "(+" + itemUpGrade.upgrade + ")", num - 5, num3 + indexSize / 2 - 5, mFont.RIGHT);
			}
			else
			{
				g.setColor(6425);
				g.fillRect(num - 1, num3 - 1, indexSize + 3, indexSize + 3);
				SmallImage.drawSmallImage(g, 154, num + indexSize / 2, num3 + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				g.setColor(12281361);
				g.drawRect(num, num3, indexSize, indexSize);
			}
			SmallImage.drawSmallImage(g, 942, num + 43, ystart - 15, 0, StaticObj.VCENTER_HCENTER);
			if (itemUpGrade != null && !itemUpGrade.isUpMax())
			{
				paintItem(g, itemUpGrade, num2, num3, 1, 0);
				g.setColor(12281361);
				g.drawRect(num2, num3, indexSize, indexSize);
				mFont.tahoma_7_yellow.drawString(g, "(+" + (itemUpGrade.upgrade + 1) + ")", num2 + indexSize + 10, num3 + indexSize / 2 - 5, mFont.LEFT);
			}
			else
			{
				g.setColor(6425);
				g.fillRect(num2 - 1, num3 - 1, indexSize + 3, indexSize + 3);
				SmallImage.drawSmallImage(g, 154, num2 + indexSize / 2, num3 + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				g.setColor(12281361);
				g.drawRect(num2, num3, indexSize, indexSize);
			}
			if (indexTitle == 1)
			{
				if (indexSelect == 0)
				{
					g.setColor(16777215);
					g.drawRect(num, num3, indexSize, indexSize);
				}
				if (indexSelect == 1)
				{
					g.setColor(16777215);
					g.drawRect(num2, num3, indexSize, indexSize);
				}
			}
			if (itemUpGrade != null)
			{
				if (itemUpGrade.isUpMax())
				{
					if (!GameCanvas.isTouchControlLargeScreen)
					{
						mFont.tahoma_7_yellow.drawString(g, mResources.HELPUPGRADE[3], popupX + popupW / 2, ystart + rows * indexSize + 5, mFont.CENTER);
					}
					else
					{
						mFont.tahoma_7_yellow.drawString(g, mResources.HELPUPGRADE[3], popupX + 7, ystart + rows * indexSize + 5, mFont.LEFT);
					}
				}
				else
				{
					int num4 = 0;
					for (int i = 0; i < arrItemUpGrade.Length; i++)
					{
						if (arrItemUpGrade[i] != null && arrItemUpGrade[i].template.type == 26)
						{
							num4 += crystals[arrItemUpGrade[i].template.id];
						}
					}
					int num5 = 0;
					int num6 = 0;
					if (itemUpGrade.isTypeClothe())
					{
						num5 = num4 * 100 / upClothe[itemUpGrade.upgrade];
						if (num5 > maxPercents[itemUpGrade.upgrade])
						{
							num5 = maxPercents[itemUpGrade.upgrade];
						}
						if (isPaintUpGradeGold)
						{
							num5 = (int)((double)num5 * 1.5);
							num6 = goldUps[itemUpGrade.upgrade];
						}
						if (Main.isPC)
						{
							if (coinUpClothes[itemUpGrade.upgrade] > Char.getMyChar().xu + Char.getMyChar().yen)
							{
								mFont.tahoma_7_red.drawString(g, mResources.replace(mResources.COINLOCKNEED, NinjaUtil.numberToString(string.Empty + coinUpClothes[itemUpGrade.upgrade])), xstart, ystart + rows * indexSize + 5, mFont.LEFT);
							}
							else
							{
								mFont.tahoma_7_yellow.drawString(g, mResources.replace(mResources.COINLOCKNEED, NinjaUtil.numberToString(string.Empty + coinUpClothes[itemUpGrade.upgrade])), xstart, ystart + rows * indexSize + 5, mFont.LEFT);
							}
							if (num6 > Char.getMyChar().luong)
							{
								mFont.tahoma_7_red.drawString(g, mResources.replace(mResources.GOLDNEED, num6 + string.Empty), xstart, ystart + rows * indexSize + 17, mFont.LEFT);
							}
							else
							{
								mFont.tahoma_7_yellow.drawString(g, mResources.replace(mResources.GOLDNEED, num6 + string.Empty), xstart, ystart + rows * indexSize + 17, mFont.LEFT);
							}
							mFont.tahoma_7_yellow.drawString(g, mResources.PERCENT + ": " + num5 + "%", xstart, ystart + rows * indexSize + 29, mFont.LEFT);
						}
						else
						{
							string[] array = new string[3];
							if (coinUpClothes[itemUpGrade.upgrade] > Char.getMyChar().xu + Char.getMyChar().yen)
							{
								array[0] = mResources.replace(mResources.COINLOCKNEED, NinjaUtil.numberToString(string.Empty + coinUpClothes[itemUpGrade.upgrade]));
							}
							else
							{
								array[0] = mResources.replace(mResources.COINLOCKNEED, NinjaUtil.numberToString(string.Empty + coinUpClothes[itemUpGrade.upgrade]));
							}
							if (num6 > Char.getMyChar().luong)
							{
								array[1] = mResources.replace(mResources.GOLDNEED, num6 + string.Empty);
							}
							else
							{
								array[1] = mResources.replace(mResources.GOLDNEED, num6 + string.Empty);
							}
							array[2] = mResources.PERCENT + ": " + num5 + "%";
							paintInfoHelpCheNgoc1(g, array, 0);
						}
					}
					else if (itemUpGrade.isTypeAdorn())
					{
						num5 = num4 * 100 / upAdorn[itemUpGrade.upgrade];
						if (num5 > maxPercents[itemUpGrade.upgrade])
						{
							num5 = maxPercents[itemUpGrade.upgrade];
						}
						if (isPaintUpGradeGold)
						{
							num5 = (int)((double)num5 * 1.5);
							num6 = goldUps[itemUpGrade.upgrade];
						}
						if (Main.isPC)
						{
							if (coinUpAdorns[itemUpGrade.upgrade] > Char.getMyChar().xu + Char.getMyChar().yen)
							{
								mFont.tahoma_7_red.drawString(g, mResources.replace(mResources.COINLOCKNEED, NinjaUtil.numberToString(string.Empty + coinUpAdorns[itemUpGrade.upgrade])), xstart, ystart + rows * indexSize + 5, mFont.LEFT);
							}
							else
							{
								mFont.tahoma_7_yellow.drawString(g, mResources.replace(mResources.COINLOCKNEED, NinjaUtil.numberToString(string.Empty + coinUpAdorns[itemUpGrade.upgrade])), xstart, ystart + rows * indexSize + 5, mFont.LEFT);
							}
							if (num6 > Char.getMyChar().luong)
							{
								mFont.tahoma_7_red.drawString(g, mResources.replace(mResources.GOLDNEED, num6 + string.Empty), xstart, ystart + rows * indexSize + 17, mFont.LEFT);
							}
							else
							{
								mFont.tahoma_7_yellow.drawString(g, mResources.replace(mResources.GOLDNEED, num6 + string.Empty), xstart, ystart + rows * indexSize + 17, mFont.LEFT);
							}
							mFont.tahoma_7_yellow.drawString(g, mResources.PERCENT + ": " + num5 + "%", xstart, ystart + rows * indexSize + 29, mFont.LEFT);
						}
						else
						{
							string[] array2 = new string[3];
							if (coinUpAdorns[itemUpGrade.upgrade] > Char.getMyChar().xu + Char.getMyChar().yen)
							{
								array2[0] = mResources.replace(mResources.COINLOCKNEED, NinjaUtil.numberToString(string.Empty + coinUpAdorns[itemUpGrade.upgrade]));
							}
							else
							{
								array2[0] = mResources.replace(mResources.COINLOCKNEED, NinjaUtil.numberToString(string.Empty + coinUpAdorns[itemUpGrade.upgrade]));
							}
							if (num6 > Char.getMyChar().luong)
							{
								array2[1] = mResources.replace(mResources.GOLDNEED, num6 + string.Empty);
							}
							else
							{
								array2[1] = mResources.replace(mResources.GOLDNEED, num6 + string.Empty);
							}
							array2[2] = mResources.PERCENT + ": " + num5 + "%";
							paintInfoHelpCheNgoc1(g, array2, 0);
						}
					}
					else if (itemUpGrade.isTypeWeapon())
					{
						num5 = num4 * 100 / upWeapon[itemUpGrade.upgrade];
						if (num5 > maxPercents[itemUpGrade.upgrade])
						{
							num5 = maxPercents[itemUpGrade.upgrade];
						}
						if (isPaintUpGradeGold)
						{
							num5 = (int)((double)num5 * 1.5);
							num6 = goldUps[itemUpGrade.upgrade];
						}
						if (Main.isPC)
						{
							if (coinUpWeapons[itemUpGrade.upgrade] > Char.getMyChar().xu + Char.getMyChar().yen)
							{
								mFont.tahoma_7_red.drawString(g, mResources.replace(mResources.COINLOCKNEED, NinjaUtil.numberToString(string.Empty + coinUpWeapons[itemUpGrade.upgrade])), xstart, ystart + rows * indexSize + 5, mFont.LEFT);
							}
							else
							{
								mFont.tahoma_7_yellow.drawString(g, mResources.replace(mResources.COINLOCKNEED, NinjaUtil.numberToString(string.Empty + coinUpWeapons[itemUpGrade.upgrade])), xstart, ystart + rows * indexSize + 5, mFont.LEFT);
							}
							if (num6 > Char.getMyChar().luong)
							{
								mFont.tahoma_7_red.drawString(g, mResources.replace(mResources.GOLDNEED, num6 + string.Empty), xstart, ystart + rows * indexSize + 17, mFont.LEFT);
							}
							else
							{
								mFont.tahoma_7_yellow.drawString(g, mResources.replace(mResources.GOLDNEED, num6 + string.Empty), xstart, ystart + rows * indexSize + 17, mFont.LEFT);
							}
							mFont.tahoma_7_yellow.drawString(g, mResources.PERCENT + ": " + num5 + "%", xstart, ystart + rows * indexSize + 29, mFont.LEFT);
						}
						else
						{
							string[] array3 = new string[3];
							if (coinUpWeapons[itemUpGrade.upgrade] > Char.getMyChar().xu + Char.getMyChar().yen)
							{
								array3[0] = mResources.replace(mResources.COINLOCKNEED, NinjaUtil.numberToString(string.Empty + coinUpWeapons[itemUpGrade.upgrade]));
							}
							else
							{
								array3[0] = mResources.replace(mResources.COINLOCKNEED, NinjaUtil.numberToString(string.Empty + coinUpWeapons[itemUpGrade.upgrade]));
							}
							if (num6 > Char.getMyChar().luong)
							{
								array3[1] = mResources.replace(mResources.GOLDNEED, num6 + string.Empty);
							}
							else
							{
								array3[1] = mResources.replace(mResources.GOLDNEED, num6 + string.Empty);
							}
							array3[2] = mResources.PERCENT + ": " + num5 + "%";
							paintInfoHelpCheNgoc1(g, array3, 0);
						}
					}
				}
			}
			else if (Main.isPC)
			{
				for (int j = 0; j < 3; j++)
				{
					mFont.tahoma_7_white.drawString(g, mResources.HELPUPGRADE[j], xstart, ystart + rows * indexSize + 5 + j * 12, mFont.LEFT);
				}
			}
			else
			{
				paintInfoHelpCheNgoc(g, mResources.HELPUPGRADE, 3);
			}
			g.setColor(0);
			g.fillRect(xstart - 1, ystart - 1, columns * indexSize + 3, rows * indexSize + 3);
			for (int k = 0; k < rows; k++)
			{
				for (int l = 0; l < columns; l++)
				{
					SmallImage.drawSmallImage(g, 154, xstart + l * indexSize + indexSize / 2, ystart + k * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
					g.setColor(12281361);
					g.drawRect(xstart + l * indexSize, ystart + k * indexSize, indexSize, indexSize);
				}
			}
			if (indexTitle == 2)
			{
				int num7 = indexSelect / columns;
				int num8 = indexSelect - num7 * columns;
				g.setColor(16777215);
				g.drawRect(xstart + num8 * indexSize, ystart + num7 * indexSize, indexSize, indexSize);
			}
			for (int m = 0; m < arrItemUpGrade.Length; m++)
			{
				Item item = arrItemUpGrade[m];
				if (item != null)
				{
					int num9 = m / columns;
					int num10 = m - num9 * columns;
					if (!item.isLock)
					{
						g.setColor(12083);
						g.fillRect(xstart + num10 * indexSize + 1, ystart + num9 * indexSize + 1, indexSize - 1, indexSize - 1);
					}
					SmallImage.drawSmallImage(g, item.template.iconID, xstart + num10 * indexSize + indexSize / 2, ystart + num9 * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				}
			}
			if (effUpok == null)
			{
				return;
			}
			SmallImage.drawSmallImage(g, effUpok.arrEfInfo[indexEff].idImg, num + indexSize / 2 + effUpok.arrEfInfo[indexEff].dx + 1, num3 + indexSize / 2 + 9 + effUpok.arrEfInfo[indexEff].dy, 0, mGraphics.VCENTER | mGraphics.HCENTER);
			if (GameCanvas.gameTick % 2 == 0)
			{
				indexEff++;
				if (indexEff >= effUpok.arrEfInfo.Length)
				{
					indexEff = 0;
					effUpok = null;
				}
			}
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
	}

	private void paintItem(mGraphics g, Item item, int x, int y)
	{
		paintItem(g, item, x, y, 0, 0);
	}

	public void paintStands(mGraphics g, string[] titles)
	{
		try
		{
			rows = 5;
			GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
			paintItemFrame(g, titles, paintMoney: false);
			g.setColor(6693376);
			g.fillRect(popupX + 3, popupY + 32, 168, 140);
			g.setColor(13408563);
			g.drawRect(popupX + 3, popupY + 32, 168, 140);
			int num = popupX + 74;
			int num2 = popupY + 40 + indexSize;
			mFont.tahoma_7_white.drawString(g, mResources.ITEM_SELL, num + indexSize / 2, num2 - indexSize / 2 - 4, mFont.CENTER);
			if (itemSell != null)
			{
				g.setColor(6425);
				g.fillRect(num - 1, num2 - 1, indexSize + 3, indexSize + 3);
				SmallImage.drawSmallImage(g, 154, num + indexSize / 2, num2 + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				paintItem(g, itemSell, num, num2);
				if (itemSell.quantity > 1)
				{
					mFont.number_yellow.drawString(g, string.Empty + itemSell.quantity, num + indexSize, num2 + indexSize / 2 + 6, 1);
				}
				g.setColor((indexTitle != 1) ? 12281361 : 16777215);
				g.drawRect(num, num2, indexSize, indexSize);
			}
			else
			{
				g.setColor(6425);
				g.fillRect(num - 1, num2 - 1, indexSize + 3, indexSize + 3);
				SmallImage.drawSmallImage(g, 154, num + indexSize / 2, num2 + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				g.setColor(12281361);
				g.drawRect(num, num2, indexSize, indexSize);
			}
			mFont.tahoma_7_white.drawString(g, mResources.MONEY_SELL, num + indexSize / 2, num2 + 3 * indexSize / 2 + 2, mFont.CENTER);
			if (Char.getMyChar().xu < 5000)
			{
				mFont.tahoma_7_red.drawString(g, mResources.SALENEED, num + indexSize / 2, popupY + popupH - 25, mFont.CENTER);
				mFont.tahoma_7_red.drawString(g, mResources.SALETAX, num + indexSize / 2, popupY + popupH - 13, mFont.CENTER);
			}
			else
			{
				mFont.tahoma_7_white.drawString(g, mResources.SALENEED, num + indexSize / 2, popupY + popupH - 25, mFont.CENTER);
				mFont.tahoma_7_white.drawString(g, mResources.SALETAX, num + indexSize / 2, popupY + popupH - 13, mFont.CENTER);
			}
			tfText.x = popupX + 40;
			tfText.y = popupY + 130;
			tfText.paint(g);
		}
		catch (Exception)
		{
		}
	}

	public void paintConvert(mGraphics g, string[] titles)
	{
		try
		{
			rows = 3;
			GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
			paintTitle(g, titles[indexMenu], titles.Length > 1);
			xstart = popupX + 3;
			ystart = popupY + 34 + indexSize;
			int num = popupX + 45;
			int num2 = popupX + 100;
			int num3 = ystart - indexSize - 3;
			if (arrItemConvert[0] != null)
			{
				paintItem(g, arrItemConvert[0], num, num3);
				g.setColor(12281361);
				g.drawRect(num, num3, indexSize, indexSize);
				mFont.tahoma_7_yellow.drawString(g, "(+" + arrItemConvert[0].upgrade + ")", num - 5, num3 + indexSize / 2 - 5, mFont.RIGHT);
			}
			else
			{
				g.setColor(6425);
				g.fillRect(num - 1, num3 - 1, indexSize + 3, indexSize + 3);
				SmallImage.drawSmallImage(g, 154, num + indexSize / 2, num3 + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				g.setColor(12281361);
				g.drawRect(num, num3, indexSize, indexSize);
			}
			SmallImage.drawSmallImage(g, 942, num + 43, ystart - 15, 0, StaticObj.VCENTER_HCENTER);
			if (arrItemConvert[1] != null)
			{
				Item item = arrItemConvert[1].clone();
				if (arrItemConvert[0] != null && arrItemConvert[0].template.type == item.template.type && arrItemConvert[1].template.level >= arrItemConvert[0].template.level)
				{
					item.upgrade = arrItemConvert[0].upgrade;
				}
				paintItem(g, item, num2, num3);
				g.setColor(12281361);
				g.drawRect(num2, num3, indexSize, indexSize);
				mFont.tahoma_7_yellow.drawString(g, "(+" + item.upgrade + ")", num2 + indexSize + 10, num3 + indexSize / 2 - 5, mFont.LEFT);
			}
			else
			{
				g.setColor(6425);
				g.fillRect(num2 - 1, num3 - 1, indexSize + 3, indexSize + 3);
				SmallImage.drawSmallImage(g, 154, num2 + indexSize / 2, num3 + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				g.setColor(12281361);
				g.drawRect(num2, num3, indexSize, indexSize);
			}
			if (indexTitle == 1)
			{
				if (indexSelect == 0)
				{
					g.setColor(16777215);
					g.drawRect(num, num3, indexSize, indexSize);
				}
				if (indexSelect == 1)
				{
					g.setColor(16777215);
					g.drawRect(num2, num3, indexSize, indexSize);
				}
			}
			g.setColor(0);
			g.fillRect(xstart - 1, ystart - 1, columns * indexSize + 3, rows * indexSize + 3);
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					SmallImage.drawSmallImage(g, 154, xstart + j * indexSize + indexSize / 2, ystart + i * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
					g.setColor(12281361);
					g.drawRect(xstart + j * indexSize, ystart + i * indexSize, indexSize, indexSize);
				}
			}
			Item item2 = arrItemConvert[2];
			if (item2 != null)
			{
				int num4 = 0 / columns;
				int num5 = -(num4 * columns);
				if (!item2.isLock)
				{
					g.setColor(12083);
					g.fillRect(xstart + num5 * indexSize + 1, ystart + num4 * indexSize + 1, indexSize - 1, indexSize - 1);
				}
				SmallImage.drawSmallImage(g, item2.template.iconID, xstart + num5 * indexSize + indexSize / 2, ystart + num4 * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
			}
			if (Main.isPC)
			{
				mFont.tahoma_7_white.drawString(g, "- " + mResources.UPGRADE_CONDITION[0], xstart, ystart + rows * indexSize + 10, mFont.LEFT);
				mFont.tahoma_7_white.drawString(g, "- " + mResources.UPGRADE_CONDITION[1], xstart, ystart + rows * indexSize + 22, mFont.LEFT);
				mFont.tahoma_7_white.drawString(g, "- " + mResources.UPGRADE_CONDITION[2], xstart, ystart + rows * indexSize + 34, mFont.LEFT);
			}
			else
			{
				paintInfoHelpCheNgoc(g, new string[2]
				{
					"- " + mResources.UPGRADE_CONDITION[0] + " " + mResources.UPGRADE_CONDITION[1],
					"- " + mResources.UPGRADE_CONDITION[2]
				}, 3);
			}
			if (indexTitle == 2)
			{
				int num6 = indexSelect / columns;
				int num7 = indexSelect - num6 * columns;
				g.setColor(16777215);
				g.drawRect(xstart + num7 * indexSize, ystart + num6 * indexSize, indexSize, indexSize);
			}
		}
		catch (Exception)
		{
			Out.println("loi paintCOnvert");
		}
	}

	private void paintItem(mGraphics g, Item item, int x, int y, int dUpgrade, int dR)
	{
		if (!item.isTypeMounts())
		{
			int num = item.upgrade + dUpgrade;
			if (num > 0)
			{
				if (num >= 4)
				{
					g.setColor(color[num]);
					g.fillRect(x + 1 + dR, y + 1 + dR, indexSize - 1 - 2 * dR, indexSize - 1 - 2 * dR);
					SmallImage.drawSmallImage(g, 154, x + indexSize / 2, y + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				}
				else
				{
					paintItemBackground(g, item, x, y, dR);
				}
				if (num >= 1)
				{
					paintUpgradeEffect(x + indexSize / 2, y + indexSize / 2, num, g);
				}
			}
			else
			{
				paintItemBackground(g, item, x, y, dR);
			}
		}
		SmallImage.drawSmallImageNew(g, item.template.iconID, x + indexSize / 2, y + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
	}

	private void paintItemBackground(mGraphics g, Item item, int x, int y, int dR)
	{
		if (!item.isLock)
		{
			g.setColor(12083);
		}
		else
		{
			g.setColor(6425);
		}
		g.fillRect(x + 1 + dR, y + 1 + dR, indexSize - 2 - 2 * dR, indexSize - 2 - 2 * dR);
		SmallImage.drawSmallImage(g, 154, x + indexSize / 2, y + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
	}

	public void paintSplit(mGraphics g, string[] titles)
	{
		try
		{
			GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
			paintTitle(g, titles[indexMenu], titles.Length > 1);
			xstart = popupX + 3;
			ystart = popupY + 34 + indexSize;
			int num = popupX + 74;
			int num2 = ystart - indexSize - 3;
			rows = 4;
			if (itemSplit != null)
			{
				paintItem(g, itemSplit, num, num2);
			}
			else
			{
				g.setColor(6425);
				g.fillRect(num - 1, num2 - 1, indexSize + 3, indexSize + 3);
				SmallImage.drawSmallImage(g, 154, num + indexSize / 2, num2 + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
			}
			g.setColor(12281361);
			g.drawRect(num, num2, indexSize, indexSize);
			g.setColor(6425);
			g.fillRect(xstart - 1, ystart - 1, indexSize * columns + 3, indexSize * rows + 3);
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					SmallImage.drawSmallImage(g, 154, xstart + j * indexSize + indexSize / 2, ystart + i * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
					g.setColor(12281361);
					g.drawRect(xstart + j * indexSize, ystart + i * indexSize, indexSize, indexSize);
				}
			}
			for (int k = 0; k < arrItemSplit.Length; k++)
			{
				Item item = arrItemSplit[k];
				if (item != null)
				{
					int num3 = k / columns;
					int num4 = k - num3 * columns;
					if (!item.isLock)
					{
						g.setColor(12083);
						g.fillRect(xstart + num4 * indexSize + 1, ystart + num3 * indexSize + 1, indexSize - 1, indexSize - 1);
					}
					SmallImage.drawSmallImage(g, item.template.iconID, xstart + num4 * indexSize + indexSize / 2, ystart + num3 * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				}
			}
			if (indexTitle == 1)
			{
				g.setColor(16777215);
				g.drawRect(num, num2, indexSize, indexSize);
			}
			else if (indexTitle == 2)
			{
				int num5 = indexSelect / columns;
				int num6 = indexSelect - num5 * columns;
				g.setColor(16777215);
				g.drawRect(xstart + num6 * indexSize, ystart + num5 * indexSize, indexSize, indexSize);
			}
			if (effUpok != null)
			{
				SmallImage.drawSmallImage(g, effUpok.arrEfInfo[indexEff].idImg, num + indexSize / 2 + effUpok.arrEfInfo[indexEff].dx, num2 + indexSize / 2 + effUpok.arrEfInfo[indexEff].dy, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				if (GameCanvas.gameTick % 2 == 0)
				{
					indexEff++;
					if (indexEff >= effUpok.arrEfInfo.Length)
					{
						indexEff = 0;
						effUpok = null;
					}
				}
			}
			if (!isPaintTinhluyen || itemSplit == null)
			{
				return;
			}
			ItemOption itemOption = null;
			for (int l = 0; l < itemSplit.options.size(); l++)
			{
				itemOption = (ItemOption)itemSplit.options.elementAt(l);
				if (itemOption.optionTemplate.id == 85)
				{
					break;
				}
				itemOption = null;
			}
			if (itemOption != null)
			{
				int[] array = new int[9] { 60, 45, 34, 26, 20, 15, 11, 8, 6 };
				int[] array2 = new int[9] { 150000, 247500, 408375, 673819, 1111801, 2056832, 4010822, 7420021, 12243035 };
				byte[] array3 = new byte[9] { 3, 5, 9, 4, 7, 10, 5, 7, 9 };
				mFont.tahoma_7_yellow.drawString(g, mResources.LEVEL_TINHLUYEN + ": " + NinjaUtil.numberToString(itemOption.param + 1 + string.Empty), xstart + 1, ystart + 114, mFont.LEFT);
				mFont.tahoma_7_yellow.drawString(g, mResources.PERCENT1 + array[itemOption.param] + "%)", xstart + 70, ystart + 114, mFont.LEFT);
				mFont.tahoma_7_yellow.drawString(g, mResources.NEED + ": " + NinjaUtil.numberToString(array2[itemOption.param] + string.Empty) + " " + mResources.YEN + ", " + array3[itemOption.param] + " " + ((itemOption.param < 3) ? mResources.TUTINH[1] : ((itemOption.param >= 6) ? mResources.TUTINH[3] : mResources.TUTINH[2])), xstart + 1, ystart + 125, mFont.LEFT);
			}
			else
			{
				mFont.tahoma_7_red.drawString(g, mResources.CAN_NOT_TINHLUYEN, xstart + 1, ystart + 120, mFont.LEFT);
			}
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
	}

	public void paintTrade(mGraphics g, string[] titles)
	{
		try
		{
			GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
			paintTitle(g, titles[indexMenu], titles.Length > 1);
			xstart = popupX + 3;
			ystart = popupY + 45;
			rows = 4;
			mFont.tahoma_7_yellow.drawString(g, Char.getMyChar().cName, xstart + 1, ystart - (Main.isPC ? 14 : 26), mFont.LEFT);
			int num = xstart;
			int num2 = ((!Main.isPC) ? (ystart + rows * indexSize) : (ystart + rows * (indexSize + 3) + 8));
			for (int i = 0; i < 3; i++)
			{
				if (i == typeTrade)
				{
					mFont.tahoma_7_blue1.drawString(g, string.Empty + (i + 1), num + ((!Main.isPC) ? 5 : 2) + i * 20, num2, mFont.LEFT);
				}
				else
				{
					mFont.tahoma_7_grey.drawString(g, string.Empty + (i + 1), num + ((!Main.isPC) ? 5 : 2) + i * 20, num2, mFont.LEFT);
				}
				if (i < 2)
				{
					SmallImage.drawSmallImage(g, 942, num + ((!Main.isPC) ? 17 : 14) + i * 20, num2 + 7, 0, StaticObj.VCENTER_HCENTER);
				}
			}
			if (Main.isPC)
			{
				mFont.tahoma_7_white.drawString(g, NinjaUtil.numberToString(string.Empty + coinTrade) + " " + mResources.XU, xstart, ystart + rows * indexSize + 4, mFont.LEFT);
			}
			else
			{
				mFont.tahoma_7_white.drawString(g, NinjaUtil.numberToString(string.Empty + coinTrade) + " " + mResources.XU, xstart, ystart - 14, mFont.LEFT);
				mFont.tahoma_7_white.drawString(g, NinjaUtil.numberToString(string.Empty + coinTradeOrder) + " " + mResources.XU, popupX + popupW - 2, ystart - 14, mFont.RIGHT);
			}
			if (typeTrade == 0)
			{
				g.setColor(0);
			}
			if (typeTrade == 1)
			{
				g.setColor(210986);
			}
			if (typeTrade == 2)
			{
				g.setColor(805690);
			}
			g.fillRect(xstart - 1, ystart - 1, indexSize * 3 + 3, indexSize * 4 + 3);
			for (int j = 0; j < rows; j++)
			{
				for (int k = 0; k < 3; k++)
				{
					SmallImage.drawSmallImage(g, 154, xstart + k * indexSize + indexSize / 2, ystart + j * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
					g.setColor(12281361);
					g.drawRect(xstart + k * indexSize, ystart + j * indexSize, indexSize, indexSize);
				}
			}
			if (indexTitle == 1)
			{
				int num3 = indexSelect / 3;
				int num4 = indexSelect - num3 * 3;
				g.setColor(16777215);
				g.drawRect(xstart + num4 * indexSize, ystart + num3 * indexSize, indexSize, indexSize);
			}
			if (arrItemTradeMe != null)
			{
				for (int l = 0; l < arrItemTradeMe.Length; l++)
				{
					Item item = arrItemTradeMe[l];
					if (item != null)
					{
						int num5 = l / 3;
						int num6 = l - num5 * 3;
						if (!item.isLock)
						{
							g.setColor(12083);
							g.fillRect(xstart + num6 * indexSize + 1, ystart + num5 * indexSize + 1, indexSize - 1, indexSize - 1);
						}
						SmallImage.drawSmallImage(g, item.template.iconID, xstart + num6 * indexSize + indexSize / 2, ystart + num5 * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
						if (item.quantity > 1)
						{
							mFont.number_yellow.drawString(g, string.Empty + item.quantity, xstart + num6 * indexSize + indexSize, ystart + num5 * indexSize + indexSize - mFont.number_yellow.getHeight(), 1);
						}
						if (item.quantity > 1)
						{
							mFont.number_yellow.drawString(g, string.Empty + item.quantity, xstart + num6 * indexSize + indexSize, ystart + num5 * indexSize + indexSize - mFont.number_yellow.getHeight(), 1);
						}
					}
				}
			}
			xstart = popupX + popupW - 2 - indexSize * 3;
			rows = 4;
			mFont.tahoma_7_yellow.drawString(g, tradeName, popupX + popupW - 2, ystart - (Main.isPC ? 14 : 26), mFont.RIGHT);
			num = popupX + popupW - 3 - 60;
			int num7 = 7;
			for (int m = 0; m < 3; m++)
			{
				if (m == typeTradeOrder)
				{
					mFont.tahoma_7_blue1.drawString(g, string.Empty + (m + 1), num + 2 + m * 20 + num7, num2, mFont.LEFT);
				}
				else
				{
					mFont.tahoma_7_grey.drawString(g, string.Empty + (m + 1), num + 2 + m * 20 + num7, num2, mFont.LEFT);
				}
				if (m < 2)
				{
					SmallImage.drawSmallImage(g, 942, num + 14 + m * 20 + num7, num2 + 7, 0, StaticObj.VCENTER_HCENTER);
				}
			}
			if (Main.isPC)
			{
				mFont.tahoma_7_white.drawString(g, NinjaUtil.numberToString(string.Empty + coinTradeOrder) + " " + mResources.XU, popupX + popupW - 2, ystart + rows * indexSize + 4, mFont.RIGHT);
			}
			if (typeTradeOrder == 0)
			{
				g.setColor(0);
			}
			if (typeTradeOrder == 1)
			{
				g.setColor(210986);
			}
			if (typeTradeOrder == 2)
			{
				g.setColor(805690);
			}
			g.fillRect(xstart - 1, ystart - 1, indexSize * 3 + 3, indexSize * 4 + 3);
			for (int n = 0; n < rows; n++)
			{
				for (int num8 = 0; num8 < 3; num8++)
				{
					SmallImage.drawSmallImage(g, 154, xstart + num8 * indexSize + indexSize / 2, ystart + n * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
					g.setColor(12281361);
					g.drawRect(xstart + num8 * indexSize, ystart + n * indexSize, indexSize, indexSize);
				}
			}
			if (indexTitle == 2)
			{
				int num9 = indexSelect / 3;
				int num10 = indexSelect - num9 * 3;
				g.setColor(16777215);
				g.drawRect(xstart + num10 * indexSize, ystart + num9 * indexSize, indexSize, indexSize);
			}
			if (arrItemTradeOrder != null)
			{
				for (int num11 = 0; num11 < arrItemTradeOrder.Length; num11++)
				{
					Item item2 = arrItemTradeOrder[num11];
					if (item2 != null)
					{
						int num12 = num11 / 3;
						int num13 = num11 - num12 * 3;
						if (!item2.isLock)
						{
							g.setColor(12083);
							g.fillRect(xstart + num13 * indexSize + 1, ystart + num12 * indexSize + 1, indexSize - 1, indexSize - 1);
						}
						SmallImage.drawSmallImage(g, item2.template.iconID, xstart + num13 * indexSize + indexSize / 2, ystart + num12 * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
						if (item2.quantity > 1)
						{
							mFont.number_yellow.drawString(g, string.Empty + item2.quantity, xstart + num13 * indexSize + indexSize, ystart + num12 * indexSize + indexSize - mFont.number_yellow.getHeight(), 1);
						}
						if (item2.quantity > 1)
						{
							mFont.number_yellow.drawString(g, string.Empty + item2.quantity, xstart + num13 * indexSize + indexSize, ystart + num12 * indexSize + indexSize - mFont.number_yellow.getHeight(), 1);
						}
					}
				}
			}
			int num14 = (int)(mSystem.getCurrentTimeMillis() / 1000);
			if (timeTrade - num14 > 0 && typeTrade == 1 && typeTradeOrder == 1)
			{
				mFont.tahoma_7_white.drawString(g, mResources.WAIT + " " + (timeTrade - num14) + " " + mResources.SECOND, popupX + popupW / 2, popupY + popupH - 15, 2);
			}
			else if (typeTrade == 0)
			{
				mFont.tahoma_7_white.drawString(g, mResources.TRADEHELP, popupX + popupW / 2, popupY + popupH - 15, 2);
			}
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
	}

	public void paintInfoHelpCheNgoc(mGraphics g, string[] infoArr, int kc)
	{
		if (infoArr == null || isPaintItemInfo)
		{
			isPaintInfoHelpNotIphone = false;
			return;
		}
		isPaintInfoHelpNotIphone = true;
		resetTranslate(g);
		yhelp = 0;
		int num = 120;
		int num2 = 4 * indexSize - 3 + kc;
		if (num > GameCanvas.w - 4)
		{
			num = GameCanvas.w - 4;
		}
		if (num2 > GameCanvas.h - 4)
		{
			num2 = GameCanvas.h - 4;
		}
		int num3 = gW / 2 - num / 2;
		int num4 = gH / 2 - num2 / 2;
		num3 = popupX + 175;
		num = popupW - 179;
		num4 = popupY + 33;
		g.setColor(0);
		g.fillRect(num3 - 2, num4 - 2, num + 5, num2 + 5);
		g.setColor(13606712);
		g.drawRect(num3 - 1, num4 - 1, num + 2, num2 + 2);
		g.setColor(Paint.COLORBACKGROUND);
		g.fillRect(num3, num4, num, num2);
		scrInfo.setClip(g, num3, num4 + 2, num, num2 - 2);
		int nItem = 3;
		yhelp = num4 + 3;
		mFont tahoma_7b_white = mFont.tahoma_7b_white;
		for (int i = 0; i < infoArr.Length; i++)
		{
			paintDetailHelpInfo(g, tahoma_7b_white, infoArr[i], num3 + 8, yhelp + i * 12, mFont.LEFT, num);
		}
		scrInfo.setStyle(nItem, 12, num3, num4 + 2, num, num2 - 4, styleUPDOWN: true, 1);
		resetTranslate(g);
	}

	public void paintInfoHelpCheNgoc1(mGraphics g, string[] infoArr, int kc)
	{
		isPaintInfoHelpNotIphone = true;
		resetTranslate(g);
		yhelp = 0;
		int num = 120;
		int num2 = 4 * indexSize - 3 + kc;
		if (num > GameCanvas.w - 4)
		{
			num = GameCanvas.w - 4;
		}
		if (num2 > GameCanvas.h - 4)
		{
			num2 = GameCanvas.h - 4;
		}
		int num3 = gW / 2 - num / 2;
		int num4 = gH / 2 - num2 / 2;
		num3 = popupX + 175;
		num = popupW - 179;
		num4 = popupY + 33;
		g.setColor(0);
		g.fillRect(num3 - 2, num4 - 2, num + 5, num2 + 5);
		g.setColor(13606712);
		g.drawRect(num3 - 1, num4 - 1, num + 2, num2 + 2);
		g.setColor(Paint.COLORBACKGROUND);
		g.fillRect(num3, num4, num, num2);
		scrInfo.setClip(g, num3, num4 + 2, num, num2 - 2);
		int nItem = 3;
		yhelp = num4 + 3;
		mFont tahoma_7_yellow = mFont.tahoma_7_yellow;
		for (int i = 0; i < infoArr.Length; i++)
		{
			paintDetailHelpInfo(g, tahoma_7_yellow, infoArr[i], num3 + 8, yhelp + i * 12, mFont.LEFT, num);
		}
		scrInfo.setStyle(nItem, 12, num3, num4 + 2, num, num2 - 4, styleUPDOWN: true, 1);
		resetTranslate(g);
	}

	public void paintDetailHelpInfo(mGraphics g, mFont f, string str, int x, int y, int align, int inforW)
	{
		int num = ((!GameCanvas.isTouch || GameCanvas.w < 320) ? 10 : 20);
		string[] array = f.splitFontArray(str, inforW - num);
		for (int i = 0; i < array.Length; i++)
		{
			if (i == 0)
			{
				f.drawString(g, array[i], x, y, 0);
				continue;
			}
			f.drawString(g, array[i], x, y + i * 12, 0);
			yhelp += 12;
		}
	}

	public void paintUpPearl(mGraphics g, string[] titles)
	{
		try
		{
			resetTranslate(g);
			GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
			paintTitle(g, titles[indexMenu], titles.Length > 1);
			xstart = popupX + 3;
			ystart = popupY + 32;
			g.setColor(6425);
			rows = 4;
			if (isPaintUpPearl)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				bool flag = false;
				for (int i = 0; i < arrItemUpPeal.Length; i++)
				{
					if (arrItemUpPeal[i] != null)
					{
						if (arrItemUpPeal[i].isLock)
						{
							flag = true;
						}
						num += crystals[arrItemUpPeal[i].template.id];
						num2++;
					}
				}
				if (num > 0)
				{
					num3 = crystals.Length - 1;
					while (num3 >= 0 && num <= crystals[num3])
					{
						num3--;
					}
				}
				if (num3 >= crystals.Length - 1)
				{
					num3 = crystals.Length - 2;
				}
				if (isTypeXu)
				{
					if (num2 > 1)
					{
						if (Main.isPC)
						{
							mFont.tahoma_7_yellow.drawString(g, mResources.CRYSTALOUT + " " + (num3 + 2) + " " + ((!flag) ? string.Empty : mResources.LOCK), xstart + 3, ystart + rows * indexSize + 9, mFont.LEFT);
							if (coinUpCrystals[num3 + 1] > Char.getMyChar().xu)
							{
								mFont.tahoma_7_red.drawString(g, mResources.replace(mResources.COINNEED, NinjaUtil.numberToString(string.Empty + coinUpCrystals[num3 + 1])), xstart + 3, ystart + rows * indexSize + 21, mFont.LEFT);
							}
							else
							{
								mFont.tahoma_7_yellow.drawString(g, mResources.replace(mResources.COINNEED, NinjaUtil.numberToString(string.Empty + coinUpCrystals[num3 + 1])), xstart + 3, ystart + rows * indexSize + 21, mFont.LEFT);
							}
							mFont.tahoma_7_yellow.drawString(g, mResources.PERCENT + ": " + num * 100 / crystals[num3 + 1] + "%", xstart + 3, ystart + rows * indexSize + 33, mFont.LEFT);
						}
						else
						{
							string[] array = new string[3]
							{
								mResources.CRYSTALOUT + " " + (num3 + 2) + " " + ((!flag) ? string.Empty : mResources.LOCK),
								null,
								null
							};
							if (coinUpCrystals[num3 + 1] > Char.getMyChar().xu)
							{
								array[1] = mResources.replace(mResources.COINNEED, NinjaUtil.numberToString(string.Empty + coinUpCrystals[num3 + 1]));
							}
							else
							{
								array[1] = mResources.replace(mResources.COINNEED, NinjaUtil.numberToString(string.Empty + coinUpCrystals[num3 + 1]));
							}
							array[2] = mResources.PERCENT + ": " + num * 100 / crystals[num3 + 1] + "%";
							paintInfoHelpCheNgoc1(g, array, 0);
						}
					}
					else if (Main.isPC)
					{
						for (int j = 1; j <= 2; j++)
						{
							mFont.tahoma_7_white.drawString(g, mResources.HELPCRYSTAL[j], xstart + 3, ystart + rows * indexSize + 5 + (j - 1) * 12 - 4, mFont.LEFT);
						}
					}
					else
					{
						string[] array2 = new string[2];
						for (int k = 0; k < 2; k++)
						{
							array2[k] = mResources.HELPCRYSTAL[k];
						}
						paintInfoHelpCheNgoc(g, array2, 1);
					}
				}
				else if (num2 > 1)
				{
					if (Main.isPC)
					{
						mFont.tahoma_7_yellow.drawString(g, mResources.CRYSTALOUT + " " + (num3 + 2) + " " + mResources.LOCK, xstart + 3, ystart + rows * indexSize + 9, mFont.LEFT);
						if (coinUpCrystals[num3 + 1] > Char.getMyChar().xu + Char.getMyChar().yen)
						{
							mFont.tahoma_7_red.drawString(g, mResources.replace(mResources.COINLOCKNEED, NinjaUtil.numberToString(string.Empty + coinUpCrystals[num3 + 1])), xstart + 3, ystart + rows * indexSize + 21, mFont.LEFT);
						}
						else
						{
							mFont.tahoma_7_yellow.drawString(g, mResources.replace(mResources.COINLOCKNEED, NinjaUtil.numberToString(string.Empty + coinUpCrystals[num3 + 1])), xstart + 3, ystart + rows * indexSize + 21, mFont.LEFT);
						}
						mFont.tahoma_7_yellow.drawString(g, mResources.PERCENT + ": " + num * 100 / crystals[num3 + 1] + "%", xstart + 3, ystart + rows * indexSize + 33, mFont.LEFT);
					}
					else
					{
						string[] array3 = new string[3]
						{
							mResources.CRYSTALOUT + " " + (num3 + 2) + " " + mResources.LOCK,
							null,
							null
						};
						if (coinUpCrystals[num3 + 1] > Char.getMyChar().xu + Char.getMyChar().yen)
						{
							array3[1] = mResources.replace(mResources.COINLOCKNEED, NinjaUtil.numberToString(string.Empty + coinUpCrystals[num3 + 1]));
						}
						else
						{
							array3[1] = mResources.replace(mResources.COINLOCKNEED, NinjaUtil.numberToString(string.Empty + coinUpCrystals[num3 + 1]));
						}
						array3[2] = mResources.PERCENT + ": " + num * 100 / crystals[num3 + 1] + "%";
						paintInfoHelpCheNgoc1(g, array3, 0);
					}
				}
				else if (Main.isPC)
				{
					for (int l = 0; l < 3; l++)
					{
						mFont.tahoma_7_white.drawString(g, mResources.HELPCRYSTAL[l], xstart + 3, ystart + rows * indexSize + 5 + l * 12, mFont.LEFT);
					}
				}
				else
				{
					paintInfoHelpCheNgoc(g, mResources.HELPCRYSTAL, 1);
				}
			}
			else
			{
				mFont.tahoma_7_white.drawString(g, mResources.LUYEN_THACH[0], xstart + 3, ystart + rows * indexSize + 9, mFont.LEFT);
				mFont.tahoma_7_white.drawString(g, mResources.LUYEN_THACH[1], xstart + 3, ystart + rows * indexSize + 21, mFont.LEFT);
				mFont.tahoma_7_white.drawString(g, mResources.LUYEN_THACH[2], xstart + 3, ystart + rows * indexSize + 33, mFont.LEFT);
			}
			g.setColor(0);
			g.fillRect(xstart, ystart, columns * indexSize + 1, rows * indexSize + 1);
			for (int m = 0; m < rows; m++)
			{
				for (int n = 0; n < columns; n++)
				{
					SmallImage.drawSmallImage(g, 154, xstart + n * indexSize + indexSize / 2, ystart + m * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
					g.setColor(12281361);
					g.drawRect(xstart + n * indexSize, ystart + m * indexSize, indexSize, indexSize);
				}
			}
			for (int num4 = 0; num4 < arrItemUpPeal.Length; num4++)
			{
				Item item = arrItemUpPeal[num4];
				if (item != null)
				{
					int num5 = num4 / columns;
					int num6 = num4 - num5 * columns;
					if (!item.isLock)
					{
						g.setColor(4543829);
						g.fillRect(xstart + num6 * indexSize + 1, ystart + num5 * indexSize + 1, indexSize - 1, indexSize - 1);
					}
					SmallImage.drawSmallImage(g, item.template.iconID, xstart + num6 * indexSize + indexSize / 2, ystart + num5 * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				}
			}
			if (indexTitle > 0)
			{
				int num7 = indexSelect / columns;
				int num8 = indexSelect - num7 * columns;
				g.setColor(16777215);
				g.drawRect(xstart + num8 * indexSize, ystart + num7 * indexSize, indexSize, indexSize);
			}
			if (effUpok == null)
			{
				return;
			}
			SmallImage.drawSmallImage(g, effUpok.arrEfInfo[indexEff].idImg, xstart + indexSize / 2 + effUpok.arrEfInfo[indexEff].dx + 1, ystart + indexSize / 2 + 9 + effUpok.arrEfInfo[indexEff].dy, 0, mGraphics.VCENTER | mGraphics.HCENTER);
			if (GameCanvas.gameTick % 2 == 0)
			{
				indexEff++;
				if (indexEff >= effUpok.arrEfInfo.Length)
				{
					indexEff = 0;
					effUpok = null;
				}
			}
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
		}
	}

	public void paintUIEliteShop(mGraphics g)
	{
		if (isPaintEliteShop)
		{
			paintItemList(g, mResources.TITLEELITESHOP, arrItemElites);
		}
	}

	public void paintUIStore(mGraphics g)
	{
		if (isPaintStore)
		{
			if (indexMenu == 0)
			{
				paintItemList(g, mResources.TITLESTORE, arrItemStore);
			}
			else if (indexMenu == 1)
			{
				paintItemList(g, mResources.TITLESTORE, arrItemBook);
			}
			else if (indexMenu == 2)
			{
				paintItemList(g, mResources.TITLESTORE, arrItemFashion);
			}
			else if (indexMenu == 3)
			{
				paintItemList(g, mResources.TITLESTORE, arrItemClanShop);
			}
			else if (indexMenu == 51)
			{
				paintShopOnline(g, arrItemFashion);
			}
		}
	}

	public void paintUILuckySprin(mGraphics g)
	{
		if (!isPaintLuckySpin)
		{
			return;
		}
		resetTranslate(g);
		GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
		int num = popupW;
		if (GameCanvas.isTouchControlLargeScreen)
		{
			num = popupW / 2 + 20;
		}
		g.setColor(0);
		g.fillRect(popupX + 7, popupY + 31, num - 14, popupH - 58);
		g.setColor(13606712);
		g.drawRect(popupX + 8, popupY + 32, num - 16, popupH - 60);
		g.setColor(Paint.COLORBACKGROUND);
		g.fillRect(popupX + 9, popupY + 33, num - 18, popupH - 62);
		paintTitle(g, mResources.LATQUA, arrow: false);
		int num2 = 40 - ((!Main.isPC) ? 3 : 0);
		int num3 = 35;
		int num4 = (Main.isPC ? 1 : 3);
		int num5 = ((!Main.isPC) ? 2 : 0);
		int num6 = 3;
		xstart = popupX + 33;
		ystart = popupY + 40;
		for (int i = 0; i < num6; i++)
		{
			for (int j = 0; j < num6; j++)
			{
				g.setColor(Paint.COLORDARK);
				g.fillRect(xstart + j * num2, ystart + 10 + i * num2, num3 - 6, num3 - 6);
				g.setColor(10249521);
				g.drawRect(xstart + j * num2, ystart + 10 + i * num2, num3 - 6, num3 - 6);
				g.setColor(10040064);
				g.fillRect(xstart + j * num2 + 2, ystart + 12 + i * num2, num3 - 9, num3 - 9);
				g.setColor(Paint.COLORDARK);
				g.fillRect(xstart + j * num2 + 4, ystart + 14 + i * num2, num3 - 13, num3 - 13);
				SmallImage.drawSmallImage(g, 1414, xstart + j * num2 + num2 / 2 - 5 + num5, ystart + i * num2 + num2 / 2 + 4 + num4, 0, StaticObj.VCENTER_HCENTER);
			}
		}
		num5 = ((num5 != 0) ? 1 : 0);
		num4 = ((num4 != 0) ? 1 : 0);
		for (int k = 0; k < 9; k++)
		{
			int num7 = k / num6;
			int num8 = k - num7 * num6;
			if (arrItemSprin != null)
			{
				g.setColor(6425);
				g.fillRect(xstart + num8 * num2 + 4, ystart + 14 + num7 * num2, num3 - 13, num3 - 13);
				g.setColor((k != indexSelect) ? 10249521 : 16777215);
				g.drawRect(xstart + num8 * num2 + 4, ystart + 14 + num7 * num2, num3 - 14, num3 - 14);
				SmallImage.drawSmallImage(g, 154, xstart + num8 * num2 + num3 / 2 - 3 + num5, ystart + 7 + num7 * num2 + num3 / 2 + num4, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				if (mSystem.getCurrentTimeMillis() - timePoint < 1000)
				{
					if (k == indexCard)
					{
						SmallImage.drawSmallImage(g, ItemTemplates.getIcon(arrItemSprin[indexCard]), (Main.isPC ? 1 : 0) + num5 + xstart + num8 * num2 + num3 / 2 - 3, num4 + ystart + 7 + num7 * num2 + num3 / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
					}
					else
					{
						SmallImage.drawSmallImage(g, 1414, num5 + xstart + num8 * num2 + num3 / 2 - 2 + ((!Main.isPC) ? (-1) : 0), num4 + ystart + 7 + num7 * num2 + num3 / 2, 0, StaticObj.VCENTER_HCENTER);
					}
				}
				else if (arrItemSprin[k] < 0 || arrItemSprin[k] >= ItemTemplates.itemTemplates.size())
				{
					SmallImage.drawSmallImage(g, ItemTemplates.getIcon(242), (Main.isPC ? 1 : 0) + num5 + xstart + num8 * num2 + num3 / 2 - 3, ystart + 7 + num7 * num2 + num3 / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				}
				else
				{
					SmallImage.drawSmallImage(g, ItemTemplates.getIcon(arrItemSprin[k]), (Main.isPC ? 1 : 0) + num5 + xstart + num8 * num2 + num3 / 2 - 3, ystart + 7 + num7 * num2 + num3 / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				}
				if (indexCard == k && yenTemp > 0)
				{
					yenValue[k] = yenTemp + string.Empty;
				}
				if (indexTitle == 1)
				{
					if (indexCard == k && GameCanvas.gameTick % 10 > 4)
					{
						g.setColor(13408563);
						g.drawRect(xstart + num8 * num2, ystart + 10 + num7 * num2, num3 - 6, num3 - 6);
					}
					else if (k == indexSelect)
					{
						g.setColor(16777215);
						g.drawRect(xstart + num8 * num2, ystart + 10 + num7 * num2, num3 - 6, num3 - 6);
					}
					else
					{
						g.setColor(Paint.COLORLIGHT);
						g.drawRect(xstart + num8 * num2, ystart + 10 + num7 * num2, num3 - 6, num3 - 6);
					}
				}
			}
			else if (indexTitle == 1)
			{
				g.setColor((k != indexSelect) ? Paint.COLORLIGHT : 16777215);
				g.drawRect(xstart + num8 * num2, ystart + 10 + num7 * num2, num3 - 6, num3 - 6);
			}
		}
		mFont.tahoma_7_yellow.drawString(g, mResources.LUOTLATQUA + numSprinLeft, popupX + popupW / 2, popupY + popupH - 20, mFont.CENTER);
	}

	public void paintNonNam(mGraphics g)
	{
		if (isPaintNonNam)
		{
			if (indexMenu == 0)
			{
				paintItemList(g, mResources.TITLECLOTHE, arrItemNonNam);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLENON);
			}
		}
	}

	public void paintNonNu(mGraphics g)
	{
		if (isPaintNonNu)
		{
			if (indexMenu == 0)
			{
				paintItemList(g, mResources.TITLECLOTHE, arrItemNonNu);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLENON);
			}
		}
	}

	public void paintAoNam(mGraphics g)
	{
		if (isPaintAoNam)
		{
			if (indexMenu == 0)
			{
				paintItemList(g, mResources.TITLECLOTHE, arrItemAoNam);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLEAO);
			}
		}
	}

	public void paintAoNu(mGraphics g)
	{
		if (isPaintAoNu)
		{
			if (indexMenu == 0)
			{
				paintItemList(g, mResources.TITLECLOTHE, arrItemAoNu);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLEAO);
			}
		}
	}

	public void paintGangTayNam(mGraphics g)
	{
		if (isPaintGangTayNam)
		{
			if (indexMenu == 0)
			{
				paintItemList(g, mResources.TITLECLOTHE, arrItemGangTayNam);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLEGANGTAY);
			}
		}
	}

	public void paintGangTayNu(mGraphics g)
	{
		if (isPaintGangTayNu)
		{
			if (indexMenu == 0)
			{
				paintItemList(g, mResources.TITLECLOTHE, arrItemGangTayNu);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLEGANGTAY);
			}
		}
	}

	public void paintQuanNam(mGraphics g)
	{
		if (isPaintQuanNam)
		{
			if (indexMenu == 0)
			{
				paintItemList(g, mResources.TITLECLOTHE, arrItemQuanNam);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLEQUAN);
			}
		}
	}

	public void paintQuanNu(mGraphics g)
	{
		if (isPaintQuanNu)
		{
			if (indexMenu == 0)
			{
				paintItemList(g, mResources.TITLEQUAN, arrItemQuanNu);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLEQUAN);
			}
		}
	}

	public void paintGiayNam(mGraphics g)
	{
		if (isPaintGiayNam)
		{
			if (indexMenu == 0)
			{
				paintItemList(g, mResources.TITLECLOTHE, arrItemGiayNam);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLEGIAY);
			}
		}
	}

	public void paintGiayNu(mGraphics g)
	{
		if (isPaintGiayNu)
		{
			if (indexMenu == 0)
			{
				paintItemList(g, mResources.TITLECLOTHE, arrItemGiayNu);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLEGIAY);
			}
		}
	}

	public void paintLien(mGraphics g)
	{
		if (isPaintLien)
		{
			if (indexMenu == 0)
			{
				paintItemList(g, mResources.TITLEDAYCHUYEN, arrItemLien);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLEDAYCHUYEN);
			}
		}
	}

	public void paintNhan(mGraphics g)
	{
		if (isPaintNhan)
		{
			if (indexMenu == 0)
			{
				paintItemList(g, mResources.TITLENHAN, arrItemNhan);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLENHAN);
			}
		}
	}

	public void paintNgocBoi(mGraphics g)
	{
		if (isPaintNgocBoi)
		{
			if (indexMenu == 0)
			{
				paintItemList(g, mResources.TITLENGOCBOI, arrItemNgocBoi);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLENGOCBOI);
			}
		}
	}

	public void paintPhu(mGraphics g)
	{
		if (isPaintPhu)
		{
			if (indexMenu == 0)
			{
				paintItemList(g, mResources.TITLEPHU, arrItemPhu);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLEPHU);
			}
		}
	}

	public void paintBinhkhi(mGraphics g)
	{
		if (isPaintWeapon)
		{
			if (indexMenu == 0)
			{
				paintItemList(g, mResources.TITLEWEAPON, arrItemWeapon);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLEWEAPON);
			}
		}
	}

	public void paintThuoc(mGraphics g)
	{
		if (isPaintStack)
		{
			if (indexMenu == 0)
			{
				paintItemList(g, mResources.TITLESTACK, arrItemStack);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLESTACK);
			}
		}
	}

	public void paintThuocKhoa(mGraphics g)
	{
		if (isPaintStackLock)
		{
			if (indexMenu == 0)
			{
				paintItemList(g, mResources.TITLESTACKLOCK, arrItemStackLock);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLESTACKLOCK);
			}
		}
	}

	public void paintTaphoa(mGraphics g)
	{
		if (isPaintGrocery)
		{
			if (indexMenu == 0)
			{
				paintItemList(g, mResources.TITLEGROCERY, arrItemGrocery);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLEGROCERY);
			}
		}
	}

	public void paintTaphoakhoa(mGraphics g)
	{
		if (isPaintGroceryLock)
		{
			if (indexMenu == 0)
			{
				paintItemList(g, mResources.TITLEGROCERYLOCK, arrItemGroceryLock);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLEGROCERYLOCK);
			}
		}
	}

	public void paintGianHang(mGraphics g)
	{
		if (isPaintAuctionSale)
		{
			if (indexMenu == 0)
			{
				paintStands(g, mResources.TITLESTAND);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLESTAND);
			}
		}
	}

	public void paintChuyenHoa(mGraphics g)
	{
		if (isPaintConvert)
		{
			if (indexMenu == 0)
			{
				paintConvert(g, mResources.TITLECONVERT);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLEUPGRADE);
			}
		}
	}

	public void paintCuonghoa(mGraphics g)
	{
		if (isPaintUpGrade)
		{
			if (indexMenu == 0)
			{
				paintUpgrade(g, mResources.TITLEUPGRADE);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLEUPGRADE);
			}
		}
	}

	public void paintTachHT(mGraphics g)
	{
		if (isPaintSplit)
		{
			if (indexMenu == 0)
			{
				paintSplit(g, mResources.TITLESPLIT);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLESPLIT);
			}
		}
	}

	public void paintLuyenThu(mGraphics g)
	{
		if (isPaintDichChuyen)
		{
			if (indexMenu == 0)
			{
				paintSplit(g, mResources.TITLELUYENTHU);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLELUYENTHU);
			}
		}
	}

	public void paintLuyenAo(mGraphics g)
	{
		if (isPaintTinhluyen)
		{
			if (indexMenu == 0)
			{
				paintSplit(g, mResources.TITLELUYENAO);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLELUYENAO);
			}
		}
	}

	public void paintItemTrade(mGraphics g)
	{
		if (isPaintTrade)
		{
			if (indexMenu == 0)
			{
				paintTrade(g, mResources.TITLETRADE);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLETRADE);
			}
		}
	}

	public void paintGhepngoc(mGraphics g)
	{
		if (isPaintUpPearl)
		{
			if (indexMenu == 0)
			{
				paintUpPearl(g, mResources.TITLEUPPEARL);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLEUPPEARL);
			}
		}
	}

	public void paintLuyenThach(mGraphics g)
	{
		if (isPaintLuyenThach)
		{
			if (indexMenu == 0)
			{
				paintUpPearl(g, mResources.TITLELUYENTHACH);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLELUYENTHACH);
			}
		}
	}

	public void paintRuong(mGraphics g)
	{
		if (isPaintBox)
		{
			if (indexMenu == 0)
			{
				paintBox(g, mResources.TITLEBOX);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLEBOX);
			}
		}
	}

	public void paintTiemNang(mGraphics g)
	{
		if (indexMenu != 2)
		{
			return;
		}
		g.translate(-g.getTranslateX(), -g.getTranslateY());
		GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
		paintTitle(g, mResources.MENUME[indexMenu], arrow: true);
		mFont.tahoma_8b.drawString(g, mResources.POTENTIAL_POINT, popupX + 10, popupY + 33, 0);
		mFont.tahoma_8b.drawString(g, string.Empty + Char.getMyChar().pPoint, popupX + popupW - 10, popupY + 33, mFont.RIGHT);
		int num = (popupH - 80) / 5;
		for (int i = 0; i < Char.getMyChar().potential.Length; i++)
		{
			g.setColor(Paint.COLORBORDER);
			if (indexTitle > 0 && indexTitle - 1 == i)
			{
				g.setColor(Paint.COLORDARK);
				g.fillRect(popupX + 5, popupY + 52 + i * (num + 4), popupW - 10, num);
				g.setColor(Paint.COLORFOCUS);
			}
			g.drawRect(popupX + 5, popupY + 52 + i * (num + 4), popupW - 10, num);
			mFont.tahoma_7b_white.drawString(g, string.Empty + Char.getMyChar().potential[i], popupX + popupW - 10, popupY + 49 + (num - 10) / 2 + i * (num + 4), mFont.RIGHT);
			mFont.tahoma_7b_white.drawString(g, mResources.NAMEPOTENTIAL[i], popupX + 10, popupY + 49 + (num - 10) / 2 + i * (num + 4), 0);
		}
		if (indexTitle > 0)
		{
			switch (Char.getMyChar().nClass.classId)
			{
			case 0:
				mFont.tahoma_7_green.drawString(g, mResources.HELPPOTENTIAL1[0], popupX + 10, popupY + 52 + (num - 10) / 2 + 4 * (num + 4), 0);
				break;
			case 1:
			case 3:
			case 5:
				mFont.tahoma_7_green.drawString(g, mResources.HELPPOTENTIAL2[indexTitle - 1], popupX + 10, popupY + 52 + (num - 10) / 2 + 4 * (num + 4), 0);
				break;
			case 2:
			case 4:
			case 6:
				mFont.tahoma_7_green.drawString(g, mResources.HELPPOTENTIAL3[indexTitle - 1], popupX + 10, popupY + 52 + (num - 10) / 2 + 4 * (num + 4), 0);
				break;
			}
		}
	}

	public static Item getItemFocus(int typeUI)
	{
		if (indexSelect < 0)
		{
			return null;
		}
		try
		{
			switch (typeUI)
			{
			case 3:
				return Char.getMyChar().arrItemBag[indexSelect];
			case 4:
				return Char.getMyChar().arrItemBox[indexSelect];
			case 5:
				return currentCharViewInfo.arrItemBody[indexSelect + indextabTrangbi];
			case 20:
				return (arrItemNonNam.Length <= indexSelect) ? null : arrItemNonNam[indexSelect];
			case 21:
				return (arrItemNonNu.Length <= indexSelect) ? null : arrItemNonNu[indexSelect];
			case 22:
				return (arrItemAoNam.Length <= indexSelect) ? null : arrItemAoNam[indexSelect];
			case 23:
				return (arrItemAoNu.Length <= indexSelect) ? null : arrItemAoNu[indexSelect];
			case 24:
				return (arrItemGangTayNam.Length <= indexSelect) ? null : arrItemGangTayNam[indexSelect];
			case 25:
				return (arrItemGangTayNu.Length <= indexSelect) ? null : arrItemGangTayNu[indexSelect];
			case 26:
				return (arrItemQuanNam.Length <= indexSelect) ? null : arrItemQuanNam[indexSelect];
			case 27:
				return (arrItemQuanNu.Length <= indexSelect) ? null : arrItemQuanNu[indexSelect];
			case 28:
				return (arrItemGiayNam.Length <= indexSelect) ? null : arrItemGiayNam[indexSelect];
			case 29:
				return (arrItemGiayNu.Length <= indexSelect) ? null : arrItemGiayNu[indexSelect];
			case 16:
				return (arrItemLien.Length <= indexSelect) ? null : arrItemLien[indexSelect];
			case 17:
				return (arrItemNhan.Length <= indexSelect) ? null : arrItemNhan[indexSelect];
			case 18:
				return (arrItemNgocBoi.Length <= indexSelect) ? null : arrItemNgocBoi[indexSelect];
			case 19:
				return (arrItemPhu.Length <= indexSelect) ? null : arrItemPhu[indexSelect];
			case 2:
				return (arrItemWeapon.Length <= indexSelect) ? null : arrItemWeapon[indexSelect];
			case 6:
				return (arrItemStack.Length <= indexSelect) ? null : arrItemStack[indexSelect];
			case 7:
				return (arrItemStackLock.Length <= indexSelect) ? null : arrItemStackLock[indexSelect];
			case 8:
				return (arrItemGrocery.Length <= indexSelect) ? null : arrItemGrocery[indexSelect];
			case 9:
				return (arrItemGroceryLock.Length <= indexSelect) ? null : arrItemGroceryLock[indexSelect];
			case 14:
				return (arrItemStore.Length <= indexSelect) ? null : arrItemStore[indexSelect];
			case 35:
				return (arrItemElites.Length <= indexSelect) ? null : arrItemElites[indexSelect];
			case 15:
				return (arrItemBook.Length <= indexSelect) ? null : arrItemBook[indexSelect];
			case 51:
				return (arrItemFashion.Length <= indexSelect) ? null : arrItemFashion[indexSelect];
			case 32:
				return (arrItemFashion.Length <= indexSelect) ? null : arrItemFashion[indexSelect];
			case 11:
				return arrItemUpPeal[indexSelect];
			case 10:
				return arrItemUpGrade[indexSelect];
			case 43:
				return arrItemUpPeal[indexSelect];
			case 44:
				return arrItemSplit[indexSelect];
			case 45:
				return arrItemSplit[indexSelect];
			case 34:
				return (arrItemClanShop.Length <= indexSelect) ? null : arrItemClanShop[indexSelect];
			case 46:
				return arrItemSplit[indexSelect];
			case 47:
				return arrItemUpGrade[indexSelect];
			case 48:
				return arrItemSplit[indexSelect];
			case 12:
			case 13:
			case 30:
			case 31:
			case 33:
			case 36:
			case 37:
			case 38:
			case 39:
			case 40:
			case 41:
			case 42:
			case 49:
			case 50:
				break;
			}
		}
		catch (Exception ex)
		{
			Out.println("loi tai getItemFocus " + ex.ToString() + typeUI);
		}
		return null;
	}

	public static void loadImg()
	{
		TileMap.loadTileImage();
	}

	public void paintTitle(mGraphics g, string title, bool arrow)
	{
		if (!svTitle.Equals(string.Empty))
		{
			title = svTitle;
		}
		int num = 0;
		num = gW / 2;
		g.setColor(Paint.COLORDARK);
		g.fillRoundRect(num - mFont.tahoma_8b.getWidth(title) / 2 - 12, popupY + 5, mFont.tahoma_8b.getWidth(title) + 22, 24, 6, 6);
		if ((indexTitle == 0 || GameCanvas.isTouch) && arrow)
		{
			SmallImage.drawSmallImage(g, 989, num - mFont.tahoma_8b.getWidth(title) / 2 - 15 - 7 - ((GameCanvas.gameTick % 8 <= 3) ? 2 : 0), popupY + 17, 2, StaticObj.VCENTER_HCENTER);
			SmallImage.drawSmallImage(g, 989, num + mFont.tahoma_8b.getWidth(title) / 2 + 15 + 5 + ((GameCanvas.gameTick % 8 <= 3) ? 2 : 0), popupY + 17, 0, StaticObj.VCENTER_HCENTER);
		}
		if (indexTitle == 0)
		{
			g.setColor(Paint.COLORFOCUS);
		}
		else
		{
			g.setColor(Paint.COLORBORDER);
		}
		g.drawRoundRect(num - mFont.tahoma_8b.getWidth(title) / 2 - 12, popupY + 5, mFont.tahoma_8b.getWidth(title) + 22, 24, 6, 6);
		mFont.tahoma_8b.drawString(g, title, num, popupY + 9, 2);
	}

	public void paintZone(mGraphics g)
	{
		if (!isPaintZone)
		{
			return;
		}
		resetTranslate(g);
		paintItemFrame(g, new string[1] { mResources.ZONE }, paintMoney: false);
		mFont.tahoma_7_yellow.drawString(g, TileMap.mapName, popupX + popupW / 2, popupY + popupH - 25, mFont.CENTER);
		if (indexSelect >= 0 && indexSelect < zones.Length)
		{
			mFont.tahoma_7_white.drawString(g, mResources.POPULATION + ": " + zones[indexSelect] + ", " + mResources.PARTY + ": " + pts[indexSelect], popupX + popupW / 2, popupY + popupH - 13, mFont.CENTER);
		}
		int num = indexSelect / zoneCol;
		int num2 = indexSelect % zoneCol;
		rows = zones.Length / zoneCol;
		if (zones.Length % zoneCol > 0)
		{
			rows++;
		}
		if (rows < 5)
		{
			rows = 5;
		}
		int num3 = (Main.isPC ? 5 : 4);
		scrMain.setStyle(rows, indexSize, xstart, ystart, columns * indexSize + 2, num3 * indexSize, styleUPDOWN: true, 6);
		scrMain.height = num3 * indexSize + 2;
		scrMain.setClip(g);
		int num4 = 0;
		for (int i = 0; i < rows; i++)
		{
			for (int j = 0; j < zoneCol; j++)
			{
				g.setColor(12281361);
				g.drawRect(xstart + j * indexSize, ystart + i * indexSize, indexSize, indexSize);
				if (num4 < zones.Length)
				{
					SmallImage.drawSmallImage(g, 154, xstart + j * indexSize + indexSize / 2, ystart + i * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
					if (zones[num4] >= 20)
					{
						mFont.tahoma_7b_red.drawString(g, string.Empty + num4, xstart + j * indexSize + indexSize / 2, ystart + i * indexSize + indexSize / 2 - 8, 2);
					}
					else if (zones[num4] >= 15)
					{
						mFont.tahoma_7b_yellow.drawString(g, string.Empty + num4, xstart + j * indexSize + indexSize / 2, ystart + i * indexSize + indexSize / 2 - 8, 2);
					}
					else
					{
						mFont.tahoma_7b_white.drawString(g, string.Empty + num4, xstart + j * indexSize + indexSize / 2, ystart + i * indexSize + indexSize / 2 - 8, 2);
					}
					num4++;
				}
			}
		}
		if (indexSelect >= 0)
		{
			g.setColor(16777215);
			g.drawRect(xstart + num2 * indexSize, ystart + num * indexSize, indexSize, indexSize);
		}
	}

	public void upPearl()
	{
		int num = 0;
		int num2 = 0;
		bool flag = false;
		bool flag2 = false;
		for (int i = 0; i < arrItemUpPeal.Length; i++)
		{
			if (arrItemUpPeal[i] != null)
			{
				num++;
				num2 += crystals[arrItemUpPeal[i].template.id];
				if (arrItemUpPeal[i].template.id == 11)
				{
					GameCanvas.msgdlg.setInfo(mResources.UP_MAX, null, new Command(mResources.CLOSE, 1), null);
					GameCanvas.msgdlg.show();
					return;
				}
			}
			if (arrItemUpPeal[i] != null && arrItemUpPeal[i].isLock)
			{
				flag = true;
			}
			if (arrItemUpPeal[i] != null && !arrItemUpPeal[i].isLock)
			{
				flag2 = true;
			}
		}
		if (num <= 1)
		{
			GameCanvas.msgdlg.setInfo(mResources.NOT_ENOUGH_UPPEARL, null, new Command(mResources.CLOSE, 1), null);
			GameCanvas.msgdlg.show();
			return;
		}
		int num3 = 0;
		num3 = crystals.Length - 1;
		while (num3 >= 0 && num2 <= crystals[num3])
		{
			num3--;
		}
		if (num3 >= crystals.Length - 1)
		{
			num3 = crystals.Length - 2;
		}
		if (isTypeXu)
		{
			if (coinUpCrystals[num3 + 1] > Char.getMyChar().xu)
			{
				GameCanvas.msgdlg.setInfo(mResources.NOT_ENOUGH_COIN_UPPEARL, null, new Command(mResources.CLOSE, 1), null);
				GameCanvas.msgdlg.show();
			}
			else if (flag)
			{
				GameCanvas.startYesNoDlg(mResources.CONFIRMUPPEARL, 88813, arrItemUpPeal, 8882, null);
			}
			else
			{
				Service.gI().crystalCollect(arrItemUpPeal);
			}
		}
		else if (coinUpCrystals[num3 + 1] > Char.getMyChar().xu + Char.getMyChar().yen)
		{
			GameCanvas.msgdlg.setInfo(mResources.NOT_ENOUGH_COIN_UPPEARL, null, new Command(mResources.CLOSE, 1), null);
			GameCanvas.msgdlg.show();
		}
		else if (flag2)
		{
			GameCanvas.startYesNoDlg(mResources.CONFIRMUPPEARL, 88814, arrItemUpPeal, 8882, null);
		}
		else
		{
			Service.gI().crystalCollectLock(arrItemUpPeal);
		}
	}

	public void doLuyenThach()
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		for (int i = 0; i < arrItemUpPeal.Length; i++)
		{
			Item item = arrItemUpPeal[i];
			if (item != null)
			{
				if (item.template.id == 455)
				{
					num++;
				}
				else if (item.template.id == 456)
				{
					num2++;
				}
				else if (item.template.type == 26)
				{
					num3++;
					num4 = item.template.id;
				}
			}
		}
		if (num3 > 1)
		{
			GameCanvas.startOKDlg(mResources.ONLY_LUYENTHACH3);
		}
		else if (num > 9 || num2 > 9 || (num4 >= 10 && (num > 3 || num2 > 3)))
		{
			GameCanvas.startOKDlg(mResources.MAX_LUYENTHACH1);
		}
		else if (num + num2 < 3)
		{
			GameCanvas.startOKDlg(mResources.NOT_ENOUGH_LUYENTHACH1);
		}
		else if ((num4 == 10 && num2 == 3) || (num4 == 11 && num == 3))
		{
			GameCanvas.startOKDlg(mResources.ONLY_LUYENTHACH4);
		}
		else
		{
			Service.gI().luyenthach(arrItemUpPeal);
		}
	}

	public sbyte getTaskMapId()
	{
		if (Char.getMyChar().ctaskId >= tasks.Length)
		{
			return -3;
		}
		sbyte b = 0;
		b = ((Char.getMyChar().taskMaint != null) ? mapTasks[Char.getMyChar().ctaskId][Char.getMyChar().taskMaint.index + 1] : mapTasks[Char.getMyChar().ctaskId][0]);
		if (b == -1)
		{
			if (Char.getMyChar().nClass.classId == 0 && Char.getMyChar().ctaskId == 9)
			{
				b = -2;
			}
			else if (Char.getMyChar().nClass.classId == 0 || Char.getMyChar().nClass.classId == 1 || Char.getMyChar().nClass.classId == 2)
			{
				b = 1;
			}
			else if (Char.getMyChar().nClass.classId == 3 || Char.getMyChar().nClass.classId == 4)
			{
				b = 72;
			}
			else if (Char.getMyChar().nClass.classId == 5 || Char.getMyChar().nClass.classId == 6)
			{
				b = 27;
			}
		}
		return b;
	}

	public sbyte getTaskNpcId()
	{
		try
		{
			if (Char.getMyChar().ctaskId >= tasks.Length)
			{
				return -3;
			}
			sbyte b = 0;
			b = ((Char.getMyChar().taskMaint != null) ? tasks[Char.getMyChar().ctaskId][Char.getMyChar().taskMaint.index + 1] : tasks[Char.getMyChar().ctaskId][0]);
			if (b == -1)
			{
				if (Char.getMyChar().nClass.classId == 0 && Char.getMyChar().ctaskId == 9)
				{
					b = -2;
				}
				else if (Char.getMyChar().nClass.classId == 0 || Char.getMyChar().nClass.classId == 1 || Char.getMyChar().nClass.classId == 2)
				{
					b = 9;
				}
				else if (Char.getMyChar().nClass.classId == 3 || Char.getMyChar().nClass.classId == 4)
				{
					b = 10;
				}
				else if (Char.getMyChar().nClass.classId == 5 || Char.getMyChar().nClass.classId == 6)
				{
					b = 11;
				}
			}
			return b;
		}
		catch (Exception)
		{
			return -1;
		}
	}

	public void upGrade()
	{
		int num = 0;
		for (int i = 0; i < arrItemUpGrade.Length; i++)
		{
			if (arrItemUpGrade[i] != null && arrItemUpGrade[i].template.type == 26)
			{
				num += crystals[arrItemUpGrade[i].template.id];
			}
		}
		bool flag = false;
		bool flag2 = false;
		int num2 = 0;
		if (itemUpGrade.isTypeClothe())
		{
			if (coinUpClothes[itemUpGrade.upgrade] > Char.getMyChar().xu + Char.getMyChar().yen)
			{
				flag = true;
			}
			num2 = num * 100 / upClothe[itemUpGrade.upgrade];
		}
		else if (itemUpGrade.isTypeAdorn())
		{
			if (coinUpAdorns[itemUpGrade.upgrade] > Char.getMyChar().xu + Char.getMyChar().yen)
			{
				flag = true;
			}
			num2 = num * 100 / upAdorn[itemUpGrade.upgrade];
		}
		else if (itemUpGrade.isTypeWeapon())
		{
			if (coinUpWeapons[itemUpGrade.upgrade] > Char.getMyChar().xu + Char.getMyChar().yen)
			{
				flag = true;
			}
			num2 = num * 100 / upWeapon[itemUpGrade.upgrade];
		}
		if (isPaintUpGradeGold && goldUps[itemUpGrade.upgrade] > Char.getMyChar().luong)
		{
			flag2 = true;
		}
		if (flag)
		{
			InfoMe.addInfo(mResources.NOT_ENOUGH_COIN_UPGRADE, 15, mFont.tahoma_7_red);
		}
		else if (flag2)
		{
			InfoMe.addInfo(mResources.NOT_ENOUGH_GOLD_UPGRADE, 15, mFont.tahoma_7_red);
		}
		else if (num2 > 250)
		{
			GameCanvas.startYesNoDlg(mResources.PERCENT_BIG, 88815, null, 8882, null);
		}
		else
		{
			doUpgrade();
		}
	}

	public void doUpgrade()
	{
		if (!itemUpGrade.isLock)
		{
			GameCanvas.startYesNoDlg(mResources.CONFIRMUPGRADE, new Command(mResources.YES, 11063), new Command(mResources.NO, 1));
		}
		else
		{
			Service.gI().upgradeItem(itemUpGrade, arrItemUpGrade, isPaintUpGradeGold);
		}
	}

	public void split()
	{
		if (isPaintLuyenNgoc)
		{
			Service.gI().ngockham(1, null, itemSplit, arrItemSplit);
			return;
		}
		if (isPaintTinhluyen)
		{
			Service.gI().tinhluyen(itemSplit, arrItemSplit);
			return;
		}
		if (isPaintDichChuyen)
		{
			Service.gI().dichchuyen(itemSplit, arrItemSplit);
			return;
		}
		if (itemSplit.upgrade == 0)
		{
			GameCanvas.msgdlg.setInfo(mResources.NOT_UPGRADE, null, new Command(mResources.CLOSE, 1), null);
			GameCanvas.msgdlg.show();
			return;
		}
		int num = -1;
		int num2 = 0;
		for (int i = 0; i < Char.getMyChar().arrItemBag.Length; i++)
		{
			if (Char.getMyChar().arrItemBag[i] == null)
			{
				num++;
			}
		}
		for (int j = 0; j < arrItemSplit.Length; j++)
		{
			if (arrItemSplit[j] != null)
			{
				num2++;
			}
		}
		if (num2 > num)
		{
			GameCanvas.msgdlg.setInfo(mResources.BAG_FULL, null, new Command(mResources.CLOSE, 1), null);
			GameCanvas.msgdlg.show();
		}
		else
		{
			GameCanvas.startYesNoDlg(mResources.CONFIRMSPLIT, new Command(mResources.YES, 11087, itemSplit), new Command(mResources.NO, 1));
		}
	}

	public void updateItemInfo(int typeUI, Item item, Command left, Command right)
	{
		updateItemInfo(typeUI, item);
		if (left != null)
		{
			base.left = new Command(left.caption, 11040);
		}
		if (right != null)
		{
			base.right = new Command(right.caption, 11041);
		}
	}

	public void updateItemInfo(int typeUI, Item item)
	{
		if (item == null)
		{
			return;
		}
		itemFocus = item;
		inforW = 120;
		inforH = 120 - ((!Main.isPC) ? indexSize : 0);
		if (GameCanvas.isTouch && !GameCanvas.isTouchControlSmallScreen)
		{
			inforH += 18;
		}
		isPaintItemInfo = true;
		scrInfo.clear();
		indexRow = 0;
		if (item.expires == 0)
		{
			if (isPaintTinhluyen || isPaintDichChuyen || isPaintLuyenNgoc || isPaintKhamNgoc || isPaintThaoNgoc || isPaintGotNgoc)
			{
				Service.gI().requestItemInfo(item.typeUI, item.indexUI);
			}
			if (isPaintAuctionBuy)
			{
				Service.gI().requestItemAuction(item.itemId);
			}
			else if (currentCharViewInfo.charID == Char.getMyChar().charID)
			{
				Service.gI().requestItemInfo(typeUI, item.indexUI);
			}
			else
			{
				Service.gI().requestItemPlayer(currentCharViewInfo.charID, item.indexUI);
			}
		}
		if (typeUI == 5)
		{
			Char.getMyChar().updateKickOption();
		}
		if (!GameCanvas.isTouch || (GameCanvas.isTouch && GameCanvas.isTouchControlSmallScreen) || (isPaintInfoMe && indexMenu > 0 && indexMenu < 4))
		{
			center = cmdItemInfoClose;
			right = null;
			left = null;
		}
		GameCanvas.clearKeyHold();
		GameCanvas.clearKeyPressed();
	}

	public void showAlert(string title, string str, bool withMenuShow)
	{
		InfoDlg.hide();
		isPaintAlert = true;
		isLockKey = true;
		indexRow = 0;
		setPopupSize(200, (indexMenu == 4) ? 200 : 176);
		if (withMenuShow)
		{
			popupH -= 60;
		}
		right = new Command(mResources.CLOSE, 3);
		left = (center = null);
		textsTitle = title;
		texts = mFont.tahoma_7.splitFontVector(str, popupW - 30);
	}

	public void doCloseAlert()
	{
		isPaintAlert = false;
		textsTitle = null;
		texts = null;
		center = null;
		resetButton();
	}

	public void scrollDownAlert()
	{
		indexRowMax = texts.size();
		scrMain.setStyle(indexRowMax, 12, popupX, ystart + 12, popupW, popupH - 42 - ((textsTitle != null) ? 10 : 0), styleUPDOWN: true, 1);
		indexRow = texts.size() - 1;
		scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
	}

	public void paintAlert(mGraphics g)
	{
		if (texts == null || !isPaintAlert)
		{
			return;
		}
		resetTranslate(g);
		GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
		if (textsTitle != null)
		{
			paintTitle(g, textsTitle, isPaintMessage);
		}
		xstart = popupX + 15;
		ystart = popupY + 15;
		if (textsTitle != null)
		{
			ystart += 10;
		}
		indexRowMax = texts.size();
		scrMain.setStyle(indexRowMax, 12, popupX, ystart + 12, popupW, popupH - 42 - ((textsTitle != null) ? 10 : 0), styleUPDOWN: true, 1);
		scrMain.setClip(g);
		yPaint = ystart;
		mFont mFont2 = mFont.tahoma_7_white;
		for (int i = 0; i < texts.size(); i++)
		{
			string text = (string)texts.elementAt(i);
			if (text == null || texts == null || mFont2 == null)
			{
				break;
			}
			if (text.StartsWith("c"))
			{
				if (text.StartsWith("c0"))
				{
					text = text.Substring(2);
					mFont2 = mFont.tahoma_7_white;
				}
				else if (text.StartsWith("c1"))
				{
					text = text.Substring(2);
					mFont2 = mFont.tahoma_7b_yellow;
				}
				else if (text.StartsWith("c2"))
				{
					text = text.Substring(2);
					mFont2 = mFont.tahoma_7b_white;
				}
				else if (text.StartsWith("c3"))
				{
					text = text.Substring(2);
					mFont2 = mFont.tahoma_7_yellow;
				}
				else if (text.StartsWith("c4"))
				{
					text = text.Substring(2);
					mFont2 = mFont.tahoma_7b_red;
				}
				else if (text.StartsWith("c5"))
				{
					text = text.Substring(2);
					mFont2 = mFont.tahoma_7_red;
				}
				else if (text.StartsWith("c6"))
				{
					text = text.Substring(2);
					mFont2 = mFont.tahoma_7_grey;
				}
				else if (text.StartsWith("c7"))
				{
					text = text.Substring(2);
					mFont2 = mFont.tahoma_7b_blue;
				}
				else if (text.StartsWith("c8"))
				{
					text = text.Substring(2);
					mFont2 = mFont.tahoma_7_blue;
				}
				else if (text.StartsWith("c9"))
				{
					text = text.Substring(2);
					mFont2 = mFont.tahoma_7_green;
				}
			}
			mFont2.drawString(g, text, xstart + 5, yPaint += 12, 0);
		}
		if (indexRow >= 0)
		{
			SmallImage.drawSmallImage(g, 942, xstart - 5, ystart + 12 + 2 + indexRow * 12, 0, StaticObj.TOP_LEFT);
		}
	}

	public void paintFindTeam(mGraphics g)
	{
		if (!isPaintFindTeam)
		{
			return;
		}
		GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
		paintTitle(g, mResources.FINDTEAM, arrow: false);
		xstart = popupX + 5;
		ystart = popupY + 40;
		if (vPtMap.size() == 0)
		{
			mFont.tahoma_7_white.drawString(g, mResources.NOT_TEAM_MAP, popupX + popupW / 2, popupY + 40, mFont.CENTER);
		}
		else
		{
			int num = (Main.isPC ? 5 : 4);
			g.setColor(6425);
			g.fillRect(xstart - 2, ystart - 2, popupW - 6, indexSize * num + 8);
			resetTranslate(g);
			scrMain.setStyle(vPtMap.size(), indexSize, xstart, ystart, popupW - 3, indexSize * num + 4, styleUPDOWN: true, 1);
			scrMain.setClip(g, xstart, ystart, popupW - 3, indexSize * num + 6);
			indexRowMax = vPtMap.size();
			for (int i = 0; i < vPtMap.size(); i++)
			{
				Party party = (Party)vPtMap.elementAt(i);
				if (indexRow == i)
				{
					g.setColor(Paint.COLORLIGHT);
					g.fillRect(xstart + 2, ystart + indexRow * indexSize + 2, popupW - 15, indexSize - 4);
					g.setColor(16777215);
					g.drawRect(xstart + 2, ystart + indexRow * indexSize + 2, popupW - 15, indexSize - 4);
				}
				else
				{
					g.setColor(Paint.COLORBACKGROUND);
					g.fillRect(xstart + 2, ystart + i * indexSize + 2, popupW - 15, indexSize - 4);
					g.setColor(13932896);
					g.drawRect(xstart + 2, ystart + i * indexSize + 2, popupW - 15, indexSize - 4);
				}
				SmallImage.drawSmallImage(g, 647, xstart + 12, ystart + i * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				mFont.tahoma_7_white.drawString(g, party.name + " - " + mResources.level + ": " + party.level + " (" + party.size + ")", xstart + 22, ystart + i * indexSize + indexSize / 2 - 6, 0);
			}
		}
		paintNumCount(g);
	}

	public void paintTeam(mGraphics g)
	{
		if (!isPaintTeam)
		{
			return;
		}
		GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
		paintTitle(g, mResources.TEAM, arrow: false);
		xstart = popupX + 5;
		ystart = popupY + 40;
		int num = ((!Main.isPC) ? 4 : 5);
		if (vParty.size() == 0)
		{
			mFont.tahoma_7_white.drawString(g, mResources.NOT_TEAM, popupX + popupW / 2, popupY + 40, mFont.CENTER);
		}
		else
		{
			g.setColor(6425);
			g.fillRect(xstart - 2, ystart - 2, popupW - 6, indexSize * num + 8);
			resetTranslate(g);
			scrMain.setStyle(vParty.size(), indexSize, xstart, ystart, popupW - 3, indexSize * num + 4, styleUPDOWN: true, 1);
			scrMain.setClip(g, xstart, ystart, popupW - 3, indexSize * num + 6);
			indexRowMax = vParty.size();
			for (int i = 0; i < vParty.size(); i++)
			{
				Party party = (Party)vParty.elementAt(i);
				if (indexRow == i)
				{
					g.setColor(Paint.COLORLIGHT);
					g.fillRect(xstart + 2, ystart + indexRow * indexSize + 2, popupW - 15, indexSize - 4);
					g.setColor(16777215);
					g.drawRect(xstart + 2, ystart + indexRow * indexSize + 2, popupW - 15, indexSize - 4);
				}
				else
				{
					g.setColor(Paint.COLORBACKGROUND);
					g.fillRect(xstart + 2, ystart + i * indexSize + 2, popupW - 15, indexSize - 4);
					g.setColor(13932896);
					g.drawRect(xstart + 2, ystart + i * indexSize + 2, popupW - 15, indexSize - 4);
				}
				SmallImage.drawSmallImage(g, party.iconId, xstart + 12, ystart + i * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				if (party.c == null)
				{
					mFont.tahoma_7_green.drawString(g, party.name, xstart + 22, ystart + i * indexSize + indexSize / 2 - 6, 0);
				}
				else if (i == 0)
				{
					mFont.tahoma_7_yellow.drawString(g, party.name + " - " + mResources.level + ": " + party.c.clevel, xstart + 22, ystart + i * indexSize + indexSize / 2 - 6, 0);
				}
				else
				{
					mFont.tahoma_7_white.drawString(g, party.name + " - " + mResources.level + ": " + party.c.clevel, xstart + 22, ystart + i * indexSize + indexSize / 2 - 6, 0);
				}
			}
		}
		paintNumCount(g);
	}

	public void PaintAuctionBuy(mGraphics g)
	{
		if (!isPaintAuctionBuy)
		{
			return;
		}
		int num = popupW;
		if (GameCanvas.isTouchControlLargeScreen)
		{
			num = popupW / 2 + 20;
		}
		GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
		paintTitle(g, mResources.MENUSTANDS[indexMenu], GameCanvas.isTouch || indexTitle == 0);
		g.setColor(6425);
		g.fillRect(xstart - 2, ystart - 2, num - 6, indexSize * 5 + 4);
		if (arrItemStands == null)
		{
			GameCanvas.paintShukiren(popupX + 90, popupY + 75, g, noRotate: false);
			mFont.tahoma_7b_white.drawString(g, mResources.PLEASEWAIT, popupX + 90, popupY + 90, 2);
			return;
		}
		ItemStands[] array = arrItemStands;
		xstart = popupX + 5;
		ystart = popupY + 33;
		if (array.Length != 0)
		{
			indexRowMax = array.Length;
			resetTranslate(g);
			scrMain.setStyle(indexRowMax, indexSize, xstart, ystart, num - 3, indexSize * 5, styleUPDOWN: true, 1);
			scrMain.setClip(g, xstart, ystart, num - 3, indexSize * 5 + 2);
			for (int i = 0; i < array.Length; i++)
			{
				ItemStands itemStands = array[i];
				if (itemStands == null || itemStands.item == null || itemStands.item.template == null)
				{
					continue;
				}
				int num2 = (int)(mSystem.getCurrentTimeMillis() / 1000);
				if (i * indexSize >= scrMain.cmy - indexSize && i * indexSize < scrMain.cmy + (indexSize * 5 + 4))
				{
					if (indexSelect == i)
					{
						g.setColor(Paint.COLORLIGHT);
						g.fillRect(xstart + 2, ystart + indexSelect * indexSize + 2, num - 15, indexSize - 4);
						g.setColor(16777215);
						g.drawRect(xstart + 2, ystart + indexSelect * indexSize + 2, num - 15, indexSize - 4);
					}
					else
					{
						g.setColor(Paint.COLORBACKGROUND);
						g.fillRect(xstart + 2, ystart + i * indexSize + 2, num - 15, indexSize - 4);
						g.setColor(13932896);
						g.drawRect(xstart + 2, ystart + i * indexSize + 2, num - 15, indexSize - 4);
					}
					g.setColor(0);
					g.fillRect(xstart + 4, ystart + i * indexSize + 4, indexSize - 1, indexSize - 8);
					g.setColor((indexSelect != i) ? 12281361 : 16777215);
					g.drawRect(xstart + 4, ystart + i * indexSize + 4, indexSize - 1, indexSize - 8);
					SmallImage.drawSmallImage(g, itemStands.item.template.iconID, xstart + indexSize / 2, ystart + i * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
					if (itemStands.item.quantity > 1)
					{
						mFont.number_yellow.drawString(g, string.Empty + itemStands.item.quantity, xstart + indexSize, ystart + i * indexSize + indexSize / 2 + 2, 1);
					}
					int num3 = itemStands.timeEnd - (num2 - itemStands.timeStart);
					mFont.tahoma_7_white.drawString(g, mResources.SELLER + ": " + itemStands.seller, xstart + indexSize + 7, ystart + i * indexSize + indexSize / 2 - mFont.number_yellow.getHeight() - 2, 0);
					mFont.tahoma_7_white.drawString(g, mResources.PRICE + ": " + NinjaUtil.numberToString(string.Empty + itemStands.price) + " " + mResources.XU, xstart + indexSize + 7, ystart + i * indexSize + indexSize / 2 - mFont.number_yellow.getHeight() + 9, 0);
					if (num3 < 60)
					{
						mFont.tahoma_7_blue.drawString(g, mResources.NEAR, xstart + num - 30, ystart + i * indexSize + indexSize / 2 - mFont.number_yellow.getHeight() - 2, 2);
						mFont.tahoma_7_blue.drawString(g, mResources.DEADLINE, xstart + num - 30, ystart + i * indexSize + indexSize / 2 - mFont.number_yellow.getHeight() + 9, 2);
					}
					else
					{
						mFont.tahoma_7_green.drawString(g, mResources.REMAIN, xstart + num - 30, ystart + i * indexSize + indexSize / 2 - mFont.number_yellow.getHeight() - 2, 2);
						mFont.tahoma_7_green.drawString(g, NinjaUtil.getTime(num3), xstart + num - 30, ystart + i * indexSize + indexSize / 2 - mFont.number_yellow.getHeight() + 9, 2);
					}
				}
			}
		}
		else
		{
			indexRowMax = array.Length;
			mFont.tahoma_7_white.drawString(g, mResources.EMPTY_INFO, popupX + num / 2, popupY + 40, mFont.CENTER);
		}
		paintNumCount(g);
	}

	public void paintFriend(mGraphics g)
	{
		if (!isPaintFriend && !isPaintEnemies)
		{
			return;
		}
		string title = ((!isPaintFriend) ? mResources.FRIENDS[1] : mResources.FRIENDS[0]);
		MyVector myVector = ((!isPaintFriend) ? vEnemies : vFriend);
		GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
		paintTitle(g, title, arrow: false);
		if (myVector.size() > 0)
		{
			xstart = popupX + 5;
			ystart = popupY + 40;
			int num = (Main.isPC ? 5 : 4);
			g.setColor(6425);
			g.fillRect(xstart - 2, ystart - 2, popupW - 6, indexSize * num + 8);
			resetTranslate(g);
			scrMain.setStyle(myVector.size(), indexSize, xstart, ystart, popupW - 3, indexSize * num + 4, styleUPDOWN: true, 1);
			scrMain.setClip(g, xstart, ystart, popupW - 3, indexSize * num + 6);
			indexRowMax = myVector.size();
			int num2 = 0;
			for (int i = 0; i < myVector.size(); i++)
			{
				Friend friend = (Friend)myVector.elementAt(i);
				if (isViewClanMemOnline && friend.type != 3)
				{
					continue;
				}
				mFont mFont2 = mFont.tahoma_7_grey;
				if (friend.type == 1 || friend.type == 2)
				{
					mFont2 = mFont.tahoma_7_green;
				}
				else if (friend.type == 3)
				{
					mFont2 = mFont.tahoma_7_white;
				}
				else if (friend.type == 4)
				{
					mFont2 = mFont.tahoma_7_red;
				}
				if (i * indexSize >= scrMain.cmy - indexSize && i * indexSize < scrMain.cmy + (indexSize * 5 + 8))
				{
					if (indexRow == i)
					{
						g.setColor(Paint.COLORLIGHT);
						g.fillRect(xstart + 2, ystart + indexRow * indexSize + 2, popupW - 15, indexSize - 4);
						g.setColor(16777215);
						g.drawRect(xstart + 2, ystart + indexRow * indexSize + 2, popupW - 15, indexSize - 4);
					}
					else
					{
						g.setColor(Paint.COLORBACKGROUND);
						g.fillRect(xstart + 2, ystart + i * indexSize + 2, popupW - 15, indexSize - 4);
						g.setColor(13932896);
						g.drawRect(xstart + 2, ystart + i * indexSize + 2, popupW - 15, indexSize - 4);
					}
					if (friend.type == 4)
					{
						if (GameCanvas.gameTick % 10 > 7)
						{
							mFont2.drawString(g, friend.friendName, xstart + 8, ystart + i * indexSize + indexSize / 2 - 6, 0);
						}
						else
						{
							mFont.tahoma_7_yellow.drawString(g, friend.friendName, xstart + 8, ystart + i * indexSize + indexSize / 2 - 6, 0);
						}
						mFont.tahoma_7_blue.drawString(g, mResources.CONFIRM_FRIEND, xstart + popupW - 15, ystart + i * indexSize + indexSize / 2 - 6, 1);
					}
					else
					{
						mFont2.drawString(g, friend.friendName, xstart + 8, ystart + i * indexSize + indexSize / 2 - 6, 0);
					}
				}
				num2++;
			}
			indexRowMax = num2;
			scrMain.setStyle(num2, indexSize, xstart, ystart, popupW - 3, indexSize * num + 4, styleUPDOWN: true, 1);
		}
		else
		{
			mFont.tahoma_7_white.drawString(g, (!isPaintFriend) ? mResources.YOU_KILLED : mResources.NO_FRIEND, popupX + popupW / 2, popupY + 40, mFont.CENTER);
		}
		paintNumCount(g);
	}

	public void paintTask(mGraphics g)
	{
		if (!isPaintTask)
		{
			return;
		}
		indexRowMax = 0;
		resetTranslate(g);
		GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
		paintTitle(g, mResources.TASK[indexMenu], arrow: false);
		xstart = popupX + 10;
		ystart = popupY + 32;
		if (indexMenu == 0)
		{
			bool flag = false;
			scrMain.setStyle(indexRowMax, 12, popupX, popupY + 32, popupW, popupH - 40, styleUPDOWN: true, 1);
			scrMain.setClip(g);
			if (Char.getMyChar().taskMaint != null)
			{
				for (int i = 0; i < Char.getMyChar().taskMaint.names.Length; i++)
				{
					mFont.tahoma_7b_white.drawString(g, Char.getMyChar().taskMaint.names[i], xstart, yPaint = ystart, 0);
					indexRowMax++;
				}
				int num = 0;
				string empty = string.Empty;
				for (int j = 0; j < Char.getMyChar().taskMaint.subNames.Length; j++)
				{
					if (Char.getMyChar().taskMaint.subNames[j] != null)
					{
						num = j;
						empty = "- " + Char.getMyChar().taskMaint.subNames[j];
						if (Char.getMyChar().taskMaint.counts[j] != -1)
						{
							if (Char.getMyChar().taskMaint.index == j)
							{
								string text = empty;
								empty = text + " " + Char.getMyChar().taskMaint.count + "/" + Char.getMyChar().taskMaint.counts[j];
								if (Char.getMyChar().taskMaint.count == Char.getMyChar().taskMaint.counts[j])
								{
									mFont.tahoma_7_white.drawString(g, empty, xstart + 5, yPaint += 12, 0);
								}
								else
								{
									mFont mFont2 = mFont.tahoma_7_grey;
									if (!flag)
									{
										flag = true;
										mFont2 = mFont.tahoma_7_yellow;
									}
									mFont2.drawString(g, empty, xstart + 5, yPaint += 12, 0);
								}
							}
							else if (Char.getMyChar().taskMaint.index > j)
							{
								string text2 = empty;
								empty = text2 + " " + Char.getMyChar().taskMaint.counts[j] + "/" + Char.getMyChar().taskMaint.counts[j];
								mFont.tahoma_7_white.drawString(g, empty, xstart + 5, yPaint += 12, 0);
							}
							else
							{
								empty = empty + " 0/" + Char.getMyChar().taskMaint.counts[j];
								mFont mFont3 = mFont.tahoma_7_grey;
								if (!flag)
								{
									flag = true;
									mFont3 = mFont.tahoma_7_yellow;
								}
								mFont3.drawString(g, empty, xstart + 5, yPaint += 12, 0);
							}
						}
						else if (Char.getMyChar().taskMaint.index > j)
						{
							mFont.tahoma_7_white.drawString(g, empty, xstart + 5, yPaint += 12, 0);
						}
						else
						{
							mFont mFont4 = mFont.tahoma_7_grey;
							if (!flag)
							{
								flag = true;
								mFont4 = mFont.tahoma_7_yellow;
							}
							mFont4.drawString(g, empty, xstart + 5, yPaint += 12, 0);
						}
						indexRowMax++;
					}
					else if (Char.getMyChar().taskMaint.index <= j)
					{
						empty = "- " + Char.getMyChar().taskMaint.subNames[num];
						mFont mFont5 = mFont.tahoma_7_grey;
						if (!flag)
						{
							flag = true;
							mFont5 = mFont.tahoma_7_yellow;
						}
						mFont5.drawString(g, empty, xstart + 5, yPaint, 0);
					}
				}
				yPaint += 5;
				for (int k = 0; k < Char.getMyChar().taskMaint.details.Length; k++)
				{
					mFont.tahoma_7_white.drawString(g, Char.getMyChar().taskMaint.details[k], xstart, yPaint += 12, 0);
					indexRowMax++;
				}
			}
			else
			{
				sbyte taskMapId = getTaskMapId();
				sbyte taskNpcId = getTaskNpcId();
				string empty2 = string.Empty;
				if (taskMapId == -3 || taskNpcId == -3)
				{
					empty2 = mResources.DES_TASK[3];
				}
				else if (Char.getMyChar().taskMaint == null && Char.getMyChar().ctaskId == 9 && Char.getMyChar().nClass.classId == 0)
				{
					empty2 = mResources.TASK_INPUT_CLASS;
				}
				else
				{
					if (taskNpcId < 0 || taskMapId < 0)
					{
						return;
					}
					empty2 = mResources.DES_TASK[0] + Npc.arrNpcTemplate[taskNpcId].name + mResources.DES_TASK[1] + TileMap.mapNames[taskMapId] + mResources.DES_TASK[2];
				}
				string[] array = mFont.tahoma_7_white.splitFontArray(empty2, 150);
				for (int l = 0; l < array.Length; l++)
				{
					if (l == 0)
					{
						mFont.tahoma_7_white.drawString(g, array[l], xstart + 5, yPaint = ystart, 0);
					}
					else
					{
						mFont.tahoma_7_white.drawString(g, array[l], xstart + 5, yPaint += 12, 0);
					}
					indexRowMax++;
				}
			}
			if (indexTitle == 1 && indexRow >= 0 && indexRowMax > 0)
			{
				SmallImage.drawSmallImage(g, 942, xstart - 8, ystart + 2 + indexRow * 12, 0, StaticObj.TOP_LEFT);
			}
			scrMain.setStyle(indexRowMax, 12, popupX, popupY + 32, popupW, popupH - 44, styleUPDOWN: true, 1);
		}
		else
		{
			if (indexMenu != 1)
			{
				return;
			}
			yPaint = ystart - 12;
			scrMain.setStyle(Char.getMyChar().taskOrders.size(), 12, popupX, popupY + 32, popupW, popupH - 44, styleUPDOWN: true, 1);
			scrMain.setClip(g);
			indexRowMax = 0;
			for (int m = 0; m < Char.getMyChar().taskOrders.size(); m++)
			{
				TaskOrder taskOrder = (TaskOrder)Char.getMyChar().taskOrders.elementAt(m);
				mFont.tahoma_7b_white.drawString(g, taskOrder.name, xstart + 5, yPaint += 12, 0);
				string text3 = string.Empty;
				if (taskOrder.taskId == 0 || taskOrder.taskId == 3)
				{
					text3 = mResources.KILL + " " + Mob.arrMobTemplate[taskOrder.killId].name;
				}
				else if (taskOrder.taskId == 1)
				{
					text3 = mResources.KILLBOSS + " " + Mob.arrMobTemplate[taskOrder.killId].name;
				}
				else if (taskOrder.taskId == 2)
				{
					text3 = mResources.GIOITHIEU;
				}
				else if (taskOrder.taskId == 4)
				{
					text3 = mResources.KILLBOSS1 + " " + Mob.arrMobTemplate[taskOrder.killId].name;
				}
				else if (taskOrder.taskId == 5)
				{
					text3 = mResources.KILLBOSS2 + " " + Mob.arrMobTemplate[taskOrder.killId].name;
				}
				else if (taskOrder.taskId == 6)
				{
					text3 = mResources.KILLBOSS3;
				}
				if (taskOrder.taskId == 6)
				{
					if (taskOrder.count == taskOrder.maxCount)
					{
						mFont.tahoma_7_white.drawString(g, text3, xstart + 5, yPaint += 12, 0);
					}
					else
					{
						mFont.tahoma_7_yellow.drawString(g, text3, xstart + 5, yPaint += 12, 0);
					}
				}
				else if (taskOrder.count == taskOrder.maxCount)
				{
					mFont.tahoma_7_white.drawString(g, text3 + " " + taskOrder.count + "/" + taskOrder.maxCount, xstart + 5, yPaint += 12, 0);
				}
				else
				{
					mFont.tahoma_7_yellow.drawString(g, text3 + " " + taskOrder.count + "/" + taskOrder.maxCount, xstart + 5, yPaint += 12, 0);
				}
				indexRowMax += 3;
				inforW = popupW - 25;
				paintMultiLine(g, mFont.tahoma_7_white, taskOrder.description, xstart + 5, yPaint += 12, 0);
				yPaint += 12;
			}
			if (typeba > 0)
			{
				mFont.tahoma_7_white.drawString(g, mResources.noti_hiddenquest, xstart + 5, yPaint += 12, 0);
				switch (typeba)
				{
				case 1:
					mFont.tahoma_7_white.drawString(g, mResources.noti_aggressivepoint, xstart + 5, yPaint += 12, 0);
					break;
				case 2:
					mFont.tahoma_7_white.drawString(g, mResources.noti_cave, xstart + 5, yPaint += 12, 0);
					break;
				case 3:
					mFont.tahoma_7_white.drawString(g, mResources.noti_huntingwildbeast, xstart + 5, yPaint += 12, 0);
					break;
				case 4:
					mFont.tahoma_7_white.drawString(g, mResources.noti_upgrade, xstart + 5, yPaint += 12, 0);
					break;
				case 5:
					mFont.tahoma_7_white.drawString(g, mResources.noti_dailyquest, xstart + 5, yPaint += 12, 0);
					break;
				case 6:
					mFont.tahoma_7_white.drawString(g, mResources.noti_battlefield, xstart + 5, yPaint += 12, 0);
					break;
				case 7:
					mFont.tahoma_7_white.drawString(g, mResources.noti_sevenbeasts, xstart + 5, yPaint += 12, 0);
					break;
				case 8:
					mFont.tahoma_7_white.drawString(g, mResources.noti_luckycard, xstart + 5, yPaint += 12, 0);
					break;
				}
			}
			if (indexTitle == 1 && indexRow >= 0 && indexRowMax > 0)
			{
				SmallImage.drawSmallImage(g, 942, xstart - 8, ystart + 2 + indexRow * 12, 0, StaticObj.TOP_LEFT);
			}
			indexRowMax++;
			scrMain.setStyle(indexRowMax, 12, popupX, popupY + 32, popupW, popupH - 44, styleUPDOWN: true, 1);
		}
	}

	public string[] splitMultiLine(mFont f, string str)
	{
		return f.splitFontArray(str, popupW - 20);
	}

	public void paintMultiLine(mGraphics g, mFont f, string[] arr, int x, int y, int align)
	{
		int num = y;
		for (int i = 0; i < arr.Length; i++)
		{
			string text = arr[i];
			if (text.StartsWith("c"))
			{
				if (text.StartsWith("c0"))
				{
					text = text.Substring(2);
					f = mFont.tahoma_7_white;
				}
				else if (text.StartsWith("c1"))
				{
					text = text.Substring(2);
					f = mFont.tahoma_7_yellow;
				}
				else if (text.StartsWith("c2"))
				{
					text = text.Substring(2);
					f = mFont.tahoma_7_green;
				}
			}
			if (i == 0)
			{
				f.drawString(g, text, x, y, align);
				continue;
			}
			if (i * scrMain.ITEM_SIZE + num >= scrMain.cmy - 12 && i * scrMain.ITEM_SIZE < scrMain.cmy + popupH - 44)
			{
				f.drawString(g, text, x, y += 12, align);
			}
			else
			{
				y += 12;
			}
			yPaint += 12;
			indexRowMax++;
		}
	}

	public void paintMultiLine(mGraphics g, mFont f, string str, int x, int y, int align)
	{
		int num = ((!GameCanvas.isTouch || GameCanvas.w < 320) ? 10 : 20);
		int num2 = y;
		string[] array = f.splitFontArray(str, inforW - num);
		for (int i = 0; i < array.Length; i++)
		{
			if (i == 0)
			{
				f.drawString(g, array[i], x, y, align);
				continue;
			}
			if (i * scrMain.ITEM_SIZE + num2 >= scrMain.cmy - 12 && i * scrMain.ITEM_SIZE < scrMain.cmy + popupH - 44)
			{
				f.drawString(g, array[i], x, y += 12, align);
				yPaint += 12;
			}
			else
			{
				y += 12;
			}
			indexRowMax++;
		}
	}

	public void paintMultiLine(mGraphics g, mFont f, string str, int x, int y, int align, int width)
	{
		int num = y;
		string[] array = f.splitFontArray(str, width);
		for (int i = 0; i < array.Length; i++)
		{
			if (i == 0)
			{
				f.drawString(g, array[i], x, y, align);
				continue;
			}
			if (i * scrMain.ITEM_SIZE + num >= scrMain.cmy - 12 && i * scrMain.ITEM_SIZE < scrMain.cmy + popupH - 44)
			{
				f.drawString(g, array[i], x, y += 12, align);
				yPaint += 12;
			}
			else
			{
				y += 12;
			}
			indexRowMax++;
		}
	}

	public void paintItemInfo(mGraphics g)
	{
		g.setClip(0, -200, GameCanvas.w, 200 + GameCanvas.h);
		if (isPaintInfoHelpNotIphone && !Main.isPC)
		{
			return;
		}
		if (GameCanvas.isTouchControlLargeScreen && !isSmallUI() && (isOpenUI() || isPaintPopup() || isPaintUI()))
		{
			setInfoFrameForLargeScreen();
			paintInforFrame(g);
			resetTranslate(g);
			paintMultiLine(g, mFont.tahoma_7_white, mResources.CHOOSE_ITEM, inforX + inforW / 2, inforY + inforH / 2 - 20, 2);
		}
		if (!isPaintItemInfo || itemFocus == null || itemFocus.template == null)
		{
			return;
		}
		Item item = itemFocus;
		if (isViewNext && !itemFocus.isUpMax() && indexMenu == 0)
		{
			item = itemFocus.viewNext(itemFocus.upgrade + 1);
		}
		if (isPaintConvert && indexMenu == 0 && indexTitle == 1 && item.isTypeBody() && item.upgrade == 0 && arrItemConvert[0] != null && arrItemConvert[0].template.type == arrItemConvert[1].template.type && arrItemConvert[1].template.level >= arrItemConvert[0].template.level)
		{
			item = itemFocus.viewNext(arrItemConvert[0].upgrade);
		}
		resetTranslate(g);
		int num;
		if (item.expires != 0L && item.options != null && item.options.size() > 0)
		{
			for (int i = 0; i < item.options.size(); i++)
			{
				ItemOption itemOption = (ItemOption)item.options.elementAt(i);
				num = itemOption.getOptionString().Length * 5;
				if (num > inforW && !GameCanvas.isTouchControlLargeScreen)
				{
					inforW = num;
				}
			}
		}
		num = mFont.tahoma_7b_white.getWidth(item.template.name) + 10;
		if (num > inforW && !GameCanvas.isTouchControlLargeScreen)
		{
			inforW = num;
		}
		if (inforW > GameCanvas.w - 4)
		{
			inforW = GameCanvas.w - 4;
		}
		if (inforH > GameCanvas.h - 4)
		{
			inforW = GameCanvas.h - 4;
		}
		inforX = gW / 2 - inforW / 2;
		inforY = gH / 2 - inforH / 2;
		setInfoFrameForLargeScreen();
		if (inforX < 2)
		{
			inforX = 2;
		}
		if (inforY < 2)
		{
			inforY = 2;
		}
		paintInforFrame(g);
		if (isPaintClan && indexMenu == 0)
		{
			if (Char.clan != null)
			{
				yPaint = inforY - 9;
				indexRowMax = 2;
				scrInfo.setClip(g, inforX, inforY + 2, inforW, inforH - 2);
				inforW = mFont.tahoma_7_white.getWidth(mResources.CLAN_ITEM[Char.clan.itemLevel][1]) + 10;
				for (int j = 0; j < 2; j++)
				{
					mFont.tahoma_7_white.drawString(g, mResources.CLAN_ITEM[Char.clan.itemLevel][j], inforX + 8, yPaint += 12, mFont.LEFT);
				}
				if (indexRow >= 0 && (!GameCanvas.isTouch || (GameCanvas.isTouch && GameCanvas.w < 320)))
				{
					SmallImage.drawSmallImage(g, 942, inforX + 1, inforY + 5 + indexRow * 12, 0, StaticObj.TOP_LEFT);
				}
				scrInfo.setStyle(indexRowMax, 12, inforX, inforY + 2, inforW, inforH - 4, styleUPDOWN: true, 1);
			}
			return;
		}
		if (Main.isPC)
		{
			scrInfo.setClip(g, inforX, inforY + 2, inforW, inforH - 2);
		}
		else
		{
			scrInfo.setClip(g, inforX, inforY + 2, inforW, inforH - 25);
		}
		indexRowMax = 3;
		yPaint = inforY + 3;
		mFont mFont2 = mFont.tahoma_7b_white;
		if (item.isTypeMounts())
		{
			if (item.sys >= 1 && item.sys < 4)
			{
				mFont2 = mFont.tahoma_7b_blue;
			}
			else if (item.sys >= 4 && item.sys < 8)
			{
				mFont2 = mFont.tahoma_7b_green;
			}
			else if (item.sys >= 8 && item.sys < 12)
			{
				mFont2 = mFont.tahoma_7b_yellow;
			}
			else if (item.sys >= 12 && item.sys < 15)
			{
				mFont2 = mFont.tahoma_7b_purple;
			}
			else if (item.sys >= 15)
			{
				mFont2 = mFont.tahoma_7b_red;
			}
		}
		if (item.upgrade >= 1 && item.upgrade < 4)
		{
			mFont2 = mFont.tahoma_7b_blue;
		}
		else if (item.upgrade >= 4 && item.upgrade < 8)
		{
			mFont2 = mFont.tahoma_7b_green;
		}
		else if (item.upgrade >= 8 && item.upgrade < 12)
		{
			mFont2 = mFont.tahoma_7b_yellow;
		}
		else if (item.upgrade >= 12 && item.upgrade < 15)
		{
			mFont2 = mFont.tahoma_7b_purple;
		}
		else if (item.upgrade >= 15)
		{
			mFont2 = mFont.tahoma_7b_red;
		}
		if (item.img != null)
		{
			g.drawRegion(item.img, 0, 0, mGraphics.getImageWidth(item.img), mGraphics.getImageHeight(item.img), 0, inforX + inforW / 2, yPaint + inforH - 10, mGraphics.BOTTOM | mGraphics.HCENTER);
		}
		if (item.isTypeMounts())
		{
			paintMultiLine(g, mFont2, item.template.name + " + " + (item.sys + 1), inforX + 8, yPaint, mFont.LEFT);
		}
		else
		{
			paintMultiLine(g, mFont2, item.template.name + ((item.upgrade <= 0) ? string.Empty : (" +" + item.upgrade)), inforX + 8, yPaint, mFont.LEFT);
		}
		if (item.upgrade >= 15 && !isChop && !item.isTypeMounts())
		{
			string[] array = mFont2.splitFontArray(item.template.name + ((item.upgrade <= 0) ? string.Empty : (" +" + item.upgrade)), inforW - ((!GameCanvas.isTouch || GameCanvas.w < 320) ? 10 : 20));
			if (array.Length > 1)
			{
				yPaint -= 12;
			}
			paintMultiLine(g, mFont.tahoma_7b_white, item.template.name + ((item.upgrade <= 0) ? string.Empty : (" +" + item.upgrade)), inforX + 8, yPaint, mFont.LEFT);
		}
		if (item.isTypeBody())
		{
			yPaint += 12;
			indexRowMax++;
			if (isChop && GameCanvas.gameTick % 5 == 0)
			{
				isChop = !isChop;
			}
			else if (!isChop && GameCanvas.gameTick % 5 == 0)
			{
				isChop = !isChop;
			}
			int num2 = item.upgrade / 2 + 1;
			if (item.upgrade == 0)
			{
				for (int k = 0; k < num2; k++)
				{
					SmallImage.drawSmallImage(g, 633, inforX + 12 + k * 10, yPaint + 5, 0, StaticObj.VCENTER_HCENTER);
				}
			}
			else if (item.upgrade >= 1 && item.upgrade < 4)
			{
				for (int l = 0; l < num2; l++)
				{
					SmallImage.drawSmallImage(g, 625, inforX + 12 + l * 10, yPaint + 5, 0, StaticObj.VCENTER_HCENTER);
				}
				if (item.upgrade == 3)
				{
					SmallImage.drawSmallImage(g, 635, inforX + 12 + num2 * 10, yPaint + 5, 0, StaticObj.VCENTER_HCENTER);
				}
			}
			else if (item.upgrade >= 4 && item.upgrade < 8)
			{
				for (int m = 0; m < num2; m++)
				{
					SmallImage.drawSmallImage(g, 626, inforX + 12 + m * 10, yPaint + 5, 0, StaticObj.VCENTER_HCENTER);
				}
				if (item.upgrade % 2 != 0)
				{
					SmallImage.drawSmallImage(g, 636, inforX + 12 + num2 * 10, yPaint + 5, 0, StaticObj.VCENTER_HCENTER);
				}
			}
			else if (item.upgrade >= 8 && item.upgrade < 12)
			{
				for (int n = 0; n < num2; n++)
				{
					if (isChop)
					{
						SmallImage.drawSmallImage(g, 627, inforX + 12 + n * 10, yPaint + 5, 0, StaticObj.VCENTER_HCENTER);
					}
					else
					{
						SmallImage.drawSmallImage(g, 628, inforX + 12 + n * 10, yPaint + 5, 0, StaticObj.VCENTER_HCENTER);
					}
				}
				if (item.upgrade % 2 != 0)
				{
					if (isChop)
					{
						SmallImage.drawSmallImage(g, 637, inforX + 12 + num2 * 10, yPaint + 5, 0, StaticObj.VCENTER_HCENTER);
					}
					else
					{
						SmallImage.drawSmallImage(g, 638, inforX + 12 + num2 * 10, yPaint + 5, 0, StaticObj.VCENTER_HCENTER);
					}
				}
			}
			else if (item.upgrade >= 12 && item.upgrade < 15)
			{
				for (int num3 = 0; num3 < num2; num3++)
				{
					if (isChop)
					{
						SmallImage.drawSmallImage(g, 629, inforX + 12 + num3 * 10, yPaint + 5, 0, StaticObj.VCENTER_HCENTER);
					}
					else
					{
						SmallImage.drawSmallImage(g, 630, inforX + 12 + num3 * 10, yPaint + 5, 0, StaticObj.VCENTER_HCENTER);
					}
				}
				if (item.upgrade % 2 != 0)
				{
					if (isChop)
					{
						SmallImage.drawSmallImage(g, 639, inforX + 12 + num2 * 10, yPaint + 5, 0, StaticObj.VCENTER_HCENTER);
					}
					else
					{
						SmallImage.drawSmallImage(g, 640, inforX + 12 + num2 * 10, yPaint + 5, 0, StaticObj.VCENTER_HCENTER);
					}
				}
			}
			else
			{
				for (int num4 = 0; num4 < num2; num4++)
				{
					if (isChop)
					{
						SmallImage.drawSmallImage(g, 631, inforX + 12 + num4 * 10, yPaint + 5, 0, StaticObj.VCENTER_HCENTER);
					}
					else
					{
						SmallImage.drawSmallImage(g, 632, inforX + 12 + num4 * 10, yPaint + 5, 0, StaticObj.VCENTER_HCENTER);
					}
				}
				if (item.upgrade % 2 != 0)
				{
					if (isChop)
					{
						SmallImage.drawSmallImage(g, 641, inforX + 12 + num2 * 10, yPaint + 5, 0, StaticObj.VCENTER_HCENTER);
					}
					else
					{
						SmallImage.drawSmallImage(g, 642, inforX + 12 + num2 * 10, yPaint + 5, 0, StaticObj.VCENTER_HCENTER);
					}
				}
			}
		}
		else if (item.isTypeMounts())
		{
			yPaint += 12;
			int num5 = item.sys + 1;
			for (int num6 = 0; num6 < num5; num6++)
			{
				SmallImage.drawSmallImage(g, 633, inforX + 12 + num6 * 10, yPaint + 5, 0, StaticObj.VCENTER_HCENTER);
			}
		}
		mFont.tahoma_7_white.drawString(g, item.getLockString(), inforX + 8, yPaint += 12, mFont.LEFT);
		if (item.isTypeBody())
		{
			string upgradeString = item.getUpgradeString();
			if (upgradeString != null)
			{
				paintMultiLine(g, mFont.tahoma_7_white, upgradeString, inforX + 8, yPaint += 12, mFont.LEFT);
				indexRowMax++;
			}
		}
		if (item.template.gender == 0 || item.template.gender == 1)
		{
			if (item.template.gender == Char.getMyChar().cgender)
			{
				mFont.tahoma_7_white.drawString(g, mResources.GENDER[item.template.gender], inforX + 8, yPaint += 12, mFont.LEFT);
				indexRowMax++;
			}
			else
			{
				mFont.tahoma_7_red.drawString(g, mResources.GENDER[item.template.gender], inforX + 8, yPaint += 12, mFont.LEFT);
				indexRowMax++;
			}
		}
		if (Char.getMyChar().clevel != -1)
		{
			if (Char.getMyChar().clevel >= item.template.level)
			{
				paintMultiLine(g, mFont.tahoma_7_white, mResources.LEVELNEED + " " + item.template.level, inforX + 8, yPaint += 12, mFont.LEFT);
			}
			else
			{
				paintMultiLine(g, mFont.tahoma_7_red, mResources.LEVELNEED + " " + item.template.level, inforX + 8, yPaint += 12, mFont.LEFT);
			}
		}
		if ((item.template.id >= 40 && item.template.id <= 48) || item.template.id == 311 || item.template.id == 375 || item.template.id == 397 || item.template.id == 552 || item.template.id == 558)
		{
			int num7 = 1;
			if (Char.getMyChar().nClass.classId == num7)
			{
				mFont.tahoma_7_white.drawString(g, mResources.CLASSNEED + " " + nClasss[num7].name, inforX + 8, yPaint += 12, mFont.LEFT);
			}
			else
			{
				mFont.tahoma_7_red.drawString(g, mResources.CLASSNEED + " " + nClasss[num7].name, inforX + 8, yPaint += 12, mFont.LEFT);
			}
			indexRowMax++;
		}
		else if ((item.template.id >= 49 && item.template.id <= 57) || item.template.id == 312 || item.template.id == 376 || item.template.id == 398 || item.template.id == 553 || item.template.id == 559)
		{
			int num8 = 2;
			if (Char.getMyChar().nClass.classId == num8)
			{
				mFont.tahoma_7_white.drawString(g, mResources.CLASSNEED + " " + nClasss[num8].name, inforX + 8, yPaint += 12, mFont.LEFT);
			}
			else
			{
				mFont.tahoma_7_red.drawString(g, mResources.CLASSNEED + " " + nClasss[num8].name, inforX + 8, yPaint += 12, mFont.LEFT);
			}
			indexRowMax++;
		}
		else if ((item.template.id >= 58 && item.template.id <= 66) || item.template.id == 313 || item.template.id == 377 || item.template.id == 399 || item.template.id == 554 || item.template.id == 560)
		{
			int num9 = 3;
			if (Char.getMyChar().nClass.classId == num9)
			{
				mFont.tahoma_7_white.drawString(g, mResources.CLASSNEED + " " + nClasss[num9].name, inforX + 8, yPaint += 12, mFont.LEFT);
			}
			else
			{
				mFont.tahoma_7_red.drawString(g, mResources.CLASSNEED + " " + nClasss[num9].name, inforX + 8, yPaint += 12, mFont.LEFT);
			}
			indexRowMax++;
		}
		else if ((item.template.id >= 67 && item.template.id <= 75) || item.template.id == 314 || item.template.id == 378 || item.template.id == 400 || item.template.id == 555 || item.template.id == 561)
		{
			int num10 = 4;
			if (Char.getMyChar().nClass.classId == num10)
			{
				mFont.tahoma_7_white.drawString(g, mResources.CLASSNEED + " " + nClasss[num10].name, inforX + 8, yPaint += 12, mFont.LEFT);
			}
			else
			{
				mFont.tahoma_7_red.drawString(g, mResources.CLASSNEED + " " + nClasss[num10].name, inforX + 8, yPaint += 12, mFont.LEFT);
			}
			indexRowMax++;
		}
		else if ((item.template.id >= 76 && item.template.id <= 84) || item.template.id == 315 || item.template.id == 379 || item.template.id == 401 || item.template.id == 556 || item.template.id == 562)
		{
			int num11 = 5;
			if (Char.getMyChar().nClass.classId == num11)
			{
				mFont.tahoma_7_white.drawString(g, mResources.CLASSNEED + " " + nClasss[num11].name, inforX + 8, yPaint += 12, mFont.LEFT);
			}
			else
			{
				mFont.tahoma_7_red.drawString(g, mResources.CLASSNEED + " " + nClasss[num11].name, inforX + 8, yPaint += 12, mFont.LEFT);
			}
			indexRowMax++;
		}
		else if ((item.template.id >= 85 && item.template.id <= 93) || item.template.id == 316 || item.template.id == 380 || item.template.id == 402 || item.template.id == 557 || item.template.id == 563)
		{
			int num12 = 6;
			if (Char.getMyChar().nClass.classId == num12)
			{
				mFont.tahoma_7_white.drawString(g, mResources.CLASSNEED + " " + nClasss[num12].name, inforX + 8, yPaint += 12, mFont.LEFT);
			}
			else
			{
				mFont.tahoma_7_red.drawString(g, mResources.CLASSNEED + " " + nClasss[num12].name, inforX + 8, yPaint += 12, mFont.LEFT);
			}
			indexRowMax++;
		}
		if (!item.isTypeMounts())
		{
			if (item.template.id == 420)
			{
				if (Char.getMyChar().nClass.classId == 1 || Char.getMyChar().nClass.classId == 2)
				{
					mFont.tahoma_7_white.drawString(g, mResources.SYSITEM[1], inforX + 8, yPaint += 12, mFont.LEFT);
				}
				else
				{
					mFont.tahoma_7_red.drawString(g, mResources.SYSITEM[1], inforX + 8, yPaint += 12, mFont.LEFT);
				}
				indexRowMax++;
			}
			else if (item.template.id == 421)
			{
				if (Char.getMyChar().nClass.classId == 3 || Char.getMyChar().nClass.classId == 4)
				{
					mFont.tahoma_7_white.drawString(g, mResources.SYSITEM[2], inforX + 8, yPaint += 12, mFont.LEFT);
				}
				else
				{
					mFont.tahoma_7_red.drawString(g, mResources.SYSITEM[2], inforX + 8, yPaint += 12, mFont.LEFT);
				}
				indexRowMax++;
			}
			else if (item.template.id == 422)
			{
				if (Char.getMyChar().nClass.classId == 5 || Char.getMyChar().nClass.classId == 6)
				{
					mFont.tahoma_7_white.drawString(g, mResources.SYSITEM[3], inforX + 8, yPaint += 12, mFont.LEFT);
				}
				else
				{
					mFont.tahoma_7_red.drawString(g, mResources.SYSITEM[3], inforX + 8, yPaint += 12, mFont.LEFT);
				}
				indexRowMax++;
			}
		}
		if (item.expires > 0)
		{
			if (item.isTypeUIShop() || item.isTypeUIShopLock() || item.isTypeUIStore() || item.isTypeUIBook() || item.isTypeUIFashion() || item.isTypeUIClanShop() || item.isTypeUIClan())
			{
				num = mFont.tahoma_7.getWidth(mResources.EXPIRES + ": " + item.getExpiresShopString()) + 10;
				if (num > inforW && !GameCanvas.isTouchControlLargeScreen)
				{
					inforW = num;
				}
				paintMultiLine(g, mFont.tahoma_7_yellow, mResources.EXPIRES + ": " + item.getExpiresShopString(), inforX + 8, yPaint += 12, mFont.LEFT);
			}
			else
			{
				num = mFont.tahoma_7.getWidth(mResources.EXPIRES + ": " + item.getExpiresString()) + 10;
				if (num > inforW && !GameCanvas.isTouchControlLargeScreen)
				{
					inforW = num;
				}
				paintMultiLine(g, mFont.tahoma_7_yellow, mResources.EXPIRES + ": " + item.getExpiresString(), inforX + 8, yPaint += 12, mFont.LEFT);
			}
			indexRowMax++;
		}
		if (!item.template.description.Equals(string.Empty))
		{
			paintMultiLine(g, mFont.tahoma_7_white, item.template.description, inforX + 8, yPaint += 12, mFont.LEFT);
			indexRowMax++;
		}
		if (item.isTypeUIMe() || item.typeUI == 37)
		{
			mFont.tahoma_7_yellow.drawString(g, mResources.replace(mResources.COIN_LOCK_SALE, NinjaUtil.numberToString(string.Empty + item.saleCoinLock)), inforX + 8, yPaint += 12, mFont.LEFT);
			indexRowMax++;
		}
		else if (item.isTypeUIShop() || item.isTypeUIShopLock() || item.isTypeUIStore() || item.isTypeUIBook() || item.isTypeUIFashion() || item.isTypeUIClanShop())
		{
			if (item.buyCoin > 0)
			{
				if (item.isTypeUIClanShop())
				{
					num = mFont.tahoma_7.getWidth(mResources.replace(mResources.COIN_BUY_CLAN, NinjaUtil.numberToString(string.Empty + item.buyCoin))) + 10;
					if (num > inforW && !GameCanvas.isTouchControlLargeScreen)
					{
						inforW = num;
					}
					mFont.tahoma_7_yellow.drawString(g, mResources.replace(mResources.COIN_BUY_CLAN, NinjaUtil.numberToString(string.Empty + item.buyCoin)), inforX + 8, yPaint += 12, mFont.LEFT);
				}
				else
				{
					mFont.tahoma_7_yellow.drawString(g, mResources.replace(mResources.COIN_BUY, NinjaUtil.numberToString(string.Empty + item.buyCoin)), inforX + 8, yPaint += 12, mFont.LEFT);
				}
				indexRowMax++;
			}
			else if (item.buyCoinLock > 0)
			{
				mFont.tahoma_7_yellow.drawString(g, mResources.replace(mResources.COIN_LOCK_BUY, NinjaUtil.numberToString(string.Empty + item.buyCoinLock)), inforX + 8, yPaint += 12, mFont.LEFT);
				indexRowMax++;
			}
			else if (item.buyGold > 0)
			{
				mFont.tahoma_7_yellow.drawString(g, mResources.replace(mResources.GOLD_BUY, NinjaUtil.numberToString(string.Empty + item.buyGold)), inforX + 8, yPaint += 12, mFont.LEFT);
				indexRowMax++;
			}
		}
		if (item.isTypeBody() && item.sys != 0)
		{
			mFont.tahoma_7_blue1.drawString(g, mResources.SYSITEM[item.sys], inforX + 8, yPaint += 12, mFont.LEFT);
			indexRowMax++;
		}
		if (item.expires != 0L && item.options != null && item.options.size() > 0)
		{
			bool flag = false;
			bool flag2 = false;
			for (int num13 = 0; num13 < item.options.size(); num13++)
			{
				ItemOption itemOption2 = (ItemOption)item.options.elementAt(num13);
				if (!flag && itemOption2.optionTemplate.type == 2)
				{
					flag = true;
					string text = mResources.LINE[0] + ": ";
					if (item.template.type == 1)
					{
						string text2 = text;
						text = text2 + mResources.BODY[item.template.type] + "(" + mResources.KICKSYS[itemFocus.sys] + ")";
					}
					else if (item.template.type == 0)
					{
						string text3 = text;
						text = text3 + mResources.BODY[6] + "(" + mResources.KICKSYS[itemFocus.sys] + "), " + mResources.BODY[5] + "(" + mResources.KICKSYS[itemFocus.sys] + ")";
					}
					else if (item.template.type == 6)
					{
						string text4 = text;
						text = text4 + mResources.BODY[0] + "(" + mResources.KICKSYS[itemFocus.sys] + "), " + mResources.BODY[5] + "(" + mResources.KICKSYS[itemFocus.sys] + ")";
					}
					else if (item.template.type == 5)
					{
						string text5 = text;
						text = text5 + mResources.BODY[0] + "(" + mResources.KICKSYS[itemFocus.sys] + "), " + mResources.BODY[6] + "(" + mResources.KICKSYS[itemFocus.sys] + ")";
					}
					else if (item.template.type == 2)
					{
						string text6 = text;
						text = text6 + mResources.BODY[8] + "(" + mResources.KICKSYS[itemFocus.sys] + "), " + mResources.BODY[7] + "(" + mResources.KICKSYS[itemFocus.sys] + ")";
					}
					else if (item.template.type == 8)
					{
						string text7 = text;
						text = text7 + mResources.BODY[2] + "(" + mResources.KICKSYS[itemFocus.sys] + "), " + mResources.BODY[7] + "(" + mResources.KICKSYS[itemFocus.sys] + ")";
					}
					else if (item.template.type == 7)
					{
						string text8 = text;
						text = text8 + mResources.BODY[2] + "(" + mResources.KICKSYS[itemFocus.sys] + "), " + mResources.BODY[8] + "(" + mResources.KICKSYS[itemFocus.sys] + ")";
					}
					else if (item.template.type == 4)
					{
						string text9 = text;
						text = text9 + mResources.BODY[3] + "(" + mResources.KICKSYS[itemFocus.sys] + "), " + mResources.BODY[9] + "(" + mResources.KICKSYS[itemFocus.sys] + ")";
					}
					else if (item.template.type == 3)
					{
						string text10 = text;
						text = text10 + mResources.BODY[4] + "(" + mResources.KICKSYS[itemFocus.sys] + "), " + mResources.BODY[9] + "(" + mResources.KICKSYS[itemFocus.sys] + ")";
					}
					else if (item.template.type == 9)
					{
						string text11 = text;
						text = text11 + mResources.BODY[4] + "(" + mResources.KICKSYS[itemFocus.sys] + "), " + mResources.BODY[3] + "(" + mResources.KICKSYS[itemFocus.sys] + ")";
					}
					num = mFont.tahoma_7_white.getWidth(text) + 15;
					if (num > inforW && !GameCanvas.isTouchControlLargeScreen)
					{
						inforW = num;
					}
					paintMultiLine(g, mFont.tahoma_7_white, text, inforX + 8, yPaint += 12, mFont.LEFT);
					indexRowMax++;
				}
				if (!flag2 && itemOption2.optionTemplate.type > 2 && itemOption2.optionTemplate.type < 8)
				{
					flag2 = true;
					mFont.tahoma_7_white.drawString(g, mResources.LINE[1], inforX + 8, yPaint += 12, mFont.LEFT);
					indexRowMax++;
				}
				if (itemOption2.optionTemplate.id == 65)
				{
					paintMultiLine(g, mFont.tahoma_7_blue, (item.template.id != 485) ? itemOption2.getOptionString() : NinjaUtil.replace(itemOption2.getOptionString(), mResources.EXP, mResources.MACHINE), inforX + 8, yPaint += 12, mFont.LEFT);
				}
				else if (itemOption2.optionTemplate.id == 66)
				{
					paintMultiLine(g, mFont.tahoma_7_blue1, (item.template.id != 485) ? itemOption2.getOptionString() : NinjaUtil.replace(itemOption2.getOptionString(), mResources.VITALITY, mResources.POWER), inforX + 8, yPaint += 12, mFont.LEFT);
				}
				else if (itemOption2.optionTemplate.type == 0)
				{
					paintMultiLine(g, mFont.tahoma_7_blue1, (!item.isTypeUIShopView()) ? itemOption2.getOptionString() : itemOption2.getOptionShopString(), inforX + 8, yPaint += 12, mFont.LEFT);
				}
				else if (itemOption2.optionTemplate.type == 1)
				{
					paintMultiLine(g, mFont.tahoma_7_green, (!item.isTypeUIShopView()) ? itemOption2.getOptionString() : itemOption2.getOptionShopString(), inforX + 8, yPaint += 12, mFont.LEFT);
				}
				else if (itemOption2.optionTemplate.type == 8)
				{
					if (itemOption2.optionTemplate.id == 85)
					{
						paintMultiLine(g, mFont.tahoma_7_yellow, (!item.isTypeUIShopView()) ? itemOption2.getOptionShopString1() : itemOption2.getOptionShopString(), inforX + 8, yPaint += 12, mFont.LEFT);
					}
					else
					{
						paintMultiLine(g, mFont.tahoma_7b_blue, (!item.isTypeUIShopView()) ? itemOption2.getOptionShopString() : itemOption2.getOptionShopString(), inforX + 8, yPaint += 12, mFont.LEFT);
					}
				}
				else if ((itemOption2.optionTemplate.type == 2 && item.typeUI == 5 && itemOption2.active == 1) || (itemOption2.optionTemplate.type == 3 && item.upgrade >= 4) || (itemOption2.optionTemplate.type == 4 && item.upgrade >= 8) || (itemOption2.optionTemplate.type == 5 && item.upgrade >= 12) || (itemOption2.optionTemplate.type == 6 && item.upgrade >= 14) || (itemOption2.optionTemplate.type == 7 && item.upgrade >= 16))
				{
					paintMultiLine(g, mFont.tahoma_7_green, (!item.isTypeUIShopView()) ? itemOption2.getOptionString() : itemOption2.getOptionShopString(), inforX + 8, yPaint += 12, mFont.LEFT);
				}
				else
				{
					paintMultiLine(g, mFont.tahoma_7_grey, (!item.isTypeUIShopView()) ? itemOption2.getOptionString() : itemOption2.getOptionShopString(), inforX + 8, yPaint += 12, mFont.LEFT);
				}
				indexRowMax++;
			}
		}
		if (isPaintLuckySpin)
		{
			if (item.template.id == 12)
			{
				mFont.tahoma_7_red.drawString(g, NinjaUtil.numberToString(yenValue[indexSelect]) + " " + mResources.YEN, inforX + 8, yPaint += 12, mFont.LEFT);
			}
			if (item.template.type >= 0 && item.template.type <= 9)
			{
				mFont.tahoma_7_yellow.drawString(g, mResources.MAX_OPTIONS, inforX + 8, yPaint += 12, mFont.LEFT);
			}
			indexRowMax++;
		}
		if (indexRow >= 0 && (!GameCanvas.isTouch || (GameCanvas.isTouch && GameCanvas.w < 320)))
		{
			SmallImage.drawSmallImage(g, 942, inforX + 1, inforY + 5 + indexRow * 12, 0, StaticObj.TOP_LEFT);
		}
		scrInfo.setStyle(indexRowMax, 12, inforX, inforY + 2, inforW, inforH - 4, styleUPDOWN: true, 1);
	}

	private void paintInforFrame(mGraphics g)
	{
		int num = ((!Main.isPC) ? indexSize : 0);
		if (indexMenu == 4 && !isPaintAuctionBuy)
		{
			num = 0;
		}
		if (isPaintSplit && indexMenu == 0)
		{
			num = -2;
		}
		resetTranslate(g);
		g.setColor(0);
		g.fillRect(inforX - 2, inforY - 2, inforW + 5, inforH + 5 - num);
		g.setColor(13606712);
		g.drawRect(inforX - 1, inforY - 1, inforW + 2, inforH + 2 - num);
		g.setColor(Paint.COLORBACKGROUND);
		g.fillRect(inforX, inforY, inforW, inforH - num);
	}

	private void setInfoFrameForLargeScreen()
	{
		if (!GameCanvas.isTouchControlLargeScreen || (isPaintClan && indexMenu == 0))
		{
			return;
		}
		inforX = popupX + 175;
		inforW = popupW - 179;
		inforY = popupY + 33;
		inforH = 138;
		if (isPaintTrade && indexMenu == 0)
		{
			inforX = popupX + 6 + 3 * indexSize;
			inforW = popupW - (11 + 6 * indexSize);
		}
		if (isPaintInfoMe)
		{
			if (indexMenu == 4)
			{
				inforX = popupX + 33;
				inforY = popupY + 87;
				inforW = popupW - 67;
				inforH = 75;
			}
			else if (indexMenu == 5)
			{
				inforH = 161;
			}
		}
	}

	public void setLCR()
	{
		center = null;
		if (indexTitle == 0 && (indexMenu == 1 || indexMenu == 3 || indexMenu == 4))
		{
			left = null;
			return;
		}
		switch (indexMenu)
		{
		case 0:
		{
			if (indexTitle != 1)
			{
				break;
			}
			Item item = getItemFocus(3);
			if (item != null)
			{
				left = cmdBagSelectItem;
				if ((GameCanvas.isTouch && GameCanvas.w < 320) || !GameCanvas.isTouch)
				{
					center = cmdBagViewItemInfo;
				}
			}
			else
			{
				isPaintItemInfo = false;
				left = cmdBagSortItem;
			}
			break;
		}
		case 1:
		{
			if (indexTitle != 1)
			{
				break;
			}
			left = null;
			if (indexSelect < 0)
			{
				break;
			}
			SkillTemplate skillTemplate3 = Char.getMyChar().nClass.skillTemplates[indexSelect];
			Skill skill3 = Char.getMyChar().getSkill(skillTemplate3);
			if (skill3 != null)
			{
				if (skill3.point < skillTemplate3.maxPoint)
				{
					left = new Command(mResources.UPPOINT, 14001);
				}
				if (skill3.template.type == 1 || skill3.template.type == 4 || skill3.template.type == 2 || skill3.template.type == 3)
				{
					center = new Command(mResources.SHORCUT, 11081);
				}
				else
				{
					center = null;
				}
			}
			break;
		}
		case 2:
			if (indexTitle >= 1)
			{
				left = new Command(mResources.UPPOINT, 11084);
				center = new Command(string.Empty, 11084);
			}
			break;
		case 3:
			left = null;
			center = new Command(mResources.CHANGE, 110854);
			break;
		case 4:
		{
			if (indexTitle != 1)
			{
				break;
			}
			left = null;
			Item item2 = getItemFocus(5);
			if (item2 != null)
			{
				if (currentCharViewInfo.charID == Char.getMyChar().charID)
				{
					left = new Command(mResources.SELECT, 11082);
					if (GameCanvas.isTouchControlLargeScreen)
					{
						updateItemInfo(5, item2);
					}
					else
					{
						center = new Command(mResources.VIEW, 11083);
					}
				}
				else if (GameCanvas.isTouchControlLargeScreen)
				{
					updateItemInfo(5, item2);
				}
				else
				{
					center = new Command(mResources.VIEW, 11083);
				}
			}
			else
			{
				isPaintItemInfo = false;
				if (!GameCanvas.isTouch && indextabTrangbi > 0)
				{
					left = new Command(mResources.tbi1, 2003);
				}
			}
			break;
		}
		case 5:
			left = null;
			if (indexTitle == 1 && indexSelect >= 0 && currentCharViewInfo.arrItemMounts[indexSelect] != null)
			{
				if (Char.getMyChar().charID == currentCharViewInfo.charID)
				{
					left = new Command(mResources.MOVEOUT, 1516);
				}
				center = new Command((!GameCanvas.isTouchControlLargeScreen) ? mResources.VIEW : string.Empty, 1515);
			}
			break;
		case 6:
		{
			if (indexBijuuMenu == 0)
			{
				left = null;
				if (indexTitle == 1 && indexSelect >= 0 && currentCharViewInfo.arrItemMounts[indexSelect] != null)
				{
					if (Char.getMyChar().charID == currentCharViewInfo.charID)
					{
						left = new Command(mResources.MOVEOUT, 501);
					}
					center = new Command((!GameCanvas.isTouchControlLargeScreen) ? mResources.VIEW : string.Empty, 503);
				}
				break;
			}
			if (indexBijuuMenu == 1)
			{
				if (indexTitle >= 1)
				{
					left = new Command(mResources.UPPOINT, 504);
				}
				break;
			}
			if (indexTitle == 1)
			{
				left = null;
				if (indexSelect >= 0)
				{
					SkillTemplate skillTemplate = Char.getMyChar().nClass.skillTemplates[indexSelect];
					Skill skill = Char.getMyChar().getSkill(skillTemplate);
					if (skill != null)
					{
						if (skill.point < skillTemplate.maxPoint)
						{
							left = new Command(mResources.UPPOINT, 14001);
						}
						if (skill.template.type == 1 || skill.template.type == 4 || skill.template.type == 2 || skill.template.type == 3)
						{
							center = new Command(mResources.SHORCUT, 11081);
						}
						else
						{
							center = null;
						}
					}
				}
			}
			if (indexTitle != 1)
			{
				break;
			}
			left = null;
			if (indexSelect < 0)
			{
				break;
			}
			SkillTemplate skillTemplate2 = Char.getMyChar().nClass.skillTemplates[indexSelect];
			Skill skill2 = Char.getMyChar().getSkill(skillTemplate2);
			if (skill2 != null)
			{
				if (skill2.point < skillTemplate2.maxPoint)
				{
					left = new Command(mResources.UPPOINT, 505);
				}
				center = null;
			}
			break;
		}
		}
		if (indexMenu == 6)
		{
			right = new Command(mResources.SELECT, 500);
		}
		else if (currentCharViewInfo.charID == Char.getMyChar().charID)
		{
			right = new Command(mResources.BACK, 11086);
		}
		else
		{
			right = cmdCloseAll;
		}
	}

	public void doOpenUI(int typeUI)
	{
		int num = ((!Main.isPC) ? indexSize : 0);
		indexTitle = 0;
		right = cmdCloseAll;
		switch (typeUI)
		{
		case 51:
			isPaintStore = true;
			indexMenu = 51;
			if (arrItemFashion == null)
			{
				Service.gI().requestItem(32);
			}
			break;
		case 40:
			isPaintAuto = true;
			indexTitle = 1;
			indexRow = 0;
			updateCommandForUI();
			break;
		case 38:
			arrItemSprin = null;
			isPaintLuckySpin = true;
			indexTitle = 1;
			updateCommandForUI();
			break;
		case 14:
			isPaintStore = true;
			indexMenu = 0;
			if (arrItemStore == null)
			{
				Service.gI().requestItem(14);
			}
			break;
		case 35:
			isPaintEliteShop = true;
			indexMenu = 0;
			if (arrItemElites == null)
			{
				Service.gI().requestItem(35);
			}
			break;
		case 15:
			isPaintStore = true;
			indexMenu = 1;
			if (arrItemBook == null)
			{
				Service.gI().requestItem(15);
			}
			break;
		case 32:
			isPaintStore = true;
			indexMenu = 2;
			if (arrItemFashion == null)
			{
				Service.gI().requestItem(32);
			}
			break;
		case 34:
			isPaintStore = true;
			indexMenu = 3;
			if (arrItemClanShop == null)
			{
				Service.gI().requestItem(34);
			}
			break;
		case 2:
			indexMenu = 0;
			isPaintWeapon = true;
			if (arrItemWeapon == null)
			{
				Service.gI().requestItem(2);
			}
			break;
		case 20:
			indexMenu = 0;
			isPaintNonNam = true;
			if (arrItemNonNam == null)
			{
				Service.gI().requestItem(20);
			}
			break;
		case 21:
			indexMenu = 0;
			isPaintNonNu = true;
			if (arrItemNonNu == null)
			{
				Service.gI().requestItem(21);
			}
			break;
		case 22:
			indexMenu = 0;
			isPaintAoNam = true;
			if (arrItemAoNam == null)
			{
				Service.gI().requestItem(22);
			}
			break;
		case 23:
			indexMenu = 0;
			isPaintAoNu = true;
			if (arrItemAoNu == null)
			{
				Service.gI().requestItem(23);
			}
			break;
		case 24:
			indexMenu = 0;
			isPaintGangTayNam = true;
			if (arrItemGangTayNam == null)
			{
				Service.gI().requestItem(24);
			}
			break;
		case 25:
			indexMenu = 0;
			isPaintGangTayNu = true;
			if (arrItemGangTayNu == null)
			{
				Service.gI().requestItem(25);
			}
			break;
		case 26:
			indexMenu = 0;
			isPaintQuanNam = true;
			if (arrItemQuanNam == null)
			{
				Service.gI().requestItem(26);
			}
			break;
		case 27:
			indexMenu = 0;
			isPaintQuanNu = true;
			if (arrItemQuanNu == null)
			{
				Service.gI().requestItem(27);
			}
			break;
		case 28:
			indexMenu = 0;
			isPaintGiayNam = true;
			if (arrItemGiayNam == null)
			{
				Service.gI().requestItem(28);
			}
			break;
		case 29:
			indexMenu = 0;
			isPaintGiayNu = true;
			if (arrItemGiayNu == null)
			{
				Service.gI().requestItem(29);
			}
			break;
		case 16:
			indexMenu = 0;
			isPaintLien = true;
			if (arrItemLien == null)
			{
				Service.gI().requestItem(16);
			}
			break;
		case 17:
			indexMenu = 0;
			isPaintNhan = true;
			if (arrItemNhan == null)
			{
				Service.gI().requestItem(17);
			}
			break;
		case 18:
			indexMenu = 0;
			isPaintNgocBoi = true;
			if (arrItemNgocBoi == null)
			{
				Service.gI().requestItem(18);
			}
			break;
		case 19:
			indexMenu = 0;
			isPaintPhu = true;
			if (arrItemPhu == null)
			{
				Service.gI().requestItem(19);
			}
			break;
		case 6:
			indexMenu = 0;
			isPaintStack = true;
			if (arrItemStack == null)
			{
				Service.gI().requestItem(6);
			}
			break;
		case 7:
			indexMenu = 0;
			isPaintStackLock = true;
			if (arrItemStackLock == null)
			{
				Service.gI().requestItem(7);
			}
			break;
		case 8:
			indexMenu = 0;
			isPaintGrocery = true;
			if (arrItemGrocery == null)
			{
				Service.gI().requestItem(8);
			}
			break;
		case 9:
			indexMenu = 0;
			isPaintGroceryLock = true;
			if (arrItemGroceryLock == null)
			{
				Service.gI().requestItem(9);
			}
			break;
		case 4:
			indexMenu = 0;
			isPaintBox = true;
			if (Char.getMyChar().arrItemBox == null)
			{
				Service.gI().requestItem(4);
			}
			break;
		case 10:
			indexMenu = 0;
			isPaintUpGrade = true;
			arrItemUpGrade = new Item[18];
			break;
		case 36:
			indexMenu = 0;
			openItemSaleUI();
			break;
		case 37:
			isPaintAuctionBuy = true;
			updateCommandForUI();
			break;
		case 33:
			indexMenu = 0;
			isPaintConvert = true;
			arrItemConvert = new Item[3];
			break;
		case 31:
			indexMenu = 0;
			isPaintUpGrade = true;
			isPaintUpGradeGold = true;
			arrItemUpGrade = new Item[18];
			break;
		case 11:
			indexMenu = 0;
			isPaintUpPearl = true;
			isTypeXu = true;
			arrItemUpPeal = new Item[24];
			break;
		case 12:
			indexMenu = 0;
			isPaintUpPearl = true;
			isTypeXu = false;
			arrItemUpPeal = new Item[24];
			break;
		case 13:
			indexMenu = 0;
			setPopupSize(175, 180);
			isPaintSplit = true;
			arrItemSplit = new Item[24];
			break;
		case 43:
			indexMenu = 0;
			isPaintLuyenThach = true;
			arrItemUpPeal = new Item[24];
			break;
		case 44:
			indexMenu = 0;
			isPaintTinhluyen = true;
			arrItemSplit = new Item[24];
			break;
		case 45:
			indexMenu = 0;
			isPaintDichChuyen = true;
			arrItemSplit = new Item[24];
			break;
		case 46:
			indexMenu = 0;
			isPaintLuyenNgoc = true;
			arrItemSplit = new Item[24];
			break;
		case 47:
			indexMenu = 0;
			isPaintKhamNgoc = true;
			arrItemUpGrade = new Item[18];
			break;
		case 48:
			indexMenu = 0;
			isPaintGiaoDo = true;
			arrItemSplit = new Item[18];
			break;
		case 49:
			indexMenu = 0;
			openGotNgocUI();
			break;
		case 50:
			indexMenu = 0;
			openThaoNgocUI();
			break;
		}
		setPopupSize(175, 200);
	}

	private void openItemSaleUI()
	{
		isPaintAuctionSale = true;
		itemSell = null;
		tfText = new TField();
		tfText.setMaxTextLenght(9);
		tfText.setIputType(TField.INPUT_TYPE_NUMERIC);
		tfText.width = 100;
		int num = ((!Main.isPC) ? (130 - indexSize) : 130);
		tfText.height = mScreen.ITEM_HEIGHT + 2;
	}

	public static Char findCharInMap(int charId)
	{
		for (int i = 0; i < vCharInMap.size(); i++)
		{
			Char @char = (Char)vCharInMap.elementAt(i);
			if (@char.charID == charId)
			{
				return @char;
			}
		}
		return null;
	}

	public static BuNhin findBuNhinInMap(int index)
	{
		if (vBuNhin.size() > 0)
		{
			return (BuNhin)vBuNhin.elementAt(index);
		}
		return null;
	}

	public void onChatFromMe(string text, string to)
	{
		if (text.Equals("angiaodien"))
		{
			hideInterface = !hideInterface;
		}
		if ((!isPaintMessage || GameCanvas.isTouch) && !Main.isPC)
		{
			ChatTextField.gI().isShow = false;
		}
		if (text.Equals(string.Empty))
		{
			return;
		}
		if (to.Equals(mResources.PUBLICCHAT[0]))
		{
			Service.gI().chat(text);
		}
		else if (to.Equals(mResources.PARTYCHAT[0]))
		{
			if (vParty.size() == 0)
			{
				ChatManager.gI().getCurrentChatTab().addInfo(mResources.NOT_IN_PARTY);
			}
			else
			{
				Service.gI().chatParty(text);
			}
		}
		else if (to.Equals(mResources.GLOBALCHAT[0]))
		{
			Service.gI().chatGlobal(text);
		}
		else if (to.Equals(mResources.CLANCHAT[0]))
		{
			if (Char.getMyChar().cClanName.Equals(string.Empty))
			{
				ChatManager.gI().getCurrentChatTab().addInfo(mResources.NOT_IN_CLAN);
			}
			else
			{
				Service.gI().chatClan(text);
			}
		}
		else
		{
			ChatManager.gI().addChat(to, Char.getMyChar().cName, text);
			Service.gI().chatPrivate(to, text);
		}
	}

	public void onCancelChat()
	{
		if (!Main.isPC)
		{
			if (isPaintMessage)
			{
				doCloseAlert();
				isPaintMessage = false;
				ChatTextField.gI().center = null;
			}
		}
		else if (isPaintMessage)
		{
			ChatTextField.gI().center = null;
		}
	}

	public void openWeb(string strLeft, string strRight, string url, string title, string str)
	{
		isPaintAlert = true;
		isLockKey = true;
		indexRow = 0;
		int num = ((!Main.isPC) ? indexSize : 0);
		setPopupSize(175, 200 - num);
		textsTitle = title;
		texts = mFont.tahoma_7.splitFontVector(str, popupW - 30);
		center = null;
		left = new Command(strLeft, 11068, url);
		right = new Command(strRight, 11069);
	}

	public void sendSms(string strLeft, string strRight, short port, string syntax, string title, string str)
	{
		isPaintAlert = true;
		isLockKey = true;
		indexRow = 0;
		int num = ((!Main.isPC) ? indexSize : 0);
		setPopupSize(175, 200 - num);
		textsTitle = title;
		texts = mFont.tahoma_7.splitFontVector(str, popupW - 30);
		center = null;
		MyVector myVector = new MyVector();
		myVector.addElement(port + string.Empty);
		myVector.addElement(syntax);
		left = new Command(strLeft, 11074);
		right = new Command(strRight, 11075);
	}

	public void indexPointer(int x, int y, int numCols, int numRows, int title)
	{
		if (!isPaintUpPearl && !isPaintLuyenThach && !isPaintTinhluyen && !isPaintDichChuyen && !isPaintSplit && !isPaintTrade && !isPaintUpGrade && !isPaintConvert && !isPaintAuctionSale && !isPaintLuyenNgoc && !isPaintKhamNgoc && !isPaintGotNgoc && !isPaintThaoNgoc)
		{
			return;
		}
		int w = numCols * indexSize;
		int h = numRows * indexSize;
		scrMain.clear();
		if (!GameCanvas.isPointerHoldIn(x, y, w, h))
		{
			return;
		}
		indexTitle = title;
		if (!GameCanvas.isPointerClick)
		{
			return;
		}
		trans = false;
		int num = (GameCanvas.pxLast - x) / indexSize + (GameCanvas.pyLast - y) / indexSize * numCols;
		if (num / columns < rows)
		{
			indexSelect = num;
		}
		left = (center = null);
		if (isPaintTrade)
		{
			if (indexSelect < 0)
			{
				indexSelect = 11;
			}
			if (indexSelect > 11)
			{
				indexSelect = 11;
			}
		}
		if (GameCanvas.isPointerJustRelease)
		{
			Sound.play(Sound.MBClick, 0.5f);
		}
		updateCommandForUI();
	}

	private void domenuClan()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.CLAN[0], 11000661));
		myVector.addElement(new Command(mResources.CLAN[1], 11000662));
		myVector.addElement(new Command(mResources.CLAN[2], 11000663));
		myVector.addElement(new Command(mResources.CLAN[3], 11000664));
		myVector.addElement(new Command(mResources.CLAN[4], 11000666));
		GameCanvas.menu.startAt(myVector, 3);
	}

	private void changeTaskInfo()
	{
		if (indexMenu == 0)
		{
			indexMenu = 1;
		}
		else
		{
			indexMenu = 0;
		}
		indexRow = 0;
		idTypeTask = indexMenu;
	}

	private void viewMemberInfo()
	{
		Party party = (Party)vParty.elementAt(indexRow);
		if (party.c != null && party.c != Char.getMyChar())
		{
			Service.gI().viewInfo(party.c.cName);
			isPaintTeam = false;
			gI().resetButton();
		}
	}

	private void doShowClan()
	{
		arrClanInfo = (arrClanDongGop = null);
		isPaintClan = true;
		Out.println("xem clan");
		isRequestMember = true;
		isSortClanByPointWeek = false;
		arrClanInfo = (arrClanDongGop = null);
		int num = ((!Main.isPC) ? indexSize : 0);
		setPopupSize(175, 200 - num);
		updateCommandForUI();
		right = cmdCloseAll;
		Service.gI().requestClanInfo();
	}

	private void doUnfocusChar()
	{
		Char.getMyChar().charFocus = null;
		Char.isManualFocus = false;
		cLastFocusID = -1;
		isPaintCharInMap = false;
		resetButton();
	}

	private void actTrangBiCenter()
	{
		indexRow = 0;
		scrMain.clear();
		if (typeViewInfo == 0)
		{
			typeViewInfo = 1;
		}
		else
		{
			typeViewInfo = 0;
		}
	}

	public void actionPerform(int idAction, object p)
	{
		Item item = null;
		string empty = string.Empty;
		MyVector myVector = null;
		switch (idAction)
		{
		case 2003:
			if (indextabTrangbi == 0)
			{
				indextabTrangbi = 16;
				cmdTrangbi2.caption = mResources.tbi1;
				break;
			}
			indextabTrangbi = 0;
			cmdTrangbi2.caption = mResources.tbi2;
			if (!GameCanvas.isTouch)
			{
				left = new Command(mResources.SELECT, 11082);
			}
			break;
		case 2002:
			GameCanvas.endDlg();
			break;
		case 2001:
			Service.gI().throwItem(indexSelect);
			break;
		case 1100181:
			GameCanvas.startYesNoDlg(mResources.noti_reg, new Command(mResources.COUNTINUE, 1100182), new Command(mResources.NO, GameCanvas.instance, 8882, null));
			break;
		case 1100182:
			GameCanvas.currentDialog = null;
			GameCanvas.loginScr.switchToMe(isRes: true);
			break;
		case 909090:
			doOpenUI(38);
			break;
		case 1:
			GameCanvas.endDlg();
			break;
		case 2:
			GameCanvas.endDlg();
			left = (center = null);
			updateCommandForUI();
			break;
		case 3:
			doCloseAlert();
			break;
		case 1000:
			Service.gI().rewardPB();
			resetButton();
			break;
		case 2000:
			Service.gI().rewardCT();
			resetButton();
			break;
		case 11000:
			actMenu();
			break;
		case 110001:
			doMenuInforMe();
			break;
		case 1100011:
			doBag();
			break;
		case 1100012:
			doskill();
			break;
		case 1100013:
			doTiemnangMe();
			break;
		case 1100014:
			doInfo();
			break;
		case 1100015:
			doTrangbi();
			break;
		case 1100016:
			doThucuoi();
			break;
		case 1100017:
			doBiJuu();
			break;
		case 110002:
			doShowMap();
			break;
		case 110003:
			doMenusynthesis();
			break;
		case 1100032:
			doShowTaskUI();
			break;
		case 1100033:
			domenuClan();
			break;
		case 1100034:
			domenuLucky_Draw();
			break;
		case 110004:
			actMenu4();
			break;
		case 1100041:
			actMenu41();
			break;
		case 110005:
			doOpenUI(14);
			break;
		case 110006:
			actOrder();
			break;
		case 1100061:
			doShowFindTeamUI();
			break;
		case 1100062:
			doShowTeamUI();
			break;
		case 1100063:
			doShowFriendUI();
			break;
		case 1100064:
			doShowEnemiesUI();
			break;
		case 1100065:
			actsubMenuOrder();
			break;
		case 11000651:
			actsubMenuOrder_PK(1);
			break;
		case 11000652:
			actsubMenuOrder_PK(2);
			break;
		case 11000653:
			actsubMenuOrder_PK(3);
			break;
		case 1100067:
			domenuPrivateLock();
			break;
		case 11000671:
			GameCanvas.startYesNoDlg(mResources.ACTIVE_PROTECT_ACC, 88836, null, 8882, null);
			break;
		case 11000672:
			GameCanvas.inputDlg.tfInput.setMaxTextLenght(6);
			GameCanvas.inputDlg.show(mResources.INPUT_PRIVATE_PASS, new Command(mResources.ACCEPT, GameCanvas.instance, 88837, null), TField.INPUT_TYPE_NUMERIC);
			break;
		case 11000673:
			GameCanvas.input2Dlg.setTitle(mResources.OLD_PASS, mResources.NEW_PASS);
			GameCanvas.input2Dlg.tfInput.setMaxTextLenght(6);
			GameCanvas.input2Dlg.tfInput2.setMaxTextLenght(6);
			GameCanvas.input2Dlg.show(mResources.INPUT_PRIVATE_PASS, new Command(mResources.CLOSE, GameCanvas.instance, 8882, null), new Command(mResources.ACCEPT, GameCanvas.instance, 88838, null), TField.INPUT_TYPE_NUMERIC, TField.INPUT_TYPE_NUMERIC);
			break;
		case 11000674:
			GameCanvas.inputDlg.tfInput.setMaxTextLenght(6);
			GameCanvas.inputDlg.show(mResources.INPUT_PRIVATE_PASS, new Command(mResources.ACCEPT, GameCanvas.instance, 88839, null), TField.INPUT_TYPE_NUMERIC);
			break;
		case 1100068:
			doOpenUI(40);
			break;
		case 11000661:
			indexMenu = 0;
			doShowClan();
			break;
		case 11000662:
			indexMenu = 1;
			doShowClan();
			Service.gI().requestClanMember();
			break;
		case 11000663:
			indexMenu = 2;
			doShowClan();
			Service.gI().requestClanItem();
			break;
		case 11000664:
			indexMenu = 3;
			doShowClan();
			Service.gI().requestClanLog();
			break;
		case 11000665:
			isViewClanInvite = !isViewClanInvite;
			if (isViewClanInvite)
			{
				RMS.saveRMSInt(Char.getMyChar().cName + "vci", 1);
			}
			else
			{
				RMS.saveRMSInt(Char.getMyChar().cName + "vci", 0);
			}
			break;
		case 11000666:
			indexMenu = 4;
			doShowClan();
			Service.gI().requestClanItem();
			break;
		case 110007:
			doOpenUI(7);
			break;
		case 110008:
			doOpenUI(6);
			break;
		case 110009:
			doOpenUI(9);
			break;
		case 110010:
			doOpenUI(8);
			break;
		case 110011:
			doOpenUI(10);
			break;
		case 110012:
			doOpenUI(11);
			break;
		case 110013:
			doOpenUI(12);
			break;
		case 110014:
			doOpenUI(4);
			break;
		case 110015:
			doOpenUI(13);
			break;
		case 110016:
			Service.gI().openUIZone();
			break;
		case 110017:
			openUITrade();
			break;
		case 110018:
			doShowListChatTab();
			break;
		case 110019:
			changeTaskInfo();
			break;
		case 11001:
			Char.getMyChar().findNextFocusByKey();
			break;
		case 11002:
			actAddFriendAccept();
			break;
		case 11003:
			actSkillUpPoint();
			break;
		case 11004:
			actView(25);
			break;
		case 11005:
			actGangTayNuBuy();
			break;
		case 110051:
			actBuy(25);
			break;
		case 110052:
			actBuys(25);
			break;
		case 11006:
			actAddPotential();
			break;
		case 11007:
			actView(24);
			break;
		case 11008:
			actGangTayNamBuy();
			break;
		case 110081:
			actBuy(24);
			break;
		case 110082:
			actBuys(24);
			break;
		case 11009:
			actView(23);
			break;
		case 11010:
			actAoNuBuy();
			break;
		case 110101:
			actBuy(23);
			break;
		case 110102:
			actBuys(23);
			break;
		case 11011:
			actView(22);
			break;
		case 11012:
			actAoNamBuy();
			break;
		case 110121:
			actBuy(22);
			break;
		case 110122:
			actBuys(22);
			break;
		case 11013:
			actView(21);
			break;
		case 11014:
			actNonNuBuy();
			break;
		case 110141:
			actBuy(21);
			break;
		case 110142:
			actBuys(21);
			break;
		case 11015:
			actView(20);
			break;
		case 11016:
			actNonNamBuy();
			break;
		case 110161:
			actBuy(20);
			break;
		case 110162:
			actBuys(20);
			break;
		case 11017:
			actView(15);
			break;
		case 11018:
			actStoreLockBuy();
			break;
		case 110181:
			actBuy(15);
			break;
		case 110182:
			actBuys(15);
			break;
		case 11019:
			actView(14);
			break;
		case 11020:
			actStoreBuy();
			break;
		case 110201:
			actBuy(14);
			break;
		case 110202:
			actBuys(14);
			break;
		case 11021:
			svTitle = string.Empty;
			svAction = string.Empty;
			resetButton();
			break;
		case 11022:
			actBagSelectItem();
			break;
		case 110221:
			actBagSortItem();
			break;
		case 11023:
			actBagViewItemInfo();
			break;
		case 11024:
			actBagThrowItem();
			break;
		case 110244:
			actBagSplitItem();
			break;
		case 11025:
			doCloseItemInfo();
			break;
		case 11026:
			actBagUseItem();
			break;
		case 11027:
			actTradeSelectInList();
			break;
		case 11028:
			actTradeSelectInBag();
			break;
		case 11029:
			actTradeSelectItem();
			break;
		case 11030:
			actTradeViewItemInfo();
			break;
		case 11032:
			actTradeLock();
			break;
		case 11033:
			actTradeAccept();
			break;
		case 11034:
			actUpgradeMoveOut();
			break;
		case 11035:
			actSplitMoveOut();
			break;
		case 11036:
			actionCoinTrade();
			break;
		case 110361:
			actionCoinTradeAccept();
			break;
		case 11037:
			actTradeMoveOut();
			break;
		case 11038:
			actDead();
			GameCanvas.isPointerJustRelease = false;
			break;
		case 110382:
			Service.gI().returnTownFromDead();
			break;
		case 110383:
			Service.gI().wakeUpFromDead();
			break;
		case 110391:
			actmenuAttack(1);
			break;
		case 110392:
			actmenuAttack(2);
			break;
		case 110393:
			actmenuAttack(3);
			break;
		case 110394:
			actmenuAttack(4);
			break;
		case 110395:
			actmenuAttack(5);
			break;
		case 110396:
			actmenuAttack(6);
			break;
		case 110397:
			actmenuAttack(7);
			break;
		case 110398:
			actmenuAttack(8);
			break;
		case 110399:
			actmenuAttack(9);
			break;
		case 1103991:
			actmenuAttack(10);
			break;
		case 11040:
			actleftItemInfo();
			break;
		case 11041:
			actrightItemInfo();
			break;
		case 11042:
			actCoinOut();
			break;
		case 11043:
			actCoinIn();
			break;
		case 11044:
			domenuFriendLeft();
			break;
		case 110441:
			doAddFriend();
			break;
		case 11045:
			domenuFindTeam();
			break;
		case 110451:
			actInputTeam();
			break;
		case 110452:
			actRefreshFindTeam();
			break;
		case 11046:
			domenuFindTeamCenter();
			break;
		case 11047:
			domenuTeamLeft();
			break;
		case 110471:
			actCreateTeam();
			break;
		case 11048:
			actBoxSort();
			break;
		case 11049:
			actionCoinOut();
			break;
		case 11050:
			actionCoinIn();
			break;
		case 11051:
			actUseItem();
			break;
		case 11052:
		{
			Item item13 = (Item)p;
			Service.gI().useItemChangeMap(item13.indexUI, GameCanvas.menu.menuSelectedItem);
			break;
		}
		case 11053:
		{
			Item itemBag = (Item)p;
			doItemChangeMap(itemBag);
			break;
		}
		case 110531:
		{
			Item item12 = (Item)p;
			Service.gI().useItemChangeMap(item12.indexUI, GameCanvas.menu.menuSelectedItem + 3);
			break;
		}
		case 11054:
			doOpenUIZone();
			break;
		case 11055:
		{
			Item item11 = (Item)p;
			doActionBuy(item11);
			break;
		}
		case 110561:
			GameCanvas.endDlg();
			updateCommandForUI();
			break;
		case 110562:
		{
			Item item10 = (Item)p;
			doActionSaleOk(item10);
			break;
		}
		case 11057:
		{
			Npc npc3 = (Npc)p;
			Service.gI().getTask(npc3.template.npcTemplateId, GameCanvas.menu.menuSelectedItem, -1);
			break;
		}
		case 11058:
		{
			Item item9 = (Item)p;
			GameCanvas.endDlg();
			Service.gI().saleItem(item9.indexUI, int.Parse(GameCanvas.inputDlg.tfInput.getText()));
			break;
		}
		case 11059:
			actdoChooseSkill();
			break;
		case 11060:
			actdoMiniInfo();
			break;
		case 11061:
		{
			Item item8 = (Item)p;
			actSaleConfirm(item8);
			break;
		}
		case 11062:
			upPearl();
			break;
		case 11063:
			actConfirmUpgrade();
			break;
		case 11064:
			Service.gI().upPotential(indexTitle - 1, 1);
			setLCR();
			break;
		case 11065:
			doUpPotential();
			break;
		case 11066:
			doCloseAlert();
			isPaintMessage = false;
			isMessageMenu = false;
			ChatTextField.gI().center = null;
			break;
		case 11067:
			if (TileMap.zoneID != indexSelect)
			{
				Service.gI().requestChangeZone(indexSelect, indexItemUse);
			}
			else
			{
				InfoMe.addInfo(mResources.ZONE_HERE);
			}
			break;
		case 11068:
			empty = (string)p;
			actOpenWeb(empty);
			break;
		case 11069:
			actOpenWebCancel();
			break;
		case 11070:
		{
			Party pt = (Party)p;
			actRefresh_TeamLeader(pt);
			break;
		}
		case 110701:
			Service.gI().outParty();
			break;
		case 110702:
			Service.gI().lockParty(isLock: true);
			break;
		case 110703:
			Service.gI().lockParty(isLock: false);
			break;
		case 11071:
			Service.gI().outParty();
			break;
		case 11072:
			actSaleItem();
			break;
		case 110721:
			Service.gI().saleItem(indexSelect, 1);
			break;
		case 110722:
			actionSale(Char.getMyChar().arrItemBag[indexSelect]);
			break;
		case 110723:
			Service.gI().saleItem(indexSelect, Char.getMyChar().arrItemBag[indexSelect].quantity);
			break;
		case 11073:
			actionSale(Char.getMyChar().arrItemBag[indexSelect]);
			break;
		case 11074:
		{
			MyVector myVector5 = (MyVector)p;
			short port = short.Parse(string.Empty + myVector5.elementAt(0));
			string syntax = string.Empty + myVector5.elementAt(1);
			actSendSMSLeft(port, syntax);
			break;
		}
		case 11075:
			actSendSMSRight();
			break;
		case 11076:
			empty = (string)p;
			Service.gI().addParty(empty);
			break;
		case 11077:
			empty = (string)p;
			actConfirmRemoveFriend(empty);
			break;
		case 110771:
			empty = (string)p;
			GameCanvas.endDlg();
			Service.gI().removeFriend(empty);
			break;
		case 11078:
			actSetEnemiesCommand();
			break;
		case 11079:
			actSetFriendCommand();
			break;
		case 110791:
			empty = (string)p;
			Service.gI().addParty(empty);
			break;
		case 110792:
			empty = (string)p;
			actSetDeleteFriend(empty);
			break;
		case 1107921:
			empty = (string)p;
			GameCanvas.endDlg();
			Service.gI().removeFriend(empty);
			actRemoveWaitAcceptFriend(empty);
			break;
		case 1107931:
			empty = (string)p;
			Service.gI().addFriend(empty);
			break;
		case 1107932:
			empty = (string)p;
			actRemoveWaitAcceptFriend(empty);
			break;
		case 11080:
			empty = (string)p;
			actSetPartyCommand(empty);
			break;
		case 110801:
			Service.gI().moveMember(indexRow);
			break;
		case 110802:
			Service.gI().changeTeamLeader(indexRow);
			break;
		case 110803:
			empty = (string)p;
			Service.gI().addFriend(empty);
			break;
		case 110804:
			viewMemberInfo();
			break;
		case 1108041:
			empty = (string)p;
			Service.gI().viewInfo(empty);
			gI().resetButton();
			break;
		case 110805:
			viewMemberClanInfo();
			break;
		case 11081:
			actdoGan();
			break;
		case 110811:
		{
			SkillTemplate skillTemplate2 = Char.getMyChar().nClass.skillTemplates[indexSelect];
			doSetKeySkill(skillTemplate2);
			break;
		}
		case 110812:
		{
			SkillTemplate skillTemplate = Char.getMyChar().nClass.skillTemplates[indexSelect];
			doSetOnScreenSkill(skillTemplate);
			break;
		}
		case 11082:
			actTrangBiSelect();
			break;
		case 110821:
			Service.gI().itemBodyToBag(indexSelect + indextabTrangbi);
			break;
		case 11083:
			actView(5);
			break;
		case 11084:
			actdoUpPoint();
			break;
		case 110841:
			Service.gI().upPotential(indexTitle - 1, 1);
			setLCR();
			break;
		case 110842:
			doUpPotential();
			break;
		case 11085:
		{
			Item item7 = (Item)p;
			actBuyQuanNam(item7);
			break;
		}
		case 110851:
		{
			Item item6 = (Item)p;
			Service.gI().buyItem(item6.typeUI, item6.indexUI, 1);
			break;
		}
		case 110852:
		{
			Item item5 = (Item)p;
			actionBuy(item5);
			break;
		}
		case 110854:
			actTrangBiCenter();
			break;
		case 11086:
			actTrangBiRight();
			break;
		case 11087:
		{
			Item item4 = (Item)p;
			GameCanvas.endDlg();
			Service.gI().splitItem(item4);
			break;
		}
		case 11088:
			actView(26);
			break;
		case 11089:
			actView(27);
			break;
		case 11090:
			actView(28);
			break;
		case 11091:
			actView(29);
			break;
		case 11092:
		{
			Item itemBuy = (Item)p;
			actBuyLeft(itemBuy);
			break;
		}
		case 110921:
		{
			Item item3 = (Item)p;
			Service.gI().buyItem(item3.typeUI, item3.indexUI, 1);
			break;
		}
		case 110922:
		{
			Item item2 = (Item)p;
			actionBuy(item2);
			break;
		}
		case 110923:
			actView(16);
			break;
		case 110924:
			actView(17);
			break;
		case 110925:
			actView(18);
			break;
		case 110926:
			actView(19);
			break;
		case 11093:
			actView(2);
			break;
		case 11094:
			actView(6);
			break;
		case 11095:
			actView(7);
			break;
		case 11096:
			actView(8);
			break;
		case 11097:
			actView(9);
			break;
		case 11098:
			actUpgradeLeft();
			break;
		case 110981:
			upGrade();
			break;
		case 11099:
			isViewNext = false;
			updateItemInfo(3, itemUpGrade);
			break;
		case 110991:
			isViewNext = true;
			updateItemInfo(3, itemUpGrade);
			break;
		case 11100:
			actUpgradeBag();
			break;
		case 111001:
			actItemUpgradeMoveOut();
			break;
		case 11101:
			item = getItemFocus(10);
			updateItemInfo(3, item);
			break;
		case 11102:
			actUpgrade_HanhTrang();
			break;
		case 11103:
			actSplitItem();
			break;
		case 111031:
			if (isPaintTinhluyen)
			{
				Service.gI().tinhluyen(itemSplit, arrItemSplit);
			}
			else if (isPaintDichChuyen)
			{
				Service.gI().dichchuyen(itemSplit, arrItemSplit);
			}
			else if (isPaintLuyenNgoc)
			{
				Service.gI().ngockham(1, null, itemSplit, arrItemSplit);
			}
			else if (isPaintGotNgoc)
			{
				Service.gI().ngockham(2, null, itemSplit, null);
			}
			else if (isPaintThaoNgoc)
			{
				Service.gI().ngockham(3, null, itemSplit, null);
			}
			break;
		case 11104:
			updateItemInfo(3, (Item)p);
			break;
		case 11105:
			split();
			break;
		case 11106:
			actSplitItemBag();
			break;
		case 11107:
			actUpPearlSelect();
			break;
		case 111071:
			actUpPearlMoveOut();
			break;
		case 11108:
			actView(3);
			break;
		case 11109:
			actUpPearlItems();
			break;
		case 11110:
			item = arrItemTradeOrder[indexSelect];
			updateItemInfo(30, item);
			break;
		case 111101:
			item = getItemFocus(4);
			Service.gI().itemBoxToBag(item.indexUI);
			break;
		case 11111:
			item = getItemFocus(4);
			updateItemInfo(4, item);
			break;
		case 11112:
			Service.gI().boxSort();
			break;
		case 11113:
			Service.gI().itemBagToBox(Char.getMyChar().arrItemBag[indexSelect].indexUI);
			break;
		case 11114:
			updateItemInfo(3, Char.getMyChar().arrItemBag[indexSelect]);
			break;
		case 11115:
			actBuyItemUILeft();
			break;
		case 11116:
			actBuyItemLeft2();
			break;
		case 11120:
		{
			object[] array2 = (object[])p;
			Skill skill2 = (Skill)array2[0];
			int num5 = int.Parse((string)array2[1]);
			onScreenSkill[num5] = skill2;
			saveOnScreenSkillToRMS();
			break;
		}
		case 11121:
		{
			object[] array = (object[])p;
			Skill skill = (Skill)array[0];
			int num4 = int.Parse((string)array[1]);
			keySkill[num4] = skill;
			saveKeySkillToRMS();
			break;
		}
		case 12000:
			actOpenAlertURL();
			break;
		case 12001:
			ChatManager.gI().switchToTab((int)p);
			openUIChatTab();
			break;
		case 12002:
		case 12004:
		{
			empty = (string)p;
			ChatTab chatTab = ChatManager.gI().findTab(empty);
			if (chatTab == null)
			{
				ChatManager.gI().addNewTab(empty);
				ChatManager.gI().switchToLastTab();
			}
			else
			{
				ChatManager.gI().switchToTab(chatTab);
			}
			openUIChatTab();
			isPaintTeam = (isPaintFriend = (isPaintEnemies = (isPaintClan = (isPaintFindTeam = false))));
			ChatTextField.gI().center = null;
			break;
		}
		case 12003:
			doShowFriendUI();
			break;
		case 12005:
			doShowChatTextFieldInMessage();
			break;
		case 120051:
		{
			ChatTab o = (ChatTab)p;
			ChatManager.gI().chatTabs.removeElement(o);
			if (ChatManager.gI().currentTabIndex > ChatManager.gI().chatTabs.size() - 1)
			{
				ChatManager.gI().switchToPreviousTab();
			}
			o = ChatManager.gI().getCurrentChatTab();
			if (o != null)
			{
				openUIChatTab();
				break;
			}
			ChatTextField.gI().isShow = false;
			resetButton();
			break;
		}
		case 12006:
			doShowBlockMessageMenu();
			break;
		case 120061:
			ChatManager.blockGlobalChat = !ChatManager.blockGlobalChat;
			GameCanvas.startOKDlg(mResources.BLOCK_GLOBAL_CHAT + ((!ChatManager.blockGlobalChat) ? mResources.OFF : mResources.ON));
			break;
		case 120062:
			ChatManager.blockPrivateChat = !ChatManager.blockPrivateChat;
			GameCanvas.startOKDlg(mResources.BLOCK_PRIVATE_CHAT + ((!ChatManager.blockPrivateChat) ? mResources.OFF : mResources.ON));
			break;
		case 12007:
			step = 1;
			strErrCard = string.Empty;
			doShowErrorInput();
			break;
		case 120071:
			step = 2;
			if (GameCanvas.input2Dlg.tfInput.getText().Equals(string.Empty))
			{
				GameCanvas.startOKDlg(mResources.NOT_INPUT_CARDINFO);
				break;
			}
			if (GameCanvas.input2Dlg.tfInput2.getText().Equals(string.Empty))
			{
				GameCanvas.startOKDlg(mResources.NOT_INPUT_CARDMONEY);
				break;
			}
			strErrCard = "Loại thẻ: " + GameCanvas.input2Dlg.tfInput.getText();
			strErrCard = strErrCard + ", Mệnh giá: " + GameCanvas.input2Dlg.tfInput2.getText();
			GameCanvas.endDlg();
			doShowErrorInput();
			break;
		case 120072:
			if (GameCanvas.input2Dlg.tfInput.getText().Equals(string.Empty))
			{
				GameCanvas.startOKDlg(mResources.NOT_INPUT_CARDSERI);
				break;
			}
			if (GameCanvas.input2Dlg.tfInput2.getText().Equals(string.Empty))
			{
				GameCanvas.startOKDlg(mResources.NOT_INPUT_CARDTIME);
				break;
			}
			strErrCard = strErrCard + ", Số seri: " + GameCanvas.input2Dlg.tfInput.getText();
			strErrCard = strErrCard + ", Khoảng thời gian nạp: " + GameCanvas.input2Dlg.tfInput2.getText();
			Service.gI().adminChat(strErrCard);
			Out.println("strERRCard: " + strErrCard);
			GameCanvas.endDlg();
			break;
		case 12008:
			domenuErrorAdim();
			break;
		case 120081:
			GameCanvas.inputDlg.tfInput.setMaxTextLenght(11);
			GameCanvas.inputDlg.show(mResources.INPUT_REG_NUMPHONE, new Command("OK", null, 120082, null), TField.INPUT_TYPE_NUMERIC);
			break;
		case 120082:
			empty = GameCanvas.inputDlg.tfInput.getText();
			if (empty.Equals(string.Empty))
			{
				GameCanvas.startOKDlg(mResources.NOT_INPUT_NUMPHONE);
				break;
			}
			Service.gI().adminChat("Số điện thoại đăng ký: " + empty);
			GameCanvas.endDlg();
			break;
		case 12009:
		{
			empty = (string)p;
			MyVector myVector4 = new MyVector();
			myVector4.addElement(new Command(mResources.CHAR_ORDER[7], 12002, empty));
			myVector4.addElement(new Command(mResources.TEAMLEADER_SELECT[2], 110803, empty));
			if (isPaintTeam)
			{
				myVector4.addElement(new Command(mResources.CHAR_ORDER[6], 110804));
			}
			if (isPaintMessage)
			{
				myVector4.addElement(new Command(mResources.MOVETO, 14020, empty));
				myVector4.addElement(new Command(mResources.CHAR_ORDER[6], 1108041, empty));
			}
			GameCanvas.menu.startAt(myVector4, 0);
			break;
		}
		case 130011:
		{
			Npc npc2 = (Npc)p;
			Service.gI().getTask(npc2.template.npcTemplateId, 0, -1);
			npc2.chatPopup = null;
			resetButton();
			break;
		}
		case 130012:
		{
			Npc npc = (Npc)p;
			npc.chatPopup = null;
			resetButton();
			break;
		}
		case 13001:
			actView(32);
			break;
		case 13002:
			actStoreFashionBuy();
			break;
		case 130021:
			actBuy(32);
			break;
		case 130022:
			actBuys(32);
			break;
		case 14001:
			actdoKyNang();
			break;
		case 140011:
			Service.gI().upSkill(Char.getMyChar().nClass.skillTemplates[indexSelect].id, 1);
			setLCR();
			break;
		case 140012:
			doUpSkill();
			break;
		case 14002:
			doUnfocusChar();
			break;
		case 14003:
			doCharFocusList();
			break;
		case 14004:
			domenuClanNotice();
			break;
		case 140041:
			GameCanvas.inputDlg.tfInput.setMaxTextLenght(180);
			GameCanvas.inputDlg.show(mResources.INPUT_CLAN_TEXT, new Command(mResources.ACCEPT, GameCanvas.instance, 88832, null), TField.INPUT_TYPE_ANY);
			break;
		case 140042:
			Service.gI().clanUpLevel();
			break;
		case 140043:
			GameCanvas.inputDlg.show(mResources.INPUT_CLAN_MONEY, new Command(mResources.ACCEPT, GameCanvas.instance, 88834, null), TField.INPUT_TYPE_ANY);
			break;
		case 140044:
			Service.gI().unlockClanItem();
			break;
		case 14005:
			domenuClanLeader();
			break;
		case 14006:
			empty = (string)p;
			actSetClanCommand(empty);
			break;
		case 14007:
			domenuClanConfig();
			break;
		case 140071:
			indexRow = 0;
			indexSelect = 0;
			scrMain.clear();
			isViewClanMemOnline = !isViewClanMemOnline;
			sortClan();
			break;
		case 140072:
			indexRow = 0;
			indexSelect = 0;
			scrMain.clear();
			isSortClanByPointWeek = !isSortClanByPointWeek;
			sortClan();
			break;
		case 14008:
			GameCanvas.startYesNoDlg(mResources.MOVE_OUT_CLAN1, new Command(mResources.YES, 140081), new Command(mResources.NO, 1));
			break;
		case 140081:
			Service.gI().outClan();
			GameCanvas.endDlg();
			break;
		case 14009:
			domenuClanPermission();
			break;
		case 140091:
			Service.gI().changeClanType(((Member)vClan.elementAt(indexRow)).name, 3);
			break;
		case 140092:
			Service.gI().changeClanType(((Member)vClan.elementAt(indexRow)).name, 2);
			break;
		case 140093:
			GameCanvas.startYesNoDlg(mResources.CLEAR_CLAN_TYPE, new Command(mResources.YES, 1400931), new Command(mResources.NO, 1));
			break;
		case 140094:
			GameCanvas.startYesNoDlg(mResources.MOVE_OUT_CLAN, new Command(mResources.YES, 1400941), new Command(mResources.NO, 1));
			break;
		case 1400931:
			Service.gI().changeClanType(((Member)vClan.elementAt(indexRow)).name, 0);
			GameCanvas.endDlg();
			break;
		case 1400941:
			Service.gI().moveOutClan(((Member)vClan.elementAt(indexRow)).name);
			GameCanvas.endDlg();
			break;
		case 140095:
		{
			Member member2 = (Member)vClan.elementAt(indexRow);
			Service.gI().inviteClanDun(member2.name);
			break;
		}
		case 140096:
			myVector = new MyVector();
			myVector.addElement(new Command(mResources.INVITE_THIS_PERSON, 1400961));
			myVector.addElement(new Command(mResources.INVITE_ALL, 1400962));
			GameCanvas.menu.startAt(myVector, 0);
			break;
		case 1400961:
		{
			Member member = (Member)vClan.elementAt(indexRow);
			Service.gI().inviteClanBattlefield(member.name);
			break;
		}
		case 1400962:
			Service.gI().inviteClanBattlefieldAll();
			break;
		case 14010:
			GameCanvas.inputDlg.show(mResources.INPUT_CLAN_CONTRIBUTE, new Command(mResources.ACCEPT, GameCanvas.instance, 88833, null), TField.INPUT_TYPE_NUMERIC);
			break;
		case 140101:
			item = new Item();
			item.template = ItemTemplates.get(0);
			item.expires = -1L;
			updateItemInfo(39, item);
			break;
		case 14011:
			isMessageMenu = false;
			break;
		case 14012:
			actConvert_HanhTrang();
			break;
		case 14013:
			actConvertLeft();
			break;
		case 140131:
			GameCanvas.startYesNoDlg(mResources.CONFIRMCONVERT, new Command(mResources.YES, 140132), new Command(mResources.NO, 1));
			break;
		case 140132:
			Convert();
			break;
		case 14014:
			actConvertMoveOut();
			break;
		case 14015:
			actItemConvertMoveOut();
			break;
		case 140151:
			actItemConvertMoveOut2();
			break;
		case 14016:
			updateItemInfo(3, arrItemConvert[indexSelect]);
			break;
		case 140161:
			updateItemInfo(3, arrItemConvert[2]);
			break;
		case 14017:
			domenuEnemieLeft();
			break;
		case 14018:
			actView(34);
			break;
		case 14019:
			actClanStoreBuy();
			break;
		case 140191:
			actBuy(34);
			break;
		case 140192:
			actBuys(34);
			break;
		case 14020:
			if (isHaveVanBienLenh())
			{
				empty = (string)p;
				Service.gI().textBoxId(1, empty);
			}
			else
			{
				GameCanvas.startOKDlg(mResources.ALERT_MOVETO);
			}
			break;
		case 14021:
			actSetDunListCommand();
			break;
		case 14022:
			actEliteShopBuy();
			break;
		case 140221:
			actBuy(35);
			break;
		case 140222:
			actBuys(35);
			break;
		case 14023:
			actView(35);
			break;
		case 14024:
			actSetRankedListCommand(1);
			break;
		case 14025:
			actSetRankedListCommand(0);
			break;
		case 1500:
			myVector = new MyVector();
			myVector.addElement(new Command(mResources.MOVEOUT, 15001));
			if (Char.getMyChar().xu >= 1000)
			{
				myVector.addElement(new Command(mResources.SALE, 15002));
			}
			GameCanvas.menu.startAt(myVector, 1);
			break;
		case 15001:
			doStandToBag();
			break;
		case 15002:
			try
			{
				int num3 = int.Parse(tfText.getText());
				if (num3 <= 0)
				{
					GameCanvas.startOKDlg(mResources.INVALID_NUM);
				}
				GameCanvas.startYesNoDlg(mResources.replace(mResources.SALE_ASK, NinjaUtil.numberToString(num3 + string.Empty)), new Command(mResources.YES, 150021), new Command(mResources.NO, 1));
				break;
			}
			catch (Exception)
			{
				GameCanvas.startOKDlg(mResources.INVALID_NUM);
				break;
			}
		case 150021:
		{
			GameCanvas.startWaitDlg();
			int value = 0;
			try
			{
				value = int.Parse(tfText.getText());
			}
			catch (Exception)
			{
			}
			Service.gI().sendToSaleItem(itemSell, value);
			break;
		}
		case 1501:
			updateItemInfo(3, itemSell);
			break;
		case 1502:
			tfText.isFocus = true;
			break;
		case 1503:
			doBagToStand();
			break;
		case 1504:
			domenuItemStand();
			break;
		case 15041:
			domenuSortItemStand();
			break;
		case 150411:
			typeSortLevel = 0;
			typeSortName = 0;
			if (typeSortPrice == 0)
			{
				typeSortPrice = 1;
			}
			else if (typeSortPrice == 1)
			{
				typeSortPrice = 2;
			}
			else if (typeSortPrice == 2)
			{
				typeSortPrice = 1;
			}
			sortItemStand();
			break;
		case 150412:
			typeSortLevel = 0;
			typeSortPrice = 0;
			if (typeSortName == 0)
			{
				typeSortName = 1;
			}
			else if (typeSortName == 1)
			{
				typeSortName = 2;
			}
			else if (typeSortName == 2)
			{
				typeSortName = 1;
			}
			sortItemStand();
			break;
		case 150413:
			typeSortPrice = 0;
			typeSortName = 0;
			if (typeSortLevel == 0)
			{
				typeSortLevel = 1;
			}
			else if (typeSortLevel == 1)
			{
				typeSortLevel = 2;
			}
			else if (typeSortLevel == 2)
			{
				typeSortLevel = 1;
			}
			sortItemStand();
			break;
		case 15042:
			GameCanvas.startYesNoDlg(mResources.replace(mResources.BUY_ASK, NinjaUtil.numberToString(arrItemStands[indexSelect].price + string.Empty)), new Command(mResources.YES, 150421), new Command(mResources.NO, 1));
			break;
		case 150421:
			GameCanvas.endDlg();
			Service.gI().buyItemAuction(arrItemStands[indexSelect].item.itemId);
			break;
		case 1505:
			updateItemInfo(3, arrItemStands[indexSelect].item);
			break;
		case 1506:
			if (arrItemSprin != null)
			{
				yenTemp = 0;
				isPaintItemInfo = false;
				indexCard = -1;
				arrItemSprin = null;
				gI().left = new Command(mResources.SELECT, 1506);
			}
			else
			{
				indexCard = indexSelect;
				Service.gI().selectCard();
				GameCanvas.startWaitDlgWithoutCancel();
			}
			break;
		case 1507:
			doviewCardsInfo();
			break;
		case 1508:
		{
			MyVector myVector3 = new MyVector();
			item = Char.clan.items[indexSelect];
			if (item.template.id == 281)
			{
				myVector3.addElement(new Command(mResources.USE, 15081));
			}
			else
			{
				myVector3.addElement(new Command(mResources.CLAN_BOX, 15082));
			}
			GameCanvas.menu.startAt(myVector3, 0);
			break;
		}
		case 15081:
			Service.gI().useClanItem();
			break;
		case 15082:
			GameCanvas.inputDlg.show(mResources.INPUT_MEM_NAME, new Command(mResources.OK, GameCanvas.instance, 88843, indexSelect), TField.INPUT_TYPE_ANY);
			break;
		case 1509:
			if (indexSelect >= 0 && Char.clan != null)
			{
				updateItemInfo(39, Char.clan.items[indexSelect]);
			}
			else
			{
				isPaintItemInfo = false;
			}
			break;
		case 1510:
			doAutoSelect();
			break;
		case 1511:
			empty = GameCanvas.inputDlg.tfInput.getText();
			GameCanvas.endDlg();
			try
			{
				if (empty.Equals(string.Empty))
				{
					GameCanvas.startOKDlg(mResources.INVALID_NUM);
					break;
				}
				int num2 = int.Parse(empty);
				if (num2 < 10 || num2 > 90)
				{
					GameCanvas.startOKDlg(mResources.INVALID_NUM);
				}
				else
				{
					Char.aHpValue = num2;
				}
				break;
			}
			catch (Exception)
			{
				GameCanvas.startOKDlg(mResources.INVALID_NUM);
				break;
			}
		case 1512:
			empty = GameCanvas.inputDlg.tfInput.getText();
			GameCanvas.endDlg();
			try
			{
				if (empty.Equals(string.Empty))
				{
					GameCanvas.startOKDlg(mResources.INVALID_NUM);
					break;
				}
				int num = int.Parse(empty);
				if (num < 10 || num > 90)
				{
					GameCanvas.startOKDlg(mResources.INVALID_NUM);
				}
				else
				{
					Char.aMpValue = num;
				}
				break;
			}
			catch (Exception)
			{
				GameCanvas.startOKDlg(mResources.INVALID_NUM);
				break;
			}
		case 151301:
			Service.gI().sendCatkeo(Char.getMyChar().mobFocus.getTemplate().mobTemplateId);
			break;
		case 15130:
			Char.aFoodValue = 1;
			break;
		case 15131:
			Char.aFoodValue = 10;
			break;
		case 15132:
			Char.aFoodValue = 20;
			break;
		case 15133:
			Char.aFoodValue = 30;
			break;
		case 15134:
			Char.aFoodValue = 40;
			break;
		case 15135:
			Char.aFoodValue = 50;
			break;
		case 15136:
			Char.aFoodValue = 60;
			break;
		case 15137:
			Char.aFoodValue = 70;
			break;
		case 1515:
			updateItemInfo(41, currentCharViewInfo.arrItemMounts[indexSelect]);
			break;
		case 1516:
			Service.gI().itemMonToBag(indexSelect);
			break;
		case 1600:
			doLuyenThach();
			break;
		case 1601:
			actLuyenThachSelect();
			break;
		case 1602:
			item = getItemFocus(43);
			updateItemInfo(3, item);
			break;
		case 1603:
			actgetLuyenThachItems();
			break;
		case 1604:
		{
			MyVector myVector2 = new MyVector();
			if (arrItemSplit[indexSelect] != null)
			{
				myVector2.addElement(new Command(mResources.MOVEOUT, 1605));
			}
			myVector2.addElement(new Command(mResources.BEGIN, 11105));
			GameCanvas.menu.startAt(myVector2, 0);
			break;
		}
		case 1605:
			actTinhLuyenMoveOut();
			break;
		case 1606:
			actDichChuyenTrangBiLeft();
			break;
		case 999:
			doOpenUI(35);
			break;
		case 1700:
			luckyDraw_refresh();
			break;
		case 1701:
			luckyDraw_Tf();
			break;
		case 1702:
			doCloseLucky_Draw();
			break;
		case 222:
			actSplitItemBag_luyenngoc();
			break;
		case 333:
			doOpenUI(47);
			break;
		case 334:
			actUpgrade_HanhTrang();
			break;
		case 335:
			isViewNext = false;
			updateItemInfo(3, itemSplit);
			break;
		case 336:
			isViewNext = false;
			updateItemInfo(3, itemUpGrade);
			break;
		case 337:
			act_update_khamngoc();
			break;
		case 338:
			setCMD_act_KhamNgoc(0);
			break;
		case 344:
			setCMD_act_KhamNgoc(1);
			break;
		case 345:
			setCMD_act_KhamNgoc(2);
			break;
		case 339:
			actKhamNgocMoveOut(0);
			break;
		case 340:
			actKhamNgocMoveOut(1);
			break;
		case 343:
			actKhamNgocMoveOut(2);
			break;
		case 341:
			khamngoc();
			break;
		case 342:
			actConfirmKhamNgoc();
			break;
		case 400:
			act_update_giaodo();
			break;
		case 401:
			setCMD_act_GiaoDo();
			break;
		case 402:
			actGiaoDoMoveOut();
			break;
		case 403:
			sendGiaoDo();
			break;
		case 405:
			actSplitItemBag_gotngoc();
			break;
		case 500:
			actBijuuSelect();
			break;
		case 501:
			Service.gI().itemMonToBag(indexSelect);
			break;
		case 502:
			doBiJuu();
			break;
		case 5021:
			doBiJuu_Point();
			break;
		case 5022:
			doBiJuu_Skill();
			break;
		case 503:
			updateItemInfo(41, currentCharViewInfo.arrItemMounts[indexSelect]);
			break;
		case 504:
			actBijuuMenuPoint();
			break;
		case 5041:
			Service.gI().upPotential(indexTitle - 1, 1);
			setLCR();
			break;
		case 5042:
			doBijuuUpPoint();
			break;
		case 5043:
			actBijuuUpPoint();
			break;
		case 505:
			actBijuuKyNang();
			break;
		case 5051:
			Service.gI().upSkill(Char.getMyChar().nClass.skillTemplates[indexSelect].id, 1);
			setLCR();
			break;
		case 5052:
			doBijuuUpSkill();
			break;
		case 5053:
			actBijSkillUpPoint();
			break;
		}
	}

	private void actDichChuyenTrangBiLeft()
	{
		try
		{
			if (Char.getMyChar().arrItemBag[indexSelect].template.id == 454)
			{
				if (arrItemSplit == null)
				{
					arrItemSplit = new Item[24];
				}
				for (int i = 0; i < arrItemSplit.Length; i++)
				{
					if (i == 20)
					{
						GameCanvas.startOKDlg(mResources.CRYSTAL_FULL);
						break;
					}
					if (arrItemSplit[i] == null)
					{
						arrItemSplit[i] = Char.getMyChar().arrItemBag[indexSelect];
						Char.getMyChar().arrItemBag[indexSelect] = null;
						left = (center = null);
						updateCommandForUI();
						break;
					}
				}
			}
			else if (Char.getMyChar().arrItemBag[indexSelect].upgrade > 11)
			{
				if (itemSplit == null)
				{
					itemSplit = Char.getMyChar().arrItemBag[indexSelect];
					Char.getMyChar().arrItemBag[indexSelect] = null;
				}
				else
				{
					Item item = Char.getMyChar().arrItemBag[indexSelect];
					Char.getMyChar().arrItemBag[indexSelect] = null;
					Char.getMyChar().arrItemBag[itemSplit.indexUI] = itemSplit;
					itemSplit = item;
				}
				Service.gI().requestItemInfo(itemSplit.typeUI, itemSplit.indexUI);
			}
			else
			{
				GameCanvas.startOKDlg(mResources.CAN_NOT_DICHCHUYEN);
			}
		}
		catch (Exception)
		{
		}
	}

	private void actTinhLuyenMoveOut()
	{
		Item item = getItemFocus(44);
		arrItemSplit[indexSelect] = null;
		Char.getMyChar().arrItemBag[item.indexUI] = item;
		left = (center = null);
		updateCommandForUI();
	}

	private void doAutoSelect()
	{
		if (indexRow == 0)
		{
			Char.isAHP = !Char.isAHP;
			if (typeActive == 1)
			{
				Char.isAHP = false;
				InfoMe.addInfo(mResources.AOPENACC, 20, mFont.tahoma_7_yellow);
			}
		}
		else if (indexRow == 1)
		{
			Char.isAMP = !Char.isAMP;
			if (typeActive == 1)
			{
				Char.isAMP = false;
				InfoMe.addInfo(mResources.AOPENACC, 20, mFont.tahoma_7_yellow);
			}
		}
		else if (indexRow == 2)
		{
			Char.isAFood = !Char.isAFood;
			if (typeActive == 1)
			{
				Char.isAFood = false;
				InfoMe.addInfo(mResources.AOPENACC, 20, mFont.tahoma_7_yellow);
			}
		}
		else if (indexRow == 3)
		{
			Char.isABuff = !Char.isABuff;
		}
		else if (indexRow == 4)
		{
			Char.isAPickYen = !Char.isAPickYen;
			if (Char.isAPickYen)
			{
				Char.isAPickYHM = (Char.isAPickYHMS = (Char.isANoPick = false));
			}
		}
		else if (indexRow == 5)
		{
			Char.isAPickYHM = !Char.isAPickYHM;
			if (Char.isAPickYHM)
			{
				Char.isAPickYen = (Char.isAPickYHMS = (Char.isANoPick = false));
			}
		}
		else if (indexRow == 6)
		{
			Char.isAPickYHMS = !Char.isAPickYHMS;
			if (Char.isAPickYHMS)
			{
				Char.isAPickYen = (Char.isAPickYHM = (Char.isANoPick = false));
			}
		}
		else if (indexRow == 7)
		{
			Char.isANoPick = !Char.isANoPick;
			if (Char.isANoPick)
			{
				Char.isAPickYen = (Char.isAPickYHM = (Char.isAPickYHMS = false));
			}
		}
	}

	private void doviewCardsInfo()
	{
		if (arrItemSprin != null)
		{
			Item item = new Item();
			item.template = ItemTemplates.get(arrItemSprin[indexSelect]);
			updateItemInfo(38, item);
		}
	}

	private void sortItemStand()
	{
		if (typeSortLevel == 0 && typeSortPrice == 0 && typeSortName == 0)
		{
			return;
		}
		for (int i = 0; i < arrItemStands.Length - 1; i++)
		{
			for (int j = i + 1; j < arrItemStands.Length; j++)
			{
				if (typeSortPrice == 1)
				{
					if (arrItemStands[i].price < arrItemStands[j].price)
					{
						ItemStands itemStands = arrItemStands[i];
						arrItemStands[i] = arrItemStands[j];
						arrItemStands[j] = itemStands;
					}
				}
				else if (typeSortPrice == 2 && arrItemStands[i].price > arrItemStands[j].price)
				{
					ItemStands itemStands2 = arrItemStands[i];
					arrItemStands[i] = arrItemStands[j];
					arrItemStands[j] = itemStands2;
				}
				if (typeSortName == 1)
				{
					if (!arrItemStands[i].item.template.name.Equals(arrItemStands[j].item.template.name) && arrItemStands[i].item.template.name.CompareTo(arrItemStands[j].item.template.name) > 0)
					{
						ItemStands itemStands3 = arrItemStands[i];
						arrItemStands[i] = arrItemStands[j];
						arrItemStands[j] = itemStands3;
					}
				}
				else if (typeSortName == 2 && !arrItemStands[i].item.template.name.Equals(arrItemStands[j].item.template.name) && arrItemStands[i].item.template.name.CompareTo(arrItemStands[j].item.template.name) < 0)
				{
					ItemStands itemStands4 = arrItemStands[i];
					arrItemStands[i] = arrItemStands[j];
					arrItemStands[j] = itemStands4;
				}
				if (typeSortLevel == 1)
				{
					if (arrItemStands[i].item.template.level < arrItemStands[j].item.template.level)
					{
						ItemStands itemStands5 = arrItemStands[i];
						arrItemStands[i] = arrItemStands[j];
						arrItemStands[j] = itemStands5;
					}
				}
				else if (typeSortLevel == 2 && arrItemStands[i].item.template.level > arrItemStands[j].item.template.level)
				{
					ItemStands itemStands6 = arrItemStands[i];
					arrItemStands[i] = arrItemStands[j];
					arrItemStands[j] = itemStands6;
				}
			}
		}
	}

	private void domenuSortItemStand()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.SORT_BY_PRICE, 150411));
		myVector.addElement(new Command(mResources.SORT_BY_NAME, 150412));
		myVector.addElement(new Command(mResources.SORT_BY_LEVEL, 150413));
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void domenuItemStand()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.SORT, 15041));
		myVector.addElement(new Command(mResources.BUY, 15042));
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void doStandToBag()
	{
		Char.getMyChar().arrItemBag[itemSell.indexUI] = itemSell;
		itemSell = null;
		left = (center = null);
	}

	private void doBagToStand()
	{
		Item item = Char.getMyChar().arrItemBag[indexSelect];
		if (item != null)
		{
			if (item.isLock || item.isExpires)
			{
				GameCanvas.startOKDlg(mResources.ONLY_NO_EXPIRE);
				return;
			}
			if (itemSell == null)
			{
				itemSell = Char.getMyChar().arrItemBag[indexSelect];
				Char.getMyChar().arrItemBag[indexSelect] = null;
				return;
			}
			item = Char.getMyChar().arrItemBag[indexSelect];
			Char.getMyChar().arrItemBag[indexSelect] = null;
			Char.getMyChar().arrItemBag[itemSell.indexUI] = itemSell;
			itemSell = item;
		}
	}

	private void actClanStoreBuy()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.BUY, 140191));
		myVector.addElement(new Command(mResources.BUYS, 140192));
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void domenuErrorAdim()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.BAG_CODE, null, 120081, null));
		myVector.addElement(new Command(mResources.CARD, null, 12007, null));
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void domenuClanConfig()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.CLAN_MENU[0] + ": " + ((!isViewClanMemOnline) ? mResources.ON : mResources.OFF), 140071));
		myVector.addElement(new Command(mResources.CLAN_SORTTYPE, 140072));
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void domenuEnemieLeft()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.CLAN_MENU[0] + ": " + ((!isViewClanMemOnline) ? mResources.ON : mResources.OFF), 140071));
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void doShowErrorInput()
	{
		if (step == 1)
		{
			GameCanvas.input2Dlg.setTitle(mResources.CARD_TYPE, mResources.CARD_MONEY);
			GameCanvas.input2Dlg.show(mResources.INPUT_CARDTYPE_MONEY, new Command(mResources.CLOSE, GameCanvas.gI(), 8882, null), new Command(mResources.NEXT, null, 120071, null), TField.INPUT_TYPE_ANY, TField.INPUT_TYPE_ANY);
		}
		else
		{
			GameCanvas.input2Dlg.setTitle(mResources.CARD_SERI, mResources.CARD_TIME);
			GameCanvas.input2Dlg.show(mResources.INPUT_CARDSERI_TIME, new Command(mResources.CLOSE, GameCanvas.gI(), 8882, null), new Command(mResources.OK, null, 120072, null), TField.INPUT_TYPE_ANY, TField.INPUT_TYPE_ANY);
		}
	}

	public void actRemoveWaitAcceptFriend(string strFWname)
	{
		for (int i = 0; i < vFriend.size(); i++)
		{
			Friend friend = (Friend)vFriend.elementAt(i);
			if (friend.friendName.Equals(strFWname) && friend.type == 4)
			{
				vFriend.removeElementAt(i);
				break;
			}
		}
		for (int j = 0; j < vFriendWait.size(); j++)
		{
			Friend friend2 = (Friend)vFriendWait.elementAt(j);
			if (friend2.friendName.Equals(strFWname))
			{
				vFriendWait.removeElementAt(j);
				break;
			}
		}
	}

	private void actItemConvertMoveOut2()
	{
		Item item = null;
		item = arrItemConvert[2];
		arrItemConvert[2] = null;
		Char.getMyChar().arrItemBag[item.indexUI] = item;
		left = (center = null);
		updateCommandForUI();
	}

	private void actConvertLeft()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(cmdConvertMoveOut);
		for (int i = 0; i < arrItemConvert.Length; i++)
		{
			if (arrItemConvert[i] == null)
			{
				left = null;
				break;
			}
			if (i == arrItemConvert.Length - 1)
			{
				myVector.addElement(new Command(mResources.BEGIN, 140131));
			}
		}
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actConvertMoveOut()
	{
		Item item = arrItemConvert[indexSelect];
		Char.getMyChar().arrItemBag[item.indexUI] = item;
		arrItemConvert[indexSelect] = null;
		left = (center = null);
		updateCommandForUI();
	}

	private void Convert()
	{
		GameCanvas.endDlg();
		Service.gI().doConvertUpgrade(arrItemConvert[0].indexUI, arrItemConvert[1].indexUI, arrItemConvert[2].indexUI);
	}

	public void convert(int index)
	{
		if (arrItemConvert[index] == null)
		{
			arrItemConvert[index] = Char.getMyChar().arrItemBag[indexSelect];
			Char.getMyChar().arrItemBag[indexSelect] = null;
		}
		else
		{
			Item item = Char.getMyChar().arrItemBag[indexSelect];
			Char.getMyChar().arrItemBag[indexSelect] = null;
			Char.getMyChar().arrItemBag[arrItemConvert[index].indexUI] = arrItemConvert[index];
			arrItemConvert[index] = item;
		}
		left = (center = null);
		updateCommandForUI();
	}

	private void actConvert_HanhTrang()
	{
		if (Char.getMyChar().arrItemBag[indexSelect].isTypeBody())
		{
			if (Char.getMyChar().arrItemBag[indexSelect].upgrade > 0)
			{
				convert(0);
			}
			else
			{
				convert(1);
			}
		}
		else if (Char.getMyChar().arrItemBag[indexSelect].template.id == 269 || Char.getMyChar().arrItemBag[indexSelect].template.id == 270 || Char.getMyChar().arrItemBag[indexSelect].template.id == 271)
		{
			convert(2);
		}
		else
		{
			GameCanvas.msgdlg.setInfo(mResources.ONLY_CONVERT, null, new Command(mResources.CLOSE, 2), null);
			GameCanvas.msgdlg.show();
		}
	}

	private void actItemConvertMoveOut()
	{
		Item item = null;
		item = arrItemConvert[indexSelect];
		arrItemConvert[indexSelect] = null;
		Char.getMyChar().arrItemBag[item.indexUI] = item;
		left = (center = null);
		updateCommandForUI();
	}

	private void actStoreFashionBuy()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.BUY, 130021));
		myVector.addElement(new Command(mResources.BUYS, 130022));
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void domenuClanNotice()
	{
		MyVector myVector = new MyVector();
		if (Char.getMyChar().ctypeClan == 3 || Char.getMyChar().ctypeClan == 4)
		{
			if (indexTitle == 1)
			{
				myVector.addElement(new Command(mResources.CLAN_MENU[8], 140044));
			}
			myVector.addElement(new Command(mResources.CLAN_MENU[2], 140041));
			myVector.addElement(new Command(mResources.CLAN_MENU[5], 140042));
			if (Char.getMyChar().ctypeClan == 4)
			{
				myVector.addElement(new Command(mResources.CLAN_MENU[4], 140043));
			}
			myVector.addElement(new Command(mResources.CHAR_ORDER[10] + ": " + ((!isViewClanInvite) ? mResources.ON : mResources.OFF), 11000665));
		}
		GameCanvas.menu.startAt(myVector, 3);
	}

	private void domenuFindTeam()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.REFRESH, 110452));
		if (vPtMap.size() > 0)
		{
			myVector.addElement(new Command(mResources.INPUT_TEAM, 110451));
		}
		GameCanvas.menu.startAt(myVector, 3);
	}

	private void domenuClanPermission()
	{
		Member member = (Member)vClan.elementAt(indexRow);
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.CLANS[1], 140091, member.name));
		myVector.addElement(new Command(mResources.CLANS[2], 140092, member.name));
		GameCanvas.menu.startAt(myVector, 3);
	}

	private void viewMemberClanInfo()
	{
		if (indexRow >= 0 && indexRow < vClan.size())
		{
			Member member = curMemberSelected();
			if (member != null && !member.name.Equals(string.Empty))
			{
				Service.gI().viewInfo(member.name);
				isPaintClan = false;
				gI().resetButton();
			}
		}
	}

	private void domenuFindTeamCenter()
	{
		Party party = (Party)vPtMap.elementAt(indexRow);
		if (party != null && !Char.getMyChar().cName.Equals(party.name))
		{
			MyVector myVector = new MyVector();
			myVector.addElement(new Command(mResources.CHAR_ORDER[6], 1108041, party.name));
			myVector.addElement(new Command(mResources.CHAT, 12002, party.name));
			myVector.addElement(new Command(mResources.TEAMLEADER_SELECT[2], 110803, party.name));
			GameCanvas.menu.startAt(myVector, 3);
		}
	}

	private void domenuClanLeader()
	{
		Member member = curMemberSelected();
		MyVector myVector = new MyVector();
		if (Char.getMyChar().ctypeClan == 4)
		{
			if (member.type != 4)
			{
				if (member.type != 3 && member.type != 2)
				{
					myVector.addElement(new Command(mResources.SET_TYPE_CLAN, 14009, member.name));
				}
				else
				{
					myVector.addElement(new Command(mResources.CLEAR_TYPE_CLAN, 140093, member.name));
				}
				if (TileMap.mapID == 98 || TileMap.mapID == 104)
				{
					myVector.addElement(new Command(mResources.CLAN_MENU[7], 140096, member.name));
				}
				else
				{
					myVector.addElement(new Command(mResources.CLAN_MENU[6], 140095, member.name));
				}
				myVector.addElement(new Command(mResources.FIRED_CLAN, 140094, member.name));
			}
			myVector.addElement(new Command(mResources.CONFIG, 14007));
		}
		else if (Char.getMyChar().ctypeClan == 3)
		{
			if (member.type != 4 && !member.name.Equals(Char.getMyChar().cName))
			{
				myVector.addElement(new Command(mResources.FIRED_CLAN, 140094, member.name));
				if (TileMap.mapID == 98 || TileMap.mapID == 104)
				{
					myVector.addElement(new Command(mResources.CLAN_MENU[7], 140096, member.name));
				}
				else
				{
					myVector.addElement(new Command(mResources.CLAN_MENU[6], 140095, member.name));
				}
			}
			myVector.addElement(new Command(mResources.CONFIG, 14007));
			myVector.addElement(new Command(mResources.CLAN_MENU[1], 14008, member.name));
		}
		else
		{
			myVector.addElement(new Command(mResources.CONFIG, 14007));
			myVector.addElement(new Command(mResources.CLAN_MENU[1], 14008, member.name));
		}
		GameCanvas.menu.startAt(myVector, 3);
	}

	private bool isHaveVanBienLenh()
	{
		for (int i = 0; i < Char.getMyChar().arrItemBag.Length; i++)
		{
			Item item = Char.getMyChar().arrItemBag[i];
			if (item != null && item.template.id == 279 && item.template.level <= Char.getMyChar().clevel)
			{
				return true;
			}
		}
		return false;
	}

	private void actSetClanCommand(string mName)
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.CHAR_ORDER[6], 110805));
		myVector.addElement(new Command(mResources.CHAT, 12002, mName));
		myVector.addElement(new Command(mResources.PT, 110791, mName));
		myVector.addElement(new Command(mResources.MOVETO, 14020, mName));
		myVector.addElement(new Command(mResources.TEAMLEADER_SELECT[2], 110803, mName));
		GameCanvas.menu.startAt(myVector, 3);
	}

	private void doCharFocusList()
	{
		Char @char = (Char)vCharInMap.elementAt(indexRow);
		if (!@char.isNhanbanz())
		{
			cLastFocusID = @char.charID;
			Char.getMyChar().mobFocus = null;
			Char.getMyChar().deFocusNPC();
			Char.getMyChar().itemFocus = null;
			Char.isManualFocus = true;
			isPaintCharInMap = false;
			Char.getMyChar().charFocus = @char;
		}
		resetButton();
	}

	private void actBuyItemLeft2()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.SORT, 110221));
		myVector.addElement(new Command(mResources.GETINMONEY, 11050));
		GameCanvas.menu.startAt(myVector, 3);
	}

	private void actBuyItemUILeft()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.SORT, 11048));
		myVector.addElement(new Command(mResources.GETOUTMONEY, 11049));
		GameCanvas.menu.startAt(myVector, 3);
	}

	private void actgetLuyenThachItems()
	{
		if (Char.getMyChar().arrItemBag[indexSelect].template.type == 26 || Char.getMyChar().arrItemBag[indexSelect].template.id == 455 || Char.getMyChar().arrItemBag[indexSelect].template.id == 456)
		{
			if (Char.getMyChar().arrItemBag[indexSelect].template.type == 26 && Char.getMyChar().arrItemBag[indexSelect].template.id < 10)
			{
				GameCanvas.startOKDlg(mResources.ONLY_LUYENTHACH5);
				return;
			}
			int num = 0;
			int num2 = 0;
			int num3 = ((arrItemUpPeal[12] != null) ? 1 : 0);
			for (int i = 0; i < arrItemUpPeal.Length; i++)
			{
				if (arrItemUpPeal[i] != null && arrItemUpPeal[i].template.type != 26)
				{
					num = arrItemUpPeal[i].template.id;
					num2++;
				}
			}
			for (int j = 0; j < arrItemUpPeal.Length; j++)
			{
				if (arrItemUpPeal[j] != null)
				{
					continue;
				}
				if (Char.getMyChar().arrItemBag[indexSelect].template.type == 26)
				{
					if (arrItemUpPeal[12] == null)
					{
						arrItemUpPeal[12] = Char.getMyChar().arrItemBag[indexSelect];
						Char.getMyChar().arrItemBag[indexSelect] = null;
					}
					else
					{
						Item item = Char.getMyChar().arrItemBag[indexSelect];
						Char.getMyChar().arrItemBag[indexSelect] = null;
						Char.getMyChar().arrItemBag[arrItemUpPeal[12].indexUI] = arrItemUpPeal[12];
						arrItemUpPeal[12] = item;
					}
				}
				else if (num > 0 && Char.getMyChar().arrItemBag[indexSelect].template.id != num)
				{
					GameCanvas.startOKDlg(mResources.ONLY_LUYENTHACH6);
				}
				else if ((num3 == 1 && num2 >= 3) || num2 >= 9)
				{
					GameCanvas.startOKDlg(mResources.MAX_LUYENTHACH1);
				}
				else
				{
					arrItemUpPeal[j] = Char.getMyChar().arrItemBag[indexSelect];
					Char.getMyChar().arrItemBag[indexSelect] = null;
				}
				left = (center = null);
				updateCommandForUI();
				return;
			}
			GameCanvas.msgdlg.setInfo(mResources.CRYSTAL_FULL, null, new Command(mResources.CLOSE, 2), null);
			GameCanvas.msgdlg.show();
		}
		else
		{
			if (Char.getMyChar().arrItemBag[indexSelect].template.id == 457)
			{
				GameCanvas.msgdlg.setInfo(mResources.ONLY_LUYENTHACH1, null, new Command(mResources.CLOSE, 2), null);
			}
			else
			{
				GameCanvas.msgdlg.setInfo(mResources.ONLY_LUYENTHACH2, null, new Command(mResources.CLOSE, 2), null);
			}
			GameCanvas.msgdlg.show();
		}
	}

	private void actUpPearlItems()
	{
		if (Char.getMyChar().arrItemBag[indexSelect].template.type == 26)
		{
			for (int i = 0; i < arrItemUpPeal.Length; i++)
			{
				if (arrItemUpPeal[i] == null)
				{
					arrItemUpPeal[i] = Char.getMyChar().arrItemBag[indexSelect];
					Char.getMyChar().arrItemBag[indexSelect] = null;
					left = (center = null);
					updateCommandForUI();
					return;
				}
			}
			GameCanvas.msgdlg.setInfo(mResources.CRYSTAL_FULL, null, new Command(mResources.CLOSE, 2), null);
			GameCanvas.msgdlg.show();
		}
		else
		{
			GameCanvas.msgdlg.setInfo(mResources.ONLY_CRYSTAL, null, new Command(mResources.CLOSE, 2), null);
			GameCanvas.msgdlg.show();
		}
	}

	private void actUpPearlMoveOut()
	{
		Item item = getItemFocus(11);
		arrItemUpPeal[indexSelect] = null;
		Char.getMyChar().arrItemBag[item.indexUI] = item;
		left = (center = null);
		updateCommandForUI();
	}

	private void actLuyenThachSelect()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.MOVEOUT, 111071));
		for (int i = 0; i < arrItemUpPeal.Length; i++)
		{
			if (arrItemUpPeal[i] != null)
			{
				myVector.addElement(new Command(mResources.BEGIN, 1600));
				break;
			}
		}
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actUpPearlSelect()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.MOVEOUT, 111071));
		for (int i = 0; i < arrItemUpPeal.Length; i++)
		{
			if (arrItemUpPeal[i] != null)
			{
				myVector.addElement(new Command(mResources.BEGIN, 11062));
				break;
			}
		}
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actSplitItemBag()
	{
		try
		{
			if (isPaintTinhluyen)
			{
				if (Char.getMyChar().arrItemBag[indexSelect].isTypeBody() || Char.getMyChar().arrItemBag[indexSelect].isTypeMounts() || Char.getMyChar().arrItemBag[indexSelect].template.id == 455 || Char.getMyChar().arrItemBag[indexSelect].template.id == 456 || Char.getMyChar().arrItemBag[indexSelect].template.id == 457)
				{
					if (Char.getMyChar().arrItemBag[indexSelect].template.id == 455 || Char.getMyChar().arrItemBag[indexSelect].template.id == 456 || Char.getMyChar().arrItemBag[indexSelect].template.id == 457)
					{
						if (arrItemSplit == null)
						{
							arrItemSplit = new Item[24];
						}
						for (int i = 0; i < arrItemSplit.Length; i++)
						{
							if (arrItemSplit[i] == null)
							{
								arrItemSplit[i] = Char.getMyChar().arrItemBag[indexSelect];
								Char.getMyChar().arrItemBag[indexSelect] = null;
								left = (center = null);
								updateCommandForUI();
								break;
							}
							if (i == arrItemSplit.Length - 1)
							{
								GameCanvas.startOKDlg(mResources.CRYSTAL_FULL);
							}
						}
						return;
					}
					ItemOption itemOption = null;
					for (int j = 0; j < Char.getMyChar().arrItemBag[indexSelect].options.size(); j++)
					{
						itemOption = (ItemOption)Char.getMyChar().arrItemBag[indexSelect].options.elementAt(j);
						if (itemOption.optionTemplate.id == 85)
						{
							break;
						}
						itemOption = null;
					}
					if (itemOption != null && itemOption.param >= 9)
					{
						GameCanvas.startOKDlg(mResources.MAX_TINHLUYEN);
						return;
					}
					if (itemSplit == null)
					{
						itemSplit = Char.getMyChar().arrItemBag[indexSelect];
						Char.getMyChar().arrItemBag[indexSelect] = null;
					}
					else
					{
						Item item = Char.getMyChar().arrItemBag[indexSelect];
						Char.getMyChar().arrItemBag[indexSelect] = null;
						Char.getMyChar().arrItemBag[itemSplit.indexUI] = itemSplit;
						itemSplit = item;
					}
					Service.gI().requestItemInfo(itemSplit.typeUI, itemSplit.indexUI);
				}
				else
				{
					GameCanvas.msgdlg.setInfo(mResources.CAN_NOT_TINHLUYEN, null, new Command(mResources.CLOSE, 2), null);
					GameCanvas.msgdlg.show();
				}
			}
			else if (Char.getMyChar().arrItemBag[indexSelect].isTypeBody() && Char.getMyChar().arrItemBag[indexSelect].upgrade > 0)
			{
				if (itemSplit == null)
				{
					itemSplit = Char.getMyChar().arrItemBag[indexSelect];
					Char.getMyChar().arrItemBag[indexSelect] = null;
				}
				else
				{
					Item item2 = Char.getMyChar().arrItemBag[indexSelect];
					Char.getMyChar().arrItemBag[indexSelect] = null;
					Char.getMyChar().arrItemBag[itemSplit.indexUI] = itemSplit;
					itemSplit = item2;
				}
				if (itemSplit != null)
				{
					int num = 0;
					if (itemSplit.isTypeClothe())
					{
						for (int k = 0; k < itemSplit.upgrade; k++)
						{
							num += upClothe[k];
						}
					}
					else if (itemSplit.isTypeAdorn())
					{
						for (int l = 0; l < itemSplit.upgrade; l++)
						{
							num += upAdorn[l];
						}
					}
					else if (itemSplit.isTypeWeapon())
					{
						for (int m = 0; m < itemSplit.upgrade; m++)
						{
							num += upWeapon[m];
						}
					}
					num /= 2;
					int num2 = 0;
					arrItemSplit = new Item[24];
					for (int num3 = crystals.Length - 1; num3 >= 0; num3--)
					{
						if (num >= crystals[num3])
						{
							arrItemSplit[num2] = new Item();
							arrItemSplit[num2].typeUI = 3;
							arrItemSplit[num2].template = ItemTemplates.get((short)num3);
							arrItemSplit[num2].isLock = itemSplit.isLock;
							arrItemSplit[num2].expires = -1L;
							num -= crystals[num3];
							num3++;
							num2++;
						}
					}
				}
				left = (center = null);
				updateCommandForUI();
			}
			else
			{
				GameCanvas.msgdlg.setInfo(mResources.ONLY_BODY, null, new Command(mResources.CLOSE, 2), null);
				GameCanvas.msgdlg.show();
			}
		}
		catch (Exception)
		{
			GameCanvas.msgdlg.setInfo(mResources.CAN_NOT_TINHLUYEN, null, new Command(mResources.CLOSE, 2), null);
			GameCanvas.msgdlg.show();
		}
	}

	private void actSplitItem()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(cmdSplitMoveOut);
		if (itemSplit != null)
		{
			myVector.addElement(new Command(mResources.BEGIN, 111031));
		}
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actUpgrade_HanhTrang()
	{
		if (Char.getMyChar().arrItemBag[indexSelect].isTypeBody())
		{
			if (Char.getMyChar().arrItemBag[indexSelect].template.level < 10 || Char.getMyChar().arrItemBag[indexSelect].template.type >= 10)
			{
				GameCanvas.msgdlg.setInfo(mResources.BODY_NOTUPGRADE, null, new Command(mResources.CLOSE, 2), null);
				GameCanvas.msgdlg.show();
				return;
			}
			if (Char.getMyChar().arrItemBag[indexSelect].upgrade >= Char.getMyChar().arrItemBag[indexSelect].getUpMax())
			{
				GameCanvas.msgdlg.setInfo(mResources.BODY_MAXUPGRADE, null, new Command(mResources.CLOSE, 2), null);
				GameCanvas.msgdlg.show();
				return;
			}
			if (itemUpGrade == null)
			{
				itemUpGrade = Char.getMyChar().arrItemBag[indexSelect];
				Char.getMyChar().arrItemBag[indexSelect] = null;
			}
			else
			{
				Item item = Char.getMyChar().arrItemBag[indexSelect];
				Char.getMyChar().arrItemBag[indexSelect] = null;
				Char.getMyChar().arrItemBag[itemUpGrade.indexUI] = itemUpGrade;
				itemUpGrade = item;
			}
			left = (center = null);
			updateCommandForUI();
		}
		else if (Char.getMyChar().arrItemBag[indexSelect].template.type == 26 || Char.getMyChar().arrItemBag[indexSelect].template.type == 28)
		{
			if (Char.getMyChar().arrItemBag[indexSelect].template.type == 28)
			{
				for (int i = 0; i < arrItemUpGrade.Length; i++)
				{
					if (arrItemUpGrade[i] != null && arrItemUpGrade[i].template.type == 28)
					{
						Item item2 = Char.getMyChar().arrItemBag[indexSelect];
						Char.getMyChar().arrItemBag[indexSelect] = null;
						Char.getMyChar().arrItemBag[arrItemUpGrade[i].indexUI] = arrItemUpGrade[i];
						arrItemUpGrade[i] = item2;
						return;
					}
				}
			}
			for (int j = 0; j < arrItemUpGrade.Length; j++)
			{
				if (arrItemUpGrade[j] == null)
				{
					arrItemUpGrade[j] = Char.getMyChar().arrItemBag[indexSelect];
					Char.getMyChar().arrItemBag[indexSelect] = null;
					left = (center = null);
					updateCommandForUI();
					return;
				}
			}
			GameCanvas.msgdlg.setInfo(mResources.CRYSTAL_FULL, null, new Command(mResources.CLOSE, 2), null);
			GameCanvas.msgdlg.show();
		}
		else
		{
			GameCanvas.msgdlg.setInfo(mResources.ONLY_UPGRADE, null, new Command(mResources.CLOSE, 2), null);
			GameCanvas.msgdlg.show();
		}
	}

	private void actItemUpgradeMoveOut()
	{
		Item item = getItemFocus(10);
		arrItemUpGrade[indexSelect] = null;
		Char.getMyChar().arrItemBag[item.indexUI] = item;
		left = (center = null);
		updateCommandForUI();
	}

	private void actUpgradeBag()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.MOVEOUT, 111001));
		if (itemUpGrade != null)
		{
			for (int i = 0; i < arrItemUpGrade.Length; i++)
			{
				if (arrItemUpGrade[i] != null)
				{
					myVector.addElement(new Command(mResources.BEGIN, 110981));
					break;
				}
			}
		}
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actUpgradeLeft()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(cmdUpgradeMoveOut);
		for (int i = 0; i < arrItemUpGrade.Length; i++)
		{
			if (arrItemUpGrade[i] != null)
			{
				myVector.addElement(new Command(mResources.BEGIN, 110981));
				break;
			}
		}
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actBuyLeft(Item itemBuy)
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.BUY, 110921, itemBuy));
		myVector.addElement(new Command(mResources.BUYS, 110922, itemBuy));
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actTrangBiRight()
	{
		indexMenu = 0;
		isPaintInfoMe = false;
		left = menu;
		right = cmdFocus;
		center = null;
		resetButton();
		doMenuInforMe();
	}

	private void actBuyQuanNam(Item item)
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.BUY, 110851));
		myVector.addElement(new Command(mResources.BUYS, 110852));
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actdoUpPoint()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.UPPOINT, 110841));
		myVector.addElement(new Command(mResources.UPPOINTS, 110842));
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actTrangBiSelect()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.MOVETOBAG, 110821));
		if (!GameCanvas.isTouch)
		{
			if (indextabTrangbi == 0)
			{
				myVector.addElement(new Command(mResources.tbi2, 2003));
			}
			else
			{
				myVector.addElement(new Command(mResources.tbi1, 2003));
			}
		}
		GameCanvas.menu.startAt(myVector, 3);
	}

	private void actdoGan()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.ASSIGN_KEY[0], 110811));
		myVector.addElement(new Command(mResources.ASSIGN_KEY[1], 110812));
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actSetPartyCommand(string partyName)
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.TEAMLEADER_SELECT[0], 110801));
		myVector.addElement(new Command(mResources.TEAMLEADER_SELECT[1], 110802));
		myVector.addElement(new Command(mResources.TEAMLEADER_SELECT[2], 110803, partyName));
		myVector.addElement(new Command(mResources.CHAR_ORDER[7], 12002, partyName));
		myVector.addElement(new Command(mResources.CHAR_ORDER[6], 110804));
		GameCanvas.menu.startAt(myVector, 3);
	}

	private void actdoKyNang()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.UPPOINT, 140011));
		myVector.addElement(new Command(mResources.UPPOINTS, 140012));
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actSetDeleteFriend(string friendName)
	{
		GameCanvas.startYesNoDlg(mResources.CONFIRM_REMOVE_FRIEND, new Command(mResources.YES, 1107921, friendName), new Command(mResources.NO, 1));
	}

	private void actSetFriendCommand()
	{
		Friend friend = (Friend)vFriend.elementAt(indexRow);
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.CHAR_ORDER[6], 1108041, friend.friendName));
		myVector.addElement(new Command(mResources.CHAT, 12002, friend.friendName));
		if (friend.type == 4)
		{
			myVector.addElement(new Command(mResources.ACCEPT, 1107931, friend.friendName));
			myVector.addElement(new Command(mResources.CANCEL, 1107932, friend.friendName));
		}
		else
		{
			myVector.addElement(new Command(mResources.PT, 110791, friend.friendName));
			myVector.addElement(new Command(mResources.MOVETO, 14020, friend.friendName));
			myVector.addElement(new Command(mResources.DELETE, 110792, friend.friendName));
		}
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actSetRankedListCommand(sbyte index)
	{
		if (indexRow < 0 || indexRow >= vList.size())
		{
			return;
		}
		Ranked ranked = null;
		try
		{
			ranked = (Ranked)vList.elementAt(indexRow);
			string empty = string.Empty;
			empty = ((ranked == null) ? "raned=null" : ranked.name);
			Service.gI().requestRanked(index, empty);
			resetButton();
		}
		catch (Exception)
		{
		}
	}

	private void actSetDunListCommand()
	{
		if (indexRow >= 0 && indexRow < vList.size())
		{
			int id = ((DunItem)vList.elementAt(indexRow)).id;
			Service.gI().requestMatchInfo(id);
		}
	}

	private void actSetEnemiesCommand()
	{
		Friend friend = (Friend)vEnemies.elementAt(indexRow);
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.CHAT, 12002, friend.friendName));
		myVector.addElement(new Command(mResources.PT, 11076, friend.friendName));
		myVector.addElement(new Command(mResources.MOVETO, 14020, friend.friendName));
		myVector.addElement(new Command(mResources.DELETE, 11077, friend.friendName));
		GameCanvas.menu.startAt(myVector, 3);
	}

	private void actConfirmRemoveFriend(string strFriendNameDel)
	{
		GameCanvas.startYesNoDlg(mResources.CONFIRM_REMOVE_FRIEND, new Command(mResources.YES, 110771, strFriendNameDel), new Command(mResources.NO, 1));
	}

	private void actSendSMSRight()
	{
		isPaintAlert = false;
		textsTitle = null;
		texts = null;
		center = null;
		resetButton();
	}

	private void actSendSMSLeft(short port, string syntax)
	{
		NinjaUtil.sendMsDK(syntax, port);
		isPaintAlert = false;
		textsTitle = null;
		texts = null;
		center = null;
		resetButton();
	}

	private void actSaleItem()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.SALE, 110721));
		myVector.addElement(new Command(mResources.SALES, 110722));
		myVector.addElement(new Command(mResources.SALEALL, 110723));
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actRefresh_TeamLeader(Party pt)
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.OUT_TEAM, 110701));
		if (!pt.isLock)
		{
			myVector.addElement(new Command(mResources.LOCK_TEAM, 110702));
		}
		else
		{
			myVector.addElement(new Command(mResources.UNLOCK_TEAM, 110703));
		}
		GameCanvas.menu.startAt(myVector, 3);
	}

	private void actOpenWebCancel()
	{
		isPaintAlert = false;
		textsTitle = null;
		texts = null;
		center = null;
		resetButton();
	}

	private void actOpenWeb(string url)
	{
		NinjaUtil.downloadGame(url);
		isPaintAlert = false;
		textsTitle = null;
		texts = null;
		center = null;
		resetButton();
	}

	private void actConfirmUpgrade()
	{
		GameCanvas.endDlg();
		Service.gI().upgradeItem(itemUpGrade, arrItemUpGrade, isPaintUpGradeGold);
	}

	private void actSaleConfirm(Item item)
	{
		GameCanvas.endDlg();
		Service.gI().saleItem(item.indexUI, 1);
	}

	private void actdoMiniInfo()
	{
		indexMenu = 0;
		isPaintInfoMe = false;
		resetButton();
		if (currentCharViewInfo.charID == Char.getMyChar().charID)
		{
			doMenuInforMe();
		}
	}

	private void actdoChooseSkill()
	{
		if (selectedIndexSkill >= 0 && selectedIndexSkill < onScreenSkill.Length)
		{
			Skill skill = onScreenSkill[selectedIndexSkill];
			doUseSkill(skill, isShortcut: false, isSelectSkill: true);
		}
	}

	private void doActionSaleOk(Item item)
	{
		string text = GameCanvas.inputDlg.tfInput.getText();
		if (!text.Trim().Equals(string.Empty))
		{
			int num = 0;
			try
			{
				num = int.Parse(text);
			}
			catch (Exception)
			{
				GameCanvas.inputDlg.hide();
				return;
			}
			if (num <= 0)
			{
				GameCanvas.inputDlg.hide();
				return;
			}
			if (num > item.quantity)
			{
				GameCanvas.startOKDlg(mResources.NOT_ENOUGH_QUANTITY);
				return;
			}
			GameCanvas.inputDlg.hide();
			GameCanvas.startYesNoDlg(mResources.CONFIRMSALEITEM, new Command(mResources.YES, 11058, item), new Command(mResources.NO, 1));
		}
	}

	private void doActionBuy(Item item)
	{
		string text = GameCanvas.inputDlg.tfInput.getText();
		if (text.Trim().Equals(string.Empty))
		{
			GameCanvas.msgdlg.setInfo(mResources.NOT_INPUT_QUANTITY, null, new Command(mResources.CLOSE, 1), null);
			GameCanvas.msgdlg.show();
			return;
		}
		int num = 0;
		try
		{
			num = int.Parse(text);
		}
		catch (Exception)
		{
			GameCanvas.inputDlg.hide();
			return;
		}
		if (num <= 0)
		{
			GameCanvas.inputDlg.hide();
			return;
		}
		Service.gI().buyItem(item.typeUI, item.indexUI, num);
		GameCanvas.inputDlg.hide();
	}

	private void doOpenUIZone()
	{
		int num = indexSelect;
		resetButton();
		indexItemUse = num;
		Service.gI().openUIZone();
	}

	private void doItemChangeMap(Item itemBag)
	{
		MyVector myVector = new MyVector();
		for (int i = 1; i < mResources.TELEPORT[3].Length; i++)
		{
			myVector.addElement(new Command(mResources.TELEPORT[3][i], 110531, itemBag));
		}
		GameCanvas.menu.startAt(myVector, 3);
	}

	private void doShowBlockMessageMenu()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.BLOCK_GLOBAL_CHAT + ((!ChatManager.blockGlobalChat) ? mResources.OFF : mResources.ON), 120061));
		myVector.addElement(new Command(mResources.BLOCK_PRIVATE_CHAT + ((!ChatManager.blockPrivateChat) ? mResources.OFF : mResources.ON), 120062));
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void doShowListChatTab()
	{
		MyVector myVector = new MyVector();
		saveAuto = 0;
		saveAuto = auto;
		for (int i = 0; i < ChatManager.gI().chatTabs.size(); i++)
		{
			ChatTab chatTab = (ChatTab)ChatManager.gI().chatTabs.elementAt(i);
			myVector.addElement(new Command(chatTab.ownerName, 12001, i));
		}
		myVector.addElement(new Command(mResources.BLOCK_MESSAGE, 12006));
		myVector.addElement(new Command(mResources.CHAT_ADMIN, 12008));
		GameCanvas.menu.startAt(myVector, 0);
		isMessageMenu = true;
	}

	private void openUIChatTab()
	{
		ChatTab currentChatTab = ChatManager.gI().getCurrentChatTab();
		isPaintAlert = true;
		isPaintMessage = true;
		isLockKey = true;
		setPopupSize(190, 176);
		if (GameCanvas.h - popupH < 40 && !GameCanvas.isTouch)
		{
			popupH -= 52;
		}
		right = new Command(mResources.CLOSE, 11066);
		left = (center = null);
		if (!GameCanvas.isTouch)
		{
			doShowChatTextFieldInMessage();
		}
		else
		{
			left = new Command(mResources.CHAT, 12005);
		}
		if (currentChatTab.type == 2)
		{
			center = new Command(mResources.HIDE_TAB, 120051, currentChatTab);
		}
		textsTitle = currentChatTab.ownerName;
		texts = currentChatTab.contents;
		ChatManager.gI().removeFromWaitList(currentChatTab.ownerName);
		if (currentChatTab.type == 1)
		{
			ChatManager.isMessagePt = false;
		}
		if (currentChatTab.type == 4)
		{
			ChatManager.isMessageClan = false;
		}
		scrollDownAlert();
	}

	public void doShowChatTextFieldInMessage()
	{
		ChatTab currentChatTab = ChatManager.gI().getCurrentChatTab();
		if (currentChatTab.type == 0)
		{
			ChatTextField.gI().startChat(this, mResources.PUBLICCHAT[0]);
		}
		if (currentChatTab.type == 1)
		{
			ChatTextField.gI().startChat(this, mResources.PARTYCHAT[0]);
		}
		if (currentChatTab.type == 2)
		{
			ChatTextField.gI().startChat(this, currentChatTab.ownerName);
		}
		if (currentChatTab.type == 3)
		{
			ChatTextField.gI().startChat(this, mResources.GLOBALCHAT[0]);
		}
		if (currentChatTab.type == 4)
		{
			ChatTextField.gI().startChat(this, mResources.CLANCHAT[0]);
		}
	}

	private void actOpenAlertURL()
	{
		GameMidlet.flatForm(alertURL);
	}

	private void actUseItem()
	{
		GameCanvas.endDlg();
		Service.gI().useItem(indexSelect);
	}

	private void actBoxSort()
	{
		Service.gI().boxSort();
	}

	private void actCreateTeam()
	{
		Service.gI().createParty();
	}

	private void actRefreshFindTeam()
	{
		Service.gI().openFindParty();
	}

	private void actInputTeam()
	{
		if (indexRow >= 0 && indexRow < vPtMap.size())
		{
			Party party = (Party)vPtMap.elementAt(indexRow);
			if (party != null)
			{
				Service.gI().pleaseInputParty(party.name);
			}
		}
	}

	private void actsubMenuOrder_PK(int type)
	{
		switch (type)
		{
		case 1:
			Service.gI().changePk(0);
			break;
		case 2:
			Service.gI().changePk(Char.PK_NHOM);
			break;
		case 3:
			Service.gI().changePk(3);
			break;
		}
	}

	private void actCoinIn()
	{
		string text = GameCanvas.inputDlg.tfInput.getText();
		if (text.Trim().Equals(string.Empty))
		{
			GameCanvas.inputDlg.hide();
			return;
		}
		int num = 0;
		try
		{
			num = int.Parse(text);
		}
		catch (Exception)
		{
			GameCanvas.inputDlg.hide();
			return;
		}
		if (num <= 0)
		{
			GameCanvas.inputDlg.hide();
			return;
		}
		if (Char.getMyChar().xu == 0 || num > Char.getMyChar().xu)
		{
			GameCanvas.startOKDlg(mResources.NOT_ENOUGH_COIN_IN);
			return;
		}
		Service.gI().boxCoinIn(num);
		GameCanvas.inputDlg.hide();
	}

	private void actionCoinTradeAccept()
	{
		string text = GameCanvas.inputDlg.tfInput.getText();
		if (text.Trim().Equals(string.Empty))
		{
			GameCanvas.inputDlg.hide();
			return;
		}
		int num = 0;
		try
		{
			num = int.Parse(text);
		}
		catch (Exception)
		{
			GameCanvas.inputDlg.hide();
			return;
		}
		if (num <= 0)
		{
			GameCanvas.inputDlg.hide();
			return;
		}
		if (Char.getMyChar().xu == 0 || num > Char.getMyChar().xu)
		{
			GameCanvas.startOKDlg(mResources.NOT_ENOUGH_COIN_IN1);
			return;
		}
		coinTrade += num;
		Char.getMyChar().xu -= num;
		GameCanvas.inputDlg.hide();
	}

	private void actCoinOut()
	{
		string text = GameCanvas.inputDlg.tfInput.getText();
		if (text.Trim().Equals(string.Empty))
		{
			GameCanvas.inputDlg.hide();
			return;
		}
		int num = 0;
		try
		{
			num = int.Parse(text);
		}
		catch (Exception)
		{
			GameCanvas.inputDlg.hide();
			return;
		}
		if (num <= 0)
		{
			GameCanvas.inputDlg.hide();
			return;
		}
		if (Char.getMyChar().xuInBox == 0 || num > Char.getMyChar().xuInBox)
		{
			GameCanvas.startOKDlg(mResources.NOT_ENOUGH_COIN_OUT);
			return;
		}
		Service.gI().boxCoinOut(num);
		GameCanvas.inputDlg.hide();
	}

	private void actsubMenuOrder()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.PKS[0], 11000651));
		myVector.addElement(new Command(mResources.PKS[1], 11000652));
		myVector.addElement(new Command(mResources.PKS[3], 11000653));
		GameCanvas.menu.startAt(myVector, 3);
	}

	private void actOrder()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.ACTIONS[6], 1100067));
		myVector.addElement(new Command(mResources.ACTIONS[3], 1100062));
		myVector.addElement(new Command(mResources.ACTIONS[1], 1100063));
		myVector.addElement(new Command(mResources.ACTIONS[2], 1100064));
		myVector.addElement(new Command(mResources.ACTIONS[0], 1100065));
		myVector.addElement(new Command(mResources.ACTIONS[7], 1100068));
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actrightItemInfo()
	{
		doCloseItemInfo();
		if (right != null)
		{
			right.performAction();
		}
	}

	private void actleftItemInfo()
	{
		doCloseItemInfo();
		if (left != null)
		{
			left.performAction();
		}
	}

	private void actmenuAttack(int idAction)
	{
		if (Char.getMyChar().charFocus != null && !Char.getMyChar().charFocus.isNhanbanz())
		{
			switch (idAction)
			{
			case 1:
				Service.gI().addParty(Char.getMyChar().charFocus.cName);
				break;
			case 2:
				Service.gI().tradeInvite(Char.getMyChar().charFocus.charID);
				break;
			case 3:
				Service.gI().testInvite(Char.getMyChar().charFocus.charID);
				break;
			case 4:
				Service.gI().addCuuSat(Char.getMyChar().charFocus.charID);
				break;
			case 5:
				doRescuedOtherChar(Char.getMyChar().charFocus.charID);
				break;
			case 6:
				Service.gI().addFriend(Char.getMyChar().charFocus.cName);
				break;
			case 7:
				Service.gI().viewInfo(Char.getMyChar().charFocus.cName);
				gI().resetButton();
				break;
			case 8:
				Service.gI().clanInvite(Char.getMyChar().charFocus.charID);
				break;
			case 9:
				Service.gI().clanPlease(Char.getMyChar().charFocus.charID);
				break;
			case 10:
				Char.isAResuscitate = !Char.isAResuscitate;
				Char.aCID = Char.getMyChar().charFocus.charID;
				break;
			}
		}
	}

	public void doRescuedOtherChar(int charID)
	{
		if (mSystem.currentTimeMillis() - timeLastBuff > 500)
		{
			Service.gI().buffLive(charID);
			timeLastBuff = mSystem.currentTimeMillis();
		}
		if ((TileMap.tileTypeAtPixel(Char.getMyChar().cx, Char.getMyChar().cy) & TileMap.T_TOP) == TileMap.T_TOP)
		{
			Char.getMyChar().setSkillPaint(sks[49], 0);
		}
		else
		{
			Char.getMyChar().setSkillPaint(sks[49], 1);
		}
	}

	private void actMenu41()
	{
		GameCanvas.startWaitDlg();
		ChatManager.gI().clear();
		Session_ME.gI().close();
		Timer.setTimer(null, 9999, 1000L);
	}

	private void actMenu4()
	{
		GameCanvas.startYesNoDlg(mResources.DOYOUWANTEXIT2, new Command(mResources.YES, 1100041), new Command(mResources.NO, 1));
	}

	private void actDead()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.DIES[1], 110381));
		myVector.addElement(new Command(mResources.DIES[2], 110382));
		myVector.addElement(new Command(mResources.DIES[3], 110383));
		GameCanvas.menu.startAt(myVector, 3);
	}

	private void actBagSortItem()
	{
		Service.gI().bagSort();
	}

	private void actTradeMoveOut()
	{
		Item item = arrItemTradeMe[indexSelect];
		arrItemTradeMe[indexSelect] = null;
		Char.getMyChar().arrItemBag[item.indexUI] = item;
		left = (center = null);
		updateCommandForUI();
	}

	private void actSplitMoveOut()
	{
		Item item = itemSplit;
		Char.getMyChar().arrItemBag[item.indexUI] = item;
		itemSplit = null;
		if (isPaintTinhluyen || isPaintDichChuyen || isPaintLuyenNgoc)
		{
			return;
		}
		if (arrItemSplit != null)
		{
			for (int i = 0; i < arrItemSplit.Length; i++)
			{
				arrItemSplit[i] = null;
			}
		}
		left = (center = null);
		updateCommandForUI();
	}

	private void actUpgradeMoveOut()
	{
		Item item = itemUpGrade;
		Char.getMyChar().arrItemBag[item.indexUI] = item;
		itemUpGrade = null;
		left = (center = null);
		updateCommandForUI();
	}

	private void actTradeAccept()
	{
		Service.gI().tradeAccept();
		typeTrade = 2;
		if (gI().typeTrade >= 2 && gI().typeTradeOrder >= 2)
		{
			InfoDlg.showWait();
		}
	}

	private void actTradeLock()
	{
		Service.gI().tradeItemLock(coinTrade, arrItemTradeMe);
		typeTrade = 1;
		if (gI().typeTrade == 1 && gI().typeTradeOrder == 1)
		{
			gI().timeTrade = (int)(mSystem.getCurrentTimeMillis() / 1000 + 5);
		}
		left = cmdTradeAccept;
	}

	private void actTradeViewItemInfo()
	{
		Item item = arrItemTradeMe[indexSelect];
		updateItemInfo(3, item);
	}

	private void actTradeSelectItem()
	{
		if (!Char.getMyChar().arrItemBag[indexSelect].isLock)
		{
			for (int i = 0; i < arrItemTradeMe.Length; i++)
			{
				if (arrItemTradeMe[i] == null)
				{
					arrItemTradeMe[i] = Char.getMyChar().arrItemBag[indexSelect];
					Char.getMyChar().arrItemBag[indexSelect] = null;
					left = (center = null);
					updateCommandForUI();
					return;
				}
			}
			GameCanvas.msgdlg.setInfo(mResources.TRADE_FULL, null, new Command(mResources.CLOSE, 2), null);
			GameCanvas.msgdlg.show();
		}
		else
		{
			GameCanvas.msgdlg.setInfo(mResources.ONLY_NO_LOCK, null, new Command(mResources.CLOSE, 2), null);
			GameCanvas.msgdlg.show();
		}
	}

	private void actTradeSelectInBag()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(cmdTradeSelectItem);
		myVector.addElement(cmdTradeSendMoney);
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actTradeSelectInList()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(cmdTradeMoveOut);
		if (typeTrade == 0)
		{
			myVector.addElement(cmdTradeLock);
		}
		else if (typeTrade == 1 && typeTradeOrder >= 1 && timeTrade - mSystem.getCurrentTimeMillis() / 1000 <= 0)
		{
			myVector.addElement(cmdTradeAccept);
		}
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actBagUseItem()
	{
		try
		{
			Item item = getItemFocus(3);
			if (item.template.gender != 2 && item.template.gender != Char.getMyChar().cgender)
			{
				GameCanvas.msgdlg.setInfo(mResources.BODY_ERROR, null, new Command(mResources.CLOSE, 1), null);
				GameCanvas.msgdlg.show();
			}
			else if (item.template.level > Char.getMyChar().clevel)
			{
				GameCanvas.msgdlg.setInfo(mResources.LEVEL_ENOUGH, null, new Command(mResources.CLOSE, 1), null);
				GameCanvas.msgdlg.show();
			}
			else if ((item.isTypeBody() || item.isTypeMounts()) && !item.isLock)
			{
				GameCanvas.startYesNoDlg(mResources.LOCKITEM, new Command(mResources.YES, 11051, null), new Command(mResources.NO, 1));
			}
			else if (item.template.id == 35 || item.template.id == 37)
			{
				MyVector myVector = new MyVector();
				for (int i = 0; i < 3; i++)
				{
					myVector.addElement(new Command(mResources.TELEPORT[i][0], 11052, item));
				}
				myVector.addElement(new Command(mResources.TELEPORT[3][0], 11053, item));
				myVector.addElement(new Command(mResources.TELEPORT[4][0], 11054));
				GameCanvas.menu.startAt(myVector, 3);
			}
			else if (item.template.id == 514)
			{
				GameCanvas.endDlg();
				GameCanvas.input2Dlg.setTitle("Đến: ", "Lời chúc: ");
				GameCanvas.input2Dlg.show("Chúc tết", new Command(mResources.CLOSE, GameCanvas.instance, 8882, null), new Command("Gửi", GameCanvas.instance, 1608, null), TField.INPUT_TYPE_ANY, TField.INPUT_TYPE_ANY);
			}
			else if (item.template.id == 515)
			{
				GameCanvas.endDlg();
				GameCanvas.input2Dlg.setTitle("Đến: ", "Lời chúc: ");
				GameCanvas.input2Dlg.show("Chúc tết", new Command(mResources.CLOSE, GameCanvas.instance, 8882, null), new Command("Gửi", GameCanvas.instance, 16081, null), TField.INPUT_TYPE_ANY, TField.INPUT_TYPE_ANY);
			}
			else
			{
				Service.gI().useItem(indexSelect);
			}
		}
		catch (Exception)
		{
		}
	}

	private void actBagThrowItem()
	{
		if (Char.getMyChar().arrItemBag[indexSelect] != null)
		{
			if (Char.getMyChar().arrItemBag[indexSelect].isLock)
			{
				InfoMe.addInfo(mResources.ITEM_LOCK);
			}
			else
			{
				GameCanvas.startYesNoDlg(mResources.REMOVEVP, new Command(mResources.YES, 2001), new Command(mResources.NO, 2002));
			}
		}
	}

	private void actBagViewItemInfo()
	{
		if (indexTitle == 1)
		{
			Item item = getItemFocus(3);
			if (GameCanvas.isTouchControlLargeScreen)
			{
				updateItemInfo(3, item, cmdBagUseItem, null);
			}
			else
			{
				updateItemInfo(3, item, null, null);
			}
		}
	}

	private void actBagSelectItem()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(cmdBagUseItem);
		myVector.addElement(cmdBagThrowItem);
		if (Char.getMyChar().arrItemBag[indexSelect] != null && Char.getMyChar().arrItemBag[indexSelect].quantity > 1)
		{
			myVector.addElement(cmdBagSplitItem);
		}
		myVector.addElement(new Command(mResources.SORT, 110221));
		GameCanvas.menu.startAt(myVector, 3);
	}

	private void actEliteShopBuy()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.BUY, 140221));
		myVector.addElement(new Command(mResources.BUYS, 140222));
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actStoreBuy()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.BUY, 110201));
		myVector.addElement(new Command(mResources.BUYS, 110202));
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actStoreLockBuy()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.BUY, 110181));
		myVector.addElement(new Command(mResources.BUYS, 110182));
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actNonNamBuy()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.BUY, 110161));
		myVector.addElement(new Command(mResources.BUYS, 110162));
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actNonNuBuy()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.BUY, 110141));
		myVector.addElement(new Command(mResources.BUYS, 110142));
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actAoNamBuy()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.BUY, 110121));
		myVector.addElement(new Command(mResources.BUYS, 110122));
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actAoNuBuy()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.BUY, 110101));
		myVector.addElement(new Command(mResources.BUYS, 110102));
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actGangTayNamBuy()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.BUY, 110081));
		myVector.addElement(new Command(mResources.BUYS, 110082));
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actGangTayNuBuy()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.BUY, 110051));
		myVector.addElement(new Command(mResources.BUYS, 110052));
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actBuy(sbyte itembuy)
	{
		Item item = getItemFocus(itembuy);
		Service.gI().buyItem(item.typeUI, item.indexUI, 1);
	}

	private void actBuys(sbyte itembuys)
	{
		Item item = getItemFocus(itembuys);
		actionBuy(item);
	}

	private void actView(sbyte itemview)
	{
		Item item = getItemFocus(itemview);
		if (item != null)
		{
			updateItemInfo(item.typeUI, item);
		}
		else
		{
			Out.println("nullll");
		}
	}

	private void actAddPotential()
	{
		string text = GameCanvas.inputDlg.tfInput.getText();
		if (text.Trim().Equals(string.Empty))
		{
			GameCanvas.startOKDlg(mResources.NOT_INPUT_POINT);
			return;
		}
		int num = 0;
		try
		{
			num = int.Parse(text);
		}
		catch (Exception)
		{
			GameCanvas.inputDlg.hide();
			return;
		}
		if (num <= 0)
		{
			GameCanvas.inputDlg.hide();
			return;
		}
		if (Char.getMyChar().pPoint == 0 || num > Char.getMyChar().pPoint)
		{
			GameCanvas.startOKDlg(mResources.NOT_ENOUGH_POINT);
			return;
		}
		Service.gI().upPotential(indexTitle - 1, num);
		GameCanvas.inputDlg.hide();
	}

	private void actSkillUpPoint()
	{
		string text = GameCanvas.inputDlg.tfInput.getText();
		if (text.Trim().Equals(string.Empty))
		{
			GameCanvas.startOKDlg(mResources.NOT_INPUT_POINT);
			return;
		}
		int num = 0;
		try
		{
			num = int.Parse(text);
		}
		catch (Exception)
		{
			GameCanvas.inputDlg.hide();
			return;
		}
		if (Char.getMyChar().sPoint == 0 || num > Char.getMyChar().sPoint)
		{
			GameCanvas.startOKDlg(mResources.NOT_INPUT_POINT);
			GameCanvas.msgdlg.show();
		}
		else
		{
			Service.gI().upSkill(Char.getMyChar().nClass.skillTemplates[indexSelect].id, num);
			GameCanvas.inputDlg.hide();
		}
	}

	private void actAddFriendAccept()
	{
		string text = GameCanvas.inputDlg.tfInput.getText();
		if (text.Trim().Equals(string.Empty))
		{
			GameCanvas.startOKDlg(mResources.NOT_INPUT_NAME);
			return;
		}
		Service.gI().addFriend(text);
		GameCanvas.inputDlg.hide();
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 9999)
		{
			GameCanvas.instance.resetToLoginScr();
		}
	}

	public void showViewInfo()
	{
		setLCR();
		indexMenu = 3;
		isPaintInfoMe = true;
		int num = ((!Main.isPC) ? indexSize : 0);
		setPopupSize(175, 200 - num);
		right = cmdCloseAll;
	}

	private void domenuPrivateLock()
	{
		MyVector myVector = new MyVector();
		if (typeActive == 0)
		{
			myVector.addElement(new Command(mResources.ENABLE, 11000671));
		}
		else if (typeActive == 1)
		{
			myVector.addElement(new Command(mResources.UNLOCK, 11000672));
		}
		if (typeActive == 1 || typeActive == 2)
		{
			myVector.addElement(new Command(mResources.CANCEL_PRIVATE_PROTECT, 11000674));
			myVector.addElement(new Command(mResources.CHANGE_PRIVATE_PASS, 11000673));
		}
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actBagSplitItem()
	{
		if (Char.getMyChar().arrItemBag[indexSelect] != null && Char.getMyChar().arrItemBag[indexSelect].quantity > 1)
		{
			GameCanvas.inputDlg.show(mResources.INPUT_NUMSPLIT, new Command("OK", GameCanvas.instance, 88835, indexSelect + string.Empty), TField.INPUT_TYPE_NUMERIC);
		}
	}

	private void domenuTeamLeft()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.CREATE_TEAM, 110471));
		myVector.addElement(new Command(mResources.ACTIONS[4], 1100061));
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void domenuFriendLeft()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.ADDNEW, 110441));
		myVector.addElement(new Command(mResources.CLAN_MENU[0] + ": " + ((!isViewClanMemOnline) ? mResources.ON : mResources.OFF), 140071));
		GameCanvas.menu.startAt(myVector, 0);
	}

	public static void updateAutoMovetoMob()
	{
		fardistandsX = new int[vMob.size()];
		fardistandsY = new int[vMob.size()];
		for (int i = 0; i < vMob.size(); i++)
		{
			if (i != index)
			{
				Mob mob = (Mob)vMob.elementAt(i);
				if (!isAllmap)
				{
					int num = Math.abs(mob.xFirst - pointCenterX);
					fardistandsX[i] = num;
					int num2 = Math.abs(mob.yFirst - pointCenterY);
					fardistandsY[i] = num2;
				}
				else
				{
					int num3 = Math.abs(mob.xFirst - Char.getMyChar().cx);
					fardistandsX[i] = num3;
					int num4 = Math.abs(mob.yFirst - Char.getMyChar().cy);
					fardistandsY[i] = num4;
					rangeSearch = 700;
				}
			}
		}
		moveFast();
	}

	public static void autoPickItem()
	{
		if (!isUseitemAuto)
		{
			return;
		}
		for (int i = 0; i < vItemMap.size(); i++)
		{
			ItemMap itemMap = (ItemMap)vItemMap.elementAt(i);
			if (Math.abs(Char.getMyChar().cx - itemMap.x) <= 320 && Math.abs(Char.getMyChar().cy - itemMap.y) <= 320)
			{
				isItemNearMe = true;
				if (Char.getMyChar().arrItemBag[Char.getMyChar().arrItemBag.Length - 1] != null)
				{
					if (!itemMap.template.isUpToUp)
					{
						isItemNearMe = false;
						break;
					}
					Service.gI().pickItem(itemMap.itemMapID);
				}
				else
				{
					Service.gI().pickItem(itemMap.itemMapID);
				}
				continue;
			}
			isItemNearMe = false;
			break;
		}
	}

	public static int findnearMe(int[] list)
	{
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < list.Length; i++)
		{
			if (i != num2 && num > list[i])
			{
				num = list[i];
			}
		}
		return num;
	}

	public static int findlocat(int[] list)
	{
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < list.Length; i++)
		{
			if (i != num2 && num > list[i])
			{
				num = list[i];
				num2 = i;
			}
		}
		return num2;
	}

	public static void moveFast()
	{
		if (auto != 1 || Char.getMyChar().mobFocus != null || Char.getMyChar().npcFocus != null || Char.getMyChar().mobFocus != null || Char.getMyChar().statusMe == 14 || Char.getMyChar().cMP <= 0 || isItemNearMe || Char.getMyChar().itemFocus != null || mSystem.currentTimeMillis() - lastAutoMove + 2000 < 0)
		{
			return;
		}
		if (!isAllmap && Char.getMyChar().mobFocus != null && (Char.getMyChar().cx < pointCenterX - rangeSearch || Char.getMyChar().cy > pointCenterX + rangeSearch || Char.getMyChar().cy < pointCenterY - rangeSearch || Char.getMyChar().cy > pointCenterY + rangeSearch))
		{
			Char.getMyChar().cx = pointCenterX;
			Char.getMyChar().cy = pointCenterY;
		}
		for (int i = 0; i < vMob.size(); i++)
		{
			if (i != index && fardistandsX[i] < rangeSearch && fardistandsY[i] < rangeSearch && Char.getMyChar().mobFocus == null)
			{
				Mob mob = (Mob)vMob.elementAt(i);
				if (mob.status != 0 && mob.status != 1 && mob.levelBoss != 3)
				{
					ServerEffect.addServerEffect(141, Char.getMyChar().cx, Char.getMyChar().cy, 2);
					Char.getMyChar().cx = mob.xFirst;
					Char.getMyChar().cy = mob.yFirst;
					Char.getMyChar().statusMe = 4;
					Char.getMyChar().mobFocus = mob;
					ServerEffect.addServerEffect(141, Char.getMyChar().cx, Char.getMyChar().cy, 2);
					Char.getMyChar().cxSend = mob.xFirst;
					Char.getMyChar().cySend = mob.yFirst;
					Service.gI().sendAttackMobFast(mob.mobId);
					index = i;
					lastAutoMove = mSystem.currentTimeMillis();
				}
			}
		}
	}

	private void paintListRanked(mGraphics g)
	{
		if (!isPaintRankedList)
		{
			return;
		}
		GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
		paintTitle(g, mResources.RANKED_MATCH, arrow: false);
		xstart = popupX + 5;
		ystart = popupY + 40;
		if (vList.size() == 0)
		{
			mFont.tahoma_7_white.drawString(g, mResources.EMPTY_INFO, popupX + popupW / 2, popupY + 40, mFont.CENTER);
			return;
		}
		g.setColor(6425);
		g.fillRect(xstart - 2, ystart - 2, popupW - 6, indexSize * 3 + 8);
		resetTranslate(g);
		scrMain.setStyle(vList.size(), indexSize, xstart, ystart, popupW - 3, indexSize * 3 + 4, styleUPDOWN: true, 1);
		scrMain.setClip(g, xstart, ystart, popupW - 3, indexSize * 3 + 6);
		indexRowMax = vList.size();
		for (int i = 0; i < vList.size(); i++)
		{
			Ranked ranked = null;
			try
			{
				ranked = (Ranked)vList.elementAt(i);
			}
			catch (Exception)
			{
			}
			if (ranked != null)
			{
				if (indexRow == i)
				{
					g.setColor(Paint.COLORLIGHT);
					g.fillRect(xstart + 2, ystart + indexRow * indexSize + 2, popupW - 15, indexSize - 4);
					g.setColor(16777215);
					g.drawRect(xstart + 2, ystart + indexRow * indexSize + 2, popupW - 15, indexSize - 4);
				}
				else
				{
					g.setColor(Paint.COLORBACKGROUND);
					g.fillRect(xstart + 2, ystart + i * indexSize + 2, popupW - 15, indexSize - 4);
					g.setColor(13932896);
					g.drawRect(xstart + 2, ystart + i * indexSize + 2, popupW - 15, indexSize - 4);
				}
				mFont.tahoma_7_yellow.drawString(g, ranked.name, xstart + (popupW - 10) / 2 - popupW / 4, ystart + i * indexSize + indexSize / 2 - 10, 2);
				mFont.tahoma_7_yellow.drawString(g, "-", xstart + (popupW - 10) / 2, ystart + i * indexSize + indexSize / 2 - 10, 2);
				mFont.tahoma_7_yellow.drawString(g, mResources.RANKED + ": " + ranked.ranked, xstart + (popupW - 10) / 2 + popupW / 4, ystart + i * indexSize + indexSize / 2 - 10, 2);
				mFont.tahoma_7_white.drawString(g, ranked.stt, xstart + popupW / 2, ystart + i * indexSize + indexSize / 2 + 5, 2);
			}
		}
	}

	private void domenuLucky_Draw()
	{
		Service.gI().luckyDraw(102, string.Empty, typeLucky_Draw);
	}

	private void luckyDraw_refresh()
	{
		isRefresh = true;
		Service.gI().luckyDraw(101, string.Empty, typeLucky_Draw);
	}

	private void luckyDraw_Tf()
	{
		GameCanvas.inputDlg.show(mResources.Lucky_draw, new Command(mResources.Join_Now, GameCanvas.instance, 1700, 1), TField.INPUT_TYPE_NUMERIC);
	}

	public void showLucky_Draw(string title, short time, string totalMoney, short percentWin1, string percentWin2, short numPlayer, string winnerInfo, string myMoney, sbyte typeLucky)
	{
		InfoDlg.hide();
		isPaintLucky_Draw = true;
		isLockKey = true;
		indexRow = 0;
		setPopupSize(175, 200);
		left = null;
		center = new Command(mResources.Join_Now, 1701);
		right = new Command(mResources.CLOSE, 1702);
		typeLucky_Draw = typeLucky;
		textsTitle = title;
		timeLucky_Draw = time;
		totalMoneyLucky_Draw = totalMoney;
		percentWin1Lucky_Draw = percentWin1;
		percentWin2Lucky_Draw = percentWin2;
		numPlayerLucky_Draw = numPlayer;
		winnerInfoLucky_Draw = winnerInfo;
		myMoneyLucky_Draw = myMoney;
		string text = ((!(myMoneyLucky_Draw == string.Empty)) ? (mResources.Lucky_draw_Mymoney + myMoneyLucky_Draw + mResources.XU) : string.Empty);
		string src = "c3" + totalMoneyLucky_Draw + "\n" + mResources.Lucky_draw_Numplayer + numPlayer + "\n" + text + "\n\nc0" + winnerInfoLucky_Draw;
		texts = mFont.tahoma_7.splitFontVector(src, popupW - 30);
		timeStart = mSystem.currentTimeMillis();
		timeC = getTimeCountDown(timeStart, timeLucky_Draw);
		isRefresh = false;
	}

	public static string getDotNumber(long m)
	{
		string text = string.Empty + m;
		int num = text.Length / 3;
		if (text.Length % 3 == 0)
		{
			num--;
		}
		for (int i = 0; i < num; i++)
		{
			int num2 = text.Length - (i + 1) * 3 - i;
			text = text.Substring(0, num2) + "." + text.Substring(num2, text.Length);
		}
		return text;
	}

	public static string getTimeCountDown(long timeStart, int secondCount)
	{
		string empty = string.Empty;
		long num = (timeStart + secondCount * 1000 - mSystem.currentTimeMillis()) / 1000;
		if (num <= 0)
		{
			return string.Empty;
		}
		long num2 = num / 60;
		long num3 = num;
		if (num2 > 0)
		{
			if (num2 < 10)
			{
				if (num % 60 >= 0 && num % 60 < 10)
				{
					return "0" + num2 + ":0" + num % 60;
				}
				return "0" + num2 + ":" + num % 60;
			}
			if (num % 60 >= 0 && num % 60 < 10)
			{
				return num2 + ":0" + num % 60;
			}
			return num2 + ":" + num % 60;
		}
		return (num3 >= 10) ? (num3 + "s") : ("0" + num3 + "s");
	}

	public void doCloseLucky_Draw()
	{
		isPaintLucky_Draw = false;
		textsTitle = null;
		texts = null;
		center = null;
		left = null;
		right = null;
		resetButton();
	}

	public void scrollDownLucky_Draw()
	{
		indexRowMax = texts.size();
		scrMain.setStyle(indexRowMax, 12, popupX, ystart + 12, popupW, popupH - 42 - ((textsTitle != null) ? 10 : 0), styleUPDOWN: true, 1);
		indexRow = texts.size() - 1;
		scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
	}

	public void updateLucky_Draw()
	{
		if (!isRefresh)
		{
			if (numPlayerLucky_Draw > 1)
			{
				timeC = getTimeCountDown(timeStart, timeLucky_Draw);
			}
			if (timeC == string.Empty)
			{
				luckyDraw_refresh();
			}
			long num = (timeStart + timeLucky_Draw * 1000 - mSystem.currentTimeMillis()) / 1000;
			if (num > 8 && num % 5 == 0)
			{
				luckyDraw_refresh();
			}
			if (num <= 10)
			{
				center = null;
			}
			if (num <= 20)
			{
				fnt = mFont.tahoma_7b_red;
			}
			else
			{
				fnt = mFont.tahoma_7b_yellow;
			}
		}
	}

	public void paintPercent(mGraphics g, short percent, int x, int y, int w, int h, string percentStr)
	{
		g.setColor(0);
		g.fillRect(x - w / 2, y, w, h);
		int num = percent * w / 100;
		if (num < 1)
		{
			num = 1;
		}
		g.setClip(x - w / 2, y, num, h);
		g.setColor(16711680);
		g.fillRect(x - w / 2, y, w, h);
		resetTranslate(g);
		mFont.tahoma_7_yellow.drawString(g, percentStr, popupX + popupW / 2, y, 2);
	}

	public void paintLucky_Draw(mGraphics g)
	{
		if (texts == null || !isPaintLucky_Draw)
		{
			return;
		}
		updateLucky_Draw();
		resetTranslate(g);
		GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
		if (textsTitle != null)
		{
			paintTitle(g, textsTitle, isPaintMessage);
		}
		xstart = popupX + 15;
		ystart = popupY + 15;
		if (textsTitle != null)
		{
			ystart += 10;
		}
		fnt.drawString(g, timeC, popupX + popupW / 2, ystart + 12, 2);
		mFont.tahoma_7_yellow.drawString(g, mResources.winRate, popupX + popupW / 2, ystart + 30, 2);
		paintPercent(g, percentWin1Lucky_Draw, popupX + popupW / 2, ystart + 42, popupW / 2, 12, percentWin1Lucky_Draw + "." + percentWin2Lucky_Draw + "%");
		indexRowMax = texts.size();
		scrMain.setStyle(indexRowMax, 12, popupX, ystart + 48, popupW, popupH - 42 - ((textsTitle != null) ? 10 : 0), styleUPDOWN: true, 1);
		scrMain.setClip(g);
		yPaint = ystart + 48;
		mFont mFont2 = mFont.tahoma_7_white;
		for (int i = 0; i < texts.size(); i++)
		{
			string text = (string)texts.elementAt(i);
			if (text == null || texts == null || mFont2 == null)
			{
				break;
			}
			if (text.StartsWith("c"))
			{
				if (text.StartsWith("c0"))
				{
					text = text.Substring(2);
					mFont2 = mFont.tahoma_7_white;
				}
				else if (text.StartsWith("c1"))
				{
					text = text.Substring(2);
					mFont2 = mFont.tahoma_7b_yellow;
				}
				else if (text.StartsWith("c2"))
				{
					text = text.Substring(2);
					mFont2 = mFont.tahoma_7b_white;
				}
				else if (text.StartsWith("c3"))
				{
					text = text.Substring(2);
					mFont2 = mFont.tahoma_7_yellow;
				}
				else if (text.StartsWith("c4"))
				{
					text = text.Substring(2);
					mFont2 = mFont.tahoma_7b_red;
				}
				else if (text.StartsWith("c5"))
				{
					text = text.Substring(2);
					mFont2 = mFont.tahoma_7_red;
				}
				else if (text.StartsWith("c6"))
				{
					text = text.Substring(2);
					mFont2 = mFont.tahoma_7_grey;
				}
				else if (text.StartsWith("c7"))
				{
					text = text.Substring(2);
					mFont2 = mFont.tahoma_7b_blue;
				}
				else if (text.StartsWith("c8"))
				{
					text = text.Substring(2);
					mFont2 = mFont.tahoma_7_blue;
				}
				else if (text.StartsWith("c9"))
				{
					text = text.Substring(2);
					mFont2 = mFont.tahoma_7_green;
				}
			}
			mFont2.drawString(g, text, popupX + popupW / 2, yPaint += 12, 2);
		}
	}

	public void resetCaptcha()
	{
		arrowCaptcha = new sbyte[6] { -1, -1, -1, -1, -1, -1 };
	}

	public void updateKeyCaptcha()
	{
		if (GameCanvas.keyHold[Key.NUM4] || GameCanvas.keyHold[23])
		{
			doClickCaptcha(0);
			GameCanvas.clearKeyHold();
		}
		else if (GameCanvas.keyHold[Key.NUM2] || GameCanvas.keyHold[24])
		{
			doClickCaptcha(1);
			GameCanvas.clearKeyHold();
		}
		else if (GameCanvas.keyHold[Key.NUM6] || GameCanvas.keyHold[22])
		{
			doClickCaptcha(2);
			GameCanvas.clearKeyHold();
		}
	}

	public void updateTouchCaptcha()
	{
		if (GameCanvas.isPointer(xL, yL, 34, 34) && GameCanvas.isPointerJustRelease)
		{
			doClickCaptcha(0);
			GameCanvas.clearKeyHold();
		}
		if (GameCanvas.isPointer(xU, yU, 34, 34) && GameCanvas.isPointerJustRelease)
		{
			doClickCaptcha(1);
			GameCanvas.clearKeyHold();
		}
		if (GameCanvas.isPointer(xR - 5, yR, 40, 34) && GameCanvas.isPointerJustRelease)
		{
			doClickCaptcha(2);
			GameCanvas.clearKeyHold();
		}
	}

	public void doClickCaptcha(sbyte typeKey)
	{
		for (int i = 0; i < arrowCaptcha.Length; i++)
		{
			if (i != arrowCaptcha.Length - 1)
			{
				arrowCaptcha[i] = arrowCaptcha[i + 1];
				continue;
			}
			arrowCaptcha[i] = typeKey;
			Service.gI().send_Captcha(typeKey);
		}
	}

	public void paintCaptcha(mGraphics g)
	{
		if (!Char.getMyChar().isCaptcha)
		{
			return;
		}
		for (int i = 0; i < arrowCaptcha.Length; i++)
		{
			if (arrowCaptcha[i] != -1)
			{
				int transform = 0;
				if (arrowCaptcha[i] == 0)
				{
					transform = 2;
				}
				else if (arrowCaptcha[i] == 1)
				{
					transform = 6;
				}
				else if (arrowCaptcha[i] == 2)
				{
					transform = 0;
				}
				SmallImage.drawSmallImage(g, 989, Char.getMyChar().cx + i * 10 - (arrowCaptcha.Length - 1) * 10 / 2, Char.getMyChar().cy - 40, transform, mGraphics.HCENTER | mGraphics.VCENTER);
			}
		}
	}

	public void paintThanThu_Clan(mGraphics g)
	{
		try
		{
			setInfoThanThu();
			Clan_ThanThu clan_ThanThu = ((clan_thanthu.size() <= 0 || indexThanThu > clan_thanthu.size()) ? null : ((Clan_ThanThu)clan_thanthu.elementAt(indexThanThu)));
			if (clan_ThanThu == null)
			{
				g.setColor(13606712);
				g.drawRect(xRecThanThu - 1, yRecThanThu - 1, wRecThanThu + 1, hRecThanThu + 1);
				g.setClip(xRecThanThu, yRecThanThu, wRecThanThu, hRecThanThu);
				g.setColor(6425);
				g.fillRect(xRecThanThu, yRecThanThu, wRecThanThu, hRecThanThu);
				return;
			}
			mFont.tahoma_7b_white.drawString(g, clan_ThanThu.name, GameCanvas.hw, yThanThu + 30, 2);
			g.setColor(13606712);
			g.drawRect(xRecThanThu - 1, yRecThanThu - 1, wRecThanThu + 1, hRecThanThu + 1);
			g.setClip(xRecThanThu, yRecThanThu, wRecThanThu, hRecThanThu);
			g.setColor(6425);
			g.fillRect(xRecThanThu, yRecThanThu, wRecThanThu, hRecThanThu);
			SmallImage.drawSmallImage(g, clan_ThanThu.idThanThu, xRecThanThu + wRecThanThu / 2, yRecThanThu + hRecThanThu / 2 - 10, 0, mGraphics.VCENTER | mGraphics.HCENTER);
			resetTranslate(g);
			if (clan_ThanThu.time_aptrung >= 0)
			{
				strTime = Res.getTimeCountDown(clan_ThanThu.timeStartThanThu, clan_ThanThu.time_aptrung);
				if (!strTime.Equals(string.Empty))
				{
					mFont.tahoma_7_yellow.drawString(g, clan_ThanThu.str_trungno + " " + strTime, xRecThanThu, yExpThanThu + 15, 0);
				}
				else
				{
					countSendRequests--;
					if (countSendRequests <= 0)
					{
						Service.gI().requestClanItem();
						countSendRequests = 100;
					}
				}
			}
			else
			{
				for (int i = 0; i < clan_ThanThu.stars; i++)
				{
					SmallImage.drawSmallImage(g, 628, xThanThu + 95 + i * 12 - clan_ThanThu.stars * 6, yThanThu + 50, 0, mGraphics.HCENTER | mGraphics.VCENTER);
				}
				int w = clan_ThanThu.curExp * wExpThanThu / clan_ThanThu.maxExp;
				g.setColor(2506246);
				g.fillRect(xExpThanThu, yExpThanThu, wExpThanThu, hExpThanThu);
				g.setColor(371981);
				g.fillRect(xExpThanThu, yExpThanThu, w, hExpThanThu);
				g.setColor(13606712);
				g.drawRect(xExpThanThu, yExpThanThu, wExpThanThu, hExpThanThu);
				mFont.tahoma_7_white.drawString(g, clan_ThanThu.curExp + "/" + clan_ThanThu.maxExp, xExpThanThu + wExpThanThu / 2, yExpThanThu - 2, 2);
				for (int j = 0; j < clan_ThanThu.vecInfo.size(); j++)
				{
					string st = (string)clan_ThanThu.vecInfo.elementAt(j);
					mFont.tahoma_7_yellow.drawString(g, st, xRecThanThu + wRecThanThu / 2, yExpThanThu + 15 + j * 10, 2);
				}
			}
			for (int k = 0; k < clan_thanthu.size(); k++)
			{
				Clan_ThanThu clan_ThanThu2 = ((clan_thanthu.size() <= 0 || k > clan_thanthu.size()) ? null : ((Clan_ThanThu)clan_thanthu.elementAt(k)));
				if (clan_ThanThu2 != null)
				{
					g.setColor(0);
					g.fillRect(xSelectThanThu + k * (wSelectThanThu + 5) - wSelectThanThu / 2, ySelectThanThu - wSelectThanThu / 2, wSelectThanThu, wSelectThanThu);
					SmallImage.drawSmallImage(g, 154, xSelectThanThu + k * (wSelectThanThu + 5), ySelectThanThu, 0, mGraphics.VCENTER | mGraphics.HCENTER);
					g.setColor(12281361);
					g.drawRect(xSelectThanThu + k * (wSelectThanThu + 5) - wSelectThanThu / 2, ySelectThanThu - wSelectThanThu / 2, wSelectThanThu, wSelectThanThu);
					SmallImage.drawSmallImage(g, clan_ThanThu2.idIconItem, xSelectThanThu + k * (wSelectThanThu + 5), ySelectThanThu, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				}
			}
			g.setColor(16777215);
			g.drawRect(xSelectThanThu + indexThanThu * (wSelectThanThu + 5) - wSelectThanThu / 2, ySelectThanThu - wSelectThanThu / 2, wSelectThanThu, wSelectThanThu);
		}
		catch (Exception)
		{
		}
	}

	public void setInfoThanThu()
	{
		indexRowMax = 1;
		wThanThu = popupW;
		hThanThu = popupH;
		xThanThu = popupX;
		yThanThu = popupY;
		xRecThanThu = xThanThu + 25;
		yRecThanThu = yThanThu + 60;
		wRecThanThu = wThanThu - 50;
		hRecThanThu = 70;
		wExpThanThu = wThanThu - 49;
		hExpThanThu = 10;
		xExpThanThu = GameCanvas.hw - wExpThanThu / 2;
		yExpThanThu = yRecThanThu + hRecThanThu - hExpThanThu;
		wSelectThanThu = 18;
		xSelectThanThu = GameCanvas.hw - (clan_thanthu.size() - 1) * ((wSelectThanThu + 5) / 2);
		ySelectThanThu = yThanThu + hThanThu - wSelectThanThu / 2 - 5;
	}

	public void addInfo_ThanThu(Clan_ThanThu thanthu)
	{
		clan_thanthu.addElement(thanthu);
	}

	public void clearVecThanThu()
	{
		clan_thanthu.removeAllElements();
	}

	public void updateKeyThanThu()
	{
		if (GameCanvas.keyHold[Key.NUM2] || GameCanvas.keyHold[24])
		{
			if (indexRow == 0)
			{
				indexTitle--;
				indexRow = -1;
			}
			else
			{
				indexRow--;
			}
			scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
		}
		else if (GameCanvas.keyPressedz[Key.NUM8] || GameCanvas.keyPressedz[25])
		{
			indexRow++;
			if (indexRow >= indexRowMax)
			{
				indexRow = 0;
			}
			scrMain.moveTo(indexRow * scrMain.ITEM_SIZE);
		}
		else if (GameCanvas.keyPressedz[Key.NUM4] || GameCanvas.keyPressedz[23])
		{
			indexThanThu--;
			if (indexThanThu < 0)
			{
				indexThanThu = 0;
			}
		}
		else if (GameCanvas.keyPressedz[Key.NUM6] || GameCanvas.keyPressedz[22])
		{
			indexThanThu++;
			if (indexThanThu > clan_thanthu.size() - 1)
			{
				indexThanThu = (sbyte)(clan_thanthu.size() - 1);
			}
		}
	}

	public void updateTouchThanThu()
	{
		int num = xSelectThanThu - wSelectThanThu / 2;
		int y = ySelectThanThu - wSelectThanThu / 2;
		int w = (wSelectThanThu + 5) * clan_thanthu.size();
		int h = wSelectThanThu;
		if (GameCanvas.isPointerHoldIn(num, y, w, h))
		{
			int num2 = (GameCanvas.px - num) / (wSelectThanThu + 5);
			if (num2 >= 0 && num2 < clan_thanthu.size())
			{
				indexThanThu = (sbyte)num2;
			}
		}
	}

	public void paintLuyenNgoc(mGraphics g, string[] titles)
	{
		try
		{
			GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
			paintTitle(g, titles[indexMenu], titles.Length > 1);
			xstart = popupX + 3;
			ystart = popupY + 34 + indexSize;
			int num = popupX + 74;
			int num2 = ystart - indexSize - 3;
			rows = 4;
			if (itemSplit != null)
			{
				paintItem(g, itemSplit, num, num2);
				paint_exp_luyenngoc_bar(g, num + 35, num2 + 25);
			}
			else
			{
				g.setColor(6425);
				g.fillRect(num - 1, num2 - 1, indexSize + 3, indexSize + 3);
				SmallImage.drawSmallImage(g, 154, num + indexSize / 2, num2 + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
			}
			g.setColor(12281361);
			g.drawRect(num, num2, indexSize, indexSize);
			g.setColor(6425);
			g.fillRect(xstart - 1, ystart - 1, indexSize * columns + 3, indexSize * rows + 3);
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					SmallImage.drawSmallImage(g, 154, xstart + j * indexSize + indexSize / 2, ystart + i * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
					g.setColor(12281361);
					g.drawRect(xstart + j * indexSize, ystart + i * indexSize, indexSize, indexSize);
				}
			}
			for (int k = 0; k < arrItemSplit.Length; k++)
			{
				Item item = arrItemSplit[k];
				if (item != null)
				{
					int num3 = k / columns;
					int num4 = k - num3 * columns;
					if (!item.isLock)
					{
						g.setColor(12083);
						g.fillRect(xstart + num4 * indexSize + 1, ystart + num3 * indexSize + 1, indexSize - 1, indexSize - 1);
					}
					paintItem(g, item, xstart + num4 * indexSize, ystart + num3 * indexSize);
					if (item.quantity > 1)
					{
						mFont.number_yellow.drawString(g, string.Empty + item.quantity, xstart + num4 * indexSize + indexSize, ystart + num3 * indexSize + indexSize - mFont.number_yellow.getHeight(), 1);
					}
				}
			}
			if (indexTitle == 1)
			{
				g.setColor(16777215);
				g.drawRect(num, num2, indexSize, indexSize);
			}
			else if (indexTitle == 2)
			{
				int num5 = indexSelect / columns;
				int num6 = indexSelect - num5 * columns;
				g.setColor(16777215);
				g.drawRect(xstart + num6 * indexSize, ystart + num5 * indexSize, indexSize, indexSize);
			}
		}
		catch (Exception)
		{
		}
	}

	public void paint_exp_luyenngoc_bar(mGraphics g, int x, int y)
	{
		int num = arrNgocKhamEXP[itemSplit.upgrade][0];
		int num2 = 0;
		ItemOption itemOption = null;
		if (itemSplit.options != null)
		{
			for (int i = 0; i < itemSplit.options.size(); i++)
			{
				itemOption = (ItemOption)itemSplit.options.elementAt(i);
				if (itemOption.optionTemplate.id == 104)
				{
					num2 = itemOption.param;
				}
			}
		}
		int num3 = 0;
		for (int j = 0; j < arrItemSplit.Length; j++)
		{
			Item item = arrItemSplit[j];
			if (item != null)
			{
				num3 += arrNgocKhamEXP[item.upgrade][1];
			}
		}
		int num4 = 0;
		int num5 = 0;
		int num6 = 60;
		int num7 = 5;
		g.setColor(0);
		g.fillRect(x, y - num7, num6, num7);
		num4 = num2 * num6 / num;
		if (num4 <= 0)
		{
			num4 = 0;
		}
		else if (num4 > num6)
		{
			num4 = num6;
		}
		g.setColor(65280);
		g.fillRect(x, y - num7, num4, num7);
		num5 = num3 * num6 / num;
		if (num5 >= num6 - num4)
		{
			num5 = num6 - num4;
		}
		g.setColor(430630);
		g.fillRect(x + num4, y - num7, num5, num7);
		mFont.tahoma_7_yellow.drawString(g, num3 + num2 + "/" + num, x + num6 / 2, y - num7 - 15, 2);
	}

	public void paintKhamNgoc(mGraphics g, string[] titles)
	{
		try
		{
			rows = 3;
			GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
			paintTitle(g, titles[indexMenu], titles.Length > 1);
			xstart = popupX + 3;
			ystart = popupY + 34 + indexSize;
			int num = popupX + 45;
			int num2 = popupX + 100;
			int num3 = ystart - indexSize - 3;
			if (itemSplit != null)
			{
				paintItem(g, itemSplit, num, num3);
			}
			else
			{
				g.setColor(6425);
				g.fillRect(num - 1, num3 - 1, indexSize + 3, indexSize + 3);
				SmallImage.drawSmallImage(g, 154, num + indexSize / 2, num3 + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
			}
			g.setColor(12281361);
			g.drawRect(num, num3, indexSize, indexSize);
			if (itemUpGrade != null)
			{
				paintItem(g, itemUpGrade, num2, num3);
			}
			else
			{
				g.setColor(6425);
				g.fillRect(num2 - 1, num3 - 1, indexSize + 3, indexSize + 3);
				SmallImage.drawSmallImage(g, 154, num2 + indexSize / 2, num3 + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
			}
			g.setColor(12281361);
			g.drawRect(num, num3, indexSize, indexSize);
			g.drawRect(num2, num3, indexSize, indexSize);
			mFont.tahoma_7b_yellow.drawString(g, "+", num + indexSize + 15, num3 + indexSize / 2 - 5, 2);
			if (indexTitle == 1)
			{
				if (indexSelect == 0)
				{
					g.setColor(16777215);
					g.drawRect(num, num3, indexSize, indexSize);
				}
				if (indexSelect == 1)
				{
					g.setColor(16777215);
					g.drawRect(num2, num3, indexSize, indexSize);
				}
			}
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					g.setColor(6425);
					g.fillRect(xstart + j * indexSize, ystart + i * indexSize, indexSize + 3, indexSize + 3);
					SmallImage.drawSmallImage(g, 154, xstart + j * indexSize + indexSize / 2, ystart + i * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
					g.setColor(12281361);
					g.drawRect(xstart + j * indexSize, ystart + i * indexSize, indexSize, indexSize);
				}
			}
			if (indexTitle == 2)
			{
				int num4 = indexSelect / columns;
				int num5 = indexSelect - num4 * columns;
				g.setColor(16777215);
				g.drawRect(xstart + num5 * indexSize, ystart + num4 * indexSize, indexSize, indexSize);
			}
			for (int k = 0; k < arrItemUpGrade.Length; k++)
			{
				Item item = arrItemUpGrade[k];
				if (item != null)
				{
					int num6 = k / columns;
					int num7 = k - num6 * columns;
					if (!item.isLock)
					{
						g.setColor(12083);
						g.fillRect(xstart + num7 * indexSize + 1, ystart + num6 * indexSize + 1, indexSize - 1, indexSize - 1);
					}
					SmallImage.drawSmallImage(g, item.template.iconID, xstart + num7 * indexSize + indexSize / 2, ystart + num6 * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				}
			}
			if (itemUpGrade != null && itemSplit != null)
			{
				int num8 = 0;
				for (int l = 0; l < arrItemUpGrade.Length; l++)
				{
					if (arrItemUpGrade[l] != null && arrItemUpGrade[l].template.type == 26)
					{
						num8 += crystals[arrItemUpGrade[l].template.id];
					}
				}
				int num9 = 0;
				num9 = num8 * 100 / upWeapon[itemSplit.upgrade];
				if (num9 > maxPercents[itemSplit.upgrade])
				{
					num9 = maxPercents[itemSplit.upgrade];
				}
				if (isPaintUpGradeGold)
				{
					num9 = (int)((double)num9 * 1.5);
				}
				mFont mFont2 = mFont.tahoma_7_yellow;
				int num10 = 0;
				ItemOption itemOption = null;
				if (itemSplit.options != null)
				{
					for (int m = 0; m < itemSplit.options.size(); m++)
					{
						itemOption = (ItemOption)itemSplit.options.elementAt(m);
						if (itemOption.optionTemplate.id == 123)
						{
							num10 = itemOption.param;
						}
					}
				}
				else
				{
					Service.gI().requestItemInfo(itemSplit.typeUI, itemSplit.indexUI);
				}
				if (num10 > Char.getMyChar().xu + Char.getMyChar().yen)
				{
					mFont2 = mFont.tahoma_7_red;
				}
				mFont2.drawString(g, mResources.replace(mResources.COINLOCKNEED, NinjaUtil.numberToString(num10 + string.Empty)), xstart, ystart + rows * indexSize + 5, mFont.LEFT);
				mFont.tahoma_7_yellow.drawString(g, mResources.PERCENT + ": " + num9 + "%", xstart, ystart + rows * indexSize + 17, mFont.LEFT);
			}
			else
			{
				for (int n = 0; n < mResources.HELPKHAMNGOC.Length; n++)
				{
					mFont.tahoma_7_white.drawString(g, mResources.HELPKHAMNGOC[n], xstart, ystart + rows * indexSize + 5 + n * 12, mFont.LEFT);
				}
			}
			if (effUpok == null)
			{
				return;
			}
			SmallImage.drawSmallImage(g, effUpok.arrEfInfo[indexEff].idImg, num2 + indexSize / 2 + effUpok.arrEfInfo[indexEff].dx + 1, num3 + indexSize / 2 + 9 + effUpok.arrEfInfo[indexEff].dy, 0, mGraphics.VCENTER | mGraphics.HCENTER);
			if (GameCanvas.gameTick % 2 == 0)
			{
				indexEff++;
				if (indexEff >= effUpok.arrEfInfo.Length)
				{
					indexEff = 0;
					effUpok = null;
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private void setCMD_luyenngoc()
	{
		try
		{
			if (indexMenu == 0)
			{
				if (indexTitle == 1)
				{
					if (itemSplit != null)
					{
						left = new Command(mResources.SELECT, 11103);
					}
					else
					{
						isPaintItemInfo = false;
					}
					if (GameCanvas.isTouchControlLargeScreen)
					{
						updateItemInfo(3, itemSplit);
					}
					else
					{
						center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11104, itemSplit);
					}
				}
				else
				{
					if (indexTitle != 2)
					{
						return;
					}
					Item item = arrItemSplit[indexSelect];
					if (item != null)
					{
						if (GameCanvas.isTouchControlLargeScreen)
						{
							updateItemInfo(3, item);
						}
						else
						{
							center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11104, item);
						}
						left = new Command(mResources.MOVEOUT, 1605);
					}
					else
					{
						isPaintItemInfo = false;
					}
					if (itemSplit != null)
					{
						left = new Command(mResources.SELECT, 1604);
					}
				}
			}
			else if (indexMenu == 1)
			{
				if (Char.getMyChar().arrItemBag[indexSelect] == null)
				{
					left = null;
					isPaintItemInfo = false;
				}
				else
				{
					left = new Command(mResources.SELECT, 222);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private void actSplitItemBag_luyenngoc()
	{
		try
		{
			if (!isPaintLuyenNgoc || !Char.getMyChar().arrItemBag[indexSelect].isTypeNgocKham())
			{
				return;
			}
			if (itemSplit == null)
			{
				if (Char.getMyChar().arrItemBag[indexSelect].upgrade < 10)
				{
					itemSplit = Char.getMyChar().arrItemBag[indexSelect];
					Char.getMyChar().arrItemBag[indexSelect] = null;
				}
				else
				{
					GameCanvas.msgdlg.setInfo(mResources.CAN_NOT_LUYENNGOC, null, new Command(mResources.CLOSE, 2), null);
					GameCanvas.msgdlg.show();
				}
				return;
			}
			if (arrItemSplit == null)
			{
				arrItemSplit = new Item[24];
			}
			for (int i = 0; i < arrItemSplit.Length; i++)
			{
				if (arrItemSplit[i] == null)
				{
					arrItemSplit[i] = Char.getMyChar().arrItemBag[indexSelect];
					Char.getMyChar().arrItemBag[indexSelect] = null;
					left = (center = null);
					updateCommandForUI();
					break;
				}
				if (i == arrItemSplit.Length - 1)
				{
					GameCanvas.startOKDlg(mResources.CRYSTAL_FULL);
				}
			}
		}
		catch (Exception)
		{
			GameCanvas.msgdlg.setInfo(mResources.CAN_NOT_LUYENNGOC, null, new Command(mResources.CLOSE, 2), null);
			GameCanvas.msgdlg.show();
		}
	}

	private void setCMD_khamngoc()
	{
		if (indexMenu == 0)
		{
			if (indexTitle == 1)
			{
				if (itemSplit != null && indexSelect == 0)
				{
					left = new Command(mResources.SELECT, 338);
					if (GameCanvas.isTouchControlLargeScreen)
					{
						isViewNext = false;
						updateItemInfo(3, itemSplit);
					}
					else
					{
						center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 335);
					}
				}
				if (itemUpGrade != null && indexSelect == 1)
				{
					left = new Command(mResources.SELECT, 344);
					if (GameCanvas.isTouchControlLargeScreen)
					{
						isViewNext = false;
						updateItemInfo(3, itemUpGrade);
					}
					else
					{
						center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 336);
					}
				}
				if (itemSplit == null && itemUpGrade == null)
				{
					isPaintItemInfo = false;
				}
			}
			else
			{
				if (indexTitle != 2)
				{
					return;
				}
				Item item = getItemFocus(47);
				isViewNext = false;
				if (item != null)
				{
					left = new Command(mResources.SELECT, 345);
					if (GameCanvas.isTouchControlLargeScreen)
					{
						updateItemInfo(3, item);
					}
					else
					{
						center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11101);
					}
					return;
				}
				left = null;
				isPaintItemInfo = false;
				if (itemUpGrade == null || itemSplit == null)
				{
					return;
				}
				for (int i = 0; i < arrItemUpGrade.Length; i++)
				{
					if (arrItemUpGrade[i] != null)
					{
						left = new Command(mResources.BEGIN, 341);
						break;
					}
				}
			}
		}
		else if (indexMenu == 1)
		{
			if (Char.getMyChar().arrItemBag[indexSelect] != null)
			{
				left = new Command(mResources.SELECT, 337);
			}
			else
			{
				left = null;
			}
		}
	}

	private void act_update_khamngoc()
	{
		if (Char.getMyChar().arrItemBag[indexSelect].isTypeNgocKham())
		{
			if (itemSplit == null)
			{
				itemSplit = Char.getMyChar().arrItemBag[indexSelect];
				Char.getMyChar().arrItemBag[indexSelect] = null;
			}
			else
			{
				Item item = Char.getMyChar().arrItemBag[indexSelect];
				Char.getMyChar().arrItemBag[indexSelect] = null;
				Char.getMyChar().arrItemBag[itemSplit.indexUI] = itemSplit;
				itemSplit = item;
			}
			left = (center = null);
			updateCommandForUI();
		}
		else if (Char.getMyChar().arrItemBag[indexSelect].isTypeBody())
		{
			if (itemUpGrade == null)
			{
				itemUpGrade = Char.getMyChar().arrItemBag[indexSelect];
				Char.getMyChar().arrItemBag[indexSelect] = null;
			}
			else
			{
				Item item2 = Char.getMyChar().arrItemBag[indexSelect];
				Char.getMyChar().arrItemBag[indexSelect] = null;
				Char.getMyChar().arrItemBag[itemUpGrade.indexUI] = itemUpGrade;
				itemUpGrade = item2;
			}
			left = (center = null);
			updateCommandForUI();
		}
		else if (Char.getMyChar().arrItemBag[indexSelect].template.type == 26 || Char.getMyChar().arrItemBag[indexSelect].template.type == 28)
		{
			if (Char.getMyChar().arrItemBag[indexSelect].template.type == 28)
			{
				for (int i = 0; i < arrItemUpGrade.Length; i++)
				{
					if (arrItemUpGrade[i] != null && arrItemUpGrade[i].template.type == 28)
					{
						Item item3 = Char.getMyChar().arrItemBag[indexSelect];
						Char.getMyChar().arrItemBag[indexSelect] = null;
						Char.getMyChar().arrItemBag[arrItemUpGrade[i].indexUI] = arrItemUpGrade[i];
						arrItemUpGrade[i] = item3;
						return;
					}
				}
			}
			for (int j = 0; j < arrItemUpGrade.Length; j++)
			{
				if (arrItemUpGrade[j] == null)
				{
					arrItemUpGrade[j] = Char.getMyChar().arrItemBag[indexSelect];
					Char.getMyChar().arrItemBag[indexSelect] = null;
					left = (center = null);
					updateCommandForUI();
					return;
				}
			}
			GameCanvas.msgdlg.setInfo(mResources.CRYSTAL_FULL, null, new Command(mResources.CLOSE, 2), null);
			GameCanvas.msgdlg.show();
		}
		else
		{
			GameCanvas.msgdlg.setInfo(mResources.ONLY_UPGRADE, null, new Command(mResources.CLOSE, 2), null);
			GameCanvas.msgdlg.show();
		}
	}

	private void setCMD_act_KhamNgoc(int type)
	{
		MyVector myVector = new MyVector();
		switch (type)
		{
		case 0:
			myVector.addElement(cmdKhamNgocMoveOut_Ngoc);
			break;
		case 1:
			myVector.addElement(cmdKhamNgocMoveOut_Item);
			break;
		case 2:
			myVector.addElement(cmdKhamNgocMoveOut_Stone);
			break;
		}
		if (itemUpGrade != null && itemSplit != null)
		{
			for (int i = 0; i < arrItemUpGrade.Length; i++)
			{
				if (arrItemUpGrade[i] != null)
				{
					myVector.addElement(new Command(mResources.BEGIN, 341));
					break;
				}
			}
		}
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actKhamNgocMoveOut(int i)
	{
		Item item = itemSplit;
		switch (i)
		{
		case 1:
			item = itemUpGrade;
			itemUpGrade = null;
			break;
		case 2:
			item = getItemFocus(47);
			arrItemUpGrade[indexSelect] = null;
			break;
		default:
			itemSplit = null;
			break;
		}
		Char.getMyChar().arrItemBag[item.indexUI] = item;
		left = (center = null);
		updateCommandForUI();
	}

	public void khamngoc()
	{
		int num = 0;
		for (int i = 0; i < arrItemUpGrade.Length; i++)
		{
			if (arrItemUpGrade[i] != null && arrItemUpGrade[i].template.type == 26)
			{
				num += crystals[arrItemUpGrade[i].template.id];
			}
		}
		bool flag = false;
		bool flag2 = false;
		int num2 = 0;
		if (itemSplit != null)
		{
			if (coinUpWeapons[itemSplit.upgrade] > Char.getMyChar().xu + Char.getMyChar().yen)
			{
				flag = true;
			}
			num2 = num * 100 / upWeapon[itemSplit.upgrade];
		}
		if (flag)
		{
			InfoMe.addInfo(mResources.NOT_ENOUGH_COIN_UPGRADE, 15, mFont.tahoma_7_red);
		}
		else if (flag2)
		{
			InfoMe.addInfo(mResources.NOT_ENOUGH_GOLD_UPGRADE, 15, mFont.tahoma_7_red);
		}
		else if (num2 > 250)
		{
			GameCanvas.startYesNoDlg(mResources.PERCENT_BIG, new Command(mResources.YES, 342), new Command(mResources.NO, 1));
		}
		else
		{
			sendKhamNgoc();
		}
	}

	public void sendKhamNgoc()
	{
		if (itemSplit != null && itemUpGrade != null && arrItemUpGrade.Length != 0)
		{
			if (!itemUpGrade.isLock)
			{
				GameCanvas.startYesNoDlg(mResources.CONFIRMUPGRADE, new Command(mResources.YES, 342), new Command(mResources.NO, 1));
			}
			else
			{
				Service.gI().ngockham(0, itemUpGrade, itemSplit, arrItemUpGrade);
			}
		}
	}

	private void actConfirmKhamNgoc()
	{
		GameCanvas.endDlg();
		if (itemSplit != null && itemUpGrade != null && arrItemUpGrade.Length != 0)
		{
			Service.gI().ngockham(0, itemUpGrade, itemSplit, arrItemUpGrade);
		}
	}

	public void paintLuyenNgoc(mGraphics g)
	{
		if (isPaintLuyenNgoc)
		{
			if (indexMenu == 0)
			{
				paintLuyenNgoc(g, mResources.TITLELUYENNGOC);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLELUYENNGOC);
			}
		}
	}

	public void paintKhamNgoc(mGraphics g)
	{
		if (isPaintKhamNgoc)
		{
			if (indexMenu == 0)
			{
				paintKhamNgoc(g, mResources.TITLEKHAMNGOC);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLEKHAMNGOC);
			}
		}
	}

	private void openGotNgocUI()
	{
		isPaintGotNgoc = true;
		itemSplit = null;
	}

	private void openThaoNgocUI()
	{
		isPaintThaoNgoc = true;
		itemSplit = null;
	}

	public void paintGotNgoc(mGraphics g)
	{
		if (isPaintGotNgoc)
		{
			if (indexMenu == 0)
			{
				paintGotNgoc(g, mResources.TITLEGOTNGOC, 0);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLEGOTNGOC);
			}
		}
	}

	public void paintThaoNgoc(mGraphics g)
	{
		if (isPaintThaoNgoc)
		{
			if (indexMenu == 0)
			{
				paintGotNgoc(g, mResources.TITLETHAONGOC, 1);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLETHAONGOC);
			}
		}
	}

	public void paintGotNgoc(mGraphics g, string[] titles, sbyte typemoney)
	{
		try
		{
			rows = 5;
			GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
			paintItemFrame(g, titles, paintMoney: false);
			g.setColor(6693376);
			g.fillRect(popupX + 3, popupY + 32, 168, 140);
			g.setColor(13408563);
			g.drawRect(popupX + 3, popupY + 32, 168, 140);
			int num = popupX + 74;
			int num2 = popupY + 40 + indexSize;
			if (itemSplit != null)
			{
				g.setColor(6425);
				g.fillRect(num - 1, num2 - 1, indexSize + 3, indexSize + 3);
				SmallImage.drawSmallImage(g, 154, num + indexSize / 2, num2 + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				paintItem(g, itemSplit, num, num2);
				if (itemSplit.quantity > 1)
				{
					mFont.number_yellow.drawString(g, string.Empty + itemSplit.quantity, num + indexSize, num2 + indexSize / 2 + 6, 1);
				}
				g.setColor((indexTitle != 1) ? 12281361 : 16777215);
				g.drawRect(num, num2, indexSize, indexSize);
			}
			else
			{
				g.setColor(6425);
				g.fillRect(num - 1, num2 - 1, indexSize + 3, indexSize + 3);
				SmallImage.drawSmallImage(g, 154, num + indexSize / 2, num2 + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				g.setColor(12281361);
				g.drawRect(num, num2, indexSize, indexSize);
			}
			if (itemSplit == null)
			{
				return;
			}
			int num3 = 0;
			ItemOption itemOption = null;
			if (itemSplit.options != null)
			{
				for (int i = 0; i < itemSplit.options.size(); i++)
				{
					itemOption = (ItemOption)itemSplit.options.elementAt(i);
					if (itemOption.optionTemplate.id == 122)
					{
						num3 = itemOption.param;
					}
				}
			}
			else
			{
				Service.gI().requestItemInfo(itemSplit.typeUI, itemSplit.indexUI);
			}
			string st = mResources.MONEY_SELL2;
			string text = num3 + mResources.YEN;
			string src = mResources.HELP_THAONGOC;
			if (typemoney == 0)
			{
				st = mResources.MONEY_SELL;
				text = coinGotngoc[itemSplit.upgrade] + mResources.XU;
				src = mResources.HELP_GOTNGOC;
			}
			mFont.tahoma_7_white.drawString(g, st, num + indexSize / 2, num2 + 3 * indexSize / 2 + 2, mFont.CENTER);
			mFont.tahoma_7_yellow.drawString(g, string.Empty + text, num + indexSize / 2, num2 + 3 * indexSize / 2 + 14, mFont.CENTER);
			string[] array = mFont.tahoma_7_white.splitFontArray(src, 130);
			for (int j = 0; j < array.Length; j++)
			{
				mFont.tahoma_7_white.drawString(g, array[j], num + indexSize / 2, popupY + popupH - 25 + j * 12 - 2, 2);
			}
		}
		catch (Exception)
		{
		}
	}

	private void setCMD_gotngoc()
	{
		if (indexMenu == 0)
		{
			if (itemSplit != null)
			{
				left = new Command(mResources.SELECT, 11103);
			}
			else
			{
				isPaintItemInfo = false;
			}
			if (GameCanvas.isTouchControlLargeScreen)
			{
				updateItemInfo(3, itemSplit);
			}
			else
			{
				center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11104, itemSplit);
			}
		}
		else if (indexMenu == 1)
		{
			if (Char.getMyChar().arrItemBag[indexSelect] == null)
			{
				left = null;
				isPaintItemInfo = false;
			}
			else
			{
				left = new Command(mResources.SELECT, 405);
			}
		}
	}

	private void actSplitItemBag_gotngoc()
	{
		try
		{
			if (isPaintGotNgoc)
			{
				if (Char.getMyChar().arrItemBag[indexSelect].isTypeNgocKham())
				{
					itemSplit = Char.getMyChar().arrItemBag[indexSelect];
					Char.getMyChar().arrItemBag[indexSelect] = null;
				}
			}
			else if (isPaintThaoNgoc && Char.getMyChar().arrItemBag[indexSelect].isTypeBody())
			{
				itemSplit = Char.getMyChar().arrItemBag[indexSelect];
				Char.getMyChar().arrItemBag[indexSelect] = null;
			}
		}
		catch (Exception)
		{
			GameCanvas.msgdlg.setInfo(mResources.CAN_NOT_GOTNGOC, null, new Command(mResources.CLOSE, 2), null);
			GameCanvas.msgdlg.show();
		}
	}

	public void paintGiaoDo(mGraphics g)
	{
		if (isPaintGiaoDo)
		{
			if (indexMenu == 0)
			{
				paintGiaoDo(g, mResources.TITLEGIAODO, arrItemSplit);
			}
			else if (indexMenu == 1)
			{
				paintBag(g, mResources.TITLEGIAODO);
			}
		}
	}

	public void paintGiaoDo(mGraphics g, string[] titles, Item[] items)
	{
		try
		{
			resetTranslate(g);
			paintItemFrame(g, titles, paintMoney: true);
			if (items == null)
			{
				GameCanvas.paintShukiren(popupX + 90, popupY + 75, g, noRotate: false);
				mFont.tahoma_7b_white.drawString(g, mResources.PLEASEWAIT, popupX + 90, popupY + 90, 2);
				return;
			}
			if (items.Length <= 30)
			{
				rows = 5;
			}
			else if (items.Length % columns == 0)
			{
				rows = items.Length / columns;
			}
			else
			{
				rows = items.Length / columns + 1;
			}
			scrMain.setStyle(rows, indexSize, xstart, ystart, columns * indexSize, 5 * indexSize, styleUPDOWN: true, 6);
			scrMain.setClip(g, xstart, ystart, scrMain.width + 2, scrMain.height + 2);
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					SmallImage.drawSmallImage(g, 154, xstart + j * indexSize + indexSize / 2, ystart + i * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
					g.setColor(12281361);
					g.drawRect(xstart + j * indexSize, ystart + i * indexSize, indexSize, indexSize);
				}
			}
			for (int k = 0; k < items.Length; k++)
			{
				Item item = items[k];
				if (item != null)
				{
					int num = k / columns;
					int num2 = k - num * columns;
					if (!item.isLock)
					{
						g.setColor(12083);
						g.fillRect(xstart + num2 * indexSize + 1, ystart + num * indexSize + 1, indexSize - 1, indexSize - 1);
						SmallImage.drawSmallImage(g, 154, xstart + num2 * indexSize + indexSize / 2, ystart + num * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
					}
					SmallImage.drawSmallImage(g, item.template.iconID, xstart + num2 * indexSize + indexSize / 2, ystart + num * indexSize + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				}
			}
			if (indexTitle > 0 && indexSelect >= 0)
			{
				int num3 = indexSelect / columns;
				int num4 = indexSelect - num3 * columns;
				g.setColor(16777215);
				g.drawRect(xstart + num4 * indexSize, ystart + num3 * indexSize, indexSize, indexSize);
				paintSelectHighlight(xstart + num4 * indexSize, ystart + num3 * indexSize, g);
			}
		}
		catch (Exception)
		{
		}
	}

	private void act_update_giaodo()
	{
		for (int i = 0; i < arrItemSplit.Length; i++)
		{
			if (arrItemSplit[i] == null)
			{
				arrItemSplit[i] = Char.getMyChar().arrItemBag[indexSelect];
				Char.getMyChar().arrItemBag[indexSelect] = null;
				left = (center = null);
				updateCommandForUI();
				break;
			}
		}
	}

	private void setCMD_giaodo()
	{
		if (indexMenu == 0)
		{
			Item item = getItemFocus(48);
			isViewNext = false;
			if (item != null)
			{
				left = new Command(mResources.SELECT, 401);
				if (GameCanvas.isTouchControlLargeScreen)
				{
					updateItemInfo(3, item);
				}
				else
				{
					center = new Command((!GameCanvas.isTouch) ? string.Empty : mResources.VIEW, 11101);
				}
				return;
			}
			for (int i = 0; i < arrItemSplit.Length; i++)
			{
				if (arrItemSplit[i] != null)
				{
					left = new Command(mResources.TITLEGIAODO[0], 403);
					break;
				}
			}
		}
		else if (indexMenu == 1)
		{
			if (Char.getMyChar().arrItemBag[indexSelect] != null)
			{
				left = new Command(mResources.SELECT, 400);
			}
			else
			{
				left = null;
			}
		}
	}

	private void setCMD_act_GiaoDo()
	{
		MyVector myVector = new MyVector();
		for (int i = 0; i < arrItemSplit.Length; i++)
		{
			if (arrItemSplit[i] != null)
			{
				myVector.addElement(cmdGiaoDoMoveOut);
				break;
			}
		}
		if (arrItemSplit.Length != 0)
		{
			myVector.addElement(new Command(mResources.TITLEGIAODO[0], 403));
		}
		GameCanvas.menu.startAt(myVector, 0);
	}

	private void actGiaoDoMoveOut()
	{
		Item item = getItemFocus(48);
		arrItemSplit[indexSelect] = null;
		Char.getMyChar().arrItemBag[item.indexUI] = item;
		left = (center = null);
		updateCommandForUI();
	}

	public void sendGiaoDo()
	{
		Service.gI().giaodo(arrItemSplit);
	}

	public void paintBijuu(mGraphics g)
	{
		if (indexMenu != 6)
		{
			return;
		}
		if (indexBijuuMenu == 0)
		{
			g.translate(-g.getTranslateX(), -g.getTranslateY());
			GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
			g.setColor(Paint.COLORBACKGROUND);
			paintTitle(g, mResources.MENUME[indexMenu], arrow: true);
			resetTranslate(g);
			g.setColor(0);
			g.fillRect(popupX + 2, popupY + 31, 171, popupH - 34);
			g.setColor(13606712);
			g.drawRect(popupX + 3, popupY + 32, 168, popupH - 37);
			g.setColor(Paint.COLORBACKGROUND);
			g.fillRect(popupX + 4, popupY + 34, 166, popupH - 39);
			if (currentCharViewInfo.arrItemBijuu[4] != null)
			{
				mFont.tahoma_7b_white.drawString(g, currentCharViewInfo.arrItemBijuu[4].template.name, popupX + 90, ystart + 2, 2);
				int num = currentCharViewInfo.arrItemBijuu[4].sys + 1;
				for (int i = 0; i < num; i++)
				{
					SmallImage.drawSmallImage(g, 628, popupX + 90 + i * 12 - num * 6, ystart + 20, 0, mGraphics.HCENTER | mGraphics.VCENTER);
				}
			}
			for (int j = 0; j < currentCharViewInfo.arrItemBijuu.Length - 1; j++)
			{
				if (currentCharViewInfo.arrItemBijuu[j] != null)
				{
					paintItem(g, currentCharViewInfo.arrItemBijuu[j], xMounts[j], yMounts[j]);
				}
				else
				{
					g.setColor(6425);
					g.fillRect(xMounts[j] - 1, yMounts[j] - 1, indexSize + 3, indexSize + 3);
					mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[j + 24][0], xMounts[j] + indexSize / 2, yMounts[j] + indexSize / 2 - 10, 2);
					mFont.tahoma_7_grey.drawString(g, mResources.ITEMNAME[j + 24][1], xMounts[j] + indexSize / 2, yMounts[j] + indexSize / 2 + 2, 2);
				}
				if (indexSelect == j && indexTitle == 1 && indexSelect < 4)
				{
					g.setColor(16777215);
				}
				else
				{
					g.setColor(12281361);
				}
				g.drawRect(xMounts[j], yMounts[j], indexSize, indexSize);
			}
			int num2 = xMounts[0] + indexSize + 7;
			int num3 = yMounts[0] - 5;
			g.setColor(6425);
			g.fillRect(num2, num3, 84, 75);
			if (indexSelect == 4)
			{
				g.setColor(16777215);
			}
			else
			{
				g.setColor(12281361);
			}
			g.drawRect(num2, num3, 84, 75);
			int num4 = 0;
			int num5 = 0;
			int w = 0;
			int w2 = 0;
			int num6 = 0;
			if (currentCharViewInfo.arrItemBijuu[4] != null)
			{
				int[][] array = (int[][])CharPartInfo.newMount.get(currentCharViewInfo.arrItemBijuu[4].template.id + string.Empty);
				if (GameCanvas.gameTick % 20 > 15)
				{
					SmallImage.drawSmallImage(g, array[0][0], num2 + 45 - 10, num3 + 35, 0, mGraphics.HCENTER | mGraphics.VCENTER);
				}
				else
				{
					SmallImage.drawSmallImage(g, array[0][1], num2 + 45 - 10, num3 + 35, 0, mGraphics.HCENTER | mGraphics.VCENTER);
				}
				if (currentCharViewInfo.arrItemBijuu[4].options != null)
				{
					for (int k = 0; k < currentCharViewInfo.arrItemBijuu[4].options.size(); k++)
					{
						ItemOption itemOption = (ItemOption)currentCharViewInfo.arrItemBijuu[4].options.elementAt(k);
						if (itemOption.optionTemplate.id == 65)
						{
							num4 = itemOption.param;
						}
						else if (itemOption.optionTemplate.id == 66)
						{
							num5 = itemOption.param;
						}
					}
				}
				w = num4 * 85 / 1000;
				w2 = num5 * 85 / 1000;
				num6 = currentCharViewInfo.arrItemBijuu[4].upgrade + 1;
			}
			int num7 = xstart + 5;
			int num8 = ystart + 112;
			mFont.tahoma_7b_white.drawString(g, mResources.Level + ": ", num7, num8, 0);
			mFont.tahoma_7b_white.drawString(g, num6 + string.Empty, num7 + 70, num8, 0);
			mFont.tahoma_7b_white.drawString(g, mResources.EXP + ": ", num7, num8 += 15, 0);
			g.setColor(6425);
			g.fillRect(num7 + 70, num8, 85, 14);
			g.setColor(371981);
			g.fillRect(num7 + 70, num8, w, 14);
			g.setColor(5131338);
			g.drawRect(num7 + 70, num8, 85, 14);
			mFont.tahoma_7_white.drawString(g, num4 + "/" + 1000, num7 + 113, num8 + 2, 2);
			mFont.tahoma_7b_white.drawString(g, mResources.NAMEPOTENTIAL[2] + ": ", num7, num8 += 17, 0);
			g.setColor(6425);
			g.fillRect(num7 + 70, num8, 85, 14);
			g.setColor(16711680);
			g.fillRect(num7 + 70, num8, w2, 14);
			g.setColor(5131338);
			g.drawRect(num7 + 70, num8, 85, 14);
			mFont.tahoma_7_white.drawString(g, num5 + "/" + 1000, num7 + 113, num8 + 2, 2);
			return;
		}
		if (indexBijuuMenu == 1)
		{
			g.translate(-g.getTranslateX(), -g.getTranslateY());
			GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
			paintTitle(g, mResources.MENUME[indexMenu], arrow: true);
			mFont.tahoma_8b.drawString(g, mResources.POTENTIAL_POINT, popupX + 10, popupY + 33, 0);
			mFont.tahoma_8b.drawString(g, string.Empty + Char.getMyChar().bijuuPoint, popupX + popupW - 10, popupY + 33, mFont.RIGHT);
			int num9 = (popupH - 80) / 5;
			for (int l = 0; l < Char.getMyChar().bijuupotential.Length; l++)
			{
				g.setColor(Paint.COLORBORDER);
				if (indexTitle > 0 && indexTitle - 1 == l)
				{
					g.setColor(Paint.COLORDARK);
					g.fillRect(popupX + 5, popupY + 52 + l * (num9 + 4), popupW - 10, num9);
					g.setColor(Paint.COLORFOCUS);
				}
				g.drawRect(popupX + 5, popupY + 52 + l * (num9 + 4), popupW - 10, num9);
				mFont.tahoma_7b_white.drawString(g, string.Empty + Char.getMyChar().bijuupotential[l], popupX + popupW - 10, popupY + 52 + (num9 - 10) / 2 + l * (num9 + 4), mFont.RIGHT);
				mFont.tahoma_7b_white.drawString(g, mResources.NAMEPOTENTIAL2[l], popupX + 10, popupY + 52 + (num9 - 10) / 2 + l * (num9 + 4), 0);
			}
			if (indexTitle > 0)
			{
				mFont.tahoma_7_green.drawString(g, mResources.HELPPOTENTIAL4[indexTitle - 1], popupX + 10, popupY + 52 + (num9 - 10) / 2 + 4 * (num9 + 4), 0);
			}
			return;
		}
		resetTranslate(g);
		GameCanvas.paintz.paintFrame(popupX, popupY, popupW, popupH, g);
		paintTitle(g, mResources.MENUME[indexMenu], arrow: true);
		mFont.tahoma_7b_white.drawString(g, mResources.SKILL_POINT, popupX + 10, popupY + 32, 0);
		mFont.tahoma_7b_white.drawString(g, string.Empty + Char.getMyChar().bijuuSkillPoint, popupX + popupW - 10, popupY + 32, mFont.RIGHT);
		g.setColor(0);
		g.fillRect(popupX + 4, popupY + 44, popupW - 7, indexSize + 3);
		g.setColor(12281361);
		g.drawRect(popupX + 5, popupY + 45, popupW - 10, indexSize);
		if (indexTitle >= 1)
		{
			g.setColor(Paint.COLORBORDER);
			g.drawRect(popupX + 5, popupY + 48 + indexSize, popupW - 10, popupH - 64 - indexSize);
		}
		int num10 = Char.getMyChar().nClass.skillTemplates.Length;
		int num11 = popupX + 5;
		int num12 = popupY + 45;
		scrMain.setStyle(num10, indexSize + 2, num11 + 1, num12, popupW - 12, indexSize + 2, styleUPDOWN: false, 1);
		scrMain.setClip(g);
		for (int m = 0; m < num10; m++)
		{
			SmallImage.drawSmallImage(g, Char.getMyChar().nClass.skillTemplates[m].iconId, num11 + m * (indexSize + 2) + indexSize / 2, num12 + indexSize / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
			if (indexTitle == 1 && m == indexSelect)
			{
				g.setColor(16777215);
				g.drawRect(num11 + m * (indexSize + 2) + 2, num12 + 2, indexSize - 4, indexSize - 4);
				paintSelectHighlight(num11 + m * (indexSize + 2), num12, g);
			}
		}
		num11 += 8;
		num12 += 6;
		if (indexTitle != 1 || indexSelect < 0)
		{
			return;
		}
		resetTranslate(g);
		SkillTemplate skillTemplate = Char.getMyChar().nClass.skillTemplates[indexSelect];
		indexRowMax = 4 + skillTemplate.description.Length;
		Skill skill = Char.getMyChar().getSkill(skillTemplate);
		int num13 = popupX;
		int num14 = num12 + indexSize + 2;
		int w3 = popupW - 6;
		int h = popupH - 70 - indexSize;
		scrInfo.setClip(g, num13, num14, w3, h);
		yPaint = num12 + 18;
		if (skill == null)
		{
			skill = ((skillTemplate.skills.Length <= 1) ? skillTemplate.skills[0] : skillTemplate.skills[1]);
			mFont.tahoma_7b_red.drawString(g, skillTemplate.name, num11 + 5, yPaint += 12, 0);
			for (int n = 0; n < skillTemplate.description.Length; n++)
			{
				mFont.tahoma_7_white.drawString(g, skillTemplate.description[n], num11 + 5, yPaint += 12, 0);
			}
			mFont.tahoma_7_white.drawString(g, mResources.SKILLTYPE[skillTemplate.type], num11 + 5, yPaint += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.LEVELMAX + ": " + skillTemplate.maxPoint, num11 + 5, yPaint += 12, 0);
			mFont.tahoma_7_red.drawString(g, mResources.replace(mResources.LEVELNEXT, string.Empty + skill.point), num11 + 5, yPaint += 12, 0);
			paintSkillInfo(g, skill);
			paintSkillOption(g, skill);
		}
		else
		{
			mFont.tahoma_7b_white.drawString(g, skillTemplate.name, num11 + 5, yPaint += 12, 0);
			for (int num15 = 0; num15 < skillTemplate.description.Length; num15++)
			{
				mFont.tahoma_7_white.drawString(g, skillTemplate.description[num15], num11 + 5, yPaint += 12, 0);
			}
			mFont.tahoma_7_white.drawString(g, mResources.SKILLTYPE[skillTemplate.type], num11 + 5, yPaint += 12, 0);
			mFont.tahoma_7_white.drawString(g, mResources.LEVELMAX + ": " + skillTemplate.maxPoint, num11 + 5, yPaint += 12, 0);
			if (skill.point == skillTemplate.maxPoint)
			{
				mFont.tahoma_7_blue.drawString(g, mResources.LEVELEDMAX, num11 + 5, yPaint += 12, 0);
				paintSkillInfo(g, skill);
				paintSkillOption(g, skill);
			}
			else
			{
				mFont.tahoma_7_blue.drawString(g, mResources.replace(mResources.LEVELNOW, NinjaUtil.numberToString(skill.point + string.Empty)), num11 + 5, yPaint += 12, 0);
				paintSkillInfo(g, skill);
				paintSkillOption(g, skill);
				int num16 = 0;
				for (num16 = 0; num16 < skillTemplate.skills.Length; num16++)
				{
					if (skillTemplate.skills[num16].Equals(skill))
					{
						num16++;
						break;
					}
				}
				mFont.tahoma_7_red.drawString(g, mResources.replace(mResources.LEVELNEXT, NinjaUtil.numberToString(skillTemplate.skills[num16].point + string.Empty)), num11 + 5, yPaint += 12, 0);
				paintSkillInfo(g, skillTemplate.skills[num16]);
				indexRowMax++;
				paintSkillOption(g, skillTemplate.skills[num16]);
			}
		}
		scrInfo.setStyle(indexRowMax, 12, num13, num14, w3, h, styleUPDOWN: true, 1);
		if (indexRow >= 0)
		{
			SmallImage.drawSmallImage(g, 942, num11 + 2, num12 + 32 + indexRow * 12, 0, StaticObj.TOP_RIGHT);
		}
	}

	private void actBijuuSelect()
	{
		MyVector myVector = new MyVector();
		if (indexBijuuMenu == 0)
		{
			myVector.addElement(new Command(mResources.POTENTIAL_POINT, 5021));
			myVector.addElement(new Command(mResources.MENUME[1], 5022));
			myVector.addElement(cmdCloseAll);
		}
		else if (indexBijuuMenu == 1)
		{
			myVector.addElement(new Command(mResources.MENUME[indexMenu], 502));
			myVector.addElement(new Command(mResources.MENUME[1], 5022));
			myVector.addElement(cmdCloseAll);
		}
		else if (indexBijuuMenu == 2)
		{
			myVector.addElement(new Command(mResources.MENUME[indexMenu], 502));
			myVector.addElement(new Command(mResources.POTENTIAL_POINT, 5021));
			myVector.addElement(cmdCloseAll);
		}
		GameCanvas.menu.startAt(myVector, 3);
	}

	private void actBijuuMenuPoint()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.UPPOINT, 5041));
		myVector.addElement(new Command(mResources.UPPOINTS, 5042));
		GameCanvas.menu.startAt(myVector, 0);
	}

	public void doBijuuUpPoint()
	{
		if ((indexTitle > 0 && indexTitle <= 4) || GameCanvas.isTouch)
		{
			GameCanvas.inputDlg.show(mResources.INPUT_POINT, cmdBijuuAddPoint, TField.INPUT_TYPE_NUMERIC);
		}
	}

	private void actBijuuUpPoint()
	{
		string text = GameCanvas.inputDlg.tfInput.getText();
		if (text.Trim().Equals(string.Empty))
		{
			GameCanvas.startOKDlg(mResources.NOT_INPUT_POINT);
			return;
		}
		int num = 0;
		try
		{
			num = int.Parse(text);
		}
		catch (Exception)
		{
			GameCanvas.inputDlg.hide();
			return;
		}
		if (num <= 0)
		{
			GameCanvas.inputDlg.hide();
			return;
		}
		if (Char.getMyChar().bijuuPoint == 0 || num > Char.getMyChar().bijuuPoint)
		{
			GameCanvas.startOKDlg(mResources.NOT_ENOUGH_POINT);
			return;
		}
		Service.gI().upPotential(indexTitle - 1, num);
		GameCanvas.inputDlg.hide();
	}

	private void actBijuuKyNang()
	{
		MyVector myVector = new MyVector();
		myVector.addElement(new Command(mResources.UPPOINT, 5051));
		myVector.addElement(new Command(mResources.UPPOINTS, 5052));
		GameCanvas.menu.startAt(myVector, 0);
	}

	public void doBijuuUpSkill()
	{
		if (indexTitle > 0 && indexTitle <= 4)
		{
			GameCanvas.inputDlg.show(mResources.INPUT_POINT, cmdBijuuSkillUp, TField.INPUT_TYPE_NUMERIC);
		}
	}

	private void actBijSkillUpPoint()
	{
		string text = GameCanvas.inputDlg.tfInput.getText();
		if (text.Trim().Equals(string.Empty))
		{
			GameCanvas.startOKDlg(mResources.NOT_INPUT_POINT);
			return;
		}
		int num = 0;
		try
		{
			num = int.Parse(text);
		}
		catch (Exception)
		{
			GameCanvas.inputDlg.hide();
			return;
		}
		if (Char.getMyChar().bijuuSkillPoint == 0 || num > Char.getMyChar().bijuuSkillPoint)
		{
			GameCanvas.startOKDlg(mResources.NOT_INPUT_POINT);
			GameCanvas.msgdlg.show();
		}
		else
		{
			Service.gI().upSkill(Char.getMyChar().nClass.skillTemplates[indexSelect].id, num);
			GameCanvas.inputDlg.hide();
		}
	}
}
