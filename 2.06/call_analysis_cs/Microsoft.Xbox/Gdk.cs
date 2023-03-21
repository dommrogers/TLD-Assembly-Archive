using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.UI;

namespace Microsoft.Xbox;

public class Gdk : MonoBehaviour
{
	public delegate void OnGameSaveLoadedHandler(object sender, GameSaveLoadedArgs e);

	public delegate void OnErrorHandler(object sender, ErrorEventArgs e);

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<string, int> _003C_003E9__21_0;

		public static Func<char, bool> _003C_003E9__21_1;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CValidateGuid_003Eb__21_0(string str)
		{
			return default(int);
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "IndexOf")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CValidateGuid_003Eb__21_1(char c)
		{
			return default(bool);
		}
	}

	public string scid;

	public bool signInOnStart;

	public Text gamertagLabel;

	private static Gdk _xboxHelpers;

	private static bool _initialized;

	private static Dictionary<int, string> _hresultToFriendlyErrorLookup;

	private string _lastScid;

	private const int _100PercentAchievementProgress = 100;

	private const string _GameSaveContainerName = "x_game_save_default_container";

	private const string _GameSaveBlobName = "x_game_save_default_blob";

	private const int _MaxAssociatedProductsToRetrieve = 25;

	public static Gdk Helpers
	{
		[CalledBy(Type = typeof(GameSaveSampleLogic), Member = "Load")]
		[CalledBy(Type = typeof(Gdk), Member = "Succeeded")]
		[CalledBy(Type = typeof(Gdk), Member = "Succeeded")]
		[CalledBy(Type = typeof(Gdk), Member = "Succeeded")]
		[CalledBy(Type = typeof(GameSaveSampleLogic), Member = "Load")]
		[CalledBy(Type = typeof(GameSaveSampleLogic), Member = "Load")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(UnlockAchievementSampleLogic), Member = "UnlockAchievement")]
		[Calls(Type = typeof(Gdk), Member = "_Initialize")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 8)]
		[CalledBy(Type = typeof(GameSaveSampleLogic), Member = "Save")]
		get
		{
			return null;
		}
	}

	public event OnGameSaveLoadedHandler OnGameSaveLoaded
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public event OnErrorHandler OnError
	{
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	[CalledBy(Type = typeof(Gdk), Member = "OnValidate")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[CallsUnknownMethods(Count = 13)]
	private bool ValidateGuid(string guid)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gdk), Member = "ValidateGuid")]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gdk), Member = "_Initialize")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(Gdk), Member = "get_Helpers")]
	[CalledBy(Type = typeof(Gdk), Member = "Start")]
	private void _Initialize()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void InitializeHresultToFriendlyErrorLookup()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void SignIn()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Save(byte[] data)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void LoadSaveData()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void UnlockAchievement(string achievementId)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void Update()
	{
	}

	[Calls(Type = typeof(Gdk), Member = "get_Helpers")]
	[Calls(Type = typeof(Gdk), Member = "get_Helpers")]
	[Calls(Type = typeof(Gdk), Member = "get_Helpers")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	protected static bool Succeeded(int hresult, string operationFriendlyName)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public Gdk()
	{
	}
}
