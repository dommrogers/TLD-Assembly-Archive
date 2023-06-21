using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class ArrayIndexes
{
	public int[] indexes;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public ArrayIndexes()
	{
	}
}
