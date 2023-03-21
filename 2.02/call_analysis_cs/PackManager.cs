using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
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

	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnNearMissGunshot")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnFlareGunRound")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnFlashLightHighBeam")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnHitWithItem")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnThrownItem")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnGunshot")]
	[CalledBy(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	[CalledBy(Type = typeof(PackManager), Member = "GetMoraleThreshold")]
	[CalledBy(Type = typeof(PackManager), Member = "ShouldAnimalFleeChance")]
	[CalledBy(Type = typeof(PackManager), Member = "CanAttack")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeSetPackAttackCooldownTime")]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnDamage")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	[CalledBy(Type = typeof(PackManager), Member = "RemoveGroup")]
	[CalledBy(Type = typeof(PackManager), Member = "Serialize")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[Calls(Type = typeof(GameManager), Member = "GetCustomMode")]
	[Calls(Type = typeof(GameManager), Member = "InCustomMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 19)]
	[CalledBy(Type = typeof(PackManager), Member = "Deserialize")]
	private PackExperienceModeSettings GetExperienceModeSettings()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public string SerializeGlobal()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void DeserializeGlobal(string serialized)
	{
	}

	[CallsUnknownMethods(Count = 39)]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(PackManagerDataProxy), Member = ".ctor")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManagerDataProxyList), Member = ".ctor")]
	[Calls(Type = typeof(PackManager), Member = "MaybeCleanupDeadPackAnimals")]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(BaseAi), Member = "ForceSetPlayerTarget")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(BaseAi), Member = "Despawn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "MaybeAddOrUpdateGroup")]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void RegisterPackAnimal(PackAnimal pa)
	{
	}

	[Calls(Type = typeof(PackManager), Member = "GroupMoraleHeuristic")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(PackManager), Member = "DisbandGroup")]
	[CalledBy(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	private void RemoveGroup(PackAnimal leader, bool setReformTimer)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeAddOrUpdateGroup")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	private PackAnimal FindPackGroupLeaderByGroupId(string groupId)
	{
		return null;
	}

	[Calls(Type = typeof(PackManager), Member = "FindPackGroupLeaderByGroupId")]
	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	[CalledBy(Type = typeof(PackManager), Member = "Deserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(PackGroup), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private PackAnimal MaybeAddOrUpdateGroup(PackAnimal newLeader)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[CallerCount(Count = 0)]
	private bool IsMismatchWildlifeMode(PackAnimal animal)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool CanAnimalFormGroup(PackAnimal animal)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(PackManager), Member = "DisbandGroup")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroupOnPlayerDetectionRange")]
	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "MaybeAddOrUpdateGroup")]
	[Calls(Type = typeof(PackManager), Member = "CanAnimalFormGroup")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool MaybeFormGroup(PackAnimal newLeader)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroupOnPlayerDetectionRange")]
	public void MaybeAlertMembers(PackAnimal animal)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "IsLeader")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeStartOrJoinPackHowl")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessJoinPack")]
	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeStartOrJoinPackHowl")]
	[CallerCount(Count = 1)]
	public void MaybeStartHowl(PackAnimal animal)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeDisbandGroupOnTargetLost")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnMoraleCheck")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnBearOrMooseCheck")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "RemoveGroup")]
	public bool DisbandGroup(PackAnimal pa, bool setReformTimer)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[CallsUnknownMethods(Count = 4)]
	public PackAnimal ChooseLeader(PackGroup pack)
	{
		return null;
	}

	[Calls(Type = typeof(PackManager), Member = "RemoveGroup")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterDead")]
	[CalledBy(Type = typeof(PackAnimal), Member = "OnDestroy")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeCleanupDeadPackAnimals")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeCleanupDeadPackAnimals")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "ChooseLeader")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void UnregisterPackAnimal(PackAnimal pa, bool onDeath)
	{
	}

	[CallerCount(Count = 30)]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeStartOrJoinPackHowl")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public static bool IsLeader(PackAnimal animal)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeForceHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPerformPassingAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPerformPassingAttackChance")]
	[CalledBy(Type = typeof(BaseAi), Member = "TargetCanBeIgnored")]
	[CalledBy(Type = typeof(BaseAi), Member = "ScanForNewTarget")]
	[Calls(Type = typeof(AiTarget), Member = "IsNpcSurvivor")]
	[Calls(Type = typeof(AiTarget), Member = "IsPlayer")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterPassingAttack")]
	public static bool IsValidPackTarget(AiTarget target)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(BaseAi), Member = "FindHighGround")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "FindRandomLocation")]
	public bool IsPointCloseToPackMembers(PackAnimal animal, Vector3 point, float radius)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PackManager), Member = "ShouldAnimalFleeChance")]
	[CalledBy(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	[CalledBy(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	[CalledBy(Type = typeof(PackManager), Member = "RemoveGroup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(PackManager), Member = "GetHighestPackMorale")]
	[CallsUnknownMethods(Count = 4)]
	public float GroupMoraleHeuristic(PackAnimal animal)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	private void DebugMoraleReport(string text, float value)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CalledBy(Type = typeof(BaseAi), Member = "ApplyDamage")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "IsLeader")]
	public void ModifyGroupMoraleOnDamage(PackAnimal animal)
	{
	}

	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[CallsUnknownMethods(Count = 1)]
	public void ModifyGroupMoraleOnNearMissGunshot(PackAnimal animal)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "MaybeScareWildlife")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[CallerCount(Count = 2)]
	public void ModifyGroupMoraleOnFlareGunRound(PackAnimal animal, bool isStuckInAnimal)
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	public void ModifyGroupMoraleOnGunshot(PackAnimal animal)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	public void ModifyGroupMoraleOnFlashLightHighBeam(PackAnimal animal)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void ModifyGroupMoraleOnHitWithItem(PackAnimal animal, GearItem item)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeFromThrownItem")]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "ModifyGroupMorale")]
	[CallerCount(Count = 1)]
	public void ModifyGroupMoraleOnThrownItem(PackAnimal animal, GearItem item)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnFlareGunRound")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnGunshot")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnFlashLightHighBeam")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnNearMissGunshot")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnHitWithItem")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnThrownItem")]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnThrownItem")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PackManager), Member = "ModifyGroupMoraleOnDamage")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterFlee")]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool ModifyGroupMorale(PackExperienceModeSettings modeSettings, PackAnimal animal, float percent, MoraleModifierType eventType)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public PackAnimal GetPackLeader(BaseAi ai)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public int GetMemberCount(PackAnimal leader)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetPackCombatRestricted(bool enable)
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHoldGround")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessHideAndSeek")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPerformPassingAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanPerformPassingAttackChance")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFootstepAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "ShouldPlayTimberwolfAttackStartAnimation")]
	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[CalledBy(Type = typeof(PackManager), Member = "Deserialize")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(PackManager), Member = "CanAttack")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeSetPackAttackCooldownTime")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceAttackInCombatRestrictedArea")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceMoveMembers")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeMoveToNewHoldGroundPosition")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	public bool IsPackCombatRestricted(PackAnimal animal)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public int GetFormationCount(PackAnimal leader)
	{
		return default(int);
	}

	[Calls(Type = typeof(PackManager), Member = "GroupMoraleHeuristic")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PackManager), Member = "GroupMoraleHeuristic")]
	[CalledBy(Type = typeof(BaseAi), Member = "ChangeModeWhenTargetDetected")]
	[CalledBy(Type = typeof(BaseAi), Member = "HoldGroundFightOrFlight")]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnMoraleCheck")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(BaseAi), Member = "IsMismatchWildlifeMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	public bool ShouldAnimalFlee(PackAnimal animal)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[CallsUnknownMethods(Count = 1)]
	public float GetMoraleThreshold()
	{
		return default(float);
	}

	[Calls(Type = typeof(Utils), Member = "RollChance")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessGunshotAudioEvent")]
	[CalledBy(Type = typeof(BaseAi), Member = "AttackOrFleeAfterNearMissGunshot")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(PackManager), Member = "GroupMoraleHeuristic")]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool ShouldAnimalFleeChance(PackAnimal animal)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(BaseAi), Member = "IsTimberwolf")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AiTarget), Member = "HoldingLitFlare")]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(BaseAi), Member = "CanPathfindToPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BaseAi), Member = "IsInFlashLight")]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeForceAttackInCombatRestrictedArea")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAiMode")]
	public bool CanAttack(PackAnimal animal)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BaseAi), Member = "CantReachTarget")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeApplyAttack")]
	public void ClearAttackCooldownTimeOnAttackFailed(PackAnimal animal)
	{
	}

	[CalledBy(Type = typeof(BaseAi), Member = "EnterAttack")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public void MaybeSetPackAttackCooldownTime(PackAnimal animal)
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(MoveAgent), Member = "CanFindPath")]
	[Calls(Type = typeof(PackManager), Member = "CanAttack")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BaseAi), Member = "CanSeeTarget")]
	[CallerCount(Count = 1)]
	private void MaybeForceAttackInCombatRestrictedArea(PackExperienceModeSettings modeSettings)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(PackManager), Member = "Serialize")]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallsUnknownMethods(Count = 26)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[Calls(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	private void MaybeCleanupDeadPackAnimals(PackExperienceModeSettings modeSettings)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "DisbandGroup")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	private void MaybeDisbandGroupOnTargetLost(PackExperienceModeSettings modeSettings)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnMoraleCheck")]
	[Calls(Type = typeof(AuroraObjectMaterials), Member = "SwitchToAuroraMaterials")]
	[Calls(Type = typeof(AuroraObjectMaterials), Member = "SwitchToNormalMaterials")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void MaybeSetAuroraMaterialsOnFlee(BaseAi ai)
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PackManager), Member = "DisbandGroup")]
	[Calls(Type = typeof(AchievementManager), Member = "UpdateAchievements")]
	[Calls(Type = typeof(PackManager), Member = "MaybeSetAuroraMaterialsOnFlee")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PackManager), Member = "ShouldAnimalFlee")]
	[CallsUnknownMethods(Count = 15)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 5)]
	private void MaybeFleeAndDisbandOnMoraleCheck()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[Calls(Type = typeof(PackManager), Member = "DisbandGroup")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	private void MaybeFleeAndDisbandOnBearOrMooseCheck(PackExperienceModeSettings modeSettings)
	{
	}

	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "IsPlayerFacingAi")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Time), Member = "get_time")]
	private void MaybeForceMoveMembers(PackExperienceModeSettings modeSettings)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeMoveToNewHoldGroundPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "CanEnterStalking")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool IsMovingToHoldGroundPosition(PackAnimal animal)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeMoveToNewHoldGroundPosition")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(PackManager), Member = "MaybePickHoldGroundHint")]
	private bool MaybePickAndMoveToHoldGroundHint(PackAnimal member)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybeMoveToNewHoldGroundPosition")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(BaseAi), Member = "ClearTarget")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	private void MaybeForceHoldGroundAfterReposition(PackExperienceModeSettings modeSettings)
	{
	}

	[Calls(Type = typeof(PackManager), Member = "IsPackCombatRestricted")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[Calls(Type = typeof(PackManager), Member = "MaybeForceHoldGroundAfterReposition")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PackManager), Member = "IsMovingToHoldGroundPosition")]
	[Calls(Type = typeof(PackManager), Member = "MaybePickAndMoveToHoldGroundHint")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private void MaybeMoveToNewHoldGroundPosition(PackExperienceModeSettings modeSettings)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool IsTaggedGroupAnimal(PackAnimal animal)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals")]
	private static bool AreSameTaggedGroupAnimals(PackAnimal a, PackAnimal b)
	{
		return default(bool);
	}

	[Calls(Type = typeof(AreaMarkupManager), Member = "FindFarthestAreaMarkupOfTypeWithinRadius")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "MaybeReserveAreaMarkup")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(BaseAi), Member = "StartPath")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallsUnknownMethods(Count = 39)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(MoveAgent), Member = "GetDestination")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MoveAgent), Member = "HasPath")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(BaseAi), Member = "IsImposter")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[Calls(Type = typeof(PackManager), Member = "FindPackGroupLeaderByGroupId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private void MaybeKeepLonersWithinRadius()
	{
	}

	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(PackManager), Member = "MaybeFormGroup")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PackManager), Member = "InPack")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "ForceSetPlayerTarget")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[Calls(Type = typeof(PackManager), Member = "MaybeAlertMembers")]
	private void MaybeFormGroupOnPlayerDetectionRange(PackExperienceModeSettings modeSettings)
	{
	}

	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 37)]
	[CalledBy(Type = typeof(PackManager), Member = "MaybePickAndMoveToHoldGroundHint")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "MaybeReserveAreaMarkup")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(AreaMarkupManager), Member = "FindAreaMarkupsOfTypeWithinRadius")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private bool MaybePickHoldGroundHint(PackAnimal animal, out Vector3 point)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref point) = null;
		return default(bool);
	}

	[Calls(Type = typeof(PackManager), Member = "GroupMoraleHeuristic")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdatePackMorale")]
	[CalledBy(Type = typeof(TimberwolfReplenishTrigger), Member = "OnTriggerEnter")]
	public float GetHighestPackMorale(out float modifier, out int memberCount, out int originalMemberCount)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref modifier) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref memberCount) = null;
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref originalMemberCount) = null;
		return default(float);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 13)]
	private void MaybeEnableAnimalsOnLoad()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	private void ResetGroupEventFlags()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(PackManager), Member = "Update")]
	[Calls(Type = typeof(CustomAudioEmitter), Member = "Enable")]
	[Calls(Type = typeof(Utils), Member = "DistanceSqr")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void MaybeUpdateInteriorAudio(PackExperienceModeSettings modeSettings)
	{
	}

	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool ArePacksAllowed()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetWildlifeNotAttackUnprovoked")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Panel_HUD), Member = "QuietlyResetTimberWolfCombatMusic")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[Calls(Type = typeof(PackManager), Member = "MaybeMoveToNewHoldGroundPosition")]
	[Calls(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnMoraleCheck")]
	[Calls(Type = typeof(PackManager), Member = "MaybeDisbandGroupOnTargetLost")]
	[Calls(Type = typeof(PackManager), Member = "MaybeCleanupDeadPackAnimals")]
	[Calls(Type = typeof(PackManager), Member = "ResetGroupEventFlags")]
	[Calls(Type = typeof(PackManager), Member = "MaybeEnableAnimalsOnLoad")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(PackManager), Member = "GetExperienceModeSettings")]
	[Calls(Type = typeof(GameManager), Member = "ControlsLocked")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PackManager), Member = "MaybeForceAttackInCombatRestrictedArea")]
	[Calls(Type = typeof(PackManager), Member = "MaybeKeepLonersWithinRadius")]
	[Calls(Type = typeof(PackManager), Member = "MaybeFormGroupOnPlayerDetectionRange")]
	[Calls(Type = typeof(PackManager), Member = "MaybeUpdateInteriorAudio")]
	[Calls(Type = typeof(PackManager), Member = "MaybeFleeAndDisbandOnBearOrMooseCheck")]
	[Calls(Type = typeof(PackManager), Member = "MaybeForceMoveMembers")]
	public void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 78)]
	[CallerCount(Count = 0)]
	public PackManager()
	{
	}
}
