using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 10)]
	public void ProcessExclusionList()
	{
	}

	[Calls(Type = typeof(HexSector), Member = "SectorError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(HexSectorManager), Member = "UpdateSectors")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HexSector), Member = "SectorError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(LODGroup), Member = "ForceLOD")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(LODGroup), Member = "get_lodCount")]
	public void SetOnlyLOD(SectorLOD newLOD)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(HexSector), Member = "SectorError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(HexSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(HexSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(HexSector), Member = "SectorError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LODGroup), Member = "get_lodCount")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(HexSector), Member = "SectorError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(LODGroup), Member = "ForceLOD")]
	public void SetSectorLOD(SectorLOD newLOD)
	{
	}

	[Calls(Type = typeof(HexSector), Member = "IsScene_CurrentlyLoaded")]
	[CalledBy(Type = typeof(HexSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(HexSectorManager), Member = "UpdateSectors")]
	[CalledBy(Type = typeof(HexSectorManager), Member = "UpdateSectors")]
	[Calls(Type = typeof(HexSector), Member = "IsScene_CurrentlyLoaded")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "UnloadSceneAsync")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "LoadSceneAsync")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "UnloadSceneAsync")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "LoadSceneAsync")]
	[Calls(Type = typeof(HexSector), Member = "IsScene_CurrentlyLoaded")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "UnloadSceneAsync")]
	[Calls(Type = typeof(HexSector), Member = "IsScene_CurrentlyLoaded")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HexSector), Member = "IsScene_CurrentlyLoaded")]
	public void SetScene(SectorLOD newLOD)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(HexSector), Member = "SetScene")]
	[CalledBy(Type = typeof(HexSector), Member = "SetScene")]
	[CalledBy(Type = typeof(HexSector), Member = "SetScene")]
	[CalledBy(Type = typeof(HexSector), Member = "SetScene")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetSceneAt")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(HexSector), Member = "SetScene")]
	private bool IsScene_CurrentlyLoaded(string sceneName_no_extention)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(HexSector), Member = "SetSectorLOD")]
	[CalledBy(Type = typeof(HexSector), Member = "SetSectorLOD")]
	[CalledBy(Type = typeof(HexSector), Member = "SetSectorLOD")]
	[CalledBy(Type = typeof(HexSector), Member = "SetOnlyLOD")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(HexSector), Member = "SetOnlyLOD")]
	private void SectorError(string sectorName, int objIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public HexSector()
	{
	}
}
