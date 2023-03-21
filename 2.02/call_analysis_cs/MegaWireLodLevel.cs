using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class MegaWireLodLevel
{
	public float distance;

	public int sides;

	public float segsperunit;

	[CallerCount(Count = 0)]
	public MegaWireLodLevel()
	{
	}
}
