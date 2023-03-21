using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.StateMachines;

public class FSMDictionaryVarType
{
	public Dictionary<Graph, State_TLDBaseFSM> dict;

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "RegisterAsSubFSMOwner")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public FSMDictionaryVarType()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void AddElement(Graph g, State_TLDBaseFSM s)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void RemoveElement(Graph g)
	{
	}
}
