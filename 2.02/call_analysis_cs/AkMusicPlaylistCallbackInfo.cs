using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkMusicPlaylistCallbackInfo : AkEventCallbackInfo
{
	private IntPtr swigCPtr;

	public uint playlistID
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0u;
		}
	}

	public uint uNumPlaylistItems
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0u;
		}
	}

	public uint uPlaylistSelection
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0u;
		}
	}

	public uint uPlaylistItemDone
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0u;
		}
	}

	[CalledBy(Type = typeof(AkMusicPlaylistCallbackInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(AkCallbackManager), Member = ".cctor")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMusicPlaylistCallbackInfo_SWIGUpcast")]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	internal AkMusicPlaylistCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
		: base((IntPtr)0, cMemoryOwn: false)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkMusicPlaylistCallbackInfo obj)
	{
		return (IntPtr)0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMusicPlaylistCallbackInfo_SWIGUpcast")]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "setCPtr")]
	[CallsDeduplicatedMethods(Count = 1)]
	internal override void setCPtr(IntPtr cPtr)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "Finalize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	~AkMusicPlaylistCallbackInfo()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "Dispose")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public override void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkMusicPlaylistCallbackInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AkMusicPlaylistCallbackInfo()
		: base((IntPtr)0, cMemoryOwn: false)
	{
	}
}
