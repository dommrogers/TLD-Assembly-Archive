using System;
using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.Framework;

public interface IInvokable
{
	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	string GetInvocationID();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	object Invoke(object[] args);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	void InvokeAsync(Action<object> callback, object[] args);
}
