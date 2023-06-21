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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_SpawnObjectOnPlayer), Member = "MaybeSpawnProp")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[CallsUnknownMethods(Count = 3)]
	private Transform GetParentJoint()
	{
		return null;
	}

	[CalledBy(Type = typeof(Action_SpawnObjectOnPlayer), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Utils), Member = "SetObjectAndChildrenLayer")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void MaybeSpawnProp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnStop()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_SpawnObjectOnPlayer()
	{
	}
}
