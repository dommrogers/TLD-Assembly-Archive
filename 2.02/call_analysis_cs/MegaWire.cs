using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MegaWire : MonoBehaviour
{
	public bool Rebuild;

	public float fudge;

	public MegaWireStrandedMesher strandedMesher;

	public float spring;

	public float damp;

	public float timeStep;

	public float Mass;

	public Vector3 gravity;

	public float airdrag;

	public float massRand;

	public bool doCollisions;

	public bool useraycast;

	public LayerMask collisionmask;

	public float collisionoff;

	public float collisiondist;

	public float floor;

	public int points;

	public int iters;

	public int frameWait;

	public int frameNum;

	public bool stiffnessSprings;

	public float stiffrate;

	public float stiffdamp;

	public bool lengthConstraints;

	private Matrix4x4 wtm;

	public MegaWireSolver verletsolver;

	public bool showphysics;

	public bool showconnections;

	public bool showmeshparams;

	public List<MegaWireConnectionDef> connections;

	public List<MegaWireSpan> spans;

	public static Vector3 windDir;

	public static float windFrc;

	public float windEffect;

	public MegaWireWind wind;

	public Material material;

	public bool uselod;

	public float disableDist;

	public bool disableOnNotVisible;

	public float lodreducesides;

	public float lodreducesegs;

	public GameObject startObj;

	public float startAlpha;

	public Vector3 startRot;

	public Vector3 startOffset;

	public GameObject endObj;

	public float endAlpha;

	public Vector3 endRot;

	public Vector3 endOffset;

	public List<MegaWireLodLevel> lods;

	public bool hidespans;

	public bool disableOnDistance;

	public float distfromcamera;

	public float rbodyforce;

	public bool Enabled;

	public bool ShowWire;

	public float awakeTime;

	public bool displayGizmo;

	public Color gizmoColor;

	public List<Transform> poles;

	public float stretch;

	public float warmPhysicsTime;

	public bool builduvs;

	public static bool DisableAll;

	public float startTime;

	public bool showWindParams;

	public bool showPhysicsAdv;

	public bool showAttach;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MegaWireConnectionDef), Member = ".ctor")]
	[Calls(Type = typeof(MegaWireConnectionDef), Member = ".ctor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MegaWire), Member = "Create")]
	[CallsUnknownMethods(Count = 29)]
	public void Copy(MegaWire from, MegaWireConnectionHelper helper)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MegaWire), Member = "Start")]
	[Calls(Type = typeof(MegaWire), Member = "Create")]
	[CallsUnknownMethods(Count = 15)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void Create()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(MegaWireSpan), Member = "Init")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MegaWire), Member = "Copy")]
	[Calls(Type = typeof(MegaWire), Member = "Init")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MegaWire), Member = "Create")]
	[CalledBy(Type = typeof(MegaWirePlantPolesList), Member = "Rebuild")]
	[Calls(Type = typeof(MeshFilter), Member = "get_sharedMesh")]
	[CallsUnknownMethods(Count = 63)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Mesh), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 19)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	public static MegaWire Create(MegaWire wire, List<GameObject> objs, Material mat, string name, MegaWire copyfrom, float wiresize, float str)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void ChangeStretch(float stretch)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	public int GetVertexCount()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 7)]
	public void SetHidden(bool hide)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void SetSelection(List<GameObject> objs, bool add)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void UpdateOffsets()
	{
	}

	[CalledBy(Type = typeof(MegaWire), Member = "RebuildWire")]
	[CalledBy(Type = typeof(MegaWire), Member = "Create")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(MegaWireConnection), Member = "Init")]
	[Calls(Type = typeof(MegaWireConnection), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void Init()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MegaWire), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 79)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MegaWireSpan), Member = "UpdateSpan")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void WireUpdate(float t)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 29)]
	[CalledBy(Type = typeof(MegaWire), Member = "Start")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MegaWireSpan), Member = "MoveMasses")]
	[Calls(Type = typeof(MegaWireSpan), Member = "UpdateSpan")]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix")]
	[Calls(Type = typeof(MegaWire), Member = "RebuildWire")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	public void RunPhysics(float t)
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(MegaWireHanger), Member = "LateUpdate")]
	[CalledBy(Type = typeof(MegaWireHanger), Member = "LateUpdate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public Vector3 SetWeight(float alpha, int strand, float weight, bool snap)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 17)]
	public Vector3 GetPos(float alpha, int strand, bool snap)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(MegaWire), Member = "RunPhysics")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MegaWire), Member = "Create")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 6)]
	public void SetWireVisible(bool show)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(MegaWire), Member = "LateUpdate")]
	[CalledBy(Type = typeof(MegaWire), Member = "RunPhysics")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MegaWire), Member = "Init")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[Calls(Type = typeof(MegaWireSpan), Member = "MoveMasses")]
	public void RebuildWire()
	{
	}

	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MegaWireSpan), Member = "MoveMasses")]
	[Calls(Type = typeof(MegaWire), Member = "WireUpdate")]
	[Calls(Type = typeof(MegaWire), Member = "RebuildWire")]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Inequality")]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix")]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_identity")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private void LateUpdate()
	{
	}

	[CallsUnknownMethods(Count = 42)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public MegaWire()
	{
	}
}
