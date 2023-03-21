using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkAudioSourceChangeCallbackInfo : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public bool bOtherAudioPlaying
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(AkCallbackManager), Member = "PostCallbacks")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return default(bool);
		}
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal AkAudioSourceChangeCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkAudioSourceChangeCallbackInfo obj)
	{
		return default(IntPtr);
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
	~AkAudioSourceChangeCallbackInfo()
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AkAudioSourceChangeCallbackInfo()
	{
	}
}
