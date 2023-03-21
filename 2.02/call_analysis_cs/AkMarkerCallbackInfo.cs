using System;
using System.Threading;
using Audio.SimpleAudio;
using Cpp2ILInjected.CallAnalysis;

public class AkMarkerCallbackInfo : AkEventCallbackInfo
{
	private IntPtr swigCPtr;

	public uint uIdentifier
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(uint);
		}
	}

	public uint uPosition
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(uint);
		}
	}

	public string strLabel
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(PlayerVoice), Member = "OnAkVoiceEvent")]
		[CalledBy(Type = typeof(PlayerCough), Member = "OnAkVoiceEvent")]
		[CalledBy(Type = typeof(NPCVoice), Member = "OnAkVoiceEvent")]
		[CalledBy(Type = typeof(InvisibleEntityManager), Member = "OnAkVoiceEvent")]
		[CalledBy(Type = typeof(VoiceTracker), Member = "OnAkVoiceEvent")]
		[CalledBy(Type = typeof(Anxiety), Member = "OnAkVoiceEvent")]
		[Calls(Type = typeof(AkSoundEngine), Member = "StringFromIntPtrString")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(Fear), Member = "OnAkVoiceEvent")]
		[CallerCount(Count = 7)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMarkerCallbackInfo_SWIGUpcast")]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(AkMarkerCallbackInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(AkCallbackManager), Member = ".cctor")]
	internal AkMarkerCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
		: base(default(IntPtr), cMemoryOwn: default(bool))
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkMarkerCallbackInfo obj)
	{
		return default(IntPtr);
	}

	[Calls(Type = typeof(AkEventCallbackInfo), Member = "setCPtr")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMarkerCallbackInfo_SWIGUpcast")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal override void setCPtr(IntPtr cPtr)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "Finalize")]
	[CallsUnknownMethods(Count = 1)]
	~AkMarkerCallbackInfo()
	{
	}

	[Calls(Type = typeof(AkEventCallbackInfo), Member = "Dispose")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	public override void Dispose()
	{
	}

	[Calls(Type = typeof(AkMarkerCallbackInfo), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public AkMarkerCallbackInfo()
		: base(default(IntPtr), cMemoryOwn: default(bool))
	{
	}
}
