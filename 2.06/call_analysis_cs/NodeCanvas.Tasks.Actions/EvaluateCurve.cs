using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class EvaluateCurve : ActionTask
{
	public BBParameter<AnimationCurve> curve;

	public BBParameter<float> from;

	public BBParameter<float> to;

	public BBParameter<float> time;

	public BBParameter<float> saveAs;

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(ActionTask), Member = "get_elapsedTime")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public EvaluateCurve()
	{
	}
}
