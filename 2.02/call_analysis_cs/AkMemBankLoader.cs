using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CLoadFile_003Ed__14(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityWebRequest), Member = "Get")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest")]
		[Calls(Type = typeof(AkMemBankLoader), Member = "AllocateAlignedBuffer")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 6)]
		private bool MoveNext()
		{
			return false;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkBasePathGetter), Member = "GetPlatformBasePath")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetCurrentLanguage")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(AkMemBankLoader), Member = "DoLoadBank")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkBasePathGetter), Member = "GetPlatformBasePath")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(AkMemBankLoader), Member = "DoLoadBank")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void LoadNonLocalizedBank(string in_bankFilename)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkBasePathGetter), Member = "GetPlatformBasePath")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetCurrentLanguage")]
	[Calls(Type = typeof(Path), Member = "Combine")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(AkMemBankLoader), Member = "DoLoadBank")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void LoadLocalizedBank(string in_bankFilename)
	{
	}

	[CalledBy(Type = typeof(_003CLoadFile_003Ed__14), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GCHandle), Member = "AddrOfPinnedObject")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(GCHandle), Member = "Free")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private uint AllocateAlignedBuffer(byte[] data)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(AkMemBankLoader), Member = "DoLoadBank")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator LoadFile()
	{
		return null;
	}

	[CalledBy(Type = typeof(AkMemBankLoader), Member = "Start")]
	[CalledBy(Type = typeof(AkMemBankLoader), Member = "LoadNonLocalizedBank")]
	[CalledBy(Type = typeof(AkMemBankLoader), Member = "LoadLocalizedBank")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkMemBankLoader), Member = "LoadFile")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	private void DoLoadBank(string in_bankPath)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "UnloadBank")]
	[Calls(Type = typeof(GCHandle), Member = "Free")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public AkMemBankLoader()
	{
	}
}
