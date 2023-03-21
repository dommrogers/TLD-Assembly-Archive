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
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[CalledBy(Type = typeof(UIPlaySound), Member = "OnSelect")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(UIPlaySound), Member = "OnSelect")]
		[CalledBy(Type = typeof(UIPlaySound), Member = "OnClick")]
		[CalledBy(Type = typeof(UIPlaySound), Member = "OnPress")]
		[CalledBy(Type = typeof(UIPlaySound), Member = "OnHover")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 5)]
		get
		{
			return default(bool);
		}
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIPlaySound), Member = "get_canPlay")]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnHover(bool isOver)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIPlaySound), Member = "get_canPlay")]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	private void OnPress(bool isPressed)
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[Calls(Type = typeof(UIPlaySound), Member = "get_canPlay")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnClick()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIPlaySound), Member = "get_canPlay")]
	[Calls(Type = typeof(UIPlaySound), Member = "get_canPlay")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	private void OnSelect(bool isSelected)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "PlaySound")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Play()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public UIPlaySound()
	{
	}
}
