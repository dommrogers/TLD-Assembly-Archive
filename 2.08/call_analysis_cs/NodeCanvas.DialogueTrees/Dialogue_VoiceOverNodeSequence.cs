using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

public class Dialogue_VoiceOverNodeSequence : DTNode
{
	[Serializable]
	public class ActorVoiceOverItem
	{
		public bool m_IsUnfolded;

		private string m_ActorName;

		private string m_ActorParameterID;

		[NonSerialized]
		public DialogueTree m_DialogueTree;

		public VoiceOverItem m_VoiceOverItem;

		public string actorName
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DialogueTree), Member = "GetParameterByID")]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return null;
			}
			[CallerCount(Count = 0)]
			[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
			[Calls(Type = typeof(DialogueTree), Member = "GetParameterByName")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			set
			{
			}
		}

		public IDialogueActor finalActor
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DialogueTree), Member = "GetParameterByID")]
			[Calls(Type = typeof(DialogueTree), Member = "GetActorReferenceByName")]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VoiceOverItem), Member = ".ctor")]
		[CallsUnknownMethods(Count = 1)]
		public ActorVoiceOverItem()
		{
		}
	}

	public List<ActorVoiceOverItem> m_ActorVoiceOverItemList;

	private int m_CurrentIndex;

	public override bool requireActorSelection
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return false;
		}
	}

	public override string name
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(BBParameter), Member = "ResolveReference")]
	[Calls(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "PlayStatement")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "OnExecute")]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "OnStatementFinish")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VoiceOverItem), Member = "GetLocId")]
	[Calls(Type = typeof(DialogueTree), Member = "GetParameterByID")]
	[Calls(Type = typeof(DialogueTree), Member = "GetActorReferenceByName")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnSpeech")]
	[Calls(Type = typeof(DialogueTree), Member = "RequestSubtitles")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void PlayStatement(int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	[Calls(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "PlayStatement")]
	[CallsUnknownMethods(Count = 1)]
	private void OnStatementFinish()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	[CallsUnknownMethods(Count = 1)]
	private void OnSequenceFinish()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Dialogue_VoiceOverNodeSequence()
	{
	}
}
