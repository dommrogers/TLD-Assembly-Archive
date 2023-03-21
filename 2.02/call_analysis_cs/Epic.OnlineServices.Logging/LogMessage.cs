using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Logging;

public class LogMessage : ISettable
{
	private string _003CCategory_003Ek__BackingField;

	private string _003CMessage_003Ek__BackingField;

	private LogLevel _003CLevel_003Ek__BackingField;

	public string Category
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		private set
		{
		}
	}

	public string Message
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 77)]
		private set
		{
		}
	}

	public LogLevel Level
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return default(LogLevel);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LogMessageInternal), Member = "get_Category")]
	[Calls(Type = typeof(LogMessageInternal), Member = "get_Message")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal void Set(LogMessageInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LogMessageInternal), Member = "get_Category")]
	[Calls(Type = typeof(LogMessageInternal), Member = "get_Message")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public LogMessage()
	{
	}
}
