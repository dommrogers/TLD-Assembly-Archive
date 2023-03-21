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

	[Calls(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalPowderWeight")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Awake")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Panel_FireStart), Member = "IsThisKeroseneAccelerant")]
	[Calls(Type = typeof(Panel_FireStart), Member = "IsGunpowderAccelerant")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Panel_FireStart), Member = "IsThisKeroseneAccelerant")]
	[Calls(Type = typeof(Panel_FireStart), Member = "IsGunpowderAccelerant")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseAccelerant")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseAccelerant")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseStarter")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseStarter")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	public void SetGearItem(FireStarterItem fsi)
	{
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseTinder")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseFuel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseFuel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseTinder")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	public void SetGearItem(FuelSourceItem fsi)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public StartFireSelectionRow()
	{
	}
}
