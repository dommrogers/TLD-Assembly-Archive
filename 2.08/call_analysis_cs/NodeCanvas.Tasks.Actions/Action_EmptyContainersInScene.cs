using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_EmptyContainersInScene : ActionTask<GraphOwner>
{
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Container), Member = "DestroyAllGear")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public Action_EmptyContainersInScene()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
