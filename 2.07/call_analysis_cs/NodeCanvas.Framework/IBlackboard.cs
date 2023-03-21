using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace NodeCanvas.Framework;

public interface IBlackboard
{
	string name
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		set;
	}

	Dictionary<string, Variable> variables
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 101261)]
		set;
	}

	GameObject propertiesBindTarget
	{
		[CallerCount(Count = 101261)]
		[DeduplicatedMethod]
		get;
	}

	event Action<Variable> onVariableAdded;

	event Action<Variable> onVariableRemoved;

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	Variable AddVariable(string varName, Type type);

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	Variable AddVariable(string varName, object value);

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	Variable RemoveVariable(string varName);

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	Variable GetVariable(string varName, Type ofType = null);

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	Variable GetVariableByID(string ID);

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	Variable<T> GetVariable<T>(string varName);

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	T GetValue<T>(string varName);

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	Variable SetValue(string varName, object value);

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	string[] GetVariableNames();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	string[] GetVariableNames(Type ofType);
}
