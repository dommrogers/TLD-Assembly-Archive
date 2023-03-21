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
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(Object), Member = "op_Implicit")]
			[Calls(Type = typeof(Object), Member = "op_Implicit")]
			get
			{
				return default(bool);
			}
		}

		public string name
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(Object), Member = "op_Implicit")]
			[Calls(Type = typeof(Object), Member = "op_Implicit")]
			[Calls(Type = typeof(Object), Member = "get_name")]
			[CallsUnknownMethods(Count = 2)]
			get
			{
				return null;
			}
		}

		public Bounds bounds
		{
			[CallsUnknownMethods(Count = 4)]
			[Calls(Type = typeof(Object), Member = "op_Implicit")]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallerCount(Count = 0)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(RaycastHit2D), Member = "get_collider")]
		public HitResult(RaycastHit2D hit2D)
		{
		}

		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit3D")]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit2D")]
		[Calls(Type = typeof(Vector3), Member = "get_zero")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Vector3), Member = "get_zero")]
		[CallerCount(Count = 2)]
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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 4)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
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
		[CompilerGenerated]
		[DeduplicatedMethod]
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
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit2D")]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit3D")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastDistance")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_lossyScale")]
		get
		{
			return default(float);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public bool IsColliderHiddenByDynamicOccluder(Collider collider)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DynamicOcclusionAbstractBase), Member = "OnValidateProperties")]
	protected override void OnValidateProperties()
	{
	}

	[CallerCount(Count = 0)]
	protected override void OnEnablePostValidate()
	{
	}

	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "SetHit")]
	[Calls(Type = typeof(DynamicOcclusionAbstractBase), Member = "OnDisable")]
	[CallerCount(Count = 0)]
	protected override void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
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

	[Calls(Type = typeof(HitResult), Member = ".ctor")]
	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Utils), Member = "GetMaxArea2D")]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "get_raycastMaxDistance")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Physics), Member = "RaycastAll")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
	{
		return null;
	}

	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit")]
	[Calls(Type = typeof(RaycastHit2D), Member = "get_collider")]
	[Calls(Type = typeof(HitResult), Member = ".ctor")]
	[Calls(Type = typeof(Utils), Member = "GetMaxArea2D")]
	[Calls(Type = typeof(Collider2D), Member = "get_bounds")]
	[Calls(Type = typeof(RaycastHit2D), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit2D), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit2D), Member = "get_collider")]
	[Calls(Type = typeof(Collider2D), Member = "get_isTrigger")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
	[Calls(Type = typeof(ContactFilter2D), Member = "CreateLegacyFilter")]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "get_raycastMaxDistance")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 30)]
	private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	private uint GetDirectionCount()
	{
		return default(uint);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalRight")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalRight")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalUp")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalUp")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
	[CallsUnknownMethods(Count = 4)]
	private Vector3 GetDirection(uint dirInt)
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private bool IsHitValid(HitResult hit, Vector3 forwardVec)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "IsHitValid")]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit3D")]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit2D")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_coneRadiusEnd")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "SetHit")]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "GetDirection")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastDistance")]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "IsHitValid")]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit3D")]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit2D")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalForward")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[CallerCount(Count = 0)]
	protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnDisable")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[Calls(Type = typeof(Plane), Member = ".ctor")]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "SetClippingPlane")]
	[Calls(Type = typeof(Plane), Member = ".ctor")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalForward")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "SetClippingPlane")]
	private void SetHit(HitResult hit)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "SetHit")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "SetHit")]
	private void SetClippingPlane(Plane planeWS)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SetClippingPlaneOff()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void SetPlaneWS(Plane planeWS)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public DynamicOcclusionRaycasting()
	{
	}
}
