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

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(LagPosition), Member = "Update")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private void Interpolate(float delta)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
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
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(LagPosition), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 3)]
	public void ResetPosition()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(LagPosition), Member = "Interpolate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public LagPosition()
	{
	}
}
