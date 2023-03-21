using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DragDropContainer : MonoBehaviour
{
	public UISprite m_HoverSprite;

	public float m_HoverScale;

	public float m_HoverFadeTime;

	public EventDelegate m_Action;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	public void DroppedItem(DragDropItem droppedItem)
	{
	}

	[Calls(Type = typeof(DragDropContainer), Member = "SetSpriteScale")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void OnDragOver(GameObject draggedObject)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(DragDropContainer), Member = "SetSpriteScale")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void OnDragOut(GameObject draggedObject)
	{
	}

	[CalledBy(Type = typeof(DragDropContainer), Member = "OnDragOut")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CalledBy(Type = typeof(DragDropContainer), Member = "OnDragOver")]
	[CallsUnknownMethods(Count = 4)]
	protected void SetSpriteScale(float newScale)
	{
	}

	[CallerCount(Count = 0)]
	public DragDropContainer()
	{
	}
}
