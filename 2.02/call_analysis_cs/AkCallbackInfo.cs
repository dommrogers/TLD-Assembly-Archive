using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkCallbackInfo : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public IntPtr pCookie
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(IntPtr);
		}
	}

	public ulong gameObjID
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(ulong);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal AkCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static IntPtr getCPtr(AkCallbackInfo obj)
	{
		return default(IntPtr);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AkDynamicSequenceItemCallbackInfo), Member = "Finalize")]
	[CalledBy(Type = typeof(AkEventCallbackInfo), Member = "Finalize")]
	[CalledBy(Type = typeof(AkMusicSyncCallbackInfo), Member = "Finalize")]
	[CallsUnknownMethods(Count = 1)]
	~AkCallbackInfo()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(AkMusicSyncCallbackInfo), Member = "Dispose")]
	[CalledBy(Type = typeof(AkEventCallbackInfo), Member = "Dispose")]
	[CalledBy(Type = typeof(AkDynamicSequenceItemCallbackInfo), Member = "Dispose")]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	public virtual void Dispose()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public AkCallbackInfo()
	{
	}
}
