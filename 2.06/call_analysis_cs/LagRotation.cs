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

	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(LagRotation), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void Interpolate(float delta)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LagRotation), Member = "Interpolate")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LagRotation()
	{
	}
}
