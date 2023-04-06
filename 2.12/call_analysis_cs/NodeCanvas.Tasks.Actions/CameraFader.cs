using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class CameraFader : MonoBehaviour
{
	private sealed class _003CCoroutineFadeIn_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CameraFader _003C_003E4__this;

		public float time;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CCoroutineFadeIn_003Ed__9(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003CCoroutineFadeOut_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CameraFader _003C_003E4__this;

		public float time;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CCoroutineFadeOut_003Ed__10(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private static CameraFader _current;

	private float alpha;

	private Texture2D _blackTexture;

	private Texture2D blackTexture
	{
		[CalledBy(Type = typeof(CameraFader), Member = "OnGUI")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Texture2D), Member = ".ctor")]
		[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
		[Calls(Type = typeof(Texture2D), Member = "Apply")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public static CameraFader current
	{
		[CalledBy(Type = typeof(FadeIn), Member = "OnExecute")]
		[CalledBy(Type = typeof(FadeOut), Member = "OnExecute")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectOfType")]
		[Calls(Type = typeof(GameObject), Member = ".ctor")]
		[Calls(Type = typeof(GameObject), Member = "AddComponent")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	public void FadeIn(float time)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	public void FadeOut(float time)
	{
	}

	[IteratorStateMachine(typeof(_003CCoroutineFadeIn_003Ed__9))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator CoroutineFadeIn(float time)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoroutineFadeOut_003Ed__10))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator CoroutineFadeOut(float time)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraFader), Member = "get_blackTexture")]
	[Calls(Type = typeof(GUI), Member = "DrawTexture")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void OnGUI()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CameraFader()
	{
	}
}
