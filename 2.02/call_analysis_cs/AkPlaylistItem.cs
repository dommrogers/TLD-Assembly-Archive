using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkPlaylistItem : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public uint audioNodeID
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

	public int msDelay
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public IntPtr pCustomInfo
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return (IntPtr)0;
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
	internal AkPlaylistItem(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[CalledBy(Type = typeof(AkIterator), Member = "set_pItem")]
	[CalledBy(Type = typeof(AkPlaylistArray), Member = "FindEx")]
	[CalledBy(Type = typeof(AkPlaylistArray), Member = "Exists")]
	[CalledBy(Type = typeof(AkPlaylistArray), Member = "AddLast")]
	[CalledBy(Type = typeof(AkPlaylistArray), Member = "Remove")]
	[CalledBy(Type = typeof(AkPlaylistArray), Member = "RemoveSwap")]
	[CalledBy(Type = typeof(AkPlaylistItem), Member = ".ctor")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkPlaylistItem obj)
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
	~AkPlaylistItem()
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AkPlaylistItem()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkPlaylistItem), Member = "getCPtr")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AkPlaylistItem(AkPlaylistItem in_rCopy)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public AkPlaylistItem Assign(AkPlaylistItem in_rCopy)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public bool IsEqualTo(AkPlaylistItem in_rCopy)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public AKRESULT SetExternalSources(uint in_nExternalSrc, AkExternalSourceInfoArray in_pExternalSrc)
	{
		return default(AKRESULT);
	}
}
