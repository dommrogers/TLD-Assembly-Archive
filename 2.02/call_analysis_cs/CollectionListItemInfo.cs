using Cpp2ILInjected.CallAnalysis;

public class CollectionListItemInfo
{
	public string m_NameLocID;

	public string m_ListIconName;

	public string m_ProgressString;

	public string m_DescLocID;

	public string m_BigIconName;

	public Panel_Log.WhatIKnowType m_SubScreenToOpen;

	public Panel_Log.CollectionsType m_CollectionType;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public CollectionListItemInfo()
	{
	}
}
