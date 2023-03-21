using System;
using Cpp2ILInjected.CallAnalysis;

namespace UnityAOT;

public interface IWrappedObject
{
	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void SetNativePtr(IntPtr self);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	IntPtr GetNativePtr();
}
