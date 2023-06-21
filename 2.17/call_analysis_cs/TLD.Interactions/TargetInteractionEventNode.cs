using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using Unity.VisualScripting;

namespace TLD.Interactions;

public class TargetInteractionEventNode : InteractionEventNode
{
	private ValueInput _003Ctarget_003Ek__BackingField;

	public ValueInput target
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueInput), Member = "SetDefaultValue")]
	[Calls(Type = typeof(ComponentHolderProtocol), Member = "IsComponentHolderType")]
	[Calls(Type = typeof(InteractionEventNode), Member = "Definition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void Definition()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Flow), Member = "GetValue")]
	[CallsUnknownMethods(Count = 1)]
	protected override bool ShouldTrigger(Flow flow, InteractionEventData eventData)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unit), Member = ".ctor")]
	public TargetInteractionEventNode()
	{
	}
}
