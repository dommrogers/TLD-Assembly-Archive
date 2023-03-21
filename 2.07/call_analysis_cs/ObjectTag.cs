using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ObjectTag : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ObjectTag()
	{
	}
}
