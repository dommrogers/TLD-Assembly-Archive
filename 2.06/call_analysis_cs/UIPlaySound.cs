using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIPlaySound : MonoBehaviour
{
	public enum Trigger
	{
		OnClick,
		OnMouseOver,
		OnMouseOut,
		OnPress,
		OnRelease,
		Custom,
		OnEnable,
		OnDisable
	}

	public AudioClip audioClip;

	public Trigger trigger;

	public float volume;

	public float pitch;

	private bool mIsOver;

	private bool canPlay
	{
		[CalledBy(Type = typeof(UIPlaySound), Member = "OnHover")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CalledBy(Type = typeof(UIPlaySound), Member = "OnClick")]
		[CalledBy(Type = typeof(UIPlaySound), Member = "OnSelect")]
		[CalledBy(Type = typeof(UIPlaySound), Member = "OnSelect")]
		[CallsUnknownMethods(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(UIPlaySound), Member = "OnPress")]
		[CallerCount(Count = 5)]
		get
		{
			return default(bool);
		}
	}

	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPlaySound), Member = "get_canPlay")]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	private void OnHover(bool isOver)
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[Calls(Type = typeof(UIPlaySound), Member = "get_canPlay")]
	[CallerCount(Count = 0)]
	private void OnPress(bool isPressed)
	{
	}

	[Calls(Type = typeof(UIPlaySound), Member = "get_canPlay")]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[CallerCount(Count = 0)]
	private void OnClick()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPlaySound), Member = "get_canPlay")]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIPlaySound), Member = "get_canPlay")]
	private void OnSelect(bool isSelected)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	public void Play()
	{
	}

	[CallerCount(Count = 0)]
	public UIPlaySound()
	{
	}
}
