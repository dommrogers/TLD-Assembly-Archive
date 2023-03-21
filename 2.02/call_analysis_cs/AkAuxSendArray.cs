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
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		get
		{
			return null;
		}
	}

	public bool isFull
	{
		[CalledBy(Type = typeof(AkAuxSendArray), Member = "Add")]
		[CalledBy(Type = typeof(AkAuxSendArray), Member = "Add")]
		[CalledBy(Type = typeof(AkGameObjEnvironmentData), Member = "AddHighestPriorityEnvironmentsFromPortals")]
		[CalledBy(Type = typeof(AkGameObjEnvironmentData), Member = "AddHighestPriorityEnvironments")]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkAuxSendValue_GetSizeOf")]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkAuxSendArray), Member = "get_isFull")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkAuxSendValue_Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool Add(GameObject in_listenerGameObj, uint in_AuxBusID, float in_fValue)
	{
		return false;
	}

	[CalledBy(Type = typeof(AkGameObjEnvironmentData), Member = "AddHighestPriorityEnvironmentsFromPortals")]
	[CalledBy(Type = typeof(AkGameObjEnvironmentData), Member = "AddHighestPriorityEnvironments")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AkAuxSendArray), Member = "get_isFull")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkAuxSendValue_Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool Add(uint in_AuxBusID, float in_fValue)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkAuxSendValue_IsSame")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool Contains(GameObject in_listenerGameObj, uint in_AuxBusID)
	{
		return false;
	}

	[CalledBy(Type = typeof(AkGameObjEnvironmentData), Member = "AddHighestPriorityEnvironments")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkAuxSendValue_IsSame")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool Contains(uint in_AuxBusID)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_SetGameObjectAuxSendValues")]
	[CallsDeduplicatedMethods(Count = 1)]
	public AKRESULT SetValues(GameObject gameObject)
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AKRESULT GetValues(GameObject gameObject)
	{
		return default(AKRESULT);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 35)]
	public IntPtr GetBuffer()
	{
		return (IntPtr)0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
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
