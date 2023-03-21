using System.IO;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

public static class MB_TGAWriter
{
	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void Write(Color[] pixels, int width, int height, string path)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(BinaryWriter), Member = ".ctor")]
	[CallsUnknownMethods(Count = 35)]
	public static void Write(Color[] pixels, int width, int height, Stream output)
	{
	}
}
