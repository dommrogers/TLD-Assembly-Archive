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

	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "DrawRay")]
	[Calls(Type = typeof(Debug), Member = "DrawRay")]
	[Calls(Type = typeof(Debug), Member = "DrawRay")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Debug), Member = "DrawRay")]
	[CallsUnknownMethods(Count = 27)]
	[CallsDeduplicatedMethods(Count = 23)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public JiggleBone()
	{
	}
}
