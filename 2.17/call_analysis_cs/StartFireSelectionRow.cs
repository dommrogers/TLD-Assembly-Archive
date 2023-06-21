using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using TLD.SaveState;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Awake")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "SetGearItem")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_FireStart), Member = "IsThisKeroseneAccelerant")]
	[Calls(Type = typeof(Panel_FireStart), Member = "IsGunpowderAccelerant")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(PowderType), Member = "GetInventoryIcon")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalPowderWeight")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 10)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseStarter")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseStarter")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseAccelerant")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseAccelerant")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "Update")]
	public void SetGearItem(FireStarterItem fsi)
	{
	}

	[CalledBy(Type = typeof(Panel_FireStart), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseTinder")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseTinder")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "IncreaseFuel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "DecreaseFuel")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(StartFireSelectionRow), Member = "Update")]
	public void SetGearItem(FuelSourceItem fsi)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public StartFireSelectionRow()
	{
	}
}
