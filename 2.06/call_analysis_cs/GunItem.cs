using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Gear;
using TLD.Serialization;
using UnityEngine;

public class GunItem : MonoBehaviour
{
	public GunType m_GunType;

	public GearItemData m_AmmoData;

	public GearItemData m_CasingData;

	public bool m_AllowHipFire;

	public int m_RoundsInClip;

	public int m_ClipSize;

	public float m_DamageHP;

	public float m_FiringRateSeconds;

	public float m_ReloadCoolDownSeconds;

	public float m_FireDelayOnAim;

	public float m_FireDelayAfterReload;

	public float m_AccuracyRange;

	public float m_MinDistanceForAimAssist;

	public float m_MuzzleFlash_FlashDelay;

	public float m_MuzzleFlash_SmokeDelay;

	public string m_CasingAudio;

	public string m_DryFireAudio;

	public string m_ImpactAudio;

	public string m_UncockAudio;

	public string m_AmmoSpriteName;

	public MisfireTable m_MisfireTable;

	public string m_MisfirePlayerVO;

	[NonSerialized]
	public List<int> m_Clip;

	[NonSerialized]
	public bool m_HasMisfired;

	private int m_SpentCasingsInClip;

	public static bool m_ForceNoJam;

	public static bool m_ForceJam;

	private float m_WeightOfSingleRoundKG;

	private GearItem m_GearItem;

	public bool m_IsJammed;

	public float m_MultiplierAiming;

	public float m_MultiplierFire;

	public float m_MultiplierReload;

	public float m_SwayValueZeroFatigue;

	public float m_SwayValueMaxFatigue;

	public float m_SwayIncreasePerSecond;

	public float m_SwayDecreasePerSecond;

	public float m_SwayEnergyBoostBonus;

	public float m_SwayEnergyStimBonus;

	public float m_RestartAimingSwayRecoveryTime;

	public float m_AimingSwayDropThresholdPercent;

	public float m_PitchRecoilMin;

	public float m_PitchRecoilMax;

	public float m_YawRecoilMin;

	public float m_YawRecoilMax;

	private float m_SwayValue;

	private float m_SwayRecoverTimer;

	public string m_AimingStaminaExhaustedSound;

	private PlayerControlMode m_RestoreControlMode;

	private static GunItemSaveDataProxy m_GunItemSaveDataProxy;

	private static Action<GameObject> s_OnFlareGunFired;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GunItem), Member = "MaybeDetermineSingleRoundWeight")]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GunItem), Member = "AddRoundsToClip")]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 4)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GunItem), Member = "AddRoundsToClip")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public void AddRangeToClip(List<int> bullets)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_rifle")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_revolver")]
	[CalledBy(Type = typeof(Action_AddBearkillerRifle), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_flaregun")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(GunItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GunItem), Member = "Start")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnBulletLoaded")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(GunItem), Member = "FillClipAtCondition")]
	public void AddRoundsToClip(int count, int condition)
	{
	}

	[CallerCount(Count = 0)]
	public void ClearSpentCasings()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void EmptyClip()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GunItem), Member = "AddRoundsToClip")]
	public void FillClipAtCondition(int condition)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnUnJamComplete")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "DoUnload")]
	public int GetAmmoCondition(int index)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "Refresh")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeShootRevolver")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "Refresh")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "AddGearItemsToDict")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Reload")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Reload")]
	[CallerCount(Count = 10)]
	public int NumRoundsInClip()
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public int NumSpentCasingsInClip()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GunItem), Member = "StruggleRevolverFire")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnUnJamComplete")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallerCount(Count = 4)]
	public void RemoveNextFromClip()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	public int TotalCasingsInClip()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRifle")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[CalledBy(Type = typeof(GunItem), Member = "Update")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	public float GetSwayIncreasePerSecond()
	{
		return default(float);
	}

	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	public float GetSwayDecreasePerSecond()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetCurrentStaminaPercent()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetStaminaDropThresholdPercent()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public bool CanStartAiming()
	{
		return default(bool);
	}

	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_WeaponFatigue")]
	[Calls(Type = typeof(GunItem), Member = "GetSwayIncreasePerSecond")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GunItem), Member = "IsAiming")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	public void Update()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	public void PlayDryFireAudio(GameObject go)
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ZoomStart()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnAiming()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Freezing), Member = "MaybeCancelPlayerFreezingTeethChatter")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim_Cancel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public void ZoomEnd()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnAimingStoppedComplete()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[CallsUnknownMethods(Count = 2)]
	public void ResetControlState()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 0)]
	public void MaybePlayUncockAudio(GameObject go)
	{
	}

	[Calls(Type = typeof(GunItem), Member = "MaybeDetermineSingleRoundWeight")]
	[CallerCount(Count = 0)]
	public float GetClipWeightKG()
	{
		return default(float);
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CalledBy(Type = typeof(GunItem), Member = "Awake")]
	[CalledBy(Type = typeof(GunItem), Member = "GetClipWeightKG")]
	[CallsUnknownMethods(Count = 1)]
	public void MaybeDetermineSingleRoundWeight()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public void SetJammed(bool state)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Reset")]
	[Calls(Type = typeof(SmokeTrail), Member = "InitEffect")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void ResetEffects()
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "IsAllowedToFire")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(GunItem), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private bool IsAiming()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 3)]
	private bool IsEquipped()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	public float GetRecoilPitch()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 2)]
	public float GetRecoilYaw()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnRevolverFired")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "PlayEffect")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "RemoveNextFromClip")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	public void StruggleRevolverFire()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CallsUnknownMethods(Count = 1)]
	public void Fired(GameObject projectile)
	{
	}

	[Calls(Type = typeof(GunItem), Member = "PlayCasingAudio")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void HandleShellDischarge()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 2)]
	public void MaybeHandleMisfire()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MisfireTable), Member = "DoesMisfire")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CallsUnknownMethods(Count = 2)]
	public bool RollForMisfire()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GunItem), Member = "HandleShellDischarge")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Discharge_Shell_Event")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnRoundsUnloaded")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnUnJamComplete")]
	[CallerCount(Count = 4)]
	public void PlayCasingAudio(int count)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GunItem), Member = "IsFiredActionRegistered")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 4)]
	public static void RegisterOnFiredAction(Action<GameObject> action, GunType gunType)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(GunItem), Member = "IsFiredActionRegistered")]
	[CallerCount(Count = 0)]
	public static void UnRegisterOnFiredAction(Action<GameObject> action, GunType gunType)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "op_Inequality")]
	[CalledBy(Type = typeof(GunItem), Member = "RegisterOnFiredAction")]
	[CalledBy(Type = typeof(GunItem), Member = "UnRegisterOnFiredAction")]
	[CalledBy(Type = typeof(RescueZone), Member = "Awake")]
	[CalledBy(Type = typeof(RescueZone), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 4)]
	private static bool IsFiredActionRegistered(Action<GameObject> action, GunType gunType)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	public GunItem()
	{
	}
}
