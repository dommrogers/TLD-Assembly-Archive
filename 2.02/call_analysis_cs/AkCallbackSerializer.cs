using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkCallbackSerializer : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal AkCallbackSerializer(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkCallbackSerializer obj)
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
	~AkCallbackSerializer()
	{
	}

	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual void Dispose()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AKRESULT Init(IntPtr in_pMemory, uint in_uSize)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Term()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static IntPtr Lock()
	{
		return default(IntPtr);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetLocalOutput(uint in_uErrorLevel)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void Unlock()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static AKRESULT AudioSourceChangeCallbackFunc(bool in_bOtherAudioPlaying, object in_pCookie)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AkCallbackSerializer()
	{
	}
}
