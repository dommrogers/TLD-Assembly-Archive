using Cpp2ILInjected.CallAnalysis;

public class HighResolutionTimer
{
	private class HighResolutionTimerSaveDataProxy
	{
		public ulong m_ElapsedTime;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
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
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	public void Stop()
	{
	}

	[CalledBy(Type = typeof(PassTime), Member = "Begin")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "OnUpdate")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Restart()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsPaused()
	{
		return false;
	}

	[CalledBy(Type = typeof(HighResolutionTimer), Member = "Stop")]
	[CalledBy(Type = typeof(HighResolutionTimer), Member = "GetElapsedSeconds")]
	[CalledBy(Type = typeof(HighResolutionTimer), Member = "GetElapsedMinutes")]
	[CalledBy(Type = typeof(HighResolutionTimer), Member = "GetElapsedHours")]
	[CalledBy(Type = typeof(HighResolutionTimer), Member = "GetElapsedDays")]
	[CalledBy(Type = typeof(HighResolutionTimer), Member = "Serialize")]
	[CalledBy(Type = typeof(PassTime), Member = "UpdatePassingTime")]
	[CalledBy(Type = typeof(PassTime), Member = "End")]
	[CalledBy(Type = typeof(PassTime), Member = "GetNumHoursRemaining")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "UpdateTimeForCurrentScene")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public ulong GetElapsedMilliseconds()
	{
		return 0uL;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetElapsedSeconds()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetElapsedMinutes()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(PassTime), Member = "UpdatePassingTime")]
	[CalledBy(Type = typeof(PassTime), Member = "End")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetElapsedHours()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetElapsedDays()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	public static double MillisecondsToSeconds(ulong milliseconds)
	{
		return 0.0;
	}

	[CallerCount(Count = 0)]
	public static double MilliSecondsToMinutes(ulong milliseconds)
	{
		return 0.0;
	}

	[CallerCount(Count = 0)]
	public static double MillisecondsToHours(ulong milliseconds)
	{
		return 0.0;
	}

	[CallerCount(Count = 0)]
	public static double MillisecondsToDays(ulong milliseconds)
	{
		return 0.0;
	}

	[CallerCount(Count = 0)]
	public static ulong SecondsToMilliseconds(double seconds)
	{
		return 0uL;
	}

	[CallerCount(Count = 0)]
	public static ulong MinutesToMilliseconds(double minutes)
	{
		return 0uL;
	}

	[CallerCount(Count = 0)]
	public static ulong HoursToMilliseconds(double hours)
	{
		return 0uL;
	}

	[CallerCount(Count = 0)]
	public static ulong DaysToMilliseconds(double days)
	{
		return 0uL;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public HighResolutionTimer()
	{
	}
}
