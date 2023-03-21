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
			[CallsUnknownMethods(Count = 1)]
			[Calls(Type = typeof(DialogueTree), Member = "GetParameterByID")]
			[CallerCount(Count = 0)]
			get
			{
				return null;
			}
			[CallsUnknownMethods(Count = 1)]
			[Calls(Type = typeof(DialogueTree), Member = "GetParameterByName")]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
			set
			{
			}
		}

		public IDialogueActor finalActor
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DialogueTree), Member = "GetParameterByID")]
			[Calls(Type = typeof(DialogueTree), Member = "GetActorReferenceByName")]
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
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
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

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(BBParameter), Member = "ResolveReference")]
	[Calls(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "PlayStatement")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "OnStatementFinish")]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "OnExecute")]
	[Calls(Type = typeof(DialogueTree), Member = "RequestSubtitles")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnSpeech")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(DialogueTree), Member = "GetActorReferenceByName")]
	[Calls(Type = typeof(DialogueTree), Member = "GetParameterByID")]
	[Calls(Type = typeof(VoiceOverItem), Member = "GetLocId")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DialogueTree), Member = "GetActorReferenceByName")]
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

	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	private void OnSequenceFinish()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public Dialogue_VoiceOverNodeSequence()
	{
	}
}
