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
		[CallerCount(Count = 5)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(UIPlaySound), Member = "OnPress")]
		[CalledBy(Type = typeof(UIPlaySound), Member = "OnClick")]
		[CalledBy(Type = typeof(UIPlaySound), Member = "OnSelect")]
		[CalledBy(Type = typeof(UIPlaySound), Member = "OnSelect")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(UIPlaySound), Member = "OnHover")]
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

	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[Calls(Type = typeof(UIPlaySound), Member = "get_canPlay")]
	private void OnHover(bool isOver)
	{
	}

	[Calls(Type = typeof(UIPlaySound), Member = "get_canPlay")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	private void OnPress(bool isPressed)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPlaySound), Member = "get_canPlay")]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	private void OnClick()
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPlaySound), Member = "get_canPlay")]
	[Calls(Type = typeof(UIPlaySound), Member = "get_canPlay")]
	[CallsUnknownMethods(Count = 1)]
	private void OnSelect(bool isSelected)
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[CallerCount(Count = 0)]
	public void Play()
	{
	}

	[CallerCount(Count = 0)]
	public UIPlaySound()
	{
	}
}
