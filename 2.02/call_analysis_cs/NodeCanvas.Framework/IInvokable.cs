using System;
using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public interface IInvokable
{
	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	string GetInvocationID();

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	object Invoke(object[] args);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	void InvokeAsync(Action<object> callback, object[] args);
}
