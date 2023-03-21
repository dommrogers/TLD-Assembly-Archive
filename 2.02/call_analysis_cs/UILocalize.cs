using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UILocalize : MonoBehaviour
{
	public string key;

	private bool mStarted;

	public string value
	{
		[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[Calls(Type = typeof(UIInput), Member = "set_defaultText")]
		[Calls(Type = typeof(UILabel), Member = "set_text")]
		[CalledBy(Type = typeof(UILocalize), Member = "OnLocalize")]
		[Calls(Type = typeof(UIButton), Member = "set_normalSprite")]
		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallerCount(Count = 1)]
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

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILocalize), Member = "set_value")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UILocalize), Member = "OnEnable")]
	private void OnLocalize()
	{
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public UILocalize()
	{
	}
}
