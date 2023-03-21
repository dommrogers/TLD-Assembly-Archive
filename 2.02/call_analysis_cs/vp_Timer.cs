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
	[CallerCount(Count = 2)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(vp_DamageHandler), Member = "Die")]
	[CalledBy(Type = typeof(vp_DamageHandler), Member = "Respawn")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "DeactivateWhenSilent")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "ReenableWeaponStatesIn")]
	[CalledBy(Type = typeof(Fatigue), Member = "EndSuppressHeavyBreathingCallback")]
	[CalledBy(Type = typeof(SafeCracking), Member = "UnlockCurrentTumbler")]
	[CalledBy(Type = typeof(vp_DamageHandler), Member = "Damage")]
	[CalledBy(Type = typeof(SafeCracking), Member = "UnlockCurrentTumbler")]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	public static vp_Timer In(float time, Callback function, int iterations = 1, float interval = 0f)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	public static vp_Timer In(float time, ArgCallback function, object args, int iterations = 1, float interval = 0f)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(vp_Timer), Member = "In")]
	[CalledBy(Type = typeof(vp_Timer), Member = "In")]
	[Calls(Type = typeof(vp_Timer), Member = "Schedule")]
	[Calls(Type = typeof(vp_Timer), Member = "Schedule")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	private static vp_Timer In(float time, Callback func, ArgCallback argFunc, object args, int iterations, float interval)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void Cancel(vp_Timer timer)
	{
	}

	[CalledBy(Type = typeof(SafeCracking), Member = "ResetTumblers")]
	[CalledBy(Type = typeof(SafeCracking), Member = "ResetTumblers")]
	[CalledBy(Type = typeof(vp_Timer), Member = "CancelInvoke")]
	[CalledBy(Type = typeof(vp_Timer), Member = "CancelInvoke")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "ReenableWeaponStatesIn")]
	[CallerCount(Count = 6)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Reload")]
	public void Cancel()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Timer), Member = "Cancel")]
	public new void CancelInvoke(string methodName)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(vp_Timer), Member = "Cancel")]
	public new void CancelInvoke()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void CancelInstance()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MonoBehaviour), Member = "InvokeDelayed")]
	[CalledBy(Type = typeof(vp_Timer), Member = "In")]
	private void Schedule(float time, Callback function)
	{
	}

	[Calls(Type = typeof(MonoBehaviour), Member = "InvokeDelayed")]
	[CalledBy(Type = typeof(vp_Timer), Member = "In")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void Schedule(float time, ArgCallback function, object args)
	{
	}

	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Execute()
	{
	}

	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void ArgExecute()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public vp_Timer()
	{
	}
}
