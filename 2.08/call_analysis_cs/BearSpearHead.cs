using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BearSpearHead : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public BearSpearHead()
	{
	}
}
