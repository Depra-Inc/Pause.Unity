// SPDX-License-Identifier: Apache-2.0
// © 2023-2024 Nikolay Melnikov <n.melnikov@depra.org>

using System;
using UnityEngine;
using static Depra.Pause.Module;

namespace Depra.Pause
{
	[DisallowMultipleComponent]
	[AddComponentMenu(MENU_PATH + nameof(LegacyPauseInput), DEFAULT_ORDER)]
	public sealed class LegacyPauseInput : ScenePauseInput
	{
		[SerializeField] private string _buttonName = "Cancel";

		private bool _paused;
		private IPauseState _state;

		public override event Action PauseTriggered;
		public override event Action ResumeTriggered;

		public override void Initialize(IPauseState state) => _state = state;

		private void Update()
		{
			if (Input.GetButtonDown(_buttonName))
			{
				Toggle();
			}
		}

		private void Toggle()
		{
			if (_state.IsPaused)
			{
				ResumeTriggered?.Invoke();
			}
			else
			{
				PauseTriggered?.Invoke();
			}
		}
	}
}