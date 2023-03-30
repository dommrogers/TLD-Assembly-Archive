using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public class TriggerZone : MonoBehaviour
{
	private enum TriggerZoneUpdateRate
	{
		OnEnable,
		OnOcclusionChange
	}

	public bool setIsTrigger;

	public float rangeMultiplier;

	private const int kMeshColliderNumSides = 8;

	private VolumetricLightBeam m_Beam;

	private DynamicOcclusionRaycasting m_DynamicOcclusionRaycasting;

	private PolygonCollider2D m_PolygonCollider2D;

	private TriggerZoneUpdateRate updateRate
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(TriggerZoneUpdateRate);
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(TriggerZone), Member = "ComputeZone")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TriggerZone), Member = "ComputeZone")]
	private void OnOcclusionProcessed()
	{
	}

	[CalledBy(Type = typeof(TriggerZone), Member = "OnEnable")]
	[CalledBy(Type = typeof(TriggerZone), Member = "OnOcclusionProcessed")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetOrAddComponent")]
	[Calls(Type = typeof(PolygonHelper.Plane2D), Member = "CutConvex")]
	[Calls(Type = typeof(Collider2D), Member = "set_isTrigger")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(MeshGenerator), Member = "GenerateConeZ_Radius")]
	[Calls(Type = typeof(Consts), Member = "get_ProceduralObjectsHideFlags")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(MeshCollider), Member = "set_sharedMesh")]
	[Calls(Type = typeof(MeshCollider), Member = "set_convex")]
	[Calls(Type = typeof(Collider), Member = "set_isTrigger")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	private void ComputeZone()
	{
	}

	[CallerCount(Count = 0)]
	public TriggerZone()
	{
	}
}
