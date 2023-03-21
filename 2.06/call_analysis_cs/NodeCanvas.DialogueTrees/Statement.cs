using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Serializable]
public class Statement : IStatement
{
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public IBlackboard bb;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass21_0()
		{
		}

		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[Calls(Type = typeof(string), Member = "Split")]
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(BlackboardSource), Member = "GetVariable")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(string), Member = "IndexOf")]
		[Calls(Type = typeof(string), Member = "Split")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(GlobalBlackboard), Member = "Find")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
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
		[CallerCount(Count = 98)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 265)]
		set
		{
		}
	}

	public AudioClip audio
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 85)]
		set
		{
		}
	}

	public string meta
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 51)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Statement()
	{
	}

	[CalledBy(Type = typeof(StatementNode), Member = ".ctor")]
	[CalledBy(Type = typeof(Say), Member = ".ctor")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnChildConnected")]
	[CalledBy(Type = typeof(ParlayNPCResponseNode), Member = ".ctor")]
	public Statement(string text)
	{
	}

	[CallerCount(Count = 0)]
	public Statement(string text, AudioClip audio)
	{
	}

	[CallerCount(Count = 0)]
	public Statement(string text, VoiceOverAnimationState anim)
	{
	}

	[CallerCount(Count = 0)]
	public Statement(string text, AudioClip audio, string meta)
	{
	}

	[CalledBy(Type = typeof(MultipleChoiceNode), Member = "OnOptionSelected")]
	[CalledBy(Type = typeof(MultipleChoiceNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(StatementNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnOptionSelected")]
	[CalledBy(Type = typeof(SayRandom), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Say), Member = "OnExecute")]
	[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(ParlayNPCResponseNode), Member = "OnExecute")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 8)]
	public IStatement BlackboardReplace(IBlackboard bb)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 98)]
	public override string ToString()
	{
		return null;
	}
}
