using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class StartFireSelectionRow : MonoBehaviour
{
	public UILabel m_LabelName;

	public UITexture m_TextureGear;

	public UILabel m_LabelLiquid;

	public string m_NoToolSpriteName;

	public Color m_NoToolSpriteColor;

	public Vector3 m_NoToolSpriteSizeModifier;

	public UISprite m_BackgroundOnSelected;

	public GameObject m_ButtonIncrease;

	public GameObject m_ButtonDecrease;

	public UILabel m_LabelItemCount;

	private GearItem m_GearItem;

	[Calls(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(Panel_FireStart), Member = "IsThisKeroseneAccelerant")]
	[Calls(Type = typeof(Panel_FireStart), Member = "IsGunpowderAccelerant")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalPowderWeight")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Awake")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[CallsUnknownMethods(Count = 56)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_FireStart), Member = "IsThisKeroseneAccelerant")]
	[Calls(Type = typeof(Panel_FireStart), Member = "IsGunpowderAccelerant")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseAccelerant")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseAccelerant")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseStarter")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseStarter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	public void SetGearItem(FireStarterItem fsi)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseFuel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseFuel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseTinder")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseTinder")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	public void SetGearItem(FuelSourceItem fsi)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public StartFireSelectionRow()
	{
	}
}
