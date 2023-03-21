using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LagRotation : MonoBehaviour
{
	public float speed;

	public bool ignoreTimeScale;

	private Transform mTrans;

	private Quaternion mRelative;

	private Quaternion mAbsolute;

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void OnRepositionEnd()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(LagRotation), Member = "Update")]
	private void Interpolate(float delta)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Start()
	{
	}

	[Calls(Type = typeof(LagRotation), Member = "Interpolate")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public LagRotation()
	{
	}
}
