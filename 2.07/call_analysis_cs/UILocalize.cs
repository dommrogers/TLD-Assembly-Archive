using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UILocalize : MonoBehaviour
{
	public string key;

	private bool mStarted;

	public string value
	{
		[Calls(Type = typeof(UILabel), Member = "set_text")]
		[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
		[CalledBy(Type = typeof(UILocalize), Member = "OnLocalize")]
		[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "UpdateUISelection")]
		[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "UpdateUISelection")]
		[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "UpdateUISelection")]
		[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "UpdateUISelection")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UIButton), Member = "set_normalSprite")]
		[Calls(Type = typeof(UIInput), Member = "set_defaultText")]
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 7)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILocalize), Member = "set_value")]
	[CalledBy(Type = typeof(UILocalize), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void OnLocalize()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public UILocalize()
	{
	}
}
