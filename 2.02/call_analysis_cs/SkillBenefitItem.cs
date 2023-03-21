using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SkillBenefitItem : MonoBehaviour
{
	public UISprite m_Background;

	public UILabel m_LabelBenifit;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SkillBenefitItem()
	{
	}
}
