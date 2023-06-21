using Cpp2ILInjected.CallAnalysis;
using TLD.GameplayTags;
using UnityEngine;

namespace TLD.AI;

public class AiTimberwolf : AiBaseWolf
{
	public float m_HoldGroundDistance;

	public float m_MinFollowDistance;

	public float m_ComfortableFollowDistance;

	public float m_MaxFollowDistance;

	public float m_HideAndSeekStalkingSpeed;

	public float m_HideAndSeekCirclingSpeed;

	public float m_HideAndSeekRetreatingSpeed;

	public float m_RetreatDistance;

	public float m_CirclingDistance;

	public float m_RetreatPositionMinRadius;

	public float m_RetreatPositionMaxRadius;

	public float m_ChangeDistanceThreshold;

	public float m_HighGroundSearchRadius;

	public float m_PackSeperationDistance;

	public float m_SneakAmbushTime;

	public float m_PassingAttackChance;

	public float m_PassingAttackCameraShakeForce;

	public float m_PassingAttackCameraRollForce;

	public float m_HideAndSeekCooldownTime;

	public float m_MinNewPathCooldownTimeSeconds;

	public float m_MaxNewPathCooldownTimeSeconds;

	public float m_RepathApproachTimeSeconds;

	public float m_HighGroundClosingDistancePercent;

	public bool m_ShouldAlwaysPerformPassingAttack;

	private uint m_HideAndSeekAudioId;

	private bool m_IsRetreating;

	private float m_SneakApproach;

	private float m_SneakAmbushTimer;

	private float m_ClosingDistancePercent;

	private float m_EnterHideAndSeekCooldownTime;

	private float m_NewPathCooldownTimer;

	public float m_PackJoinTimeSeconds;

	public float m_PackSkipJoinStateWhenTargetNearbyDistance;

	private uint m_JoinPackAudioId;

	private float m_JoinTimer;

	private bool m_RequestedHowl;

	public GameplayTag m_PassingAttackDamageEventTableTag;

	public float m_PassingAttackAnimTimeout;

	private bool m_TriggeredPassingAttackAnim;

	private float m_PassingAttackAnimTimer;

	private bool m_HasPassingAttackDamageFired;

	[CalledBy(Type = typeof(PackManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroupOnPlayerDetectionRange")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void ForceSetPlayerTarget()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterPlayerStruggle")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsUnknownMethods(Count = 2)]
	public bool CanPerformPassingAttackChance()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[CallsUnknownMethods(Count = 2)]
	public bool CanPerformPassingAttack()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void EnterHideAndSeek()
	{
	}

	[CalledBy(Type = typeof(AiTimberwolf), Member = "FindTacticalPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointAndNormalOnNavmeshNoPadding")]
	[Calls(Type = typeof(PackManager), Member = "IsPointCloseToPackMembers")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Vector3 FindHighGround(Vector3 origin, float radius)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(AiTimberwolf), Member = "FindTacticalPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointAndNormalOnNavmeshNoPadding")]
	[Calls(Type = typeof(PackManager), Member = "IsPointCloseToPackMembers")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private Vector3 FindRandomLocation(Vector3 origin, float radius)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(AiTimberwolf), Member = "ProcessHideAndSeek")]
	[CallerCount(Count = 2)]
	private float GetClosingDistancePercent()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(AiTimberwolf), Member = "FindTacticalPosition")]
	[CalledBy(Type = typeof(AiTimberwolf), Member = "ProcessHideAndSeek")]
	[CallerCount(Count = 3)]
	private float GetMinFollowDistance()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(AiTimberwolf), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(AiTimberwolf), Member = "MaybeForceHideAndSeek")]
	[CallerCount(Count = 2)]
	private float GetMaxFollowDistance()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(AiTimberwolf), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(AiTimberwolf), Member = "MaybeForceHideAndSeek")]
	[CallerCount(Count = 2)]
	private float GetComfortableFollowDistance()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[CallsUnknownMethods(Count = 1)]
	public bool TriggerPassingAttackAnim()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAiManager), Member = "ResetAudioLoops")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void StopHideAndSeekAudio()
	{
	}

	[CalledBy(Type = typeof(AiTimberwolf), Member = "FindTacticalPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 10)]
	private Vector3 FindShortestDistanceToPlayerSide()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(AiTimberwolf), Member = "ProcessHideAndSeek")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindFarthestAreaMarkupOfTypeWithinRadius")]
	[Calls(Type = typeof(AiTimberwolf), Member = "GetMinFollowDistance")]
	[Calls(Type = typeof(AiTimberwolf), Member = "FindHighGround")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiTimberwolf), Member = "FindShortestDistanceToPlayerSide")]
	[Calls(Type = typeof(AiTimberwolf), Member = "FindRandomLocation")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 12)]
	private Vector3 FindTacticalPosition()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	private void ResetApproachDistance()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(AiTimberwolf), Member = "GetClosingDistancePercent")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(MoveAgent), Member = "GetCurrentSpeed")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[Calls(Type = typeof(AiTimberwolf), Member = "GetMinFollowDistance")]
	[Calls(Type = typeof(AiTimberwolf), Member = "GetComfortableFollowDistance")]
	[Calls(Type = typeof(AiTimberwolf), Member = "GetMaxFollowDistance")]
	[Calls(Type = typeof(AiTimberwolf), Member = "FindTacticalPosition")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	public void ProcessHideAndSeek()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetEnterCooldownTime()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ExitHideAndSeek()
	{
	}

	[CalledBy(Type = typeof(AiTimberwolf), Member = "CanEnterHideAndSeek")]
	[CalledBy(Type = typeof(AiTimberwolf), Member = "MaybeForceHideAndSeek")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsInvisibleToAi")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private bool CanEnterHideAndSeekInternal()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(AiTimberwolf), Member = "ProcessJoinPack")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTimberwolf), Member = "CanEnterHideAndSeekInternal")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanEnterHideAndSeek()
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(AiTimberwolf), Member = "CanEnterHideAndSeekInternal")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(AiTimberwolf), Member = "GetComfortableFollowDistance")]
	[Calls(Type = typeof(AiTimberwolf), Member = "GetMaxFollowDistance")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	public bool MaybeForceHideAndSeek()
	{
		return false;
	}

	[CalledBy(Type = typeof(PackManager), Member = "MaybeStartHowl")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "get_Timberwolf")]
	[Calls(Type = typeof(PackManager), Member = "IsLeader")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(WolfHowlController), Member = "StartLeadHowl")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool MaybeStartOrJoinPackHowl()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "Play3DSound")]
	[Calls(Type = typeof(BaseAi), Member = "MoveAgentStop")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void EnterJoinPack()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "IsLeader")]
	[Calls(Type = typeof(PackManager), Member = "MaybeStartHowl")]
	[Calls(Type = typeof(AiTimberwolf), Member = "CanEnterHideAndSeek")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void ProcessJoinPack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void ExitJoinPack()
	{
	}

	[CalledBy(Type = typeof(AiTimberwolf), Member = "EnterPassingAttack")]
	[CalledBy(Type = typeof(AiTimberwolf), Member = "DoPassingAttackDamage")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "GetDamageEventsForTag")]
	private DamageEventTable GetPassingAttackDamageEventTable()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "IsValidPackTarget")]
	[Calls(Type = typeof(AiTimberwolf), Member = "GetPassingAttackDamageEventTable")]
	[Calls(Type = typeof(DamageEventTable), Member = "Initialize")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetInt")]
	[Calls(Type = typeof(BaseAi), Member = "get_Timberwolf")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(BaseAi), Member = "AnimSetTrigger")]
	[Calls(Type = typeof(PassTime), Member = "End")]
	[Calls(Type = typeof(Rest), Member = "EndSleeping")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public void EnterPassingAttack()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AiTimberwolf), Member = "DoPassingAttackDamage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void ProcessPassingAttack()
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessCurrentAiMode")]
	[CalledBy(Type = typeof(AiTimberwolf), Member = "ProcessPassingAttack")]
	[CalledBy(Type = typeof(AiTimberwolf), Member = "OnAnimationEvent_OnPassingAttackChomp")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "PlayMeleeAttackAudio")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(BaseAi), Member = "GetDamageSource")]
	[Calls(Type = typeof(AiTarget), Member = "ApplyDamage")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[Calls(Type = typeof(AiTimberwolf), Member = "GetPassingAttackDamageEventTable")]
	[Calls(Type = typeof(DamageEventTable), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetTrigger")]
	[CallsUnknownMethods(Count = 2)]
	private void DoPassingAttackDamage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AiTimberwolf), Member = "DoPassingAttackDamage")]
	public void OnAnimationEvent_OnPassingAttackChomp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = ".ctor")]
	public AiTimberwolf()
	{
	}
}
