using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BigCarryItem : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public BigCarryItem()
	{
	}
}
