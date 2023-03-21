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

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MegaWireOrbit), Member = "NewTarget")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private float easeInOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private float easeInQuad(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(MegaWireOrbit), Member = "LateUpdate")]
	[CalledBy(Type = typeof(MegaWireOrbit), Member = "LateUpdate")]
	[CalledBy(Type = typeof(MegaWireOrbit), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 1)]
	private float easeInSine(float start, float end, float value)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(MegaWireOrbit), Member = "Start")]
	[Calls(Type = typeof(Mesh), Member = "get_bounds")]
	[Calls(Type = typeof(MeshFilter), Member = "get_sharedMesh")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	public void NewTarget(GameObject targ)
	{
	}

	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(MeshFilter), Member = "get_mesh")]
	[Calls(Type = typeof(Mesh), Member = "get_bounds")]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(MegaWireOrbit), Member = "easeInSine")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(MegaWireOrbit), Member = "easeInSine")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(MegaWireOrbit), Member = "easeInSine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Mathf), Member = "SmoothDamp")]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void OnGUI()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MegaWireOrbit()
	{
	}
}
