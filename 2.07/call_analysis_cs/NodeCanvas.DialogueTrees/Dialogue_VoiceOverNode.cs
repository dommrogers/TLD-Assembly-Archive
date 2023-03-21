using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public class Dialogue_VoiceOverNode : DTNode
{
	public VoiceOverItem statement;

	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(DialogueTree), Member = "RequestSubtitles")]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnSpeech")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "ResolveReference")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VoiceOverItem), Member = "GetLocId")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnStatementFinish()
	{
	}

	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VoiceOverItem), Member = ".ctor")]
	public Dialogue_VoiceOverNode()
	{
	}
}
