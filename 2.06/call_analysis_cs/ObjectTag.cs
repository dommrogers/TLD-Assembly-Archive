using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ObjectTag : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public ObjectTag()
	{
	}
}
