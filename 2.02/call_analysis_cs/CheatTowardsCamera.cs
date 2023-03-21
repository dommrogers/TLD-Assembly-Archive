using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CheatTowardsCamera : MonoBehaviour
{
	public float m_CheatDistance;

	private float m_DisplacementSpeed;

	private Vector3 m_LastPosition;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
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
