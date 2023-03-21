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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LanguageSelection), Member = "Refresh")]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(LanguageSelection), Member = "Awake")]
	[Calls(Type = typeof(UIPopupList), Member = "set_value")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void Refresh()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public LanguageSelection()
	{
	}
}
