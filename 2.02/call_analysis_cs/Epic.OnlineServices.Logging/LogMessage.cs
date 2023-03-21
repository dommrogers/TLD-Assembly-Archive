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
		[CallerCount(Count = 52)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		private set
		{
		}
	}

	public string Message
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
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
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LogMessageInternal), Member = "get_Category")]
	[Calls(Type = typeof(LogMessageInternal), Member = "get_Message")]
	[CallsUnknownMethods(Count = 3)]
	internal void Set(LogMessageInternal? other)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(LogMessageInternal), Member = "get_Category")]
	[Calls(Type = typeof(LogMessageInternal), Member = "get_Message")]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public LogMessage()
	{
	}
}
