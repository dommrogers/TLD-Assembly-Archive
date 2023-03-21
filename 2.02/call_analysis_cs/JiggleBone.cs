using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class JiggleBone : MonoBehaviour
{
	public bool debugMode;

	private Vector3 dynamicPos;

	public Vector3 boneAxis;

	public float targetDistance;

	public float bStiffness;

	public float bMass;

	public float bDamping;

	public float bGravity;

	private Vector3 force;

	private Vector3 acc;

	private Vector3 vel;

	public bool SquashAndStretch;

	public float sideStretch;

	public float frontStretch;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Debug), Member = "DrawRay")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallsUnknownMethods(Count = 27)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public JiggleBone()
	{
	}
}
