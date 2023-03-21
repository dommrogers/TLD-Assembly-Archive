using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CameraPathDelay : CameraPathPoint
{
	public float time;

	public float introStartEasePercentage;

	public AnimationCurve introCurve;

	public float outroEndEasePercentage;

	public AnimationCurve outroCurve;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AnimationCurve), Member = "Linear")]
	[Calls(Type = typeof(CameraPathPoint), Member = ".ctor")]
	public CameraPathDelay()
	{
	}
}
