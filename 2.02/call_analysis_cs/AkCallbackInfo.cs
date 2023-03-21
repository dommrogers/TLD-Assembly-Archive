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
			return (IntPtr)0;
		}
	}

	public ulong gameObjID
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0uL;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal AkCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkCallbackInfo obj)
	{
		return (IntPtr)0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[CalledBy(Type = typeof(AkDynamicSequenceItemCallbackInfo), Member = "Finalize")]
	[CalledBy(Type = typeof(AkEventCallbackInfo), Member = "Finalize")]
	[CalledBy(Type = typeof(AkMusicSyncCallbackInfo), Member = "Finalize")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	~AkCallbackInfo()
	{
	}

	[CalledBy(Type = typeof(AkDynamicSequenceItemCallbackInfo), Member = "Dispose")]
	[CalledBy(Type = typeof(AkEventCallbackInfo), Member = "Dispose")]
	[CalledBy(Type = typeof(AkMusicSyncCallbackInfo), Member = "Dispose")]
	[CallerCount(Count = 3)]
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
	public AkCallbackInfo()
	{
	}
}
