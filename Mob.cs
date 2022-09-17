using System;

public class Mob : MainObject
{
	public const sbyte TYPE_DUNG = 0;

	public const sbyte TYPE_DI = 1;

	public const sbyte TYPE_NHAY = 2;

	public const sbyte TYPE_LET = 3;

	public const sbyte TYPE_BAY = 4;

	public const sbyte TYPE_BAY_DAU = 5;

	public const sbyte TYPE_HIDE = 6;

	public static MobTemplate[] arrMobTemplate;

	public const sbyte MA_INHELL = 0;

	public const sbyte MA_DEADFLY = 1;

	public const sbyte MA_STANDWAIT = 2;

	public const sbyte MA_ATTACK = 3;

	public const sbyte MA_STANDFLY = 4;

	public const sbyte MA_WALK = 5;

	public const sbyte MA_FALL = 6;

	public const sbyte MA_INJURE = 7;

	public const sbyte MA_NOTACTIVE = 8;

	public const sbyte MA_DISSAPPEAR = 9;

	public const sbyte MA_REVIVAL = 10;

	public string flyString;

	public int flyx;

	public int flyy;

	public int flyIndex;

	public int hp;

	public int maxHp;

	public int x;

	public int y;

	public int frame;

	public int dir = 1;

	public int dirV = 1;

	public int status;

	public int p1;

	public int p2;

	public int p3;

	public int xFirst;

	public int yFirst;

	public int vy;

	public int exp;

	public int w;

	public int h;

	public int hpInjure;

	public int charIndex;

	public int timeStatus;

	public short mobId;

	public bool isx;

	public bool isy;

	public bool isDisable;

	public bool isDontMove;

	public bool isFire;

	public bool isIce;

	public bool isWind;

	public MyVector vMobMove = new MyVector();

	public bool isGo;

	public string mobName;

	public int templateId;

	public short pointx;

	public short pointy;

	public Char cFocus;

	public BuNhin bFocus;

	public int dame;

	public int dameMp;

	public int sys;

	public int typeAtt;

	public short levelBoss;

	public short level;

	public bool isBoss;

	private long timeStartDie;

	private int frameIndex;

	public static Char interestChar;

	public static Char CharAtt;

	public static MyVector vEggMonter = new MyVector();

	public static EggMonters egg;

	public static bool isdetrung = false;

	public static long timewait;

	private bool removeWhenDie;

	public bool isBusyAttackSomeOne = true;

	public long timeCurrent;

	private sbyte[] cou = new sbyte[2] { -1, 1 };

	public Char injureBy;

	public bool injureThenDie;

	public Mob mobToAttack;

	public Char charToAttack;

	public short idSkill_atk;

	public sbyte typeAtk;

	public sbyte typeTool;

	private sbyte indexlongden = -1;

	public static sbyte[][] idframe = new sbyte[53][]
	{
		new sbyte[4] { 3, 4, 5, 6 },
		new sbyte[1],
		new sbyte[8] { 2, 2, 2, 2, 3, 3, 3, 3 },
		new sbyte[2] { 0, 1 },
		new sbyte[2] { 0, 1 },
		new sbyte[3] { 3, 4, 5 },
		new sbyte[1],
		new sbyte[6] { 3, 3, 4, 4, 5, 5 },
		new sbyte[1],
		new sbyte[3] { 3, 4, 5 },
		new sbyte[5] { 0, 1, 2, 3, 4 },
		new sbyte[3] { 3, 4, 5 },
		new sbyte[3] { 4, 5, 6 },
		new sbyte[1],
		new sbyte[2] { 0, 1 },
		new sbyte[2] { 0, 1 },
		new sbyte[6] { 3, 3, 4, 4, 5, 5 },
		new sbyte[3] { 0, 1, 2 },
		new sbyte[3] { 0, 1, 2 },
		new sbyte[4] { 5, 6, 7, 8 },
		new sbyte[3] { 0, 1, 2 },
		new sbyte[3] { 0, 1, 2 },
		new sbyte[3] { 0, 1, 2 },
		new sbyte[4] { 3, 4, 5, 6 },
		new sbyte[3] { 0, 1, 2 },
		new sbyte[4] { 0, 1, 2, 3 },
		new sbyte[3] { 0, 1, 2 },
		new sbyte[3] { 0, 1, 2 },
		new sbyte[3] { 0, 1, 2 },
		new sbyte[3] { 0, 1, 2 },
		new sbyte[1],
		new sbyte[1],
		new sbyte[1],
		new sbyte[1],
		new sbyte[3] { 0, 1, 2 },
		new sbyte[1],
		new sbyte[1],
		new sbyte[6] { 0, 0, 1, 1, 2, 2 },
		new sbyte[10] { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[2] { 0, 1 },
		new sbyte[2] { 0, 1 }
	};

	public static sbyte[][] idframeAppear = new sbyte[52][]
	{
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[1]
	};

	public static sbyte[][] idframeDisappear = new sbyte[56][]
	{
		new sbyte[5] { 5, 4, 3, 2, 1 },
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[5] { 5, 4, 3, 2, 1 },
		new sbyte[5] { 5, 4, 3, 2, 1 },
		new sbyte[5] { 5, 4, 3, 2, 1 },
		new sbyte[0],
		new sbyte[5] { 5, 4, 3, 2, 1 },
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[0],
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[8] { 0, 0, 1, 1, 2, 2, 3, 3 },
		new sbyte[1]
	};

	public bool isNotRangeMove;

	private int tt;

	public Mob(short mobId, bool isDisable, bool isDontMove, bool isFire, bool isIce, bool isWind, int templateId, int sys, int hp, int level, int maxhp, short pointx, short pointy, sbyte status, sbyte levelBoss, bool isBos, bool removeWhenDie)
	{
		this.isDisable = isDisable;
		this.isDontMove = isDontMove;
		this.isFire = isFire;
		this.isIce = isIce;
		this.isWind = isWind;
		this.sys = sys;
		this.mobId = mobId;
		this.templateId = templateId;
		this.hp = hp;
		this.level = (short)level;
		xFirst = (x = (this.pointx = pointx));
		yFirst = (y = (this.pointy = pointy));
		if (templateId == 168 || templateId == 179 || templateId == 175 || templateId == 177 || templateId == 202)
		{
			this.status = 8;
		}
		else
		{
			this.status = status;
		}
		maxHp = maxhp;
		this.levelBoss = levelBoss;
		isBoss = isBos;
		if (templateId == 202)
		{
			egg = new EggMonters(xFirst, yFirst - 100);
			vEggMonter.addElement(egg);
			EggMonters.ownerEgg = this;
		}
		if (arrMobTemplate[templateId].imgs == null)
		{
			arrMobTemplate[templateId].imgs = new Image[0];
			Service.gI().requestModTemplate(templateId);
		}
		timewait = Res.random(2000, 3500);
		this.removeWhenDie = removeWhenDie;
	}

	public void update()
	{
		if (!isUpdate())
		{
			return;
		}
		if (cFocus == null && (templateId == 168 || templateId == 179 || templateId == 175))
		{
			status = 8;
		}
		if (vMobMove == null && arrMobTemplate[templateId].rangeMove != 0)
		{
			return;
		}
		if (status != 3 && isBusyAttackSomeOne)
		{
			if (cFocus != null)
			{
				cFocus.doInjure(dame, dameMp, isBoss, getTemplate().mobTemplateId);
				cFocus = null;
			}
			isBusyAttackSomeOne = false;
		}
		if (hp <= 0 && mobId != -1)
		{
			status = 1;
		}
		switch (status)
		{
		case 9:
			updateDissappare();
			break;
		case 8:
			updateMobNotActive();
			break;
		case 1:
			isDisable = false;
			isDontMove = false;
			isFire = false;
			isIce = false;
			isWind = false;
			if (templateId != 98 && templateId != 99)
			{
				p1++;
				y += p1;
				if (interestChar != null)
				{
					if (interestChar.myskill != null)
					{
						if (interestChar.myskill.template.id > 72)
						{
							if (GameCanvas.gameTick % 9 == 0)
							{
								if (p2 > 1)
								{
									p2 += 5;
								}
								else if (p2 < -1)
								{
									p2 -= 5;
								}
							}
						}
						else if (GameCanvas.gameTick % 2 == 0)
						{
							if (p2 > 1)
							{
								p2--;
							}
							else if (p2 < -1)
							{
								p2++;
							}
						}
					}
				}
				else if (Char.getMyChar() != null && Char.getMyChar().myskill != null)
				{
					if (Char.getMyChar().myskill.template.id > 72)
					{
						if (GameCanvas.gameTick % 9 == 0)
						{
							if (p2 > 1)
							{
								p2 += 5;
							}
							else if (p2 < -1)
							{
								p2 -= 5;
							}
						}
					}
					else if (GameCanvas.gameTick % 2 == 0)
					{
						if (p2 > 1)
						{
							p2--;
						}
						else if (p2 < -1)
						{
							p2++;
						}
					}
				}
				x += p2;
				if (templateId == 209 || templateId == 210)
				{
					frame = 6;
				}
				else if (templateId == 168 || templateId == 176 || templateId == 177 || templateId == 179 || templateId == 180 || templateId == 191)
				{
					frame = 7;
				}
				else if (templateId == 178 || templateId == 181 || templateId == 183 || templateId == 185 || templateId == 188 || templateId == 192 || templateId == 194)
				{
					frame = 4;
				}
				else if (templateId == 173 || templateId == 184)
				{
					frame = 6;
				}
				else if (templateId == 175)
				{
					frame = 8;
				}
				else if (templateId == 170 || templateId == 195 || templateId == 196 || templateId == 197 || templateId == 186 || templateId == 189 || templateId == 190)
				{
					frame = 3;
				}
				else if (templateId == 187)
				{
					frame = 9;
				}
				else if (templateId == 193)
				{
					frame = 5;
				}
				else if (templateId == 174)
				{
					frame = 10;
				}
				else
				{
					frame = ((!isBoss) ? 2 : 10);
				}
				if (y > GameScr.gssye * 24 || x < GameScr.gssx * 24 || x > GameScr.gssxe * 24)
				{
					p1 = 0;
					p2 = 0;
					x = (y = 0);
					hp = getTemplate().hp;
					status = 0;
					if (templateId < 168)
					{
						frame = 0;
					}
					else
					{
						frame = setFrameAppear(GameCanvas.gameTick);
					}
					timeStatus = 0;
					return;
				}
				if (p3 == 0 && (TileMap.tileTypeAtPixel(x, y) & TileMap.T_TOP) == TileMap.T_TOP)
				{
					p1 = ((p1 <= 4) ? (-p1) : (-4));
					p3 = 16;
				}
				if (p3 > 0)
				{
					p3--;
				}
			}
			else
			{
				long num = mSystem.currentTimeMillis();
				if (num - timeStartDie > 1200)
				{
					status = 0;
				}
			}
			break;
		case 2:
			timeStatus = 0;
			if (isBoss && templateId > 210)
			{
				updWalk_NewBoss();
			}
			else
			{
				updateMobStandWait();
			}
			break;
		case 4:
			timeStatus = 0;
			frame = 0;
			p1++;
			if (p1 > 40 + mobId % 5)
			{
				y -= 2;
				status = 5;
				p1 = 0;
			}
			break;
		case 3:
			if (mobToAttack == null && charToAttack == null)
			{
				if (idSkill_atk < 0)
				{
					if (isBoss && templateId > 210)
					{
						updAtk_NewBoss();
					}
					else
					{
						updateMobAttack();
					}
				}
				else
				{
					updateTypeMobAttk();
				}
			}
			else
			{
				updateAttk_Thunuoi();
			}
			break;
		case 5:
			try
			{
				if (GameCanvas.gameTick % 4 == 0 && isBoss)
				{
					frameIndex++;
					if (frameIndex > arrMobTemplate[templateId].frameBossMove.Length - 1)
					{
						frameIndex = 0;
					}
				}
			}
			catch (Exception)
			{
			}
			timeStatus = 0;
			updateMobWalk();
			break;
		case 6:
			timeStatus = 0;
			p1++;
			y += p1;
			if (y >= yFirst)
			{
				y = yFirst;
				p1 = 0;
				status = 5;
			}
			break;
		case 7:
			updateInjure();
			break;
		}
		setatk_mob();
		if (removeWhenDie && hp <= 0)
		{
			GameScr.vMob.removeElement(this);
		}
		updateDataEff(1, status);
	}

	public void setInjure()
	{
		if (hp > 0)
		{
			timeStatus = 4;
			status = 7;
		}
	}

	public void setAttack(Char cFocus)
	{
		isBusyAttackSomeOne = true;
		this.cFocus = cFocus;
		p1 = 0;
		p2 = 0;
		status = 3;
		if (templateId == 209 || templateId == 210)
		{
			frameIndex = 0;
		}
		else if (templateId == 168 || templateId == 176 || templateId == 177 || templateId == 179)
		{
			frameIndex = 6;
		}
		else if (templateId == 169 || templateId == 171 || templateId == 172 || templateId == 182)
		{
			frameIndex = 2;
		}
		else if (templateId == 175)
		{
			frameIndex = 7;
		}
		else if (templateId == 181 || templateId == 185 || templateId == 188 || templateId == 194 || templateId == 192)
		{
			frameIndex = 3;
		}
		else if (templateId == 183 || templateId == 170 || templateId == 193)
		{
			frameIndex = 4;
		}
		else if (templateId == 187 || templateId == 168 || templateId == 175 || templateId == 176 || templateId == 179 || templateId == 174)
		{
			frameIndex = setFrameAtt(GameCanvas.gameTick);
		}
		else
		{
			frameIndex = 0;
		}
		typeAtt = 0;
		isNotRangeMove = false;
	}

	public void setAttack(BuNhin bFocus)
	{
		this.bFocus = bFocus;
		p1 = 0;
		p2 = 0;
		status = 3;
		typeAtt = 1;
	}

	private void updateInjure()
	{
		frame = ((!isBoss) ? 2 : ((getTemplate().mobTemplateId == 204) ? 9 : ((getTemplate().mobTemplateId == 203) ? 9 : ((getTemplate().mobTemplateId == 139) ? 4 : ((getTemplate().mobTemplateId != 160) ? 10 : 12)))));
		if (getTemplate().mobTemplateId == 209 || getTemplate().mobTemplateId == 210)
		{
			frame = 3;
		}
		else if (getTemplate().mobTemplateId == 141)
		{
			frame = 13;
		}
		else if (getTemplate().mobTemplateId == 169 || getTemplate().mobTemplateId == 170 || getTemplate().mobTemplateId == 171 || getTemplate().mobTemplateId == 172 || getTemplate().mobTemplateId == 182)
		{
			frame = 3;
		}
		else if (getTemplate().mobTemplateId == 168 || getTemplate().mobTemplateId == 176 || getTemplate().mobTemplateId == 177 || getTemplate().mobTemplateId == 179 || getTemplate().mobTemplateId == 180)
		{
			frame = 7;
		}
		else if (getTemplate().mobTemplateId == 173 || getTemplate().mobTemplateId == 184)
		{
			frame = 6;
		}
		else if (getTemplate().mobTemplateId == 181 || getTemplate().mobTemplateId == 178 || getTemplate().mobTemplateId == 185 || getTemplate().mobTemplateId == 202)
		{
			frame = 4;
		}
		else if (getTemplate().mobTemplateId == 174)
		{
			frame = 10;
		}
		else if (getTemplate().mobTemplateId == 183)
		{
			frame = 5;
		}
		else if (getTemplate().mobTemplateId == 175)
		{
			frame = 8;
		}
		timeStatus--;
		if (timeStatus <= 0)
		{
			if ((injureBy != null && injureThenDie) || hp == 0)
			{
				status = 1;
				p2 = injureBy.cdir << 3;
				p1 = -5;
				p3 = 0;
			}
			else
			{
				status = 5;
				if (injureBy != null)
				{
					dir = -injureBy.cdir;
					if (Res.abs(x - injureBy.cx) < 24)
					{
						status = 2;
					}
				}
				p1 = (p2 = (p3 = 0));
				timeStatus = 0;
			}
			injureBy = null;
		}
		else if (arrMobTemplate[templateId].type != 0)
		{
			int num = -injureBy.cdir << 1;
			if (x > xFirst - arrMobTemplate[templateId].rangeMove && x < xFirst + arrMobTemplate[templateId].rangeMove)
			{
				x -= num;
			}
		}
	}

	private void updateMobStandWait()
	{
		switch (arrMobTemplate[templateId].type)
		{
		case 0:
		case 1:
		case 2:
		case 3:
			if (templateId == 209 || templateId == 210)
			{
				frame = 1;
			}
			else if (templateId == 173 || templateId == 175 || templateId == 176 || templateId == 177 || templateId == 179 || templateId == 180 || templateId == 181 || templateId == 183 || templateId == 184 || templateId == 185)
			{
				frame = 1;
			}
			else if (templateId == 168 || templateId == 179)
			{
				frame = 6;
			}
			else if (templateId == 174)
			{
				frame = 4;
			}
			else if (templateId == 202)
			{
				frame = 0;
			}
			else
			{
				frame = 0;
			}
			p1++;
			if (p1 > 10 + mobId % 10 && mSystem.currentTimeMillis() - (timeCurrent + timewait) >= 0)
			{
				status = 5;
			}
			if (isBoss)
			{
				frame = ((GameCanvas.gameTick % 101 <= 1) ? 1 : 0);
			}
			break;
		case 4:
		case 5:
			if (!isBoss)
			{
				if (templateId < 168)
				{
					frame = ((GameCanvas.gameTick % 4 <= 1) ? 1 : 0);
				}
				else
				{
					frame = setFrameMove(GameCanvas.gameTick);
				}
			}
			else
			{
				frame = arrMobTemplate[templateId].frameBossMove[frameIndex];
			}
			p1++;
			if (p1 > mobId % 3)
			{
				status = 5;
			}
			break;
		}
	}

	private void updateMobNotActive()
	{
		frame = 0;
	}

	private void updateTypeMobAttk()
	{
		if (p1 == 0)
		{
			int num = 0;
			int num2 = 0;
			num = cFocus.cx;
			num2 = cFocus.cy;
			typeAtt = typeAtk;
			dir = ((x < num) ? 1 : 0);
			if (isBoss)
			{
				frameIndex++;
				if (frameIndex >= arrMobTemplate[templateId].frameBossAttack[typeAtt].Length)
				{
					frameIndex = 0;
					status = 2;
					mobToAttack = null;
					charToAttack = null;
					p1 = 0;
					p2 = 0;
				}
				if (frameIndex == arrMobTemplate[templateId].frameBossAttack[typeAtt].Length - 1)
				{
					if (typeTool == 0)
					{
						ServerEffect.addServerEffect(idSkill_atk, num, num2, 1, (sbyte)((dir != 0) ? 1 : (-1)));
					}
					else if (typeTool == 1 && idSkill_atk > -1)
					{
						EffectAuto.addEffectAuto(idSkill_atk, num, num2, 1, -1, (dir != 0) ? 1 : (-1));
					}
				}
				frame = arrMobTemplate[templateId].frameBossAttack[typeAtk][frameIndex];
			}
			else
			{
				ServerEffect.addServerEffect(idSkill_atk, num, num2, 1, (sbyte)((dir != 0) ? 1 : (-1)));
			}
			if (arrMobTemplate[templateId].type != 0 && !isDontMove && isIce && isWind)
			{
				x += (num - x) / 3;
			}
			if (x > xFirst + arrMobTemplate[templateId].rangeMove)
			{
				p1 = 1;
			}
			if (x < xFirst - arrMobTemplate[templateId].rangeMove)
			{
				p1 = 1;
			}
		}
		else if (p1 == 1)
		{
			if (arrMobTemplate[templateId].type != 0 && !isDontMove && !isIce && !isWind)
			{
				x += (xFirst - x) / 4;
				y += (yFirst - y) / 4;
			}
			if (Res.abs(xFirst - x) < 5 && Res.abs(yFirst - y) < 5)
			{
				status = 2;
				frameIndex = 0;
				p1 = 0;
				p2 = 0;
			}
		}
	}

	private void updateMobAttack()
	{
		if (templateId == 209 || templateId == 210)
		{
			frame = 6;
		}
		else if (templateId == 176 || templateId == 177 || templateId == 179)
		{
			frame = 6;
		}
		else if (templateId == 175)
		{
			frame = 7;
		}
		else if (templateId == 180 || templateId == 181 || templateId == 183 || templateId == 184 || templateId == 173 || templateId == 188 || templateId == 192 || templateId == 194 || templateId == 202)
		{
			frame = 3;
		}
		else if (templateId == 193)
		{
			frame = 4;
		}
		else if (templateId == 187 || templateId == 168 || templateId == 175 || templateId == 176 || templateId == 179 || templateId == 174)
		{
			frame = setFrameAtt(GameCanvas.gameTick);
		}
		else
		{
			frame = ((GameCanvas.gameTick % 4 <= 1) ? 1 : ((arrMobTemplate[templateId].type == 5) ? 3 : 0));
		}
		if (p1 == 0)
		{
			int num = 0;
			int num2 = 0;
			if (typeAtt == 0)
			{
				num = cFocus.cx;
				num2 = cFocus.cy;
			}
			else if (typeAtt == 1)
			{
				num = bFocus.x;
				num2 = bFocus.y;
			}
			if (Res.abs(num - x) < 24 || Res.abs(num - x) < 5 || arrMobTemplate[templateId].type == 0)
			{
				if (templateId == 168 || templateId == 176 || templateId == 177 || templateId == 179)
				{
					frame = 6;
				}
				else if (templateId == 175)
				{
					frame = 7;
				}
				else if (templateId == 180 || templateId == 181 || templateId == 183 || templateId == 184 || templateId == 173 || templateId == 202)
				{
					frame = 3;
				}
				else if (templateId == 187 || templateId == 168 || templateId == 179 || templateId == 174)
				{
					frame = setFrameAtt(GameCanvas.gameTick);
				}
				else
				{
					frame = ((arrMobTemplate[templateId].imgs.Length != 3) ? 3 : 0);
				}
			}
			if (isBoss && (Res.abs(num - x) < 48 || Res.abs(num - x) < 10 || arrMobTemplate[templateId].type == 0))
			{
				frame = ((arrMobTemplate[templateId].imgs.Length != 3) ? 3 : 0);
			}
			if (isBoss)
			{
				frameIndex++;
				if (Res.abs(num - x) < 48 || Res.abs(num2 - y) < 10)
				{
					if (frameIndex >= arrMobTemplate[templateId].frameBossAttack[0].Length)
					{
						frameIndex = 0;
					}
					frame = arrMobTemplate[templateId].frameBossAttack[0][frameIndex];
				}
				else
				{
					if (frameIndex >= arrMobTemplate[templateId].frameBossAttack[1].Length)
					{
						frameIndex = 0;
					}
					frame = arrMobTemplate[templateId].frameBossAttack[1][frameIndex];
				}
			}
			if (frame == 3 || frame == 6 || frame == 7)
			{
				p1 = 1;
			}
			if (arrMobTemplate[templateId].type != 0 && !isDontMove && isIce && isWind)
			{
				x += (num - x) / 3;
			}
			if (x > xFirst + arrMobTemplate[templateId].rangeMove)
			{
				p1 = 1;
			}
			if (x < xFirst - arrMobTemplate[templateId].rangeMove)
			{
				p1 = 1;
			}
			if ((arrMobTemplate[templateId].type == 4 || arrMobTemplate[templateId].type == 5) && !isDontMove)
			{
				y += (num2 - y) / 20;
			}
			p2++;
			if ((isBoss && Res.abs(num - x) < 48 && Res.abs(num2 - y) < 15) || (Res.abs(num - x) < 12 && Res.abs(num2 - y) < 12) || p2 > 12 || p1 == 1 || (arrMobTemplate != null && arrMobTemplate[templateId].frameBossAttack != null && frameIndex == arrMobTemplate[templateId].frameBossAttack[0].Length - 2 && (getTemplate().mobTemplateId == 166 || getTemplate().mobTemplateId == 167)))
			{
				p1 = 1;
				if (typeAtt == 0)
				{
					if (isBoss && Res.abs(num - x) < 48 && Res.abs(num2 - y) < 15)
					{
						cFocus.doInjure(dame, dameMp, isBoss, getTemplate().mobTemplateId);
						isBusyAttackSomeOne = false;
						if (getTemplate().mobTemplateId == 210)
						{
							if (cFocus.cx > x)
							{
								ServerEffect.addServerEffect(142, x, y, 1);
							}
							else
							{
								ServerEffect.addServerEffect(142, x, y, 1, -1);
							}
						}
						else if (getTemplate().mobTemplateId == 209)
						{
							if (cFocus.cx > x)
							{
								ServerEffect.addServerEffect(108, x, y, 1);
							}
							else
							{
								ServerEffect.addServerEffect(108, x, y, 1, -1);
							}
						}
						else if (getTemplate().mobTemplateId == 114)
						{
							ServerEffect.addServerEffect(79, cFocus, 3);
						}
						else if (getTemplate().mobTemplateId == 115)
						{
							if (cFocus == Char.getMyChar())
							{
								GameScr.shaking = 1;
							}
							GameScr.count = 0;
							ServerEffect.addServerEffect(81, cFocus.cx, yFirst + TileMap.size, 2);
							ServerEffect.addServerEffect(81, cFocus.cx - 40, yFirst + TileMap.size, 2);
							ServerEffect.addServerEffect(81, cFocus.cx + 40, yFirst + TileMap.size, 2);
						}
						else if (getTemplate().mobTemplateId == 116)
						{
							if (cFocus == Char.getMyChar())
							{
								GameScr.shaking = 1;
								GameScr.count = 0;
							}
							if (cFocus.cx > x)
							{
								ServerEffect.addServerEffect(86, x, y - h / 2 + 5, 1);
							}
							else
							{
								ServerEffect.addServerEffect(88, x, y - h / 2 + 5, 1);
							}
							ServerEffect.addServerEffect(87, cFocus.cx, cFocus.cy - cFocus.ch / 2, 2);
							ServerEffect.addServerEffect(87, cFocus.cx - 40, cFocus.cy - cFocus.ch / 2, 2);
							ServerEffect.addServerEffect(87, cFocus.cx + 40, cFocus.cy - cFocus.ch / 2, 2);
						}
						else if (getTemplate().mobTemplateId == 138)
						{
							if (cFocus.cx > x)
							{
								ServerEffect.addServerEffect(89, x + w / 2, y - h / 2 - 5, 1);
							}
							else
							{
								ServerEffect.addServerEffect(89, x - w / 2, y - h / 2 - 5, 1, -1);
							}
							ServerEffect.addServerEffect(90, cFocus, 2);
						}
						else if (getTemplate().mobTemplateId == 139)
						{
							if (cFocus == Char.getMyChar())
							{
								GameScr.shaking = 1;
								GameScr.count = 0;
							}
							ServerEffect.addServerEffect(91, cFocus, 2);
						}
						else if (getTemplate().mobTemplateId == 140 || getTemplate().mobTemplateId == 161)
						{
							if (cFocus == Char.getMyChar())
							{
								GameScr.shaking = 1;
								GameScr.count = 0;
							}
							ServerEffect.addServerEffect(112, cFocus, 2);
							ServerEffect.addServerEffect(109, cFocus.cx - 40, cFocus.cy - 40, 1);
							ServerEffect.addServerEffect(109, cFocus.cx + 40, cFocus.cy - 40, 1);
							ServerEffect.addServerEffect(109, cFocus.cx - 20, cFocus.cy, 2);
							ServerEffect.addServerEffect(109, cFocus.cx + 20, cFocus.cy, 2);
						}
						else if (getTemplate().mobTemplateId == 141 || getTemplate().mobTemplateId == 162)
						{
							if (cFocus.cx > x)
							{
								ServerEffect.addServerEffect(108, x + w / 2, y, 1);
							}
							else
							{
								ServerEffect.addServerEffect(108, x - w / 2, y, 1, -1);
							}
							ServerEffect.addServerEffect(122, x, y, 1, (sbyte)dir);
							ServerEffect.addServerEffect(91, cFocus, 1);
						}
						else if (getTemplate().mobTemplateId == 144 || getTemplate().mobTemplateId == 163)
						{
							if (cFocus == Char.getMyChar())
							{
								GameScr.shaking = 1;
								GameScr.count = 0;
							}
							ServerEffect.addServerEffect(112, cFocus, 2);
							ServerEffect.addServerEffect(109, cFocus.cx - 40, cFocus.cy - 40, 1);
							ServerEffect.addServerEffect(109, cFocus.cx + 40, cFocus.cy - 40, 1);
							ServerEffect.addServerEffect(109, cFocus.cx - 20, cFocus.cy, 2);
							ServerEffect.addServerEffect(109, cFocus.cx + 20, cFocus.cy, 2);
						}
						else if (getTemplate().mobTemplateId == 160)
						{
							if (cFocus.cx > x)
							{
								ServerEffect.addServerEffect(123, x + w / 2, y - 5, 1);
							}
							else
							{
								ServerEffect.addServerEffect(123, x - w / 2, y - 5, 1, -1);
							}
							ServerEffect.addServerEffect(91, cFocus, 1);
						}
						else if (getTemplate().mobTemplateId == 164 || getTemplate().mobTemplateId == 165)
						{
							if (cFocus.cx > x)
							{
								ServerEffect.addServerEffect(125, x + w / 2, y, 1);
							}
							else
							{
								ServerEffect.addServerEffect(125, x - w / 2, y, 1, -1);
							}
							ServerEffect.addServerEffect(90, cFocus, 1);
						}
						else if (getTemplate().mobTemplateId == 167)
						{
							if (cFocus.cx > x)
							{
								ServerEffect.addServerEffect(125, x + w / 2, y, 1);
							}
							else
							{
								ServerEffect.addServerEffect(125, x - w / 2, y, 1, -1);
							}
						}
						else if (getTemplate().mobTemplateId == 166)
						{
							if (cFocus.cx > x)
							{
								ServerEffect.addServerEffect(108, x + w / 2, y, 1);
							}
							else
							{
								ServerEffect.addServerEffect(108, x - w / 2, y, 1, -1);
							}
						}
						else if (getTemplate().mobTemplateId == 198)
						{
							if (cFocus.cx > x)
							{
								ServerEffect.addServerEffect(143, x + w / 2, y, 1);
							}
							else
							{
								ServerEffect.addServerEffect(143, x - w / 2, y, 1, -1);
							}
						}
						else if (getTemplate().mobTemplateId == 199)
						{
							if (cFocus.cx > x)
							{
								ServerEffect.addServerEffect(144, x + w / 2, y, 1);
							}
							else
							{
								ServerEffect.addServerEffect(144, x - w / 2, y, 1, -1);
							}
						}
						else if (getTemplate().mobTemplateId == 200)
						{
							if (cFocus.cx > x)
							{
								ServerEffect.addServerEffect(142, x + w / 2, y, 1);
							}
							else
							{
								ServerEffect.addServerEffect(142, x - w / 2, y, 1, -1);
							}
						}
						else if (getTemplate().mobTemplateId == 201)
						{
							if (cFocus.cx > x)
							{
								ServerEffect.addServerEffect(144, x + w / 2, y, 1);
							}
							else
							{
								ServerEffect.addServerEffect(144, x - w / 2, y, 1, -1);
							}
						}
						else if (getTemplate().mobTemplateId == 203)
						{
							if (cFocus.cx > x)
							{
								ServerEffect.addServerEffect(159, x + w / 2, y, 1);
								ServerEffect.addServerEffect(156, cFocus.cx, cFocus.cy, 1);
							}
							else
							{
								ServerEffect.addServerEffect(159, x - w / 2, y, 1, -1);
								ServerEffect.addServerEffect(156, cFocus.cx, cFocus.cy, -1);
							}
						}
						else if (getTemplate().mobTemplateId == 204)
						{
							if (cFocus.cx > x)
							{
								ServerEffect.addServerEffect(159, x + w / 2, y, 1);
								ServerEffect.addServerEffect(173, cFocus.cx, cFocus.cy, 1);
							}
							else
							{
								ServerEffect.addServerEffect(159, x - w / 2, y, 1, -1);
								ServerEffect.addServerEffect(173, cFocus.cx, cFocus.cy, -1);
							}
						}
					}
					else if (Res.abs(num - x) < 24 && Res.abs(num2 - y) < 15)
					{
						cFocus.doInjure(dame, dameMp, isBoss, getTemplate().mobTemplateId);
						isBusyAttackSomeOne = false;
					}
					else
					{
						if (isBoss)
						{
							if (getTemplate().mobTemplateId == 210)
							{
								if (cFocus.cx > x)
								{
									ServerEffect.addServerEffect(178, cFocus.cx, cFocus.cy, 1);
								}
								else
								{
									ServerEffect.addServerEffect(178, cFocus.cx, cFocus.cy, 1, -1);
								}
							}
							else if (getTemplate().mobTemplateId == 209)
							{
								if (cFocus.cx > x)
								{
									ServerEffect.addServerEffect(179, cFocus.cx, cFocus.cy, 1);
								}
								else
								{
									ServerEffect.addServerEffect(179, cFocus.cx, cFocus.cy, 1, -1);
								}
							}
							else if (getTemplate().mobTemplateId == 114 || getTemplate().mobTemplateId == 115)
							{
								MonsterDart.addMonsterDart(x + (dir - 1) * 15, y - 20, isBoss, levelBoss, getTemplate().mobTemplateId, dame, dameMp, cFocus);
							}
							else if (getTemplate().mobTemplateId == 116)
							{
								ServerEffect.addServerEffect(84, cFocus, 2);
								isBusyAttackSomeOne = false;
								cFocus.doInjure(dame, dameMp, isBoss, getTemplate().mobTemplateId);
							}
							else if (getTemplate().mobTemplateId == 138)
							{
								if (cFocus == Char.getMyChar())
								{
									GameScr.shaking = 1;
									GameScr.count = 0;
								}
								ServerEffect.addServerEffect(83, cFocus, 2);
								isBusyAttackSomeOne = false;
								cFocus.doInjure(dame, dameMp, isBoss, getTemplate().mobTemplateId);
							}
							else if (getTemplate().mobTemplateId == 139)
							{
								MonsterDart.addMonsterDart(x + (dir - 1) * 30, y - 30, isBoss, levelBoss, getTemplate().mobTemplateId, dame, dameMp, cFocus);
							}
							else if (getTemplate().mobTemplateId == 140 || getTemplate().mobTemplateId == 161)
							{
								if (cFocus == Char.getMyChar())
								{
									GameScr.shaking = 1;
									GameScr.count = 0;
								}
								ServerEffect.addServerEffect(110, cFocus, 2);
								ServerEffect.addServerEffect(104, cFocus.cx - 20, cFocus.cy, 2);
								ServerEffect.addServerEffect(104, cFocus.cx + 20, cFocus.cy, 2);
								isBusyAttackSomeOne = false;
								cFocus.doInjure(dame, dameMp, isBoss, getTemplate().mobTemplateId);
							}
							else if (getTemplate().mobTemplateId == 141 || getTemplate().mobTemplateId == 162)
							{
								if (cFocus == Char.getMyChar())
								{
									GameScr.shaking = 1;
									GameScr.count = 0;
								}
								ServerEffect.addServerEffect(121, cFocus, 1);
								isBusyAttackSomeOne = false;
								cFocus.doInjure(dame, dameMp, isBoss, getTemplate().mobTemplateId);
							}
							else if (getTemplate().mobTemplateId == 144 || getTemplate().mobTemplateId == 163)
							{
								MonsterDart.addMonsterDart(x + (dir - 1) * 15, y - 20, isBoss, levelBoss, getTemplate().mobTemplateId, dame, dameMp, cFocus);
							}
							else if (getTemplate().mobTemplateId == 160)
							{
								ServerEffect.addServerEffect(124, cFocus, 2);
								isBusyAttackSomeOne = false;
								cFocus.doInjure(dame, dameMp, isBoss, getTemplate().mobTemplateId);
							}
							else if (getTemplate().mobTemplateId == 164 || getTemplate().mobTemplateId == 165)
							{
								ServerEffect.addServerEffect(126, cFocus, 1);
								isBusyAttackSomeOne = false;
								cFocus.doInjure(dame, dameMp, isBoss, getTemplate().mobTemplateId);
							}
							else if (getTemplate().mobTemplateId == 167)
							{
								ServerEffect.addServerEffect(112, cFocus.cx + 5, cFocus.cy, 1);
								ServerEffect.addServerEffect(112, cFocus.cx - 5, cFocus.cy, 1);
								ServerEffect.addServerEffect(112, cFocus, 1);
								isBusyAttackSomeOne = false;
								cFocus.doInjure(dame, dameMp, isBoss, getTemplate().mobTemplateId);
							}
							else if (getTemplate().mobTemplateId == 166)
							{
								ServerEffect.addServerEffect(92, cFocus.cx + 5, cFocus.cy, 1);
								ServerEffect.addServerEffect(92, cFocus.cx - 5, cFocus.cy, 1);
								ServerEffect.addServerEffect(92, cFocus, 1);
								isBusyAttackSomeOne = false;
								cFocus.doInjure(dame, dameMp, isBoss, getTemplate().mobTemplateId);
							}
							else if (getTemplate().mobTemplateId == 198)
							{
								ServerEffect.addServerEffect(142, cFocus.cx + 5, cFocus.cy, 1);
								ServerEffect.addServerEffect(142, cFocus.cx - 5, cFocus.cy, 1);
								ServerEffect.addServerEffect(142, cFocus, 1);
								isBusyAttackSomeOne = false;
								cFocus.doInjure(dame, dameMp, isBoss, getTemplate().mobTemplateId);
							}
							else if (getTemplate().mobTemplateId == 199)
							{
								ServerEffect.addServerEffect(143, cFocus.cx + 5, cFocus.cy, 1);
								ServerEffect.addServerEffect(143, cFocus.cx - 5, cFocus.cy, 1);
								ServerEffect.addServerEffect(143, cFocus, 1);
								isBusyAttackSomeOne = false;
								cFocus.doInjure(dame, dameMp, isBoss, getTemplate().mobTemplateId);
							}
							else if (getTemplate().mobTemplateId == 200)
							{
								ServerEffect.addServerEffect(144, cFocus.cx + 5, cFocus.cy, 1);
								ServerEffect.addServerEffect(144, cFocus.cx - 5, cFocus.cy, 1);
								ServerEffect.addServerEffect(144, cFocus, 1);
								isBusyAttackSomeOne = false;
								cFocus.doInjure(dame, dameMp, isBoss, getTemplate().mobTemplateId);
							}
							else if (getTemplate().mobTemplateId == 201)
							{
								ServerEffect.addServerEffect(108, cFocus.cx + 5, cFocus.cy, 1);
								ServerEffect.addServerEffect(108, cFocus.cx - 5, cFocus.cy, 1);
								ServerEffect.addServerEffect(108, cFocus, 1);
								isBusyAttackSomeOne = false;
								cFocus.doInjure(dame, dameMp, isBoss, getTemplate().mobTemplateId);
							}
							else if (getTemplate().mobTemplateId == 203)
							{
								ServerEffect.addServerEffect(149, cFocus.cx + 5, cFocus.cy, 1);
								ServerEffect.addServerEffect(149, cFocus.cx - 5, cFocus.cy, 1);
								ServerEffect.addServerEffect(149, cFocus, 1);
								ServerEffect.addServerEffect(156, cFocus, 1);
								isBusyAttackSomeOne = false;
								cFocus.doInjure(dame, dameMp, isBoss, getTemplate().mobTemplateId);
							}
							else if (getTemplate().mobTemplateId == 204)
							{
								ServerEffect.addServerEffect(153, cFocus.cx + 5, cFocus.cy, 1);
								ServerEffect.addServerEffect(153, cFocus.cx - 5, cFocus.cy, 1);
								ServerEffect.addServerEffect(153, cFocus, 1);
								ServerEffect.addServerEffect(173, cFocus, 1);
								isBusyAttackSomeOne = false;
								cFocus.doInjure(dame, dameMp, isBoss, getTemplate().mobTemplateId);
							}
						}
						else
						{
							MonsterDart.addMonsterDart(x - 5, y + dir * 10, isBoss, level, getTemplate().mobTemplateId, dame, dameMp, cFocus);
						}
						isBusyAttackSomeOne = false;
					}
				}
				else if (typeAtt == 1)
				{
					if (Res.abs(num - x) < 24 && Res.abs(num2 - y) < 15)
					{
						bFocus.doInjure();
						isBusyAttackSomeOne = false;
					}
					else
					{
						if (isBoss)
						{
							MonsterDart.addMonsterDart(x - 5, y + dir * 10 - 20, bFocus);
						}
						else
						{
							MonsterDart.addMonsterDart(x - 5, y + dir * 10, bFocus);
						}
						isBusyAttackSomeOne = false;
					}
				}
			}
			dir = ((x < num) ? 1 : (-1));
		}
		else if (p1 == 1)
		{
			if (arrMobTemplate[templateId].type != 0 && !isDontMove && !isIce && !isWind)
			{
				x += (xFirst - x) / 4;
				y += (yFirst - y) / 4;
			}
			if (Res.abs(xFirst - x) < 5 && Res.abs(yFirst - y) < 5)
			{
				status = 2;
				p1 = 0;
				p2 = 0;
			}
		}
	}

	public void updateMobWalk()
	{
		int num = 0;
		try
		{
			if (injureThenDie)
			{
				status = 1;
				p2 = injureBy.cdir << 3;
				p1 = -5;
				p3 = 0;
			}
			num = 1;
			if (isIce)
			{
				return;
			}
			if (isDontMove || isWind)
			{
				frame = 0;
				return;
			}
			switch (arrMobTemplate[templateId].type)
			{
			case 0:
				num = 2;
				if (templateId == 176)
				{
					status = 9;
				}
				frame = 0;
				break;
			case 1:
			case 2:
			case 3:
			{
				num = 3;
				sbyte b = arrMobTemplate[templateId].speed;
				if (b == 1)
				{
					if (GameCanvas.gameTick % 2 == 1)
					{
						break;
					}
				}
				else if (b > 2)
				{
					b = (sbyte)(b + (sbyte)(mobId % 2));
				}
				else if (GameCanvas.gameTick % 2 == 1)
				{
					b = (sbyte)(b - 1);
				}
				x += b * dir;
				if (Res.random(0, arrMobTemplate[templateId].rangeMove) == arrMobTemplate[templateId].rangeMove / 3)
				{
					status = 2;
					timeCurrent = mSystem.currentTimeMillis();
				}
				if (x > xFirst + arrMobTemplate[templateId].rangeMove)
				{
					dir = -1;
					if (templateId == 168 || templateId == 177)
					{
						status = 9;
						p1 = 0;
					}
				}
				else if (x < xFirst - arrMobTemplate[templateId].rangeMove)
				{
					dir = 1;
					if (templateId == 168 || templateId == 177)
					{
						status = 9;
						p1 = 0;
					}
				}
				if (!isBoss)
				{
					if (templateId < 168)
					{
						frame = ((GameCanvas.gameTick % 4 <= 1) ? 1 : 0);
					}
					else
					{
						frame = setFrameMove(GameCanvas.gameTick);
					}
				}
				else
				{
					frame = arrMobTemplate[templateId].frameBossMove[frameIndex];
				}
				break;
			}
			case 4:
			{
				num = 4;
				sbyte speed2 = arrMobTemplate[templateId].speed;
				speed2 = (sbyte)(speed2 + (sbyte)(mobId % 2));
				x += speed2 * dir;
				if (GameCanvas.gameTick % 10 > 2 && templateId != 205 && templateId != 206 && templateId != 207 && templateId != 208)
				{
					indexlongden = -1;
					y += speed2 * dirV;
				}
				speed2 = (sbyte)(speed2 + (sbyte)((GameCanvas.gameTick + mobId) % 2));
				if (x > xFirst + arrMobTemplate[templateId].rangeMove)
				{
					dir = -1;
					if (templateId == 179 || templateId == 175)
					{
						status = 9;
					}
					p1 = 0;
				}
				else if (x < xFirst - arrMobTemplate[templateId].rangeMove)
				{
					dir = 1;
					if (templateId == 179 || templateId == 175)
					{
						status = 9;
					}
					p1 = 0;
				}
				if (y > yFirst + 24)
				{
					dirV = -1;
				}
				else if (y < yFirst - (20 + GameCanvas.gameTick % 10))
				{
					dirV = 1;
				}
				if (!isBoss)
				{
					if (templateId < 168)
					{
						frame = ((GameCanvas.gameTick % 4 <= 1) ? 1 : 0);
					}
					else
					{
						frame = setFrameMove(GameCanvas.gameTick);
					}
				}
				else
				{
					frame = arrMobTemplate[templateId].frameBossMove[frameIndex];
				}
				break;
			}
			case 5:
			{
				num = 5;
				sbyte speed = arrMobTemplate[templateId].speed;
				speed = (sbyte)(speed + (sbyte)(mobId % 2));
				x += speed * dir;
				speed = (sbyte)(speed + (sbyte)((GameCanvas.gameTick + mobId) % 2));
				if (GameCanvas.gameTick % 10 > 2)
				{
					y += speed * dirV;
				}
				if (x > xFirst + arrMobTemplate[templateId].rangeMove)
				{
					dir = -1;
					if (templateId == 179 || templateId == 175)
					{
						status = 9;
					}
					else
					{
						status = 2;
					}
					p1 = 0;
				}
				else if (x < xFirst - arrMobTemplate[templateId].rangeMove)
				{
					dir = 1;
					if (templateId == 179 || templateId == 175)
					{
						status = 9;
					}
					else
					{
						status = 2;
					}
					p1 = 0;
				}
				if (y > yFirst + 24)
				{
					dirV = -1;
				}
				else if (y < yFirst - (20 + GameCanvas.gameTick % 10))
				{
					dirV = 1;
				}
				if (TileMap.tileTypeAt(x, y, TileMap.T_TOP))
				{
					if (GameCanvas.gameTick % 10 > 5)
					{
						y = TileMap.tileYofPixel(y);
						status = 4;
						p1 = 0;
						dirV = -1;
					}
					else
					{
						dirV = -1;
					}
				}
				if (!isBoss)
				{
					if (templateId < 168)
					{
						frame = ((GameCanvas.gameTick % 4 <= 1) ? 1 : 3);
					}
					else
					{
						frame = setFrameMove(GameCanvas.gameTick);
					}
				}
				else
				{
					frame = arrMobTemplate[templateId].frameBossMove[frameIndex];
				}
				break;
			}
			}
		}
		catch (Exception)
		{
		}
	}

	public MobTemplate getTemplate()
	{
		return arrMobTemplate[templateId];
	}

	public bool isPaint()
	{
		if (x < GameScr.cmx)
		{
			return false;
		}
		if (x > GameScr.cmx + GameScr.gW)
		{
			return false;
		}
		if (y < GameScr.cmy)
		{
			return false;
		}
		if (y > GameScr.cmy + GameScr.gH + 30)
		{
			return false;
		}
		if (arrMobTemplate[templateId] == null)
		{
			return false;
		}
		if (!isBoss)
		{
			if (frame >= arrMobTemplate[templateId].imgs.Length)
			{
				return false;
			}
			if (arrMobTemplate[templateId].imgs[frame] == null)
			{
				return false;
			}
			if (templateId == 179 || templateId == 175 || templateId == 202)
			{
				if (status == 8)
				{
					return false;
				}
			}
			else if (templateId == 176 && (frame == 1 || frame == 0))
			{
				return false;
			}
		}
		if (status == 0)
		{
			return false;
		}
		return true;
	}

	public bool isUpdate()
	{
		if (arrMobTemplate[templateId] == null)
		{
			return false;
		}
		if (arrMobTemplate[templateId].imgs == null)
		{
			return false;
		}
		if (!isBoss)
		{
			if (frame >= arrMobTemplate[templateId].imgs.Length)
			{
				return false;
			}
			if (arrMobTemplate[templateId].imgs[frame] == null)
			{
				return false;
			}
		}
		if (status == 0)
		{
			return false;
		}
		return true;
	}

	public void paint(mGraphics g)
	{
		if (!isPaint())
		{
			return;
		}
		int num = y;
		if (templateId == 205 || templateId == 206 || templateId == 207 || templateId == 208)
		{
			indexlongden++;
			if (indexlongden > Char.locate.Length - 1)
			{
				indexlongden = 0;
			}
		}
		if (indexlongden > -1)
		{
			num += Char.locate[indexlongden];
		}
		MobTemplate mobTemplate = arrMobTemplate[templateId];
		if (!isBoss)
		{
			if (w == 0)
			{
				w = mGraphics.getImageWidth(mobTemplate.imgs[0]);
			}
			if (h == 0)
			{
				h = mGraphics.getImageHeight(mobTemplate.imgs[0]);
			}
		}
		else
		{
			w = 40;
			h = 40;
		}
		paintBottomDataEff(g, x, num, getStartPointPaintFly());
		try
		{
			int arg = ((dir <= 0) ? 2 : 0);
			if (templateId == 219)
			{
				arg = 0;
			}
			if ((templateId == 98 || templateId == 99) && status == 1)
			{
				long num2 = mSystem.currentTimeMillis();
				if (num2 - timeStartDie < 400)
				{
					g.drawRegion(mobTemplate.imgs[this.frame], 0, 0, mGraphics.getImageWidth(mobTemplate.imgs[this.frame]), mGraphics.getImageHeight(mobTemplate.imgs[this.frame]), arg, x, num, StaticObj.BOTTOM_HCENTER);
				}
				else if (num2 - timeStartDie < 800)
				{
					g.drawRegion(mobTemplate.imgs[this.frame], 0, 0, mGraphics.getImageWidth(mobTemplate.imgs[this.frame]), 3 * mGraphics.getImageHeight(mobTemplate.imgs[this.frame]) / 5, arg, x, num, StaticObj.BOTTOM_HCENTER);
				}
				else if (num2 - timeStartDie < 1200)
				{
					g.drawRegion(mobTemplate.imgs[this.frame], 0, 0, mGraphics.getImageWidth(mobTemplate.imgs[this.frame]), mGraphics.getImageHeight(mobTemplate.imgs[this.frame]) / 3, arg, x, num, StaticObj.BOTTOM_HCENTER);
				}
				if (GameCanvas.gameTick % 8 < 2)
				{
					SmallImage.drawSmallImage(g, 457, x, num, 0, StaticObj.BOTTOM_HCENTER);
				}
				else if (GameCanvas.gameTick % 8 < 4)
				{
					SmallImage.drawSmallImage(g, 458, x, num, 0, StaticObj.BOTTOM_HCENTER);
				}
				else if (GameCanvas.gameTick % 8 < 6)
				{
					SmallImage.drawSmallImage(g, 459, x, num, 0, StaticObj.BOTTOM_HCENTER);
				}
			}
			else if (isBoss)
			{
				if (getTemplate().frameBoss != null)
				{
					if (templateId < 236)
					{
						Frame frame = getTemplate().frameBoss[this.frame];
						for (int i = 0; i < frame.dx.Length; i++)
						{
							ImageInfo imgInfo = getTemplate().getImgInfo(frame.idImg[i]);
							if (dir > 0)
							{
								g.drawRegion(getTemplate().imgs[0], imgInfo.x0, imgInfo.y0, imgInfo.w, imgInfo.h, 0, x + frame.dx[i], num + frame.dy[i] - 1, mGraphics.TOP | mGraphics.LEFT);
							}
							else
							{
								g.drawRegion(getTemplate().imgs[0], imgInfo.x0, imgInfo.y0, imgInfo.w, imgInfo.h, 2, x - frame.dx[i], num + frame.dy[i] - 1, mGraphics.TOP | mGraphics.RIGHT);
							}
						}
					}
					else
					{
						paintBottomMobNew(g);
						paintTopMobNew(g);
					}
				}
			}
			else if (templateId == 168)
			{
				if (status == 8)
				{
					g.drawRegion(mobTemplate.imgs[this.frame], 0, 0, mGraphics.getImageWidth(mobTemplate.imgs[this.frame]), mGraphics.getImageHeight(mobTemplate.imgs[this.frame]), arg, x, num, StaticObj.BOTTOM_HCENTER);
				}
				else
				{
					g.drawRegion(mobTemplate.imgs[this.frame], 0, 0, mGraphics.getImageWidth(mobTemplate.imgs[this.frame]), mGraphics.getImageHeight(mobTemplate.imgs[this.frame]), arg, x, num, StaticObj.BOTTOM_HCENTER);
				}
			}
			else
			{
				g.drawRegion(mobTemplate.imgs[this.frame], 0, 0, mGraphics.getImageWidth(mobTemplate.imgs[this.frame]), mGraphics.getImageHeight(mobTemplate.imgs[this.frame]), arg, x, num, StaticObj.BOTTOM_HCENTER);
			}
			paintTopDataEff(g, x, num, 0);
		}
		catch (Exception ex)
		{
			ex.ToString();
		}
		int num3 = num;
		if (Char.getMyChar().mobFocus != null && Char.getMyChar().mobFocus.Equals(this) && status != 1)
		{
			if (isBoss)
			{
				int num4 = maxHp;
				if (num4 < hp)
				{
					num4 = hp;
				}
				int num5 = (int)((long)hp * 100L / num4);
				int num6 = w;
				int num7 = 4;
				if (levelBoss == 1 || levelBoss == 2 || levelBoss == 3 || isBoss)
				{
					num7 += num7 / 2;
					num6 += num6 / 2;
				}
				num6 += 2;
				int num8 = num6 * num5 / 100;
				if (num8 < 2)
				{
					num8 = 2;
				}
				if (status == 1)
				{
					num5 = 0;
				}
				if (templateId == 140 || templateId == 160)
				{
					num3 -= 20;
				}
				if (templateId != 142 && templateId != 143)
				{
					g.setColor(16777215);
					g.fillRect(x - num6 / 2 - 1, num3 - h - 12, num6, num7);
					g.setColor(getHPColor());
					g.fillRect(x - num6 / 2 - 1, num3 - h - 12, num8, num7);
					g.setColor(0);
					g.drawRect(x - num6 / 2 - 1, num3 - h - 12, num6, num7);
				}
				else
				{
					SmallImage.drawSmallImage(g, 988, x, num3 - h, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
				}
			}
			else
			{
				int num9 = maxHp;
				if (num9 < hp)
				{
					num9 = hp;
				}
				int num10 = (int)((long)hp * 100L / num9);
				int num11 = w;
				if (templateId > 167)
				{
					num11 = w / 2;
				}
				int num12 = 4;
				if (levelBoss == 1 || levelBoss == 2 || levelBoss == 3 || isBoss)
				{
					num12 += num12 / 2;
					num11 += num11 / 2;
				}
				
				if (levelBoss == 4) {
					num12 += num12;
					num11 += num11 * 4;
				} // test boss level 4

				num11 += 2;
				int num13 = num11 * num10 / 100;
				if (num13 < 2)
				{
					num13 = 2;
				}
				if (status == 1)
				{
					num10 = 0;
				}
				if (templateId == 140 || templateId == 160)
				{
					num3 -= 20;
				}
				if (templateId != 142 && templateId != 143)
				{
					g.setColor(16777215);
					g.fillRect(x - num11 / 2 - 1, num3 - h - 12, num11, num12);
					g.setColor(getHPColor());
					g.fillRect(x - num11 / 2 - 1, num3 - h - 12, num13, num12);
					g.setColor(0);
					g.drawRect(x - num11 / 2 - 1, num3 - h - 12, num11, num12);
				}
				else
				{
					SmallImage.drawSmallImage(g, 988, x, num3 - h, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
				}
			}
			if (levelBoss > 0)
			{
				if (levelBoss == 1)
				{
					mFont.tahoma_7_yellow.drawString(g, mResources.BOSS[levelBoss], x, num3 - h - 26, 2, mFont.tahoma_7_grey);
				}
				else if (levelBoss == 2)
				{
					mFont.tahoma_7_yellow.drawString(g, mResources.BOSS[levelBoss], x, num3 - h - 26, 2, mFont.tahoma_7_grey);
				}
				else if (levelBoss == 3)
				{
					mFont.tahoma_7_blue1.drawString(g, mResources.BOSS[levelBoss], x, num3 - h - 26, 2, mFont.tahoma_7_grey);
				}
				else if (levelBoss == 4)
				{
					mFont.tahoma_7b_purple.drawString(g, mResources.BOSS[levelBoss], x, num3 - h - 26, 2, mFont.tahoma_7_grey);
				}
				if (isDisable)
				{
					SmallImage.drawSmallImage(g, 494, x, num3 - h - 28, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
				}
			}
			else if (isDisable)
			{
				SmallImage.drawSmallImage(g, 494, x, num3 - h - 15, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
			}
		}
		else if (levelBoss > 0)
		{
			if (levelBoss == 1)
			{
				mFont.tahoma_7_yellow.drawString(g, mResources.BOSS[levelBoss], x, num3 - h - 20, 2, mFont.tahoma_7_grey);
			}
			else if (levelBoss == 2)
			{
				mFont.tahoma_7_yellow.drawString(g, mResources.BOSS[levelBoss], x, num3 - h - 20, 2, mFont.tahoma_7_grey);
			}
			else if (levelBoss == 3)
			{
				mFont.tahoma_7_blue1.drawString(g, mResources.BOSS[levelBoss], x, num3 - h - 20, 2, mFont.tahoma_7_grey);
			}
			else if (levelBoss == 4)
			{
				mFont.tahoma_7b_purple.drawString(g, mResources.BOSS[levelBoss], x, num3 - h - 26, 2, mFont.tahoma_7_grey);
			}
			if (isDisable)
			{
				SmallImage.drawSmallImage(g, 494, x, num3 - h - 22, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
			}
		}
		else if (isDisable)
		{
			SmallImage.drawSmallImage(g, 494, x, num - h - 5, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
		}
		if (isDontMove)
		{
			if (GameCanvas.gameTick % 2 == 0)
			{
				SmallImage.drawSmallImage(g, 1082, x, num - h / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
			}
			else
			{
				SmallImage.drawSmallImage(g, 1084, x, num - h / 2, 0, mGraphics.VCENTER | mGraphics.HCENTER);
			}
		}
		if (isIce)
		{
			SmallImage.drawSmallImage(g, 290, x, num, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
		}
		if (isWind)
		{
			switch (GameCanvas.gameTick % 6)
			{
			case 0:
			case 1:
				SmallImage.drawSmallImage(g, 998, x, num - h - 5, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				break;
			case 2:
			case 3:
				SmallImage.drawSmallImage(g, 999, x, num - h - 5, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				break;
			case 4:
			case 5:
				SmallImage.drawSmallImage(g, 1000, x, num - h - 5, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				break;
			}
		}
		if (isFire)
		{
			switch (GameCanvas.gameTick % 16)
			{
			case 0:
				SmallImage.drawSmallImage(g, 1013, x - w / 2, num - h + h / 4, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				break;
			case 1:
				SmallImage.drawSmallImage(g, 1014, x - w / 2, num - h + h / 4, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				break;
			case 2:
				SmallImage.drawSmallImage(g, 1015, x - w / 2, num - h + h / 4, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				break;
			case 3:
				SmallImage.drawSmallImage(g, 1016, x - w / 2, num - h + h / 4, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				break;
			case 4:
				SmallImage.drawSmallImage(g, 1013, x + w / 2, num - h, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				break;
			case 5:
				SmallImage.drawSmallImage(g, 1014, x + w / 2, num - h, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				break;
			case 6:
				SmallImage.drawSmallImage(g, 1015, x + w / 2, num - h, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				break;
			case 7:
				SmallImage.drawSmallImage(g, 1016, x + w / 2, num - h, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				break;
			case 8:
				SmallImage.drawSmallImage(g, 1013, x - w / 2, num, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				break;
			case 9:
				SmallImage.drawSmallImage(g, 1014, x - w / 2, num, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				break;
			case 10:
				SmallImage.drawSmallImage(g, 1015, x - w / 2, num, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				break;
			case 11:
				SmallImage.drawSmallImage(g, 1016, x - w / 2, num, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				break;
			case 12:
				SmallImage.drawSmallImage(g, 1013, x + w / 2, num - h / 4, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				break;
			case 13:
				SmallImage.drawSmallImage(g, 1014, x + w / 2, num - h / 4, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				break;
			case 14:
				SmallImage.drawSmallImage(g, 1015, x + w / 2, num - h / 4, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				break;
			case 15:
				SmallImage.drawSmallImage(g, 1016, x + w / 2, num - h / 4, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				break;
			}
		}
	}

	public int getHPColor()
	{
		if (sys <= 1)
		{
			return 16711680;
		}
		if (sys == 2)
		{
			return 33023;
		}
		if (sys == 3)
		{
			return 7443811;
		}
		return 16711680;
	}

	public void startDie()
	{
		hp = 0;
		timeStartDie = mSystem.currentTimeMillis();
		if (injureBy != null)
		{
			injureThenDie = true;
			return;
		}
		injureThenDie = true;
		hp = 0;
		status = 1;
		p1 = -5;
		p2 = -dir << 2;
		p3 = 0;
	}

	public void attackOtherMob(Mob mobToAttack)
	{
		this.mobToAttack = mobToAttack;
	}

	public void attackOtherChar(Char charToAttack)
	{
		this.charToAttack = charToAttack;
	}

	public void setatk_mob()
	{
		if (mobToAttack != null)
		{
			if (isBoss)
			{
				status = 3;
			}
			else
			{
				int num = mobToAttack.x - x;
				int num2 = mobToAttack.y - y;
				x += num / 4;
				y += num2 / 4;
				dir = ((x < mobToAttack.x) ? 1 : 0);
				if (mobToAttack.status == 1 || mobToAttack.status == 0 || (Res.abs(num) < 20 && Res.abs(num2) < 20))
				{
					if (typeTool == 0)
					{
						ServerEffect.addServerEffect((idSkill_atk != -1) ? idSkill_atk : 59, mobToAttack.x, mobToAttack.y, (dir != 0) ? 1 : (-1));
					}
					else if (typeTool == 1 && idSkill_atk > -1)
					{
						EffectAuto.addEffectAuto(idSkill_atk, mobToAttack.x, mobToAttack.y, 1, -1, (dir != 0) ? 1 : (-1));
					}
					mobToAttack = null;
				}
			}
		}
		if (charToAttack == null)
		{
			return;
		}
		if (isBoss)
		{
			status = 3;
			return;
		}
		int num3 = charToAttack.cx - x;
		int num4 = charToAttack.cy - y;
		x += num3 / 4;
		y += num4 / 4;
		dir = ((x < charToAttack.cx) ? 1 : 0);
		if (charToAttack.statusMe == 5 || charToAttack.statusMe == 14 || (Res.abs(num3) < 20 && Res.abs(num4) < 20))
		{
			if (typeTool == 0)
			{
				ServerEffect.addServerEffect((idSkill_atk != -1) ? idSkill_atk : 59, charToAttack.cx, charToAttack.cy, (dir != 0) ? 1 : (-1));
			}
			else if (typeTool == 1 && idSkill_atk > -1)
			{
				EffectAuto.addEffectAuto(idSkill_atk, charToAttack.cx, charToAttack.cy, 1, -1, (dir != 0) ? 1 : (-1));
			}
			charToAttack = null;
		}
	}

	public void setTypeAtk(short idSkill_atk, sbyte typeAtk, sbyte typeTool)
	{
		this.idSkill_atk = idSkill_atk;
		this.typeAtk = typeAtk;
		this.typeTool = typeTool;
	}

	public void attackOtherInRange()
	{
		if (templateId == 116)
		{
			ServerEffect.addServerEffect(84, Char.getMyChar(), 1);
		}
		else if (templateId == 115)
		{
			ServerEffect.addServerEffect(81, Char.getMyChar(), 1);
		}
		else if (templateId == 138)
		{
			ServerEffect.addServerEffect(90, Char.getMyChar(), 1);
		}
		else if (templateId == 139)
		{
			ServerEffect.addServerEffect(91, Char.getMyChar(), 1);
		}
		else if (templateId == 140 || templateId == 161)
		{
			ServerEffect.addServerEffect(110, Char.getMyChar(), 2);
		}
		else if (templateId == 141 || templateId == 162)
		{
			ServerEffect.addServerEffect(121, Char.getMyChar(), 1);
		}
		else if (templateId == 144 || templateId == 163)
		{
			ServerEffect.addServerEffect(121, Char.getMyChar(), 1);
		}
		else if (templateId == 160)
		{
			ServerEffect.addServerEffect(124, Char.getMyChar(), 1);
		}
		else if (templateId == 164 || templateId == 165)
		{
			ServerEffect.addServerEffect(126, cFocus, 1);
		}
		else if (templateId == 166)
		{
			ServerEffect.addServerEffect(103, cFocus, 1);
		}
		else if (templateId == 166)
		{
			ServerEffect.addServerEffect(105, cFocus, 1);
		}
	}

	private int setFrameMove(int Gametick)
	{
		int num = Gametick % idframe[templateId - 168].Length;
		if (templateId != 198 && templateId != 199 && templateId != 200 && templateId != 201 && templateId != 203 && templateId != 204)
		{
			return idframe[templateId - 168][num];
		}
		return 0;
	}

	private int setFrameAppear(int Gametick)
	{
		try
		{
			int num = Gametick % idframeAppear[templateId - 168].Length;
			return idframeAppear[templateId - 168][num];
		}
		catch (Exception)
		{
			return 0;
		}
	}

	private int setFrameAtt(int Gametick)
	{
		int num = Gametick % 5;
		if (templateId == 178)
		{
			switch (num)
			{
			case 0:
				return 5;
			case 1:
				return 6;
			case 2:
				return 7;
			case 3:
				return 8;
			}
		}
		else if (templateId == 168)
		{
			switch (num)
			{
			case 0:
				return 1;
			case 1:
				return 2;
			case 2:
				return 3;
			case 3:
				return 4;
			case 4:
				return 5;
			}
		}
		else if (templateId == 179)
		{
			switch (num)
			{
			case 0:
				return 0;
			case 1:
				return 2;
			case 2:
				return 3;
			case 3:
				return 4;
			case 4:
				return 5;
			}
		}
		else if (templateId == 175)
		{
			switch (num)
			{
			case 0:
				return 0;
			case 1:
				return 2;
			case 2:
				return 3;
			case 3:
				return 4;
			case 4:
				return 5;
			}
		}
		else if (templateId == 176)
		{
			switch (num)
			{
			case 0:
				return 2;
			case 1:
				return 3;
			case 2:
				return 4;
			case 3:
				return 5;
			case 4:
				return 6;
			}
		}
		else if (templateId == 177)
		{
			switch (num)
			{
			case 0:
				return 1;
			case 1:
				return 2;
			case 2:
				return 3;
			case 3:
				return 4;
			case 4:
				return 5;
			}
		}
		else if (templateId == 174)
		{
			switch (num)
			{
			case 0:
				return 5;
			case 1:
				return 6;
			case 2:
				return 7;
			case 3:
				return 8;
			case 4:
				return 9;
			}
		}
		return 0;
	}

	private int setFrameDisappear(int Gametick)
	{
		try
		{
			int num = Gametick % idframeDisappear[templateId - 168].Length;
			return idframeDisappear[templateId - 168][num];
		}
		catch (Exception)
		{
			return 0;
		}
	}

	private void updateDissappare()
	{
		frame = setFrameDisappear(GameCanvas.gameTick);
		if (frame == 1)
		{
			status = 8;
		}
	}

	public Image loadImg(string path)
	{
		Image image = null;
		if (image == null)
		{
			return GameCanvas.loadImage("/trung1");
		}
		return null;
	}

	public static int AttbyidSkill()
	{
		if (interestChar != null)
		{
			return interestChar.myskill.template.id;
		}
		return 0;
	}

	public static void loadImagez(string path, int templateid)
	{
		arrMobTemplate[templateid].imgs = new Image[5];
		for (int i = 0; i < arrMobTemplate[templateid].imgs.Length; i++)
		{
			arrMobTemplate[templateid].imgs[i] = GameCanvas.loadImage(path + (i + 1));
		}
	}

	public bool isBossz()
	{
		return isBoss;
	}

	public void updateAttmobFly(Char charFocus, int templateid)
	{
		if ((arrMobTemplate[templateid].type == 4 || arrMobTemplate[templateid].type == 5) && status == 3)
		{
			isNotRangeMove = true;
			int num = x - charFocus.cx;
			int num2 = y - charFocus.cy;
			if (num > 50 || num < -50)
			{
				x += num;
			}
			if (num2 > 50 || num2 < -50)
			{
				y += num2;
			}
			if (x > xFirst + arrMobTemplate[templateid].rangeMove || x > xFirst - arrMobTemplate[templateid].rangeMove)
			{
				x = xFirst;
				y = yFirst;
			}
			update();
		}
	}

	public void updateAttmobStand(Char charFocus, int templateid)
	{
		if ((arrMobTemplate[templateid].type == 3 || arrMobTemplate[templateid].type == 1) && y == cFocus.cy)
		{
			isNotRangeMove = true;
			int num = x - charFocus.cx;
			if (num > 50 || num < -50)
			{
				x += num;
			}
			if (x > xFirst + arrMobTemplate[templateid].rangeMove || x > xFirst - arrMobTemplate[templateid].rangeMove)
			{
				x = xFirst;
				y = yFirst;
			}
			update();
		}
	}

	public Image loadImageMob(int i)
	{
		return GameCanvas.loadImage("/" + templateId + "/" + (i + 1) + ".png");
	}

	public void updateAttk_Thunuoi()
	{
		if (p1 == 0)
		{
			int num = 0;
			int cy = 0;
			if (mobToAttack != null)
			{
				num = mobToAttack.x;
				cy = mobToAttack.y;
			}
			if (charToAttack != null)
			{
				num = charToAttack.cx;
				cy = charToAttack.cy;
			}
			typeAtt = typeAtk;
			dir = ((x < num) ? 1 : 0);
			if (isBoss)
			{
				frameIndex++;
				if (frameIndex >= arrMobTemplate[templateId].frameBossAttack[typeAtt].Length)
				{
					frameIndex = 0;
					status = 2;
					mobToAttack = null;
					charToAttack = null;
					p1 = 0;
					p2 = 0;
				}
				if (frameIndex == arrMobTemplate[templateId].frameBossAttack[typeAtt].Length - 2)
				{
					if (typeTool == 0)
					{
						ServerEffect.addServerEffect((idSkill_atk != -1) ? idSkill_atk : 59, num, cy, 1, (sbyte)((dir != 0) ? 1 : (-1)));
					}
					else if (typeTool == 1 && idSkill_atk > -1)
					{
						EffectAuto.addEffectAuto(idSkill_atk, num, cy, 1, -1, (dir != 0) ? 1 : (-1));
					}
				}
				frame = arrMobTemplate[templateId].frameBossAttack[typeAtk][frameIndex];
			}
			if (arrMobTemplate[templateId].type != 0 && !isDontMove && isIce && isWind)
			{
				x += (num - x) / 3;
			}
			if (x > xFirst + arrMobTemplate[templateId].rangeMove)
			{
				p1 = 1;
			}
			if (x < xFirst - arrMobTemplate[templateId].rangeMove)
			{
				p1 = 1;
			}
		}
		else if (p1 == 1)
		{
			if (arrMobTemplate[templateId].type != 0 && !isDontMove && !isIce && !isWind)
			{
				x += (xFirst - x) / 4;
				y += (yFirst - y) / 4;
			}
			if (Res.abs(xFirst - x) < 5 && Res.abs(yFirst - y) < 5)
			{
				status = 2;
				frameIndex = 0;
				p1 = 0;
				p2 = 0;
			}
		}
	}

	public static Mob get_Mob(int ID)
	{
		for (int num = GameScr.vMob.size() - 1; num >= 0; num--)
		{
			Mob mob = (Mob)GameScr.vMob.elementAt(num);
			if (mob != null && mob.mobId == ID)
			{
				return mob;
			}
		}
		return null;
	}

	public void updWalk_NewBoss()
	{
		if (arrMobTemplate[templateId].frameBossMove != null)
		{
			p1++;
			if (GameCanvas.gameTick % 2 == 0)
			{
				frameIndex++;
			}
			if (frameIndex >= arrMobTemplate[templateId].frameBossMove.Length)
			{
				frameIndex = 0;
			}
			frame = arrMobTemplate[templateId].frameBossMove[frameIndex];
			if (p1 > 10 + mobId % 10 && mSystem.currentTimeMillis() - (timeCurrent + timewait) >= 0)
			{
				status = 5;
				p1 = 0;
			}
		}
	}

	public void updAtk_NewBoss()
	{
		if (arrMobTemplate[templateId].frameBossAttack == null)
		{
			return;
		}
		if (p1 == 0)
		{
			int num = 0;
			int num2 = 0;
			if (typeAtt == 0)
			{
				num = cFocus.cx;
				num2 = cFocus.cy;
			}
			else if (typeAtt == 1)
			{
				num = bFocus.x;
				num2 = bFocus.y;
			}
			if (GameCanvas.gameTick % 2 == 0)
			{
				frameIndex++;
			}
			if (Res.abs(num - x) < 48 || Res.abs(num2 - y) < 10)
			{
				if (frameIndex >= arrMobTemplate[templateId].frameBossAttack[0].Length)
				{
					p1 = 1;
					frameIndex = 0;
				}
				frame = arrMobTemplate[templateId].frameBossAttack[0][frameIndex];
			}
			else
			{
				if (frameIndex >= arrMobTemplate[templateId].frameBossAttack[1].Length)
				{
					p1 = 1;
					frameIndex = 0;
				}
				frame = arrMobTemplate[templateId].frameBossAttack[1][frameIndex];
			}
		}
		else if (p1 == 1)
		{
			if (arrMobTemplate[templateId].type != 0 && !isDontMove && !isIce && !isWind)
			{
				x += (xFirst - x) / 4;
				y += (yFirst - y) / 4;
			}
			if (Res.abs(xFirst - x) < 5 && Res.abs(yFirst - y) < 5)
			{
				status = 2;
				frameIndex = 0;
				p1 = 0;
				p2 = 0;
			}
		}
	}

	public void paintTopMobNew(mGraphics g)
	{
		try
		{
			if (GameCanvas.gameTick % 2 == 0)
			{
				tt++;
				if (tt > getTemplate().frameBoss.Length - 1)
				{
					tt = 0;
				}
			}
			this.frame = tt;
			dir = Char.getMyChar().cdir;
			Frame frame = getTemplate().frameBoss[this.frame];
			for (int i = 0; i < frame.dx.Length; i++)
			{
				if (frame.onTop[i] == 0)
				{
					continue;
				}
				ImageInfo imgInfo = getTemplate().getImgInfo(frame.idImg[i]);
				int num = imgInfo.x0;
				int num2 = imgInfo.y0;
				int num3 = imgInfo.w;
				int num4 = imgInfo.h;
				int num5 = frame.dx[i];
				int num6 = frame.dy[i];
				if (num > getTemplate().imgs[0].getWidth())
				{
					num = 0;
				}
				if (num2 > getTemplate().imgs[0].getHeight())
				{
					num2 = 0;
				}
				if (num + num3 > getTemplate().imgs[0].getWidth())
				{
					num3 = getTemplate().imgs[0].getWidth() - num;
				}
				if (num2 + num4 > getTemplate().imgs[0].getHeight())
				{
					num4 = getTemplate().imgs[0].getHeight() - num2;
				}
				int num7 = ((frame.flip[i] == 1) ? 2 : 0);
				if (dir == 1)
				{
					if (num7 == 2)
					{
						num7 = 0;
						num5 += num3;
					}
					else
					{
						num7 = 2;
						num5 = -(num5 + num3);
					}
				}
				g.drawRegion(getTemplate().imgs[0], num, num2, num3, num4, num7, x + num5, y + num6, 0);
			}
		}
		catch (Exception)
		{
		}
	}

	public void paintBottomMobNew(mGraphics g)
	{
		try
		{
			Frame frame = getTemplate().frameBoss[this.frame];
			for (int i = 0; i < frame.dx.Length; i++)
			{
				if (frame.onTop[i] != 0)
				{
					continue;
				}
				ImageInfo imgInfo = getTemplate().getImgInfo(frame.idImg[i]);
				int num = imgInfo.x0;
				int num2 = imgInfo.y0;
				int num3 = imgInfo.w;
				int num4 = imgInfo.h;
				int num5 = frame.dx[i];
				int num6 = frame.dy[i];
				if (num > getTemplate().imgs[0].getWidth())
				{
					num = 0;
				}
				if (num2 > getTemplate().imgs[0].getHeight())
				{
					num2 = 0;
				}
				if (num + num3 > getTemplate().imgs[0].getWidth())
				{
					num3 = getTemplate().imgs[0].getWidth() - num;
				}
				if (num2 + num4 > getTemplate().imgs[0].getHeight())
				{
					num4 = getTemplate().imgs[0].getHeight() - num2;
				}
				int num7 = ((frame.flip[i] == 1) ? 2 : 0);
				if (dir == 1)
				{
					if (num7 == 2)
					{
						num7 = 0;
						num5 += num3;
					}
					else
					{
						num7 = 2;
						num5 = -(num5 + num3);
					}
				}
				g.drawRegion(getTemplate().imgs[0], num, num2, num3, num4, num7, x + num5, y + num6, 0);
			}
		}
		catch (Exception)
		{
		}
	}
}
