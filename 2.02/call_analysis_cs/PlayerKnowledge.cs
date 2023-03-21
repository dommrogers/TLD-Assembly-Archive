using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayerKnowledge : MonoBehaviour
{
	public List<GameObject> m_KnowledgeObjects;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void AddKnowledge(GameObject go)
	{
	}

	[CalledBy(Type = typeof(PlayerKnowledge), Member = "InstantiateRandomKnowledge")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	public bool KnownByPlayer(string name)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerKnowledge), Member = "KnownByPlayer")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 13)]
	public GameObject InstantiateRandomKnowledge(GameObject[] knowledgePrefabArray)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public GameObject GetKnowledgeInstance(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public PlayerKnowledge()
	{
	}
}
