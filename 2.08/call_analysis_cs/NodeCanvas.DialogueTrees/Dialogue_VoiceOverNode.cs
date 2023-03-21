using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public class Dialogue_VoiceOverNode : DTNode
{
	public VoiceOverItem statement;

	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnSpeech")]
	[Calls(Type = typeof(DialogueTree), Member = "RequestSubtitles")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[Calls(Type = typeof(DTNode), Member = "get_finalActor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "ResolveReference")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VoiceOverItem), Member = "GetLocId")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	[CallsUnknownMethods(Count = 1)]
	private void OnStatementFinish()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VoiceOverItem), Member = ".ctor")]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public Dialogue_VoiceOverNode()
	{
	}
}
