using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DishEffectInfoIcon : MonoBehaviour
{
	private UISprite m_Sprite;

	private UILabel m_Label;

	private GameObject[] m_BenefitArrows;

	private GameObject[] m_DetrimentArrows;

	private GameObject m_Tooltip;

	private UILabel m_TooltipLabel;

	private Color m_BenefitColor;

	private Color m_DetrimentColor;

	[CalledBy(Type = typeof(DishEffectInfo), Member = "ShowDishBenefits")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	public void ShowDishEffect(DishEffectInfoUI.DishEffectUIMapping dishEffectUIMapping, IFoodEffect.Effect effect)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public DishEffectInfoIcon()
	{
	}
}
