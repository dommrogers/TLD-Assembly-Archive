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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetInputAxis), Member = "Do")]
	[DeduplicatedMethod]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(GetInputAxis), Member = "Do")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected override void OnUpdate()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(GetInputAxis), Member = "OnUpdate")]
	[CalledBy(Type = typeof(GetInputAxis), Member = "OnExecute")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	private void Do()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public GetInputAxis()
	{
	}
}
