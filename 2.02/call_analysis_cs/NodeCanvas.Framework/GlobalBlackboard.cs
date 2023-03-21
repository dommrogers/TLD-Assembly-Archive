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
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[Calls(Type = typeof(Blackboard), Member = "get_name")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal bool _003CFind_003Eb__0(GlobalBlackboard b)
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Blackboard), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CFind_003Eb__1(GlobalBlackboard b)
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Blackboard), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
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
		[Calls(Type = typeof(GlobalBlackboard), Member = "IsUnique")]
		[CallsUnknownMethods(Count = 4)]
		[CalledBy(Type = typeof(Action_InvokeConcurrentGraph), Member = "OnExecute")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CalledBy(Type = typeof(GlobalBlackboard), Member = "Create")]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[Calls(Type = typeof(Blackboard), Member = "get_name")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "get_name")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(GlobalBlackboard), Member = "set_name")]
	[CallsUnknownMethods(Count = 9)]
	public static GlobalBlackboard Create()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 33)]
	[CalledBy(Type = typeof(Statement._003C_003Ec__DisplayClass21_0), Member = "<BlackboardReplace>b__0")]
	[CalledBy(Type = typeof(BBParameter<>), Member = "CheckForPromotedVariable")]
	[CalledBy(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[CalledBy(Type = typeof(BBParameter), Member = "ResolveReference")]
	[CalledBy(Type = typeof(GameManager), Member = "ApplyTransferData")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(GameManager), Member = "SetupTransferData")]
	public static GlobalBlackboard Find(string name)
	{
		return null;
	}

	[Calls(Type = typeof(Object), Member = "DontDestroyOnLoad")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Blackboard), Member = "get_name")]
	[Calls(Type = typeof(GlobalBlackboard), Member = "IsUnique")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(GlobalBlackboard), Member = "IsUnique")]
	[Calls(Type = typeof(Blackboard), Member = "get_name")]
	[Calls(Type = typeof(BlackboardSource), Member = "InitializePropertiesBinding")]
	protected override void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(GlobalBlackboard), Member = "Awake")]
	[CalledBy(Type = typeof(GlobalBlackboard), Member = "set_name")]
	[CalledBy(Type = typeof(GlobalBlackboard), Member = "Awake")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallerCount(Count = 3)]
	private bool IsUnique()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Blackboard), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public GlobalBlackboard()
	{
	}
}
