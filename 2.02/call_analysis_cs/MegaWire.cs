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

	[CalledBy(Type = typeof(MegaWire), Member = "Create")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MegaWireConnectionDef), Member = ".ctor")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 29)]
	public void Copy(MegaWire from, MegaWireConnectionHelper helper)
	{
	}

	[CalledBy(Type = typeof(MegaWire), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(MegaWire), Member = "Create")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	public void Create()
	{
	}

	[CalledBy(Type = typeof(MegaWire), Member = "Create")]
	[CalledBy(Type = typeof(MegaWirePlantPolesList), Member = "Rebuild")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Mesh), Member = ".ctor")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh")]
	[Calls(Type = typeof(MeshFilter), Member = "get_sharedMesh")]
	[Calls(Type = typeof(MegaWireSpan), Member = "Init")]
	[Calls(Type = typeof(MegaWire), Member = "Copy")]
	[Calls(Type = typeof(MegaWire), Member = "Init")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 63)]
	public static MegaWire Create(MegaWire wire, List<GameObject> objs, Material mat, string name, MegaWire copyfrom, float wiresize, float str)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public void ChangeStretch(float stretch)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public int GetVertexCount()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_hideFlags")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public void SetHidden(bool hide)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void SetSelection(List<GameObject> objs, bool add)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public void UpdateOffsets()
	{
	}

	[CalledBy(Type = typeof(MegaWire), Member = "Create")]
	[CalledBy(Type = typeof(MegaWire), Member = "RebuildWire")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(MegaWireConnection), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(MegaWireConnection), Member = "Init")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	public void Init()
	{
	}

	[CalledBy(Type = typeof(MegaWire), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MegaWireSpan), Member = "UpdateSpan")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 79)]
	private void WireUpdate(float t)
	{
	}

	[CalledBy(Type = typeof(MegaWire), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MegaWire), Member = "RebuildWire")]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix")]
	[Calls(Type = typeof(MegaWireSpan), Member = "UpdateSpan")]
	[Calls(Type = typeof(MegaWireSpan), Member = "MoveMasses")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 29)]
	public void RunPhysics(float t)
	{
	}

	[CalledBy(Type = typeof(MegaWireHanger), Member = "LateUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	public Vector3 SetWeight(float alpha, int strand, float weight, bool snap)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	public Vector3 GetPos(float alpha, int strand, bool snap)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MegaWire), Member = "Create")]
	[Calls(Type = typeof(MegaWire), Member = "RunPhysics")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public void SetWireVisible(bool show)
	{
	}

	[CalledBy(Type = typeof(MegaWire), Member = "RunPhysics")]
	[CalledBy(Type = typeof(MegaWire), Member = "LateUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MegaWire), Member = "Init")]
	[Calls(Type = typeof(MegaWireSpan), Member = "MoveMasses")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void RebuildWire()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Matrix4x4), Member = "get_identity")]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix")]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Inequality")]
	[Calls(Type = typeof(MegaWire), Member = "RebuildWire")]
	[Calls(Type = typeof(MegaWire), Member = "WireUpdate")]
	[Calls(Type = typeof(MegaWireSpan), Member = "MoveMasses")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 30)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 42)]
	public MegaWire()
	{
	}
}
