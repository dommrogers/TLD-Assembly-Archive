using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using NodeCanvas.Framework;
using TLD.Serialization;
using UnityEngine;

public class TLDBehaviourTreeManager
{
	private static List<TLDBehaviourTreeOwner> m_BehaviourTreeOwnerList;

	private static TLDBehaviourTreeManagerProxy m_TLDBehaviourTreeManagerProxy;

	private const int TREE_OWNER_PROXY_POOL_LEN = 128;

	private static TLDBehaviourTreeOwnerProxy[] m_TreeOwnerProxyPool;

	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Init()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void RegisterBehaviourTreeOwner(TLDBehaviourTreeOwner behaviourTreeOwner)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void UnregisterBehaviourTreeOwner(TLDBehaviourTreeOwner behaviourTreeOwner)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(NCUtils), Member = "GetSerializedBlackboard")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public static string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TLDBehaviourTreeManager), Member = "Deserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static TLDBehaviourTreeOwner FindBehaviourTreeOwner(string name)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[Calls(Type = typeof(TLDBehaviourTreeManager), Member = "FindBehaviourTreeOwner")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public static void Deserialize(string buffer)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public TLDBehaviourTreeManager()
	{
	}
}
