using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetFpHands : ActionTask
{
	public BBParameter<HandState> hands;

	protected override string info
	{
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetHandMeshState")]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(PlayerAnimation), Member = "SetHandMeshState")]
	private void DoWork()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_SetFpHands()
	{
	}
}
