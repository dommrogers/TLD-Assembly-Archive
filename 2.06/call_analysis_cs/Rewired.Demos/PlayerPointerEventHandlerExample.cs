using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using Rewired.Integration.UnityUI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.Demos;

public sealed class PlayerPointerEventHandlerExample : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerUpHandler, IPointerExitHandler, IEventSystemHandler, IDragHandler, IBeginDragHandler, IScrollHandler, IEndDragHandler, IPointerClickHandler
{
	public Text text;

	private const int logLength = 10;

	private List<string> log;

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnEndDrag")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnDrag")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnBeginDrag")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnScroll")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnPointerClick")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnPointerDown")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnPointerExit")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnPointerEnter")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnPointerUp")]
	private void Log(string o)
	{
	}

	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "GetSourceName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[CallsUnknownMethods(Count = 28)]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "GetSourceName")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "GetSourceName")]
	[CallerCount(Count = 0)]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[CallsUnknownMethods(Count = 37)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "GetSourceName")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "GetSourceName")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "GetSourceName")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	public void OnScroll(PointerEventData eventData)
	{
	}

	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "GetSourceName")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "GetSourceName")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[CallsUnknownMethods(Count = 37)]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "GetSourceName")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnEndDrag")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnBeginDrag")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnScroll")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnPointerClick")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnPointerDown")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnDrag")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnPointerExit")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnPointerEnter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnPointerUp")]
	private static string GetSourceName(PlayerPointerEventData playerEventData)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public PlayerPointerEventHandlerExample()
	{
	}
}
