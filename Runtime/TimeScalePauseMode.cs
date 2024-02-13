// SPDX-License-Identifier: Apache-2.0
// © 2023-2024 Nikolay Melnikov <n.melnikov@depra.org>

using UnityEngine;

namespace Depra.Pause
{
	public sealed class TimeScalePauseMode : IPauseListener
	{
		[SerializeField] private float _defaultTimeScale;
		[SerializeField] private float _timeScaleDuringPause;

		public TimeScalePauseMode() : this(1, 0.001f) { }

		public TimeScalePauseMode(float defaultTimeScale, float timeScaleDuringPause)
		{
			_defaultTimeScale = defaultTimeScale;
			_timeScaleDuringPause = timeScaleDuringPause;
		}

		void IPauseListener.Pause() => Time.timeScale = _timeScaleDuringPause;

		void IPauseListener.Resume() => Time.timeScale = _defaultTimeScale;
	}
}