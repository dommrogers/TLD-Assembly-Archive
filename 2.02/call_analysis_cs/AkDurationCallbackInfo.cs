using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkDurationCallbackInfo : AkEventCallbackInfo
{
	private IntPtr swigCPtr;

	public float fDuration
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(float);
		}
	}

	public float fEstimatedDuration
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(WwiseEventTracker), Member = "CallbackHandler")]
		[CalledBy(Type = typeof(PlayableBehaviourPlayAudio), Member = "AudioCallback")]
		[CalledBy(Type = typeof(PlayerVoice), Member = "OnAkVoiceEvent")]
		[CalledBy(Type = typeof(CinematicTrack), Member = "AudioCallback")]
		[CalledBy(Type = typeof(Phone), Member = "AudioCallback")]
		[CalledBy(Type = typeof(ConsoleManager), Member = "AudioCallback")]
		[CalledBy(Type = typeof(DialogueModeRigFP), Member = "AudioCallback")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 8)]
		[CalledBy(Type = typeof(NPC_Animation), Member = "AudioCallback")]
		get
		{
			return default(float);
		}
	}

	public uint audioNodeID
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(uint);
		}
	}

	public uint mediaID
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(uint);
		}
	}

	public bool bStreaming
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return default(bool);
		}
	}

	[CalledBy(Type = typeof(AkCallbackManager), Member = ".cctor")]
	[CalledBy(Type = typeof(AkDurationCallbackInfo), Member = ".ctor")]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkDurationCallbackInfo_SWIGUpcast")]
	internal AkDurationCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
		: base(default(IntPtr), cMemoryOwn: default(bool))
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkDurationCallbackInfo obj)
	{
		return default(IntPtr);
	}

	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkDurationCallbackInfo_SWIGUpcast")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "setCPtr")]
	internal override void setCPtr(IntPtr cPtr)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "Finalize")]
	~AkDurationCallbackInfo()
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
	[Calls(Type = typeof(AkDurationCallbackInfo), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public AkDurationCallbackInfo()
		: base(default(IntPtr), cMemoryOwn: default(bool))
	{
	}
}
