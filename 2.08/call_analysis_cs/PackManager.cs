using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD;
using TLD.PDID;
using TLD.Serialization;
using UnityEngine;

public class PackManager : MonoBehaviour
{
	public PackSettings m_DefaultPackSettings;

	private List<PackAnimal> m_PackAnimals;

	private Dictionary<PackAnimal, PackGroup> m_PackAnimalGroupByLeader;

	private List<PackGroup> m_FreePackGroups;

	private List<PackAnimal> m_RemoveAnimalList;

	public int m_MaxPackSize;

	public float m_PackReformDisplayTimeSeconds;

	private float m_PackReformDisplayTimer;

	public float m_PackNearbyRange;

	public string m_PackNearbySoundName;

	public float m_MinCombatRestrictedDistance;

	public float m_MinPlayerDistanceToHoldGroundPoint;

	public float m_MaxPlayerDistanceToHoldGroundPoint;

	public float m_MinAngleBetweenPlayerAndMarkup;

	public float m_QueueCombatRestrictedAttackDelay;

	public float m_AiModeSwitchDelayDuringRepositioningSeconds;

	public float m_MinDistanceToPlayerDuringReposition;

	public float m_AcceptanceDistanceToHoldGround;

	private bool m_EnablePacksOnLoad;

	private bool m_PlayerInPackCombatTrigger;

	public float m_DeserializeDelayTimeSeconds;

	private float m_DeserializeDelayTimer;

	private List<AreaMarkup> m_AreaMarkupList;

	private List<AreaMarkup> m_PrunedAreaMarkupList;

	private Dictionary<AreaMarkup, PackAnimal> m_PackAnimalByHoldGroundHint;

	private Dictionary<PackAnimal, AreaMarkup> m_HoldGroundHintByPackAnimal;

	private Dictionary<string, Vector3> m_LonerWanderLocationByGroupId;

	private bool m_IsPackNearby;

	private bool m_WasPackNearby;

	private float m_HoursPlayedAtStart;

	private bool m_SystemEnabled;

	[CallerCount(Count = 21)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private PackSettings GetPackSettings()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string SerializeGlobal()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void DeserializeGlobal(string serialized)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(PackManager), Member = "MaybeCleanupDeadPackAnimals")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 25)]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ForceSetPlayerTarget")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "MaybeAddOrUpdateGroup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public void RegisterPackAnimal(PackAnimal pa)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnMoraleCheck")]
	[CalledBy(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[CalledBy(Type = typeof(PackManager), Member = "DisbandGroup")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PackManager), Member = "GroupMoraleHeuristic")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	private void RemoveGroup(PackAnimal leader, bool setReformTimer)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeAddOrUpdateGroup")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CallsUnknownMethods(Count = 4)]
	private PackAnimal FindPackGroupLeaderByGroupId(string groupId)
	{
		return null;
	}

	[CalledBy(Type = typeof(PackManager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	[Calls(Type = typeof(PackManager), Member = "FindPackGroupLeaderByGroupId")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	private PackAnimal MaybeAddOrUpdateGroup(PackAnimal newLeader)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsMismatchWildlifeMode(PackAnimal animal)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool CanAnimalFormGroup(PackAnimal animal)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroupOnPlayerDetectionRange")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PackManager), Member = "DisbandGroup")]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "MaybeAddOrUpdateGroup")]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	public bool MaybeFormGroup(PackAnimal newLeader)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroupOnPlayerDetectionRange")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void MaybeAlertMembers(PackAnimal animal)
	{
	}

	[Calls(Type = typeof(PackManager), Member = "IsLeader")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessJoinPack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeStartOrJoinPackHowl")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeStartOrJoinPackHowl")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void MaybeStartHowl(PackAnimal animal)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeDisbandGroupOnTargetLost")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnBearOrMooseCheck")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PackManager), Member = "RemoveGroup")]
	public bool DisbandGroup(PackAnimal pa, bool setReformTimer)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[CallsUnknownMethods(Count = 4)]
	public PackAnimal ChooseLeader(PackGroup pack)
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeCleanupDeadPackAnimals")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeCleanupDeadPackAnimals")]
	[CalledBy(Type = typeof(PackAnimal), Member = "OnDestroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(PackManager), Member = "RemoveGroup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PackManager), Member = "ChooseLeader")]
	public void UnregisterPackAnimal(PackAnimal pa, bool onDeath)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "WarnOthersNearby")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPerformPassingAttackChance")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroupOnPlayerDetectionRange")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "MaybeScareWildlife")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPerformPassingAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFootstepAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 18)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	public static bool InPack(PackAnimal animal)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeStartHowl")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessJoinPack")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnDamage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeStartOrJoinPackHowl")]
	public static bool IsLeader(PackAnimal animal)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterPassingAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterHideAndSeekInternal")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPerformPassingAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPerformPassingAttackChance")]
	public static bool IsValidPackTarget(AiTarget target)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "FindHighGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindRandomLocation")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool IsPointCloseToPackMembers(PackAnimal animal, Vector3 point, float radius)
	{
		return default(bool);
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PackManager), Member = "RemoveGroup")]
	[CalledBy(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	[CalledBy(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	[CalledBy(Type = typeof(PackManager), Member = "ShouldAnimalFleeChance")]
	[CalledBy(Type = typeof(PackManager), Member = "GetHighestPackMorale")]
	[CallsUnknownMethods(Count = 1)]
	public float GroupMoraleHeuristic(PackAnimal animal)
	{
		return default(float);
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	private void DebugMoraleReport(string text, float value)
	{
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "IsLeader")]
	public void ModifyGroupMoraleOnDamage(PackAnimal animal)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallsUnknownMethods(Count = 1)]
	public void ModifyGroupMoraleOnNearMissGunshot(PackAnimal animal)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	public void ModifyGroupMoraleOnFlareGunRound(PackAnimal animal, bool isStuckInAnimal)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[CallsUnknownMethods(Count = 5)]
	public void ModifyGroupMoraleOnGunshot(PackAnimal animal)
	{
	}

	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	public void ModifyGroupMoraleOnFlashLightHighBeam(PackAnimal animal)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[CallsUnknownMethods(Count = 1)]
	public void ModifyGroupMoraleOnHitWithItem(PackAnimal animal, GearItem item)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ModifyGroupMoraleOnThrownItem(PackAnimal animal, GearItem item)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnGunshot")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "MaybeScareWildlife")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnThrownItem")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnThrownItem")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnHitWithItem")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnFlashLightHighBeam")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnFlareGunRound")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnNearMissGunshot")]
	public bool ModifyGroupMorale(PackSettings modeSettings, PackAnimal animal, float percent, MoraleModifierType eventType)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public PackAnimal GetPackLeader(BaseAi ai)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int GetMemberCount(PackAnimal leader)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetPackCombatRestricted(bool enable)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterHideAndSeekInternal")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[CalledBy(Type = typeof(PackManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PackManager), Member = "CanAttack")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceMoveMembers")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceAttackInCombatRestrictedArea")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeMoveToNewHoldGroundPosition")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeSetPackAttackCooldownTime")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPerformPassingAttackChance")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPerformPassingAttack")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFootstepAudioEvent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldPlayTimberwolfAttackStartAnimation")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	public bool IsPackCombatRestricted(PackAnimal animal)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int GetFormationCount(PackAnimal leader)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundFightOrFlight")]
	[Calls(Type = typeof(PackManager), Member = "GroupMoraleHeuristic")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnMoraleCheck")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "GroupMoraleHeuristic")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public bool ShouldAnimalFlee(PackAnimal animal)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[CallsUnknownMethods(Count = 1)]
	public float GetMoraleThreshold()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(PackManager), Member = "GroupMoraleHeuristic")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	public bool ShouldAnimalFleeChance(PackAnimal animal)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceAttackInCombatRestrictedArea")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(AiTarget), Member = "HoldingLitFlare")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	public bool CanAttack(PackAnimal animal)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public void ClearAttackCooldownTimeOnAttackFailed(PackAnimal animal)
	{
	}

	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public void MaybeSetPackAttackCooldownTime(PackAnimal animal)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PackManager), Member = "CanAttack")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(BaseAi), Member = "CanSeeTarget")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	private void MaybeForceAttackInCombatRestrictedArea(PackSettings modeSettings)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(PackManager), Member = "Serialize")]
	[Calls(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[Calls(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void MaybeCleanupDeadPackAnimals(PackSettings modeSettings)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "DisbandGroup")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallsUnknownMethods(Count = 19)]
	private void MaybeDisbandGroupOnTargetLost(PackSettings modeSettings)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnMoraleCheck")]
	[Calls(Type = typeof(AuroraObjectMaterials), Member = "SwitchToAuroraMaterials")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraObjectMaterials), Member = "SwitchToNormalMaterials")]
	private void MaybeSetAuroraMaterialsOnFlee(BaseAi ai)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PackManager), Member = "RemoveGroup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PackManager), Member = "MaybeSetAuroraMaterialsOnFlee")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void MaybeFleeAndDisbandOnMoraleCheck()
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[Calls(Type = typeof(PackManager), Member = "DisbandGroup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void MaybeFleeAndDisbandOnBearOrMooseCheck(PackSettings modeSettings)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	private void MaybeForceMoveMembers(PackSettings modeSettings)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeMoveToNewHoldGroundPosition")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsMovingToHoldGroundPosition(PackAnimal animal)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeMoveToNewHoldGroundPosition")]
	[Calls(Type = typeof(PackManager), Member = "MaybePickHoldGroundHint")]
	[CallerCount(Count = 1)]
	private bool MaybePickAndMoveToHoldGroundHint(PackAnimal member)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 37)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeMoveToNewHoldGroundPosition")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	private void MaybeForceHoldGroundAfterReposition(PackSettings modeSettings)
	{
	}

	[Calls(Type = typeof(PackManager), Member = "MaybePickAndMoveToHoldGroundHint")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PackManager), Member = "MaybeForceHoldGroundAfterReposition")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "IsMovingToHoldGroundPosition")]
	private void MaybeMoveToNewHoldGroundPosition(PackSettings modeSettings)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsTaggedGroupAnimal(PackAnimal animal)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 1)]
	private static bool AreSameTaggedGroupAnimals(PackAnimal a, PackAnimal b)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(AreaMarkupManager), Member = "MaybeReserveAreaMarkup")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindFarthestAreaMarkupOfTypeWithinRadius")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "FindPackGroupLeaderByGroupId")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeKeepLonersWithinRadius()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "ForceSetPlayerTarget")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[Calls(Type = typeof(PackManager), Member = "MaybeAlertMembers")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	private void MaybeFormGroupOnPlayerDetectionRange(PackSettings modeSettings)
	{
	}

	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "MaybeReserveAreaMarkup")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybePickAndMoveToHoldGroundHint")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindAreaMarkupsOfTypeWithinRadius")]
	[CallsUnknownMethods(Count = 34)]
	private bool MaybePickHoldGroundHint(PackAnimal animal, out Vector3 point)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref point) = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePackMorale")]
	[CalledBy(Type = typeof(TimberwolfReplenishTrigger), Member = "OnTriggerEnter")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "GroupMoraleHeuristic")]
	public float GetHighestPackMorale(out float modifier, out int memberCount, out int originalMemberCount)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref modifier) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref memberCount) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref originalMemberCount) = null;
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallsUnknownMethods(Count = 16)]
	private void MaybeEnableAnimalsOnLoad()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	private void ResetGroupEventFlags()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(CustomAudioEmitter), Member = "Enable")]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	private void MaybeUpdateInteriorAudio(PackSettings modeSettings)
	{
	}

	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	public bool ArePacksAllowed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[Calls(Type = typeof(PackManager), Member = "MaybeFormGroupOnPlayerDetectionRange")]
	[Calls(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[Calls(Type = typeof(PackManager), Member = "MaybeForceAttackInCombatRestrictedArea")]
	[Calls(Type = typeof(PackManager), Member = "MaybeMoveToNewHoldGroundPosition")]
	[Calls(Type = typeof(PackManager), Member = "MaybeForceMoveMembers")]
	[Calls(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnBearOrMooseCheck")]
	[Calls(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnMoraleCheck")]
	[Calls(Type = typeof(PackManager), Member = "MaybeEnableAnimalsOnLoad")]
	[Calls(Type = typeof(PackManager), Member = "MaybeCleanupDeadPackAnimals")]
	[Calls(Type = typeof(PackManager), Member = "ResetGroupEventFlags")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PackManager), Member = "MaybeUpdateInteriorAudio")]
	[Calls(Type = typeof(PackManager), Member = "MaybeDisbandGroupOnTargetLost")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	public PackManager()
	{
	}
}
