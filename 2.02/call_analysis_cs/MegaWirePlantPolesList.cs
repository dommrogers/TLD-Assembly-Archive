using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MegaWirePlantPolesList : MonoBehaviour
{
	[Serializable]
	public class MegaWireSection
	{
		public Vector3 p;

		public Vector3 p1;

		public float length;

		public float seglength;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public MegaWireSection()
		{
		}
	}

	public List<Vector3> waypoints;

	public bool closed;

	public int curve;

	public float start;

	public float length;

	public float spacing;

	public bool update;

	public GameObject pole;

	public Vector3 rotate;

	public float offset;

	public bool conform;

	public float upright;

	public bool addwires;

	public List<GameObject> poles;

	public MegaWire copyfrom;

	public Material material;

	public Vector3 positionVariation;

	public Vector3 rotateVariation;

	public Vector3 scaleVariation;

	public float spacingVariation;

	public bool reverseWire;

	public int seed;

	public float wireSizeMult;

	public float stretch;

	public bool showgizmo;

	public bool showgizmoparams;

	public MegaWireGizmoType gizmoType;

	public float arrowwidth;

	public float arrowlength;

	public float vertStart;

	public float vertLength;

	public float arrowoff;

	public float dashdist;

	public Color arrowCol;

	public Color lineCol;

	public Color otherCol;

	public Color dashCol;

	public MegaWireUnits units;

	public float unitsScale;

	private List<MegaWireSection> knots;

	private float pathlength;

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(MegaWirePlantPolesList), Member = "InterpCurve3D")]
	[CalledBy(Type = typeof(MegaWirePlantPolesList), Member = "InterpCurve3D")]
	[CalledBy(Type = typeof(MegaWirePlantPolesList), Member = "InterpCurve3D")]
	[CalledBy(Type = typeof(MegaWirePlantPolesList), Member = "InterpCurve3D")]
	[CalledBy(Type = typeof(MegaWirePlantPolesList), Member = "InterpCurve3D")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public Vector3 Interpolate(float alpha)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CalledBy(Type = typeof(MegaWirePlantPolesList), Member = "Rebuild")]
	[CalledBy(Type = typeof(MegaWirePlantPolesList), Member = "Rebuild")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Repeat")]
	[Calls(Type = typeof(MegaWirePlantPolesList), Member = "Interpolate")]
	[Calls(Type = typeof(MegaWirePlantPolesList), Member = "Interpolate")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MegaWirePlantPolesList), Member = "Interpolate")]
	[Calls(Type = typeof(MegaWirePlantPolesList), Member = "Interpolate")]
	[Calls(Type = typeof(MegaWirePlantPolesList), Member = "Interpolate")]
	public Vector3 InterpCurve3D(float alpha)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(MegaWirePlantPolesList), Member = "Rebuild")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private float CalcLength()
	{
		return default(float);
	}

	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(MegaWire), Member = "Create")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Quaternion), Member = "FromToRotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MegaWireWatch), Member = "Update")]
	[CallsUnknownMethods(Count = 36)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(MegaWirePlantPolesList), Member = "CalcLength")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "InitState")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(MegaWirePlantPolesList), Member = "InterpCurve3D")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Physics), Member = "RaycastAll")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(MegaWirePlantPolesList), Member = "InterpCurve3D")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	public void Rebuild()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsUnknownMethods(Count = 26)]
	public MegaWirePlantPolesList()
	{
	}
}
