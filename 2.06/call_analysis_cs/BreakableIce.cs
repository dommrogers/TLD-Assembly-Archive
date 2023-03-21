using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
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
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(BreakableIce), Member = "InitializeBrokenIceTexture")]
	[Calls(Type = typeof(BreakableIce), Member = "InitializeAudioEmitters")]
	[Calls(Type = typeof(BreakableIce), Member = "InitializeNavmeshCuts")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[Calls(Type = typeof(Shader), Member = "SetGlobalVectorArray")]
	[Calls(Type = typeof(BreakableIce), Member = "UpdateAudioEmitters")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(IceCrackingManager), Member = "FindNearestFallTrigger")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(IceCrackingTrigger), Member = "FallInWater")]
	[Calls(Type = typeof(BreakableIce), Member = "RemoveOldestBrokenIce")]
	[Calls(Type = typeof(BitmaskTexture), Member = "ApplyChanges")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(BreakableIce), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(BreakableIce), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(BreakableIce), Member = "AddBrokenIceToTexture")]
	[Calls(Type = typeof(BreakableIce), Member = "AddBrokenIceToNavmeshCuts")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public void Deserialize(BreakableIceComponentSaveDataProxy proxy)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BreakableIce), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 10)]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(BreakableIce), Member = "FindBreakableIceByPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BreakableIce), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	public static void DeserializeAll(string text)
	{
	}

	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "BreakIce")]
	[CalledBy(Type = typeof(WetZoneTrigger), Member = "BreakIce")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(BreakableIce), Member = "AddBrokenIceToTexture")]
	[Calls(Type = typeof(BreakableIce), Member = "AddBrokenIceToNavmeshCuts")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(BreakableIce), Member = "RemoveOldestBrokenIce")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphere")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "DropIntoWater")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Fire), Member = "TurnOff")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 9)]
	public void BreakIce(Vector3 pos, float radius)
	{
	}

	[CalledBy(Type = typeof(FlareItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(TorchItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(BreakableIce), Member = "BreakIce")]
	[CalledBy(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[CalledBy(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(BreakableIce), Member = "GetVoronoiPointSet")]
	[Calls(Type = typeof(VoronoiPointSet), Member = "ComputeNearestPointIndex")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public bool IsIceBroken(Vector3 position)
	{
		return false;
	}

	[CalledBy(Type = typeof(GearItem), Member = "MaybeFallIntoWater")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceIsOnBrokenIce")]
	[CalledBy(Type = typeof(BreakableIce), Member = "Update")]
	[CalledBy(Type = typeof(BreakableIce), Member = "BreakIce")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	public bool IsIceBroken(Vector3 position, float radius)
	{
		return false;
	}

	[CalledBy(Type = typeof(IceCrackingManager), Member = "GetRespawnLocation")]
	[CalledBy(Type = typeof(IceCrackingManager), Member = "UpdateTrackLocation")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsInDangerOfFallingIn(Vector3 position)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(BreakableIce), Member = "Deserialize")]
	[CalledBy(Type = typeof(BreakableIce), Member = "BreakIce")]
	[CalledBy(Type = typeof(BreakableIce), Member = "InitializeNavmeshCuts")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NavMeshObstacle), Member = "set_radius")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void AddBrokenIceToNavmeshCuts(int index)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(BreakableIce), Member = "Deserialize")]
	[CalledBy(Type = typeof(BreakableIce), Member = "BreakIce")]
	[CallerCount(Count = 2)]
	private void AddBrokenIceToTexture(int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BreakableIce), Member = "GetVoronoiPointSet")]
	[Calls(Type = typeof(VoronoiPointSet), Member = "ComputeNearestPointIndex")]
	[CallsUnknownMethods(Count = 4)]
	private void AddBrokenIceToTexture(Vector2 position)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(BreakableIce), Member = "RemoveOldestBrokenIce")]
	[CallerCount(Count = 1)]
	private void RemoveBrokenIceFromTexture(int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BreakableIce), Member = "GetVoronoiPointSet")]
	[Calls(Type = typeof(VoronoiPointSet), Member = "ComputeNearestPointIndex")]
	[CallsUnknownMethods(Count = 4)]
	private void RemoveBrokenIceFromTexture(Vector2 position)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private BrokenIce GetOldestBrokenIce()
	{
		return default(BrokenIce);
	}

	[CalledBy(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[CalledBy(Type = typeof(BreakableIce), Member = "AddBrokenIceToTexture")]
	[CalledBy(Type = typeof(BreakableIce), Member = "RemoveBrokenIceFromTexture")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private VoronoiPointSet GetVoronoiPointSet(Vector2 tile)
	{
		return null;
	}

	[CalledBy(Type = typeof(BreakableIce), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	private void InitializeAudioEmitters()
	{
	}

	[CalledBy(Type = typeof(BreakableIce), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitmaskTexture), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	private void InitializeBrokenIceTexture()
	{
	}

	[CalledBy(Type = typeof(BreakableIce), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(BreakableIce), Member = "AddBrokenIceToNavmeshCuts")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 17)]
	private void InitializeNavmeshCuts()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void InitializeShaderProperties()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BreakableIce), Member = "RemoveOldestBrokenIce")]
	[CallsUnknownMethods(Count = 2)]
	private void RemoveExpiredBrokenIce()
	{
	}

	[CalledBy(Type = typeof(BreakableIce), Member = "Update")]
	[CalledBy(Type = typeof(BreakableIce), Member = "BreakIce")]
	[CalledBy(Type = typeof(BreakableIce), Member = "RemoveExpiredBrokenIce")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BreakableIce), Member = "RemoveBrokenIceFromTexture")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void RemoveOldestBrokenIce()
	{
	}

	[CalledBy(Type = typeof(BreakableIce), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateAudioEmitters(Vector3 listenerPosition)
	{
	}

	[CalledBy(Type = typeof(BreakableIce), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private static BreakableIce FindBreakableIceByPosition(Vector3 pos)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public BreakableIce()
	{
	}
}
