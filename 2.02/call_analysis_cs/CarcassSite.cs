using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CarcassSite : MonoBehaviour
{
	public class ManagerDataProxy
	{
		public List<CarcassSiteDataProxy> m_ProxyDataList;

		[CallsUnknownMethods(Count = 12)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(Manager), Member = ".cctor")]
		public ManagerDataProxy()
		{
		}
	}

	public class Manager
	{
		private static List<CarcassSite> m_AllCarcassSiteList;

		private static ManagerDataProxy m_ManagerDataProxy;

		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(Utils), Member = "SerializeObject")]
		[Calls(Type = typeof(CarcassSite), Member = "Serialize")]
		[Calls(Type = typeof(CarcassSite), Member = "GetNumberOfNonDepletedItemsOnSite")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 8)]
		public static string Serialize()
		{
			return null;
		}

		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 4)]
		[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
		[Calls(Type = typeof(CarcassSite), Member = "Deserialize")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(Manager), Member = "TryInstanciateCarcassSite")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(Resources), Member = "Load")]
		[Calls(Type = typeof(SpawnRegion), Member = "GetPrefabNameFromInstanceName")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 1)]
		public static void Deserialize(string text)
		{
		}

		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(Manager), Member = "TrySpawnCarcassSite")]
		[CalledBy(Type = typeof(Manager), Member = "Deserialize")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeSpawnCarcassSite")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Manager), Member = "IsCarcasseSiteNearby")]
		private static CarcassSite TryInstanciateCarcassSite(GameObject carcassSitePrefab, Vector3 position, GameObject originCorpse)
		{
			return null;
		}

		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(CarcassSite), Member = "Initialize")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Manager), Member = "TryInstanciateCarcassSite")]
		public static CarcassSite TrySpawnCarcassSite(GameObject carcassSitePrefab, Vector3 position, GameObject originCorpse, bool spawnPostHarvestFX, float timeHours)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[CallsUnknownMethods(Count = 1)]
		public static void Reset()
		{
		}

		[CalledBy(Type = typeof(Manager), Member = "TryInstanciateCarcassSite")]
		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(Transform), Member = "get_position")]
		public static bool IsCarcasseSiteNearby(Vector3 position, float radius)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public static void Add(CarcassSite site)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public Manager()
		{
		}
	}

	public struct CarcassSiteDataProxy
	{
		public string m_PrefabName;

		public Vector3 m_Position;

		public float m_LastHarvestTimeHours;

		public bool m_HasSpawnPostHarvestFX;

		public bool m_IsQuarteringSite;

		public Vector3 m_LegRearLeftPosition;

		public Vector3 m_LegRearRightPosition;

		public Vector3 m_LegFrontLeftPosition;

		public Vector3 m_LegFrontLRightPosition;

		public Quaternion m_LegRearLeftRotation;

		public Quaternion m_LegRearRightRotation;

		public Quaternion m_LegFrontLeftRotation;

		public Quaternion m_LegFrontLRightRotation;
	}

	public float m_SiteRadius;

	public float m_LimitOtherCarrionsRadius;

	public float m_PostHarvestMessDurationHours;

	public GameObject m_PostHarvestMessFXPrefab;

	public GameObject m_LegRearLeftPrefab;

	public GameObject m_LegRearRightPrefab;

	public GameObject m_LegFrontLeftPrefab;

	public GameObject m_LegFrontLRightPrefab;

	public float m_LegSpawnAngle;

	public float m_LegSpawnRadius;

	private Carrion m_Carrion;

	private GameObject m_PostHarvestMessFX;

	private bool m_IsQuarteringSite;

	private GameObject m_BodyParts;

	private float m_LastHarvestTimeHours;

	private List<BodyHarvest> m_BodyHarvestList;

	private bool m_HasSpawnPostHarvestFX;

	private GameObject m_LegRearLeftObject;

	private GameObject m_LegRearRightObject;

	private GameObject m_LegFrontLeftObject;

	private GameObject m_LegFrontLRightObject;

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[Calls(Type = typeof(CarcassSite), Member = "HasPostHarvestMessFxExpired")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Carrion), Member = "HasDispersed")]
	[Calls(Type = typeof(CarcassSite), Member = "IsCarrionActive")]
	[Calls(Type = typeof(CarcassSite), Member = "GetNumberOfNonDepletedItemsOnSite")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CarcassSite), Member = "IsCarrionActive")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(CarcassSite), Member = "ResetBodyHarvestOnSite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CarcassSite), Member = "AddPostHarvestMessFx")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(CarcassSite), Member = "AddBodyHarvestOnSite")]
	public void Refresh(float hoursAtRefresh)
	{
	}

	[Calls(Type = typeof(CarcassSite), Member = "MaybeSpawnBodyParts")]
	[CallerCount(Count = 0)]
	public void SpawnQuarteringMess()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(CarcassSite), Member = "PlaceBodyPart")]
	[Calls(Type = typeof(Utils), Member = "GetOrientationOnSlope")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	public bool StickToGroundAndOrientOnSlope(Transform modifiedTransform, Vector3 desiredPosition)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(CarcassSite), Member = "MaybeSpawnBodyParts")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(CarcassSite), Member = "StickToGroundAndOrientOnSlope")]
	[CallsUnknownMethods(Count = 18)]
	private void PlaceBodyPart(float spawnAngle, float startAngle, float spawnRadius, int i, GameObject legObject)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(CarcassSite), Member = "PlaceBodyPart")]
	[CalledBy(Type = typeof(CarcassSite), Member = "SpawnQuarteringMess")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Deserialize")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeSpawnQuarteringMess")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnQuarteringMessOnCarcassSite")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CallsUnknownMethods(Count = 56)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void MaybeSpawnBodyParts()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallerCount(Count = 0)]
	private void RandomRotateLeg(Transform transform)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CarcassSite), Member = "AddPostHarvestMessFx")]
	private void RefreshPostHarvestMessFX(float hoursAtRefresh)
	{
	}

	[CalledBy(Type = typeof(Manager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 38)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private CarcassSiteDataProxy Serialize()
	{
		return default(CarcassSiteDataProxy);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CarcassSite), Member = "HasPostHarvestMessFxExpired")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Manager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(CarcassSite), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CarcassSite), Member = "MaybeSpawnBodyParts")]
	private void Deserialize(CarcassSiteDataProxy dataProxy)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Manager), Member = "TrySpawnCarcassSite")]
	[Calls(Type = typeof(CarcassSite), Member = "ResetBodyHarvestOnSite")]
	[Calls(Type = typeof(CarcassSite), Member = "AddBodyHarvestOnSite")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CarcassSite), Member = "HasPostHarvestMessFxExpired")]
	[Calls(Type = typeof(CarcassSite), Member = "AddPostHarvestMessFx")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Deserialize")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeSpawnCarcassSite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	private void Initialize(Vector3 position, string name, bool spawnPostHarvestFX, float timeHours)
	{
	}

	[CalledBy(Type = typeof(BodyHarvest), Member = "RefreshCarcassSite")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Refresh")]
	[CalledBy(Type = typeof(CarcassSite), Member = "RefreshPostHarvestMessFX")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Initialize")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 4)]
	private void AddPostHarvestMessFx(Vector3 position, float postHarvestMessDurationHours)
	{
	}

	[CalledBy(Type = typeof(CarcassSite), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(CarcassSite), Member = "UpdatePostHarvestMess")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(CarcassSite), Member = "Initialize")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Deserialize")]
	private bool HasPostHarvestMessFxExpired()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(CarcassSite), Member = "HasPostHarvestMessFxExpired")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdatePostHarvestMess()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CarcassSite), Member = "AddBodyHarvestOnSite")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	private BodyHarvest TryGetBodyHarvestFromCollider(Collider collider)
	{
		return null;
	}

	[Calls(Type = typeof(Carrion), Member = "HasDispersed")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void SetCarrionActive(bool enabled)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Update")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Update")]
	[CalledBy(Type = typeof(CarcassSite), Member = "UpdateCarrion")]
	[CalledBy(Type = typeof(CarcassSite), Member = "UpdateCarrion")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 4)]
	private bool IsCarrionActive()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(CarcassSite), Member = "AddBodyHarvestOnSite")]
	private void AddBodyHarvest(BodyHarvest bodyHarvest)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(CarcassSite), Member = "Refresh")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Initialize")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "RefreshCarcassSite")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void ResetBodyHarvestOnSite()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BodyHarvest), Member = "RefreshCarcassSite")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Initialize")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Refresh")]
	[Calls(Type = typeof(CarcassSite), Member = "AddBodyHarvest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CarcassSite), Member = "TryGetBodyHarvestFromCollider")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphere")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	private void AddBodyHarvestOnSite()
	{
	}

	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Update")]
	[CalledBy(Type = typeof(CarcassSite), Member = "UpdateCarrion")]
	[CalledBy(Type = typeof(Manager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 6)]
	private int GetNumberOfNonDepletedItemsOnSite()
	{
		return default(int);
	}

	[Calls(Type = typeof(Carrion), Member = "HasDispersed")]
	[Calls(Type = typeof(CarcassSite), Member = "GetNumberOfNonDepletedItemsOnSite")]
	[Calls(Type = typeof(CarcassSite), Member = "IsCarrionActive")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CarcassSite), Member = "IsCarrionActive")]
	private void UpdateCarrion()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public CarcassSite()
	{
	}
}
