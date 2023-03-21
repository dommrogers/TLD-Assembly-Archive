using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class PhoneManagerSaveData
{
	public List<DialogueSequenceProgressionInfo> m_ListDialogueSequenceInfo;

	public List<PhoneSaveDataInfo> m_ListPhoneSaveDataInfo;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public void Reset()
	{
	}

	[CalledBy(Type = typeof(PhoneManager), Member = ".cctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public PhoneManagerSaveData()
	{
	}
}
