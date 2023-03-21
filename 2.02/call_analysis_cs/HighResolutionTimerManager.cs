using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class HighResolutionTimerManager : MonoBehaviour
{
	public class HighResolutionTimerManagerSaveDataProxy
	{
		public ulong m_Elapsed;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public HighResolutionTimerManagerSaveDataProxy()
		{
		}
	}

	private const double DAY_IN_SECONDS = 86400.0;

	private Stopwatch m_StopWatch;

	private ulong m_Elapsed;

	private bool m_HasCalculatedBaseScale;

	private double m_BaseScale;

	private double m_CurrentTimeScale;

	private static HighResolutionTimerManagerSaveDataProxy s_TimerManagerSaveDataProxy;

	public static bool s_TimeAccumulationDebug;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[Calls(Type = typeof(Stopwatch), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	private void OnApplicationPause(bool pauseState)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[Calls(Type = typeof(Stopwatch), Member = "Start")]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[Calls(Type = typeof(Stopwatch), Member = "Start")]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void SetTimerPaused(bool shouldPause)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Stopwatch), Member = "Restart")]
	[CallsUnknownMethods(Count = 5)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(HighResolutionTimerManager), Member = "UpdateTimeScale")]
	[CalledBy(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedDays")]
	[CalledBy(Type = typeof(HighResolutionTimer), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedHours")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CalledBy(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMinutes")]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds")]
	[CalledBy(Type = typeof(HighResolutionTimerManager), Member = "Serialize")]
	[CalledBy(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[CalledBy(Type = typeof(HighResolutionTimer), Member = "Restart")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedSeconds")]
	public ulong GetElapsedMilliseconds()
	{
		return default(ulong);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	public double GetElapsedSeconds()
	{
		return default(double);
	}

	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public double GetElapsedMinutes()
	{
		return default(double);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	public double GetElapsedHours()
	{
		return default(double);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	public double GetElapsedDays()
	{
		return default(double);
	}

	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private ulong CalculateElapsedMillisecondsSinceLastBank()
	{
		return default(ulong);
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Stopwatch), Member = "Restart")]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public void UpdateTimeScale(double timeScale)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public HighResolutionTimerManager()
	{
	}
}
