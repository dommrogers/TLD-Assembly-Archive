using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkAuxSendArray : IDisposable
{
	private const int MAX_COUNT = 4;

	private readonly int SIZE_OF_AKAUXSENDVALUE;

	private IntPtr m_Buffer;

	private int m_Count;

	public AkAuxSendValue Item
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 9)]
		get
		{
			return null;
		}
	}

	public bool isFull
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(AkGameObjEnvironmentData), Member = "AddHighestPriorityEnvironments")]
		[CalledBy(Type = typeof(AkGameObjEnvironmentData), Member = "AddHighestPriorityEnvironments")]
		[CalledBy(Type = typeof(AkGameObjEnvironmentData), Member = "AddHighestPriorityEnvironmentsFromPortals")]
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(AkAuxSendArray), Member = "Add")]
		[CalledBy(Type = typeof(AkAuxSendArray), Member = "Add")]
		get
		{
			return default(bool);
		}
	}

	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkAuxSendValue_GetSizeOf")]
	public AkAuxSendArray()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Dispose()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	~AkAuxSendArray()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Reset()
	{
	}

	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkAuxSendValue_Set")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkAuxSendArray), Member = "get_isFull")]
	public bool Add(GameObject in_listenerGameObj, uint in_AuxBusID, float in_fValue)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkAuxSendArray), Member = "get_isFull")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkAuxSendValue_Set")]
	[CalledBy(Type = typeof(AkGameObjEnvironmentData), Member = "AddHighestPriorityEnvironmentsFromPortals")]
	[CalledBy(Type = typeof(AkGameObjEnvironmentData), Member = "AddHighestPriorityEnvironments")]
	public bool Add(uint in_AuxBusID, float in_fValue)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkAuxSendValue_IsSame")]
	public bool Contains(GameObject in_listenerGameObj, uint in_AuxBusID)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(AkGameObjEnvironmentData), Member = "AddHighestPriorityEnvironments")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkAuxSendValue_IsSame")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public bool Contains(uint in_AuxBusID)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_SetGameObjectAuxSendValues")]
	public AKRESULT SetValues(GameObject gameObject)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsUnknownMethods(Count = 1)]
	public AKRESULT GetValues(GameObject gameObject)
	{
		return default(AKRESULT);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 29)]
	public IntPtr GetBuffer()
	{
		return default(IntPtr);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
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
