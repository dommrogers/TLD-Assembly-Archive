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

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public StarLineData()
	{
	}
}
