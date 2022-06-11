using System;
using System.IO;
using UnityEngine;

public class TileMap
{
	public class PosWater
	{
		public int x = -1;

		public int y = -1;
	}

	public static int T_EMPTY = 0;

	public static int T_TOP = 2;

	public static int T_LEFT = 4;

	public static int T_RIGHT = 8;

	public static int T_TREE = 16;

	public static int T_WATERFALL = 32;

	public static int T_WATERFLOW = 64;

	public static int T_TOPFALL = 128;

	public static int T_OUTSIDE = 256;

	public static int T_DOWN1PIXEL = 512;

	public static int T_BRIDGE = 1024;

	public static int T_UNDERWATER = 2048;

	public static int T_SOLIDGROUND = 4096;

	public static int T_BOTTOM = 8192;

	public static int T_DIE = 16384;

	public static int T_HEBI = 32768;

	public static int T_BANG = 65536;

	public static int T_JUM8 = 131072;

	public static int T_NT0 = 262144;

	public static int T_NT1 = 524288;

	public static int tmw;

	public static int tmh;

	public static int pxw;

	public static int pxh;

	public static int tileID;

	public static char[] maps;

	public static int[] types;

	public static Image imgTileSmall;

	public static Image imgMiniMap;

	public static Image imgWaterfall;

	public static Image imgTopWaterfall;

	public static Image imgWaterflow;

	public static Image imgLeaf;

	public static Image imgflowRiver;

	public static sbyte size = 24;

	private static int bx;

	private static int dbx;

	private static int fx;

	private static int dfx;

	public static string[] instruction;

	public static int[] iX;

	public static int[] iY;

	public static int[] iW;

	public static int iCount;

	public static string mapName1 = null;

	public static string mapName = string.Empty;

	public static sbyte versionMap = 1;

	public static sbyte zoneID;

	public static sbyte bgID;

	public static sbyte typeMap;

	public static short mapID;

	public static short oldMapID;

	public static int cmtoYmini;

	public static int cmyMini;

	public static int cmdyMini;

	public static int cmvyMini;

	public static int cmtoXMini;

	public static int cmxMini;

	public static int cmdxMini;

	public static int cmvxMini;

	public static int wMiniMap;

	public static int hMiniMap;

	public static int posMiniMapX;

	public static int posMiniMapY;

	public static long timeTranMini;

	public static MyVector vGo = new MyVector();

	public static string[] mapNames;

	public static sbyte MAP_NORMAL = 0;

	public static sbyte MAP_DAUTRUONG = 1;

	public static sbyte MAP_PB = 2;

	public static sbyte MAP_CHIENTRUONG = 3;

	public static mHashtable locationStand = new mHashtable();

	public static mHashtable itemMap = new mHashtable();

	private static int defaultSolidTile;

	public static int totalTileLoad = 0;

	public static MyVector totalWater = new MyVector();

	public static int[] totalTile = new int[4] { 120, 141, 143, 103 };

	public static int sizeMiniMap = 2;

	public static int gssx;

	public static int gssxe;

	public static int gssy;

	public static int gssye;

	public static int countx;

	public static int county;

	private static int[] colorMini = new int[2] { 5257738, 8807192 };

	public static Image[] imgTileMap = new Image[150];

	public static Color[][][] colorMiniMap = new Color[4][][];

	public static Color[] blackAr;

	public static int miniSize = 2;

	public static int saveTileId = -1;

	public static bool isStopping;

	public static float volume;

	public static void setPosMiniMap(int x, int y, int w, int h)
	{
		wMiniMap = w;
		hMiniMap = h;
		posMiniMapX = x;
		posMiniMapY = y;
	}

	public static void updateMiniMap()
	{
		cmtoXMini = Char.getMyChar().cx / 12;
		cmtoYmini = Char.getMyChar().cy / 12;
		if (cmtoXMini > tmw * sizeMiniMap - wMiniMap / 2)
		{
			cmtoXMini = tmw * sizeMiniMap - wMiniMap;
		}
		else if (cmtoXMini < wMiniMap / 2)
		{
			cmtoXMini = 0;
		}
		else
		{
			cmtoXMini -= wMiniMap / 2;
		}
		if (cmtoYmini < hMiniMap / 2)
		{
			cmtoYmini = 0;
		}
		else
		{
			cmtoYmini -= hMiniMap / 2;
		}
		if (cmtoYmini > tmh * sizeMiniMap - hMiniMap)
		{
			cmtoYmini = tmh * sizeMiniMap - hMiniMap;
		}
	}

	public static void updateCmMiniMap()
	{
		if (tmw * sizeMiniMap >= wMiniMap || tmh * sizeMiniMap >= hMiniMap)
		{
			if (cmyMini != cmtoYmini)
			{
				cmvyMini = cmtoYmini - cmyMini << 2;
				cmdyMini += cmvyMini;
				cmyMini += cmdyMini >> 4;
				cmdyMini &= 15;
			}
			if (cmxMini != cmtoXMini)
			{
				cmvxMini = cmtoXMini - cmxMini << 2;
				cmdxMini += cmvxMini;
				cmxMini += cmdxMini >> 4;
				cmdxMini &= 15;
			}
		}
	}

	public static void freeTilemap()
	{
	}

	public static void loadTileImage()
	{
		if (imgWaterfall == null)
		{
			imgWaterfall = GameCanvas.loadImage("/t/wtf");
		}
		if (imgTopWaterfall == null)
		{
			imgTopWaterfall = GameCanvas.loadImage("/t/twtf");
		}
		if (imgWaterflow == null)
		{
			imgWaterflow = GameCanvas.loadImage("/t/wts");
		}
		if (imgflowRiver == null)
		{
			imgflowRiver = GameCanvas.loadImage("/t/wts1");
		}
	}

	public static void resetDataImg()
	{
		if (imgTileMap != null)
		{
			mGraphics.cachedTextures.Clear();
			for (int i = 0; i < imgTileMap.Length; i++)
			{
				if (imgTileMap[i] != null)
				{
					imgTileMap[i].texture = null;
					imgTileMap[i] = null;
				}
			}
			Resources.UnloadUnusedAssets();
			GC.Collect();
		}
		else
		{
			imgTileMap = new Image[150];
		}
	}

	public static void loadTileUse(int id)
	{
		if (id >= 0 && imgTileMap[id] == null)
		{
			if (mGraphics.zoomLevel == 1)
			{
				imgTileMap[id] = GameCanvas.loadImage("/t/tile" + tileID + "/" + id);
			}
			else
			{
				imgTileMap[id] = GameCanvas.loadImage("/t/tile" + tileID + "/" + (id + 1));
			}
			totalTileLoad++;
		}
	}

	public static void setPosWater()
	{
		totalWater = new MyVector();
		for (int i = 0; i < tmw; i++)
		{
			for (int j = 0; j < tmh; j++)
			{
				int num = maps[j * tmw + i] - 1;
				if ((tileTypeAt(i, j) & T_OUTSIDE) != T_OUTSIDE && (tileTypeAt(i, j) & T_WATERFALL) == T_WATERFALL)
				{
					putPosIntoVector(i * size, j * size);
				}
			}
		}
	}

	public static bool getPosVsMainChar()
	{
		for (int i = 0; i < totalWater.size(); i++)
		{
			PosWater posWater = (PosWater)totalWater.elementAt(i);
			int num = posWater.x - GameCanvas.w;
			int num2 = posWater.x + GameCanvas.w;
			int num3 = posWater.y - GameCanvas.h;
			int num4 = posWater.y + GameCanvas.h;
			if (Char.getMyChar().cx >= num && Char.getMyChar().cx <= num2 && Char.getMyChar().cy >= num3 && Char.getMyChar().cy <= num4 && posWater.x <= GameScr.cmx + GameCanvas.w && posWater.x >= GameScr.cmx && posWater.y >= GameScr.cmy && posWater.y <= GameScr.cmy + GameCanvas.h)
			{
				return true;
			}
		}
		return false;
	}

	public static void putPosIntoVector(int x, int y)
	{
		PosWater posWater = new PosWater();
		posWater.x = x;
		posWater.y = y;
		totalWater.addElement(posWater);
	}

	public static bool isStand(int index)
	{
		if (locationStand != null)
		{
			return locationStand.get(index + string.Empty) != null;
		}
		return false;
	}

	public static void loadMap(int tileId)
	{
		totalTileLoad = 0;
		resetDataImg();
		pxh = tmh * size;
		pxw = tmw * size;
		try
		{
			for (int i = 0; i < tmw * tmh; i++)
			{
				if (isStand(i))
				{
					types[i] |= T_TOP;
				}
				loadTileUse(maps[i] - 1);
				if (tileId == 4)
				{
					if (maps[i] == '\u0001' || maps[i] == '\u0002' || maps[i] == '\u0003' || maps[i] == '\u0004' || maps[i] == '\u0005' || maps[i] == '\u0006' || maps[i] == '\t' || maps[i] == '\n' || maps[i] == 'O' || maps[i] == 'P' || maps[i] == '\r' || maps[i] == '\u000e' || maps[i] == '+' || maps[i] == ',' || maps[i] == '-' || maps[i] == '2')
					{
						types[i] |= T_TOP;
					}
					if (maps[i] == '\t' || maps[i] == '\v')
					{
						types[i] |= T_LEFT;
					}
					if (maps[i] == '\n' || maps[i] == '\f')
					{
						types[i] |= T_RIGHT;
					}
					if (maps[i] == '\r' || maps[i] == '\u000e')
					{
						types[i] |= T_BRIDGE;
					}
					if (maps[i] == 'L' || maps[i] == 'M')
					{
						types[i] |= T_WATERFLOW;
						if (maps[i] == 'N')
						{
							types[i] |= T_SOLIDGROUND;
						}
					}
				}
				if (tileId == 1)
				{
					if (maps[i] == '\u0016')
					{
						defaultSolidTile = maps[i] - 1;
					}
					if (maps[i] == '\u0001' || maps[i] == '\u0002' || maps[i] == '\u0003' || maps[i] == '\u0004' || maps[i] == '\u0005' || maps[i] == '\u0006' || maps[i] == '\a' || maps[i] == '$' || maps[i] == '%' || maps[i] == '6' || maps[i] == '[' || maps[i] == '\\' || maps[i] == ']' || maps[i] == '^' || maps[i] == 'I' || maps[i] == 'J' || maps[i] == 'a' || maps[i] == 'b' || maps[i] == 't' || maps[i] == 'u' || maps[i] == 'v' || maps[i] == 'x' || maps[i] == '=')
					{
						types[i] |= T_TOP;
					}
					if (maps[i] == '\u0002' || maps[i] == '\u0003' || maps[i] == '\u0004' || maps[i] == '\u0005' || maps[i] == '\u0006' || maps[i] == '\u0014' || maps[i] == '\u0015' || maps[i] == '\u0016' || maps[i] == '\u0017' || maps[i] == '$' || maps[i] == '%' || maps[i] == '&' || maps[i] == '\'' || maps[i] == '=')
					{
						types[i] |= T_SOLIDGROUND;
					}
					if (maps[i] == '\b' || maps[i] == '\t' || maps[i] == '\n' || maps[i] == '\f' || maps[i] == '\r' || maps[i] == '\u000e' || maps[i] == '\u001e')
					{
						types[i] |= T_TREE;
					}
					if (maps[i] == '\u0011')
					{
						types[i] |= T_WATERFALL;
					}
					if (maps[i] == '\u0012')
					{
						types[i] |= T_TOPFALL;
					}
					if (maps[i] == '%' || maps[i] == '&' || maps[i] == '=')
					{
						types[i] |= T_LEFT;
					}
					if (maps[i] == '$' || maps[i] == '\'' || maps[i] == '=')
					{
						types[i] |= T_RIGHT;
					}
					if (maps[i] == '\u0013')
					{
						types[i] |= T_WATERFLOW;
						if ((types[i - tmw] & T_SOLIDGROUND) == T_SOLIDGROUND)
						{
							types[i] |= T_SOLIDGROUND;
						}
					}
					if (maps[i] == '#')
					{
						types[i] |= T_UNDERWATER;
					}
					if (maps[i] == '\a')
					{
						types[i] |= T_BRIDGE;
					}
					if (maps[i] == ' ' || maps[i] == '!' || maps[i] == '"')
					{
						types[i] |= T_OUTSIDE;
					}
				}
				if (tileId == 2)
				{
					if (maps[i] == '\u0016' || maps[i] == 'g' || maps[i] == 'o')
					{
						defaultSolidTile = maps[i] - 1;
					}
					if (maps[i] == '\u0001' || maps[i] == '\u0002' || maps[i] == '\u0003' || maps[i] == '\u0004' || maps[i] == '\u0005' || maps[i] == '\u0006' || maps[i] == '\a' || maps[i] == '$' || maps[i] == '%' || maps[i] == '6' || maps[i] == '=' || maps[i] == 'I' || maps[i] == 'L' || maps[i] == 'M' || maps[i] == 'N' || maps[i] == 'O' || maps[i] == 'R' || maps[i] == 'S' || maps[i] == 'b' || maps[i] == 'c' || maps[i] == 'd' || maps[i] == 'f' || maps[i] == 'g' || maps[i] == 'l' || maps[i] == 'm' || maps[i] == 'n' || maps[i] == 'p' || maps[i] == 'q' || maps[i] == 't' || maps[i] == 'u' || maps[i] == '}' || maps[i] == '~' || maps[i] == '\u007f' || maps[i] == '\u0081' || maps[i] == '\u0082')
					{
						types[i] |= T_TOP;
					}
					if (maps[i] == '\u0001' || maps[i] == '\u0003' || maps[i] == '\u0004' || maps[i] == '\u0005' || maps[i] == '\u0006' || maps[i] == '\u0014' || maps[i] == '\u0015' || maps[i] == '\u0016' || maps[i] == '\u0017' || maps[i] == '$' || maps[i] == '%' || maps[i] == '&' || maps[i] == '\'' || maps[i] == '7' || maps[i] == 'm' || maps[i] == 'o' || maps[i] == 'p' || maps[i] == 'q' || maps[i] == 'r' || maps[i] == 's' || maps[i] == 't' || maps[i] == '\u007f' || maps[i] == '\u0081' || maps[i] == '\u0082')
					{
						types[i] |= T_SOLIDGROUND;
					}
					if (maps[i] == '\b' || maps[i] == '\t' || maps[i] == '\n' || maps[i] == '\f' || maps[i] == '\r' || maps[i] == '\u000e' || maps[i] == '\u001e' || maps[i] == '\u0087')
					{
						types[i] |= T_TREE;
					}
					if (maps[i] == '\u0011')
					{
						types[i] |= T_WATERFALL;
					}
					if (maps[i] == '\u0012')
					{
						types[i] |= T_TOPFALL;
					}
					if (maps[i] == '=' || maps[i] == '%' || maps[i] == '&' || maps[i] == '\u007f' || maps[i] == '\u0082' || maps[i] == '\u0083')
					{
						types[i] |= T_LEFT;
					}
					if (maps[i] == '=' || maps[i] == '$' || maps[i] == '\'' || maps[i] == '\u007f' || maps[i] == '\u0081' || maps[i] == '\u0084')
					{
						types[i] |= T_RIGHT;
					}
					if (maps[i] == '\u0013')
					{
						types[i] |= T_WATERFLOW;
						if ((types[i - tmw] & T_SOLIDGROUND) == T_SOLIDGROUND)
						{
							types[i] |= T_SOLIDGROUND;
						}
					}
					if (maps[i] == '\u0086')
					{
						types[i] |= T_WATERFLOW;
						if ((types[i - tmw] & T_SOLIDGROUND) == T_SOLIDGROUND)
						{
							types[i] |= T_SOLIDGROUND;
						}
					}
					if (maps[i] == '#')
					{
						types[i] |= T_UNDERWATER;
					}
					if (maps[i] == '\a')
					{
						types[i] |= T_BRIDGE;
					}
					if (maps[i] == ' ' || maps[i] == '!' || maps[i] == '"')
					{
						types[i] |= T_OUTSIDE;
					}
					if (maps[i] == '=' || maps[i] == '\u007f')
					{
						types[i] |= T_BOTTOM;
					}
				}
				if (tileId != 3)
				{
					continue;
				}
				if (maps[i] == '\f' || maps[i] == '3' || maps[i] == 'X' || maps[i] == 't' || maps[i] == '\u0080')
				{
					defaultSolidTile = maps[i] - 1;
				}
				if (maps[i] == 'm' || maps[i] == 'n')
				{
					defaultSolidTile = maps[i];
				}
				if (maps[i] == '\u0001' || maps[i] == '\u0002' || maps[i] == '\u0003' || maps[i] == '\u0004' || maps[i] == '\u0005' || maps[i] == '\u0006' || maps[i] == '\a' || maps[i] == '\v' || maps[i] == '\u000e' || maps[i] == '\u0011' || maps[i] == '+' || maps[i] == '3' || maps[i] == '?' || maps[i] == 'A' || maps[i] == 'C' || maps[i] == 'D' || maps[i] == 'G' || maps[i] == 'H' || maps[i] == 'S' || maps[i] == 'T' || maps[i] == 'U' || maps[i] == 'W' || maps[i] == '[' || maps[i] == '^' || maps[i] == 'a' || maps[i] == 'b' || maps[i] == 'j' || maps[i] == 'k' || maps[i] == 'o' || maps[i] == 'q' || maps[i] == 'u' || maps[i] == 'v' || maps[i] == 'w' || maps[i] == '}' || maps[i] == '~' || maps[i] == '\u0081' || maps[i] == '\u0082' || maps[i] == '\u0083' || maps[i] == '\u0085' || maps[i] == '\u0088' || maps[i] == '\u008a' || maps[i] == '\u008b' || maps[i] == '\u008e')
				{
					types[i] |= T_TOP;
				}
				if (maps[i] == '|' || maps[i] == 't' || maps[i] == '{' || maps[i] == ',' || maps[i] == '\f' || maps[i] == '\u000f' || maps[i] == '\u0010' || maps[i] == '-' || maps[i] == '\n' || maps[i] == '\t')
				{
					types[i] |= T_SOLIDGROUND;
				}
				if (maps[i] == '\u0017')
				{
					types[i] |= T_WATERFALL;
				}
				if (maps[i] == '\u0018')
				{
					types[i] |= T_TOPFALL;
				}
				if (maps[i] == '\u0006' || maps[i] == '\u000f' || maps[i] == '3' || maps[i] == '_' || maps[i] == 'a' || maps[i] == 'j' || maps[i] == 'o' || maps[i] == '{' || maps[i] == '}' || maps[i] == '\u008a' || maps[i] == '\u008c')
				{
					types[i] |= T_LEFT;
				}
				if (maps[i] == '\a' || maps[i] == '\u0010' || maps[i] == '3' || maps[i] == '`' || maps[i] == 'b' || maps[i] == 'k' || maps[i] == 'o' || maps[i] == '|' || maps[i] == '~' || maps[i] == '\u008b' || maps[i] == '\u008d')
				{
					types[i] |= T_RIGHT;
				}
				if (maps[i] == '\u0019')
				{
					types[i] |= T_WATERFLOW;
					if ((types[i - tmw] & T_SOLIDGROUND) == T_SOLIDGROUND)
					{
						types[i] |= T_SOLIDGROUND;
					}
				}
				if (maps[i] == '"')
				{
					types[i] |= T_UNDERWATER;
				}
				if (maps[i] == '\u0011')
				{
					types[i] |= T_BRIDGE;
				}
				if (maps[i] == '!' || maps[i] == 'g' || maps[i] == 'h' || maps[i] == 'i' || maps[i] == '\u001a' || maps[i] == '!')
				{
					types[i] |= T_OUTSIDE;
				}
				if (maps[i] == '3' || maps[i] == 'o' || maps[i] == 'D')
				{
					types[i] |= T_BOTTOM;
				}
				if (maps[i] == 'R' || maps[i] == 'n' || maps[i] == '\u008f')
				{
					types[i] |= T_DIE;
				}
				if (maps[i] == 'q')
				{
					types[i] |= T_BANG;
				}
				if (maps[i] == '\u008e')
				{
					types[i] |= T_HEBI;
				}
				if (maps[i] == '(' || maps[i] == ')')
				{
					types[i] |= T_JUM8;
				}
				if (maps[i] == 'n')
				{
					types[i] |= T_NT0;
				}
				if (maps[i] == '\u008f')
				{
					types[i] |= T_NT1;
				}
			}
			if (imgMiniMap != null)
			{
				imgMiniMap.texture = null;
				imgMiniMap = null;
				Resources.UnloadUnusedAssets();
				GC.Collect();
			}
			loadMiniMap();
			if (!GameCanvas.lowGraphic && !Main.isIpod && mGraphics.zoomLevel != 1)
			{
				if (mapID == 0 || mapID <= 4 || (mapID >= 16 && mapID <= 18) || (mapID >= 24 && mapID <= 27) || mapID == 22 || mapID == 33 || mapID == 34 || mapID == 38 || mapID == 57 || mapID == 58 || mapID == 60 || mapID == 68 || (mapID >= 70 && mapID <= 75) || mapID == 81)
				{
					Effect2.vAnimateEffect.addElement(new AnimateEffect(1, isStart: true, 10, 200));
				}
				if ((mapID >= 39 && mapID <= 44) || (mapID >= 46 && mapID <= 48) || mapID == 56 || (mapID >= 62 && mapID <= 65))
				{
					Effect2.vAnimateEffect.addElement(new AnimateEffect(3, isStart: true, Res.random(150, 200), 200));
				}
			}
			setPosWater();
		}
		catch (Exception ex)
		{
			Out.println("Error Load Map>>>>>>>>>>>>>>>>>>>>>.");
			Debug.Log(ex.Message + ex.StackTrace);
			GameMidlet.instance.exit();
		}
	}

	public static void loadColorMiniMap(int tileId)
	{
		if (colorMiniMap[tileId - 1] == null)
		{
			Image[] array = new Image[totalTile[tileId - 1]];
			colorMiniMap[tileId - 1] = new Color[totalTile[tileId - 1]][];
			for (int i = 0; i < totalTile[tileId - 1]; i++)
			{
				array[i] = GameCanvas.loadImage("/t/mini" + tileId + "/" + (i + 1));
				colorMiniMap[tileId - 1][i] = array[i].texture.GetPixels();
				array[i].texture = null;
				array[i] = null;
			}
			Resources.UnloadUnusedAssets();
			GC.Collect();
		}
	}

	public static void loadMiniMap()
	{
		loadColorMiniMap(tileID);
		imgMiniMap = Image.createImage(tmw * sizeMiniMap * mGraphics.zoomLevel, tmh * sizeMiniMap * mGraphics.zoomLevel);
		for (int i = 0; i < tmw; i++)
		{
			for (int j = 0; j < tmh; j++)
			{
				int num = maps[j * tmw + i] - 1;
				if (num != -1 && num < colorMiniMap[tileID - 1].Length && num >= 0)
				{
					imgMiniMap.texture.SetPixels(i * sizeMiniMap * mGraphics.zoomLevel, (tmh - 1 - j) * sizeMiniMap * mGraphics.zoomLevel, sizeMiniMap * mGraphics.zoomLevel, sizeMiniMap * mGraphics.zoomLevel, colorMiniMap[tileID - 1][num]);
				}
				else
				{
					imgMiniMap.texture.SetPixels(i * sizeMiniMap * mGraphics.zoomLevel, (tmh - 1 - j) * sizeMiniMap * mGraphics.zoomLevel, sizeMiniMap * mGraphics.zoomLevel, sizeMiniMap * mGraphics.zoomLevel, blackAr);
				}
			}
		}
		imgMiniMap.texture.Apply();
	}

	public static void paintTilemapLOW(mGraphics g)
	{
		for (int i = GameScr.gssx; i < GameScr.gssxe; i++)
		{
			for (int j = GameScr.gssy; j < GameScr.gssye; j++)
			{
				int num = maps[j * tmw + i] - 1;
				if (num != -1)
				{
					g.drawImage(imgTileMap[num], i * size, j * size, 0);
				}
				if ((tileTypeAt(i, j) & T_WATERFALL) == T_WATERFALL)
				{
					g.drawRegion(imgWaterfall, 0, 24 * (GameCanvas.gameTick % 4), 24, 24, 0, i * size, j * size, 0);
				}
				else if ((tileTypeAt(i, j) & T_WATERFLOW) == T_WATERFLOW)
				{
					if ((tileTypeAt(i, j - 1) & T_WATERFALL) == T_WATERFALL)
					{
						g.drawRegion(imgWaterfall, 0, 24 * (GameCanvas.gameTick % 4), 24, 24, 0, i * size, j * size, 0);
					}
					else if ((tileTypeAt(i, j - 1) & T_SOLIDGROUND) == T_SOLIDGROUND)
					{
						g.drawImage(imgTileMap[21], i * size, j * size, 0);
					}
					g.drawRegion(imgWaterflow, 0, (GameCanvas.gameTick % 8 >> 2) * 24, 24, 24, 0, i * size, j * size, 0);
				}
				if ((tileTypeAt(i, j) & T_UNDERWATER) == T_UNDERWATER)
				{
					if ((tileTypeAt(i, j - 1) & T_WATERFALL) == T_WATERFALL)
					{
						g.drawRegion(imgWaterfall, 0, 24 * (GameCanvas.gameTick % 4), 24, 24, 0, i * size, j * size, 0);
					}
					else if ((tileTypeAt(i, j - 1) & T_SOLIDGROUND) == T_SOLIDGROUND)
					{
						g.drawImage(imgTileMap[21], i * size, j * size, 0);
					}
					g.drawImage(imgTileMap[maps[j * tmw + i] - 1], i * size, j * size, 0);
				}
			}
		}
	}

	public static void paintTilemap(mGraphics g)
	{
		try
		{
			for (int i = GameScr.gssx; i < GameScr.gssxe; i++)
			{
				for (int j = GameScr.gssy; j < GameScr.gssye; j++)
				{
					int num = maps[j * tmw + i] - 1;
					if ((tileTypeAt(i, j) & T_OUTSIDE) == T_OUTSIDE)
					{
						continue;
					}
					if (tileID == 4 && (tileTypeAt(i, j) & T_WATERFLOW) == T_WATERFLOW)
					{
						int num2 = j - 1;
						num = maps[num2 * tmw + i] - 1;
						if (num == 15)
						{
							num = 17;
							g.drawImage(imgTileMap[num], i * size, j * size, 0);
							continue;
						}
						if (num == 5)
						{
							num = 7;
							g.drawImage(imgTileMap[num], i * size, j * size, 0);
							continue;
						}
						if (num == 18 || num == 22 || num == 15)
						{
							num = 17;
							g.drawImage(imgTileMap[num], i * size, j * size, 0);
							continue;
						}
						if (num == 44 || num == 52 || num == 51)
						{
							num = 56;
							g.drawImage(imgTileMap[num], i * size, j * size, 0);
							continue;
						}
						if (num == 24 || num == 23 || num == 20 || num == 21 || num == 19 || num == 12 || num == 13)
						{
							continue;
						}
						if (num != -1)
						{
							g.drawImage(imgTileMap[num], i * size, j * size, 0);
						}
						else if (num == -1)
						{
							continue;
						}
					}
					if (tileID == 1)
					{
						if ((tileTypeAt(i, j) & T_WATERFALL) == T_WATERFALL)
						{
							g.drawRegion(imgWaterfall, 0, 24 * (GameCanvas.gameTick % 4), 24, 24, 0, i * size, j * size, 0);
							continue;
						}
						if ((tileTypeAt(i, j) & T_WATERFLOW) == T_WATERFLOW || (tileTypeAt(i, j) & T_UNDERWATER) == T_UNDERWATER)
						{
							if ((tileTypeAt(i, j - 1) & T_WATERFALL) == T_WATERFALL)
							{
								g.drawRegion(imgWaterfall, 0, 24 * (GameCanvas.gameTick % 4), 24, 24, 0, i * size, j * size, 0);
								continue;
							}
							if ((tileTypeAt(i, j - 1) & T_SOLIDGROUND) == T_SOLIDGROUND)
							{
								g.drawImage(imgTileMap[21], i * size, j * size, 0);
								continue;
							}
						}
					}
					if (tileID == 2)
					{
						if ((tileTypeAt(i, j) & T_WATERFALL) == T_WATERFALL)
						{
							g.drawRegion(imgWaterfall, 0, 24 * (GameCanvas.gameTick % 8 >> 1), 24, 24, 0, i * size, j * size, 0);
							continue;
						}
						switch (num)
						{
						case 17:
							g.drawRegion(imgTopWaterfall, 0, 24 * (GameCanvas.gameTick % 8 >> 1), 24, 24, 0, i * size, j * size, 0);
							continue;
						case 133:
							g.drawImage(imgTileMap[132], i * size, j * size, 0);
							continue;
						}
						if ((tileTypeAt(i, j) & T_WATERFLOW) == T_WATERFLOW || (tileTypeAt(i, j) & T_UNDERWATER) == T_UNDERWATER)
						{
							if ((tileTypeAt(i, j - 1) & T_WATERFALL) == T_WATERFALL)
							{
								g.drawRegion(imgWaterfall, 0, 24 * (GameCanvas.gameTick % 4), 24, 24, 0, i * size, j * size, 0);
								continue;
							}
							if ((tileTypeAt(i, j - 1) & T_SOLIDGROUND) == T_SOLIDGROUND)
							{
								int num3 = tileAt(i, j - 1);
								if (num3 == 55)
								{
									num3 = 54;
								}
								else if (num3 != 19 && num3 != 35)
								{
									num3 = ((num3 >= 40) ? 110 : 21);
								}
								else
								{
									num3 = tileAt(i, j - 2);
									if (num3 == 55)
									{
										num3 = 54;
									}
									else if (num3 < 40)
									{
										num3 = 21;
									}
								}
								g.drawImage(imgTileMap[num3], i * size, j * size, 0);
								continue;
							}
						}
					}
					if (tileID == 3)
					{
						if ((tileTypeAt(i, j) & T_WATERFALL) == T_WATERFALL)
						{
							g.drawRegion(imgWaterfall, 0, 24 * (GameCanvas.gameTick % 8 >> 1), 24, 24, 0, i * size, j * size, 0);
							continue;
						}
						if (num == 23)
						{
							g.drawRegion(imgTopWaterfall, 0, 24 * (GameCanvas.gameTick % 8 >> 1), 24, 24, 0, i * size, j * size, 0);
							continue;
						}
						if ((tileTypeAt(i, j) & T_WATERFLOW) == T_WATERFLOW || (tileTypeAt(i, j) & T_UNDERWATER) == T_UNDERWATER)
						{
							if ((tileTypeAt(i, j - 1) & T_WATERFALL) == T_WATERFALL)
							{
								g.drawRegion(imgWaterfall, 0, 24 * (GameCanvas.gameTick % 4), 24, 24, 0, i * size, j * size, 0);
								continue;
							}
							if ((tileTypeAt(i, j - 1) & T_SOLIDGROUND) == T_SOLIDGROUND)
							{
								int num4 = tileAt(i, j - 1);
								if (num4 == 25)
								{
									num4 = tileAt(i, j - 2);
								}
								if (num4 == 45)
								{
									num4 = 44;
								}
								num4--;
								g.drawImage(imgTileMap[num4], i * size, j * size, 0);
								continue;
							}
						}
					}
					if ((tileTypeAt(i, j) & T_TREE) == T_TREE)
					{
						bx = i * size - GameScr.cmx;
						dbx = bx - GameScr.gW2;
						dfx = (size - 2) * dbx / size;
						fx = dfx + GameScr.gW2;
						g.drawImage(imgTileMap[num], fx + GameScr.cmx, j * size, 0);
					}
					else if ((tileTypeAt(i, j) & T_DOWN1PIXEL) == T_DOWN1PIXEL)
					{
						if (num != -1)
						{
							g.drawImage(imgTileMap[num], i * size, j * size, 0);
							g.drawImage(imgTileMap[num], i * size, j * size + 1, 0);
						}
					}
					else if (num != -1)
					{
						g.drawImage(imgTileMap[num], i * size, j * size, 0);
					}
				}
			}
			if (mapID == 6 && Screen.width > pxw && mGraphics.zoomLevel != 3)
			{
				g.setColor(0);
				g.fillRect(GameScr.cmx, 0, 80, pxh);
				g.setColor(0);
				g.fillRect(pxw - 24, 0, 50, pxh);
			}
		}
		catch (IOException)
		{
		}
	}

	public static void paintMiniMap(mGraphics g)
	{
		Res.resetTrans(g);
		g.translate(posMiniMapX + 1, posMiniMapY + 2);
		int num = Char.getMyChar().cx / 12;
		int num2 = Char.getMyChar().cy / 12;
		g.setColor(0);
		g.fillRect(-2, -2, wMiniMap + 2, hMiniMap);
		g.setClip(-2, -2, wMiniMap + 4, hMiniMap + 4);
		for (int i = 0; i < 2; i++)
		{
			g.setColor(colorMini[i]);
			g.drawRect(i - 2, i - 2, wMiniMap + 2 - i * 2, hMiniMap - i * 2);
		}
		g.setClip(0, 0, wMiniMap - 2, hMiniMap - 3);
		if (mGraphics.getImageWidth(imgMiniMap) > wMiniMap || mGraphics.getImageHeight(imgMiniMap) > hMiniMap)
		{
			g.translate(-cmxMini, -cmyMini);
		}
		g.drawImage(imgMiniMap, 0, 0, 0);
		g.setColor(16777215);
		g.fillRect(num - 2, num2 - 2, 5, 5);
		g.setColor(16711680);
		g.fillRect(num - 1, num2 - 1, 3, 3);
		for (int j = 0; j < GameScr.vParty.size(); j++)
		{
			Party party = (Party)GameScr.vParty.elementAt(j);
			if (party.c != null && party.c != Char.getMyChar())
			{
				int num3 = party.c.cx / 12;
				int num4 = party.c.cy / 12;
				if (num3 < cmxMini)
				{
					num3 = cmxMini;
				}
				if (num4 < cmyMini)
				{
					num4 = cmyMini;
				}
				if (num3 > cmxMini + wMiniMap)
				{
					num3 = cmxMini + wMiniMap;
				}
				if (num4 > cmyMini + hMiniMap)
				{
					num4 = cmyMini + hMiniMap;
				}
				if (GameCanvas.gameTick % 10 < 8)
				{
					g.setColor(16777215);
					g.fillRect(num3 - 2, num4 - 2, 5, 5);
					g.setColor(65280);
					g.fillRect(num3 - 1, num4 - 1, 3, 3);
				}
			}
		}
		Res.resetTrans(g);
		if (GameCanvas.isTouch)
		{
			g.drawImage(GameScr.imgMapBorder, posMiniMapX - 1, posMiniMapY, 0);
		}
	}

	public static void paintOutTilemap(mGraphics g)
	{
		if (GameCanvas.lowGraphic || Main.isIpod || mGraphics.zoomLevel == 1)
		{
			return;
		}
		for (int i = GameScr.gssx; i < GameScr.gssxe; i++)
		{
			for (int j = GameScr.gssy; j < GameScr.gssye; j++)
			{
				Image image = null;
				image = ((tileID != 4) ? imgWaterflow : imgflowRiver);
				if ((tileTypeAt(i, j) & T_WATERFLOW) == T_WATERFLOW)
				{
					g.drawRegion(image, 0, (GameCanvas.gameTick % 8 >> 2) * 24, 24, 24, 0, i * size, j * size, 0);
				}
				if ((tileTypeAt(i, j) & T_OUTSIDE) == T_OUTSIDE)
				{
					g.drawImage(imgTileMap[maps[j * tmw + i] - 1], i * size, j * size, 0);
				}
			}
		}
		if (!GameCanvas.isTouch || !GameCanvas.isTouchControl || GameScr.gssye < tmh - 2)
		{
			return;
		}
		for (int k = GameScr.gssx; k < GameScr.gssxe; k++)
		{
			int num = tmh - 2;
			int num2 = maps[num * tmw + k] - 1;
			if ((tileTypeAt(k, num) & T_WATERFALL) == T_WATERFALL)
			{
				for (int l = 1; l <= 4; l++)
				{
					g.drawRegion(imgWaterfall, 0, 24 * (GameCanvas.gameTick % 4), 24, 24, 0, k * size, (num + l) * size, 0);
				}
				continue;
			}
			if (mapID == 64)
			{
				defaultSolidTile = 115;
			}
			if ((tileTypeAt(k, num) & T_TOP) == T_TOP || (tileTypeAt(k, num) & T_WATERFLOW) == T_WATERFLOW)
			{
				num2 = defaultSolidTile;
			}
			if (num2 >= 0)
			{
				for (int m = 1; m <= 4; m++)
				{
					g.drawImage(imgTileMap[num2], k * size, (num + m) * size, 0);
				}
			}
		}
	}

	public static int tileAt(int x, int y)
	{
		try
		{
			return maps[y * tmw + x];
		}
		catch (Exception)
		{
			return 1000;
		}
	}

	public static int tileTypeAt(int x, int y)
	{
		try
		{
			return types[y * tmw + x];
		}
		catch (Exception)
		{
			return 1000;
		}
	}

	public static int tileTypeAtPixel(int px, int py)
	{
		try
		{
			return types[py / size * tmw + px / size];
		}
		catch (Exception)
		{
			return 1000;
		}
	}

	public static bool tileTypeAt(int px, int py, int t)
	{
		try
		{
			return (types[py / size * tmw + px / size] & t) == t;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static void setTileTypeAtPixel(int px, int py, int t)
	{
		types[py / size * tmw + px / size] |= t;
	}

	public static void setTileTypeAt(int x, int y, int t)
	{
		types[y * tmw + x] = t;
	}

	public static void killTileTypeAt(int px, int py, int t)
	{
		types[py / size * tmw + px / size] &= ~t;
	}

	public static int tileYofPixel(int py)
	{
		return py / size * size;
	}

	public static int tileXofPixel(int px)
	{
		return px / size * size;
	}

	public static void loadMapFromResource(short mapID)
	{
		int num = 0;
		DataInputStream resourceAsStream = DataInputStream.getResourceAsStream(Main.res + "/map/" + TileMap.mapID);
		tmw = (ushort)resourceAsStream.read();
		tmh = (ushort)resourceAsStream.read();
		maps = new char[resourceAsStream.available()];
		for (int i = 0; i < tmw * tmh; i++)
		{
			maps[i] = (char)resourceAsStream.read();
		}
		types = new int[maps.Length];
	}

	public static void loadTileMapArr()
	{
		Image image = GameCanvas.loadImage("/black");
		blackAr = image.texture.GetPixels(0, 0, miniSize * mGraphics.zoomLevel, miniSize * mGraphics.zoomLevel);
		Resources.UnloadUnusedAssets();
		GC.Collect();
	}

	public static void loadMusicBackground()
	{
		if (oldMapID != mapID)
		{
			Sound.stopAllBg();
			switch (mapID)
			{
			case 1:
				Sound.play(Sound.MHirosaki, 0.8f);
				break;
			case 27:
				Sound.play(Sound.MHaruna, 0.8f);
				break;
			case 72:
				Sound.play(Sound.MOokaza, 0.8f);
				break;
			case 10:
				Sound.play(Sound.MKojin, 0.8f);
				break;
			case 17:
				Sound.play(Sound.MSanzu, 0.8f);
				break;
			case 22:
				Sound.play(Sound.MTone, 0.8f);
				break;
			case 32:
				Sound.play(Sound.MChai, 0.8f);
				break;
			case 38:
				Sound.play(Sound.MChakumi, 0.8f);
				break;
			case 43:
				Sound.play(Sound.MEchigo, 0.8f);
				break;
			case 48:
				Sound.play(Sound.MOshin, 0.8f);
				break;
			}
		}
	}

	public static void updateMusic()
	{
		if (GameCanvas.gameTick % 700 == 0 && !GameCanvas.lowGraphic && !Main.isIpod && mGraphics.zoomLevel != 1)
		{
			if (mapID == 0 || mapID <= 4 || (mapID >= 16 && mapID <= 18) || (mapID >= 24 && mapID <= 27) || mapID == 22 || mapID == 33 || mapID == 34 || mapID == 38 || mapID == 57 || mapID == 58 || mapID == 60 || mapID == 68 || (mapID >= 70 && mapID <= 75) || mapID == 81)
			{
				Sound.play(Sound.MChimKeu, 0.4f);
			}
			else if ((mapID >= 39 && mapID <= 44) || (mapID >= 46 && mapID <= 48) || mapID == 56 || (mapID >= 62 && mapID <= 65))
			{
				Sound.play(Sound.MGiotuyet, 0.4f);
			}
			else if (mapID == 29 || mapID == 35)
			{
				Sound.play(Sound.MHangdong, 0.4f);
			}
			else if (mapID == 50 || mapID == 51 || mapID == 52)
			{
				Sound.play(Sound.MDeKeu, 0.4f);
			}
			else if (mapID == 64)
			{
				if (Res.random(0, 8) % 2 == 0)
				{
					Sound.play(Sound.MDeKeu, 0.4f);
				}
				else
				{
					Sound.play(Sound.MHangdong, 0.4f);
				}
			}
		}
		if (getPosVsMainChar() && !isStopping)
		{
			volume += 0.01f;
			if (volume >= 0.1f)
			{
				volume = 0.1f;
			}
			if (!Sound.isPlayingSoundBG(Sound.MNuocChay))
			{
				Sound.playSoundBGLoop(Sound.MNuocChay, volume);
			}
			Sound.SoundBGLoop.GetComponent<AudioSource>().volume = volume;
		}
		else
		{
			Sound.SoundBGLoop.GetComponent<AudioSource>().volume -= 0.01f;
			isStopping = true;
			if (Sound.SoundBGLoop.GetComponent<AudioSource>().volume <= 0f)
			{
				Sound.SoundBGLoop.GetComponent<AudioSource>().volume = 0f;
				Sound.sTopSoundBG(Sound.MNuocChay);
				isStopping = false;
				volume = 0f;
			}
		}
	}
}
