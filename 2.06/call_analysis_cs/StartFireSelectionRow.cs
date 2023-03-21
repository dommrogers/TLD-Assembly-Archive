using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class StartFireSelectionRow : MonoBehaviour
{
	private Panel_FireStart m_FireStart;

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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(Panel_FireStart), Member = "IsGunpowderAccelerant")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalPowderWeight")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Awake")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_FireStart), Member = "IsThisKeroseneAccelerant")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_FireStart), Member = "IsThisKeroseneAccelerant")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_FireStart), Member = "IsGunpowderAccelerant")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseStarter")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseStarter")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseAccelerant")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseAccelerant")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	public void SetGearItem(FireStarterItem fsi)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseFuel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseTinder")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseFuel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseTinder")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	public void SetGearItem(FuelSourceItem fsi)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public StartFireSelectionRow()
	{
	}
}
