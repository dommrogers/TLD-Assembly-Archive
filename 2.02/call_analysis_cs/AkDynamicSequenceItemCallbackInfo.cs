using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkDynamicSequenceItemCallbackInfo : AkCallbackInfo
{
	private IntPtr swigCPtr;

	public uint playingID
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0u;
		}
	}

	public uint audioNodeID
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0u;
		}
	}

	public IntPtr pCustomInfo
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return (IntPtr)0;
		}
	}

	[CalledBy(Type = typeof(AkDynamicSequenceItemCallbackInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(AkCallbackManager), Member = ".cctor")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkDynamicSequenceItemCallbackInfo_SWIGUpcast")]
	[CallsDeduplicatedMethods(Count = 1)]
	internal AkDynamicSequenceItemCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
		: base((IntPtr)0, cMemoryOwn: false)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkDynamicSequenceItemCallbackInfo obj)
	{
		return (IntPtr)0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkDynamicSequenceItemCallbackInfo_SWIGUpcast")]
	[CallsDeduplicatedMethods(Count = 2)]
	internal override void setCPtr(IntPtr cPtr)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkCallbackInfo), Member = "Finalize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	~AkDynamicSequenceItemCallbackInfo()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[Calls(Type = typeof(AkCallbackInfo), Member = "Dispose")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public override void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkDynamicSequenceItemCallbackInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AkDynamicSequenceItemCallbackInfo()
		: base((IntPtr)0, cMemoryOwn: false)
	{
	}
}
