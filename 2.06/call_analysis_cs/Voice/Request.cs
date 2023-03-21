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

	[CalledBy(Type = typeof(NPCVoice), Member = "StartNextRequest")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "Update")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "MaybeHandleNextQueuedRequest")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "StartNextRequest")]
	[CalledBy(Type = typeof(ActiveRequest), Member = "Start")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public void Copy(Request other)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsOptionSet(uint option)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsValid()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint), Member = "ToString")]
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
