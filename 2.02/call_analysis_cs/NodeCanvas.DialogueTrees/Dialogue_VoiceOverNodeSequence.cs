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
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
			[Calls(Type = typeof(DialogueTree), Member = "GetParameterByID")]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return null;
			}
			[CallsUnknownMethods(Count = 2)]
			[Calls(Type = typeof(DialogueTree.ActorParameter), Member = "get_ID")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(string), Member = "EqualsHelper")]
			[Calls(Type = typeof(DialogueTree), Member = "GetParameterByName")]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(VoiceOverItem), Member = ".ctor")]
		[CallsUnknownMethods(Count = 7)]
		public ActorVoiceOverItem()
		{
		}
	}

	public List<ActorVoiceOverItem> m_ActorVoiceOverItemList;

	private int m_CurrentIndex;

	public override bool requireActorSelection
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	public override string name
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	[Calls(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "PlayStatement")]
	[CallsUnknownMethods(Count = 5)]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[CallsUnknownMethods(Count = 39)]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "OnStatementFinish")]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(DialogueModeRigFP), Member = "OnSpeech")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(DialogueTree), Member = "GetActorReferenceByName")]
	[Calls(Type = typeof(DialogueTree), Member = "GetActorReferenceByName")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Statement), Member = ".ctor")]
	[Calls(Type = typeof(DialogueTree), Member = "RequestSubtitles")]
	[Calls(Type = typeof(VoiceOverItem), Member = "GetLocId")]
	[Calls(Type = typeof(DialogueTree), Member = "GetParameterByID")]
	private void PlayStatement(int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DTNode), Member = "get_DLGTree")]
	[Calls(Type = typeof(DialogueTree), Member = "Continue")]
	[Calls(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "PlayStatement")]
	[CallsUnknownMethods(Count = 2)]
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

	[Calls(Type = typeof(DTNode), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public Dialogue_VoiceOverNodeSequence()
	{
	}
}
