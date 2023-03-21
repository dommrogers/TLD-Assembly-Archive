using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Conditions;
using TLD.Serialization;
using UnityEngine;

public class MissionTimer
{
	public enum MissionTimerOptions
	{
		None = 0,
		Realtime = 1,
		AccountsForLoadingTime = 2,
		Countdown = 4,
		ShowOnHud = 8,
		RemoveOnExpire = 0x10
	}

	private const float HOURS_TO_SECONDS_SCALAR = 3600f;

	private const float SECONDS_TO_HOURS_SCALAR = 0.00027777778f;

	private const float SECONDS_PER_TICK = 1E-07f;

	private static MissionTimerSaveProxy m_MissionTimerSaveProxy;

	private DateTime m_TimerStartTime;

	private Panel_Loading m_Loading;

	public const string TIMER_DATE_FORMAT = "yyyy-mm-dd H:mm:ss";

	public MissionManagerBase m_MissionManager;

	public MissionServicesManager m_MainMissionManager;

	public string m_Name;

	public MissionTimerType m_Type;

	public bool m_IsRealtime;

	public float m_Duration;

	public float m_BaseTime;

	public bool m_ShowOnHUD;

	public string m_EventOnExpire;

	public bool m_RemoveOnExpire;

	private bool m_ExpireHandled;

	private float m_ElapsedFromSave;

	private bool m_AccountsForLoadingTime;

	public static bool s_Debug;

	public float Time
	{
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(MissionTimer), Member = "get_ElapsedTime")]
		[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateTimerObjectiveUI")]
		[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateTimerObjectiveUI")]
		[CalledBy(Type = typeof(Panel_Map), Member = "RefreshHoverIconText")]
		[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
		[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
		get
		{
			return default(float);
		}
	}

	public float ElapsedTime
	{
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(Condition_IsTimeActive), Member = "OnCheck")]
		[CalledBy(Type = typeof(MissionTimer), Member = "GetDebugString")]
		[CalledBy(Type = typeof(MissionTimer), Member = "Update")]
		[CalledBy(Type = typeof(MissionTimer), Member = "Serialize")]
		[CalledBy(Type = typeof(MissionTimer), Member = "get_Time")]
		[Calls(Type = typeof(MissionTimer), Member = "GetAllSecondsElapsedSinceTimerStarted")]
		[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
		[CalledBy(Type = typeof(StoryMissionListEntry), Member = "Refresh")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 8)]
		[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
		get
		{
			return default(float);
		}
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "StartMissionTimer")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "DeserializeTimers")]
	public MissionTimer(MissionServicesManager mainMissionManager, MissionManagerBase manager, string name)
	{
	}

	[CalledBy(Type = typeof(MissionTimer), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "StartMissionTimer")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionTimer), Member = "GetAllSecondsElapsedSinceTimerStarted")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	public void Initialize(MissionTimerType type, float duration, string eventOnExpire, MissionTimerOptions timerOptions)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionTimer), Member = "get_ElapsedTime")]
	[Calls(Type = typeof(System.DateTimeFormat), Member = "Format")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionTimer), Member = "Initialize")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_InvariantInfo")]
	[Calls(Type = typeof(DateTime), Member = "ParseExact")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "DeserializeTimers")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void PostDeserialize()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(MissionTimer), Member = "get_ElapsedTime")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	public bool Update()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallerCount(Count = 0)]
	public void PostExpireEvent()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[CalledBy(Type = typeof(MissionTimer), Member = "Initialize")]
	[CalledBy(Type = typeof(MissionTimer), Member = "get_ElapsedTime")]
	private float GetAllSecondsElapsedSinceTimerStarted()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public string GetTimerTypeString()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetMissionTimerDebugText")]
	[CalledBy(Type = typeof(MissionTimer), Member = "GetDebugText")]
	[Calls(Type = typeof(MissionTimer), Member = "get_ElapsedTime")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format")]
	public string GetDebugString()
	{
		return null;
	}

	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MissionTimer), Member = "GetDebugString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static string GetDebugText()
	{
		return null;
	}
}
