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

	[Calls(Type = typeof(Debug), Member = "Log")]
	[CalledBy(Type = typeof(MB3_TestBakeAllWithSameMaterial), Member = "Start")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(MB3_MultiMeshCombiner), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(MB3_MeshCombinerSingle), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	private void testCombine()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public MB3_TestBakeAllWithSameMaterial()
	{
	}
}
