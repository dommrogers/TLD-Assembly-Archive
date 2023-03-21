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
			return default(int);
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

	private List<Vector3> m_Positions;

	private int m_PositionIndex;

	private float m_PositionOffsetY;

	private int m_DisplayedMaterials;

	private bool m_RequiresForge;

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ClearSelectedBlueprint")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Start")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public void Disable()
	{
	}

	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "Disable")]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "Enable")]
	[Calls(Type = typeof(CraftingRequirementTool), Member = "Disable")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "ApplyNextPosition")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "ApplyNextPosition")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "ApplyNextPosition")]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Enable")]
	[Calls(Type = typeof(CraftingRequirementTool), Member = "Enable")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "RefreshCraftingTimeDisplay")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "SetHighlightedItem")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "ApplyNextPosition")]
	[Calls(Type = typeof(CraftingRequirementTool), Member = "Disable")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "ApplyNextPosition")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "SetOwnerPanel")]
	[Calls(Type = typeof(CraftingRequirementLocation), Member = "Enable")]
	[Calls(Type = typeof(BlueprintData), Member = "get_transform")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "ApplyNextPosition")]
	[Calls(Type = typeof(CraftingRequirementMaterial), Member = "EnableForKerosene")]
	[Calls(Type = typeof(BlueprintData), Member = "get_transform")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "ApplyNextPosition")]
	[Calls(Type = typeof(CraftingRequirementMaterial), Member = "Disable")]
	[Calls(Type = typeof(CraftingRequirementMaterial), Member = "Enable")]
	[Calls(Type = typeof(BlueprintData), Member = "get_transform")]
	[Calls(Type = typeof(CraftingRequirementMaterial), Member = "EnableForGunpowder")]
	public void Enable(Panel_Crafting panel)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateCrafting")]
	[CallsUnknownMethods(Count = 1)]
	public GearItem GetSelectedTool()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "CraftingStart")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "GetFinalCraftingTimeWithAllModifiers")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public int GetQuantity()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "SetHighlightedItem")]
	[CallsUnknownMethods(Count = 1)]
	public void HandleNavigation()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public bool HasMultipleNavigationOptions()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Refresh")]
	[CallsUnknownMethods(Count = 1)]
	public void ManualUpdate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "RefreshDisplayed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(CraftingRequirementTimeSelect), Member = "Refresh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Refresh")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	public void OnNext()
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "RefreshDisplayed")]
	[Calls(Type = typeof(CraftingRequirementTimeSelect), Member = "Refresh")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Refresh")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	public void OnPrevious()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "AddPosition")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "AddPosition")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "AddPosition")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "Disable")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "AddPosition")]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Start")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Start")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Start")]
	private void AddPosition(GameObject go)
	{
	}

	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
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

	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "OnSelectedToolChanged")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[Calls(Type = typeof(CraftingRequirementTimeSelect), Member = "Disable")]
	[Calls(Type = typeof(CraftingRequirementTimeSelect), Member = "Refresh")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetFinalCraftingTimeWithAllModifiers")]
	[Calls(Type = typeof(Utils), Member = "FormatDisplayTimeMinutes")]
	private void RefreshCraftingTimeDisplay()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CraftingRequirementMaterial), Member = "EnableForKerosene")]
	[Calls(Type = typeof(CraftingRequirementMaterial), Member = "EnableForGunpowder")]
	[Calls(Type = typeof(CraftingRequirementMaterial), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void RefreshMaterialDisplay()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void RefreshHighlight()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void ResetNextPosition()
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(CraftingRequirementTimeSelect), Member = "SetSelected")]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "SetSelected")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "HandleNavigation")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CallsUnknownMethods(Count = 1)]
	private void SetHighlightedItem(HighlightItems item)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	private void SetOwnerPanel(Panel_Crafting panel)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public CraftingRequirementContainer()
	{
	}
}
