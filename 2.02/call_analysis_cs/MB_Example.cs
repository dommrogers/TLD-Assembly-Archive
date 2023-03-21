using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MB_Example : MonoBehaviour
{
	public MB3_MeshBaker meshbaker;

	public GameObject[] objsToCombine;

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	private void OnGUI()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MB_Example()
	{
	}
}
