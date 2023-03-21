using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkTerminator : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public AkTerminator()
	{
	}
}
