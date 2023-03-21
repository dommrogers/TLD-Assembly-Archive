using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using TLD.PDID;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class BreakDown : BaseInteraction
{
	private struct LayerInfo
	{
		public GameObject m_GameObject;

		public int m_Layer;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<Collider> _003C_003E9__38_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallsUnknownMethods(Count = 7)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		internal int _003CStickSurfaceObjectsToGround_003Eb__38_0(Collider a, Collider b)
		{
			return default(int);
		}
	}

	public static List<BreakDown> m_BreakDownObjects;

	public static bool m_CanBreakDownObjects;

	public LocalizedString m_LocalizedDisplayName;

	public string m_BreakDownAudio;

	public float m_TimeCostHours;

	public bool m_RequiresTool;

	public bool m_ForceToPlayersFeet;

	private PanelReference<Panel_BreakDown> m_BreakDown;

	public GameObject[] m_UsableTools;

	public GameObject[] m_YieldObject;

	public int[] m_YieldObjectUnits;

	private List<Renderer> m_RendererList;

	private bool m_PostLoadBreakdown;

	private float m_CountdownToBreakdown;

	private float m_CountdownToBreakdownTime;

	private Collider[] m_OverlapSphereColliders;

	private List<LayerInfo> m_LayerInfos;

	private static BreakDownSaveData m_BreakDownSaveData;

	private static List<BreakDown> m_BreakDownItemsToSerialize;

	private static RaycastHit[] s_RaycastHit;

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(BreakDown), Member = "AddAlternateTools")]
	[CallsUnknownMethods(Count = 7)]
	protected override void Start()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(BreakDown), Member = "StickSurfaceObjectsToGround")]
	[CallsUnknownMethods(Count = 8)]
	public static void UpdateAll()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BreakDown), Member = "StickSurfaceObjectsToGround")]
	private void ManualUpdate()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeGetGuidFromGameObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(BreakDown), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 6)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(BreakDown), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(BreakDown), Member = "Serialize")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(BreakDown), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneDataAdditive")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BreakDown), Member = "FindBreakDownByPosition")]
	public static void DeserializeAll(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseInteraction), Member = "InitializeInteraction")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public override void InitializeInteraction()
	{
	}

	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIMenuOpen")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public override bool PerformInteraction()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_breakdown_all")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "BreakDownFinished")]
	[CalledBy(Type = typeof(Panel_BreakDown), Member = "Update")]
	[Calls(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[Calls(Type = typeof(BreakDown), Member = "SpawnYieldObjectsAndAddToInventory")]
	[Calls(Type = typeof(RadialSpawnManager), Member = "ReturnToObjectPool")]
	[Calls(Type = typeof(RadialObjectSpawner), Member = "RemoveFromSpawns")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BreakDown), Member = "StickSurfaceObjectsToGround")]
	public void DoBreakDown(bool spawnYieldObjects)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	public void OnEnable()
	{
	}

	[CalledBy(Type = typeof(BreakDown), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static BreakDown FindBreakDownByPosition(BreakDownSaveData proxy)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private static BreakDown FindBreakDownByGuid(string guid)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Utils), Member = "StickItemToGroundAtLocation")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "StickItemToGroundAtLocation")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void SpawnYieldObjectsAndStickToGround()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(BreakDown), Member = "DoBreakDown")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(GearMessage), Member = "AddMessage")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "ProcessPickupItemInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	private void SpawnYieldObjectsAndAddToInventory()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[CallsUnknownMethods(Count = 2)]
	private void DetachAttachedObjects()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Bounds), Member = "IntersectRay")]
	[Calls(Type = typeof(BreakDown), Member = "RestoreLayerInfos")]
	[Calls(Type = typeof(BreakDown), Member = "StickToGround")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[CalledBy(Type = typeof(BreakDown), Member = "ManualUpdate")]
	[CalledBy(Type = typeof(BreakDown), Member = "DoBreakDown")]
	[CallsUnknownMethods(Count = 90)]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(BreakDown), Member = "UpdateAll")]
	[Calls(Type = typeof(BreakDown), Member = "StickToGround")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 34)]
	[Calls(Type = typeof(BreakDown), Member = "SaveLayerInfos")]
	[Calls(Type = typeof(Utils), Member = "SetObjectAndChildrenLayer")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphereNonAlloc")]
	[Calls(Type = typeof(BreakDown), Member = "CanStickToGround")]
	[Calls(Type = typeof(GearItem), Member = "SetPlacePoint")]
	[Calls(Type = typeof(BreakDown), Member = "CanStickToGround")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphereNonAlloc")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(BreakDown), Member = "CanStickToGround")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphereNonAlloc")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void StickSurfaceObjectsToGround()
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(BreakDown), Member = "StickToGround")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	private static StickToGround GetStickToGroundInDirectParent(GameObject go)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BreakDown), Member = "StickToGround")]
	[CalledBy(Type = typeof(BreakDown), Member = "StickToGround")]
	[CalledBy(Type = typeof(BreakDown), Member = "RayCastForNearest")]
	[CalledBy(Type = typeof(BreakDown), Member = "SphereCastForNearest")]
	[Calls(Type = typeof(Utils), Member = "IsChild")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	private bool ProcessRaycastResults(GameObject targetObj, float objectTop, int numHits, out RaycastHit hitOut)
	{
		System.Runtime.CompilerServices.Unsafe.As<RaycastHit, @null>(ref hitOut) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Physics), Member = "SphereCastNonAlloc")]
	[Calls(Type = typeof(BreakDown), Member = "ProcessRaycastResults")]
	private bool SphereCastForNearest(GameObject targetObj, Vector3 startPos, float radius, out RaycastHit hitOut)
	{
		System.Runtime.CompilerServices.Unsafe.As<RaycastHit, @null>(ref hitOut) = null;
		return default(bool);
	}

	[Calls(Type = typeof(BreakDown), Member = "ProcessRaycastResults")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool RayCastForNearest(GameObject targetObj, Vector3 startPos, out RaycastHit hitOut)
	{
		System.Runtime.CompilerServices.Unsafe.As<RaycastHit, @null>(ref hitOut) = null;
		return default(bool);
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(BreakDown), Member = "StickSurfaceObjectsToGround")]
	[CalledBy(Type = typeof(BreakDown), Member = "StickSurfaceObjectsToGround")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Physics), Member = "SyncTransforms")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Rigidbody), Member = "ClosestPointOnBounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BreakDown), Member = "ProcessRaycastResults")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 32)]
	[Calls(Type = typeof(BreakDown), Member = "GetStickToGroundInDirectParent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BreakDown), Member = "CanStickToGround")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Physics), Member = "SphereCastNonAlloc")]
	[Calls(Type = typeof(BreakDown), Member = "ProcessRaycastResults")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void StickToGround(GameObject go)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private bool IsGround(GameObject go)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BreakDown), Member = "StickToGround")]
	[CalledBy(Type = typeof(BreakDown), Member = "StickSurfaceObjectsToGround")]
	[CalledBy(Type = typeof(BreakDown), Member = "StickSurfaceObjectsToGround")]
	[CalledBy(Type = typeof(BreakDown), Member = "StickSurfaceObjectsToGround")]
	[Calls(Type = typeof(CookingPotItem), Member = "IsAttachedToGearPlacePoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private bool CanStickToGround(GameObject go)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BreakDown), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void AddAlternateTools()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BreakDown), Member = "RestoreLayerInfos")]
	[CallsUnknownMethods(Count = 6)]
	private LayerInfo GetLayerInfo(Transform transform)
	{
		return default(LayerInfo);
	}

	[CalledBy(Type = typeof(BreakDown), Member = "StickSurfaceObjectsToGround")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	private void SaveLayerInfos(GameObject go)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BreakDown), Member = "GetLayerInfo")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(BreakDown), Member = "StickSurfaceObjectsToGround")]
	[CallsUnknownMethods(Count = 2)]
	private void RestoreLayerInfos(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public BreakDown()
	{
	}
}
