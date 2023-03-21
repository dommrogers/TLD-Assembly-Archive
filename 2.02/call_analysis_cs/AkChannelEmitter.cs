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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(AkTransform), Member = "getCPtr")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public uint uInputChannels
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(uint);
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
	~AkChannelEmitter()
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
}
