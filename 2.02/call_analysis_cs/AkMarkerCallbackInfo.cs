using System;
using System.Threading;
using Audio.SimpleAudio;
using Cpp2ILInjected.CallAnalysis;

public class AkMarkerCallbackInfo : AkEventCallbackInfo
{
	private IntPtr swigCPtr;

	public uint uIdentifier
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0u;
		}
	}

	public uint uPosition
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0u;
		}
	}

	public string strLabel
	{
		[CalledBy(Type = typeof(Anxiety), Member = "OnAkVoiceEvent")]
		[CalledBy(Type = typeof(Fear), Member = "OnAkVoiceEvent")]
		[CalledBy(Type = typeof(InvisibleEntityManager), Member = "OnAkVoiceEvent")]
		[CalledBy(Type = typeof(NPCVoice), Member = "OnAkVoiceEvent")]
		[CalledBy(Type = typeof(PlayerCough), Member = "OnAkVoiceEvent")]
		[CalledBy(Type = typeof(PlayerVoice), Member = "OnAkVoiceEvent")]
		[CalledBy(Type = typeof(VoiceTracker), Member = "OnAkVoiceEvent")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(AkSoundEngine), Member = "StringFromIntPtrString")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(AkMarkerCallbackInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(AkCallbackManager), Member = ".cctor")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMarkerCallbackInfo_SWIGUpcast")]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	internal AkMarkerCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
		: base((IntPtr)0, cMemoryOwn: false)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkMarkerCallbackInfo obj)
	{
		return (IntPtr)0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMarkerCallbackInfo_SWIGUpcast")]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "setCPtr")]
	[CallsDeduplicatedMethods(Count = 1)]
	internal override void setCPtr(IntPtr cPtr)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "Finalize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	~AkMarkerCallbackInfo()
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
	[Calls(Type = typeof(AkMarkerCallbackInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AkMarkerCallbackInfo()
		: base((IntPtr)0, cMemoryOwn: false)
	{
	}
}
