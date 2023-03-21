using System.Text;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UITextList : MonoBehaviour
{
	public enum Style
	{
		Text,
		Chat
	}

	protected class Paragraph
	{
		public string text;

		public string[] lines;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public Paragraph()
		{
		}
	}

	public UILabel textLabel;

	public UIProgressBar scrollBar;

	public Style style;

	public int paragraphHistory;

	protected char[] mSeparator;

	protected BetterList<Paragraph> mParagraphs;

	protected float mScroll;

	protected int mTotalLines;

	protected int mLastWidth;

	protected int mLastHeight;

	public bool isValid
	{
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(UITextList), Member = "get_scrollHeight")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UITextList), Member = "set_scrollValue")]
		[CalledBy(Type = typeof(UITextList), Member = "Update")]
		[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
		[CalledBy(Type = typeof(UITextList), Member = "UpdateVisibleText")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UILabel), Member = "get_ambigiousFont")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		get
		{
			return default(bool);
		}
	}

	public float scrollValue
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
		[Calls(Type = typeof(UITextList), Member = "get_isValid")]
		[Calls(Type = typeof(UITextList), Member = "UpdateVisibleText")]
		[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
		[CalledBy(Type = typeof(UITextList), Member = "OnScroll")]
		[CalledBy(Type = typeof(UITextList), Member = "OnDrag")]
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(UITextList), Member = "Start")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[CallerCount(Count = 3)]
		set
		{
		}
	}

	protected float lineHeight
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(UITextList), Member = "UpdateVisibleText")]
		[CalledBy(Type = typeof(UITextList), Member = "OnDrag")]
		[CalledBy(Type = typeof(UITextList), Member = "OnScroll")]
		[CalledBy(Type = typeof(UITextList), Member = "get_scrollHeight")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(UILabel), Member = "get_fontSize")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		get
		{
			return default(float);
		}
	}

	protected int scrollHeight
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
		[CalledBy(Type = typeof(UITextList), Member = "OnScroll")]
		[CalledBy(Type = typeof(UITextList), Member = "OnDrag")]
		[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UITextList), Member = "get_isValid")]
		[Calls(Type = typeof(UITextList), Member = "get_lineHeight")]
		get
		{
			return default(int);
		}
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UITextList), Member = "UpdateVisibleText")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Clear()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UITextList), Member = "set_scrollValue")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	private void Start()
	{
	}

	[Calls(Type = typeof(UITextList), Member = "Rebuild")]
	[Calls(Type = typeof(UITextList), Member = "get_isValid")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[Calls(Type = typeof(UITextList), Member = "get_scrollHeight")]
	[Calls(Type = typeof(UITextList), Member = "set_scrollValue")]
	[Calls(Type = typeof(UITextList), Member = "get_lineHeight")]
	[CallerCount(Count = 0)]
	public void OnScroll(float val)
	{
	}

	[Calls(Type = typeof(UITextList), Member = "set_scrollValue")]
	[Calls(Type = typeof(UITextList), Member = "get_lineHeight")]
	[Calls(Type = typeof(UITextList), Member = "get_scrollHeight")]
	[CallerCount(Count = 0)]
	public void OnDrag(Vector2 delta)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UITextList), Member = "UpdateVisibleText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	private void OnScrollBar()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void Add(string text)
	{
	}

	[CalledBy(Type = typeof(ChatInput), Member = "OnSubmit")]
	[CalledBy(Type = typeof(ChatInput), Member = "Start")]
	[CallerCount(Count = 2)]
	[CallAnalysisFailed]
	protected void Add(string text, bool updateVisible)
	{
	}

	[Calls(Type = typeof(UIScrollBar), Member = "set_barSize")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UITextList), Member = "get_scrollHeight")]
	[Calls(Type = typeof(UITextList), Member = "UpdateVisibleText")]
	[CalledBy(Type = typeof(UITextList), Member = "Update")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(UITextList), Member = "get_isValid")]
	[Calls(Type = typeof(NGUIText), Member = "WrapText")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void Rebuild()
	{
	}

	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
	[CalledBy(Type = typeof(UITextList), Member = "Clear")]
	[CalledBy(Type = typeof(UITextList), Member = "set_scrollValue")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(UITextList), Member = "get_lineHeight")]
	[CalledBy(Type = typeof(UITextList), Member = "OnScrollBar")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UITextList), Member = "get_isValid")]
	protected void UpdateVisibleText()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public UITextList()
	{
	}
}
