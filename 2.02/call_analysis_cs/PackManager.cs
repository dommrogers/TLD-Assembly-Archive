using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PackManager : MonoBehaviour
{
	public PackExperienceModeSettings m_DefaultPackExperienceModeSettings;

	public List<PackExperienceModeSettings> m_PackExperienceModeSettings;

	private Dictionary<ExperienceModeType, PackExperienceModeSettings> m_PackExperienceModeSettingsByMode;

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

	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterFlee")]
	[CalledBy(Type = typeof(PackManager), Member = "Serialize")]
	[CalledBy(Type = typeof(PackManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PackManager), Member = "RemoveGroup")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnDamage")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnNearMissGunshot")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnFlareGunRound")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnGunshot")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnFlashLightHighBeam")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnHitWithItem")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnThrownItem")]
	[CalledBy(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	[CalledBy(Type = typeof(PackManager), Member = "GetMoraleThreshold")]
	[CalledBy(Type = typeof(PackManager), Member = "ShouldAnimalFleeChance")]
	[CalledBy(Type = typeof(PackManager), Member = "CanAttack")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeSetPackAttackCooldownTime")]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private PackExperienceModeSettings GetExperienceModeSettings()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public string SerializeGlobal()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void DeserializeGlobal(string serialized)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(PackManager), Member = "MaybeCleanupDeadPackAnimals")]
	[Calls(Type = typeof(PackManagerDataProxyList), Member = ".ctor")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PackManagerDataProxy), Member = ".ctor")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 39)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(PackManager), Member = "MaybeAddOrUpdateGroup")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ForceSetPlayerTarget")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 32)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void RegisterPackAnimal(PackAnimal pa)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "DisbandGroup")]
	[CalledBy(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(PackManager), Member = "GroupMoraleHeuristic")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 22)]
	private void RemoveGroup(PackAnimal leader, bool setReformTimer)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "MaybeAddOrUpdateGroup")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(PackGroup), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 22)]
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

	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private bool CanAnimalFormGroup(PackAnimal animal)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroupOnPlayerDetectionRange")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "CanAnimalFormGroup")]
	[Calls(Type = typeof(PackManager), Member = "MaybeAddOrUpdateGroup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(PackManager), Member = "DisbandGroup")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 35)]
	public bool MaybeFormGroup(PackAnimal newLeader)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroupOnPlayerDetectionRange")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public void MaybeAlertMembers(PackAnimal animal)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessJoinPack")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeStartOrJoinPackHowl")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PackManager), Member = "IsLeader")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public void MaybeStartHowl(PackAnimal animal)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeDisbandGroupOnTargetLost")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnMoraleCheck")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnBearOrMooseCheck")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "RemoveGroup")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public bool DisbandGroup(PackAnimal pa, bool setReformTimer)
	{
		return false;
	}

	[CalledBy(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PackManager), Member = "ChooseLeader")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(PackManager), Member = "RemoveGroup")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
	public void UnregisterPackAnimal(PackAnimal pa, bool onDeath)
	{
	}

	[CallerCount(Count = 30)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool InPack(PackAnimal animal)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeStartOrJoinPackHowl")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessJoinPack")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeStartHowl")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnDamage")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsLeader(PackAnimal animal)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPerformPassingAttackChance")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPerformPassingAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterPassingAttack")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsValidPackTarget(AiTarget target)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "FindHighGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "FindRandomLocation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public float GroupMoraleHeuristic(PackAnimal animal)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void DebugMoraleReport(string text, float value)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(PackManager), Member = "IsLeader")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallsUnknownMethods(Count = 1)]
	public void ModifyGroupMoraleOnDamage(PackAnimal animal)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallsUnknownMethods(Count = 1)]
	public void ModifyGroupMoraleOnNearMissGunshot(PackAnimal animal)
	{
	}

	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "MaybeScareWildlife")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallsUnknownMethods(Count = 1)]
	public void ModifyGroupMoraleOnFlareGunRound(PackAnimal animal, bool isStuckInAnimal)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	public void ModifyGroupMoraleOnGunshot(PackAnimal animal)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallsUnknownMethods(Count = 1)]
	public void ModifyGroupMoraleOnFlashLightHighBeam(PackAnimal animal)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void ModifyGroupMoraleOnHitWithItem(PackAnimal animal, GearItem item)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
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
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public bool ModifyGroupMorale(PackExperienceModeSettings modeSettings, PackAnimal animal, float percent, MoraleModifierType eventType)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public PackAnimal GetPackLeader(BaseAi ai)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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
	[CalledBy(Type = typeof(BaseAi), Member = "CanPerformPassingAttackChance")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPerformPassingAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(PackManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PackManager), Member = "CanAttack")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeSetPackAttackCooldownTime")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceAttackInCombatRestrictedArea")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceMoveMembers")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeMoveToNewHoldGroundPosition")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	public bool IsPackCombatRestricted(PackAnimal animal)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(PackManager), Member = "GroupMoraleHeuristic")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public bool ShouldAnimalFlee(PackAnimal animal)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[CallsUnknownMethods(Count = 1)]
	public float GetMoraleThreshold()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(PackManager), Member = "GroupMoraleHeuristic")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool ShouldAnimalFleeChance(PackAnimal animal)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceAttackInCombatRestrictedArea")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(AiTarget), Member = "HoldingLitFlare")]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 24)]
	public bool CanAttack(PackAnimal animal)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void ClearAttackCooldownTimeOnAttackFailed(PackAnimal animal)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
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
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(PackManager), Member = "CanAttack")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	private void MaybeForceAttackInCombatRestrictedArea(PackExperienceModeSettings modeSettings)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "Serialize")]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 26)]
	private void MaybeCleanupDeadPackAnimals(PackExperienceModeSettings modeSettings)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(PackManager), Member = "DisbandGroup")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 19)]
	private void MaybeDisbandGroupOnTargetLost(PackExperienceModeSettings modeSettings)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnMoraleCheck")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AuroraObjectMaterials), Member = "SwitchToNormalMaterials")]
	[Calls(Type = typeof(AuroraObjectMaterials), Member = "SwitchToAuroraMaterials")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void MaybeSetAuroraMaterialsOnFlee(BaseAi ai)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PackManager), Member = "MaybeSetAuroraMaterialsOnFlee")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(PackManager), Member = "DisbandGroup")]
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
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(PackManager), Member = "DisbandGroup")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	private void MaybeFleeAndDisbandOnBearOrMooseCheck(PackExperienceModeSettings modeSettings)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	private void MaybeForceMoveMembers(PackExperienceModeSettings modeSettings)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeMoveToNewHoldGroundPosition")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 25)]
	private void MaybeForceHoldGroundAfterReposition(PackExperienceModeSettings modeSettings)
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(PackManager), Member = "IsMovingToHoldGroundPosition")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(PackManager), Member = "MaybePickAndMoveToHoldGroundHint")]
	[Calls(Type = typeof(PackManager), Member = "MaybeForceHoldGroundAfterReposition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private void MaybeMoveToNewHoldGroundPosition(PackExperienceModeSettings modeSettings)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsTaggedGroupAnimal(PackAnimal animal)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsUnknownMethods(Count = 1)]
	private static bool AreSameTaggedGroupAnimals(PackAnimal a, PackAnimal b)
	{
		return false;
	}

	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(PackManager), Member = "FindPackGroupLeaderByGroupId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindFarthestAreaMarkupOfTypeWithinRadius")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "MaybeReserveAreaMarkup")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 39)]
	private void MaybeKeepLonersWithinRadius()
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(PackManager), Member = "MaybeAlertMembers")]
	[Calls(Type = typeof(BaseAi), Member = "ForceSetPlayerTarget")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	private void MaybeFormGroupOnPlayerDetectionRange(PackExperienceModeSettings modeSettings)
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "MaybeReserveAreaMarkup")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 37)]
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
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 14)]
	private void MaybeEnableAnimalsOnLoad()
	{
	}

	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(CustomAudioEmitter), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	private void MaybeUpdateInteriorAudio(PackExperienceModeSettings modeSettings)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool ArePacksAllowed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Panel_HUD), Member = "QuietlyResetTimberWolfCombatMusic")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 78)]
	public PackManager()
	{
	}
}
