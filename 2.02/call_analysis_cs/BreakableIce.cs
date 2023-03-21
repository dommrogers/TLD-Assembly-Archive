using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.AI;

public class BreakableIce : MonoBehaviour
{
	private struct BrokenIce
	{
		public Vector2 m_Position;

		public float m_Radius;

		public float m_PlacementDay;
	}

	private const int MAX_BROKEN_ICE_DATA = 100;

	private const int MAX_VORONOI_POINT_SETS_X = 1;

	private const int MAX_VORONOI_POINT_SETS_Y = 1;

	private const int MAX_VORONOI_POINT_SETS = 1;

	private float m_RefreezeDays;

	private float m_FallInDistance;

	private string m_BrokenIceAudioId;

	private int m_EmitterCount;

	private float m_NavmeshCutScale;

	private int m_TileSize;

	private float m_IceBreakScale;

	private VoronoiPointSet[] m_VoronoiPointSets;

	private Terrain m_Terrain;

	private int m_BrokenIceTextureId;

	private int m_RenderTargetExtentsId;

	private int m_TileSizeId;

	private int m_VoronoiPointSetsId;

	private BrokenIce[] m_BrokenIceData;

	private int m_BrokenIceDataWriteIndex;

	private int m_BrokenIceDataRemoveIndex;

	private BitmaskTexture m_BrokenIceTexture;

	private Vector4[] m_VoronoiPointsSetsForShader;

	private GameObject[] m_AudioEmitters;

	private float[] m_NearestEmitterDistances;

	private NavMeshObstacle[] m_NavMeshObstacles;

	private static BreakableIceComponentSaveDataProxy m_BreakableIceComponentSaveDataProxy;

	private static BrokenIceSaveDataProxy m_BrokenIceSaveDataProxy;

	private static List<BreakableIce> m_Instances;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(BreakableIce), Member = "InitializeBrokenIceTexture")]
	[Calls(Type = typeof(BreakableIce), Member = "InitializeAudioEmitters")]
	[Calls(Type = typeof(BreakableIce), Member = "InitializeNavmeshCuts")]
	[CallsUnknownMethods(Count = 4)]
	private void Start()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(BitmaskTexture), Member = "ApplyChanges")]
	[Calls(Type = typeof(BreakableIce), Member = "RemoveExpiredBrokenIce")]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(IceCrackingTrigger), Member = "FallInWater")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(BreakableIce), Member = "UpdateAudioEmitters")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IceCrackingManager), Member = "FindNearestFallTrigger")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnable()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(BreakableIce), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 17)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(BreakableIce), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BreakableIce), Member = "AddBrokenIceToNavmeshCuts")]
	[Calls(Type = typeof(BreakableIce), Member = "AddBrokenIceToTexture")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public void Deserialize(BreakableIceComponentSaveDataProxy proxy)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BreakableIce), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 16)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(BreakableIce), Member = "Deserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(BreakableIce), Member = "FindBreakableIceByPosition")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	public static void DeserializeAll(string text)
	{
	}

	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(WetZoneTrigger), Member = "BreakIce")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "BreakIce")]
	[Calls(Type = typeof(Bounds), Member = "get_size")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Fire), Member = "TurnOff")]
	[Calls(Type = typeof(Campfire), Member = "SetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItem), Member = "DropIntoWater")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphere")]
	[Calls(Type = typeof(BreakableIce), Member = "RemoveOldestBrokenIce")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(BreakableIce), Member = "AddBrokenIceToNavmeshCuts")]
	[Calls(Type = typeof(BreakableIce), Member = "AddBrokenIceToTexture")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 2)]
	public void BreakIce(Vector3 pos, float radius)
	{
	}

	[CalledBy(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[CalledBy(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[CalledBy(Type = typeof(FlareItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	[CalledBy(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[CalledBy(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[CalledBy(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(BreakableIce), Member = "GetVoronoiPointSet")]
	[CalledBy(Type = typeof(TorchItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "OnCollisionEnter")]
	[Calls(Type = typeof(VoronoiPointSet), Member = "ComputeNearestPointIndex")]
	[CallsUnknownMethods(Count = 14)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(BreakableIce), Member = "BreakIce")]
	public bool IsIceBroken(Vector3 position)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceIsOnBrokenIce")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeFallIntoWater")]
	[CalledBy(Type = typeof(BreakableIce), Member = "BreakIce")]
	[CalledBy(Type = typeof(BreakableIce), Member = "Update")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[CallerCount(Count = 4)]
	public bool IsIceBroken(Vector3 position, float radius)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(IceCrackingManager), Member = "GetRespawnLocation")]
	[CalledBy(Type = typeof(IceCrackingManager), Member = "UpdateTrackLocation")]
	[CallsUnknownMethods(Count = 4)]
	public bool IsInDangerOfFallingIn(Vector3 position)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NavMeshObstacle), Member = "set_radius")]
	[CalledBy(Type = typeof(BreakableIce), Member = "Deserialize")]
	[CalledBy(Type = typeof(BreakableIce), Member = "BreakIce")]
	[CalledBy(Type = typeof(BreakableIce), Member = "InitializeNavmeshCuts")]
	[CallsUnknownMethods(Count = 12)]
	private void AddBrokenIceToNavmeshCuts(int index)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BreakableIce), Member = "Deserialize")]
	[CalledBy(Type = typeof(BreakableIce), Member = "BreakIce")]
	private void AddBrokenIceToTexture(int index)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(VoronoiPointSet), Member = "ComputeNearestPointIndex")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BreakableIce), Member = "GetVoronoiPointSet")]
	private void AddBrokenIceToTexture(Vector2 position)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BreakableIce), Member = "RemoveOldestBrokenIce")]
	private void RemoveBrokenIceFromTexture(int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BreakableIce), Member = "GetVoronoiPointSet")]
	[Calls(Type = typeof(VoronoiPointSet), Member = "ComputeNearestPointIndex")]
	[CallsUnknownMethods(Count = 11)]
	private void RemoveBrokenIceFromTexture(Vector2 position)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private BrokenIce GetOldestBrokenIce()
	{
		return default(BrokenIce);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Mathf), Member = "Abs")]
	[CalledBy(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[CalledBy(Type = typeof(BreakableIce), Member = "AddBrokenIceToTexture")]
	[CalledBy(Type = typeof(BreakableIce), Member = "RemoveBrokenIceFromTexture")]
	[CallsUnknownMethods(Count = 3)]
	private VoronoiPointSet GetVoronoiPointSet(Vector2 tile)
	{
		return null;
	}

	[CalledBy(Type = typeof(BreakableIce), Member = "Start")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void InitializeAudioEmitters()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(BitmaskTexture), Member = ".ctor")]
	[CalledBy(Type = typeof(BreakableIce), Member = "Start")]
	[CallsUnknownMethods(Count = 19)]
	private void InitializeBrokenIceTexture()
	{
	}

	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(BreakableIce), Member = "Start")]
	[Calls(Type = typeof(BreakableIce), Member = "AddBrokenIceToNavmeshCuts")]
	[Calls(Type = typeof(NavMeshObstacle), Member = "set_radius")]
	[Calls(Type = typeof(NavMeshObstacle), Member = "set_height")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	private void InitializeNavmeshCuts()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	private void InitializeShaderProperties()
	{
	}

	[CalledBy(Type = typeof(BreakableIce), Member = "Update")]
	[Calls(Type = typeof(BreakableIce), Member = "RemoveOldestBrokenIce")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void RemoveExpiredBrokenIce()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BreakableIce), Member = "RemoveBrokenIceFromTexture")]
	[CalledBy(Type = typeof(BreakableIce), Member = "BreakIce")]
	[CalledBy(Type = typeof(BreakableIce), Member = "RemoveExpiredBrokenIce")]
	[CallsUnknownMethods(Count = 6)]
	private void RemoveOldestBrokenIce()
	{
	}

	[CallsUnknownMethods(Count = 26)]
	[CalledBy(Type = typeof(BreakableIce), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector2), Member = "get_up")]
	[Calls(Type = typeof(Vector2), Member = "get_magnitude")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector2), Member = "get_up")]
	private void UpdateAudioEmitters(Vector3 listenerPosition)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(BreakableIce), Member = "DeserializeAll")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	private static BreakableIce FindBreakableIceByPosition(Vector3 pos)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public BreakableIce()
	{
	}
}
