using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public class Dialogue_VoiceOverNode : DTNode
{
	public VoiceOverItem statement;

	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnSpeech")]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DialogueTree), Member = "RequestSubtitles")]
	[Calls(Type = typeof(VoiceOverItem), Member = "GetLocId")]
	[CallsUnknownMethods(Count = 21)]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnStatementFinish()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VoiceOverItem), Member = ".ctor")]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public Dialogue_VoiceOverNode()
	{
	}
}
