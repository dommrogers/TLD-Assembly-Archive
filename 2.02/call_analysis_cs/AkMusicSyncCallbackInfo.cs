using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkMusicSyncCallbackInfo : AkCallbackInfo
{
	private IntPtr swigCPtr;

	public uint playingID
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(uint);
		}
	}

	public int segmentInfo_iCurrentPosition
	{
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public int segmentInfo_iPreEntryDuration
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
		}
	}

	public int segmentInfo_iActiveDuration
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
		}
	}

	public int segmentInfo_iPostExitDuration
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
		}
	}

	public int segmentInfo_iRemainingLookAheadTime
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
		}
	}

	public float segmentInfo_fBeatDuration
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
	}

	public float segmentInfo_fBarDuration
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(float);
		}
	}

	public float segmentInfo_fGridDuration
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(float);
		}
	}

	public float segmentInfo_fGridOffset
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(float);
		}
	}

	public AkCallbackType musicSyncType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(AkCallbackType);
		}
	}

	public string userCueName
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(AkSoundEngine), Member = "StringFromIntPtrString")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMusicSyncCallbackInfo_SWIGUpcast")]
	[CalledBy(Type = typeof(AkMusicSyncCallbackInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(AkCallbackManager), Member = ".cctor")]
	internal AkMusicSyncCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
		: base(default(IntPtr), cMemoryOwn: default(bool))
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkMusicSyncCallbackInfo obj)
	{
		return default(IntPtr);
	}

	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMusicSyncCallbackInfo_SWIGUpcast")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal override void setCPtr(IntPtr cPtr)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkCallbackInfo), Member = "Finalize")]
	[CallsUnknownMethods(Count = 1)]
	~AkMusicSyncCallbackInfo()
	{
	}

	[Calls(Type = typeof(AkCallbackInfo), Member = "Dispose")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[CallsUnknownMethods(Count = 4)]
	public override void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkMusicSyncCallbackInfo), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public AkMusicSyncCallbackInfo()
		: base(default(IntPtr), cMemoryOwn: default(bool))
	{
	}
}
