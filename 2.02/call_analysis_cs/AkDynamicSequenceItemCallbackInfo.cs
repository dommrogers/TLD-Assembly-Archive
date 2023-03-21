using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkDynamicSequenceItemCallbackInfo : AkCallbackInfo
{
	private IntPtr swigCPtr;

	public uint playingID
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(uint);
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

	public IntPtr pCustomInfo
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(IntPtr);
		}
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkDynamicSequenceItemCallbackInfo_SWIGUpcast")]
	[CalledBy(Type = typeof(AkDynamicSequenceItemCallbackInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(AkCallbackManager), Member = ".cctor")]
	internal AkDynamicSequenceItemCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
		: base(default(IntPtr), cMemoryOwn: default(bool))
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkDynamicSequenceItemCallbackInfo obj)
	{
		return default(IntPtr);
	}

	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkDynamicSequenceItemCallbackInfo_SWIGUpcast")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal override void setCPtr(IntPtr cPtr)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkCallbackInfo), Member = "Finalize")]
	[CallsUnknownMethods(Count = 1)]
	~AkDynamicSequenceItemCallbackInfo()
	{
	}

	[Calls(Type = typeof(AkCallbackInfo), Member = "Dispose")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	public override void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkDynamicSequenceItemCallbackInfo), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public AkDynamicSequenceItemCallbackInfo()
		: base(default(IntPtr), cMemoryOwn: default(bool))
	{
	}
}
