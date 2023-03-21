using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class GetInputAxis : ActionTask
{
	public BBParameter<string> xAxisName;

	public BBParameter<string> yAxisName;

	public BBParameter<string> zAxisName;

	public BBParameter<float> multiplier;

	public BBParameter<Vector3> saveAs;

	public BBParameter<float> saveXAs;

	public BBParameter<float> saveYAs;

	public BBParameter<float> saveZAs;

	public bool repeat;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetInputAxis), Member = "Do")]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetInputAxis), Member = "Do")]
	protected override void OnUpdate()
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(GetInputAxis), Member = "OnUpdate")]
	[CalledBy(Type = typeof(GetInputAxis), Member = "OnExecute")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	private void Do()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public GetInputAxis()
	{
	}
}
