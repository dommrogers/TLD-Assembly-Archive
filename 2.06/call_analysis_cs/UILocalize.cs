using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UILocalize : MonoBehaviour
{
	public string key;

	private bool mStarted;

	public string value
	{
		[CalledBy(Type = typeof(UILocalize), Member = "OnLocalize")]
		[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "UpdateUISelection")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Component), Member = "GetComponent")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(NGUITools), Member = "FindInParents")]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[Calls(Type = typeof(UIButton), Member = "set_normalSprite")]
		[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
		[Calls(Type = typeof(UIInput), Member = "set_defaultText")]
		[Calls(Type = typeof(UILabel), Member = "set_text")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILocalize), Member = "OnLocalize")]
	private void OnEnable()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(UILocalize), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILocalize), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	private void OnLocalize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public UILocalize()
	{
	}
}
