using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkChannelEmitter : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public AkTransform position
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkTransform), Member = "getCPtr")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public uint uInputChannels
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0u;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal AkChannelEmitter(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkChannelEmitter obj)
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
	~AkChannelEmitter()
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
}
