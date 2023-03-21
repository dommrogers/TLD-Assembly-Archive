using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;

public class HighResolutionTimer
{
	private class HighResolutionTimerSaveDataProxy
	{
		public ulong m_ElapsedTime;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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
	[CallsUnknownMethods(Count = 6)]
	public static HighResolutionTimer FromMilliseconds(ulong milliseconds)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public static HighResolutionTimer FromSeconds(double seconds)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public static HighResolutionTimer FromMinutes(double minutes)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public static HighResolutionTimer FromHours(double hours)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public static HighResolutionTimer FromDays(double days)
	{
		return null;
	}

	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(PassTime), Member = "Begin")]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	[CallerCount(Count = 2)]
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
	[CalledBy(Type = typeof(PassTime), Member = "End")]
	[CalledBy(Type = typeof(PassTime), Member = "UpdatePassingTime")]
	[CalledBy(Type = typeof(HighResolutionTimer), Member = "Serialize")]
	[CalledBy(Type = typeof(PassTime), Member = "GetNumHoursRemaining")]
	[CalledBy(Type = typeof(HighResolutionTimer), Member = "GetElapsedHours")]
	[CalledBy(Type = typeof(HighResolutionTimer), Member = "GetElapsedMinutes")]
	[CalledBy(Type = typeof(HighResolutionTimer), Member = "GetElapsedSeconds")]
	[CalledBy(Type = typeof(HighResolutionTimer), Member = "GetElapsedDays")]
	[CalledBy(Type = typeof(HighResolutionTimer), Member = "Stop")]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	[CallerCount(Count = 11)]
	public ulong GetElapsedMilliseconds()
	{
		return default(ulong);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	public float GetElapsedSeconds()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	public float GetElapsedMinutes()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(PassTime), Member = "End")]
	[CalledBy(Type = typeof(PassTime), Member = "UpdatePassingTime")]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[CallerCount(Count = 2)]
	public float GetElapsedHours()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	public float GetElapsedDays()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public HighResolutionTimer()
	{
	}
}
