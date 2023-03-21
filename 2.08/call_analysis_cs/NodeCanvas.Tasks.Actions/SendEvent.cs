using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class SendEvent : ActionTask<GraphOwner>
{
	public BBParameter<string> eventName;

	public BBParameter<float> delay;

	public bool sendGlobal;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 22)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Graph), Member = "SendGlobalEvent")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public SendEvent()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
public class SendEvent<T> : ActionTask<GraphOwner>
{
	public BBParameter<string> eventName;

	public BBParameter<T> eventValue;

	public BBParameter<float> delay;

	public bool sendGlobal;

	protected override string info
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsUnknownMethods(Count = 18)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Graph), Member = "SendGlobalEvent")]
	[DeduplicatedMethod]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SendEvent()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
