using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkBankCallbackInfo : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public uint bankID
	{
		[CalledBy(Type = typeof(AkCallbackManager), Member = "PostCallbacks")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(uint);
		}
	}

	public IntPtr inMemoryBankPtr
	{
		[CalledBy(Type = typeof(AkCallbackManager), Member = "PostCallbacks")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(IntPtr);
		}
	}

	public AKRESULT loadResult
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(AkCallbackManager), Member = "PostCallbacks")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(AKRESULT);
		}
	}

	public int memPoolId
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(AkCallbackManager), Member = "PostCallbacks")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal AkBankCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static IntPtr getCPtr(AkBankCallbackInfo obj)
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
	~AkBankCallbackInfo()
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
	public AkBankCallbackInfo()
	{
	}
}
