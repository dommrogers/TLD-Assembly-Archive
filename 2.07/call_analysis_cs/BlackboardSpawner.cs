using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using UnityEngine;

public class BlackboardSpawner : MonoBehaviour
{
	public GameObject m_Prefab;

	public bool m_EnableBehaviourTree;

	[Calls(Type = typeof(BlackboardSpawner), Member = "MaybeCopyBlackboardVariables")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BlackboardSpawner), Member = "SpawnInstance")]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(BlackboardSpawner), Member = "Start")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	private GameObject SpawnInstance()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BlackboardSpawner), Member = "Start")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(BlackboardSource), Member = "SetValue")]
	[Calls(Type = typeof(Blackboard), Member = "AddVariable")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	private void MaybeCopyBlackboardVariables(GameObject instance)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void MaybeEnableBehaviourTree(GameObject instance)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BlackboardSpawner()
	{
	}
}
