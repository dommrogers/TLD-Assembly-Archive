using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LogListItem : MonoBehaviour
{
	public UILabel m_Label;

	public UISprite m_BG;

	public UISprite m_LeftLine;

	public UISprite m_RightLine;

	public UISprite m_NoteSprite;

	private bool m_IsDay;

	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	public void SetText(string itemText, bool isDay, bool hasNotes)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIRect), Member = "get_isAnchored")]
	[CallsUnknownMethods(Count = 2)]
	public void SetHasNotes(bool hasNotes)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public void SetSelected(bool selected)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LogListItem()
	{
	}
}
