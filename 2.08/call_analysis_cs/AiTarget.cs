using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AiTarget : MonoBehaviour
{
	public float m_EyeOffset;

	public bool m_InstaKillNPC;

	public float m_HP;

	public GameObject m_Stalker;

	public BaseAi m_BaseAi;

	public NPC m_Npc;

	public BaseAi m_BaseAiTargetingMe;

	[NonSerialized]
	public bool m_IsEnabled;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	public void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Update()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 91)]
	public bool IsPlayer()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public bool InSnowShelter()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsWolf()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool IsBear()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[CalledBy(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public bool IsMoose()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterPassingAttack")]
	[CalledBy(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "TriggerPassingAttackAnim")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPerformPassingAttackChance")]
	[CalledBy(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	public bool IsNpcSurvivor()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[Calls(Type = typeof(NPC), Member = "IsAlive")]
	[CalledBy(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CalledBy(Type = typeof(AiTarget), Member = "IsHostileTowards")]
	public bool IsDead()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	public bool IsAmbient()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsDead")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFootstepAudioEvent")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsHostileTowards(BaseAi compareBaseAi)
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundFightOrFlight")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundCommon")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Condition), Member = "IsPlayerVulnerable")]
	public bool IsVulnerable()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "DoPassingAttackDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	public void ApplyDamage(float damage, DamageSource damageSource, string collider)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "IsTooScaredToAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "DoTargetDetectedWhileFeeding")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeAttackOrHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundForMoose")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundFightOrFlight")]
	[CalledBy(Type = typeof(BaseAi), Member = "IsTargetGoneOrOutOfRange")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHowl")]
	[CalledBy(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigate")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateScent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 18)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateFood")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterJoinPack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeClearTarget")]
	public float Distance(Vector3 pos)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	public float Dot(Vector3 pos, Vector3 forward)
	{
		return default(float);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public string GetName()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerMovement), Member = "GetVelocity")]
	public Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "GetCurrentHoldGroundCausePosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldPlayBearAttackStartAnimation")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "ComputeDistanceForTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateHeadTrackingIk")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForSpear")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetTargetHeadingParameter")]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateAimingIk")]
	[CalledBy(Type = typeof(AiUtils), Member = "TurnTowardsTarget")]
	[Calls(Type = typeof(BaseAi), Member = "GetEyePos")]
	[CalledBy(Type = typeof(HeadTrack), Member = "OnStateIK")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeEnterAttackModeWhenStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForTorch")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlare")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlare")]
	public Vector3 GetEyePos()
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(Inventory), Member = "GetExtraScentIntensity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "SmellLost")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForSmells")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessInvestigateSmell")]
	public bool EmitsTrackableSmell()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ShouldHoldGround")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForBlueFlare")]
	[CalledBy(Type = typeof(PackManager), Member = "CanAttack")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeHoldGroundForRedFlare")]
	public bool HoldingLitFlare(FlareType flareType)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool HoldingRaisedSpear()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool HoldingLitTorch()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public AiTarget()
	{
	}
}
