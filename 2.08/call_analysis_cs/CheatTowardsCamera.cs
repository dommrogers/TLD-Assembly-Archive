using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CheatTowardsCamera : MonoBehaviour
{
	public float m_CheatDistance;

	private float m_DisplacementSpeed;

	private Vector3 m_LastPosition;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CheatTowardsCamera()
	{
	}
}
