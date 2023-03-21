using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkEventCallbackInfo : AkCallbackInfo
{
	private IntPtr swigCPtr;

	public uint playingID
	{
		[CalledBy(Type = typeof(Keypad), Member = "OnAkCallback")]
		[CalledBy(Type = typeof(MoviePlayer), Member = "OnAkVoiceEvent")]
		[CalledBy(Type = typeof(NPCVoice), Member = "OnAkVoiceEvent")]
		[CalledBy(Type = typeof(PlayerVoice), Member = "OnAkVoiceEvent")]
		[CalledBy(Type = typeof(AkAudioInputManager), Member = "EventCallback")]
		[CallerCount(Count = 7)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0u;
		}
	}

	public uint eventID
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0u;
		}
	}

	[CalledBy(Type = typeof(AkDurationCallbackInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(AkEventCallbackInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(AkMIDIEventCallbackInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(AkMarkerCallbackInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(AkMusicPlaylistCallbackInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(AkCallbackManager), Member = ".cctor")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkEventCallbackInfo_SWIGUpcast")]
	[CallsDeduplicatedMethods(Count = 1)]
	internal AkEventCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
		: base((IntPtr)0, cMemoryOwn: false)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkEventCallbackInfo obj)
	{
		return (IntPtr)0;
	}

	[CalledBy(Type = typeof(AkDurationCallbackInfo), Member = "setCPtr")]
	[CalledBy(Type = typeof(AkMIDIEventCallbackInfo), Member = "setCPtr")]
	[CalledBy(Type = typeof(AkMarkerCallbackInfo), Member = "setCPtr")]
	[CalledBy(Type = typeof(AkMusicPlaylistCallbackInfo), Member = "setCPtr")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkEventCallbackInfo_SWIGUpcast")]
	[CallsDeduplicatedMethods(Count = 2)]
	internal override void setCPtr(IntPtr cPtr)
	{
	}

	[CalledBy(Type = typeof(AkDurationCallbackInfo), Member = "Finalize")]
	[CalledBy(Type = typeof(AkMIDIEventCallbackInfo), Member = "Finalize")]
	[CalledBy(Type = typeof(AkMarkerCallbackInfo), Member = "Finalize")]
	[CalledBy(Type = typeof(AkMusicPlaylistCallbackInfo), Member = "Finalize")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AkCallbackInfo), Member = "Finalize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	~AkEventCallbackInfo()
	{
	}

	[CalledBy(Type = typeof(AkDurationCallbackInfo), Member = "Dispose")]
	[CalledBy(Type = typeof(AkMIDIEventCallbackInfo), Member = "Dispose")]
	[CalledBy(Type = typeof(AkMarkerCallbackInfo), Member = "Dispose")]
	[CalledBy(Type = typeof(AkMusicPlaylistCallbackInfo), Member = "Dispose")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[Calls(Type = typeof(AkCallbackInfo), Member = "Dispose")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public override void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AkEventCallbackInfo()
		: base((IntPtr)0, cMemoryOwn: false)
	{
	}
}
