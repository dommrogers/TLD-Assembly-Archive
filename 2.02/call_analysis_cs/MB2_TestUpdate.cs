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
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(Mesh), Member = "get_uv")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 24)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mesh), Member = "get_uv")]
	[Calls(Type = typeof(Mesh), Member = "set_uv")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 36)]
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
