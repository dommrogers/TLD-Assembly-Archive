using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class SprainedWrist : MonoBehaviour
{
	public enum CanEquipItemResult
	{
		Success,
		CannotEquipWeapon,
		CannotEquip2HandedWeapon
	}

	public LocalizedString m_LocalizedDisplayName;

	public LocalizedString m_LocalizedDescription;

	public float m_ChanceSprainAfterFall;

	public float m_DurationHoursMin;

	public float m_DurationHoursMax;

	public float m_NumHoursRestForCure;

	public string m_SprainedWristVO;

	public string m_SprainedWristSFX;

	private string m_StumblePainAudio;

	private float m_StumbleCameraTiltMin;

	private float m_StumbleCameraTiltMax;

	private PanelReference<Panel_FirstAid> m_FirstAid;

	private PanelReference<Panel_HUD> m_HUD;

	private List<string> m_CausesLocIDs;

	private List<int> m_Locations;

	private List<float> m_ElapsedHoursList;

	private List<float> m_DurationHoursList;

	private List<float> m_ElapsedRestList;

	private bool m_IsNoSprainWristForced;

	private static SprainedWristSaveDataProxy m_SprainedWristSaveDataProxy;

	public string m_DisplayName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string m_Description
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[DeduplicatedMethod]
		[CallerCount(Count = 13)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SprainedWrist), Member = "UpdateSprainedWrist")]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(SprainedWrist), Member = "UnequipItemInHands")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool LocationAvailable()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SprainedWristEvent), Member = "OnExecute")]
	[Calls(Type = typeof(SprainedWrist), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(GameManager), Member = "TriggerSurvivalSaveAndDisplayHUDMessage")]
	[CalledBy(Type = typeof(SprainedWristEvent), Member = "OnExecute")]
	[CalledBy(Type = typeof(FallDamage), Member = "MaybeSprainWrist")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWrist")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_sprain_wrist")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_sprain_wrist_nofx")]
	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[Calls(Type = typeof(SprainPain), Member = "ApplyAffliction")]
	[Calls(Type = typeof(StatsManager), Member = "IncrementValue")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ApplyFallImpact")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnDamageEvent")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public void SprainedWristStart(string causeId, AfflictionOptions options)
	{
	}

	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAffliction")]
	[CalledBy(Type = typeof(SprainedWrist), Member = "UpdateSprainedWrist")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CalledBy(Type = typeof(SprainedWrist), Member = "ApplyBandage")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public void SprainedWristEnd(int index)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasSprainedWrist()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public float GetRestAmountRemaining(int index)
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasSprainNeedingRest()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public bool RequiresBandage()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	public AfflictionBodyArea GetLocation(int index)
	{
		return default(AfflictionBodyArea);
	}

	[CalledBy(Type = typeof(Panel_Actions), Member = "RefreshScrollList")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string[] GetCauseLocIDList()
	{
		return null;
	}

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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristEnd")]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyBandage(int localAfflictionIndex)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_sprain_wrist_cure")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_afflictions_cure")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_FirstAid), Member = "UpdateDueToAfflictionHealed")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	public void Cure()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void AddRest(float hours)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SprainedWrist), Member = "SprainedWristEnd")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SprainedWrist), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateSprainedWrist(int index)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsNoSprainWristForced()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetForceNoSprainWrist(bool isNoSprainWristForced)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EquipItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(SprainedWrist), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseWeaponInventoryItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	public CanEquipItemResult CanEquipItem(GearItem gi)
	{
		return default(CanEquipItemResult);
	}

	[CalledBy(Type = typeof(SprainedWrist), Member = "SprainedWristStart")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "UnequipItemInHands")]
	[Calls(Type = typeof(SprainedWrist), Member = "CanEquipItem")]
	[CalledBy(Type = typeof(SprainedWrist), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	private void UnequipItemInHands()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "ApplyFallImpact")]
	[CallsUnknownMethods(Count = 4)]
	private void DoStumbleEffects(bool alreadyInjured = false)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 34)]
	public SprainedWrist()
	{
	}
}
