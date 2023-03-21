using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace NodeCanvas.Framework;

public interface IBlackboard
{
	string name
	{
		[CallerCount(Count = 101262)]
		[DeduplicatedMethod]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		set;
	}

	Dictionary<string, Variable> variables
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		set;
	}

	GameObject propertiesBindTarget
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101262)]
		get;
	}

	event Action<Variable> onVariableAdded;

	event Action<Variable> onVariableRemoved;

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	Variable AddVariable(string varName, Type type);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	Variable AddVariable(string varName, object value);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	Variable RemoveVariable(string varName);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	Variable GetVariable(string varName, Type ofType = null);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	Variable GetVariableByID(string ID);

	[CallerCount(Count = 101262)]
	[DeduplicatedMethod]
	Variable<T> GetVariable<T>(string varName);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	T GetValue<T>(string varName);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	Variable SetValue(string varName, object value);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	string[] GetVariableNames();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	string[] GetVariableNames(Type ofType);
}
