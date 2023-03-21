using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class ArrayIndexes
{
	public int[] indexes;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public ArrayIndexes()
	{
	}
}
