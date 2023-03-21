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

	[CalledBy(Type = typeof(PlayerVoice), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ActiveRequest), Member = "Start")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "StartNextRequest")]
	[CalledBy(Type = typeof(NPCVoice), Member = "StartNextRequest")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(PlayerVoice), Member = "MaybeHandleNextQueuedRequest")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	[Conditional("__DEBUG")]
	public void SetEventName(string name)
	{
	}

	[CallerCount(Count = 6)]
	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
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
