using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DynamicAudioObject : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public DynamicAudioObject()
	{
	}
}
