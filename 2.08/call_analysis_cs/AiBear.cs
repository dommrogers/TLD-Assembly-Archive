using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AiBear : MonoBehaviour
{
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public AiBear()
	{
	}
}
