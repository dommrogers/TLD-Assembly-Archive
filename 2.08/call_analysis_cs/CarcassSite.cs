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

		[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Array), Member = "Clear")]
		[Calls(Type = typeof(CarcassSite), Member = "GetNumberOfNonDepletedItemsOnSite")]
		[Calls(Type = typeof(CarcassSite), Member = "Serialize")]
		[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsUnknownMethods(Count = 3)]
		public static string Serialize()
		{
			return null;
		}

		[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
		[Calls(Type = typeof(SpawnRegion), Member = "GetPrefabNameFromInstanceName")]
		[Calls(Type = typeof(Manager), Member = "TryInstanciateCarcassSite")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(CarcassSite), Member = "Deserialize")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public static void Deserialize(string text)
		{
		}

		[CalledBy(Type = typeof(Manager), Member = "Deserialize")]
		[CalledBy(Type = typeof(Manager), Member = "TrySpawnCarcassSite")]
		[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeSpawnCarcassSite")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(Type = typeof(Manager), Member = "IsCarcasseSiteNearby")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
		[Calls(Type = typeof(GameObject), Member = "GetComponent")]
		[CallsUnknownMethods(Count = 1)]
		private static CarcassSite TryInstanciateCarcassSite(GameObject carcassSitePrefab, Vector3 position, GameObject originCorpse)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Manager), Member = "TryInstanciateCarcassSite")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(CarcassSite), Member = "Initialize")]
		[CallsUnknownMethods(Count = 1)]
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

		[CalledBy(Type = typeof(Manager), Member = "TryInstanciateCarcassSite")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		public static bool IsCarcasseSiteNearby(Vector3 position, float radius)
		{
			return false;
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
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CarcassSite), Member = "GetNumberOfNonDepletedItemsOnSite")]
	[Calls(Type = typeof(CarcassSite), Member = "IsCarrionActive")]
	[Calls(Type = typeof(Carrion), Member = "HasDispersed")]
	[Calls(Type = typeof(CarcassSite), Member = "UpdatePostHarvestMess")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeSpawnOrRefreshCarcassSite")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "RefreshCarcassSite")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnOrRefreshCarcassSite")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(CarcassSite), Member = "AddBodyHarvestOnSite")]
	[Calls(Type = typeof(CarcassSite), Member = "AddPostHarvestMessFx")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void Refresh(float hoursAtRefresh)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CarcassSite), Member = "MaybeSpawnBodyParts")]
	public void SpawnQuarteringMess()
	{
	}

	[CalledBy(Type = typeof(CarcassSite), Member = "PlaceBodyPart")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Utils), Member = "GetOrientationOnSlope")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public bool StickToGroundAndOrientOnSlope(Transform modifiedTransform, Vector3 desiredPosition)
	{
		return false;
	}

	[CalledBy(Type = typeof(CarcassSite), Member = "MaybeSpawnBodyParts")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(CarcassSite), Member = "StickToGroundAndOrientOnSlope")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 12)]
	private void PlaceBodyPart(float spawnAngle, float startAngle, float spawnRadius, int i, GameObject legObject)
	{
	}

	[CalledBy(Type = typeof(CarcassSite), Member = "SpawnQuarteringMess")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Deserialize")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeSpawnQuarteringMess")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnQuarteringMessOnCarcassSite")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "QuarterSuccessful")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(CarcassSite), Member = "PlaceBodyPart")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 30)]
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
	[Calls(Type = typeof(CarcassSite), Member = "AddPostHarvestMessFx")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshPostHarvestMessFX(float hoursAtRefresh)
	{
	}

	[CalledBy(Type = typeof(Manager), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 20)]
	private CarcassSiteDataProxy Serialize()
	{
		return default(CarcassSiteDataProxy);
	}

	[CalledBy(Type = typeof(Manager), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CarcassSite), Member = "Initialize")]
	[Calls(Type = typeof(CarcassSite), Member = "HasPostHarvestMessFxExpired")]
	[Calls(Type = typeof(CarcassSite), Member = "MaybeSpawnBodyParts")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 17)]
	private void Deserialize(CarcassSiteDataProxy dataProxy)
	{
	}

	[CalledBy(Type = typeof(Manager), Member = "TrySpawnCarcassSite")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Deserialize")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeSpawnCarcassSite")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(CarcassSite), Member = "AddBodyHarvestOnSite")]
	[Calls(Type = typeof(CarcassSite), Member = "HasPostHarvestMessFxExpired")]
	[Calls(Type = typeof(CarcassSite), Member = "AddPostHarvestMessFx")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void Initialize(Vector3 position, string name, bool spawnPostHarvestFX, float timeHours)
	{
	}

	[CalledBy(Type = typeof(CarcassSite), Member = "Refresh")]
	[CalledBy(Type = typeof(CarcassSite), Member = "RefreshPostHarvestMessFX")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Initialize")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void AddPostHarvestMessFx(Vector3 position, float postHarvestMessDurationHours)
	{
	}

	[CalledBy(Type = typeof(CarcassSite), Member = "Deserialize")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Initialize")]
	[CalledBy(Type = typeof(CarcassSite), Member = "UpdatePostHarvestMess")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private bool HasPostHarvestMessFxExpired()
	{
		return false;
	}

	[CalledBy(Type = typeof(CarcassSite), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CarcassSite), Member = "HasPostHarvestMessFxExpired")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	private void UpdatePostHarvestMess()
	{
	}

	[CalledBy(Type = typeof(CarcassSite), Member = "AddBodyHarvestOnSite")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private BodyHarvest TryGetBodyHarvestFromCollider(Collider collider)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Carrion), Member = "HasDispersed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void SetCarrionActive(bool enabled)
	{
	}

	[CalledBy(Type = typeof(CarcassSite), Member = "Update")]
	[CalledBy(Type = typeof(CarcassSite), Member = "UpdateCarrion")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsCarrionActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(CarcassSite), Member = "AddBodyHarvestOnSite")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(CarcassSite), Member = "Refresh")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Initialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Physics), Member = "OverlapSphere")]
	[Calls(Type = typeof(CarcassSite), Member = "TryGetBodyHarvestFromCollider")]
	[Calls(Type = typeof(CarcassSite), Member = "AddBodyHarvest")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void AddBodyHarvestOnSite()
	{
	}

	[CalledBy(Type = typeof(Manager), Member = "Serialize")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Update")]
	[CalledBy(Type = typeof(CarcassSite), Member = "UpdateCarrion")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BodyHarvest), Member = "NoMoreResources")]
	[Calls(Type = typeof(BodyHarvest), Member = "ConditionReachedZero")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 5)]
	private int GetNumberOfNonDepletedItemsOnSite()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CarcassSite), Member = "GetNumberOfNonDepletedItemsOnSite")]
	[Calls(Type = typeof(CarcassSite), Member = "IsCarrionActive")]
	[Calls(Type = typeof(Carrion), Member = "HasDispersed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
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
