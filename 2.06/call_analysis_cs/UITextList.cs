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
		[CalledBy(Type = typeof(UITextList), Member = "set_scrollValue")]
		[CalledBy(Type = typeof(UITextList), Member = "get_scrollHeight")]
		[CalledBy(Type = typeof(UITextList), Member = "Update")]
		[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
		[CalledBy(Type = typeof(UITextList), Member = "UpdateVisibleText")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UILabel), Member = "get_ambigiousFont")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public float scrollValue
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CalledBy(Type = typeof(UITextList), Member = "Start")]
		[CalledBy(Type = typeof(UITextList), Member = "OnScroll")]
		[CalledBy(Type = typeof(UITextList), Member = "OnDrag")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(UITextList), Member = "get_isValid")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UITextList), Member = "UpdateVisibleText")]
		[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	protected float lineHeight
	{
		[CalledBy(Type = typeof(UITextList), Member = "get_scrollHeight")]
		[CalledBy(Type = typeof(UITextList), Member = "OnScroll")]
		[CalledBy(Type = typeof(UITextList), Member = "OnDrag")]
		[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
		[CalledBy(Type = typeof(UITextList), Member = "UpdateVisibleText")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UILabel), Member = "get_fontSize")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
	}

	protected int scrollHeight
	{
		[CalledBy(Type = typeof(UITextList), Member = "OnScroll")]
		[CalledBy(Type = typeof(UITextList), Member = "OnDrag")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UITextList), Member = "get_isValid")]
		[Calls(Type = typeof(UITextList), Member = "get_lineHeight")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return 0;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextList), Member = "UpdateVisibleText")]
	[CallsUnknownMethods(Count = 1)]
	public void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(UITextList), Member = "set_scrollValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextList), Member = "get_isValid")]
	[Calls(Type = typeof(UITextList), Member = "Rebuild")]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextList), Member = "get_scrollHeight")]
	[Calls(Type = typeof(UITextList), Member = "get_lineHeight")]
	[Calls(Type = typeof(UITextList), Member = "set_scrollValue")]
	public void OnScroll(float val)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextList), Member = "get_scrollHeight")]
	[Calls(Type = typeof(UITextList), Member = "get_lineHeight")]
	[Calls(Type = typeof(UITextList), Member = "set_scrollValue")]
	public void OnDrag(Vector2 delta)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextList), Member = "UpdateVisibleText")]
	[CallsUnknownMethods(Count = 2)]
	private void OnScrollBar()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Add(string text)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(ChatInput), Member = "Start")]
	[CalledBy(Type = typeof(ChatInput), Member = "OnSubmit")]
	[CallerCount(Count = 2)]
	protected void Add(string text, bool updateVisible)
	{
	}

	[CalledBy(Type = typeof(UITextList), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UITextList), Member = "get_isValid")]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(NGUIText), Member = "WrapText")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UITextList), Member = "get_lineHeight")]
	[Calls(Type = typeof(UIScrollBar), Member = "set_barSize")]
	[Calls(Type = typeof(UITextList), Member = "UpdateVisibleText")]
	[CallsUnknownMethods(Count = 3)]
	protected void Rebuild()
	{
	}

	[CalledBy(Type = typeof(UITextList), Member = "set_scrollValue")]
	[CalledBy(Type = typeof(UITextList), Member = "Clear")]
	[CalledBy(Type = typeof(UITextList), Member = "OnScrollBar")]
	[CalledBy(Type = typeof(UITextList), Member = "Rebuild")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UITextList), Member = "get_isValid")]
	[Calls(Type = typeof(UITextList), Member = "get_lineHeight")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	protected void UpdateVisibleText()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	public UITextList()
	{
	}
}
