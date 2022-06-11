using System;

public class Item
{
	public const int TYPE_BODY_MIN = 0;

	public const int TYPE_BODY_MAX = 15;

	public const int TYPE_NON = 0;

	public const int TYPE_VUKHI = 1;

	public const int TYPE_AO = 2;

	public const int TYPE_LIEN = 3;

	public const int TYPE_GANGTAY = 4;

	public const int TYPE_NHAN = 5;

	public const int TYPE_QUAN = 6;

	public const int TYPE_NGOCBOI = 7;

	public const int TYPE_GIAY = 8;

	public const int TYPE_PHU = 9;

	public const int TYPE_THUNUOI = 10;

	public const int TYPE_MATNA = 11;

	public const int TYPE_AOCHOANG = 12;

	public const int TYPE_BAOTAY = 13;

	public const int TYPE_UNKNOW2 = 14;

	public const int TYPE_BIKIP = 15;

	public const int TYPE_HP = 16;

	public const int TYPE_MP = 17;

	public const int TYPE_EAT = 18;

	public const int TYPE_MONEY = 19;

	public const int TYPE_TUI_TIEN = 20;

	public const int TYPE_MEAT = 21;

	public const int TYPE_DRAGONBALL = 22;

	public const int TYPE_TASK_SAVE = 23;

	public const int TYPE_TASK_WAIT = 24;

	public const int TYPE_TASK = 25;

	public const int TYPE_CRYSTAL = 26;

	public const int TYPE_ORDER = 27;

	public const int TYPE_PROTECT = 28;

	public const int TYPE_MON0 = 29;

	public const int TYPE_MON1 = 30;

	public const int TYPE_MON2 = 31;

	public const int TYPE_MON3 = 32;

	public const int TYPE_MON4 = 33;

	public const int TYPE_NGOCKHAM = 34;

	public const sbyte UI_WEAPON = 2;

	public const sbyte UI_BAG = 3;

	public const sbyte UI_BOX = 4;

	public const sbyte UI_BODY = 5;

	public const sbyte UI_STACK = 6;

	public const sbyte UI_STACK_LOCK = 7;

	public const sbyte UI_GROCERY = 8;

	public const sbyte UI_GROCERY_LOCK = 9;

	public const sbyte UI_UPGRADE = 10;

	public const sbyte UI_UPPEARL = 11;

	public const sbyte UI_UPPEARL_LOCK = 12;

	public const sbyte UI_SPLIT = 13;

	public const sbyte UI_STORE = 14;

	public const sbyte UI_BOOK = 15;

	public const sbyte UI_LIEN = 16;

	public const sbyte UI_NHAN = 17;

	public const sbyte UI_NGOCBOI = 18;

	public const sbyte UI_PHU = 19;

	public const sbyte UI_NONNAM = 20;

	public const sbyte UI_NONNU = 21;

	public const sbyte UI_AONAM = 22;

	public const sbyte UI_AONU = 23;

	public const sbyte UI_GANGTAYNAM = 24;

	public const sbyte UI_GANGTAYNU = 25;

	public const sbyte UI_QUANNAM = 26;

	public const sbyte UI_QUANNU = 27;

	public const sbyte UI_GIAYNAM = 28;

	public const sbyte UI_GIAYNU = 29;

	public const sbyte UI_TRADE = 30;

	public const sbyte UI_UPGRADE_GOLD = 31;

	public const sbyte UI_FASHION = 32;

	public const sbyte UI_CONVERT = 33;

	public const sbyte UI_CLANSHOP = 34;

	public const sbyte UI_ELITES = 35;

	public const sbyte UI_AUCTION_SALE = 36;

	public const sbyte UI_AUCTION_BUY = 37;

	public const sbyte UI_LUCKY_SPIN = 38;

	public const sbyte UI_CLAN = 39;

	public const sbyte UI_AUTO = 40;

	public const sbyte UI_MON = 41;

	public const sbyte UI_NAP_GOOGLE = 42;

	public const sbyte UI_LUYEN_THACH = 43;

	public const sbyte UI_TINH_LUYEN_AO = 44;

	public const sbyte UI_TINH_LUYEN_THU = 45;

	public const sbyte UI_LUYEN_NGOC = 46;

	public const sbyte UI_KHAM_NGOC = 47;

	public const sbyte UI_GIAO_DO = 48;

	public const sbyte UI_GOT_NGOC = 49;

	public const sbyte UI_THAO_NGOC = 50;

	public const sbyte UI_SHOP_ONLINE = 51;

	public ItemTemplate template;

	public MyVector options;

	public int itemId;

	public int playerId;

	public int indexUI;

	public int quantity;

	public long expires;

	public bool isLock;

	public int sys;

	public int upgrade;

	public int buyCoin;

	public int buyCoinLock;

	public int buyGold;

	public int buyGoldLock;

	public int saleCoinLock;

	public int typeUI;

	public bool isExpires;

	public EffectCharPaint eff;

	public int indexEff;

	public Image img;

	public Item clone()
	{
		Item item = new Item();
		item.template = template;
		if (options != null)
		{
			item.options = new MyVector();
			for (int i = 0; i < options.size(); i++)
			{
				ItemOption itemOption = new ItemOption();
				itemOption.optionTemplate = ((ItemOption)options.elementAt(i)).optionTemplate;
				itemOption.param = ((ItemOption)options.elementAt(i)).param;
				item.options.addElement(itemOption);
			}
		}
		item.itemId = itemId;
		item.playerId = playerId;
		item.indexUI = indexUI;
		item.quantity = quantity;
		item.expires = expires;
		item.isLock = isLock;
		item.sys = sys;
		item.upgrade = upgrade;
		item.buyCoin = buyCoin;
		item.buyCoinLock = buyCoinLock;
		item.buyGold = buyGold;
		item.buyGoldLock = buyGoldLock;
		item.saleCoinLock = saleCoinLock;
		item.typeUI = typeUI;
		item.isExpires = isExpires;
		return item;
	}

	public Item viewNext(int up)
	{
		Item item = clone();
		item.isLock = true;
		int num = up - item.upgrade;
		if (num == 0)
		{
			return item;
		}
		item.upgrade = up;
		if (item.options != null)
		{
			for (int i = 0; i < item.options.size(); i++)
			{
				ItemOption itemOption = (ItemOption)item.options.elementAt(i);
				if (itemOption.optionTemplate.id == 6 || itemOption.optionTemplate.id == 7)
				{
					itemOption.param += (short)(15 * num);
				}
				else if (itemOption.optionTemplate.id == 8 || itemOption.optionTemplate.id == 9 || itemOption.optionTemplate.id == 19)
				{
					itemOption.param += (short)(10 * num);
				}
				else if (itemOption.optionTemplate.id == 10 || itemOption.optionTemplate.id == 11 || itemOption.optionTemplate.id == 12 || itemOption.optionTemplate.id == 13 || itemOption.optionTemplate.id == 14 || itemOption.optionTemplate.id == 15 || itemOption.optionTemplate.id == 17 || itemOption.optionTemplate.id == 18 || itemOption.optionTemplate.id == 20)
				{
					itemOption.param += (short)(5 * num);
				}
				else if (itemOption.optionTemplate.id == 21 || itemOption.optionTemplate.id == 22 || itemOption.optionTemplate.id == 23 || itemOption.optionTemplate.id == 24 || itemOption.optionTemplate.id == 25 || itemOption.optionTemplate.id == 26)
				{
					itemOption.param += (short)(150 * num);
				}
				else if (itemOption.optionTemplate.id == 16)
				{
					itemOption.param += (short)(3 * num);
				}
			}
		}
		return item;
	}

	public bool isTypeBody()
	{
		if (0 <= template.type && template.type <= 15)
		{
			return true;
		}
		return false;
	}

	public bool isTypeNgocKham()
	{
		if (template.type == 34)
		{
			return true;
		}
		return false;
	}

	public bool isTypeMounts()
	{
		if (29 <= template.type && template.type <= 33)
		{
			return true;
		}
		return false;
	}

	public string getLockString()
	{
		return (!isLock) ? mResources.NOLOCK : mResources.LOCKED;
	}

	public string getUpgradeString()
	{
		if (template.type == 12)
		{
			return mResources.SPECUPGRADE;
		}
		if (template.level < 10 || template.type >= 10)
		{
			return mResources.NOTUPGRADE;
		}
		if (upgrade == 0)
		{
			return mResources.NOUPGRADE;
		}
		return null;
	}

	public string getExpiresString()
	{
		if (expires <= 0)
		{
			return mResources.FOREVER;
		}
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Add(new TimeSpan(expires * 10000)).ToLocalTime();
		int hour = dateTime.Hour;
		int minute = dateTime.Minute;
		int day = dateTime.Day;
		int month = dateTime.Month;
		int year = dateTime.Year;
		return day + "/" + month + "/" + year + " " + hour + "h" + minute + "'";
	}

	public string getExpiresShopString()
	{
		if (expires <= 0)
		{
			return mResources.FOREVER;
		}
		if (expires / 1000 >= 2592000)
		{
			return expires / 1000 / 2592000 + " " + mResources.MONTH;
		}
		if (expires / 1000 >= 604800)
		{
			return expires / 1000 / 604800 + " " + mResources.WEEK;
		}
		if (expires / 1000 >= 86400)
		{
			return expires / 1000 / 86400 + " " + mResources.DAY;
		}
		if (expires / 1000 >= 3600)
		{
			return expires / 1000 / 3600 + " " + mResources.HOUR;
		}
		if (expires / 1000 >= 60)
		{
			return expires / 1000 / 60 + " " + mResources.MINUTE;
		}
		return string.Empty;
	}

	public void clearExpire()
	{
		if (!isTypeMounts())
		{
			expires = 0L;
		}
	}

	public bool isTypeUIMe()
	{
		if (typeUI == 5 || typeUI == 3 || typeUI == 4 || typeUI == 39)
		{
			return true;
		}
		return false;
	}

	public bool isTypeUIShopView()
	{
		if (isTypeUIShop())
		{
			return true;
		}
		if (isTypeUIStore() || isTypeUIBook() || isTypeUIFashion() || isTypeUIClanShop())
		{
			return true;
		}
		return false;
	}

	public bool isTypeUIShop()
	{
		if (typeUI == 20 || typeUI == 21 || typeUI == 22 || typeUI == 23 || typeUI == 24 || typeUI == 25 || typeUI == 26 || typeUI == 27 || typeUI == 28 || typeUI == 29 || typeUI == 16 || typeUI == 17 || typeUI == 18 || typeUI == 19 || typeUI == 2 || typeUI == 6 || typeUI == 8 || typeUI == 34)
		{
			return true;
		}
		return false;
	}

	public bool isTypeUIShopLock()
	{
		if (typeUI == 7 || typeUI == 9)
		{
			return true;
		}
		return false;
	}

	public bool isTypeUIStore()
	{
		if (typeUI == 14)
		{
			return true;
		}
		return false;
	}

	public bool isTypeUIBook()
	{
		if (typeUI == 15)
		{
			return true;
		}
		return false;
	}

	public bool isTypeUIFashion()
	{
		if (typeUI == 32)
		{
			return true;
		}
		return false;
	}

	public bool isTypeUIClanShop()
	{
		if (typeUI == 34)
		{
			return true;
		}
		return false;
	}

	public bool isTypeUIClan()
	{
		if (typeUI == 39)
		{
			return true;
		}
		return false;
	}

	public bool isUpMax()
	{
		if (getUpMax() == upgrade)
		{
			return true;
		}
		return false;
	}

	public int getUpMax()
	{
		if (template.level >= 1 && template.level < 20)
		{
			return 4;
		}
		if (template.level >= 20 && template.level < 40)
		{
			return 8;
		}
		if (template.level >= 40 && template.level < 50)
		{
			return 12;
		}
		if (template.level >= 50 && template.level < 60)
		{
			return 14;
		}
		return 16;
	}

	public bool isTypeClothe()
	{
		if (template.type == 0 || template.type == 2 || template.type == 4 || template.type == 6 || template.type == 8)
		{
			return true;
		}
		return false;
	}

	public bool isTypeAdorn()
	{
		if (template.type == 3 || template.type == 5 || template.type == 7 || template.type == 9)
		{
			return true;
		}
		return false;
	}

	public bool isTypeStack()
	{
		if (expires == -1 && (template.type == 16 || template.type == 17))
		{
			return true;
		}
		return false;
	}

	public bool isTypeCrystal()
	{
		if (template.type == 26)
		{
			return true;
		}
		return false;
	}

	public bool isTypeWeapon()
	{
		if (template.type == 1)
		{
			return true;
		}
		return false;
	}

	public bool isItemClass0()
	{
		if (itemId == 194 || itemId == 94 || itemId == 95 || itemId == 96 || itemId == 97 || itemId == 98)
		{
			return true;
		}
		return false;
	}

	public bool isItemClass1()
	{
		if (itemId == 194 || itemId == 94 || itemId == 95 || itemId == 96 || itemId == 97 || itemId == 98)
		{
			return true;
		}
		return false;
	}

	public bool isItemClass2()
	{
		if (itemId == 99 || itemId == 100 || itemId == 101 || itemId == 102 || itemId == 103)
		{
			return true;
		}
		return false;
	}

	public bool isItemClass3()
	{
		if (itemId == 104 || itemId == 105 || itemId == 106 || itemId == 107 || itemId == 108)
		{
			return true;
		}
		return false;
	}

	public bool isItemClass4()
	{
		if (itemId == 109 || itemId == 110 || itemId == 111 || itemId == 112 || itemId == 113)
		{
			return true;
		}
		return false;
	}

	public bool isItemClass5()
	{
		if (itemId == 114 || itemId == 115 || itemId == 116 || itemId == 117 || itemId == 118)
		{
			return true;
		}
		return false;
	}

	public bool isItemClass6()
	{
		if (itemId == 119 || itemId == 120 || itemId == 121 || itemId == 122 || itemId == 123)
		{
			return true;
		}
		return false;
	}
}
