using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CheatTowardsCamera : MonoBehaviour
{
	public float m_CheatDistance;

	private float m_DisplacementSpeed;

	private Vector3 m_LastPosition;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 18)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CheatTowardsCamera()
	{
	}
}
