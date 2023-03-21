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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 11)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public CheatTowardsCamera()
	{
	}
}
