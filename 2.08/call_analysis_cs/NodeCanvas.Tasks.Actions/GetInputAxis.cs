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

	[Calls(Type = typeof(GetInputAxis), Member = "Do")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CalledBy(Type = typeof(GetInputAxis), Member = "OnExecute")]
	[CalledBy(Type = typeof(GetInputAxis), Member = "OnUpdate")]
	[CallsUnknownMethods(Count = 18)]
	private void Do()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public GetInputAxis()
	{
	}
}
