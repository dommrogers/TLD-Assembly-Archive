using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string m_Description
	{
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BrokenRib), Member = "BrokenRibEnd")]
	[Calls(Type = typeof(BrokenRib), Member = "GetBrokenRibCount")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 59)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 3)]
	public void PlayBrokenRibAudio()
	{
	}

	[CallsUnknownMethods(Count = 36)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ApplyDamageAfterMooseAttack")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_brokenrib_minor_nofx")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_brokenrib_nofx")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_brokenrib_minor")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_brokenrib")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	public void BrokenRibStart(string causeID, bool displayIcon, bool noVO = false, bool isMinor = false, bool autoSave = true, float recoveryTimeModifier = 0f)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(BrokenRib), Member = "Cure")]
	[CalledBy(Type = typeof(BrokenRib), Member = "AddRest")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(BrokenRib), Member = "Update")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[Calls(Type = typeof(BrokenRib), Member = "GetBrokenRibCount")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(BrokenRib), Member = "GetBrokenRibCount")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	public void BrokenRibEnd(int localIndex)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RequiresBandage")]
	[CalledBy(Type = typeof(BrokenRib), Member = "ApplyBandage")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CalledBy(Type = typeof(BrokenRib), Member = "GetRequiredBandages")]
	[CallsUnknownMethods(Count = 2)]
	public bool RequiresBandage(int localIndex)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresBandage")]
	public int GetRequiredBandages(int localIndex)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RequiresPainKiller")]
	[CalledBy(Type = typeof(BrokenRib), Member = "TakePainKillers")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BrokenRib), Member = "GetRequiredPainKiller")]
	public bool RequiresPainKiller(int localIndex)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresPainKiller")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 2)]
	public int GetRequiredPainKiller(int localIndex)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CallsUnknownMethods(Count = 2)]
	public AfflictionBodyArea GetLocation(int index)
	{
		return default(AfflictionBodyArea);
	}

	[Calls(Type = typeof(BrokenRib), Member = "GetBrokenRibCount")]
	[CallerCount(Count = 0)]
	public bool HasBrokenRib()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public string[] GetCauseLocIDList()
	{
		return null;
	}

	[CalledBy(Type = typeof(BrokenRib), Member = "GetAfflictionsCount")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetNormalizedSprintReduction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CalledBy(Type = typeof(RopeClimbPoint), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(BrokenRib), Member = "BrokenRibEnd")]
	[CalledBy(Type = typeof(BrokenRib), Member = "HasBrokenRib")]
	[CalledBy(Type = typeof(BrokenRib), Member = "Update")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateRestForCures")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[CalledBy(Type = typeof(Condition), Member = "HasSpecificAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(BrokenRib), Member = "BrokenRibEnd")]
	public int GetBrokenRibCount()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BrokenRib), Member = "GetBrokenRibCount")]
	public int GetAfflictionsCount()
	{
		return default(int);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string GetAfflictionCauseLocalizationId(int localAfflictionIndex)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresPainKiller")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void TakePainKillers(int localAfflictionIndex, int paintKillerCount)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresBandage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 3)]
	public void ApplyBandage(int localAfflictionIndex, int bandageCount)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_brokenrib_cure")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BrokenRib), Member = "BrokenRibEnd")]
	public void Cure()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BrokenRib), Member = "BrokenRibEnd")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(PassTime), Member = "UpdatePassingTime")]
	[CalledBy(Type = typeof(Rest), Member = "UpdateRestForCures")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 2)]
	public void AddRest(float hours)
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public float GetRestAmountRemaining(int index)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 1)]
	public float GetNumHoursRestForCure(int index)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 67)]
	public BrokenRib()
	{
	}
}
