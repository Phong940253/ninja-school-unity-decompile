using System;
using System.Collections;

public class Char : MainObject
{
	public int testAsset = 2047;


	public bool isPantEffclonechar;

	public short[] idpartThoitrang = new short[4] { -1, -1, -1, -1 };

	public bool isHuman;

	public bool isNhanban;

	public bool isCaptcha;

	private int tickEffWolf;

	private int timeBocdau;

	public long lastUpdateTime;

	public const sbyte A_STAND = 1;

	public const sbyte A_RUN = 2;

	public const sbyte A_JUMP = 3;

	public const sbyte A_FALL = 4;

	public const sbyte A_DEADFLY = 5;

	public const sbyte A_NOTHING = 6;

	public const sbyte A_ATTK = 7;

	public const sbyte A_INJURE = 8;

	public const sbyte A_AUTOJUMP = 9;

	public const sbyte A_WATERRUN = 10;

	public const sbyte A_WATERDOWN = 11;

	public const sbyte SKILL_STAND = 12;

	public const sbyte SKILL_FALL = 13;

	public const sbyte A_DEAD = 14;

	public const sbyte A_HIDE = 15;

	public ChatPopup chatPopup;

	public long cEXP;

	public long cExpDown;

	public long cExpR;

	public int lcx;

	public int lcy;

	public int cx = 24;

	public int cy = 24;

	public int cvx;

	public int cvy;

	public int cp1;

	public int cp2;

	public int cp3;

	public int statusMe = 5;

	public int cdir = 1;

	public int charID;

	public int cgender;

	public int ctaskId;

	public int cBonusSpeed;

	public int cspeed;

	public int ccurrentAttack;

	public int cdame;

	public int cdameDown;

	public int clevel;

	public int cMP;

	public int cMaxMP;

	public int cHP;

	public int cHpNew;

	public int cMaxHP;

	public int cMaxEXP;

	public int HPShow;

	public int xReload;

	public int yReload;

	public int cyStartFall;

	public int saveStatus;

	public int eff5BuffHp;

	public int eff5BuffMp;

	public int autoUpHp;

	public int pPoint;

	public int sPoint;

	public int pointUydanh;

	public int pointNon;

	public int pointVukhi;

	public int pointAo;

	public int pointLien;

	public int pointGangtay;

	public int pointNhan;

	public int pointQuan;

	public int pointNgocboi;

	public int pointGiay;

	public int pointPhu;

	public int pointTinhTu;

	public int countFinishDay;

	public int countLoopBoos;

	public int limitTiemnangso;

	public int limitKynangso;

	public int limitPhongLoi;

	public int limitBangHoa;

	public int countPB;

	public int[] potential = new int[4];

	public int bijuuPoint;

	public int bijuuSkillPoint;

	public int[] bijuupotential = new int[4];

	public MyVector vSkillBijuu = new MyVector();

	public string cName;

	public int cw = 22;

	public int ch = 32;

	public int chw = 11;

	public int chh = 16;

	public bool canJumpHigh = true;

	public bool cmtoChar;

	public bool me;

	public bool cchistlast;

	public bool isAttack;

	public bool isAttFly;

	public int cf;

	public int tick;

	public static bool fallAttack;

	public bool isJump;

	public bool autoFall;

	public bool isMoto;

	public bool isWolf;

	public bool isMotoBehind;

	public bool isBocdau;

	public bool isNewMount;

	public int xu;

	public int xuInBox;

	public int yen;

	public int gold_lock;

	public int luong;

	public NClass nClass;

	public MyVector vSkill = new MyVector();

	public MyVector vSkillFight = new MyVector();

	public MyVector vEff = new MyVector();

	public MyVector vDomsang = new MyVector();

	public Skill myskill;

	public Task taskMaint;

	public bool paintName = true;

	public Item[] arrItemBag;

	public Item[] arrItemBox;

	public Item[] arrItemBody;

	public Item[] arrItemMounts = new Item[5];

	public sbyte[] mountsPoint = new sbyte[10];

	public Item[] arrItemBijuu = new Item[5];

	public short cResFire;

	public short cResIce;

	public short cResWind;

	public short cMiss;

	public short cExactly;

	public short cFatal;

	public sbyte cPk;

	public sbyte cTypePk;

	public short cReactDame;

	public short sysUp;

	public short sysDown;

	public int skillTemplateId;

	public Mob mobFocus;

	public Mob mobMe;

	public Npc npcFocus;

	public Char charFocus;

	public ItemMap itemFocus;

	public MyVector focus = new MyVector();

	public Mob[] attMobs;

	public Char[] attChars;

	public short[] moveFast;

	public int testCharId = -9999;

	public int killCharId = -9999;

	public sbyte resultTest;

	public int countKill;

	public int countKillMax;

	public int tickCoat;

	public int tickEffmoto;

	public int tickEffFireW;

	public bool isInvisible;

	public long timeStartBlink;

	public static bool isAHP;

	public static bool isAMP;

	public static bool isAFood;

	public static bool isABuff;

	public static bool isAResuscitate;

	public static bool isAPickYen;

	public static bool isAPickYHM;

	public static bool isAPickYHMS;

	public static bool isANoPick;

	public static bool isAFocusDie;

	public static int aHpValue = 20;

	public static int aMpValue = 20;

	public static int aFoodValue = 70;

	public static int aCID;

	public long lastTimeUseSkill;

	public const sbyte PK_NORMAL = 0;

	public static sbyte PK_NHOM = 1;

	public const sbyte PK_PHE = 1;

	public const sbyte PK_BANG = 2;

	public const sbyte PK_DOSAT = 3;

	public static sbyte PK_PHE1 = 4;

	public static sbyte PK_PHE2 = 5;

	public static sbyte PK_PHE3 = 6;

	public MyVector taskOrders = new MyVector();

	public string cClanName = string.Empty;

	public sbyte ctypeClan;

	public static Clan clan;

	public static int pointPB;

	public static int pointChienTruong;

	public long timeSummon;

	public long timeChatReturn;

	public bool isPolycy;

	public static readonly int[][][] CharInfo = new int[30][][]
	{
		new int[4][]
		{
			new int[3] { 0, -10, 32 },
			new int[3] { 1, -7, 7 },
			new int[3] { 1, -11, 15 },
			new int[3] { 1, -9, 45 }
		},
		new int[4][]
		{
			new int[3] { 0, -10, 33 },
			new int[3] { 1, -7, 7 },
			new int[3] { 1, -11, 16 },
			new int[3] { 1, -9, 46 }
		},
		new int[4][]
		{
			new int[3] { 1, -10, 33 },
			new int[3] { 2, -10, 11 },
			new int[3] { 2, -9, 16 },
			new int[3] { 1, -12, 49 }
		},
		new int[4][]
		{
			new int[3] { 1, -10, 32 },
			new int[3] { 3, -11, 9 },
			new int[3] { 3, -11, 16 },
			new int[3] { 1, -13, 47 }
		},
		new int[4][]
		{
			new int[3] { 1, -10, 34 },
			new int[3] { 4, -9, 9 },
			new int[3] { 4, -8, 16 },
			new int[3] { 1, -12, 47 }
		},
		new int[4][]
		{
			new int[3] { 1, -10, 34 },
			new int[3] { 5, -11, 11 },
			new int[3] { 5, -10, 17 },
			new int[3] { 1, -13, 49 }
		},
		new int[4][]
		{
			new int[3] { 1, -10, 33 },
			new int[3] { 6, -9, 9 },
			new int[3] { 6, -8, 16 },
			new int[3] { 1, -12, 47 }
		},
		new int[4][]
		{
			new int[3] { 0, -9, 36 },
			new int[3] { 7, -5, 15 },
			new int[3] { 7, -10, 21 },
			new int[3] { 1, -8, 49 }
		},
		new int[4][]
		{
			new int[3] { 4, -13, 26 },
			new int[3],
			new int[3],
			new int[3]
		},
		new int[4][]
		{
			new int[3] { 5, -13, 25 },
			new int[3],
			new int[3],
			new int[3]
		},
		new int[4][]
		{
			new int[3] { 6, -12, 26 },
			new int[3],
			new int[3],
			new int[3]
		},
		new int[4][]
		{
			new int[3] { 7, -13, 25 },
			new int[3],
			new int[3],
			new int[3]
		},
		new int[4][]
		{
			new int[3] { 0, -9, 35 },
			new int[3] { 8, -4, 13 },
			new int[3] { 8, -14, 27 },
			new int[3] { 1, -9, 49 }
		},
		new int[4][]
		{
			new int[3] { 0, -9, 31 },
			new int[3] { 9, -11, 8 },
			new int[3] { 10, -10, 17 },
			new int[3]
		},
		new int[4][]
		{
			new int[3] { 2, -7, 33 },
			new int[3] { 9, -11, 8 },
			new int[3] { 11, -8, 15 },
			new int[3]
		},
		new int[4][]
		{
			new int[3] { 2, -8, 32 },
			new int[3] { 9, -11, 8 },
			new int[3] { 12, -8, 14 },
			new int[3]
		},
		new int[4][]
		{
			new int[3] { 2, -7, 32 },
			new int[3] { 9, -11, 8 },
			new int[3] { 13, -12, 15 },
			new int[3]
		},
		new int[4][]
		{
			new int[3] { 0, -11, 31 },
			new int[3] { 9, -11, 8 },
			new int[3] { 14, -15, 18 },
			new int[3]
		},
		new int[4][]
		{
			new int[3] { 2, -9, 32 },
			new int[3] { 9, -11, 8 },
			new int[3] { 15, -13, 19 },
			new int[3]
		},
		new int[4][]
		{
			new int[3] { 2, -9, 31 },
			new int[3] { 9, -11, 8 },
			new int[3] { 16, -7, 22 },
			new int[3]
		},
		new int[4][]
		{
			new int[3] { 2, -9, 32 },
			new int[3] { 9, -11, 8 },
			new int[3] { 17, -11, 18 },
			new int[3]
		},
		new int[4][]
		{
			new int[3] { 3, -12, 34 },
			new int[3] { 8, -4, 13 },
			new int[3] { 8, -15, 25 },
			new int[3] { 1, -10, 46 }
		},
		new int[4][]
		{
			new int[3] { 0, -9, 32 },
			new int[3] { 8, -4, 9 },
			new int[3] { 10, -10, 18 },
			new int[3]
		},
		new int[4][]
		{
			new int[3] { 2, -7, 34 },
			new int[3] { 8, -4, 9 },
			new int[3] { 11, -8, 16 },
			new int[3]
		},
		new int[4][]
		{
			new int[3] { 2, -8, 33 },
			new int[3] { 8, -4, 9 },
			new int[3] { 12, -8, 15 },
			new int[3]
		},
		new int[4][]
		{
			new int[3] { 2, -7, 33 },
			new int[3] { 8, -4, 9 },
			new int[3] { 13, -12, 16 },
			new int[3]
		},
		new int[4][]
		{
			new int[3] { 0, -11, 32 },
			new int[3] { 7, -5, 9 },
			new int[3] { 14, -15, 19 },
			new int[3]
		},
		new int[4][]
		{
			new int[3] { 2, -9, 33 },
			new int[3] { 7, -5, 9 },
			new int[3] { 15, -13, 20 },
			new int[3]
		},
		new int[4][]
		{
			new int[3] { 2, -9, 32 },
			new int[3] { 7, -5, 9 },
			new int[3] { 16, -7, 23 },
			new int[3]
		},
		new int[4][]
		{
			new int[3] { 2, -9, 33 },
			new int[3] { 7, -5, 9 },
			new int[3] { 17, -11, 19 },
			new int[3]
		}
	};

	public int[] CHAR_WEAPONX = new int[11]
	{
		-2, -6, 22, 21, 19, 22, 10, -2, -2, 5,
		19
	};

	public int[] CHAR_WEAPONY = new int[11]
	{
		9, 22, 25, 17, 26, 37, 36, 49, 50, 52,
		36
	};

	private static Char myChar;

	public static int[] listAttack;

	public static int[][] listIonC;

	public int cvyJump;

	private int indexUseSkill = -1;

	public int cxSend;

	public int cySend;

	public int cdirSend = 1;

	public int cxFocus;

	public int cyFocus;

	public int cxMoveLast;

	public int cyMoveLast;

	public int cactFirst = 5;

	public MyVector vMovePoints = new MyVector();

	public static bool flag;

	public static bool ischangingMap;

	public static bool isLockKey;

	public bool isLockMove;

	public bool isLockAttack;

	public bool isBlinking;

	public MovePoint currentMovePoint;

	public int bom;

	public int count;

	public bool isEffBatTu;

	public long lastUseHP = mSystem.currentTimeMillis();

	public bool beginSound;

	public long timeBeGinRun;

	public int vitaWolf;

	public long timeSendmove;

	public static bool isSendMove = true;

	public long time;

	private int cX0;

	private int cY0;

	private int fbyhorse;

	private int FramecharRideHorse;

	private int inAir;

	private long currMove;

	public bool isLastMove;

	public static sbyte[] locate = new sbyte[12]
	{
		0, 0, 0, -1, -1, -1, -2, -2, -2, -1,
		-1, -1
	};

	private long timeLastCheck;

	public long timelastSendmove;

	public static short delaySendmove = 250;

	public short head;

	public short leg;

	public short body;

	public short wp;

	public short coat = -1;

	public short glove = -1;

	public int indexEff = -1;

	public int indexEffTask = -1;

	public EffectCharPaint eff;

	public EffectCharPaint effTask;

	public int indexSkill;

	public int i0;

	public int i1;

	public int i2;

	public int dx0;

	public int dx1;

	public int dx2;

	public int dy0;

	public int dy1;

	public int dy2;

	public EffectCharPaint eff0;

	public EffectCharPaint eff1;

	public EffectCharPaint eff2;

	public Arrow arr;

	public SkillPaint skillPaint;

	public EffectPaint[] effPaints;

	public int sType;

	public sbyte isInjure;

	public static mHashtable ALL_PART_EFF = new mHashtable();

	private int heightCharName;

	private int dxHead;

	private int dyHead;

	private int dxBody;

	private int dyBody;

	private int tickWolf;

	private int dy;

	private int hdx;

	private int hdy;

	private int[] idWolfW = new int[4] { 1715, 1737, 1714, 1738 };

	public int FrameName;

	public int fName;

	public int FrameRank;

	public int fRank;

	public int FrameMatna;

	public int fMatNa;

	public int FrameBienHinh;

	public int fBienhinh;

	public int FrameWeaPone;

	public int fWeapone;

	public int FrameLeg;

	public int fLeg;

	public int FrameBody;

	public int fBody;

	public int FrameHair;

	public int fHair;

	public short ID_Body = -1;

	public short ID_PP = -1;

	public short ID_HAIR = -1;

	public short ID_LEG = -1;

	public short ID_HORSE = -1;

	public short ID_NAME = -1;

	public short ID_RANK = -1;

	public short ID_MAT_NA = -1;

	public short ID_Bien_Hinh = -1;

	public short ID_WEA_PONE = -1;

	public int FramePP;

	public int fPP;

	public int FrameHorse;

	public int fho;

	private sbyte[] ActionHorse;

	public sbyte inDexActionn;

	private int fHorseUI;

	public short[] fRun_PP = new short[10] { 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };

	private int FbodyUI;

	private int FlegUI;

	private int fHeadUI;

	private int fPPUI;

	private byte fWeaponUI;

	private byte fMatNaUI;

	private int dynewhhorse;

	private int dxnewhorse;

	private sbyte frameFix = 2;

	public static bool isManualFocus = false;

	private int nInjure;

	public short wdx;

	public short wdy;

	public bool isDirtyPostion;

	public Skill lastNormalSkill;

	public bool currentFireByShortcut;

	private int EffdefautX;

	private int EffdefautY;

	private int Effx;

	private int Effy;

	private int tickEffyesWolfmove;

	private int EffdefautX1;

	private int EffdefautY1;

	private bool isPaintNo = true;

	private FrameImage img;

	private static Image imgNo;

	private int f;

	private int countNo;

	private int dyNo;

	private int dxNo;

	private int[][] frameMount = new int[6][]
	{
		new int[2] { 3049, 3050 },
		new int[6] { 3051, 3051, 3052, 3052, 3053, 3053 },
		new int[1] { 3054 },
		new int[1] { 3055 },
		new int[1] { 3056 },
		new int[6] { 3049, 3049, 3049, 3050, 3050, 3050 }
	};

	private int tickNewMount;

	private int fNewMount;

	private int dxMount;

	private int dyMount;

	public Char()
	{
		statusMe = 6;
	}

	public int getdxSkill()
	{
		if (myskill != null)
		{
			return myskill.dx;
		}
		return 0;
	}

	public int getdySkill()
	{
		if (myskill != null)
		{
			return myskill.dy;
		}
		return 0;
	}

	public int getSys()
	{
		if (nClass.classId == 1 || nClass.classId == 2)
		{
			return 1;
		}
		if (nClass.classId == 3 || nClass.classId == 4)
		{
			return 2;
		}
		if (nClass.classId == 5 || nClass.classId == 6)
		{
			return 3;
		}
		return 0;
	}

	public int getSpeed()
	{
		if (isWolf || isMoto)
		{
			return cspeed + 2;
		}
		return cspeed;
	}

	public bool isUseLongRangeWeapon()
	{
		return nClass.classId == 2 || nClass.classId == 4 || nClass.classId == 6;
	}

	public static Char getMyChar()
	{
		if (myChar == null)
		{
			myChar = new Char();
			myChar.me = true;
			myChar.cmtoChar = true;
			myChar.timelastSendmove = mSystem.currentTimeMillis();
		}
		return myChar;
	}

	public static void clearMyChar()
	{
		isABuff = (isAFocusDie = (isAFood = (isAHP = (isAMP = (isANoPick = (isAPickYen = (isAPickYHM = (isAPickYHMS = (isAResuscitate = false)))))))));
		myChar = null;
	}

	public void readParam(Message msg, string pos)
	{
		try
		{
			cspeed = msg.reader().readByte();
			cMaxHP = msg.reader().readInt();
			cMaxMP = msg.reader().readInt();
		}
		catch (Exception)
		{
		}
	}

	public void bagSort()
	{
		try
		{
			MyVector myVector = new MyVector();
			for (int i = 0; i < arrItemBag.Length; i++)
			{
				Item item = arrItemBag[i];
				if (item != null && item.template.isUpToUp && !item.isExpires)
				{
					myVector.addElement(item);
				}
			}
			for (int j = 0; j < myVector.size(); j++)
			{
				Item item2 = (Item)myVector.elementAt(j);
				if (item2 == null)
				{
					continue;
				}
				for (int k = j + 1; k < myVector.size(); k++)
				{
					Item item3 = (Item)myVector.elementAt(k);
					if (item3 != null && item2.template.Equals(item3.template) && item2.isLock == item3.isLock)
					{
						item2.quantity += item3.quantity;
						arrItemBag[item3.indexUI] = null;
						myVector.setElementAt(null, k);
					}
				}
			}
			for (int l = 0; l < arrItemBag.Length; l++)
			{
				if (arrItemBag[l] == null)
				{
					continue;
				}
				for (int m = 0; m <= l; m++)
				{
					if (arrItemBag[m] == null)
					{
						arrItemBag[m] = arrItemBag[l];
						arrItemBag[m].indexUI = m;
						arrItemBag[l] = null;
						break;
					}
				}
			}
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
			Out.println("Char.bagSort()");
		}
	}

	public void boxSort()
	{
		try
		{
			MyVector myVector = new MyVector();
			for (int i = 0; i < arrItemBox.Length; i++)
			{
				Item item = arrItemBox[i];
				if (item != null && item.template.isUpToUp && !item.isExpires)
				{
					myVector.addElement(item);
				}
			}
			for (int j = 0; j < myVector.size(); j++)
			{
				Item item2 = (Item)myVector.elementAt(j);
				if (item2 == null)
				{
					continue;
				}
				for (int k = j + 1; k < myVector.size(); k++)
				{
					Item item3 = (Item)myVector.elementAt(k);
					if (item3 != null && item2.template.Equals(item3.template) && item2.isLock == item3.isLock)
					{
						item2.quantity += item3.quantity;
						arrItemBox[item3.indexUI] = null;
						myVector.setElementAt(null, k);
					}
				}
			}
			for (int l = 0; l < arrItemBox.Length; l++)
			{
				if (arrItemBox[l] == null)
				{
					continue;
				}
				for (int m = 0; m <= l; m++)
				{
					if (arrItemBox[m] == null)
					{
						arrItemBox[m] = arrItemBox[l];
						arrItemBox[m].indexUI = m;
						arrItemBox[l] = null;
						break;
					}
				}
			}
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
			Out.println("Char.boxSort()");
		}
	}

	public void useItem(int indexUI)
	{
		Item item = arrItemBag[indexUI];
		if (item.isTypeBody())
		{
			item.isLock = true;
			item.typeUI = 5;
			Item item2 = arrItemBody[item.template.type];
			arrItemBag[indexUI] = null;
			if (item2 != null)
			{
				item2.typeUI = 3;
				arrItemBody[item.template.type] = null;
				item2.indexUI = indexUI;
				arrItemBag[indexUI] = item2;
			}
			item.indexUI = item.template.type;
			arrItemBody[item.indexUI] = item;
			for (int i = 0; i < arrItemBody.Length; i++)
			{
				Item item3 = arrItemBody[i];
				if (item3 != null)
				{
					if (item3.template.type == 1)
					{
						wp = item3.template.part;
					}
					else if (item3.template.type == 2)
					{
						body = item3.template.part;
					}
					else if (item3.template.type == 6)
					{
						leg = item3.template.part;
					}
				}
			}
		}
		else
		{
			if (!item.isTypeMounts())
			{
				return;
			}
			item.isLock = true;
			item.typeUI = 41;
			arrItemBag[indexUI] = null;
			for (int j = 0; j < arrItemMounts.Length; j++)
			{
				int num = item.template.type - 29;
				if (num == j)
				{
					Item item4 = arrItemMounts[num];
					if (item4 != null)
					{
						item4.typeUI = 41;
						arrItemMounts[num] = null;
						item4.indexUI = indexUI;
						arrItemBag[indexUI] = item4;
					}
					item.indexUI = item.template.type;
					arrItemMounts[num] = item;
					break;
				}
			}
		}
	}

	public Skill getSkill(SkillTemplate skillTemplate)
	{
		for (int i = 0; i < vSkill.size(); i++)
		{
			Skill skill = (Skill)vSkill.elementAt(i);
			if (skill.template.Equals(skillTemplate))
			{
				return skill;
			}
		}
		return null;
	}

	public bool isInWaypoint()
	{
		int num = TileMap.vGo.size();
		for (sbyte b = 0; b < num; b = (sbyte)(b + 1))
		{
			Waypoint waypoint = (Waypoint)TileMap.vGo.elementAt(b);
			if (cx >= waypoint.minX && cx <= waypoint.maxX && cy >= waypoint.minY && cy <= waypoint.maxY)
			{
				return true;
			}
		}
		return false;
	}

	private void updateCharSound()
	{
		if (me && getMyChar().statusMe == 2 && !Sound.isPlayingSound())
		{
			Sound.playSoundRun(Sound.MBuocChan, 0.8f);
		}
	}

	public void sendMove()
	{
		if (me && cHP > 0)
		{
			int distance = getDistance(cxSend, cx);
			int distance2 = getDistance(cySend, cy);
			if ((distance > 0 || distance2 > 0) && mSystem.currentTimeMillis() - timeSendmove >= 250)
			{
				isSendMove = true;
			}
			if (isSendMove)
			{
				isSendMove = false;
				Service.gI().charMove("--1:", cx, cy);
				timeSendmove = mSystem.currentTimeMillis();
				cxSend = cx;
				cySend = cy;
				cdirSend = cdir;
				cactFirst = statusMe;
			}
		}
	}

	public static int getDistance(int x, int x2)
	{
		return Res.abs(x - x2);
	}

	public void updateFramecharByhorse()
	{
		if (ID_HORSE == -1)
		{
			dynewhhorse = 0;
			dxnewhorse = 0;
			return;
		}
		DataSkillEff partEff = getPartEff(ID_HORSE, ishorse: true);
		if (partEff != null && partEff.isLoadData)
		{
			if (ActionHorse == null)
			{
				ActionHorse = partEff.ActionStand;
			}
			dynewhhorse = partEff.dyHorse;
			dxnewhorse = partEff.dxHorse;
			if (cdir == 1)
			{
				dxnewhorse *= -1;
			}
			if (statusMe == 1 || statusMe == 6)
			{
				ActionHorse = partEff.ActionStand;
				inDexActionn = 0;
			}
			else if (statusMe == 2 || statusMe == 10)
			{
				ActionHorse = partEff.ActionMove;
				inDexActionn = (sbyte)(partEff.ActionMove.Length - 1);
			}
			else if (statusMe == 4)
			{
				ActionHorse = partEff.ActionFall;
				inDexActionn = (sbyte)(partEff.ActionMove.Length + partEff.ActionStand.Length + partEff.ActionJum.Length - 3);
			}
			else if (statusMe == 3)
			{
				ActionHorse = partEff.ActionJum;
				inDexActionn = (sbyte)(partEff.ActionMove.Length + partEff.ActionStand.Length - 2);
			}
			else
			{
				ActionHorse = partEff.ActionStand;
				inDexActionn = 0;
			}
			if (GameCanvas.gameTick % 3 == 0)
			{
				fbyhorse = (fbyhorse + 1) % ActionHorse.Length;
				FramecharRideHorse = partEff.FrameChar[fbyhorse + inDexActionn];
				fho = (fho + 1) % ActionHorse.Length;
			}
			cf = FramecharRideHorse;
		}
	}

	public void updateFrameRank()
	{
		if (ID_RANK <= -1)
		{
			return;
		}
		DataSkillEff partEff = getPartEff(ID_RANK, ishorse: false);
		if (partEff != null && partEff.sequence != null)
		{
			fRank++;
			if (fRank > partEff.sequence.Length - 1)
			{
				fRank = 0;
			}
			FrameRank = partEff.sequence[fRank];
		}
	}

	public void updateFrameName()
	{
		if (ID_NAME <= -1)
		{
			return;
		}
		DataSkillEff partEff = getPartEff(ID_NAME, ishorse: false);
		if (partEff != null && partEff.sequence != null)
		{
			fName++;
			if (fName > partEff.sequence.Length - 1)
			{
				fName = 0;
			}
			FrameName = partEff.sequence[fName];
		}
	}

	public virtual void update()
	{
		updateFrameName();
		updateFrameRank();
		cX0 = cx;
		cY0 = cy;
		if (arrItemBody != null && arrItemBody[10] == null && mobMe != null)
		{
			mobMe = null;
		}
		if (ID_Bien_Hinh > -1)
		{
			fBienhinh = (fBienhinh + 1) % 10;
		}
		if (ID_MAT_NA > -1)
		{
			fMatNa = (fMatNa + 1) % 10;
		}
		if (ID_WEA_PONE > -1)
		{
			fWeapone = (fWeapone + 1) % 10;
		}
		if (ID_LEG > -1)
		{
			fLeg = (fLeg + 1) % 10;
		}
		if (ID_Body > -1)
		{
			fBody = (fBody + 1) % 10;
		}
		if (ID_HAIR > -1)
		{
			fHair = (fHair + 1) % 10;
		}
		if (ID_PP > -1)
		{
			fPP = (fPP + 1) % 10;
		}
		update_No();
		sendMove();
		if (mobMe != null)
		{
			updateMobMe();
		}
		isEffBatTu = false;
		if (resultTest > 0 && GameCanvas.gameTick % 2 == 0)
		{
			resultTest = (sbyte)(resultTest - 1);
			if (resultTest == 30 || resultTest == 60)
			{
				resultTest = 0;
			}
		}
		updateSkillPaint();
		if (mobMe != null)
		{
			mobMe.update();
		}
		if (arr != null)
		{
			arr.update();
		}
		if (arrItemMounts[4] != null && arrItemMounts[4].options != null)
		{
			for (int i = 0; i < arrItemMounts[4].options.size(); i++)
			{
				ItemOption itemOption = (ItemOption)arrItemMounts[4].options.elementAt(i);
				if (itemOption.optionTemplate.id == 66)
				{
					vitaWolf = itemOption.param;
				}
			}
		}
		if (isWolf && vitaWolf < 500)
		{
			isWolf = false;
		}
		if (isWolf)
		{
			updateEffwolfMove();
			for (int j = 0; j < vDomsang.size(); j++)
			{
				Domsang domsang = (Domsang)vDomsang.elementAt(j);
				domsang.update();
				if (domsang.frame >= 6)
				{
					vDomsang.removeElementAt(j);
				}
			}
		}
		else if (isMoto)
		{
			updateEffmotoMove();
			for (int k = 0; k < vDomsang.size(); k++)
			{
				Domsang domsang2 = (Domsang)vDomsang.elementAt(k);
				domsang2.update();
				if (domsang2.frame >= 6)
				{
					vDomsang.removeElementAt(k);
				}
			}
		}
		else
		{
			for (int l = 0; l < vDomsang.size(); l++)
			{
				Domsang domsang3 = (Domsang)vDomsang.elementAt(l);
				domsang3.update();
				if (domsang3.frame >= 6)
				{
					vDomsang.removeElementAt(l);
				}
			}
		}
		if (me && isAHP && cHP < cMaxHP * aHpValue / 100 && mSystem.currentTimeMillis() - lastUseHP > 5000 && statusMe != 14 && statusMe != 5 && cHP > 0)
		{
			if (vEff.size() == 0)
			{
				for (int m = 0; m < arrItemBag.Length; m++)
				{
					Item item = arrItemBag[m];
					if (item != null && item.template.type == 16 && item.template.level == aHpValue)
					{
						GameScr.gI().doUseHP();
						lastUseHP = mSystem.currentTimeMillis();
						break;
					}
				}
			}
			else
			{
				for (int n = 0; n < vEff.size(); n++)
				{
					Effect effect = (Effect)getMyChar().vEff.elementAt(n);
					if (effect.template.type == 17)
					{
						break;
					}
					if (n == vEff.size() - 1)
					{
						GameScr.gI().doUseHP();
						lastUseHP = mSystem.currentTimeMillis();
					}
				}
			}
		}
		if (me && isAFood && GameCanvas.gameTick % 10 == 0 && !GameScr.isPaintAuto && statusMe != 14 && statusMe != 5 && cHP > 0)
		{
			if (vEff.size() == 0)
			{
				for (int num = 0; num < arrItemBag.Length; num++)
				{
					Item item2 = arrItemBag[num];
					if (item2 != null && item2.template.type == 18 && item2.template.level == aFoodValue)
					{
						Service.gI().useItem(num);
						break;
					}
				}
			}
			else
			{
				for (int num2 = 0; num2 < vEff.size(); num2++)
				{
					Effect effect2 = (Effect)getMyChar().vEff.elementAt(num2);
					if (effect2.template.type == 0)
					{
						break;
					}
					if (num2 != vEff.size() - 1)
					{
						continue;
					}
					for (int num3 = 0; num3 < arrItemBag.Length; num3++)
					{
						Item item3 = arrItemBag[num3];
						if (item3 != null && item3.template.type == 18 && item3.template.level == aFoodValue)
						{
							Service.gI().useItem(num3);
							break;
						}
					}
				}
			}
		}
		if (me && isABuff && getMyChar().statusMe != 14 && getMyChar().statusMe != 5 && cHP > 0 && mSystem.currentTimeMillis() - lastTimeUseSkill > 500)
		{
			for (int num4 = 0; num4 < vSkill.size(); num4++)
			{
				bool flag = false;
				Skill skill = (Skill)vSkill.elementAt(num4);
				if ((skill.template.id >= 67 && skill.template.id <= 72) || skill == null || skill.template.type != 2 || skill.isCooldown())
				{
					continue;
				}
				for (int num5 = 0; num5 < vEff.size(); num5++)
				{
					Effect effect3 = (Effect)vEff.elementAt(num5);
					if (effect3 != null && effect3.template.iconId == skill.template.iconId)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					GameScr.gI().doUseSkill(skill, isShortcut: true, isSelectSkill: false);
					Service.gI().sendUseSkillMyBuff();
					saveLoadPreviousSkill();
					lastTimeUseSkill = mSystem.currentTimeMillis();
					break;
				}
			}
		}
		if (me && isAMP && cMP < cMaxMP * aMpValue / 100 && GameCanvas.gameTick % 4 == 0 && statusMe != 14 && statusMe != 5 && cHP > 0)
		{
			GameScr.gI().doUseMP();
		}
		if (me && isAResuscitate && nClass.classId == 6 && aCID > 0 && getMyChar().statusMe != 14 && getMyChar().statusMe != 5)
		{
			Char @char = GameScr.findCharInMap(aCID);
			if (@char != null && (@char.cHP <= 0 || @char.statusMe == 14 || @char.statusMe == 5 || isAFocusDie))
			{
				for (int num6 = 0; num6 < vSkill.size(); num6++)
				{
					Skill skill2 = (Skill)getMyChar().vSkill.elementAt(num6);
					if (skill2 != null && skill2.template.type == 4)
					{
						if (Res.abs(cx - @char.cx) < skill2.dx && Res.abs(cy - @char.cy) < skill2.dy)
						{
							getMyChar().myskill = skill2;
							GameScr.gI().doRescuedOtherChar(aCID);
							isAFocusDie = false;
							saveLoadPreviousSkill();
						}
						else
						{
							InfoMe.addInfo(mResources.LIVE_TEXT, 20, mFont.tahoma_7_white);
						}
						break;
					}
				}
			}
		}
		if (cHP > 0)
		{
			for (int num7 = 0; num7 < vEff.size(); num7++)
			{
				Effect effect4 = (Effect)vEff.elementAt(num7);
				if (effect4.template.type == 0 || effect4.template.type == 12)
				{
					if (GameCanvas.isEff1)
					{
						cHP += effect4.param;
						cMP += effect4.param;
					}
				}
				else if (effect4.template.type == 4 || effect4.template.type == 17)
				{
					if (GameCanvas.isEff1)
					{
						cHP += effect4.param;
					}
				}
				else if (effect4.template.type == 13)
				{
					if (GameCanvas.isEff1)
					{
						cHP -= cMaxHP * 3 / 100;
						if (cHP < 1)
						{
							cHP = 1;
						}
					}
				}
				else if (effect4.template.type == 7)
				{
					isEffBatTu = true;
				}
				else if (effect4.template.type == 1)
				{
					cHP += autoUpHp;
				}
			}
			if (isEffBatTu)
			{
				count++;
			}
			else
			{
				count = 0;
			}
			if (eff5BuffHp > 0 && GameCanvas.isEff2)
			{
				cHP += eff5BuffHp;
			}
			if (eff5BuffMp > 0 && GameCanvas.isEff2)
			{
				cMP += eff5BuffMp;
			}
			if (cHP > cMaxHP)
			{
				cHP = cMaxHP;
			}
			if (cMP > cMaxMP)
			{
				cMP = cMaxMP;
			}
		}
		if (cmtoChar)
		{
			GameScr.cmtoX = cx - GameScr.gW2 + GameScr.gW6 * cdir;
			GameScr.cmtoY = cy - GameScr.gH23;
		}
		tick = (tick + 1) % 100;
		if (me)
		{
			if (charFocus != null && !GameScr.vCharInMap.contains(charFocus))
			{
				charFocus = null;
			}
			if (cx < 10)
			{
				cvx = 0;
				cx = 10;
			}
			else if (cx > TileMap.pxw - 10)
			{
				cx = TileMap.pxw - 10;
				cvx = 0;
			}
			if (!ischangingMap && isInWaypoint())
			{
				isSendMove = true;
				Service.gI().requestChangeMap();
				isLockKey = true;
				ischangingMap = true;
				GameCanvas.clearKeyHold();
				GameCanvas.clearKeyPressed();
				return;
			}
			if (isBlinking)
			{
				isBlinking = mSystem.currentTimeMillis() - timeStartBlink < 2000;
			}
			else if (statusMe != 4 && (Res.abs(cx - cxSend) >= 90 || Res.abs(cy - cySend) >= 90) && cy - cySend > 0)
			{
			}
			if (isLockMove)
			{
				currentMovePoint = null;
			}
			if (currentMovePoint != null && (statusMe == 1 || statusMe == 2))
			{
				statusMe = 2;
				if (cx - currentMovePoint.xEnd > 0)
				{
					cdir = -1;
					if (cx - currentMovePoint.xEnd <= 10)
					{
						currentMovePoint = null;
					}
				}
				else
				{
					cdir = 1;
					if (cx - currentMovePoint.xEnd >= -10)
					{
						currentMovePoint = null;
					}
				}
				if (currentMovePoint != null)
				{
					cvx = getSpeed() * cdir;
					cvy = 0;
				}
			}
			searchFocus();
			if (statusMe == 1 || statusMe == 6)
			{
				if (mSystem.currentTimeMillis() - currMove > 500 && isLastMove)
				{
					isSendMove = true;
					isLastMove = false;
					currMove = mSystem.currentTimeMillis();
				}
			}
			else
			{
				currMove = mSystem.currentTimeMillis();
				isLastMove = true;
			}
		}
		else
		{
			if (GameCanvas.gameTick % 20 == 0 && charID >= 0)
			{
				paintName = true;
				for (int num8 = 0; num8 < GameScr.vCharInMap.size(); num8++)
				{
					Char char2 = null;
					try
					{
						char2 = (Char)GameScr.vCharInMap.elementAt(num8);
					}
					catch (Exception)
					{
					}
					if (char2 != null && !char2.Equals(this) && ((char2.cy == cy && Res.abs(char2.cx - cx) < 35) || (cy - char2.cy < 32 && cy - char2.cy > 0 && Res.abs(char2.cx - cx) < 24)))
					{
						paintName = false;
					}
				}
			}
			if (statusMe == 1 || statusMe == 6)
			{
				bool flag2 = false;
				if (currentMovePoint != null)
				{
					if (abs(currentMovePoint.xEnd - cx) < 4 && abs(currentMovePoint.yEnd - cy) < 4)
					{
						cx = currentMovePoint.xEnd;
						cy = currentMovePoint.yEnd;
						currentMovePoint = null;
						if ((TileMap.tileTypeAtPixel(cx, cy) & TileMap.T_TOP) == TileMap.T_TOP)
						{
							changeStatusStand();
							GameCanvas.gI().startDust(-1, cx - -8, cy);
							GameCanvas.gI().startDust(1, cx - 8, cy);
						}
						else
						{
							statusMe = 4;
							cvy = 0;
						}
						flag2 = true;
					}
					else if (cy == currentMovePoint.yEnd)
					{
						if (cx != currentMovePoint.xEnd)
						{
							cx = (cx + currentMovePoint.xEnd) / 2;
							cf = GameCanvas.gameTick % 5 + 2;
						}
					}
					else if (cy < currentMovePoint.yEnd)
					{
						cf = 12;
						cx = (cx + currentMovePoint.xEnd) / 2;
						if (cvy < 0)
						{
							cvy = 0;
						}
						cy += cvy;
						if ((TileMap.tileTypeAtPixel(cx, cy) & TileMap.T_TOP) == TileMap.T_TOP)
						{
							GameCanvas.gI().startDust(-1, cx - -8, cy);
							GameCanvas.gI().startDust(1, cx - 8, cy);
						}
						cvy++;
						if (cvy > 16)
						{
							cy = (cy + currentMovePoint.yEnd) / 2;
						}
					}
					else
					{
						cf = 7;
						cx = (cx + currentMovePoint.xEnd) / 2;
						cy = (cy + currentMovePoint.yEnd) / 2;
					}
				}
				else
				{
					flag2 = true;
				}
				if (flag2 && vMovePoints.size() > 0)
				{
					if (vMovePoints.size() > 5)
					{
						currentMovePoint = (MovePoint)vMovePoints.lastElement();
						vMovePoints.removeElementAt(0);
						cx = currentMovePoint.xEnd;
						cy = currentMovePoint.yEnd;
						vMovePoints.removeAllElements();
						statusMe = 6;
						currentMovePoint = null;
						return;
					}
					currentMovePoint = (MovePoint)vMovePoints.firstElement();
					vMovePoints.removeElementAt(0);
					if (currentMovePoint.status == 2)
					{
						statusMe = 2;
						if (cx - currentMovePoint.xEnd > 0)
						{
							cdir = -1;
						}
						else if (cx - currentMovePoint.xEnd < 0)
						{
							cdir = 1;
						}
						cvx = 5 * cdir;
						cvy = 0;
					}
					else if (currentMovePoint.status == 3)
					{
						statusMe = 3;
						GameCanvas.gI().startDust(-1, cx - -8, cy);
						GameCanvas.gI().startDust(1, cx - 8, cy);
						if (cx - currentMovePoint.xEnd > 0)
						{
							cdir = -1;
						}
						else if (cx - currentMovePoint.xEnd < 0)
						{
							cdir = 1;
						}
						cvx = abs(cx - currentMovePoint.xEnd) / 9 * cdir;
						cvy = -10;
					}
					else if (currentMovePoint.status == 4)
					{
						statusMe = 4;
						if (cx - currentMovePoint.xEnd > 0)
						{
							cdir = -1;
						}
						else if (cx - currentMovePoint.xEnd < 0)
						{
							cdir = 1;
						}
						cvx = abs(cx - currentMovePoint.xEnd) / 9 * cdir;
						cvy = 0;
					}
					else
					{
						cx = currentMovePoint.xEnd;
						cy = currentMovePoint.yEnd;
						currentMovePoint = null;
					}
				}
				if (statusMe == 6)
				{
					if (cf >= 8 && cf <= 11)
					{
						cf++;
						cp1++;
						if (cf > 11)
						{
							cf = 8;
						}
						if (cp1 > 5)
						{
							cf = 0;
						}
					}
					if (cf <= 1)
					{
						cp1++;
						if (cp1 > 6)
						{
							cf = 0;
						}
						else
						{
							cf = 1;
						}
						if (cp1 > 10)
						{
							cp1 = 0;
						}
					}
				}
				lcx = cx;
				lcy = cy;
				if (mSystem.currentTimeMillis() - timeSummon > 7000)
				{
					// stand
					if (!isWolf && isHaveWolf() && vitaWolf >= 500)
					{
						isWolf = true;
						ServerEffect.addServerEffect(60, this, 1);
					}
					if (isMoto && isHaveMoto())
					{
						isMoto = false;
						isMotoBehind = true;
					}
				}
			}
		}
		if (isInjure > 0)
		{
			cf = 21;
			isInjure = (sbyte)(isInjure - 1);
		}
		else
		{
			switch (statusMe)
			{
			case 1:
				isBocdau = false;
				timeBocdau = 0;
				if (isWolf)
				{
					if (cdir == 1)
					{
						EffdefautX = cx + 21 + 4;
						EffdefautY = cy - 15;
					}
					else
					{
						EffdefautX = cx - 24 - 4;
						EffdefautY = cy - 15;
					}
				}
				updateCharStand();
				break;
			case 2:
				if (isMoto)
				{
					timeBocdau++;
					if (arrItemMounts[4].template.id == 485 && arrItemMounts[4].sys >= 4)
					{
						isBocdau = true;
					}
					if (timeBocdau > 20)
					{
						isBocdau = false;
					}
				}
				if (isWolf)
				{
					if (cdir == 1)
					{
						if (idWolfW[tickWolf] == 1737)
						{
							EffdefautX = cx + 21 + 4;
							EffdefautY = cy - 19;
						}
						else
						{
							EffdefautX = cx + 21 + 4;
							EffdefautY = cy - 16;
						}
					}
					else if (idWolfW[tickWolf] == 1737)
					{
						EffdefautX = cx - 24 - 4;
						EffdefautY = cy - 19;
					}
					else
					{
						EffdefautX = cx - 24 - 4;
						EffdefautY = cy - 16;
					}
				}
				else if (isMoto)
				{
					if (cdir == 1)
					{
						EffdefautX = cx + 15;
						EffdefautX1 = cx - 25;
						EffdefautY = cy;
						EffdefautY1 = cy;
					}
					else
					{
						EffdefautX = cx - 18;
						EffdefautX1 = cx + 25;
						EffdefautY = cy;
						EffdefautY1 = cy;
					}
				}
				updateCharRun();
				break;
			case 3:
				isBocdau = false;
				timeBocdau = 0;
				if (isWolf)
				{
					if (cdir == 1)
					{
						EffdefautX = cx + 21 + 4;
						EffdefautY = cy - 30;
					}
					else
					{
						EffdefautX = cx - 23 - 4;
						EffdefautY = cy - 30;
					}
				}
				updateCharJump();
				break;
			case 4:
				isBocdau = false;
				timeBocdau = 0;
				if (isWolf)
				{
					if (cdir == 1)
					{
						EffdefautX = cx + 21 + 4;
						EffdefautY = cy - 19;
					}
					else
					{
						EffdefautX = cx - 24;
						EffdefautY = cy - 20;
					}
				}
				updateCharFall();
				break;
			case 5:
				isBocdau = false;
				timeBocdau = 0;
				updateCharDeadFly();
				break;
			case 9:
				isBocdau = false;
				timeBocdau = 0;
				updateCharAutoJump();
				break;
			case 10:
				isBocdau = false;
				timeBocdau = 0;
				updateCharWaterRun();
				break;
			case 11:
				isBocdau = false;
				timeBocdau = 0;
				updateCharWaterDown();
				break;
			case 12:
				isBocdau = false;
				timeBocdau = 0;
				updateSkillStand();
				break;
			case 13:
				isBocdau = false;
				timeBocdau = 0;
				updateSkillFall();
				break;
			case 14:
				isBocdau = false;
				timeBocdau = 0;
				break;
			case 6:
				isBocdau = false;
				timeBocdau = 0;
				if (cf == 21 && isInjure <= 0)
				{
					cf = 0;
				}
				break;
			}
		}
		if (wdx != 0 || wdy != 0)
		{
			startDie(wdx, wdy);
			wdx = 0;
			wdy = 0;
		}
		if (moveFast != null)
		{
			if (moveFast[0] == 0)
			{
				moveFast[0]++;
				ServerEffect.addServerEffect(60, this, 1);
			}
			else if (moveFast[0] < 10)
			{
				moveFast[0]++;
			}
			else
			{
				cx = moveFast[1];
				cy = moveFast[2];
				moveFast = null;
				ServerEffect.addServerEffect(60, this, 1);
				if (me)
				{
					if ((TileMap.tileTypeAtPixel(cx, cy) & TileMap.T_TOP) != TileMap.T_TOP)
					{
						statusMe = 4;
						getMyChar().setAutoSkillPaint(GameScr.sks[38], 1);
					}
					else
					{
						getMyChar().setAutoSkillPaint(GameScr.sks[38], 0);
					}
				}
			}
		}
		if (!me && vMovePoints.size() == 0 && cxMoveLast != 0 && cyMoveLast != 0 && currentMovePoint == null)
		{
			if (cxMoveLast != cx)
			{
				cx = cxMoveLast;
			}
			if (cyMoveLast != cy)
			{
				cy = cyMoveLast;
			}
			if (cHP > 0)
			{
				statusMe = 6;
			}
		}
		updateEffectWolf();
		fixMove();
		updateDataEff(0, statusMe);
		if (ID_HORSE > 0)
		{
			isNewMount = false;
			isMoto = false;
			isWolf = false;
		}
		updNewMount();
		updateFramecharByhorse();
	}

	public void fixMove()
	{
		if (me)
		{
			return;
		}
		if (cf == 12 && cX0 == cx && cY0 == cy)
		{
			inAir++;
		}
		else if (cf == 0 && (TileMap.tileTypeAtPixel(cx, cy) & TileMap.T_TOP) != TileMap.T_TOP)
		{
			inAir++;
		}
		else
		{
			inAir = 0;
		}
		if (inAir <= 1)
		{
			return;
		}
		for (int i = cy; i < cy + 150; i += 24)
		{
			if ((TileMap.tileTypeAtPixel(cx, i) & TileMap.T_TOP) == TileMap.T_TOP)
			{
				continue;
			}
			int num = TileMap.tileYofPixel(i) + 24;
			if (num - cy > 24)
			{
				cy += (num - cy) / 2;
				if (!isMoto && !isWolf && !isNewMount)
				{
					cf = 12;
				}
				vMovePoints.removeAllElements();
				currentMovePoint = null;
			}
			else
			{
				statusMe = 1;
				vMovePoints.removeAllElements();
				currentMovePoint = null;
				cvx = 0;
				cvy = 0;
				cp1 = 0;
				cp2 = 0;
				cp3 = 0;
				inAir = 0;
				cxMoveLast = 0;
				cyMoveLast = 0;
				cy = num;
			}
			lcy = cy;
			break;
		}
	}

	private void autoPickItemMap()
	{
		if (!me || cHP <= 0 || statusMe == 14 || statusMe == 5 || testCharId != -9999)
		{
			return;
		}
		int num = 70;
		if (GameScr.isUseitemAuto)
		{
			num = 240;
		}
		if (!isAPickYen && !isAPickYHM && !isAPickYHMS)
		{
			return;
		}
		for (int i = 0; i < GameScr.vItemMap.size(); i++)
		{
			ItemMap itemMap = (ItemMap)GameScr.vItemMap.elementAt(i);
			if (itemMap == null)
			{
				continue;
			}
			int num2 = Math.abs(getMyChar().cx - itemMap.x);
			int num3 = Math.abs(getMyChar().cy - itemMap.y);
			if (num2 <= num && num3 <= num)
			{
				if ((isAPickYen || isAPickYHM || isAPickYHMS) && itemMap.template.type == 19)
				{
					Service.gI().pickItem(itemMap.itemMapID);
				}
				else if ((itemMap.template.type == 16 || itemMap.template.type == 17) && (isAPickYHM || isAPickYHMS))
				{
					Service.gI().pickItem(itemMap.itemMapID);
				}
				else if (itemMap.template.id == 27 && isAPickYHMS)
				{
					Service.gI().pickItem(itemMap.itemMapID);
				}
			}
		}
	}

	// public void updateNew_NobMe()
	// {
	// 	if (mobMe != null)
	// 	{
	// 		mobMe.owner = this;
	// 	}
	// 	if (mobMe.templateId == 122 || mobMe.templateId == 70 || (mobMe.getTemplate() != null && mobMe.getTemplate().typeFly == 1))
	// 	{
	// 		if (mobMe.status != 3)
	// 		{
	// 			mobMe.xFirst = cx + (3 - GameCanvas.gameTick % 6) * 6;
	// 			mobMe.yFirst = cy - 60;
	// 		}
	// 		mobMe.update();
	// 		return;
	// 	}
	// 	if (mobMe.status != 3)
	// 	{
	// 		if (cdir == -1)
	// 		{
	// 			mobMe.xFirst = cx + 20;
	// 			mobMe.yFirst = cy;
	// 			mobMe.dir = cdir;
	// 			mobMe.y = cy - 20;
	// 		}
	// 		else
	// 		{
	// 			mobMe.xFirst = cx - 20;
	// 			mobMe.yFirst = cy;
	// 			mobMe.dir = cdir;
	// 			mobMe.y = cy - 20;
	// 		}
	// 		int num = mobMe.xFirst - mobMe.x;
	// 		int num2 = mobMe.yFirst - mobMe.y;
	// 		if (num > 50 || num < -50)
	// 		{
	// 			mobMe.x += num / 10;
	// 		}
	// 		else
	// 		{
	// 			mobMe.x += num;
	// 		}
	// 		if (num2 > 50 || num2 < -50)
	// 		{
	// 			mobMe.y += num2 / 10;
	// 		}
	// 	}
	// 	mobMe.update();
	// }

	private void updateMobMe()
	{
		// if (mobMe != null && mobMe.templateId >= 236)
		// {
		// 	updateNew_NobMe();
		// 	return;
		// }
		if (mobMe.templateId == 122 || mobMe.templateId == 70 || (mobMe.getTemplate() != null && mobMe.getTemplate().typeFly == 1))
		{
			if (mobMe.status != 3)
			{
				mobMe.xFirst = cx + (3 - GameCanvas.gameTick % 6) * 6;
				mobMe.yFirst = cy - 60;
				int num = mobMe.xFirst - mobMe.x;
				int num2 = mobMe.yFirst - mobMe.y;
				if (num > 50 || num < -50)
				{
					mobMe.x += num / 10;
				}
				if (num2 > 50 || num2 < -50)
				{
					mobMe.y += num2 / 10;
				}
			}
			mobMe.update();
			return;
		}
		if (mobMe.status != 3)
		{
			if (cdir == -1)
			{
				mobMe.xFirst = cx + 20;
				mobMe.yFirst = cy;
				mobMe.dir = cdir;
				mobMe.y = cy - 20;
			}
			else
			{
				mobMe.xFirst = cx - 20;
				mobMe.yFirst = cy;
				mobMe.dir = cdir;
				mobMe.y = cy - 20;
			}
			int num3 = mobMe.xFirst - mobMe.x;
			int num4 = mobMe.yFirst - mobMe.y;
			if (num3 > 50 || num3 < -50)
			{
				mobMe.x += num3 / 10;
			}
			else
			{
				mobMe.x += num3;
			}
			if (num4 > 50 || num4 < -50)
			{
				mobMe.y += num4 / 10;
			}
		}
		mobMe.update();
	}

	private void updateSkillPaint()
	{
		if (statusMe == 14 || statusMe == 5)
		{
			return;
		}
		if (skillPaint != null && mobFocus != null && mobFocus.status == 0)
		{
			if (!me)
			{
				if ((TileMap.tileTypeAtPixel(cx, cy) & TileMap.T_TOP) == TileMap.T_TOP)
				{
					changeStatusStand();
				}
				else
				{
					statusMe = 6;
				}
			}
			indexSkill = 0;
			skillPaint = null;
			eff0 = (eff1 = (eff2 = null));
			i0 = (i1 = (i2 = 0));
			mobFocus = null;
			effPaints = null;
			arr = null;
		}
		if (skillPaint != null && arr == null && indexSkill >= skillInfoPaint1().Length)
		{
			if (!me)
			{
				if ((TileMap.tileTypeAtPixel(cx, cy) & TileMap.T_TOP) == TileMap.T_TOP)
				{
					changeStatusStand();
				}
				else
				{
					statusMe = 6;
				}
			}
			indexSkill = 0;
			skillPaint = null;
			eff0 = (eff1 = (eff2 = null));
			i0 = (i1 = (i2 = 0));
			arr = null;
		}
		SkillInfoPaint[] array = skillInfoPaint1();
		if (array == null)
		{
			return;
		}
		if (me && myskill.template.type == 2)
		{
			if (indexSkill == array.Length - array.Length / 3)
			{
				Service.gI().sendUseSkillMyBuff();
				saveLoadPreviousSkill();
			}
		}
		else if ((mobFocus != null || (!me && charFocus != null) || (me && charFocus != null && isMeCanAttackOtherPlayer(charFocus))) && arr == null && indexSkill == array.Length - array.Length / 3)
		{
			setAttack();
			if (me)
			{
				saveLoadPreviousSkill();
			}
		}
	}

	public void saveLoadPreviousSkill()
	{
		if (mSystem.currentTimeMillis() - timeLastCheck <= 500)
		{
			return;
		}
		if (myskill.template.type != 1 && lastNormalSkill != null)
		{
			myskill = lastNormalSkill;
			Service.gI().selectSkill(myskill.template.id);
		}
		if (currentFireByShortcut)
		{
			if (lastNormalSkill != null)
			{
				myskill = lastNormalSkill;
				Service.gI().selectSkill(myskill.template.id);
			}
		}
		else if (GameScr.auto != 1)
		{
			lastNormalSkill = myskill;
		}
		timeLastCheck = mSystem.currentTimeMillis();
	}

	private void updateCharDeadFly()
	{
		cp1++;
		cx += (cp2 - cx) / 4;
		if (cp1 > 7)
		{
			cy += (cp3 - cy) / 4;
		}
		else
		{
			cy += cp1 - 10;
		}
		if (Res.abs(cp2 - cx) < 4 && Res.abs(cp3 - cy) < 10)
		{
			cx = cp2;
			cy = cp3;
			statusMe = 14;
			callEff(60);
			if (me)
			{
				GameScr.gI().resetButton();
			}
		}
		cf = 21;
	}

	public void setAttk()
	{
		cp1++;
		if (cdir == 1)
		{
			if ((TileMap.tileTypeAtPixel(cx + chw, cy - chh) & TileMap.T_LEFT) == TileMap.T_LEFT)
			{
				cvx = 0;
			}
		}
		else if ((TileMap.tileTypeAtPixel(cx - chw, cy - chh) & TileMap.T_RIGHT) == TileMap.T_RIGHT)
		{
			cvx = 0;
		}
		if (cy > ch && TileMap.tileTypeAt(cx, cy - ch, TileMap.T_BOTTOM))
		{
			if (!TileMap.tileTypeAt(cx, cy, TileMap.T_TOP))
			{
				statusMe = 4;
				cp1 = 0;
				cp2 = 0;
				cvy = 1;
			}
			else
			{
				cy = TileMap.tileYofPixel(cy);
			}
		}
		cx += cvx;
		cy += cvy;
		if (cy < 0)
		{
			cy = (cvy = 0);
		}
		if (cvy == 0)
		{
			if ((TileMap.tileTypeAtPixel(cx, cy) & TileMap.T_TOP) != TileMap.T_TOP)
			{
				statusMe = 4;
				cvx = (getSpeed() >> 1) * cdir;
				cp1 = (cp2 = 0);
			}
		}
		else if (cvy < 0)
		{
			cvy++;
			if (cvy == 0)
			{
				cvy = 1;
			}
		}
		else
		{
			if (cvy < 20 && cp1 % 5 == 0)
			{
				cvy++;
			}
			if (cvy > 3)
			{
				cvy = 3;
			}
			if ((TileMap.tileTypeAtPixel(cx, cy + 3) & TileMap.T_TOP) == TileMap.T_TOP && cy <= TileMap.tileXofPixel(cy + 3))
			{
				cvx = (cvy = 0);
				cy = TileMap.tileXofPixel(cy + 3);
			}
			if (TileMap.tileTypeAt(cx, cy, TileMap.T_WATERFLOW) && cy % TileMap.size > 8)
			{
				statusMe = 10;
				cvx = cdir << 1;
				cvy >>= 2;
				cy = TileMap.tileYofPixel(cy) + 12;
				statusMe = 11;
				return;
			}
			if (TileMap.tileTypeAt(cx, cy, TileMap.T_UNDERWATER))
			{
				statusMe = 11;
				return;
			}
		}
		if (cvx > 0)
		{
			cvx--;
		}
		else if (cvx < 0)
		{
			cvx++;
		}
	}

	private void playSound(SkillPaint skillPaint)
	{
		int num = NinjaUtil.randomNumber(3);
		float num2 = 0f;
		num2 = (me ? 0.8f : 0.4f);
		switch (nClass.classId)
		{
		case 0:
			Sound.play(Sound.MKiemGo, num2);
			break;
		case 1:
			switch (num)
			{
			case 0:
				Sound.play(Sound.MKiem, num2);
				break;
			case 1:
				Sound.play(Sound.MKiem2, num2);
				break;
			default:
				Sound.play(Sound.MKiem3, num2);
				break;
			}
			break;
		case 2:
			Sound.play(Sound.MTieu, num2);
			break;
		case 3:
			Sound.play(Sound.MKunai, num2);
			break;
		case 4:
			switch (num)
			{
			case 0:
				Sound.play(Sound.MCung, num2);
				break;
			case 1:
				Sound.play(Sound.MCung2, num2);
				break;
			default:
				Sound.play(Sound.MCung3, num2);
				break;
			}
			break;
		case 5:
			if (skillPaint.id == 41)
			{
				Sound.play(Sound.MDao2, num2);
			}
			else if (skillPaint.id == 45)
			{
				Sound.play(Sound.MDao3, num2);
			}
			else
			{
				Sound.play(Sound.MDao, num2);
			}
			break;
		case 6:
			Sound.play(Sound.MQuat, num2);
			break;
		}
	}

	public void updateSkillFall()
	{
	}

	public void updateSkillStand()
	{
		setAttk();
	}

	public void updateCharAutoJump()
	{
		cx += cvx * cdir;
		cy += cvyJump;
		cvyJump++;
		if (cp1 == 0)
		{
			cf = 7;
		}
		else
		{
			cf = 23;
		}
		if (canJumpHigh)
		{
			if (cvyJump == -3)
			{
				cf = 8;
			}
			else if (cvyJump == -2)
			{
				cf = 9;
			}
			else if (cvyJump == -1)
			{
				cf = 10;
			}
			else if (cvyJump == 0)
			{
				cf = 11;
			}
		}
		if (cvyJump == 0)
		{
			statusMe = 6;
			((MovePoint)vMovePoints.firstElement()).status = 4;
			isJump = true;
			cp1 = 0;
			cvy = 1;
		}
	}

	public int getVx(int size, int dx, int dy)
	{
		if (dy > 0 && !TileMap.tileTypeAt(cx, cy, TileMap.T_TOP))
		{
			if (dx - dy <= 10)
			{
				return 5;
			}
			if (dx - dy <= 30)
			{
				return 6;
			}
			if (dx - dy <= 50)
			{
				return 7;
			}
			if (dx - dy <= 70)
			{
				return 8;
			}
		}
		if (dx <= 30)
		{
			return 4;
		}
		if (dx <= 160)
		{
			return 5;
		}
		if (dx <= 270)
		{
			return 6;
		}
		if (dx <= 320)
		{
			return 7;
		}
		return 8;
	}

	public int getVy(int size, int dx, int dy)
	{
		if (dy <= 10)
		{
			return 5;
		}
		if (dy <= 20)
		{
			return 6;
		}
		if (dy <= 30)
		{
			return 7;
		}
		if (dy <= 40)
		{
			return 8;
		}
		if (dy <= 50)
		{
			return 9;
		}
		return 10;
	}

	public int returnAct(int xFirst, int yFirst, int xEnd, int yEnd)
	{
		int num = xEnd - xFirst;
		int num2 = yEnd - yFirst;
		if (num == 0 && num2 == 0)
		{
			return 1;
		}
		if (num2 == 0 && yFirst % 24 == 0 && TileMap.tileTypeAt(xFirst, yFirst, TileMap.T_TOP))
		{
			return 2;
		}
		if (num2 > 0 && (yFirst % 24 != 0 || !TileMap.tileTypeAt(xFirst, yFirst, TileMap.T_TOP)))
		{
			return 4;
		}
		cvy = -10;
		cp1 = 0;
		cdir = ((num > 0) ? 1 : (-1));
		if (num <= 5)
		{
			cvx = 0;
		}
		else if (num <= 10)
		{
			cvx = 3;
		}
		else
		{
			cvx = 5;
		}
		return 9;
	}

	public void setAutoJump()
	{
		int num = ((MovePoint)vMovePoints.firstElement()).xEnd - cx;
		if (canJumpHigh)
		{
			cvyJump = -10;
		}
		else
		{
			cvyJump = -8;
		}
		cp1 = 0;
		cdir = ((num > 0) ? 1 : (-1));
		if (num <= 6)
		{
			cvx = 0;
		}
		else if (num <= 20)
		{
			cvx = 3;
		}
		else
		{
			cvx = 5;
		}
	}

	public void updateCharStand()
	{
		isAttack = false;
		isAttFly = false;
		cvx = 0;
		cvy = 0;
		cp1++;
		lcx = cx;
		lcy = cy;
		if (cp1 > 30)
		{
			cp1 = 0;
		}
		if (cp1 % 15 < 5)
		{
			cf = 0;
		}
		else
		{
			cf = 1;
		}
		updateCharInBridge();
		if (mSystem.currentTimeMillis() - timeSummon > 7000)
		{
			if (!isWolf && isHaveWolf() && vitaWolf >= 500)
			{
				isWolf = true;
				ServerEffect.addServerEffect(60, this, 1);
			}
			if (isMoto && isHaveMoto())
			{
				isMoto = false;
				isMotoBehind = true;
			}
		}
	}

	public void updateCharRun()
	{
		int num = 0;
		if (!me && currentMovePoint != null)
		{
			num = abs(cx - currentMovePoint.xEnd);
		}
		cp1++;
		if (cp1 >= 10)
		{
			cp1 = 0;
			cBonusSpeed = 0;
		}
		cf = (cp1 >> 1) + 2;
		if ((TileMap.tileTypeAtPixel(cx, cy - 1) & TileMap.T_WATERFLOW) == TileMap.T_WATERFLOW)
		{
			cx += cvx >> 1;
		}
		else
		{
			cx += cvx;
		}
		if (cdir == 1)
		{
			if (GameScr.auto != 1)
			{
				if (TileMap.tileTypeAt(cx + chw, cy - chh, TileMap.T_LEFT))
				{
					if (me)
					{
						cvx = 0;
						cx = TileMap.tileXofPixel(cx + chw) - chw;
					}
					else
					{
						stop();
					}
				}
			}
			else if (TileMap.tileTypeAt(cx + chw, cy - chh, TileMap.T_LEFT))
			{
				if (me)
				{
					statusMe = 3;
					if (statusMe == 3)
					{
						cvy -= 10;
					}
				}
				else
				{
					stop();
				}
			}
		}
		else if (GameScr.auto != 1)
		{
			if (TileMap.tileTypeAt(cx - chw - 1, cy - chh, TileMap.T_RIGHT))
			{
				if (me)
				{
					cvx = 0;
					cx = TileMap.tileXofPixel(cx - chw - 1) + TileMap.size + chw;
				}
				else
				{
					stop();
				}
			}
		}
		else if (TileMap.tileTypeAt(cx - chw - 1, cy - chh, TileMap.T_RIGHT))
		{
			if (me)
			{
				statusMe = 3;
				if (statusMe == 3)
				{
					cvy -= 10;
				}
			}
			else
			{
				stop();
			}
		}
		if (!isNewMount && isHaveNewMount())
		{
			isNewMount = true;
			isMotoBehind = false;
		}
		if (!isMoto && isHaveMoto())
		{
			isMoto = true;
			isMotoBehind = false;
		}
		if (!isWolf && isHaveWolf() && vitaWolf >= 500)
		{
			dx0 = Res.abs(cx - lcx);
			dy0 = Res.abs(cy - lcy);
			dx0 = ((dx0 <= dy0) ? dy0 : dx0);
			if ((me && dx0 > 150) || (!me && dx0 > 40))
			{
				isWolf = true;
				ServerEffect.addServerEffect(60, this, 1);
			}
			dx0 = (dy0 = 0);
		}
		if (me)
		{
			if (cvx > 0)
			{
				cvx--;
			}
			else if (cvx < 0)
			{
				cvx++;
			}
			else
			{
				if (cx - cxSend != 0)
				{
				}
				changeStatusStand();
				cBonusSpeed = 0;
			}
		}
		if ((TileMap.tileTypeAtPixel(cx, cy) & TileMap.T_TOP) != TileMap.T_TOP)
		{
			if (me)
			{
				cf = 7;
				statusMe = 4;
				cvx = 3 * cdir;
				cp2 = 0;
			}
			else
			{
				stop();
			}
		}
		if (!me && currentMovePoint != null)
		{
			int num2 = abs(cx - currentMovePoint.xEnd);
			if (num2 > num)
			{
				stop();
			}
		}
		if (isMoto || isNewMount)
		{
			if (GameCanvas.gameTick % 5 == 0)
			{
				ServerEffect.addServerEffect(120, cx - (cdir << 5), cy, 0, (sbyte)cdir);
			}
		}
		else
		{
			GameCanvas.gI().startDust(cdir, cx - (cdir << 3), cy);
		}
		updateCharInBridge();
		startCoatEffect(cx - (cdir << 4), cy);
	}

	private void stop()
	{
		statusMe = 6;
		cvx = 0;
		cvy = 0;
		cp1 = (cp2 = 0);
	}

	public static int abs(int i)
	{
		return (i <= 0) ? (-i) : i;
	}

	public void updateCharJump()
	{
		if (GameScr.auto == 1)
		{
			if (cdir == 1)
			{
				cvx = 5;
			}
			else
			{
				cvx = -5;
			}
		}
		if (isHaveNewMount())
		{
			isNewMount = true;
			isMotoBehind = false;
		}
		if (isHaveMoto())
		{
			isMoto = true;
			isMotoBehind = false;
		}
		cx += cvx;
		cy += cvy;
		if (cy < 0)
		{
			cy = 0;
			cvy = -1;
		}
		cvy++;
		if (!me && currentMovePoint != null)
		{
			int num = currentMovePoint.xEnd - cx;
			if (num > 0)
			{
				if (cvx > num)
				{
					cvx = num;
				}
				if (cvx < 0)
				{
					cvx = num;
				}
			}
			else if (num < 0)
			{
				if (cvx < num)
				{
					cvx = num;
				}
				if (cvx > 0)
				{
					cvx = num;
				}
			}
			else
			{
				cvx = num;
			}
		}
		if (cp1 == 0)
		{
			cf = 7;
		}
		else
		{
			cf = 23;
		}
		if (canJumpHigh)
		{
			if (cvy == -3)
			{
				cf = 8;
			}
			else if (cvy == -2)
			{
				cf = 9;
			}
			else if (cvy == -1)
			{
				cf = 10;
			}
			else if (cvy == 0)
			{
				cf = 11;
			}
		}
		if (cdir == 1)
		{
			if ((TileMap.tileTypeAtPixel(cx + chw, cy - 1) & TileMap.T_LEFT) == TileMap.T_LEFT && cx <= TileMap.tileXofPixel(cx + chw) + 12)
			{
				cx = TileMap.tileXofPixel(cx + chw) - chw;
				cvx = 0;
			}
		}
		else if ((TileMap.tileTypeAtPixel(cx - chw, cy - 1) & TileMap.T_RIGHT) == TileMap.T_RIGHT && cx >= TileMap.tileXofPixel(cx - chw) + 12)
		{
			cx = TileMap.tileXofPixel(cx + 24 - chw) + chw;
			cvx = 0;
		}
		if (cvy == 0)
		{
			if (!isAttFly)
			{
				if (me)
				{
					setCharFallFromJump();
				}
				else
				{
					stop();
				}
			}
			else
			{
				setCharFallFromJump();
			}
		}
		if (me && !ischangingMap && isInWaypoint())
		{
			InfoDlg.hide();
			isSendMove = true;
			Service.gI().requestChangeMap();
			isLockKey = true;
			ischangingMap = true;
			GameCanvas.clearKeyHold();
			GameCanvas.clearKeyPressed();
			return;
		}
		if (cp3 < 0)
		{
			cp3++;
		}
		if (cy > ch && TileMap.tileTypeAt(cx, cy - ch, TileMap.T_BOTTOM))
		{
			if (me)
			{
				statusMe = 4;
				cp1 = 0;
				cp2 = 0;
				cvy = 1;
			}
			else
			{
				stop();
			}
		}
		if (!me && currentMovePoint != null && cy < currentMovePoint.yEnd)
		{
			stop();
		}
	}

	public bool checkInRangeJump(int x1, int xw1, int xmob, int y1, int yh1, int ymob)
	{
		if (xmob > xw1 || xmob < x1 || ymob > y1 || ymob < yh1)
		{
			return false;
		}
		return true;
	}

	public void setCharFallFromJump()
	{
		cyStartFall = cy;
		statusMe = 4;
		cp1 = 0;
		if (canJumpHigh)
		{
			cp2 = 1;
		}
		else
		{
			cp2 = 0;
		}
		cvy = 1;
		if (!me)
		{
		}
	}

	public void updateCharFall()
	{
		if (cy + 4 >= TileMap.pxh)
		{
			changeStatusStand();
			cvx = (cvy = 0);
			return;
		}
		if (cy % 24 == 0 && (TileMap.tileTypeAtPixel(cx, cy) & TileMap.T_TOP) == TileMap.T_TOP)
		{
			if (me)
			{
				cvx = (cvy = 0);
				cp1 = (cp2 = 0);
				changeStatusStand();
				return;
			}
			stop();
			cf = 0;
			GameCanvas.gI().startDust(-1, cx - -8, cy);
			GameCanvas.gI().startDust(1, cx - 8, cy);
		}
		cf = 12;
		cx += cvx;
		if (!me && currentMovePoint != null)
		{
			int num = currentMovePoint.xEnd - cx;
			if (num > 0)
			{
				if (cvx > num)
				{
					cvx = num;
				}
				if (cvx < 0)
				{
					cvx = num;
				}
			}
			else if (num < 0)
			{
				if (cvx < num)
				{
					cvx = num;
				}
				if (cvx > 0)
				{
					cvx = num;
				}
			}
			else
			{
				cvx = num;
			}
		}
		cy += cvy;
		if (cvy < 20)
		{
			cvy++;
		}
		if (cdir == 1)
		{
			if ((TileMap.tileTypeAtPixel(cx + chw, cy - 1) & TileMap.T_LEFT) == TileMap.T_LEFT && cx <= TileMap.tileXofPixel(cx + chw) + 12)
			{
				cx = TileMap.tileXofPixel(cx + chw) - chw;
				cvx = 0;
			}
		}
		else if ((TileMap.tileTypeAtPixel(cx - chw, cy - 1) & TileMap.T_RIGHT) == TileMap.T_RIGHT && cx >= TileMap.tileXofPixel(cx - chw) + 12)
		{
			cx = TileMap.tileXofPixel(cx + 24 - chw) + chw;
			cvx = 0;
		}
		if (cvy > 4 && (cyStartFall == 0 || cyStartFall <= TileMap.tileYofPixel(cy + 3)) && (TileMap.tileTypeAtPixel(cx, cy + 3) & TileMap.T_TOP) == TileMap.T_TOP)
		{
			if (me)
			{
				cyStartFall = 0;
				cvx = (cvy = 0);
				cp1 = (cp2 = 0);
				cy = TileMap.tileXofPixel(cy + 3);
				changeStatusStand();
				GameCanvas.gI().startDust(-1, cx - -8, cy);
				GameCanvas.gI().startDust(1, cx - 8, cy);
			}
			else
			{
				stop();
				cy = TileMap.tileXofPixel(cy + 3);
				cf = 0;
				GameCanvas.gI().startDust(-1, cx - -8, cy);
				GameCanvas.gI().startDust(1, cx - 8, cy);
			}
			return;
		}
		if (cp2 == 1)
		{
			if (cvy == 3)
			{
				cf = 11;
			}
			else if (cvy == 2)
			{
				cf = 8;
			}
			else if (cvy == 1)
			{
				cf = 9;
			}
			else if (cvy == 0)
			{
				cf = 10;
			}
		}
		else
		{
			cf = 12;
		}
		if (cvy > 6 && TileMap.tileTypeAt(cx, cy, TileMap.T_WATERFLOW) && cy % TileMap.size > 8)
		{
			cy = TileMap.tileYofPixel(cy) + 8;
			statusMe = 10;
			cvx = cdir << 1;
			cvy >>= 2;
			cy = TileMap.tileYofPixel(cy) + 12;
		}
		if (me)
		{
			if (!isAttack)
			{
			}
			return;
		}
		if ((TileMap.tileTypeAtPixel(cx, cy + 1) & TileMap.T_TOP) == TileMap.T_TOP)
		{
			cf = 0;
		}
		if (currentMovePoint != null && cy > currentMovePoint.yEnd)
		{
			stop();
		}
	}

	public void updateCharWaterRun()
	{
		if (!TileMap.tileTypeAt(cx, cy, TileMap.T_WATERFLOW))
		{
			statusMe = 4;
		}
		cp1++;
		if (cp1 >= 5)
		{
			cp1 = 0;
			cBonusSpeed = 0;
		}
		cf = cp1 + 2;
		if (cdir == 1)
		{
			if (TileMap.tileTypeAt(cx + chw, cy - 1, TileMap.T_LEFT))
			{
				cvx = 0;
				cx = TileMap.tileXofPixel(cx + chw) - chw;
			}
		}
		else if (TileMap.tileTypeAt(cx - chw - 1, cy - 1, TileMap.T_RIGHT))
		{
			cvx = 0;
			cx = TileMap.tileXofPixel(cx - chw - 1) + TileMap.size + chw;
		}
		cx += cvx;
		if (cvx > 0)
		{
			cvx--;
		}
		else if (cvx < 0)
		{
			cvx++;
		}
		else
		{
			if (me && mSystem.currentTimeMillis() - (timelastSendmove + delaySendmove) >= 0)
			{
				isSendMove = true;
			}
			statusMe = 11;
			cBonusSpeed = 0;
		}
		if (GameCanvas.gameTick % 8 == 0)
		{
		}
		GameCanvas.gI().startWaterSplash(cx, cy);
		GameCanvas.gI().startDust(cdir, cx - (cdir << 3), cy);
	}

	public void updateCharWaterDown()
	{
		cy += cvy;
		if (cvy < 20 && GameCanvas.gameTick % 2 == 0)
		{
			cvy++;
		}
		cf = 7;
		if (cy >= TileMap.pxh)
		{
			cHP = 0;
			statusMe = 5;
		}
		else if (TileMap.tileTypeAt(cx, cy, TileMap.T_TOP))
		{
			changeStatusStand();
			cvx = (cvy = 0);
			cp1 = (cp2 = 0);
			cy = TileMap.tileXofPixel(cy);
		}
		else if (TileMap.tileTypeAt(cx, cy, TileMap.T_UNDERWATER))
		{
			cHP = 0;
			statusMe = 5;
		}
	}

	public void setDefaultPart()
	{
		setDefaultWeapon();
		setDefaultBody();
		setDefaultLeg();
	}

	public void setDefaultWeapon()
	{
		wp = 15;
	}

	public Part getDefaultHead(int gender)
	{
		try
		{
			if (gender == 0)
			{
				return GameScr.parts[27];
			}
			return GameScr.parts[2];
		}
		catch (Exception)
		{
		}
		return null;
	}

	public void setDefaultBody()
	{
		if (cgender == 0)
		{
			body = 10;
		}
		else
		{
			body = 1;
		}
	}

	public void setDefaultLeg()
	{
		if (cgender == 0)
		{
			leg = 9;
		}
		else
		{
			leg = 0;
		}
	}

	public void setSkillPaint(SkillPaint skillPaint, int sType)
	{
		long currentTimeMillis = mSystem.getCurrentTimeMillis();
		if (me)
		{
			if (currentTimeMillis - myskill.lastTimeUseThisSkill < myskill.coolDown)
			{
				myskill.paintCanNotUseSkill = true;
				return;
			}
			myskill.lastTimeUseThisSkill = currentTimeMillis;
			cMP -= myskill.manaUse;
			if (cMP < 0)
			{
				cMP = 0;
			}
			playSound(skillPaint);
		}
		else if (isCharInScreen(this))
		{
			playSound(skillPaint);
		}
		setAutoSkillPaint(skillPaint, sType);
	}

	public void setAutoSkillPaint(SkillPaint skillPaint, int sType)
	{
		this.skillPaint = skillPaint;
		this.sType = sType;
		indexSkill = 0;
		i0 = (i1 = (i2 = (dx0 = (dx1 = (dx2 = (dy0 = (dy1 = (dy2 = 0))))))));
		eff0 = null;
		eff1 = null;
		eff2 = null;
	}

	public SkillInfoPaint[] skillInfoPaint1()
	{
		if (skillPaint == null)
		{
			return null;
		}
		if (sType == 0)
		{
			return skillPaint.skillStand;
		}
		return skillPaint.skillfly;
	}

	public void paintHead(mGraphics g, int xStart, int yStart)
	{
		Part part = GameScr.parts[head];
		Part part2 = GameScr.parts[leg];
		Part part3 = GameScr.parts[body];
		if (arrItemBody != null && arrItemBody[11] != null)
		{
			part = GameScr.parts[arrItemBody[11].template.part];
		}
		if (cdir == 1)
		{
			SmallImage.drawSmallImage(g, part.pi[CharInfo[cf][0][0]].id, xStart + CharInfo[cf][0][1] + part.pi[CharInfo[cf][0][0]].dx, yStart - CharInfo[cf][0][2] + part.pi[CharInfo[cf][0][0]].dy, 0, 0);
			SmallImage.drawSmallImage(g, part2.pi[CharInfo[cf][1][0]].id, xStart + CharInfo[cf][1][1] + part2.pi[CharInfo[cf][1][0]].dx, yStart - CharInfo[cf][1][2] + part2.pi[CharInfo[cf][1][0]].dy, 0, 0);
			SmallImage.drawSmallImage(g, part3.pi[CharInfo[cf][2][0]].id, xStart + CharInfo[cf][2][1] + part3.pi[CharInfo[cf][2][0]].dx, yStart - CharInfo[cf][2][2] + part3.pi[CharInfo[cf][2][0]].dy, 0, 0);
		}
		else
		{
			SmallImage.drawSmallImage(g, part.pi[CharInfo[cf][0][0]].id, xStart - CharInfo[cf][0][1] - part.pi[CharInfo[cf][0][0]].dx, yStart - CharInfo[cf][0][2] + part.pi[CharInfo[cf][0][0]].dy, 2, 24);
			SmallImage.drawSmallImage(g, part2.pi[CharInfo[cf][1][0]].id, xStart - CharInfo[cf][1][1] - part2.pi[CharInfo[cf][1][0]].dx, yStart - CharInfo[cf][1][2] + part2.pi[CharInfo[cf][1][0]].dy, 2, 24);
			SmallImage.drawSmallImage(g, part3.pi[CharInfo[cf][2][0]].id, xStart - CharInfo[cf][2][1] - part3.pi[CharInfo[cf][2][0]].dx, yStart - CharInfo[cf][2][2] + part3.pi[CharInfo[cf][2][0]].dy, 2, 24);
		}
	}

	public void setAttack()
	{
		int num = 0;
		try
		{
			GameCanvas.debug("SetAttk", 0);
			if (me)
			{
				num = 1;
				GameCanvas.debug("Sk1", 0);
				if (myskill.template.type == 2)
				{
					return;
				}
				if (myskill.template.id == 42 && !myskill.isCooldown())
				{
					isBlinking = true;
					timeStartBlink = mSystem.getCurrentTimeMillis();
				}
				GameCanvas.debug("Sk2", 0);
				if (skillPaint != null && (mobFocus != null || (charFocus != null && isMeCanAttackOtherPlayer(charFocus))))
				{
					int dx;
					int num2;
					if (isUseLongRangeWeapon())
					{
						dx = myskill.dx;
						num2 = myskill.dy;
					}
					else
					{
						dx = myskill.dx;
						num2 = myskill.dy;
					}
					GameCanvas.debug("Sk3", 0);
					MyVector myVector = new MyVector();
					MyVector myVector2 = new MyVector();
					if (charFocus != null)
					{
						GameCanvas.debug("Sk5", 0);
						myVector2.addElement(charFocus);
						for (int i = 0; i < GameScr.vCharInMap.size(); i++)
						{
							if (myVector.size() + myVector2.size() >= myskill.maxFight)
							{
								break;
							}
							Char @char = (Char)GameScr.vCharInMap.elementAt(i);
							if (@char.statusMe != 14 && @char.statusMe != 5 && @char.statusMe != 15 && !@char.isInvisible && !@char.Equals(charFocus) && isMeCanAttackOtherPlayer(@char) && charFocus.cx - dx <= @char.cx && @char.cx <= charFocus.cx + dx && charFocus.cy - num2 <= @char.cy && @char.cy <= charFocus.cy + num2 && ((cdir == -1 && @char.cx <= cx) || (cdir == 1 && @char.cx >= cx)))
							{
								myVector2.addElement(@char);
							}
						}
						for (int j = 0; j < GameScr.vMob.size(); j++)
						{
							if (myVector.size() + myVector2.size() >= myskill.maxFight)
							{
								break;
							}
							Mob mob = (Mob)GameScr.vMob.elementAt(j);
							if (mob.status != 1 && mob.status != 0 && charFocus.cx - dx <= mob.x && mob.x <= charFocus.cx + dx && charFocus.cy - num2 <= mob.y && mob.y <= charFocus.cy + num2 && ((cdir == -1 && mob.x <= cx) || (cdir == 1 && mob.x >= cx)))
							{
								myVector.addElement(mob);
							}
						}
					}
					else if (mobFocus != null && mobFocus.status != 1 && mobFocus.status != 0)
					{
						GameCanvas.debug("Sk6", 0);
						myVector.addElement(mobFocus);
						for (int k = 0; k < GameScr.vMob.size(); k++)
						{
							if (myVector.size() + myVector2.size() >= myskill.maxFight)
							{
								break;
							}
							Mob mob2 = (Mob)GameScr.vMob.elementAt(k);
							if (mob2.status != 1 && mob2.status != 0 && !mob2.Equals(mobFocus) && mobFocus.x - 100 <= mob2.x && mob2.x <= mobFocus.x + 100 && mobFocus.y - 50 <= mob2.y && mob2.y <= mobFocus.y + 50)
							{
								myVector.addElement(mob2);
							}
						}
						for (int l = 0; l < GameScr.vCharInMap.size(); l++)
						{
							if (myVector.size() + myVector2.size() >= myskill.maxFight)
							{
								break;
							}
							Char char2 = (Char)GameScr.vCharInMap.elementAt(l);
							if (char2.statusMe != 14 && char2.statusMe != 5 && char2.statusMe != 15 && !char2.isInvisible && ((cTypePk >= PK_PHE1 && cTypePk <= PK_PHE3 && char2.cTypePk >= PK_PHE1 && char2.cTypePk <= PK_PHE3 && cTypePk != char2.cTypePk) || char2.cTypePk == 3 || cTypePk == 3 || (char2.cTypePk == PK_NHOM && cTypePk == PK_NHOM) || (testCharId >= 0 && testCharId == char2.charID) || (killCharId >= 0 && killCharId == char2.charID)) && mobFocus.x - dx <= char2.cx && char2.cx <= mobFocus.x + dx && mobFocus.y - num2 <= char2.cy && char2.cy <= mobFocus.y + num2 && ((cdir == -1 && char2.cx <= cx) || (cdir == 1 && char2.cx >= cx)))
							{
								myVector2.addElement(char2);
							}
						}
					}
					GameCanvas.debug("Sk7", 0);
					effPaints = new EffectPaint[myVector.size() + myVector2.size()];
					for (int m = 0; m < myVector.size(); m++)
					{
						effPaints[m] = new EffectPaint();
						effPaints[m].effCharPaint = GameScr.efs[skillPaint.effId - 1];
						effPaints[m].eMob = (Mob)myVector.elementAt(m);
					}
					for (int n = 0; n < myVector2.size(); n++)
					{
						effPaints[n + myVector.size()] = new EffectPaint();
						effPaints[n + myVector.size()].effCharPaint = GameScr.efs[skillPaint.effId - 1];
						effPaints[n + myVector.size()].eChar = (Char)myVector2.elementAt(n);
					}
					GameCanvas.debug("Sk8", 0);
					if (effPaints.Length > 1)
					{
						EPosition firstPos = new EPosition();
						if (effPaints[0].eMob != null)
						{
							firstPos = new EPosition(effPaints[0].eMob.x, effPaints[0].eMob.y);
						}
						else if (effPaints[0].eChar != null)
						{
							firstPos = new EPosition(effPaints[0].eChar.cx, effPaints[0].eChar.cy);
						}
						MyVector myVector3 = new MyVector();
						for (int num3 = 1; num3 < effPaints.Length; num3++)
						{
							if (effPaints[num3].eMob != null)
							{
								myVector3.addElement(new EPosition(effPaints[num3].eMob.x, effPaints[num3].eMob.y));
							}
							else if (effPaints[num3].eChar != null)
							{
								myVector3.addElement(new EPosition(effPaints[num3].eChar.cx, effPaints[num3].eChar.cy));
							}
							if (num3 > 5)
							{
								break;
							}
						}
						Lightning.addLight(myVector3, firstPos, isContinue: true, getClassColor());
					}
					GameCanvas.debug("Sk9", 0);
					int type = 0;
					if (mobFocus != null)
					{
						type = 1;
					}
					else if (charFocus != null)
					{
						type = 2;
					}
					if (me)
					{
						Service.gI().sendPlayerAttack(myVector, myVector2, type);
					}
					GameCanvas.debug("SkA", 0);
				}
			}
			else if (skillPaint != null && (mobFocus != null || charFocus != null))
			{
				num = 2;
				GameCanvas.debug("SkB", 0);
				if (attMobs != null && attChars != null)
				{
					num = 3;
					effPaints = new EffectPaint[attMobs.Length + attChars.Length];
					for (int num4 = 0; num4 < attMobs.Length; num4++)
					{
						effPaints[num4] = new EffectPaint();
						effPaints[num4].effCharPaint = GameScr.efs[skillPaint.effId - 1];
						effPaints[num4].eMob = attMobs[num4];
					}
					for (int num5 = 0; num5 < attChars.Length; num5++)
					{
						effPaints[num5 + attMobs.Length] = new EffectPaint();
						effPaints[num5 + attMobs.Length].effCharPaint = GameScr.efs[skillPaint.effId - 1];
						effPaints[num5 + attMobs.Length].eChar = attChars[num5];
					}
					attMobs = null;
					attChars = null;
				}
				else if (attMobs != null)
				{
					num = 4;
					effPaints = new EffectPaint[attMobs.Length];
					for (int num6 = 0; num6 < attMobs.Length; num6++)
					{
						effPaints[num6] = new EffectPaint();
						effPaints[num6].effCharPaint = GameScr.efs[skillPaint.effId - 1];
						effPaints[num6].eMob = attMobs[num6];
					}
					attMobs = null;
				}
				else if (attChars != null)
				{
					num = 5;
					effPaints = new EffectPaint[attChars.Length];
					for (int num7 = 0; num7 < attChars.Length; num7++)
					{
						effPaints[num7] = new EffectPaint();
						effPaints[num7].effCharPaint = GameScr.efs[skillPaint.effId - 1];
						effPaints[num7].eChar = attChars[num7];
					}
					attChars = null;
				}
				GameCanvas.debug("SkC", 0);
				num = 6;
				if (effPaints.Length > 1 && effPaints[0] != null)
				{
					num = 7;
					EPosition firstPos2 = new EPosition();
					if (effPaints[0].eMob != null)
					{
						firstPos2 = new EPosition(effPaints[0].eMob.x, effPaints[0].eMob.y);
					}
					else if (effPaints[0].eChar != null)
					{
						firstPos2 = new EPosition(effPaints[0].eChar.cx, effPaints[0].eChar.cy);
					}
					num = 8;
					MyVector myVector4 = new MyVector();
					for (int num8 = 1; num8 < effPaints.Length; num8++)
					{
						if (effPaints[num8].eMob != null)
						{
							myVector4.addElement(new EPosition(effPaints[num8].eMob.x, effPaints[num8].eMob.y));
						}
						else if (effPaints[num8].eChar != null)
						{
							myVector4.addElement(new EPosition(effPaints[num8].eChar.cx, effPaints[num8].eChar.cy));
						}
						if (num8 > 5)
						{
							break;
						}
					}
					num = 9;
					Lightning.addLight(myVector4, firstPos2, isContinue: true, getClassColor());
				}
				GameCanvas.debug("SkD", 0);
			}
			GameCanvas.debug("SkE", 0);
		}
		catch (Exception)
		{
		}
	}

	public bool isHaveWolf()
	{
		if (ID_HORSE > -1)
		{
			return false;
		}
		if (arrItemMounts != null && arrItemMounts[4] != null && arrItemMounts[4].template != null && (arrItemMounts[4].template.id == 443 || arrItemMounts[4].template.id == 523))
		{
			return true;
		}
		return false;
	}

	public bool isHaveMoto()
	{
		if (ID_HORSE > -1)
		{
			return false;
		}
		if (arrItemMounts != null && arrItemMounts[4] != null && arrItemMounts[4].template != null && (arrItemMounts[4].template.id == 485 || arrItemMounts[4].template.id == 524))
		{
			return true;
		}
		return false;
	}

	public bool isPaint()
	{
		if (cx < GameScr.cmx)
		{
			return false;
		}
		if (cx > GameScr.cmx + GameScr.gW)
		{
			return false;
		}
		if (cy < GameScr.cmy)
		{
			return false;
		}
		if (cy > GameScr.cmy + GameScr.gH + 30)
		{
			return false;
		}
		return true;
	}

	public static DataSkillEff getPartEff(short id, bool ishorse)
	{
		if (id == -1)
		{
			return null;
		}
		DataSkillEff dataSkillEff = (DataSkillEff)ALL_PART_EFF.get(id + string.Empty);
		if (dataSkillEff == null)
		{
			dataSkillEff = new DataSkillEff(id, ishorse);
			ALL_PART_EFF.put(id + string.Empty, dataSkillEff);
			dataSkillEff.timeRemove = (int)(mSystem.currentTimeMillis() / 1000);
		}
		else
		{
			dataSkillEff.timeRemove = mSystem.currentTimeMillis();
		}
		return dataSkillEff;
	}

	public static void SetRemove()
	{
		IDictionaryEnumerator enumerator = ALL_PART_EFF.GetEnumerator();
		MyVector myVector = new MyVector();
		while (enumerator.MoveNext())
		{
			string text = enumerator.Key.ToString();
			DataSkillEff dataSkillEff = (DataSkillEff)ALL_PART_EFF.get(text);
			if (mSystem.currentTimeMillis() / 1000 - dataSkillEff.timeRemove > 60)
			{
				myVector.addElement(text);
			}
			for (int i = 0; i < myVector.size(); i++)
			{
				string k = (string)myVector.elementAt(i);
				ALL_PART_EFF.remove(k);
			}
		}
	}

	public virtual void paint(mGraphics g)
	{
		if (!isPaint())
		{
			if (skillPaint != null)
			{
				indexSkill = skillInfoPaint1().Length;
				skillPaint = null;
				effPaints = null;
				eff = null;
				effTask = null;
				indexEff = -1;
				indexEffTask = -1;
			}
			return;
		}
		paintBottomDataEff(g, cx, cy, -heightCharName);
		if (statusMe == 15 || (moveFast != null && moveFast[0] > 0))
		{
			return;
		}
		if (statusMe == 1 || statusMe == 6)
		{
			paint_No(g);
		}
		paintCharName_HP_MP_Overhead(g);
		if (skillPaint != null && indexSkill < skillInfoPaint1().Length)
		{
			paintCharWithSkill(g);
		}
		else
		{
			paintCharWithoutSkill(g);
		}
		paintArrowAttack(g);
		if (effPaints != null)
		{
			for (int i = 0; i < effPaints.Length; i++)
			{
				if (effPaints[i] == null)
				{
					continue;
				}
				if (effPaints[i].eMob != null)
				{
					if (!effPaints[i].isFly)
					{
						effPaints[i].eMob.setInjure();
						effPaints[i].eMob.injureBy = this;
						if (me)
						{
							effPaints[i].eMob.hpInjure = getMyChar().cdame / 2 - getMyChar().cdame * NinjaUtil.randomNumber(11) / 100;
						}
						if (effPaints[i].eMob.templateId != 98 && effPaints[i].eMob.templateId != 99)
						{
							GameScr.startSplash(effPaints[i].eMob.x, effPaints[i].eMob.y - (effPaints[i].eMob.h >> 1), cdir);
						}
						effPaints[i].isFly = true;
					}
					SmallImage.drawSmallImage(g, effPaints[i].getImgId(), effPaints[i].eMob.x, effPaints[i].eMob.y, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
				}
				else if (effPaints[i].eChar != null)
				{
					if (!effPaints[i].isFly)
					{
						if (effPaints[i].eChar.charID >= 0)
						{
							effPaints[i].eChar.doInjure();
						}
						GameScr.startSplash(effPaints[i].eChar.cx, effPaints[i].eChar.cy - (effPaints[i].eChar.ch >> 1), cdir);
						effPaints[i].isFly = true;
					}
					SmallImage.drawSmallImage(g, effPaints[i].getImgId(), effPaints[i].eChar.cx, effPaints[i].eChar.cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
				}
				effPaints[i].index++;
				if (effPaints[i].index >= effPaints[i].effCharPaint.arrEfInfo.Length)
				{
					effPaints[i] = null;
				}
			}
		}
		if (indexEff >= 0 && eff != null)
		{
			SmallImage.drawSmallImage(g, eff.arrEfInfo[indexEff].idImg, cx + eff.arrEfInfo[indexEff].dx, cy + eff.arrEfInfo[indexEff].dy, 0, mGraphics.VCENTER | mGraphics.HCENTER);
			if (Main.isPC)
			{
				if (GameCanvas.gameTick % 2 == 0)
				{
					indexEff++;
					if (indexEff >= eff.arrEfInfo.Length)
					{
						indexEff = -1;
						eff = null;
					}
				}
			}
			else
			{
				indexEff++;
				if (indexEff >= eff.arrEfInfo.Length)
				{
					indexEff = -1;
					eff = null;
				}
			}
		}
		if (indexEffTask >= 0 && effTask != null)
		{
			SmallImage.drawSmallImage(g, effTask.arrEfInfo[indexEffTask].idImg, cx + effTask.arrEfInfo[indexEffTask].dx, cy + effTask.arrEfInfo[indexEffTask].dy, 0, mGraphics.VCENTER | mGraphics.HCENTER);
			if (GameCanvas.gameTick % 2 == 0)
			{
				indexEffTask++;
				if (indexEffTask >= effTask.arrEfInfo.Length)
				{
					indexEffTask = -1;
					effTask = null;
				}
			}
		}
		if (isEffBatTu)
		{
			if (count < 2)
			{
				SmallImage.drawSmallImage(g, 1366, cx, cy - chh, 0, mGraphics.VCENTER | mGraphics.HCENTER);
			}
			else if (count < 4)
			{
				SmallImage.drawSmallImage(g, 1367, cx, cy - chh, 0, mGraphics.VCENTER | mGraphics.HCENTER);
			}
			else if (count < 8)
			{
				SmallImage.drawSmallImage(g, 1368, cx, cy - chh, 0, mGraphics.VCENTER | mGraphics.HCENTER);
			}
			else if (GameCanvas.gameTick % 2 == 0)
			{
				SmallImage.drawSmallImage(g, 1369, cx, cy - chh, 0, mGraphics.VCENTER | mGraphics.HCENTER);
			}
			else
			{
				SmallImage.drawSmallImage(g, 1370, cx, cy - chh, 0, mGraphics.VCENTER | mGraphics.HCENTER);
			}
		}
		if (mobMe != null)
		{
			mobMe.paint(g);
		}
		if (statusMe != 1 && statusMe != 6)
		{
			for (int j = 0; j < vDomsang.size(); j++)
			{
				Domsang domsang = (Domsang)vDomsang.elementAt(j);
				domsang.paint(g);
			}
		}
		paintTopDataEff(g, cx, cy, -heightCharName);
	}

	private void paintArrowAttack(mGraphics g)
	{
		if (arr != null)
		{
			arr.paint(g);
		}
	}

	public void paintHp(mGraphics g, int px, int py)
	{
		int num = cHP * 26 / cMaxHP;
		if (statusMe != 5 && statusMe != 14 && num < 2)
		{
			num = 2;
		}
		else if (statusMe == 5 || statusMe == 14)
		{
			num = 0;
		}
		if (num > 26)
		{
			num = 0;
		}
		g.setColor(16777215);
		g.fillRect(px, py, 26, 4);
		g.setColor(getClassColor());
		g.fillRect(px, py, num, 4);
		g.setColor(0);
		g.drawRect(px, py, 26, 4);
	}

	public void startCoatEffect(int x, int y)
	{
		if (isWolf && arrItemMounts[4].sys >= 4 && getSys() > 0 && GameCanvas.gameTick % 8 == 0)
		{
			if (getSys() == 1)
			{
				ServerEffect.addServerEffect(116, x, y, 2);
			}
			else if (getSys() == 2)
			{
				ServerEffect.addServerEffect(117, x, y, 2);
			}
			else if (getSys() == 3)
			{
				ServerEffect.addServerEffect(118, x, y, 2);
			}
		}
	}

	public int[] getClassCoat()
	{
		int[] result = null;
		int num = -1;
		if (me)
		{
			if (arrItemBody[12] != null)
			{
				num = arrItemBody[12].template.id;
			}
		}
		else
		{
			num = coat;
		}
		switch (num)
		{
		case -1:
			return null;
		case 420:
			result = ((!isWolf && !isMoto && !isNewMount) ? new int[4] { 1635, 1636, 1637, 1636 } : new int[4] { 2029, 2030, 2031, 2030 });
			break;
		case 421:
			result = ((!isWolf && !isMoto && !isNewMount) ? new int[4] { 1652, 1653, 1654, 1653 } : new int[4] { 2035, 2036, 2037, 2036 });
			break;
		case 422:
			result = ((!isWolf && !isMoto && !isNewMount) ? new int[4] { 1655, 1656, 1657, 1656 } : new int[4] { 2032, 2033, 2034, 2033 });
			break;
		}
		return result;
	}

	public int getClassColor()
	{
		int result = 9145227;
		if (nClass.classId == 1 || nClass.classId == 2)
		{
			result = 16711680;
		}
		else if (nClass.classId == 3 || nClass.classId == 4)
		{
			result = 33023;
		}
		else if (nClass.classId == 5 || nClass.classId == 6)
		{
			result = 7443811;
		}
		return result;
	}

	public void paintNameInSameParty(mGraphics g)
	{
		if (isPaint())
		{
			if (getMyChar().charFocus == null || !getMyChar().charFocus.Equals(this))
			{
				mFont.tahoma_7_yellow.drawString(g, cName, cx, cy - (ch + 5 + mFont.tahoma_7.getHeight()), mFont.CENTER);
			}
			else if (getMyChar().charFocus != null && getMyChar().charFocus.Equals(this))
			{
				mFont.tahoma_7_yellow.drawString(g, cName, cx, cy - ch - mFont.tahoma_7_green.getHeight() - 10, mFont.CENTER, mFont.tahoma_7_grey);
			}
		}
	}

	public void paintCharName_HP_MP_Overhead(mGraphics g)
	{
		heightCharName = ch + 5;
		heightCharName += ((isWolf || isMoto || isNewMount) ? 15 : 0);
		if (ID_HORSE > -1)
		{
			DataSkillEff partEff = getPartEff(ID_HORSE, ishorse: true);
			if (partEff != null && partEff.isLoadData)
			{
				heightCharName += partEff.dyHorse;
			}
		}
		if (isInvisible && !me)
		{
			return;
		}
		bool flag = false;
		if (me)
		{
			if (GameScr.auto == 1)
			{
				if (!GameScr.gI().lockAutoMove)
				{
					heightCharName += mFont.tahoma_7.getHeight();
					mFont.tahoma_7_yellow.drawString(g, mResources.AUTO_FIRE, cx, cy - heightCharName, mFont.CENTER, mFont.tahoma_7_grey);
					heightCharName++;
				}
				else
				{
					heightCharName += mFont.tahoma_7.getHeight();
					mFont.tahoma_7_yellow.drawString(g, mResources.UNMOVE, cx, cy - heightCharName, mFont.CENTER, mFont.tahoma_7_grey);
					heightCharName++;
				}
			}
			else if (npcFocus == null && charFocus == null && mobFocus == null && itemFocus == null)
			{
				flag = true;
				heightCharName += mFont.tahoma_7.getHeight();
				if (!isHumanz())
				{
					mFont.tahoma_7_blue1.drawString(g, cName, cx, cy - heightCharName, mFont.CENTER, mFont.tahoma_7_grey);
				}
				else if (ID_NAME < 0)
				{
					mFont.tahoma_7_white.drawString(g, cName, cx, cy - heightCharName, mFont.CENTER, mFont.tahoma_7_grey);
				}
				heightCharName++;
			}
		}
		else if (getMyChar().charFocus != null && getMyChar().charFocus.Equals(this))
		{
			flag = true;
			heightCharName += 5;
			paintHp(g, cx - 13, cy - heightCharName);
			heightCharName += mFont.tahoma_7.getHeight();
			if (!isHumanz())
			{
				mFont.tahoma_7_blue1.drawString(g, cName, cx, cy - heightCharName, mFont.CENTER, mFont.tahoma_7_grey);
			}
			else
			{
				mFont.tahoma_7_white.drawString(g, cName, cx, cy - heightCharName, mFont.CENTER, mFont.tahoma_7_grey);
			}
			heightCharName++;
		}
		else if (paintName)
		{
			flag = true;
			heightCharName += mFont.tahoma_7.getHeight();
			if (!isHumanz())
			{
				mFont.tahoma_7_blue1.drawString(g, cName, cx, cy - heightCharName, mFont.CENTER, mFont.tahoma_7_grey);
			}
			else
			{
				mFont.tahoma_7_white.drawString(g, cName, cx, cy - heightCharName, mFont.CENTER, mFont.tahoma_7_grey);
			}
			heightCharName++;
		}
		if (charID == -getMyChar().charID)
		{
			heightCharName += mFont.tahoma_7.getHeight();
			mFont.tahoma_7_yellow.drawString(g, mResources.BY + " " + getMyChar().cName + " " + mResources.PROTECT, cx, cy - heightCharName, mFont.CENTER, mFont.tahoma_7_grey);
			heightCharName++;
		}
		if (!cClanName.Equals(string.Empty) && flag)
		{
			heightCharName += mFont.tahoma_7.getHeight() - 1;
			int num = 0;
			if (ctypeClan > 0)
			{
				num = 5;
			}
			mFont.tahoma_7_white.drawString(g, cClanName, cx + num, cy - heightCharName, mFont.CENTER, mFont.tahoma_7_blue);
			if (ctypeClan == 3)
			{
				SmallImage.drawSmallImage(g, 1215, cx - (mFont.tahoma_7_white.getWidth(cClanName) / 2 + (7 - num)), cy - heightCharName + 1, 0, mGraphics.HCENTER | mGraphics.TOP);
			}
			else if (ctypeClan == 4)
			{
				SmallImage.drawSmallImage(g, 1216, cx - (mFont.tahoma_7_white.getWidth(cClanName) / 2 + (7 - num)), cy - heightCharName + 1, 0, mGraphics.HCENTER | mGraphics.TOP);
			}
			else if (ctypeClan == 2)
			{
				SmallImage.drawSmallImage(g, 1217, cx - (mFont.tahoma_7_white.getWidth(cClanName) / 2 + (7 - num)), cy - heightCharName + 1, 0, mGraphics.HCENTER | mGraphics.TOP);
			}
			heightCharName++;
		}
		if (resultTest > 0 && resultTest < 30)
		{
			heightCharName += SmallImage.smallImg[1117][4];
			SmallImage.drawSmallImage(g, 1117, cx, cy - heightCharName, 0, mGraphics.HCENTER | mGraphics.TOP);
			heightCharName++;
		}
		else if (resultTest > 30 && resultTest < 60)
		{
			heightCharName += SmallImage.smallImg[1117][4];
			SmallImage.drawSmallImage(g, 1126, cx, cy - heightCharName, 0, mGraphics.HCENTER | mGraphics.TOP);
			heightCharName++;
		}
		else if (resultTest > 60 && resultTest < 90)
		{
			heightCharName += SmallImage.smallImg[1117][4];
			SmallImage.drawSmallImage(g, 1118, cx, cy - heightCharName, 0, mGraphics.HCENTER | mGraphics.TOP);
			heightCharName++;
		}
		else if (charID >= 0)
		{
			if (killCharId >= 0)
			{
				heightCharName += SmallImage.smallImg[1122][4];
				SmallImage.drawSmallImage(g, 1122, cx, cy - heightCharName, 0, mGraphics.HCENTER | mGraphics.TOP);
				heightCharName++;
			}
			else if (cTypePk == 3)
			{
				heightCharName += SmallImage.smallImg[1121][4];
				SmallImage.drawSmallImage(g, 1121, cx, cy - heightCharName, 0, mGraphics.HCENTER | mGraphics.TOP);
				heightCharName++;
			}
			else if (cTypePk == 2)
			{
				heightCharName += SmallImage.smallImg[1124][4];
				SmallImage.drawSmallImage(g, 1124, cx, cy - heightCharName, 0, mGraphics.HCENTER | mGraphics.TOP);
				heightCharName++;
			}
			else if (cTypePk == PK_NHOM)
			{
				heightCharName += SmallImage.smallImg[1123][4];
				SmallImage.drawSmallImage(g, 1123, cx, cy - heightCharName, 0, mGraphics.HCENTER | mGraphics.TOP);
				heightCharName++;
			}
			else if (cTypePk == PK_PHE1)
			{
				heightCharName += SmallImage.smallImg[1240][4];
				SmallImage.drawSmallImage(g, 1240, cx, cy - heightCharName, 0, mGraphics.HCENTER | mGraphics.TOP);
				heightCharName++;
			}
			else if (cTypePk == PK_PHE2)
			{
				heightCharName += SmallImage.smallImg[1241][4];
				SmallImage.drawSmallImage(g, 1241, cx, cy - heightCharName, 0, mGraphics.HCENTER | mGraphics.TOP);
				heightCharName++;
			}
			else if (cTypePk == PK_PHE3)
			{
				heightCharName += SmallImage.smallImg[1241][4];
				SmallImage.drawSmallImage(g, 1123, cx, cy - heightCharName, 0, mGraphics.HCENTER | mGraphics.TOP);
				heightCharName++;
			}
			else if (testCharId > 0)
			{
				heightCharName += SmallImage.smallImg[1116][4];
				SmallImage.drawSmallImage(g, 1116, cx, cy - heightCharName, 0, mGraphics.HCENTER | mGraphics.TOP);
				heightCharName++;
			}
		}
	}

	public void loadFromServer()
	{
		for (int i = 0; i < 26; i++)
		{
			int num = getBodyPaintId() + i;
			Image image = (Image)SmallImage.imgNew.get(num + string.Empty);
			if (image == null)
			{
				SmallImage.imgNew.put(num + string.Empty, SmallImage.imgEmpty);
				Service.gI().requestIcon(num);
			}
			if (i == 25)
			{
				break;
			}
		}
	}

	public sbyte getFrameHores()
	{
		DataSkillEff partEff = getPartEff(ID_HORSE, ishorse: true);
		if (partEff == null || !partEff.isLoadData)
		{
			return 0;
		}
		if (statusMe == 1 || statusMe == 6)
		{
			ActionHorse = partEff.ActionStand;
		}
		else if (statusMe == 2 || statusMe == 10)
		{
			ActionHorse = partEff.ActionMove;
		}
		else if (statusMe == 4)
		{
			ActionHorse = partEff.ActionFall;
		}
		else if (statusMe == 3)
		{
			ActionHorse = partEff.ActionJum;
		}
		else
		{
			ActionHorse = partEff.ActionStand;
		}
		if (fho >= ActionHorse.Length)
		{
			return (sbyte)(ActionHorse[ActionHorse.Length - 1] + FrameHorse * partEff.nHorseFrame);
		}
		return (sbyte)(ActionHorse[fho] + FrameHorse * partEff.nHorseFrame);
	}

	public int getFrameHorseui(int fr)
	{
		return fr + fHorseUI * 30;
	}

	public void paintHorseUI(mGraphics g, int x, int y, int f)
	{
		DataSkillEff partEff = getPartEff(ID_HORSE, ishorse: true);
		if (partEff == null || !partEff.isLoadData)
		{
			return;
		}
		if (GameCanvas.gameTick % 10 == 0)
		{
			int num = partEff.listFrame.size() / partEff.sequence.Length;
			if (num == 0)
			{
				num = 1;
			}
			fHorseUI = (byte)((fHorseUI + 1) % num);
		}
		partEff.paintBottomEff_new(g, x, y, getFrameHorseui(f), 2);
		partEff.paintTopEff_new(g, x, y, getFrameHorseui(f), 2);
	}

	public int getFrameBienHinh()
	{
		if (isMoto || isWolf || isNewMount || ID_HORSE > -1)
		{
			if (statusMe == 1 || statusMe == 6)
			{
				return cf + FrameBienHinh * 30;
			}
			return fRun_PP[fBienhinh] + FrameBienHinh * 30;
		}
		return cf + FrameBienHinh * 30;
	}

	public int getFrameLeg()
	{
		if (isMoto || isWolf || isNewMount || ID_HORSE > -1)
		{
			if (statusMe == 1 || statusMe == 6)
			{
				return cf + FrameLeg * 30;
			}
			return fRun_PP[fLeg] + FrameLeg * 30;
		}
		return cf + FrameLeg * 30;
	}

	public void paintMatna(mGraphics g, int cx, int cy, int f)
	{
		if (ID_MAT_NA < 0)
		{
			return;
		}
		DataSkillEff partEff = getPartEff(ID_MAT_NA, ishorse: false);
		int num = 0;
		if ((statusMe == 1 || statusMe == 6) && cf <= 1)
		{
			num = cf * f;
		}
		if (partEff == null)
		{
			return;
		}
		if (isWolf && (arrItemMounts[4].template.id == 443 || arrItemMounts[4].template.id == 523))
		{
			int num2 = -2;
			if (statusMe == 1 || statusMe == 6)
			{
				num2 = 0;
			}
			int num3 = 0;
			if (cgender == 1)
			{
				num3 = 3;
			}
			if (statusMe == 1 || statusMe == 6)
			{
				num3 = 0;
			}
			partEff.paintBottomEff_new(g, cx + num2, cy + num - getys() - num3, (statusMe != 1 && statusMe != 6) ? (5 + FrameMatna * 30) : getFrameMatna(), (cdir != 1) ? 2 : 0);
			partEff.paintTopEff_new(g, cx + num2, cy + num - getys() - num3, (statusMe != 1 && statusMe != 6) ? (5 + FrameMatna * 30) : getFrameMatna(), (cdir != 1) ? 2 : 0);
		}
		else
		{
			partEff.paintBottomEff_new(g, cx + getxs(), cy + num - getys(), (statusMe != 1 && statusMe != 6) ? (5 + FrameMatna * 30) : getFrameMatna(), (cdir != 1) ? 2 : 0);
			partEff.paintTopEff_new(g, cx + getxs(), cy + num - getys(), (statusMe != 1 && statusMe != 6) ? (5 + FrameMatna * 30) : getFrameMatna(), (cdir != 1) ? 2 : 0);
		}
	}

	public int getFrameMatna()
	{
		if (isMoto || isWolf || isNewMount)
		{
			if (statusMe == 1 || statusMe == 6)
			{
				return cf + FrameMatna * 30;
			}
			return fRun_PP[fMatNa] + FrameMatna * 30;
		}
		return cf + FrameMatna * 30;
	}

	public int getFrameWeapone()
	{
		if (isMoto || isWolf || isNewMount)
		{
			if (statusMe == 1 || statusMe == 6)
			{
				return cf + FrameWeaPone * 30;
			}
			return fRun_PP[fWeapone] + FrameWeaPone * 30;
		}
		return cf + FrameWeaPone * 30;
	}

	public int getFrameBody()
	{
		if (isMoto || isWolf || isNewMount)
		{
			if (statusMe == 1 || statusMe == 6)
			{
				return cf + FrameBody * 30;
			}
			return fRun_PP[fBody] + FrameBody * 30;
		}
		return cf + FrameBody * 30;
	}

	public int getFrameHair()
	{
		if (isMoto || isWolf || isNewMount)
		{
			if (statusMe == 1 || statusMe == 6)
			{
				return cf + FrameHair * 30;
			}
			return fRun_PP[fHair] + FrameHair * 30;
		}
		return cf + FrameHair * 30;
	}

	public int getFramePP()
	{
		if (isMoto || isWolf || isNewMount || ID_HORSE > -1)
		{
			if (statusMe == 1 || statusMe == 6)
			{
				return cf + FramePP * 30;
			}
			return fRun_PP[fPP] + FramePP * 30;
		}
		return cf + FramePP * 30;
	}

	public void paintLeg(mGraphics g, int cx, int cy, int f)
	{
		DataSkillEff partEff = getPartEff(ID_LEG, ishorse: false);
		int num = 0;
		if ((statusMe == 1 || statusMe == 6) && cf <= 1)
		{
			num = cf * f;
		}
		if (partEff != null)
		{
			partEff.paintBottomEff_new(g, cx, cy + num, (statusMe != 1 && statusMe != 6) ? (5 + FrameLeg * 30) : getFrameLeg(), (cdir != 1) ? 2 : 0);
			partEff.paintTopEff_new(g, cx, cy + num, (statusMe != 1 && statusMe != 6) ? (5 + FrameLeg * 30) : getFrameLeg(), (cdir != 1) ? 2 : 0);
		}
	}

	public int getFramePP(int fr)
	{
		return fr + fPPUI * 30;
	}

	public int getFrameHeadUI(int fr)
	{
		return fr + fHeadUI * 30;
	}

	public int getFrameBodyUI(int fr)
	{
		return fr + FbodyUI * 30;
	}

	public int getFrameLegUI(int fr)
	{
		return fr + FlegUI * 30;
	}

	public void paintPPUIBot(mGraphics g, int cx, int cy, int f)
	{
		getPartEff(ID_PP, ishorse: false)?.paintBottomEff_new(g, cx, cy, getFramePP(f), 0);
	}

	public void paintPPUITop(mGraphics g, int cx, int cy, int f)
	{
		DataSkillEff partEff = getPartEff(ID_PP, ishorse: false);
		if (partEff == null)
		{
			return;
		}
		if (GameCanvas.gameTick % 10 == 0)
		{
			int num = partEff.listFrame.size() / 30;
			if (num == 0)
			{
				num = 1;
			}
			fPPUI = (byte)((fPPUI + 1) % num);
		}
		partEff.paintTopEff_new(g, cx, cy, getFramePP(f), 0);
	}

	public int getFrameWeaponUI(int fr)
	{
		return fr + fWeaponUI * 30;
	}

	public int getFrameMatNaUI(int fr)
	{
		return fr + fMatNaUI * 30;
	}

	public void paintMatNaUI(mGraphics g, int cx, int cy, int f)
	{
		DataSkillEff partEff = getPartEff(ID_MAT_NA, ishorse: false);
		if (partEff == null)
		{
			return;
		}
		if (GameCanvas.gameTick % 6 == 0)
		{
			int num = partEff.listFrame.size() / 30;
			if (num == 0)
			{
				num = 1;
			}
			fMatNaUI = (byte)((fMatNaUI + 1) % num);
		}
		partEff.paintTopEff_new(g, cx, cy, getFrameMatNaUI(f), 0);
		partEff.paintBottomEff_new(g, cx, cy, getFrameMatNaUI(f), 0);
	}

	public void paintWeaponUITop(mGraphics g, int cx, int cy, int f)
	{
		DataSkillEff partEff = getPartEff(ID_WEA_PONE, ishorse: false);
		if (partEff == null)
		{
			return;
		}
		if (GameCanvas.gameTick % 6 == 0)
		{
			int num = partEff.listFrame.size() / 30;
			if (num == 0)
			{
				num = 1;
			}
			fWeaponUI = (byte)((fWeaponUI + 1) % num);
		}
		partEff.paintTopEff_new(g, cx, cy, getFrameWeaponUI(f), 0);
	}

	public void paintWeaponUIBot(mGraphics g, int cx, int cy, int f)
	{
		DataSkillEff partEff = getPartEff(ID_WEA_PONE, ishorse: false);
		if (partEff == null)
		{
			return;
		}
		if (GameCanvas.gameTick % 6 == 0)
		{
			int num = partEff.listFrame.size() / 30;
			if (num == 0)
			{
				num = 1;
			}
			fWeaponUI = (byte)((fWeaponUI + 1) % num);
		}
		partEff.paintBottomEff_new(g, cx, cy, getFrameWeaponUI(f), 0);
	}

	public void paintHeadUI(mGraphics g, int cx, int cy, int f)
	{
		DataSkillEff partEff = getPartEff(ID_HAIR, ishorse: false);
		if (partEff == null)
		{
			return;
		}
		if (GameCanvas.gameTick % 6 == 0)
		{
			int num = partEff.listFrame.size() / 30;
			if (num == 0)
			{
				num = 1;
			}
			fHeadUI = (byte)((fHeadUI + 1) % num);
		}
		partEff.paintBottomEff_new(g, cx, cy, getFrameHeadUI(f), 0);
		partEff.paintTopEff_new(g, cx, cy, getFrameHeadUI(f), 0);
	}

	public void paintLegUI(mGraphics g, int cx, int cy, int f)
	{
		DataSkillEff partEff = getPartEff(ID_LEG, ishorse: false);
		if (partEff == null)
		{
			return;
		}
		if (GameCanvas.gameTick % 6 == 0)
		{
			int num = partEff.listFrame.size() / 30;
			if (num == 0)
			{
				num = 1;
			}
			FlegUI = (byte)((FlegUI + 1) % num);
		}
		partEff.paintBottomEff_new(g, cx, cy, getFrameLegUI(f), 0);
		partEff.paintTopEff_new(g, cx, cy, getFrameLegUI(f), 0);
	}

	public void paintBodyUI(mGraphics g, int cx, int cy, int f)
	{
		DataSkillEff partEff = getPartEff(ID_Body, ishorse: false);
		if (partEff == null)
		{
			return;
		}
		if (GameCanvas.gameTick % 6 == 0)
		{
			int num = partEff.listFrame.size() / 30;
			if (num == 0)
			{
				num = 1;
			}
			FbodyUI = (byte)((FbodyUI + 1) % num);
		}
		partEff.paintBottomEff_new(g, cx, cy, getFrameBodyUI(f), 0);
		partEff.paintTopEff_new(g, cx, cy, getFrameBodyUI(f), 0);
	}

	public void paintMatNaBot(mGraphics g, int cx, int cy, int f, DataSkillEff partMatNa)
	{
	}

	public void paintMatNaTop(mGraphics g, int cx, int cy, int f, DataSkillEff partMatNa)
	{
	}

	public void paintWeaponBot(mGraphics g, int cx, int cy, int f, DataSkillEff partWeapon)
	{
		int num = 0;
		if ((statusMe == 1 || statusMe == 6) && cf <= 1)
		{
			num = cf * f;
		}
		if (partWeapon == null)
		{
			return;
		}
		if (isNewMount)
		{
			int num2 = -2;
			if (cdir == 1)
			{
				num2 = 2;
			}
			if ((statusMe == 1 || statusMe == 6) && cf <= 1)
			{
				num = cf;
			}
			partWeapon.paintBottomEff_new(g, cx + getxs() + num2, cy + num - getDyHorse() + dyMount - getys(), (statusMe != 1 && statusMe != 6) ? (5 + FrameWeaPone * 30) : getFrameWeapone(), (cdir != 1) ? 2 : 0);
		}
		else if (isWolf)
		{
			partWeapon.paintBottomEff_new(g, cx + getxs(), cy + num - getDyHorse() - getys(), (statusMe != 1 && statusMe != 6) ? (5 + FrameWeaPone * 30) : getFrameWeapone(), (cdir != 1) ? 2 : 0);
		}
		else if (isMoto)
		{
			partWeapon.paintBottomEff_new(g, cx + getxs(), cy + num - getDyHorse() - getys(), (statusMe != 1 && statusMe != 6) ? (5 + FrameWeaPone * 30) : getFrameWeapone(), (cdir != 1) ? 2 : 0);
		}
		else if (ID_HORSE > -1)
		{
			partWeapon.paintBottomEff_new(g, cx + getxs() + dxnewhorse, cy - getys() - getDyHorse(), getFrameWeapone(), (cdir != 1) ? 2 : 0);
		}
		else
		{
			partWeapon.paintBottomEff_new(g, cx + getxs(), cy - getys(), getFrameWeapone(), (cdir != 1) ? 2 : 0);
		}
	}

	public void paintWeaponTop(mGraphics g, int cx, int cy, int f, DataSkillEff partWeapon)
	{
		int num = 0;
		if ((statusMe == 1 || statusMe == 6) && cf <= 1)
		{
			num = cf * f;
		}
		if (partWeapon == null)
		{
			return;
		}
		if (isNewMount)
		{
			int num2 = -2;
			if (cdir == 1)
			{
				num2 = 2;
			}
			if ((statusMe == 1 || statusMe == 6) && cf <= 1)
			{
				num = cf;
			}
			partWeapon.paintTopEff_new(g, cx + getxs() + num2, cy + num - getDyHorse() + dyMount - getys(), (statusMe != 1 && statusMe != 6) ? (5 + FrameWeaPone * 30) : getFrameWeapone(), (cdir != 1) ? 2 : 0);
		}
		else if (isWolf)
		{
			partWeapon.paintTopEff_new(g, cx + getxs(), cy + num - getDyHorse() - getys(), (statusMe != 1 && statusMe != 6) ? (5 + FrameWeaPone * 30) : getFrameWeapone(), (cdir != 1) ? 2 : 0);
		}
		else if (isMoto)
		{
			partWeapon.paintTopEff_new(g, cx + getxs(), cy + num - getDyHorse() - getys(), (statusMe != 1 && statusMe != 6) ? (5 + FrameWeaPone * 30) : getFrameWeapone(), (cdir != 1) ? 2 : 0);
		}
		else if (ID_HORSE > -1)
		{
			partWeapon.paintTopEff_new(g, cx + getxs() + dxnewhorse, cy - getys() - getDyHorse(), getFrameWeapone(), (cdir != 1) ? 2 : 0);
		}
		else
		{
			partWeapon.paintTopEff_new(g, cx + getxs(), cy - getys(), getFrameWeapone(), (cdir != 1) ? 2 : 0);
		}
	}

	public void paintBody(mGraphics g, int cx, int cy, int f)
	{
		DataSkillEff partEff = getPartEff(ID_Body, ishorse: false);
		int num = 0;
		if ((statusMe == 1 || statusMe == 6) && cf <= 1)
		{
			num = cf * f;
		}
		if (partEff != null)
		{
			partEff.paintBottomEff_new(g, cx + getxs(), cy + num - getys(), (statusMe != 1 && statusMe != 6) ? (5 + FrameBody * 30) : getFrameBody(), (cdir != 1) ? 2 : 0);
			partEff.paintTopEff_new(g, cx + getxs(), cy + num - getys(), (statusMe != 1 && statusMe != 6) ? (5 + FrameBody * 30) : getFrameBody(), (cdir != 1) ? 2 : 0);
		}
	}

	public int getys()
	{
		int result = 0;
		if (isMoto)
		{
			result = ((arrItemMounts[4].template.id != 485) ? 6 : 4);
		}
		if (isNewMount)
		{
			result = 2;
			if (statusMe == 3)
			{
				result = 4;
			}
		}
		return result;
	}

	public int getxs()
	{
		int result = 0;
		if (isWolf)
		{
			result = 3;
			if (cdir == 1)
			{
				result = -3;
			}
		}
		if (isMoto)
		{
			if (arrItemMounts[4].template.id == 485)
			{
				result = 4;
				if (cdir == 1)
				{
					result = -4;
				}
			}
			else
			{
				result = 7;
				if (cdir == 1)
				{
					result = -7;
				}
			}
		}
		if (isNewMount)
		{
			result = 1;
			if (cdir == 1)
			{
				result = -1;
			}
		}
		return result;
	}

	public void paintHair(mGraphics g, int cx, int cy, int f)
	{
		DataSkillEff partEff = getPartEff(ID_HAIR, ishorse: false);
		int num = 0;
		if ((statusMe == 1 || statusMe == 6) && cf <= 1)
		{
			num = cf * f;
		}
		if (partEff != null)
		{
			partEff.paintBottomEff_new(g, cx + getxs(), cy + num - getys(), (statusMe != 1 && statusMe != 6) ? (5 + FrameHair * 30) : getFrameHair(), (cdir != 1) ? 2 : 0);
			partEff.paintTopEff_new(g, cx + getxs(), cy + num - getys(), (statusMe != 1 && statusMe != 6) ? (5 + FrameHair * 30) : getFrameHair(), (cdir != 1) ? 2 : 0);
		}
	}

	public bool isoldHorse()
	{
		if (arrItemMounts[4] == null)
		{
			return false;
		}
		if (arrItemMounts[4].template.id == 485 || arrItemMounts[4].template.id == 524 || arrItemMounts[4].template.id == 523 || arrItemMounts[4].template.id == 443)
		{
			return true;
		}
		return false;
	}

	public void paintPP_Bot(mGraphics g)
	{
		DataSkillEff partEff = getPartEff(ID_PP, ishorse: false);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		if (isMoto)
		{
			if (arrItemMounts[4].template.id == 485)
			{
				num = 9;
				if ((statusMe == 1 || statusMe == 6) && cf <= 1)
				{
					num3 = cf * 2;
				}
				partEff?.paintBottomEff_new(g, cx + getxs(), cy - num + num3 - getys(), getFramePP(), (cdir != 1) ? 2 : 0);
			}
			if (arrItemMounts[4].template.id == 524)
			{
				num = 12;
				num2 = 2;
				if ((statusMe == 1 || statusMe == 6) && cf <= 1)
				{
					num3 = cf * 2;
				}
				if (cdir == 1)
				{
					num2 = -2;
				}
				partEff?.paintBottomEff_new(g, cx + num2 + getxs(), cy - num + num3 - getys(), getFramePP(), (cdir != 1) ? 2 : 0);
			}
		}
		else if (isWolf)
		{
			if (arrItemMounts[4].template.id == 523)
			{
				if ((statusMe == 1 || statusMe == 6) && cf <= 1)
				{
					num3 = cf * 2;
				}
				num = 15;
				num2 = 2;
				if (cdir == 1)
				{
					num2 = -2;
				}
				partEff?.paintBottomEff_new(g, cx + num2 + getxs(), cy - num + num3 - getys(), getFramePP(), (cdir != 1) ? 2 : 0);
			}
			else if (arrItemMounts[4].template.id == 443)
			{
				if ((statusMe == 1 || statusMe == 6) && cf <= 1)
				{
					num3 = cf * 2;
				}
				num = 15;
				num2 = 2;
				if (cdir == 1)
				{
					num2 = -2;
				}
				partEff?.paintBottomEff_new(g, cx + num2 + getxs(), cy - num + num3 - getys(), getFramePP(), (cdir != 1) ? 2 : 0);
			}
		}
		else if (isNewMount)
		{
			num = 18;
			num2 = -4;
			if ((statusMe == 1 || statusMe == 6) && cf <= 1)
			{
				num3 = cf;
			}
			if (cdir == 1)
			{
				num2 = 4;
			}
			partEff?.paintBottomEff_new(g, cx + num2 + getxs(), cy - num + dyMount + num3 - getys(), getFramePP(), (cdir != 1) ? 2 : 0);
		}
		else
		{
			partEff?.paintBottomEff_new(g, cx + dxnewhorse + getxs(), cy - dynewhhorse - getys(), getFramePP(), (cdir != 1) ? 2 : 0);
		}
	}

	public void paintPP_Top(mGraphics g)
	{
		DataSkillEff partEff = getPartEff(ID_PP, ishorse: false);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		if (isMoto)
		{
			if (arrItemMounts[4].template.id == 485)
			{
				num = 9;
				if ((statusMe == 1 || statusMe == 6) && cf <= 1)
				{
					num3 = cf * 2;
				}
				partEff?.paintTopEff_new(g, cx + getxs(), cy - num + num3 - getys(), getFramePP(), (cdir != 1) ? 2 : 0);
			}
			if (arrItemMounts[4].template.id == 524)
			{
				num = 12;
				num2 = 2;
				if ((statusMe == 1 || statusMe == 6) && cf <= 1)
				{
					num3 = cf * 2;
				}
				if (cdir == 1)
				{
					num2 = -2;
				}
				partEff?.paintTopEff_new(g, cx + num2 + getxs(), cy - num + num3 - getys(), getFramePP(), (cdir != 1) ? 2 : 0);
			}
		}
		else if (isWolf)
		{
			if (arrItemMounts[4].template.id == 523)
			{
				num = 15;
				num2 = 2;
				if ((statusMe == 1 || statusMe == 6) && cf <= 1)
				{
					num3 = cf * 2;
				}
				if (cdir == 1)
				{
					num2 = -2;
				}
				partEff?.paintTopEff_new(g, cx + num2 + getxs(), cy - num + num3 - getys(), getFramePP(), (cdir != 1) ? 2 : 0);
			}
			else if (arrItemMounts[4].template.id == 443)
			{
				if ((statusMe == 1 || statusMe == 6) && cf <= 1)
				{
					num3 = cf * 2;
				}
				num = 15;
				num2 = 2;
				if (cdir == 1)
				{
					num2 = -2;
				}
				partEff?.paintTopEff_new(g, cx + num2 + getxs(), cy - num + num3 - getys(), getFramePP(), (cdir != 1) ? 2 : 0);
			}
		}
		else if (isNewMount)
		{
			num = 18;
			num2 = -4;
			if ((statusMe == 1 || statusMe == 6) && cf <= 1)
			{
				num3 = cf;
			}
			if (cdir == 1)
			{
				num2 = 4;
			}
			partEff?.paintTopEff_new(g, cx + num2 + getxs(), cy - num + dyMount + num3 - getys(), getFramePP(), (cdir != 1) ? 2 : 0);
		}
		else
		{
			partEff?.paintTopEff_new(g, cx + dxnewhorse + getxs(), cy - dynewhhorse - getys(), getFramePP(), (cdir != 1) ? 2 : 0);
		}
	}

	public int getDyHorse()
	{
		if (ID_HORSE > -1)
		{
			DataSkillEff partEff = getPartEff(ID_HORSE, ishorse: true);
			if (partEff != null && partEff.isLoadData)
			{
				return partEff.dyHorse;
			}
		}
		if (isWolf || isMoto || isNewMount)
		{
			return 12;
		}
		return 0;
	}

	private void paintCharWithoutSkill(mGraphics g)
	{
		try
		{
			DataSkillEff partEff = getPartEff(ID_WEA_PONE, ishorse: false);
			if (partEff != null && GameCanvas.gameTick % 6 == 0)
			{
				int num = partEff.listFrame.size() / 30;
				if (num == 0)
				{
					num = 1;
				}
				FrameWeaPone = (byte)((FrameWeaPone + 1) % num);
			}
			DataSkillEff partEff2 = getPartEff(ID_Bien_Hinh, ishorse: false);
			if (partEff2 != null && GameCanvas.gameTick % 6 == 0)
			{
				int num2 = partEff2.listFrame.size() / 30;
				if (num2 == 0)
				{
					num2 = 1;
				}
				FrameBienHinh = (byte)((FrameBienHinh + 1) % num2);
			}
			DataSkillEff partEff3 = getPartEff(ID_MAT_NA, ishorse: false);
			if (partEff3 != null && GameCanvas.gameTick % 6 == 0)
			{
				int num3 = partEff3.listFrame.size() / 30;
				if (num3 == 0)
				{
					num3 = 1;
				}
				FrameMatna = (byte)((FrameMatna + 1) % num3);
			}
			DataSkillEff partEff4 = getPartEff(ID_RANK, ishorse: false);
			DataSkillEff partEff5 = getPartEff(ID_NAME, ishorse: false);
			DataSkillEff partEff6 = getPartEff(ID_LEG, ishorse: false);
			if (partEff6 != null && GameCanvas.gameTick % 6 == 0)
			{
				int num4 = partEff6.listFrame.size() / 30;
				if (num4 == 0)
				{
					num4 = 1;
				}
				FrameLeg = (byte)((FrameLeg + 1) % num4);
			}
			DataSkillEff partEff7 = getPartEff(ID_HORSE, ishorse: true);
			if (partEff7 != null && partEff7.isLoadData && GameCanvas.gameTick % 10 == 0)
			{
				int num5 = partEff7.listFrame.size() / partEff7.sequence.Length;
				if (num5 == 0)
				{
					num5 = 1;
				}
				FrameHorse = (byte)((FrameHorse + 1) % num5);
			}
			DataSkillEff partEff8 = getPartEff(ID_Body, ishorse: false);
			if (partEff8 != null && GameCanvas.gameTick % 6 == 0)
			{
				int num6 = partEff8.listFrame.size() / 30;
				if (num6 == 0)
				{
					num6 = 1;
				}
				FrameBody = (byte)((FrameBody + 1) % num6);
			}
			DataSkillEff partEff9 = getPartEff(ID_HAIR, ishorse: false);
			if (partEff9 != null && GameCanvas.gameTick % 6 == 0)
			{
				int num7 = partEff9.listFrame.size() / 30;
				if (num7 == 0)
				{
					num7 = 1;
				}
				FrameHair = (byte)((FrameHair + 1) % num7);
			}
			DataSkillEff partEff10 = getPartEff(ID_PP, ishorse: false);
			if (partEff10 != null && GameCanvas.gameTick % 6 == 0)
			{
				int num8 = partEff10.listFrame.size() / 30;
				if (num8 == 0)
				{
					num8 = 1;
				}
				FramePP = (byte)((FramePP + 1) % num8);
			}
			int[] array = null;
			Part part = GameScr.parts[head];
			Part part2 = GameScr.parts[leg];
			Part part3 = GameScr.parts[body];
			Part part4 = GameScr.parts[wp];
			if (partEff != null)
			{
				part4 = null;
			}
			if (arrItemBody != null && arrItemBody[11] != null)
			{
				part = GameScr.parts[arrItemBody[11].template.part];
				head = arrItemBody[11].template.part;
			}
			if (part.pi == null || part.pi.Length < 8)
			{
				part = getDefaultHead(cgender);
			}
			else
			{
				for (int i = 0; i < part.pi.Length; i++)
				{
					if (part.pi[i] == null || !SmallImage.isExitsImage(part.pi[i].id))
					{
						part = getDefaultHead(cgender);
						break;
					}
				}
			}
			array = ((part.pi[CharInfo[cf][0][0]].id > 4) ? getClassCoat() : null);
			if ((((statusMe == 1 || statusMe == 6) && GameCanvas.gameTick % 10 == 0) || ((statusMe == 2 || statusMe == 10) && GameCanvas.gameTick % 2 == 0) || ((statusMe == 4 || statusMe == 3) && GameCanvas.gameTick % 3 == 0)) && array != null)
			{
				tickCoat++;
				if (tickCoat > array.Length - 1)
				{
					tickCoat = 0;
				}
			}
			if (statusMe == 14)
			{
				if (isHaveNewMount())
				{
					paintBehindNewMount(g);
				}
				else if (isHaveMoto())
				{
					if (arrItemMounts[4].template.id == 485)
					{
						if (arrItemMounts[4].sys < 2)
						{
							SmallImage.drawSmallImage(g, 1800, lcx, lcy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
						}
						else
						{
							SmallImage.drawSmallImage(g, 2063, lcx, lcy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
						}
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						if (arrItemMounts[4].sys < 2)
						{
							SmallImage.drawSmallImage(g, 2064, lcx, lcy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
						}
						else
						{
							SmallImage.drawSmallImage(g, 2068, lcx, lcy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
						}
					}
				}
				SmallImage.drawSmallImage(g, 1040, cx, cy, 0, mGraphics.HCENTER | mGraphics.BOTTOM);
			}
			else if (isInvisible)
			{
				if (me)
				{
					if (GameCanvas.gameTick % 50 == 48 || GameCanvas.gameTick % 50 == 90)
					{
						SmallImage.drawSmallImage(g, 1196, cx, cy - 18, 0, mGraphics.VCENTER | mGraphics.HCENTER);
					}
					else
					{
						SmallImage.drawSmallImage(g, 1195, cx, cy - 18, 0, mGraphics.VCENTER | mGraphics.HCENTER);
					}
				}
			}
			else
			{
				if (partEff != null)
				{
					paintWeaponBot(g, cx, cy, 2, partEff);
				}
				if (partEff2 != null)
				{
					partEff2.paintBottomEff_new(g, cx, cy, getFrameBienHinh(), (cdir != 1) ? 2 : 0);
					partEff2.paintTopEff_new(g, cx, cy, getFrameBienHinh(), (cdir != 1) ? 2 : 0);
				}
				partEff7?.paintBottomEff_new(g, cx, cy, getFrameHores(), (cdir == 1) ? 2 : 0);
				partEff4?.paintBottomEff_new(g, cx, cy - getDyHorse(), FrameRank, (cdir != 1) ? 2 : 0);
				partEff5?.paintBottomEff_new(g, cx, cy - getDyHorse(), FrameName, 0);
				paintPP_Bot(g);
				if (isMoto)
				{
					int num9 = 0;
					int num10 = 0;
					int num11 = 0;
					int num12 = 0;
					int[] array2 = geteffOngbo();
					if (array2 != null)
					{
						tickEffmoto++;
						if (tickEffmoto >= array2.Length)
						{
							tickEffmoto = 0;
						}
					}
					if (arrItemMounts[4].template.id == 485)
					{
						if (arrItemMounts[4].sys < 2)
						{
							if (statusMe == 1 || statusMe == 6)
							{
								num9 = ((GameCanvas.gameTick % 20 > 12) ? 1 : 0);
								if ((partEff10 != null || partEff8 != null || partEff9 != null || partEff != null || partEff3 != null) && cf <= 1)
								{
									num9 = cf;
								}
							}
							else if (statusMe == 2 || statusMe == 10)
							{
								num9 = ((GameCanvas.gameTick % 6 > 3) ? 1 : 0);
							}
							if (statusMe == 3)
							{
								num11 = -5 * cdir;
							}
							if (cdir == 1)
							{
								if (statusMe == 3)
								{
									SmallImage.drawSmallImage(g, 1711, cx, cy + 2, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								else
								{
									SmallImage.drawSmallImage(g, (num9 != 0) ? 1710 : 1709, cx, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								if (partEff9 != null)
								{
									paintHair(g, cx, cy - 8, 2);
								}
								else
								{
									SmallImage.drawSmallImage(g, getHeadId(), cx + num11 + dxHead * cdir, cy - CharInfo[0][0][2] + part.pi[CharInfo[0][0][0]].dy - 12 + num9 + dyHead, 0, mGraphics.TOP | mGraphics.HCENTER);
								}
								if (partEff8 != null)
								{
									paintBody(g, cx, cy - 8, 2);
								}
								else
								{
									SmallImage.drawSmallImage(g, getBodyPaintId(), cx + dxBody * cdir, cy - SmallImage.getHeight(getLegId()) - 8 + num9 + dyBody, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								paintMatna(g, cx, cy - 8, 2);
							}
							else
							{
								if (statusMe == 3)
								{
									SmallImage.drawSmallImage(g, 1711, cx, cy + 2, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								else
								{
									SmallImage.drawSmallImage(g, (num9 != 0) ? 1710 : 1709, cx, cy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								if (partEff9 != null)
								{
									paintHair(g, cx, cy - 8, 2);
								}
								else
								{
									SmallImage.drawSmallImage(g, getHeadId(), cx + num11 + dxHead * cdir, cy - CharInfo[0][0][2] + part.pi[CharInfo[0][0][0]].dy - 12 + num9 + dyHead, 2, mGraphics.TOP | mGraphics.HCENTER);
								}
								if (partEff8 != null)
								{
									paintBody(g, cx, cy - 8, 2);
								}
								else
								{
									SmallImage.drawSmallImage(g, getBodyPaintId(), cx + dxBody * cdir, cy - SmallImage.getHeight(getLegId()) - 8 + num9 + dyBody, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								paintMatna(g, cx, cy - 8, 2);
							}
						}
						else
						{
							if (statusMe == 1 || statusMe == 6)
							{
								num9 = ((GameCanvas.gameTick % 20 > 12) ? 1 : 0);
								if ((partEff10 != null || partEff8 != null || partEff9 != null || partEff != null || partEff3 != null) && cf <= 1)
								{
									num9 = cf;
								}
							}
							else if (statusMe == 2 || statusMe == 10)
							{
								num9 = ((GameCanvas.gameTick % 6 > 3) ? 1 : 0);
							}
							if (statusMe == 3)
							{
								num11 = -5 * cdir;
							}
							if (cdir == 1)
							{
								if (statusMe == 3)
								{
									SmallImage.drawSmallImage(g, 2057, cx, cy + 2, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								else if (!isBocdau)
								{
									SmallImage.drawSmallImage(g, (num9 != 0) ? 2055 : 2056, cx, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								else
								{
									SmallImage.drawSmallImage(g, 2057, cx, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								if (statusMe == 2 && array2 != null)
								{
									SmallImage.drawSmallImage(g, array2[tickEffmoto], cx - 25, cy - 2, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								if (!isBocdau)
								{
									if (partEff9 != null)
									{
										paintHair(g, cx, cy - 8, 2);
									}
									else
									{
										SmallImage.drawSmallImage(g, getHeadId(), cx + num11 + dxHead * cdir, cy - CharInfo[0][0][2] + part.pi[CharInfo[0][0][0]].dy - 12 + num9 + dyHead, 0, mGraphics.TOP | mGraphics.HCENTER);
									}
									if (partEff8 != null)
									{
										paintBody(g, cx, cy - 8, 2);
									}
									else
									{
										SmallImage.drawSmallImage(g, getBodyPaintId(), cx + dxBody * cdir, cy - SmallImage.getHeight(getLegId()) - 8 + num9 + dyBody, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
									}
									paintMatna(g, cx, cy - 8, 2);
								}
								else
								{
									if (partEff9 != null)
									{
										paintHair(g, cx, cy - 8, 2);
									}
									else
									{
										SmallImage.drawSmallImage(g, getHeadId(), cx + num11 + dxHead * cdir - 3, cy - 1 - CharInfo[0][0][2] + part.pi[CharInfo[0][0][0]].dy - 12 + num9 + dyHead, 0, mGraphics.TOP | mGraphics.HCENTER);
									}
									if (partEff8 != null)
									{
										paintBody(g, cx, cy - 8, 2);
									}
									else
									{
										SmallImage.drawSmallImage(g, getBodyPaintId(), cx - 3 + dxBody * cdir, cy - 1 - SmallImage.getHeight(getLegId()) - 8 + num9 + dyBody, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
									}
									paintMatna(g, cx, cy - 8, 2);
								}
							}
							else
							{
								if (statusMe == 3)
								{
									SmallImage.drawSmallImage(g, 2057, cx, cy + 2, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								else if (!isBocdau)
								{
									SmallImage.drawSmallImage(g, (num9 != 0) ? 2055 : 2056, cx, cy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								else
								{
									SmallImage.drawSmallImage(g, 2057, cx, cy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								if (statusMe == 2 && array2 != null)
								{
									SmallImage.drawSmallImage(g, array2[tickEffmoto], cx + 25, cy - 2, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								if (partEff9 != null)
								{
									paintHair(g, cx, cy - 8, 2);
								}
								else
								{
									SmallImage.drawSmallImage(g, getHeadId(), cx + num11 + dxHead * cdir, cy - CharInfo[0][0][2] + part.pi[CharInfo[0][0][0]].dy - 12 + num9 + dyHead, 2, mGraphics.TOP | mGraphics.HCENTER);
								}
								if (partEff8 != null)
								{
									paintBody(g, cx, cy - 8, 2);
								}
								else
								{
									SmallImage.drawSmallImage(g, getBodyPaintId(), cx + dxBody * cdir, cy - SmallImage.getHeight(getLegId()) - 8 + num9 + dyBody, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								paintMatna(g, cx, cy - 8, 2);
							}
						}
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						if (arrItemMounts[4].sys < 2)
						{
							if (statusMe == 1 || statusMe == 6)
							{
								num9 = ((GameCanvas.gameTick % 20 > 12) ? 1 : 0);
								if ((partEff10 != null || partEff8 != null || partEff9 != null || partEff != null || partEff3 != null) && cf <= 1)
								{
									num9 = cf;
								}
							}
							else if (statusMe == 2 || statusMe == 10)
							{
								num9 = ((GameCanvas.gameTick % 6 > 3) ? 1 : 0);
							}
							if (statusMe == 3)
							{
								num11 = -5 * cdir;
							}
							if (cdir == 1)
							{
								if (statusMe == 3)
								{
									SmallImage.drawSmallImage(g, 2066, cx, cy + 2, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								else
								{
									SmallImage.drawSmallImage(g, (num9 != 0) ? 2065 : 2064, cx, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								if (partEff9 != null)
								{
									paintHair(g, cx, cy - 8, 2);
								}
								else
								{
									SmallImage.drawSmallImage(g, getHeadId(), cx + num11 + dxHead * cdir, cy - CharInfo[0][0][2] + part.pi[CharInfo[0][0][0]].dy - 12 + num9 + dyHead, 0, mGraphics.TOP | mGraphics.HCENTER);
								}
								if (partEff8 != null)
								{
									paintBody(g, cx, cy - 8, 2);
								}
								else
								{
									SmallImage.drawSmallImage(g, getBodyPaintId(), cx + dxBody * cdir, cy - SmallImage.getHeight(getLegId()) - 8 + num9 + dyBody, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								paintMatna(g, cx, cy - 8, 2);
							}
							else
							{
								if (statusMe == 3)
								{
									SmallImage.drawSmallImage(g, 2066, cx, cy + 2, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								else
								{
									SmallImage.drawSmallImage(g, (num9 != 0) ? 2065 : 2064, cx, cy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								if (partEff9 != null)
								{
									paintHair(g, cx, cy - 8, 2);
								}
								else
								{
									SmallImage.drawSmallImage(g, getHeadId(), cx + num11 + dxHead * cdir, cy - CharInfo[0][0][2] + part.pi[CharInfo[0][0][0]].dy - 12 + num9 + dyHead, 2, mGraphics.TOP | mGraphics.HCENTER);
								}
								if (partEff8 != null)
								{
									paintBody(g, cx, cy - 8, 2);
								}
								else
								{
									SmallImage.drawSmallImage(g, getBodyPaintId(), cx + dxBody * cdir, cy - SmallImage.getHeight(getLegId()) - 8 + num9 + dyBody, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								paintMatna(g, cx, cy - 8, 2);
							}
						}
						else if (arrItemMounts[4].sys >= 2 && arrItemMounts[4].sys < 4)
						{
							int[] effmoto = getEffmoto();
							if (effmoto != null)
							{
								tickEffmoto++;
								if (tickEffmoto >= effmoto.Length)
								{
									tickEffmoto = 0;
								}
							}
							if (statusMe == 1 || statusMe == 6)
							{
								num9 = ((GameCanvas.gameTick % 20 > 12) ? 1 : 0);
								if ((partEff10 != null || partEff8 != null || partEff9 != null || partEff != null || partEff3 != null) && cf <= 1)
								{
									num9 = cf;
								}
							}
							else if (statusMe == 2 || statusMe == 10)
							{
								num9 = ((GameCanvas.gameTick % 6 > 3) ? 1 : 0);
							}
							if (statusMe == 3)
							{
								num11 = -5 * cdir;
							}
							if (cdir == 1)
							{
								if (statusMe == 3)
								{
									SmallImage.drawSmallImage(g, 2070, cx, cy + 2, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								else if (statusMe == 4)
								{
									SmallImage.drawSmallImage(g, (num9 != 0) ? 2069 : 2068, cx, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								else if (statusMe == 2 || statusMe == 10)
								{
									SmallImage.drawSmallImage(g, (num9 != 0) ? 2069 : 2068, cx, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								else if (statusMe == 1 || statusMe == 6)
								{
									SmallImage.drawSmallImage(g, (num9 != 0) ? 2069 : 2068, cx, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								if (partEff9 != null)
								{
									paintHair(g, cx, cy - 8, 2);
								}
								else
								{
									SmallImage.drawSmallImage(g, getHeadId(), cx + num11 + dxHead * cdir, cy - CharInfo[0][0][2] + part.pi[CharInfo[0][0][0]].dy - 12 + num9 + dyHead, 0, mGraphics.TOP | mGraphics.HCENTER);
								}
								if (partEff8 != null)
								{
									paintBody(g, cx, cy - 8, 2);
								}
								else
								{
									SmallImage.drawSmallImage(g, getBodyPaintId(), cx + dxBody * cdir, cy - SmallImage.getHeight(getLegId()) - 8 + num9 + dyBody, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								paintMatna(g, cx, cy - 8, 2);
							}
							else
							{
								if (statusMe == 3)
								{
									SmallImage.drawSmallImage(g, 2070, cx, cy + 2, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								if (statusMe == 4)
								{
									SmallImage.drawSmallImage(g, (num9 != 0) ? 2069 : 2068, cx, cy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								else if (statusMe == 2 || statusMe == 10)
								{
									SmallImage.drawSmallImage(g, (num9 != 0) ? 2069 : 2068, cx, cy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								else if (statusMe == 1 || statusMe == 6)
								{
									SmallImage.drawSmallImage(g, (num9 != 0) ? 2069 : 2068, cx, cy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								if (partEff9 != null)
								{
									paintHair(g, cx, cy - 8, 2);
								}
								else
								{
									SmallImage.drawSmallImage(g, getHeadId(), cx + num11 + dxHead * cdir, cy - CharInfo[0][0][2] + part.pi[CharInfo[0][0][0]].dy - 12 + num9 + dyHead, 2, mGraphics.TOP | mGraphics.HCENTER);
								}
								if (partEff8 != null)
								{
									paintBody(g, cx, cy - 8, 2);
								}
								else
								{
									SmallImage.drawSmallImage(g, getBodyPaintId(), cx + dxBody * cdir, cy - SmallImage.getHeight(getLegId()) - 8 + num9 + dyBody, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								paintMatna(g, cx, cy - 8, 2);
							}
						}
						else
						{
							int[] effmoto2 = getEffmoto();
							if (effmoto2 != null)
							{
								tickEffmoto++;
								if (tickEffmoto >= effmoto2.Length)
								{
									tickEffmoto = 0;
								}
							}
							if (statusMe == 1 || statusMe == 6)
							{
								num9 = ((GameCanvas.gameTick % 20 > 12) ? 1 : 0);
								if ((partEff10 != null || partEff8 != null || partEff9 != null || partEff != null || partEff3 != null) && cf <= 1)
								{
									num9 = cf;
								}
							}
							else if (statusMe == 2 || statusMe == 10)
							{
								num9 = ((GameCanvas.gameTick % 6 > 3) ? 1 : 0);
							}
							if (statusMe == 3)
							{
								num11 = -5 * cdir;
							}
							if (cdir == 1)
							{
								if (statusMe == 3)
								{
									SmallImage.drawSmallImage(g, 2070, cx, cy + 2, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
									SmallImage.drawSmallImage(g, effmoto2[tickEffmoto], cx + 13, cy - 17, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
									SmallImage.drawSmallImage(g, effmoto2[tickEffmoto], cx - 24, cy + 2, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								else if (statusMe == 4)
								{
									SmallImage.drawSmallImage(g, (num9 != 0) ? 2069 : 2068, cx, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
									SmallImage.drawSmallImage(g, effmoto2[tickEffmoto], cx + 15, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
									SmallImage.drawSmallImage(g, effmoto2[tickEffmoto], cx - 27, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								else if (statusMe == 2 || statusMe == 10)
								{
									SmallImage.drawSmallImage(g, (num9 != 0) ? 2069 : 2068, cx, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
									SmallImage.drawSmallImage(g, effmoto2[tickEffmoto], cx + 15, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
									SmallImage.drawSmallImage(g, effmoto2[tickEffmoto], cx - 27, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								else if (statusMe == 1 || statusMe == 6)
								{
									SmallImage.drawSmallImage(g, (num9 != 0) ? 2069 : 2068, cx, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
									SmallImage.drawSmallImage(g, effmoto2[tickEffmoto], cx + 15, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
									SmallImage.drawSmallImage(g, effmoto2[tickEffmoto], cx - 27, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								if (partEff9 != null)
								{
									paintHair(g, cx, cy - 8, 2);
								}
								else
								{
									SmallImage.drawSmallImage(g, getHeadId(), cx + num11 + dxHead * cdir, cy - CharInfo[0][0][2] + part.pi[CharInfo[0][0][0]].dy - 12 + num9 + dyHead, 0, mGraphics.TOP | mGraphics.HCENTER);
								}
								if (partEff8 != null)
								{
									paintBody(g, cx, cy - 8, 2);
								}
								else
								{
									SmallImage.drawSmallImage(g, getBodyPaintId(), cx + dxBody * cdir, cy - SmallImage.getHeight(getLegId()) - 8 + num9 + dyBody, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								paintMatna(g, cx, cy - 8, 2);
							}
							else
							{
								if (statusMe == 3)
								{
									SmallImage.drawSmallImage(g, 2070, cx, cy + 2, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
									SmallImage.drawSmallImage(g, effmoto2[tickEffmoto], cx - 12, cy - 17, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
									SmallImage.drawSmallImage(g, effmoto2[tickEffmoto], cx + 25, cy + 3, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								if (statusMe == 4)
								{
									SmallImage.drawSmallImage(g, (num9 != 0) ? 2069 : 2068, cx, cy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
									SmallImage.drawSmallImage(g, effmoto2[tickEffmoto], cx - 15, cy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
									SmallImage.drawSmallImage(g, effmoto2[tickEffmoto], cx + 27, cy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								else if (statusMe == 2 || statusMe == 10)
								{
									SmallImage.drawSmallImage(g, (num9 != 0) ? 2069 : 2068, cx, cy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
									SmallImage.drawSmallImage(g, effmoto2[tickEffmoto], cx - 15, cy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
									SmallImage.drawSmallImage(g, effmoto2[tickEffmoto], cx + 27, cy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								else if (statusMe == 1 || statusMe == 6)
								{
									SmallImage.drawSmallImage(g, (num9 != 0) ? 2069 : 2068, cx, cy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
									SmallImage.drawSmallImage(g, effmoto2[tickEffmoto], cx - 15, cy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
									SmallImage.drawSmallImage(g, effmoto2[tickEffmoto], cx + 27, cy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								if (partEff9 != null)
								{
									paintHair(g, cx, cy - 8, 2);
								}
								else
								{
									SmallImage.drawSmallImage(g, getHeadId(), cx + num11 + dxHead * cdir, cy - CharInfo[0][0][2] + part.pi[CharInfo[0][0][0]].dy - 12 + num9 + dyHead, 2, mGraphics.TOP | mGraphics.HCENTER);
								}
								if (partEff8 != null)
								{
									paintBody(g, cx, cy - 8, 2);
								}
								else
								{
									SmallImage.drawSmallImage(g, getBodyPaintId(), cx + dxBody * cdir, cy - SmallImage.getHeight(getLegId()) - 8 + num9 + dyBody, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								paintMatna(g, cx, cy - 8, 2);
							}
						}
					}
				}
				else if (isWolf)
				{
					int[] effwolf = getEffwolf();
					if (effwolf != null)
					{
						tickEffFireW++;
						if (tickEffFireW >= effwolf.Length)
						{
							tickEffFireW = 0;
						}
					}
					if (statusMe == 1 || statusMe == 6)
					{
						tickWolf = ((GameCanvas.gameTick % 20 > 12) ? 1 : 0);
						if ((partEff10 != null || partEff8 != null || partEff9 != null || partEff != null || partEff3 != null) && cf <= 1)
						{
							tickWolf = cf;
						}
						dy = -tickWolf;
					}
					else if (statusMe == 2 || statusMe == 10)
					{
						if (GameCanvas.gameTick % 12 <= 3)
						{
							tickWolf = 0;
						}
						else if (GameCanvas.gameTick % 12 <= 6)
						{
							tickWolf = 1;
							dy = 2;
						}
						else if (GameCanvas.gameTick % 12 <= 9)
						{
							tickWolf = 2;
							dy = 4;
						}
						else
						{
							tickWolf = 3;
							dy = 2;
						}
					}
					int[] array3 = new int[4] { 2050, 2053, 2049, 2052 };
					int[] array4 = new int[4] { 2075, 2078, 2074, 2079 };
					int[] array5 = new int[4]
					{
						cy - 22,
						cy - 23,
						cy - 22,
						cy - 23
					};
					int[] array6 = new int[4]
					{
						cy - 22,
						cy - 23,
						cy - 22,
						cy - 22
					};
					if (statusMe == 3)
					{
						hdx = -5 * cdir;
						// hdy = 2;
					}
					else
					{
						hdx = -3 * cdir;
					}
					if (arrItemMounts[4].template.id == 523)
					{
						if (cdir == 1) // direction (right)
						{
							// part 1: head
							// part 2: leg
							// part 3: body
							// part 4: wp
							if (part4 != null)
							{
								SmallImage.drawSmallImage(g, part4.pi[CharInfo[cf][3][0]].id, cx + CharInfo[cf][3][1] + part4.pi[CharInfo[cf][3][0]].dx, cy - CharInfo[cf][3][2] + part4.pi[CharInfo[cf][3][0]].dy - 10, 0, 0);
							}
							if (statusMe == 3)
							{
								SmallImage.drawSmallImage(g, 2051, cx, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
							}
							else if (statusMe == 4)
							{
								SmallImage.drawSmallImage(g, 2052, cx, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
							}
							else if (statusMe == 1 || statusMe == 6)
							{
								SmallImage.drawSmallImage(g, (tickWolf != 0) ? 2048 : 2047, cx, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
								// SmallImage.drawSmallImage(g, testAsset, cx, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);

							}
							else if (statusMe == 2 || statusMe == 10)
							{
								SmallImage.drawSmallImage(g, array3[tickWolf], cx, cy - dy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
							}
							int num13 = 15;
							int num14 = 2;
							if (cdir == 1)
							{
								num14 = -2;
							}
							if (partEff9 != null)
							{
								paintHair(g, cx + num14, cy - num13, 2);
							}
							else
							{
								SmallImage.drawSmallImage(g, getHeadId(), cx + hdx + dxHead * cdir, cy - CharInfo[0][0][2] + part.pi[CharInfo[0][0][0]].dy - 12 - hdy - dy + dyHead, 0, mGraphics.TOP | mGraphics.HCENTER);
							}
							if (partEff8 != null)
							{
								paintBody(g, cx + num14, cy - num13, 2);
							}
							else
							{
								SmallImage.drawSmallImage(g, getBodyPaintId(), cx + hdx + dxBody * cdir, cy - SmallImage.getHeight(getLegId()) - 9 - hdy - dy + dyBody, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
							}
							paintMatna(g, cx + num14, cy - num13, 2);
						}
						else
						{
							if (part4 != null)
							{
								SmallImage.drawSmallImage(g, part4.pi[CharInfo[cf][3][0]].id, cx - CharInfo[cf][3][1] - part4.pi[CharInfo[cf][3][0]].dx, cy - CharInfo[cf][3][2] + part4.pi[CharInfo[cf][3][0]].dy - 10, 2, 24);
							}
							if (statusMe == 3)
							{
								SmallImage.drawSmallImage(g, 2051, cx, cy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
							}
							else if (statusMe == 4)
							{
								SmallImage.drawSmallImage(g, 2052, cx, cy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
							}
							else if (statusMe == 1 || statusMe == 6)
							{
								SmallImage.drawSmallImage(g, (tickWolf != 0) ? 2048 : 2047, cx, cy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
							}
							else if (statusMe == 2 || statusMe == 10)
							{
								SmallImage.drawSmallImage(g, array3[tickWolf], cx, cy - dy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
							}
							int num15 = 15;
							int num16 = 2;
							if (cdir == 1)
							{
								num16 = -2;
							}
							if (partEff9 != null)
							{
								paintHair(g, cx + num16, cy - num15, 2);
							}
							else
							{
								SmallImage.drawSmallImage(g, getHeadId(), cx + hdx + dxHead * cdir, cy - CharInfo[0][0][2] + part.pi[CharInfo[0][0][0]].dy - 12 - hdy - dy + dyHead, 2, mGraphics.TOP | mGraphics.HCENTER);
							}
							if (partEff8 != null)
							{
								paintBody(g, cx + num16, cy - num15, 2);
							}
							else
							{
								SmallImage.drawSmallImage(g, getBodyPaintId(), cx + hdx + dxBody * cdir, cy - SmallImage.getHeight(getLegId()) - 9 - hdy - dy + dyBody, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
							}
							paintMatna(g, cx + num16, cy - num15, 2);
						}
					}
					else if (arrItemMounts[4].template.id == 443)
					{
						if (arrItemMounts[4].sys >= 3)
						{
							if (cdir == 1)
							{
								if (part4 != null)
								{
									SmallImage.drawSmallImage(g, part4.pi[CharInfo[cf][3][0]].id, cx + CharInfo[cf][3][1] + part4.pi[CharInfo[cf][3][0]].dx, cy - CharInfo[cf][3][2] + part4.pi[CharInfo[cf][3][0]].dy - 10, 0, 0);
								}
								if (statusMe == 3)
								{
									SmallImage.drawSmallImage(g, 2077, cx, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
									g.drawRegion(GameScr.imgMatcho, 0, tickEffWolf * 3, 3, 3, 0, cx + 21, cy - 30, 0);
								}
								else if (statusMe == 4)
								{
									SmallImage.drawSmallImage(g, 2076, cx, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
									g.drawRegion(GameScr.imgMatcho, 0, tickEffWolf * 3, 3, 3, 0, cx + 21, cy - 19, 0);
								}
								else if (statusMe == 1 || statusMe == 6)
								{
									SmallImage.drawSmallImage(g, (tickWolf != 0) ? 2072 : 2073, cx, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
									g.drawRegion(GameScr.imgMatcho, 0, tickEffWolf * 3, 3, 3, 0, cx + 21, cy - 19, 0);
								}
								else if (statusMe == 2 || statusMe == 10)
								{
									SmallImage.drawSmallImage(g, array4[tickWolf], cx, cy - dy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
									g.drawRegion(GameScr.imgMatcho, 0, tickEffWolf * 3, 3, 3, 0, cx + 21, array5[tickWolf], 0);
								}
								int num17 = 15;
								int num18 = 2;
								if (cdir == 1)
								{
									num18 = -2;
								}
								if (partEff9 != null)
								{
									paintHair(g, cx + num18, cy - num17, 2);
								}
								else
								{
									SmallImage.drawSmallImage(g, getHeadId(), cx + hdx + dxHead * cdir, cy - CharInfo[0][0][2] + part.pi[CharInfo[0][0][0]].dy - 12 - hdy - dy + dyHead, 0, mGraphics.TOP | mGraphics.HCENTER);
								}
								if (partEff8 != null)
								{
									paintBody(g, cx + num18, cy - num17, 2);
								}
								else
								{
									SmallImage.drawSmallImage(g, getBodyPaintId(), cx + hdx + dxBody * cdir, cy - SmallImage.getHeight(getLegId()) - 9 - hdy - dy + dyBody, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								paintMatna(g, cx + num18, cy - num17, 2);
							}
							else
							{
								if (part4 != null)
								{
									SmallImage.drawSmallImage(g, part4.pi[CharInfo[cf][3][0]].id, cx - CharInfo[cf][3][1] - part4.pi[CharInfo[cf][3][0]].dx, cy - CharInfo[cf][3][2] + part4.pi[CharInfo[cf][3][0]].dy - 10, 2, 24);
								}
								if (statusMe == 3)
								{
									SmallImage.drawSmallImage(g, 2077, cx, cy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
									g.drawRegion(GameScr.imgMatcho, 0, tickEffWolf * 3, 3, 3, 0, cx - 23, cy - 30, 0);
								}
								else if (statusMe == 4)
								{
									SmallImage.drawSmallImage(g, 2076, cx, cy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
									g.drawRegion(GameScr.imgMatcho, 0, tickEffWolf * 3, 3, 3, 0, cx - 24, cy - 20, 0);
								}
								else if (statusMe == 1 || statusMe == 6)
								{
									SmallImage.drawSmallImage(g, (tickWolf != 0) ? 2072 : 2073, cx, cy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
									g.drawRegion(GameScr.imgMatcho, 0, tickEffWolf * 3, 3, 3, 0, cx - 24, cy - 20, 0);
								}
								else if (statusMe == 2 || statusMe == 10)
								{
									SmallImage.drawSmallImage(g, array4[tickWolf], cx, cy - dy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
									g.drawRegion(GameScr.imgMatcho, 0, tickEffWolf * 3, 3, 3, 0, cx - 24, array6[tickWolf], 0);
								}
								int num19 = 15;
								int num20 = 2;
								if (cdir == 1)
								{
									num20 = -2;
								}
								if (partEff9 != null)
								{
									paintHair(g, cx + num20, cy - num19, 2);
								}
								else
								{
									SmallImage.drawSmallImage(g, getHeadId(), cx + hdx + dxHead * cdir, cy - CharInfo[0][0][2] + part.pi[CharInfo[0][0][0]].dy - 12 - hdy - dy + dyHead, 2, mGraphics.TOP | mGraphics.HCENTER);
								}
								if (partEff8 != null)
								{
									paintBody(g, cx + num20, cy - num19, 2);
								}
								else
								{
									SmallImage.drawSmallImage(g, getBodyPaintId(), cx + hdx + dxBody * cdir, cy - SmallImage.getHeight(getLegId()) - 9 - hdy - dy + dyBody, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								paintMatna(g, cx + num20, cy - num19, 2);
							}
						}
						else if (cdir == 1)
						{
							if (part4 != null)
							{
								SmallImage.drawSmallImage(g, part4.pi[CharInfo[cf][3][0]].id, cx + CharInfo[cf][3][1] + part4.pi[CharInfo[cf][3][0]].dx, cy - CharInfo[cf][3][2] + part4.pi[CharInfo[cf][3][0]].dy - 10, 0, 0);
							}
							if (statusMe == 3)
							{
								SmallImage.drawSmallImage(g, 1716, cx, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
							}
							else if (statusMe == 4)
							{
								SmallImage.drawSmallImage(g, 1717, cx, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
							}
							else if (statusMe == 1 || statusMe == 6)
							{
								SmallImage.drawSmallImage(g, (tickWolf != 0) ? 1713 : 1712, cx, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
							}
							else if (statusMe == 2 || statusMe == 10)
							{
								SmallImage.drawSmallImage(g, idWolfW[tickWolf], cx, cy - dy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
							}
							int num21 = 14;
							int num22 = 2;
							if (cdir == 1)
							{
								num22 = -2;
							}
							if (partEff9 != null)
							{
								paintHair(g, cx + num22, cy - num21, 2);
							}
							else
							{
								SmallImage.drawSmallImage(g, getHeadId(), cx + hdx + dxHead * cdir, cy - CharInfo[0][0][2] + part.pi[CharInfo[0][0][0]].dy - 12 - hdy - dy + dyHead, 0, mGraphics.TOP | mGraphics.HCENTER);
							}
							if (partEff8 != null)
							{
								paintBody(g, cx + num22, cy - num21, 2);
							}
							else
							{
								SmallImage.drawSmallImage(g, getBodyPaintId(), cx + hdx + dxBody * cdir, cy - SmallImage.getHeight(getLegId()) - 9 - hdy - dy + dyBody, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
							}
							paintMatna(g, cx + num22, cy - num21, 2);
						}
						else
						{
							if (part4 != null)
							{
								SmallImage.drawSmallImage(g, part4.pi[CharInfo[cf][3][0]].id, cx - CharInfo[cf][3][1] - part4.pi[CharInfo[cf][3][0]].dx, cy - CharInfo[cf][3][2] + part4.pi[CharInfo[cf][3][0]].dy - 10, 2, 24);
							}
							if (statusMe == 3)
							{
								SmallImage.drawSmallImage(g, 1716, cx, cy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
							}
							else if (statusMe == 4)
							{
								SmallImage.drawSmallImage(g, 1717, cx, cy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
							}
							else if (statusMe == 1 || statusMe == 6)
							{
								SmallImage.drawSmallImage(g, (tickWolf != 0) ? 1713 : 1712, cx, cy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
							}
							else if (statusMe == 2 || statusMe == 10)
							{
								SmallImage.drawSmallImage(g, idWolfW[tickWolf], cx, cy - dy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
							}
							int num23 = 14;
							int num24 = 2;
							if (cdir == 1)
							{
								num24 = -2;
							}
							if (partEff9 != null)
							{
								paintHair(g, cx - num24, cy - num23, 2);
							}
							else
							{
								SmallImage.drawSmallImage(g, getHeadId(), cx + hdx + dxHead * cdir, cy - CharInfo[0][0][2] + part.pi[CharInfo[0][0][0]].dy - 12 - hdy - dy + dyHead, 2, mGraphics.TOP | mGraphics.HCENTER);
							}
							if (partEff8 != null)
							{
								paintBody(g, cx + num24, cy - num23, 2);
							}
							else
							{
								SmallImage.drawSmallImage(g, getBodyPaintId(), cx + hdx + dxBody * cdir, cy - SmallImage.getHeight(getLegId()) - 9 - hdy - dy + dyBody, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
							}
							paintMatna(g, cx + num24, cy - num23, 2);
						}
					}
				}
				else
				{
					int transform = 2;
					int anchor = 24;
					if (cdir == 1)
					{
						transform = 0;
						anchor = 0;
					}
					if (isNewMount)
					{
						paintNewMount(g, part4, part, array, partEff3);
						paintPP_Top(g);
						partEff5?.paintTopEff_new(g, cx, cy - getDyHorse(), FrameName, 0);
						partEff4?.paintTopEff_new(g, cx, cy - getDyHorse(), FrameRank, (cdir != 1) ? 2 : 0);
						if (partEff != null)
						{
							paintWeaponTop(g, cx, cy, 2, partEff);
						}
						return;
					}
					if (isMotoBehind)
					{
						if (isHaveNewMount())
						{
							paintBehindNewMount(g);
						}
						else if (!isMoto && !isWolf)
						{
							if (arrItemMounts[4].template.id == 485)
							{
								if (arrItemMounts[4].sys <= 1)
								{
									SmallImage.drawSmallImage(g, 1800, lcx, lcy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								else
								{
									SmallImage.drawSmallImage(g, 2063, lcx, lcy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
							}
							else if (arrItemMounts[4].template.id == 524)
							{
								if (arrItemMounts[4].sys <= 1)
								{
									SmallImage.drawSmallImage(g, 2067, lcx, lcy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
								else
								{
									SmallImage.drawSmallImage(g, 2071, lcx, lcy, 2, mGraphics.BOTTOM | mGraphics.HCENTER);
								}
							}
						}
					}
					if (array != null && partEff10 == null)
					{
						SmallImage.drawSmallImage(g, array[tickCoat], cx + dxnewhorse - 7 * cdir, cy - dynewhhorse - 18, transform, mGraphics.TOP | mGraphics.HCENTER);
					}
					if (part4 != null)
					{
						SmallImage.drawSmallImage(g, part4.pi[CharInfo[cf][3][0]].id, cx + dxnewhorse + (CharInfo[cf][3][1] + part4.pi[CharInfo[cf][3][0]].dx) * cdir, cy - dynewhhorse - CharInfo[cf][3][2] + part4.pi[CharInfo[cf][3][0]].dy, transform, anchor);
					}
					if (partEff7 == null)
					{
						if (partEff6 != null)
						{
							partEff6.paintBottomEff_new(g, cx, cy, getFrameLeg(), (cdir != 1) ? 2 : 0);
							partEff6.paintTopEff_new(g, cx, cy, getFrameLeg(), (cdir != 1) ? 2 : 0);
						}
						else
						{
							SmallImage.drawSmallImage(g, part2.pi[CharInfo[cf][1][0]].id, cx + (CharInfo[cf][1][1] + part2.pi[CharInfo[cf][1][0]].dx) * cdir, cy - CharInfo[cf][1][2] + part2.pi[CharInfo[cf][1][0]].dy, transform, anchor);
						}
					}
					if (statusMe != 2)
					{
						paintClanEffect(g, cx + 7 * cdir, cy - 2);
					}
					if (statusMe != 1 && statusMe != 6)
					{
						if (partEff9 != null)
						{
							partEff9.paintBottomEff_new(g, cx + dxnewhorse, cy - dynewhhorse, getFrameHair(), (cdir != 1) ? 2 : 0);
							partEff9.paintTopEff_new(g, cx + dxnewhorse, cy - dynewhhorse, getFrameHair(), (cdir != 1) ? 2 : 0);
						}
						else
						{
							SmallImage.drawSmallImage(g, part.pi[CharInfo[cf][0][0]].id, cx + dxnewhorse + (CharInfo[cf][0][1] + part.pi[CharInfo[cf][0][0]].dx) * cdir, cy - dynewhhorse - CharInfo[cf][0][2] + part.pi[CharInfo[cf][0][0]].dy, transform, anchor);
						}
					}
					if (partEff8 != null)
					{
						partEff8.paintBottomEff_new(g, cx + dxnewhorse, cy - dynewhhorse, getFrameBody(), (cdir != 1) ? 2 : 0);
						partEff8.paintTopEff_new(g, cx + dxnewhorse, cy - dynewhhorse, getFrameBody(), (cdir != 1) ? 2 : 0);
					}
					else
					{
						SmallImage.drawSmallImage(g, part3.pi[CharInfo[cf][2][0]].id, cx + dxnewhorse + (CharInfo[cf][2][1] + part3.pi[CharInfo[cf][2][0]].dx) * cdir, cy - CharInfo[cf][2][2] + part3.pi[CharInfo[cf][2][0]].dy - dynewhhorse, transform, anchor);
					}
					if (statusMe == 1 || statusMe == 6)
					{
						if (partEff9 != null)
						{
							partEff9.paintBottomEff_new(g, cx + dxnewhorse, cy - dynewhhorse, getFrameHair(), (cdir != 1) ? 2 : 0);
							partEff9.paintTopEff_new(g, cx + dxnewhorse, cy - dynewhhorse, getFrameHair(), (cdir != 1) ? 2 : 0);
						}
						else
						{
							SmallImage.drawSmallImage(g, part.pi[CharInfo[cf][0][0]].id, cx + dxnewhorse + (CharInfo[cf][0][1] + part.pi[CharInfo[cf][0][0]].dx) * cdir, cy - dynewhhorse - CharInfo[cf][0][2] + part.pi[CharInfo[cf][0][0]].dy, transform, anchor);
						}
					}
					if (partEff3 != null)
					{
						partEff3.paintBottomEff_new(g, cx + dxnewhorse, cy - dynewhhorse, getFrameMatna(), (cdir != 1) ? 2 : 0);
						partEff3.paintTopEff_new(g, cx + dxnewhorse, cy - dynewhhorse, getFrameMatna(), (cdir != 1) ? 2 : 0);
					}
					if (statusMe == 2)
					{
						paintClanEffectRun(g, cx - 14 * cdir, cy - 2);
						paintClanEffect2(g, cx + 7 * cdir, cy - 2);
					}
					else
					{
						paintClanEffect(g, cx - 7 * cdir, cy - 2);
						paintClanEffect2(g, cx + 11 * cdir, cy - 2);
					}
				}
				partEff7?.paintTopEff_new(g, cx, cy, getFrameHores(), (cdir == 1) ? 2 : 0);
				paintPP_Top(g);
				partEff5?.paintTopEff_new(g, cx, cy - getDyHorse(), FrameName, 0);
				partEff4?.paintTopEff_new(g, cx, cy - getDyHorse(), FrameRank, (cdir != 1) ? 2 : 0);
				if (partEff != null)
				{
					paintWeaponTop(g, cx, cy, 2, partEff);
				}
			}
			if (isLockAttack)
			{
				SmallImage.drawSmallImage(g, 290, cx, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
			}
		}
		catch (Exception)
		{
		}
	}

	private int getLegId()
	{
		return ((CharPartInfo)CharPartInfo.head_jump.get(leg + string.Empty))?.idSmall ?? (leg switch
		{
			0 => 26, 
			4 => 58, 
			6 => 86, 
			8 => 114, 
			9 => 123, 
			17 => 353, 
			19 => 379, 
			21 => 405, 
			30 => 484, 
			33 => 518, 
			35 => 544, 
			37 => 571, 
			39 => 810, 
			43 => 982, 
			95 => 1156, 
			142 => 1360, 
			155 => 1494, 
			157 => 1519, 
			_ => 26, 
		});
	}

	private int getBodyPaintId()
	{
		dxBody = 0;
		dyBody = 0;
		CharPartInfo charPartInfo = null;
		Part part = GameScr.parts[body];
		if (statusMe == 3)
		{
			charPartInfo = (CharPartInfo)CharPartInfo.body_jump.get(body + string.Empty);
			if (charPartInfo != null)
			{
				CharPartInfo charPartInfo2 = (CharPartInfo)charPartInfo.item.get(arrItemMounts[4].template.id + string.Empty);
				if (charPartInfo2 != null)
				{
					dxBody = charPartInfo2.dx;
					dyBody = charPartInfo2.dy;
					return (part == null) ? charPartInfo.idSmall : part.pi[frameFix].id;
				}
			}
			switch (body)
			{
			case 1:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 4;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 4;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -8;
					dyBody = -6;
				}
				return 13;
			case 3:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 4;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 4;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -8;
					dyBody = -6;
				}
				return 45;
			case 5:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 4;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 4;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -9;
					dyBody = -7;
				}
				return 73;
			case 7:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 4;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 4;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -9;
					dyBody = -7;
				}
				return 101;
			case 10:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 4;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 4;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -9;
					dyBody = -7;
				}
				return 137;
			case 18:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 4;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 4;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -9;
					dyBody = -7;
				}
				return 365;
			case 20:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 4;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 4;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -9;
					dyBody = -7;
				}
				return 391;
			case 22:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 4;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 4;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -9;
					dyBody = -7;
				}
				return 417;
			case 29:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 1;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 1;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -3;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -11;
					dyBody = -6;
				}
				return 472;
			case 32:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 1;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 1;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -3;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -11;
					dyBody = -6;
				}
				return 506;
			case 34:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 3;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 3;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -8;
					dyBody = -7;
				}
				return 531;
			case 36:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 3;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 3;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -8;
					dyBody = -7;
				}
				return 559;
			case 38:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 3;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 3;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -8;
					dyBody = -7;
				}
				return 798;
			case 42:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 3;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 3;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -8;
					dyBody = -7;
				}
				return 970;
			case 94:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 0;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 0;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -4;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -12;
					dyBody = -7;
				}
				return 1142;
			case 141:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 3;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 3;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -9;
					dyBody = -7;
				}
				return 1348;
			case 154:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = -3;
					dyBody = 0;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = -3;
					dyBody = 0;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -8;
					dyBody = 0;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -15;
					dyBody = -3;
				}
				return 1487;
			case 156:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 1;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 1;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -4;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -10;
					dyBody = -7;
				}
				return 1507;
			case 157:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 4;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 4;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -8;
					dyBody = -7;
				}
				return 1812;
			case 173:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 4;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 4;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -8;
					dyBody = -7;
				}
				return 1838;
			case 180:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 4;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 4;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -8;
					dyBody = -7;
				}
				return 1959;
			case 183:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 4;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 4;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -8;
					dyBody = -7;
				}
				return 1987;
			case 186:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = -3;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = -3;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -6;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -14;
					dyBody = -5;
				}
				return 2117;
			case 189:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = -3;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = -3;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -6;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -14;
					dyBody = -5;
				}
				return 2144;
			case 206:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = -1;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = -1;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -5;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -10;
					dyBody = -6;
				}
				return 2459;
			case 197:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = -1;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = -1;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -5;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -10;
					dyBody = -6;
				}
				return 2342;
			case 199:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = -1;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = -1;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -5;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -10;
					dyBody = -6;
				}
				return 2373;
			default:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 3;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 3;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = 0;
					dyBody = -4;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -7;
					dyBody = -6;
				}
				return 13;
			}
		}
		if (!isBocdau)
		{
			charPartInfo = (CharPartInfo)CharPartInfo.body_normal.get(body + string.Empty);
			if (charPartInfo != null)
			{
				CharPartInfo charPartInfo3 = (CharPartInfo)charPartInfo.item.get(arrItemMounts[4].template.id + string.Empty);
				if (charPartInfo3 != null)
				{
					dxBody = charPartInfo3.dx;
					dyBody = charPartInfo3.dy;
					return (part == null) ? charPartInfo.idSmall : part.pi[frameFix].id;
				}
			}
			switch (body)
			{
			case 1:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 2;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 2;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = 0;
					dyBody = 0;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -5;
					dyBody = -2;
				}
				return 9;
			case 3:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 0;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 0;
					dyBody = -3;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = 0;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -5;
					dyBody = -3;
				}
				return 41;
			case 5:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -6;
					dyBody = -2;
				}
				return 70;
			case 7:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -6;
					dyBody = -2;
				}
				return 97;
			case 10:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -6;
					dyBody = -2;
				}
				return 133;
			case 18:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -6;
					dyBody = -2;
				}
				return 369;
			case 20:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -6;
					dyBody = -2;
				}
				return 395;
			case 22:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -6;
					dyBody = -2;
				}
				return 421;
			case 29:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = 0;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -6;
					dyBody = -2;
				}
				return 468;
			case 32:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = 0;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -6;
					dyBody = -2;
				}
				return 502;
			case 34:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = 0;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -5;
					dyBody = -2;
				}
				return 540;
			case 36:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = 0;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -5;
					dyBody = -2;
				}
				return 555;
			case 38:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = 0;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -5;
					dyBody = -2;
				}
				return 794;
			case 42:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = 0;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -5;
					dyBody = -2;
				}
				return 966;
			case 94:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 0;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = 0;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -5;
					dyBody = -2;
				}
				return 1139;
			case 141:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = -2;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = -2;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -3;
					dyBody = 0;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -7;
					dyBody = -1;
				}
				return 1343;
			case 154:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 0;
					dyBody = 0;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 0;
					dyBody = 0;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = 0;
					dyBody = 1;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -3;
					dyBody = -1;
				}
				return 1479;
			case 156:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 3;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 3;
					dyBody = -2;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = 0;
					dyBody = 2;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -3;
					dyBody = 0;
				}
				return 1502;
			case 157:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 0;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 0;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -6;
					dyBody = -2;
				}
				return 1808;
			case 173:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 0;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 0;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -6;
					dyBody = -2;
				}
				return 1834;
			case 180:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 0;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 0;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -6;
					dyBody = -2;
				}
				return 1955;
			case 183:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 0;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 0;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -1;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -6;
					dyBody = -2;
				}
				return 1983;
			case 186:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 0;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 0;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -2;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -8;
					dyBody = -2;
				}
				return 2135;
			case 189:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 0;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 0;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -2;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -8;
					dyBody = -2;
				}
				return 2135;
			case 206:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = -3;
					dyBody = 0;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = -3;
					dyBody = 0;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -4;
					dyBody = 0;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -9;
					dyBody = -1;
				}
				return 2456;
			case 197:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = -3;
					dyBody = 0;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = -3;
					dyBody = 0;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -4;
					dyBody = 0;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -5;
					dyBody = -1;
				}
				return 2337;
			case 199:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = -3;
					dyBody = 0;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = -3;
					dyBody = 0;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = -4;
					dyBody = 0;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -5;
					dyBody = -1;
				}
				return 2363;
			default:
				if (arrItemMounts[4].template.id == 443)
				{
					dxBody = 2;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 523)
				{
					dxBody = 2;
					dyBody = -1;
				}
				else if (arrItemMounts[4].template.id == 485)
				{
					dxBody = 0;
					dyBody = 0;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxBody = -5;
					dyBody = -2;
				}
				return 9;
			}
		}
		charPartInfo = (CharPartInfo)CharPartInfo.body_boc_dau.get(body + string.Empty);
		if (charPartInfo != null)
		{
			CharPartInfo charPartInfo4 = (CharPartInfo)charPartInfo.item.get(arrItemMounts[4].template.id + string.Empty);
			if (charPartInfo4 != null)
			{
				dxBody = charPartInfo4.dx;
				dyBody = charPartInfo4.dy;
				return (part == null) ? charPartInfo.idSmall : part.pi[frameFix].id;
			}
		}
		switch (body)
		{
		case 1:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = 3;
				dyBody = -3;
				dxBody = 4;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = 3;
				dyBody = -3;
				dxBody = 4;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -1;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -8;
				dyBody = -6;
			}
			return 13;
		case 3:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = 4;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = 4;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -1;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -8;
				dyBody = -6;
			}
			return 45;
		case 5:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = 4;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = 4;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -1;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -9;
				dyBody = -7;
			}
			return 73;
		case 7:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = 4;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = 4;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -1;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -9;
				dyBody = -7;
			}
			return 101;
		case 10:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = 4;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = 4;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -1;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -9;
				dyBody = -7;
			}
			return 137;
		case 18:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = 4;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = 4;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -1;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -9;
				dyBody = -7;
			}
			return 365;
		case 20:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = 4;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = 4;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -1;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -9;
				dyBody = -7;
			}
			return 391;
		case 22:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = 4;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = 4;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -1;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -9;
				dyBody = -7;
			}
			return 417;
		case 29:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = 1;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = 1;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -3;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -11;
				dyBody = -6;
			}
			return 472;
		case 32:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = 1;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = 1;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -3;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -11;
				dyBody = -6;
			}
			return 506;
		case 34:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = 3;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = 3;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -1;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -8;
				dyBody = -7;
			}
			return 531;
		case 36:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = 3;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = 3;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -1;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -8;
				dyBody = -7;
			}
			return 559;
		case 38:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = 3;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = 3;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -1;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -8;
				dyBody = -7;
			}
			return 798;
		case 42:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = 3;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = 3;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -1;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -8;
				dyBody = -7;
			}
			return 970;
		case 94:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = 0;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = 0;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -4;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -12;
				dyBody = -7;
			}
			return 1142;
		case 141:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = 3;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = 3;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -1;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -9;
				dyBody = -7;
			}
			return 1348;
		case 154:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = -3;
				dyBody = 0;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = -3;
				dyBody = 0;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -8;
				dyBody = 0;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -15;
				dyBody = -3;
			}
			return 1487;
		case 156:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = 1;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = 1;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -4;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -10;
				dyBody = -7;
			}
			return 1507;
		case 157:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = 4;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = 4;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -1;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -8;
				dyBody = -7;
			}
			return 1812;
		case 173:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = 4;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = 4;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -1;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -8;
				dyBody = -7;
			}
			return 1838;
		case 180:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = 4;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = 4;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -1;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -8;
				dyBody = -7;
			}
			return 1959;
		case 183:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = 4;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = 4;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -1;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -8;
				dyBody = -7;
			}
			return 1987;
		case 186:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = -3;
				dyBody = -2;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = -3;
				dyBody = -2;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -6;
				dyBody = -2;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -14;
				dyBody = -5;
			}
			return 2117;
		case 189:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = -3;
				dyBody = -2;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = -3;
				dyBody = -2;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -6;
				dyBody = -2;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -14;
				dyBody = -5;
			}
			return 2144;
		case 206:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = -1;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = -1;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -5;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -10;
				dyBody = -6;
			}
			return 2459;
		case 197:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = -1;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = -1;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -5;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -10;
				dyBody = -6;
			}
			return 2342;
		case 199:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = -1;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = -1;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = -5;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -10;
				dyBody = -6;
			}
			return 2373;
		default:
			if (arrItemMounts[4].template.id == 443)
			{
				dxBody = 3;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 523)
			{
				dxBody = 3;
				dyBody = -3;
			}
			else if (arrItemMounts[4].template.id == 485)
			{
				dxBody = 0;
				dyBody = -4;
			}
			else if (arrItemMounts[4].template.id == 524)
			{
				dxBody = -7;
				dyBody = -6;
			}
			return 13;
		}
	}

	private int getHeadId()
	{
		dxHead = (dyHead = 0);
		Part part = GameScr.parts[head];
		CharPartInfo charPartInfo = null;
		if (statusMe == 3)
		{
			charPartInfo = (CharPartInfo)CharPartInfo.head_jump.get(head + string.Empty);
			if (charPartInfo != null)
			{
				CharPartInfo charPartInfo2 = (CharPartInfo)charPartInfo.item.get(arrItemMounts[4].template.id + string.Empty);
				if (charPartInfo2 != null)
				{
					dxHead = charPartInfo2.dx;
					dyHead = charPartInfo2.dy;
					return (part == null) ? charPartInfo.idSmall : part.pi[frameFix].id;
				}
			}
			switch (head)
			{
			case 2:
				dxHead = 0;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 33;
			case 11:
				dxHead = 0;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 147;
			case 23:
				dxHead = 1;
				dyHead = -4;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 427;
			case 24:
				dxHead = 1;
				dyHead = -4;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 430;
			case 25:
				dxHead = 3;
				dyHead = -4;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 433;
			case 26:
				dxHead = 0;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 436;
			case 27:
				dxHead = 0;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 439;
			case 28:
				dxHead = 0;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 442;
			case 112:
				dxHead = 1;
				dyHead = -4;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 148;
			case 113:
				dxHead = -1;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 443;
			case 124:
				dxHead = 1;
				dyHead = -4;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 1235;
			case 125:
				dxHead = -1;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 1237;
			case 126:
				dxHead = -1;
				dyHead = -4;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 1255;
			case 127:
				dxHead = -1;
				dyHead = -4;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 1257;
			case 137:
				dxHead = 0;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 1309;
			case 138:
				dxHead = 0;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 1311;
			case 139:
				dxHead = 2;
				dyHead = -5;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 1315;
			case 140:
				dxHead = 3;
				dyHead = -4;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 1313;
			case 146:
				dxHead = 1;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 1416;
			case 147:
				dxHead = -2;
				dyHead = -4;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 1418;
			case 148:
				dxHead = 0;
				dyHead = -4;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 1422;
			case 149:
				dxHead = -2;
				dyHead = -4;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 1424;
			case 150:
				dxHead = 0;
				dyHead = -4;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 1441;
			case 151:
				dxHead = -2;
				dyHead = -4;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 1439;
			case 152:
				dxHead = 1;
				dyHead = -4;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 1447;
			case 153:
				dxHead = 0;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 1445;
			case 158:
				dxHead = -2;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 1585;
			case 159:
				dxHead = 0;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 1589;
			case 160:
				dxHead = 2;
				dyHead = -2;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 1587;
			case 161:
				dxHead = 3;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 1595;
			case 162:
				dxHead = -5;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 1597;
			case 163:
				dxHead = -3;
				dyHead = -2;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 1604;
			case 179:
				dxHead = 3;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 1978;
			case 182:
				dxHead = 3;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 2006;
			case 185:
				dxHead = -4;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 2129;
			case 188:
				dxHead = 0;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 2156;
			case 205:
				dxHead = 0;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 2451;
			case 210:
				dxHead = 0;
				dyHead = -5;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 2519;
			case 211:
				dxHead = -1;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 2521;
			case 212:
				dxHead = -2;
				dyHead = -2;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 2523;
			case 213:
				dxHead = 0;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 2525;
			case 214:
				dxHead = 1;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 2526;
			default:
				dxHead = 2;
				dyHead = -5;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dxHead -= 2;
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 7;
						dyHead--;
					}
				}
				return 33;
			}
		}
		if (!isBocdau)
		{
			charPartInfo = (CharPartInfo)CharPartInfo.head_normal.get(head + string.Empty);
			if (charPartInfo != null)
			{
				CharPartInfo charPartInfo3 = (CharPartInfo)charPartInfo.item.get(arrItemMounts[4].template.id + string.Empty);
				if (charPartInfo3 != null)
				{
					dxHead = charPartInfo3.dx;
					dyHead = charPartInfo3.dy;
					return (part == null) ? charPartInfo.idSmall : part.pi[frameFix].id;
				}
			}
			switch (head)
			{
			case 2:
				dxHead = -1;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 33;
			case 11:
				dxHead = -2;
				dyHead = -1;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 147;
			case 23:
				dxHead = -1;
				dyHead = -2;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 427;
			case 24:
				dxHead = -1;
				dyHead = -2;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 430;
			case 25:
				dxHead = 1;
				dyHead = -2;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 433;
			case 26:
				dxHead = -2;
				dyHead = -1;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 436;
			case 27:
				dxHead = -2;
				dyHead = -1;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 439;
			case 28:
				dxHead = -2;
				dyHead = -1;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 442;
			case 112:
				dxHead = -1;
				dyHead = -2;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 148;
			case 113:
				dxHead = -3;
				dyHead = -1;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 443;
			case 124:
				dxHead = -1;
				dyHead = -2;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 1235;
			case 125:
				dxHead = -1;
				dyHead = -2;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 1237;
			case 126:
				dxHead = -1;
				dyHead = -2;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 1255;
			case 127:
				dxHead = -3;
				dyHead = -2;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 1257;
			case 137:
				dxHead = -2;
				dyHead = -1;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 1309;
			case 138:
				dxHead = -2;
				dyHead = -1;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 1311;
			case 139:
				dxHead = 0;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 1315;
			case 140:
				dxHead = 1;
				dyHead = -2;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 1313;
			case 146:
				dxHead = -1;
				dyHead = -1;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 1416;
			case 147:
				dxHead = -4;
				dyHead = -2;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 1418;
			case 148:
				dxHead = -2;
				dyHead = -2;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 1422;
			case 149:
				dxHead = -4;
				dyHead = -2;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 1424;
			case 150:
				dxHead = -2;
				dyHead = -2;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 1441;
			case 151:
				dxHead = -4;
				dyHead = -2;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 1439;
			case 152:
				dxHead = -1;
				dyHead = -2;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 1447;
			case 153:
				dxHead = -2;
				dyHead = -1;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 1445;
			case 158:
				dxHead = -4;
				dyHead = -1;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 1585;
			case 159:
				dxHead = -2;
				dyHead = -1;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 1589;
			case 160:
				dxHead = 0;
				dyHead = 0;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 1587;
			case 161:
				dxHead = 1;
				dyHead = -1;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 1595;
			case 162:
				dxHead = -7;
				dyHead = -1;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 1597;
			case 163:
				dxHead = -5;
				dyHead = 0;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 1604;
			case 179:
				dxHead = 1;
				dyHead = -1;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 1978;
			case 182:
				dxHead = 1;
				dyHead = -1;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 2006;
			case 185:
				dxHead = -6;
				dyHead = -1;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 2129;
			case 188:
				dxHead = -2;
				dyHead = -1;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 2156;
			case 205:
				dxHead = -2;
				dyHead = -1;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 2451;
			case 210:
				dxHead = -2;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 2519;
			case 211:
				dxHead = -3;
				dyHead = -1;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 2521;
			case 212:
				dxHead = -4;
				dyHead = 0;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 2523;
			case 213:
				dxHead = 0;
				dyHead = -1;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 2525;
			case 214:
				dxHead = -1;
				dyHead = -1;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 2526;
			default:
				dxHead = -1;
				dyHead = -3;
				if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
				{
					if (arrItemMounts[4].template.id == 485)
					{
						dyHead++;
					}
					else if (arrItemMounts[4].template.id == 524)
					{
						dxHead -= 5;
						dyHead--;
					}
				}
				return 33;
			}
		}
		charPartInfo = (CharPartInfo)CharPartInfo.head_boc_dau.get(head + string.Empty);
		if (charPartInfo != null)
		{
			CharPartInfo charPartInfo4 = (CharPartInfo)charPartInfo.item.get(arrItemMounts[4].template.id + string.Empty);
			if (charPartInfo4 != null)
			{
				dxHead = charPartInfo4.dx;
				dyHead = charPartInfo4.dy;
				return (part == null) ? charPartInfo.idSmall : part.pi[frameFix].id;
			}
		}
		switch (head)
		{
		case 2:
			dxHead = 2;
			dyHead = -5;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 33;
		case 11:
			dxHead = 0;
			dyHead = -3;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 147;
		case 23:
			dxHead = 1;
			dyHead = -4;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 427;
		case 24:
			dxHead = 1;
			dyHead = -4;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 430;
		case 25:
			dxHead = 3;
			dyHead = -4;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 433;
		case 26:
			dxHead = 0;
			dyHead = -3;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 436;
		case 27:
			dxHead = 0;
			dyHead = -3;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 439;
		case 28:
			dxHead = 0;
			dyHead = -3;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 442;
		case 112:
			dxHead = 1;
			dyHead = -4;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 148;
		case 113:
			dxHead = -1;
			dyHead = -3;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 443;
		case 124:
			dxHead = 1;
			dyHead = -4;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 1235;
		case 125:
			dxHead = -1;
			dyHead = -3;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 1237;
		case 126:
			dxHead = -1;
			dyHead = -4;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 1255;
		case 127:
			dxHead = -1;
			dyHead = -4;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 1257;
		case 137:
			dxHead = 0;
			dyHead = -3;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 1309;
		case 138:
			dxHead = 0;
			dyHead = -3;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 1311;
		case 139:
			dxHead = 2;
			dyHead = -5;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 1315;
		case 140:
			dxHead = 3;
			dyHead = -4;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 1313;
		case 146:
			dxHead = 1;
			dyHead = -3;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 1416;
		case 147:
			dxHead = -2;
			dyHead = -4;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 1418;
		case 148:
			dxHead = 0;
			dyHead = -4;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 1422;
		case 149:
			dxHead = -2;
			dyHead = -4;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 1424;
		case 150:
			dxHead = 0;
			dyHead = -4;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 1441;
		case 151:
			dxHead = -2;
			dyHead = -4;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 1439;
		case 152:
			dxHead = 1;
			dyHead = -4;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 1447;
		case 153:
			dxHead = 0;
			dyHead = -3;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 1445;
		case 158:
			dxHead = -2;
			dyHead = -3;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 1585;
		case 159:
			dxHead = 0;
			dyHead = -3;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 1589;
		case 160:
			dxHead = 2;
			dyHead = -2;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 1587;
		case 161:
			dxHead = 3;
			dyHead = -3;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 1595;
		case 162:
			dxHead = -5;
			dyHead = -3;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 1597;
		case 163:
			dxHead = -3;
			dyHead = -2;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 1604;
		case 179:
			dxHead = 3;
			dyHead = -3;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 1978;
		case 182:
			dxHead = 3;
			dyHead = -3;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 2006;
		case 185:
			dxHead = -4;
			dyHead = -3;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 2129;
		case 188:
			dxHead = 0;
			dyHead = -3;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 2156;
		case 205:
			dxHead = 0;
			dyHead = -3;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 2451;
		case 210:
			dxHead = 0;
			dyHead = -5;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 2519;
		case 211:
			dxHead = -1;
			dyHead = -3;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 2521;
		case 212:
			dxHead = -2;
			dyHead = -2;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 2523;
		case 213:
			dxHead = 0;
			dyHead = -3;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 2525;
		case 214:
			dxHead = 1;
			dyHead = -3;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 2526;
		default:
			dxHead = 2;
			dyHead = -5;
			if (arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523)
			{
				if (arrItemMounts[4].template.id == 485)
				{
					dxHead -= 2;
					dyHead++;
				}
				else if (arrItemMounts[4].template.id == 524)
				{
					dxHead -= 7;
					dyHead--;
				}
			}
			return 33;
		}
	}

	private int[] getClanEffect()
	{
		if (statusMe != 6 && statusMe != 1 && statusMe != 2 && statusMe != 10 && statusMe != 11)
		{
			return null;
		}
		int[] result = null;
		if (me)
		{
			if (arrItemBody[13] != null)
			{
				if (arrItemBody[13].template.id == 425)
				{
					result = new int[5] { 1687, 1688, 1689, 1690, 1691 };
				}
				else if (arrItemBody[13].template.id == 426)
				{
					result = new int[5] { 1682, 1683, 1684, 1685, 1686 };
				}
				else if (arrItemBody[13].template.id == 427)
				{
					result = new int[5] { 1677, 1678, 1679, 1680, 1681 };
				}
			}
		}
		else
		{
			if (glove == -1)
			{
				return null;
			}
			if (glove == 425)
			{
				result = new int[5] { 1687, 1688, 1689, 1690, 1691 };
			}
			else if (glove == 426)
			{
				result = new int[5] { 1682, 1683, 1684, 1685, 1686 };
			}
			else if (glove == 427)
			{
				result = new int[5] { 1677, 1678, 1679, 1680, 1681 };
			}
		}
		return result;
	}

	public void paintClanEffect(mGraphics g, int x, int y)
	{
		int[] clanEffect = getClanEffect();
		if (clanEffect != null)
		{
			int transform = 0;
			if (statusMe == 2)
			{
				transform = ((cdir != 1) ? 5 : 6);
			}
			int num = GameCanvas.gameTick % 13;
			if (num > 9)
			{
				SmallImage.drawSmallImage(g, clanEffect[0], x, y, transform, mGraphics.HCENTER | mGraphics.BOTTOM);
			}
			else if (num > 6)
			{
				SmallImage.drawSmallImage(g, clanEffect[1], x, y, transform, mGraphics.HCENTER | mGraphics.BOTTOM);
			}
			else if (num > 3)
			{
				SmallImage.drawSmallImage(g, clanEffect[2], x - 2, y, transform, mGraphics.HCENTER | mGraphics.BOTTOM);
			}
			else
			{
				SmallImage.drawSmallImage(g, clanEffect[3], x - 2, y, transform, mGraphics.HCENTER | mGraphics.BOTTOM);
			}
		}
	}

	private void paintClanEffectRun(mGraphics g, int x, int y)
	{
		int[] clanEffect = getClanEffect();
		if (clanEffect != null)
		{
			int transform = ((cdir != 1) ? 5 : 6);
			int anchor = ((cdir != -1) ? (mGraphics.BOTTOM | mGraphics.LEFT) : (mGraphics.BOTTOM | mGraphics.RIGHT));
			int num = GameCanvas.gameTick % 13;
			if (num > 9)
			{
				SmallImage.drawSmallImage(g, clanEffect[0], x, y, transform, anchor);
			}
			else if (num > 6)
			{
				SmallImage.drawSmallImage(g, clanEffect[1], x, y, transform, anchor);
			}
			else if (num > 3)
			{
				SmallImage.drawSmallImage(g, clanEffect[2], x, y, transform, anchor);
			}
			else
			{
				SmallImage.drawSmallImage(g, clanEffect[3], x, y, transform, anchor);
			}
		}
	}

	public void paintClanEffect2(mGraphics g, int x, int y)
	{
		int[] clanEffect = getClanEffect();
		if (clanEffect != null)
		{
			SmallImage.drawSmallImage(g, clanEffect[4], x - 2, y, 0, mGraphics.HCENTER | mGraphics.BOTTOM);
		}
	}

	private void paintCharWithSkill(mGraphics g)
	{
		try
		{
			SkillInfoPaint[] array = skillInfoPaint1();
			cf = array[indexSkill].status;
			if (array[indexSkill].effS0Id != 0)
			{
				eff0 = GameScr.efs[array[indexSkill].effS0Id - 1];
				i0 = (dx0 = (dy0 = 0));
			}
			if (array[indexSkill].effS1Id != 0)
			{
				eff1 = GameScr.efs[array[indexSkill].effS1Id - 1];
				i1 = (dx1 = (dy1 = 0));
			}
			if (array[indexSkill].effS2Id != 0)
			{
				eff2 = GameScr.efs[array[indexSkill].effS2Id - 1];
				i2 = (dx2 = (dy2 = 0));
			}
			SkillInfoPaint[] array2 = array;
			if (array2 != null && array2[indexSkill] != null && array2[indexSkill].arrowId != 0)
			{
				arr = new Arrow(this, GameScr.arrs[array2[indexSkill].arrowId - 1]);
				arr.life = 10;
				arr.ax = cx + array2[indexSkill].adx;
				arr.ay = cy + array2[indexSkill].ady;
			}
			paintCharWithoutSkill(g);
			if (cdir == 1)
			{
				if (eff0 != null)
				{
					if (dx0 == 0)
					{
						dx0 = array[indexSkill].e0dx;
					}
					if (dy0 == 0)
					{
						dy0 = array[indexSkill].e0dy;
					}
					SmallImage.drawSmallImage(g, eff0.arrEfInfo[i0].idImg, cx + dx0 + eff0.arrEfInfo[i0].dx, cy + dy0 + eff0.arrEfInfo[i0].dy, 0, mGraphics.VCENTER | mGraphics.HCENTER);
					i0++;
					if (i0 >= eff0.arrEfInfo.Length)
					{
						eff0 = null;
						i0 = (dx0 = (dy0 = 0));
					}
				}
				if (eff1 != null)
				{
					if (dx1 == 0)
					{
						dx1 = array[indexSkill].e1dx;
					}
					if (dy1 == 0)
					{
						dy1 = array[indexSkill].e1dy;
					}
					SmallImage.drawSmallImage(g, eff1.arrEfInfo[i1].idImg, cx + dx1 + eff1.arrEfInfo[i1].dx, cy + dy1 + eff1.arrEfInfo[i1].dy, 0, mGraphics.VCENTER | mGraphics.HCENTER);
					i1++;
					if (i1 >= eff1.arrEfInfo.Length)
					{
						eff1 = null;
						i1 = (dx1 = (dy1 = 0));
					}
				}
				if (eff2 != null)
				{
					if (dx2 == 0)
					{
						dx2 = array[indexSkill].e2dx;
					}
					if (dy2 == 0)
					{
						dy2 = array[indexSkill].e2dy;
					}
					SmallImage.drawSmallImage(g, eff2.arrEfInfo[i2].idImg, cx + dx2 + eff2.arrEfInfo[i2].dx, cy + dy2 + eff2.arrEfInfo[i2].dy, 0, mGraphics.VCENTER | mGraphics.HCENTER);
					i2++;
					if (eff2.arrEfInfo != null && i2 >= eff2.arrEfInfo.Length)
					{
						eff2 = null;
						i2 = (dx2 = (dy2 = 0));
					}
				}
			}
			else
			{
				if (eff0 != null)
				{
					if (dx0 == 0)
					{
						dx0 = array[indexSkill].e0dx;
					}
					if (dy0 == 0)
					{
						dy0 = array[indexSkill].e0dy;
					}
					SmallImage.drawSmallImage(g, eff0.arrEfInfo[i0].idImg, cx - dx0 - eff0.arrEfInfo[i0].dx, cy + dy0 + eff0.arrEfInfo[i0].dy, 2, mGraphics.VCENTER | mGraphics.HCENTER);
					i0++;
					if (i0 >= eff0.arrEfInfo.Length)
					{
						eff0 = null;
						i0 = 0;
						dx0 = 0;
						dy0 = 0;
					}
				}
				if (eff1 != null)
				{
					if (dx1 == 0)
					{
						dx1 = array[indexSkill].e1dx;
					}
					if (dy1 == 0)
					{
						dy1 = array[indexSkill].e1dy;
					}
					SmallImage.drawSmallImage(g, eff1.arrEfInfo[i1].idImg, cx - dx1 - eff1.arrEfInfo[i1].dx, cy + dy1 + eff1.arrEfInfo[i1].dy, 2, mGraphics.VCENTER | mGraphics.HCENTER);
					i1++;
					if (i1 >= eff1.arrEfInfo.Length)
					{
						eff1 = null;
						i1 = 0;
						dx1 = 0;
						dy1 = 0;
					}
				}
				if (eff2 != null)
				{
					if (dx2 == 0)
					{
						dx2 = array[indexSkill].e2dx;
					}
					if (dy2 == 0)
					{
						dy2 = array[indexSkill].e2dy;
					}
					SmallImage.drawSmallImage(g, eff2.arrEfInfo[i2].idImg, cx - dx2 - eff2.arrEfInfo[i2].dx, cy + dy2 + eff2.arrEfInfo[i2].dy, 2, mGraphics.VCENTER | mGraphics.HCENTER);
					i2++;
					if (eff2.arrEfInfo != null && i2 >= eff2.arrEfInfo.Length)
					{
						eff2 = null;
						i2 = 0;
						dx2 = 0;
						dy2 = 0;
					}
				}
			}
			indexSkill++;
		}
		catch (Exception)
		{
		}
	}

	public static bool isCharInScreen(Char c)
	{
		int cmx = GameScr.cmx;
		int num = GameScr.cmx + GameCanvas.w;
		int num2 = GameScr.cmy + 10;
		int num3 = GameScr.cmy + GameScr.gH;
		if (c.statusMe != 15 && !c.isInvisible && cmx <= c.cx && c.cx <= num && num2 <= c.cy && c.cy <= num3)
		{
			return true;
		}
		return false;
	}

	public void callEff(int effId)
	{
		indexEff = 0;
		eff = GameScr.efs[effId];
	}

	public void callEffTask(int effId)
	{
		indexEffTask = 0;
		effTask = GameScr.efs[effId];
	}

	public static int getIndexChar(int ID)
	{
		for (int i = 0; i < GameScr.vCharInMap.size(); i++)
		{
			Char @char = (Char)GameScr.vCharInMap.elementAt(i);
			if (@char.charID == ID)
			{
				return i;
			}
		}
		return -1;
	}

	public void moveTo(int toX, int toY)
	{
		int dir = 0;
		int act = 0;
		int num = toX - cx;
		int num2 = toY - cy;
		if (num == 0 && num2 == 0)
		{
			act = 1;
		}
		else if (num2 == 0)
		{
			act = 2;
			if (vMovePoints.size() > 0)
			{
				MovePoint movePoint = null;
				try
				{
					movePoint = (MovePoint)vMovePoints.lastElement();
				}
				catch (Exception)
				{
				}
				if (movePoint != null && TileMap.tileTypeAt(movePoint.xEnd, movePoint.yEnd, TileMap.T_WATERFLOW) && movePoint.yEnd % TileMap.size > 8)
				{
					act = 10;
				}
			}
			if (num > 0)
			{
				dir = 1;
			}
			if (num < 0)
			{
				dir = -1;
			}
		}
		else if (num2 != 0)
		{
			if (num2 < 0)
			{
				act = 3;
			}
			if (num2 > 0)
			{
				act = 4;
			}
			if (num < 0)
			{
				dir = -1;
			}
			if (num > 0)
			{
				dir = 1;
			}
		}
		int num3 = 0;
		int num4 = 0;
		num3 = cx + num;
		num4 = cy + num2;
		vMovePoints.addElement(new MovePoint(num3, num4, act, dir));
		statusMe = 6;
	}

	public static void getcharInjure(int cID, int dx, int dy, int HP)
	{
		Char @char = (Char)GameScr.vCharInMap.elementAt(cID);
		if (@char.vMovePoints.size() != 0)
		{
			MovePoint movePoint = (MovePoint)@char.vMovePoints.lastElement();
			int xEnd = movePoint.xEnd + dx;
			int yEnd = movePoint.yEnd + dy;
			((Char)GameScr.vCharInMap.elementAt(cID)).cHP -= HP;
			if (((Char)GameScr.vCharInMap.elementAt(cID)).cHP < 0)
			{
				((Char)GameScr.vCharInMap.elementAt(cID)).cHP = 0;
			}
			((Char)GameScr.vCharInMap.elementAt(cID)).statusMe = 6;
			((Char)GameScr.vCharInMap.elementAt(cID)).HPShow = ((Char)GameScr.vCharInMap.elementAt(cID)).cHP - HP;
			((Char)GameScr.vCharInMap.elementAt(cID)).vMovePoints.addElement(new MovePoint(xEnd, yEnd, 8, ((Char)GameScr.vCharInMap.elementAt(cID)).cdir));
		}
	}

	public void searchFocus()
	{
		if (charFocus != null && charFocus.isNhanban)
		{
			charFocus = null;
		}
		if (isManualFocus && charFocus != null && (charFocus.statusMe == 15 || charFocus.isInvisible))
		{
			charFocus = null;
		}
		if (GameCanvas.gameTick % 2 == 0 || isMeCanAttackOtherPlayer(charFocus))
		{
			return;
		}
		int num = 0;
		if (nClass.classId == 0 || nClass.classId == 1 || nClass.classId == 3 || nClass.classId == 5)
		{
			num = ((GameScr.auto != 1) ? 40 : 0);
		}
		int[] array = new int[4] { -1, -1, -1, -1 };
		int num2 = GameScr.cmx - 10;
		int num3 = GameScr.cmx + GameCanvas.w + 10;
		int cmy = GameScr.cmy;
		int num4 = GameScr.cmy + GameCanvas.h - GameScr.cmdBarH + 10;
		if (isManualFocus)
		{
			if ((mobFocus != null && mobFocus.status != 1 && mobFocus.status != 0 && num2 <= mobFocus.x && mobFocus.x <= num3 && cmy <= mobFocus.y && mobFocus.y <= num4) || (npcFocus != null && num2 <= npcFocus.cx && npcFocus.cx <= num3 && cmy <= npcFocus.cy && npcFocus.cy <= num4) || (charFocus != null && num2 <= charFocus.cx && charFocus.cx <= num3 && cmy <= charFocus.cy && charFocus.cy <= num4) || (itemFocus != null && num2 <= itemFocus.x && itemFocus.x <= num3 && cmy <= itemFocus.y && itemFocus.y <= num4))
			{
				return;
			}
			isManualFocus = false;
		}
		if (itemFocus == null)
		{
			for (int i = 0; i < GameScr.vItemMap.size(); i++)
			{
				ItemMap itemMap = (ItemMap)GameScr.vItemMap.elementAt(i);
				int num5 = Math.abs(getMyChar().cx - itemMap.x);
				int num6 = Math.abs(getMyChar().cy - itemMap.y);
				int num7 = ((num5 <= num6) ? num6 : num5);
				if (num5 > 48 || num6 > 48 || (itemFocus != null && num7 >= array[3]))
				{
					continue;
				}
				if (GameScr.auto != 0 && GameScr.gI().isBagFull())
				{
					if (itemMap.template.type == 19)
					{
						if (GameScr.isUseitemAuto)
						{
							itemFocus = null;
						}
						else
						{
							itemFocus = itemMap;
						}
						array[3] = num7;
					}
				}
				else if (isAPickYen || isAPickYHM || isAPickYHMS || isANoPick)
				{
					if ((isAPickYen && itemMap.template.type == 19) || (isAPickYHM && (itemMap.template.type == 19 || itemMap.template.type == 16 || itemMap.template.type == 17)) || (isAPickYHMS && (itemMap.template.type == 19 || itemMap.template.type == 16 || itemMap.template.type == 17 || itemMap.template.type == 26)))
					{
						if (GameScr.isUseitemAuto)
						{
							itemFocus = null;
						}
						else
						{
							itemFocus = itemMap;
						}
						array[3] = num7;
					}
				}
				else
				{
					if (GameScr.isUseitemAuto)
					{
						itemFocus = null;
					}
					else
					{
						itemFocus = itemMap;
					}
					array[3] = num7;
				}
			}
		}
		else
		{
			if (num2 <= itemFocus.x && itemFocus.x <= num3 && cmy <= itemFocus.y && itemFocus.y <= num4)
			{
				clearFocus(3);
				return;
			}
			itemFocus = null;
			for (int j = 0; j < GameScr.vItemMap.size(); j++)
			{
				ItemMap itemMap2 = (ItemMap)GameScr.vItemMap.elementAt(j);
				int num8 = Math.abs(getMyChar().cx - itemMap2.x);
				int num9 = Math.abs(getMyChar().cy - itemMap2.y);
				int num10 = ((num8 <= num9) ? num9 : num8);
				if (num2 > itemMap2.x || itemMap2.x > num3 || cmy > itemMap2.y || itemMap2.y > num4 || (itemFocus != null && num10 >= array[3]))
				{
					continue;
				}
				if (GameScr.auto != 0 && GameScr.gI().isBagFull())
				{
					if (itemMap2.template.type == 19)
					{
						if (GameScr.isUseitemAuto)
						{
							itemFocus = null;
						}
						else
						{
							itemFocus = itemMap2;
						}
						array[3] = num10;
					}
				}
				else if (isAPickYen || isAPickYHM || isAPickYHMS || isANoPick)
				{
					if ((isAPickYen && itemMap2.template.type == 19) || (isAPickYHM && (itemMap2.template.type == 19 || itemMap2.template.type == 16 || itemMap2.template.type == 17)) || (isAPickYHMS && (itemMap2.template.type == 19 || itemMap2.template.type == 16 || itemMap2.template.type == 17 || itemMap2.template.type == 26)))
					{
						if (GameScr.isUseitemAuto)
						{
							itemFocus = null;
						}
						else
						{
							itemFocus = itemMap2;
						}
						array[3] = num10;
					}
				}
				else
				{
					if (GameScr.isUseitemAuto)
					{
						itemFocus = null;
					}
					else
					{
						itemFocus = itemMap2;
					}
					array[3] = num10;
				}
			}
		}
		if (TileMap.typeMap == TileMap.MAP_CHIENTRUONG || TileMap.mapID == 111)
		{
			num2 = getMyChar().cx - getMyChar().getdxSkill();
			num3 = getMyChar().cx + getMyChar().getdxSkill();
			cmy = getMyChar().cy - getMyChar().getdySkill() - num;
			num4 = getMyChar().cy + getMyChar().getdySkill();
			if (num4 > getMyChar().cy + 30)
			{
				num4 = getMyChar().cy + 30;
			}
			if (mobFocus == null)
			{
				for (int k = 0; k < GameScr.vMob.size(); k++)
				{
					Mob mob = (Mob)GameScr.vMob.elementAt(k);
					int num11 = Math.abs(getMyChar().cx - mob.x);
					int num12 = Math.abs(getMyChar().cy - mob.y);
					int num13 = ((num11 <= num12) ? num12 : num11);
					if ((mob.templateId != 97 || getMyChar().cTypePk != PK_PHE1) && (mob.templateId != 96 || getMyChar().cTypePk != PK_PHE2) && (mob.templateId != 98 || getMyChar().cTypePk != PK_PHE1) && (mob.templateId != 167 || getMyChar().cTypePk != PK_PHE1) && (mob.templateId != 99 || getMyChar().cTypePk != PK_PHE2) && (mob.templateId != 166 || getMyChar().cTypePk != PK_PHE2) && (mob.templateId != 200 || getMyChar().cTypePk != PK_PHE1) && (mob.templateId != 199 || getMyChar().cTypePk != PK_PHE2) && (mob.templateId != 198 || getMyChar().cTypePk != PK_PHE3) && (mob.templateId != 202 || mob.status != 8 || mob.isPaint()) && (!GameScr.isUseitemAuto || mob.levelBoss != 3) && num2 <= mob.x && mob.x <= num3 && cmy <= mob.y && mob.y <= num4 && mob.status != 0 && mob.status != 1 && (mobFocus == null || num13 < array[0]))
					{
						mobFocus = mob;
						array[0] = num13;
					}
				}
			}
			else
			{
				if (mobFocus.status != 1 && mobFocus.status != 0 && num2 <= mobFocus.x && mobFocus.x <= num3 && cmy <= mobFocus.y && mobFocus.y <= num4)
				{
					clearFocus(0);
					return;
				}
				mobFocus = null;
				for (int l = 0; l < GameScr.vMob.size(); l++)
				{
					Mob mob2 = (Mob)GameScr.vMob.elementAt(l);
					int num14 = Math.abs(getMyChar().cx - mob2.x);
					int num15 = Math.abs(getMyChar().cy - mob2.y);
					int num16 = ((num14 <= num15) ? num15 : num14);
					if ((mob2.templateId != 97 || getMyChar().cTypePk != PK_PHE1) && (mob2.templateId != 96 || getMyChar().cTypePk != PK_PHE2) && (mob2.templateId != 98 || getMyChar().cTypePk != PK_PHE1) && (mob2.templateId != 167 || getMyChar().cTypePk != PK_PHE1) && (mob2.templateId != 99 || getMyChar().cTypePk != PK_PHE2) && (mob2.templateId != 166 || getMyChar().cTypePk != PK_PHE2) && (mob2.templateId != 200 || getMyChar().cTypePk != PK_PHE1) && (mob2.templateId != 199 || getMyChar().cTypePk != PK_PHE2) && (mob2.templateId != 198 || getMyChar().cTypePk != PK_PHE3) && (mob2.templateId != 202 || mob2.status != 8 || mob2.isPaint()) && (!GameScr.isUseitemAuto || mob2.levelBoss != 3) && num2 <= mob2.x && mob2.x <= num3 && cmy <= mob2.y && mob2.y <= num4 && mob2.status != 0 && mob2.status != 1 && (mobFocus == null || num16 < array[0]))
					{
						mobFocus = mob2;
						array[0] = num16;
					}
				}
			}
			num2 = getMyChar().cx - 80;
			num3 = getMyChar().cx + 80;
			cmy = getMyChar().cy - 30;
			num4 = getMyChar().cy + 30;
			if (npcFocus != null && npcFocus.template.npcTemplateId == 13)
			{
				num2 = getMyChar().cx - 20;
				num3 = getMyChar().cx + 20;
				cmy = getMyChar().cy - 10;
				num4 = getMyChar().cy + 10;
			}
			if (npcFocus == null)
			{
				for (int m = 0; m < GameScr.vNpc.size(); m++)
				{
					Npc npc = (Npc)GameScr.vNpc.elementAt(m);
					if (npc.statusMe == 15)
					{
						continue;
					}
					int num17 = Math.abs(getMyChar().cx - npc.cx);
					int num18 = Math.abs(getMyChar().cy - npc.cy);
					int num19 = ((num17 <= num18) ? num18 : num17);
					num2 = getMyChar().cx - 80;
					num3 = getMyChar().cx + 80;
					cmy = getMyChar().cy - 30;
					num4 = getMyChar().cy + 30;
					if (npc.template.npcTemplateId == 13)
					{
						num2 = getMyChar().cx - 20;
						num3 = getMyChar().cx + 20;
						cmy = getMyChar().cy - 10;
						num4 = getMyChar().cy + 10;
					}
					if (num2 <= npc.cx && npc.cx <= num3 && cmy <= npc.cy && npc.cy <= num4 && (npcFocus == null || num19 < array[1]))
					{
						if (GameScr.isUseitemAuto && GameScr.auto == 1)
						{
							break;
						}
						npcFocus = npc;
						array[1] = num19;
					}
				}
			}
			else
			{
				if (num2 <= npcFocus.cx && npcFocus.cx <= num3 && cmy <= npcFocus.cy && npcFocus.cy <= num4)
				{
					clearFocus(1);
					return;
				}
				deFocusNPC();
				for (int n = 0; n < GameScr.vNpc.size(); n++)
				{
					Npc npc2 = (Npc)GameScr.vNpc.elementAt(n);
					if (npc2.statusMe == 15)
					{
						continue;
					}
					int num20 = Math.abs(getMyChar().cx - npc2.cx);
					int num21 = Math.abs(getMyChar().cy - npc2.cy);
					int num22 = ((num20 <= num21) ? num21 : num20);
					num2 = getMyChar().cx - 80;
					num3 = getMyChar().cx + 80;
					cmy = getMyChar().cy - 30;
					num4 = getMyChar().cy + 30;
					if (npc2.template.npcTemplateId == 13)
					{
						num2 = getMyChar().cx - 20;
						num3 = getMyChar().cx + 20;
						cmy = getMyChar().cy - 10;
						num4 = getMyChar().cy + 10;
					}
					if (num2 <= npc2.cx && npc2.cx <= num3 && cmy <= npc2.cy && npc2.cy <= num4 && (npcFocus == null || num22 < array[1]))
					{
						if (GameScr.isUseitemAuto && GameScr.auto == 1)
						{
							break;
						}
						npcFocus = npc2;
						array[1] = num22;
					}
				}
			}
			num2 = getMyChar().cx - 40;
			num3 = getMyChar().cx + 40;
			cmy = getMyChar().cy - 30;
			num4 = getMyChar().cy + 30;
			if (charFocus == null)
			{
				for (int num23 = 0; num23 < GameScr.vCharInMap.size(); num23++)
				{
					Char @char = (Char)GameScr.vCharInMap.elementAt(num23);
					if (@char.isNhanbanz())
					{
						continue;
					}
					if (TileMap.mapID != 111)
					{
						if (@char.statusMe == 15 || @char.isInvisible || @char.cTypePk == myChar.cTypePk || wdx != 0 || wdy != 0 || @char.statusMe == 14 || @char.statusMe == 5)
						{
							continue;
						}
					}
					else
					{
						if (@char.statusMe == 15 || @char.isInvisible || wdx != 0 || wdy != 0)
						{
							continue;
						}
						if (myChar.nClass.classId == 6)
						{
							if (myChar.cTypePk == @char.cTypePk)
							{
								if (@char.statusMe != 14 || @char.statusMe != 5)
								{
									continue;
								}
							}
							else if (@char.statusMe == 14 || @char.statusMe == 5)
							{
								continue;
							}
						}
						else if (myChar.cTypePk == @char.cTypePk || @char.statusMe == 14 || @char.statusMe == 5)
						{
							continue;
						}
					}
					int num24 = Math.abs(getMyChar().cx - @char.cx);
					int num25 = Math.abs(getMyChar().cy - @char.cy);
					int num26 = ((num24 <= num25) ? num25 : num24);
					if (num2 <= @char.cx && @char.cx <= num3 && cmy <= @char.cy && @char.cy <= num4 && (charFocus == null || num26 < array[2]))
					{
						charFocus = @char;
						array[2] = num26;
					}
				}
			}
			else
			{
				if (num2 <= charFocus.cx && charFocus.cx <= num3 && cmy <= charFocus.cy && charFocus.cy <= num4 && charFocus.statusMe != 15 && !charFocus.isInvisible && charFocus.statusMe != 14 && charFocus.statusMe != 5)
				{
					clearFocus(2);
					return;
				}
				charFocus = null;
				for (int num27 = 0; num27 < GameScr.vCharInMap.size(); num27++)
				{
					Char char2 = (Char)GameScr.vCharInMap.elementAt(num27);
					if (char2.isNhanbanz())
					{
						continue;
					}
					if (TileMap.mapID != 111)
					{
						if (char2.statusMe == 15 || char2.isInvisible || char2.cTypePk == myChar.cTypePk || wdx != 0 || wdy != 0 || char2.statusMe == 14 || char2.statusMe == 5)
						{
							continue;
						}
					}
					else
					{
						if (char2.statusMe == 15 || char2.isInvisible || wdx != 0 || wdy != 0)
						{
							continue;
						}
						if (myChar.nClass.classId == 6)
						{
							if (myChar.cTypePk == char2.cTypePk)
							{
								if (char2.statusMe != 14 || char2.statusMe != 5)
								{
									continue;
								}
							}
							else if (char2.statusMe == 14 || char2.statusMe == 5)
							{
								continue;
							}
						}
						else if (myChar.cTypePk == char2.cTypePk || char2.statusMe == 14 || char2.statusMe == 5)
						{
							continue;
						}
					}
					int num28 = Math.abs(getMyChar().cx - char2.cx);
					int num29 = Math.abs(getMyChar().cy - char2.cy);
					int num30 = ((num28 <= num29) ? num29 : num28);
					if (num2 <= char2.cx && char2.cx <= num3 && cmy <= char2.cy && char2.cy <= num4 && (charFocus == null || num30 < array[2]))
					{
						charFocus = char2;
						array[2] = num30;
					}
				}
			}
			int num31 = -1;
			for (int num32 = 0; num32 < array.Length; num32++)
			{
				if (num31 == -1)
				{
					if (array[num32] != -1)
					{
						num31 = num32;
					}
				}
				else if (array[num32] < array[num31] && array[num32] != -1)
				{
					num31 = num32;
				}
			}
			clearFocus(num31);
			return;
		}
		num2 = getMyChar().cx - getMyChar().getdxSkill() - 10;
		num3 = getMyChar().cx + getMyChar().getdxSkill() + 10;
		cmy = getMyChar().cy - getMyChar().getdySkill() - num;
		num4 = getMyChar().cy + getMyChar().getdySkill();
		if (num4 > getMyChar().cy + 30)
		{
			num4 = getMyChar().cy + 30;
		}
		if (mobFocus == null)
		{
			for (int num33 = 0; num33 < GameScr.vMob.size(); num33++)
			{
				Mob mob3 = (Mob)GameScr.vMob.elementAt(num33);
				int num34 = Math.abs(getMyChar().cx - mob3.x);
				int num35 = Math.abs(getMyChar().cy - mob3.y);
				int num36 = ((num34 <= num35) ? num35 : num34);
				if ((mob3.templateId != 97 || getMyChar().cTypePk != PK_PHE1) && (mob3.templateId != 98 || getMyChar().cTypePk != PK_PHE1) && (mob3.templateId != 167 || getMyChar().cTypePk != PK_PHE1) && (mob3.templateId != 99 || getMyChar().cTypePk != PK_PHE2) && (mob3.templateId != 96 || getMyChar().cTypePk != PK_PHE2) && (mob3.templateId != 166 || getMyChar().cTypePk != PK_PHE2) && (mob3.templateId != 200 || getMyChar().cTypePk != PK_PHE1) && (mob3.templateId != 199 || getMyChar().cTypePk != PK_PHE2) && (mob3.templateId != 198 || getMyChar().cTypePk != PK_PHE3) && (mob3.templateId != 202 || mob3.status != 8 || mob3.isPaint()) && (!GameScr.isUseitemAuto || mob3.levelBoss != 3) && mob3.templateId != 202 && num2 <= mob3.x && mob3.x <= num3 && cmy <= mob3.y && mob3.y <= num4 && mob3.status != 0 && mob3.status != 1 && (mobFocus == null || num36 < array[0]))
				{
					mobFocus = mob3;
					array[0] = num36;
				}
			}
		}
		else
		{
			if (mobFocus.status != 1 && mobFocus.status != 0 && num2 <= mobFocus.x && mobFocus.x <= num3 && cmy <= mobFocus.y && mobFocus.y <= num4)
			{
				clearFocus(0);
				return;
			}
			mobFocus = null;
			for (int num37 = 0; num37 < GameScr.vMob.size(); num37++)
			{
				Mob mob4 = (Mob)GameScr.vMob.elementAt(num37);
				int num38 = Math.abs(getMyChar().cx - mob4.x);
				int num39 = Math.abs(getMyChar().cy - mob4.y);
				int num40 = ((num38 <= num39) ? num39 : num38);
				if ((mob4.templateId != 97 || getMyChar().cTypePk != PK_PHE1) && (mob4.templateId != 96 || getMyChar().cTypePk != PK_PHE2) && (mob4.templateId != 98 || getMyChar().cTypePk != PK_PHE1) && (mob4.templateId != 167 || getMyChar().cTypePk != PK_PHE1) && (mob4.templateId != 99 || getMyChar().cTypePk != PK_PHE2) && (mob4.templateId != 166 || getMyChar().cTypePk != PK_PHE2) && (mob4.templateId != 96 || getMyChar().cTypePk != PK_PHE3) && (mob4.templateId != 99 || getMyChar().cTypePk != PK_PHE3) && (mob4.templateId != 166 || getMyChar().cTypePk != PK_PHE3) && (mob4.templateId != 202 || mob4.status != 8 || mob4.isPaint()) && (!GameScr.isUseitemAuto || mob4.levelBoss != 3) && mob4.templateId != 202 && (!GameScr.isUseitemAuto || mob4.levelBoss != 3) && mob4.templateId != 202 && num2 <= mob4.x && mob4.x <= num3 && cmy <= mob4.y && mob4.y <= num4 && mob4.status != 0 && mob4.status != 1 && (mobFocus == null || num40 < array[0]))
				{
					mobFocus = mob4;
					array[0] = num40;
				}
			}
		}
		num2 = getMyChar().cx - 80;
		num3 = getMyChar().cx + 80;
		cmy = getMyChar().cy - 30;
		num4 = getMyChar().cy + 30;
		if (npcFocus != null && npcFocus.template.npcTemplateId == 13)
		{
			num2 = getMyChar().cx - 20;
			num3 = getMyChar().cx + 20;
			cmy = getMyChar().cy - 10;
			num4 = getMyChar().cy + 10;
		}
		if (npcFocus == null)
		{
			for (int num41 = 0; num41 < GameScr.vNpc.size(); num41++)
			{
				Npc npc3 = (Npc)GameScr.vNpc.elementAt(num41);
				if (npc3.statusMe == 15 || TileMap.typeMap == TileMap.MAP_DAUTRUONG)
				{
					continue;
				}
				int num42 = Math.abs(getMyChar().cx - npc3.cx);
				int num43 = Math.abs(getMyChar().cy - npc3.cy);
				int num44 = ((num42 <= num43) ? num43 : num42);
				num2 = getMyChar().cx - 80;
				num3 = getMyChar().cx + 80;
				cmy = getMyChar().cy - 30;
				num4 = getMyChar().cy + 30;
				if (npc3.template.npcTemplateId == 13)
				{
					num2 = getMyChar().cx - 20;
					num3 = getMyChar().cx + 20;
					cmy = getMyChar().cy - 10;
					num4 = getMyChar().cy + 10;
				}
				if (num2 <= npc3.cx && npc3.cx <= num3 && cmy <= npc3.cy && npc3.cy <= num4 && (npcFocus == null || num44 < array[1]))
				{
					if (GameScr.isUseitemAuto && GameScr.auto == 1)
					{
						break;
					}
					npcFocus = npc3;
					array[1] = num44;
				}
			}
		}
		else
		{
			if (num2 <= npcFocus.cx && npcFocus.cx <= num3 && cmy <= npcFocus.cy && npcFocus.cy <= num4)
			{
				clearFocus(1);
				return;
			}
			deFocusNPC();
			for (int num45 = 0; num45 < GameScr.vNpc.size(); num45++)
			{
				Npc npc4 = (Npc)GameScr.vNpc.elementAt(num45);
				if (npc4.statusMe == 15 || TileMap.typeMap == TileMap.MAP_DAUTRUONG)
				{
					continue;
				}
				int num46 = Math.abs(getMyChar().cx - npc4.cx);
				int num47 = Math.abs(getMyChar().cy - npc4.cy);
				int num48 = ((num46 <= num47) ? num47 : num46);
				num2 = getMyChar().cx - 80;
				num3 = getMyChar().cx + 80;
				cmy = getMyChar().cy - 30;
				num4 = getMyChar().cy + 30;
				if (npc4.template.npcTemplateId == 13)
				{
					num2 = getMyChar().cx - 20;
					num3 = getMyChar().cx + 20;
					cmy = getMyChar().cy - 10;
					num4 = getMyChar().cy + 10;
				}
				if (num2 <= npc4.cx && npc4.cx <= num3 && cmy <= npc4.cy && npc4.cy <= num4 && (npcFocus == null || num48 < array[1]))
				{
					if (GameScr.isUseitemAuto && GameScr.auto == 1)
					{
						break;
					}
					npcFocus = npc4;
					array[1] = num48;
				}
			}
		}
		if (charFocus == null)
		{
			for (int num49 = 0; num49 < GameScr.vCharInMap.size(); num49++)
			{
				Char char3 = (Char)GameScr.vCharInMap.elementAt(num49);
				if (!char3.isNhanbanz() && char3.statusMe != 15 && !char3.isInvisible && char3.charID < -1 && wdx == 0 && wdy == 0 && char3.statusMe != 14 && char3.statusMe != 5)
				{
					int num50 = Math.abs(getMyChar().cx - char3.cx);
					int num51 = Math.abs(getMyChar().cy - char3.cy);
					int num52 = ((num50 <= num51) ? num51 : num50);
					if (num2 <= char3.cx && char3.cx <= num3 && cmy <= char3.cy && char3.cy <= num4 && (charFocus == null || num52 < array[2]))
					{
						charFocus = char3;
						array[2] = num52;
					}
				}
			}
		}
		else
		{
			if (num2 <= charFocus.cx && charFocus.cx <= num3 && cmy <= charFocus.cy && charFocus.cy <= num4 && charFocus.statusMe != 15 && !charFocus.isInvisible)
			{
				clearFocus(2);
				return;
			}
			charFocus = null;
			for (int num53 = 0; num53 < GameScr.vCharInMap.size(); num53++)
			{
				Char char4 = (Char)GameScr.vCharInMap.elementAt(num53);
				if (!char4.isNhanbanz() && char4.statusMe != 15 && !char4.isInvisible && char4.charID < 0 && wdx == 0 && wdy == 0 && char4.statusMe != 14 && char4.statusMe != 5)
				{
					int num54 = Math.abs(getMyChar().cx - char4.cx);
					int num55 = Math.abs(getMyChar().cy - char4.cy);
					int num56 = ((num54 <= num55) ? num55 : num54);
					if (num2 <= char4.cx && char4.cx <= num3 && cmy <= char4.cy && char4.cy <= num4 && (charFocus == null || num56 < array[2]))
					{
						charFocus = char4;
						array[2] = num56;
					}
				}
			}
		}
		int num57 = -1;
		for (int num58 = 0; num58 < array.Length; num58++)
		{
			if (num57 == -1)
			{
				if (array[num58] != -1)
				{
					num57 = num58;
				}
			}
			else if (array[num58] < array[num57] && array[num58] != -1)
			{
				num57 = num58;
			}
		}
		if (GameScr.isUseitemAuto && GameScr.auto == 1 && !GameScr.gI().lockAutoMove)
		{
			GameScr.updateAutoMovetoMob();
		}
		clearFocus(num57);
	}

	public void clearFocus(int index)
	{
		switch (index)
		{
		case 0:
			deFocusNPC();
			charFocus = null;
			itemFocus = null;
			break;
		case 1:
			mobFocus = null;
			charFocus = null;
			itemFocus = null;
			break;
		case 2:
			mobFocus = null;
			deFocusNPC();
			itemFocus = null;
			break;
		case 3:
			mobFocus = null;
			deFocusNPC();
			charFocus = null;
			break;
		}
	}

	public void findNextFocusByKey()
	{
		if (charFocus != null && charFocus.isNhanbanz())
		{
			charFocus = null;
		}
		if (getMyChar().skillPaint != null || getMyChar().arr != null)
		{
			return;
		}
		int num = 0;
		if (nClass.classId == 0 || nClass.classId == 1 || nClass.classId == 3 || nClass.classId == 5)
		{
			num = 40;
		}
		focus.removeAllElements();
		int num2 = 0;
		int num3 = GameScr.cmx + 10;
		int num4 = GameScr.cmx + GameCanvas.w - 10;
		int num5 = GameScr.cmy + 10;
		int num6 = GameScr.cmy + GameScr.gH;
		if (TileMap.typeMap == TileMap.MAP_CHIENTRUONG || TileMap.mapID == 111)
		{
			if (TileMap.mapID == 98 || TileMap.mapID == 104)
			{
				for (int i = 0; i < GameScr.vCharInMap.size(); i++)
				{
					Char @char = (Char)GameScr.vCharInMap.elementAt(i);
					if (!@char.isNhanbanz() && @char.statusMe != 15 && !@char.isInvisible && num3 <= @char.cx && @char.cx <= num4 && num5 <= @char.cy && @char.cy <= num6)
					{
						focus.addElement(@char);
						if (charFocus != null && @char.Equals(charFocus))
						{
							num2 = focus.size();
						}
					}
				}
			}
			else
			{
				for (int j = 0; j < GameScr.vCharInMap.size(); j++)
				{
					Char char2 = (Char)GameScr.vCharInMap.elementAt(j);
					if (char2.isNhanbanz() || char2.statusMe == 15 || char2.isInvisible || num3 > char2.cx || char2.cx > num4 || num5 > char2.cy || char2.cy > num6)
					{
						continue;
					}
					if (TileMap.mapID != 111)
					{
						if (char2.cTypePk != getMyChar().cTypePk && char2.statusMe != 14 && char2.statusMe != 5)
						{
							focus.addElement(char2);
							if (charFocus != null && char2.Equals(charFocus))
							{
								num2 = focus.size();
							}
						}
					}
					else if (myChar.cTypePk == 0)
					{
						focus.addElement(char2);
						if (charFocus != null && char2.Equals(charFocus))
						{
							num2 = focus.size();
						}
					}
					else if (myChar.nClass.classId == 6)
					{
						if (myChar.cTypePk == char2.cTypePk)
						{
							if (char2.statusMe == 14 || char2.statusMe == 5)
							{
								focus.addElement(char2);
								if (charFocus != null && char2.Equals(charFocus))
								{
									num2 = focus.size();
								}
							}
						}
						else if ((myChar.cTypePk != PK_PHE1 || char2.cTypePk == PK_PHE2 || char2.cTypePk == PK_PHE3) && (myChar.cTypePk != PK_PHE2 || char2.cTypePk == PK_PHE1 || char2.cTypePk == PK_PHE3) && (myChar.cTypePk != PK_PHE3 || char2.cTypePk == PK_PHE1 || char2.cTypePk == PK_PHE2) && char2.statusMe != 14 && char2.statusMe != 5)
						{
							focus.addElement(char2);
							if (charFocus != null && char2.Equals(charFocus))
							{
								num2 = focus.size();
							}
						}
					}
					else if ((myChar.cTypePk != PK_PHE1 || char2.cTypePk == PK_PHE2 || char2.cTypePk == PK_PHE3) && (myChar.cTypePk != PK_PHE2 || char2.cTypePk == PK_PHE1 || char2.cTypePk == PK_PHE3) && (myChar.cTypePk != PK_PHE3 || char2.cTypePk == PK_PHE1 || char2.cTypePk == PK_PHE2) && char2.statusMe != 14 && char2.statusMe != 5)
					{
						focus.addElement(char2);
						if (charFocus != null && char2.Equals(charFocus))
						{
							num2 = focus.size();
						}
					}
				}
			}
			for (int k = 0; k < GameScr.vItemMap.size(); k++)
			{
				ItemMap itemMap = (ItemMap)GameScr.vItemMap.elementAt(k);
				if (num3 <= itemMap.x && itemMap.x <= num4 && num5 <= itemMap.y && itemMap.y <= num6)
				{
					focus.addElement(itemMap);
					if (itemFocus != null && itemMap.Equals(itemFocus))
					{
						num2 = focus.size();
					}
				}
			}
			for (int l = 0; l < GameScr.vMob.size(); l++)
			{
				Mob mob = (Mob)GameScr.vMob.elementAt(l);
				if ((mob.templateId != 97 || getMyChar().cTypePk != PK_PHE1) && (mob.templateId != 98 || getMyChar().cTypePk != PK_PHE1) && (mob.templateId != 167 || getMyChar().cTypePk != PK_PHE1) && (mob.templateId != 96 || getMyChar().cTypePk != PK_PHE2) && (mob.templateId != 99 || getMyChar().cTypePk != PK_PHE2) && (mob.templateId != 166 || getMyChar().cTypePk != PK_PHE2) && (mob.templateId != 200 || getMyChar().cTypePk != PK_PHE1) && (mob.templateId != 199 || getMyChar().cTypePk != PK_PHE2) && (mob.templateId != 198 || getMyChar().cTypePk != PK_PHE3) && (mob.templateId != 202 || mob.status != 8 || mob.isPaint()) && mob.status != 1 && mob.status != 0 && num3 <= mob.x && mob.x <= num4 && num5 <= mob.y && mob.y <= num6)
				{
					focus.addElement(mob);
					if (mobFocus != null && mob.Equals(mobFocus))
					{
						num2 = focus.size();
					}
				}
			}
			for (int m = 0; m < GameScr.vNpc.size(); m++)
			{
				Npc npc = (Npc)GameScr.vNpc.elementAt(m);
				if (npc.statusMe != 15 && num3 <= npc.cx && npc.cx <= num4 && num5 <= npc.cy && npc.cy <= num6)
				{
					focus.addElement(npc);
					if (npcFocus != null && npc.Equals(npcFocus))
					{
						num2 = focus.size();
					}
				}
			}
			if (focus.size() > 0)
			{
				if (num2 >= focus.size())
				{
					num2 = 0;
				}
				if (focus.elementAt(num2) is Char)
				{
					mobFocus = null;
					deFocusNPC();
					charFocus = (Char)focus.elementAt(num2);
					itemFocus = null;
					isManualFocus = true;
				}
				else if (focus.elementAt(num2) is Npc)
				{
					mobFocus = null;
					deFocusNPC();
					npcFocus = (Npc)focus.elementAt(num2);
					charFocus = null;
					itemFocus = null;
					isManualFocus = true;
				}
				else if (focus.elementAt(num2) is Mob)
				{
					mobFocus = (Mob)focus.elementAt(num2);
					deFocusNPC();
					charFocus = null;
					itemFocus = null;
					isManualFocus = true;
				}
				else if (focus.elementAt(num2) is ItemMap)
				{
					mobFocus = null;
					deFocusNPC();
					charFocus = null;
					itemFocus = (ItemMap)focus.elementAt(num2);
					isManualFocus = true;
				}
			}
			else
			{
				mobFocus = null;
				deFocusNPC();
				charFocus = null;
				itemFocus = null;
				isManualFocus = false;
			}
			return;
		}
		for (int n = 0; n < GameScr.vItemMap.size(); n++)
		{
			ItemMap itemMap2 = (ItemMap)GameScr.vItemMap.elementAt(n);
			if (num3 <= itemMap2.x && itemMap2.x <= num4 && num5 <= itemMap2.y && itemMap2.y <= num6)
			{
				focus.addElement(itemMap2);
				if (itemFocus != null && itemMap2.Equals(itemFocus))
				{
					num2 = focus.size();
				}
			}
		}
		for (int num7 = 0; num7 < GameScr.vMob.size(); num7++)
		{
			Mob mob2 = (Mob)GameScr.vMob.elementAt(num7);
			if ((mob2.templateId != 97 || getMyChar().cTypePk != PK_PHE1) && (mob2.templateId != 96 || getMyChar().cTypePk != PK_PHE2) && (mob2.templateId != 98 || getMyChar().cTypePk != PK_PHE1) && (mob2.templateId != 167 || getMyChar().cTypePk != PK_PHE1) && (mob2.templateId != 99 || getMyChar().cTypePk != PK_PHE2) && (mob2.templateId != 166 || getMyChar().cTypePk != PK_PHE2) && (mob2.templateId != 200 || getMyChar().cTypePk != PK_PHE1) && (mob2.templateId != 199 || getMyChar().cTypePk != PK_PHE2) && (mob2.templateId != 198 || getMyChar().cTypePk != PK_PHE3) && (mob2.templateId != 202 || mob2.status != 8 || mob2.isPaint()) && mob2.status != 1 && mob2.status != 0 && num3 <= mob2.x && mob2.x <= num4 && num5 <= mob2.y && mob2.y <= num6)
			{
				focus.addElement(mob2);
				if (mobFocus != null && mob2.Equals(mobFocus))
				{
					num2 = focus.size();
				}
			}
		}
		for (int num8 = 0; num8 < GameScr.vNpc.size(); num8++)
		{
			Npc npc2 = (Npc)GameScr.vNpc.elementAt(num8);
			if (npc2.statusMe != 15 && num3 <= npc2.cx && npc2.cx <= num4 && num5 <= npc2.cy && npc2.cy <= num6)
			{
				focus.addElement(npc2);
				if (npcFocus != null && npc2.Equals(npcFocus))
				{
					num2 = focus.size();
				}
			}
		}
		for (int num9 = 0; num9 < GameScr.vCharInMap.size(); num9++)
		{
			Char char3 = (Char)GameScr.vCharInMap.elementAt(num9);
			if (!char3.isNhanbanz() && char3.statusMe != 15 && !char3.isInvisible && num3 <= char3.cx && char3.cx <= num4 && num5 <= char3.cy && char3.cy <= num6)
			{
				focus.addElement(char3);
				if (charFocus != null && char3.Equals(charFocus))
				{
					num2 = focus.size();
				}
			}
		}
		if (focus.size() > 0)
		{
			if (num2 >= focus.size())
			{
				num2 = 0;
			}
			if (focus.elementAt(num2) is Mob)
			{
				mobFocus = (Mob)focus.elementAt(num2);
				deFocusNPC();
				charFocus = null;
				itemFocus = null;
				isManualFocus = true;
			}
			else if (focus.elementAt(num2) is Npc)
			{
				mobFocus = null;
				deFocusNPC();
				npcFocus = (Npc)focus.elementAt(num2);
				charFocus = null;
				itemFocus = null;
				isManualFocus = true;
			}
			else if (focus.elementAt(num2) is Char)
			{
				mobFocus = null;
				deFocusNPC();
				charFocus = (Char)focus.elementAt(num2);
				itemFocus = null;
				isManualFocus = true;
			}
			else if (focus.elementAt(num2) is ItemMap)
			{
				mobFocus = null;
				deFocusNPC();
				charFocus = null;
				itemFocus = (ItemMap)focus.elementAt(num2);
				isManualFocus = true;
			}
		}
		else
		{
			mobFocus = null;
			deFocusNPC();
			charFocus = null;
			itemFocus = null;
			isManualFocus = false;
		}
	}

	public void deFocusNPC()
	{
		if (me && npcFocus != null)
		{
			npcFocus.chatPopup = null;
			npcFocus = null;
		}
	}

	public void updateCharInBridge()
	{
		if (!GameCanvas.lowGraphic && !Main.isIpod && mGraphics.zoomLevel != 1)
		{
			if (TileMap.tileTypeAt(cx, cy + 1, TileMap.T_BRIDGE))
			{
				TileMap.setTileTypeAtPixel(cx, cy + 1, TileMap.T_DOWN1PIXEL);
				TileMap.setTileTypeAtPixel(cx, cy - 2, TileMap.T_DOWN1PIXEL);
			}
			if (TileMap.tileTypeAt(cx - TileMap.size, cy + 1, TileMap.T_DOWN1PIXEL))
			{
				TileMap.killTileTypeAt(cx - TileMap.size, cy + 1, TileMap.T_DOWN1PIXEL);
				TileMap.killTileTypeAt(cx - TileMap.size, cy - 2, TileMap.T_DOWN1PIXEL);
			}
			if (TileMap.tileTypeAt(cx + TileMap.size, cy + 1, TileMap.T_DOWN1PIXEL))
			{
				TileMap.killTileTypeAt(cx + TileMap.size, cy + 1, TileMap.T_DOWN1PIXEL);
				TileMap.killTileTypeAt(cx + TileMap.size, cy - 2, TileMap.T_DOWN1PIXEL);
			}
		}
	}

	public static void sort(int[] data)
	{
		int num = 5;
		for (int i = 0; i < num - 1; i++)
		{
			for (int j = i + 1; j < num; j++)
			{
				if (data[i] < data[j])
				{
					int num2 = data[j];
					data[j] = data[i];
					data[i] = num2;
				}
			}
		}
	}

	public static bool setInsc(int cmX, int cmWx, int x, int cmy, int cmyH, int y)
	{
		if (x > cmWx || x < cmX || y > cmyH || y < cmy)
		{
			return false;
		}
		return true;
	}

	public void itemMonToBag(Message msg)
	{
		try
		{
			readParam(msg, "itemMonToBag");
			getMyChar().eff5BuffHp = msg.reader().readShort();
			getMyChar().eff5BuffMp = msg.reader().readShort();
			int num = msg.reader().readUnsignedByte();
			Item item = arrItemMounts[num];
			item.typeUI = 3;
			arrItemMounts[num] = null;
			item.indexUI = msg.reader().readUnsignedByte();
			arrItemBag[item.indexUI] = item;
			if (num == 4)
			{
				isNewMount = (isWolf = (isMoto = (isMotoBehind = false)));
			}
			GameScr.isPaintItemInfo = false;
			GameScr.gI().setLCR();
		}
		catch (Exception)
		{
		}
	}

	public void itemBodyToBag(Message msg)
	{
		try
		{
			readParam(msg, "itemBodyToBag");
			getMyChar().eff5BuffHp = msg.reader().readShort();
			getMyChar().eff5BuffMp = msg.reader().readShort();
			Item item = arrItemBody[msg.reader().readUnsignedByte()];
			item.typeUI = 3;
			if (item.indexUI == 1)
			{
				setDefaultWeapon();
			}
			else if (item.indexUI == 2)
			{
				setDefaultBody();
			}
			else if (item.indexUI == 6)
			{
				setDefaultLeg();
			}
			arrItemBody[item.indexUI] = null;
			item.indexUI = msg.reader().readUnsignedByte();
			getMyChar().head = msg.reader().readShort();
			arrItemBag[item.indexUI] = item;
			GameScr.gI().left = (GameScr.gI().center = null);
			GameScr.gI().setLCR();
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
			Out.println("Char.itemBodyToBag()");
		}
	}

	public void itemBagToBox(Message msg)
	{
		try
		{
			int num = msg.reader().readUnsignedByte();
			int num2 = msg.reader().readUnsignedByte();
			Item item = arrItemBag[num];
			if (item != null)
			{
				if (item.template.type == 16)
				{
					GameScr.hpPotion -= item.quantity;
				}
				if (item.template.type == 17)
				{
					GameScr.mpPotion -= item.quantity;
				}
				arrItemBag[num] = null;
				if (arrItemBox[num2] == null)
				{
					item.indexUI = num2;
					item.typeUI = 4;
					arrItemBox[num2] = item;
				}
				else
				{
					arrItemBox[num2].quantity += item.quantity;
				}
			}
			GameScr.gI().left = (GameScr.gI().center = null);
			GameScr.gI().updateKeyBuyItemUI();
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
			Out.println("Char.itemBagToBox()");
		}
	}

	public void itemBoxToBag(Message msg)
	{
		try
		{
			int num = msg.reader().readUnsignedByte();
			int num2 = msg.reader().readUnsignedByte();
			Item item = arrItemBox[num];
			if (item != null)
			{
				if (item.template.type == 16)
				{
					GameScr.hpPotion += item.quantity;
				}
				if (item.template.type == 17)
				{
					GameScr.mpPotion += item.quantity;
				}
				arrItemBox[num] = null;
				if (arrItemBag[num2] == null)
				{
					item.indexUI = num2;
					item.typeUI = 3;
					arrItemBag[num2] = item;
				}
				else
				{
					arrItemBag[num2].quantity += item.quantity;
				}
			}
			GameScr.gI().left = (GameScr.gI().center = null);
			GameScr.gI().updateKeyBuyItemUI();
		}
		catch (Exception ex)
		{
			Out.println(ex.Message + ex.StackTrace);
			Out.println("Char.itemBoxToBag()");
		}
	}

	public void crystalCollect(Message msg, bool isCoin)
	{
		try
		{
			for (int i = 0; i < GameScr.arrItemUpPeal.Length; i++)
			{
				GameScr.arrItemUpPeal[i] = null;
			}
			int num = msg.reader().readByte();
			Item item = new Item();
			item.typeUI = 3;
			item.indexUI = msg.reader().readByte();
			item.template = ItemTemplates.get(msg.reader().readShort());
			item.isLock = msg.reader().readBoolean();
			item.isExpires = msg.reader().readBoolean();
			item.quantity = 1;
			if (isCoin)
			{
				getMyChar().xu = msg.reader().readInt();
			}
			else
			{
				getMyChar().yen = msg.reader().readInt();
				try
				{
					getMyChar().xu = msg.reader().readInt();
				}
				catch (Exception)
				{
				}
			}
			GameScr.arrItemUpPeal[0] = item;
			GameScr.effUpok = GameScr.efs[53];
			GameScr.indexEff = 0;
			GameScr.gI().left = (GameScr.gI().center = null);
			GameScr.gI().updateCommandForUI();
			GameCanvas.endDlg();
			if (num == 1)
			{
				InfoMe.addInfo(mResources.UPGRADE_SUCCESS + " " + item.template.name);
				return;
			}
			InfoMe.addInfo(mResources.UPGRADE + " " + ItemTemplates.get((short)(item.template.id + 1)).name + " " + mResources.UPGRADE_FAIL + " " + item.template.name, 25, mFont.tahoma_7_red);
		}
		catch (Exception ex2)
		{
			Out.println(ex2.Message + ex2.StackTrace);
			Out.println("Char.itemBagToBox()");
		}
	}

	public void kickOption(Item item, int maxKick)
	{
		int num = 0;
		if (item == null || item.options == null)
		{
			return;
		}
		for (int i = 0; i < item.options.size(); i++)
		{
			ItemOption itemOption = (ItemOption)item.options.elementAt(i);
			itemOption.active = 0;
			if (itemOption.optionTemplate.type == 2)
			{
				if (num < maxKick)
				{
					itemOption.active = 1;
					num++;
				}
			}
			else if (itemOption.optionTemplate.type == 3 && item.upgrade >= 4)
			{
				itemOption.active = 1;
			}
			else if (itemOption.optionTemplate.type == 4 && item.upgrade >= 8)
			{
				itemOption.active = 1;
			}
			else if (itemOption.optionTemplate.type == 5 && item.upgrade >= 12)
			{
				itemOption.active = 1;
			}
			else if (itemOption.optionTemplate.type == 6 && item.upgrade >= 14)
			{
				itemOption.active = 1;
			}
			else if (itemOption.optionTemplate.type == 7 && item.upgrade >= 16)
			{
				itemOption.active = 1;
			}
		}
	}

	public void updateKickOption()
	{
		int num = 2;
		int num2 = 2;
		int num3 = 2;
		if (arrItemBody[0] == null)
		{
			num--;
		}
		if (arrItemBody[6] == null)
		{
			num--;
		}
		if (arrItemBody[5] == null)
		{
			num--;
		}
		kickOption(arrItemBody[0], num);
		kickOption(arrItemBody[6], num);
		kickOption(arrItemBody[5], num);
		if (arrItemBody[2] == null)
		{
			num2--;
		}
		if (arrItemBody[8] == null)
		{
			num2--;
		}
		if (arrItemBody[7] == null)
		{
			num2--;
		}
		kickOption(arrItemBody[2], num2);
		kickOption(arrItemBody[8], num2);
		kickOption(arrItemBody[7], num2);
		if (arrItemBody[4] == null)
		{
			num3--;
		}
		if (arrItemBody[3] == null)
		{
			num3--;
		}
		if (arrItemBody[9] == null)
		{
			num3--;
		}
		if (arrItemBody[1] != null)
		{
			if (arrItemBody[1].sys == getSys())
			{
				if (arrItemBody[1].options != null)
				{
					for (int i = 0; i < arrItemBody[1].options.size(); i++)
					{
						ItemOption itemOption = (ItemOption)arrItemBody[1].options.elementAt(i);
						if (itemOption.optionTemplate.type == 2)
						{
							itemOption.active = 1;
						}
					}
				}
			}
			else if (arrItemBody[1].options != null)
			{
				for (int j = 0; j < arrItemBody[1].options.size(); j++)
				{
					ItemOption itemOption2 = (ItemOption)arrItemBody[1].options.elementAt(j);
					if (itemOption2.optionTemplate.type == 2)
					{
						itemOption2.active = 0;
					}
				}
			}
		}
		kickOption(arrItemBody[4], num3);
		kickOption(arrItemBody[3], num3);
		kickOption(arrItemBody[9], num3);
	}

	public void doInjure(int HPShow, int MPShow, bool isBoss, int idBoss)
	{
		cHP -= HPShow;
		cMP -= MPShow;
		if (!me)
		{
			cHP = cHpNew;
		}
		if (cHP < 0)
		{
			cHP = 0;
		}
		if (cHP < 1 && statusMe != 14 && statusMe != 5)
		{
			cHP = 1;
		}
		if (HPShow <= 0)
		{
			if (me)
			{
				GameScr.startFlyText(string.Empty, cx, cy - ch, 0, -2, mFont.MISS_ME);
			}
			else
			{
				GameScr.startFlyText(string.Empty, cx, cy - ch, 0, -2, mFont.MISS);
			}
		}
		else
		{
			GameScr.startFlyText("-" + HPShow, cx, cy - ch, 0, -2, mFont.RED);
		}
		if (HPShow > 0)
		{
			isInjure = 4;
		}
		if (isBoss)
		{
			switch (idBoss)
			{
			case 114:
				ServerEffect.addServerEffect(32, cx, cy - chh, 1);
				break;
			case 115:
				ServerEffect.addServerEffect(85, cx, cy, 1);
				break;
			case 139:
				GameScr.shaking = 1;
				GameScr.count = 0;
				ServerEffect.addServerEffect(91, this, 2);
				break;
			case 144:
				ServerEffect.addServerEffect(91, this, 1);
				break;
			}
		}
		else
		{
			callEff(49);
		}
	}

	public void doInjure()
	{
		isInjure = 4;
		callEff(49);
	}

	public void startDie(short toX, short toY)
	{
		if (me)
		{
			isLockKey = true;
			for (int i = 0; i < GameScr.vCharInMap.size(); i++)
			{
				Char @char = (Char)GameScr.vCharInMap.elementAt(i);
				@char.killCharId = -9999;
			}
		}
		statusMe = 5;
		cp2 = toX;
		cp3 = toY;
		cp1 = 0;
		cHP = 0;
		testCharId = -9999;
		killCharId = -9999;
	}

	public void waitToDie(short toX, short toY)
	{
		wdx = toX;
		wdy = toY;
	}

	public void changeStatusStand()
	{
		timeBocdau = 0;
		statusMe = 1;
		timeSummon = mSystem.currentTimeMillis();
	}

	public void liveFromDead()
	{
		cHP = cMaxHP;
		cMP = cMaxMP;
		changeStatusStand();
		cp1 = (cp2 = (cp3 = 0));
		ServerEffect.addServerEffect(20, this, 2);
		GameScr.gI().center = null;
	}

	public bool doUsePotion(int type)
	{
		if (arrItemBag == null)
		{
			return false;
		}
		for (int i = 0; i < arrItemBag.Length; i++)
		{
			if (arrItemBag[i] != null && arrItemBag[i].template.type == type && arrItemBag[i].template.level <= myChar.clevel)
			{
				Service.gI().useItem(i);
				return true;
			}
		}
		return false;
	}

	public bool isLang()
	{
		if (TileMap.mapID == 1 || TileMap.mapID == 27 || TileMap.mapID == 72 || TileMap.mapID == 10 || TileMap.mapID == 17 || TileMap.mapID == 22 || TileMap.mapID == 32 || TileMap.mapID == 38 || TileMap.mapID == 43 || TileMap.mapID == 48)
		{
			return true;
		}
		return false;
	}

	public bool isMeCanAttackOtherPlayer(Char cAtt)
	{
		if (cAtt != null && cAtt.isNhanbanz())
		{
			return false;
		}
		if (cAtt == null || getMyChar().myskill == null || getMyChar().myskill.template.type == 2 || getMyChar().myskill.template.type == 3 || (getMyChar().myskill.template.type == 4 && cAtt.statusMe != 14 && cAtt.statusMe != 5))
		{
			return false;
		}
		return ((((getMyChar().cTypePk == PK_PHE3 && (cAtt.cTypePk == PK_PHE1 || cAtt.cTypePk == PK_PHE2)) || (getMyChar().cTypePk == PK_PHE1 && (cAtt.cTypePk == PK_PHE2 || cAtt.cTypePk == PK_PHE3)) || (getMyChar().cTypePk == PK_PHE2 && (cAtt.cTypePk == PK_PHE1 || cAtt.cTypePk == PK_PHE3))) && !getMyChar().isTeam(cAtt) && !isLang()) || (cAtt.cTypePk == 3 && !getMyChar().isTeam(cAtt) && !isLang()) || (getMyChar().cTypePk == 3 && !getMyChar().isTeam(cAtt) && !isLang()) || (getMyChar().cTypePk == PK_NHOM && cAtt.cTypePk == PK_NHOM && !getMyChar().isTeam(cAtt) && !isLang()) || (getMyChar().testCharId >= 0 && getMyChar().testCharId == cAtt.charID) || (getMyChar().killCharId >= 0 && getMyChar().killCharId == cAtt.charID && !isLang()) || (cAtt.killCharId >= 0 && cAtt.killCharId == getMyChar().charID && !isLang())) && cAtt.statusMe != 14 && cAtt.statusMe != 5;
	}

	public bool isTeam(Char c)
	{
		for (int i = 0; i < GameScr.vParty.size(); i++)
		{
			Party party = (Party)GameScr.vParty.elementAt(i);
			if (c.charID == party.charId)
			{
				return true;
			}
		}
		return false;
	}

	public void clearTask()
	{
		getMyChar().callEffTask(21);
		getMyChar().taskMaint = null;
		for (int i = 0; i < getMyChar().arrItemBag.Length; i++)
		{
			if (getMyChar().arrItemBag[i] != null && (getMyChar().arrItemBag[i].template.type == 25 || getMyChar().arrItemBag[i].template.type == 23 || getMyChar().arrItemBag[i].template.type == 24))
			{
				getMyChar().arrItemBag[i] = null;
			}
		}
		Npc.clearEffTask();
	}

	public static int getCT()
	{
		if (pointChienTruong >= 4000)
		{
			return 4;
		}
		if (pointChienTruong >= 1500)
		{
			return 3;
		}
		if (pointChienTruong >= 600)
		{
			return 2;
		}
		if (pointChienTruong >= 200)
		{
			return 1;
		}
		return 0;
	}

	private void updateEffectWolf()
	{
		tickEffWolf++;
		if (tickEffWolf > 5)
		{
			tickEffWolf = 0;
		}
	}

	private void updateEffwolfMove()
	{
		if (arrItemMounts[4].template.id != 443 || arrItemMounts[4].sys < 2)
		{
			return;
		}
		Effx = EffdefautX;
		Effy = EffdefautY;
		if (idWolfW[1] == 1737)
		{
			if (cdir != 1)
			{
				EffdefautY -= 5;
			}
			else
			{
				EffdefautY -= 5;
			}
		}
		Domsang o;
		Domsang o2;
		if (cdir != 1)
		{
			o = new Domsang(EffdefautX - 4, EffdefautY, 0);
			o2 = new Domsang(EffdefautX - 1, EffdefautY, 0);
		}
		else
		{
			o = new Domsang(EffdefautX + 4, EffdefautY, 0);
			o2 = new Domsang(EffdefautX + 1, EffdefautY, 0);
		}
		if (statusMe != 1 || statusMe != 6)
		{
			vDomsang.addElement(o);
			vDomsang.addElement(o2);
		}
	}

	private void updateEffmotoMove()
	{
		if (arrItemMounts[4].template.id == 524 && arrItemMounts[4].sys >= 2)
		{
			Domsang o;
			Domsang o2;
			if (cdir != 1)
			{
				o = new Domsang(EffdefautX, EffdefautY, 1);
				o2 = new Domsang(EffdefautX1, EffdefautY1, 1);
			}
			else
			{
				o = new Domsang(EffdefautX, EffdefautY, 1);
				o2 = new Domsang(EffdefautX1, EffdefautY1, 1);
			}
			if ((statusMe == 2 || statusMe == 10) && GameCanvas.gameTick % 3 == 0)
			{
				vDomsang.addElement(o);
				vDomsang.addElement(o2);
			}
		}
	}

	public int[] geteffOngbo()
	{
		int[] result = null;
		if (isMoto && arrItemMounts[4].template.id == 485 && arrItemMounts[4].sys >= 3)
		{
			result = new int[3] { 2094, 2095, 2096 };
		}
		return result;
	}

	public int[] getEffmoto()
	{
		int[] result = null;
		if (isMoto)
		{
			result = new int[12]
			{
				2082, 2082, 2083, 2083, 2084, 2084, 2089, 2089, 2082, 2082,
				2083, 2083
			};
		}
		return result;
	}

	public int[] getEffwolf()
	{
		int[] result = null;
		if (isWolf)
		{
			result = new int[4] { 2085, 2086, 2087, 2088 };
		}
		return result;
	}

	public bool isHumanz()
	{
		return isHuman;
	}

	public bool isNhanbanz()
	{
		return isNhanban;
	}

	public void paint_No(mGraphics g)
	{
	}

	public void update_No()
	{
	}

	public void GetNewMount()
	{
		frameMount = (int[][])CharPartInfo.newMount.get(arrItemMounts[4].template.id + string.Empty);
	}

	public bool isHaveNewMount()
	{
		if (ID_HORSE > -1)
		{
			return false;
		}
		if (arrItemMounts != null && arrItemMounts[4] != null && arrItemMounts[4].template != null && arrItemMounts[4].template.id != 443 && arrItemMounts[4].template.id != 523 && arrItemMounts[4].template.id != 485 && arrItemMounts[4].template.id != 524)
		{
			return true;
		}
		return false;
	}

	public void updNewMount()
	{
		if (ID_HORSE > -1 || !isNewMount)
		{
			return;
		}
		tickNewMount++;
		if (isMotoBehind)
		{
			fNewMount = 5;
		}
		else if (statusMe == 1 || statusMe == 6)
		{
			fNewMount = 0;
			tickNewMount = ((GameCanvas.gameTick % 20 > 12) ? 1 : 0);
			if (ID_PP > -1)
			{
				tickNewMount = cf;
			}
			dyMount = tickNewMount;
		}
		else if (statusMe == 2 || statusMe == 10)
		{
			fNewMount = 1;
			int num = frameMount[fNewMount].Length / 3;
			if (tickNewMount < num)
			{
				dyMount = 0;
			}
			else if (tickNewMount < num * 2)
			{
				dyMount = 1;
			}
			else
			{
				dyMount = 2;
			}
		}
		else if (statusMe == 3)
		{
			fNewMount = 2;
		}
		else if (statusMe == 4)
		{
			fNewMount = 3;
		}
		else if (statusMe == 14)
		{
			fNewMount = 4;
		}
		if (tickNewMount > frameMount[fNewMount].Length - 1)
		{
			tickNewMount = 0;
		}
	}

	public void paintBehindNewMount(mGraphics g)
	{
		int transform = 2;
		if (cdir == 1)
		{
			transform = 0;
		}
		SmallImage.drawSmallImage(g, frameMount[fNewMount][tickNewMount], cx, cy, transform, mGraphics.BOTTOM | mGraphics.HCENTER);
	}

	public void paintNewMount(mGraphics g, Part pW, Part ph, int[] idCoat, DataSkillEff partMatna)
	{
		int transform = 2;
		int anchor = 24;
		if (cdir == 1)
		{
			transform = 0;
			anchor = 0;
		}
		int num = 0;
		int num2 = -7;
		if (pW != null)
		{
			SmallImage.drawSmallImage(g, pW.pi[CharInfo[cf][3][0]].id, cx + (CharInfo[cf][3][1] + pW.pi[CharInfo[cf][3][0]].dx) * cdir, cy - CharInfo[cf][3][2] + pW.pi[CharInfo[cf][3][0]].dy - 10 + dyMount + num, transform, anchor);
		}
		if (idCoat != null && ID_PP == -1)
		{
			SmallImage.drawSmallImage(g, idCoat[tickCoat], cx + hdx + (dxBody + num2) * cdir, cy - SmallImage.getHeight(getLegId()) - 19 + dyBody + dyMount + num, transform, mGraphics.TOP | mGraphics.HCENTER);
		}
		int num3 = 18;
		int num4 = -4;
		if (cdir == 1)
		{
			num4 = 4;
		}
		SmallImage.drawSmallImage(g, frameMount[fNewMount][tickNewMount], cx, cy, transform, mGraphics.BOTTOM | mGraphics.HCENTER);
		if (ID_Body > -1)
		{
			paintBody(g, cx + num4 + getxs(), cy - num3 + dyMount - getys(), 1);
		}
		else
		{
			SmallImage.drawSmallImage(g, getBodyPaintId(), cx + hdx + dxBody * cdir, cy - SmallImage.getHeight(getLegId()) - 9 + dyBody + dyMount + num, transform, mGraphics.BOTTOM | mGraphics.HCENTER);
		}
		if (ID_HAIR > -1)
		{
			paintHair(g, cx + num4 + getxs(), cy - num3 + dyMount - getys(), 1);
		}
		else
		{
			SmallImage.drawSmallImage(g, getHeadId(), cx + hdx + dxHead * cdir, cy - CharInfo[0][0][2] + ph.pi[CharInfo[0][0][0]].dy - 12 + dyHead + dyMount + num, transform, mGraphics.TOP | mGraphics.HCENTER);
		}
		if (partMatna != null)
		{
			paintMatNaTop(g, cx + hdx + dxHead * cdir, cy - CharInfo[0][0][2] + ph.pi[CharInfo[0][0][0]].dy - 12 + dyHead + dyMount + num + 31, 1, partMatna);
		}
	}

	public override void setThoiTrang(short[] arr)
	{
		if (arr != null)
		{
			ID_HAIR = arr[0];
			ID_Body = arr[1];
			ID_LEG = arr[2];
			ID_WEA_PONE = arr[3];
			ID_PP = arr[4];
			ID_NAME = arr[5];
			ID_HORSE = arr[6];
			ID_RANK = arr[7];
			ID_MAT_NA = arr[8];
			ID_Bien_Hinh = arr[9];
		}
	}
}
