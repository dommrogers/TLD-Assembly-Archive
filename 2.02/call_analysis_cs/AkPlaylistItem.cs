using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkPlaylistItem : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public uint audioNodeID
	{
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
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

	public int msDelay
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
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
			return default(IntPtr);
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

	[CalledBy(Type = typeof(AkPlaylistItem), Member = ".ctor")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AkIterator), Member = "set_pItem")]
	[CalledBy(Type = typeof(AkPlaylistArray), Member = "FindEx")]
	[CalledBy(Type = typeof(AkPlaylistArray), Member = "Exists")]
	[CalledBy(Type = typeof(AkPlaylistArray), Member = "AddLast")]
	[CalledBy(Type = typeof(AkPlaylistArray), Member = "Remove")]
	[CalledBy(Type = typeof(AkPlaylistArray), Member = "RemoveSwap")]
	internal static IntPtr getCPtr(AkPlaylistItem obj)
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
	~AkPlaylistItem()
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
	public AkPlaylistItem()
	{
	}

	[Calls(Type = typeof(AkPlaylistItem), Member = "getCPtr")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
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
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public AKRESULT SetExternalSources(uint in_nExternalSrc, AkExternalSourceInfoArray in_pExternalSrc)
	{
		return default(AKRESULT);
	}
}
