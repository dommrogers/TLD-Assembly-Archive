using System;
using System.Globalization;
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
	[CalledBy(Type = typeof(PlayerVoice), Member = "MaybeHandleNextQueuedRequest")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "StartNextRequest")]
	[CalledBy(Type = typeof(ActiveRequest), Member = "Start")]
	[CallerCount(Count = 4)]
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
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatUInt32")]
	public string GetEventName()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public TimeSpan GetTimestamp()
	{
		return default(TimeSpan);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void SetEventName(string name)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void SetTimestamp()
	{
	}

	[CallerCount(Count = 0)]
	public virtual void Reset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public Request()
	{
	}
}
