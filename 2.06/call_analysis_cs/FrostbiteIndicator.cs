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

	[CalledBy(Type = typeof(FrostbiteIndicator), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Frostbite), Member = "NumInstancesFrostbiteAtLocation")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteRiskValue")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public FrostbiteIndicator()
	{
	}
}
