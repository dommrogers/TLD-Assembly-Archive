using AOT;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkLogger
{
	public delegate void ErrorLoggerInteropDelegate(string message);

	private static AkLogger ms_Instance;

	private ErrorLoggerInteropDelegate errorLoggerDelegate;

	public static AkLogger Instance
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(AkLogger), Member = ".cctor")]
	[CallsUnknownMethods(Count = 9)]
	private AkLogger()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	~AkLogger()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Init()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[AOT.MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static void WwiseInternalLogError(string message)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Message(string message)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Warning(string message)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Error(string message)
	{
	}
}
