using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ResearchManager : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
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
	public ResearchManager()
	{
	}
}
