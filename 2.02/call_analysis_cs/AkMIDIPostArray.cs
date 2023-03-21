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
		[CallsUnknownMethods(Count = 9)]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
		[Calls(Type = typeof(AkMIDIPost), Member = ".ctor")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(AkMIDIPost), Member = "getCPtr")]
		[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMIDIPost_Clone")]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMIDIPost_GetSizeOf")]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal")]
	public AkMIDIPostArray(int size)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	~AkMIDIPostArray()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMIDIPost_PostOnEvent")]
	public void PostOnEvent(uint in_eventID, GameObject gameObject)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMIDIPost_PostOnEvent")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	public void PostOnEvent(uint in_eventID, GameObject gameObject, int count)
	{
	}

	[CallerCount(Count = 29)]
	[DeduplicatedMethod]
	public IntPtr GetBuffer()
	{
		return default(IntPtr);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public int Count()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	private IntPtr GetObjectPtr(int index)
	{
		return default(IntPtr);
	}
}
