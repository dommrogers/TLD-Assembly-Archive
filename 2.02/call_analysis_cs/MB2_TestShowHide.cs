using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MB2_TestShowHide : MonoBehaviour
{
	public MB3_MeshBaker mb;

	public GameObject[] objs;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 6)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public MB2_TestShowHide()
	{
	}
}
