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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public UISliderColors()
	{
	}
}
