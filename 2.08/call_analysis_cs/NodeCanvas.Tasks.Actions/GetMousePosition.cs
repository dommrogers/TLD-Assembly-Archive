using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class GetMousePosition : ActionTask
{
	public BBParameter<Vector3> saveAs;

	public bool repeat;

	[Calls(Type = typeof(GetMousePosition), Member = "Do")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetMousePosition), Member = "Do")]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CalledBy(Type = typeof(GetMousePosition), Member = "OnExecute")]
	[CalledBy(Type = typeof(GetMousePosition), Member = "OnUpdate")]
	[CallsUnknownMethods(Count = 3)]
	private void Do()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public GetMousePosition()
	{
	}
}
