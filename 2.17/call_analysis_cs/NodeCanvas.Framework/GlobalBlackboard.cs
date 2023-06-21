using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected.CallAnalysis;
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
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CFind_003Eb__0(GlobalBlackboard b)
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Blackboard), Member = "get_name")]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CFind_003Eb__1(GlobalBlackboard b)
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Blackboard), Member = "get_name")]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CFind_003Eb__2(GlobalBlackboard b)
		{
			return false;
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
		[CalledBy(Type = typeof(GlobalBlackboard), Member = "Create")]
		[CalledBy(Type = typeof(Action_InvokeConcurrentGraph), Member = "OnExecute")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Blackboard), Member = "get_name")]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
		[Calls(Type = typeof(Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(GlobalBlackboard), Member = "IsUnique")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(GlobalBlackboard), Member = "set_name")]
	[CallsUnknownMethods(Count = 1)]
	public static GlobalBlackboard Create()
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "SetupTransferData")]
	[CalledBy(Type = typeof(GameManager), Member = "ApplyTransferData")]
	[CalledBy(Type = typeof(BBParameter), Member = "ResolveReference")]
	[CalledBy(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[CalledBy(Type = typeof(BBParameter<>), Member = "CheckForPromotedVariable")]
	[CalledBy(TypeFullName = "NodeCanvas.DialogueTrees.Statement.<>c__DisplayClass21_0", Member = "<BlackboardReplace>b__0")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(List<>), Member = "Find")]
	[Calls(Type = typeof(Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(Enumerable), Member = "Where")]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public static GlobalBlackboard Find(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlackboardSource), Member = "InitializePropertiesBinding")]
	[Calls(Type = typeof(GlobalBlackboard), Member = "IsUnique")]
	[Calls(Type = typeof(Blackboard), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "DontDestroyOnLoad")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	protected override void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(GlobalBlackboard), Member = "set_name")]
	[CalledBy(Type = typeof(GlobalBlackboard), Member = "Awake")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>), Member = "Find")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsUnique()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlackboardSource), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public GlobalBlackboard()
	{
	}
}
