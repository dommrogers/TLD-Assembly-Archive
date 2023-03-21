using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LagPosition : MonoBehaviour
{
	public Vector3 speed;

	public bool ignoreTimeScale;

	private Transform mTrans;

	private Vector3 mRelative;

	private Vector3 mAbsolute;

	private bool mStarted;

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void OnRepositionEnd()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(LagPosition), Member = "Update")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void Interpolate(float delta)
	{
	}

	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LagPosition), Member = "ResetPosition")]
	private void OnEnable()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(LagPosition), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public void ResetPosition()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(LagPosition), Member = "Interpolate")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public LagPosition()
	{
	}
}
