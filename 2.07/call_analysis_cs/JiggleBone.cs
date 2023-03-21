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
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(Debug), Member = "DrawRay")]
	[Calls(Type = typeof(Debug), Member = "DrawRay")]
	[Calls(Type = typeof(Debug), Member = "DrawRay")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "DrawRay")]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public JiggleBone()
	{
	}
}
