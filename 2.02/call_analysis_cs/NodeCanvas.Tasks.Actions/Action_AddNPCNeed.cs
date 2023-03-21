using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_AddNPCNeed : ActionTask
{
	public BBParameter<string> npcTrustID;

	public BBParameter<NPC_NeedPrefab> needPrefabVar;

	public NPC_NeedPrefab needPrefab;

	protected override string info
	{
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(NPC_NeedTracker), Member = "AddNeed")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TrustManager), Member = "GetNeedTracker")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public Action_AddNPCNeed()
	{
	}
}
