using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public class ConditionList : ConditionTask, ISubTasksContainer
{
	public enum ConditionsCheckMode
	{
		AllTrueRequired,
		AnyTrueSuffice
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ConditionTask, bool> _003C_003E9__10_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003COnInit_003Eb__10_0(ConditionTask c)
		{
			return default(bool);
		}
	}

	public ConditionsCheckMode checkMode;

	public List<ConditionTask> conditions;

	private List<ConditionTask> initialActiveConditions;

	private bool allTrueRequired
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	protected override string info
	{
		[CallsUnknownMethods(Count = 7)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Task), Member = "get_summaryInfo")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private Task[] NodeCanvas_002EFramework_002EISubTasksContainer_002EGetSubTasks()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Task), Member = "Duplicate")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ConditionList), Member = "AddCondition")]
	[CallsUnknownMethods(Count = 7)]
	public override Task Duplicate(ITaskSystem newOwnerSystem)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	protected override string OnInit()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(Task), Member = "Set")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 3)]
	public override void OnDrawGizmos()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 3)]
	public override void OnDrawGizmosSelected()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ConditionList), Member = "AddCondition")]
	[CalledBy(Type = typeof(ConditionList), Member = "Duplicate")]
	[Calls(Type = typeof(ConditionList), Member = "AddCondition")]
	[Calls(Type = typeof(Task), Member = "SetOwnerSystem")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public void AddCondition(ConditionTask condition)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public ConditionList()
	{
	}
}
