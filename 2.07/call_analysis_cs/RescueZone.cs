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

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GunItem), Member = "IsFiredActionRegistered")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GunItem), Member = "IsFiredActionRegistered")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsUnknownMethods(Count = 5)]
	public void OnDestroy()
	{
	}

	[Calls(Type = typeof(RescueZone), Member = "FireFlareGun")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(RescueZone), Member = "CanReplyToPlayerShot")]
	[Calls(Type = typeof(RescueZone), Member = "UpdateTrackProjectile")]
	[Calls(Type = typeof(RescueZone), Member = "UpdatePlayerCheck")]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(Action_RescueZoneFireFlareGun), Member = "DoWork")]
	[CalledBy(Type = typeof(RescueZone), Member = "UpdateReplyShot")]
	[CalledBy(Type = typeof(RescueZone), Member = "Update")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "SpawnAndFire")]
	[CalledBy(Type = typeof(Action_RescueZoneFireFlareGun), Member = "OnExecute")]
	[Calls(Type = typeof(RescueZone), Member = "GetRescueTargetPosition")]
	[Calls(Type = typeof(RescueZone), Member = "CanReplyToPlayerShot")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RescueZone), Member = "GetShotOrientation")]
	public void FireFlareGun(Vector3 targetPosition)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CalledBy(Type = typeof(RescueZone), Member = "FireFlareGun")]
	[CallsUnknownMethods(Count = 7)]
	private Quaternion GetShotOrientation(Vector3 targetPosition)
	{
		return default(Quaternion);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(RescueZone), Member = "FireFlareGun")]
	[Calls(Type = typeof(RescueZone), Member = "CanReplyToPlayerShot")]
	[CallerCount(Count = 0)]
	private void UpdateReplyShot()
	{
	}

	[CalledBy(Type = typeof(RescueZone), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[CallsUnknownMethods(Count = 10)]
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
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	private void RequestReplyShot()
	{
	}

	[CalledBy(Type = typeof(RescueZone), Member = "Update")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RescueZone), Member = "GetRescueTargetPosition")]
	private void UpdatePlayerCheck()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(RescueZone), Member = "FireFlareGun")]
	[CalledBy(Type = typeof(RescueZone), Member = "UpdatePlayerCheck")]
	[CalledBy(Type = typeof(RescueZone), Member = "CanReplyToPlayerShot")]
	[CallsUnknownMethods(Count = 5)]
	private Vector3 GetRescueTargetPosition()
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(RescueZone), Member = "UpdateReplyShot")]
	[CalledBy(Type = typeof(RescueZone), Member = "FireFlareGun")]
	[CalledBy(Type = typeof(RescueZone), Member = "Update")]
	[CalledBy(Type = typeof(RescueZone), Member = "OnFlareGunShot")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RescueZone), Member = "GetRescueTargetPosition")]
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
	[CalledBy(Type = typeof(RescueZone), Member = "OnFlareGunShot")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
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
