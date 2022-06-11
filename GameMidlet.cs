using System;
using System.IO;
using System.Net;
using UnityEngine;

public class GameMidlet
{
	public static sbyte CLIENT_TYPE;

	public static sbyte indexClient;

	public static string IP;

	public static int PORT;

	public static sbyte userProvider;

	public static string clientAgent;

	public static bool isWorldver;

	public static sbyte serverLogin;

	public const string VERSION = "1.8.8";

	public static GameMidlet instance;

	public static int muzic;

	public static bool isPlaySound;

	public static string inFoSMS;

	public static string latitude;

	public static string longitude;

	public static string linkDefault;

	public static string java;

	public static string smartPhone;

	public static string[] nameServer;

	public static string[] ipList;

	public static short[] portList;

	public static sbyte[] serverLoginList;

	public static sbyte[] language;

	public static sbyte[] serverST;

	public GameMidlet()
	{
		MotherCanvas.instance = new MotherCanvas();
		Session_ME.gI().setHandler(Controller.gI());
		instance = this;
		mFont.init();
		mScreen.ITEM_HEIGHT = mFont.tahoma_8b.getHeight() + 6;
		clientAgent = readFileText("agent");
		if (Main.isPC)
		{
			userProvider = sbyte.Parse(readFileText("provider"));
		}
		else
		{
			userProvider = sbyte.Parse(string.Empty + iOSPlugins.getProvider());
		}
		Debug.Log("AGENT: " + clientAgent + ", PROVIDER: " + userProvider);
		SplashScr.loadSplashScr();
		GameCanvas.currentScreen = new SplashScr();
		Key.mapKeyPC();
	}

	public void exit()
	{
		GameCanvas.bRun = false;
		Main.exit();
	}

	public static void sendSMSRe(string data, string to, Command successAction, Command failAction)
	{
		if (to.Contains("sms://"))
		{
			to = to.Remove(0, 6);
		}
		_ = Main.isPC;
		GameCanvas.endDlg();
		GameCanvas.startOKDlg(inFoSMS + data + mResources.SEND_TO + to);
	}

	public static void sendSMS(string data, string to, Command successAction, Command failAction)
	{
		Out.println("Send SMS >> " + data + "  " + to);
	}

	public static void flatForm(string url)
	{
		Out.println("PLATFORM " + url);
	}

	public void platformRequest(string url)
	{
		Out.LogWarning("PLATFORM REQUEST: " + url);
		Application.OpenURL(url);
	}

	public void notifyDestroyed()
	{
		GameCanvas.endDlg();
		Main.exit();
	}

	public string readFileText(string fileName)
	{
		try
		{
			string text = new StringReader(((TextAsset)Resources.Load(Main.res + "/" + fileName, typeof(TextAsset))).text).ReadLine();
			return text.ToString();
		}
		catch (IOException)
		{
			return string.Empty;
		}
	}

	public void CheckPerGPS()
	{
		getLocation();
	}

	public void getLocation()
	{
		longitude = GPS.Longitude;
		latitude = GPS.Latitude;
		Service.gI().sendGPS();
	}

	public static void getServerList(string str)
	{
		string[] array = Res.split(str.Trim(), ",", 0);
		nameServer = new string[array.Length];
		ipList = new string[array.Length];
		portList = new short[array.Length];
		serverLoginList = new sbyte[array.Length];
		language = new sbyte[array.Length];
		serverST = new sbyte[array.Length];
		sbyte b = 0;
		sbyte b2 = 0;
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = Res.split(array[i].Trim(), ":", 0);
			nameServer[i] = array2[0];
			ipList[i] = array2[1];
			portList[i] = short.Parse(array2[2]);
			serverLoginList[i] = sbyte.Parse(array2[3]);
			language[i] = sbyte.Parse(array2[4]);
			if (language[i] == mResources.Lang_VI)
			{
				serverST[i] = b;
				b = (sbyte)(b + 1);
			}
			else if (language[i] == mResources.Lang_EN)
			{
				serverST[i] = b2;
				b2 = (sbyte)(b2 + 1);
			}
		}
		saveIP();
	}

	public static void saveIP()
	{
		DataOutputStream dataOutputStream = new DataOutputStream();
		try
		{
			dataOutputStream.writeByte(nameServer.Length);
			for (int i = 0; i < nameServer.Length; i++)
			{
				dataOutputStream.writeUTF(nameServer[i]);
				dataOutputStream.writeUTF(ipList[i]);
				dataOutputStream.writeShort(portList[i]);
				dataOutputStream.writeByte(serverLoginList[i]);
				dataOutputStream.writeByte(language[i]);
				dataOutputStream.writeByte(serverST[i]);
			}
			RMS.saveRMS("NJlink", dataOutputStream.toByteArray());
			dataOutputStream.close();
			SelectServerScr.loadIP();
		}
		catch (Exception)
		{
		}
	}

	public static void getStrSv()
	{
		string empty = string.Empty;
		empty = ((CLIENT_TYPE != 1) ? connectHTTP("http://localhost/server.txt") : connectHTTP("http://localhost/server.txt"));
		if (empty.Equals(string.Empty))
		{
			empty = ((CLIENT_TYPE != 1) ? smartPhone : java);
		}
		getServerList(empty);
	}

	public static void loadLinkRMS()
	{
		sbyte[] array = RMS.loadRMS("NJlink");
		if (array == null)
		{
			getStrSv();
			return;
		}
		DataInputStream dataInputStream = new DataInputStream(array);
		if (dataInputStream == null)
		{
			return;
		}
		try
		{
			sbyte b = dataInputStream.readByte();
			nameServer = new string[b];
			ipList = new string[b];
			portList = new short[b];
			serverLoginList = new sbyte[b];
			language = new sbyte[b];
			serverST = new sbyte[b];
			for (int i = 0; i < b; i++)
			{
				nameServer[i] = dataInputStream.readUTF();
				ipList[i] = dataInputStream.readUTF();
				portList[i] = dataInputStream.readShort();
				serverLoginList[i] = dataInputStream.readByte();
				language[i] = dataInputStream.readByte();
				serverST[i] = dataInputStream.readByte();
			}
			dataInputStream.close();
			SelectServerScr.loadIP();
		}
		catch (IOException)
		{
		}
	}

	public static int GetWorldIndex()
	{
		int result = 0;
		int num = mResources.Lang_VI;
		if (isWorldver)
		{
			num = mResources.Lang_EN;
		}
		for (int i = 0; i <= language.Length - 1; i++)
		{
			if (language[i] == num)
			{
				return i;
			}
		}
		return result;
	}

	public static int GetLastIndex()
	{
		int result = 0;
		for (int i = 0; i <= language.Length - 1; i++)
		{
			if (language[i] == mResources.Lang_EN)
			{
				return i - 1;
			}
		}
		return result;
	}

	public static string connectHTTP(string link)
	{
		string empty = string.Empty;
		using WebClient webClient = new WebClient();
		return webClient.DownloadString(link);
	}

	static GameMidlet()
	{
		CLIENT_TYPE = 4;
		IP = string.Empty;
		PORT = 14444;
		muzic = -1;
		latitude = string.Empty;
		longitude = string.Empty;
		java = "Localhost(New):127.0.0.1:14444:0:0,Tone:112.213.94.205:14444:0:0,Bokken:112.213.84.18:14444:0:0,Shuriken:27.0.14.73:14444:0:0,Tessen:27.0.14.73:14444:1:0,Kunai:112.213.94.135:14444:0:0,Katana:112.213.94.161:14444:0:0,Hirosaki:13.251.169.132:14444:0:1,Haruna (NEW):54.151.133.77:14444:0:1";
		smartPhone = "Localhost(New):127.0.0.1:14444:0:0,Tone:112.213.94.205:14444:0:0,Bokken:112.213.84.18:14444:0:0,Shuriken:27.0.14.73:14444:0:0,Tessen:27.0.14.73:14444:1:0,Kunai:112.213.94.135:14444:0:0,Katana:112.213.94.161:14444:0:0,Hirosaki:13.251.169.132:14444:0:1,Haruna (NEW):54.151.133.77:14444:0:1";
	}
}
