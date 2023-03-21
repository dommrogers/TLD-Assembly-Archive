using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkMonitoringCallbackInfo : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public AkMonitorErrorCode errorCode
	{
		[CalledBy(Type = typeof(AkCallbackManager), Member = "PostCallbacks")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(AkMonitorErrorCode);
		}
	}

	public AkMonitorErrorLevel errorLevel
	{
		[CalledBy(Type = typeof(AkCallbackManager), Member = "PostCallbacks")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(AkMonitorErrorLevel);
		}
	}

	public uint playingID
	{
		[CalledBy(Type = typeof(AkCallbackManager), Member = "PostCallbacks")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0u;
		}
	}

	public ulong gameObjID
	{
		[CalledBy(Type = typeof(AkCallbackManager), Member = "PostCallbacks")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0uL;
		}
	}

	public string message
	{
		[CalledBy(Type = typeof(AkCallbackManager), Member = "PostCallbacks")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(AkSoundEngine), Member = "StringFromIntPtrOSString")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal AkMonitoringCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkMonitoringCallbackInfo obj)
	{
		return (IntPtr)0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	~AkMonitoringCallbackInfo()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AkMonitoringCallbackInfo()
	{
	}
}
