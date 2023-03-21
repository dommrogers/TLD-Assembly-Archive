using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class HighResolutionTimerManager : MonoBehaviour
{
	public class HighResolutionTimerManagerSaveDataProxy
	{
		public ulong m_Elapsed;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(HighResolutionTimer), Member = "Start")]
	[CalledBy(Type = typeof(HighResolutionTimer), Member = "Restart")]
	[CalledBy(Type = typeof(HighResolutionTimer), Member = "GetElapsedMilliseconds")]
	[CalledBy(Type = typeof(HighResolutionTimerManager), Member = "Serialize")]
	[CalledBy(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedSeconds")]
	[CalledBy(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMinutes")]
	[CalledBy(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedHours")]
	[CalledBy(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedDays")]
	[CalledBy(Type = typeof(HighResolutionTimerManager), Member = "UpdateTimeScale")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "SetDayLengthScale")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateVisuals")]
	[CalledBy(Type = typeof(Action_NomadRequirements), Member = "OnExecute")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds")]
	[CallsUnknownMethods(Count = 1)]
	public ulong GetElapsedMilliseconds()
	{
		return 0uL;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	public double GetElapsedSeconds()
	{
		return 0.0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	public double GetElapsedMinutes()
	{
		return 0.0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	public double GetElapsedHours()
	{
		return 0.0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	public double GetElapsedDays()
	{
		return 0.0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds")]
	[CallsUnknownMethods(Count = 1)]
	private ulong CalculateElapsedMillisecondsSinceLastBank()
	{
		return 0uL;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HighResolutionTimerManager), Member = "GetElapsedMilliseconds")]
	[CallsUnknownMethods(Count = 3)]
	public void UpdateTimeScale(double timeScale)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public HighResolutionTimerManager()
	{
	}
}
