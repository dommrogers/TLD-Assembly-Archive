using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase
{
	public class HitResult
	{
		public Vector3 point;

		public Vector3 normal;

		public float distance;

		private Collider2D collider2D;

		private Collider collider3D;

		public bool hasCollider
		{
			[Calls(Type = typeof(Object), Member = "op_Implicit")]
			[Calls(Type = typeof(Object), Member = "op_Implicit")]
			[CallerCount(Count = 0)]
			get
			{
				return default(bool);
			}
		}

		public string name
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Object), Member = "op_Implicit")]
			[Calls(Type = typeof(Object), Member = "op_Implicit")]
			[Calls(Type = typeof(Object), Member = "get_name")]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return null;
			}
		}

		public Bounds bounds
		{
			[CallsUnknownMethods(Count = 3)]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(Object), Member = "op_Implicit")]
			[Calls(Type = typeof(Object), Member = "op_Implicit")]
			get
			{
				return default(Bounds);
			}
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
		public HitResult(RaycastHit hit3D)
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RaycastHit2D), Member = "get_collider")]
		public HitResult(RaycastHit2D hit2D)
		{
		}

		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit3D")]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit2D")]
		public HitResult()
		{
		}
	}

	private enum Direction
	{
		Up = 0,
		Down = 1,
		Left = 2,
		Right = 3,
		Max2D = 1,
		Max3D = 3
	}

	public Dimensions dimensions;

	public LayerMask layerMask;

	public bool considerTriggers;

	public float minOccluderArea;

	public float minSurfaceRatio;

	public float maxSurfaceDot;

	public PlaneAlignment planeAlignment;

	public float planeOffset;

	public float fadeDistanceToSurface;

	private HitResult _003CcurrentHit_003Ek__BackingField;

	private float m_RangeMultiplier;

	private Plane _003CplaneEquationWS_003Ek__BackingField;

	private uint m_PrevNonSubHitDirectionId;

	public float fadeDistanceToPlane
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return default(float);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public HitResult currentHit
	{
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		private set
		{
		}
	}

	public Plane planeEquationWS
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return default(Plane);
		}
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	private QueryTriggerInteraction queryTriggerInteraction
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(QueryTriggerInteraction);
		}
	}

	private float raycastMaxDistance
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastDistance")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_lossyScale")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(float);
		}
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public bool IsColliderHiddenByDynamicOccluder(Collider collider)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	protected override string GetShaderKeyword()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
	{
		return default(MaterialManager.DynamicOcclusion);
	}

	[CallerCount(Count = 0)]
	protected override void OnValidateProperties()
	{
	}

	[CallerCount(Count = 0)]
	protected override void OnEnablePostValidate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicOcclusionAbstractBase), Member = "OnDisable")]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "SetHit")]
	protected override void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Random), Member = "Range")]
	private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit2D")]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit3D")]
	private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
	{
		return null;
	}

	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
	[Calls(Type = typeof(HitResult), Member = ".ctor")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_lossyScale")]
	[Calls(Type = typeof(Physics), Member = "RaycastAll")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastDistance")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
	{
		return null;
	}

	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
	[Calls(Type = typeof(RaycastHit2D), Member = "get_collider")]
	[Calls(Type = typeof(HitResult), Member = ".ctor")]
	[Calls(Type = typeof(RaycastHit2D), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit2D), Member = "get_collider")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit")]
	[Calls(Type = typeof(RaycastHit2D), Member = "get_collider")]
	[Calls(Type = typeof(ContactFilter2D), Member = "CreateLegacyFilter")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_lossyScale")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastDistance")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Collider2D), Member = "get_isTrigger")]
	private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	private uint GetDirectionCount()
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalUp")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalUp")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalRight")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalRight")]
	private Vector3 GetDirection(uint dirInt)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
	[CallsUnknownMethods(Count = 1)]
	private bool IsHitValid(HitResult hit, Vector3 forwardVec)
	{
		return default(bool);
	}

	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit2D")]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit3D")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "SetHit")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalUp")]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "IsHitValid")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalRight")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalUp")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastDistance")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalForward")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalRight")]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit3D")]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit2D")]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "IsHitValid")]
	protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalForward")]
	[Calls(Type = typeof(Plane), Member = ".ctor")]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "SetClippingPlane")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnDisable")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "SetClippingPlane")]
	private void SetHit(HitResult hit)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "SetHit")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "SetHit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	private void SetClippingPlane(Plane planeWS)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[CallsUnknownMethods(Count = 1)]
	private void SetClippingPlaneOff()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void SetPlaneWS(Plane planeWS)
	{
	}

	[CallerCount(Count = 0)]
	public DynamicOcclusionRaycasting()
	{
	}
}
