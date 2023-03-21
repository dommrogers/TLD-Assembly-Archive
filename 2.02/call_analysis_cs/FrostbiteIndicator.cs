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
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(FrostbiteIndicator), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CalledBy(Type = typeof(FrostbiteIndicator), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Frostbite), Member = "NumInstancesFrostbiteAtLocation")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteRiskValue")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
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
