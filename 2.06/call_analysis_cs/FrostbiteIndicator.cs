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
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(FrostbiteIndicator), Member = "Update")]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(FrostbiteIndicator), Member = "OnEnable")]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteRiskValue")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Frostbite), Member = "NumInstancesFrostbiteAtLocation")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public FrostbiteIndicator()
	{
	}
}
