using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ExampleCommands : MonoBehaviour
{
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "RegisterCommand")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[Calls(Type = typeof(uConsole), Member = "UnRegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "UnRegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "UnRegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "UnRegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "UnRegisterCommand")]
	[Calls(Type = typeof(uConsole), Member = "UnRegisterCommand")]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[CallsUnknownMethods(Count = 1)]
	public void EchoNothing()
	{
	}

	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[Calls(Type = typeof(uConsole), Member = "GetInt")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public void EchoInteger()
	{
	}

	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetFloat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public void EchoFloat()
	{
	}

	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetBool")]
	public void EchoBool()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	public void EchoString()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[Calls(Type = typeof(uConsoleLog), Member = "Add")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public void EchoStrings()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uConsole), Member = "GetString")]
	[Calls(Type = typeof(SceneManager), Member = "LoadScene")]
	public static void LoadScene()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ExampleCommands()
	{
	}
}
