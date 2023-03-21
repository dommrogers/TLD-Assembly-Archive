using System;
using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public interface IInvokable
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	string GetInvocationID();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	object Invoke(object[] args);

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	void InvokeAsync(Action<object> callback, object[] args);
}
