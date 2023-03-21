using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class vp_FPSShooter : vp_Component
{
	protected vp_FPSWeapon m_Weapon;

	protected vp_FPSCamera m_Camera;

	public Transform BulletEmissionLocator;

	public GameObject ProjectilePrefab;

	public bool ProjectileCustomPrefab;

	public float ProjectileScale;

	public int ProjectileCount;

	public float ProjectileSpread;

	protected float m_NextAllowedFireTime;

	public Vector3 MotionPositionRecoil;

	public Vector3 MotionRotationRecoil;

	public float MotionPositionReset;

	public float MotionRotationReset;

	public float MotionPositionPause;

	public float MotionRotationPause;

	public float MotionDryFireRecoil;

	public Vector3 MuzzleFlashPosition;

	public Vector3 MuzzleFlashScale;

	public float MuzzleFlashFadeSpeed;

	public GameObject MuzzleFlashPrefab;

	protected GameObject m_MuzzleFlash;

	protected vp_MuzzleFlash m_MuzzleFlashComponent;

	public GameObject ShellPrefab;

	public float ShellScale;

	public Vector3 ShellEjectDirection;

	public Vector3 ShellEjectPosition;

	public float ShellEjectVelocity;

	public float ShellEjectDelay;

	public float ShellEjectSpin;

	public float JamConditionThreshold;

	public float JamMinimumChance;

	public float JamMaximumChance;

	protected float m_NextAllowedReloadTime;

	private float m_LastFiredTime;

	private bool m_WeaponRotatedForShot;

	private GameObject m_MuzzleFlashTagObject;

	private float m_SendGunShotAudioEventTimer;

	public GameObject MuzzleFlash
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public float NextAllowedReloadTime
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float NextAllowedFireTime
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(vp_Component), Member = "Awake")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	protected override void Awake()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	protected override void Start()
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "get_DefaultRotation")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameAudioManager), Member = "NotifyAiAudioEvent")]
	protected override void Update()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_forward")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeAdjustShotPositionForNearShot")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "GetWeaponCamera")]
	[Calls(Type = typeof(Transform), Member = "set_localScale")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[Calls(Type = typeof(GameManager), Member = "GetSkillRifle")]
	[CallsUnknownMethods(Count = 39)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "PullTrigger")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(vp_FPSShooter), Member = "DryFire")]
	[Calls(Type = typeof(MissionServicesManager), Member = "OnFiredEquippedWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSShooter), Member = "ShowMuzzleFlash")]
	[Calls(Type = typeof(GunItem), Member = "RemoveNextFromClip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "Fired")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "SpawnAndFire")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Skill_Rifle), Member = "GetEffectiveRange")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "PlayFireAnimation")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 37)]
	[Calls(Type = typeof(PlayerAnimation), Member = "IsAllowedToFire")]
	[Calls(Type = typeof(PlayerAnimation), Member = "IsAllowedToFire")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "GetAmmoCount")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MisfireTable), Member = "DoesMisfire")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetRTPCValue")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(vp_FPSShooter), Member = "ShowMuzzleFlash")]
	[Calls(Type = typeof(GunItem), Member = "RemoveNextFromClip")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "PlayFireAnimation")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(RumbleEffectManager), Member = "PlayEffect")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "PlayDryFireAudio")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Condition), Member = "StartEarRinging")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "ResetSprings")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	public void Fire()
	{
	}

	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	public void DryFire()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "SetBulletsToReload")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Reload")]
	[CallsUnknownMethods(Count = 3)]
	public bool Reload(int ammoCount)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "InputZoom")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "OnReloadComplete")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public void PreventFiring(float seconds)
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	public override void Refresh()
	{
	}

	[Calls(Type = typeof(FirstPersonWeapon), Member = "ShowNextLoadedBullet")]
	[Calls(Type = typeof(Inventory), Member = "RemoveBestQualityAmmoForWeaponSingle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "EnableReloadBulletInstance")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "ShowNextLoadedBullet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonWeapon), Member = "ShowNextLoadedBullet")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GunItem), Member = "AddRoundsToClip")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "DecrementBulletsToReload")]
	public void OnBulletLoaded()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(vp_FPSWeapon), Member = "DecrementBulletsToReload")]
	[Calls(Type = typeof(Inventory), Member = "RemoveBestQualityAmmoForWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public void OnClipLoaded()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "Fire")]
	[Calls(Type = typeof(vp_MuzzleFlash), Member = "ShowSmoke")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_MuzzleFlash), Member = "ShowFlash")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void ShowMuzzleFlash(bool hasMisfired)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Component), Member = ".ctor")]
	public vp_FPSShooter()
	{
	}
}
