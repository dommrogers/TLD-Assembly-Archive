using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace UnityAOT;

public class GCSys<T>
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static IntPtr SetupHandle(ref GCHandle handle, T obj)
	{
		return default(IntPtr);
	}

	[Calls(Type = typeof(GCHandle), Member = "Free")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static void FreeHandle(ref GCHandle handle)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public GCSys()
	{
	}
}
