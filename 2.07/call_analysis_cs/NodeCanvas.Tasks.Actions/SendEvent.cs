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
		[CallsUnknownMethods(Count = 22)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(Graph), Member = "SendGlobalEvent")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 3)]
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
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 18)]
		[Calls(Type = typeof(string), Member = "Format")]
		[DeduplicatedMethod]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Graph), Member = "SendGlobalEvent")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
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
