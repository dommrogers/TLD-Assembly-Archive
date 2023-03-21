using Cpp2ILInjected.CallAnalysis;
using DigitalOpus.MB.Core;
using UnityEngine;

public class MB3_TestBakeAllWithSameMaterial : MonoBehaviour
{
	public GameObject[] listOfObjsToCombineGood;

	public GameObject[] listOfObjsToCombineBad;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MB3_TestBakeAllWithSameMaterial), Member = "testCombine")]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(MB3_TestBakeAllWithSameMaterial), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(MB3_MultiMeshCombiner), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 16)]
	private void testCombine()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MB3_TestBakeAllWithSameMaterial()
	{
	}
}
