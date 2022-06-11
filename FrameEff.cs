public class FrameEff
{
	public MyVector listPartTop = new MyVector();

	public MyVector listPartBottom = new MyVector();

	public sbyte xShadow;

	public sbyte yShadow;

	public FrameEff(MyVector listtop, MyVector listbottom)
	{
		listPartTop = listtop;
		listPartBottom = listbottom;
	}

	public MyVector getListPartPaint()
	{
		MyVector myVector = new MyVector();
		for (int i = 0; i < listPartBottom.size(); i++)
		{
			myVector.addElement(listPartBottom.elementAt(i));
		}
		for (int j = 0; j < listPartTop.size(); j++)
		{
			myVector.addElement(listPartTop.elementAt(j));
		}
		return myVector;
	}
}
