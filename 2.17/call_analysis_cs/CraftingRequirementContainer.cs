using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using UnityEngine;

public class CraftingRequirementContainer : MonoBehaviour
{
	private enum HighlightItems
	{
		None,
		Tool,
		Time,
		Quantity
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<Vector3> _003C_003E9__24_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		internal int _003CStart_003Eb__24_0(Vector3 lhs, Vector3 rhs)
		{
			return 0;
		}
	}

	public CraftingRequirementLocation m_Location;

	public List<CraftingRequirementMaterial> m_Materials;

	public CraftingRequirementMultiTool m_MultiTool;

	public CraftingRequirementTool m_SingleTool;

	public CraftingRequirementTime m_Time;

	public CraftingRequirementTimeSelect m_TimeSelect;

	public CraftingRequirementQuantitySelect m_QuantitySelect;

	private HighlightItems m_CurrentHighlight;

	private Panel_Crafting m_OwnerPanel;

	private readonly List<Vector3> m_Positions;

	private int m_PositionIndex;

	private float m_PositionOffsetY;

	private int m_DisplayedMaterials;

	private bool m_RequiresForge;

	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Start")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ClearSelectedBlueprint")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Disable()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "SetOwnerPanel")]
	[Calls(Type = typeof(CraftingRequirementMaterial), Member = "EnableForKerosene")]
	[Calls(Type = typeof(BlueprintData), Member = "get_transform")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "ApplyNextPosition")]
	[Calls(Type = typeof(CraftingRequirementMaterial), Member = "Disable")]
	[Calls(Type = typeof(CraftingRequirementMaterial), Member = "EnableForPowder")]
	[Calls(Type = typeof(CraftingRequirementMaterial), Member = "Enable")]
	[Calls(Type = typeof(CraftingRequirementLocation), Member = "Enable")]
	[Calls(Type = typeof(CraftingRequirementTool), Member = "Enable")]
	[Calls(Type = typeof(CraftingRequirementTool), Member = "Disable")]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "Disable")]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "Enable")]
	[Calls(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Enable")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "RefreshCraftingTimeDisplay")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "SetHighlightedItem")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 11)]
	public void Enable(Panel_Crafting panel)
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public GearItem GetSelectedTool()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "GetFinalCraftingTimeWithAllModifiers")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CraftingStart")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int GetQuantity()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "SetHighlightedItem")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public void HandleNavigation()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasMultipleNavigationOptions()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Refresh")]
	[CallsUnknownMethods(Count = 1)]
	public void ManualUpdate()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Refresh")]
	[Calls(Type = typeof(CraftingRequirementTimeSelect), Member = "Refresh")]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "RefreshDisplayed")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public void OnNext()
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Refresh")]
	[Calls(Type = typeof(CraftingRequirementTimeSelect), Member = "Refresh")]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "RefreshDisplayed")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public void OnPrevious()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "Disable")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "AddPosition")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentNullException")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 14)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Start")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void AddPosition(GameObject go)
	{
	}

	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CallerCount(Count = 7)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void ApplyNextPosition(Transform trans)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnSelectedQuantityChanged()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "RefreshCraftingTimeDisplay")]
	private void OnSelectedToolChanged()
	{
	}

	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "OnSelectedToolChanged")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetFinalCraftingTimeWithAllModifiers")]
	[Calls(Type = typeof(Utils), Member = "FormatDisplayTimeMinutes")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	[Calls(Type = typeof(CraftingRequirementTimeSelect), Member = "Refresh")]
	[Calls(Type = typeof(CraftingRequirementTimeSelect), Member = "Disable")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void RefreshCraftingTimeDisplay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CraftingRequirementMaterial), Member = "EnableForKerosene")]
	[Calls(Type = typeof(CraftingRequirementMaterial), Member = "EnableForPowder")]
	[Calls(Type = typeof(CraftingRequirementMaterial), Member = "Enable")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void RefreshMaterialDisplay()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void RefreshHighlight()
	{
	}

	[CallerCount(Count = 0)]
	private void ResetNextPosition()
	{
	}

	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "HandleNavigation")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(CraftingRequirementTimeSelect), Member = "SetSelected")]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "SetSelected")]
	[CallsUnknownMethods(Count = 1)]
	private void SetHighlightedItem(HighlightItems item)
	{
	}

	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void SetOwnerPanel(Panel_Crafting panel)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public CraftingRequirementContainer()
	{
	}
}
