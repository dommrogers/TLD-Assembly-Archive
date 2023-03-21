using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DynamicAudioObject : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public DynamicAudioObject()
	{
	}
}
