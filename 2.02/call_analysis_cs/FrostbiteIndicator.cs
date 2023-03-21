using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FrostbiteIndicator : MonoBehaviour
{
	public UISprite m_FullFrostbiteSprite;

	public UISprite m_RiskSprite;

	public UISprite m_FillSprite;

	public UILabel m_MultiplierLabel;

	public AfflictionBodyArea m_BodyLocation;

	private int m_NumInstances;

	private float m_RiskValue;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(FrostbiteIndicator), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(FrostbiteIndicator), Member = "OnEnable")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteRiskValue")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Frostbite), Member = "NumInstancesFrostbiteAtLocation")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FrostbiteIndicator()
	{
	}
}
