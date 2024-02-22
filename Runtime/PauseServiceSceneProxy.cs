// SPDX-License-Identifier: Apache-2.0
// © 2023-2024 Nikolay Melnikov <n.melnikov@depra.org>

using System.Collections.Generic;
using UnityEngine;
using static Depra.Pause.Module;

namespace Depra.Pause.Utils
{
	[DisallowMultipleComponent]
	[AddComponentMenu(MENU_PATH + nameof(PauseServiceSceneProxy), DEFAULT_ORDER)]
	internal sealed class PauseServiceSceneProxy : MonoBehaviour, IPauseService
	{
		private IPauseService _service;

		private void Awake() => _service = new PauseService(
			new List<IPauseInput>(GetComponents<IPauseInput>()),
			new List<IPauseListener>(GetComponentsInChildren<IPauseListener>()));

		bool IPauseService.Paused => _service.Paused;

		void IPauseService.Add(IPauseInput input) => _service.Add(input);

		void IPauseService.Add(IPauseListener listener) => _service.Add(listener);

		void IPauseService.Remove(IPauseInput input) => _service.Remove(input);

		void IPauseService.Remove(IPauseListener listener) => _service.Remove(listener);
	}
}