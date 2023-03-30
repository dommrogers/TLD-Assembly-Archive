using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class ConsoleManagerSettings : ScriptableObject
{
	[Serializable]
	public class KeyToGearItem
	{
		public string m_Key;

		public AssetReferenceGearItem m_GearItemReference;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public KeyToGearItem()
		{
		}
	}

	public AssetLabelReference m_GearItemDataLabel;

	public KeyToGearItem[] m_CustomGearItemSearchTerms;

	public string[] m_GearItemComponentNames;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public ConsoleManagerSettings()
	{
	}
}
