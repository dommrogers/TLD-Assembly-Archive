using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class vp_Timer : MonoBehaviour
{
	public delegate void Callback();

	public delegate void ArgCallback(object args);

	private static GameObject m_GameObject;

	private Callback m_Function;

	private ArgCallback m_ArgFunction;

	private object m_Arguments;

	private List<vp_Timer> m_Iterations;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	public static vp_Timer In(float time, Callback function, int iterations = 1, float interval = 0f)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	public static vp_Timer In(float time, ArgCallback function, object args, int iterations = 1, float interval = 0f)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "ReenableWeaponStatesIn")]
	[CalledBy(Type = typeof(vp_Timer), Member = "In")]
	[CalledBy(Type = typeof(vp_Timer), Member = "In")]
	[CalledBy(Type = typeof(Fatigue), Member = "EndSuppressHeavyBreathingCallback")]
	[CalledBy(Type = typeof(SafeCracking), Member = "UnlockCurrentTumbler")]
	[CalledBy(Type = typeof(SafeCracking), Member = "UnlockCurrentTumbler")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "DeactivateWhenSilent")]
	[CalledBy(Type = typeof(vp_DamageHandler), Member = "Respawn")]
	[CalledBy(Type = typeof(vp_DamageHandler), Member = "Die")]
	[CalledBy(Type = typeof(vp_DamageHandler), Member = "Damage")]
	[Calls(Type = typeof(vp_Timer), Member = "Schedule")]
	[Calls(Type = typeof(vp_Timer), Member = "Schedule")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 10)]
	private static vp_Timer In(float time, Callback func, ArgCallback argFunc, object args, int iterations, float interval)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void Cancel(vp_Timer timer)
	{
	}

	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Reload")]
	[CallerCount(Count = 6)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(vp_Timer), Member = "CancelInvoke")]
	[CalledBy(Type = typeof(SafeCracking), Member = "ResetTumblers")]
	[CalledBy(Type = typeof(SafeCracking), Member = "ResetTumblers")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "ReenableWeaponStatesIn")]
	[CalledBy(Type = typeof(vp_Timer), Member = "CancelInvoke")]
	public void Cancel()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(vp_Timer), Member = "Cancel")]
	public new void CancelInvoke(string methodName)
	{
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(vp_Timer), Member = "Cancel")]
	[CallerCount(Count = 0)]
	public new void CancelInvoke()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void CancelInstance()
	{
	}

	[CalledBy(Type = typeof(vp_Timer), Member = "In")]
	[Calls(Type = typeof(MonoBehaviour), Member = "InvokeDelayed")]
	[CallerCount(Count = 1)]
	private void Schedule(float time, Callback function)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(vp_Timer), Member = "In")]
	[Calls(Type = typeof(MonoBehaviour), Member = "InvokeDelayed")]
	private void Schedule(float time, ArgCallback function, object args)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Execute()
	{
	}

	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void ArgExecute()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public vp_Timer()
	{
	}
}
