using System;
using Cpp2ILInjected.CallAnalysis;

namespace Unity.Screenshots;

public static class Downsampler
{
	[CalledBy(TypeFullName = "Unity.Screenshots.ScreenshotRecorder.ScreenshotOperation", Member = "EncodeCallback")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 79)]
	public static byte[] Downsample(byte[] dataRgba, int stride, int maximumWidth, int maximumHeight, out int downsampledStride)
	{
		downsampledStride = default(int);
		return null;
	}
}
