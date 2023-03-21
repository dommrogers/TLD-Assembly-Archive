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
		[CallerCount(Count = 6)]
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
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(UITextList), Member = "get_scrollHeight")]
		[CalledBy(Type = typeof(UITextList), Member = "set_scrollValue")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UILabel), Member = "get_ambigiousFont")]
		[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UITextList), Member = "Update")]
		[CalledBy(Type = typeof(UITextList), Member = "UpdateVisibleText")]
		[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
		get
		{
			return default(bool);
		}
	}

	public float scrollValue
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UITextList), Member = "get_isValid")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UITextList), Member = "OnScroll")]
		[CalledBy(Type = typeof(UITextList), Member = "OnDrag")]
		[Calls(Type = typeof(UITextList), Member = "UpdateVisibleText")]
		[CalledBy(Type = typeof(UITextList), Member = "Start")]
		[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
		set
		{
		}
	}

	protected float lineHeight
	{
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UILabel), Member = "get_fontSize")]
		[CalledBy(Type = typeof(UITextList), Member = "get_scrollHeight")]
		[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
		[CalledBy(Type = typeof(UITextList), Member = "UpdateVisibleText")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UITextList), Member = "OnScroll")]
		[CalledBy(Type = typeof(UITextList), Member = "OnDrag")]
		get
		{
			return default(float);
		}
	}

	protected int scrollHeight
	{
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UITextList), Member = "get_isValid")]
		[Calls(Type = typeof(UITextList), Member = "get_lineHeight")]
		[CalledBy(Type = typeof(UITextList), Member = "OnDrag")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(UITextList), Member = "OnScroll")]
		get
		{
			return default(int);
		}
	}

	[Calls(Type = typeof(UITextList), Member = "UpdateVisibleText")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Clear()
	{
	}

	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UITextList), Member = "set_scrollValue")]
	private void Start()
	{
	}

	[Calls(Type = typeof(UITextList), Member = "get_isValid")]
	[Calls(Type = typeof(UITextList), Member = "Rebuild")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextList), Member = "get_scrollHeight")]
	[Calls(Type = typeof(UITextList), Member = "set_scrollValue")]
	[Calls(Type = typeof(UITextList), Member = "get_lineHeight")]
	public void OnScroll(float val)
	{
	}

	[Calls(Type = typeof(UITextList), Member = "get_lineHeight")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextList), Member = "get_scrollHeight")]
	[Calls(Type = typeof(UITextList), Member = "set_scrollValue")]
	public void OnDrag(Vector2 delta)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UITextList), Member = "UpdateVisibleText")]
	[CallerCount(Count = 0)]
	private void OnScrollBar()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void Add(string text)
	{
	}

	[CalledBy(Type = typeof(ChatInput), Member = "Start")]
	[CallerCount(Count = 2)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(ChatInput), Member = "OnSubmit")]
	protected void Add(string text, bool updateVisible)
	{
	}

	[Calls(Type = typeof(UITextList), Member = "UpdateVisibleText")]
	[Calls(Type = typeof(NGUIText), Member = "WrapText")]
	[Calls(Type = typeof(UIScrollBar), Member = "set_barSize")]
	[Calls(Type = typeof(UITextList), Member = "get_lineHeight")]
	[Calls(Type = typeof(UITextList), Member = "get_isValid")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(UITextList), Member = "Update")]
	[Calls(Type = typeof(UITextList), Member = "get_isValid")]
	protected void Rebuild()
	{
	}

	[CalledBy(Type = typeof(UITextList), Member = "set_scrollValue")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(UITextList), Member = "get_lineHeight")]
	[Calls(Type = typeof(UITextList), Member = "get_isValid")]
	[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
	[CalledBy(Type = typeof(UITextList), Member = "Clear")]
	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(UITextList), Member = "OnScrollBar")]
	protected void UpdateVisibleText()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	public UITextList()
	{
	}
}
