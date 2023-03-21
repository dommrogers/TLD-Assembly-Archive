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
		[CallerCount(Count = 98)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 265)]
		private set
		{
		}
	}

	public LocalizedString m_HealedAfflictionLocalizedId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
		get
		{
			return null;
		}
		[CallerCount(Count = 85)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		private set
		{
		}
	}

	public LocalizedString m_HeadacheDescription
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 23)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 51)]
		private set
		{
		}
	}

	public LocalizedString m_TreatmentRequiredDescription
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 58)]
		get
		{
			return null;
		}
		[CallerCount(Count = 36)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	public HeadacheStatus m_HeadacheStatus
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return default(HeadacheCause);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
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
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public HeadacheParams()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Headache), Member = "ApplyHeadache")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Headache), Member = "Deserialize")]
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
	[CallsUnknownMethods(Count = 6)]
	public HeadacheParamsSaveDataProxy Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Headache), Member = "Deserialize")]
	public void Deserialize(HeadacheParamsSaveDataProxy saveDataProxy)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(Headache), Member = "ApplyHeadache")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	public void Initialize()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(HeadacheParams), Member = "HandleOnHeadacheStatusChanged")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	public void Deactivate()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CalledBy(Type = typeof(HeadacheParams), Member = "OnWeatherStageChanged")]
	[CallsUnknownMethods(Count = 15)]
	public void RemoveRisk()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Headache), Member = "MaybeUpdateHeadaches")]
	[CalledBy(Type = typeof(Headache), Member = "Update")]
	[Calls(Type = typeof(HeadacheParams), Member = "MaybeStartHealing")]
	[Calls(Type = typeof(HeadacheParams), Member = "AddHeadacheAffliction")]
	[Calls(Type = typeof(HeadacheParams), Member = "SetStatus")]
	[Calls(Type = typeof(HeadacheParams), Member = "UpdateTimer")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HeadacheParams), Member = "SetStatus")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public float GetActiveHoursRemaining()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public bool IsAfflictionActive()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(HeadacheParams), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(HeadacheParams), Member = "MaybeActivate")]
	[CalledBy(Type = typeof(HeadacheParams), Member = "MaybePutOnHoldAfterRisk")]
	[CalledBy(Type = typeof(HeadacheParams), Member = "HandleOnHeadacheStatusChanged")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	private void AddHeadacheAffliction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	private void ApplyHeadacheExitEffects()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(HeadacheParams), Member = "Update")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
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

	[CalledBy(Type = typeof(HeadacheParams), Member = "MaybePutOnHoldAfterRisk")]
	[CalledBy(Type = typeof(HeadacheParams), Member = "MaybeStartHealing")]
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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CalledBy(Type = typeof(Headache), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 8)]
	public void Destroy()
	{
	}

	[Calls(Type = typeof(HeadacheParams), Member = "AddHeadacheAffliction")]
	[Calls(Type = typeof(HeadacheParams), Member = "Deactivate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(HeadacheParams), Member = "AddHeadacheAffliction")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void MaybeActivate()
	{
	}

	[Calls(Type = typeof(HeadacheParams), Member = "SetStatus")]
	[CallerCount(Count = 0)]
	private void MaybeActivateWithCondition()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CalledBy(Type = typeof(HeadacheParams), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(CameraEffects), Member = "HeadachePulse")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup")]
	[Calls(Type = typeof(HeadacheParams), Member = "SetStatus")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	private void MaybeStartHealing()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HeadacheParams), Member = "RemoveRisk")]
	[CallsUnknownMethods(Count = 1)]
	private void OnWeatherStageChanged(WeatherSetStage current)
	{
	}
}
