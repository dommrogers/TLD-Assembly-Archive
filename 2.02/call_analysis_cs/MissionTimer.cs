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
		[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateTimerObjectiveUI")]
		[CalledBy(Type = typeof(StoryMissionListEntry), Member = "Refresh")]
		[CalledBy(Type = typeof(Panel_Map), Member = "RefreshHoverIconText")]
		[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
		[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(MissionTimer), Member = "get_ElapsedTime")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return 0f;
		}
	}

	public float ElapsedTime
	{
		[CalledBy(Type = typeof(MissionTimer), Member = "get_Time")]
		[CalledBy(Type = typeof(MissionTimer), Member = "Serialize")]
		[CalledBy(Type = typeof(MissionTimer), Member = "Update")]
		[CalledBy(Type = typeof(MissionTimer), Member = "GetDebugString")]
		[CalledBy(Type = typeof(Condition_IsTimeActive), Member = "OnCheck")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(MissionTimer), Member = "GetAllSecondsElapsedSinceTimerStarted")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		get
		{
			return 0f;
		}
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "StartMissionTimer")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "DeserializeTimers")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[CallsDeduplicatedMethods(Count = 1)]
	public MissionTimer(MissionServicesManager mainMissionManager, MissionManagerBase manager, string name)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "StartMissionTimer")]
	[CalledBy(Type = typeof(MissionTimer), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(MissionTimer), Member = "GetAllSecondsElapsedSinceTimerStarted")]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public void Initialize(MissionTimerType type, float duration, string eventOnExpire, MissionTimerOptions timerOptions)
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionTimer), Member = "get_ElapsedTime")]
	[Calls(Type = typeof(DateTime), Member = "ToString")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "DeserializeTimers")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(MissionTimer), Member = "Initialize")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_InvariantInfo")]
	[Calls(Type = typeof(DateTime), Member = "ParseExact")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void PostDeserialize()
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(MissionTimer), Member = "get_ElapsedTime")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool Update()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsUnknownMethods(Count = 1)]
	public void PostExpireEvent()
	{
	}

	[CalledBy(Type = typeof(MissionTimer), Member = "Initialize")]
	[CalledBy(Type = typeof(MissionTimer), Member = "get_ElapsedTime")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetAllSecondsElapsedSinceTimerStarted()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetTimerTypeString()
	{
		return null;
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetMissionTimerDebugText")]
	[CalledBy(Type = typeof(MissionTimer), Member = "GetDebugText")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionTimer), Member = "get_ElapsedTime")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	public string GetDebugString()
	{
		return null;
	}

	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MissionTimer), Member = "GetDebugString")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static string GetDebugText()
	{
		return null;
	}
}
