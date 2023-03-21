using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class ArrayIndexes
{
	public int[] indexes;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public ArrayIndexes()
	{
	}
}
