using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SprayPaintCan : MonoBehaviour
{
	private sealed class _003CReduceHealthForPaint_003Ed__18 : IEnumerator, IDisposable, IEnumerator<object>
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SprayPaintCan _003C_003E4__this;

		private float _003CstartingHealthBeforeReduction_003E5__2;

		private float _003CoverallAmountToReduce_003E5__3;

		private float _003CelapsedTime_003E5__4;

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
		[DeduplicatedMethod]
		[DebuggerHidden]
		public _003CReduceHealthForPaint_003Ed__18(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
		[Calls(Type = typeof(Mathf), Member = "Lerp")]
		[CallsUnknownMethods(Count = 10)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public DecalColour m_Colour;

	private static SprayPaintCanItemSaveDataProxy m_SprayPaintCanSaveDataProxy;

	private AnimationCurve m_HealthReductionCurve;

	private float m_AnimationLength;

	private float m_HealthRequiredToPaintDecal;

	private float m_FullCanLiquidWeightKG;

	private bool m_CancelHealthReduction;

	private GearItem m_GearItem;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	public void Deserialize(string text)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnWield(bool immediate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "CancelPlacementMode")]
	[CallsUnknownMethods(Count = 2)]
	public void UnwieldBegin()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	public void UnwieldEnd()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool HasEnoughPaintForSprayDecal()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SprayPaintCan), Member = "ReduceHealthForPaint")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	public void OnPlacedown()
	{
	}

	[CallerCount(Count = 0)]
	public void CancelPlacedown()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetLiquidWeightKG()
	{
		return default(float);
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SprayPaintCan), Member = "OnPlacedown")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToPlaceDecal")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AttemptToPlaceDecal")]
	[CallsUnknownMethods(Count = 7)]
	private IEnumerator ReduceHealthForPaint()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public SprayPaintCan()
	{
	}
}
