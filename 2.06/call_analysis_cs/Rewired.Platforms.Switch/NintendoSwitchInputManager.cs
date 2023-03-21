using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Platforms.Switch;

public sealed class NintendoSwitchInputManager : MonoBehaviour, IExternalInputManager
{
	[Serializable]
	private class UserData : IKeyedData<int>
	{
		private int _allowedNpadStyles;

		private int _joyConGripStyle;

		private bool _adjustIMUsForGripStyle;

		private int _handheldActivationMode;

		private bool _assignJoysticksByNpadId;

		private bool _useVibrationThread;

		private NpadSettings_Internal _npadNo1;

		private NpadSettings_Internal _npadNo2;

		private NpadSettings_Internal _npadNo3;

		private NpadSettings_Internal _npadNo4;

		private NpadSettings_Internal _npadNo5;

		private NpadSettings_Internal _npadNo6;

		private NpadSettings_Internal _npadNo7;

		private NpadSettings_Internal _npadNo8;

		private NpadSettings_Internal _npadHandheld;

		private DebugPadSettings_Internal _debugPad;

		private Dictionary<int, object[]> __delegates;

		public int allowedNpadStyles
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 14)]
			get
			{
				return default(int);
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		public int joyConGripStyle
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			get
			{
				return default(int);
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		public bool adjustIMUsForGripStyle
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return default(bool);
			}
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			set
			{
			}
		}

		public int handheldActivationMode
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 1)]
			get
			{
				return default(int);
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		public bool assignJoysticksByNpadId
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 3)]
			get
			{
				return default(bool);
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		public bool useVibrationThread
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return default(bool);
			}
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			set
			{
			}
		}

		private NpadSettings_Internal npadNo1
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 58)]
			get
			{
				return null;
			}
		}

		private NpadSettings_Internal npadNo2
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 56)]
			get
			{
				return null;
			}
		}

		private NpadSettings_Internal npadNo3
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 18)]
			get
			{
				return null;
			}
		}

		private NpadSettings_Internal npadNo4
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			get
			{
				return null;
			}
		}

		private NpadSettings_Internal npadNo5
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 15)]
			get
			{
				return null;
			}
		}

		private NpadSettings_Internal npadNo6
		{
			[CallerCount(Count = 11)]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
		}

		private NpadSettings_Internal npadNo7
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 9)]
			get
			{
				return null;
			}
		}

		private NpadSettings_Internal npadNo8
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 31)]
			get
			{
				return null;
			}
		}

		private NpadSettings_Internal npadHandheld
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 8)]
			get
			{
				return null;
			}
		}

		public DebugPadSettings_Internal debugPad
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 10)]
			get
			{
				return null;
			}
		}

		private Dictionary<int, object[]> delegates
		{
			[CallsUnknownMethods(Count = 218)]
			[CalledBy(Type = typeof(UserData), Member = "Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TrySetValue")]
			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 27)]
			[CalledBy(Type = typeof(UserData), Member = "Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TryGetValue")]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UserData), Member = "get_delegates")]
		[CallsUnknownMethods(Count = 4)]
		private bool Rewired_002EUtils_002EInterfaces_002EIKeyedData_003CSystem_002EInt32_003E_002ETryGetValue<T>(int key, out T value)
		{
			System.Runtime.CompilerServices.Unsafe.As<T, @null>(ref value) = null;
			return default(bool);
		}

		[CallsUnknownMethods(Count = 4)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UserData), Member = "get_delegates")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private bool Rewired_002EUtils_002EInterfaces_002EIKeyedData_003CSystem_002EInt32_003E_002ETrySetValue<T>(int key, T value)
		{
			return default(bool);
		}

		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(NintendoSwitchInputManager), Member = ".ctor")]
		[CallsUnknownMethods(Count = 51)]
		public UserData()
		{
		}
	}

	[Serializable]
	private sealed class NpadSettings_Internal : IKeyedData<int>
	{
		private bool _isAllowed;

		private int _rewiredPlayerId;

		private int _joyConAssignmentMode;

		private Dictionary<int, object[]> __delegates;

		private bool isAllowed
		{
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			get
			{
				return default(bool);
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		private int rewiredPlayerId
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			get
			{
				return default(int);
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		private int joyConAssignmentMode
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 11)]
			get
			{
				return default(int);
			}
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			set
			{
			}
		}

		private Dictionary<int, object[]> delegates
		{
			[CallsUnknownMethods(Count = 66)]
			[CalledBy(Type = typeof(NpadSettings_Internal), Member = "Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TrySetValue")]
			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 4)]
			[CalledBy(Type = typeof(NpadSettings_Internal), Member = "Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TryGetValue")]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		internal NpadSettings_Internal(int playerId)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(NpadSettings_Internal), Member = "get_delegates")]
		[CallsUnknownMethods(Count = 4)]
		private bool Rewired_002EUtils_002EInterfaces_002EIKeyedData_003CSystem_002EInt32_003E_002ETryGetValue<T>(int key, out T value)
		{
			System.Runtime.CompilerServices.Unsafe.As<T, @null>(ref value) = null;
			return default(bool);
		}

		[Calls(Type = typeof(NpadSettings_Internal), Member = "get_delegates")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private bool Rewired_002EUtils_002EInterfaces_002EIKeyedData_003CSystem_002EInt32_003E_002ETrySetValue<T>(int key, T value)
		{
			return default(bool);
		}
	}

	[Serializable]
	private sealed class DebugPadSettings_Internal : IKeyedData<int>
	{
		private bool _enabled;

		private int _rewiredPlayerId;

		private Dictionary<int, object[]> __delegates;

		private int rewiredPlayerId
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			get
			{
				return default(int);
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		private bool enabled
		{
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			get
			{
				return default(bool);
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			set
			{
			}
		}

		private Dictionary<int, object[]> delegates
		{
			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 3)]
			[CalledBy(Type = typeof(DebugPadSettings_Internal), Member = "Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TryGetValue")]
			[CalledBy(Type = typeof(DebugPadSettings_Internal), Member = "Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TrySetValue")]
			[CallsUnknownMethods(Count = 46)]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal DebugPadSettings_Internal(int playerId)
		{
		}

		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(DebugPadSettings_Internal), Member = "get_delegates")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsDeduplicatedMethods(Count = 2)]
		private bool Rewired_002EUtils_002EInterfaces_002EIKeyedData_003CSystem_002EInt32_003E_002ETryGetValue<T>(int key, out T value)
		{
			System.Runtime.CompilerServices.Unsafe.As<T, @null>(ref value) = null;
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(DebugPadSettings_Internal), Member = "get_delegates")]
		[CallsUnknownMethods(Count = 4)]
		private bool Rewired_002EUtils_002EInterfaces_002EIKeyedData_003CSystem_002EInt32_003E_002ETrySetValue<T>(int key, T value)
		{
			return default(bool);
		}
	}

	private UserData _userData;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private object Rewired_002EUtils_002EInterfaces_002EIExternalInputManager_002EInitialize(Platform platform, object configVars)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Rewired_002EUtils_002EInterfaces_002EIExternalInputManager_002EDeinitialize()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserData), Member = ".ctor")]
	public NintendoSwitchInputManager()
	{
	}
}
