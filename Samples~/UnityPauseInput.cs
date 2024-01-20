// SPDX-License-Identifier: Apache-2.0
// © 2023-2024 Nikolay Melnikov <n.melnikov@depra.org>

using System;
using System.Collections.Generic;
using Depra.Pause.Input;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Depra.Pause.Services
{
	[DisallowMultipleComponent]
	public sealed class UnityPauseInput : MonoBehaviour, IPauseInput
	{
		private Controls _controls;
		private IPauseService _pause;

		public event Action Pause;
		public event Action Resume;

		private void Awake()
		{
			_controls = new Controls();
			var listeners = new List<IPauseListener> { new DebugPauseListener() };
			listeners.AddRange(GetComponents<IPauseListener>());
			_pause = new PauseService(this, listeners);
		}

		private void OnDestroy() => _controls.Dispose();

		private void OnEnable()
		{
			_controls.Pause.Enable();
			_controls.Pause.Back.performed += OnBackButtonPressed;
		}

		private void OnDisable()
		{
			_controls.Pause.Disable();
			_controls.Pause.Back.performed -= OnBackButtonPressed;
		}

		private void OnBackButtonPressed(InputAction.CallbackContext context)
		{
			if (_pause.IsPaused)
			{
				Resume?.Invoke();
			}
			else
			{
				Pause?.Invoke();
			}
		}
	}
}