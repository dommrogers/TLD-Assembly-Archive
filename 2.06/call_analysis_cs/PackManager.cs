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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 21)]
	[CallsDeduplicatedMethods(Count = 1)]
	private PackSettings GetPackSettings()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 6)]
	public string SerializeGlobal()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void DeserializeGlobal(string serialized)
	{
	}

	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[CallsUnknownMethods(Count = 51)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(PackManager), Member = "MaybeCleanupDeadPackAnimals")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManagerDataProxyList), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ForceSetPlayerTarget")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 11)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public void RegisterPackAnimal(PackAnimal pa)
	{
	}

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[CalledBy(Type = typeof(PackManager), Member = "DisbandGroup")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PackManager), Member = "GroupMoraleHeuristic")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private void RemoveGroup(PackAnimal leader, bool setReformTimer)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeAddOrUpdateGroup")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private PackAnimal FindPackGroupLeaderByGroupId(string groupId)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(PackManager), Member = "FindPackGroupLeaderByGroupId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(PackManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	private PackAnimal MaybeAddOrUpdateGroup(PackAnimal newLeader)
	{
		return null;
	}

	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool IsMismatchWildlifeMode(PackAnimal animal)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[CallsUnknownMethods(Count = 2)]
	private bool CanAnimalFormGroup(PackAnimal animal)
	{
		return default(bool);
	}

	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PackManager), Member = "DisbandGroup")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[Calls(Type = typeof(PackManager), Member = "AreSameTaggedGroupAnimals")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroupOnPlayerDetectionRange")]
	[Calls(Type = typeof(PackManager), Member = "MaybeAddOrUpdateGroup")]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 45)]
	public bool MaybeFormGroup(PackAnimal newLeader)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroupOnPlayerDetectionRange")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public void MaybeAlertMembers(PackAnimal animal)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessJoinPack")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeStartOrJoinPackHowl")]
	[Calls(Type = typeof(PackManager), Member = "IsLeader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeStartOrJoinPackHowl")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void MaybeStartHowl(PackAnimal animal)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnMoraleCheck")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnBearOrMooseCheck")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeDisbandGroupOnTargetLost")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PackManager), Member = "RemoveGroup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	public bool DisbandGroup(PackAnimal pa, bool setReformTimer)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[CallsUnknownMethods(Count = 4)]
	public PackAnimal ChooseLeader(PackGroup pack)
	{
		return null;
	}

	[CalledBy(Type = typeof(PackAnimal), Member = "OnDestroy")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeCleanupDeadPackAnimals")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeCleanupDeadPackAnimals")]
	[Calls(Type = typeof(PackManager), Member = "RemoveGroup")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "ChooseLeader")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[CallerCount(Count = 5)]
	public void UnregisterPackAnimal(PackAnimal pa, bool onDeath)
	{
	}

	[CallerCount(Count = 26)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public static bool InPack(PackAnimal animal)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnDamage")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeStartHowl")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessJoinPack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeStartOrJoinPackHowl")]
	public static bool IsLeader(PackAnimal animal)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterPassingAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterHideAndSeekInternal")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPerformPassingAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPerformPassingAttackChance")]
	public static bool IsValidPackTarget(AiTarget target)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(BaseAi), Member = "FindHighGround")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindRandomLocation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	public bool IsPointCloseToPackMembers(PackAnimal animal, Vector3 point, float radius)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PackManager), Member = "GetHighestPackMorale")]
	[CalledBy(Type = typeof(PackManager), Member = "ShouldAnimalFleeChance")]
	[CalledBy(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	[CalledBy(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(PackManager), Member = "RemoveGroup")]
	public float GroupMoraleHeuristic(PackAnimal animal)
	{
		return default(float);
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	private void DebugMoraleReport(string text, float value)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
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

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[CallsUnknownMethods(Count = 1)]
	public void ModifyGroupMoraleOnFlareGunRound(PackAnimal animal, bool isStuckInAnimal)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	public void ModifyGroupMoraleOnGunshot(PackAnimal animal)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallsUnknownMethods(Count = 1)]
	public void ModifyGroupMoraleOnFlashLightHighBeam(PackAnimal animal)
	{
	}

	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ModifyGroupMoraleOnHitWithItem(PackAnimal animal, GearItem item)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnHitWithItem")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnFlashLightHighBeam")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnFlareGunRound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnNearMissGunshot")]
	public bool ModifyGroupMorale(PackSettings modeSettings, PackAnimal animal, float percent, MoraleModifierType eventType)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public PackAnimal GetPackLeader(BaseAi ai)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public int GetMemberCount(PackAnimal leader)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetPackCombatRestricted(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeMoveToNewHoldGroundPosition")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceMoveMembers")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceAttackInCombatRestrictedArea")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeSetPackAttackCooldownTime")]
	[CalledBy(Type = typeof(PackManager), Member = "CanAttack")]
	[CalledBy(Type = typeof(PackManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterHideAndSeekInternal")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPerformPassingAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFootstepAudioEvent")]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPerformPassingAttackChance")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldPlayTimberwolfAttackStartAnimation")]
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

	[Calls(Type = typeof(PackManager), Member = "GroupMoraleHeuristic")]
	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnMoraleCheck")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundFightOrFlight")]
	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PackManager), Member = "GroupMoraleHeuristic")]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "GroupMoraleHeuristic")]
	public bool ShouldAnimalFleeChance(PackAnimal animal)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceAttackInCombatRestrictedArea")]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(AiTarget), Member = "HoldingLitFlare")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	public bool CanAttack(PackAnimal animal)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void ClearAttackCooldownTimeOnAttackFailed(PackAnimal animal)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[CallsUnknownMethods(Count = 1)]
	public void MaybeSetPackAttackCooldownTime(PackAnimal animal)
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PackManager), Member = "CanAttack")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(BaseAi), Member = "CanSeeTarget")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	private void MaybeForceAttackInCombatRestrictedArea(PackSettings modeSettings)
	{
	}

	[CallsUnknownMethods(Count = 39)]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CalledBy(Type = typeof(PackManager), Member = "Serialize")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	private void MaybeCleanupDeadPackAnimals(PackSettings modeSettings)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(PackManager), Member = "DisbandGroup")]
	private void MaybeDisbandGroupOnTargetLost(PackSettings modeSettings)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraObjectMaterials), Member = "SwitchToNormalMaterials")]
	[Calls(Type = typeof(AuroraObjectMaterials), Member = "SwitchToAuroraMaterials")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnMoraleCheck")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeSetAuroraMaterialsOnFlee(BaseAi ai)
	{
	}

	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PackManager), Member = "MaybeSetAuroraMaterialsOnFlee")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PackManager), Member = "DisbandGroup")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void MaybeFleeAndDisbandOnMoraleCheck()
	{
	}

	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[Calls(Type = typeof(PackManager), Member = "DisbandGroup")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void MaybeFleeAndDisbandOnBearOrMooseCheck(PackSettings modeSettings)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	private void MaybeForceMoveMembers(PackSettings modeSettings)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "MaybeMoveToNewHoldGroundPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsMovingToHoldGroundPosition(PackAnimal animal)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "MaybePickHoldGroundHint")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeMoveToNewHoldGroundPosition")]
	[CallsUnknownMethods(Count = 1)]
	private bool MaybePickAndMoveToHoldGroundHint(PackAnimal member)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[CallsUnknownMethods(Count = 36)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeMoveToNewHoldGroundPosition")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	private void MaybeForceHoldGroundAfterReposition(PackSettings modeSettings)
	{
	}

	[Calls(Type = typeof(PackManager), Member = "MaybePickAndMoveToHoldGroundHint")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[Calls(Type = typeof(PackManager), Member = "MaybeForceHoldGroundAfterReposition")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(PackManager), Member = "IsMovingToHoldGroundPosition")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private void MaybeMoveToNewHoldGroundPosition(PackSettings modeSettings)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsTaggedGroupAnimal(PackAnimal animal)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	[CallsUnknownMethods(Count = 1)]
	private static bool AreSameTaggedGroupAnimals(PackAnimal a, PackAnimal b)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 36)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "MaybeReserveAreaMarkup")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindFarthestAreaMarkupOfTypeWithinRadius")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[Calls(Type = typeof(PackManager), Member = "FindPackGroupLeaderByGroupId")]
	private void MaybeKeepLonersWithinRadius()
	{
	}

	[Calls(Type = typeof(PackManager), Member = "MaybeAlertMembers")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[Calls(Type = typeof(BaseAi), Member = "ForceSetPlayerTarget")]
	[Calls(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private void MaybeFormGroupOnPlayerDetectionRange(PackSettings modeSettings)
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybePickAndMoveToHoldGroundHint")]
	[CallsUnknownMethods(Count = 45)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "MaybeReserveAreaMarkup")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindAreaMarkupsOfTypeWithinRadius")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
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

	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	private void MaybeEnableAnimalsOnLoad()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	private void ResetGroupEventFlags()
	{
	}

	[Calls(Type = typeof(CustomAudioEmitter), Member = "Enable")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void MaybeUpdateInteriorAudio(PackSettings modeSettings)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	[CallsUnknownMethods(Count = 2)]
	public bool ArePacksAllowed()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	public void Start()
	{
	}

	[Calls(Type = typeof(PackManager), Member = "MaybeForceAttackInCombatRestrictedArea")]
	[Calls(Type = typeof(PackManager), Member = "MaybeMoveToNewHoldGroundPosition")]
	[Calls(Type = typeof(PackManager), Member = "MaybeForceMoveMembers")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(PackManager), Member = "MaybeFormGroupOnPlayerDetectionRange")]
	[Calls(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnBearOrMooseCheck")]
	[Calls(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[Calls(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnMoraleCheck")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[Calls(Type = typeof(PackManager), Member = "MaybeCleanupDeadPackAnimals")]
	[Calls(Type = typeof(PackManager), Member = "ResetGroupEventFlags")]
	[Calls(Type = typeof(PackManager), Member = "MaybeEnableAnimalsOnLoad")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PackManager), Member = "MaybeUpdateInteriorAudio")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PackManager), Member = "MaybeDisbandGroupOnTargetLost")]
	public void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 47)]
	[CallerCount(Count = 0)]
	public PackManager()
	{
	}
}
