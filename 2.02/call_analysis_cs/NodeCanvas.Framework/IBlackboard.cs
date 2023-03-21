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
		[CallerCount(Count = 121780)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		set;
	}

	Dictionary<string, Variable> variables
	{
		[CallerCount(Count = 121780)]
		[DeduplicatedMethod]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		set;
	}

	GameObject propertiesBindTarget
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	event Action<Variable> onVariableAdded;

	event Action<Variable> onVariableRemoved;

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	Variable AddVariable(string varName, Type type);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	Variable AddVariable(string varName, object value);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	Variable RemoveVariable(string varName);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	Variable GetVariable(string varName, Type ofType = null);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	Variable GetVariableByID(string ID);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	Variable<T> GetVariable<T>(string varName);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	T GetValue<T>(string varName);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	Variable SetValue(string varName, object value);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	string[] GetVariableNames();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	string[] GetVariableNames(Type ofType);
}
