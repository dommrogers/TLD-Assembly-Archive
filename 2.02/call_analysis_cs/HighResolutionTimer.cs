using Cpp2ILInjected.CallAnalysis;

public class HighResolutionTimer
{
	private class HighResolutionTimerSaveDataProxy
	{
		public ulong m_ElapsedTime;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public HighResolutionTimerSaveDataProxy()
		{
		}
	}

	private const double SECOND_IN_MILLISECONDS = 1000.0;

	private const double MINUTE_IN_MILLISECONDS = 60000.0;

	private const double HOUR_IN_MILLISECONDS = 3600000.0;

	private const double DAY_IN_MILLISECONDS = 86400000.0;

	private ulong m_ElapsedTime;

	private ulong m_StartTime;

	private bool m_IsRunning;

	private static HighResolutionTimerSaveDataProxy s_TimerSaveDataProxy;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static HighResolutionTimer FromMilliseconds(ulong milliseconds)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static HighResolutionTimer FromSeconds(double seconds)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static HighResolutionTimer FromMinutes(double minutes)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static HighResolutionTimer FromHours(double hours)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static HighResolutionTimer FromDays(double days)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	public void Stop()
	{
	}

	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "OnUpdate")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "OnExecute")]
	[CalledBy(Type = typeof(PassTime), Member = "Begin")]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public void Restart()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsPaused()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "UpdateTimeForCurrentScene")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(PassTime), Member = "GetNumHoursRemaining")]
	[CalledBy(Type = typeof(PassTime), Member = "End")]
	[CalledBy(Type = typeof(PassTime), Member = "UpdatePassingTime")]
	[CalledBy(Type = typeof(HighResolutionTimer), Member = "Serialize")]
	[CalledBy(Type = typeof(HighResolutionTimer), Member = "GetElapsedDays")]
	[CalledBy(Type = typeof(HighResolutionTimer), Member = "GetElapsedHours")]
	[CalledBy(Type = typeof(HighResolutionTimer), Member = "GetElapsedMinutes")]
	[CalledBy(Type = typeof(HighResolutionTimer), Member = "GetElapsedSeconds")]
	[CalledBy(Type = typeof(HighResolutionTimer), Member = "Stop")]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	public ulong GetElapsedMilliseconds()
	{
		return default(ulong);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	public float GetElapsedSeconds()
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[CallerCount(Count = 0)]
	public float GetElapsedMinutes()
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[CalledBy(Type = typeof(PassTime), Member = "UpdatePassingTime")]
	[CalledBy(Type = typeof(PassTime), Member = "End")]
	public float GetElapsedHours()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	public float GetElapsedDays()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	public static double MillisecondsToSeconds(ulong milliseconds)
	{
		return default(double);
	}

	[CallerCount(Count = 0)]
	public static double MilliSecondsToMinutes(ulong milliseconds)
	{
		return default(double);
	}

	[CallerCount(Count = 0)]
	public static double MillisecondsToHours(ulong milliseconds)
	{
		return default(double);
	}

	[CallerCount(Count = 0)]
	public static double MillisecondsToDays(ulong milliseconds)
	{
		return default(double);
	}

	[CallerCount(Count = 0)]
	public static ulong SecondsToMilliseconds(double seconds)
	{
		return default(ulong);
	}

	[CallerCount(Count = 0)]
	public static ulong MinutesToMilliseconds(double minutes)
	{
		return default(ulong);
	}

	[CallerCount(Count = 0)]
	public static ulong HoursToMilliseconds(double hours)
	{
		return default(ulong);
	}

	[CallerCount(Count = 0)]
	public static ulong DaysToMilliseconds(double days)
	{
		return default(ulong);
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public HighResolutionTimer()
	{
	}
}
