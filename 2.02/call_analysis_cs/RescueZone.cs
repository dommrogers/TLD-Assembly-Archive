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
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GunItem), Member = "IsFiredActionRegistered")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 11)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GunItem), Member = "IsFiredActionRegistered")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsUnknownMethods(Count = 10)]
	public void OnDestroy()
	{
	}

	[Calls(Type = typeof(RescueZone), Member = "CanReplyToPlayerShot")]
	[Calls(Type = typeof(RescueZone), Member = "FireFlareGun")]
	[Calls(Type = typeof(RescueZone), Member = "UpdateTrackProjectile")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RescueZone), Member = "UpdatePlayerCheck")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(RescueZone), Member = "Update")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "SpawnAndFire")]
	[CalledBy(Type = typeof(Action_RescueZoneFireFlareGun), Member = "DoWork")]
	[Calls(Type = typeof(RescueZone), Member = "GetShotOrientation")]
	[CalledBy(Type = typeof(RescueZone), Member = "UpdateReplyShot")]
	[Calls(Type = typeof(RescueZone), Member = "GetRescueTargetPosition")]
	[Calls(Type = typeof(RescueZone), Member = "CanReplyToPlayerShot")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	public void FireFlareGun(Vector3 targetPosition)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RescueZone), Member = "FireFlareGun")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Vector3), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Quaternion), Member = "SetLookRotation")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	private Quaternion GetShotOrientation(Vector3 targetPosition)
	{
		return default(Quaternion);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(RescueZone), Member = "FireFlareGun")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RescueZone), Member = "CanReplyToPlayerShot")]
	private void UpdateReplyShot()
	{
	}

	[Calls(Type = typeof(RescueZone), Member = "HandleProjectileSpotted")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(RescueZone), Member = "Update")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	private void UpdateTrackProjectile()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CalledBy(Type = typeof(RescueZone), Member = "UpdateTrackProjectile")]
	[CallsUnknownMethods(Count = 7)]
	private void HandleProjectileSpotted()
	{
	}

	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void RequestReplyShot()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(RescueZone), Member = "GetRescueTargetPosition")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[CalledBy(Type = typeof(RescueZone), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdatePlayerCheck()
	{
	}

	[CalledBy(Type = typeof(RescueZone), Member = "CanReplyToPlayerShot")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(RescueZone), Member = "UpdatePlayerCheck")]
	[CalledBy(Type = typeof(RescueZone), Member = "FireFlareGun")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	private Vector3 GetRescueTargetPosition()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(RescueZone), Member = "GetRescueTargetPosition")]
	[CalledBy(Type = typeof(RescueZone), Member = "Update")]
	[CalledBy(Type = typeof(RescueZone), Member = "FireFlareGun")]
	[CalledBy(Type = typeof(RescueZone), Member = "UpdateReplyShot")]
	[CalledBy(Type = typeof(RescueZone), Member = "OnFlareGunShot")]
	[CallsUnknownMethods(Count = 5)]
	private bool CanReplyToPlayerShot()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(RescueZone), Member = "OnFlareGunShot")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	private void StartTrackingProjectile(GameObject projectile)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(RescueZone), Member = "OnFlareGunShot")]
	[CallsUnknownMethods(Count = 7)]
	private static RescueZone GetActiveRescueZone()
	{
		return null;
	}

	[Calls(Type = typeof(RescueZone), Member = "CanReplyToPlayerShot")]
	[Calls(Type = typeof(RescueZone), Member = "StartTrackingProjectile")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RescueZone), Member = "GetActiveRescueZone")]
	private static void OnFlareGunShot(GameObject projectile)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public RescueZone()
	{
	}
}
