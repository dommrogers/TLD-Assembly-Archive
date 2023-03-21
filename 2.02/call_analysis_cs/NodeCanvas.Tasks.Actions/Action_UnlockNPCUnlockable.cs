using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_UnlockNPCUnlockable : ActionTask
{
	public BBParameter<string> npcTrustID;

	public BBParameter<NPC_UnlockablePrefab> unlockablePrefabVar;

	public NPC_UnlockablePrefab unlockablePrefab;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 4)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(TrustManager), Member = "GetUnlockableTracker")]
	[Calls(Type = typeof(NPC_UnlockableTracker), Member = "UnlockUnlockable")]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public Action_UnlockNPCUnlockable()
	{
	}
}
