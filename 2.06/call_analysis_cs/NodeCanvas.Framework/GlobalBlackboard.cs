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

		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Blackboard), Member = "get_name")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal bool _003CFind_003Eb__0(GlobalBlackboard b)
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Blackboard), Member = "get_name")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CFind_003Eb__1(GlobalBlackboard b)
		{
			return default(bool);
		}

		[Calls(Type = typeof(Blackboard), Member = "get_name")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
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
		[Calls(Type = typeof(Blackboard), Member = "get_name")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Blackboard), Member = "get_name")]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(GlobalBlackboard), Member = "IsUnique")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CalledBy(Type = typeof(GlobalBlackboard), Member = "Create")]
		[CalledBy(Type = typeof(Action_InvokeConcurrentGraph), Member = "OnExecute")]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(GlobalBlackboard), Member = "set_name")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static GlobalBlackboard Create()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(Statement._003C_003Ec__DisplayClass21_0), Member = "<BlackboardReplace>b__0")]
	[CalledBy(Type = typeof(BBParameter<>), Member = "CheckForPromotedVariable")]
	[CalledBy(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[CalledBy(Type = typeof(GameManager), Member = "ApplyTransferData")]
	[CalledBy(Type = typeof(BBParameter), Member = "ResolveReference")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(GameManager), Member = "SetupTransferData")]
	public static GlobalBlackboard Find(string name)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "DontDestroyOnLoad")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Blackboard), Member = "get_name")]
	[Calls(Type = typeof(GlobalBlackboard), Member = "IsUnique")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Blackboard), Member = "get_name")]
	[Calls(Type = typeof(GlobalBlackboard), Member = "IsUnique")]
	[Calls(Type = typeof(BlackboardSource), Member = "InitializePropertiesBinding")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	protected override void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(GlobalBlackboard), Member = "Awake")]
	[CalledBy(Type = typeof(GlobalBlackboard), Member = "set_name")]
	[CalledBy(Type = typeof(GlobalBlackboard), Member = "Awake")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private bool IsUnique()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlackboardSource), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	public GlobalBlackboard()
	{
	}
}
