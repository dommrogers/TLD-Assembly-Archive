using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using Rewired.Integration.UnityUI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.Demos;

public sealed class PlayerPointerEventHandlerExample : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerUpHandler, IScrollHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler
{
	public Text text;

	private const int logLength = 10;

	private List<string> log;

	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnPointerUp")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnDrag")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnBeginDrag")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnScroll")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnPointerClick")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnPointerDown")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnPointerExit")]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnPointerEnter")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(PlayerPointerEventHandlerExample), Member = "OnEndDrag")]
	[CallsUnknownMethods(Count = 3)]
	private void Log(string o)
	{
	}

	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(StringBuilder), Member = "Append")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[CallsUnknownMethods(Count = 28)]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 37)]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 0)]
	public void OnScroll(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[CallsUnknownMethods(Count = 37)]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PlayerPointerEventHandlerExample), Member = "Log")]
	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 1)]
	private static string GetSourceName(PlayerPointerEventData playerEventData)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public PlayerPointerEventHandlerExample()
	{
	}
}
