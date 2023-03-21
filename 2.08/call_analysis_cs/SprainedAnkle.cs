using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class SprainedAnkle : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public LocalizedString m_LocalizedDescription;

	public float m_ChanceSprainAfterFall;

	public float m_DurationHoursMin;

	public float m_DurationHoursMax;

	public float m_NumHoursRestForCure;

	public float m_MinSecondsBetweenPainAudio;

	public float m_MaxSecondsBetweenPainAudio;

	public float m_LimpCameraTiltMin;

	public float m_LimpCameraTiltMax;

	public float m_StumbleCameraTiltMin;

	public float m_StumbleCameraTiltMax;

	public string m_SprainedAnkleVO;

	public string m_StumblePainAudio;

	public string m_StumblePainMinorAudio;

	public string m_SprainedAnkleSFX;

	public string m_LimpAudio;

	public float m_LimpAudioDelay;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	private PanelReference<Panel_HUD> m_HUD;

	private float m_NextLimpAudio;

	private float m_SecondsSinceLastPainAudio;

	private float m_SecondsUntilNextPainAudio;

	private List<string> m_CausesLocIDs;

	private List<int> m_Locations;

	private List<float> m_ElapsedHoursList;

	private List<float> m_DurationHoursList;

	private List<float> m_ElapsedRestList;

	private static SprainedAnkleSaveDataProxy m_SprainedAnkleSaveDataProxy;

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

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetPlayerMovement")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetBool")]
	private void UpdateLimpAnimation()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SprainedAnkle), Member = "UpdateLimpAnimation")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SprainedAnkle), Member = "UpdateSprainedAnkle")]
	public void Update()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallsUnknownMethods(Count = 5)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 11)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool LocationAvailable()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SprainedAnkleEvent), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SprainedAnkleEvent), Member = "OnExecute")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameManager), Member = "SaveGameAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(FallDamage), Member = "MaybeSprainAnkle")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_sprain_ankle")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_sprain_ankle_nofx")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_sprain_ankle_nofx_unique")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainAnkle")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(SprainPain), Member = "ApplyAffliction")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ApplyFallImpact")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public void SprainedAnkleStart(string causeID, AfflictionOptions options)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "UpdateSprainedAnkle")]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "ApplyBandage")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	public void SprainedAnkleEnd(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 4)]
	public AfflictionBodyArea GetLocation(int index)
	{
		return default(AfflictionBodyArea);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasSprainedAnkle()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public bool HasSprainedLeftAnkle()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string[] GetCauseLocIDList()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 2)]
	public float GetRestAmountRemaining(int index)
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasSprainNeedingRest()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	public bool RequiresBandage()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleEnd")]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyBandage(int localAfflictionIndex)
	{
	}

	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_sprain_ankle_cure")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	public void Cure()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public void AddRest(float hours)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SprainedAnkle), Member = "SprainedAnkleEnd")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsWalking")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateSprainedAnkle(int index)
	{
	}

	[CalledBy(Type = typeof(FootStepSounds), Member = "AddMoveDistance")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SprainedAnkle), Member = "MaybeLimpOrStumbleWithFootStep")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ApplyFallImpact")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public void DoLimpAnimation()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 2)]
	public void MaybeDoLimpAudio()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(FootStepSounds), Member = "AddMoveDistance")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SprainedAnkle), Member = "DoLimpAnimation")]
	public bool MaybeLimpOrStumbleWithFootStep(bool left)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ApplyFallImpact")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private void DoStumbleEffects(bool alreadyInjured = false)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public SprainedAnkle()
	{
	}
}
