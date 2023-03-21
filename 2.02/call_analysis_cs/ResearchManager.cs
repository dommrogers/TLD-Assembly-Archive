using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ResearchManager : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private void Update()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ResearchManager()
	{
	}
}
