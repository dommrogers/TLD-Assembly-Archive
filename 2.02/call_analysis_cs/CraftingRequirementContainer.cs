using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
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
		[CallerCount(Count = 2)]
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

	private bool m_Selected;

	private List<Vector3> m_Positions;

	private int m_PositionIndex;

	private float m_PositionOffsetY;

	private int m_DisplayedMaterials;

	private bool m_RequiresForge;

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ClearSelectedBlueprint")]
	public void Disable()
	{
	}

	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "Disable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CraftingRequirementTool), Member = "Enable")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "SetHighlightedItem")]
	[Calls(Type = typeof(CraftingRequirementTool), Member = "Disable")]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "Disable")]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "Enable")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "ApplyNextPosition")]
	[Calls(Type = typeof(CraftingRequirementTool), Member = "Disable")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "ApplyNextPosition")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "ApplyNextPosition")]
	[Calls(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Enable")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "ApplyNextPosition")]
	[Calls(Type = typeof(CraftingRequirementLocation), Member = "Enable")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "ApplyNextPosition")]
	[Calls(Type = typeof(CraftingRequirementMaterial), Member = "Enable")]
	[CallsUnknownMethods(Count = 41)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(CraftingRequirementMaterial), Member = "EnableForKerosene")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "ApplyNextPosition")]
	[Calls(Type = typeof(CraftingRequirementMaterial), Member = "EnableForGunpowder")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "ApplyNextPosition")]
	[Calls(Type = typeof(CraftingRequirementMaterial), Member = "Disable")]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "RefreshCraftingTimeDisplay")]
	public void Enable(BlueprintItem bpi, InProgressCraftItem wip)
	{
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "UpdateCrafting")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	public GearItem GetSelectedTool()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "CraftingStart")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "GetFinalCraftingTimeWithAllModifiers")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public int GetQuantity()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "SetHighlightedItem")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public void HandleNavigation()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public bool HasMultipleNavigationOptions()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Refresh")]
	public void ManualUpdate()
	{
	}

	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "RefreshDisplayed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(CraftingRequirementTimeSelect), Member = "Refresh")]
	[Calls(Type = typeof(CraftingRequirementTimeSelect), Member = "Refresh")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Refresh")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	public void OnNext()
	{
	}

	[Calls(Type = typeof(CraftingRequirementTimeSelect), Member = "Refresh")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(CraftingRequirementTimeSelect), Member = "Refresh")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(CraftingRequirementMultiTool), Member = "RefreshDisplayed")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "Refresh")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	public void OnPrevious()
	{
	}

	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "AddPosition")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "AddPosition")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "AddPosition")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "AddPosition")]
	[Calls(Type = typeof(CraftingRequirementContainer), Member = "Disable")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[CallsUnknownMethods(Count = 45)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Start")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Start")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Start")]
	[CallsUnknownMethods(Count = 6)]
	private void AddPosition(GameObject go)
	{
	}

	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[Calls(Type = typeof(Panel_Crafting), Member = "CanCraftSelectedBlueprint")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "OnSelectedToolChanged")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[Calls(Type = typeof(CraftingRequirementTimeSelect), Member = "Disable")]
	[Calls(Type = typeof(CraftingRequirementTimeSelect), Member = "Enable")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "FormatDisplayTimeMinutes")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Crafting), Member = "GetFinalCraftingTimeWithAllModifiers")]
	private void RefreshCraftingTimeDisplay()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(CraftingRequirementMaterial), Member = "EnableForKerosene")]
	[Calls(Type = typeof(CraftingRequirementMaterial), Member = "EnableForGunpowder")]
	[Calls(Type = typeof(CraftingRequirementMaterial), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void RefreshMaterialDisplay()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void RefreshHighlight()
	{
	}

	[CallerCount(Count = 0)]
	private void ResetNextPosition()
	{
	}

	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[Calls(Type = typeof(CraftingRequirementQuantitySelect), Member = "SetSelected")]
	[Calls(Type = typeof(CraftingRequirementTimeSelect), Member = "SetSelected")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "HandleNavigation")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleInput")]
	private void SetHighlightedItem(HighlightItems item)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 19)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CraftingRequirementContainer()
	{
	}
}
