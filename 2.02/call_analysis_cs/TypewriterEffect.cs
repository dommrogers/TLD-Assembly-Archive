using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TypewriterEffect : MonoBehaviour
{
	private struct FadeEntry
	{
		public int index;

		public string text;

		public float alpha;
	}

	public static TypewriterEffect current;

	public int charsPerSecond;

	public float fadeInTime;

	public float delayOnPeriod;

	public float delayOnNewLine;

	public UIScrollView scrollView;

	public bool keepFullDimensions;

	public List<EventDelegate> onFinished;

	private UILabel mLabel;

	private string mFullText;

	private int mCurrentOffset;

	private float mNextChar;

	private bool mReset;

	private bool mActive;

	private BetterList<FadeEntry> mFade;

	public bool isActive
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	[Calls(Type = typeof(TypewriterEffect), Member = "Update")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypewriterEffect), Member = "Finish")]
	public void ResetToBeginning()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(TypewriterEffect), Member = "ResetToBeginning")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(UIScrollView), Member = "UpdatePosition")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void Finish()
	{
	}

	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(NGUIText), Member = "EncodeAlpha")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(UIScrollView), Member = "UpdatePosition")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(TypewriterEffect), Member = "ResetToBeginning")]
	[CallsUnknownMethods(Count = 63)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UILabel), Member = "get_processedText")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIScrollView), Member = "UpdatePosition")]
	[Calls(Type = typeof(NGUIText), Member = "ParseSymbol")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 15)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public TypewriterEffect()
	{
	}
}
