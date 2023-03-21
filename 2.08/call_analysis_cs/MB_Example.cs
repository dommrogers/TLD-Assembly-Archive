using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MB_Example : MonoBehaviour
{
	public MB3_MeshBaker meshbaker;

	public GameObject[] objsToCombine;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	private void OnGUI()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public MB_Example()
	{
	}
}
