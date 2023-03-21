using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class ArrayIndexes
{
	public int[] indexes;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public ArrayIndexes()
	{
	}
}
