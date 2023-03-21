using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class CarcassSite : MonoBehaviour
{
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

	public class ManagerDataProxy
	{
		public List<CarcassSiteDataProxy> m_ProxyDataList;

		[CalledBy(Type = typeof(Manager), Member = ".cctor")]
		[CallsUnknownMethods(Count = 8)]
		[CallerCount(Count = 1)]
		public ManagerDataProxy()
		{
		}
	}

	public class Manager
	{
		private static List<CarcassSite> m_AllCarcassSiteList;

		private static ManagerDataProxy m_ManagerDataProxy;

		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(CarcassSite), Member = "GetNumberOfNonDepletedItemsOnSite")]
		[Calls(Type = typeof(CarcassSite), Member = "Serialize")]
		[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
		[CallsUnknownMethods(Count = 3)]
		public static string Serialize()
		{
			return null;
		}

		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
		[Calls(Type = typeof(CarcassSite), Member = "Deserialize")]
		[Calls(Type = typeof(SpawnRegion), Member = "GetPrefabNameFromInstanceName")]
		[Calls(Type = typeof(Manager), Member = "TryInstanciateCarcassSite")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		public static void Deserialize(string text)
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeSpawnCarcassSite")]
		[CalledBy(Type = typeof(Manager), Member = "TrySpawnCarcassSite")]
		[CalledBy(Type = typeof(Manager), Member = "Deserialize")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Manager), Member = "IsCarcasseSiteNearby")]
		private static CarcassSite TryInstanciateCarcassSite(GameObject carcassSitePrefab, Vector3 position, GameObject originCorpse)
		{
			return null;
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Manager), Member = "TryInstanciateCarcassSite")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(CarcassSite), Member = "Initialize")]
		public static CarcassSite TrySpawnCarcassSite(GameObject carcassSitePrefab, Vector3 position, GameObject originCorpse, bool spawnPostHarvestFX, float timeHours)
		{
			return null;
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Clear")]
		public static void Reset()
		{
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(Transform), Member = "get_position")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[CalledBy(Type = typeof(Manager), Member = "TryInstanciateCarcassSite")]
		[CallsUnknownMethods(Count = 2)]
		public static bool IsCarcasseSiteNearby(Vector3 position, float radius)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public static void Add(CarcassSite site)
		{
		}

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public Manager()
		{
		}
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void Awake()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(CarcassSite), Member = "HasPostHarvestMessFxExpired")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Carrion), Member = "HasDispersed")]
	[Calls(Type = typeof(CarcassSite), Member = "IsCarrionActive")]
	[Calls(Type = typeof(CarcassSite), Member = "GetNumberOfNonDepletedItemsOnSite")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CarcassSite), Member = "IsCarrionActive")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	public void Update()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(CarcassSite), Member = "AddBodyHarvestOnSite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(CarcassSite), Member = "AddPostHarvestMessFx")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeSpawnOrRefreshCarcassSite")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnOrRefreshCarcassSite")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BodyHarvest), Member = "RefreshCarcassSite")]
	public void Refresh(float hoursAtRefresh)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CarcassSite), Member = "MaybeSpawnBodyParts")]
	public void SpawnQuarteringMess()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Utils), Member = "GetOrientationOnSlope")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(CarcassSite), Member = "PlaceBodyPart")]
	public bool StickToGroundAndOrientOnSlope(Transform modifiedTransform, Vector3 desiredPosition)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(CarcassSite), Member = "StickToGroundAndOrientOnSlope")]
	[CalledBy(Type = typeof(CarcassSite), Member = "MaybeSpawnBodyParts")]
	[CallsUnknownMethods(Count = 12)]
	private void PlaceBodyPart(float spawnAngle, float startAngle, float spawnRadius, int i, GameObject legObject)
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(CarcassSite), Member = "PlaceBodyPart")]
	[CalledBy(Type = typeof(CarcassSite), Member = "SpawnQuarteringMess")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Deserialize")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeSpawnQuarteringMess")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnQuarteringMessOnCarcassSite")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 5)]
	private void MaybeSpawnBodyParts()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void RandomRotateLeg(Transform transform)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CarcassSite), Member = "AddPostHarvestMessFx")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshPostHarvestMessFX(float hoursAtRefresh)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Manager), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 19)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 21)]
	private CarcassSiteDataProxy Serialize()
	{
		return default(CarcassSiteDataProxy);
	}

	[Calls(Type = typeof(CarcassSite), Member = "MaybeSpawnBodyParts")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CarcassSite), Member = "HasPostHarvestMessFxExpired")]
	[CalledBy(Type = typeof(Manager), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(CarcassSite), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 1)]
	private void Deserialize(CarcassSiteDataProxy dataProxy)
	{
	}

	[CalledBy(Type = typeof(CarcassSite), Member = "Deserialize")]
	[CalledBy(Type = typeof(Manager), Member = "TrySpawnCarcassSite")]
	[Calls(Type = typeof(CarcassSite), Member = "AddPostHarvestMessFx")]
	[Calls(Type = typeof(CarcassSite), Member = "HasPostHarvestMessFxExpired")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(CarcassSite), Member = "AddBodyHarvestOnSite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeSpawnCarcassSite")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void Initialize(Vector3 position, string name, bool spawnPostHarvestFX, float timeHours)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Refresh")]
	[CalledBy(Type = typeof(CarcassSite), Member = "RefreshPostHarvestMessFX")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Initialize")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	private void AddPostHarvestMessFx(Vector3 position, float postHarvestMessDurationHours)
	{
	}

	[CalledBy(Type = typeof(CarcassSite), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CarcassSite), Member = "UpdatePostHarvestMess")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Initialize")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(CarcassSite), Member = "Update")]
	private bool HasPostHarvestMessFxExpired()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(CarcassSite), Member = "HasPostHarvestMessFxExpired")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	private void UpdatePostHarvestMess()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CarcassSite), Member = "AddBodyHarvestOnSite")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	private BodyHarvest TryGetBodyHarvestFromCollider(Collider collider)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Carrion), Member = "HasDispersed")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void SetCarrionActive(bool enabled)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Update")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Update")]
	[CalledBy(Type = typeof(CarcassSite), Member = "UpdateCarrion")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CarcassSite), Member = "UpdateCarrion")]
	private bool IsCarrionActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CarcassSite), Member = "AddBodyHarvestOnSite")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void AddBodyHarvest(BodyHarvest bodyHarvest)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	private void ResetBodyHarvestOnSite()
	{
	}

	[Calls(Type = typeof(Physics), Member = "OverlapSphere")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Initialize")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Refresh")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(CarcassSite), Member = "AddBodyHarvest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CarcassSite), Member = "TryGetBodyHarvestFromCollider")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private void AddBodyHarvestOnSite()
	{
	}

	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	[CalledBy(Type = typeof(Manager), Member = "Serialize")]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(CarcassSite), Member = "UpdateCarrion")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private int GetNumberOfNonDepletedItemsOnSite()
	{
		return default(int);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CarcassSite), Member = "IsCarrionActive")]
	[Calls(Type = typeof(Carrion), Member = "HasDispersed")]
	[Calls(Type = typeof(CarcassSite), Member = "IsCarrionActive")]
	[Calls(Type = typeof(CarcassSite), Member = "GetNumberOfNonDepletedItemsOnSite")]
	private void UpdateCarrion()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	public CarcassSite()
	{
	}
}
