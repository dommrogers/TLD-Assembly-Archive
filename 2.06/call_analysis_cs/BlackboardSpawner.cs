using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using UnityEngine;

public class BlackboardSpawner : MonoBehaviour
{
	public GameObject m_Prefab;

	public bool m_EnableBehaviourTree;

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BlackboardSpawner), Member = "MaybeCopyBlackboardVariables")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BlackboardSpawner), Member = "SpawnInstance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(BlackboardSpawner), Member = "Start")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[CallerCount(Count = 1)]
	private GameObject SpawnInstance()
	{
		return null;
	}

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Blackboard), Member = "AddVariable")]
	[Calls(Type = typeof(BlackboardSource), Member = "GetVariable")]
	[Calls(Type = typeof(BlackboardSource), Member = "SetValue")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(BlackboardSpawner), Member = "Start")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	private void MaybeCopyBlackboardVariables(GameObject instance)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeEnableBehaviourTree(GameObject instance)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public BlackboardSpawner()
	{
	}
}
