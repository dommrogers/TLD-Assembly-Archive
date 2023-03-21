using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkEventCallbackInfo : AkCallbackInfo
{
	private IntPtr swigCPtr;

	public uint playingID
	{
		[CalledBy(Type = typeof(AkAudioInputManager), Member = "EventCallback")]
		[CalledBy(Type = typeof(AkAudioInputManager), Member = "EventCallback")]
		[CalledBy(Type = typeof(PlayerVoice), Member = "OnAkVoiceEvent")]
		[CalledBy(Type = typeof(PlayerVoice), Member = "OnAkVoiceEvent")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(MoviePlayer), Member = "OnAkVoiceEvent")]
		[CalledBy(Type = typeof(Keypad), Member = "OnAkCallback")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 7)]
		[CalledBy(Type = typeof(NPCVoice), Member = "OnAkVoiceEvent")]
		get
		{
			return default(uint);
		}
	}

	public uint eventID
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(uint);
		}
	}

	[CalledBy(Type = typeof(AkMusicPlaylistCallbackInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(AkMarkerCallbackInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(AkCallbackManager), Member = ".cctor")]
	[CalledBy(Type = typeof(AkMIDIEventCallbackInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AkDurationCallbackInfo), Member = ".ctor")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkEventCallbackInfo_SWIGUpcast")]
	[CalledBy(Type = typeof(AkEventCallbackInfo), Member = ".ctor")]
	[CallerCount(Count = 6)]
	internal AkEventCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
		: base(default(IntPtr), cMemoryOwn: default(bool))
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkEventCallbackInfo obj)
	{
		return default(IntPtr);
	}

	[CalledBy(Type = typeof(AkMarkerCallbackInfo), Member = "setCPtr")]
	[CalledBy(Type = typeof(AkMIDIEventCallbackInfo), Member = "setCPtr")]
	[CalledBy(Type = typeof(AkDurationCallbackInfo), Member = "setCPtr")]
	[CalledBy(Type = typeof(AkMusicPlaylistCallbackInfo), Member = "setCPtr")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkEventCallbackInfo_SWIGUpcast")]
	internal override void setCPtr(IntPtr cPtr)
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkCallbackInfo), Member = "Finalize")]
	[CalledBy(Type = typeof(AkDurationCallbackInfo), Member = "Finalize")]
	[CalledBy(Type = typeof(AkMIDIEventCallbackInfo), Member = "Finalize")]
	[CalledBy(Type = typeof(AkMarkerCallbackInfo), Member = "Finalize")]
	[CalledBy(Type = typeof(AkMusicPlaylistCallbackInfo), Member = "Finalize")]
	[CallsUnknownMethods(Count = 1)]
	~AkEventCallbackInfo()
	{
	}

	[CalledBy(Type = typeof(AkMIDIEventCallbackInfo), Member = "Dispose")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(AkMusicPlaylistCallbackInfo), Member = "Dispose")]
	[CalledBy(Type = typeof(AkMarkerCallbackInfo), Member = "Dispose")]
	[CalledBy(Type = typeof(AkDurationCallbackInfo), Member = "Dispose")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[Calls(Type = typeof(AkCallbackInfo), Member = "Dispose")]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	public override void Dispose()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public AkEventCallbackInfo()
		: base(default(IntPtr), cMemoryOwn: default(bool))
	{
	}
}
