using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class SendMessage : ActionTask<Transform>
{
	public BBParameter<string> methodName;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public SendMessage()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
public class SendMessage<T> : ActionTask<Transform>
{
	public BBParameter<string> methodName;

	public BBParameter<T> argument;

	protected override string info
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SendMessage()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
