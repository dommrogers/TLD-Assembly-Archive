using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class HighResolutionTimerManager : MonoBehaviour
{
	public class HighResolutionTimerManagerSaveDataProxy
	{
		public ulong m_Elapsed;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Stopwatch), Member = "Start")]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnApplicationPause(bool pauseState)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[Calls(Type = typeof(Stopwatch), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stopwatch), Member = "Stop")]
	[Calls(Type = typeof(Stopwatch), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	private void SetTimerPaused(bool shouldPause)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "OnExecute")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CalledBy(Type = typeof(HighResolutionTimerManager), Member = "UpdateTimeScale")]
	[CalledBy(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedDays")]
	[CalledBy(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedHours")]
	[CalledBy(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedSeconds")]
	[CalledBy(Type = typeof(HighResolutionTimerManager), Member = "Serialize")]
	[CalledBy(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[CalledBy(Type = typeof(HighResolutionTimer), Member = "Restart")]
	[CalledBy(Type = typeof(HighResolutionTimer), Member = "Start")]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds")]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMinutes")]
	public ulong GetElapsedMilliseconds()
	{
		return default(ulong);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	public double GetElapsedSeconds()
	{
		return default(double);
	}

	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	[CallerCount(Count = 0)]
	public double GetElapsedMinutes()
	{
		return default(double);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	public double GetElapsedHours()
	{
		return default(double);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	public double GetElapsedDays()
	{
		return default(double);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds")]
	[CallsUnknownMethods(Count = 1)]
	private ulong CalculateElapsedMillisecondsSinceLastBank()
	{
		return default(ulong);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	public void UpdateTimeScale(double timeScale)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public HighResolutionTimerManager()
	{
	}
}
