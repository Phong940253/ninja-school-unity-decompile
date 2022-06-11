public class Map
{
	public short mapID;

	public sbyte mapVersion;

	public string mapName;

	public string mapDescription;

	public char[] mapData;

	public int mapH;

	public int mapW;

	public short sumMob;

	public int[] mobID;

	public int[] mobX;

	public int[] mobY;

	public int tileID;

	public int bgID;

	public void setmapID(short mapID)
	{
		this.mapID = mapID;
	}

	public void setmapVersion(sbyte mapVersion)
	{
		this.mapVersion = mapVersion;
	}

	public void setmapName(string mapName)
	{
		this.mapName = mapName;
	}

	public void setmapDescription(string mapDescription)
	{
		this.mapDescription = mapDescription;
	}

	public void setmapFile(char[] mapFile)
	{
		mapData = mapFile;
	}

	public void setmapH(char mapH)
	{
		this.mapH = mapH;
	}

	public void setmapW(char mapW)
	{
		this.mapW = mapW;
	}

	public void setsumMob(short sumMob)
	{
		this.sumMob = sumMob;
	}

	public void setmobID(int[] mobID)
	{
		this.mobID = mobID;
	}

	public void setmobX(int[] mobX)
	{
		this.mobX = mobX;
	}

	public void setmobY(int[] mobY)
	{
		this.mobY = mobY;
	}

	public void setTileID(sbyte tileID)
	{
		this.tileID = tileID;
	}

	public void setBgID(int bgID)
	{
		this.bgID = bgID;
	}
}
