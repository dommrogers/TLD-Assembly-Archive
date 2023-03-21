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

	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(GetInputAxis), Member = "OnUpdate")]
	[CalledBy(Type = typeof(GetInputAxis), Member = "OnExecute")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	private void Do()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public GetInputAxis()
	{
	}
}
