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
	private sealed class _003CCoroutineFadeIn_003Ed__9 : IEnumerator, IDisposable, IEnumerator<object>
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CameraFader _003C_003E4__this;

		public float time;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DeduplicatedMethod]
			[DebuggerHidden]
			[CallerCount(Count = 29)]
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

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CCoroutineFadeIn_003Ed__9(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003CCoroutineFadeOut_003Ed__10 : IEnumerator, IDisposable, IEnumerator<object>
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CameraFader _003C_003E4__this;

		public float time;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
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
		public _003CCoroutineFadeOut_003Ed__10(int _003C_003E1__state)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
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

	private static CameraFader _current;

	private float alpha;

	private Texture2D _blackTexture;

	private Texture2D blackTexture
	{
		[Calls(Type = typeof(Texture2D), Member = "Apply")]
		[CallsUnknownMethods(Count = 9)]
		[CalledBy(Type = typeof(CameraFader), Member = "OnGUI")]
		[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Texture2D), Member = ".ctor")]
		get
		{
			return null;
		}
	}

	public static CameraFader current
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(GameObject), Member = ".ctor")]
		[CalledBy(Type = typeof(FadeIn), Member = "OnExecute")]
		[CalledBy(Type = typeof(FadeOut), Member = "OnExecute")]
		[CallsUnknownMethods(Count = 8)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(CameraFader), Member = "CoroutineFadeIn")]
	[CallerCount(Count = 0)]
	public void FadeIn(float time)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraFader), Member = "CoroutineFadeOut")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	public void FadeOut(float time)
	{
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(CameraFader), Member = "FadeIn")]
	[CalledBy(Type = typeof(FadeIn), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator CoroutineFadeIn(float time)
	{
		return null;
	}

	[CalledBy(Type = typeof(FadeOut), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(CameraFader), Member = "FadeOut")]
	[CallerCount(Count = 2)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 1)]
	private IEnumerator CoroutineFadeOut(float time)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GUI), Member = "set_color")]
	[Calls(Type = typeof(CameraFader), Member = "get_blackTexture")]
	[Calls(Type = typeof(GUI), Member = "DrawTexture")]
	[Calls(Type = typeof(GUI), Member = "set_color")]
	[CallsUnknownMethods(Count = 2)]
	private void OnGUI()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CameraFader()
	{
	}
}
