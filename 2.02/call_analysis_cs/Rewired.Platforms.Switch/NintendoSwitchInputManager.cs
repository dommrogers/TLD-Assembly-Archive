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
			[CallerCount(Count = 7)]
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
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
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

		public bool adjustIMUsForGripStyle
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
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

		public int handheldActivationMode
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
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
			[CallerCount(Count = 2)]
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
			[CallerCount(Count = 0)]
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

		private NpadSettings_Internal npadNo1
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 12)]
			get
			{
				return null;
			}
		}

		private NpadSettings_Internal npadNo2
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 15)]
			get
			{
				return null;
			}
		}

		private NpadSettings_Internal npadNo3
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 8)]
			get
			{
				return null;
			}
		}

		private NpadSettings_Internal npadNo4
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return null;
			}
		}

		private NpadSettings_Internal npadNo5
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 3)]
			get
			{
				return null;
			}
		}

		private NpadSettings_Internal npadNo6
		{
			[CallerCount(Count = 5)]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
		}

		private NpadSettings_Internal npadNo7
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 10)]
			get
			{
				return null;
			}
		}

		private NpadSettings_Internal npadNo8
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 20)]
			get
			{
				return null;
			}
		}

		private NpadSettings_Internal npadHandheld
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 4)]
			get
			{
				return null;
			}
		}

		public DebugPadSettings_Internal debugPad
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 8)]
			get
			{
				return null;
			}
		}

		private Dictionary<int, object[]> delegates
		{
			[CalledBy(Type = typeof(UserData), Member = "Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TrySetValue")]
			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 17)]
			[CalledBy(Type = typeof(UserData), Member = "Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TryGetValue")]
			[CallsUnknownMethods(Count = 270)]
			get
			{
				return null;
			}
		}

		[CallsUnknownMethods(Count = 7)]
		[Calls(Type = typeof(UserData), Member = "get_delegates")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		private bool Rewired_002EUtils_002EInterfaces_002EIKeyedData_003CSystem_002EInt32_003E_002ETryGetValue<T>(int key, out T value)
		{
			System.Runtime.CompilerServices.Unsafe.As<T, @null>(ref value) = null;
			return default(bool);
		}

		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(UserData), Member = "get_delegates")]
		private bool Rewired_002EUtils_002EInterfaces_002EIKeyedData_003CSystem_002EInt32_003E_002ETrySetValue<T>(int key, T value)
		{
			return default(bool);
		}

		[CalledBy(Type = typeof(NintendoSwitchInputManager), Member = ".ctor")]
		[CallsUnknownMethods(Count = 70)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
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
			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
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
			[CallerCount(Count = 8)]
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
			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 5)]
			[CalledBy(Type = typeof(NpadSettings_Internal), Member = "Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TryGetValue")]
			[CalledBy(Type = typeof(NpadSettings_Internal), Member = "Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TrySetValue")]
			[CallsUnknownMethods(Count = 77)]
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
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(NpadSettings_Internal), Member = "get_delegates")]
		[CallsUnknownMethods(Count = 7)]
		private bool Rewired_002EUtils_002EInterfaces_002EIKeyedData_003CSystem_002EInt32_003E_002ETryGetValue<T>(int key, out T value)
		{
			System.Runtime.CompilerServices.Unsafe.As<T, @null>(ref value) = null;
			return default(bool);
		}

		[CallsUnknownMethods(Count = 7)]
		[Calls(Type = typeof(NpadSettings_Internal), Member = "get_delegates")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsDeduplicatedMethods(Count = 3)]
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
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			set
			{
			}
		}

		private Dictionary<int, object[]> delegates
		{
			[CallerCount(Count = 2)]
			[CallsDeduplicatedMethods(Count = 4)]
			[CalledBy(Type = typeof(DebugPadSettings_Internal), Member = "Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TryGetValue")]
			[CalledBy(Type = typeof(DebugPadSettings_Internal), Member = "Rewired.Utils.Interfaces.IKeyedData<System.Int32>.TrySetValue")]
			[CallsUnknownMethods(Count = 54)]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(DebugPadSettings_Internal), Member = "get_delegates")]
		[CallsUnknownMethods(Count = 7)]
		private bool Rewired_002EUtils_002EInterfaces_002EIKeyedData_003CSystem_002EInt32_003E_002ETryGetValue<T>(int key, out T value)
		{
			System.Runtime.CompilerServices.Unsafe.As<T, @null>(ref value) = null;
			return default(bool);
		}

		[CallsUnknownMethods(Count = 7)]
		[Calls(Type = typeof(DebugPadSettings_Internal), Member = "get_delegates")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsDeduplicatedMethods(Count = 3)]
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
	[CallerCount(Count = 2)]
	private void Rewired_002EUtils_002EInterfaces_002EIExternalInputManager_002EDeinitialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UserData), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public NintendoSwitchInputManager()
	{
	}
}
