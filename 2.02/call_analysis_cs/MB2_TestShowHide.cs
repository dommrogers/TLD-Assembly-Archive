using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MB2_TestShowHide : MonoBehaviour
{
	public MB3_MeshBaker mb;

	public GameObject[] objs;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MB2_TestShowHide()
	{
	}
}
