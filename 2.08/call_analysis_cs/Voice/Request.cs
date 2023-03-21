using System;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;

namespace Voice;

public class Request
{
	public Action m_CompletionCallback;

	public uint m_EventID;

	public uint m_Options;

	public Priority m_Priority;

	public float m_Timeout;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Copy(Request other)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsOptionSet(uint option)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsValid()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public string GetEventName()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public TimeSpan GetTimestamp()
	{
		return default(TimeSpan);
	}

	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void SetEventName(string name)
	{
	}

	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void SetTimestamp()
	{
	}

	[CallerCount(Count = 0)]
	public virtual void Reset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public Request()
	{
	}
}
