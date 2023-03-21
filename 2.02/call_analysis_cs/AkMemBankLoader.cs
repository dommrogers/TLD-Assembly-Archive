using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Networking;

public class AkMemBankLoader : MonoBehaviour
{
	private sealed class _003CLoadFile_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AkMemBankLoader _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(Count = 29)]
			[DeduplicatedMethod]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		public _003CLoadFile_003Ed__14(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(UnityWebRequest), Member = "Get")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest")]
		[Calls(Type = typeof(AkMemBankLoader), Member = "AllocateAlignedBuffer")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 6)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private const int WaitMs = 50;

	private const long AK_BANK_PLATFORM_DATA_ALIGNMENT = 16L;

	private const long AK_BANK_PLATFORM_DATA_ALIGNMENT_MASK = 15L;

	public string bankName;

	public bool isLocalizedBank;

	private string m_bankPath;

	public uint ms_bankID;

	private IntPtr ms_pInMemoryBankPtr;

	private GCHandle ms_pinnedArray;

	private UnityWebRequest ms_www;

	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(AkMemBankLoader), Member = "DoLoadBank")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkBasePathGetter), Member = "GetPlatformBasePath")]
	[Calls(Type = typeof(AkBasePathGetter), Member = "GetPlatformBasePath")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetCurrentLanguage")]
	private void Start()
	{
	}

	[Calls(Type = typeof(AkMemBankLoader), Member = "DoLoadBank")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkBasePathGetter), Member = "GetPlatformBasePath")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public void LoadNonLocalizedBank(string in_bankFilename)
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(AkMemBankLoader), Member = "DoLoadBank")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkBasePathGetter), Member = "GetPlatformBasePath")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetCurrentLanguage")]
	public void LoadLocalizedBank(string in_bankFilename)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(_003CLoadFile_003Ed__14), Member = "MoveNext")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(GCHandle), Member = "Free")]
	[Calls(Type = typeof(GCHandle), Member = "AddrOfPinnedObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GCHandle), Member = "AddrOfPinnedObject")]
	private uint AllocateAlignedBuffer(byte[] data)
	{
		return default(uint);
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(AkMemBankLoader), Member = "DoLoadBank")]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator LoadFile()
	{
		return null;
	}

	[CalledBy(Type = typeof(AkMemBankLoader), Member = "LoadLocalizedBank")]
	[CalledBy(Type = typeof(AkMemBankLoader), Member = "LoadNonLocalizedBank")]
	[CalledBy(Type = typeof(AkMemBankLoader), Member = "Start")]
	[Calls(Type = typeof(AkMemBankLoader), Member = "LoadFile")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	private void DoLoadBank(string in_bankPath)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "UnloadBank")]
	[Calls(Type = typeof(GCHandle), Member = "Free")]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public AkMemBankLoader()
	{
	}
}
