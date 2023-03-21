using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RopeItem : MonoBehaviour
{
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public RopeItem()
	{
	}
}
