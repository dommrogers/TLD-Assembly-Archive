using System;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices;

internal interface ICallbackInfoInternal
{
	IntPtr ClientDataAddress
	{
		[CallerCount(Count = 121780)]
		[DeduplicatedMethod]
		get;
	}
}
