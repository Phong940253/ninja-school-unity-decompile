public class Npc : Char
{
	public const sbyte BINH_KHI = 0;

	public const sbyte PHONG_CU = 1;

	public const sbyte TRANG_SUC = 2;

	public const sbyte DUOC_PHAM = 3;

	public const sbyte TAP_HOA = 4;

	public const sbyte THU_KHO = 5;

	public const sbyte DA_LUYEN = 6;

	public const sbyte XA_PHU_LANG = 7;

	public const sbyte XA_PHU_TRUONG = 8;

	public const sbyte CHU_NHIEM_HOA = 9;

	public const sbyte CHU_NHIEM_THUY = 10;

	public const sbyte CHU_NHIEM_GIO = 11;

	public const sbyte TRUONG_LANG_TONE = 12;

	public const sbyte KHU_VUC = 13;

	public const sbyte GIAO_THU_1 = 14;

	public const sbyte GIAO_THU_2 = 15;

	public const sbyte GIAO_THU_3 = 16;

	public const sbyte CHAU_BA_REI = 17;

	public const sbyte TRUONG_LANG_CHAI = 18;

	public const sbyte TRUONG_LANG_KOJIN = 19;

	public const sbyte TRUONG_LANG_CHAKUMI = 20;

	public const sbyte TRUONG_LANG_ECHIGO = 21;

	public const sbyte TRUONG_LANG_SANZU = 22;

	public const sbyte TRUONG_LANG_OSHIN = 23;

	public const sbyte TIEN_TRANG = 24;

	public const sbyte DAU_TRUONG = 25;

	public const sbyte THUONG_NHAN = 26;

	public const sbyte TRU_CO_QUAN = 27;

	public const sbyte KY_TRAN = 28;

	public NpcTemplate template;

	public int npcId;

	public bool isFocus = true;

	public static NpcTemplate[] arrNpcTemplate;

	public int sys;

	public Npc(int npcId, int status, int cx, int cy, int templateId)
	{
		this.npcId = npcId;
		base.cx = cx;
		base.cy = cy;
		statusMe = status;
		template = arrNpcTemplate[templateId];
	}

	public static void clearEffTask()
	{
		for (int i = 0; i < GameScr.vNpc.size(); i++)
		{
			Npc npc = (Npc)GameScr.vNpc.elementAt(i);
			npc.effTask = null;
			npc.indexEffTask = -1;
		}
	}

	public override void update()
	{
		if (effTask == null)
		{
			sbyte[] array = new sbyte[7] { -1, 9, 9, 10, 10, 11, 11 };
			if (Char.getMyChar().ctaskId >= 9 && Char.getMyChar().ctaskId <= 10 && Char.getMyChar().nClass.classId > 0 && array[Char.getMyChar().nClass.classId] == template.npcTemplateId)
			{
				if (Char.getMyChar().taskMaint == null)
				{
					effTask = GameScr.efs[57];
					indexEffTask = 0;
				}
				else if (Char.getMyChar().taskMaint != null && Char.getMyChar().taskMaint.index + 1 == Char.getMyChar().taskMaint.subNames.Length)
				{
					effTask = GameScr.efs[62];
					indexEffTask = 0;
				}
			}
			else
			{
				sbyte taskNpcId = GameScr.gI().getTaskNpcId();
				if (Char.getMyChar().taskMaint == null && taskNpcId == template.npcTemplateId)
				{
					effTask = GameScr.efs[57];
					indexEffTask = 0;
				}
				else if (Char.getMyChar().taskMaint != null && taskNpcId == template.npcTemplateId)
				{
					if (Char.getMyChar().taskMaint.index + 1 == Char.getMyChar().taskMaint.subNames.Length)
					{
						effTask = GameScr.efs[62];
					}
					else
					{
						effTask = GameScr.efs[57];
					}
					indexEffTask = 0;
				}
			}
		}
		base.update();
	}

	public void paintHead(mGraphics g)
	{
		Part part = GameScr.parts[template.headId];
		if (cdir == 1)
		{
			SmallImage.drawSmallImage(g, part.pi[Char.CharInfo[cf][0][0]].id, GameCanvas.w - 31 - g.getTranslateX(), 2 - g.getTranslateY(), 0, 0);
		}
		else
		{
			SmallImage.drawSmallImage(g, part.pi[Char.CharInfo[cf][0][0]].id, GameCanvas.w - 31 - g.getTranslateX(), 2 - g.getTranslateY(), 2, 24);
		}
	}

	public override void paint(mGraphics g)
	{
		if (!isPaint() || statusMe == 15)
		{
			return;
		}
		if (cTypePk != 0)
		{
			base.paint(g);
		}
		else
		{
			if (template == null)
			{
				return;
			}
			if (template.npcTemplateId == 13)
			{
				if (Char.getMyChar().npcFocus != null && Char.getMyChar().npcFocus.Equals(this))
				{
					SmallImage.drawSmallImage(g, 988, cx, cy - ch - 1, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
				}
				SmallImage.drawSmallImage(g, 1060, cx, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
				mFont.tahoma_7_white.drawString(g, TileMap.zoneID + string.Empty, cx + 1, cy - 14 - mFont.tahoma_7.getHeight(), mFont.CENTER);
				return;
			}
			if (template.npcTemplateId == 31)
			{
				if (Char.getMyChar().npcFocus != null && Char.getMyChar().npcFocus.Equals(this))
				{
					SmallImage.drawSmallImage(g, 988, cx, cy - ch - 1, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
				}
				SmallImage.drawSmallImage(g, 1291, cx, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
				return;
			}
			if (template.npcTemplateId == 27)
			{
				if (Char.getMyChar().npcFocus != null && Char.getMyChar().npcFocus.Equals(this))
				{
					SmallImage.drawSmallImage(g, 988, cx, cy - ch - 1, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
				}
				SmallImage.drawSmallImage(g, 1224, cx, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
				return;
			}
			Part part = GameScr.parts[template.headId];
			Part part2 = GameScr.parts[template.legId];
			Part part3 = GameScr.parts[template.bodyId];
			Part part4 = null;
			if (cdir == 1)
			{
				SmallImage.drawSmallImage(g, part.pi[Char.CharInfo[cf][0][0]].id, cx + Char.CharInfo[cf][0][1] + part.pi[Char.CharInfo[cf][0][0]].dx, cy - Char.CharInfo[cf][0][2] + part.pi[Char.CharInfo[cf][0][0]].dy, 0, 0);
				SmallImage.drawSmallImage(g, part2.pi[Char.CharInfo[cf][1][0]].id, cx + Char.CharInfo[cf][1][1] + part2.pi[Char.CharInfo[cf][1][0]].dx, cy - Char.CharInfo[cf][1][2] + part2.pi[Char.CharInfo[cf][1][0]].dy, 0, 0);
				SmallImage.drawSmallImage(g, part3.pi[Char.CharInfo[cf][2][0]].id, cx + Char.CharInfo[cf][2][1] + part3.pi[Char.CharInfo[cf][2][0]].dx, cy - Char.CharInfo[cf][2][2] + part3.pi[Char.CharInfo[cf][2][0]].dy, 0, 0);
				if (part4 != null)
				{
					SmallImage.drawSmallImage(g, part4.pi[Char.CharInfo[cf][2][0]].id, cx + Char.CharInfo[cf][3][1] + part4.pi[Char.CharInfo[cf][3][0]].dx, cy - Char.CharInfo[cf][3][2] + part4.pi[Char.CharInfo[cf][3][0]].dy, 0, 0);
				}
			}
			else
			{
				SmallImage.drawSmallImage(g, part.pi[Char.CharInfo[cf][0][0]].id, cx - Char.CharInfo[cf][0][1] - part.pi[Char.CharInfo[cf][0][0]].dx, cy - Char.CharInfo[cf][0][2] + part.pi[Char.CharInfo[cf][0][0]].dy, 2, 24);
				SmallImage.drawSmallImage(g, part2.pi[Char.CharInfo[cf][1][0]].id, cx - Char.CharInfo[cf][1][1] - part2.pi[Char.CharInfo[cf][1][0]].dx, cy - Char.CharInfo[cf][1][2] + part2.pi[Char.CharInfo[cf][1][0]].dy, 2, 24);
				SmallImage.drawSmallImage(g, part3.pi[Char.CharInfo[cf][2][0]].id, cx - Char.CharInfo[cf][2][1] - part3.pi[Char.CharInfo[cf][2][0]].dx, cy - Char.CharInfo[cf][2][2] + part3.pi[Char.CharInfo[cf][2][0]].dy, 2, 24);
				if (part4 != null)
				{
					SmallImage.drawSmallImage(g, part4.pi[Char.CharInfo[cf][2][0]].id, cx - Char.CharInfo[cf][3][1] - part4.pi[Char.CharInfo[cf][3][0]].dx, cy - Char.CharInfo[cf][3][2] + part4.pi[Char.CharInfo[cf][3][0]].dy, 2, 24);
				}
			}
			if (indexEffTask >= 0 && effTask != null && cTypePk == 0)
			{
				SmallImage.drawSmallImage(g, effTask.arrEfInfo[indexEffTask].idImg, cx + effTask.arrEfInfo[indexEffTask].dx, cy + effTask.arrEfInfo[indexEffTask].dy, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				if (GameCanvas.gameTick % 2 == 0)
				{
					indexEffTask++;
					if (indexEffTask >= effTask.arrEfInfo.Length)
					{
						indexEffTask = 0;
					}
				}
			}
			if (Char.getMyChar().npcFocus != null && Char.getMyChar().npcFocus.Equals(this))
			{
				mFont.tahoma_7_yellow.drawString(g, template.name, cx, cy - ch - mFont.tahoma_7.getHeight() - 7, mFont.CENTER, mFont.tahoma_7_grey);
				SmallImage.drawSmallImage(g, 988, cx, cy - ch - 2, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
			}
			else
			{
				mFont.tahoma_7_yellow.drawString(g, template.name, cx, cy - ch - 3 - mFont.tahoma_7.getHeight(), mFont.CENTER, mFont.tahoma_7_grey);
			}
		}
	}

	public void hide()
	{
		statusMe = 15;
		chatPopup = null;
	}
}
