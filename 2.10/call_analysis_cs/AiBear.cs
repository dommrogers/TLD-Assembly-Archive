using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AiBear : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AiBear()
	{
	}
}
