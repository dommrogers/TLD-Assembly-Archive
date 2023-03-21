using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;
using TLD.SaveState;

public class SlotData : BaseState
{
	public static bool s_DebugAllowInvalidVersions;

	public const int CURRENT_VERSION = 100;

	public const int LOWEST_COMPATIBLE_VERSION = 100;

	public const string BOOT_KEY = "boot";

	public const string GLOBAL_KEY = "global";

	public const string INFO_KEY = "info";

	public const string SCREENSHOT_KEY = "screenshot";

	public string m_InternalName;

	public string m_BaseName;

	public string m_DisplayName;

	[NonSerialized]
	public string m_Filename;

	public DateTime m_Timestamp;

	public SaveSlotType m_GameMode;

	public uint m_GameId;

	public Episode m_Episode;

	public readonly List<string> m_InstalledOptionalContent;

	[NonSerialized]
	private Mutex m_SlotDataMutex;

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "AddGUIDToPrevSceneSave")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "CopyData")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SaveDataToSlot")]
	[Calls(Type = typeof(Mutex), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "WriteSlotToDisk")]
	public void Lock()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void UnLock()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsValidVersion()
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	public override string ToString()
	{
		return null;
	}

	[Calls(Type = typeof(BaseState), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public SlotData()
	{
	}
}
