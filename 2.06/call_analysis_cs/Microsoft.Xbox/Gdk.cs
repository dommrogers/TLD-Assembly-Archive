using System;
using System.Collections.Generic;
using System.Linq;
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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal int _003CValidateGuid_003Eb__21_0(string str)
		{
			return 0;
		}

		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "IndexOf")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CValidateGuid_003Eb__21_1(char c)
		{
			return false;
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
		[CalledBy(Type = typeof(UnlockAchievementSampleLogic), Member = "UnlockAchievement")]
		[CalledBy(Type = typeof(GameSaveSampleLogic), Member = "Save")]
		[CalledBy(Type = typeof(GameSaveSampleLogic), Member = "Load")]
		[CalledBy(Type = typeof(Gdk), Member = "Succeeded")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(Gdk), Member = "_Initialize")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public event OnGameSaveLoadedHandler OnGameSaveLoaded
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
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
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(Gdk), Member = "OnValidate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(Enumerable), Member = "Select")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray")]
	[Calls(Type = typeof(Enumerable), Member = "All")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	private bool ValidateGuid(string guid)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Gdk), Member = "ValidateGuid")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 1)]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gdk), Member = "_Initialize")]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(Gdk), Member = "get_Helpers")]
	[CalledBy(Type = typeof(Gdk), Member = "Start")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 8)]
	private void _Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void UnlockAchievement(string achievementId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Gdk), Member = "get_Helpers")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	protected static bool Succeeded(int hresult, string operationFriendlyName)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public Gdk()
	{
	}
}
