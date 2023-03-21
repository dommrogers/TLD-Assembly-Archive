using System;
using System.Diagnostics;
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

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(NPCVoice), Member = "StartNextRequest")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "MaybeHandleNextQueuedRequest")]
	[CalledBy(Type = typeof(PlayerVoice), Member = "StartNextRequest")]
	[CalledBy(Type = typeof(ActiveRequest), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
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

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatUInt32")]
	[CallerCount(Count = 0)]
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

	[Conditional(/*Could not decode attribute arguments.*/)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void SetEventName(string name)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void SetTimestamp()
	{
	}

	[CallerCount(Count = 0)]
	public virtual void Reset()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public Request()
	{
	}
}
