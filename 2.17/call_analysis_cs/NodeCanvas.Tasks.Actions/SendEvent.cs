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
		[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 21)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(Graph), Member = "SendGlobalEvent")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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
		[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 17)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(Graph), Member = "SendGlobalEvent")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
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
