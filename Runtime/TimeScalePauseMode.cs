// SPDX-License-Identifier: Apache-2.0
// © 2023-2024 Nikolay Melnikov <n.melnikov@depra.org>

namespace Depra.Pause
{
	public sealed record TimeScalePauseMode : IPauseListener
	{
		private readonly float _defaultTimeScale;
		private readonly float _timeScaleDuringPause;

		public TimeScalePauseMode(float defaultTimeScale = 1f, float timeScaleDuringPause = 0.001f)
		{
			_defaultTimeScale = defaultTimeScale;
			_timeScaleDuringPause = timeScaleDuringPause;
		}

		void IPauseListener.Pause() => UnityEngine.Time.timeScale = _timeScaleDuringPause;

		void IPauseListener.Resume() => UnityEngine.Time.timeScale = _defaultTimeScale;
	}
}