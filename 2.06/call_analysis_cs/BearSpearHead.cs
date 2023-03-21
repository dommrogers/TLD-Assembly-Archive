using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BearSpearHead : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public BearSpearHead()
	{
	}
}
