using System;
using System.Linq;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using NodeCanvas.Tasks.Actions;
using ParadoxNotion;
using ParadoxNotion.Serialization;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Serializable]
public class Statement : IStatement
{
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public IBlackboard bb;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass21_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[Calls(Type = typeof(string), Member = "IndexOf")]
		[Calls(Type = typeof(string), Member = "SplitInternal")]
		[Calls(Type = typeof(Enumerable), Member = "First")]
		[Calls(Type = typeof(GlobalBlackboard), Member = "Find")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Enumerable), Member = "Last")]
		[Calls(Type = typeof(BlackboardSource), Member = "GetVariable")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 11)]
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
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		set
		{
		}
	}

	public AudioClip audio
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 77)]
		set
		{
		}
	}

	public string meta
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
		set
		{
		}
	}

	public VoiceOverAnimationState anim
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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

	[CalledBy(Type = typeof(Dialogue_VoiceOverNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "PlayStatement")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Statement()
	{
	}

	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnChildConnected")]
	[CalledBy(Type = typeof(ParlayNPCResponseNode), Member = ".ctor")]
	[CalledBy(Type = typeof(StatementNode), Member = ".ctor")]
	[CalledBy(Type = typeof(Say), Member = ".ctor")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Statement(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnOptionSelected")]
	[CalledBy(Type = typeof(ParlayNPCResponseNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(MultipleChoiceNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(MultipleChoiceNode), Member = "OnOptionSelected")]
	[CalledBy(Type = typeof(StatementNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(Say), Member = "OnExecute")]
	[CalledBy(Type = typeof(SayRandom), Member = "OnExecute")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(JSONSerializer), Member = "Clone")]
	[Calls(Type = typeof(StringUtils), Member = "ReplaceWithin")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	public IStatement BlackboardReplace(IBlackboard bb)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 59)]
	public override string ToString()
	{
		return null;
	}
}
