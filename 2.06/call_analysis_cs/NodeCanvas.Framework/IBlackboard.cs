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
		[CallerCount(Count = 101224)]
		get;
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		set;
	}

	Dictionary<string, Variable> variables
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		set;
	}

	GameObject propertiesBindTarget
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	event Action<Variable> onVariableAdded;

	event Action<Variable> onVariableRemoved;

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	Variable AddVariable(string varName, Type type);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	Variable AddVariable(string varName, object value);

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	Variable RemoveVariable(string varName);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	Variable GetVariable(string varName, Type ofType = null);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	Variable GetVariableByID(string ID);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	Variable<T> GetVariable<T>(string varName);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	T GetValue<T>(string varName);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	Variable SetValue(string varName, object value);

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	string[] GetVariableNames();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	string[] GetVariableNames(Type ofType);
}
