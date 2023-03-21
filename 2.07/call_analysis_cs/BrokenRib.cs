using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class BrokenRib : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public LocalizedString m_LocalizedDescription;

	public float m_FirstRibRecoveryTimeDays;

	public float m_SecondaryRibRecoveryTimeDays;

	public float m_SprintStaminaReduction;

	public float m_CarryingCapacityReduction;

	public int m_PainKillersRequiredPerInstance;

	public int m_BandagesRequiredPerInstance;

	public string m_StartAudioID;

	public string m_BrokenRibVO;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	private PanelReference<Panel_HUD> m_HUD;

	private List<string> m_CausesLocIDs;

	private List<int> m_Locations;

	private List<int> m_PainKillersTaken;

	private List<int> m_BandagesApplied;

	private List<float> m_ElapsedRestList;

	private List<float> m_NumHoursRestForCureList;

	private bool m_StartHasBeenCalled;

	private static BrokenRibSaveDataProxy m_BrokenRibSaveDataProxy;

	public string m_DisplayName
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public string m_Description
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BrokenRib), Member = "BrokenRibEnd")]
	public void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 6)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool LocationAvailable()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 2)]
	public void PlayBrokenRibAudio()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyDamageAfterMooseAttack")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_brokenrib_minor_nofx")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_brokenrib_nofx")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_brokenrib_minor")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_brokenrib")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	public void BrokenRibStart(string causeID, bool displayIcon, bool noVO = false, bool isMinor = false, bool autoSave = true, float recoveryTimeModifier = 0f)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_brokenrib_cure")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CalledBy(Type = typeof(BrokenRib), Member = "AddRest")]
	[CalledBy(Type = typeof(BrokenRib), Member = "Cure")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BrokenRib), Member = "Update")]
	public void BrokenRibEnd(int localIndex)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RequiresBandage")]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CalledBy(Type = typeof(BrokenRib), Member = "GetRequiredBandages")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(BrokenRib), Member = "ApplyBandage")]
	public bool RequiresBandage(int localIndex)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresBandage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 2)]
	public int GetRequiredBandages(int localIndex)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RequiresPainKiller")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BrokenRib), Member = "GetRequiredPainKiller")]
	[CalledBy(Type = typeof(BrokenRib), Member = "TakePainKillers")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public bool RequiresPainKiller(int localIndex)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresPainKiller")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 2)]
	public int GetRequiredPainKiller(int localIndex)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public AfflictionBodyArea GetLocation(int index)
	{
		return default(AfflictionBodyArea);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallsUnknownMethods(Count = 1)]
	public bool HasBrokenRib()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string[] GetCauseLocIDList()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int GetBrokenRibCount()
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetAfflictionsCount()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public string GetAfflictionCauseLocalizationId(int localAfflictionIndex)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresPainKiller")]
	public void TakePainKillers(int localAfflictionIndex, int paintKillerCount)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresBandage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void ApplyBandage(int localAfflictionIndex, int bandageCount)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BrokenRib), Member = "BrokenRibEnd")]
	[CallsUnknownMethods(Count = 1)]
	public void Cure()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Rest), Member = "UpdateRestForCures")]
	[CalledBy(Type = typeof(PassTime), Member = "UpdatePassingTime")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BrokenRib), Member = "BrokenRibEnd")]
	[CallerCount(Count = 2)]
	public void AddRest(float hours)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 2)]
	public float GetRestAmountRemaining(int index)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public float GetNumHoursRestForCure(int index)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public BrokenRib()
	{
	}
}
