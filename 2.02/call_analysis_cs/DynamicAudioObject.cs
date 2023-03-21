using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DynamicAudioObject : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public DynamicAudioObject()
	{
	}
}
