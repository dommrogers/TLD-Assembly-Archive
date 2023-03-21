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
	[Calls(Type = typeof(Component), Member = "GetComponent")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(GunItem), Member = "AddRoundsToClip")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void AddRangeToClip(List<int> bullets)
	{
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnBulletLoaded")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GunItem), Member = "Start")]
	[CalledBy(Type = typeof(GunItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(GunItem), Member = "FillClipAtCondition")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_flaregun")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_revolver")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_rifle")]
	[CalledBy(Type = typeof(Action_AddBearkillerRifle), Member = "OnExecute")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnUnJamComplete")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "DoUnload")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public int GetAmmoCondition(int index)
	{
		return 0;
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Reload")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "Refresh")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "Refresh")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "AddGearItemsToDict")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Equip")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "MaybeShootRevolver")]
	[CallerCount(Count = 10)]
	public int NumRoundsInClip()
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public int NumSpentCasingsInClip()
	{
		return 0;
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnUnJamComplete")]
	[CalledBy(Type = typeof(GunItem), Member = "StruggleRevolverFire")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveNextFromClip()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[CallerCount(Count = 1)]
	public int TotalCasingsInClip()
	{
		return 0;
	}

	[CalledBy(Type = typeof(GunItem), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRifle")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallsUnknownMethods(Count = 4)]
	public float GetSwayIncreasePerSecond()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[CallsUnknownMethods(Count = 3)]
	public float GetSwayDecreasePerSecond()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetCurrentStaminaPercent()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetStaminaDropThresholdPercent()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public bool CanStartAiming()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GunItem), Member = "IsAiming")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GunItem), Member = "GetSwayIncreasePerSecond")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_WeaponFatigue")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[CallsUnknownMethods(Count = 6)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public void PlayDryFireAudio(GameObject go)
	{
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void ZoomStart()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnAiming()
	{
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim_Cancel")]
	[Calls(Type = typeof(Freezing), Member = "MaybeCancelPlayerFreezingTeethChatter")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	public void MaybePlayUncockAudio(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GunItem), Member = "MaybeDetermineSingleRoundWeight")]
	public float GetClipWeightKG()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CalledBy(Type = typeof(GunItem), Member = "Awake")]
	[CalledBy(Type = typeof(GunItem), Member = "GetClipWeightKG")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	public void MaybeDetermineSingleRoundWeight()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public void SetJammed(bool state)
	{
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Reset")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(SmokeTrail), Member = "InitEffect")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void ResetEffects()
	{
	}

	[CalledBy(Type = typeof(GunItem), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerAnimation), Member = "IsAllowedToFire")]
	[CallsUnknownMethods(Count = 4)]
	private bool IsAiming()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 3)]
	private bool IsEquipped()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 2)]
	public float GetRecoilPitch()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 2)]
	public float GetRecoilYaw()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnRevolverFired")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GunItem), Member = "RemoveNextFromClip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "PlayEffect")]
	[Calls(Type = typeof(MissionServicesManager), Member = "BroadcastMissionEvent")]
	[CallsUnknownMethods(Count = 3)]
	public void StruggleRevolverFire()
	{
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Fired(GameObject projectile)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[Calls(Type = typeof(GunItem), Member = "PlayCasingAudio")]
	[CallsUnknownMethods(Count = 2)]
	public void HandleShellDischarge()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 2)]
	public void MaybeHandleMisfire()
	{
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MisfireTable), Member = "DoesMisfire")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public bool RollForMisfire()
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnUnJamComplete")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnRoundsUnloaded")]
	[CalledBy(Type = typeof(GunItem), Member = "HandleShellDischarge")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Discharge_Shell_Event")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GunItem), Member = "IsFiredActionRegistered")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsUnknownMethods(Count = 4)]
	public static void UnRegisterOnFiredAction(Action<GameObject> action, GunType gunType)
	{
	}

	[CalledBy(Type = typeof(GunItem), Member = "RegisterOnFiredAction")]
	[CalledBy(Type = typeof(GunItem), Member = "UnRegisterOnFiredAction")]
	[CalledBy(Type = typeof(RescueZone), Member = "Awake")]
	[CalledBy(Type = typeof(RescueZone), Member = "OnDestroy")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Delegate), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static bool IsFiredActionRegistered(Action<GameObject> action, GunType gunType)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	public GunItem()
	{
	}
}
