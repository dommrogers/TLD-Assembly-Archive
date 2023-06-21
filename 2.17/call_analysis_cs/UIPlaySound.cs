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
		[CalledBy(Type = typeof(UIPlaySound), Member = "OnPress")]
		[CalledBy(Type = typeof(UIPlaySound), Member = "OnClick")]
		[CalledBy(Type = typeof(UIPlaySound), Member = "OnSelect")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Component), Member = "GetComponent")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPlaySound), Member = "get_canPlay")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPlaySound), Member = "get_canPlay")]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[CallsUnknownMethods(Count = 1)]
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
