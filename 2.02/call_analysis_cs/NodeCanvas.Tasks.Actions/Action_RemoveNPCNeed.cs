using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_RemoveNPCNeed : ActionTask
{
	public BBParameter<string> npcTrustID;

	public BBParameter<NPC_NeedPrefab> needPrefabVar;

	public NPC_NeedPrefab needPrefab;

	protected override string info
	{
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TrustManager), Member = "GetNeedTracker")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public Action_RemoveNPCNeed()
	{
	}
}
