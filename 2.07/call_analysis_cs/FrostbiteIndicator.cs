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
	[Calls(Type = typeof(FrostbiteIndicator), Member = "Update")]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(FrostbiteIndicator), Member = "OnEnable")]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteRiskValue")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Frostbite), Member = "NumInstancesFrostbiteAtLocation")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FrostbiteIndicator()
	{
	}
}
