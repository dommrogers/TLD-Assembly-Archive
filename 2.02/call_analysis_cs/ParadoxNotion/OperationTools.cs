using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using UnityEngine;

namespace ParadoxNotion;

public static class OperationTools
{
	[CalledBy(Type = typeof(SetInt), Member = "get_info")]
	[CalledBy(Type = typeof(SetVector3), Member = "get_info")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(SetFloat), Member = "get_info")]
	public static string GetOperationString(OperationMethod om)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static float Operate(float a, float b, OperationMethod om, float delta = 1f)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static int Operate(int a, int b, OperationMethod om)
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(SetVector3), Member = "OnExecute")]
	public static Vector3 Operate(Vector3 a, Vector3 b, OperationMethod om, float delta = 1f)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 21)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetCompareString(CompareMethod cm)
	{
		return null;
	}

	[CalledBy(Type = typeof(CheckProperty), Member = "OnCheck")]
	[CalledBy(Type = typeof(CheckFunction), Member = "OnCheck")]
	[CalledBy(Type = typeof(CheckProperty_Multiplatform), Member = "OnCheck")]
	[CalledBy(Type = typeof(CheckFunction_Multiplatform), Member = "OnCheck")]
	[CalledBy(Type = typeof(CheckField), Member = "OnCheck")]
	[CalledBy(Type = typeof(CheckDistanceToGameObject), Member = "OnCheck")]
	[CalledBy(Type = typeof(CheckVectorDistance), Member = "OnCheck")]
	[CalledBy(Type = typeof(CheckFloat), Member = "OnCheck")]
	[CalledBy(Type = typeof(Condition_PlayerHasItemsWithWeight), Member = "Test")]
	[CalledBy(Type = typeof(Condition_CheckN2HRealtimeHoursSurvived), Member = "OnCheck")]
	[CalledBy(Type = typeof(Condition_CheckStat), Member = "OnCheck")]
	[CalledBy(Type = typeof(CheckSpeed), Member = "OnCheck")]
	[CalledBy(Type = typeof(Condition_PlayerStats), Member = "OnCheck")]
	[CalledBy(Type = typeof(Condition_PlayerHealth), Member = "OnCheck")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(MecanimCheckFloat), Member = "OnCheck")]
	[CalledBy(Type = typeof(NodeCanvas.Tasks.Conditions.Condition_HoursWithinRangeOfFire), Member = "OnCheck")]
	public static bool Compare(float a, float b, CompareMethod cm, float floatingPoint)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Condition_CheckInventoryItemCondition), Member = "OnCheck")]
	[CallerCount(Count = 1)]
	public static bool Compare(int a, int b, CompareMethod cm)
	{
		return default(bool);
	}
}
