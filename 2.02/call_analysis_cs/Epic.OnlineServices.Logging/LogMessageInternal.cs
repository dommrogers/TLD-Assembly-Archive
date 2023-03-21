using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Logging;

[StructLayout(0, Pack = 8, Size = 24)]
internal struct LogMessageInternal
{
	private IntPtr m_Category;

	private IntPtr m_Message;

	private LogLevel m_Level;

	public string Category
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(LogMessage), Member = "Set")]
		[CalledBy(Type = typeof(LogMessage), Member = "Set")]
		get
		{
			return null;
		}
	}

	public string Message
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalGet")]
		[CalledBy(Type = typeof(LogMessage), Member = "Set")]
		[CalledBy(Type = typeof(LogMessage), Member = "Set")]
		get
		{
			return null;
		}
	}

	public LogLevel Level
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return default(LogLevel);
		}
	}
}
