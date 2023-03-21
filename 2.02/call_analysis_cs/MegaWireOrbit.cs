using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MegaWireOrbit : MonoBehaviour
{
	public GameObject target;

	private MeshRenderer render;

	private SkinnedMeshRenderer srender;

	private MeshFilter filter;

	public float distance;

	public float xSpeed;

	public float ySpeed;

	public float zSpeed;

	public float yMinLimit;

	public float yMaxLimit;

	public float xMinLimit;

	public float xMaxLimit;

	public float x;

	public float y;

	private Vector3 center;

	public bool Dynamic;

	public Vector3 offset;

	public Vector3 EditTest;

	private Vector3 tpos;

	private float t;

	public float trantime;

	public float vx;

	public float vy;

	public float vz;

	public float nx;

	public float ny;

	public float nz;

	public float delay;

	public float delayz;

	public float mindist;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MegaWireOrbit), Member = "NewTarget")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 13)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float easeInOutQuint(float start, float end, float value)
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private float easeInQuad(float start, float end, float value)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(MegaWireOrbit), Member = "LateUpdate")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private float easeInSine(float start, float end, float value)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(MegaWireOrbit), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(MeshFilter), Member = "get_sharedMesh")]
	[Calls(Type = typeof(Mesh), Member = "get_bounds")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public void NewTarget(GameObject targ)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(MeshFilter), Member = "get_mesh")]
	[Calls(Type = typeof(Mesh), Member = "get_bounds")]
	[Calls(Type = typeof(MegaWireOrbit), Member = "easeInSine")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 32)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static float ClampAngle(float angle, float min, float max)
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void OnGUI()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MegaWireOrbit()
	{
	}
}
