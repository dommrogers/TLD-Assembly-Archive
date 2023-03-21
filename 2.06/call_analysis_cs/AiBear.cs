using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AiBear : MonoBehaviour
{
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public AiBear()
	{
	}
}
