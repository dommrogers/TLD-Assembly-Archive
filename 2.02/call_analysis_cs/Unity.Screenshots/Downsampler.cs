using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Unity.Screenshots;

public static class Downsampler
{
	[CallsUnknownMethods(Count = 79)]
	[CalledBy(Type = typeof(ScreenshotRecorder.ScreenshotOperation), Member = "EncodeCallback")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	public static byte[] Downsample(byte[] dataRgba, int stride, int maximumWidth, int maximumHeight, out int downsampledStride)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref downsampledStride) = null;
		return null;
	}
}
