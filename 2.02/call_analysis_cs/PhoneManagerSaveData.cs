using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class PhoneManagerSaveData
{
	public List<DialogueSequenceProgressionInfo> m_ListDialogueSequenceInfo;

	public List<PhoneSaveDataInfo> m_ListPhoneSaveDataInfo;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 2)]
	public void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(PhoneManager), Member = ".cctor")]
	[CallsUnknownMethods(Count = 14)]
	public PhoneManagerSaveData()
	{
	}
}
