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
	[Calls(Type = typeof(GunItem), Member = "IsFiredActionRegistered")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GunItem), Member = "IsFiredActionRegistered")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
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

	[CalledBy(Type = typeof(RescueZone), Member = "Update")]
	[CalledBy(Type = typeof(RescueZone), Member = "UpdateReplyShot")]
	[CalledBy(Type = typeof(Action_RescueZoneFireFlareGun), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_RescueZoneFireFlareGun), Member = "DoWork")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RescueZone), Member = "CanReplyToPlayerShot")]
	[Calls(Type = typeof(RescueZone), Member = "GetRescueTargetPosition")]
	[Calls(Type = typeof(RescueZone), Member = "GetShotOrientation")]
	[Calls(Type = typeof(FlareGunRoundItem), Member = "SpawnAndFire")]
	public void FireFlareGun(Vector3 targetPosition)
	{
	}

	[CalledBy(Type = typeof(RescueZone), Member = "FireFlareGun")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
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

	[CalledBy(Type = typeof(RescueZone), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateTrackProjectile()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void HandleProjectileSpotted()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsUnknownMethods(Count = 1)]
	private void RequestReplyShot()
	{
	}

	[CalledBy(Type = typeof(RescueZone), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(RescueZone), Member = "GetRescueTargetPosition")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdatePlayerCheck()
	{
	}

	[CalledBy(Type = typeof(RescueZone), Member = "FireFlareGun")]
	[CalledBy(Type = typeof(RescueZone), Member = "UpdatePlayerCheck")]
	[CalledBy(Type = typeof(RescueZone), Member = "CanReplyToPlayerShot")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private Vector3 GetRescueTargetPosition()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(RescueZone), Member = "Update")]
	[CalledBy(Type = typeof(RescueZone), Member = "FireFlareGun")]
	[CalledBy(Type = typeof(RescueZone), Member = "UpdateReplyShot")]
	[CalledBy(Type = typeof(RescueZone), Member = "OnFlareGunShot")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(RescueZone), Member = "GetRescueTargetPosition")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private bool CanReplyToPlayerShot()
	{
		return false;
	}

	[CalledBy(Type = typeof(RescueZone), Member = "OnFlareGunShot")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void StartTrackingProjectile(GameObject projectile)
	{
	}

	[CalledBy(Type = typeof(RescueZone), Member = "OnFlareGunShot")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
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
