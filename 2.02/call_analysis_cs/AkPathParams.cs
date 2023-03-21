using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkPathParams : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public AkVector listenerPos
	{
		[CallsUnknownMethods(Count = 8)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(AkVector), Member = "getCPtr")]
		set
		{
		}
	}

	public AkVector emitterPos
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
		[Calls(Type = typeof(AkVector), Member = "getCPtr")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public uint numValidPaths
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(uint);
		}
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal AkPathParams(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "QueryIndirectPaths")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "QuerySoundPropagationPaths")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "QueryDiffractionPaths")]
	internal static IntPtr getCPtr(AkPathParams obj)
	{
		return default(IntPtr);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	~AkPathParams()
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public AkPathParams()
	{
	}
}
