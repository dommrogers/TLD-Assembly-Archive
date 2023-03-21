using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UILocalize : MonoBehaviour
{
	public string key;

	private bool mStarted;

	public string value
	{
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
		[Calls(Type = typeof(UIButton), Member = "set_normalSprite")]
		[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "UpdateUISelection")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "UpdateUISelection")]
		[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "UpdateUISelection")]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[Calls(Type = typeof(UIInput), Member = "set_defaultText")]
		[Calls(Type = typeof(UILabel), Member = "set_text")]
		[CalledBy(Type = typeof(UILocalize), Member = "OnLocalize")]
		[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "UpdateUISelection")]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 7)]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILocalize), Member = "OnLocalize")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UILocalize), Member = "OnEnable")]
	[Calls(Type = typeof(UILocalize), Member = "set_value")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnLocalize()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public UILocalize()
	{
	}
}
