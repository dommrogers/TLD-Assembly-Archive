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
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 22)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(Graph), Member = "SendGlobalEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
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

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Graph), Member = "SendGlobalEvent")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	protected override void OnUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SendEvent()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
