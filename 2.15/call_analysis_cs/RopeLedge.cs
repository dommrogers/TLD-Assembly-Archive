using Cpp2ILInjected.CallAnalysis;
using SuperSplines;
using UnityEngine;

public class RopeLedge : MonoBehaviour
{
	public Rope m_Rope;

	public Transform m_DismountPoint;

	public RopeExitPoint m_LedgeAccess;

	public RopeClimbPoint m_RopeAccess;

	public float m_LedgeAccessOffsetFromRope;

	public float m_LedgeAccessForwardOffset;

	public float m_LedgeAccessLiftUp;

	public float m_DismountPointOffsetFromRope;

	public float m_DismountPointForwardOffset;

	public float m_DismountPointYaw;

	public float m_DismountPointPitch;

	private bool m_IsLeftSide;

	private Vector3 m_Forward;

	private Vector3 m_FromRope;

	private float m_ClosestRopeT;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Spline), Member = "GetClosestPointParam")]
	[Calls(Type = typeof(Spline), Member = "GetPositionOnSpline")]
	[Calls(Type = typeof(Spline), Member = "GetTangentToSpline")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 25)]
	[CallsUnknownMethods(Count = 18)]
	private void Start()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(RopeAnchorPoint), Member = "SetRopeActiveState")]
	[CallerCount(Count = 1)]
	public void SetActiveInitial(bool state)
	{
	}

	[CalledBy(Type = typeof(PlayerClimbRope), Member = "OnRopeTransition")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void OnRopeTransition(bool playerOnRope)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public RopeLedge()
	{
	}
}
