using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkMIDIPostArray
{
	private readonly int m_Count;

	private readonly int SIZE_OF;

	private IntPtr m_Buffer;

	public AkMIDIPost Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkMIDIPost), Member = ".ctor")]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AkMIDIPost), Member = "getCPtr")]
		[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMIDIPost_Clone")]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMIDIPost_GetSizeOf")]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal")]
	[CallsDeduplicatedMethods(Count = 1)]
	public AkMIDIPostArray(int size)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	~AkMIDIPostArray()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMIDIPost_PostOnEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void PostOnEvent(uint in_eventID, GameObject gameObject)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMIDIPost_PostOnEvent")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void PostOnEvent(uint in_eventID, GameObject gameObject, int count)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 35)]
	public IntPtr GetBuffer()
	{
		return (IntPtr)0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public int Count()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	private IntPtr GetObjectPtr(int index)
	{
		return (IntPtr)0;
	}
}
