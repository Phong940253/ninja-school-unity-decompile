public class ItemTree
{
	public int idTree;

	public int xTree;

	public int yTree;

	public ItemTree(int x, int y)
	{
		xTree = x * 24 + 12;
		yTree = y * 24 + 24 + 2;
	}

	public object getImageFromHash()
	{
		object obj = TileMap.itemMap.get(idTree + string.Empty);
		if (obj != null)
		{
			return obj;
		}
		return null;
	}

	public void paint(mGraphics g)
	{
		if (getImageFromHash() != null)
		{
			g.drawImage((Image)getImageFromHash(), xTree, yTree, mGraphics.BOTTOM | mGraphics.HCENTER);
		}
	}
}
