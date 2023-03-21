using System;
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

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public void ProcessExclusionList()
	{
	}

	[CalledBy(Type = typeof(HexSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(HexSector), Member = "SectorError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(HexSector), Member = "SectorError")]
	[Calls(Type = typeof(LODGroup), Member = "get_lodCount")]
	[Calls(Type = typeof(LODGroup), Member = "ForceLOD")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void SetOnlyLOD(SectorLOD newLOD)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(HexSector), Member = "SectorError")]
	[CalledBy(Type = typeof(HexSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(HexSectorManager), Member = "UpdateSectors")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(HexSector), Member = "SectorError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(HexSector), Member = "SectorError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(LODGroup), Member = "ForceLOD")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(LODGroup), Member = "get_lodCount")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	public void SetSectorLOD(SectorLOD newLOD)
	{
	}

	[CalledBy(Type = typeof(HexSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(HexSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(HexSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(HexSector), Member = "IsScene_CurrentlyLoaded")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "UnloadSceneAsync")]
	[Calls(Type = typeof(HexSector), Member = "IsScene_CurrentlyLoaded")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "UnloadSceneAsync")]
	[Calls(Type = typeof(HexSector), Member = "IsScene_CurrentlyLoaded")]
	[Calls(Type = typeof(Addressables), Member = "LoadSceneAsync")]
	[Calls(Type = typeof(HexSector), Member = "IsScene_CurrentlyLoaded")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "UnloadSceneAsync")]
	[Calls(Type = typeof(HexSector), Member = "IsScene_CurrentlyLoaded")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Addressables), Member = "LoadSceneAsync")]
	public void SetScene(SectorLOD newLOD)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(HexSector), Member = "SetScene")]
	[CalledBy(Type = typeof(HexSector), Member = "SetScene")]
	[CalledBy(Type = typeof(HexSector), Member = "SetScene")]
	[CalledBy(Type = typeof(HexSector), Member = "SetScene")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetSceneAt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(HexSector), Member = "SetScene")]
	private bool IsScene_CurrentlyLoaded(string sceneName_no_extention)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(HexSector), Member = "SetSectorLOD")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(HexSector), Member = "SetOnlyLOD")]
	[CalledBy(Type = typeof(HexSector), Member = "SetOnlyLOD")]
	[CalledBy(Type = typeof(HexSector), Member = "SetSectorLOD")]
	[CalledBy(Type = typeof(HexSector), Member = "SetSectorLOD")]
	[CallsUnknownMethods(Count = 9)]
	private void SectorError(string sectorName, int objIndex)
	{
	}

	[CallerCount(Count = 0)]
	public HexSector()
	{
	}
}
