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
			return default(uint);
		}
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(AkMIDIPost), Member = ".ctor")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMIDIPost_SWIGUpcast")]
	[CalledBy(Type = typeof(AkMIDIPostArray), Member = "get_Item")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal AkMIDIPost(IntPtr cPtr, bool cMemoryOwn)
		: base(default(IntPtr), cMemoryOwn: default(bool))
	{
	}

	[CalledBy(Type = typeof(AkMIDIPostArray), Member = "set_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	internal static IntPtr getCPtr(AkMIDIPost obj)
	{
		return default(IntPtr);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMIDIPost_SWIGUpcast")]
	internal override void setCPtr(IntPtr cPtr)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkMIDIEvent), Member = "Finalize")]
	[CallsUnknownMethods(Count = 1)]
	~AkMIDIPost()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize")]
	[Calls(Type = typeof(AkMIDIEvent), Member = "Dispose")]
	[CallsUnknownMethods(Count = 4)]
	public override void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMIDIPost_PostOnEvent")]
	public AKRESULT PostOnEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uNumPosts)
	{
		return default(AKRESULT);
	}

	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMIDIPost_Clone")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Clone(AkMIDIPost other)
	{
	}

	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMIDIPost_GetSizeOf")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static int GetSizeOf()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkMIDIPost), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public AkMIDIPost()
		: base(default(IntPtr), cMemoryOwn: default(bool))
	{
	}
}
