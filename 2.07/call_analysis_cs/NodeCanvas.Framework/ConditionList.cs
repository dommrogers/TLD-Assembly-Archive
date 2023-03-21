using System;
using System.Collections.Generic;
using System.Linq;
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
		[CallerCount(Count = 6)]
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
		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "get_summaryInfo")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private Task[] NodeCanvas_002EFramework_002EISubTasksContainer_002EGetSubTasks()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(ConditionList), Member = "AddCondition")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "Duplicate")]
	public override Task Duplicate(ITaskSystem newOwnerSystem)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsUnknownMethods(Count = 6)]
	protected override string OnInit()
	{
		return null;
	}

	[Calls(Type = typeof(Task), Member = "Set")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnDisable()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public override void OnDrawGizmos()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public override void OnDrawGizmosSelected()
	{
	}

	[CalledBy(Type = typeof(ConditionList), Member = "AddCondition")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Task), Member = "SetOwnerSystem")]
	[CalledBy(Type = typeof(ConditionList), Member = "Duplicate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ConditionList), Member = "AddCondition")]
	public void AddCondition(ConditionTask condition)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public ConditionList()
	{
	}
}
