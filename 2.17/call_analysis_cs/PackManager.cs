using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using TLD.AI;
using TLD.PDID;
using TLD.Serialization;
using TLD.UI;
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	public void DeserializeGlobal(string serialized)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(PackManager), Member = "MaybeCleanupDeadPackAnimals")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 22)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(PackManager), Member = "MaybeAddOrUpdateGroup")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "get_Timberwolf")]
	[Calls(Type = typeof(AiTimberwolf), Member = "ForceSetPlayerTarget")]
	[CallsUnknownMethods(Count = 28)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void RegisterPackAnimal(PackAnimal pa)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "DisbandGroup")]
	[CalledBy(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnMoraleCheck")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(PackManager), Member = "GroupMoraleHeuristic")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private void RemoveGroup(PackAnimal leader, bool setReformTimer)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "MaybeAddOrUpdateGroup")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 3)]
	private PackAnimal FindPackGroupLeaderByGroupId(string groupId)
	{
		return null;
	}

	[CalledBy(Type = typeof(PackManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "FindPackGroupLeaderByGroupId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	private PackAnimal MaybeAddOrUpdateGroup(PackAnimal newLeader)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsMismatchWildlifeMode(PackAnimal animal)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[CallsUnknownMethods(Count = 2)]
	private bool CanAnimalFormGroup(PackAnimal animal)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroupOnPlayerDetectionRange")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[Calls(Type = typeof(PackManager), Member = "MaybeAddOrUpdateGroup")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(BaseAi), Member = "get_Timberwolf")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(PackManager), Member = "DisbandGroup")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 23)]
	public bool MaybeFormGroup(PackAnimal newLeader)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroupOnPlayerDetectionRange")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 5)]
	public void MaybeAlertMembers(PackAnimal animal)
	{
	}

	[CalledBy(Type = typeof(AiTimberwolf), Member = "ProcessJoinPack")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(AiTimberwolf), Member = "MaybeStartOrJoinPackHowl")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PackManager), Member = "IsLeader")]
	[Calls(Type = typeof(BaseAi), Member = "get_Timberwolf")]
	[CallsUnknownMethods(Count = 4)]
	public void MaybeStartHowl(PackAnimal animal)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeDisbandGroupOnTargetLost")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnBearOrMooseCheck")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "RemoveGroup")]
	[CallsUnknownMethods(Count = 1)]
	public bool DisbandGroup(PackAnimal pa, bool setReformTimer)
	{
		return false;
	}

	[CalledBy(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 3)]
	public PackAnimal ChooseLeader(PackGroup pack)
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(PackAnimal), Member = "OnDestroy")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeCleanupDeadPackAnimals")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(PackManager), Member = "RemoveGroup")]
	[Calls(Type = typeof(PackManager), Member = "ChooseLeader")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void UnregisterPackAnimal(PackAnimal pa, bool onDeath)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[CalledBy(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFootstepAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldAlwaysFleeFromCurrentTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "WarnOthersNearby")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroupOnPlayerDetectionRange")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "MaybeScareWildlife")]
	[CalledBy(Type = typeof(AiTimberwolf), Member = "CanPerformPassingAttackChance")]
	[CalledBy(Type = typeof(AiTimberwolf), Member = "CanPerformPassingAttack")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public static bool InPack(PackAnimal animal)
	{
		return false;
	}

	[CalledBy(Type = typeof(PackManager), Member = "MaybeStartHowl")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnDamage")]
	[CalledBy(Type = typeof(AiTimberwolf), Member = "MaybeStartOrJoinPackHowl")]
	[CalledBy(Type = typeof(AiTimberwolf), Member = "ProcessJoinPack")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsLeader(PackAnimal animal)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[CalledBy(Type = typeof(AiTimberwolf), Member = "CanPerformPassingAttackChance")]
	[CalledBy(Type = typeof(AiTimberwolf), Member = "CanPerformPassingAttack")]
	[CalledBy(Type = typeof(AiTimberwolf), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(AiTimberwolf), Member = "CanEnterHideAndSeekInternal")]
	[CalledBy(Type = typeof(AiTimberwolf), Member = "MaybeForceHideAndSeek")]
	[CalledBy(Type = typeof(AiTimberwolf), Member = "EnterPassingAttack")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	public static bool IsValidPackTarget(AiTarget target)
	{
		return false;
	}

	[CalledBy(Type = typeof(AiTimberwolf), Member = "FindHighGround")]
	[CalledBy(Type = typeof(AiTimberwolf), Member = "FindRandomLocation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public bool IsPointCloseToPackMembers(PackAnimal animal, Vector3 point, float radius)
	{
		return false;
	}

	[CalledBy(Type = typeof(PackManager), Member = "RemoveGroup")]
	[CalledBy(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	[CalledBy(Type = typeof(PackManager), Member = "ShouldAnimalFleeChance")]
	[CalledBy(Type = typeof(PackManager), Member = "GetHighestPackMorale")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsUnknownMethods(Count = 1)]
	public float GroupMoraleHeuristic(PackAnimal animal)
	{
		return 0f;
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	private void DebugMoraleReport(string text, float value)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(PackManager), Member = "IsLeader")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallsUnknownMethods(Count = 1)]
	public void ModifyGroupMoraleOnFlareGunRound(PackAnimal animal, bool isStuckInAnimal)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void ModifyGroupMoraleOnGunshot(PackAnimal animal)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallsUnknownMethods(Count = 1)]
	public void ModifyGroupMoraleOnFlashLightHighBeam(PackAnimal animal)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallsUnknownMethods(Count = 1)]
	public void ModifyGroupMoraleOnHitWithItem(PackAnimal animal, GearItem item)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallsUnknownMethods(Count = 1)]
	public void ModifyGroupMoraleOnThrownItem(PackAnimal animal, GearItem item)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterFlee")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnDamage")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnNearMissGunshot")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnFlareGunRound")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnGunshot")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnFlashLightHighBeam")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnHitWithItem")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnThrownItem")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "MaybeScareWildlife")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallsUnknownMethods(Count = 2)]
	public bool ModifyGroupMorale(PackSettings modeSettings, PackAnimal animal, float percent, MoraleModifierType eventType)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public PackAnimal GetPackLeader(BaseAi ai)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsUnknownMethods(Count = 1)]
	public int GetMemberCount(PackAnimal leader)
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetPackCombatRestricted(bool enable)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldPlayTimberwolfAttackStartAnimation")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFootstepAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[CalledBy(Type = typeof(PackManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PackManager), Member = "CanAttack")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeSetPackAttackCooldownTime")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceAttackInCombatRestrictedArea")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceMoveMembers")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeMoveToNewHoldGroundPosition")]
	[CalledBy(Type = typeof(AiTimberwolf), Member = "CanPerformPassingAttackChance")]
	[CalledBy(Type = typeof(AiTimberwolf), Member = "CanPerformPassingAttack")]
	[CalledBy(Type = typeof(AiTimberwolf), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(AiTimberwolf), Member = "CanEnterHideAndSeekInternal")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public bool IsPackCombatRestricted(PackAnimal animal)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsUnknownMethods(Count = 1)]
	public int GetFormationCount(PackAnimal leader)
	{
		return 0;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundFightOrFlight")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnMoraleCheck")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(PackManager), Member = "GroupMoraleHeuristic")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 6)]
	public bool ShouldAnimalFlee(PackAnimal animal)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[CallsUnknownMethods(Count = 1)]
	public float GetMoraleThreshold()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(PackManager), Member = "GroupMoraleHeuristic")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsUnknownMethods(Count = 1)]
	public bool ShouldAnimalFleeChance(PackAnimal animal)
	{
		return false;
	}

	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceAttackInCombatRestrictedArea")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(BaseAi), Member = "get_Timberwolf")]
	[Calls(Type = typeof(AiTarget), Member = "HoldingLitFlare")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 5)]
	public bool CanAttack(PackAnimal animal)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsUnknownMethods(Count = 1)]
	public void ClearAttackCooldownTimeOnAttackFailed(PackAnimal animal)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void MaybeSetPackAttackCooldownTime(PackAnimal animal)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(BaseAi), Member = "CanSeeTarget")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(PackManager), Member = "CanAttack")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	private void MaybeForceAttackInCombatRestrictedArea(PackSettings modeSettings)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "Serialize")]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 22)]
	private void MaybeCleanupDeadPackAnimals(PackSettings modeSettings)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "DisbandGroup")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	private void MaybeDisbandGroupOnTargetLost(PackSettings modeSettings)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnMoraleCheck")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraObjectMaterials), Member = "SwitchToNormalMaterials")]
	[Calls(Type = typeof(AuroraObjectMaterials), Member = "SwitchToAuroraMaterials")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeSetAuroraMaterialsOnFlee(BaseAi ai)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PackManager), Member = "MaybeSetAuroraMaterialsOnFlee")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "RemoveGroup")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	private void MaybeFleeAndDisbandOnMoraleCheck()
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "get_Moose")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PackManager), Member = "DisbandGroup")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 17)]
	private void MaybeFleeAndDisbandOnBearOrMooseCheck(PackSettings modeSettings)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 20)]
	private void MaybeForceMoveMembers(PackSettings modeSettings)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeMoveToNewHoldGroundPosition")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsMovingToHoldGroundPosition(PackAnimal animal)
	{
		return false;
	}

	[CalledBy(Type = typeof(PackManager), Member = "MaybeMoveToNewHoldGroundPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "MaybePickHoldGroundHint")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 1)]
	private bool MaybePickAndMoveToHoldGroundHint(PackAnimal member)
	{
		return false;
	}

	[CalledBy(Type = typeof(PackManager), Member = "MaybeMoveToNewHoldGroundPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowKeyNotFoundException")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 33)]
	private void MaybeForceHoldGroundAfterReposition(PackSettings modeSettings)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(PackManager), Member = "IsMovingToHoldGroundPosition")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PackManager), Member = "MaybePickAndMoveToHoldGroundHint")]
	[Calls(Type = typeof(PackManager), Member = "MaybeForceHoldGroundAfterReposition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	private void MaybeMoveToNewHoldGroundPosition(PackSettings modeSettings)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsTaggedGroupAnimal(PackAnimal animal)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 1)]
	private static bool AreSameTaggedGroupAnimals(PackAnimal a, PackAnimal b)
	{
		return false;
	}

	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "FindPackGroupLeaderByGroupId")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindFarthestAreaMarkupOfTypeWithinRadius")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "MaybeReserveAreaMarkup")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 34)]
	private void MaybeKeepLonersWithinRadius()
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(PackManager), Member = "MaybeAlertMembers")]
	[Calls(Type = typeof(BaseAi), Member = "get_Timberwolf")]
	[Calls(Type = typeof(AiTimberwolf), Member = "ForceSetPlayerTarget")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	private void MaybeFormGroupOnPlayerDetectionRange(PackSettings modeSettings)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "MaybePickAndMoveToHoldGroundHint")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindAreaMarkupsOfTypeWithinRadius")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "MaybeReserveAreaMarkup")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentNullException")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 32)]
	private bool MaybePickHoldGroundHint(PackAnimal animal, out Vector3 point)
	{
		point = default(Vector3);
		return false;
	}

	[CalledBy(Type = typeof(TimberwolfReplenishTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePackMorale")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PackManager), Member = "GroupMoraleHeuristic")]
	[CallsUnknownMethods(Count = 4)]
	public float GetHighestPackMorale(out float modifier, out int memberCount, out int originalMemberCount)
	{
		modifier = default(float);
		memberCount = default(int);
		originalMemberCount = default(int);
		return 0f;
	}

	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 14)]
	private void MaybeEnableAnimalsOnLoad()
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 3)]
	private void ResetGroupEventFlags()
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(CustomAudioEmitter), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	private void MaybeUpdateInteriorAudio(PackSettings modeSettings)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	[CallsUnknownMethods(Count = 2)]
	public bool ArePacksAllowed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference), Member = "Get")]
	[Calls(Type = typeof(PanelReference), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[Calls(Type = typeof(PackManager), Member = "GetPackSettings")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PackManager), Member = "MaybeEnableAnimalsOnLoad")]
	[Calls(Type = typeof(PackManager), Member = "ResetGroupEventFlags")]
	[Calls(Type = typeof(PackManager), Member = "MaybeCleanupDeadPackAnimals")]
	[Calls(Type = typeof(PackManager), Member = "MaybeDisbandGroupOnTargetLost")]
	[Calls(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnMoraleCheck")]
	[Calls(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnBearOrMooseCheck")]
	[Calls(Type = typeof(PackManager), Member = "MaybeForceMoveMembers")]
	[Calls(Type = typeof(PackManager), Member = "MaybeMoveToNewHoldGroundPosition")]
	[Calls(Type = typeof(PackManager), Member = "MaybeForceAttackInCombatRestrictedArea")]
	[Calls(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[Calls(Type = typeof(PackManager), Member = "MaybeFormGroupOnPlayerDetectionRange")]
	[Calls(Type = typeof(PackManager), Member = "MaybeUpdateInteriorAudio")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	public PackManager()
	{
	}
}
