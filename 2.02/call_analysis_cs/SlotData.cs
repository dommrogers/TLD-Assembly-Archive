using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

public class SlotData
{
	public string m_Name;

	public string m_BaseName;

	public string m_DisplayName;

	public DateTime m_Timestamp;

	public SaveSlotType m_GameMode;

	public uint m_GameId;

	public Episode m_Episode;

	public Dictionary<string, byte[]> m_Dict;

	public bool m_IsPS4Compliant;

	public int m_VersionChangelistNumber;

	[NonSerialized]
	public string m_ResourceName;

	[NonSerialized]
	private Mutex m_SlotDataMutex;

	[CalledBy(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CopyData")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "AddGUIDToPrevSceneSave")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Mutex), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public void Lock()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mutex), Member = "ReleaseMutex")]
	[CallsUnknownMethods(Count = 1)]
	public void UnLock()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public SlotData()
	{
	}
}
