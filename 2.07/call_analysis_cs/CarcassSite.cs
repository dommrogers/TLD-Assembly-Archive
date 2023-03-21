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

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		public ManagerDataProxy()
		{
		}
	}

	public class Manager
	{
		private static List<CarcassSite> m_AllCarcassSiteList;

		private static ManagerDataProxy m_ManagerDataProxy;

		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
		[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
		[Calls(Type = typeof(CarcassSite), Member = "GetNumberOfNonDepletedItemsOnSite")]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[Calls(Type = typeof(CarcassSite), Member = "Serialize")]
		[CallerCount(Count = 1)]
		public static string Serialize()
		{
			return null;
		}

		[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[Calls(Type = typeof(CarcassSite), Member = "Deserialize")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(SpawnRegion), Member = "GetPrefabNameFromInstanceName")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Manager), Member = "TryInstanciateCarcassSite")]
		public static void Deserialize(string text)
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeSpawnCarcassSite")]
		[CalledBy(Type = typeof(Manager), Member = "TrySpawnCarcassSite")]
		[CalledBy(Type = typeof(Manager), Member = "Deserialize")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(Manager), Member = "IsCarcasseSiteNearby")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		private static CarcassSite TryInstanciateCarcassSite(GameObject carcassSitePrefab, Vector3 position, GameObject originCorpse)
		{
			return null;
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(CarcassSite), Member = "Initialize")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Manager), Member = "TryInstanciateCarcassSite")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		public static CarcassSite TrySpawnCarcassSite(GameObject carcassSitePrefab, Vector3 position, GameObject originCorpse, bool spawnPostHarvestFX, float timeHours)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[CallsUnknownMethods(Count = 1)]
		public static void Reset()
		{
		}

		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[CalledBy(Type = typeof(Manager), Member = "TryInstanciateCarcassSite")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(CarcassSite), Member = "IsCarrionActive")]
	[Calls(Type = typeof(CarcassSite), Member = "UpdatePostHarvestMess")]
	[Calls(Type = typeof(Carrion), Member = "HasDispersed")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CarcassSite), Member = "GetNumberOfNonDepletedItemsOnSite")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CarcassSite), Member = "IsCarrionActive")]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(BodyHarvest), Member = "RefreshCarcassSite")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnOrRefreshCarcassSite")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeSpawnOrRefreshCarcassSite")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(CarcassSite), Member = "AddBodyHarvestOnSite")]
	[Calls(Type = typeof(CarcassSite), Member = "AddPostHarvestMessFx")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
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
	[CalledBy(Type = typeof(CarcassSite), Member = "PlaceBodyPart")]
	[CallsUnknownMethods(Count = 6)]
	public bool StickToGroundAndOrientOnSlope(Transform modifiedTransform, Vector3 desiredPosition)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(CarcassSite), Member = "MaybeSpawnBodyParts")]
	[Calls(Type = typeof(CarcassSite), Member = "StickToGroundAndOrientOnSlope")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	private void PlaceBodyPart(float spawnAngle, float startAngle, float spawnRadius, int i, GameObject legObject)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 30)]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnQuarteringMessOnCarcassSite")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeSpawnQuarteringMess")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Deserialize")]
	[Calls(Type = typeof(CarcassSite), Member = "PlaceBodyPart")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(CarcassSite), Member = "SpawnQuarteringMess")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	private void MaybeSpawnBodyParts()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void RandomRotateLeg(Transform transform)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CarcassSite), Member = "AddPostHarvestMessFx")]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshPostHarvestMessFX(float hoursAtRefresh)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Manager), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 20)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private CarcassSiteDataProxy Serialize()
	{
		return default(CarcassSiteDataProxy);
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(Manager), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CarcassSite), Member = "HasPostHarvestMessFxExpired")]
	[Calls(Type = typeof(CarcassSite), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CarcassSite), Member = "MaybeSpawnBodyParts")]
	private void Deserialize(CarcassSiteDataProxy dataProxy)
	{
	}

	[Calls(Type = typeof(CarcassSite), Member = "AddPostHarvestMessFx")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(CarcassSite), Member = "Deserialize")]
	[CalledBy(Type = typeof(Manager), Member = "TrySpawnCarcassSite")]
	[Calls(Type = typeof(CarcassSite), Member = "HasPostHarvestMessFxExpired")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeSpawnCarcassSite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CarcassSite), Member = "AddBodyHarvestOnSite")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Initialize(Vector3 position, string name, bool spawnPostHarvestFX, float timeHours)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Refresh")]
	[CalledBy(Type = typeof(CarcassSite), Member = "RefreshPostHarvestMessFX")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Initialize")]
	[CallsUnknownMethods(Count = 2)]
	private void AddPostHarvestMessFx(Vector3 position, float postHarvestMessDurationHours)
	{
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(CarcassSite), Member = "Deserialize")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Initialize")]
	[CalledBy(Type = typeof(CarcassSite), Member = "UpdatePostHarvestMess")]
	[CallsUnknownMethods(Count = 1)]
	private bool HasPostHarvestMessFxExpired()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(CarcassSite), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CarcassSite), Member = "HasPostHarvestMessFxExpired")]
	private void UpdatePostHarvestMess()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(CarcassSite), Member = "AddBodyHarvestOnSite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private BodyHarvest TryGetBodyHarvestFromCollider(Collider collider)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Carrion), Member = "HasDispersed")]
	[CallsUnknownMethods(Count = 2)]
	private void SetCarrionActive(bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CarcassSite), Member = "UpdateCarrion")]
	[CalledBy(Type = typeof(CarcassSite), Member = "UpdateCarrion")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Update")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool IsCarrionActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(CarcassSite), Member = "AddBodyHarvestOnSite")]
	[CallsUnknownMethods(Count = 2)]
	private void AddBodyHarvest(BodyHarvest bodyHarvest)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	private void ResetBodyHarvestOnSite()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(CarcassSite), Member = "Initialize")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Refresh")]
	[Calls(Type = typeof(CarcassSite), Member = "AddBodyHarvest")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Physics), Member = "OverlapSphere")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CarcassSite), Member = "TryGetBodyHarvestFromCollider")]
	private void AddBodyHarvestOnSite()
	{
	}

	[CalledBy(Type = typeof(CarcassSite), Member = "Update")]
	[CalledBy(Type = typeof(CarcassSite), Member = "UpdateCarrion")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Manager), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private int GetNumberOfNonDepletedItemsOnSite()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(CarcassSite), Member = "IsCarrionActive")]
	[Calls(Type = typeof(CarcassSite), Member = "IsCarrionActive")]
	[Calls(Type = typeof(Carrion), Member = "HasDispersed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CarcassSite), Member = "GetNumberOfNonDepletedItemsOnSite")]
	private void UpdateCarrion()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public CarcassSite()
	{
	}
}
