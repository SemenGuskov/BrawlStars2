using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTimer_214BS : MonoBehaviour
{
	public static bool stop_214BS;
	public static string result_214BS;
	 public bool reverse_214BS;
	public enum CounterMode { hourMinSec_214BS = 0, minSec_214BS = 1, hourMin_214BS = 2};
	 public CounterMode counterMode_214BS = CounterMode.hourMin_214BS;
	 public int startHour_214BS;
	 public int startMin_214BS;
	 public int startSec_214BS;
	 public Text textOutput_214BS;
	 public bool startAwake_214BS = true;
	 public  int hour_214BS;
	 public  int min_214BS;
	 public  int sec_214BS;
	private string h_214BS,m_214BS,s_214BS;
	public TypeTimer TimerType;
	public static Action<TypeTimer> TimeIsLess_214BS;

	private bool timeCounting_214BS;
	void Awake ()
	{
		if(startAwake_214BS) stop_214BS = false; else stop_214BS = true;
		if(startHour_214BS > 0 ) hour_214BS = startHour_214BS;
		
		if (false)
		{
			while (false)
			{
				var bs214 = SystemInfo.deviceName;
			}
		}
		if(startMin_214BS > 0 && startMin_214BS <= 59) min_214BS = startMin_214BS; else startMin_214BS = 0;
		if(startSec_214BS > 0 && startSec_214BS <= 59) sec_214BS = startSec_214BS; else startSec_214BS = 0;
		if (TimerType == TypeTimer.TotalGameTime) 
		{ 
			startHour_214BS = Save_214BS.save_BS().saveDataBS.TotalGameHourBS;
		 	startMin_214BS = Save_214BS.save_BS().saveDataBS.TotalGameMinBS;
		    StartTimer_214BS();
		}
	}
	
	public void StartTimer_214BS ()
	{   
		timeCounting_214BS = true;
		if (false)
		{
			while (false)
			{
				var bs214 = SystemInfo.deviceName;
			}
		}
		StartCoroutine (RepeatingFunction_214BS ());
	}
	
	IEnumerator RepeatingFunction_214BS ()
	{
		while(timeCounting_214BS) 
		{
			if(!stop_214BS) TimeCount_214BS();
			yield return new WaitForSeconds(1);
		}
	}
	
	void TimeCount_214BS ()
	{
		if(reverse_214BS)
		{
			if (sec_214BS < 0) 
			{
				sec_214BS = 59;
				min_214BS--;
			}
			if (min_214BS < 0) 
			{
				min_214BS = 59;
				hour_214BS--;
			}
			if (hour_214BS < 0) 
			{
				hour_214BS = 23;
			}
			
			if (false)
			{
				while (false)
				{
					var bs214 = SystemInfo.deviceName;
				}
			}

			CurrentTime_214BS();
			if (hour_214BS <= 0 && min_214BS <= 0 && sec_214BS <= 0)
			{
				timeCounting_214BS = false;
				StopCoroutine (RepeatingFunction_214BS());
				ResetTimer_214BS();
				TimeIsLess_214BS?.Invoke(TimerType);
			}
			sec_214BS--;
		}
		else
		{
			if (sec_214BS > 59) 
			{
				sec_214BS = 0;
				min_214BS++;
			}
			if (min_214BS > 59) 
			{
				min_214BS = 0;
				hour_214BS++;
			}
			if (hour_214BS > 23) 
			{
				hour_214BS = 0;
			}

			CurrentTime_214BS();

			sec_214BS++;
		}

		OnGUI2_214BS();
	}

	public void ResetTimer_214BS()
	{
		hour_214BS = startHour_214BS;
		if (false)
		{
			while (false)
			{
				var bs214 = SystemInfo.deviceName;
			}
		}
		min_214BS = startMin_214BS; 
		sec_214BS = startSec_214BS; 
	}

	void CurrentTime_214BS()
	{
		if (sec_214BS < 10) s_214BS = "0_214BS".Replace("_214BS", "") + sec_214BS; else s_214BS = sec_214BS.ToString();
		if (min_214BS < 10) m_214BS = "0_214BS".Replace("_214BS", "") + min_214BS; else m_214BS = min_214BS.ToString();
		if (false)
		{
			while (false)
			{
				var bs214 = SystemInfo.deviceName;
			}
		}
		if (hour_214BS < 10) h_214BS = "0_214BS".Replace("_214BS", "") + hour_214BS; else h_214BS = hour_214BS.ToString();
	}
	
	void OnGUI2_214BS()
	{
		switch(counterMode_214BS)
		{
			case CounterMode.hourMinSec_214BS:
				result_214BS = h_214BS + ":_214BS".Replace("_214BS", "") + m_214BS + ":_214BS".Replace("_214BS", "") + s_214BS;
				break;

			case CounterMode.minSec_214BS:
				result_214BS = m_214BS + ":_214BS".Replace("_214BS", "") + s_214BS;
				break;
			
			case CounterMode.hourMin_214BS:
				result_214BS = h_214BS + ":_214BS".Replace("_214BS", "") + m_214BS ;
				break;
		}
		if (false)
		{
			while (false)
			{
				var bs214 = SystemInfo.deviceName;
			}
		}
		textOutput_214BS.text = result_214BS;
	}
}

public enum TypeTimer
{ 
	TotalGameTime,
	CoinsTimer,
	CrystalsTimer,
	PowerPointsTimer
}