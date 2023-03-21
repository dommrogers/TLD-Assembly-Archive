using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using NodeCanvas.Tasks.Actions;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Serializable]
public class Statement : IStatement
{
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public IBlackboard bb;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass21_0()
		{
		}

		[Calls(Type = typeof(string), Member = "SplitInternal")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(BlackboardSource), Member = "GetVariable")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallsUnknownMethods(Count = 11)]
		[Calls(Type = typeof(GlobalBlackboard), Member = "Find")]
		[Calls(Type = typeof(string), Member = "IndexOf")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "SplitInternal")]
		internal string _003CBlackboardReplace_003Eb__0(string input)
		{
			return null;
		}
	}

	private string _text;

	private AudioClip _audio;

	private string _meta;

	private VoiceOverAnimationState _anim;

	public string text
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		set
		{
		}
	}

	public AudioClip audio
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		set
		{
		}
	}

	public string meta
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 41)]
		set
		{
		}
	}

	public VoiceOverAnimationState anim
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(VoiceOverAnimationState);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "PlayStatement")]
	public Statement()
	{
	}

	[CalledBy(Type = typeof(ParlayNPCResponseNode), Member = ".ctor")]
	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnChildConnected")]
	[CalledBy(Type = typeof(StatementNode), Member = ".ctor")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Say), Member = ".ctor")]
	public Statement(string text)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public Statement(string text, AudioClip audio)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Statement(string text, VoiceOverAnimationState anim)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Statement(string text, AudioClip audio, string meta)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(SayRandom), Member = "OnExecute")]
	[CalledBy(Type = typeof(StatementNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(MultipleChoiceNode), Member = "OnOptionSelected")]
	[CalledBy(Type = typeof(MultipleChoiceNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(Say), Member = "OnExecute")]
	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnOptionSelected")]
	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnExecute")]
	[Calls(Type = typeof(StringUtils), Member = "ReplaceWithin")]
	[CalledBy(Type = typeof(ParlayNPCResponseNode), Member = "OnExecute")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	public IStatement BlackboardReplace(IBlackboard bb)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 52)]
	public override string ToString()
	{
		return null;
	}
}
