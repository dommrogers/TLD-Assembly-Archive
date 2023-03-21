using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkThreadProperties : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public int nPriority
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
		}
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public uint dwAffinityMask
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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

	public uint uStackSize
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
	internal AkThreadProperties(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[CalledBy(Type = typeof(AkPlatformInitSettings), Member = "set_threadBankManager")]
	[CalledBy(Type = typeof(AkPlatformInitSettings), Member = "set_threadMonitor")]
	[CalledBy(Type = typeof(AkPlatformInitSettings), Member = "set_threadOutputMgr")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "AkGetDefaultHighPriorityThreadProperties")]
	[CalledBy(Type = typeof(AkDeviceSettings), Member = "set_threadProperties")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(AkPlatformInitSettings), Member = "set_threadLEngine")]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkThreadProperties obj)
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
	~AkThreadProperties()
	{
	}

	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[CallsUnknownMethods(Count = 4)]
	public virtual void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AkThreadProperties()
	{
	}
}
