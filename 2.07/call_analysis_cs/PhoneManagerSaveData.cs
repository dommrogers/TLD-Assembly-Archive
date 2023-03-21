using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class PhoneManagerSaveData
{
	public List<DialogueSequenceProgressionInfo> m_ListDialogueSequenceInfo;

	public List<PhoneSaveDataInfo> m_ListPhoneSaveDataInfo;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void Reset()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public PhoneManagerSaveData()
	{
	}
}
