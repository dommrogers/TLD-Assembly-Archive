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
	[CallerCount(Count = 7)]
	private void CreateData(Mesh mesh)
	{
	}

	[CalledBy(Type = typeof(VertexPaintedMesh), Member = "UpdateMeshReference")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetSceneAt")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(VertexPaintedData), Member = "SetMesh")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 50)]
	private void LoadData(Mesh mesh)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 35)]
	protected string GetPrefabName()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(VertexPaintedMesh), Member = "LoadData")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateMeshReference()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public VertexPaintedMesh()
	{
	}
}
