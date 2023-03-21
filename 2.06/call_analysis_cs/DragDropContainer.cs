using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DragDropContainer : MonoBehaviour
{
	public UISprite m_HoverSprite;

	public float m_HoverScale;

	public float m_HoverFadeTime;

	public EventDelegate m_Action;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[CallsUnknownMethods(Count = 1)]
	public void DroppedItem(DragDropItem droppedItem)
	{
	}

	[Calls(Type = typeof(DragDropContainer), Member = "SetSpriteScale")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	protected void OnDragOver(GameObject draggedObject)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(DragDropContainer), Member = "SetSpriteScale")]
	[CallsUnknownMethods(Count = 1)]
	protected void OnDragOut(GameObject draggedObject)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(DragDropContainer), Member = "OnDragOut")]
	[CalledBy(Type = typeof(DragDropContainer), Member = "OnDragOver")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	protected void SetSpriteScale(float newScale)
	{
	}

	[CallerCount(Count = 0)]
	public DragDropContainer()
	{
	}
}
