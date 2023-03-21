using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Action_SpawnHuntedChallengeBear : ActionTask
{
	public bool spawnOnTopOfPlayer;

	public BBParameter<float> bearHP;

	public BBParameter<float> forceStalkDistance;

	public BBParameter<float> minSpawnDistance;

	public BBParameter<float> maxSpawnDistance;

	private const string WILDLIFE_BEAR = "WILDLIFE_BearHuntedChallenge";

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "OnUpdate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearOnTopOfPlayer")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	private void SpawnBear()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnBear")]
	protected override void OnUpdate()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearOnTopOfPlayer")]
	[Calls(Type = typeof(BaseAi), Member = "SetRotation")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[Calls(Type = typeof(MoveAgent), Member = "Warp")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(BaseAi), Member = "IsMoveAgent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private GameObject InstantiateChallengeBear(Vector3 pos, Quaternion rot)
	{
		return null;
	}

	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnBear")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "InstantiateChallengeBear")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private bool SpawnChallengeBearOnTopOfPlayer()
	{
		return default(bool);
	}

	[Calls(Type = typeof(AiUtils), Member = "GetNavmeshArea")]
	[Calls(Type = typeof(CameraFade), Member = "GetFadeAlpha")]
	[Calls(Type = typeof(Utils), Member = "GetPlayerEyePosition")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "InstantiateChallengeBear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NavMeshPath), Member = "get_status")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(NavMeshPath), Member = "ClearCorners")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(AiUtils), Member = "GetRandomPointOnNavmesh")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(NavMeshPath), Member = ".ctor")]
	[Calls(Type = typeof(AiUtils), Member = "GetNavmeshArea")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnBear")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Utils), Member = "SceneIsTransition")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 15)]
	private bool SpawnChallengeBearNearPlayer()
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool ChallengeBearIsActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	public Action_SpawnHuntedChallengeBear()
	{
	}
}
