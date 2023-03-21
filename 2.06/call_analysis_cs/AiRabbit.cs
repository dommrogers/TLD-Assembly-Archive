using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AiRabbit : MonoBehaviour
{
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void Start()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public AiRabbit()
	{
	}
}
