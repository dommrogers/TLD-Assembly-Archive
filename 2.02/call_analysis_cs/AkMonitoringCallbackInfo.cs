using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkMonitoringCallbackInfo : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public AkMonitorErrorCode errorCode
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(AkCallbackManager), Member = "PostCallbacks")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(AkMonitorErrorCode);
		}
	}

	public AkMonitorErrorLevel errorLevel
	{
		[CalledBy(Type = typeof(AkCallbackManager), Member = "PostCallbacks")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(AkMonitorErrorLevel);
		}
	}

	public uint playingID
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(AkCallbackManager), Member = "PostCallbacks")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(uint);
		}
	}

	public ulong gameObjID
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(AkCallbackManager), Member = "PostCallbacks")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(ulong);
		}
	}

	public string message
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(AkSoundEngine), Member = "StringFromIntPtrOSString")]
		[CalledBy(Type = typeof(AkCallbackManager), Member = "PostCallbacks")]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static IntPtr getCPtr(AkMonitoringCallbackInfo obj)
	{
		return default(IntPtr);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	~AkMonitoringCallbackInfo()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsUnknownMethods(Count = 4)]
	public virtual void Dispose()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public AkMonitoringCallbackInfo()
	{
	}
}
