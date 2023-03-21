using System;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkMIDIPost : AkMIDIEvent
{
	private IntPtr swigCPtr;

	public uint uOffset
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0u;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(AkMIDIPost), Member = ".ctor")]
	[CalledBy(Type = typeof(AkMIDIPostArray), Member = "get_Item")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMIDIPost_SWIGUpcast")]
	[CallsDeduplicatedMethods(Count = 1)]
	internal AkMIDIPost(IntPtr cPtr, bool cMemoryOwn)
		: base((IntPtr)0, cMemoryOwn: false)
	{
	}

	[CalledBy(Type = typeof(AkMIDIPostArray), Member = "set_Item")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static IntPtr getCPtr(AkMIDIPost obj)
	{
		return (IntPtr)0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMIDIPost_SWIGUpcast")]
	[CallsDeduplicatedMethods(Count = 2)]
	internal override void setCPtr(IntPtr cPtr)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkMIDIEvent), Member = "Finalize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	~AkMIDIPost()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[Calls(Type = typeof(AkMIDIEvent), Member = "Dispose")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public override void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMIDIPost_PostOnEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	public AKRESULT PostOnEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uNumPosts)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMIDIPost_Clone")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Clone(AkMIDIPost other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMIDIPost_GetSizeOf")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static int GetSizeOf()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkMIDIPost), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AkMIDIPost()
		: base((IntPtr)0, cMemoryOwn: false)
	{
	}
}
