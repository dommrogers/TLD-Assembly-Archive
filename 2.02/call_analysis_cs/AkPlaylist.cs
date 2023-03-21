using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkPlaylist : AkPlaylistArray
{
	private IntPtr swigCPtr;

	[CalledBy(Type = typeof(AkPlaylist), Member = ".ctor")]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "DynamicSequenceLockPlaylist")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkPlaylist_SWIGUpcast")]
	[CallsDeduplicatedMethods(Count = 1)]
	internal AkPlaylist(IntPtr cPtr, bool cMemoryOwn)
		: base((IntPtr)0, cMemoryOwn: false)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkPlaylist obj)
	{
		return (IntPtr)0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkPlaylist_SWIGUpcast")]
	[CallsDeduplicatedMethods(Count = 2)]
	internal override void setCPtr(IntPtr cPtr)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkPlaylistArray), Member = "Finalize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	~AkPlaylist()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[Calls(Type = typeof(AkPlaylistArray), Member = "Dispose")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public override void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo, uint in_cExternals)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public AKRESULT Enqueue(uint in_audioNodeID)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkPlaylist), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AkPlaylist()
		: base((IntPtr)0, cMemoryOwn: false)
	{
	}
}
