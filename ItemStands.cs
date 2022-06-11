public class ItemStands
{
	public Item item;

	public int price;

	public int timeEnd;

	public int timeStart;

	public string seller = string.Empty;

	public ItemStands(Item item, string seller, int price)
	{
		this.item = item;
		this.seller = seller;
		this.price = price;
	}

	public ItemStands()
	{
	}
}
