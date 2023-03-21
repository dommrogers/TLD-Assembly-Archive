using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using UnityEngine;

public class BlackboardSpawner : MonoBehaviour
{
	public GameObject m_Prefab;

	public bool m_EnableBehaviourTree;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlackboardSpawner), Member = "SpawnInstance")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(BlackboardSpawner), Member = "MaybeCopyBlackboardVariables")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(BlackboardSpawner), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 15)]
	private GameObject SpawnInstance()
	{
		return null;
	}

	[CalledBy(Type = typeof(BlackboardSpawner), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(BlackboardSource), Member = "GetVariable")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Blackboard), Member = "AddVariable")]
	[Calls(Type = typeof(BlackboardSource), Member = "SetValue")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	private void MaybeCopyBlackboardVariables(GameObject instance)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeEnableBehaviourTree(GameObject instance)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public BlackboardSpawner()
	{
	}
}
