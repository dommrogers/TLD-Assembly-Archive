using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;

public class HexSector : MonoBehaviour
{
	public enum SectorLOD
	{
		Unininitialized = -2,
		Empty,
		LOD0,
		LOD1,
		LOD2,
		Vista,
		Culled
	}

	public List<GameObject> m_GameObjects;

	public GameObject m_VistaObject;

	public List<HexSectorDef> m_SectorDefinitionList;

	public List<HexSector> m_ExclusionList;

	public string m_SectorScene;

	public string m_SectorVista;

	public int m_MaxSectorsPerFrame;

	private SectorLOD m_CurLod;

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void ProcessExclusionList()
	{
	}

	[CalledBy(Type = typeof(HexSectorManager), Member = "UpdateSectors")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LODGroup), Member = "get_lodCount")]
	[Calls(Type = typeof(LODGroup), Member = "ForceLOD")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(HexSector), Member = "SectorError")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void SetOnlyLOD(SectorLOD newLOD)
	{
	}

	[CalledBy(Type = typeof(HexSectorManager), Member = "UpdateSectors")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LODGroup), Member = "get_lodCount")]
	[Calls(Type = typeof(LODGroup), Member = "ForceLOD")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(HexSector), Member = "SectorError")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	public void SetSectorLOD(SectorLOD newLOD)
	{
	}

	[CalledBy(Type = typeof(HexSectorManager), Member = "UpdateSectors")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HexSector), Member = "IsScene_CurrentlyLoaded")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "UnloadSceneAsync")]
	[Calls(Type = typeof(Addressables), Member = "LoadSceneAsync")]
	public void SetScene(SectorLOD newLOD)
	{
	}

	[CalledBy(Type = typeof(HexSector), Member = "SetScene")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetSceneAt")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsScene_CurrentlyLoaded(string sceneName_no_extention)
	{
		return false;
	}

	[CalledBy(Type = typeof(HexSector), Member = "SetOnlyLOD")]
	[CalledBy(Type = typeof(HexSector), Member = "SetSectorLOD")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsUnknownMethods(Count = 9)]
	private void SectorError(string sectorName, int objIndex)
	{
	}

	[CallerCount(Count = 0)]
	public HexSector()
	{
	}
}
