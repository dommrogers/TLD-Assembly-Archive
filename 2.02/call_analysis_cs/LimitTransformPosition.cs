using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LimitTransformPosition : MonoBehaviour
{
	public Vector2 m_LimitsX;

	public Vector2 m_LimitsY;

	public Vector2 m_LimitsZ;

	private Transform m_Transform;

	private Vector3 m_TransformPosCache;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 16)]
	private void LateUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LimitTransformPosition()
	{
	}
}
