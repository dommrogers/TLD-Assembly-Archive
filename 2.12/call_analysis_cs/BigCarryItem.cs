using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BigCarryItem : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BigCarryItem()
	{
	}
}
