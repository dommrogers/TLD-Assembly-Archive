using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VertexPaintedMesh : MonoBehaviour
{
	public string m_PrefabName;

	private Mesh m_Mesh;

	private ObjectGuid m_ObjectGuid;

	private VertexPaintedData m_Data;

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void CreateData(Mesh mesh)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(VertexPaintedData), Member = "SetMesh")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(VertexPaintedMesh), Member = "UpdateMeshReference")]
	[CallsUnknownMethods(Count = 50)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetSceneAt")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	private void LoadData(Mesh mesh)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 29)]
	protected string GetPrefabName()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(VertexPaintedMesh), Member = "LoadData")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateMeshReference()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public VertexPaintedMesh()
	{
	}
}
