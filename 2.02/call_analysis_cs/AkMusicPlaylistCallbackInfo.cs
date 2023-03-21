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
			return default(uint);
		}
	}

	public uint uNumPlaylistItems
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(uint);
		}
	}

	public uint uPlaylistSelection
	{
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(uint);
		}
	}

	public uint uPlaylistItemDone
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(uint);
		}
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMusicPlaylistCallbackInfo_SWIGUpcast")]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(AkMusicPlaylistCallbackInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(AkCallbackManager), Member = ".cctor")]
	internal AkMusicPlaylistCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
		: base(default(IntPtr), cMemoryOwn: default(bool))
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkMusicPlaylistCallbackInfo obj)
	{
		return default(IntPtr);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMusicPlaylistCallbackInfo_SWIGUpcast")]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "setCPtr")]
	internal override void setCPtr(IntPtr cPtr)
	{
	}

	[Calls(Type = typeof(AkEventCallbackInfo), Member = "Finalize")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	~AkMusicPlaylistCallbackInfo()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "Dispose")]
	[CallsUnknownMethods(Count = 4)]
	public override void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkMusicPlaylistCallbackInfo), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public AkMusicPlaylistCallbackInfo()
		: base(default(IntPtr), cMemoryOwn: default(bool))
	{
	}
}
