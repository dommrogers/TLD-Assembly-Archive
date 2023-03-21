using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkPlaylist : AkPlaylistArray
{
	private IntPtr swigCPtr;

	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkPlaylist_SWIGUpcast")]
	[CalledBy(Type = typeof(AkPlaylist), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AkSoundEngine), Member = "DynamicSequenceLockPlaylist")]
	internal AkPlaylist(IntPtr cPtr, bool cMemoryOwn)
		: base(default(IntPtr), cMemoryOwn: default(bool))
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	internal static IntPtr getCPtr(AkPlaylist obj)
	{
		return default(IntPtr);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkPlaylist_SWIGUpcast")]
	[CallerCount(Count = 0)]
	internal override void setCPtr(IntPtr cPtr)
	{
	}

	[Calls(Type = typeof(AkPlaylistArray), Member = "Finalize")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	~AkPlaylist()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[Calls(Type = typeof(AkPlaylistArray), Member = "Dispose")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkPlaylist), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public AkPlaylist()
		: base(default(IntPtr), cMemoryOwn: default(bool))
	{
	}
}
