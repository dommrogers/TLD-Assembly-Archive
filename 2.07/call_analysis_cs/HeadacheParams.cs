using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

[Serializable]
public class HeadacheParams
{
	private delegate void HeadacheStatusChangedEvent(HeadacheStatus status);

	private LocalizedString _003Cm_HeadacheLocalizedId_003Ek__BackingField;

	private LocalizedString _003Cm_HealedAfflictionLocalizedId_003Ek__BackingField;

	private LocalizedString _003Cm_HeadacheDescription_003Ek__BackingField;

	private LocalizedString _003Cm_TreatmentRequiredDescription_003Ek__BackingField;

	private HeadacheStatus _003Cm_HeadacheStatus_003Ek__BackingField;

	private HeadacheCause _003Cm_Cause_003Ek__BackingField;

	private float _003Cm_HoursRequiredIndoorToExitAffliction_003Ek__BackingField;

	private float m_TimeSpentIndoor;

	private float m_TimeSpentOutdoor;

	private float m_StartTimeInGameHours;

	private float m_LastHeadachePulseTime;

	private float m_HeadacheDurationHours;

	private float m_HeadachePulseFrequencyStart;

	private float m_HeadachePulseFrequencyEnd;

	private string m_HeadachePulseEvent;

	private string m_HeadacheStartAudio;

	private string m_HeadacheAfflictionIcoName;

	private float m_HoursRequiredOutdoorToGetAffliction;

	private PanelReference<Panel_HUD> m_HUD;

	private static HeadacheStatusChangedEvent OnHeadacheStatusChanged;

	public LocalizedString m_HeadacheLocalizedId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 80)]
		get
		{
			return null;
		}
		[CallerCount(Count = 279)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	public LocalizedString m_HealedAfflictionLocalizedId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 28)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 79)]
		private set
		{
		}
	}

	public LocalizedString m_HeadacheDescription
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 27)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 55)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public LocalizedString m_TreatmentRequiredDescription
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 25)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 40)]
		private set
		{
		}
	}

	public HeadacheStatus m_HeadacheStatus
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return default(HeadacheStatus);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public HeadacheCause m_Cause
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(HeadacheCause);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		private set
		{
		}
	}

	public float m_HoursRequiredIndoorToExitAffliction
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public HeadacheParams()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public HeadacheParams(HeadacheData data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void OverrideDefaultValue(HeadacheParams oldHp, HeadacheParams newHp)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Headache), Member = "Serialize")]
	[CallsUnknownMethods(Count = 1)]
	public HeadacheParamsSaveDataProxy Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Headache), Member = "Deserialize")]
	public void Deserialize(HeadacheParamsSaveDataProxy saveDataProxy)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CalledBy(Type = typeof(Headache), Member = "ApplyHeadache")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	public void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(HeadacheParams), Member = "HandleOnHeadacheStatusChanged")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	public void Deactivate()
	{
	}

	[CalledBy(Type = typeof(HeadacheParams), Member = "OnWeatherStageChanged")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	public void RemoveRisk()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HeadacheParams), Member = "UpdateTimer")]
	[Calls(Type = typeof(HeadacheParams), Member = "SetStatus")]
	[Calls(Type = typeof(HeadacheParams), Member = "AddHeadacheAffliction")]
	[Calls(Type = typeof(HeadacheParams), Member = "SetStatus")]
	[Calls(Type = typeof(HeadacheParams), Member = "MaybeStartHealing")]
	[CalledBy(Type = typeof(Headache), Member = "Update")]
	[CalledBy(Type = typeof(Headache), Member = "MaybeUpdateHeadaches")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public float GetActiveHoursRemaining()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public bool IsAfflictionActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(HeadacheParams), Member = "MaybeActivate")]
	[CalledBy(Type = typeof(HeadacheParams), Member = "MaybePutOnHoldAfterRisk")]
	[CalledBy(Type = typeof(HeadacheParams), Member = "Update")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[CalledBy(Type = typeof(HeadacheParams), Member = "HandleOnHeadacheStatusChanged")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void AddHeadacheAffliction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	private void ApplyHeadacheExitEffects()
	{
	}

	[CalledBy(Type = typeof(HeadacheParams), Member = "Update")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	private void UpdateTimer()
	{
	}

	[CallerCount(Count = 0)]
	private float HoursRequiredToDeactivateAfflictionRemaining()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private float HoursRequiredToActivateAfflictionRemaining()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(HeadacheParams), Member = "MaybeStartHealing")]
	[CalledBy(Type = typeof(HeadacheParams), Member = "MaybePutOnHoldAfterRisk")]
	[CalledBy(Type = typeof(HeadacheParams), Member = "Update")]
	[CalledBy(Type = typeof(HeadacheParams), Member = "MaybeActivateWithCondition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(HeadacheParams), Member = "Update")]
	public void SetStatus(HeadacheStatus status)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public bool NeedsTreatment()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsUnknownMethods(Count = 3)]
	public void Destroy()
	{
	}

	[Calls(Type = typeof(HeadacheParams), Member = "AddHeadacheAffliction")]
	[Calls(Type = typeof(HeadacheParams), Member = "Deactivate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void HandleOnHeadacheStatusChanged(HeadacheStatus status)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void MaybePutOnHold()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HeadacheParams), Member = "SetStatus")]
	[Calls(Type = typeof(HeadacheParams), Member = "AddHeadacheAffliction")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybePutOnHoldAfterRisk()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(HeadacheParams), Member = "AddHeadacheAffliction")]
	private void MaybeActivate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HeadacheParams), Member = "SetStatus")]
	private void MaybeActivateWithCondition()
	{
	}

	[Calls(Type = typeof(CameraEffects), Member = "HeadachePulse")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup")]
	[Calls(Type = typeof(HeadacheParams), Member = "SetStatus")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CalledBy(Type = typeof(HeadacheParams), Member = "Update")]
	private void MaybeStartHealing()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HeadacheParams), Member = "RemoveRisk")]
	private void OnWeatherStageChanged(WeatherSetStage current)
	{
	}
}
