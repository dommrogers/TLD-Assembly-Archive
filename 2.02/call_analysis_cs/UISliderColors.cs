using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UISliderColors : MonoBehaviour
{
	public UISprite sprite;

	public Color[] colors;

	private UIProgressBar mBar;

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public UISliderColors()
	{
	}
}
