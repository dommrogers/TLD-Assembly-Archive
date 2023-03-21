using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AiRabbit : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AiRabbit()
	{
	}
}
