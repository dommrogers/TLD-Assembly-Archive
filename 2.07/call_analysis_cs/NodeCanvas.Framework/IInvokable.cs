using System;

namespace NodeCanvas.Framework;

public interface IInvokable
{
	string GetInvocationID();

	object Invoke(object[] args);

	void InvokeAsync(Action<object> callback, object[] args);
}
