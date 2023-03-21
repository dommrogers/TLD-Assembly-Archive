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

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(LagRotation), Member = "Update")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 6)]
	private void Interpolate(float delta)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(LagRotation), Member = "Interpolate")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LagRotation()
	{
	}
}
