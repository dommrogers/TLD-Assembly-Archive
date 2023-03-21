using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using Unity.VisualScripting;
using UnityEngine;

namespace TLD.Interactions;

public class TargetInteractionEventNode : InteractionEventNode
{
	private ValueInput _003Ctarget_003Ek__BackingField;

	public ValueInput target
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 10)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ValueInput), Member = "SetDefaultValue")]
	[Calls(Type = typeof(ValueInput), Member = "NullMeansSelf")]
	[CallsUnknownMethods(Count = 4)]
	protected override void Definition()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	protected override bool ShouldTrigger(Flow flow, InteractionEventData eventData)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unit), Member = ".ctor")]
	public TargetInteractionEventNode()
	{
	}
}
