using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace UnityAOT;

public class GCSys<T>
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = ".ctor")]
	public static IntPtr SetupHandle(ref GCHandle handle, T obj)
	{
		return (IntPtr)0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static void FreeHandle(ref GCHandle handle)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public GCSys()
	{
	}
}
