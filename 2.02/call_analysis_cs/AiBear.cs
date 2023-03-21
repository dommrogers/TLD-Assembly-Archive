using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AiBear : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public AiBear()
	{
	}
}
