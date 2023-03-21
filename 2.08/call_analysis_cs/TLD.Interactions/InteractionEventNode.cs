using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using Unity.VisualScripting;

namespace TLD.Interactions;

public class InteractionEventNode : EventUnit<InteractionEventData>
{
	public const string EVENT_NAME = "InteractionEvent";

	private ValueOutput _003Cinteraction_003Ek__BackingField;

	private ValueOutput _003CinteractionObject_003Ek__BackingField;

	protected override bool register
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	public ValueOutput interaction
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private set
		{
		}
	}

	public ValueOutput interactionObject
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 7)]
		private set
		{
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Unit), Member = "ControlOutput")]
	[CalledBy(Type = typeof(TargetInteractionEventNode), Member = "Definition")]
	[CallsUnknownMethods(Count = 3)]
	protected override void Definition()
	{
	}

	[Calls(Type = typeof(EventHook), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public override EventHook GetHook(GraphReference reference)
	{
		return default(EventHook);
	}

	[Calls(Type = typeof(Flow), Member = "SetValue")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Flow), Member = "SetValue")]
	protected override void AssignArguments(Flow flow, InteractionEventData eventData)
	{
	}

	[Calls(Type = typeof(Unit), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public InteractionEventNode()
	{
		((EventUnit<TArgs>)(object)this)._002Ector();
	}
}
