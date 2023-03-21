using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class PhoneManagerSaveData
{
	public List<DialogueSequenceProgressionInfo> m_ListDialogueSequenceInfo;

	public List<PhoneSaveDataInfo> m_ListPhoneSaveDataInfo;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(PhoneManager), Member = ".cctor")]
	[CallsUnknownMethods(Count = 11)]
	public PhoneManagerSaveData()
	{
	}
}
