using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RNode : MonoBehaviour
{
	public GameObject[] m_SpawnPrefabs;

	public int[] m_SpawnWeights;

	public int m_PreviewPrefabIndex;

	public GameObject m_PreviewPrefab;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 24)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(Object), Member = "Instantiate")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 26)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public RNode()
	{
	}
}
