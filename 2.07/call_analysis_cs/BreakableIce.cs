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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(BreakableIce), Member = "InitializeNavmeshCuts")]
	[Calls(Type = typeof(BreakableIce), Member = "InitializeAudioEmitters")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(BreakableIce), Member = "InitializeBrokenIceTexture")]
	private void Start()
	{
	}

	[Calls(Type = typeof(IceCrackingTrigger), Member = "FallInWater")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(BitmaskTexture), Member = "ApplyChanges")]
	[Calls(Type = typeof(BreakableIce), Member = "RemoveOldestBrokenIce")]
	[Calls(Type = typeof(IceCrackingManager), Member = "FindNearestFallTrigger")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(BreakableIce), Member = "UpdateAudioEmitters")]
	[Calls(Type = typeof(Shader), Member = "SetGlobalVectorArray")]
	[Calls(Type = typeof(Array), Member = "CopyTo")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnEnable()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(BreakableIce), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 5)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(BreakableIce), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BreakableIce), Member = "AddBrokenIceToTexture")]
	[Calls(Type = typeof(BreakableIce), Member = "AddBrokenIceToNavmeshCuts")]
	[CallerCount(Count = 1)]
	public void Deserialize(BreakableIceComponentSaveDataProxy proxy)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BreakableIce), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 6)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(BreakableIce), Member = "Deserialize")]
	[Calls(Type = typeof(BreakableIce), Member = "FindBreakableIceByPosition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public static void DeserializeAll(string text)
	{
	}

	[CalledBy(Type = typeof(WetZoneTrigger), Member = "BreakIce")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "BreakIce")]
	[Calls(Type = typeof(Fire), Member = "TurnOff")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GearItem), Member = "DropIntoWater")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BreakableIce), Member = "AddBrokenIceToNavmeshCuts")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphere")]
	[Calls(Type = typeof(BreakableIce), Member = "RemoveOldestBrokenIce")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(BreakableIce), Member = "AddBrokenIceToTexture")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	public void BreakIce(Vector3 pos, float radius)
	{
	}

	[CalledBy(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	[CalledBy(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[CalledBy(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[CalledBy(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[CalledBy(Type = typeof(BreakableIce), Member = "BreakIce")]
	[CalledBy(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "OnCollisionEnter")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BreakableIce), Member = "GetVoronoiPointSet")]
	[CalledBy(Type = typeof(TorchItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(FlareItem), Member = "OnCollisionEnter")]
	[Calls(Type = typeof(VoronoiPointSet), Member = "ComputeNearestPointIndex")]
	public bool IsIceBroken(Vector3 position)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BreakableIce), Member = "BreakIce")]
	[CalledBy(Type = typeof(BreakableIce), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceIsOnBrokenIce")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeFallIntoWater")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	public bool IsIceBroken(Vector3 position, float radius)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(IceCrackingManager), Member = "GetRespawnLocation")]
	[CalledBy(Type = typeof(IceCrackingManager), Member = "UpdateTrackLocation")]
	public bool IsInDangerOfFallingIn(Vector3 position)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BreakableIce), Member = "InitializeNavmeshCuts")]
	[CalledBy(Type = typeof(BreakableIce), Member = "BreakIce")]
	[CalledBy(Type = typeof(BreakableIce), Member = "Deserialize")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(NavMeshObstacle), Member = "set_radius")]
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
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(BreakableIce), Member = "RemoveOldestBrokenIce")]
	private void RemoveBrokenIceFromTexture(int index)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(VoronoiPointSet), Member = "ComputeNearestPointIndex")]
	[Calls(Type = typeof(BreakableIce), Member = "GetVoronoiPointSet")]
	[CallerCount(Count = 0)]
	private void RemoveBrokenIceFromTexture(Vector2 position)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private BrokenIce GetOldestBrokenIce()
	{
		return default(BrokenIce);
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[CalledBy(Type = typeof(BreakableIce), Member = "AddBrokenIceToTexture")]
	[CalledBy(Type = typeof(BreakableIce), Member = "RemoveBrokenIceFromTexture")]
	[CallsUnknownMethods(Count = 4)]
	private VoronoiPointSet GetVoronoiPointSet(Vector2 tile)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(BreakableIce), Member = "Start")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private void InitializeAudioEmitters()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(BitmaskTexture), Member = ".ctor")]
	[CalledBy(Type = typeof(BreakableIce), Member = "Start")]
	[CallsUnknownMethods(Count = 8)]
	private void InitializeBrokenIceTexture()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(BreakableIce), Member = "Start")]
	[Calls(Type = typeof(BreakableIce), Member = "AddBrokenIceToNavmeshCuts")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
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

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(BreakableIce), Member = "RemoveExpiredBrokenIce")]
	[CalledBy(Type = typeof(BreakableIce), Member = "BreakIce")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BreakableIce), Member = "RemoveBrokenIceFromTexture")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(BreakableIce), Member = "Update")]
	private void RemoveOldestBrokenIce()
	{
	}

	[CalledBy(Type = typeof(BreakableIce), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateAudioEmitters(Vector3 listenerPosition)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(BreakableIce), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private static BreakableIce FindBreakableIceByPosition(Vector3 pos)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public BreakableIce()
	{
	}
}
