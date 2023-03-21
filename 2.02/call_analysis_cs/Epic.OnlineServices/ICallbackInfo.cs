using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices;

internal interface ICallbackInfo
{
	object ClientData
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	Result? GetResultCode();
}
