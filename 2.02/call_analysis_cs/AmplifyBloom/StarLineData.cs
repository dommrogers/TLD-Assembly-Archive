using System;
using Cpp2ILInjected.CallAnalysis;

namespace AmplifyBloom;

[Serializable]
public class StarLineData
{
	internal int PassCount;

	internal float SampleLength;

	internal float Attenuation;

	internal float Inclination;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public StarLineData()
	{
	}
}
