using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RopeItem : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public RopeItem()
	{
	}
}
