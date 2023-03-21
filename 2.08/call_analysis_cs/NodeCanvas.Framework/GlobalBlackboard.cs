using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework.Internal;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

namespace NodeCanvas.Framework;

public class GlobalBlackboard : Blackboard
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public string name;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Blackboard), Member = "get_name")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CFind_003Eb__0(GlobalBlackboard b)
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Calls(Type = typeof(Blackboard), Member = "get_name")]
		internal bool _003CFind_003Eb__1(GlobalBlackboard b)
		{
			return default(bool);
		}

		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Blackboard), Member = "get_name")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CFind_003Eb__2(GlobalBlackboard b)
		{
			return default(bool);
		}
	}

	public static List<GlobalBlackboard> allGlobals;

	public bool dontDestroy;

	public new string name
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Blackboard), Member = "get_name")]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(Action_InvokeConcurrentGraph), Member = "OnExecute")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(GlobalBlackboard), Member = "IsUnique")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CalledBy(Type = typeof(GlobalBlackboard), Member = "Create")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[Calls(Type = typeof(Blackboard), Member = "get_name")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(GlobalBlackboard), Member = "set_name")]
	[CallsUnknownMethods(Count = 1)]
	public static GlobalBlackboard Create()
	{
		return null;
	}

	[CalledBy(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Statement._003C_003Ec__DisplayClass21_0), Member = "<BlackboardReplace>b__0")]
	[CalledBy(Type = typeof(BBParameter<>), Member = "CheckForPromotedVariable")]
	[CalledBy(Type = typeof(BBParameter), Member = "ResolveReference")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CalledBy(Type = typeof(GameManager), Member = "SetupTransferData")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(GameManager), Member = "ApplyTransferData")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	public static GlobalBlackboard Find(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(BlackboardSource), Member = "InitializePropertiesBinding")]
	[Calls(Type = typeof(GlobalBlackboard), Member = "IsUnique")]
	[Calls(Type = typeof(Blackboard), Member = "get_name")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DontDestroyOnLoad")]
	[Calls(Type = typeof(GlobalBlackboard), Member = "IsUnique")]
	[Calls(Type = typeof(Blackboard), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Format")]
	protected override void Awake()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(GlobalBlackboard), Member = "set_name")]
	[CalledBy(Type = typeof(GlobalBlackboard), Member = "Awake")]
	[CalledBy(Type = typeof(GlobalBlackboard), Member = "Awake")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsUnique()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlackboardSource), Member = ".ctor")]
	public GlobalBlackboard()
	{
	}
}
