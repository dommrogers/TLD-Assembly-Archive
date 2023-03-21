using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RopeItem : MonoBehaviour
{
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void Start()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public RopeItem()
	{
	}
}
