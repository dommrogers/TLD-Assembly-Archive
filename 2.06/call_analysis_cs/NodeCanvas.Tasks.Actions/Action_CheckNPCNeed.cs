using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_CheckNPCNeed : ActionTask
{
	public BBParameter<string> npcTrustID;

	public BBParameter<NPC_NeedPrefab> needPrefabVar;

	public NPC_NeedPrefab needPrefab;

	public string needMetVar;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(TrustManager), Member = "GetNeedTracker")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	public Action_CheckNPCNeed()
	{
	}
}
