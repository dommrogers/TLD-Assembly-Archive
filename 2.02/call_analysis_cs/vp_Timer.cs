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
	[CallerCount(Count = 7)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(vp_DamageHandler), Member = "Damage")]
	[CalledBy(Type = typeof(vp_DamageHandler), Member = "Die")]
	[CalledBy(Type = typeof(vp_DamageHandler), Member = "Respawn")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "DeactivateWhenSilent")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "ReenableWeaponStatesIn")]
	[CalledBy(Type = typeof(Fatigue), Member = "EndSuppressHeavyBreathingCallback")]
	[CalledBy(Type = typeof(SafeCracking), Member = "UnlockCurrentTumbler")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static vp_Timer In(float time, Callback function, int iterations = 1, float interval = 0f)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Timer), Member = "In")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static vp_Timer In(float time, ArgCallback function, object args, int iterations = 1, float interval = 0f)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_Timer), Member = "In")]
	[CalledBy(Type = typeof(vp_Timer), Member = "In")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(vp_Timer), Member = "Schedule")]
	[Calls(Type = typeof(vp_Timer), Member = "Schedule")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	private static vp_Timer In(float time, Callback func, ArgCallback argFunc, object args, int iterations, float interval)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void Cancel(vp_Timer timer)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "Reload")]
	[CalledBy(Type = typeof(vp_FPSPlayer), Member = "ReenableWeaponStatesIn")]
	[CalledBy(Type = typeof(vp_Timer), Member = "CancelInvoke")]
	[CalledBy(Type = typeof(vp_Timer), Member = "CancelInvoke")]
	[CalledBy(Type = typeof(SafeCracking), Member = "ResetTumblers")]
	[CallerCount(Count = 6)]
	public void Cancel()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Timer), Member = "Cancel")]
	public new void CancelInvoke(string methodName)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Timer), Member = "Cancel")]
	public new void CancelInvoke()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void CancelInstance()
	{
	}

	[CalledBy(Type = typeof(vp_Timer), Member = "In")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBehaviour), Member = "InvokeDelayed")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Schedule(float time, Callback function)
	{
	}

	[CalledBy(Type = typeof(vp_Timer), Member = "In")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBehaviour), Member = "InvokeDelayed")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Schedule(float time, ArgCallback function, object args)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Execute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void ArgExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public vp_Timer()
	{
	}
}
