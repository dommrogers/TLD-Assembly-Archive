using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LanguageSelection : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static EventDelegate.Callback _003C_003E9__2_0;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Localization), Member = "set_Language")]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CStart_003Eb__2_0()
		{
		}
	}

	private UIPopupList mList;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LanguageSelection), Member = "Refresh")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[Calls(Type = typeof(UIPopupList), Member = "set_value")]
	[CalledBy(Type = typeof(LanguageSelection), Member = "Awake")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public void Refresh()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LanguageSelection()
	{
	}
}
