public interface IMessageHandler
{
	void onMessage(Message message);

	void onConnectionFail();

	void onDisconnected();

	void onConnectOK();
}
