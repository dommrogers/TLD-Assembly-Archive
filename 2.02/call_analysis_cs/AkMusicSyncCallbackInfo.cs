using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class AkMusicSyncCallbackInfo : AkCallbackInfo
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

	public int segmentInfo_iCurrentPosition
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	public int segmentInfo_iPreEntryDuration
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	public int segmentInfo_iActiveDuration
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	public int segmentInfo_iPostExitDuration
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	public int segmentInfo_iRemainingLookAheadTime
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	public float segmentInfo_fBeatDuration
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
	}

	public float segmentInfo_fBarDuration
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
	}

	public float segmentInfo_fGridDuration
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
	}

	public float segmentInfo_fGridOffset
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkSoundEngine), Member = "StringFromIntPtrString")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(AkMusicSyncCallbackInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(AkCallbackManager), Member = ".cctor")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMusicSyncCallbackInfo_SWIGUpcast")]
	[CallsDeduplicatedMethods(Count = 1)]
	internal AkMusicSyncCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
		: base((IntPtr)0, cMemoryOwn: false)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkMusicSyncCallbackInfo obj)
	{
		return (IntPtr)0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMusicSyncCallbackInfo_SWIGUpcast")]
	[CallsDeduplicatedMethods(Count = 2)]
	internal override void setCPtr(IntPtr cPtr)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkCallbackInfo), Member = "Finalize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	~AkMusicSyncCallbackInfo()
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
	[Calls(Type = typeof(AkMusicSyncCallbackInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AkMusicSyncCallbackInfo()
		: base((IntPtr)0, cMemoryOwn: false)
	{
	}
}
