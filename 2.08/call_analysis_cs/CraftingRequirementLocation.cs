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

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIWidget), Member = "set_color")]
		[CallsUnknownMethods(Count = 3)]
		public void Enable(Panel_Crafting panel, bool enable, bool requirementsMet)
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public void Setup()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public Data()
		{
		}
	}

	public List<Data> m_DataSets;

	public UILabel m_Display;

	private Color m_DisplayTint;

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

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void Enable(Panel_Crafting ownerPanel, BlueprintData bp)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public CraftingRequirementLocation()
	{
	}
}
