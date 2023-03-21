using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SkillBenefitItem : MonoBehaviour
{
	public UISprite m_Background;

	public UILabel m_LabelBenifit;

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public SkillBenefitItem()
	{
	}
}
