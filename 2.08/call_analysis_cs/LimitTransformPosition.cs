using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LimitTransformPosition : MonoBehaviour
{
	public Vector2 m_LimitsX;

	public Vector2 m_LimitsY;

	public Vector2 m_LimitsZ;

	private Transform m_Transform;

	private Vector3 m_TransformPosCache;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	private void LateUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LimitTransformPosition()
	{
	}
}
