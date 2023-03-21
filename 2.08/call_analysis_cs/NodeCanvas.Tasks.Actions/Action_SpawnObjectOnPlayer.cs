using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_SpawnObjectOnPlayer : ActionTask
{
	public BBParameter<GameObject> prefab;

	public BBParameter<GameObject> spawnedObject;

	public BBParameter<bool> propInWorldSpace;

	public BBParameter<bool> destroyOnComplete;

	public BBParameter<SpawnLocation> spawnLocation;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_SpawnObjectOnPlayer), Member = "MaybeSpawnProp")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	private Transform GetParentJoint()
	{
		return null;
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "SetObjectAndChildrenLayer")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(Action_SpawnObjectOnPlayer), Member = "OnExecute")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void MaybeSpawnProp()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnStop()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_SpawnObjectOnPlayer()
	{
	}
}
