using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BigCarryItem : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public BigCarryItem()
	{
	}
}
