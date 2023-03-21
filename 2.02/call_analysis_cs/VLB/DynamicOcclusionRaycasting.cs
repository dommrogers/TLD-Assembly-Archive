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
			[Calls(Type = typeof(Object), Member = "op_Implicit")]
			[CallsDeduplicatedMethods(Count = 1)]
			get
			{
				return false;
			}
		}

		public string name
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Object), Member = "op_Implicit")]
			[Calls(Type = typeof(Object), Member = "get_name")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			get
			{
				return null;
			}
		}

		public Bounds bounds
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Object), Member = "op_Implicit")]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 4)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		public HitResult(RaycastHit2D hit2D)
		{
		}

		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit3D")]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit2D")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Vector3), Member = "get_zero")]
		[CallsDeduplicatedMethods(Count = 1)]
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
			return 0f;
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
		[CallerCount(Count = 7)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 19)]
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
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit3D")]
		[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit2D")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastDistance")]
		[Calls(Type = typeof(VolumetricLightBeam), Member = "get_lossyScale")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public bool IsColliderHiddenByDynamicOccluder(Collider collider)
	{
		return false;
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
	[Calls(Type = typeof(DynamicOcclusionAbstractBase), Member = "OnValidateProperties")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "get_raycastMaxDistance")]
	[Calls(Type = typeof(Physics), Member = "RaycastAll")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(Utils), Member = "GetMaxArea2D")]
	[Calls(Type = typeof(HitResult), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 28)]
	private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
	{
		return null;
	}

	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "get_raycastMaxDistance")]
	[Calls(Type = typeof(ContactFilter2D), Member = "CreateLegacyFilter")]
	[Calls(Type = typeof(RaycastHit2D), Member = "get_collider")]
	[Calls(Type = typeof(Collider2D), Member = "get_isTrigger")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Collider2D), Member = "get_bounds")]
	[Calls(Type = typeof(Utils), Member = "GetMaxArea2D")]
	[Calls(Type = typeof(HitResult), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 30)]
	private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	private uint GetDirectionCount()
	{
		return 0u;
	}

	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalRight")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalUp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Vector3 GetDirection(uint dirInt)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private bool IsHitValid(HitResult hit, Vector3 forwardVec)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalForward")]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit2D")]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "GetBestHit3D")]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "IsHitValid")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastDistance")]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "GetDirection")]
	[Calls(Type = typeof(Transform), Member = "get_localScale")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_coneRadiusEnd")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "SetHit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 12)]
	protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
	{
		return false;
	}

	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnDisable")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnProcessOcclusion")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "get_raycastGlobalForward")]
	[Calls(Type = typeof(Plane), Member = ".ctor")]
	[Calls(Type = typeof(DynamicOcclusionRaycasting), Member = "SetClippingPlane")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void SetHit(HitResult hit)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
	{
	}

	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "SetHit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private void SetClippingPlane(Plane planeWS)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public DynamicOcclusionRaycasting()
	{
	}
}
