using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkVector : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public float X
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(float);
		}
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(AkRoomPortal), Member = "Awake")]
		[CalledBy(Type = typeof(AkRoom), Member = "OnEnable")]
		[CalledBy(Type = typeof(AkRoom), Member = "OnEnable")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 3)]
		set
		{
		}
	}

	public float Y
	{
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(AkRoom), Member = "OnEnable")]
		[CalledBy(Type = typeof(AkRoom), Member = "OnEnable")]
		[CalledBy(Type = typeof(AkRoomPortal), Member = "Awake")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public float Z
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(AkRoom), Member = "OnEnable")]
		[CalledBy(Type = typeof(AkRoom), Member = "OnEnable")]
		[CalledBy(Type = typeof(AkRoomPortal), Member = "Awake")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal AkVector(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 20)]
	internal static IntPtr getCPtr(AkVector obj)
	{
		return default(IntPtr);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	~AkVector()
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Zero()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AkVector()
	{
	}
}
