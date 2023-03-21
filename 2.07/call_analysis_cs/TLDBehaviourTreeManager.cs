using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
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
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 1)]
	public static void Init()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void RegisterBehaviourTreeOwner(TLDBehaviourTreeOwner behaviourTreeOwner)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void UnregisterBehaviourTreeOwner(TLDBehaviourTreeOwner behaviourTreeOwner)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(Blackboard), Member = "RestoreInternalVars")]
	[Calls(Type = typeof(Blackboard), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Blackboard), Member = "ExtractInternalVars")]
	[CallsUnknownMethods(Count = 5)]
	public static string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(TLDBehaviourTreeManager), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public static TLDBehaviourTreeOwner FindBehaviourTreeOwner(string name)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TLDBehaviourTreeManager), Member = "FindBehaviourTreeOwner")]
	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 2)]
	public static void Deserialize(string buffer)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public TLDBehaviourTreeManager()
	{
	}
}
