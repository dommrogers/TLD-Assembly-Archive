using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using UnityEngine;

public class CraftingRequirementLocation : MonoBehaviour
{
	[Serializable]
	public class Data
	{
		public UISprite m_Icon;

		public LocalizedString m_Name;

		private Color m_IconTint;

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(CraftingRequirementLocation), Member = "Enable")]
		[CallsUnknownMethods(Count = 3)]
		public void Enable(Panel_Crafting panel, bool enable, bool requirementsMet)
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		public void Setup()
		{
		}

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public Data()
		{
		}
	}

	public List<Data> m_DataSets;

	public UILabel m_Display;

	private Color m_DisplayTint;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	public void Disable()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Data), Member = "Enable")]
	public void Enable(Panel_Crafting ownerPanel, BlueprintData bp)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public CraftingRequirementLocation()
	{
	}
}
