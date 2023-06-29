using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_OverridePosBeforeInteriorLoad : ActionTask<GraphOwner>
{
	public Vector3 overridePos;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public Action_OverridePosBeforeInteriorLoad()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
