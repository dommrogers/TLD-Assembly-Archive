using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class GunItem : MonoBehaviour
{
	public GunType m_GunType;

	public GameObject m_AmmoPrefab;

	public GameObject m_CasingPrefab;

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

	[Calls(Type = typeof(GunItem), Member = "MaybeDetermineSingleRoundWeight")]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GunItem), Member = "AddRoundsToClip")]
	public void Start()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallsUnknownMethods(Count = 5)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GunItem), Member = "AddRoundsToClip")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnClipLoaded")]
	[CallsUnknownMethods(Count = 6)]
	public void AddRangeToClip(List<int> bullets)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Action_AddBearkillerRifle), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_rifle")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_flaregun")]
	[CalledBy(Type = typeof(GunItem), Member = "FillClipAtCondition")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_revolver")]
	[CalledBy(Type = typeof(GunItem), Member = "Start")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnBulletLoaded")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(GunItem), Member = "Deserialize")]
	public void AddRoundsToClip(int count, int condition)
	{
	}

	[CallerCount(Count = 0)]
	public void ClearSpentCasings()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "DoUnload")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnRefuel")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EmptyClip()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GunItem), Member = "AddRoundsToClip")]
	public void FillClipAtCondition(int condition)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "DoUnload")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnUnJamComplete")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public int GetAmmoCondition(int index)
	{
		return default(int);
	}

	[CallerCount(Count = 43)]
	[CallsDeduplicatedMethods(Count = 1)]
	public int NumRoundsInClip()
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	public int NumSpentCasingsInClip()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnUnJamComplete")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(GunItem), Member = "StruggleRevolverFire")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void RemoveNextFromClip()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	public int TotalCasingsInClip()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(GunItem), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRifle")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallsUnknownMethods(Count = 12)]
	public float GetSwayIncreasePerSecond()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(GunItem), Member = "Update")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
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

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(GunItem), Member = "GetSwayDecreasePerSecond")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GunItem), Member = "GetSwayIncreasePerSecond")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Update_WeaponFatigue")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(PlayerAnimation), Member = "IsAllowedToFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GunItem), Member = "IsEquipped")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	public void Update()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "DryFire")]
	public void PlayDryFireAudio(GameObject go)
	{
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[Calls(Type = typeof(PlayerVoice), Member = "CompleteActiveRequest")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	public void ZoomStart()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void OnAiming()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "MaybeCancelZoomInternal")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Freezing), Member = "MaybeCancelPlayerFreezingTeethChatter")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_Generic_Aim_Cancel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	public void ZoomEnd()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void OnAimingStoppedComplete()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	public void ResetControlState()
	{
	}

	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void MaybePlayUncockAudio(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GunItem), Member = "MaybeDetermineSingleRoundWeight")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	public float GetClipWeightKG()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(GunItem), Member = "GetClipWeightKG")]
	[CalledBy(Type = typeof(GunItem), Member = "Awake")]
	[CalledBy(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CalledBy(Type = typeof(GearItem), Member = "GetItemWeightIgnoreClothingWornBonusKG")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void MaybeDetermineSingleRoundWeight()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetJammed(bool state)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnUnequipItemInHandInternalComplete")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "Reset")]
	[Calls(Type = typeof(SmokeTrail), Member = "InitEffect")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public void ResetEffects()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "IsAllowedToFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GunItem), Member = "IsEquipped")]
	private bool IsAiming()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(GunItem), Member = "Update")]
	[CalledBy(Type = typeof(GunItem), Member = "IsAiming")]
	[CallsUnknownMethods(Count = 5)]
	private bool IsEquipped()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	public float GetRecoilPitch()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRevolver")]
	[Calls(Type = typeof(Skill), Member = "GetCurrentTierNumber")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 4)]
	public float GetRecoilYaw()
	{
		return default(float);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "OnRevolverFired")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnFiredEquippedWeapon")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "PlayEffect")]
	[Calls(Type = typeof(Condition), Member = "StartEarRinging")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "RemoveNextFromClip")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	public void StruggleRevolverFire()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CallsUnknownMethods(Count = 1)]
	public void Fired(GameObject projectile)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GunItem), Member = "PlayCasingAudio")]
	[Calls(Type = typeof(PlayerManager), Member = "InstantiateItemAtPlayersFeet")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void HandleShellDischarge()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 2)]
	public void MaybeHandleMisfire()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[Calls(Type = typeof(MisfireTable), Member = "DoesMisfire")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool RollForMisfire()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "OnAnimationEvent_Discharge_Shell_Event")]
	[CalledBy(Type = typeof(GunItem), Member = "HandleShellDischarge")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnRoundsUnloaded")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnUnJamComplete")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	public void PlayCasingAudio(int count)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GunItem), Member = "IsFiredActionRegistered")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void RegisterOnFiredAction(Action<GameObject> action, GunType gunType)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GunItem), Member = "IsFiredActionRegistered")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	public static void UnRegisterOnFiredAction(Action<GameObject> action, GunType gunType)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(RescueZone), Member = "OnDestroy")]
	[CalledBy(Type = typeof(GunItem), Member = "UnRegisterOnFiredAction")]
	[CalledBy(Type = typeof(RescueZone), Member = "Awake")]
	[Calls(Type = typeof(Delegate), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(GunItem), Member = "RegisterOnFiredAction")]
	private static bool IsFiredActionRegistered(Action<GameObject> action, GunType gunType)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 12)]
	public GunItem()
	{
	}
}
