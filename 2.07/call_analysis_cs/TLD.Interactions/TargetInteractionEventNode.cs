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
		[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InteractionEventNode), Member = "Definition")]
	[Calls(Type = typeof(ComponentHolderProtocol), Member = "IsComponentHolderType")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueInput), Member = "SetDefaultValue")]
	protected override void Definition()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
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
