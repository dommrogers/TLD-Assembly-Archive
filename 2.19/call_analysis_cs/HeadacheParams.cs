using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

[Serializable]
public class HeadacheParams
{
	private LocalizedString _003Cm_CausedByLocalizedId_003Ek__BackingField;

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

	public LocalizedString m_CausedByLocalizedId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 92)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 283)]
		private set
		{
		}
	}

	public LocalizedString m_HeadacheLocalizedId
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 86)]
		private set
		{
		}
	}

	public LocalizedString m_HealedAfflictionLocalizedId
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
		[CallerCount(Count = 57)]
		private set
		{
		}
	}

	public LocalizedString m_HeadacheDescription
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 53)]
		private set
		{
		}
	}

	public LocalizedString m_TreatmentRequiredDescription
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 25)]
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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(HeadacheCause);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
			return 0f;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
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

	[CalledBy(Type = typeof(Headache), Member = "Deserialize")]
	[CalledBy(Type = typeof(Headache), Member = "ApplyHeadache")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public HeadacheParams(HeadacheData data)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void OverrideDefaultValue(HeadacheParams oldHp, HeadacheParams newHp)
	{
	}

	[CalledBy(Type = typeof(Headache), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public HeadacheParamsSaveDataProxy Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(Headache), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	public void Deserialize(HeadacheParamsSaveDataProxy saveDataProxy)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HeadacheParams), Member = "SetStatus")]
	public void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsUnknownMethods(Count = 1)]
	public void Deactivate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HeadacheParams), Member = "SetStatus")]
	public void RemoveRisk()
	{
	}

	[CalledBy(Type = typeof(Headache), Member = "Update")]
	[CalledBy(Type = typeof(Headache), Member = "MaybeUpdateHeadaches")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HeadacheParams), Member = "UpdateTimer")]
	[Calls(Type = typeof(HeadacheParams), Member = "SetStatus")]
	[Calls(Type = typeof(HeadacheParams), Member = "AddHeadacheAffliction")]
	[Calls(Type = typeof(HeadacheParams), Member = "MaybeStartHealing")]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(Headache), Member = "GetActiveHoursRemaining")]
	[CalledBy(Type = typeof(Headache), Member = "GetNormalizedTimeRemaining")]
	[CalledBy(Type = typeof(HeadacheParams), Member = "GetNormalizedTimeRemaining")]
	[CalledBy(Type = typeof(AfflictionButton), Member = "UpdateFillBar")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public float GetActiveHoursRemaining()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HeadacheParams), Member = "GetActiveHoursRemaining")]
	public float GetNormalizedTimeRemaining()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public bool IsAfflictionActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(HeadacheParams), Member = "Update")]
	[CalledBy(Type = typeof(HeadacheParams), Member = "SetStatus")]
	[CalledBy(Type = typeof(HeadacheParams), Member = "MaybePutOnHoldAfterRisk")]
	[CalledBy(Type = typeof(HeadacheParams), Member = "MaybeActivate")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[CallsUnknownMethods(Count = 1)]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateTimer()
	{
	}

	[CallerCount(Count = 0)]
	private float HoursRequiredToDeactivateAfflictionRemaining()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private float HoursRequiredToActivateAfflictionRemaining()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Headache), Member = "ApplyHeadache")]
	[CalledBy(Type = typeof(Headache), Member = "RemoveHeadache")]
	[CalledBy(Type = typeof(HeadacheParams), Member = "Initialize")]
	[CalledBy(Type = typeof(HeadacheParams), Member = "RemoveRisk")]
	[CalledBy(Type = typeof(HeadacheParams), Member = "Update")]
	[CalledBy(Type = typeof(HeadacheParams), Member = "MaybePutOnHold")]
	[CalledBy(Type = typeof(HeadacheParams), Member = "MaybePutOnHoldAfterRisk")]
	[CalledBy(Type = typeof(HeadacheParams), Member = "MaybeActivate")]
	[CalledBy(Type = typeof(HeadacheParams), Member = "MaybeActivateWithCondition")]
	[CalledBy(Type = typeof(HeadacheParams), Member = "MaybeStartHealing")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(HeadacheParams), Member = "AddHeadacheAffliction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsUnknownMethods(Count = 1)]
	public void SetStatus(HeadacheStatus status)
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 1)]
	public bool NeedsTreatment()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HeadacheParams), Member = "SetStatus")]
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
	[Calls(Type = typeof(HeadacheParams), Member = "AddHeadacheAffliction")]
	[Calls(Type = typeof(HeadacheParams), Member = "SetStatus")]
	private void MaybeActivate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HeadacheParams), Member = "SetStatus")]
	private void MaybeActivateWithCondition()
	{
	}

	[CalledBy(Type = typeof(HeadacheParams), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HeadacheParams), Member = "SetStatus")]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(CameraEffects), Member = "HeadachePulse")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeStartHealing()
	{
	}
}
