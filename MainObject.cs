public class MainObject
{
	public MyVector vecEFfect = new MyVector();

	public void addDataeff(short id, long timelive, int miliSecondWait, bool isHead)
	{
		for (int i = 0; i < vecEFfect.size(); i++)
		{
			DataSkillEff dataSkillEff = (DataSkillEff)vecEFfect.elementAt(i);
			if (dataSkillEff != null && dataSkillEff.idEff == id)
			{
				dataSkillEff.timelive = timelive + mSystem.currentTimeMillis();
				dataSkillEff.miliSecondWait = miliSecondWait;
				dataSkillEff.setTypeEff(timelive);
				return;
			}
		}
		DataSkillEff o = new DataSkillEff(id, timelive, miliSecondWait, isHead);
		vecEFfect.addElement(o);
	}

	public int getStartPointPaintFly()
	{
		return 0;
	}

	public void paintTopDataEff(mGraphics g, int x, int y, int dy)
	{
		for (int i = 0; i < vecEFfect.size(); i++)
		{
			DataSkillEff dataSkillEff = (DataSkillEff)vecEFfect.elementAt(i);
			if (dataSkillEff != null)
			{
				int y2 = y;
				if (dataSkillEff.isHead)
				{
					y2 = y + dy + 4;
				}
				dataSkillEff.paintTopEff(g, x, y2);
			}
		}
	}

	public void paintBottomDataEff(mGraphics g, int x, int y, int dy)
	{
		for (int i = 0; i < vecEFfect.size(); i++)
		{
			DataSkillEff dataSkillEff = (DataSkillEff)vecEFfect.elementAt(i);
			if (dataSkillEff != null)
			{
				int y2 = y;
				if (dataSkillEff.isHead)
				{
					y2 = y + dy + 4;
				}
				dataSkillEff.paintBottomEff(g, x, y2);
			}
		}
	}

	public void updateDataEff(sbyte type, int statusMe)
	{
		for (int i = 0; i < vecEFfect.size(); i++)
		{
			DataSkillEff dataSkillEff = (DataSkillEff)vecEFfect.elementAt(i);
			if (dataSkillEff != null)
			{
				dataSkillEff.update();
				if (dataSkillEff.wantDetroy)
				{
					vecEFfect.removeElement(dataSkillEff);
				}
			}
		}
		if (type == 0 && statusMe == 14)
		{
			removeAllEff();
		}
		if (type == 1 && statusMe == 0)
		{
			removeAllEff();
		}
	}

	public void setidPP(short id)
	{
	}

	public virtual void setThoiTrang(short[] arr)
	{
	}

	public void removeAllEff()
	{
		vecEFfect.removeAllElements();
	}
}
