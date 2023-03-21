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

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void OnRepositionEnd()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(LagPosition), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	private void Interpolate(float delta)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(LagPosition), Member = "ResetPosition")]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void Start()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(LagPosition), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 3)]
	public void ResetPosition()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LagPosition), Member = "Interpolate")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public LagPosition()
	{
	}
}
