using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BigCarryItem : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public BigCarryItem()
	{
	}
}
