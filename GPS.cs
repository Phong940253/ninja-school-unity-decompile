using System.Collections;
using UnityEngine;

public class GPS : MonoBehaviour
{
	public static string Latitude = string.Empty;

	public static string Longitude = string.Empty;

	private void Start()
	{
		StartCoroutine(StartLocationService());
	}

	private void Update()
	{
	}

	private IEnumerator StartLocationService()
	{
		if (Input.location.isEnabledByUser)
		{
			Input.location.Start(1f, 1f);
			int maxWait = 20;
			while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
			{
				yield return new WaitForSeconds(1f);
				maxWait--;
			}
			if (maxWait > 0 && Input.location.status != LocationServiceStatus.Failed)
			{
				Latitude = Input.location.lastData.latitude + string.Empty;
				Longitude = Input.location.lastData.longitude + string.Empty;
				StartCoroutine(TrackLocation());
			}
		}
	}

	private IEnumerator TrackLocation()
	{
		while (true)
		{
			yield return new WaitForSeconds(5f);
			if (Input.location.status == LocationServiceStatus.Running)
			{
				Latitude = Input.location.lastData.latitude + string.Empty;
				Longitude = Input.location.lastData.longitude + string.Empty;
			}
			Debug.LogWarning("VO DAY ");
		}
	}
}
