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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public ValueOutput interaction
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
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

	public ValueOutput interactionObject
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 18)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventUnit<>), Member = "Definition")]
	[Calls(Type = typeof(Unit), Member = "ValueOutput")]
	protected override void Definition()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventHook), Member = ".ctor")]
	public override EventHook GetHook(GraphReference reference)
	{
		return default(EventHook);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Flow), Member = "SetValue")]
	[CallsUnknownMethods(Count = 1)]
	protected override void AssignArguments(Flow flow, InteractionEventData eventData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unit), Member = ".ctor")]
	public InteractionEventNode()
	{
		((EventUnit<TArgs>)(object)this)._002Ector();
	}
}
