using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MB2_TestUpdate : MonoBehaviour
{
	public MB3_MeshBaker meshbaker;

	public MB3_MultiMeshBaker multiMeshBaker;

	public GameObject[] objsToMove;

	public GameObject objWithChangingUVs;

	private Vector2[] uvs;

	private Mesh m;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Mesh), Member = "get_uv")]
	[Calls(Type = typeof(Mesh), Member = "get_uv")]
	[CallsUnknownMethods(Count = 24)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Mesh), Member = "set_uv")]
	[CallsUnknownMethods(Count = 36)]
	[Calls(Type = typeof(Mesh), Member = "get_uv")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "get_uv")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Mesh), Member = "set_uv")]
	private void LateUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MB2_TestUpdate()
	{
	}
}
