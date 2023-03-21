using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Conditions;
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
		[CalledBy(Type = typeof(Panel_Map), Member = "RefreshHoverIconText")]
		[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
		[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
		[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
		[CalledBy(Type = typeof(StoryMissionListEntry), Member = "Refresh")]
		[CallerCount(Count = 7)]
		[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateTimerObjectiveUI")]
		[Calls(Type = typeof(MissionTimer), Member = "get_ElapsedTime")]
		[Calls(Type = typeof(MissionTimer), Member = "get_ElapsedTime")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateTimerObjectiveUI")]
		get
		{
			return default(float);
		}
	}

	public float ElapsedTime
	{
		[CalledBy(Type = typeof(MissionTimer), Member = "Update")]
		[CallsUnknownMethods(Count = 4)]
		[CalledBy(Type = typeof(MissionTimer), Member = "GetDebugString")]
		[CalledBy(Type = typeof(MissionTimer), Member = "Serialize")]
		[CalledBy(Type = typeof(Condition_IsTimeActive), Member = "OnCheck")]
		[CalledBy(Type = typeof(MissionTimer), Member = "get_Time")]
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(MissionTimer), Member = "get_Time")]
		[Calls(Type = typeof(MissionTimer), Member = "GetAllSecondsElapsedSinceTimerStarted")]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return default(float);
		}
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "StartMissionTimer")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "DeserializeTimers")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public MissionTimer(MissionServicesManager mainMissionManager, MissionManagerBase manager, string name)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(MissionTimer), Member = "Deserialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "StartMissionTimer")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(MissionTimer), Member = "GetAllSecondsElapsedSinceTimerStarted")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	public void Initialize(MissionTimerType type, float duration, string eventOnExpire, MissionTimerOptions timerOptions)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionTimer), Member = "get_ElapsedTime")]
	[Calls(Type = typeof(DateTime), Member = "ToString")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 9)]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(DateTime), Member = "ParseExact")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "DeserializeTimers")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_InvariantInfo")]
	[Calls(Type = typeof(MissionTimer), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void PostDeserialize()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(MissionTimer), Member = "get_ElapsedTime")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	public bool Update()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	public void PostExpireEvent()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[CalledBy(Type = typeof(MissionTimer), Member = "Initialize")]
	[CalledBy(Type = typeof(MissionTimer), Member = "get_ElapsedTime")]
	private float GetAllSecondsElapsedSinceTimerStarted()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetTimerTypeString()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(MissionTimer), Member = "GetDebugText")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetMissionTimerDebugText")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionTimer), Member = "get_ElapsedTime")]
	public string GetDebugString()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MissionTimer), Member = "GetDebugString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	public static string GetDebugText()
	{
		return null;
	}
}
