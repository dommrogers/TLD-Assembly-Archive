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
		[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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
		[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CalledBy(TypeFullName = "ParadoxNotion.Internal.AOTDummy.NodeCanvas_Tasks_Actions_SendMessage_Collision", Member = ".ctor")]
	[CalledBy(TypeFullName = "ParadoxNotion.Internal.AOTDummy.NodeCanvas_Tasks_Actions_SendMessage_Collision2D", Member = ".ctor")]
	[CalledBy(TypeFullName = "ParadoxNotion.Internal.AOTDummy.NodeCanvas_Tasks_Actions_SendMessage_Space", Member = ".ctor")]
	[CalledBy(TypeFullName = "ParadoxNotion.Internal.AOTDummy.NodeCanvas_Tasks_Actions_SendMessage_SpawnLocation", Member = ".ctor")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public SendMessage()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
