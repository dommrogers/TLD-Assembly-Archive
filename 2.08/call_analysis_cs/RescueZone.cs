using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class RescueZone : MonoBehaviour
{
	public float m_ZoneRadius;

	public float m_DelayReplyMinSeconds;

	public float m_DelayReplyMaxSeconds;

	public GameObject m_FlareGunRound;

	public GameObject m_RescueTarget;

	public bool m_AutoReplyShot;

	public float m_TargetFoundRadius;

	public float m_NoReply_Radius;

	public float m_MinAltitudeSight;

	public float m_ShotHeightStartMeters;

	public float m_MaxShotPitchBiasDegrees;

	public float m_MinShotYawBiasDegrees;

	public float m_MaxShotYawBiasDegrees;

	private bool m_HasFoundTarget;

	private float m_NextReplyTime;

	private static List<RescueZone> s_RescueZoneList;

	private GameObject m_TrackedProjectile;

	private float m_CurrentProjectileAltitude;

	private float m_ReplyShotTimeHours;

	private Rigidbody m_TrackedProjectileRigidBody;

	private Vector3 m_ProjectileInitialPosition;

	private bool m_ReplyShotRequested;

	private bool m_HasPlayerEntered;

	private bool m_HasSpottedProjectile;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GunItem), Member = "IsFiredActionRegistered")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 6)]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GunItem), Member = "IsFiredActionRegistered")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RescueZone), Member = "UpdatePlayerCheck")]
	[Calls(Type = typeof(RescueZone), Member = "UpdateTrackProjectile")]
	[Calls(Type = typeof(RescueZone), Member = "CanReplyToPlayerShot")]
	[Calls(Type = typeof(RescueZone), Member = "FireFlareGun")]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[Calls(Type = typeof(RescueZone), Member = "CanReplyToPlayerShot")]
	[CalledBy(Type = typeof(RescueZone), Member = "UpdateReplyShot")]
	[CalledBy(Type = typeof(RescueZone), Member = "Update")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "SpawnAndFire")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RescueZone), Member = "GetRescueTargetPosition")]
	[CalledBy(Type = typeof(Action_RescueZoneFireFlareGun), Member = "OnExecute")]
	[Calls(Type = typeof(RescueZone), Member = "GetShotOrientation")]
	[CalledBy(Type = typeof(Action_RescueZoneFireFlareGun), Member = "DoWork")]
	public void FireFlareGun(Vector3 targetPosition)
	{
	}

	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CalledBy(Type = typeof(RescueZone), Member = "FireFlareGun")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	private Quaternion GetShotOrientation(Vector3 targetPosition)
	{
		return default(Quaternion);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RescueZone), Member = "CanReplyToPlayerShot")]
	[Calls(Type = typeof(RescueZone), Member = "FireFlareGun")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateReplyShot()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(RescueZone), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateTrackProjectile()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 2)]
	private void HandleProjectileSpotted()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallerCount(Count = 0)]
	private void RequestReplyShot()
	{
	}

	[CalledBy(Type = typeof(RescueZone), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(RescueZone), Member = "GetRescueTargetPosition")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[CallsUnknownMethods(Count = 4)]
	private void UpdatePlayerCheck()
	{
	}

	[CalledBy(Type = typeof(RescueZone), Member = "CanReplyToPlayerShot")]
	[CalledBy(Type = typeof(RescueZone), Member = "UpdatePlayerCheck")]
	[CalledBy(Type = typeof(RescueZone), Member = "FireFlareGun")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private Vector3 GetRescueTargetPosition()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(RescueZone), Member = "UpdateReplyShot")]
	[CalledBy(Type = typeof(RescueZone), Member = "FireFlareGun")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(RescueZone), Member = "Update")]
	[CalledBy(Type = typeof(RescueZone), Member = "OnFlareGunShot")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(RescueZone), Member = "GetRescueTargetPosition")]
	[CallerCount(Count = 4)]
	private bool CanReplyToPlayerShot()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(RescueZone), Member = "OnFlareGunShot")]
	[CallsUnknownMethods(Count = 5)]
	private void StartTrackingProjectile(GameObject projectile)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CalledBy(Type = typeof(RescueZone), Member = "OnFlareGunShot")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	private static RescueZone GetActiveRescueZone()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RescueZone), Member = "GetActiveRescueZone")]
	[Calls(Type = typeof(RescueZone), Member = "CanReplyToPlayerShot")]
	[Calls(Type = typeof(RescueZone), Member = "StartTrackingProjectile")]
	private static void OnFlareGunShot(GameObject projectile)
	{
	}

	[CallerCount(Count = 0)]
	public RescueZone()
	{
	}
}
