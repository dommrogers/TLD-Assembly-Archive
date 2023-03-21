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

	[CalledBy(Type = typeof(GetInputAxis), Member = "OnExecute")]
	[CalledBy(Type = typeof(GetInputAxis), Member = "OnUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 18)]
	private void Do()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	public GetInputAxis()
	{
	}
}
