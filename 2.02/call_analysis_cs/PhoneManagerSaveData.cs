using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class PhoneManagerSaveData
{
	public List<DialogueSequenceProgressionInfo> m_ListDialogueSequenceInfo;

	public List<PhoneSaveDataInfo> m_ListPhoneSaveDataInfo;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Reset()
	{
	}

	[CalledBy(Type = typeof(PhoneManager), Member = ".cctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public PhoneManagerSaveData()
	{
	}
}
