using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.AI;

public class AiPtarmigan : BaseAi
{
	public float m_CrouchDetectionRange;

	public float m_VerticalFlyingSpeed;

	public float m_FlyingSpeed;

	public float m_FleeRunningTimeMin;

	public float m_FleeRunningTimeMax;

	public float m_DespawnAltitude;

	private float m_Altitude;

	private bool m_IsFlying;

	private int m_AnimParameter_SetFlying;

	private float m_RunningCountdown;

	private float m_AbsoluteDespawnAltitude;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "Start_Anim")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void Start_Anim()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "EnterFlee")]
	[Calls(Type = typeof(Random), Member = "Range")]
	public override void EnterFlee()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "PickFleeDesination")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(AiPtarmigan), Member = "SetFlying")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegion), Member = "RemoveFromSpawnRegion")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public override void ProcessFlee()
	{
	}

	[CallerCount(Count = 0)]
	public override bool CanProjectileStick()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public override bool CanBleedOut()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	protected override float GetFleeSpeed()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SpawnRegion), Member = "RemoveFromSpawnRegion")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void DespawnFlyingAnimal()
	{
	}

	[CalledBy(Type = typeof(AiPtarmigan), Member = "ProcessFlee")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private void SetFlying(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderCharacterController")]
	[Calls(Type = typeof(BaseAi), Member = "GetHitInfoUnderCharacterControllerFromBatch")]
	[Calls(Type = typeof(BaseAi), Member = "AlignTransformWithNormal")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 8)]
	protected override void OrientCharacterControllerToGround()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[Calls(Type = typeof(AiTarget), Member = "GetEyePos")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsCrouched")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsTimeLapseActive")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	protected override float ComputeDistanceForTarget(Vector3 eyePos, AiTarget potentialTarget)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = ".ctor")]
	public AiPtarmigan()
	{
	}
}
