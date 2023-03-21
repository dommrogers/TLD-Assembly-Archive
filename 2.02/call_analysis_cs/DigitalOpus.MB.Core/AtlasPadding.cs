using System;
using Cpp2ILInjected.CallAnalysis;

namespace DigitalOpus.MB.Core;

[Serializable]
public struct AtlasPadding
{
	public int topBottom;

	public int leftRight;

	[CallerCount(Count = 0)]
	public AtlasPadding(int p)
	{
	}

	[CallerCount(Count = 0)]
	public AtlasPadding(int px, int py)
	{
	}
}
